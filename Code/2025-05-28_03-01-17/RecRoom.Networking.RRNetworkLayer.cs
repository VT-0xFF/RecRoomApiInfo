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
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7ECDBA0", Offset = "0x7ECC9A0", VA = "0x187ECDBA0", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Networking_RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
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
			[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7CCE070", Offset = "0x7CCCE70", VA = "0x187CCE070", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7EE1CD0", Offset = "0x7EE0AD0", VA = "0x187EE1CD0")]
		private void OCIJCOAIOEO(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7EE1A50", Offset = "0x7EE0850", VA = "0x187EE1A50")]
		private void JOJOLCIOGCC(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7EE2330", Offset = "0x7EE1130", VA = "0x187EE2330", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7EE23E0", Offset = "0x7EE11E0", VA = "0x187EE23E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MLCIOGKGILF
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEBEPMGFCGH NNLLPHNMAFL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IEBEPMGFCGH OLOGGEGFJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7ECDE00", Offset = "0x7ECCC00", VA = "0x187ECDE00")]
		get
		{
			return default(IEBEPMGFCGH);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PCLODAAAOGP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	RRNetworkView KJBAOMDIAPO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	OPFNGPKNABD BEENCIEHNDB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool Serialize(GMLAOLGCPGH LGMEMFFHIDF);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void Deserialize(GNFMIDICEEO DOKMLDLFBEF, GMLAOLGCPGH LGMEMFFHIDF);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface JCHCEPACFPA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FEAGFLJNFGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JBFBIAGEBGO(GNFMIDICEEO DOKMLDLFBEF);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LGDBIGPAFJK(GNFMIDICEEO DOKMLDLFBEF, GMLAOLGCPGH LGMEMFFHIDF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface NNPNONPCNFN : INetworkUpdateSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KEMEJJLNDFN(PCLODAAAOGP DLCADAGKMBA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NGPIMBAFGHP(PCLODAAAOGP DLCADAGKMBA);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LADOGLBAAOK(MMBIICOFCGK.JPHKAIKPHEA FNHKEAPDGGH);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HOGPKLPKELN();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LFOOHFCDAEJ(object FELHJOMEEAD);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum OPFNGPKNABD : byte
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
public struct GNFMIDICEEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public int ONEIDEFNEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public uint CGEKPFMCNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public double FKCIMOHLBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public int GPCIBMHNFCF;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EMIDEJDFGCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Dictionary<(ViewId, OPFNGPKNABD), JCHCEPACFPA> IDFGKHOCENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly List<PCLODAAAOGP> IBMPIAGJEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly HashSet<(ViewId, OPFNGPKNABD)> OGHCKKMJMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int LMIIGNHHANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public bool LLOCMBEOOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private MMBIICOFCGK.JPHKAIKPHEA FNHKEAPDGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MemoryStream POAOJLAMBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly GMLAOLGCPGH IHMAFHCBPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly GMLAOLGCPGH LHHMPIBLFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private byte[] NLFCEKKNOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private float ONCBHGDIFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int DJBFNFDNJOE;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7EC14E0", Offset = "0x7EC02E0", VA = "0x187EC14E0")]
	public EMIDEJDFGCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1070", Offset = "0x7EBFE70", VA = "0x187EC1070")]
	public void LADOGLBAAOK(MMBIICOFCGK.JPHKAIKPHEA FNHKEAPDGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7EC08A0", Offset = "0x7EBF6A0", VA = "0x187EC08A0")]
	public void HOGPKLPKELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0C90", Offset = "0x7EBFA90", VA = "0x187EC0C90")]
	public void JPEBABACHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0030", Offset = "0x7EBEE30", VA = "0x187EC0030")]
	public bool AIKICPLLADB(PCLODAAAOGP DLCADAGKMBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0770", Offset = "0x7EBF570", VA = "0x187EC0770")]
	public bool FKCGDELNEED(PCLODAAAOGP DLCADAGKMBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0550", Offset = "0x7EBF350", VA = "0x187EC0550")]
	private JCHCEPACFPA BMFIGLAFPGP(ViewId EMPDJGGGCNA, OPFNGPKNABD DCDMGGJGLNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7EC14D0", Offset = "0x7EC02D0", VA = "0x187EC14D0")]
	public void NGMJLHNFDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7EC10B0", Offset = "0x7EBFEB0", VA = "0x187EC10B0")]
	private void LFJEECOHMGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1090", Offset = "0x7EBFE90", VA = "0x187EC1090")]
	private void LEOOKALMHDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7EC08F0", Offset = "0x7EBF6F0", VA = "0x187EC08F0")]
	public bool IANKLCKNPMB(FastBufferWriter KMFJBCLMGLE, int IOLLEJLGCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1110", Offset = "0x7EBFF10", VA = "0x187EC1110")]
	public void LGDBIGPAFJK(GNFMIDICEEO DOKMLDLFBEF, FastBufferReader JFLBMHOJFED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class IOCGAIENMOL : JCHCEPACFPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private PCLODAAAOGP AEGMCKAIIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private uint DELGKGEKEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int CBMDHPNANAL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool FEAGFLJNFGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public IOCGAIENMOL(PCLODAAAOGP AEGMCKAIIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7EC40E0", Offset = "0x7EC2EE0", VA = "0x187EC40E0", Slot = "5")]
	public bool JBFBIAGEBGO(GNFMIDICEEO DOKMLDLFBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7EC41D0", Offset = "0x7EC2FD0", VA = "0x187EC41D0", Slot = "6")]
	public void LGDBIGPAFJK(GNFMIDICEEO DOKMLDLFBEF, GMLAOLGCPGH LGMEMFFHIDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JJDNOGPLCOM : JCHCEPACFPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private MMBIICOFCGK.JPHKAIKPHEA FNHKEAPDGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly ViewId EMPDJGGGCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private int CBMDHPNANAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private uint DELGKGEKEOH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool FEAGFLJNFGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x19F9D40", Offset = "0x19F8B40", VA = "0x1819F9D40")]
	public JJDNOGPLCOM(ViewId EMPDJGGGCNA, MMBIICOFCGK.JPHKAIKPHEA FNHKEAPDGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7EC42B0", Offset = "0x7EC30B0", VA = "0x187EC42B0", Slot = "5")]
	public bool JBFBIAGEBGO(GNFMIDICEEO DOKMLDLFBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7EC42F0", Offset = "0x7EC30F0", VA = "0x187EC42F0", Slot = "6")]
	public void LGDBIGPAFJK(GNFMIDICEEO DOKMLDLFBEF, GMLAOLGCPGH LGMEMFFHIDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LEAIMBNHIFG
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7ECC290", Offset = "0x7ECB090", VA = "0x187ECC290")]
	public static void KIDMEGDOMCG(this KLOPPHJHMCG HEDEJOPCPGP, GMLAOLGCPGH DGBFPBHCCIM, ViewId JAPGNGDBBIF, bool DCOAOOPEIHN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7ECBD90", Offset = "0x7ECAB90", VA = "0x187ECBD90")]
	public static void EPNBOLDHBNC(this KLOPPHJHMCG HEDEJOPCPGP, GMLAOLGCPGH DGBFPBHCCIM, bool DCOAOOPEIHN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7ECC450", Offset = "0x7ECB250", VA = "0x187ECC450")]
	public static KLOPPHJHMCG LGDBIGPAFJK(GMLAOLGCPGH DGBFPBHCCIM, ViewId JAPGNGDBBIF, bool DCOAOOPEIHN = true)
	{
		return default(KLOPPHJHMCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB9D0", Offset = "0x7ECA7D0", VA = "0x187ECB9D0")]
	public static void EHBOFIJOPKH(this KLOPPHJHMCG HEDEJOPCPGP, GMLAOLGCPGH DGBFPBHCCIM, bool DCOAOOPEIHN = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(NNPNONPCNFN), new string[] { })]
public class LMONIHFNLHE : NNPNONPCNFN, INetworkUpdateSystem, BMBJAHBBAND, IMNKKHLGPLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IEBEPMGFCGH CNLPFNFLHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private EMIDEJDFGCE ANBMFCGEHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private uint AMAOGFJNKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private float FMHHGAHOOEC;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCF60", Offset = "0x7ECBD60", VA = "0x187ECCF60", Slot = "4")]
	public void KEMEJJLNDFN(PCLODAAAOGP DLCADAGKMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD270", Offset = "0x7ECC070", VA = "0x187ECD270", Slot = "5")]
	public void NGPIMBAFGHP(PCLODAAAOGP DLCADAGKMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD110", Offset = "0x7ECBF10", VA = "0x187ECD110", Slot = "10")]
	public void NELONKEPHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD470", Offset = "0x7ECC270", VA = "0x187ECD470", Slot = "9")]
	public void NetworkUpdate(NetworkUpdateStage NGJHOJNHJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD4F0", Offset = "0x7ECC2F0", VA = "0x187ECD4F0")]
	private void OGMOPJJHDBB(uint FEGNHAMMBGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD080", Offset = "0x7ECBE80", VA = "0x187ECD080", Slot = "6")]
	public void LADOGLBAAOK(MMBIICOFCGK.JPHKAIKPHEA FNHKEAPDGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCF00", Offset = "0x7ECBD00", VA = "0x187ECCF00", Slot = "7")]
	public void HOGPKLPKELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7ECD0B0", Offset = "0x7ECBEB0", VA = "0x187ECD0B0", Slot = "8")]
	public void LFOOHFCDAEJ(object KPAGBEKAECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCA60", Offset = "0x7ECB860", VA = "0x187ECCA60")]
	private void BKGKIMPMJEA(NEJHGGPCOKC KPAGBEKAECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7ECCDE0", Offset = "0x7ECBBE0", VA = "0x187ECCDE0", Slot = "11")]
	public void DAHEEJMILJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7ECDAC0", Offset = "0x7ECC8C0", VA = "0x187ECDAC0")]
	public LMONIHFNLHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LCMDGEFCHFE : JCHCEPACFPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private float PIKPLDPELGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int CBMDHPNANAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private uint DELGKGEKEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly OPFNGPKNABD BGJJIFBDDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public GNFMIDICEEO OHHMMIOGIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int LDELDBMBDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public byte[] NHBEDDKEAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private GNFMIDICEEO LDPCMBCFCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int HFCLLCLAJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private byte[] AEECHPMBJDM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool FEAGFLJNFGL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7ECB460", Offset = "0x7ECA260", VA = "0x187ECB460", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB960", Offset = "0x7ECA760", VA = "0x187ECB960")]
	public LCMDGEFCHFE(OPFNGPKNABD BGJJIFBDDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB490", Offset = "0x7ECA290", VA = "0x187ECB490", Slot = "5")]
	public bool JBFBIAGEBGO(GNFMIDICEEO DOKMLDLFBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB6A0", Offset = "0x7ECA4A0", VA = "0x187ECB6A0", Slot = "6")]
	public void LGDBIGPAFJK(GNFMIDICEEO DOKMLDLFBEF, GMLAOLGCPGH LGMEMFFHIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB850", Offset = "0x7ECA650", VA = "0x187ECB850")]
	internal IOCGAIENMOL LMPPGAOKADF(PCLODAAAOGP DLCADAGKMBA, GMLAOLGCPGH DGBFPBHCCIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB4D0", Offset = "0x7ECA2D0", VA = "0x187ECB4D0")]
	private static void JHNKNDFGKCJ(IOCGAIENMOL HIKHLHKADIN, GMLAOLGCPGH DGBFPBHCCIM, GNFMIDICEEO HEPHHPNAPMC, byte[] GLBDCBGACGO, int JCNIFNPPGLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[RegisterService(typeof(KAAFGCPJPBP), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class KAAFGCPJPBP : CLJPJNPNMPP, BMBJAHBBAND, IMNKKHLGPLB
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly Hashtable PNKNLIIEHKC;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly Hashtable OPBFNMCJDOH;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly Hashtable PNNLHNOFCLN;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly EEKDOOHAAOB MIHJDHKLNEE;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly EEKDOOHAAOB JHABJLOKNPP;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly EEKDOOHAAOB BMJBNODDNCM;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly EEKDOOHAAOB BIMNJFMOJDC;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly EEKDOOHAAOB EPBLMCMKGOL;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int GEDLONGNIDC;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4820", Offset = "0x7EC3620", VA = "0x187EC4820", Slot = "4")]
	public bool DGOBKFPNPCF(AEJMJLLLPAC CNCKIIIBBGO, bool DJNKFPJFAAB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4C60", Offset = "0x7EC3A60", VA = "0x187EC4C60", Slot = "5")]
	public int HCBMOBOIKBL(AEJMJLLLPAC[] NIEGGDAPLBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7EC46F0", Offset = "0x7EC34F0", VA = "0x187EC46F0", Slot = "6")]
	public bool CLJDOFGFCDI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7EC6180", Offset = "0x7EC4F80", VA = "0x187EC6180", Slot = "7")]
	public bool MOBDIMMFMMB(int EMPDJGGGCNA, int HPMJMOFABBN, bool NFFALLPBCIC, GameObject MMMAEDGEACA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7EC5020", Offset = "0x7EC3E20", VA = "0x187EC5020", Slot = "8")]
	public void HDBEAJBABFF(int HPMJMOFABBN, [Optional] int? MELMEPMJOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7EC6010", Offset = "0x7EC4E10", VA = "0x187EC6010", Slot = "9")]
	public bool MLGANLFOMHM(NEJHGGPCOKC FELHJOMEEAD, [Out] AEJMJLLLPAC ILNKPLKLGAC, bool MKJINPBEEBP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7EC5650", Offset = "0x7EC4450", VA = "0x187EC5650", Slot = "10")]
	public bool JPJAALHHBMP(NEJHGGPCOKC FELHJOMEEAD, [Out] int DCMKLAJPLBB, [Out] AEJMJLLLPAC[] NIEGGDAPLBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7EC5930", Offset = "0x7EC4730", VA = "0x187EC5930", Slot = "11")]
	public bool KOFMDLBDBFP(NEJHGGPCOKC FELHJOMEEAD, [Out] int HPMJMOFABBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4A80", Offset = "0x7EC3880", VA = "0x187EC4A80", Slot = "12")]
	public void GCDKKLBPJGP(NEJHGGPCOKC FELHJOMEEAD, [Out] int JLCNGKHMHPF, [Out] int[] AEKCOLFKJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7EC6490", Offset = "0x7EC5290", VA = "0x187EC6490", Slot = "13")]
	public void NNIPEFLKNHB(int DCMKLAJPLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4960", Offset = "0x7EC3760", VA = "0x187EC4960", Slot = "14")]
	public void FFNOOONHAKM(int DCMKLAJPLBB, int[] AEKCOLFKJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4640", Offset = "0x7EC3440", VA = "0x187EC4640", Slot = "15")]
	public void BPFKEIOFDJB(int[] AEKCOLFKJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7EC63C0", Offset = "0x7EC51C0", VA = "0x187EC63C0", Slot = "16")]
	public void NKDHHEOOHHO(int[] AEKCOLFKJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7EC44D0", Offset = "0x7EC32D0", VA = "0x187EC44D0", Slot = "17")]
	public void AFGNEKMDACL(int DCMKLAJPLBB, int HPMJMOFABBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7EC5210", Offset = "0x7EC4010", VA = "0x187EC5210")]
	private static void IIHBJJLDLPF(AEJMJLLLPAC CNCKIIIBBGO, Hashtable OAPMPJKHKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7EC5A50", Offset = "0x7EC4850", VA = "0x187EC5A50")]
	private static bool MLGANLFOMHM(Hashtable OAPMPJKHKNH, AHNIMKBJLEJ NIEDOFANOLB, [Out] AEJMJLLLPAC ILNKPLKLGAC, bool MKJINPBEEBP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7EC65F0", Offset = "0x7EC53F0", VA = "0x187EC65F0")]
	private static int PMGCNCNFDKD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7EC6320", Offset = "0x7EC5120", VA = "0x187EC6320", Slot = "18")]
	public void NELONKEPHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7EC4780", Offset = "0x7EC3580", VA = "0x187EC4780", Slot = "19")]
	public void DAHEEJMILJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public KAAFGCPJPBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(KFOADNEKDGD), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class KFOADNEKDGD : JFFIFGMEPHO, BMBJAHBBAND, IMNKKHLGPLB
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static Hashtable PIBCNGNPKCI;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static Hashtable ALPLEDALBAN;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static EEKDOOHAAOB EICKHHINBBC;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly EEKDOOHAAOB NCDOAIOCKJA;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB1B0", Offset = "0x7EC9FB0", VA = "0x187ECB1B0", Slot = "4")]
	public void OMMOBKGPBPC(ViewId EMPDJGGGCNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7ECADD0", Offset = "0x7EC9BD0", VA = "0x187ECADD0", Slot = "5")]
	public bool GKFCFLGPOJJ(NEJHGGPCOKC FELHJOMEEAD, [Out] ViewId EMPDJGGGCNA, [Out] string HGKLDIPJCMH, [Out] int GEKHAOKOBBH, [Out] object[] PECPDCLIACL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7ECA760", Offset = "0x7EC9560", VA = "0x187ECA760", Slot = "6")]
	public void AEKLBDOMNDN(ViewId IOEIHBPMNDC, string HGKLDIPJCMH, BGJPLAEOAHJ NIDFNACFIPF, AHNIMKBJLEJ ENPELEHFGFF, GFNNCIDMKDA CJLMBKIAAJN, object[] CNCKIIIBBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7ECAD30", Offset = "0x7EC9B30", VA = "0x187ECAD30", Slot = "8")]
	public void DAHEEJMILJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7ECB110", Offset = "0x7EC9F10", VA = "0x187ECB110", Slot = "7")]
	public void NELONKEPHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public KFOADNEKDGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class PDDGBNCHELD
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED6FB0", Offset = "0x7ED5DB0", VA = "0x187ED6FB0")]
	public static AHNIMKBJLEJ CANGMPHNCKO(this HMJDCIMFIOA LCALHIDHIGO)
	{
		return null;
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class RRNetworkBehavior : MonoBehaviour, NJDFEANOOND, CPKFDJDBFFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool networkedViewInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private RRNetworkView networkedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private List<HBEJCHCGOCJ> destroyHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool isForwarderRegistered;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ViewId CJANOIALIEB
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7EDA1E0", Offset = "0x7ED8FE0", VA = "0x187EDA1E0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId MCLJOGBKNAK
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7EDA1E0", Offset = "0x7ED8FE0", VA = "0x187EDA1E0", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView DNCCNJDOKKL
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7EDA260", Offset = "0x7ED9060", VA = "0x187EDA260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public RRNetworkView KJBAOMDIAPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7EDA260", Offset = "0x7ED9060", VA = "0x187EDA260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public AHNIMKBJLEJ BKPPJKFJHPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7EDA360", Offset = "0x7ED9160", VA = "0x187EDA360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AHNIMKBJLEJ EALBMDJEHIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7EDA6C0", Offset = "0x7ED94C0", VA = "0x187EDA6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool DHMMNOOJEJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7EDA4C0", Offset = "0x7ED92C0", VA = "0x187EDA4C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool ICJNPIDFLHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7EDA630", Offset = "0x7ED9430", VA = "0x187EDA630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GONBNGOOGBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7EDA110", Offset = "0x7ED8F10", VA = "0x187EDA110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool JANJLKDBJPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7EDA3F0", Offset = "0x7ED91F0", VA = "0x187EDA3F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool NDCGCAPKDMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7EDA110", Offset = "0x7ED8F10", VA = "0x187EDA110", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool FHAAHJPKGBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7EDA190", Offset = "0x7ED8F90", VA = "0x187EDA190", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public string ELCEKMPPOKD
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7EDA2D0", Offset = "0x7ED90D0", VA = "0x187EDA2D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool NLNMHBMELOF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7EDA090", Offset = "0x7ED8E90", VA = "0x187EDA090", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<AHNIMKBJLEJ> GIOCEDLJAGC
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7ED9F60", Offset = "0x7ED8D60", VA = "0x187ED9F60")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7EDA750", Offset = "0x7ED9550", VA = "0x187EDA750")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7ED9EC0", Offset = "0x7ED8CC0", VA = "0x187ED9EC0")]
		public bool WasSpawnedForPlayer(int ONNMKFJKFNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x724EE60", Offset = "0x724DC60", VA = "0x18724EE60")]
		private void HJKPOJKCCIE(RRNetworkView AOJFFKDCAKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED9AF0", Offset = "0x7ED88F0", VA = "0x187ED9AF0", Slot = "9")]
		public void RegisterDestroyHandler(HBEJCHCGOCJ EAEFPGALELD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7ED9CF0", Offset = "0x7ED8AF0", VA = "0x187ED9CF0", Slot = "10")]
		public void UnregisterDestroyHandler(HBEJCHCGOCJ EAEFPGALELD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7ED9AD0", Offset = "0x7ED88D0", VA = "0x187ED9AD0", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
		public RRNetworkBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HKCIIHJJCKL
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void GOADDNCCFKH([In] AEJMJLLLPAC CNCKIIIBBGO, bool BFPMODGPNMP, bool OAPMPJKHKNH, bool HBJKCCDIPND);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void KBIHFJLLCDI(GameObject CIEOFCKLMHA);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void HIIJOGAJPDA(GameObject CIEOFCKLMHA);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void MOIJNJPHLOM(RRNetworkView IOEIHBPMNDC, string HGKLDIPJCMH, AHNIMKBJLEJ JBJICEBBHIA, BGJPLAEOAHJ? GDCDKMJLKDH, bool MHIFMDGCBCN, GFNNCIDMKDA HDPGNFCANCD, object[] CNCKIIIBBGO, string NPGCNKOPFOP);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate void FLPEEKLHEIG(RRNetworkView IOEIHBPMNDC, string HGKLDIPJCMH, AHNIMKBJLEJ JBJICEBBHIA, BGJPLAEOAHJ? GDCDKMJLKDH, bool MHIFMDGCBCN, GFNNCIDMKDA HDPGNFCANCD, object[] CNCKIIIBBGO, string NPGCNKOPFOP);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void PMCEIOPDEON(RRNetworkView IOEIHBPMNDC, string HGKLDIPJCMH, object[] PECPDCLIACL, string AIHGIEIDKOG);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void OMGCKNOIJKA(RRNetworkView IOEIHBPMNDC, AHNIMKBJLEJ FBICAMKLONP);

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[CompilerGenerated]
	private static KBIHFJLLCDI PKCEFMDNPFN;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event GOADDNCCFKH CKIKHADENHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7EC24A0", Offset = "0x7EC12A0", VA = "0x187EC24A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7EC1E40", Offset = "0x7EC0C40", VA = "0x187EC1E40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event KBIHFJLLCDI AIPEDMJHONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2BC0", Offset = "0x7EC19C0", VA = "0x187EC2BC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2830", Offset = "0x7EC1630", VA = "0x187EC2830")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event HIIJOGAJPDA KENILHHMAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7EC3040", Offset = "0x7EC1E40", VA = "0x187EC3040")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7EC26B0", Offset = "0x7EC14B0", VA = "0x187EC26B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public static event HIIJOGAJPDA KCKPCCICOBP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7EC28F0", Offset = "0x7EC16F0", VA = "0x187EC28F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2350", Offset = "0x7EC1150", VA = "0x187EC2350")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public static event MOIJNJPHLOM LDGMAHPGIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7EC25F0", Offset = "0x7EC13F0", VA = "0x187EC25F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7EC1FC0", Offset = "0x7EC0DC0", VA = "0x187EC1FC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public static event FLPEEKLHEIG BFDAOPCEPBG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2B00", Offset = "0x7EC1900", VA = "0x187EC2B00")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2F80", Offset = "0x7EC1D80", VA = "0x187EC2F80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event PMCEIOPDEON GHOLMLIGHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2D80", Offset = "0x7EC1B80", VA = "0x187EC2D80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7EC29B0", Offset = "0x7EC17B0", VA = "0x187EC29B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public static event OMGCKNOIJKA AAADIBOPJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2200", Offset = "0x7EC1000", VA = "0x187EC2200")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2080", Offset = "0x7EC0E80", VA = "0x187EC2080")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event OMGCKNOIJKA CHGIALANKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7EC1F00", Offset = "0x7EC0D00", VA = "0x187EC1F00")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2770", Offset = "0x7EC1570", VA = "0x187EC2770")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2140", Offset = "0x7EC0F40", VA = "0x187EC2140")]
	public static void EACMHOAEFEO([In] AEJMJLLLPAC CNCKIIIBBGO, bool BFPMODGPNMP, bool OAPMPJKHKNH, bool HBJKCCDIPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2410", Offset = "0x7EC1210", VA = "0x187EC2410")]
	public static void GBHJLFKOOOJ(GameObject CIEOFCKLMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2A70", Offset = "0x7EC1870", VA = "0x187EC2A70")]
	public static void LAFAPFOAKOE(GameObject CIEOFCKLMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7EC22C0", Offset = "0x7EC10C0", VA = "0x187EC22C0")]
	public static void FJBAODLBMBM(GameObject CIEOFCKLMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2560", Offset = "0x7EC1360", VA = "0x187EC2560")]
	public static void GNNLCJODGGO(GameObject CIEOFCKLMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3100", Offset = "0x7EC1F00", VA = "0x187EC3100")]
	public static void PIJEDMKHHMA(RRNetworkView IOEIHBPMNDC, string HGKLDIPJCMH, AHNIMKBJLEJ JBJICEBBHIA, BGJPLAEOAHJ? GDCDKMJLKDH, bool MHIFMDGCBCN, GFNNCIDMKDA HDPGNFCANCD, object[] CNCKIIIBBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2E40", Offset = "0x7EC1C40", VA = "0x187EC2E40")]
	public static void OKALJEFMIDB(RRNetworkView IOEIHBPMNDC, string HGKLDIPJCMH, int EDNKABGLFAD, object[] PECPDCLIACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2C80", Offset = "0x7EC1A80", VA = "0x187EC2C80")]
	public static void MIMNFKLOJCA(int EMPDJGGGCNA, int LCALHIDHIGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class PLKFNHIOOML
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9A20", Offset = "0x7ED8820", VA = "0x187ED9A20")]
	[CanBeNull]
	private static bool MCEFHNPMLCK(ViewId FONJFDCCINO, [Out] RRNetworkView IOEIHBPMNDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9940", Offset = "0x7ED8740", VA = "0x187ED9940")]
	[CanBeNull]
	public static Component IAKBDJIHLGM(this ViewId IOEIHBPMNDC, Type PGGHOMGDDEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3B20920", Offset = "0x3B1F720", VA = "0x183B20920")]
	[CanBeNull]
	public static T IAKBDJIHLGM<T>(this ViewId IOEIHBPMNDC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3B20920", Offset = "0x3B1F720", VA = "0x183B20920")]
	[CanBeNull]
	public static T FHHHKOBBDJI<T>(this ViewId IOEIHBPMNDC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3B20990", Offset = "0x3B1F790", VA = "0x183B20990")]
	public static bool PCCELMLCLPG<T>(this ViewId IOEIHBPMNDC, [Out] T BPINCJLADGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9870", Offset = "0x7ED8670", VA = "0x187ED9870")]
	[CanBeNull]
	public static RRNetworkView GEACMIJDPJL(this ViewId IOEIHBPMNDC)
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
		private static RRNetworkHandler BNOFOIBJLLE;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		internal static RRNetworkHandler ICOFMPPJNFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7EDA880", Offset = "0x7ED9680", VA = "0x187EDA880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7EDAA50", Offset = "0x7ED9850", VA = "0x187EDAA50")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7EDAA10", Offset = "0x7ED9810", VA = "0x187EDAA10")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
		public RRNetworkHandler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(OJFIHFHNIGF), new string[] { "Photon" })]
public sealed class OJFIHFHNIGF : KHMJIBCKPMB, BMBJAHBBAND, IMNKKHLGPLB, IIPCECBIBKI, DKKCOAOBEHF
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class LHFMFCDDEAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int requestedViewId;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LHFMFCDDEAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7ECC9A0", Offset = "0x7ECB7A0", VA = "0x187ECC9A0")]
		internal object AJNCJACJDEL((int requestedViewId, int newOwnerId, int senderId) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static IEBEPMGFCGH INMJILKMMOA;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static IEBEPMGFCGH BOOOMBCLFKF;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static Dictionary<int, HashSet<int>> GOLMBONIDPC;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static Dictionary<int, int> NEDMJJBJMME;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly List<(GameObject GameObject, int ParentCount)> ACBILPHIIII;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static readonly List<GameObject> CEOMJGKJOAH;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static List<int> CEBIHGBNDFO;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<RRNetworkView> LIHLKIKHANL;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly EEKDOOHAAOB BIMNJFMOJDC;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly EEKDOOHAAOB EPBLMCMKGOL;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5540", Offset = "0x7ED4340", VA = "0x187ED5540", Slot = "8")]
	public void NELONKEPHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFFB0", Offset = "0x7ECEDB0", VA = "0x187ECFFB0", Slot = "9")]
	public void DAHEEJMILJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7ED69F0", Offset = "0x7ED57F0", VA = "0x187ED69F0", Slot = "10")]
	public void PIEFLCLFLGG(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4F40", Offset = "0x7ED3D40", VA = "0x187ED4F40", Slot = "11")]
	public void KMEHAKMMBMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFDF0", Offset = "0x7ECEBF0", VA = "0x187ECFDF0")]
	private void CMJCMNNAGIK(OJNBBCLMJHF EKOCOIHOGCM, OJNBBCLMJHF JNOIIIFBOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5440", Offset = "0x7ED4240", VA = "0x187ED5440")]
	private void NCMHAGKMNLL(KOKPHDNOEMH NKIHBIMPCMA, KOKPHDNOEMH AEIALKPFDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0730", Offset = "0x7ECF530", VA = "0x187ED0730")]
	public GameObject DOEDAAPPKPL(string IHGFMOMOADA, Vector3 NPJPCFKLMHD, Quaternion LJIHJJKHDDH, Vector3 JCGDFDLNFJA, ViewId EMPDJGGGCNA, IKHGLHKGDCI CNCKIIIBBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2F20", Offset = "0x7ED1D20", VA = "0x187ED2F20")]
	public GameObject GPIMOBDBGOO(string IHGFMOMOADA, Vector3 NPJPCFKLMHD, Quaternion LJIHJJKHDDH, float JCGDFDLNFJA, object[] CNCKIIIBBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3DB0", Offset = "0x7ED2BB0", VA = "0x187ED3DB0")]
	public GameObject KBIFGBLCCKJ(string IHGFMOMOADA, Vector3 NPJPCFKLMHD, Quaternion LJIHJJKHDDH, Vector3 JCGDFDLNFJA, ViewId IOEIHBPMNDC, IKHGLHKGDCI CNCKIIIBBGO, bool HBJKCCDIPND = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2170", Offset = "0x7ED0F70", VA = "0x187ED2170")]
	public GameObject FKNEAKGOICB(AEJMJLLLPAC CNCKIIIBBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3D20", Offset = "0x7ED2B20", VA = "0x187ED3D20", Slot = "6")]
	public void JPMFKCJKFBO(GameObject CIEOFCKLMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE4C0", Offset = "0x7ECD2C0", VA = "0x187ECE4C0")]
	public void ABNMJBEMABO(GameObject MMMAEDGEACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7ED53D0", Offset = "0x7ED41D0", VA = "0x187ED53D0", Slot = "7")]
	public void LFEHLBPENLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7ED66C0", Offset = "0x7ED54C0", VA = "0x187ED66C0", Slot = "4")]
	public GameObject[] OLFCPNCNCLG(IList<HKDDDPDOOAM> KKEOIEBPBPK, bool IIAKKFIMGAL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7ECED40", Offset = "0x7ECDB40", VA = "0x187ECED40", Slot = "5")]
	public void CGGIPABKHLC(List<GameObject> GKGINNAJOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7ECEA90", Offset = "0x7ECD890", VA = "0x187ECEA90")]
	public void CBNNCLAKEHJ(GameObject MMMAEDGEACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE790", Offset = "0x7ECD590", VA = "0x187ECE790")]
	private void BKGKIMPMJEA(NEJHGGPCOKC FELHJOMEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7ECEB70", Offset = "0x7ECD970", VA = "0x187ECEB70")]
	private void CFEJHBAJNBE(NEJHGGPCOKC FELHJOMEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7ED5110", Offset = "0x7ED3F10", VA = "0x187ED5110")]
	private void LDFOENCGMMI(NEJHGGPCOKC FELHJOMEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7ED63E0", Offset = "0x7ED51E0", VA = "0x187ED63E0")]
	private void OJGMMLHNLNJ(NEJHGGPCOKC FELHJOMEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFA30", Offset = "0x7ECE830", VA = "0x187ECFA30")]
	private void CKJHLAKDIIB(NEJHGGPCOKC FELHJOMEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0330", Offset = "0x7ECF130", VA = "0x187ED0330")]
	private void DMGFOLMHLFO(NEJHGGPCOKC FELHJOMEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7ED25B0", Offset = "0x7ED13B0", VA = "0x187ED25B0")]
	private void GKFGNGENCND(NEJHGGPCOKC FELHJOMEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4D50", Offset = "0x7ED3B50", VA = "0x187ED4D50")]
	private GameObject KKIOPOMMGDC(string PGMKJGMLBKD, Vector3 NPJPCFKLMHD, Quaternion LJIHJJKHDDH, Vector3 JCGDFDLNFJA, byte NNLLPHNMAFL = 0, [Optional] object[] FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF120", Offset = "0x7ECDF20", VA = "0x187ECF120")]
	private GameObject CHJKOFIKOFN(AEJMJLLLPAC CNCKIIIBBGO, bool BFPMODGPNMP = false, bool OAPMPJKHKNH = false, bool HBJKCCDIPND = true, bool OOPKJEHDANP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3D30", Offset = "0x7ED2B30", VA = "0x187ED3D30")]
	private static GameObject KAJKEPKAKHM(string PGMKJGMLBKD, bool CAOJFKPNHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF820", Offset = "0x7ECE620", VA = "0x187ECF820")]
	private static GameObject CHJLIHHIFEF(GameObject OHJAGGPLIGB, AEJMJLLLPAC CNCKIIIBBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0900", Offset = "0x7ECF700", VA = "0x187ED0900")]
	private static void EGJBIPFHCJG(GameObject CIEOFCKLMHA, RRNetworkView IOEIHBPMNDC, [In] AEJMJLLLPAC CNCKIIIBBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7ED1970", Offset = "0x7ED0770", VA = "0x187ED1970")]
	private GameObject[] FKKCHGECMDL(IList<HKDDDPDOOAM> KKEOIEBPBPK, bool IIAKKFIMGAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3A80", Offset = "0x7ED2880", VA = "0x187ED3A80")]
	private GameObject[] JLGEJACHBGL(AEJMJLLLPAC[] NIEGGDAPLBF, int DCMKLAJPLBB, AHNIMKBJLEJ ENPELEHFGFF, GameObject[] JAEIMIDNHGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3670", Offset = "0x7ED2470", VA = "0x187ED3670")]
	private GameObject JAMJLJOJDGA([In] AEJMJLLLPAC CNCKIIIBBGO, GameObject OHJAGGPLIGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7230F60", Offset = "0x722FD60", VA = "0x187230F60")]
	private static bool LKHLCLBOILN(bool BFPMODGPNMP, bool HBJKCCDIPND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4120", Offset = "0x7ED2F20", VA = "0x187ED4120")]
	private void KHGDKMEOJDI(IEnumerable<GameObject> GKGINNAJOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0A50", Offset = "0x7ECF850", VA = "0x187ED0A50")]
	private void FKDGJDDLCFF(GameObject CIEOFCKLMHA, bool OOPKJEHDANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7ED21A0", Offset = "0x7ED0FA0", VA = "0x187ED21A0")]
	private static void GCPKIKIOKDN(IEnumerable<GameObject> CKKHEBCCBLP, List<(GameObject GameObject, int ParentCount)> FDEFADJMHAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE590", Offset = "0x7ECD390", VA = "0x187ECE590")]
	private void AELMCDNGBBM(int HPMJMOFABBN, int DCMKLAJPLBB, bool OOPKJEHDANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7ECFF10", Offset = "0x7ECED10", VA = "0x187ECFF10")]
	private static int CMOBGDIENFD(int HPMJMOFABBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7ED53E0", Offset = "0x7ED41E0", VA = "0x187ED53E0")]
	private void MPGNMHDDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3020", Offset = "0x7ED1E20", VA = "0x187ED3020")]
	private void HLFENDCDBCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE530", Offset = "0x7ECD330", VA = "0x187ECE530")]
	private static int AEJCOOCJGHC(int NDGJIOHGPKL, bool HBJKCCDIPND = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7ED4040", Offset = "0x7ED2E40", VA = "0x187ED4040")]
	private static int[] KEBGLNJIMGA(int NNIGPGCKAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7ED62E0", Offset = "0x7ED50E0", VA = "0x187ED62E0")]
	private static int[] OGAGCKGCNDA(int EALBMDJEHIA, int NNIGPGCKAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7ED0A10", Offset = "0x7ECF810", VA = "0x187ED0A10")]
	private void FDJAPPFCHOE(AHNIMKBJLEJ OCMOPICGOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7ED58B0", Offset = "0x7ED46B0", VA = "0x187ED58B0")]
	private void NLAIHKAKHAC(AHNIMKBJLEJ ENPELEHFGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7ED2C40", Offset = "0x7ED1A40", VA = "0x187ED2C40")]
	private void GLKFKKHNOFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7ED60A0", Offset = "0x7ED4EA0", VA = "0x187ED60A0")]
	private void ODCNHGIAPPE(AHNIMKBJLEJ ENPELEHFGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7ECE6F0", Offset = "0x7ECD4F0", VA = "0x187ECE6F0")]
	private static void AOKJIHGLJAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3570", Offset = "0x7ED2370", VA = "0x187ED3570")]
	private void IHFDCMKHNDA(int[] HLPIAKOPLDM, int JICAGBCIPLJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public OJFIHFHNIGF()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
		public RRNetworkProfiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(KBBBNOAIGBF), new string[] { "Photon" })]
public class KBBBNOAIGBF : BMBJAHBBAND, IMNKKHLGPLB, DKLJEFOPEOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct BCLFAHDGJEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly MethodInfo MAGLBIANMKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly Func<MonoBehaviour, object> ODBNNHBMFMJ;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xAE6A40", Offset = "0xAE5840", VA = "0x180AE6A40")]
		public BCLFAHDGJEM(MethodInfo MAGLBIANMKB, [Optional] Func<MonoBehaviour, object> ODBNNHBMFMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7238340", Offset = "0x7237140", VA = "0x187238340")]
		public object GIPHPKNMJGP(MonoBehaviour JHEFOCPABHK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class IJCIFHPMGAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public FieldInfo instanceAccessFromField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Func<MonoBehaviour, object> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public IJCIFHPMGAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7EC4010", Offset = "0x7EC2E10", VA = "0x187EC4010")]
		internal BCLFAHDGJEM KIPNNLNCMJN(MethodInfo methodInfo)
		{
			return default(BCLFAHDGJEM);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x46BE2F0", Offset = "0x46BD0F0", VA = "0x1846BE2F0")]
		internal object GDFKOIBFEAA(MonoBehaviour mb)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class JBLDLMGDMOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Func<MonoBehaviour, object> accessor;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JBLDLMGDMOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x721CAB0", Offset = "0x721B8B0", VA = "0x18721CAB0")]
		internal BCLFAHDGJEM LNFKEFEKIMK(MethodInfo methodInfo)
		{
			return default(BCLFAHDGJEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class ECNKPPECJPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Type attributeType;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ECNKPPECJPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7EBFFF0", Offset = "0x7EBEDF0", VA = "0x187EBFFF0")]
		internal bool AGOEGAJJIIJ(MethodInfo m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly Stopwatch LAGCLEBHBOC;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Dictionary<MethodInfo, ParameterInfo[]> FAGMBGBAMCF;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly Dictionary<Type, List<BCLFAHDGJEM>> GKANFPNGOOB;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7EC99B0", Offset = "0x7EC87B0", VA = "0x187EC99B0", Slot = "4")]
	public void NELONKEPHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7EC7260", Offset = "0x7EC6060", VA = "0x187EC7260", Slot = "5")]
	public void DAHEEJMILJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7EC69D0", Offset = "0x7EC57D0", VA = "0x187EC69D0")]
	private void BKGKIMPMJEA(NEJHGGPCOKC FELHJOMEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9080", Offset = "0x7EC7E80", VA = "0x187EC9080", Slot = "9")]
	public string GDOGBHAMCCA(NEJHGGPCOKC FELHJOMEEAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9AB0", Offset = "0x7EC88B0", VA = "0x187EC9AB0", Slot = "8")]
	public void OMMOBKGPBPC(ViewId EMPDJGGGCNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7EC7160", Offset = "0x7EC5F60", VA = "0x187EC7160", Slot = "6")]
	public void CLHDOFCDEHD(ViewId IOEIHBPMNDC, string HGKLDIPJCMH, AHNIMKBJLEJ ENPELEHFGFF, GFNNCIDMKDA HDPGNFCANCD, params object[] CNCKIIIBBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7EC7230", Offset = "0x7EC6030", VA = "0x187EC7230", Slot = "7")]
	public void CLHDOFCDEHD(ViewId IOEIHBPMNDC, string HGKLDIPJCMH, BGJPLAEOAHJ GDCDKMJLKDH, GFNNCIDMKDA HDPGNFCANCD, params object[] CNCKIIIBBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7EC6C80", Offset = "0x7EC5A80", VA = "0x187EC6C80")]
	private void CLHDOFCDEHD(ViewId IOEIHBPMNDC, string HGKLDIPJCMH, BGJPLAEOAHJ GDCDKMJLKDH, AHNIMKBJLEJ ENPELEHFGFF, GFNNCIDMKDA HDPGNFCANCD, params object[] CNCKIIIBBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7EC73B0", Offset = "0x7EC61B0", VA = "0x187EC73B0")]
	private void EPDANNIJOFA(ViewId EMPDJGGGCNA, string HGKLDIPJCMH, AHNIMKBJLEJ HLDOEFCHGDK, int GEKHAOKOBBH, object[] PECPDCLIACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7EC91C0", Offset = "0x7EC7FC0", VA = "0x187EC91C0")]
	private static void JGNHKBDOGPD(BCLFAHDGJEM KAHHHPDDBEL, MonoBehaviour HMJHEKIFDMD, object[] AOGFOJGFMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9680", Offset = "0x7EC8480", VA = "0x187EC9680")]
	private static bool MJBIOIBMIBD(ParameterInfo[] EDKKGJMOKAH, Type[] GNJMOPCFNKN, [Out] bool KLCIDKDHEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7EC9B90", Offset = "0x7EC8990", VA = "0x187EC9B90")]
	private List<BCLFAHDGJEM> POJLODBPIFO(MonoBehaviour HMJHEKIFDMD, Type PPNOFMIAPHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7EC98B0", Offset = "0x7EC86B0", VA = "0x187EC98B0")]
	private static IEnumerable<MethodInfo> NACINCDDMFA(Type AAFMBEEMJAC, Type CCKPMKIPGBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7EC90B0", Offset = "0x7EC7EB0", VA = "0x187EC90B0")]
	public static ParameterInfo[] GEJNBHEODJO(MethodInfo AGOABLEDKCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public KBBBNOAIGBF()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, AOMONGPLOBA, APIIMLLINOF, NJBELAMDMOG, PJMNNLIOKLG, BEDAPPGPKDN
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum NBMGDNJKANB
		{
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			False,
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			True_SetInSceneForRoom,
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			True_ManuallySetInPrefab
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class BDJIIMHHOLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public int actorNumber;

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public BDJIIMHHOLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x7EBFF90", Offset = "0x7EBED90", VA = "0x187EBFF90")]
			internal bool AEJFEDGHFLK(RRNetworkView view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static Dictionary<int, RRNetworkView> EBLLKHNPGKG;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static EEKDOOHAAOB IOPPNCHGDNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		private int viewIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		private int instantiationIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private bool FNCMDAKFGKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		internal bool DPJJGDEAFCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Tooltip("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		[SerializeField]
		public NBMGDNJKANB hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private bool HEGGCMDICBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private bool IBILAFOPKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int KCLNLHHOMCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool AHNFDAHHBDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int OCGEIBENKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private AHNIMKBJLEJ EALBMDJEHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private AHNIMKBJLEJ ODJGBEKDEFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private bool? LGADAMPMOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool AFGCDCOGAMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		internal bool DCJPLGAMIHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		internal MonoBehaviour[] NLHLIHFKKPN;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly IEBEPMGFCGH NMIONPEDDLH;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ViewId MCLJOGBKNAK
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7EDFD10", Offset = "0x7EDEB10", VA = "0x187EDFD10")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ViewId FFMGCFGGGHM
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7EDFD10", Offset = "0x7EDEB10", VA = "0x187EDFD10", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ViewId CJANOIALIEB
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7EDFD10", Offset = "0x7EDEB10", VA = "0x187EDFD10")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int FBGHGAGCAPK
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xA148C0", Offset = "0xA136C0", VA = "0x180A148C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int DICKAPDHKDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xA31A00", Offset = "0xA30800", VA = "0x180A31A00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xD8DB90", Offset = "0xD8C990", VA = "0x180D8DB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ViewId GFOMKOPNGNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7EDFB80", Offset = "0x7EDE980", VA = "0x187EDFB80")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool NFFALLPBCIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED10", Offset = "0xA0DB10", VA = "0x180A0ED10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA0ECB0", Offset = "0xA0DAB0", VA = "0x180A0ECB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool PJHFCMCPNGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7EDFB90", Offset = "0x7EDE990", VA = "0x187EDFB90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool GEAOINOCNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xDD8CC0", Offset = "0xDD7AC0", VA = "0x180DD8CC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAD8900", Offset = "0xAD7700", VA = "0x180AD8900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int JJIMCNLGGHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xC910C0", Offset = "0xC8FEC0", VA = "0x180C910C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int AMNDEMNAEEN
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7EDFB20", Offset = "0x7EDE920", VA = "0x187EDFB20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public AHNIMKBJLEJ MBFONMAHDDD
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7EDFD20", Offset = "0x7EDEB20", VA = "0x187EDFD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public AHNIMKBJLEJ OGPLKCFGGEH
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7EDFAF0", Offset = "0x7EDE8F0", VA = "0x187EDFAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public AHNIMKBJLEJ BKPPJKFJHPL
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7EDFAF0", Offset = "0x7EDE8F0", VA = "0x187EDFAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public AHNIMKBJLEJ AHJJPKDILHL
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7EDFAF0", Offset = "0x7EDE8F0", VA = "0x187EDFAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool EPDCFFOAJAI
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7EDFC60", Offset = "0x7EDEA60", VA = "0x187EDFC60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int OFIFCEBGOJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7EDFB50", Offset = "0x7EDE950", VA = "0x187EDFB50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public object[] PNOJGFDOOLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA0DA00", Offset = "0xA0C800", VA = "0x180A0DA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool DHMMNOOJEJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7EDFD50", Offset = "0x7EDEB50", VA = "0x187EDFD50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool GJGCDKDMBAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7EDFCE0", Offset = "0x7EDEAE0", VA = "0x187EDFCE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool OBEEEOBKNAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xD55D20", Offset = "0xD54B20", VA = "0x180D55D20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xE9B620", Offset = "0xE9A420", VA = "0x180E9B620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool HGOEAGNGJNI
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xBFED00", Offset = "0xBFDB00", VA = "0x180BFED00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> NECCGNOMBIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7EDF990", Offset = "0x7EDE790", VA = "0x187EDF990")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7EDFF10", Offset = "0x7EDED10", VA = "0x187EDFF10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<AHNIMKBJLEJ> ECMJHACEIKG
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7EDAFC0", Offset = "0x7ED9DC0", VA = "0x187EDAFC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7EDC2F0", Offset = "0x7EDB0F0", VA = "0x187EDC2F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<AHNIMKBJLEJ> GGPBJNEGGDL
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7EDAFC0", Offset = "0x7ED9DC0", VA = "0x187EDAFC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7EDC2F0", Offset = "0x7EDB0F0", VA = "0x187EDC2F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> LIEFHDCKBCD
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7EDB0F0", Offset = "0x7ED9EF0", VA = "0x187EDB0F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7EDC240", Offset = "0x7EDB040", VA = "0x187EDC240")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> BKHLBCBJNHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7EDB0F0", Offset = "0x7ED9EF0", VA = "0x187EDB0F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7EDC240", Offset = "0x7EDB040", VA = "0x187EDC240")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> FPKANJEIGAF
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x7EDFA40", Offset = "0x7EDE840", VA = "0x187EDFA40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x7EDFFC0", Offset = "0x7EDEDC0", VA = "0x187EDFFC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action BCLGGMNHCKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x7EDF8E0", Offset = "0x7EDE6E0", VA = "0x187EDF8E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x7EDFE60", Offset = "0x7EDEC60", VA = "0x187EDFE60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7EDF710", Offset = "0x7EDE510", VA = "0x187EDF710")]
		public static bool TryGetNetworkView(int EMPDJGGGCNA, [Out] RRNetworkView IOEIHBPMNDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7EDB1A0", Offset = "0x7ED9FA0", VA = "0x187EDB1A0")]
		public static RRNetworkView Find(int EMPDJGGGCNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7EDB360", Offset = "0x7EDA160", VA = "0x187EDB360")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int HCHHJGLKNCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7EDB2F0", Offset = "0x7EDA0F0", VA = "0x187EDB2F0")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7EDCE80", Offset = "0x7EDBC80", VA = "0x187EDCE80")]
		public static bool RemoveNetworkView(RRNetworkView IOEIHBPMNDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7EDCC50", Offset = "0x7EDBA50", VA = "0x187EDCC50")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7EDC620", Offset = "0x7EDB420", VA = "0x187EDC620")]
		public static void OnPlayerJoinedRoom(AHNIMKBJLEJ EFJCJCFFEIJ, List<int> HLPIAKOPLDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7EDB4A0", Offset = "0x7EDA2A0", VA = "0x187EDB4A0")]
		public static RRNetworkView Get(Component OFNOAHMACNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7EDB500", Offset = "0x7EDA300", VA = "0x187EDB500")]
		public static RRNetworkView Get(GameObject IIJNGAGBCIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7EDC3A0", Offset = "0x7EDB1A0", VA = "0x187EDC3A0")]
		private void OOEEEODNOMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7EDAF30", Offset = "0x7ED9D30", VA = "0x187EDAF30")]
		public bool CreatedBy(AHNIMKBJLEJ ENPELEHFGFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7EDF520", Offset = "0x7EDE320", VA = "0x187EDF520")]
		public void TransferOwnership(int OJGIJFMMACB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7EDF4C0", Offset = "0x7EDE2C0", VA = "0x187EDF4C0")]
		public void TransferOwnership(AHNIMKBJLEJ FBICAMKLONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7EDBD50", Offset = "0x7EDAB50", VA = "0x187EDBD50", Slot = "4")]
		public void Initialize(ViewId AGLKMBMOLNB, ViewId DKNNLJKKGFD, Dictionary<int, object> HLNAGBKDKBG, HMJDCIMFIOA EALBMDJEHIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7EDBED0", Offset = "0x7EDACD0", VA = "0x187EDBED0")]
		public void Initialize(ViewId AGLKMBMOLNB, ViewId DKNNLJKKGFD, object[] DDNFLLFMJDL, HMJDCIMFIOA EALBMDJEHIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7EDAA90", Offset = "0x7ED9890", VA = "0x187EDAA90")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7EDB600", Offset = "0x7EDA400", VA = "0x187EDB600")]
		private void HLKAEGDDNPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1DDB400", Offset = "0x1DDA200", VA = "0x181DDB400")]
		internal void KIGIAFONPCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7EDC970", Offset = "0x7EDB770", VA = "0x187EDC970", Slot = "6")]
		private void PPDMLNBHCNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7EDBCE0", Offset = "0x7EDAAE0", VA = "0x187EDBCE0")]
		internal bool IDAIDEKFFJP(RRNetworkView JNJBDENAGME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7EDC480", Offset = "0x7EDB280", VA = "0x187EDC480")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7EDC160", Offset = "0x7EDAF60", VA = "0x187EDC160")]
		internal void LNONCBCNEGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7EDAFB0", Offset = "0x7ED9DB0", VA = "0x187EDAFB0")]
		private void DCNHJNGJNLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7EDB230", Offset = "0x7EDA030", VA = "0x187EDB230")]
		internal void GOPJLDPPAMN(AHNIMKBJLEJ FBICAMKLONP, int OJGIJFMMACB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7EDCDE0", Offset = "0x7EDBBE0", VA = "0x187EDCDE0")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7EDCF00", Offset = "0x7EDBD00", VA = "0x187EDCF00")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7EDB560", Offset = "0x7EDA360", VA = "0x187EDB560")]
		private void HKCAONDJCEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7EDBFD0", Offset = "0x7EDADD0", VA = "0x187EDBFD0")]
		private void JLLGGOEIGJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7EDCBC0", Offset = "0x7EDB9C0", VA = "0x187EDCBC0")]
		public void RPC(string HGKLDIPJCMH, BGJPLAEOAHJ GDCDKMJLKDH, params object[] CNCKIIIBBGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7EDCB30", Offset = "0x7EDB930", VA = "0x187EDCB30")]
		public void RPC(string HGKLDIPJCMH, AHNIMKBJLEJ JBJICEBBHIA, params object[] CNCKIIIBBGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7EDCE30", Offset = "0x7EDBC30", VA = "0x187EDCE30")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7EDAC40", Offset = "0x7ED9A40", VA = "0x187EDAC40", Slot = "7")]
		public void Bake(GHEBJLJHKJI JAPGNGDBBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7EDB070", Offset = "0x7ED9E70", VA = "0x187EDB070")]
		private static void DOHEOHGBLGE(AHNIMKBJLEJ ALDGPAKLOOK, [Out] AHNIMKBJLEJ COJGENHFAGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7EDB9C0", Offset = "0x7EDA7C0", VA = "0x187EDB9C0")]
		private static void HPLFPHHNLGA(RRNetworkView DNCCNJDOKKL, Delegate KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7EDC1C0", Offset = "0x7EDAFC0", VA = "0x187EDC1C0")]
		private static LFJEHFKMNHM MBCKPCAFDJM(RRNetworkView DNCCNJDOKKL)
		{
			return default(LFJEHFKMNHM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7EDBF30", Offset = "0x7EDAD30", VA = "0x187EDBF30")]
		private static BGIPHKOMDPN JFIDIALKBBE(RRNetworkView DNCCNJDOKKL)
		{
			return default(BGIPHKOMDPN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7EDB8E0", Offset = "0x7EDA6E0", VA = "0x187EDB8E0")]
		private static void HPABNLACCKM(RRNetworkView DNCCNJDOKKL, Delegate KAHHHPDDBEL, AHNIMKBJLEJ JKLBOHMJEDF, params object[] CNCKIIIBBGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7EDB800", Offset = "0x7EDA600", VA = "0x187EDB800")]
		private static void HPABNLACCKM(RRNetworkView DNCCNJDOKKL, Delegate KAHHHPDDBEL, BGJPLAEOAHJ JKLBOHMJEDF, params object[] CNCKIIIBBGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7EDAAF0", Offset = "0x7ED98F0", VA = "0x187EDAAF0")]
		private static void BINJLBAPKNH(RRNetworkView DNCCNJDOKKL, Delegate KAHHHPDDBEL, BGJPLAEOAHJ JKLBOHMJEDF, LHIIGJPFOGM JKCCFOCGEGP, params object[] CNCKIIIBBGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7EDCA30", Offset = "0x7EDB830", VA = "0x187EDCA30")]
		public void RPCBuffered(string HGKLDIPJCMH, BGJPLAEOAHJ GDCDKMJLKDH, LHIIGJPFOGM HDPGNFCANCD, params object[] CNCKIIIBBGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7EDC0C0", Offset = "0x7EDAEC0", VA = "0x187EDC0C0")]
		private static bool LFEHHIAEHOJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7EDD9C0", Offset = "0x7EDC7C0", VA = "0x187EDD9C0", Slot = "24")]
		public void RpcAll(AOLBKFLABMF.BOBOBHECBKB KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3BECE00", Offset = "0x3BEBC00", VA = "0x183BECE00", Slot = "8")]
		public void RpcAll<T1>(AOLBKFLABMF.JMHAMGINDME<T1> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3BEC630", Offset = "0x3BEB430", VA = "0x183BEC630", Slot = "9")]
		public void RpcAll<T1, T2>(AOLBKFLABMF.DLPKHIBAFBK<T1, T2> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3BEEB10", Offset = "0x3BED910", VA = "0x183BEEB10", Slot = "25")]
		public void RpcAll<T1, T2, T3>(AOLBKFLABMF.JELFCLFBOFD<T1, T2, T3> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3BEC860", Offset = "0x3BEB660", VA = "0x183BEC860", Slot = "26")]
		public void RpcAll<T1, T2, T3, T4>(AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, T4> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE4B0", Offset = "0x3BED2B0", VA = "0x183BEE4B0", Slot = "27")]
		public void RpcAll<T1, T2, T3, T4, T5>(AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, T5> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3BEF020", Offset = "0x3BEDE20", VA = "0x183BEF020", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, T6> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3BF3010", Offset = "0x3BF1E10", VA = "0x183BF3010", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, T7> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3BF41B0", Offset = "0x3BF2FB0", VA = "0x183BF41B0", Slot = "10")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, T8> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3BEF4D0", Offset = "0x3BEE2D0", VA = "0x183BEF4D0", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, T9> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3BED880", Offset = "0x3BEC680", VA = "0x183BED880", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3BFB070", Offset = "0x3BF9E70", VA = "0x183BFB070", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3BF99E0", Offset = "0x3BF87E0", VA = "0x183BF99E0", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8770", Offset = "0x3BF7570", VA = "0x183BF8770", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3BECFA0", Offset = "0x3BEBDA0", VA = "0x183BECFA0", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7EDD7B0", Offset = "0x7EDC5B0", VA = "0x187EDD7B0")]
		public void RpcAll(AOLBKFLABMF.JMHAMGINDME<LFJEHFKMNHM> KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3BF16E0", Offset = "0x3BF04E0", VA = "0x183BF16E0")]
		public void RpcAll<T1>(AOLBKFLABMF.DLPKHIBAFBK<T1, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3BF2130", Offset = "0x3BF0F30", VA = "0x183BF2130")]
		public void RpcAll<T1, T2>(AOLBKFLABMF.JELFCLFBOFD<T1, T2, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE180", Offset = "0x3BECF80", VA = "0x183BEE180")]
		public void RpcAll<T1, T2, T3>(AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3C004C0", Offset = "0x3BFF2C0", VA = "0x183C004C0")]
		public void RpcAll<T1, T2, T3, T4>(AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3BFF940", Offset = "0x3BFE740", VA = "0x183BFF940")]
		public void RpcAll<T1, T2, T3, T4, T5>(AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3BFF5C0", Offset = "0x3BFE3C0", VA = "0x183BFF5C0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3BFE3C0", Offset = "0x3BFD1C0", VA = "0x183BFE3C0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3BFDF80", Offset = "0x3BFCD80", VA = "0x183BFDF80")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3BFCE60", Offset = "0x3BFBC60", VA = "0x183BFCE60")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3BFC4C0", Offset = "0x3BFB2C0", VA = "0x183BFC4C0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3BFB590", Offset = "0x3BFA390", VA = "0x183BFB590")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA530", Offset = "0x3BF9330", VA = "0x183BFA530")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8D60", Offset = "0x3BF7B60", VA = "0x183BF8D60")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3BF73B0", Offset = "0x3BF61B0", VA = "0x183BF73B0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IAOEKABFGHB KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7EDD580", Offset = "0x7EDC380", VA = "0x187EDD580", Slot = "35")]
		public void RpcAll(AOLBKFLABMF.JMHAMGINDME<BGIPHKOMDPN> KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3C04E80", Offset = "0x3C03C80", VA = "0x183C04E80", Slot = "36")]
		public void RpcAll<T1>(AOLBKFLABMF.DLPKHIBAFBK<T1, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3C02C80", Offset = "0x3C01A80", VA = "0x183C02C80", Slot = "37")]
		public void RpcAll<T1, T2>(AOLBKFLABMF.JELFCLFBOFD<T1, T2, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3C01080", Offset = "0x3BFFE80", VA = "0x183C01080", Slot = "38")]
		public void RpcAll<T1, T2, T3>(AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3C00790", Offset = "0x3BFF590", VA = "0x183C00790", Slot = "39")]
		public void RpcAll<T1, T2, T3, T4>(AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3BFFC60", Offset = "0x3BFEA60", VA = "0x183BFFC60", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4, T5>(AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3BFF240", Offset = "0x3BFE040", VA = "0x183BFF240", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3BFE7A0", Offset = "0x3BFD5A0", VA = "0x183BFE7A0", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3BFDB40", Offset = "0x3BFC940", VA = "0x183BFDB40", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3BFC9C0", Offset = "0x3BFB7C0", VA = "0x183BFC9C0", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3BFBFC0", Offset = "0x3BFADC0", VA = "0x183BFBFC0", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3BFAB00", Offset = "0x3BF9900", VA = "0x183BFAB00", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9F60", Offset = "0x3BF8D60", VA = "0x183BF9F60", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3BF93A0", Offset = "0x3BF81A0", VA = "0x183BF93A0", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3BF7A60", Offset = "0x3BF6860", VA = "0x183BF7A60", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IAOEKABFGHB KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7EDD1F0", Offset = "0x7EDBFF0", VA = "0x187EDD1F0", Slot = "50")]
		public void RpcAllViaServer(AOLBKFLABMF.BOBOBHECBKB KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3C18190", Offset = "0x3C16F90", VA = "0x183C18190", Slot = "51")]
		public void RpcAllViaServer<T1>(AOLBKFLABMF.JMHAMGINDME<T1> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3C0FFE0", Offset = "0x3C0EDE0", VA = "0x183C0FFE0", Slot = "12")]
		public void RpcAllViaServer<T1, T2>(AOLBKFLABMF.DLPKHIBAFBK<T1, T2> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3C17AC0", Offset = "0x3C168C0", VA = "0x183C17AC0", Slot = "52")]
		public void RpcAllViaServer<T1, T2, T3>(AOLBKFLABMF.JELFCLFBOFD<T1, T2, T3> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3C17160", Offset = "0x3C15F60", VA = "0x183C17160", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3, T4>(AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, T4> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3C16F10", Offset = "0x3C15D10", VA = "0x183C16F10", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, T5> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3C162C0", Offset = "0x3C150C0", VA = "0x183C162C0", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, T6> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3C15A20", Offset = "0x3C14820", VA = "0x183C15A20", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, T7> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3C153C0", Offset = "0x3C141C0", VA = "0x183C153C0", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, T8> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3C14610", Offset = "0x3C13410", VA = "0x183C14610", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, T9> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3C14240", Offset = "0x3C13040", VA = "0x183C14240", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3C13680", Offset = "0x3C12480", VA = "0x183C13680", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3C129D0", Offset = "0x3C117D0", VA = "0x183C129D0", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3C11770", Offset = "0x3C10570", VA = "0x183C11770", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3C10870", Offset = "0x3C0F670", VA = "0x183C10870", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7EDD450", Offset = "0x7EDC250", VA = "0x187EDD450")]
		public void RpcAllViaServer(AOLBKFLABMF.JMHAMGINDME<LFJEHFKMNHM> KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3C18290", Offset = "0x3C17090", VA = "0x183C18290")]
		public void RpcAllViaServer<T1>(AOLBKFLABMF.DLPKHIBAFBK<T1, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3C17DD0", Offset = "0x3C16BD0", VA = "0x183C17DD0")]
		public void RpcAllViaServer<T1, T2>(AOLBKFLABMF.JELFCLFBOFD<T1, T2, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3C17910", Offset = "0x3C16710", VA = "0x183C17910")]
		public void RpcAllViaServer<T1, T2, T3>(AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3C17560", Offset = "0x3C16360", VA = "0x183C17560")]
		public void RpcAllViaServer<T1, T2, T3, T4>(AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3C16A70", Offset = "0x3C15870", VA = "0x183C16A70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3C16550", Offset = "0x3C15350", VA = "0x183C16550")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3C15FE0", Offset = "0x3C14DE0", VA = "0x183C15FE0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3C15090", Offset = "0x3C13E90", VA = "0x183C15090")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3C14990", Offset = "0x3C13790", VA = "0x183C14990")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3C13AA0", Offset = "0x3C128A0", VA = "0x183C13AA0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3C13260", Offset = "0x3C12060", VA = "0x183C13260")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3C120F0", Offset = "0x3C10EF0", VA = "0x183C120F0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3C112B0", Offset = "0x3C100B0", VA = "0x183C112B0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3C10D90", Offset = "0x3C0FB90", VA = "0x183C10D90")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IAOEKABFGHB KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7EDD320", Offset = "0x7EDC120", VA = "0x187EDD320", Slot = "64")]
		public void RpcAllViaServer(AOLBKFLABMF.JMHAMGINDME<BGIPHKOMDPN> KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3C18090", Offset = "0x3C16E90", VA = "0x183C18090", Slot = "65")]
		public void RpcAllViaServer<T1>(AOLBKFLABMF.DLPKHIBAFBK<T1, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3C17F30", Offset = "0x3C16D30", VA = "0x183C17F30", Slot = "66")]
		public void RpcAllViaServer<T1, T2>(AOLBKFLABMF.JELFCLFBOFD<T1, T2, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3C17760", Offset = "0x3C16560", VA = "0x183C17760", Slot = "67")]
		public void RpcAllViaServer<T1, T2, T3>(AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3C17360", Offset = "0x3C16160", VA = "0x183C17360", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3, T4>(AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3C16CC0", Offset = "0x3C15AC0", VA = "0x183C16CC0", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3C167E0", Offset = "0x3C155E0", VA = "0x183C167E0", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3C15D00", Offset = "0x3C14B00", VA = "0x183C15D00", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3C156F0", Offset = "0x3C144F0", VA = "0x183C156F0", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3C14D10", Offset = "0x3C13B10", VA = "0x183C14D10", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3C13E70", Offset = "0x3C12C70", VA = "0x183C13E70", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3C12E40", Offset = "0x3C11C40", VA = "0x183C12E40", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3C12560", Offset = "0x3C11360", VA = "0x183C12560", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3C11C30", Offset = "0x3C10A30", VA = "0x183C11C30", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3C10350", Offset = "0x3C0F150", VA = "0x183C10350", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IAOEKABFGHB KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7EDEC00", Offset = "0x7EDDA00", VA = "0x187EDEC00", Slot = "79")]
		public void RpcOthers(AOLBKFLABMF.BOBOBHECBKB KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3C3CD20", Offset = "0x3C3BB20", VA = "0x183C3CD20", Slot = "13")]
		public void RpcOthers<T1>(AOLBKFLABMF.JMHAMGINDME<T1> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D2F0", Offset = "0x3C3C0F0", VA = "0x183C3D2F0", Slot = "80")]
		public void RpcOthers<T1, T2>(AOLBKFLABMF.DLPKHIBAFBK<T1, T2> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3C46140", Offset = "0x3C44F40", VA = "0x183C46140", Slot = "81")]
		public void RpcOthers<T1, T2, T3>(AOLBKFLABMF.JELFCLFBOFD<T1, T2, T3> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3C4EBA0", Offset = "0x3C4D9A0", VA = "0x183C4EBA0", Slot = "82")]
		public void RpcOthers<T1, T2, T3, T4>(AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, T4> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3C46D70", Offset = "0x3C45B70", VA = "0x183C46D70", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4, T5>(AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, T5> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3C4DA90", Offset = "0x3C4C890", VA = "0x183C4DA90", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, T6> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3C4D1B0", Offset = "0x3C4BFB0", VA = "0x183C4D1B0", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, T7> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3C4CB40", Offset = "0x3C4B940", VA = "0x183C4CB40", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, T8> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C4C0D0", Offset = "0x3C4AED0", VA = "0x183C4C0D0", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, T9> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3C4B580", Offset = "0x3C4A380", VA = "0x183C4B580", Slot = "14")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3C4A520", Offset = "0x3C49320", VA = "0x183C4A520", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3C49330", Offset = "0x3C48130", VA = "0x183C49330", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3C48950", Offset = "0x3C47750", VA = "0x183C48950", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3C479E0", Offset = "0x3C467E0", VA = "0x183C479E0", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7EDE960", Offset = "0x7EDD760", VA = "0x187EDE960")]
		public void RpcOthers(AOLBKFLABMF.JMHAMGINDME<LFJEHFKMNHM> KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D050", Offset = "0x3C3BE50", VA = "0x183C3D050")]
		public void RpcOthers<T1>(AOLBKFLABMF.DLPKHIBAFBK<T1, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3C3CE70", Offset = "0x3C3BC70", VA = "0x183C3CE70")]
		public void RpcOthers<T1, T2>(AOLBKFLABMF.JELFCLFBOFD<T1, T2, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3C4FB00", Offset = "0x3C4E900", VA = "0x183C4FB00")]
		public void RpcOthers<T1, T2, T3>(AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3C463C0", Offset = "0x3C451C0", VA = "0x183C463C0")]
		public void RpcOthers<T1, T2, T3, T4>(AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3C466A0", Offset = "0x3C454A0", VA = "0x183C466A0")]
		public void RpcOthers<T1, T2, T3, T4, T5>(AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3C469E0", Offset = "0x3C457E0", VA = "0x183C469E0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3C4CEA0", Offset = "0x3C4BCA0", VA = "0x183C4CEA0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3C4C7E0", Offset = "0x3C4B5E0", VA = "0x183C4C7E0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3C4BD20", Offset = "0x3C4AB20", VA = "0x183C4BD20")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3C4ADA0", Offset = "0x3C49BA0", VA = "0x183C4ADA0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3C4A0E0", Offset = "0x3C48EE0", VA = "0x183C4A0E0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3C49C50", Offset = "0x3C48A50", VA = "0x183C49C50")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3C48460", Offset = "0x3C47260", VA = "0x183C48460")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3C47F20", Offset = "0x3C46D20", VA = "0x183C47F20")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IAOEKABFGHB KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7EDEAB0", Offset = "0x7EDD8B0", VA = "0x187EDEAB0", Slot = "92")]
		public void RpcOthers(AOLBKFLABMF.JMHAMGINDME<BGIPHKOMDPN> KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3C3DD60", Offset = "0x3C3CB60", VA = "0x183C3DD60", Slot = "93")]
		public void RpcOthers<T1>(AOLBKFLABMF.DLPKHIBAFBK<T1, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3C50050", Offset = "0x3C4EE50", VA = "0x183C50050", Slot = "94")]
		public void RpcOthers<T1, T2>(AOLBKFLABMF.JELFCLFBOFD<T1, T2, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3C4F930", Offset = "0x3C4E730", VA = "0x183C4F930", Slot = "95")]
		public void RpcOthers<T1, T2, T3>(AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3C4E760", Offset = "0x3C4D560", VA = "0x183C4E760", Slot = "96")]
		public void RpcOthers<T1, T2, T3, T4>(AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3C4E010", Offset = "0x3C4CE10", VA = "0x183C4E010", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4, T5>(AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3C4D7D0", Offset = "0x3C4C5D0", VA = "0x183C4D7D0", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3C4D4C0", Offset = "0x3C4C2C0", VA = "0x183C4D4C0", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3C4C480", Offset = "0x3C4B280", VA = "0x183C4C480", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3C4B970", Offset = "0x3C4A770", VA = "0x183C4B970", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3C4B190", Offset = "0x3C49F90", VA = "0x183C4B190", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3C4A960", Offset = "0x3C49760", VA = "0x183C4A960", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3C497C0", Offset = "0x3C485C0", VA = "0x183C497C0", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3C48E40", Offset = "0x3C47C40", VA = "0x183C48E40", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3C474A0", Offset = "0x3C462A0", VA = "0x183C474A0", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IAOEKABFGHB KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7EDE3B0", Offset = "0x7EDD1B0", VA = "0x187EDE3B0", Slot = "107")]
		public void RpcMaster(AOLBKFLABMF.BOBOBHECBKB KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3C28CF0", Offset = "0x3C27AF0", VA = "0x183C28CF0", Slot = "108")]
		public void RpcMaster<T1>(AOLBKFLABMF.JMHAMGINDME<T1> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3C290C0", Offset = "0x3C27EC0", VA = "0x183C290C0", Slot = "15")]
		public void RpcMaster<T1, T2>(AOLBKFLABMF.DLPKHIBAFBK<T1, T2> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3C28A10", Offset = "0x3C27810", VA = "0x183C28A10", Slot = "109")]
		public void RpcMaster<T1, T2, T3>(AOLBKFLABMF.JELFCLFBOFD<T1, T2, T3> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3C286A0", Offset = "0x3C274A0", VA = "0x183C286A0", Slot = "110")]
		public void RpcMaster<T1, T2, T3, T4>(AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, T4> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3C2C910", Offset = "0x3C2B710", VA = "0x183C2C910", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4, T5>(AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, T5> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3C2EE50", Offset = "0x3C2DC50", VA = "0x183C2EE50", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, T6> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3C372E0", Offset = "0x3C360E0", VA = "0x183C372E0", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, T7> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3C36EC0", Offset = "0x3C35CC0", VA = "0x183C36EC0", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, T8> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3C357D0", Offset = "0x3C345D0", VA = "0x183C357D0", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, T9> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3C2C0B0", Offset = "0x3C2AEB0", VA = "0x183C2C0B0", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3C2AC60", Offset = "0x3C29A60", VA = "0x183C2AC60", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3C332E0", Offset = "0x3C320E0", VA = "0x183C332E0", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3C31490", Offset = "0x3C30290", VA = "0x183C31490", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3C30E30", Offset = "0x3C2FC30", VA = "0x183C30E30", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7EDE190", Offset = "0x7EDCF90", VA = "0x187EDE190")]
		public void RpcMaster(AOLBKFLABMF.JMHAMGINDME<LFJEHFKMNHM> KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3C28EB0", Offset = "0x3C27CB0", VA = "0x183C28EB0")]
		public void RpcMaster<T1>(AOLBKFLABMF.DLPKHIBAFBK<T1, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3C29DD0", Offset = "0x3C28BD0", VA = "0x183C29DD0")]
		public void RpcMaster<T1, T2>(AOLBKFLABMF.JELFCLFBOFD<T1, T2, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3C29320", Offset = "0x3C28120", VA = "0x183C29320")]
		public void RpcMaster<T1, T2, T3>(AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3C39300", Offset = "0x3C38100", VA = "0x183C39300")]
		public void RpcMaster<T1, T2, T3, T4>(AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3C2D3C0", Offset = "0x3C2C1C0", VA = "0x183C2D3C0")]
		public void RpcMaster<T1, T2, T3, T4, T5>(AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3C385C0", Offset = "0x3C373C0", VA = "0x183C385C0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3C376A0", Offset = "0x3C364A0", VA = "0x183C376A0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3C365E0", Offset = "0x3C353E0", VA = "0x183C365E0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3C36110", Offset = "0x3C34F10", VA = "0x183C36110")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3C352A0", Offset = "0x3C340A0", VA = "0x183C352A0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3C33870", Offset = "0x3C32670", VA = "0x183C33870")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3C32D00", Offset = "0x3C31B00", VA = "0x183C32D00")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3C320D0", Offset = "0x3C30ED0", VA = "0x183C320D0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3C300D0", Offset = "0x3C2EED0", VA = "0x183C300D0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IAOEKABFGHB KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7EDE540", Offset = "0x7EDD340", VA = "0x187EDE540", Slot = "121")]
		public void RpcMaster(AOLBKFLABMF.JMHAMGINDME<BGIPHKOMDPN> KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3C3C320", Offset = "0x3C3B120", VA = "0x183C3C320", Slot = "122")]
		public void RpcMaster<T1>(AOLBKFLABMF.DLPKHIBAFBK<T1, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3C3B330", Offset = "0x3C3A130", VA = "0x183C3B330", Slot = "123")]
		public void RpcMaster<T1, T2>(AOLBKFLABMF.JELFCLFBOFD<T1, T2, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A050", Offset = "0x3C38E50", VA = "0x183C3A050", Slot = "124")]
		public void RpcMaster<T1, T2, T3>(AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3C39890", Offset = "0x3C38690", VA = "0x183C39890", Slot = "125")]
		public void RpcMaster<T1, T2, T3, T4>(AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3C38FB0", Offset = "0x3C37DB0", VA = "0x183C38FB0", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4, T5>(AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3C38210", Offset = "0x3C37010", VA = "0x183C38210", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3C37AB0", Offset = "0x3C368B0", VA = "0x183C37AB0", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3C36A50", Offset = "0x3C35850", VA = "0x183C36A50", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3C35C40", Offset = "0x3C34A40", VA = "0x183C35C40", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3C348A0", Offset = "0x3C336A0", VA = "0x183C348A0", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3C34320", Offset = "0x3C33120", VA = "0x183C34320", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3C32720", Offset = "0x3C31520", VA = "0x183C32720", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3C31A80", Offset = "0x3C30880", VA = "0x183C31A80", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3C30780", Offset = "0x3C2F580", VA = "0x183C30780", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IAOEKABFGHB KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7EDDD80", Offset = "0x7EDCB80", VA = "0x187EDDD80", Slot = "136")]
		public void RpcAuthority(AOLBKFLABMF.BOBOBHECBKB KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3C18ED0", Offset = "0x3C17CD0", VA = "0x183C18ED0", Slot = "137")]
		public void RpcAuthority<T1>(AOLBKFLABMF.JMHAMGINDME<T1> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3C19F40", Offset = "0x3C18D40", VA = "0x183C19F40", Slot = "138")]
		public void RpcAuthority<T1, T2>(AOLBKFLABMF.DLPKHIBAFBK<T1, T2> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3C1A3A0", Offset = "0x3C191A0", VA = "0x183C1A3A0", Slot = "139")]
		public void RpcAuthority<T1, T2, T3>(AOLBKFLABMF.JELFCLFBOFD<T1, T2, T3> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3C19BF0", Offset = "0x3C189F0", VA = "0x183C19BF0", Slot = "140")]
		public void RpcAuthority<T1, T2, T3, T4>(AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, T4> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3C18390", Offset = "0x3C17190", VA = "0x183C18390", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, T5> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3C23380", Offset = "0x3C22180", VA = "0x183C23380", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, T6> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3C21FF0", Offset = "0x3C20DF0", VA = "0x183C21FF0", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, T7> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3C21BC0", Offset = "0x3C209C0", VA = "0x183C21BC0", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, T8> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3C20E30", Offset = "0x3C1FC30", VA = "0x183C20E30", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, T9> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3C1FA40", Offset = "0x3C1E840", VA = "0x183C1FA40", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3C1EFC0", Offset = "0x3C1DDC0", VA = "0x183C1EFC0", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3C187B0", Offset = "0x3C175B0", VA = "0x183C187B0", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3C1C030", Offset = "0x3C1AE30", VA = "0x183C1C030", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3C1AC40", Offset = "0x3C19A40", VA = "0x183C1AC40", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7EDDB30", Offset = "0x7EDC930", VA = "0x187EDDB30")]
		public void RpcAuthority(AOLBKFLABMF.JMHAMGINDME<LFJEHFKMNHM> KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3C26A10", Offset = "0x3C25810", VA = "0x183C26A10")]
		public void RpcAuthority<T1>(AOLBKFLABMF.DLPKHIBAFBK<T1, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3C25800", Offset = "0x3C24600", VA = "0x183C25800")]
		public void RpcAuthority<T1, T2>(AOLBKFLABMF.JELFCLFBOFD<T1, T2, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3C249B0", Offset = "0x3C237B0", VA = "0x183C249B0")]
		public void RpcAuthority<T1, T2, T3>(AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3C240E0", Offset = "0x3C22EE0", VA = "0x183C240E0")]
		public void RpcAuthority<T1, T2, T3, T4>(AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3C23D70", Offset = "0x3C22B70", VA = "0x183C23D70")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3C22C00", Offset = "0x3C21A00", VA = "0x183C22C00")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3C227E0", Offset = "0x3C215E0", VA = "0x183C227E0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3C21740", Offset = "0x3C20540", VA = "0x183C21740")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3C20950", Offset = "0x3C1F750", VA = "0x183C20950")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3C1F500", Offset = "0x3C1E300", VA = "0x183C1F500")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3C1EA30", Offset = "0x3C1D830", VA = "0x183C1EA30")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3C1D300", Offset = "0x3C1C100", VA = "0x183C1D300")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3C1C640", Offset = "0x3C1B440", VA = "0x183C1C640")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B970", Offset = "0x3C1A770", VA = "0x183C1B970")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IAOEKABFGHB KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7EDDF30", Offset = "0x7EDCD30", VA = "0x187EDDF30", Slot = "151")]
		public void RpcAuthority(AOLBKFLABMF.JMHAMGINDME<BGIPHKOMDPN> KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3C26690", Offset = "0x3C25490", VA = "0x183C26690", Slot = "152")]
		public void RpcAuthority<T1>(AOLBKFLABMF.DLPKHIBAFBK<T1, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3C253D0", Offset = "0x3C241D0", VA = "0x183C253D0", Slot = "153")]
		public void RpcAuthority<T1, T2>(AOLBKFLABMF.JELFCLFBOFD<T1, T2, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3C24EA0", Offset = "0x3C23CA0", VA = "0x183C24EA0", Slot = "154")]
		public void RpcAuthority<T1, T2, T3>(AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3C243F0", Offset = "0x3C231F0", VA = "0x183C243F0", Slot = "155")]
		public void RpcAuthority<T1, T2, T3, T4>(AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3C236F0", Offset = "0x3C224F0", VA = "0x183C236F0", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3C22FC0", Offset = "0x3C21DC0", VA = "0x183C22FC0", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3C223C0", Offset = "0x3C211C0", VA = "0x183C223C0", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3C212C0", Offset = "0x3C200C0", VA = "0x183C212C0", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3C20470", Offset = "0x3C1F270", VA = "0x183C20470", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3C1FF30", Offset = "0x3C1ED30", VA = "0x183C1FF30", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3C1E4A0", Offset = "0x3C1D2A0", VA = "0x183C1E4A0", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3C1DEA0", Offset = "0x3C1CCA0", VA = "0x183C1DEA0", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CCA0", Offset = "0x3C1BAA0", VA = "0x183C1CCA0", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B2B0", Offset = "0x3C1A0B0", VA = "0x183C1B2B0", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IAOEKABFGHB KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x7EDF2C0", Offset = "0x7EDE0C0", VA = "0x187EDF2C0", Slot = "16")]
		public void RpcPlayer(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.BOBOBHECBKB KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3C50940", Offset = "0x3C4F740", VA = "0x183C50940", Slot = "17")]
		public void RpcPlayer<T1>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.JMHAMGINDME<T1> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3C516E0", Offset = "0x3C504E0", VA = "0x183C516E0", Slot = "18")]
		public void RpcPlayer<T1, T2>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.DLPKHIBAFBK<T1, T2> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3C510F0", Offset = "0x3C4FEF0", VA = "0x183C510F0", Slot = "19")]
		public void RpcPlayer<T1, T2, T3>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.JELFCLFBOFD<T1, T2, T3> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3C50B10", Offset = "0x3C4F910", VA = "0x183C50B10", Slot = "20")]
		public void RpcPlayer<T1, T2, T3, T4>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, T4> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3C554A0", Offset = "0x3C542A0", VA = "0x183C554A0", Slot = "166")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, T5> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3C55030", Offset = "0x3C53E30", VA = "0x183C55030", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, T6> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3C55890", Offset = "0x3C54690", VA = "0x183C55890", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, T7> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3C55D60", Offset = "0x3C54B60", VA = "0x183C55D60", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, T8> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3C5E900", Offset = "0x3C5D700", VA = "0x183C5E900", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, T9> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3C5D4D0", Offset = "0x3C5C2D0", VA = "0x183C5D4D0", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(AHNIMKBJLEJ ENPELEHFGFF, DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3C51FD0", Offset = "0x3C50DD0", VA = "0x183C51FD0", Slot = "21")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(AHNIMKBJLEJ ENPELEHFGFF, DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B310", Offset = "0x3C5A110", VA = "0x183C5B310", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AHNIMKBJLEJ ENPELEHFGFF, HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3C5A070", Offset = "0x3C58E70", VA = "0x183C5A070", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(AHNIMKBJLEJ ENPELEHFGFF, IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3C59380", Offset = "0x3C58180", VA = "0x183C59380", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(AHNIMKBJLEJ ENPELEHFGFF, JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7EDED50", Offset = "0x7EDDB50", VA = "0x187EDED50")]
		public void RpcPlayer(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.JMHAMGINDME<LFJEHFKMNHM> KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3C50EC0", Offset = "0x3C4FCC0", VA = "0x183C50EC0")]
		public void RpcPlayer<T1>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.DLPKHIBAFBK<T1, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3C57CF0", Offset = "0x3C56AF0", VA = "0x183C57CF0")]
		public void RpcPlayer<T1, T2>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.JELFCLFBOFD<T1, T2, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3C62800", Offset = "0x3C61600", VA = "0x183C62800")]
		public void RpcPlayer<T1, T2, T3>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3C61C60", Offset = "0x3C60A60", VA = "0x183C61C60")]
		public void RpcPlayer<T1, T2, T3, T4>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3C61560", Offset = "0x3C60360", VA = "0x183C61560")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3C60E70", Offset = "0x3C5FC70", VA = "0x183C60E70")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3C5FF20", Offset = "0x3C5ED20", VA = "0x183C5FF20")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3C5EDA0", Offset = "0x3C5DBA0", VA = "0x183C5EDA0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x3C5E410", Offset = "0x3C5D210", VA = "0x183C5E410")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AHNIMKBJLEJ ENPELEHFGFF, DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x3C5D9D0", Offset = "0x3C5C7D0", VA = "0x183C5D9D0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(AHNIMKBJLEJ ENPELEHFGFF, DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x3C5C9D0", Offset = "0x3C5B7D0", VA = "0x183C5C9D0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(AHNIMKBJLEJ ENPELEHFGFF, HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3C5AD00", Offset = "0x3C59B00", VA = "0x183C5AD00")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AHNIMKBJLEJ ENPELEHFGFF, IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3C5A690", Offset = "0x3C59490", VA = "0x183C5A690")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(AHNIMKBJLEJ ENPELEHFGFF, JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3C585E0", Offset = "0x3C573E0", VA = "0x183C585E0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(AHNIMKBJLEJ ENPELEHFGFF, IAOEKABFGHB KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x7EDF000", Offset = "0x7EDDE00", VA = "0x187EDF000", Slot = "175")]
		public void RpcPlayer(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.JMHAMGINDME<BGIPHKOMDPN> KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3C53BE0", Offset = "0x3C529E0", VA = "0x183C53BE0", Slot = "176")]
		public void RpcPlayer<T1>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.DLPKHIBAFBK<T1, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x3C51CE0", Offset = "0x3C50AE0", VA = "0x183C51CE0", Slot = "22")]
		public void RpcPlayer<T1, T2>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.JELFCLFBOFD<T1, T2, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3C51960", Offset = "0x3C50760", VA = "0x183C51960", Slot = "23")]
		public void RpcPlayer<T1, T2, T3>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x3C53810", Offset = "0x3C52610", VA = "0x183C53810", Slot = "177")]
		public void RpcPlayer<T1, T2, T3, T4>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x3C618E0", Offset = "0x3C606E0", VA = "0x183C618E0", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3C60A90", Offset = "0x3C5F890", VA = "0x183C60A90", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3C5FAF0", Offset = "0x3C5E8F0", VA = "0x183C5FAF0", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3C5F230", Offset = "0x3C5E030", VA = "0x183C5F230", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(AHNIMKBJLEJ ENPELEHFGFF, AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3C5DF20", Offset = "0x3C5CD20", VA = "0x183C5DF20", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AHNIMKBJLEJ ENPELEHFGFF, DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3C5CF80", Offset = "0x3C5BD80", VA = "0x183C5CF80", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(AHNIMKBJLEJ ENPELEHFGFF, DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3C5BED0", Offset = "0x3C5ACD0", VA = "0x183C5BED0", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(AHNIMKBJLEJ ENPELEHFGFF, HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B8C0", Offset = "0x3C5A6C0", VA = "0x183C5B8C0", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AHNIMKBJLEJ ENPELEHFGFF, IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3C59A00", Offset = "0x3C58800", VA = "0x183C59A00", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(AHNIMKBJLEJ ENPELEHFGFF, JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3C58CB0", Offset = "0x3C57AB0", VA = "0x183C58CB0", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(AHNIMKBJLEJ ENPELEHFGFF, IAOEKABFGHB KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7EDD150", Offset = "0x7EDBF50", VA = "0x187EDD150", Slot = "188")]
		public void RpcAllBuffered(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.BOBOBHECBKB KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x3C0FC80", Offset = "0x3C0EA80", VA = "0x183C0FC80", Slot = "189")]
		public void RpcAllBuffered<T1>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.JMHAMGINDME<T1> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x3C0F9A0", Offset = "0x3C0E7A0", VA = "0x183C0F9A0", Slot = "190")]
		public void RpcAllBuffered<T1, T2>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.DLPKHIBAFBK<T1, T2> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x3C0F4B0", Offset = "0x3C0E2B0", VA = "0x183C0F4B0", Slot = "191")]
		public void RpcAllBuffered<T1, T2, T3>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.JELFCLFBOFD<T1, T2, T3> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x3C0F0E0", Offset = "0x3C0DEE0", VA = "0x183C0F0E0", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3, T4>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, T4> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x3C0EA70", Offset = "0x3C0D870", VA = "0x183C0EA70", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, T5> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3C0DDF0", Offset = "0x3C0CBF0", VA = "0x183C0DDF0", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, T6> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3C0D810", Offset = "0x3C0C610", VA = "0x183C0D810", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, T7> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3C0CEA0", Offset = "0x3C0BCA0", VA = "0x183C0CEA0", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, T8> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C7D0", Offset = "0x3C0B5D0", VA = "0x183C0C7D0", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, T9> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B510", Offset = "0x3C0A310", VA = "0x183C0B510", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LHIIGJPFOGM HDPGNFCANCD, DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A880", Offset = "0x3C09680", VA = "0x183C0A880", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LHIIGJPFOGM HDPGNFCANCD, DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x3C09B00", Offset = "0x3C08900", VA = "0x183C09B00", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHIIGJPFOGM HDPGNFCANCD, HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x3C08C90", Offset = "0x3C07A90", VA = "0x183C08C90", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHIIGJPFOGM HDPGNFCANCD, IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x3C07D30", Offset = "0x3C06B30", VA = "0x183C07D30", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LHIIGJPFOGM HDPGNFCANCD, JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7EDD0B0", Offset = "0x7EDBEB0", VA = "0x187EDD0B0")]
		public void RpcAllBuffered(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.JMHAMGINDME<LFJEHFKMNHM> KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x3C0FDA0", Offset = "0x3C0EBA0", VA = "0x183C0FDA0")]
		public void RpcAllBuffered<T1>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.DLPKHIBAFBK<T1, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x3C0F830", Offset = "0x3C0E630", VA = "0x183C0F830")]
		public void RpcAllBuffered<T1, T2>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.JELFCLFBOFD<T1, T2, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x3C0F2F0", Offset = "0x3C0E0F0", VA = "0x183C0F2F0")]
		public void RpcAllBuffered<T1, T2, T3>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x3C0ECC0", Offset = "0x3C0DAC0", VA = "0x183C0ECC0")]
		public void RpcAllBuffered<T1, T2, T3, T4>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E5D0", Offset = "0x3C0D3D0", VA = "0x183C0E5D0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E330", Offset = "0x3C0D130", VA = "0x183C0E330")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x3C0D520", Offset = "0x3C0C320", VA = "0x183C0D520")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x3C0CB60", Offset = "0x3C0B960", VA = "0x183C0CB60")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C440", Offset = "0x3C0B240", VA = "0x183C0C440")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LHIIGJPFOGM HDPGNFCANCD, DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B8F0", Offset = "0x3C0A6F0", VA = "0x183C0B8F0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LHIIGJPFOGM HDPGNFCANCD, DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x3C0ACB0", Offset = "0x3C09AB0", VA = "0x183C0ACB0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LHIIGJPFOGM HDPGNFCANCD, HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3C09F80", Offset = "0x3C08D80", VA = "0x183C09F80")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHIIGJPFOGM HDPGNFCANCD, IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x3C09630", Offset = "0x3C08430", VA = "0x183C09630")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHIIGJPFOGM HDPGNFCANCD, JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3C08250", Offset = "0x3C07050", VA = "0x183C08250")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LHIIGJPFOGM HDPGNFCANCD, IAOEKABFGHB KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7EDD010", Offset = "0x7EDBE10", VA = "0x187EDD010", Slot = "203")]
		public void RpcAllBuffered(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.JMHAMGINDME<BGIPHKOMDPN> KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3C0FEC0", Offset = "0x3C0ECC0", VA = "0x183C0FEC0", Slot = "204")]
		public void RpcAllBuffered<T1>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.DLPKHIBAFBK<T1, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x3C0FB10", Offset = "0x3C0E910", VA = "0x183C0FB10", Slot = "205")]
		public void RpcAllBuffered<T1, T2>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.JELFCLFBOFD<T1, T2, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x3C0F670", Offset = "0x3C0E470", VA = "0x183C0F670", Slot = "206")]
		public void RpcAllBuffered<T1, T2, T3>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3C0EED0", Offset = "0x3C0DCD0", VA = "0x183C0EED0", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3, T4>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E820", Offset = "0x3C0D620", VA = "0x183C0E820", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E090", Offset = "0x3C0CE90", VA = "0x183C0E090", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x3C0DB00", Offset = "0x3C0C900", VA = "0x183C0DB00", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3C0D1E0", Offset = "0x3C0BFE0", VA = "0x183C0D1E0", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C0B0", Offset = "0x3C0AEB0", VA = "0x183C0C0B0", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LHIIGJPFOGM HDPGNFCANCD, DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x3C0BCD0", Offset = "0x3C0AAD0", VA = "0x183C0BCD0", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LHIIGJPFOGM HDPGNFCANCD, DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B0E0", Offset = "0x3C09EE0", VA = "0x183C0B0E0", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LHIIGJPFOGM HDPGNFCANCD, HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A400", Offset = "0x3C09200", VA = "0x183C0A400", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHIIGJPFOGM HDPGNFCANCD, IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x3C09160", Offset = "0x3C07F60", VA = "0x183C09160", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHIIGJPFOGM HDPGNFCANCD, JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x3C08770", Offset = "0x3C07570", VA = "0x183C08770", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LHIIGJPFOGM HDPGNFCANCD, IAOEKABFGHB KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7EDE780", Offset = "0x7EDD580", VA = "0x187EDE780", Slot = "218")]
		public void RpcOthersBuffered(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.BOBOBHECBKB KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3C46020", Offset = "0x3C44E20", VA = "0x183C46020", Slot = "219")]
		public void RpcOthersBuffered<T1>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.JMHAMGINDME<T1> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x3C45C70", Offset = "0x3C44A70", VA = "0x183C45C70", Slot = "220")]
		public void RpcOthersBuffered<T1, T2>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.DLPKHIBAFBK<T1, T2> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x3C45610", Offset = "0x3C44410", VA = "0x183C45610", Slot = "221")]
		public void RpcOthersBuffered<T1, T2, T3>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.JELFCLFBOFD<T1, T2, T3> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3C45030", Offset = "0x3C43E30", VA = "0x183C45030", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, T4> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3C44730", Offset = "0x3C43530", VA = "0x183C44730", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, T5> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3C43F50", Offset = "0x3C42D50", VA = "0x183C43F50", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, T6> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3C43C60", Offset = "0x3C42A60", VA = "0x183C43C60", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, T7> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x3C43000", Offset = "0x3C41E00", VA = "0x183C43000", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, T8> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3C42210", Offset = "0x3C41010", VA = "0x183C42210", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, T9> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3C41670", Offset = "0x3C40470", VA = "0x183C41670", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LHIIGJPFOGM HDPGNFCANCD, DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3C409E0", Offset = "0x3C3F7E0", VA = "0x183C409E0", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LHIIGJPFOGM HDPGNFCANCD, DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x3C40560", Offset = "0x3C3F360", VA = "0x183C40560", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHIIGJPFOGM HDPGNFCANCD, HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3C3F790", Offset = "0x3C3E590", VA = "0x183C3F790", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHIIGJPFOGM HDPGNFCANCD, IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3C3DE90", Offset = "0x3C3CC90", VA = "0x183C3DE90", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LHIIGJPFOGM HDPGNFCANCD, JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7EDE8C0", Offset = "0x7EDD6C0", VA = "0x187EDE8C0")]
		public void RpcOthersBuffered(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.JMHAMGINDME<LFJEHFKMNHM> KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x3C45DE0", Offset = "0x3C44BE0", VA = "0x183C45DE0")]
		public void RpcOthersBuffered<T1>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.DLPKHIBAFBK<T1, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x3C45B00", Offset = "0x3C44900", VA = "0x183C45B00")]
		public void RpcOthersBuffered<T1, T2>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.JELFCLFBOFD<T1, T2, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x3C457D0", Offset = "0x3C445D0", VA = "0x183C457D0")]
		public void RpcOthersBuffered<T1, T2, T3>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3C45240", Offset = "0x3C44040", VA = "0x183C45240")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x3C44980", Offset = "0x3C43780", VA = "0x183C44980")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3C44490", Offset = "0x3C43290", VA = "0x183C44490")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x3C43680", Offset = "0x3C42480", VA = "0x183C43680")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3C42CC0", Offset = "0x3C41AC0", VA = "0x183C42CC0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, LFJEHFKMNHM> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x3C42930", Offset = "0x3C41730", VA = "0x183C42930")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LHIIGJPFOGM HDPGNFCANCD, DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3C41E30", Offset = "0x3C40C30", VA = "0x183C41E30")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LHIIGJPFOGM HDPGNFCANCD, DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x3C40E10", Offset = "0x3C3FC10", VA = "0x183C40E10")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LHIIGJPFOGM HDPGNFCANCD, HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3C400E0", Offset = "0x3C3EEE0", VA = "0x183C400E0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHIIGJPFOGM HDPGNFCANCD, IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x3C3EDF0", Offset = "0x3C3DBF0", VA = "0x183C3EDF0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHIIGJPFOGM HDPGNFCANCD, JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3C3E3B0", Offset = "0x3C3D1B0", VA = "0x183C3E3B0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LHIIGJPFOGM HDPGNFCANCD, IAOEKABFGHB KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7EDE820", Offset = "0x7EDD620", VA = "0x187EDE820", Slot = "233")]
		public void RpcOthersBuffered(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.JMHAMGINDME<BGIPHKOMDPN> KAHHHPDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3C45F00", Offset = "0x3C44D00", VA = "0x183C45F00", Slot = "234")]
		public void RpcOthersBuffered<T1>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.DLPKHIBAFBK<T1, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x3C45990", Offset = "0x3C44790", VA = "0x183C45990", Slot = "235")]
		public void RpcOthersBuffered<T1, T2>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.JELFCLFBOFD<T1, T2, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x3C45450", Offset = "0x3C44250", VA = "0x183C45450", Slot = "236")]
		public void RpcOthersBuffered<T1, T2, T3>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.DAFIPINHFNI<T1, T2, T3, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x3C44E20", Offset = "0x3C43C20", VA = "0x183C44E20", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.JDKEDPHHEHG<T1, T2, T3, T4, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x3C44BD0", Offset = "0x3C439D0", VA = "0x183C44BD0", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.MLNBCACOOKE<T1, T2, T3, T4, T5, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x3C441F0", Offset = "0x3C42FF0", VA = "0x183C441F0", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.LADJGIFGJLM<T1, T2, T3, T4, T5, T6, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3C43970", Offset = "0x3C42770", VA = "0x183C43970", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.KOGOIIKOCBM<T1, T2, T3, T4, T5, T6, T7, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x3C43340", Offset = "0x3C42140", VA = "0x183C43340", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(LHIIGJPFOGM HDPGNFCANCD, AOLBKFLABMF.FCMMFJJPDPF<T1, T2, T3, T4, T5, T6, T7, T8, BGIPHKOMDPN> KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x3C425A0", Offset = "0x3C413A0", VA = "0x183C425A0", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LHIIGJPFOGM HDPGNFCANCD, DLFJILNKAAC KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C41A50", Offset = "0x3C40850", VA = "0x183C41A50", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LHIIGJPFOGM HDPGNFCANCD, DJLOHKOLLOE KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x3C41240", Offset = "0x3C40040", VA = "0x183C41240", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LHIIGJPFOGM HDPGNFCANCD, HDLNCHJMBCK KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x3C3FC60", Offset = "0x3C3EA60", VA = "0x183C3FC60", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHIIGJPFOGM HDPGNFCANCD, IAPACCOCCDA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x3C3F2C0", Offset = "0x3C3E0C0", VA = "0x183C3F2C0", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHIIGJPFOGM HDPGNFCANCD, JFGPMLEBDPA KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x3C3E8D0", Offset = "0x3C3D6D0", VA = "0x183C3E8D0", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LHIIGJPFOGM HDPGNFCANCD, IAOEKABFGHB KAHHHPDDBEL, T1 AMLBFINICIL, T2 ECKBMCFHGNI, T3 ILGMIONCIBE, T4 LCHDNOKNPAM, T5 HOKHAJOCOLJ, T6 HNGNJHNCKOO, T7 BDJIHOCMDAH, T8 KPAHNPHNINK, T9 EGDGCIIEOJB, T10 PJNENEMNPGN, T11 GHLFDBGMFIB, T12 PAOELCCMBNB, T13 OLJCBLFACMB, T14 OAAJKDGBNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7EDACB0", Offset = "0x7ED9AB0", VA = "0x187EDACB0", Slot = "248")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7EDAED0", Offset = "0x7ED9CD0", VA = "0x187EDAED0", Slot = "249")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x1E30050", Offset = "0x1E2EE50", VA = "0x181E30050")]
		public RRNetworkView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class IGMEGNDDDPC
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3250", Offset = "0x7EC2050", VA = "0x187EC3250")]
	private static bool FALKNGJHGMB(ViewId FONJFDCCINO, [Out] RRNetworkView IOEIHBPMNDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x394A350", Offset = "0x3949150", VA = "0x18394A350")]
	[CanBeNull]
	public static T DCMFHEBEFMA<T>(this ViewId EMPDJGGGCNA)
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
		private sealed class PJBHEECKMGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public AHNIMKBJLEJ[] sorted;

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public PJBHEECKMGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x7ED70D0", Offset = "0x7ED5ED0", VA = "0x187ED70D0")]
			internal int FNPBCMFCBHA(int index)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x7ED7040", Offset = "0x7ED5E40", VA = "0x187ED7040")]
			internal void APCDCOPBMKL(int index, int number)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static readonly IEBEPMGFCGH NHLEILEPJMB;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static AHNIMKBJLEJ[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		internal int BOPDJFOCNPH;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7EE01C0", Offset = "0x7EDEFC0", VA = "0x187EE01C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7EE07F0", Offset = "0x7EDF5F0", VA = "0x187EE07F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7EE0BC0", Offset = "0x7EDF9C0", VA = "0x187EE0BC0")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7EE0C40", Offset = "0x7EDFA40", VA = "0x187EE0C40")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7EE07E0", Offset = "0x7EDF5E0", VA = "0x187EE07E0")]
		private void EONCOEHBNGC(AHNIMKBJLEJ EFJCJCFFEIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7EE07E0", Offset = "0x7EDF5E0", VA = "0x187EE07E0")]
		private void NLAIHKAKHAC(AHNIMKBJLEJ BGPDJLHAPJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7EE06F0", Offset = "0x7EDF4F0", VA = "0x187EE06F0")]
		private void ENIPKDOADNP(AHNIMKBJLEJ JBJICEBBHIA, IDictionary<object, object> HDEAGHIEAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7EE0070", Offset = "0x7EDEE70", VA = "0x187EE0070")]
		public static void AssignPlayerNumbers(int FBBIFJPBHBC, int BJBBFLIENFC, Func<int, int> EOHAGDFKCHO, Action<int, int> AIJFGCHIEKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7EE0CF0", Offset = "0x7EDFAF0", VA = "0x187EE0CF0")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7EE0600", Offset = "0x7EDF400", VA = "0x187EE0600")]
		private void BIPDLLEOFBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xA1A790", Offset = "0xA19590", VA = "0x180A1A790")]
		public RRPlayerNumbering()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class GJJMGFOMDFD
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1C20", Offset = "0x7EC0A20", VA = "0x187EC1C20")]
	public static int IMCGNKMGMHN(this AHNIMKBJLEJ ENPELEHFGFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1850", Offset = "0x7EC0650", VA = "0x187EC1850")]
	public static void DJHMLFPODDK(this AHNIMKBJLEJ ENPELEHFGFF, int MJHIMKDDAKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class NLJOJGCHPGL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void LLHDIJPONFO(Hashtable ADPBPEDNFCM);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate void KBCIBGAKPLB(AHNIMKBJLEJ ENPELEHFGFF, Hashtable ADPBPEDNFCM);

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public static event LLHDIJPONFO MECLLPCEIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE100", Offset = "0x7ECCF00", VA = "0x187ECE100")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE400", Offset = "0x7ECD200", VA = "0x187ECE400")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public static event LLHDIJPONFO AOIHJHAFPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7ECDEC0", Offset = "0x7ECCCC0", VA = "0x187ECDEC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE280", Offset = "0x7ECD080", VA = "0x187ECE280")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public static event KBCIBGAKPLB AJCKCHHAKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE340", Offset = "0x7ECD140", VA = "0x187ECE340")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7ECDF80", Offset = "0x7ECCD80", VA = "0x187ECDF80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public static event KBCIBGAKPLB CLCCAEAAPJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE040", Offset = "0x7ECCE40", VA = "0x187ECE040")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7ECE1C0", Offset = "0x7ECCFC0", VA = "0x187ECE1C0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class LGJPKOELDCJ
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static int LGOBACHLPEO;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static int OOHPNDIGFND;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int ABDNCGFNBIE;

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x7ECC950", Offset = "0x7ECB750", VA = "0x187ECC950")]
	public static void MNLAOHOLJDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7ECC870", Offset = "0x7ECB670", VA = "0x187ECC870")]
	public static void HFFLFHOKEDE(int[] HHMLCCMDJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7ECC5C0", Offset = "0x7ECB3C0", VA = "0x187ECC5C0")]
	public static int AEJCOOCJGHC(int NDGJIOHGPKL, bool HBJKCCDIPND = true)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[RegisterService(typeof(PJGDPFFFDLJ), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class PJGDPFFFDLJ : CLJPJNPNMPP, BMBJAHBBAND, IMNKKHLGPLB
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly Hashtable PNKNLIIEHKC;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static readonly Hashtable OPBFNMCJDOH;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static readonly Hashtable PNNLHNOFCLN;

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static readonly EEKDOOHAAOB MIHJDHKLNEE;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static readonly EEKDOOHAAOB JHABJLOKNPP;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly EEKDOOHAAOB BMJBNODDNCM;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static readonly EEKDOOHAAOB BIMNJFMOJDC;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly EEKDOOHAAOB EPBLMCMKGOL;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static int GEDLONGNIDC;

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7ED90D0", Offset = "0x7ED7ED0", VA = "0x187ED90D0", Slot = "18")]
	public void NELONKEPHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7400", Offset = "0x7ED6200", VA = "0x187ED7400", Slot = "19")]
	public void DAHEEJMILJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7ED74A0", Offset = "0x7ED62A0", VA = "0x187ED74A0", Slot = "4")]
	public bool DGOBKFPNPCF(AEJMJLLLPAC CNCKIIIBBGO, bool DJNKFPJFAAB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7ED78E0", Offset = "0x7ED66E0", VA = "0x187ED78E0", Slot = "5")]
	public int HCBMOBOIKBL(AEJMJLLLPAC[] NIEGGDAPLBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7370", Offset = "0x7ED6170", VA = "0x187ED7370", Slot = "6")]
	public bool CLJDOFGFCDI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8F30", Offset = "0x7ED7D30", VA = "0x187ED8F30", Slot = "7")]
	public bool MOBDIMMFMMB(int EMPDJGGGCNA, int HPMJMOFABBN, bool NFFALLPBCIC, GameObject MMMAEDGEACA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7CA0", Offset = "0x7ED6AA0", VA = "0x187ED7CA0", Slot = "8")]
	public void HDBEAJBABFF(int HPMJMOFABBN, [Optional] int? MELMEPMJOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8DC0", Offset = "0x7ED7BC0", VA = "0x187ED8DC0", Slot = "9")]
	public bool MLGANLFOMHM(NEJHGGPCOKC FELHJOMEEAD, [Out] AEJMJLLLPAC ILNKPLKLGAC, bool MKJINPBEEBP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7ED82D0", Offset = "0x7ED70D0", VA = "0x187ED82D0", Slot = "10")]
	public bool JPJAALHHBMP(NEJHGGPCOKC FELHJOMEEAD, [Out] int DCMKLAJPLBB, [Out] AEJMJLLLPAC[] NIEGGDAPLBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7ED85B0", Offset = "0x7ED73B0", VA = "0x187ED85B0", Slot = "11")]
	public bool KOFMDLBDBFP(NEJHGGPCOKC FELHJOMEEAD, [Out] int HPMJMOFABBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7700", Offset = "0x7ED6500", VA = "0x187ED7700", Slot = "12")]
	public void GCDKKLBPJGP(NEJHGGPCOKC FELHJOMEEAD, [Out] int JLCNGKHMHPF, [Out] int[] AEKCOLFKJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9240", Offset = "0x7ED8040", VA = "0x187ED9240", Slot = "13")]
	public void NNIPEFLKNHB(int DCMKLAJPLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x7ED75E0", Offset = "0x7ED63E0", VA = "0x187ED75E0", Slot = "14")]
	public void FFNOOONHAKM(int DCMKLAJPLBB, int[] AEKCOLFKJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x7ED72C0", Offset = "0x7ED60C0", VA = "0x187ED72C0", Slot = "15")]
	public void BPFKEIOFDJB(int[] AEKCOLFKJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9170", Offset = "0x7ED7F70", VA = "0x187ED9170", Slot = "16")]
	public void NKDHHEOOHHO(int[] AEKCOLFKJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7150", Offset = "0x7ED5F50", VA = "0x187ED7150", Slot = "17")]
	public void AFGNEKMDACL(int DCMKLAJPLBB, int HPMJMOFABBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7ED7E90", Offset = "0x7ED6C90", VA = "0x187ED7E90")]
	private static void IIHBJJLDLPF(AEJMJLLLPAC CNCKIIIBBGO, Hashtable OAPMPJKHKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7ED86D0", Offset = "0x7ED74D0", VA = "0x187ED86D0")]
	private static bool MLGANLFOMHM(Hashtable OAPMPJKHKNH, AHNIMKBJLEJ NIEDOFANOLB, [Out] AEJMJLLLPAC ILNKPLKLGAC, bool MKJINPBEEBP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7ED9480", Offset = "0x7ED8280", VA = "0x187ED9480")]
	private static bool PNLDBPBOPJO(int HPMJMOFABBN, AEJMJLLLPAC OAPMPJKHKNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7ED93A0", Offset = "0x7ED81A0", VA = "0x187ED93A0")]
	private static int PMGCNCNFDKD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public PJGDPFFFDLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
[RegisterService(typeof(IHGKLJKNJAN), new string[] { })]
public class IHGKLJKNJAN : JFFIFGMEPHO, BMBJAHBBAND, IMNKKHLGPLB
{
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static Hashtable PIBCNGNPKCI;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static Hashtable ALPLEDALBAN;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static EEKDOOHAAOB EICKHHINBBC;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly EEKDOOHAAOB NCDOAIOCKJA;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7EC38E0", Offset = "0x7EC26E0", VA = "0x187EC38E0", Slot = "8")]
	public void DAHEEJMILJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3CC0", Offset = "0x7EC2AC0", VA = "0x187EC3CC0", Slot = "7")]
	public void NELONKEPHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3D60", Offset = "0x7EC2B60", VA = "0x187EC3D60", Slot = "4")]
	public void OMMOBKGPBPC(ViewId EMPDJGGGCNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3980", Offset = "0x7EC2780", VA = "0x187EC3980", Slot = "5")]
	public bool GKFCFLGPOJJ(NEJHGGPCOKC FELHJOMEEAD, [Out] ViewId EMPDJGGGCNA, [Out] string HGKLDIPJCMH, [Out] int GEKHAOKOBBH, [Out] object[] PECPDCLIACL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7EC3310", Offset = "0x7EC2110", VA = "0x187EC3310", Slot = "6")]
	public void AEKLBDOMNDN(ViewId IOEIHBPMNDC, string HGKLDIPJCMH, BGJPLAEOAHJ NIDFNACFIPF, AHNIMKBJLEJ ENPELEHFGFF, GFNNCIDMKDA CJLMBKIAAJN, object[] CNCKIIIBBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public IHGKLJKNJAN()
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
