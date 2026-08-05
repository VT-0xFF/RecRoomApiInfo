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
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x822F770", Offset = "0x822E370", VA = "0x18822F770", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x230C5A0", Offset = "0x230B1A0", VA = "0x18230C5A0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8243590", Offset = "0x8242190", VA = "0x188243590")]
		private void GAOPLNBGOGD(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8243320", Offset = "0x8241F20", VA = "0x188243320")]
		private void BBOPNMEHPCH(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8243BF0", Offset = "0x82427F0", VA = "0x188243BF0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8243CA0", Offset = "0x82428A0", VA = "0x188243CA0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AAFFKCIGEBD
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly PEOHNMCPNIJ KAPGMCDEGPH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static PEOHNMCPNIJ EDNGIBKHNNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82216B0", Offset = "0x82202B0", VA = "0x1882216B0")]
		get
		{
			return default(PEOHNMCPNIJ);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NGGNPFPFPHL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	RRNetworkView HABLGGMFJNB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	EPOECJPKADK AOIIOAOJEJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HDAMEMCFMDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool Serialize(CMODEHBMKPA CGMEIBHKOMA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Deserialize(OCKEHJCPBHA ACLFBNHJPDH, CMODEHBMKPA CGMEIBHKOMA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface EMHCIGOBJDE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JFLICNLPAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FNEHNJHAFGD(OCKEHJCPBHA ACLFBNHJPDH);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GLDNKJDIMCO(OCKEHJCPBHA ACLFBNHJPDH, CMODEHBMKPA CGMEIBHKOMA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface EDLMHIPJKGF : INetworkUpdateSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMHLLDBNIFP(NGGNPFPFPHL HBFAGGPFDBN);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADKBIHLFMAC(NGGNPFPFPHL HBFAGGPFDBN);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCFIDBBIPMM(OCLDEINPEGJ.PJBMIGBHLFB MMMAIEFFLFN);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LHOEAFBHNNC();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AOFJGLLMHFH(object CKGMOBNFAKG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum EPOECJPKADK : byte
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
public struct OCKEHJCPBHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int OMFLIKNBECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public uint HKEMEELNMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public double BEMMDDJOEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public int IBCAPACNDAD;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DCGGNEIGLOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly Dictionary<(ViewId, EPOECJPKADK), EMHCIGOBJDE> CEDJNMNPPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly List<NGGNPFPFPHL> ACFOMILMELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly HashSet<(ViewId, EPOECJPKADK)> ILKBGFGHEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private int HNIPEKFGJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public bool NCBIFKMHDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private OCLDEINPEGJ.PJBMIGBHLFB MMMAIEFFLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly MemoryStream OGFGEBDMAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly CMODEHBMKPA MPFKBPHAECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CMODEHBMKPA BEMMHHLMCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private byte[] KMFFAHBPNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private float MCOCLDAPKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int FGIGBIPEDMG;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x822B0C0", Offset = "0x8229CC0", VA = "0x18822B0C0")]
	public DCGGNEIGLOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x822A6D0", Offset = "0x82292D0", VA = "0x18822A6D0")]
	public void JCFIDBBIPMM(OCLDEINPEGJ.PJBMIGBHLFB MMMAIEFFLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x822A6F0", Offset = "0x82292F0", VA = "0x18822A6F0")]
	public void LHOEAFBHNNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x822A740", Offset = "0x8229340", VA = "0x18822A740")]
	public void MONBEGLCAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x822AB20", Offset = "0x8229720", VA = "0x18822AB20")]
	public bool NDGLNAHKHEG(NGGNPFPFPHL HBFAGGPFDBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8229C10", Offset = "0x8228810", VA = "0x188229C10")]
	public bool ENKPLOICKCM(NGGNPFPFPHL HBFAGGPFDBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x822A0F0", Offset = "0x8228CF0", VA = "0x18822A0F0")]
	private EMHCIGOBJDE HBJMOOMAMLE(ViewId ECLEFOAKJDA, EPOECJPKADK AHMLDNAGDAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x822A6C0", Offset = "0x82292C0", VA = "0x18822A6C0")]
	public void HOABGHECOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x822B040", Offset = "0x8229C40", VA = "0x18822B040")]
	private void NJACGLMONJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x822B0A0", Offset = "0x8229CA0", VA = "0x18822B0A0")]
	private void PDONCFGNOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x822A310", Offset = "0x8228F10", VA = "0x18822A310")]
	public bool HKBKBJJIKPF(FastBufferWriter HDDCOPOMJML, int COONILEBBNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8229D40", Offset = "0x8228940", VA = "0x188229D40")]
	public void GLDNKJDIMCO(OCKEHJCPBHA ACLFBNHJPDH, FastBufferReader NOIAIJBDKGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class CDBOINLGMGI : EMHCIGOBJDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NGGNPFPFPHL AOOPBBJNDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private uint DHHKCFBKMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int NOMJBOAHOAJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool JFLICNLPAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
	public CDBOINLGMGI(NGGNPFPFPHL AOOPBBJNDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8225630", Offset = "0x8224230", VA = "0x188225630", Slot = "5")]
	public bool FNEHNJHAFGD(OCKEHJCPBHA ACLFBNHJPDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8225740", Offset = "0x8224340", VA = "0x188225740", Slot = "6")]
	public void GLDNKJDIMCO(OCKEHJCPBHA ACLFBNHJPDH, CMODEHBMKPA CGMEIBHKOMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ACDNBBNFAOG : EMHCIGOBJDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private OCLDEINPEGJ.PJBMIGBHLFB MMMAIEFFLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly ViewId ECLEFOAKJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int NOMJBOAHOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private uint DHHKCFBKMOD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool JFLICNLPAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1BDE900", Offset = "0x1BDD500", VA = "0x181BDE900")]
	public ACDNBBNFAOG(ViewId ECLEFOAKJDA, OCLDEINPEGJ.PJBMIGBHLFB MMMAIEFFLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8221770", Offset = "0x8220370", VA = "0x188221770", Slot = "5")]
	public bool FNEHNJHAFGD(OCKEHJCPBHA ACLFBNHJPDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x82217B0", Offset = "0x82203B0", VA = "0x1882217B0", Slot = "6")]
	public void GLDNKJDIMCO(OCKEHJCPBHA ACLFBNHJPDH, CMODEHBMKPA CGMEIBHKOMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class EMJFCECIDHC
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x822BD10", Offset = "0x822A910", VA = "0x18822BD10")]
	public static void PBHGMJKEMBG(this IHJNLMEPEBP OIOIIPDCDNE, CMODEHBMKPA FCFBPELPJNJ, ViewId PBHLPKLGFAP, bool IJLNBLABADP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x822B450", Offset = "0x822A050", VA = "0x18822B450")]
	public static void LFKMGAEBAFA(this IHJNLMEPEBP OIOIIPDCDNE, CMODEHBMKPA FCFBPELPJNJ, bool IJLNBLABADP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x822B2E0", Offset = "0x8229EE0", VA = "0x18822B2E0")]
	public static IHJNLMEPEBP GLDNKJDIMCO(CMODEHBMKPA FCFBPELPJNJ, ViewId PBHLPKLGFAP, bool IJLNBLABADP = true)
	{
		return default(IHJNLMEPEBP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x822B950", Offset = "0x822A550", VA = "0x18822B950")]
	public static void LINCBAGNNJD(this IHJNLMEPEBP OIOIIPDCDNE, CMODEHBMKPA FCFBPELPJNJ, bool IJLNBLABADP = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(EDLMHIPJKGF), new string[] { })]
public class IJKMHMEPDMH : EDLMHIPJKGF, INetworkUpdateSystem, HHIKJEGILJH, IBPJLLPNJDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly PEOHNMCPNIJ GKEJHGMJODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private DCGGNEIGLOA IKBOBEPJMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private uint LGLGPBJJMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private float HHLFBHGHIBB;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x822D970", Offset = "0x822C570", VA = "0x18822D970", Slot = "4")]
	public void AMHLLDBNIFP(NGGNPFPFPHL HBFAGGPFDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x822D770", Offset = "0x822C370", VA = "0x18822D770", Slot = "5")]
	public void ADKBIHLFMAC(NGGNPFPFPHL HBFAGGPFDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x822E670", Offset = "0x822D270", VA = "0x18822E670", Slot = "10")]
	public void PLHNEJELPBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x822E5F0", Offset = "0x822D1F0", VA = "0x18822E5F0", Slot = "9")]
	public void NetworkUpdate(NetworkUpdateStage NMJPCJFGECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x822E020", Offset = "0x822CC20", VA = "0x18822E020")]
	private void NIDJOPGEJBJ(uint HKEECNKOFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x822DF90", Offset = "0x822CB90", VA = "0x18822DF90", Slot = "6")]
	public void JCFIDBBIPMM(OCLDEINPEGJ.PJBMIGBHLFB MMMAIEFFLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x822DFC0", Offset = "0x822CBC0", VA = "0x18822DFC0", Slot = "7")]
	public void LHOEAFBHNNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x822DA90", Offset = "0x822C690", VA = "0x18822DA90", Slot = "8")]
	public void AOFJGLLMHFH(object PJIJGMLMHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x822DC10", Offset = "0x822C810", VA = "0x18822DC10")]
	private void DODJFDEHJPK(GDFAENLHEKK PJIJGMLMHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x822DAF0", Offset = "0x822C6F0", VA = "0x18822DAF0", Slot = "11")]
	public void DJBBIIKCKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x822E7D0", Offset = "0x822D3D0", VA = "0x18822E7D0")]
	public IJKMHMEPDMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FBOIBCIHNLN : EMHCIGOBJDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private float CLJCGNBBDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int NOMJBOAHOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private uint DHHKCFBKMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly EPOECJPKADK CEKMKFPLHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public OCKEHJCPBHA IEGFEJIJKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int CFMIDFPLKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public byte[] LFIBFFHDBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private OCKEHJCPBHA DNMDNPHJOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int JBJDJBPDCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private byte[] KMBFGBKLMGD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JFLICNLPAOP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x822BED0", Offset = "0x822AAD0", VA = "0x18822BED0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x822C3D0", Offset = "0x822AFD0", VA = "0x18822C3D0")]
	public FBOIBCIHNLN(EPOECJPKADK CEKMKFPLHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x822BF00", Offset = "0x822AB00", VA = "0x18822BF00", Slot = "5")]
	public bool FNEHNJHAFGD(OCKEHJCPBHA ACLFBNHJPDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x822BF40", Offset = "0x822AB40", VA = "0x18822BF40", Slot = "6")]
	public void GLDNKJDIMCO(OCKEHJCPBHA ACLFBNHJPDH, CMODEHBMKPA CGMEIBHKOMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x822C2C0", Offset = "0x822AEC0", VA = "0x18822C2C0")]
	internal CDBOINLGMGI MFJPHGBJGPA(NGGNPFPFPHL HBFAGGPFDBN, CMODEHBMKPA FCFBPELPJNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x822C0F0", Offset = "0x822ACF0", VA = "0x18822C0F0")]
	private static void LNHHBBFJJOJ(CDBOINLGMGI CDGDEPGDFHP, CMODEHBMKPA FCFBPELPJNJ, OCKEHJCPBHA LDGPPJNNOMK, byte[] HAPOFGGDNGL, int BMOCCOKCPNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[RegisterService(typeof(OAFGDNABCMF), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class OAFGDNABCMF : ABJONLICPGP, HHIKJEGILJH, IBPJLLPNJDI
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly Hashtable AOEKCKMBAKF;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly Hashtable NIJCFPLDFFE;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly Hashtable GDIGDBPBNNH;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly OEINLGFEHLC KOPLHHAMFPJ;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly OEINLGFEHLC HMEJJLHJAKF;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly OEINLGFEHLC FCNJANKMJKE;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly OEINLGFEHLC JLBBEPNMAEH;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly OEINLGFEHLC EPKPOCHMEGD;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int EDHPGCBBKAE;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x823A3F0", Offset = "0x8238FF0", VA = "0x18823A3F0", Slot = "4")]
	public bool KHHJFBMDHEH(PNMEEJKMDEB KCHMACEBLIA, bool IPGKPJBCINO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8239740", Offset = "0x8238340", VA = "0x188239740", Slot = "5")]
	public int IDOMHJNNCJN(PNMEEJKMDEB[] MLDGDAABNCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8238D30", Offset = "0x8237930", VA = "0x188238D30", Slot = "6")]
	public bool AMGNNDMCCFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8239B00", Offset = "0x8238700", VA = "0x188239B00", Slot = "7")]
	public bool JLJNPGOAPKK(int ECLEFOAKJDA, int ONCCMIGFIIN, bool ANCJCHDFDLL, GameObject HLOIBGDKPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8238DC0", Offset = "0x82379C0", VA = "0x188238DC0", Slot = "8")]
	public void BFCFONNKADG(int ONCCMIGFIIN, [Optional] int? IGJKPDOPFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8239CA0", Offset = "0x82388A0", VA = "0x188239CA0", Slot = "9")]
	public bool KHDCJLAJAOG(GDFAENLHEKK CKGMOBNFAKG, [Out] PNMEEJKMDEB NFMFDKGGOPC, bool DGDFOFIDOPB = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8239170", Offset = "0x8237D70", VA = "0x188239170", Slot = "10")]
	public bool FLFHCCOAJFP(GDFAENLHEKK CKGMOBNFAKG, [Out] int MIFICPGEIIP, [Out] PNMEEJKMDEB[] MLDGDAABNCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x823A530", Offset = "0x8239130", VA = "0x18823A530", Slot = "11")]
	public bool MJAIHIIDOLP(GDFAENLHEKK CKGMOBNFAKG, [Out] int ONCCMIGFIIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x823AD70", Offset = "0x8239970", VA = "0x18823AD70", Slot = "12")]
	public void PLLGICGPOPC(GDFAENLHEKK CKGMOBNFAKG, [Out] int FOEHBGEBKPC, [Out] int[] MDJJDINMALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8239530", Offset = "0x8238130", VA = "0x188239530", Slot = "13")]
	public void GGNOGLOFDFP(int MIFICPGEIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8239050", Offset = "0x8237C50", VA = "0x188239050", Slot = "14")]
	public void FFGOJBBBLAP(int MIFICPGEIIP, int[] MDJJDINMALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8239690", Offset = "0x8238290", VA = "0x188239690", Slot = "15")]
	public void GPNGAKFOAON(int[] MDJJDINMALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x823AA90", Offset = "0x8239690", VA = "0x18823AA90", Slot = "16")]
	public void PFGPPJNNDAB(int[] MDJJDINMALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x823AB60", Offset = "0x8239760", VA = "0x18823AB60", Slot = "17")]
	public void PIOFKNILLED(int MIFICPGEIIP, int ONCCMIGFIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x823A650", Offset = "0x8239250", VA = "0x18823A650")]
	private static void NHJNGFEBKIH(PNMEEJKMDEB KCHMACEBLIA, Hashtable IKFHBKIOPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8239E10", Offset = "0x8238A10", VA = "0x188239E10")]
	private static bool KHDCJLAJAOG(Hashtable IKFHBKIOPJJ, PLCCGHEKGIM IFCMDBPBLCL, [Out] PNMEEJKMDEB NFMFDKGGOPC, bool DGDFOFIDOPB = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8239450", Offset = "0x8238050", VA = "0x188239450")]
	private static int GDPPMHKGDGE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x823ACD0", Offset = "0x82398D0", VA = "0x18823ACD0", Slot = "18")]
	public void PLHNEJELPBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8238FB0", Offset = "0x8237BB0", VA = "0x188238FB0", Slot = "19")]
	public void DJBBIIKCKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public OAFGDNABCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(KGHMNKBEDNI), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class KGHMNKBEDNI : GHOKPBGIIHC, HHIKJEGILJH, IBPJLLPNJDI
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static Hashtable EGJAOMHBEFE;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static Hashtable HMDCJEKIEBA;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static OEINLGFEHLC IAJNFICNPCK;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly OEINLGFEHLC NDOCEMGFNAN;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x822E8B0", Offset = "0x822D4B0", VA = "0x18822E8B0", Slot = "4")]
	public void ACMPKGNPFJB(ViewId ECLEFOAKJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x822EF70", Offset = "0x822DB70", VA = "0x18822EF70", Slot = "5")]
	public bool BFHJAJKKLEI(GDFAENLHEKK CKGMOBNFAKG, [Out] ViewId ECLEFOAKJDA, [Out] string IEFFJAPJBDG, [Out] int CPGGDKBEPKI, [Out] object[] HPGHIMFEEID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x822E9A0", Offset = "0x822D5A0", VA = "0x18822E9A0", Slot = "6")]
	public void AKPLDDCLDKD(ViewId CDNODGDIFHH, string IEFFJAPJBDG, GMGKCOMLIHF CKFJPNMCHND, PLCCGHEKGIM FANAFCDPEEP, MOEJDFAPMAA OKDAKIFDNBD, object[] KCHMACEBLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x822F2D0", Offset = "0x822DED0", VA = "0x18822F2D0", Slot = "8")]
	public void DJBBIIKCKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x822F370", Offset = "0x822DF70", VA = "0x18822F370", Slot = "7")]
	public void PLHNEJELPBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public KGHMNKBEDNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LIGMEGGMBJK
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x822F690", Offset = "0x822E290", VA = "0x18822F690")]
	public static PLCCGHEKGIM AKDGDENNAEL(this MKFFFMAICOP LHBOIGHHIJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x822F720", Offset = "0x822E320", VA = "0x18822F720")]
	public static MKFFFMAICOP FENPPBDFDKJ(this PLCCGHEKGIM FANAFCDPEEP)
	{
		return default(MKFFFMAICOP);
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class RRNetworkBehavior : MonoBehaviour, JOCJMDNHGPE, NJMPDLBKJDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool networkedViewInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private RRNetworkView networkedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<ODEODKBNNCJ> destroyHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private bool isForwarderRegistered;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId OENOEBEDEKI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x823BAC0", Offset = "0x823A6C0", VA = "0x18823BAC0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId AIGFCOAJIPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x823BAC0", Offset = "0x823A6C0", VA = "0x18823BAC0", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView IECIOIOJDMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x823BB40", Offset = "0x823A740", VA = "0x18823BB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView HABLGGMFJNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x823BB40", Offset = "0x823A740", VA = "0x18823BB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public PLCCGHEKGIM AKMCLDDFMJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x823BC40", Offset = "0x823A840", VA = "0x18823BC40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public PLCCGHEKGIM JAOGNEOIMGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x823BFA0", Offset = "0x823ABA0", VA = "0x18823BFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool PMPJABONKBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x823BDA0", Offset = "0x823A9A0", VA = "0x18823BDA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool CMDHGJFJHFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x823BF10", Offset = "0x823AB10", VA = "0x18823BF10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool IKGCJGDPAJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x823B9F0", Offset = "0x823A5F0", VA = "0x18823B9F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool LKNPNINHCID
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x823BCD0", Offset = "0x823A8D0", VA = "0x18823BCD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool AIHCABJGCKC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x823B9F0", Offset = "0x823A5F0", VA = "0x18823B9F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool CDEKABIGDBI
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x823BA70", Offset = "0x823A670", VA = "0x18823BA70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string CHGFHHJIEME
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x823BBB0", Offset = "0x823A7B0", VA = "0x18823BBB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool KDMGCBIPPON
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x823B970", Offset = "0x823A570", VA = "0x18823B970", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<PLCCGHEKGIM> CBDNGOBGGEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x823B840", Offset = "0x823A440", VA = "0x18823B840")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x823C030", Offset = "0x823AC30", VA = "0x18823C030")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x823B7A0", Offset = "0x823A3A0", VA = "0x18823B7A0")]
		public bool WasSpawnedForPlayer(int CNECGCDGCNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x754D9C0", Offset = "0x754C5C0", VA = "0x18754D9C0")]
		private void CMIMGPCOBMA(RRNetworkView HPNKJCMLGMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x823B380", Offset = "0x8239F80", VA = "0x18823B380", Slot = "9")]
		public void RegisterDestroyHandler(ODEODKBNNCJ NOMKKKJDNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x823B5D0", Offset = "0x823A1D0", VA = "0x18823B5D0", Slot = "10")]
		public void UnregisterDestroyHandler(ODEODKBNNCJ NOMKKKJDNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x823B360", Offset = "0x8239F60", VA = "0x18823B360", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		public RRNetworkBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ACKOHOLGFOB
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void OFMONBBAAFN([In] PNMEEJKMDEB KCHMACEBLIA, bool PFOGMIDIHLD, bool IKFHBKIOPJJ, bool AEOHGJBPNOG);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void JBEEJKAGHLL(GameObject JDCKHFIIKIH);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void PDDCEMMLNLP(GameObject JDCKHFIIKIH);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void HLHLBBAHKOO(RRNetworkView CDNODGDIFHH, string IEFFJAPJBDG, PLCCGHEKGIM HPFELNLMLAB, GMGKCOMLIHF? ADGCHNLKFKK, bool ACCJILEJNBO, MOEJDFAPMAA HMMJNMNHAID, object[] KCHMACEBLIA, string OAFCNHJJABP);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate void CBFMAMOKHPH(RRNetworkView CDNODGDIFHH, string IEFFJAPJBDG, PLCCGHEKGIM HPFELNLMLAB, GMGKCOMLIHF? ADGCHNLKFKK, bool ACCJILEJNBO, MOEJDFAPMAA HMMJNMNHAID, object[] KCHMACEBLIA, string OAFCNHJJABP);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void LEOJJNCJDAM(RRNetworkView CDNODGDIFHH, string IEFFJAPJBDG, object[] HPGHIMFEEID, string FICCIMFKDLO);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void JOPCDLMNBLN(RRNetworkView CDNODGDIFHH, PLCCGHEKGIM OOKBDGAKMNC);

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[CompilerGenerated]
	private static JBEEJKAGHLL DFCJCLGNLFL;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event OFMONBBAAFN MHNDPBDJODF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x82226B0", Offset = "0x82212B0", VA = "0x1882226B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8221C50", Offset = "0x8220850", VA = "0x188221C50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event JBEEJKAGHLL OKHAHJGKGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8222C20", Offset = "0x8221820", VA = "0x188222C20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8222530", Offset = "0x8221130", VA = "0x188222530")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event PDDCEMMLNLP PAHEFAKGIHA
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8222230", Offset = "0x8220E30", VA = "0x188222230")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8221DD0", Offset = "0x82209D0", VA = "0x188221DD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public static event PDDCEMMLNLP AFEIAKCINNE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x82223B0", Offset = "0x8220FB0", VA = "0x1882223B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8222A10", Offset = "0x8221610", VA = "0x188222A10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public static event HLHLBBAHKOO NPKJKHOGLHP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8222170", Offset = "0x8220D70", VA = "0x188222170")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8221E90", Offset = "0x8220A90", VA = "0x188221E90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public static event CBFMAMOKHPH CMKGKBMAPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8221990", Offset = "0x8220590", VA = "0x188221990")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8221A50", Offset = "0x8220650", VA = "0x188221A50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event LEOJJNCJDAM BDFPDLOHLID
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x82222F0", Offset = "0x8220EF0", VA = "0x1882222F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8221D10", Offset = "0x8220910", VA = "0x188221D10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public static event JOPCDLMNBLN AMKPPFBIMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8222CE0", Offset = "0x82218E0", VA = "0x188222CE0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8222470", Offset = "0x8221070", VA = "0x188222470")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event JOPCDLMNBLN NPADEDNACOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x82225F0", Offset = "0x82211F0", VA = "0x1882225F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8222950", Offset = "0x8221550", VA = "0x188222950")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8222800", Offset = "0x8221400", VA = "0x188222800")]
	public static void LGEAPIFADKC([In] PNMEEJKMDEB KCHMACEBLIA, bool PFOGMIDIHLD, bool IKFHBKIOPJJ, bool AEOHGJBPNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x82228C0", Offset = "0x82214C0", VA = "0x1882228C0")]
	public static void LOGLKCNMONJ(GameObject JDCKHFIIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8221F50", Offset = "0x8220B50", VA = "0x188221F50")]
	public static void EJLNPOOIBIK(GameObject JDCKHFIIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8221FE0", Offset = "0x8220BE0", VA = "0x188221FE0")]
	public static void FJFEDFGNCEK(GameObject JDCKHFIIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8222770", Offset = "0x8221370", VA = "0x188222770")]
	public static void KFDPJCCIAOJ(GameObject JDCKHFIIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8222AD0", Offset = "0x82216D0", VA = "0x188222AD0")]
	public static void NGEOBHIKCGL(RRNetworkView CDNODGDIFHH, string IEFFJAPJBDG, PLCCGHEKGIM HPFELNLMLAB, GMGKCOMLIHF? ADGCHNLKFKK, bool ACCJILEJNBO, MOEJDFAPMAA HMMJNMNHAID, object[] KCHMACEBLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8221B10", Offset = "0x8220710", VA = "0x188221B10")]
	public static void COOFCOPCCGO(RRNetworkView CDNODGDIFHH, string IEFFJAPJBDG, int KOMEBJJKBKK, object[] HPGHIMFEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8222070", Offset = "0x8220C70", VA = "0x188222070")]
	public static void FKOMAMJLJIB(int ECLEFOAKJDA, int LHBOIGHHIJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class MLDMKNNNFKG
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x822F9D0", Offset = "0x822E5D0", VA = "0x18822F9D0")]
	[CanBeNull]
	private static bool JBGMOGNNPPF(ViewId OIBGADINDDP, [Out] RRNetworkView CDNODGDIFHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x822FB50", Offset = "0x822E750", VA = "0x18822FB50")]
	[CanBeNull]
	public static Component LKMJPCFLCFO(this ViewId CDNODGDIFHH, Type EPFOOLJELNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3D595D0", Offset = "0x3D581D0", VA = "0x183D595D0")]
	[CanBeNull]
	public static T LKMJPCFLCFO<T>(this ViewId CDNODGDIFHH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3D595D0", Offset = "0x3D581D0", VA = "0x183D595D0")]
	[CanBeNull]
	public static T LJECLKNDJFN<T>(this ViewId CDNODGDIFHH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D59560", Offset = "0x3D58160", VA = "0x183D59560")]
	public static bool AEPBAEHBMHM<T>(this ViewId CDNODGDIFHH, [Out] T ABEFNIJCBBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x822FA80", Offset = "0x822E680", VA = "0x18822FA80")]
	[CanBeNull]
	public static RRNetworkView JNEMPJOELIO(this ViewId CDNODGDIFHH)
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
		private static RRNetworkHandler MIOFGENCPDE;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler MFAGMJBMEEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x823C160", Offset = "0x823AD60", VA = "0x18823C160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x823C330", Offset = "0x823AF30", VA = "0x18823C330")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x823C2F0", Offset = "0x823AEF0", VA = "0x18823C2F0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		public RRNetworkHandler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(NFIHPPPOJEO), new string[] { "Photon" })]
public sealed class NFIHPPPOJEO : IDDLHPNNHCM, HHIKJEGILJH, IBPJLLPNJDI, EHGHELAPGBD, HFOOIEJDCCF
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KPAOIHJBCMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int requestedViewId;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public KPAOIHJBCMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x822F5D0", Offset = "0x822E1D0", VA = "0x18822F5D0")]
		internal object BHNMLBFCOPG((int requestedViewId, int newOwnerId, int senderId) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static PEOHNMCPNIJ AHDMNAFEGGF;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static PEOHNMCPNIJ NGDOANCMEOF;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static Dictionary<int, HashSet<int>> LPBIODEKHEO;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static Dictionary<int, int> LDHBCCKNHJI;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<(GameObject GameObject, int ParentCount)> KGCEDCCFJCG;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<GameObject> IKOOCAACEME;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static List<int> BAGIJIHIAFC;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<RRNetworkView> MNKLMBDBFEP;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly OEINLGFEHLC JLBBEPNMAEH;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly OEINLGFEHLC EPKPOCHMEGD;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8237D70", Offset = "0x8236970", VA = "0x188237D70", Slot = "8")]
	public void PLHNEJELPBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8230A20", Offset = "0x822F620", VA = "0x188230A20", Slot = "9")]
	public void DJBBIIKCKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x82353E0", Offset = "0x8233FE0", VA = "0x1882353E0", Slot = "10")]
	public void InitExternal(MDHHMAKNOBB HKAENDMEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8237BA0", Offset = "0x82367A0", VA = "0x188237BA0", Slot = "11")]
	public void OPOAIGHCBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x82375C0", Offset = "0x82361C0", VA = "0x1882375C0")]
	private void OHLHBKJPJME(LGFKOPKNACM DLOJGDHFIKP, LGFKOPKNACM EKPDKNLBIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x82374C0", Offset = "0x82360C0", VA = "0x1882374C0")]
	private void NHCNELMMEKB(GEBOIIDFPFP CHDALOGLLPI, GEBOIIDFPFP GMLGCKAOGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8232190", Offset = "0x8230D90", VA = "0x188232190")]
	public GameObject EOGCGKGAFGC(string BKILENEPEEB, Vector3 FEMJLOIOGIK, Quaternion DINDLKHALMD, Vector3 ECJMFFOLCCL, ViewId ECLEFOAKJDA, MJAPGGNPMGD KCHMACEBLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8238240", Offset = "0x8236E40", VA = "0x188238240")]
	public GameObject POGBEBNAIBP(string BKILENEPEEB, Vector3 FEMJLOIOGIK, Quaternion DINDLKHALMD, float ECJMFFOLCCL, object[] KCHMACEBLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8236020", Offset = "0x8234C20", VA = "0x188236020")]
	public GameObject LDOBKCJCEGP(string BKILENEPEEB, Vector3 FEMJLOIOGIK, Quaternion DINDLKHALMD, Vector3 ECJMFFOLCCL, ViewId CDNODGDIFHH, MJAPGGNPMGD KCHMACEBLIA, bool AEOHGJBPNOG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x82362B0", Offset = "0x8234EB0", VA = "0x1882362B0")]
	public GameObject LMKKOFMAIJF(PNMEEJKMDEB KCHMACEBLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8234E20", Offset = "0x8233A20", VA = "0x188234E20", Slot = "6")]
	public void HDFLAEEGHBO(GameObject JDCKHFIIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8235D50", Offset = "0x8234950", VA = "0x188235D50")]
	public void KKPHAPOJGCN(GameObject HLOIBGDKPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8235DC0", Offset = "0x82349C0", VA = "0x188235DC0", Slot = "7")]
	public void KLCKPKPEMIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8230690", Offset = "0x822F290", VA = "0x188230690", Slot = "4")]
	public GameObject[] CEIEJPLMPBK(IList<HCMBAAIOIJI> BJKHAGFNLGH, bool DEHAALJLHGF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x82370E0", Offset = "0x8235CE0", VA = "0x1882370E0", Slot = "5")]
	public void MECFCPMNDIM(List<GameObject> PDNPOCECEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8234E30", Offset = "0x8233A30", VA = "0x188234E30")]
	public void HHOOJEJPKIA(GameObject HLOIBGDKPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x82312F0", Offset = "0x822FEF0", VA = "0x1882312F0")]
	private void DODJFDEHJPK(GDFAENLHEKK CKGMOBNFAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8236F10", Offset = "0x8235B10", VA = "0x188236F10")]
	private void MCAPJKOONKC(GDFAENLHEKK CKGMOBNFAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8234F10", Offset = "0x8233B10", VA = "0x188234F10")]
	private void HMPHNIMMJMD(GDFAENLHEKK CKGMOBNFAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x822FFF0", Offset = "0x822EBF0", VA = "0x18822FFF0")]
	private void BOLIFFKBAAF(GDFAENLHEKK CKGMOBNFAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x82302D0", Offset = "0x822EED0", VA = "0x1882302D0")]
	private void CCOHPDONFHB(GDFAENLHEKK CKGMOBNFAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8234620", Offset = "0x8233220", VA = "0x188234620")]
	private void GMDOCMLPMFP(GDFAENLHEKK CKGMOBNFAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8232370", Offset = "0x8230F70", VA = "0x188232370")]
	private void FDAIFBOLKKA(GDFAENLHEKK CKGMOBNFAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8235DD0", Offset = "0x82349D0", VA = "0x188235DD0")]
	private GameObject LBJPMOGPIOK(string HNHFKFKDOJD, Vector3 FEMJLOIOGIK, Quaternion DINDLKHALMD, Vector3 ECJMFFOLCCL, byte KAPGMCDEGPH = 0, [Optional] object[] CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8235650", Offset = "0x8234250", VA = "0x188235650")]
	private GameObject KBPMLIBFOFA(PNMEEJKMDEB KCHMACEBLIA, bool PFOGMIDIHLD = false, bool IKFHBKIOPJJ = false, bool AEOHGJBPNOG = true, bool CGCHLAJOEBG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x822FC30", Offset = "0x822E830", VA = "0x18822FC30")]
	private static GameObject AHNJCOHIJOL(string HNHFKFKDOJD, bool FNIGMJNFIDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8237990", Offset = "0x8236590", VA = "0x188237990")]
	private static GameObject OOCKEHDNIEJ(GameObject JBPODHEOMGI, PNMEEJKMDEB KCHMACEBLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x82352D0", Offset = "0x8233ED0", VA = "0x1882352D0")]
	private static void INLPIEAHFMN(GameObject JDCKHFIIKIH, RRNetworkView CDNODGDIFHH, [In] PNMEEJKMDEB KCHMACEBLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8233970", Offset = "0x8232570", VA = "0x188233970")]
	private GameObject[] FJPNNGMDPAG(IList<HCMBAAIOIJI> BJKHAGFNLGH, bool DEHAALJLHGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x82376E0", Offset = "0x82362E0", VA = "0x1882376E0")]
	private GameObject[] OMKHAHEPMAG(PNMEEJKMDEB[] MLDGDAABNCF, int MIFICPGEIIP, PLCCGHEKGIM FANAFCDPEEP, GameObject[] CNFKEOECNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8234210", Offset = "0x8232E10", VA = "0x188234210")]
	private GameObject GAJPCIOCJEI([In] PNMEEJKMDEB KCHMACEBLIA, GameObject JBPODHEOMGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x752FD40", Offset = "0x752E940", VA = "0x18752FD40")]
	private static bool NDINIIEIAGE(bool PFOGMIDIHLD, bool AEOHGJBPNOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x82362E0", Offset = "0x8234EE0", VA = "0x1882362E0")]
	private void LPHBNKKFNLL(IEnumerable<GameObject> PDNPOCECEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8232A40", Offset = "0x8231640", VA = "0x188232A40")]
	private void FIIECEIPBFG(GameObject JDCKHFIIKIH, bool CGCHLAJOEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8234A20", Offset = "0x8233620", VA = "0x188234A20")]
	private static void GPJHMLFOHHE(IEnumerable<GameObject> DFJMOEDAKAE, List<(GameObject GameObject, int ParentCount)> DPLLGEPKJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x82380E0", Offset = "0x8236CE0", VA = "0x1882380E0")]
	private void PNIOOILPOJN(int ONCCMIGFIIN, int MIFICPGEIIP, bool CGCHLAJOEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x82355B0", Offset = "0x82341B0", VA = "0x1882355B0")]
	private static int JBOBAJIIMMF(int ONCCMIGFIIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8235FC0", Offset = "0x8234BC0", VA = "0x188235FC0")]
	private void LCLOHFJBHDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8230DA0", Offset = "0x822F9A0", VA = "0x188230DA0")]
	private void DLAMODGDGLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x82309C0", Offset = "0x822F5C0", VA = "0x1882309C0")]
	private static int CEKCPLIGDIF(int DMHKKDPIOJB, bool AEOHGJBPNOG = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x82320B0", Offset = "0x8230CB0", VA = "0x1882320B0")]
	private static int[] EOEBGJMGBGA(int MKJFKDKHKMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x822FEF0", Offset = "0x822EAF0", VA = "0x18822FEF0")]
	private static int[] BDGEBDDDHOA(int JAOGNEOIMGK, int MKJFKDKHKMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8232A00", Offset = "0x8231600", VA = "0x188232A00")]
	private void FFEJIBNHGKG(PLCCGHEKGIM KFDOAKEPDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x82315F0", Offset = "0x82301F0", VA = "0x1882315F0")]
	private void DOMLADOJDAP(PLCCGHEKGIM FANAFCDPEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8231DD0", Offset = "0x82309D0", VA = "0x188231DD0")]
	private void EALNOHPHPEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x822FCB0", Offset = "0x822E8B0", VA = "0x18822FCB0")]
	private void BBKFJAONCFJ(PLCCGHEKGIM FANAFCDPEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8234170", Offset = "0x8232D70", VA = "0x188234170")]
	private static void FNJDKFJJNBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x82351D0", Offset = "0x8233DD0", VA = "0x1882351D0")]
	private void HPHGNCGANLO(int[] JOMMLAPBLBE, int BGCLOAJFHOF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public NFIHPPPOJEO()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		public RRNetworkProfiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(CENGHOHBJED), new string[] { "Photon" })]
public class CENGHOHBJED : HHIKJEGILJH, IBPJLLPNJDI, OAPGHPKDKBP
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct AEOBJPPJIBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly MethodInfo GJNLDAKNOGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly Func<MonoBehaviour, object> MFECAFIFBLE;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xBCEBD0", Offset = "0xBCD7D0", VA = "0x180BCEBD0")]
		public AEOBJPPJIBJ(MethodInfo GJNLDAKNOGK, [Optional] Func<MonoBehaviour, object> MFECAFIFBLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x751CB90", Offset = "0x751B790", VA = "0x18751CB90")]
		public object GIEDNMGFJEF(MonoBehaviour CBBOJCMMLJF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class HGMDADMGOMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public FieldInfo instanceAccessFromField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<MonoBehaviour, object> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public HGMDADMGOMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x822D600", Offset = "0x822C200", VA = "0x18822D600")]
		internal AEOBJPPJIBJ MNNGJJMKLDB(MethodInfo methodInfo)
		{
			return default(AEOBJPPJIBJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4976590", Offset = "0x4975190", VA = "0x184976590")]
		internal object CDECBODMCGH(MonoBehaviour mb)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class OGPIICOPNJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Func<MonoBehaviour, object> accessor;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public OGPIICOPNJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x751B940", Offset = "0x751A540", VA = "0x18751B940")]
		internal AEOBJPPJIBJ JDDGAJKLDJJ(MethodInfo methodInfo)
		{
			return default(AEOBJPPJIBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class HKJNNHPKECH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Type attributeType;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public HKJNNHPKECH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x822D730", Offset = "0x822C330", VA = "0x18822D730")]
		internal bool AACOHGIHENB(MethodInfo m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly Stopwatch HHOHAFGPAOJ;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Dictionary<MethodInfo, ParameterInfo[]> EFOOBLIEJIP;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly Dictionary<Type, List<AEOBJPPJIBJ>> EJIDDLMNDFF;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8229380", Offset = "0x8227F80", VA = "0x188229380", Slot = "4")]
	public void PLHNEJELPBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8225B10", Offset = "0x8224710", VA = "0x188225B10", Slot = "5")]
	public void DJBBIIKCKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8225C60", Offset = "0x8224860", VA = "0x188225C60")]
	private void DODJFDEHJPK(GDFAENLHEKK CKGMOBNFAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8225F10", Offset = "0x8224B10", VA = "0x188225F10", Slot = "9")]
	public string FJBANJDKFDA(GDFAENLHEKK CKGMOBNFAKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8225820", Offset = "0x8224420", VA = "0x188225820", Slot = "8")]
	public void ACMPKGNPFJB(ViewId ECLEFOAKJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8228880", Offset = "0x8227480", VA = "0x188228880", Slot = "6")]
	public void JKNJDBJPEPO(ViewId CDNODGDIFHH, string IEFFJAPJBDG, PLCCGHEKGIM FANAFCDPEEP, MOEJDFAPMAA HMMJNMNHAID, params object[] KCHMACEBLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8228850", Offset = "0x8227450", VA = "0x188228850", Slot = "7")]
	public void JKNJDBJPEPO(ViewId CDNODGDIFHH, string IEFFJAPJBDG, GMGKCOMLIHF ADGCHNLKFKK, MOEJDFAPMAA HMMJNMNHAID, params object[] KCHMACEBLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8228370", Offset = "0x8226F70", VA = "0x188228370")]
	private void JKNJDBJPEPO(ViewId CDNODGDIFHH, string IEFFJAPJBDG, GMGKCOMLIHF ADGCHNLKFKK, PLCCGHEKGIM FANAFCDPEEP, MOEJDFAPMAA HMMJNMNHAID, params object[] KCHMACEBLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8226630", Offset = "0x8225230", VA = "0x188226630")]
	private void JDBINFDALCL(ViewId ECLEFOAKJDA, string IEFFJAPJBDG, PLCCGHEKGIM NGJLHELIFON, int CPGGDKBEPKI, object[] HPGHIMFEEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8226170", Offset = "0x8224D70", VA = "0x188226170")]
	private static void HPCMIHMFPAF(AEOBJPPJIBJ OBAAMCMFDIE, MonoBehaviour HGEJFBLIHDG, object[] AHEPAEIEJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8225F40", Offset = "0x8224B40", VA = "0x188225F40")]
	private static bool HKIOLBOCAKH(ParameterInfo[] BGHAPJFFNOA, Type[] JBNDDBKLILA, [Out] bool PKOOAKAIJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8228950", Offset = "0x8227550", VA = "0x188228950")]
	private List<AEOBJPPJIBJ> NDPBCNBPCPM(MonoBehaviour HGEJFBLIHDG, Type LBFLEICELGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8225A10", Offset = "0x8224610", VA = "0x188225A10")]
	private static IEnumerable<MethodInfo> DHHAGFIHABI(Type MDCDODCGNEK, Type KIHCDFGNJBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x8225900", Offset = "0x8224500", VA = "0x188225900")]
	public static ParameterInfo[] BBHGMNHODDL(MethodInfo DMDADCIFOKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public CENGHOHBJED()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, JJDJNNFCKLB, CIOKMEBIAHA, LLJCFEBNCHJ, OFHCPBDAGAI, CHCMEDNOJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum ONHLLCBIGEE
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
		private sealed class HIPDIHEEIMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public int actorNumber;

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public HIPDIHEEIMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x822D6D0", Offset = "0x822C2D0", VA = "0x18822D6D0")]
			internal bool PPENMOBJKEL(RRNetworkView view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static Dictionary<int, RRNetworkView> EMHCGEIMAKG;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static OEINLGFEHLC MDGEPGJOIFO;

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
		private bool FKEHMPLILNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		internal bool CLGBNNDMHAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Tooltip("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		[SerializeField]
		public ONHLLCBIGEE hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool DECMMHBHADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool CIHOIOKONBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int LGHBAHBGELF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private bool FLMKBAKNMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int JPDDECMOCPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private PLCCGHEKGIM JAOGNEOIMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private PLCCGHEKGIM OBLMFNNOGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool? MODJMBLBFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool IFACGDKCEHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		internal bool OMDFJDCOOAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		internal MonoBehaviour[] HPCBKOJMDNF;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly PEOHNMCPNIJ DHFNHHLGPFD;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ViewId AIGFCOAJIPC
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x82415F0", Offset = "0x82401F0", VA = "0x1882415F0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ViewId HJFBHEKPKEL
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x82415F0", Offset = "0x82401F0", VA = "0x1882415F0", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId OENOEBEDEKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x82415F0", Offset = "0x82401F0", VA = "0x1882415F0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int PJMLLAPLEOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xA5EBA0", Offset = "0xA5D7A0", VA = "0x180A5EBA0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xA5FCA0", Offset = "0xA5E8A0", VA = "0x180A5FCA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int GBCFHAHFBMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA85600", Offset = "0xA84200", VA = "0x180A85600")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xE7F020", Offset = "0xE7DC20", VA = "0x180E7F020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ViewId AJIOBELHGIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8241460", Offset = "0x8240060", VA = "0x188241460")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool ANCJCHDFDLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A350", VA = "0x180A5B750")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xA5B510", Offset = "0xA5A110", VA = "0x180A5B510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool IIAGKMDMNPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x8241470", Offset = "0x8240070", VA = "0x188241470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool PMICCKECDFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xAC0B50", Offset = "0xABF750", VA = "0x180AC0B50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0880", Offset = "0xABF480", VA = "0x180AC0880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int MMGKNCPODFK
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAAD070", Offset = "0xAABC70", VA = "0x180AAD070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int KPAOFADBPNL
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8241400", Offset = "0x8240000", VA = "0x188241400")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public PLCCGHEKGIM ABPDPFDBHDN
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8241600", Offset = "0x8240200", VA = "0x188241600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public PLCCGHEKGIM LDNBDCEFCKI
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x82413D0", Offset = "0x823FFD0", VA = "0x1882413D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public PLCCGHEKGIM AKMCLDDFMJM
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x82413D0", Offset = "0x823FFD0", VA = "0x1882413D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public PLCCGHEKGIM BMHJLHIHBDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x82413D0", Offset = "0x823FFD0", VA = "0x1882413D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool OBILHHDBDKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x8241540", Offset = "0x8240140", VA = "0x188241540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public int OKJLHPMOMIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8241430", Offset = "0x8240030", VA = "0x188241430")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public object[] BEEODFJNOMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA5B690", Offset = "0xA5A290", VA = "0x180A5B690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA5B550", Offset = "0xA5A150", VA = "0x180A5B550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool PMPJABONKBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8241630", Offset = "0x8240230", VA = "0x188241630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool OPOHAPMALBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x82415C0", Offset = "0x82401C0", VA = "0x1882415C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool PJIDGBEFLKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xE4A5F0", Offset = "0xE491F0", VA = "0x180E4A5F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xFB5510", Offset = "0xFB4110", VA = "0x180FB5510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool JHBJJHAFIOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xCEA630", Offset = "0xCE9230", VA = "0x180CEA630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> KBJJLHELCAE
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x8241270", Offset = "0x823FE70", VA = "0x188241270")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x82417F0", Offset = "0x82403F0", VA = "0x1882417F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<PLCCGHEKGIM> AGLBILNIOON
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x823CD20", Offset = "0x823B920", VA = "0x18823CD20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x823C3D0", Offset = "0x823AFD0", VA = "0x18823C3D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<PLCCGHEKGIM> HMCDLPICOMI
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x823CD20", Offset = "0x823B920", VA = "0x18823CD20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x823C3D0", Offset = "0x823AFD0", VA = "0x18823C3D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> JCICGGKLIAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x823E260", Offset = "0x823CE60", VA = "0x18823E260")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x823D0E0", Offset = "0x823BCE0", VA = "0x18823D0E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> IHDCOBOBMFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x823E260", Offset = "0x823CE60", VA = "0x18823E260")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x823D0E0", Offset = "0x823BCE0", VA = "0x18823D0E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> KHHHAFOOGGL
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x8241320", Offset = "0x823FF20", VA = "0x188241320")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x82418A0", Offset = "0x82404A0", VA = "0x1882418A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action JBBHEGLLAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x82411C0", Offset = "0x823FDC0", VA = "0x1882411C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8241740", Offset = "0x8240340", VA = "0x188241740")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8240FF0", Offset = "0x823FBF0", VA = "0x188240FF0")]
		public static bool TryGetNetworkView(int ECLEFOAKJDA, [Out] RRNetworkView CDNODGDIFHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x823CAC0", Offset = "0x823B6C0", VA = "0x18823CAC0")]
		public static RRNetworkView Find(int ECLEFOAKJDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x823CE40", Offset = "0x823BA40", VA = "0x18823CE40")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int MJABLPKNAHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x823CDD0", Offset = "0x823B9D0", VA = "0x18823CDD0")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x823E760", Offset = "0x823D360", VA = "0x18823E760")]
		public static bool RemoveNetworkView(RRNetworkView CDNODGDIFHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x823E530", Offset = "0x823D130", VA = "0x18823E530")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x823DE70", Offset = "0x823CA70", VA = "0x18823DE70")]
		public static void OnPlayerJoinedRoom(PLCCGHEKGIM PIAPLNCFGPE, List<int> JOMMLAPBLBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x823CF80", Offset = "0x823BB80", VA = "0x18823CF80")]
		public static RRNetworkView Get(Component GCOJJLDOHCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x823CFE0", Offset = "0x823BBE0", VA = "0x18823CFE0")]
		public static RRNetworkView Get(GameObject IHPPEIICEPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x823DA10", Offset = "0x823C610", VA = "0x18823DA10")]
		private void NFFJMBMLGCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x823C780", Offset = "0x823B380", VA = "0x18823C780")]
		public bool CreatedBy(PLCCGHEKGIM FANAFCDPEEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8240E00", Offset = "0x823FA00", VA = "0x188240E00")]
		public void TransferOwnership(int BFMMEPBHLIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8240DA0", Offset = "0x823F9A0", VA = "0x188240DA0")]
		public void TransferOwnership(PLCCGHEKGIM OOKBDGAKMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x823D1F0", Offset = "0x823BDF0", VA = "0x18823D1F0", Slot = "4")]
		public void Initialize(ViewId OIKNGBAFDJB, ViewId FIIADEBIMKO, Dictionary<int, object> ELIABFCDDBG, MKFFFMAICOP JAOGNEOIMGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x823D190", Offset = "0x823BD90", VA = "0x18823D190")]
		public void Initialize(ViewId OIKNGBAFDJB, ViewId FIIADEBIMKO, object[] EHDEELKCFGF, MKFFFMAICOP JAOGNEOIMGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x823C370", Offset = "0x823AF70", VA = "0x18823C370")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x823C800", Offset = "0x823B400", VA = "0x18823C800")]
		private void FBMNLNFHOAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1FE94A0", Offset = "0x1FE80A0", VA = "0x181FE94A0")]
		internal void DBBLCNIAJCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x823DAF0", Offset = "0x823C6F0", VA = "0x18823DAF0", Slot = "6")]
		private void NJFHALLFCHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x823D690", Offset = "0x823C290", VA = "0x18823D690")]
		internal bool LKGNLIBJKAH(RRNetworkView GMNPLONFDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x823DCD0", Offset = "0x823C8D0", VA = "0x18823DCD0")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x823CBD0", Offset = "0x823B7D0", VA = "0x18823CBD0")]
		internal void GDFFELNGBEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x823C480", Offset = "0x823B080", VA = "0x18823C480")]
		private void BMPFEDOMFCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x823CA00", Offset = "0x823B600", VA = "0x18823CA00")]
		internal void FNBEDMAMKHI(PLCCGHEKGIM OOKBDGAKMNC, int BFMMEPBHLIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x823E6C0", Offset = "0x823D2C0", VA = "0x18823E6C0")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x823E7E0", Offset = "0x823D3E0", VA = "0x18823E7E0")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x823DC30", Offset = "0x823C830", VA = "0x18823DC30")]
		private void OOEFGCLLFMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x823CC30", Offset = "0x823B830", VA = "0x18823CC30")]
		private void GIKKFFBBHDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x823E410", Offset = "0x823D010", VA = "0x18823E410")]
		public void RPC(string IEFFJAPJBDG, GMGKCOMLIHF ADGCHNLKFKK, params object[] KCHMACEBLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x823E4A0", Offset = "0x823D0A0", VA = "0x18823E4A0")]
		public void RPC(string IEFFJAPJBDG, PLCCGHEKGIM HPFELNLMLAB, params object[] KCHMACEBLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x823E710", Offset = "0x823D310", VA = "0x18823E710")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x823C490", Offset = "0x823B090", VA = "0x18823C490", Slot = "8")]
		public void Bake(HBNCMEMJHAL PBHLPKLGFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x823CB50", Offset = "0x823B750", VA = "0x18823CB50")]
		private static void GAIBMCHGEMO(PLCCGHEKGIM HLIHHEBAMJP, [Out] PLCCGHEKGIM EMBMBIOGHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x823D370", Offset = "0x823BF70", VA = "0x18823D370")]
		private static void KJHFMDMDDFL(RRNetworkView IECIOIOJDMB, Delegate OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x823DBB0", Offset = "0x823C7B0", VA = "0x18823DBB0")]
		private static ILALCDLDIIG ODDIDHCGKCB(RRNetworkView IECIOIOJDMB)
		{
			return default(ILALCDLDIIG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x823E1C0", Offset = "0x823CDC0", VA = "0x18823E1C0")]
		private static OJPNDDCHNHP PEHNMBBFNGP(RRNetworkView IECIOIOJDMB)
		{
			return default(OJPNDDCHNHP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x823D700", Offset = "0x823C300", VA = "0x18823D700")]
		private static void MGDGKJEHAKH(RRNetworkView IECIOIOJDMB, Delegate OBAAMCMFDIE, PLCCGHEKGIM NNMFFMMOEKL, params object[] KCHMACEBLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x823D7E0", Offset = "0x823C3E0", VA = "0x18823D7E0")]
		private static void MGDGKJEHAKH(RRNetworkView IECIOIOJDMB, Delegate OBAAMCMFDIE, GMGKCOMLIHF NNMFFMMOEKL, params object[] KCHMACEBLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x823D8C0", Offset = "0x823C4C0", VA = "0x18823D8C0")]
		private static void NCAECGAKALN(RRNetworkView IECIOIOJDMB, Delegate OBAAMCMFDIE, GMGKCOMLIHF NNMFFMMOEKL, MAGOLDLHMLF DLPAFPIEOHK, params object[] KCHMACEBLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x823E310", Offset = "0x823CF10", VA = "0x18823E310")]
		public void RPCBuffered(string IEFFJAPJBDG, GMGKCOMLIHF ADGCHNLKFKK, MAGOLDLHMLF HMMJNMNHAID, params object[] KCHMACEBLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x823D040", Offset = "0x823BC40", VA = "0x18823D040")]
		private static bool HHLGHNNLHEG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x823F090", Offset = "0x823DC90", VA = "0x18823F090", Slot = "26")]
		public void RpcAll(NNPNGKOCNDO.DJKDNFBOFCH OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3EC5A20", Offset = "0x3EC4620", VA = "0x183EC5A20", Slot = "9")]
		public void RpcAll<T1>(NNPNGKOCNDO.BPLCMOELNKD<T1> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3EC5270", Offset = "0x3EC3E70", VA = "0x183EC5270", Slot = "10")]
		public void RpcAll<T1, T2>(NNPNGKOCNDO.CIEPLPICPOA<T1, T2> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6310", Offset = "0x3EC4F10", VA = "0x183EC6310", Slot = "27")]
		public void RpcAll<T1, T2, T3>(NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, T3> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3EC5490", Offset = "0x3EC4090", VA = "0x183EC5490", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, T4> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3EE09A0", Offset = "0x3EDF5A0", VA = "0x183EE09A0", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, T5> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3EE0DD0", Offset = "0x3EDF9D0", VA = "0x183EE0DD0", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, T6> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3EE18C0", Offset = "0x3EE04C0", VA = "0x183EE18C0", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, T7> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3EE35B0", Offset = "0x3EE21B0", VA = "0x183EE35B0", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, T8> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3EE1280", Offset = "0x3EDFE80", VA = "0x183EE1280", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, T9> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3EE02D0", Offset = "0x3EDEED0", VA = "0x183EE02D0", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3EE8360", Offset = "0x3EE6F60", VA = "0x183EE8360", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3EE7870", Offset = "0x3EE6470", VA = "0x183EE7870", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3EE6090", Offset = "0x3EE4C90", VA = "0x183EE6090", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3EDF9E0", Offset = "0x3EDE5E0", VA = "0x183EDF9E0", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x823F200", Offset = "0x823DE00", VA = "0x18823F200")]
		public void RpcAll(NNPNGKOCNDO.BPLCMOELNKD<ILALCDLDIIG> OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7EE0", Offset = "0x3EC6AE0", VA = "0x183EC7EE0")]
		public void RpcAll<T1>(NNPNGKOCNDO.CIEPLPICPOA<T1, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3EC8550", Offset = "0x3EC7150", VA = "0x183EC8550")]
		public void RpcAll<T1, T2>(NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3EC5DD0", Offset = "0x3EC49D0", VA = "0x183EC5DD0")]
		public void RpcAll<T1, T2, T3>(NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3EED450", Offset = "0x3EEC050", VA = "0x183EED450")]
		public void RpcAll<T1, T2, T3, T4>(NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3EED140", Offset = "0x3EEBD40", VA = "0x183EED140")]
		public void RpcAll<T1, T2, T3, T4, T5>(NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3EEC7F0", Offset = "0x3EEB3F0", VA = "0x183EEC7F0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3EEBD90", Offset = "0x3EEA990", VA = "0x183EEBD90")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3EEAA00", Offset = "0x3EE9600", VA = "0x183EEAA00")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3EEA570", Offset = "0x3EE9170", VA = "0x183EEA570")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3EE9290", Offset = "0x3EE7E90", VA = "0x183EE9290")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3EE8870", Offset = "0x3EE7470", VA = "0x183EE8870")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3EE6CD0", Offset = "0x3EE58D0", VA = "0x183EE6CD0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3EE5A50", Offset = "0x3EE4650", VA = "0x183EE5A50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3EE4680", Offset = "0x3EE3280", VA = "0x183EE4680")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(AFOMNCEHMCJ OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x823EE60", Offset = "0x823DA60", VA = "0x18823EE60", Slot = "36")]
		public void RpcAll(NNPNGKOCNDO.BPLCMOELNKD<OJPNDDCHNHP> OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3ECD340", Offset = "0x3ECBF40", VA = "0x183ECD340", Slot = "37")]
		public void RpcAll<T1>(NNPNGKOCNDO.CIEPLPICPOA<T1, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3ECC200", Offset = "0x3ECAE00", VA = "0x183ECC200", Slot = "38")]
		public void RpcAll<T1, T2>(NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3ECBAF0", Offset = "0x3ECA6F0", VA = "0x183ECBAF0", Slot = "39")]
		public void RpcAll<T1, T2, T3>(NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3EED710", Offset = "0x3EEC310", VA = "0x183EED710", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3EECE30", Offset = "0x3EEBA30", VA = "0x183EECE30", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3EEC480", Offset = "0x3EEB080", VA = "0x183EEC480", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB650", Offset = "0x3EEA250", VA = "0x183EEB650", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB220", Offset = "0x3EE9E20", VA = "0x183EEB220", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3EE9C90", Offset = "0x3EE8890", VA = "0x183EE9C90", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3EE9790", Offset = "0x3EE8390", VA = "0x183EE9790", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3EE7E00", Offset = "0x3EE6A00", VA = "0x183EE7E00", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3EE72A0", Offset = "0x3EE5EA0", VA = "0x183EE72A0", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3EE6690", Offset = "0x3EE5290", VA = "0x183EE6690", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3EE53A0", Offset = "0x3EE3FA0", VA = "0x183EE53A0", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(AFOMNCEHMCJ OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x823EC00", Offset = "0x823D800", VA = "0x18823EC00", Slot = "51")]
		public void RpcAllViaServer(NNPNGKOCNDO.DJKDNFBOFCH OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3EDF8D0", Offset = "0x3EDE4D0", VA = "0x183EDF8D0", Slot = "52")]
		public void RpcAllViaServer<T1>(NNPNGKOCNDO.BPLCMOELNKD<T1> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7210", Offset = "0x3ED5E10", VA = "0x183ED7210", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(NNPNGKOCNDO.CIEPLPICPOA<T1, T2> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3EDF0E0", Offset = "0x3EDDCE0", VA = "0x183EDF0E0", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, T3> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE750", Offset = "0x3EDD350", VA = "0x183EDE750", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, T4> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE4F0", Offset = "0x3EDD0F0", VA = "0x183EDE4F0", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, T5> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3EDDAD0", Offset = "0x3EDC6D0", VA = "0x183EDDAD0", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, T6> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3EDD220", Offset = "0x3EDBE20", VA = "0x183EDD220", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, T7> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3EDC530", Offset = "0x3EDB130", VA = "0x183EDC530", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, T8> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3EDC190", Offset = "0x3EDAD90", VA = "0x183EDC190", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, T9> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3EDAE80", Offset = "0x3ED9A80", VA = "0x183EDAE80", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3EDA600", Offset = "0x3ED9200", VA = "0x183EDA600", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3ED9410", Offset = "0x3ED8010", VA = "0x183ED9410", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8A30", Offset = "0x3ED7630", VA = "0x183ED8A30", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8000", Offset = "0x3ED6C00", VA = "0x183ED8000", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x823ED30", Offset = "0x823D930", VA = "0x18823ED30")]
		public void RpcAllViaServer(NNPNGKOCNDO.BPLCMOELNKD<ILALCDLDIIG> OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3EDF6B0", Offset = "0x3EDE2B0", VA = "0x183EDF6B0")]
		public void RpcAllViaServer<T1>(NNPNGKOCNDO.CIEPLPICPOA<T1, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3EDF290", Offset = "0x3EDDE90", VA = "0x183EDF290")]
		public void RpcAllViaServer<T1, T2>(NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3EDED80", Offset = "0x3EDD980", VA = "0x183EDED80")]
		public void RpcAllViaServer<T1, T2, T3>(NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3EDEB70", Offset = "0x3EDD770", VA = "0x183EDEB70")]
		public void RpcAllViaServer<T1, T2, T3, T4>(NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE290", Offset = "0x3EDCE90", VA = "0x183EDE290")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3EDD820", Offset = "0x3EDC420", VA = "0x183EDD820")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3EDCF20", Offset = "0x3EDBB20", VA = "0x183EDCF20")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3EDCBD0", Offset = "0x3EDB7D0", VA = "0x183EDCBD0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3EDBA50", Offset = "0x3EDA650", VA = "0x183EDBA50")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3EDB660", Offset = "0x3EDA260", VA = "0x183EDB660")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3EDA1C0", Offset = "0x3ED8DC0", VA = "0x183EDA1C0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3ED9D30", Offset = "0x3ED8930", VA = "0x183ED9D30")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8F20", Offset = "0x3ED7B20", VA = "0x183ED8F20")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7AC0", Offset = "0x3ED66C0", VA = "0x183ED7AC0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(AFOMNCEHMCJ OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x823EAD0", Offset = "0x823D6D0", VA = "0x18823EAD0", Slot = "65")]
		public void RpcAllViaServer(NNPNGKOCNDO.BPLCMOELNKD<OJPNDDCHNHP> OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3EDF7C0", Offset = "0x3EDE3C0", VA = "0x183EDF7C0", Slot = "66")]
		public void RpcAllViaServer<T1>(NNPNGKOCNDO.CIEPLPICPOA<T1, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3EDF3F0", Offset = "0x3EDDFF0", VA = "0x183EDF3F0", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3EDEF30", Offset = "0x3EDDB30", VA = "0x183EDEF30", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE960", Offset = "0x3EDD560", VA = "0x183EDE960", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE030", Offset = "0x3EDCC30", VA = "0x183EDE030", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3EDDD80", Offset = "0x3EDC980", VA = "0x183EDDD80", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3EDD520", Offset = "0x3EDC120", VA = "0x183EDD520", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3EDC880", Offset = "0x3EDB480", VA = "0x183EDC880", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3EDBDF0", Offset = "0x3EDA9F0", VA = "0x183EDBDF0", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3EDB270", Offset = "0x3ED9E70", VA = "0x183EDB270", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3EDAA40", Offset = "0x3ED9640", VA = "0x183EDAA40", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3ED98A0", Offset = "0x3ED84A0", VA = "0x183ED98A0", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8540", Offset = "0x3ED7140", VA = "0x183ED8540", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7580", Offset = "0x3ED6180", VA = "0x183ED7580", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(AFOMNCEHMCJ OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8240240", Offset = "0x823EE40", VA = "0x188240240", Slot = "80")]
		public void RpcOthers(NNPNGKOCNDO.DJKDNFBOFCH OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3F1E690", Offset = "0x3F1D290", VA = "0x183F1E690", Slot = "15")]
		public void RpcOthers<T1>(NNPNGKOCNDO.BPLCMOELNKD<T1> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3F1EF90", Offset = "0x3F1DB90", VA = "0x183F1EF90", Slot = "81")]
		public void RpcOthers<T1, T2>(NNPNGKOCNDO.CIEPLPICPOA<T1, T2> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3F1E410", Offset = "0x3F1D010", VA = "0x183F1E410", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, T3> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3F27ED0", Offset = "0x3F26AD0", VA = "0x183F27ED0", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, T4> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3F1FD40", Offset = "0x3F1E940", VA = "0x183F1FD40", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, T5> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3F26D50", Offset = "0x3F25950", VA = "0x183F26D50", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, T6> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3F26120", Offset = "0x3F24D20", VA = "0x183F26120", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, T7> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3F25A40", Offset = "0x3F24640", VA = "0x183F25A40", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, T8> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3F24B90", Offset = "0x3F23790", VA = "0x183F24B90", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, T9> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3F24370", Offset = "0x3F22F70", VA = "0x183F24370", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3F23240", Offset = "0x3F21E40", VA = "0x183F23240", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3F22400", Offset = "0x3F21000", VA = "0x183F22400", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3F214D0", Offset = "0x3F200D0", VA = "0x183F214D0", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3F20F60", Offset = "0x3F1FB60", VA = "0x183F20F60", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8240390", Offset = "0x823EF90", VA = "0x188240390")]
		public void RpcOthers(NNPNGKOCNDO.BPLCMOELNKD<ILALCDLDIIG> OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3F1ECD0", Offset = "0x3F1D8D0", VA = "0x183F1ECD0")]
		public void RpcOthers<T1>(NNPNGKOCNDO.CIEPLPICPOA<T1, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3F1EAE0", Offset = "0x3F1D6E0", VA = "0x183F1EAE0")]
		public void RpcOthers<T1, T2>(NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3F28CC0", Offset = "0x3F278C0", VA = "0x183F28CC0")]
		public void RpcOthers<T1, T2, T3>(NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3F1E7F0", Offset = "0x3F1D3F0", VA = "0x183F1E7F0")]
		public void RpcOthers<T1, T2, T3, T4>(NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3F1F4A0", Offset = "0x3F1E0A0", VA = "0x183F1F4A0")]
		public void RpcOthers<T1, T2, T3, T4, T5>(NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3F1F7F0", Offset = "0x3F1E3F0", VA = "0x183F1F7F0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3F26760", Offset = "0x3F25360", VA = "0x183F26760")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3F25DB0", Offset = "0x3F249B0", VA = "0x183F25DB0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3F24F50", Offset = "0x3F23B50", VA = "0x183F24F50")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3F24780", Offset = "0x3F23380", VA = "0x183F24780")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3F236A0", Offset = "0x3F222A0", VA = "0x183F236A0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3F228C0", Offset = "0x3F214C0", VA = "0x183F228C0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3F219E0", Offset = "0x3F205E0", VA = "0x183F219E0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3F209F0", Offset = "0x3F1F5F0", VA = "0x183F209F0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(AFOMNCEHMCJ OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x82404E0", Offset = "0x823F0E0", VA = "0x1882404E0", Slot = "93")]
		public void RpcOthers(NNPNGKOCNDO.BPLCMOELNKD<OJPNDDCHNHP> OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3F29B50", Offset = "0x3F28750", VA = "0x183F29B50", Slot = "94")]
		public void RpcOthers<T1>(NNPNGKOCNDO.CIEPLPICPOA<T1, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3F295A0", Offset = "0x3F281A0", VA = "0x183F295A0", Slot = "95")]
		public void RpcOthers<T1, T2>(NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3F28EA0", Offset = "0x3F27AA0", VA = "0x183F28EA0", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3F27CA0", Offset = "0x3F268A0", VA = "0x183F27CA0", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3F277F0", Offset = "0x3F263F0", VA = "0x183F277F0", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3F27020", Offset = "0x3F25C20", VA = "0x183F27020", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3F26440", Offset = "0x3F25040", VA = "0x183F26440", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3F256D0", Offset = "0x3F242D0", VA = "0x183F256D0", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3F25310", Offset = "0x3F23F10", VA = "0x183F25310", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3F23F60", Offset = "0x3F22B60", VA = "0x183F23F60", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3F23B00", Offset = "0x3F22700", VA = "0x183F23B00", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3F22D80", Offset = "0x3F21980", VA = "0x183F22D80", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3F21EF0", Offset = "0x3F20AF0", VA = "0x183F21EF0", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3F20480", Offset = "0x3F1F080", VA = "0x183F20480", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(AFOMNCEHMCJ OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x823FC90", Offset = "0x823E890", VA = "0x18823FC90", Slot = "108")]
		public void RpcMaster(NNPNGKOCNDO.DJKDNFBOFCH OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3F01FF0", Offset = "0x3F00BF0", VA = "0x183F01FF0", Slot = "109")]
		public void RpcMaster<T1>(NNPNGKOCNDO.BPLCMOELNKD<T1> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3F021A0", Offset = "0x3F00DA0", VA = "0x183F021A0", Slot = "17")]
		public void RpcMaster<T1, T2>(NNPNGKOCNDO.CIEPLPICPOA<T1, T2> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3F01B20", Offset = "0x3F00720", VA = "0x183F01B20", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, T3> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3F055C0", Offset = "0x3F041C0", VA = "0x183F055C0", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, T4> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3F07860", Offset = "0x3F06460", VA = "0x183F07860", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, T5> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3F094F0", Offset = "0x3F080F0", VA = "0x183F094F0", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, T6> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3F11FB0", Offset = "0x3F10BB0", VA = "0x183F11FB0", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, T7> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3F113A0", Offset = "0x3F0FFA0", VA = "0x183F113A0", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, T8> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3F0FCB0", Offset = "0x3F0E8B0", VA = "0x183F0FCB0", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, T9> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3F07210", Offset = "0x3F05E10", VA = "0x183F07210", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3F06290", Offset = "0x3F04E90", VA = "0x183F06290", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3F0D780", Offset = "0x3F0C380", VA = "0x183F0D780", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3F0BF50", Offset = "0x3F0AB50", VA = "0x183F0BF50", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3F0ABD0", Offset = "0x3F097D0", VA = "0x183F0ABD0", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x823FA70", Offset = "0x823E670", VA = "0x18823FA70")]
		public void RpcMaster(NNPNGKOCNDO.BPLCMOELNKD<ILALCDLDIIG> OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3F01DF0", Offset = "0x3F009F0", VA = "0x183F01DF0")]
		public void RpcMaster<T1>(NNPNGKOCNDO.CIEPLPICPOA<T1, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3F02630", Offset = "0x3F01230", VA = "0x183F02630")]
		public void RpcMaster<T1, T2>(NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3F05920", Offset = "0x3F04520", VA = "0x183F05920")]
		public void RpcMaster<T1, T2, T3>(NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3F137B0", Offset = "0x3F123B0", VA = "0x183F137B0")]
		public void RpcMaster<T1, T2, T3, T4>(NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3F07CC0", Offset = "0x3F068C0", VA = "0x183F07CC0")]
		public void RpcMaster<T1, T2, T3, T4, T5>(NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3F12370", Offset = "0x3F10F70", VA = "0x183F12370")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3F117B0", Offset = "0x3F103B0", VA = "0x183F117B0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3F10AC0", Offset = "0x3F0F6C0", VA = "0x183F10AC0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3F105F0", Offset = "0x3F0F1F0", VA = "0x183F105F0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3F0F780", Offset = "0x3F0E380", VA = "0x183F0F780")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3F0DD20", Offset = "0x3F0C920", VA = "0x183F0DD20")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3F0D190", Offset = "0x3F0BD90", VA = "0x183F0D190")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3F0B900", Offset = "0x3F0A500", VA = "0x183F0B900")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A510", Offset = "0x3F09110", VA = "0x183F0A510")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(AFOMNCEHMCJ OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x823FE20", Offset = "0x823EA20", VA = "0x18823FE20", Slot = "122")]
		public void RpcMaster(NNPNGKOCNDO.BPLCMOELNKD<OJPNDDCHNHP> OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3F050A0", Offset = "0x3F03CA0", VA = "0x183F050A0", Slot = "123")]
		public void RpcMaster<T1>(NNPNGKOCNDO.CIEPLPICPOA<T1, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3F04720", Offset = "0x3F03320", VA = "0x183F04720", Slot = "124")]
		public void RpcMaster<T1, T2>(NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3F14020", Offset = "0x3F12C20", VA = "0x183F14020", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3F13D30", Offset = "0x3F12930", VA = "0x183F13D30", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3F13110", Offset = "0x3F11D10", VA = "0x183F13110", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3F12720", Offset = "0x3F11320", VA = "0x183F12720", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3F11BB0", Offset = "0x3F107B0", VA = "0x183F11BB0", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3F10F30", Offset = "0x3F0FB30", VA = "0x183F10F30", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3F10120", Offset = "0x3F0ED20", VA = "0x183F10120", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3F0F250", Offset = "0x3F0DE50", VA = "0x183F0F250", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3F0E2B0", Offset = "0x3F0CEB0", VA = "0x183F0E2B0", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3F0CBA0", Offset = "0x3F0B7A0", VA = "0x183F0CBA0", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3F0C550", Offset = "0x3F0B150", VA = "0x183F0C550", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3F0B240", Offset = "0x3F09E40", VA = "0x183F0B240", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(AFOMNCEHMCJ OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x823F8C0", Offset = "0x823E4C0", VA = "0x18823F8C0", Slot = "137")]
		public void RpcAuthority(NNPNGKOCNDO.DJKDNFBOFCH OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3EF1BC0", Offset = "0x3EF07C0", VA = "0x183EF1BC0", Slot = "138")]
		public void RpcAuthority<T1>(NNPNGKOCNDO.BPLCMOELNKD<T1> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3EF34D0", Offset = "0x3EF20D0", VA = "0x183EF34D0", Slot = "139")]
		public void RpcAuthority<T1, T2>(NNPNGKOCNDO.CIEPLPICPOA<T1, T2> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3EF3C80", Offset = "0x3EF2880", VA = "0x183EF3C80", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, T3> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3EF3190", Offset = "0x3EF1D90", VA = "0x183EF3190", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, T4> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3EF17B0", Offset = "0x3EF03B0", VA = "0x183EF17B0", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, T5> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3EFC8F0", Offset = "0x3EFB4F0", VA = "0x183EFC8F0", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, T6> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3EFB920", Offset = "0x3EFA520", VA = "0x183EFB920", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, T7> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3EFB070", Offset = "0x3EF9C70", VA = "0x183EFB070", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, T8> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3EFA760", Offset = "0x3EF9360", VA = "0x183EFA760", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, T9> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3EF98B0", Offset = "0x3EF84B0", VA = "0x183EF98B0", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8340", Offset = "0x3EF6F40", VA = "0x183EF8340", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3EF1D80", Offset = "0x3EF0980", VA = "0x183EF1D80", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3EF65D0", Offset = "0x3EF51D0", VA = "0x183EF65D0", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3EF4BC0", Offset = "0x3EF37C0", VA = "0x183EF4BC0", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x823F670", Offset = "0x823E270", VA = "0x18823F670")]
		public void RpcAuthority(NNPNGKOCNDO.BPLCMOELNKD<ILALCDLDIIG> OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3EFFBE0", Offset = "0x3EFE7E0", VA = "0x183EFFBE0")]
		public void RpcAuthority<T1>(NNPNGKOCNDO.CIEPLPICPOA<T1, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3EFEC60", Offset = "0x3EFD860", VA = "0x183EFEC60")]
		public void RpcAuthority<T1, T2>(NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE750", Offset = "0x3EFD350", VA = "0x183EFE750")]
		public void RpcAuthority<T1, T2, T3>(NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3EFDCE0", Offset = "0x3EFC8E0", VA = "0x183EFDCE0")]
		public void RpcAuthority<T1, T2, T3, T4>(NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3EFD680", Offset = "0x3EFC280", VA = "0x183EFD680")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3EFCC50", Offset = "0x3EFB850", VA = "0x183EFCC50")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3EFC110", Offset = "0x3EFAD10", VA = "0x183EFC110")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3EFB4A0", Offset = "0x3EFA0A0", VA = "0x183EFB4A0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3EFA280", Offset = "0x3EF8E80", VA = "0x183EFA280")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8E30", Offset = "0x3EF7A30", VA = "0x183EF8E30")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7DA0", Offset = "0x3EF69A0", VA = "0x183EF7DA0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6BF0", Offset = "0x3EF57F0", VA = "0x183EF6BF0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3EF5910", Offset = "0x3EF4510", VA = "0x183EF5910")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3EF44F0", Offset = "0x3EF30F0", VA = "0x183EF44F0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(AFOMNCEHMCJ OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x823F410", Offset = "0x823E010", VA = "0x18823F410", Slot = "152")]
		public void RpcAuthority(NNPNGKOCNDO.BPLCMOELNKD<OJPNDDCHNHP> OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3EFFF40", Offset = "0x3EFEB40", VA = "0x183EFFF40", Slot = "153")]
		public void RpcAuthority<T1>(NNPNGKOCNDO.CIEPLPICPOA<T1, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3EFF070", Offset = "0x3EFDC70", VA = "0x183EFF070", Slot = "154")]
		public void RpcAuthority<T1, T2>(NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE4C0", Offset = "0x3EFD0C0", VA = "0x183EFE4C0", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3EFD9E0", Offset = "0x3EFC5E0", VA = "0x183EFD9E0", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3EFD010", Offset = "0x3EFBC10", VA = "0x183EFD010", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3EFC530", Offset = "0x3EFB130", VA = "0x183EFC530", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3EFBCF0", Offset = "0x3EFA8F0", VA = "0x183EFBCF0", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3EFABF0", Offset = "0x3EF97F0", VA = "0x183EFABF0", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9DA0", Offset = "0x3EF89A0", VA = "0x183EF9DA0", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9370", Offset = "0x3EF7F70", VA = "0x183EF9370", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8890", Offset = "0x3EF7490", VA = "0x183EF8890", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3EF71F0", Offset = "0x3EF5DF0", VA = "0x183EF71F0", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3EF5F70", Offset = "0x3EF4B70", VA = "0x183EF5F70", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3EF5240", Offset = "0x3EF3E40", VA = "0x183EF5240", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(AFOMNCEHMCJ OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x82408E0", Offset = "0x823F4E0", VA = "0x1882408E0", Slot = "18")]
		public void RpcPlayer(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.DJKDNFBOFCH OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A250", Offset = "0x3F28E50", VA = "0x183F2A250", Slot = "19")]
		public void RpcPlayer<T1>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.BPLCMOELNKD<T1> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B1B0", Offset = "0x3F29DB0", VA = "0x183F2B1B0", Slot = "20")]
		public void RpcPlayer<T1, T2>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.CIEPLPICPOA<T1, T2> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3F2ABC0", Offset = "0x3F297C0", VA = "0x183F2ABC0", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, T3> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A5F0", Offset = "0x3F291F0", VA = "0x183F2A5F0", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, T4> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3F2EF20", Offset = "0x3F2DB20", VA = "0x183F2EF20", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, T5> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3F2EAB0", Offset = "0x3F2D6B0", VA = "0x183F2EAB0", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, T6> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3F2F310", Offset = "0x3F2DF10", VA = "0x183F2F310", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, T7> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3F2F7E0", Offset = "0x3F2E3E0", VA = "0x183F2F7E0", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, T8> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3F350C0", Offset = "0x3F33CC0", VA = "0x183F350C0", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, T9> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3F34120", Offset = "0x3F32D20", VA = "0x183F34120", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PLCCGHEKGIM FANAFCDPEEP, GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3F2BAA0", Offset = "0x3F2A6A0", VA = "0x183F2BAA0", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PLCCGHEKGIM FANAFCDPEEP, CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3F32480", Offset = "0x3F31080", VA = "0x183F32480", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(PLCCGHEKGIM FANAFCDPEEP, KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3F3D7F0", Offset = "0x3F3C3F0", VA = "0x183F3D7F0", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(PLCCGHEKGIM FANAFCDPEEP, FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3F3D160", Offset = "0x3F3BD60", VA = "0x183F3D160", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PLCCGHEKGIM FANAFCDPEEP, LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8240630", Offset = "0x823F230", VA = "0x188240630")]
		public void RpcPlayer(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.BPLCMOELNKD<ILALCDLDIIG> OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A990", Offset = "0x3F29590", VA = "0x183F2A990")]
		public void RpcPlayer<T1>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.CIEPLPICPOA<T1, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3F31570", Offset = "0x3F30170", VA = "0x183F31570")]
		public void RpcPlayer<T1, T2>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3F39930", Offset = "0x3F38530", VA = "0x183F39930")]
		public void RpcPlayer<T1, T2, T3>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3F38DC0", Offset = "0x3F379C0", VA = "0x183F38DC0")]
		public void RpcPlayer<T1, T2, T3, T4>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3F383D0", Offset = "0x3F36FD0", VA = "0x183F383D0")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3F38000", Offset = "0x3F36C00", VA = "0x183F38000")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x3F37490", Offset = "0x3F36090", VA = "0x183F37490")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x3F35F40", Offset = "0x3F34B40", VA = "0x183F35F40")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x3F35560", Offset = "0x3F34160", VA = "0x183F35560")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PLCCGHEKGIM FANAFCDPEEP, GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3F34620", Offset = "0x3F33220", VA = "0x183F34620")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PLCCGHEKGIM FANAFCDPEEP, CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3F33B70", Offset = "0x3F32770", VA = "0x183F33B70")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PLCCGHEKGIM FANAFCDPEEP, KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3F32A40", Offset = "0x3F31640", VA = "0x183F32A40")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(PLCCGHEKGIM FANAFCDPEEP, FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3F3E4A0", Offset = "0x3F3D0A0", VA = "0x183F3E4A0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(PLCCGHEKGIM FANAFCDPEEP, LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3F3CA80", Offset = "0x3F3B680", VA = "0x183F3CA80")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PLCCGHEKGIM FANAFCDPEEP, AFOMNCEHMCJ OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8240AE0", Offset = "0x823F6E0", VA = "0x188240AE0", Slot = "176")]
		public void RpcPlayer(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.BPLCMOELNKD<OJPNDDCHNHP> OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3F2D8A0", Offset = "0x3F2C4A0", VA = "0x183F2D8A0", Slot = "177")]
		public void RpcPlayer<T1>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.CIEPLPICPOA<T1, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B7B0", Offset = "0x3F2A3B0", VA = "0x183F2B7B0", Slot = "24")]
		public void RpcPlayer<T1, T2>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B430", Offset = "0x3F2A030", VA = "0x183F2B430", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3F2D2F0", Offset = "0x3F2BEF0", VA = "0x183F2D2F0", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3F38740", Offset = "0x3F37340", VA = "0x183F38740", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3F37C30", Offset = "0x3F36830", VA = "0x183F37C30", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3F36C90", Offset = "0x3F35890", VA = "0x183F36C90", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3F363D0", Offset = "0x3F34FD0", VA = "0x183F363D0", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(PLCCGHEKGIM FANAFCDPEEP, NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3F35A50", Offset = "0x3F34650", VA = "0x183F35A50", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PLCCGHEKGIM FANAFCDPEEP, GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3F34B70", Offset = "0x3F33770", VA = "0x183F34B70", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PLCCGHEKGIM FANAFCDPEEP, CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3F335C0", Offset = "0x3F321C0", VA = "0x183F335C0", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PLCCGHEKGIM FANAFCDPEEP, KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3F31E60", Offset = "0x3F30A60", VA = "0x183F31E60", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(PLCCGHEKGIM FANAFCDPEEP, FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x3F3DE20", Offset = "0x3F3CA20", VA = "0x183F3DE20", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(PLCCGHEKGIM FANAFCDPEEP, LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C3A0", Offset = "0x3F3AFA0", VA = "0x183F3C3A0", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PLCCGHEKGIM FANAFCDPEEP, AFOMNCEHMCJ OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x823E8F0", Offset = "0x823D4F0", VA = "0x18823E8F0", Slot = "189")]
		public void RpcAllBuffered(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.DJKDNFBOFCH OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x3ED70F0", Offset = "0x3ED5CF0", VA = "0x183ED70F0", Slot = "190")]
		public void RpcAllBuffered<T1>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.BPLCMOELNKD<T1> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6A60", Offset = "0x3ED5660", VA = "0x183ED6A60", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.CIEPLPICPOA<T1, T2> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x3ED66E0", Offset = "0x3ED52E0", VA = "0x183ED66E0", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, T3> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3ED5EF0", Offset = "0x3ED4AF0", VA = "0x183ED5EF0", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, T4> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3ED5C90", Offset = "0x3ED4890", VA = "0x183ED5C90", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, T5> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3ED5520", Offset = "0x3ED4120", VA = "0x183ED5520", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, T6> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3ED49C0", Offset = "0x3ED35C0", VA = "0x183ED49C0", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, T7> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4360", Offset = "0x3ED2F60", VA = "0x183ED4360", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, T8> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3540", Offset = "0x3ED2140", VA = "0x183ED3540", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, T9> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2990", Offset = "0x3ED1590", VA = "0x183ED2990", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MAGOLDLHMLF HMMJNMNHAID, GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1CF0", Offset = "0x3ED08F0", VA = "0x183ED1CF0", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MAGOLDLHMLF HMMJNMNHAID, CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0F60", Offset = "0x3ECFB60", VA = "0x183ED0F60", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MAGOLDLHMLF HMMJNMNHAID, KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x3ECFBC0", Offset = "0x3ECE7C0", VA = "0x183ECFBC0", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MAGOLDLHMLF HMMJNMNHAID, FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x3ECF670", Offset = "0x3ECE270", VA = "0x183ECF670", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MAGOLDLHMLF HMMJNMNHAID, LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x823EA30", Offset = "0x823D630", VA = "0x18823EA30")]
		public void RpcAllBuffered(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.BPLCMOELNKD<ILALCDLDIIG> OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6FD0", Offset = "0x3ED5BD0", VA = "0x183ED6FD0")]
		public void RpcAllBuffered<T1>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.CIEPLPICPOA<T1, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6D40", Offset = "0x3ED5940", VA = "0x183ED6D40")]
		public void RpcAllBuffered<T1, T2>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x3ED68A0", Offset = "0x3ED54A0", VA = "0x183ED68A0")]
		public void RpcAllBuffered<T1, T2, T3>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6310", Offset = "0x3ED4F10", VA = "0x183ED6310")]
		public void RpcAllBuffered<T1, T2, T3, T4>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x3ED57D0", Offset = "0x3ED43D0", VA = "0x183ED57D0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x3ED5270", Offset = "0x3ED3E70", VA = "0x183ED5270")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3ED46C0", Offset = "0x3ED32C0", VA = "0x183ED46C0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3CA0", Offset = "0x3ED28A0", VA = "0x183ED3CA0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3190", Offset = "0x3ED1D90", VA = "0x183ED3190")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MAGOLDLHMLF HMMJNMNHAID, GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2590", Offset = "0x3ED1190", VA = "0x183ED2590")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MAGOLDLHMLF HMMJNMNHAID, CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2140", Offset = "0x3ED0D40", VA = "0x183ED2140")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MAGOLDLHMLF HMMJNMNHAID, KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1400", Offset = "0x3ED0000", VA = "0x183ED1400")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MAGOLDLHMLF HMMJNMNHAID, FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3ED00C0", Offset = "0x3ECECC0", VA = "0x183ED00C0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MAGOLDLHMLF HMMJNMNHAID, LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3ECEBD0", Offset = "0x3ECD7D0", VA = "0x183ECEBD0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MAGOLDLHMLF HMMJNMNHAID, AFOMNCEHMCJ OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x823E990", Offset = "0x823D590", VA = "0x18823E990", Slot = "204")]
		public void RpcAllBuffered(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.BPLCMOELNKD<OJPNDDCHNHP> OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6EB0", Offset = "0x3ED5AB0", VA = "0x183ED6EB0", Slot = "205")]
		public void RpcAllBuffered<T1>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.CIEPLPICPOA<T1, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6BD0", Offset = "0x3ED57D0", VA = "0x183ED6BD0", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6520", Offset = "0x3ED5120", VA = "0x183ED6520", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6100", Offset = "0x3ED4D00", VA = "0x183ED6100", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x3ED5A30", Offset = "0x3ED4630", VA = "0x183ED5A30", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4FC0", Offset = "0x3ED3BC0", VA = "0x183ED4FC0", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4CC0", Offset = "0x3ED38C0", VA = "0x183ED4CC0", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4000", Offset = "0x3ED2C00", VA = "0x183ED4000", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3ED38F0", Offset = "0x3ED24F0", VA = "0x183ED38F0", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MAGOLDLHMLF HMMJNMNHAID, GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2D90", Offset = "0x3ED1990", VA = "0x183ED2D90", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MAGOLDLHMLF HMMJNMNHAID, CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x3ED18A0", Offset = "0x3ED04A0", VA = "0x183ED18A0", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MAGOLDLHMLF HMMJNMNHAID, KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0AC0", Offset = "0x3ECF6C0", VA = "0x183ED0AC0", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MAGOLDLHMLF HMMJNMNHAID, FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x3ED05C0", Offset = "0x3ECF1C0", VA = "0x183ED05C0", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MAGOLDLHMLF HMMJNMNHAID, LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3ECF120", Offset = "0x3ECDD20", VA = "0x183ECF120", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MAGOLDLHMLF HMMJNMNHAID, AFOMNCEHMCJ OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8240100", Offset = "0x823ED00", VA = "0x188240100", Slot = "219")]
		public void RpcOthersBuffered(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.DJKDNFBOFCH OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x3F1E1D0", Offset = "0x3F1CDD0", VA = "0x183F1E1D0", Slot = "220")]
		public void RpcOthersBuffered<T1>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.BPLCMOELNKD<T1> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3F1DC60", Offset = "0x3F1C860", VA = "0x183F1DC60", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.CIEPLPICPOA<T1, T2> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3F1D8E0", Offset = "0x3F1C4E0", VA = "0x183F1D8E0", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, T3> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3F1D0F0", Offset = "0x3F1BCF0", VA = "0x183F1D0F0", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, T4> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3F1CC30", Offset = "0x3F1B830", VA = "0x183F1CC30", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, T5> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C1C0", Offset = "0x3F1ADC0", VA = "0x183F1C1C0", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, T6> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3F1B8C0", Offset = "0x3F1A4C0", VA = "0x183F1B8C0", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, T7> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3F1AEA0", Offset = "0x3F19AA0", VA = "0x183F1AEA0", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, T8> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3F1A390", Offset = "0x3F18F90", VA = "0x183F1A390", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, T9> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x3F19B90", Offset = "0x3F18790", VA = "0x183F19B90", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MAGOLDLHMLF HMMJNMNHAID, GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3F19340", Offset = "0x3F17F40", VA = "0x183F19340", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MAGOLDLHMLF HMMJNMNHAID, CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3F18160", Offset = "0x3F16D60", VA = "0x183F18160", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MAGOLDLHMLF HMMJNMNHAID, KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3F16DC0", Offset = "0x3F159C0", VA = "0x183F16DC0", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MAGOLDLHMLF HMMJNMNHAID, FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x3F15DD0", Offset = "0x3F149D0", VA = "0x183F15DD0", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MAGOLDLHMLF HMMJNMNHAID, LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8240060", Offset = "0x823EC60", VA = "0x188240060")]
		public void RpcOthersBuffered(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.BPLCMOELNKD<ILALCDLDIIG> OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x3F1E2F0", Offset = "0x3F1CEF0", VA = "0x183F1E2F0")]
		public void RpcOthersBuffered<T1>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.CIEPLPICPOA<T1, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3F1DDD0", Offset = "0x3F1C9D0", VA = "0x183F1DDD0")]
		public void RpcOthersBuffered<T1, T2>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x3F1D720", Offset = "0x3F1C320", VA = "0x183F1D720")]
		public void RpcOthersBuffered<T1, T2, T3>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3F1D300", Offset = "0x3F1BF00", VA = "0x183F1D300")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C9D0", Offset = "0x3F1B5D0", VA = "0x183F1C9D0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C470", Offset = "0x3F1B070", VA = "0x183F1C470")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x3F1BEC0", Offset = "0x3F1AAC0", VA = "0x183F1BEC0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3F1B560", Offset = "0x3F1A160", VA = "0x183F1B560")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, ILALCDLDIIG> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x3F1A740", Offset = "0x3F19340", VA = "0x183F1A740")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MAGOLDLHMLF HMMJNMNHAID, GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3F19790", Offset = "0x3F18390", VA = "0x183F19790")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MAGOLDLHMLF HMMJNMNHAID, CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x3F18AA0", Offset = "0x3F176A0", VA = "0x183F18AA0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MAGOLDLHMLF HMMJNMNHAID, KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3F17CC0", Offset = "0x3F168C0", VA = "0x183F17CC0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MAGOLDLHMLF HMMJNMNHAID, FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3F172C0", Offset = "0x3F15EC0", VA = "0x183F172C0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MAGOLDLHMLF HMMJNMNHAID, LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3F16870", Offset = "0x3F15470", VA = "0x183F16870")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MAGOLDLHMLF HMMJNMNHAID, AFOMNCEHMCJ OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x82401A0", Offset = "0x823EDA0", VA = "0x1882401A0", Slot = "234")]
		public void RpcOthersBuffered(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.BPLCMOELNKD<OJPNDDCHNHP> OBAAMCMFDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x3F1E0B0", Offset = "0x3F1CCB0", VA = "0x183F1E0B0", Slot = "235")]
		public void RpcOthersBuffered<T1>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.CIEPLPICPOA<T1, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x3F1DF40", Offset = "0x3F1CB40", VA = "0x183F1DF40", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.MKHMOPBIBJD<T1, T2, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x3F1DAA0", Offset = "0x3F1C6A0", VA = "0x183F1DAA0", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.GFDIDJOPFKB<T1, T2, T3, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x3F1D510", Offset = "0x3F1C110", VA = "0x183F1D510", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.IHNOLLIMAMI<T1, T2, T3, T4, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3F1CE90", Offset = "0x3F1BA90", VA = "0x183F1CE90", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.FPFBCEOAFNG<T1, T2, T3, T4, T5, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C720", Offset = "0x3F1B320", VA = "0x183F1C720", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.OFEBPIOOCCM<T1, T2, T3, T4, T5, T6, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x3F1BBC0", Offset = "0x3F1A7C0", VA = "0x183F1BBC0", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.DOLKACHFGHG<T1, T2, T3, T4, T5, T6, T7, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x3F1B200", Offset = "0x3F19E00", VA = "0x183F1B200", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(MAGOLDLHMLF HMMJNMNHAID, NNPNGKOCNDO.CKMABGGOFKN<T1, T2, T3, T4, T5, T6, T7, T8, OJPNDDCHNHP> OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x3F1AAF0", Offset = "0x3F196F0", VA = "0x183F1AAF0", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(MAGOLDLHMLF HMMJNMNHAID, GIFGOJBIFLL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x3F19F90", Offset = "0x3F18B90", VA = "0x183F19F90", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(MAGOLDLHMLF HMMJNMNHAID, CIGNCNDFKDM OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x3F18EF0", Offset = "0x3F17AF0", VA = "0x183F18EF0", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(MAGOLDLHMLF HMMJNMNHAID, KNPACGPBGDG OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x3F18600", Offset = "0x3F17200", VA = "0x183F18600", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(MAGOLDLHMLF HMMJNMNHAID, FBIHJAMPPOL OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x3F177C0", Offset = "0x3F163C0", VA = "0x183F177C0", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(MAGOLDLHMLF HMMJNMNHAID, LEMCHADCHKI OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x3F16320", Offset = "0x3F14F20", VA = "0x183F16320", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(MAGOLDLHMLF HMMJNMNHAID, AFOMNCEHMCJ OBAAMCMFDIE, T1 FEPMJGCELEH, T2 OMDGLIENELF, T3 NLIONCMPFCA, T4 MJPAFONMCEH, T5 HBFBOLNEBPO, T6 MEECPCCPEKA, T7 LALHBAHODIH, T8 PNNEKGELNOB, T9 NFPDLBNECFI, T10 GJMBEEOACFE, T11 JAICDJFELPO, T12 FPOMPGCLODH, T13 LEANIPGANPJ, T14 BNHAKOPODHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x823C500", Offset = "0x823B100", VA = "0x18823C500", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x823C720", Offset = "0x823B320", VA = "0x18823C720", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x203A1C0", Offset = "0x2038DC0", VA = "0x18203A1C0")]
		public RRNetworkView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class HCDBCLEGDLD
{
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x822D160", Offset = "0x822BD60", VA = "0x18822D160")]
	private static bool MDDPCAKAEKJ(ViewId OIBGADINDDP, [Out] RRNetworkView CDNODGDIFHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x3C57080", Offset = "0x3C55C80", VA = "0x183C57080")]
	[CanBeNull]
	public static T EMJLGEGCIKG<T>(this ViewId ECLEFOAKJDA)
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
		private sealed class PKCIIMDLBHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public PLCCGHEKGIM[] sorted;

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public PKCIIMDLBHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x823B250", Offset = "0x8239E50", VA = "0x18823B250")]
			internal int BOAGFAANNOG(int index)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x823B2D0", Offset = "0x8239ED0", VA = "0x18823B2D0")]
			internal void JBPAJPMHBHC(int index, int number)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly PEOHNMCPNIJ GDLIBGFAMED;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public static PLCCGHEKGIM[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		internal int AANAKNFKDDB;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8241AA0", Offset = "0x82406A0", VA = "0x188241AA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x82420C0", Offset = "0x8240CC0", VA = "0x1882420C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8242490", Offset = "0x8241090", VA = "0x188242490")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8242510", Offset = "0x8241110", VA = "0x188242510")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8241EE0", Offset = "0x8240AE0", VA = "0x188241EE0")]
		private void PADPPFPCJNA(PLCCGHEKGIM PIAPLNCFGPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8241EE0", Offset = "0x8240AE0", VA = "0x188241EE0")]
		private void DOMLADOJDAP(PLCCGHEKGIM KJDJNKGGJKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8241FE0", Offset = "0x8240BE0", VA = "0x188241FE0")]
		private void NIPCNEHKPCO(PLCCGHEKGIM HPFELNLMLAB, IDictionary<object, object> IFFALOHCONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8241950", Offset = "0x8240550", VA = "0x188241950")]
		public static void AssignPlayerNumbers(int AAPKOICINCE, int AJIFEDMGPHL, Func<int, int> BPJOPHJDPMI, Action<int, int> PGPFBFALIBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x82425C0", Offset = "0x82411C0", VA = "0x1882425C0")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8241EF0", Offset = "0x8240AF0", VA = "0x188241EF0")]
		private void HBAJDBAKMAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA6DB20", Offset = "0xA6C720", VA = "0x180A6DB20")]
		public RRPlayerNumbering()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class CJIGIHGIKHN
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x82299F0", Offset = "0x82285F0", VA = "0x1882299F0")]
	public static int PKCJIFCLFAH(this PLCCGHEKGIM FANAFCDPEEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x8229620", Offset = "0x8228220", VA = "0x188229620")]
	public static void BOCIKCJBLNB(this PLCCGHEKGIM FANAFCDPEEP, int POAFCKONGFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class NLIIKHCHNGP
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void HCJOLIKEKPB(Hashtable FDEACFJBFDB);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate void AMHNKPDLKLE(PLCCGHEKGIM FANAFCDPEEP, Hashtable FDEACFJBFDB);

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public static event HCJOLIKEKPB KNLPIGDGMMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8238A30", Offset = "0x8237630", VA = "0x188238A30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8238970", Offset = "0x8237570", VA = "0x188238970")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public static event HCJOLIKEKPB LJHKBNPPBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x82388B0", Offset = "0x82374B0", VA = "0x1882388B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8238730", Offset = "0x8237330", VA = "0x188238730")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public static event AMHNKPDLKLE MILBHBIJOED
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8238C70", Offset = "0x8237870", VA = "0x188238C70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x82387F0", Offset = "0x82373F0", VA = "0x1882387F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public static event AMHNKPDLKLE NKAKDJBEONI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8238AF0", Offset = "0x82376F0", VA = "0x188238AF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8238BB0", Offset = "0x82377B0", VA = "0x188238BB0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class HFEPHJIOKNH
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int OJDJOJBODMI;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static int HCKOIFKJLHJ;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static int DADEOOIFIIA;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x822D5B0", Offset = "0x822C1B0", VA = "0x18822D5B0")]
	public static void LENBBFPMENA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x822D4D0", Offset = "0x822C0D0", VA = "0x18822D4D0")]
	public static void IMDLCJNHKFL(int[] DOIMJMJILBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x822D220", Offset = "0x822BE20", VA = "0x18822D220")]
	public static int CEKCPLIGDIF(int DMHKKDPIOJB, bool AEOHGJBPNOG = true)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
[RegisterService(typeof(AEOCIPLNAMB), new string[] { })]
public class AEOCIPLNAMB : ABJONLICPGP, HHIKJEGILJH, IBPJLLPNJDI
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static readonly Hashtable AOEKCKMBAKF;

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static readonly Hashtable NIJCFPLDFFE;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static readonly Hashtable GDIGDBPBNNH;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly OEINLGFEHLC KOPLHHAMFPJ;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static readonly OEINLGFEHLC HMEJJLHJAKF;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly OEINLGFEHLC FCNJANKMJKE;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly OEINLGFEHLC JLBBEPNMAEH;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly OEINLGFEHLC EPKPOCHMEGD;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static int EDHPGCBBKAE;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x8224F60", Offset = "0x8223B60", VA = "0x188224F60", Slot = "18")]
	public void PLHNEJELPBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x8223020", Offset = "0x8221C20", VA = "0x188223020", Slot = "19")]
	public void DJBBIIKCKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x8224590", Offset = "0x8223190", VA = "0x188224590", Slot = "4")]
	public bool KHHJFBMDHEH(PNMEEJKMDEB KCHMACEBLIA, bool IPGKPJBCINO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x82237B0", Offset = "0x82223B0", VA = "0x1882237B0", Slot = "5")]
	public int IDOMHJNNCJN(PNMEEJKMDEB[] MLDGDAABNCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x8222DA0", Offset = "0x82219A0", VA = "0x188222DA0", Slot = "6")]
	public bool AMGNNDMCCFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x8223B70", Offset = "0x8222770", VA = "0x188223B70", Slot = "7")]
	public bool JLJNPGOAPKK(int ECLEFOAKJDA, int ONCCMIGFIIN, bool ANCJCHDFDLL, GameObject HLOIBGDKPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x8222E30", Offset = "0x8221A30", VA = "0x188222E30", Slot = "8")]
	public void BFCFONNKADG(int ONCCMIGFIIN, [Optional] int? IGJKPDOPFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x8223D10", Offset = "0x8222910", VA = "0x188223D10", Slot = "9")]
	public bool KHDCJLAJAOG(GDFAENLHEKK CKGMOBNFAKG, [Out] PNMEEJKMDEB NFMFDKGGOPC, bool DGDFOFIDOPB = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x82231E0", Offset = "0x8221DE0", VA = "0x1882231E0", Slot = "10")]
	public bool FLFHCCOAJFP(GDFAENLHEKK CKGMOBNFAKG, [Out] int MIFICPGEIIP, [Out] PNMEEJKMDEB[] MLDGDAABNCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x82247C0", Offset = "0x82233C0", VA = "0x1882247C0", Slot = "11")]
	public bool MJAIHIIDOLP(GDFAENLHEKK CKGMOBNFAKG, [Out] int ONCCMIGFIIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x8225000", Offset = "0x8223C00", VA = "0x188225000", Slot = "12")]
	public void PLLGICGPOPC(GDFAENLHEKK CKGMOBNFAKG, [Out] int FOEHBGEBKPC, [Out] int[] MDJJDINMALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x82235A0", Offset = "0x82221A0", VA = "0x1882235A0", Slot = "13")]
	public void GGNOGLOFDFP(int MIFICPGEIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x82230C0", Offset = "0x8221CC0", VA = "0x1882230C0", Slot = "14")]
	public void FFGOJBBBLAP(int MIFICPGEIIP, int[] MDJJDINMALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8223700", Offset = "0x8222300", VA = "0x188223700", Slot = "15")]
	public void GPNGAKFOAON(int[] MDJJDINMALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x8224D20", Offset = "0x8223920", VA = "0x188224D20", Slot = "16")]
	public void PFGPPJNNDAB(int[] MDJJDINMALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x8224DF0", Offset = "0x82239F0", VA = "0x188224DF0", Slot = "17")]
	public void PIOFKNILLED(int MIFICPGEIIP, int ONCCMIGFIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x82248E0", Offset = "0x82234E0", VA = "0x1882248E0")]
	private static void NHJNGFEBKIH(PNMEEJKMDEB KCHMACEBLIA, Hashtable IKFHBKIOPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8223E80", Offset = "0x8222A80", VA = "0x188223E80")]
	private static bool KHDCJLAJAOG(Hashtable IKFHBKIOPJJ, PLCCGHEKGIM IFCMDBPBLCL, [Out] PNMEEJKMDEB NFMFDKGGOPC, bool DGDFOFIDOPB = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x82246D0", Offset = "0x82232D0", VA = "0x1882246D0")]
	private static bool KMHEELFAEBN(int ONCCMIGFIIN, PNMEEJKMDEB IKFHBKIOPJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x82234C0", Offset = "0x82220C0", VA = "0x1882234C0")]
	private static int GDPPMHKGDGE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public AEOCIPLNAMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[RegisterService(typeof(GLBCNDLNBPD), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class GLBCNDLNBPD : GHOKPBGIIHC, HHIKJEGILJH, IBPJLLPNJDI
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static Hashtable EGJAOMHBEFE;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static Hashtable HMDCJEKIEBA;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static OEINLGFEHLC IAJNFICNPCK;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly OEINLGFEHLC NDOCEMGFNAN;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x822CE60", Offset = "0x822BA60", VA = "0x18822CE60", Slot = "8")]
	public void DJBBIIKCKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x822CF00", Offset = "0x822BB00", VA = "0x18822CF00", Slot = "7")]
	public void PLHNEJELPBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x822C440", Offset = "0x822B040", VA = "0x18822C440", Slot = "4")]
	public void ACMPKGNPFJB(ViewId ECLEFOAKJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x822CB00", Offset = "0x822B700", VA = "0x18822CB00", Slot = "5")]
	public bool BFHJAJKKLEI(GDFAENLHEKK CKGMOBNFAKG, [Out] ViewId ECLEFOAKJDA, [Out] string IEFFJAPJBDG, [Out] int CPGGDKBEPKI, [Out] object[] HPGHIMFEEID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x822C530", Offset = "0x822B130", VA = "0x18822C530", Slot = "6")]
	public void AKPLDDCLDKD(ViewId CDNODGDIFHH, string IEFFJAPJBDG, GMGKCOMLIHF CKFJPNMCHND, PLCCGHEKGIM FANAFCDPEEP, MOEJDFAPMAA OKDAKIFDNBD, object[] KCHMACEBLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public GLBCNDLNBPD()
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
