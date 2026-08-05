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
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E81960", Offset = "0x7E80360", VA = "0x187E81960", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x21CF550", Offset = "0x21CDF50", VA = "0x1821CF550", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7E8D5B0", Offset = "0x7E8BFB0", VA = "0x187E8D5B0")]
		private void LNHKNJMKPNK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7E8D330", Offset = "0x7E8BD30", VA = "0x187E8D330")]
		private void LEGOBPIAIHA(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7E8DC00", Offset = "0x7E8C600", VA = "0x187E8DC00", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7E8DCB0", Offset = "0x7E8C6B0", VA = "0x187E8DCB0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IHJLBGGDJKD
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly COJJKFBGGKB AJEELMNCDNB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static COJJKFBGGKB ODAKDIJNGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7E78950", Offset = "0x7E77350", VA = "0x187E78950")]
		get
		{
			return default(COJJKFBGGKB);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IPJKAKKEJHL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	RRNetworkView GIDGEBJOFPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NCANJHIHDAF KBJABBHLNEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MHCEMCGLKLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool Serialize(CMIFAEGLOIN BHCOKNKGCOP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Deserialize(OMKIBNHFCJE HPNFFCPPBFG, CMIFAEGLOIN BHCOKNKGCOP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface OKOGBLJOHPI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HPMIFHJBKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DBIMPFBGANL(OMKIBNHFCJE HPNFFCPPBFG);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PGEPBAPICDN(OMKIBNHFCJE HPNFFCPPBFG, CMIFAEGLOIN BHCOKNKGCOP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface FECGFODPKDF : INetworkUpdateSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EPIAMCEAEFP(IPJKAKKEJHL KDAPFAHHHPD);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IAJHDKMEFKB(IPJKAKKEJHL KDAPFAHHHPD);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BAHJOODPIJB(JPICIJANLHK.EIDECOBNHBL JODNDIFCBNF);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OIJAGJPJJFE();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AKFJOBGJKDP(object JEMDJIEKJFA);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum NCANJHIHDAF : byte
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
public struct OMKIBNHFCJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int GHGIHIAONFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public uint FIJBMAECDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public double LOCMLOAPFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public int HFEOJKKBBKP;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class ICPGKKBMIEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly Dictionary<(ViewId, NCANJHIHDAF), OKOGBLJOHPI> APCONOBPAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly List<IPJKAKKEJHL> CHCOHLHLNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly HashSet<(ViewId, NCANJHIHDAF)> PKCLBOHBANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private int NJKHCNCJKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public bool EIOLKALMPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private JPICIJANLHK.EIDECOBNHBL JODNDIFCBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly MemoryStream DPPOEFFKBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly CMIFAEGLOIN LCMDANDJBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CMIFAEGLOIN OKJKFBKKEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private byte[] KIPGHKFEBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private float CGLOMJFIMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int IFGDPHKBBDK;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7E77450", Offset = "0x7E75E50", VA = "0x187E77450")]
	public ICPGKKBMIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7E75F80", Offset = "0x7E74980", VA = "0x187E75F80")]
	public void BAHJOODPIJB(JPICIJANLHK.EIDECOBNHBL JODNDIFCBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7E76890", Offset = "0x7E75290", VA = "0x187E76890")]
	public void OIJAGJPJJFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7E76490", Offset = "0x7E74E90", VA = "0x187E76490")]
	public void FPILOHDMIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7E76B00", Offset = "0x7E75500", VA = "0x187E76B00")]
	public bool PBDMKLNODMP(IPJKAKKEJHL KDAPFAHHHPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E75FB0", Offset = "0x7E749B0", VA = "0x187E75FB0")]
	public bool DAAFLACHELB(IPJKAKKEJHL KDAPFAHHHPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7E768E0", Offset = "0x7E752E0", VA = "0x187E768E0")]
	private OKOGBLJOHPI OOADGAGIAPD(ViewId POHODHGBPHP, NCANJHIHDAF EBLFCNMBKOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7E75FA0", Offset = "0x7E749A0", VA = "0x187E75FA0")]
	public void BCPPAKMFOOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7E773F0", Offset = "0x7E75DF0", VA = "0x187E773F0")]
	private void PMKDECHJGGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7E76870", Offset = "0x7E75270", VA = "0x187E76870")]
	private void JOOOJONKDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7E760E0", Offset = "0x7E74AE0", VA = "0x187E760E0")]
	public bool DMMDKPAGDBH(FastBufferWriter EDJIMCINKFD, int CDLDBMPKEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7E77030", Offset = "0x7E75A30", VA = "0x187E77030")]
	public void PGEPBAPICDN(OMKIBNHFCJE HPNFFCPPBFG, FastBufferReader LJMOCEGEAFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class BNCKIHONMCO : OKOGBLJOHPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IPJKAKKEJHL OOPMNIONMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private uint FIGKILMJKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int HKKPDFKIJOA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool HPMIFHJBKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
	public BNCKIHONMCO(IPJKAKKEJHL OOPMNIONMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7E6BD80", Offset = "0x7E6A780", VA = "0x187E6BD80", Slot = "5")]
	public bool DBIMPFBGANL(OMKIBNHFCJE HPNFFCPPBFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7E6BE90", Offset = "0x7E6A890", VA = "0x187E6BE90", Slot = "6")]
	public void PGEPBAPICDN(OMKIBNHFCJE HPNFFCPPBFG, CMIFAEGLOIN BHCOKNKGCOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ALDPCEPLJHH : OKOGBLJOHPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private JPICIJANLHK.EIDECOBNHBL JODNDIFCBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly ViewId POHODHGBPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int HKKPDFKIJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private uint FIGKILMJKAL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool HPMIFHJBKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1ADF4A0", Offset = "0x1ADDEA0", VA = "0x181ADF4A0")]
	public ALDPCEPLJHH(ViewId POHODHGBPHP, JPICIJANLHK.EIDECOBNHBL JODNDIFCBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7E6BB60", Offset = "0x7E6A560", VA = "0x187E6BB60", Slot = "5")]
	public bool DBIMPFBGANL(OMKIBNHFCJE HPNFFCPPBFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7E6BBA0", Offset = "0x7E6A5A0", VA = "0x187E6BBA0", Slot = "6")]
	public void PGEPBAPICDN(OMKIBNHFCJE HPNFFCPPBFG, CMIFAEGLOIN BHCOKNKGCOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class EDGJBODKKBN
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7E72F90", Offset = "0x7E71990", VA = "0x187E72F90")]
	public static void PGPOMLMDCHO(this KFGKIGCKOGK DCPMLFOLFAK, CMIFAEGLOIN LCNEAEJGKKA, ViewId GJIMIGJJJKI, bool JABFBDCIKML = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7E72570", Offset = "0x7E70F70", VA = "0x187E72570")]
	public static void CGJHAJALNAJ(this KFGKIGCKOGK DCPMLFOLFAK, CMIFAEGLOIN LCNEAEJGKKA, bool JABFBDCIKML = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7E72E20", Offset = "0x7E71820", VA = "0x187E72E20")]
	public static KFGKIGCKOGK PGEPBAPICDN(CMIFAEGLOIN LCNEAEJGKKA, ViewId GJIMIGJJJKI, bool JABFBDCIKML = true)
	{
		return default(KFGKIGCKOGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7E72A70", Offset = "0x7E71470", VA = "0x187E72A70")]
	public static void FAEKLIJGPAJ(this KFGKIGCKOGK DCPMLFOLFAK, CMIFAEGLOIN LCNEAEJGKKA, bool JABFBDCIKML = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(FECGFODPKDF), new string[] { })]
public class ENDMAOPNKCF : FECGFODPKDF, INetworkUpdateSystem, MJHCLHMDOAB, IIAKOCKOOML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly COJJKFBGGKB NOEFHGJILDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private ICPGKKBMIEJ JHBCEHMGENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private uint GJGDLKCMFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private float JNAIPHDODHO;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7E746D0", Offset = "0x7E730D0", VA = "0x187E746D0", Slot = "4")]
	public void EPIAMCEAEFP(IPJKAKKEJHL KDAPFAHHHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7E747F0", Offset = "0x7E731F0", VA = "0x187E747F0", Slot = "5")]
	public void IAJHDKMEFKB(IPJKAKKEJHL KDAPFAHHHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7E75540", Offset = "0x7E73F40", VA = "0x187E75540", Slot = "10")]
	public void PIJDKGLEIBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7E74E90", Offset = "0x7E73890", VA = "0x187E74E90", Slot = "9")]
	public void NetworkUpdate(NetworkUpdateStage ABJCJOIECLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7E74F70", Offset = "0x7E73970", VA = "0x187E74F70")]
	private void PCFCPPAMGDD(uint LMAMBADEILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7E746A0", Offset = "0x7E730A0", VA = "0x187E746A0", Slot = "6")]
	public void BAHJOODPIJB(JPICIJANLHK.EIDECOBNHBL JODNDIFCBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7E74F10", Offset = "0x7E73910", VA = "0x187E74F10", Slot = "7")]
	public void OIJAGJPJJFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7E74640", Offset = "0x7E73040", VA = "0x187E74640", Slot = "8")]
	public void AKFJOBGJKDP(object IPADIJEFNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7E74B10", Offset = "0x7E73510", VA = "0x187E74B10")]
	private void NENNEGLPAFI(HCCHCCGILAH IPADIJEFNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7E749F0", Offset = "0x7E733F0", VA = "0x187E749F0", Slot = "11")]
	public void NEAHCMEBFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7E756A0", Offset = "0x7E740A0", VA = "0x187E756A0")]
	public ENDMAOPNKCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JGCLCEKFGFM : OKOGBLJOHPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private float HLKMLDAIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int HKKPDFKIJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private uint FIGKILMJKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly NCANJHIHDAF JMIGIKABNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public OMKIBNHFCJE NGCPFFFLINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int OGAIIODLLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public byte[] JCAMFIIJAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private OMKIBNHFCJE IHBDBEEPMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int MHAMIGGLBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private byte[] GOIAELGJEIM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool HPMIFHJBKBA
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7E78B50", Offset = "0x7E77550", VA = "0x187E78B50", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7E78F00", Offset = "0x7E77900", VA = "0x187E78F00")]
	public JGCLCEKFGFM(NCANJHIHDAF JMIGIKABNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7E78B10", Offset = "0x7E77510", VA = "0x187E78B10", Slot = "5")]
	public bool DBIMPFBGANL(OMKIBNHFCJE HPNFFCPPBFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7E78D50", Offset = "0x7E77750", VA = "0x187E78D50", Slot = "6")]
	public void PGEPBAPICDN(OMKIBNHFCJE HPNFFCPPBFG, CMIFAEGLOIN BHCOKNKGCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7E78A00", Offset = "0x7E77400", VA = "0x187E78A00")]
	internal BNCKIHONMCO BCICHBOFLNK(IPJKAKKEJHL KDAPFAHHHPD, CMIFAEGLOIN LCNEAEJGKKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7E78B80", Offset = "0x7E77580", VA = "0x187E78B80")]
	private static void LGMGPNCLIEL(BNCKIHONMCO ONBBJIKEFAM, CMIFAEGLOIN LCNEAEJGKKA, OMKIBNHFCJE CIAHJKOEJBF, byte[] NNHDOHEKGEG, int GACPLDHCANA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[RegisterService(typeof(MGFBHPJNEDF), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class MGFBHPJNEDF : APIHBEIAIJE, MJHCLHMDOAB, IIAKOCKOOML
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly Hashtable DBGMDBKFPHD;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly Hashtable NLHDPOJAMKK;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly Hashtable OMDJLLILCEJ;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly AIJLKOBFKFM CAFGCLJPKJN;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static readonly AIJLKOBFKFM IGGMCGGCPLJ;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly AIJLKOBFKFM IFBCNLCHIEG;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly AIJLKOBFKFM PDABADPEGOJ;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly AIJLKOBFKFM ENGEAKOPHJO;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int NBPEONBCMGL;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7E82A20", Offset = "0x7E81420", VA = "0x187E82A20", Slot = "4")]
	public bool CLHFIKJJEPE(BCHAGGJCBIN JKGCHKOAIPN, bool OLAALDJFJON = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7E82F90", Offset = "0x7E81990", VA = "0x187E82F90", Slot = "5")]
	public int ICACDDLNLIK(BCHAGGJCBIN[] CAIHDKKACCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7E82CE0", Offset = "0x7E816E0", VA = "0x187E82CE0", Slot = "6")]
	public bool DIJHOGHEJAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7E82B50", Offset = "0x7E81550", VA = "0x187E82B50", Slot = "7")]
	public bool DDJKOLJIGNB(int POHODHGBPHP, int KCAHOJHAGKP, bool OBLENHAAONG, GameObject HNGFDIJGINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7E838E0", Offset = "0x7E822E0", VA = "0x187E838E0", Slot = "8")]
	public void NLPPHFDPCMJ(int KCAHOJHAGKP, [Optional] int? FEKGEHBGLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E82480", Offset = "0x7E80E80", VA = "0x187E82480", Slot = "9")]
	public bool BCDNAMFLMNG(HCCHCCGILAH JEMDJIEKJFA, [Out] BCHAGGJCBIN CMDCHHFPJJG, bool JLABGODBDMG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7E81BC0", Offset = "0x7E805C0", VA = "0x187E81BC0", Slot = "10")]
	public bool ABKAIKKINKB(HCCHCCGILAH JEMDJIEKJFA, [Out] int BCHHOFOFBKL, [Out] BCHAGGJCBIN[] CAIHDKKACCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7E83BF0", Offset = "0x7E825F0", VA = "0x187E83BF0", Slot = "11")]
	public bool OKJNCOMJGPG(HCCHCCGILAH JEMDJIEKJFA, [Out] int KCAHOJHAGKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7E83590", Offset = "0x7E81F90", VA = "0x187E83590", Slot = "12")]
	public void LBKNNOHDMKI(HCCHCCGILAH JEMDJIEKJFA, [Out] int JCLAEJFHIOG, [Out] int[] MHOOIKNKEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7E83350", Offset = "0x7E81D50", VA = "0x187E83350", Slot = "13")]
	public void INJLABHIGAK(int BCHHOFOFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7E83AD0", Offset = "0x7E824D0", VA = "0x187E83AD0", Slot = "14")]
	public void OHJEPAMMAPL(int BCHHOFOFBKL, int[] MHOOIKNKEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E82EE0", Offset = "0x7E818E0", VA = "0x187E82EE0", Slot = "15")]
	public void EOJBJMMNJMD(int[] MHOOIKNKEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7E83770", Offset = "0x7E82170", VA = "0x187E83770", Slot = "16")]
	public void LDLJJPHMFOB(int[] MHOOIKNKEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7E82D70", Offset = "0x7E81770", VA = "0x187E82D70", Slot = "17")]
	public void EAADEPKOFPB(int BCHHOFOFBKL, int KCAHOJHAGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E825F0", Offset = "0x7E80FF0", VA = "0x187E825F0")]
	private static void BLMIFOIEBJC(BCHAGGJCBIN JKGCHKOAIPN, Hashtable LMFLICBCKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7E81EA0", Offset = "0x7E808A0", VA = "0x187E81EA0")]
	private static bool BCDNAMFLMNG(Hashtable LMFLICBCKAJ, GBDECDHLMJN MIIHDODFGFN, [Out] BCHAGGJCBIN CMDCHHFPJJG, bool JLABGODBDMG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7E834B0", Offset = "0x7E81EB0", VA = "0x187E834B0")]
	private static int JBJDIPCBLIE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7E83D10", Offset = "0x7E82710", VA = "0x187E83D10", Slot = "18")]
	public void PIJDKGLEIBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7E83840", Offset = "0x7E82240", VA = "0x187E83840", Slot = "19")]
	public void NEAHCMEBFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public MGFBHPJNEDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(IELKEJBCGPH), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class IELKEJBCGPH : KAFDOFNEINA, MJHCLHMDOAB, IIAKOCKOOML
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static Hashtable EJBNLAKOFDF;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static Hashtable MHHHPLPNLJJ;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static AIJLKOBFKFM HPLNADMGHJF;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly AIJLKOBFKFM JCGEMNNDBNI;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7E77670", Offset = "0x7E76070", VA = "0x187E77670", Slot = "4")]
	public void HDPGMIKIEGL(ViewId POHODHGBPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7E77760", Offset = "0x7E76160", VA = "0x187E77760", Slot = "5")]
	public bool KDPLBIKLLBD(HCCHCCGILAH JEMDJIEKJFA, [Out] ViewId POHODHGBPHP, [Out] string KJHKPFJLEEB, [Out] int ENCFEMPDCCA, [Out] object[] FOABHHONDMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7E77B60", Offset = "0x7E76560", VA = "0x187E77B60", Slot = "6")]
	public void PDOKONKOCKK(ViewId MMGGIIKGBNM, string KJHKPFJLEEB, KGENHPLGJBJ PDKPPAEHICP, GBDECDHLMJN KPIDJKLDGJJ, PJHBHKGEEAK BKKIDHENLIH, object[] JKGCHKOAIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7E77AC0", Offset = "0x7E764C0", VA = "0x187E77AC0", Slot = "8")]
	public void NEAHCMEBFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7E78110", Offset = "0x7E76B10", VA = "0x187E78110", Slot = "7")]
	public void PIJDKGLEIBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public IELKEJBCGPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class EEAAOHKDMIH
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7E731A0", Offset = "0x7E71BA0", VA = "0x187E731A0")]
	public static GBDECDHLMJN IKCHGBCKABN(this PGNMDKGFDBN BJBHFAMODGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7E73150", Offset = "0x7E71B50", VA = "0x187E73150")]
	public static PGNMDKGFDBN DDCPIIEIPKA(this GBDECDHLMJN KPIDJKLDGJJ)
	{
		return default(PGNMDKGFDBN);
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class RRNetworkBehavior : MonoBehaviour, NHBJPDLNMGD, ENPMHDHFNFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool networkedViewInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private RRNetworkView networkedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<NJPGPEBFJKB> destroyHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private bool isForwarderRegistered;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId LHCDLGAONDH
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7E85BD0", Offset = "0x7E845D0", VA = "0x187E85BD0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId IBJKJLLCLHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7E85BD0", Offset = "0x7E845D0", VA = "0x187E85BD0", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView GNNAFAGJBDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7E85C50", Offset = "0x7E84650", VA = "0x187E85C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView GIDGEBJOFPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7E85C50", Offset = "0x7E84650", VA = "0x187E85C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public GBDECDHLMJN NPDGLACCHNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7E85D50", Offset = "0x7E84750", VA = "0x187E85D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GBDECDHLMJN BBAFJLLBENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7E860B0", Offset = "0x7E84AB0", VA = "0x187E860B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool FMAAHCDKFEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7E85EB0", Offset = "0x7E848B0", VA = "0x187E85EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OHGDCGHAAJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7E86020", Offset = "0x7E84A20", VA = "0x187E86020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool IHLIICMADDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7E85B00", Offset = "0x7E84500", VA = "0x187E85B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool GFDCDHCCKNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7E85DE0", Offset = "0x7E847E0", VA = "0x187E85DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool HNPGBPIODPE
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7E85B00", Offset = "0x7E84500", VA = "0x187E85B00", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool OOFAJKPAOKE
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7E85B80", Offset = "0x7E84580", VA = "0x187E85B80", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string KNDMDMFHKEE
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x7E85CC0", Offset = "0x7E846C0", VA = "0x187E85CC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool JDNJOHPAFKO
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7E85A80", Offset = "0x7E84480", VA = "0x187E85A80", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<GBDECDHLMJN> AFGJDFCMLOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7E85950", Offset = "0x7E84350", VA = "0x187E85950")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x7E86140", Offset = "0x7E84B40", VA = "0x187E86140")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7E858B0", Offset = "0x7E842B0", VA = "0x187E858B0")]
		public bool WasSpawnedForPlayer(int AMBALDBKDPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x71D8910", Offset = "0x71D7310", VA = "0x1871D8910")]
		private void KKNFEJMKOHD(RRNetworkView FHFGMILAALL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7E85490", Offset = "0x7E83E90", VA = "0x187E85490", Slot = "9")]
		public void RegisterDestroyHandler(NJPGPEBFJKB NGGCDDHMKBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7E856E0", Offset = "0x7E840E0", VA = "0x187E856E0", Slot = "10")]
		public void UnregisterDestroyHandler(NJPGPEBFJKB NGGCDDHMKBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7E85470", Offset = "0x7E83E70", VA = "0x187E85470", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public RRNetworkBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class EIDHMNINKMC
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void LBOKNJPDCLN([In] BCHAGGJCBIN JKGCHKOAIPN, bool FPHCODJPACE, bool LMFLICBCKAJ, bool IIBLMLHNGLH);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void BGKKKBICAKF(GameObject MDCCLJKNLLP);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void HPDICNNJHJG(GameObject MDCCLJKNLLP);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void CNPNOHOLKDM(RRNetworkView MMGGIIKGBNM, string KJHKPFJLEEB, GBDECDHLMJN BJBIEGLAMFB, KGENHPLGJBJ? DKLAGICAOGN, bool FAHFEDHIHEI, PJHBHKGEEAK FPBDNNHBBEJ, object[] JKGCHKOAIPN, string EHEIOMCOCJM);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate void NCFHFDJHHFM(RRNetworkView MMGGIIKGBNM, string KJHKPFJLEEB, GBDECDHLMJN BJBIEGLAMFB, KGENHPLGJBJ? DKLAGICAOGN, bool FAHFEDHIHEI, PJHBHKGEEAK FPBDNNHBBEJ, object[] JKGCHKOAIPN, string EHEIOMCOCJM);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void NAHENLADEOK(RRNetworkView MMGGIIKGBNM, string KJHKPFJLEEB, object[] FOABHHONDMI, string JOPMNFNOAPH);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void JMFCEKJEDMD(RRNetworkView MMGGIIKGBNM, GBDECDHLMJN OEGGBNKIPPJ);

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[CompilerGenerated]
	private static BGKKKBICAKF NFFLEANPFOC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event LBOKNJPDCLN HGIECGGGFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7E742B0", Offset = "0x7E72CB0", VA = "0x187E742B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7E73590", Offset = "0x7E71F90", VA = "0x187E73590")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event BGKKKBICAKF KOCCMDACCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7E73710", Offset = "0x7E72110", VA = "0x187E73710")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7E73380", Offset = "0x7E71D80", VA = "0x187E73380")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event HPDICNNJHJG IKHIHGMHMAN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7E73D70", Offset = "0x7E72770", VA = "0x187E73D70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7E744F0", Offset = "0x7E72EF0", VA = "0x187E744F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public static event HPDICNNJHJG IEILFCIFCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7E73890", Offset = "0x7E72290", VA = "0x187E73890")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7E73AA0", Offset = "0x7E724A0", VA = "0x187E73AA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public static event CNPNOHOLKDM PPOBLBKBHLL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7E734D0", Offset = "0x7E71ED0", VA = "0x187E734D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7E73650", Offset = "0x7E72050", VA = "0x187E73650")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public static event NCFHFDJHHFM ICEBOFJMCLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7E74430", Offset = "0x7E72E30", VA = "0x187E74430")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7E74370", Offset = "0x7E72D70", VA = "0x187E74370")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event NAHENLADEOK LPHGDFNKPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7E73230", Offset = "0x7E71C30", VA = "0x187E73230")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7E73FB0", Offset = "0x7E729B0", VA = "0x187E73FB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public static event JMFCEKJEDMD PKNIADPJOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7E73950", Offset = "0x7E72350", VA = "0x187E73950")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7E737D0", Offset = "0x7E721D0", VA = "0x187E737D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event JMFCEKJEDMD JBOHNGJCHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7E73CB0", Offset = "0x7E726B0", VA = "0x187E73CB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7E73E30", Offset = "0x7E72830", VA = "0x187E73E30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7E73EF0", Offset = "0x7E728F0", VA = "0x187E73EF0")]
	public static void KIIGNODBMLB([In] BCHAGGJCBIN JKGCHKOAIPN, bool FPHCODJPACE, bool LMFLICBCKAJ, bool IIBLMLHNGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7E73A10", Offset = "0x7E72410", VA = "0x187E73A10")]
	public static void ECJAELKLEJC(GameObject MDCCLJKNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7E73440", Offset = "0x7E71E40", VA = "0x187E73440")]
	public static void ALGNLKHLHDE(GameObject MDCCLJKNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7E745B0", Offset = "0x7E72FB0", VA = "0x187E745B0")]
	public static void POIEKINDBKM(GameObject MDCCLJKNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7E732F0", Offset = "0x7E71CF0", VA = "0x187E732F0")]
	public static void ADHMKKGIMIL(GameObject MDCCLJKNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7E73B60", Offset = "0x7E72560", VA = "0x187E73B60")]
	public static void FHELEOFMNJO(RRNetworkView MMGGIIKGBNM, string KJHKPFJLEEB, GBDECDHLMJN BJBIEGLAMFB, KGENHPLGJBJ? DKLAGICAOGN, bool FAHFEDHIHEI, PJHBHKGEEAK FPBDNNHBBEJ, object[] JKGCHKOAIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7E74170", Offset = "0x7E72B70", VA = "0x187E74170")]
	public static void MMNLFOMPAJB(RRNetworkView MMGGIIKGBNM, string KJHKPFJLEEB, int MKFOGEPCALJ, object[] FOABHHONDMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7E74070", Offset = "0x7E72A70", VA = "0x187E74070")]
	public static void LPOHGGDCKEM(int POHODHGBPHP, int BJBHFAMODGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class MIFPLDNCFJI
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7E84230", Offset = "0x7E82C30", VA = "0x187E84230")]
	[CanBeNull]
	private static bool LLKCKCBKEIB(ViewId KHNIMGKFPOO, [Out] RRNetworkView MMGGIIKGBNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7E84080", Offset = "0x7E82A80", VA = "0x187E84080")]
	[CanBeNull]
	public static Component BHCOICOANCH(this ViewId MMGGIIKGBNM, Type COIEKHIICND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3B50130", Offset = "0x3B4EB30", VA = "0x183B50130")]
	[CanBeNull]
	public static T BHCOICOANCH<T>(this ViewId MMGGIIKGBNM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3B50130", Offset = "0x3B4EB30", VA = "0x183B50130")]
	[CanBeNull]
	public static T PEDHNHABMLB<T>(this ViewId MMGGIIKGBNM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3B500C0", Offset = "0x3B4EAC0", VA = "0x183B500C0")]
	public static bool BEKJFGPGABC<T>(this ViewId MMGGIIKGBNM, [Out] T MGJNMKLFKCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7E84160", Offset = "0x7E82B60", VA = "0x187E84160")]
	[CanBeNull]
	public static RRNetworkView GAHICBPMLNP(this ViewId MMGGIIKGBNM)
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
		private static RRNetworkHandler NMGHOHCNINO;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler FDCAMNOGINK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7E86270", Offset = "0x7E84C70", VA = "0x187E86270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7E86420", Offset = "0x7E84E20", VA = "0x187E86420")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7E863E0", Offset = "0x7E84DE0", VA = "0x187E863E0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public RRNetworkHandler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(JIBJDMOHEAO), new string[] { "Photon" })]
public sealed class JIBJDMOHEAO : APCCBHPCOGC, MJHCLHMDOAB, IIAKOCKOOML, IHANPPPLLHC, PCPOMAIKFAI
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KDBIIMONFBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int requestedViewId;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public KDBIIMONFBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7E818A0", Offset = "0x7E802A0", VA = "0x187E818A0")]
		internal object AJHMNKKLMID((int requestedViewId, int newOwnerId, int senderId) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static COJJKFBGGKB PCHBMGMBHAN;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static COJJKFBGGKB GCIFBDJPDCD;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static Dictionary<int, HashSet<int>> CBFDNAGCPGB;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static Dictionary<int, int> JBENAOPFHEK;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<(GameObject GameObject, int ParentCount)> ADCCGPIAADJ;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<GameObject> NGEGNFHELLK;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static List<int> MPHEBIDOIED;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<RRNetworkView> MCJCEMHIDPE;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly AIJLKOBFKFM PDABADPEGOJ;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly AIJLKOBFKFM ENGEAKOPHJO;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7E81110", Offset = "0x7E7FB10", VA = "0x187E81110", Slot = "8")]
	public void PIJDKGLEIBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7E7FF60", Offset = "0x7E7E960", VA = "0x187E7FF60", Slot = "9")]
	public void NEAHCMEBFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7E7DBE0", Offset = "0x7E7C5E0", VA = "0x187E7DBE0", Slot = "10")]
	public void InitExternal(FKFJNEKJHIE CCGCAONCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7E7A0A0", Offset = "0x7E78AA0", VA = "0x187E7A0A0", Slot = "11")]
	public void CBHKFMHLIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7E7F5F0", Offset = "0x7E7DFF0", VA = "0x187E7F5F0")]
	private void LBPLCLNNMJB(NOAABDNNCAE KCADCJODFHO, NOAABDNNCAE LOPOEJHIPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7E7D6E0", Offset = "0x7E7C0E0", VA = "0x187E7D6E0")]
	private void ILGNCMLDNHJ(ABEGIIDNPGF EACEFKEJDGB, ABEGIIDNPGF KOHECGPMBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7E80F30", Offset = "0x7E7F930", VA = "0x187E80F30")]
	public GameObject PDPGBDIPOHE(string GBCFHNGPBLM, Vector3 JFMEMBGKAOB, Quaternion NGPACIMGGNA, Vector3 JAHHKOMJJAE, ViewId POHODHGBPHP, HFLODILPGJG JKGCHKOAIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7E7B7F0", Offset = "0x7E7A1F0", VA = "0x187E7B7F0")]
	public GameObject EFKFBOLPGBH(string GBCFHNGPBLM, Vector3 JFMEMBGKAOB, Quaternion NGPACIMGGNA, float JAHHKOMJJAE, object[] JKGCHKOAIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7E7B170", Offset = "0x7E79B70", VA = "0x187E7B170")]
	public GameObject DOHCMPFKPFB(string GBCFHNGPBLM, Vector3 JFMEMBGKAOB, Quaternion NGPACIMGGNA, Vector3 JAHHKOMJJAE, ViewId MMGGIIKGBNM, HFLODILPGJG JKGCHKOAIPN, bool IIBLMLHNGLH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7E7F710", Offset = "0x7E7E110", VA = "0x187E7F710")]
	public GameObject LDHHKLIKBEN(BCHAGGJCBIN JKGCHKOAIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7E7B150", Offset = "0x7E79B50", VA = "0x187E7B150", Slot = "6")]
	public void CHBBFDPCPNN(GameObject MDCCLJKNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7E81470", Offset = "0x7E7FE70", VA = "0x187E81470")]
	public void PPINJMKDKLO(GameObject HNGFDIJGINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7E7B160", Offset = "0x7E79B60", VA = "0x187E7B160", Slot = "7")]
	public void DHEBJBFOIED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7E79070", Offset = "0x7E77A70", VA = "0x187E79070", Slot = "4")]
	public GameObject[] AGFBCJOLFCH(IList<EHOGLJMNICP> CONHHEBAINP, bool KBCMFMDFMLA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7E805B0", Offset = "0x7E7EFB0", VA = "0x187E805B0", Slot = "5")]
	public void NGHIIMKFKMK(List<GameObject> LGEEGHMACEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E7F740", Offset = "0x7E7E140", VA = "0x187E7F740")]
	public void LNNGDFENIIM(GameObject HNGFDIJGINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7E802C0", Offset = "0x7E7ECC0", VA = "0x187E802C0")]
	private void NENNEGLPAFI(HCCHCCGILAH JEMDJIEKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E79EE0", Offset = "0x7E788E0", VA = "0x187E79EE0")]
	private void CALJEKGEOFL(HCCHCCGILAH JEMDJIEKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7E7E3F0", Offset = "0x7E7CDF0", VA = "0x187E7E3F0")]
	private void JCGIHMHPHFG(HCCHCCGILAH JEMDJIEKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E7B510", Offset = "0x7E79F10", VA = "0x187E7B510")]
	private void EDADLEIDPIF(HCCHCCGILAH JEMDJIEKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E7F820", Offset = "0x7E7E220", VA = "0x187E7F820")]
	private void LOPHPFHFPMK(HCCHCCGILAH JEMDJIEKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7E7D7E0", Offset = "0x7E7C1E0", VA = "0x187E7D7E0")]
	private void IMFFOEBKJKC(HCCHCCGILAH JEMDJIEKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7E7DDB0", Offset = "0x7E7C7B0", VA = "0x187E7DDB0")]
	private void JAKAMFFDDAP(HCCHCCGILAH JEMDJIEKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7E7EAF0", Offset = "0x7E7D4F0", VA = "0x187E7EAF0")]
	private GameObject JNPMCPHJJLN(string DBLNPCOHJMA, Vector3 JFMEMBGKAOB, Quaternion NGPACIMGGNA, Vector3 JAHHKOMJJAE, byte AJEELMNCDNB = 0, [Optional] object[] HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7E7C3E0", Offset = "0x7E7ADE0", VA = "0x187E7C3E0")]
	private GameObject GPOJDOKODDO(BCHAGGJCBIN JKGCHKOAIPN, bool FPHCODJPACE = false, bool LMFLICBCKAJ = false, bool IIBLMLHNGLH = true, bool PAMPGCGBJPE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7E80970", Offset = "0x7E7F370", VA = "0x187E80970")]
	private static GameObject NPLIIHAMIAP(string DBLNPCOHJMA, bool PAGKKLMNHNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7E79CD0", Offset = "0x7E786D0", VA = "0x187E79CD0")]
	private static GameObject BNMCDMHHPCD(GameObject ANGPMLNFAIK, BCHAGGJCBIN JKGCHKOAIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7E7B400", Offset = "0x7E79E00", VA = "0x187E7B400")]
	private static void ECJNIPHKMHD(GameObject MDCCLJKNLLP, RRNetworkView MMGGIIKGBNM, [In] BCHAGGJCBIN JKGCHKOAIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7E79490", Offset = "0x7E77E90", VA = "0x187E79490")]
	private GameObject[] BLNJIHOLCAL(IList<EHOGLJMNICP> CONHHEBAINP, bool KBCMFMDFMLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7E7FBC0", Offset = "0x7E7E5C0", VA = "0x187E7FBC0")]
	private GameObject[] MBOHKOBGOLD(BCHAGGJCBIN[] CAIHDKKACCK, int BCHHOFOFBKL, GBDECDHLMJN KPIDJKLDGJJ, GameObject[] CDDNEJEIIBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7E7E6A0", Offset = "0x7E7D0A0", VA = "0x187E7E6A0")]
	private GameObject JHCIICAABJE([In] BCHAGGJCBIN JKGCHKOAIPN, GameObject ANGPMLNFAIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x71A7B80", Offset = "0x71A6580", VA = "0x1871A7B80")]
	private static bool CCMDBHCAJOF(bool FPHCODJPACE, bool IIBLMLHNGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7E7CAD0", Offset = "0x7E7B4D0", VA = "0x187E7CAD0")]
	private void IALGLDCGBIM(IEnumerable<GameObject> LGEEGHMACEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7E7A270", Offset = "0x7E78C70", VA = "0x187E7A270")]
	private void CGFFNAJNKJF(GameObject MDCCLJKNLLP, bool PAMPGCGBJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7E7F1F0", Offset = "0x7E7DBF0", VA = "0x187E7F1F0")]
	private static void LBGAPNHDFKP(IEnumerable<GameObject> KOHKCCNNBDH, List<(GameObject GameObject, int ParentCount)> CBIHEFCNGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7E7C1E0", Offset = "0x7E7ABE0", VA = "0x187E7C1E0")]
	private void GLONICOJCLB(int KCAHOJHAGKP, int BCHHOFOFBKL, bool PAMPGCGBJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7E7C340", Offset = "0x7E7AD40", VA = "0x187E7C340")]
	private static int GOJDMEAJEJM(int KCAHOJHAGKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7E79430", Offset = "0x7E77E30", VA = "0x187E79430")]
	private void BHDACKINJEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7E809F0", Offset = "0x7E7F3F0", VA = "0x187E809F0")]
	private void ONHNPBBFBLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7E7C180", Offset = "0x7E7AB80", VA = "0x187E7C180")]
	private static int FMAKLPODJDJ(int NHFPGBAFPBD, bool IIBLMLHNGLH = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7E7B8E0", Offset = "0x7E7A2E0", VA = "0x187E7B8E0")]
	private static int[] ELCFMAPNFDA(int GPOHFOCLKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7E7FE60", Offset = "0x7E7E860", VA = "0x187E7FE60")]
	private static int[] MCCNONPCNKE(int BBAFJLLBENK, int GPOHFOCLKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7E7EAB0", Offset = "0x7E7D4B0", VA = "0x187E7EAB0")]
	private void JIDLHFGGFEH(GBDECDHLMJN GKJDHMPBADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7E7B9C0", Offset = "0x7E7A3C0", VA = "0x187E7B9C0")]
	private void FACKHGKBLIN(GBDECDHLMJN KPIDJKLDGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7E7EF20", Offset = "0x7E7D920", VA = "0x187E7EF20")]
	private void LAADHLHEKNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7E7ECE0", Offset = "0x7E7D6E0", VA = "0x187E7ECE0")]
	private void KGOOIPDMOBG(GBDECDHLMJN KPIDJKLDGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7E79390", Offset = "0x7E77D90", VA = "0x187E79390")]
	private static void BDIDGOOJCHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7E78F70", Offset = "0x7E77970", VA = "0x187E78F70")]
	private void ADBCNIDFBAG(int[] JOELKHGPMHN, int DLMCELCIALD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public JIBJDMOHEAO()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public RRNetworkProfiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(BPIAKOBJPCE), new string[] { "Photon" })]
public class BPIAKOBJPCE : MJHCLHMDOAB, IIAKOCKOOML, HJCHDPGBPHP
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct JKGNBIKIHFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly MethodInfo CMEBAMDOCHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly Func<MonoBehaviour, object> PLAEPGDLCID;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xB64460", Offset = "0xB62E60", VA = "0x180B64460")]
		public JKGNBIKIHFE(MethodInfo CMEBAMDOCHF, [Optional] Func<MonoBehaviour, object> PLAEPGDLCID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x71C22F0", Offset = "0x71C0CF0", VA = "0x1871C22F0")]
		public object BFGKDNBMOBP(MonoBehaviour GMEIIMMOOMA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OJPFDPGHGAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public FieldInfo instanceAccessFromField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<MonoBehaviour, object> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public OJPFDPGHGAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7E846B0", Offset = "0x7E830B0", VA = "0x187E846B0")]
		internal JKGNBIKIHFE OAODDBJNKIP(MethodInfo methodInfo)
		{
			return default(JKGNBIKIHFE);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x47786E0", Offset = "0x47770E0", VA = "0x1847786E0")]
		internal object OADFFPBFGEO(MonoBehaviour mb)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class BGIDKEAKOKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Func<MonoBehaviour, object> accessor;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public BGIDKEAKOKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x71A4230", Offset = "0x71A2C30", VA = "0x1871A4230")]
		internal JKGNBIKIHFE AOCOCHHGKKL(MethodInfo methodInfo)
		{
			return default(JKGNBIKIHFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class HIGNHFDOFIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Type attributeType;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HIGNHFDOFIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7E75D70", Offset = "0x7E74770", VA = "0x187E75D70")]
		internal bool DBEELDCCMIO(MethodInfo m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly Stopwatch DGLFJKILIIN;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Dictionary<MethodInfo, ParameterInfo[]> LJFMHCHDPBO;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly Dictionary<Type, List<JKGNBIKIHFE>> FPNOPAIECOL;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7E6FA20", Offset = "0x7E6E420", VA = "0x187E6FA20", Slot = "4")]
	public void PIJDKGLEIBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7E6F3F0", Offset = "0x7E6DDF0", VA = "0x187E6F3F0", Slot = "5")]
	public void NEAHCMEBFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7E6F540", Offset = "0x7E6DF40", VA = "0x187E6F540")]
	private void NENNEGLPAFI(HCCHCCGILAH JEMDJIEKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7E6C400", Offset = "0x7E6AE00", VA = "0x187E6C400", Slot = "9")]
	public string AMCILNEHCJK(HCCHCCGILAH JEMDJIEKJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7E6F200", Offset = "0x7E6DC00", VA = "0x187E6F200", Slot = "8")]
	public void HDPGMIKIEGL(ViewId POHODHGBPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7E6C460", Offset = "0x7E6AE60", VA = "0x187E6C460", Slot = "6")]
	public void DGAIPBNBGNL(ViewId MMGGIIKGBNM, string KJHKPFJLEEB, GBDECDHLMJN KPIDJKLDGJJ, PJHBHKGEEAK FPBDNNHBBEJ, params object[] JKGCHKOAIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7E6C430", Offset = "0x7E6AE30", VA = "0x187E6C430", Slot = "7")]
	public void DGAIPBNBGNL(ViewId MMGGIIKGBNM, string KJHKPFJLEEB, KGENHPLGJBJ DKLAGICAOGN, PJHBHKGEEAK FPBDNNHBBEJ, params object[] JKGCHKOAIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7E6C530", Offset = "0x7E6AF30", VA = "0x187E6C530")]
	private void DGAIPBNBGNL(ViewId MMGGIIKGBNM, string KJHKPFJLEEB, KGENHPLGJBJ DKLAGICAOGN, GBDECDHLMJN KPIDJKLDGJJ, PJHBHKGEEAK FPBDNNHBBEJ, params object[] JKGCHKOAIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7E6D4F0", Offset = "0x7E6BEF0", VA = "0x187E6D4F0")]
	private void FDCIJKKCMFK(ViewId POHODHGBPHP, string KJHKPFJLEEB, GBDECDHLMJN GAMOJFHOMGC, int ENCFEMPDCCA, object[] FOABHHONDMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7E6BF70", Offset = "0x7E6A970", VA = "0x187E6BF70")]
	private static void ADLJFLGNCME(JKGNBIKIHFE PAANMNLCKIA, MonoBehaviour HEKNALPHJEO, object[] MPEOAHOICFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7E6F7F0", Offset = "0x7E6E1F0", VA = "0x187E6F7F0")]
	private static bool ODFFOEECJOF(ParameterInfo[] OFPOHMCKLBG, Type[] GDIBJHKDCKK, [Out] bool EHDBJPMFBED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7E6CA00", Offset = "0x7E6B400", VA = "0x187E6CA00")]
	private List<JKGNBIKIHFE> EEIKELOFGEO(MonoBehaviour HEKNALPHJEO, Type JBHDFIOHJKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7E6D3F0", Offset = "0x7E6BDF0", VA = "0x187E6D3F0")]
	private static IEnumerable<MethodInfo> EIEFEDABNLL(Type HHCAOFMCNLG, Type DELCMJGNGJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7E6F2E0", Offset = "0x7E6DCE0", VA = "0x187E6F2E0")]
	public static ParameterInfo[] HOJFAMAFLIL(MethodInfo EILOOFKALED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public BPIAKOBJPCE()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, AOOENPIJLCF, KDPDILGOJMC, GLKONMGDJKH, ABMABIKDNCI, JBKJHLPCIFD
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum OLFOKEAGACK
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
		private sealed class DCLBNJMGFNB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public int actorNumber;

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public DCLBNJMGFNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x7E6FE40", Offset = "0x7E6E840", VA = "0x187E6FE40")]
			internal bool DMCKKMCMAJA(RRNetworkView view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static Dictionary<int, RRNetworkView> LFIOCDIMFMD;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static AIJLKOBFKFM DIDONEIIJEK;

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
		private bool NACIDLGDLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		internal bool KKONCLPNPPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Tooltip("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		[SerializeField]
		public OLFOKEAGACK hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool EBLIIIMKDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool GPGBDBJFADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int GCCMCIGFIBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private bool EJCJDAPILPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int DDAJAGEMFKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private GBDECDHLMJN BBAFJLLBENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private GBDECDHLMJN OKECAJENOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool? DBFFBFHELJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool IONILDJAHMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		internal bool OBPHKMNAACN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		internal MonoBehaviour[] JDHIJHJGDFP;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly COJJKFBGGKB LAALKNPOODD;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ViewId IBJKJLLCLHE
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B6B0", Offset = "0x7E8A0B0", VA = "0x187E8B6B0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ViewId FDIENAPAFLF
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B6B0", Offset = "0x7E8A0B0", VA = "0x187E8B6B0", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId LHCDLGAONDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B6B0", Offset = "0x7E8A0B0", VA = "0x187E8B6B0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int CEMNNGEJAFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xA16630", Offset = "0xA15030", VA = "0x180A16630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int ELENFCDPOCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA32DA0", Offset = "0xA317A0", VA = "0x180A32DA0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xDF8840", Offset = "0xDF7240", VA = "0x180DF8840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ViewId CGNILFGCEKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B520", Offset = "0x7E89F20", VA = "0x187E8B520")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool OBLENHAAONG
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA10D70", Offset = "0xA0F770", VA = "0x180A10D70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xA10D60", Offset = "0xA0F760", VA = "0x180A10D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool BPOKOCEFLCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B530", Offset = "0x7E89F30", VA = "0x187E8B530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool DKGCLLDKBCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xA6EB70", Offset = "0xA6D570", VA = "0x180A6EB70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xA6E7D0", Offset = "0xA6D1D0", VA = "0x180A6E7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int MKBFGECGGMG
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xA5A900", Offset = "0xA59300", VA = "0x180A5A900")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int FKCJJJJDOLN
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B4C0", Offset = "0x7E89EC0", VA = "0x187E8B4C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public GBDECDHLMJN IPCKBKAKDGC
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B6C0", Offset = "0x7E8A0C0", VA = "0x187E8B6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public GBDECDHLMJN GGGLHKOMPOB
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B490", Offset = "0x7E89E90", VA = "0x187E8B490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public GBDECDHLMJN NPDGLACCHNF
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B490", Offset = "0x7E89E90", VA = "0x187E8B490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public GBDECDHLMJN EGOGPAPMIMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B490", Offset = "0x7E89E90", VA = "0x187E8B490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool GPPEIPLPABK
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B600", Offset = "0x7E8A000", VA = "0x187E8B600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public int IDDIEEKCGIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B4F0", Offset = "0x7E89EF0", VA = "0x187E8B4F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public object[] FBIGOJCICMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA091E0", Offset = "0xA07BE0", VA = "0x180A091E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA09180", Offset = "0xA07B80", VA = "0x180A09180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool FMAAHCDKFEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B6F0", Offset = "0x7E8A0F0", VA = "0x187E8B6F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool LBIEFJBDIMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B680", Offset = "0x7E8A080", VA = "0x187E8B680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool BEOAIADIFDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xDC95A0", Offset = "0xDC7FA0", VA = "0x180DC95A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xF11DB0", Offset = "0xF107B0", VA = "0x180F11DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool DHDBIEJCKNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xC77AD0", Offset = "0xC764D0", VA = "0x180C77AD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> AEFFFMLABNI
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B330", Offset = "0x7E89D30", VA = "0x187E8B330")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B8B0", Offset = "0x7E8A2B0", VA = "0x187E8B8B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<GBDECDHLMJN> JCCCOCHHDNN
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7E87C20", Offset = "0x7E86620", VA = "0x187E87C20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7E87260", Offset = "0x7E85C60", VA = "0x187E87260")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<GBDECDHLMJN> BGLLCLKBDJD
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7E87C20", Offset = "0x7E86620", VA = "0x187E87C20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7E87260", Offset = "0x7E85C60", VA = "0x187E87260")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> CEDHOKJHKNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7E86C70", Offset = "0x7E85670", VA = "0x187E86C70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7E868C0", Offset = "0x7E852C0", VA = "0x187E868C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> GHNLNNLHLJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7E86C70", Offset = "0x7E85670", VA = "0x187E86C70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x7E868C0", Offset = "0x7E852C0", VA = "0x187E868C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> MMJPLOMONKO
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B3E0", Offset = "0x7E89DE0", VA = "0x187E8B3E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B960", Offset = "0x7E8A360", VA = "0x187E8B960")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action IIJDCNLMDPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B280", Offset = "0x7E89C80", VA = "0x187E8B280")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x7E8B800", Offset = "0x7E8A200", VA = "0x187E8B800")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7E8B0C0", Offset = "0x7E89AC0", VA = "0x187E8B0C0")]
		public static bool TryGetNetworkView(int POHODHGBPHP, [Out] RRNetworkView MMGGIIKGBNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7E86E00", Offset = "0x7E85800", VA = "0x187E86E00")]
		public static RRNetworkView Find(int POHODHGBPHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7E86FF0", Offset = "0x7E859F0", VA = "0x187E86FF0")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int KJCCMAJJDNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7E86F80", Offset = "0x7E85980", VA = "0x187E86F80")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7E88830", Offset = "0x7E87230", VA = "0x187E88830")]
		public static bool RemoveNetworkView(RRNetworkView MMGGIIKGBNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7E88600", Offset = "0x7E87000", VA = "0x187E88600")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7E87F30", Offset = "0x7E86930", VA = "0x187E87F30")]
		public static void OnPlayerJoinedRoom(GBDECDHLMJN BMGANHBBEFA, List<int> JOELKHGPMHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7E87130", Offset = "0x7E85B30", VA = "0x187E87130")]
		public static RRNetworkView Get(Component FDMBFEDKLFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7E87190", Offset = "0x7E85B90", VA = "0x187E87190")]
		public static RRNetworkView Get(GameObject CMHOFEEALDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7E86D20", Offset = "0x7E85720", VA = "0x187E86D20")]
		private void FPJNBOCKKFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7E86840", Offset = "0x7E85240", VA = "0x187E86840")]
		public bool CreatedBy(GBDECDHLMJN KPIDJKLDGJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7E8AED0", Offset = "0x7E898D0", VA = "0x187E8AED0")]
		public void TransferOwnership(int DNFMPCLBKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7E8AE70", Offset = "0x7E89870", VA = "0x187E8AE70")]
		public void TransferOwnership(GBDECDHLMJN OEGGBNKIPPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7E87460", Offset = "0x7E85E60", VA = "0x187E87460", Slot = "4")]
		public void Initialize(ViewId OONHBDPLCKB, ViewId GIPPHEHKPKC, Dictionary<int, object> FHONBPKKLIE, PGNMDKGFDBN BBAFJLLBENK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7E875E0", Offset = "0x7E85FE0", VA = "0x187E875E0")]
		public void Initialize(ViewId OONHBDPLCKB, ViewId GIPPHEHKPKC, object[] DMNCHBINFKO, PGNMDKGFDBN BBAFJLLBENK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7E86460", Offset = "0x7E84E60", VA = "0x187E86460")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7E86970", Offset = "0x7E85370", VA = "0x187E86970")]
		private void DOLDADJDIFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1EDE540", Offset = "0x1EDCF40", VA = "0x181EDE540")]
		internal void GMGANAJNFLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7E88280", Offset = "0x7E86C80", VA = "0x187E88280", Slot = "6")]
		private void PAOOFKFENLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7E871F0", Offset = "0x7E85BF0", VA = "0x187E871F0")]
		internal bool HEIAKIMJICA(RRNetworkView HEDNGALAFBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7E87D90", Offset = "0x7E86790", VA = "0x187E87D90")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7E87960", Offset = "0x7E86360", VA = "0x187E87960")]
		internal void KKCLFJPFBED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7E86BE0", Offset = "0x7E855E0", VA = "0x187E86BE0")]
		private void ELBDENBPODB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7E87CD0", Offset = "0x7E866D0", VA = "0x187E87CD0")]
		internal void NCALIOAMGPJ(GBDECDHLMJN OEGGBNKIPPJ, int DNFMPCLBKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7E88790", Offset = "0x7E87190", VA = "0x187E88790")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7E888B0", Offset = "0x7E872B0", VA = "0x187E888B0")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7E88340", Offset = "0x7E86D40", VA = "0x187E88340")]
		private void PGNDEJDDNPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7E86E90", Offset = "0x7E85890", VA = "0x187E86E90")]
		private void GJHNLFDFNMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7E88570", Offset = "0x7E86F70", VA = "0x187E88570")]
		public void RPC(string KJHKPFJLEEB, KGENHPLGJBJ DKLAGICAOGN, params object[] JKGCHKOAIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7E884E0", Offset = "0x7E86EE0", VA = "0x187E884E0")]
		public void RPC(string KJHKPFJLEEB, GBDECDHLMJN BJBIEGLAMFB, params object[] JKGCHKOAIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7E887E0", Offset = "0x7E871E0", VA = "0x187E887E0")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7E86560", Offset = "0x7E84F60", VA = "0x187E86560", Slot = "8")]
		public void Bake(OKBMAOLKCPM GJIMIGJJJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7E86BF0", Offset = "0x7E855F0", VA = "0x187E86BF0")]
		private static void EPCCFGCGNHG(GBDECDHLMJN IKJHHAOIKGK, [Out] GBDECDHLMJN DCMMAAEJIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7E87640", Offset = "0x7E86040", VA = "0x187E87640")]
		private static void JHJKBFGPAHA(RRNetworkView GNNAFAGJBDF, Delegate PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7E86B60", Offset = "0x7E85560", VA = "0x187E86B60")]
		private static ANACEAMGMLK EHCGNDOJOBN(RRNetworkView GNNAFAGJBDF)
		{
			return default(ANACEAMGMLK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7E864C0", Offset = "0x7E84EC0", VA = "0x187E864C0")]
		private static LFDJLIAPKMA BANKBBMCGMC(RRNetworkView GNNAFAGJBDF)
		{
			return default(LFDJLIAPKMA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7E879C0", Offset = "0x7E863C0", VA = "0x187E879C0")]
		private static void LBEHKEHNIKB(RRNetworkView GNNAFAGJBDF, Delegate PAANMNLCKIA, GBDECDHLMJN CAJJMICIHPL, params object[] JKGCHKOAIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7E87AA0", Offset = "0x7E864A0", VA = "0x187E87AA0")]
		private static void LBEHKEHNIKB(RRNetworkView GNNAFAGJBDF, Delegate PAANMNLCKIA, KGENHPLGJBJ CAJJMICIHPL, params object[] JKGCHKOAIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7E87310", Offset = "0x7E85D10", VA = "0x187E87310")]
		private static void IAMOODHPNIB(RRNetworkView GNNAFAGJBDF, Delegate PAANMNLCKIA, KGENHPLGJBJ CAJJMICIHPL, BAKNFIIHGGM KEKIEPPKACO, params object[] JKGCHKOAIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7E883E0", Offset = "0x7E86DE0", VA = "0x187E883E0")]
		public void RPCBuffered(string KJHKPFJLEEB, KGENHPLGJBJ DKLAGICAOGN, BAKNFIIHGGM FPBDNNHBBEJ, params object[] JKGCHKOAIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7E87B80", Offset = "0x7E86580", VA = "0x187E87B80")]
		private static bool LGDKPHJFDKN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7E88F30", Offset = "0x7E87930", VA = "0x187E88F30", Slot = "26")]
		public void RpcAll(JFGAMMLOFIO.JLNGAIDNFNM PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3CE42F0", Offset = "0x3CE2CF0", VA = "0x183CE42F0", Slot = "9")]
		public void RpcAll<T1>(JFGAMMLOFIO.GBNMBEPAKNI<T1> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3B40", Offset = "0x3CE2540", VA = "0x183CE3B40", Slot = "10")]
		public void RpcAll<T1, T2>(JFGAMMLOFIO.COGKFABEFLE<T1, T2> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5FD0", Offset = "0x3CE49D0", VA = "0x183CE5FD0", Slot = "27")]
		public void RpcAll<T1, T2, T3>(JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, T3> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3D60", Offset = "0x3CE2760", VA = "0x183CE3D60", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, T4> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5980", Offset = "0x3CE4380", VA = "0x183CE5980", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, T5> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3CE64D0", Offset = "0x3CE4ED0", VA = "0x183CE64D0", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, T6> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3CE6FC0", Offset = "0x3CE59C0", VA = "0x183CE6FC0", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, T7> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3CEBA80", Offset = "0x3CEA480", VA = "0x183CEBA80", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, T8> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3CE6980", Offset = "0x3CE5380", VA = "0x183CE6980", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, T9> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3CE4D70", Offset = "0x3CE3770", VA = "0x183CE4D70", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3CF28F0", Offset = "0x3CF12F0", VA = "0x183CF28F0", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3CF1830", Offset = "0x3CF0230", VA = "0x183CF1830", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0C60", Offset = "0x3CEF660", VA = "0x183CF0C60", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3CE4480", Offset = "0x3CE2E80", VA = "0x183CE4480", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7E892D0", Offset = "0x7E87CD0", VA = "0x187E892D0")]
		public void RpcAll(JFGAMMLOFIO.GBNMBEPAKNI<ANACEAMGMLK> PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3CE9040", Offset = "0x3CE7A40", VA = "0x183CE9040")]
		public void RpcAll<T1>(JFGAMMLOFIO.COGKFABEFLE<T1, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3CE9A90", Offset = "0x3CE8490", VA = "0x183CE9A90")]
		public void RpcAll<T1, T2>(JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5660", Offset = "0x3CE4060", VA = "0x183CE5660")]
		public void RpcAll<T1, T2, T3>(JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7C40", Offset = "0x3CF6640", VA = "0x183CF7C40")]
		public void RpcAll<T1, T2, T3, T4>(JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3CF76D0", Offset = "0x3CF60D0", VA = "0x183CF76D0")]
		public void RpcAll<T1, T2, T3, T4, T5>(JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3CF66E0", Offset = "0x3CF50E0", VA = "0x183CF66E0")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5F60", Offset = "0x3CF4960", VA = "0x183CF5F60")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5380", Offset = "0x3CF3D80", VA = "0x183CF5380")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4B00", Offset = "0x3CF3500", VA = "0x183CF4B00")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3CF3D20", Offset = "0x3CF2720", VA = "0x183CF3D20")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3CF2390", Offset = "0x3CF0D90", VA = "0x183CF2390")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3CF1260", Offset = "0x3CEFC60", VA = "0x183CF1260")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0620", Offset = "0x3CEF020", VA = "0x183CF0620")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3CEF930", Offset = "0x3CEE330", VA = "0x183CEF930")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EBFDHAMOBHF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7E890A0", Offset = "0x7E87AA0", VA = "0x187E890A0", Slot = "36")]
		public void RpcAll(JFGAMMLOFIO.GBNMBEPAKNI<LFDJLIAPKMA> PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3CFC4C0", Offset = "0x3CFAEC0", VA = "0x183CFC4C0", Slot = "37")]
		public void RpcAll<T1>(JFGAMMLOFIO.COGKFABEFLE<T1, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3CFA140", Offset = "0x3CF8B40", VA = "0x183CFA140", Slot = "38")]
		public void RpcAll<T1, T2>(JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3CF8C30", Offset = "0x3CF7630", VA = "0x183CF8C30", Slot = "39")]
		public void RpcAll<T1, T2, T3>(JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7F00", Offset = "0x3CF6900", VA = "0x183CF7F00", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3CF73C0", Offset = "0x3CF5DC0", VA = "0x183CF73C0", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6D80", Offset = "0x3CF5780", VA = "0x183CF6D80", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6320", Offset = "0x3CF4D20", VA = "0x183CF6320", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3CF57B0", Offset = "0x3CF41B0", VA = "0x183CF57B0", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4670", Offset = "0x3CF3070", VA = "0x183CF4670", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3CF3820", Offset = "0x3CF2220", VA = "0x183CF3820", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3CF2E00", Offset = "0x3CF1800", VA = "0x183CF2E00", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3CF1DC0", Offset = "0x3CF07C0", VA = "0x183CF1DC0", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3CEFFE0", Offset = "0x3CEE9E0", VA = "0x183CEFFE0", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3CEEC10", Offset = "0x3CED610", VA = "0x183CEEC10", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EBFDHAMOBHF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7E88BA0", Offset = "0x7E875A0", VA = "0x187E88BA0", Slot = "51")]
		public void RpcAllViaServer(JFGAMMLOFIO.JLNGAIDNFNM PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3A30", Offset = "0x3CE2430", VA = "0x183CE3A30", Slot = "52")]
		public void RpcAllViaServer<T1>(JFGAMMLOFIO.GBNMBEPAKNI<T1> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3CDB370", Offset = "0x3CD9D70", VA = "0x183CDB370", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(JFGAMMLOFIO.COGKFABEFLE<T1, T2> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3090", Offset = "0x3CE1A90", VA = "0x183CE3090", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, T3> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2CD0", Offset = "0x3CE16D0", VA = "0x183CE2CD0", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, T4> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3CE23F0", Offset = "0x3CE0DF0", VA = "0x183CE23F0", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, T5> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1EE0", Offset = "0x3CE08E0", VA = "0x183CE1EE0", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, T6> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1380", Offset = "0x3CDFD80", VA = "0x183CE1380", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, T7> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3CE0D30", Offset = "0x3CDF730", VA = "0x183CE0D30", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, T8> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3CDFF50", Offset = "0x3CDE950", VA = "0x183CDFF50", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, T9> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3CDF3D0", Offset = "0x3CDDDD0", VA = "0x183CDF3D0", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3CDE320", Offset = "0x3CDCD20", VA = "0x183CDE320", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3CDD570", Offset = "0x3CDBF70", VA = "0x183CDD570", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3CDCB90", Offset = "0x3CDB590", VA = "0x183CDCB90", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3CDC160", Offset = "0x3CDAB60", VA = "0x183CDC160", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7E88E00", Offset = "0x7E87800", VA = "0x187E88E00")]
		public void RpcAllViaServer(JFGAMMLOFIO.GBNMBEPAKNI<ANACEAMGMLK> PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3810", Offset = "0x3CE2210", VA = "0x183CE3810")]
		public void RpcAllViaServer<T1>(JFGAMMLOFIO.COGKFABEFLE<T1, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3CE33F0", Offset = "0x3CE1DF0", VA = "0x183CE33F0")]
		public void RpcAllViaServer<T1, T2>(JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3240", Offset = "0x3CE1C40", VA = "0x183CE3240")]
		public void RpcAllViaServer<T1, T2, T3>(JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3CE28B0", Offset = "0x3CE12B0", VA = "0x183CE28B0")]
		public void RpcAllViaServer<T1, T2, T3, T4>(JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2650", Offset = "0x3CE1050", VA = "0x183CE2650")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1C30", Offset = "0x3CE0630", VA = "0x183CE1C30")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1080", Offset = "0x3CDFA80", VA = "0x183CE1080")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3CE09E0", Offset = "0x3CDF3E0", VA = "0x183CE09E0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3CDFBB0", Offset = "0x3CDE5B0", VA = "0x183CDFBB0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3CDF7C0", Offset = "0x3CDE1C0", VA = "0x183CDF7C0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3CDEBA0", Offset = "0x3CDD5A0", VA = "0x183CDEBA0")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3CDDA00", Offset = "0x3CDC400", VA = "0x183CDDA00")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3CDD080", Offset = "0x3CDBA80", VA = "0x183CDD080")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3CDBC20", Offset = "0x3CDA620", VA = "0x183CDBC20")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EBFDHAMOBHF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7E88CD0", Offset = "0x7E876D0", VA = "0x187E88CD0", Slot = "65")]
		public void RpcAllViaServer(JFGAMMLOFIO.GBNMBEPAKNI<LFDJLIAPKMA> PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3920", Offset = "0x3CE2320", VA = "0x183CE3920", Slot = "66")]
		public void RpcAllViaServer<T1>(JFGAMMLOFIO.COGKFABEFLE<T1, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3550", Offset = "0x3CE1F50", VA = "0x183CE3550", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2EE0", Offset = "0x3CE18E0", VA = "0x183CE2EE0", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2AC0", Offset = "0x3CE14C0", VA = "0x183CE2AC0", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2190", Offset = "0x3CE0B90", VA = "0x183CE2190", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1980", Offset = "0x3CE0380", VA = "0x183CE1980", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1680", Offset = "0x3CE0080", VA = "0x183CE1680", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3CE0690", Offset = "0x3CDF090", VA = "0x183CE0690", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3CE02F0", Offset = "0x3CDECF0", VA = "0x183CE02F0", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3CDEFE0", Offset = "0x3CDD9E0", VA = "0x183CDEFE0", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3CDE760", Offset = "0x3CDD160", VA = "0x183CDE760", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3CDDE90", Offset = "0x3CDC890", VA = "0x183CDDE90", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3CDC6A0", Offset = "0x3CDB0A0", VA = "0x183CDC6A0", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3CDB6E0", Offset = "0x3CDA0E0", VA = "0x183CDB6E0", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EBFDHAMOBHF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7E8A5B0", Offset = "0x7E88FB0", VA = "0x187E8A5B0", Slot = "80")]
		public void RpcOthers(JFGAMMLOFIO.JLNGAIDNFNM PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3D2C150", Offset = "0x3D2AB50", VA = "0x183D2C150", Slot = "15")]
		public void RpcOthers<T1>(JFGAMMLOFIO.GBNMBEPAKNI<T1> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3D2CA50", Offset = "0x3D2B450", VA = "0x183D2CA50", Slot = "81")]
		public void RpcOthers<T1, T2>(JFGAMMLOFIO.COGKFABEFLE<T1, T2> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D2BED0", Offset = "0x3D2A8D0", VA = "0x183D2BED0", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, T3> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D35760", Offset = "0x3D34160", VA = "0x183D35760", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, T4> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D800", Offset = "0x3D2C200", VA = "0x183D2D800", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, T5> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3D34810", Offset = "0x3D33210", VA = "0x183D34810", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, T6> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D33BE0", Offset = "0x3D325E0", VA = "0x183D33BE0", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, T7> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D33500", Offset = "0x3D31F00", VA = "0x183D33500", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, T8> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D32A10", Offset = "0x3D31410", VA = "0x183D32A10", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, T9> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3D31E30", Offset = "0x3D30830", VA = "0x183D31E30", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3D30D00", Offset = "0x3D2F700", VA = "0x183D30D00", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3D2FEC0", Offset = "0x3D2E8C0", VA = "0x183D2FEC0", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F4A0", Offset = "0x3D2DEA0", VA = "0x183D2F4A0", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3D2DF40", Offset = "0x3D2C940", VA = "0x183D2DF40", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7E8A310", Offset = "0x7E88D10", VA = "0x187E8A310")]
		public void RpcOthers(JFGAMMLOFIO.GBNMBEPAKNI<ANACEAMGMLK> PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3D2C790", Offset = "0x3D2B190", VA = "0x183D2C790")]
		public void RpcOthers<T1>(JFGAMMLOFIO.COGKFABEFLE<T1, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3D2C5A0", Offset = "0x3D2AFA0", VA = "0x183D2C5A0")]
		public void RpcOthers<T1, T2>(JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3D365A0", Offset = "0x3D34FA0", VA = "0x183D365A0")]
		public void RpcOthers<T1, T2, T3>(JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3D2C2B0", Offset = "0x3D2ACB0", VA = "0x183D2C2B0")]
		public void RpcOthers<T1, T2, T3, T4>(JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3D2CF60", Offset = "0x3D2B960", VA = "0x183D2CF60")]
		public void RpcOthers<T1, T2, T3, T4, T5>(JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D2B0", Offset = "0x3D2BCB0", VA = "0x183D2D2B0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3D34220", Offset = "0x3D32C20", VA = "0x183D34220")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3D33190", Offset = "0x3D31B90", VA = "0x183D33190")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3D32650", Offset = "0x3D31050", VA = "0x183D32650")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3D32240", Offset = "0x3D30C40", VA = "0x183D32240")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D315C0", Offset = "0x3D2FFC0", VA = "0x183D315C0")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3D30840", Offset = "0x3D2F240", VA = "0x183D30840")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EF90", Offset = "0x3D2D990", VA = "0x183D2EF90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EA20", Offset = "0x3D2D420", VA = "0x183D2EA20")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EBFDHAMOBHF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7E8A460", Offset = "0x7E88E60", VA = "0x187E8A460", Slot = "93")]
		public void RpcOthers(JFGAMMLOFIO.GBNMBEPAKNI<LFDJLIAPKMA> PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3D37610", Offset = "0x3D36010", VA = "0x183D37610", Slot = "94")]
		public void RpcOthers<T1>(JFGAMMLOFIO.COGKFABEFLE<T1, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3D36D40", Offset = "0x3D35740", VA = "0x183D36D40", Slot = "95")]
		public void RpcOthers<T1, T2>(JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3D36960", Offset = "0x3D35360", VA = "0x183D36960", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3D35990", Offset = "0x3D34390", VA = "0x183D35990", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3D352B0", Offset = "0x3D33CB0", VA = "0x183D352B0", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3D34AE0", Offset = "0x3D334E0", VA = "0x183D34AE0", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3D33F00", Offset = "0x3D32900", VA = "0x183D33F00", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3D33870", Offset = "0x3D32270", VA = "0x183D33870", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3D32DD0", Offset = "0x3D317D0", VA = "0x183D32DD0", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3D31A20", Offset = "0x3D30420", VA = "0x183D31A20", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3D31160", Offset = "0x3D2FB60", VA = "0x183D31160", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3D30380", Offset = "0x3D2ED80", VA = "0x183D30380", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F9B0", Offset = "0x3D2E3B0", VA = "0x183D2F9B0", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E4B0", Offset = "0x3D2CEB0", VA = "0x183D2E4B0", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EBFDHAMOBHF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7E89B40", Offset = "0x7E88540", VA = "0x187E89B40", Slot = "108")]
		public void RpcMaster(JFGAMMLOFIO.JLNGAIDNFNM PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3D0FC10", Offset = "0x3D0E610", VA = "0x183D0FC10", Slot = "109")]
		public void RpcMaster<T1>(JFGAMMLOFIO.GBNMBEPAKNI<T1> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3D0FFC0", Offset = "0x3D0E9C0", VA = "0x183D0FFC0", Slot = "17")]
		public void RpcMaster<T1, T2>(JFGAMMLOFIO.COGKFABEFLE<T1, T2> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3D0F940", Offset = "0x3D0E340", VA = "0x183D0F940", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, T3> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3D0F5E0", Offset = "0x3D0DFE0", VA = "0x183D0F5E0", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, T4> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3D136A0", Offset = "0x3D120A0", VA = "0x183D136A0", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, T5> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3D15B20", Offset = "0x3D14520", VA = "0x183D15B20", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, T6> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DFE0", Offset = "0x3D1C9E0", VA = "0x183D1DFE0", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, T7> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D2F0", Offset = "0x3D1BCF0", VA = "0x183D1D2F0", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, T8> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C9B0", Offset = "0x3D1B3B0", VA = "0x183D1C9B0", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, T9> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3D12E50", Offset = "0x3D11850", VA = "0x183D12E50", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3D11A50", Offset = "0x3D10450", VA = "0x183D11A50", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3D199C0", Offset = "0x3D183C0", VA = "0x183D199C0", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3D18DD0", Offset = "0x3D177D0", VA = "0x183D18DD0", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3D17400", Offset = "0x3D15E00", VA = "0x183D17400", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7E89F10", Offset = "0x7E88910", VA = "0x187E89F10")]
		public void RpcMaster(JFGAMMLOFIO.GBNMBEPAKNI<ANACEAMGMLK> PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3D0FDC0", Offset = "0x3D0E7C0", VA = "0x183D0FDC0")]
		public void RpcMaster<T1>(JFGAMMLOFIO.COGKFABEFLE<T1, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3D10A60", Offset = "0x3D0F460", VA = "0x183D10A60")]
		public void RpcMaster<T1, T2>(JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3D10210", Offset = "0x3D0EC10", VA = "0x183D10210")]
		public void RpcMaster<T1, T2, T3>(JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D20270", Offset = "0x3D1EC70", VA = "0x183D20270")]
		public void RpcMaster<T1, T2, T3, T4>(JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3D140E0", Offset = "0x3D12AE0", VA = "0x183D140E0")]
		public void RpcMaster<T1, T2, T3, T4, T5>(JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EBA0", Offset = "0x3D1D5A0", VA = "0x183D1EBA0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E7A0", Offset = "0x3D1D1A0", VA = "0x183D1E7A0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DB70", Offset = "0x3D1C570", VA = "0x183D1DB70")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C4E0", Offset = "0x3D1AEE0", VA = "0x183D1C4E0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3D1BAE0", Offset = "0x3D1A4E0", VA = "0x183D1BAE0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A550", Offset = "0x3D18F50", VA = "0x183D1A550")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3D193D0", Offset = "0x3D17DD0", VA = "0x183D193D0")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3D18130", Offset = "0x3D16B30", VA = "0x183D18130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3D17A70", Offset = "0x3D16470", VA = "0x183D17A70")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EBFDHAMOBHF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7E89CD0", Offset = "0x7E886D0", VA = "0x187E89CD0", Slot = "122")]
		public void RpcMaster(JFGAMMLOFIO.GBNMBEPAKNI<LFDJLIAPKMA> PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3D22D40", Offset = "0x3D21740", VA = "0x183D22D40", Slot = "123")]
		public void RpcMaster<T1>(JFGAMMLOFIO.COGKFABEFLE<T1, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3D22190", Offset = "0x3D20B90", VA = "0x183D22190", Slot = "124")]
		public void RpcMaster<T1, T2>(JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3D20CF0", Offset = "0x3D1F6F0", VA = "0x183D20CF0", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3D20560", Offset = "0x3D1EF60", VA = "0x183D20560", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3D1FC90", Offset = "0x3D1E690", VA = "0x183D1FC90", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F2A0", Offset = "0x3D1DCA0", VA = "0x183D1F2A0", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E3A0", Offset = "0x3D1CDA0", VA = "0x183D1E3A0", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D700", Offset = "0x3D1C100", VA = "0x183D1D700", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3D1CE20", Offset = "0x3D1B820", VA = "0x183D1CE20", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B5B0", Offset = "0x3D19FB0", VA = "0x183D1B5B0", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B020", Offset = "0x3D19A20", VA = "0x183D1B020", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3D19F60", Offset = "0x3D18960", VA = "0x183D19F60", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3D18780", Offset = "0x3D17180", VA = "0x183D18780", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3D16D40", Offset = "0x3D15740", VA = "0x183D16D40", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EBFDHAMOBHF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7E89730", Offset = "0x7E88130", VA = "0x187E89730", Slot = "137")]
		public void RpcAuthority(JFGAMMLOFIO.JLNGAIDNFNM PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3CFF680", Offset = "0x3CFE080", VA = "0x183CFF680", Slot = "138")]
		public void RpcAuthority<T1>(JFGAMMLOFIO.GBNMBEPAKNI<T1> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3D00860", Offset = "0x3CFF260", VA = "0x183D00860", Slot = "139")]
		public void RpcAuthority<T1, T2>(JFGAMMLOFIO.COGKFABEFLE<T1, T2> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3D01010", Offset = "0x3CFFA10", VA = "0x183D01010", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, T3> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3D00520", Offset = "0x3CFEF20", VA = "0x183D00520", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, T4> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3CFF270", Offset = "0x3CFDC70", VA = "0x183CFF270", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, T5> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3D0E7A0", Offset = "0x3D0D1A0", VA = "0x183D0E7A0", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, T6> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3D0E010", Offset = "0x3D0CA10", VA = "0x183D0E010", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, T7> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3D0CF20", Offset = "0x3D0B920", VA = "0x183D0CF20", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, T8> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3D0BC50", Offset = "0x3D0A650", VA = "0x183D0BC50", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, T9> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3D0B220", Offset = "0x3D09C20", VA = "0x183D0B220", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3D09C50", Offset = "0x3D08650", VA = "0x183D09C50", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3D05C70", Offset = "0x3D04670", VA = "0x183D05C70", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3D07E20", Offset = "0x3D06820", VA = "0x183D07E20", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3D063A0", Offset = "0x3D04DA0", VA = "0x183D063A0", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7E894E0", Offset = "0x7E87EE0", VA = "0x187E894E0")]
		public void RpcAuthority(JFGAMMLOFIO.GBNMBEPAKNI<ANACEAMGMLK> PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3D04090", Offset = "0x3D02A90", VA = "0x183D04090")]
		public void RpcAuthority<T1>(JFGAMMLOFIO.COGKFABEFLE<T1, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3D034D0", Offset = "0x3D01ED0", VA = "0x183D034D0")]
		public void RpcAuthority<T1, T2>(JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3D02FC0", Offset = "0x3D019C0", VA = "0x183D02FC0")]
		public void RpcAuthority<T1, T2, T3>(JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3D02250", Offset = "0x3D00C50", VA = "0x183D02250")]
		public void RpcAuthority<T1, T2, T3, T4>(JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3D01EF0", Offset = "0x3D008F0", VA = "0x183D01EF0")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3D0E3E0", Offset = "0x3D0CDE0", VA = "0x183D0E3E0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3D0D7D0", Offset = "0x3D0C1D0", VA = "0x183D0D7D0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3D0CAA0", Offset = "0x3D0B4A0", VA = "0x183D0CAA0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3D0C0E0", Offset = "0x3D0AAE0", VA = "0x183D0C0E0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3D0B710", Offset = "0x3D0A110", VA = "0x183D0B710")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3D0A1A0", Offset = "0x3D08BA0", VA = "0x183D0A1A0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3D08AA0", Offset = "0x3D074A0", VA = "0x183D08AA0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3D077C0", Offset = "0x3D061C0", VA = "0x183D077C0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3D070F0", Offset = "0x3D05AF0", VA = "0x183D070F0")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EBFDHAMOBHF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7E898E0", Offset = "0x7E882E0", VA = "0x187E898E0", Slot = "152")]
		public void RpcAuthority(JFGAMMLOFIO.GBNMBEPAKNI<LFDJLIAPKMA> PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3D03D30", Offset = "0x3D02730", VA = "0x183D03D30", Slot = "153")]
		public void RpcAuthority<T1>(JFGAMMLOFIO.COGKFABEFLE<T1, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3D03700", Offset = "0x3D02100", VA = "0x183D03700", Slot = "154")]
		public void RpcAuthority<T1, T2>(JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3D02AF0", Offset = "0x3D014F0", VA = "0x183D02AF0", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3D027F0", Offset = "0x3D011F0", VA = "0x183D027F0", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3D01880", Offset = "0x3D00280", VA = "0x183D01880", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3D0EB00", Offset = "0x3D0D500", VA = "0x183D0EB00", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3D0DBF0", Offset = "0x3D0C5F0", VA = "0x183D0DBF0", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3D0D350", Offset = "0x3D0BD50", VA = "0x183D0D350", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3D0C5C0", Offset = "0x3D0AFC0", VA = "0x183D0C5C0", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3D0ACE0", Offset = "0x3D096E0", VA = "0x183D0ACE0", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3D0A740", Offset = "0x3D09140", VA = "0x183D0A740", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3D090A0", Offset = "0x3D07AA0", VA = "0x183D090A0", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3D08440", Offset = "0x3D06E40", VA = "0x183D08440", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3D06A20", Offset = "0x3D05420", VA = "0x183D06A20", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(EBFDHAMOBHF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7E8A9C0", Offset = "0x7E893C0", VA = "0x187E8A9C0", Slot = "18")]
		public void RpcPlayer(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.JLNGAIDNFNM PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3D37D10", Offset = "0x3D36710", VA = "0x183D37D10", Slot = "19")]
		public void RpcPlayer<T1>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.GBNMBEPAKNI<T1> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3D385F0", Offset = "0x3D36FF0", VA = "0x183D385F0", Slot = "20")]
		public void RpcPlayer<T1, T2>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.COGKFABEFLE<T1, T2> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3D382E0", Offset = "0x3D36CE0", VA = "0x183D382E0", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, T3> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3D3C380", Offset = "0x3D3AD80", VA = "0x183D3C380", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, T4> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3D3ED40", Offset = "0x3D3D740", VA = "0x183D3ED40", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, T5> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3D3E8D0", Offset = "0x3D3D2D0", VA = "0x183D3E8D0", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, T6> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3D3F130", Offset = "0x3D3DB30", VA = "0x183D3F130", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, T7> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3D3F600", Offset = "0x3D3E000", VA = "0x183D3F600", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, T8> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3D47130", Offset = "0x3D45B30", VA = "0x183D47130", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, T9> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3D45D00", Offset = "0x3D44700", VA = "0x183D45D00", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(GBDECDHLMJN KPIDJKLDGJJ, PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3D3CD80", Offset = "0x3D3B780", VA = "0x183D3CD80", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GBDECDHLMJN KPIDJKLDGJJ, BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3D434F0", Offset = "0x3D41EF0", VA = "0x183D434F0", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GBDECDHLMJN KPIDJKLDGJJ, CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3D421C0", Offset = "0x3D40BC0", VA = "0x183D421C0", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GBDECDHLMJN KPIDJKLDGJJ, JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3D41B30", Offset = "0x3D40530", VA = "0x183D41B30", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(GBDECDHLMJN KPIDJKLDGJJ, DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x7E8ABC0", Offset = "0x7E895C0", VA = "0x187E8ABC0")]
		public void RpcPlayer(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.GBNMBEPAKNI<ANACEAMGMLK> PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3D380B0", Offset = "0x3D36AB0", VA = "0x183D380B0")]
		public void RpcPlayer<T1>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.COGKFABEFLE<T1, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3D3AA70", Offset = "0x3D39470", VA = "0x183D3AA70")]
		public void RpcPlayer<T1, T2>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3D4B200", Offset = "0x3D49C00", VA = "0x183D4B200")]
		public void RpcPlayer<T1, T2, T3>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A450", Offset = "0x3D48E50", VA = "0x183D4A450")]
		public void RpcPlayer<T1, T2, T3, T4>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3D49D70", Offset = "0x3D48770", VA = "0x183D49D70")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3D49690", Offset = "0x3D48090", VA = "0x183D49690")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x3D48750", Offset = "0x3D47150", VA = "0x183D48750")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x3D47E90", Offset = "0x3D46890", VA = "0x183D47E90")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x3D46750", Offset = "0x3D45150", VA = "0x183D46750")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GBDECDHLMJN KPIDJKLDGJJ, PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3D46200", Offset = "0x3D44C00", VA = "0x183D46200")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(GBDECDHLMJN KPIDJKLDGJJ, BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3D45200", Offset = "0x3D43C00", VA = "0x183D45200")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GBDECDHLMJN KPIDJKLDGJJ, CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3D440D0", Offset = "0x3D42AD0", VA = "0x183D440D0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GBDECDHLMJN KPIDJKLDGJJ, JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3D427F0", Offset = "0x3D411F0", VA = "0x183D427F0")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GBDECDHLMJN KPIDJKLDGJJ, DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3D41450", Offset = "0x3D3FE50", VA = "0x183D41450")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(GBDECDHLMJN KPIDJKLDGJJ, EBFDHAMOBHF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7E8A700", Offset = "0x7E89100", VA = "0x187E8A700", Slot = "176")]
		public void RpcPlayer(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.GBNMBEPAKNI<LFDJLIAPKMA> PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3D39700", Offset = "0x3D38100", VA = "0x183D39700", Slot = "177")]
		public void RpcPlayer<T1>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.COGKFABEFLE<T1, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x3D38870", Offset = "0x3D37270", VA = "0x183D38870", Slot = "24")]
		public void RpcPlayer<T1, T2>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x3D3CA00", Offset = "0x3D3B400", VA = "0x183D3CA00", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3D3DE40", Offset = "0x3D3C840", VA = "0x183D3DE40", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A0E0", Offset = "0x3D48AE0", VA = "0x183D4A0E0", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3D48F50", Offset = "0x3D47950", VA = "0x183D48F50", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3D48320", Offset = "0x3D46D20", VA = "0x183D48320", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3D47A00", Offset = "0x3D46400", VA = "0x183D47A00", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(GBDECDHLMJN KPIDJKLDGJJ, JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3D46C40", Offset = "0x3D45640", VA = "0x183D46C40", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GBDECDHLMJN KPIDJKLDGJJ, PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3D457B0", Offset = "0x3D441B0", VA = "0x183D457B0", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(GBDECDHLMJN KPIDJKLDGJJ, BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3D446F0", Offset = "0x3D430F0", VA = "0x183D446F0", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GBDECDHLMJN KPIDJKLDGJJ, CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3D43AB0", Offset = "0x3D424B0", VA = "0x183D43AB0", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GBDECDHLMJN KPIDJKLDGJJ, JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x3D42E70", Offset = "0x3D41870", VA = "0x183D42E70", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GBDECDHLMJN KPIDJKLDGJJ, DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x3D40D70", Offset = "0x3D3F770", VA = "0x183D40D70", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(GBDECDHLMJN KPIDJKLDGJJ, EBFDHAMOBHF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7E88A60", Offset = "0x7E87460", VA = "0x187E88A60", Slot = "189")]
		public void RpcAllBuffered(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.JLNGAIDNFNM PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x3CDB250", Offset = "0x3CD9C50", VA = "0x183CDB250", Slot = "190")]
		public void RpcAllBuffered<T1>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.GBNMBEPAKNI<T1> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x3CDAD30", Offset = "0x3CD9730", VA = "0x183CDAD30", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.COGKFABEFLE<T1, T2> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x3CDAA00", Offset = "0x3CD9400", VA = "0x183CDAA00", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, T3> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3CDA260", Offset = "0x3CD8C60", VA = "0x183CDA260", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, T4> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3CD9DF0", Offset = "0x3CD87F0", VA = "0x183CD9DF0", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, T5> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3CD9120", Offset = "0x3CD7B20", VA = "0x183CD9120", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, T6> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3CD8E20", Offset = "0x3CD7820", VA = "0x183CD8E20", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, T7> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3CD8160", Offset = "0x3CD6B60", VA = "0x183CD8160", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, T8> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3CD7A50", Offset = "0x3CD6450", VA = "0x183CD7A50", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, T9> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x3CD66F0", Offset = "0x3CD50F0", VA = "0x183CD66F0", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BAKNFIIHGGM FPBDNNHBBEJ, PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5E50", Offset = "0x3CD4850", VA = "0x183CD5E50", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BAKNFIIHGGM FPBDNNHBBEJ, BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4C20", Offset = "0x3CD3620", VA = "0x183CD4C20", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BAKNFIIHGGM FPBDNNHBBEJ, CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x3CD3D20", Offset = "0x3CD2720", VA = "0x183CD3D20", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BAKNFIIHGGM FPBDNNHBBEJ, JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x3CD3280", Offset = "0x3CD1C80", VA = "0x183CD3280", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BAKNFIIHGGM FPBDNNHBBEJ, DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7E88B00", Offset = "0x7E87500", VA = "0x187E88B00")]
		public void RpcAllBuffered(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.GBNMBEPAKNI<ANACEAMGMLK> PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x3CDB130", Offset = "0x3CD9B30", VA = "0x183CDB130")]
		public void RpcAllBuffered<T1>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.COGKFABEFLE<T1, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x3CDAEA0", Offset = "0x3CD98A0", VA = "0x183CDAEA0")]
		public void RpcAllBuffered<T1, T2>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x3CDA840", Offset = "0x3CD9240", VA = "0x183CDA840")]
		public void RpcAllBuffered<T1, T2, T3>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x3CDA470", Offset = "0x3CD8E70", VA = "0x183CDA470")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x3CD9930", Offset = "0x3CD8330", VA = "0x183CD9930")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x3CD93D0", Offset = "0x3CD7DD0", VA = "0x183CD93D0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3CD8820", Offset = "0x3CD7220", VA = "0x183CD8820")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3CD7E00", Offset = "0x3CD6800", VA = "0x183CD7E00")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x3CD76A0", Offset = "0x3CD60A0", VA = "0x183CD76A0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BAKNFIIHGGM FPBDNNHBBEJ, PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6EF0", Offset = "0x3CD58F0", VA = "0x183CD6EF0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BAKNFIIHGGM FPBDNNHBBEJ, BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5A00", Offset = "0x3CD4400", VA = "0x183CD5A00")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BAKNFIIHGGM FPBDNNHBBEJ, CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x3CD50C0", Offset = "0x3CD3AC0", VA = "0x183CD50C0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BAKNFIIHGGM FPBDNNHBBEJ, JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4720", Offset = "0x3CD3120", VA = "0x183CD4720")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BAKNFIIHGGM FPBDNNHBBEJ, DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x3CD37D0", Offset = "0x3CD21D0", VA = "0x183CD37D0")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BAKNFIIHGGM FPBDNNHBBEJ, EBFDHAMOBHF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7E889C0", Offset = "0x7E873C0", VA = "0x187E889C0", Slot = "204")]
		public void RpcAllBuffered(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.GBNMBEPAKNI<LFDJLIAPKMA> PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x3CDB010", Offset = "0x3CD9A10", VA = "0x183CDB010", Slot = "205")]
		public void RpcAllBuffered<T1>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.COGKFABEFLE<T1, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3CDABC0", Offset = "0x3CD95C0", VA = "0x183CDABC0", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3CDA680", Offset = "0x3CD9080", VA = "0x183CDA680", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3CDA050", Offset = "0x3CD8A50", VA = "0x183CDA050", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x3CD9B90", Offset = "0x3CD8590", VA = "0x183CD9B90", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x3CD9680", Offset = "0x3CD8080", VA = "0x183CD9680", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3CD8B20", Offset = "0x3CD7520", VA = "0x183CD8B20", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x3CD84C0", Offset = "0x3CD6EC0", VA = "0x183CD84C0", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3CD72F0", Offset = "0x3CD5CF0", VA = "0x183CD72F0", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BAKNFIIHGGM FPBDNNHBBEJ, PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6AF0", Offset = "0x3CD54F0", VA = "0x183CD6AF0", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BAKNFIIHGGM FPBDNNHBBEJ, BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x3CD62A0", Offset = "0x3CD4CA0", VA = "0x183CD62A0", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BAKNFIIHGGM FPBDNNHBBEJ, CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5560", Offset = "0x3CD3F60", VA = "0x183CD5560", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BAKNFIIHGGM FPBDNNHBBEJ, JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4220", Offset = "0x3CD2C20", VA = "0x183CD4220", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BAKNFIIHGGM FPBDNNHBBEJ, DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3CD2D30", Offset = "0x3CD1730", VA = "0x183CD2D30", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BAKNFIIHGGM FPBDNNHBBEJ, EBFDHAMOBHF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7E8A1D0", Offset = "0x7E88BD0", VA = "0x187E8A1D0", Slot = "219")]
		public void RpcOthersBuffered(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.JLNGAIDNFNM PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x3D2BB70", Offset = "0x3D2A570", VA = "0x183D2BB70", Slot = "220")]
		public void RpcOthersBuffered<T1>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.GBNMBEPAKNI<T1> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B890", Offset = "0x3D2A290", VA = "0x183D2B890", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.COGKFABEFLE<T1, T2> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B560", Offset = "0x3D29F60", VA = "0x183D2B560", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, T3> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3D2AFD0", Offset = "0x3D299D0", VA = "0x183D2AFD0", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, T4> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A6F0", Offset = "0x3D290F0", VA = "0x183D2A6F0", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, T5> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A1E0", Offset = "0x3D28BE0", VA = "0x183D2A1E0", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, T6> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3D29980", Offset = "0x3D28380", VA = "0x183D29980", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, T7> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3D28960", Offset = "0x3D27360", VA = "0x183D28960", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, T8> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3D285B0", Offset = "0x3D26FB0", VA = "0x183D285B0", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, T9> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x3D27A50", Offset = "0x3D26450", VA = "0x183D27A50", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BAKNFIIHGGM FPBDNNHBBEJ, PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3D269B0", Offset = "0x3D253B0", VA = "0x183D269B0", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BAKNFIIHGGM FPBDNNHBBEJ, BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3D260C0", Offset = "0x3D24AC0", VA = "0x183D260C0", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BAKNFIIHGGM FPBDNNHBBEJ, CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3D24880", Offset = "0x3D23280", VA = "0x183D24880", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BAKNFIIHGGM FPBDNNHBBEJ, JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x3D23890", Offset = "0x3D22290", VA = "0x183D23890", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BAKNFIIHGGM FPBDNNHBBEJ, DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7E8A270", Offset = "0x7E88C70", VA = "0x187E8A270")]
		public void RpcOthersBuffered(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.GBNMBEPAKNI<ANACEAMGMLK> PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x3D2BDB0", Offset = "0x3D2A7B0", VA = "0x183D2BDB0")]
		public void RpcOthersBuffered<T1>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.COGKFABEFLE<T1, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B720", Offset = "0x3D2A120", VA = "0x183D2B720")]
		public void RpcOthersBuffered<T1, T2>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B1E0", Offset = "0x3D29BE0", VA = "0x183D2B1E0")]
		public void RpcOthersBuffered<T1, T2, T3>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D2ADC0", Offset = "0x3D297C0", VA = "0x183D2ADC0")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A490", Offset = "0x3D28E90", VA = "0x183D2A490")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3D29C80", Offset = "0x3D28680", VA = "0x183D29C80")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x3D29680", Offset = "0x3D28080", VA = "0x183D29680")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3D28CC0", Offset = "0x3D276C0", VA = "0x183D28CC0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, ANACEAMGMLK> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x3D27E50", Offset = "0x3D26850", VA = "0x183D27E50")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BAKNFIIHGGM FPBDNNHBBEJ, PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3D27650", Offset = "0x3D26050", VA = "0x183D27650")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BAKNFIIHGGM FPBDNNHBBEJ, BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x3D26560", Offset = "0x3D24F60", VA = "0x183D26560")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BAKNFIIHGGM FPBDNNHBBEJ, CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x3D25C20", Offset = "0x3D24620", VA = "0x183D25C20")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BAKNFIIHGGM FPBDNNHBBEJ, JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3D25280", Offset = "0x3D23C80", VA = "0x183D25280")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BAKNFIIHGGM FPBDNNHBBEJ, DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3D23DE0", Offset = "0x3D227E0", VA = "0x183D23DE0")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BAKNFIIHGGM FPBDNNHBBEJ, EBFDHAMOBHF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7E8A130", Offset = "0x7E88B30", VA = "0x187E8A130", Slot = "234")]
		public void RpcOthersBuffered(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.GBNMBEPAKNI<LFDJLIAPKMA> PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x3D2BC90", Offset = "0x3D2A690", VA = "0x183D2BC90", Slot = "235")]
		public void RpcOthersBuffered<T1>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.COGKFABEFLE<T1, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x3D2BA00", Offset = "0x3D2A400", VA = "0x183D2BA00", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.DKCAPMKHGGD<T1, T2, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B3A0", Offset = "0x3D29DA0", VA = "0x183D2B3A0", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.KNBNCLPDBEO<T1, T2, T3, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D2ABB0", Offset = "0x3D295B0", VA = "0x183D2ABB0", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.GIDKHNPKGNL<T1, T2, T3, T4, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A950", Offset = "0x3D29350", VA = "0x183D2A950", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.LIGBBFHIKNH<T1, T2, T3, T4, T5, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x3D29F30", Offset = "0x3D28930", VA = "0x183D29F30", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.KEMCJODKEPO<T1, T2, T3, T4, T5, T6, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x3D29380", Offset = "0x3D27D80", VA = "0x183D29380", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.NNECOMMKDJC<T1, T2, T3, T4, T5, T6, T7, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D29020", Offset = "0x3D27A20", VA = "0x183D29020", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BAKNFIIHGGM FPBDNNHBBEJ, JFGAMMLOFIO.MMCLOHGDDFH<T1, T2, T3, T4, T5, T6, T7, T8, LFDJLIAPKMA> PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D28200", Offset = "0x3D26C00", VA = "0x183D28200", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BAKNFIIHGGM FPBDNNHBBEJ, PLGABKNPPCF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D27250", Offset = "0x3D25C50", VA = "0x183D27250", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BAKNFIIHGGM FPBDNNHBBEJ, BJNKAOKCEGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x3D26E00", Offset = "0x3D25800", VA = "0x183D26E00", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BAKNFIIHGGM FPBDNNHBBEJ, CEADDKBOOGM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x3D25780", Offset = "0x3D24180", VA = "0x183D25780", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BAKNFIIHGGM FPBDNNHBBEJ, JGJNJAEFPJC PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x3D24D80", Offset = "0x3D23780", VA = "0x183D24D80", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BAKNFIIHGGM FPBDNNHBBEJ, DBPOMAKGPJM PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x3D24330", Offset = "0x3D22D30", VA = "0x183D24330", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BAKNFIIHGGM FPBDNNHBBEJ, EBFDHAMOBHF PAANMNLCKIA, T1 MJOJJCFKGII, T2 PLMMOHMJNFJ, T3 HPPALJMFCGO, T4 BCCMJDFODJE, T5 MBNOHECFNOB, T6 NOOEDGDMBDM, T7 GAGFDAGMDFP, T8 GFICGDCPOMI, T9 IHFCHKKEBKF, T10 MDHAANJLMJJ, T11 BPLDIPPCIGF, T12 KMFCAFLCNFF, T13 KJKOLCMBEHG, T14 GPBMGBJFOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7E865D0", Offset = "0x7E84FD0", VA = "0x187E865D0", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7E867E0", Offset = "0x7E851E0", VA = "0x187E867E0", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x1F2FCA0", Offset = "0x1F2E6A0", VA = "0x181F2FCA0")]
		public RRNetworkView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class ICENPJBJGBH
{
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7E75EC0", Offset = "0x7E748C0", VA = "0x187E75EC0")]
	private static bool KDHFCBOGKBO(ViewId KHNIMGKFPOO, [Out] RRNetworkView MMGGIIKGBNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x3A9DC20", Offset = "0x3A9C620", VA = "0x183A9DC20")]
	[CanBeNull]
	public static T CPLBJLJJCEA<T>(this ViewId POHODHGBPHP)
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
		private sealed class IAFEPGAPHBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public GBDECDHLMJN[] sorted;

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public IAFEPGAPHBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x7E75DB0", Offset = "0x7E747B0", VA = "0x187E75DB0")]
			internal int AFBMFPOKGNK(int index)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x7E75E30", Offset = "0x7E74830", VA = "0x187E75E30")]
			internal void LJHELHKEEMK(int index, int number)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly COJJKFBGGKB PMPMPCJHKKF;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public static GBDECDHLMJN[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		internal int JGBNBGIDDPB;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7E8BB60", Offset = "0x7E8A560", VA = "0x187E8BB60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7E8C170", Offset = "0x7E8AB70", VA = "0x187E8C170")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7E8C520", Offset = "0x7E8AF20", VA = "0x187E8C520")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7E8C590", Offset = "0x7E8AF90", VA = "0x187E8C590")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7E8C070", Offset = "0x7E8AA70", VA = "0x187E8C070")]
		private void IJLEBJFGGCJ(GBDECDHLMJN BMGANHBBEFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7E8C070", Offset = "0x7E8AA70", VA = "0x187E8C070")]
		private void FACKHGKBLIN(GBDECDHLMJN BDMLDOEBBIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7E8BF80", Offset = "0x7E8A980", VA = "0x187E8BF80")]
		private void BAABHFCIJNB(GBDECDHLMJN BJBIEGLAMFB, IDictionary<object, object> ABFBCEALCHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7E8BA10", Offset = "0x7E8A410", VA = "0x187E8BA10")]
		public static void AssignPlayerNumbers(int LJPJEEPBPNB, int LFNMNGOPCHM, Func<int, int> FHBFJOPILCD, Action<int, int> ABAINNCBIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7E8C630", Offset = "0x7E8B030", VA = "0x187E8C630")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7E8C080", Offset = "0x7E8AA80", VA = "0x187E8C080")]
		private void IHKELEAJPKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA1BA90", Offset = "0xA1A490", VA = "0x180A1BA90")]
		public RRPlayerNumbering()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class IFEOKBICAPM
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7E78730", Offset = "0x7E77130", VA = "0x187E78730")]
	public static int PNGBGKMPBKH(this GBDECDHLMJN KPIDJKLDGJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7E78360", Offset = "0x7E76D60", VA = "0x187E78360")]
	public static void HICCDOLCHBL(this GBDECDHLMJN KPIDJKLDGJJ, int JCBHOCNMFLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class HFBCCGKGEBM
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void AMCENMKAENG(Hashtable COGBEMJPNIC);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate void APOGMAGGBCH(GBDECDHLMJN KPIDJKLDGJJ, Hashtable COGBEMJPNIC);

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public static event AMCENMKAENG PINCJKDIAPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7E75BF0", Offset = "0x7E745F0", VA = "0x187E75BF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7E75B30", Offset = "0x7E74530", VA = "0x187E75B30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public static event AMCENMKAENG ICDOFOBNANJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7E759B0", Offset = "0x7E743B0", VA = "0x187E759B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7E75CB0", Offset = "0x7E746B0", VA = "0x187E75CB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public static event APOGMAGGBCH BAIFBGDJELB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7E758F0", Offset = "0x7E742F0", VA = "0x187E758F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7E75830", Offset = "0x7E74230", VA = "0x187E75830")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public static event APOGMAGGBCH AKHFKHCABEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7E75770", Offset = "0x7E74170", VA = "0x187E75770")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7E75A70", Offset = "0x7E74470", VA = "0x187E75A70")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class NCHEBPJDNNP
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int FBMFHOMKIBB;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static int MPPCOHPKGGI;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static int MOODBFOAMJJ;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7E84580", Offset = "0x7E82F80", VA = "0x187E84580")]
	public static void JLPCHNKIOED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7E845D0", Offset = "0x7E82FD0", VA = "0x187E845D0")]
	public static void KGBKMMPMODI(int[] DOCAHFNJGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7E842E0", Offset = "0x7E82CE0", VA = "0x187E842E0")]
	public static int FMAKLPODJDJ(int NHFPGBAFPBD, bool IIBLMLHNGLH = true)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
[RegisterService(typeof(DEGFLFHGKHD), new string[] { })]
public class DEGFLFHGKHD : APIHBEIAIJE, MJHCLHMDOAB, IIAKOCKOOML
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static readonly Hashtable DBGMDBKFPHD;

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static readonly Hashtable NLHDPOJAMKK;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static readonly Hashtable OMDJLLILCEJ;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly AIJLKOBFKFM CAFGCLJPKJN;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static readonly AIJLKOBFKFM IGGMCGGCPLJ;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly AIJLKOBFKFM IFBCNLCHIEG;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly AIJLKOBFKFM PDABADPEGOJ;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly AIJLKOBFKFM ENGEAKOPHJO;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static int NBPEONBCMGL;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7E72200", Offset = "0x7E70C00", VA = "0x187E72200", Slot = "18")]
	public void PIJDKGLEIBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7E71D30", Offset = "0x7E70730", VA = "0x187E71D30", Slot = "19")]
	public void NEAHCMEBFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7E70E20", Offset = "0x7E6F820", VA = "0x187E70E20", Slot = "4")]
	public bool CLHFIKJJEPE(BCHAGGJCBIN JKGCHKOAIPN, bool OLAALDJFJON = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x7E71480", Offset = "0x7E6FE80", VA = "0x187E71480", Slot = "5")]
	public int ICACDDLNLIK(BCHAGGJCBIN[] CAIHDKKACCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7E710E0", Offset = "0x7E6FAE0", VA = "0x187E710E0", Slot = "6")]
	public bool DIJHOGHEJAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7E70F50", Offset = "0x7E6F950", VA = "0x187E70F50", Slot = "7")]
	public bool DDJKOLJIGNB(int POHODHGBPHP, int KCAHOJHAGKP, bool OBLENHAAONG, GameObject HNGFDIJGINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7E71DD0", Offset = "0x7E707D0", VA = "0x187E71DD0", Slot = "8")]
	public void NLPPHFDPCMJ(int KCAHOJHAGKP, [Optional] int? FEKGEHBGLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7E70880", Offset = "0x7E6F280", VA = "0x187E70880", Slot = "9")]
	public bool BCDNAMFLMNG(HCCHCCGILAH JEMDJIEKJFA, [Out] BCHAGGJCBIN CMDCHHFPJJG, bool JLABGODBDMG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7E6FEA0", Offset = "0x7E6E8A0", VA = "0x187E6FEA0", Slot = "10")]
	public bool ABKAIKKINKB(HCCHCCGILAH JEMDJIEKJFA, [Out] int BCHHOFOFBKL, [Out] BCHAGGJCBIN[] CAIHDKKACCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7E720E0", Offset = "0x7E70AE0", VA = "0x187E720E0", Slot = "11")]
	public bool OKJNCOMJGPG(HCCHCCGILAH JEMDJIEKJFA, [Out] int KCAHOJHAGKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x7E71A80", Offset = "0x7E70480", VA = "0x187E71A80", Slot = "12")]
	public void LBKNNOHDMKI(HCCHCCGILAH JEMDJIEKJFA, [Out] int JCLAEJFHIOG, [Out] int[] MHOOIKNKEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x7E71840", Offset = "0x7E70240", VA = "0x187E71840", Slot = "13")]
	public void INJLABHIGAK(int BCHHOFOFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7E71FC0", Offset = "0x7E709C0", VA = "0x187E71FC0", Slot = "14")]
	public void OHJEPAMMAPL(int BCHHOFOFBKL, int[] MHOOIKNKEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7E712E0", Offset = "0x7E6FCE0", VA = "0x187E712E0", Slot = "15")]
	public void EOJBJMMNJMD(int[] MHOOIKNKEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7E71C60", Offset = "0x7E70660", VA = "0x187E71C60", Slot = "16")]
	public void LDLJJPHMFOB(int[] MHOOIKNKEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7E71170", Offset = "0x7E6FB70", VA = "0x187E71170", Slot = "17")]
	public void EAADEPKOFPB(int BCHHOFOFBKL, int KCAHOJHAGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7E709F0", Offset = "0x7E6F3F0", VA = "0x187E709F0")]
	private static void BLMIFOIEBJC(BCHAGGJCBIN JKGCHKOAIPN, Hashtable LMFLICBCKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7E70180", Offset = "0x7E6EB80", VA = "0x187E70180")]
	private static bool BCDNAMFLMNG(Hashtable LMFLICBCKAJ, GBDECDHLMJN MIIHDODFGFN, [Out] BCHAGGJCBIN CMDCHHFPJJG, bool JLABGODBDMG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7E71390", Offset = "0x7E6FD90", VA = "0x187E71390")]
	private static bool FHGHMIEBFFF(int KCAHOJHAGKP, BCHAGGJCBIN LMFLICBCKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7E719A0", Offset = "0x7E703A0", VA = "0x187E719A0")]
	private static int JBJDIPCBLIE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public DEGFLFHGKHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[RegisterService(typeof(PNPNELKACNC), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class PNPNELKACNC : KAFDOFNEINA, MJHCLHMDOAB, IIAKOCKOOML
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static Hashtable EJBNLAKOFDF;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static Hashtable MHHHPLPNLJJ;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static AIJLKOBFKFM HPLNADMGHJF;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly AIJLKOBFKFM JCGEMNNDBNI;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7E84BD0", Offset = "0x7E835D0", VA = "0x187E84BD0", Slot = "8")]
	public void NEAHCMEBFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7E85220", Offset = "0x7E83C20", VA = "0x187E85220", Slot = "7")]
	public void PIJDKGLEIBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7E84780", Offset = "0x7E83180", VA = "0x187E84780", Slot = "4")]
	public void HDPGMIKIEGL(ViewId POHODHGBPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7E84870", Offset = "0x7E83270", VA = "0x187E84870", Slot = "5")]
	public bool KDPLBIKLLBD(HCCHCCGILAH JEMDJIEKJFA, [Out] ViewId POHODHGBPHP, [Out] string KJHKPFJLEEB, [Out] int ENCFEMPDCCA, [Out] object[] FOABHHONDMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7E84C70", Offset = "0x7E83670", VA = "0x187E84C70", Slot = "6")]
	public void PDOKONKOCKK(ViewId MMGGIIKGBNM, string KJHKPFJLEEB, KGENHPLGJBJ PDKPPAEHICP, GBDECDHLMJN KPIDJKLDGJJ, PJHBHKGEEAK BKKIDHENLIH, object[] JKGCHKOAIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public PNPNELKACNC()
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
