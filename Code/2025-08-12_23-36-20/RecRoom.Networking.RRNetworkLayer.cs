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
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84C12C0", Offset = "0x84C00C0", VA = "0x1884C12C0", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
			[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x238F970", Offset = "0x238E770", VA = "0x18238F970", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84CF990", Offset = "0x84CE790", VA = "0x1884CF990")]
		private void EDICDPMMNIG(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84CF710", Offset = "0x84CE510", VA = "0x1884CF710")]
		private void DGAAKECFDPD(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84CFFF0", Offset = "0x84CEDF0", VA = "0x1884CFFF0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84D00A0", Offset = "0x84CEEA0", VA = "0x1884D00A0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AOCGGMJJOFH
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ALMLLDBPKBM EBICCMLJNEM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static ALMLLDBPKBM GJPHDEHHALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84ADEA0", Offset = "0x84ACCA0", VA = "0x1884ADEA0")]
		get
		{
			return default(ALMLLDBPKBM);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BLCABDGIPGC
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	RRNetworkView ECNDCIBHKPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	ILHIMEBCJKJ KNDDLNABIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MFLJKJADDGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool Serialize(BHJKEGIFLGN EPAJCFPDHBG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Deserialize(PAANDILDCLP NLCAIENELJM, BHJKEGIFLGN EPAJCFPDHBG);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface JNFOBJFCODN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LALMNPPHFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPCBMFDKHJK(PAANDILDCLP NLCAIENELJM);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PPEAGMPJINO(PAANDILDCLP NLCAIENELJM, BHJKEGIFLGN EPAJCFPDHBG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface PDJMICNPIBD : INetworkUpdateSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAIIODDINIJ(BLCABDGIPGC FLMPDHCPAGP);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIOINIJEMOP(BLCABDGIPGC FLMPDHCPAGP);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BDCEPMMAHDG(BDAFCEOBMGK.LIKOJCGCFAI PBHNHOAOGGN);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KOHANKPCMJD();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDFNGODNLEN(object PEKEABNFGOF);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct PAANDILDCLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int LBDMJCCNJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public uint PBDFMDFGKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public double JOPKLDAOHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int BFGNNHAGNNB;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HAFLJLNJLCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<(ViewId, ILHIMEBCJKJ), JNFOBJFCODN> OPPDDILOLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<BLCABDGIPGC> HDLOBBEDMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HashSet<(ViewId, ILHIMEBCJKJ)> IOIKECEJKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int NLNNEICCLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool DFFKDOKNAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private BDAFCEOBMGK.LIKOJCGCFAI PBHNHOAOGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly MemoryStream GBCJJBCBNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly BHJKEGIFLGN KDPGFFDKKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly BHJKEGIFLGN LBJBLGKGAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private byte[] NILGCCPNCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private float EFPEMGIGHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int IPBEEPDKIAM;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84BB150", Offset = "0x84B9F50", VA = "0x1884BB150")]
	public HAFLJLNJLCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x84BA070", Offset = "0x84B8E70", VA = "0x1884BA070")]
	public void BDCEPMMAHDG(BDAFCEOBMGK.LIKOJCGCFAI PBHNHOAOGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x84BA7D0", Offset = "0x84B95D0", VA = "0x1884BA7D0")]
	public void KOHANKPCMJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x84B9C90", Offset = "0x84B8A90", VA = "0x1884B9C90")]
	public void AFCEEABIEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x84BA090", Offset = "0x84B8E90", VA = "0x1884BA090")]
	public bool DPHJBDIDPOG(BLCABDGIPGC FLMPDHCPAGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84BA830", Offset = "0x84B9630", VA = "0x1884BA830")]
	public bool MDNHCHGJFLC(BLCABDGIPGC FLMPDHCPAGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84BA5B0", Offset = "0x84B93B0", VA = "0x1884BA5B0")]
	private JNFOBJFCODN JNINHOEFMHD(ViewId IAAFAPENNJO, ILHIMEBCJKJ KFLJHBLHNNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x84BA820", Offset = "0x84B9620", VA = "0x1884BA820")]
	public void LALEBAAHJIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x84BAD30", Offset = "0x84B9B30", VA = "0x1884BAD30")]
	private void OIDKOFJOIAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84BAD10", Offset = "0x84B9B10", VA = "0x1884BAD10")]
	private void NPNEAPGOCNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x84BA960", Offset = "0x84B9760", VA = "0x1884BA960")]
	public bool MJGEEBNMCMA(FastBufferWriter AOOOLDFNADH, int KJJIIOCIHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x84BAD90", Offset = "0x84B9B90", VA = "0x1884BAD90")]
	public void PPEAGMPJINO(PAANDILDCLP NLCAIENELJM, FastBufferReader CCOEJPOOOPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class GLGCOJNBNHM : JNFOBJFCODN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private BLCABDGIPGC BCHBLIEOOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private uint AKOPHNAKKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int JIBDAAAHJGK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool LALMNPPHFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	public GLGCOJNBNHM(BLCABDGIPGC BCHBLIEOOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x84B8950", Offset = "0x84B7750", VA = "0x1884B8950", Slot = "5")]
	public bool HPCBMFDKHJK(PAANDILDCLP NLCAIENELJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x84B8A60", Offset = "0x84B7860", VA = "0x1884B8A60", Slot = "6")]
	public void PPEAGMPJINO(PAANDILDCLP NLCAIENELJM, BHJKEGIFLGN EPAJCFPDHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BBECJOLMEFJ : JNFOBJFCODN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private BDAFCEOBMGK.LIKOJCGCFAI PBHNHOAOGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly ViewId IAAFAPENNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int JIBDAAAHJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private uint AKOPHNAKKFL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool LALMNPPHFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1C7B5B0", Offset = "0x1C7A3B0", VA = "0x181C7B5B0")]
	public BBECJOLMEFJ(ViewId IAAFAPENNJO, BDAFCEOBMGK.LIKOJCGCFAI PBHNHOAOGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x84AE0A0", Offset = "0x84ACEA0", VA = "0x1884AE0A0", Slot = "5")]
	public bool HPCBMFDKHJK(PAANDILDCLP NLCAIENELJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x84AE0E0", Offset = "0x84ACEE0", VA = "0x1884AE0E0", Slot = "6")]
	public void PPEAGMPJINO(PAANDILDCLP NLCAIENELJM, BHJKEGIFLGN EPAJCFPDHBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class CGDDJMCIEMB
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x84AE7C0", Offset = "0x84AD5C0", VA = "0x1884AE7C0")]
	public static void OFACCHGGJAP(this FJBDCPJKLML BFKCKILBBIJ, BHJKEGIFLGN BMJFKEDEAKO, ViewId KKBNGKDBMPF, bool LBIDDFLOCCJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x84AE2C0", Offset = "0x84AD0C0", VA = "0x1884AE2C0")]
	public static void NJKOIONFJBA(this FJBDCPJKLML BFKCKILBBIJ, BHJKEGIFLGN BMJFKEDEAKO, bool LBIDDFLOCCJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x84AED30", Offset = "0x84ADB30", VA = "0x1884AED30")]
	public static FJBDCPJKLML PPEAGMPJINO(BHJKEGIFLGN BMJFKEDEAKO, ViewId KKBNGKDBMPF, bool LBIDDFLOCCJ = true)
	{
		return default(FJBDCPJKLML);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x84AE980", Offset = "0x84AD780", VA = "0x1884AE980")]
	public static void PFIEONJFAFG(this FJBDCPJKLML BFKCKILBBIJ, BHJKEGIFLGN BMJFKEDEAKO, bool LBIDDFLOCCJ = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[RegisterService(typeof(PDJMICNPIBD), new string[] { })]
public class HAEDDIMBCGG : PDJMICNPIBD, INetworkUpdateSystem, CGBKAEJPINJ, JDBGEACJNEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly ALMLLDBPKBM NJNOKPDKEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private HAFLJLNJLCN JMKIGOKBKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private uint BNHKFGMKLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private float MAGFNMBDAFM;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84B9010", Offset = "0x84B7E10", VA = "0x1884B9010", Slot = "4")]
	public void FAIIODDINIJ(BLCABDGIPGC FLMPDHCPAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84B9130", Offset = "0x84B7F30", VA = "0x1884B9130", Slot = "5")]
	public void IIOINIJEMOP(BLCABDGIPGC FLMPDHCPAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x84B9330", Offset = "0x84B8130", VA = "0x1884B9330", Slot = "10")]
	public void KMPPGKNEJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x84B9B40", Offset = "0x84B8940", VA = "0x1884B9B40", Slot = "9")]
	public void NetworkUpdate(NetworkUpdateStage GGLGEPLICND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x84B94F0", Offset = "0x84B82F0", VA = "0x1884B94F0")]
	private void LAKLDBNOECA(uint POFGJBPLAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x84B8EC0", Offset = "0x84B7CC0", VA = "0x1884B8EC0", Slot = "6")]
	public void BDCEPMMAHDG(BDAFCEOBMGK.LIKOJCGCFAI PBHNHOAOGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x84B9490", Offset = "0x84B8290", VA = "0x1884B9490", Slot = "7")]
	public void KOHANKPCMJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x84B9AE0", Offset = "0x84B88E0", VA = "0x1884B9AE0", Slot = "8")]
	public void MDFNGODNLEN(object HBOAEALHJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x84B8B40", Offset = "0x84B7940", VA = "0x1884B8B40")]
	private void AOBCGIPOFAN(HPHHANMLLNF HBOAEALHJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x84B8EF0", Offset = "0x84B7CF0", VA = "0x1884B8EF0", Slot = "11")]
	public void EMLPGEIJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x84B9BC0", Offset = "0x84B89C0", VA = "0x1884B9BC0")]
	public HAEDDIMBCGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HBOMBCGCGGN : JNFOBJFCODN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private float LELMBFLDAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int JIBDAAAHJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private uint AKOPHNAKKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly ILHIMEBCJKJ DBBEPOOCLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public PAANDILDCLP CHAPFMGEAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public int OPHLBIEJNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public byte[] BMPBCOOANJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private PAANDILDCLP FNHMNPAPOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int HOCFCDOHLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private byte[] NJNGEJHCMKC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LALMNPPHFPI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84BB840", Offset = "0x84BA640", VA = "0x1884BB840", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x84BB870", Offset = "0x84BA670", VA = "0x1884BB870")]
	public HBOMBCGCGGN(ILHIMEBCJKJ DBBEPOOCLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x84BB540", Offset = "0x84BA340", VA = "0x1884BB540", Slot = "5")]
	public bool HPCBMFDKHJK(PAANDILDCLP NLCAIENELJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x84BB690", Offset = "0x84BA490", VA = "0x1884BB690", Slot = "6")]
	public void PPEAGMPJINO(PAANDILDCLP NLCAIENELJM, BHJKEGIFLGN EPAJCFPDHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x84BB580", Offset = "0x84BA380", VA = "0x1884BB580")]
	internal GLGCOJNBNHM NCCFMEPGMLN(BLCABDGIPGC FLMPDHCPAGP, BHJKEGIFLGN BMJFKEDEAKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x84BB370", Offset = "0x84BA170", VA = "0x1884BB370")]
	private static void GIPBHNEAMLG(GLGCOJNBNHM FEFDLCHGEDM, BHJKEGIFLGN BMJFKEDEAKO, PAANDILDCLP JGDCBNFKDAK, byte[] ALPKAMHLIAF, int HJHGJJAOCMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[RegisterService(typeof(IAAMBHMAEDD), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class IAAMBHMAEDD : LECKNKNKPIF, CGBKAEJPINJ, JDBGEACJNEG
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Hashtable JEEDCIMCDKD;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly Hashtable DMPFOAEFGJL;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly Hashtable JPEIAPPKBEE;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly ACKMCIEAMDG JALHBENJDIF;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly ACKMCIEAMDG AJLCHLPCAFC;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static readonly ACKMCIEAMDG AONCHAGJKHB;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly ACKMCIEAMDG HAAHHBDFNHA;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly ACKMCIEAMDG AHKNOKOPCOD;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static int JCKCGGGHHKG;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x84BCD40", Offset = "0x84BBB40", VA = "0x1884BCD40", Slot = "4")]
	public bool IOLJFIKOHJM(FJBBMIPBAAJ ONHEEOKCMKO, bool DCPMAGCIKCO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x84BD050", Offset = "0x84BBE50", VA = "0x1884BD050", Slot = "5")]
	public int KKDPCMFBEBP(FJBBMIPBAAJ[] CCCOBHOHKNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x84BBE70", Offset = "0x84BAC70", VA = "0x1884BBE70", Slot = "6")]
	public bool EPFAPPBNPEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x84BD790", Offset = "0x84BC590", VA = "0x1884BD790", Slot = "7")]
	public bool LOJBPICLCAF(int IAAFAPENNJO, int AIKCBCGMFCA, bool NIDNIGNHKMM, GameObject DFFAMKHOIDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x84BCA30", Offset = "0x84BB830", VA = "0x1884BCA30", Slot = "8")]
	public void HJCOMKBMHPH(int AIKCBCGMFCA, [Optional] int? CIOBDCBACEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x84BC1A0", Offset = "0x84BAFA0", VA = "0x1884BC1A0", Slot = "9")]
	public bool GBDNHNDDCGF(HPHHANMLLNF PEKEABNFGOF, [Out] FJBBMIPBAAJ IBNCJKAIFNB, bool AHLIEEGNPGA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x84BD4B0", Offset = "0x84BC2B0", VA = "0x1884BD4B0", Slot = "10")]
	public bool LDDAAAJMGEF(HPHHANMLLNF PEKEABNFGOF, [Out] int JBONNNNENLL, [Out] FJBBMIPBAAJ[] CCCOBHOHKNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x84BBFB0", Offset = "0x84BADB0", VA = "0x1884BBFB0", Slot = "11")]
	public bool FHOJHMOLEHD(HPHHANMLLNF PEKEABNFGOF, [Out] int AIKCBCGMFCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x84BCE70", Offset = "0x84BBC70", VA = "0x1884BCE70", Slot = "12")]
	public void KANEIMGKDDP(HPHHANMLLNF PEKEABNFGOF, [Out] int LCLGLNFGEMD, [Out] int[] LNHEMGNBEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x84BD920", Offset = "0x84BC720", VA = "0x1884BD920", Slot = "13")]
	public void MNMNGACACLJ(int JBONNNNENLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x84BCC20", Offset = "0x84BBA20", VA = "0x1884BCC20", Slot = "14")]
	public void IDLJDNEEGEO(int JBONNNNENLL, int[] LNHEMGNBEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x84BBF00", Offset = "0x84BAD00", VA = "0x1884BBF00", Slot = "15")]
	public void FDHKFIMIDFM(int[] LNHEMGNBEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x84BC0D0", Offset = "0x84BAED0", VA = "0x1884BC0D0", Slot = "16")]
	public void FIPADKLICBM(int[] LNHEMGNBEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x84BC8C0", Offset = "0x84BB6C0", VA = "0x1884BC8C0", Slot = "17")]
	public void HHKHBIMGHPC(int JBONNNNENLL, int AIKCBCGMFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x84BB9A0", Offset = "0x84BA7A0", VA = "0x1884BB9A0")]
	private static void EGJLGKJGBEA(FJBBMIPBAAJ ONHEEOKCMKO, Hashtable MGJHBBPMNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x84BC310", Offset = "0x84BB110", VA = "0x1884BC310")]
	private static bool GBDNHNDDCGF(Hashtable MGJHBBPMNPM, AFLCFHLHEHB IJIAOFHPIOC, [Out] FJBBMIPBAAJ IBNCJKAIFNB, bool AHLIEEGNPGA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x84BDA80", Offset = "0x84BC880", VA = "0x1884BDA80")]
	private static int OCJJEJPMMBL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x84BD410", Offset = "0x84BC210", VA = "0x1884BD410", Slot = "18")]
	public void KMPPGKNEJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x84BBDD0", Offset = "0x84BABD0", VA = "0x1884BBDD0", Slot = "19")]
	public void EMLPGEIJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public IAAMBHMAEDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[RegisterService(typeof(CKAOEALOLCK), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class CKAOEALOLCK : LIFJFAPADPH, CGBKAEJPINJ, JDBGEACJNEG
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Hashtable ELHDGFKHBMM;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Hashtable OGGCLPDAJHD;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static ACKMCIEAMDG HECPKAIEFFJ;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly ACKMCIEAMDG AFGGFAIBPHJ;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x84AF610", Offset = "0x84AE410", VA = "0x1884AF610", Slot = "4")]
	public void OAPDKEJBGHB(ViewId IAAFAPENNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x84AF700", Offset = "0x84AE500", VA = "0x1884AF700", Slot = "5")]
	public bool PJPGAFFAOII(HPHHANMLLNF PEKEABNFGOF, [Out] ViewId IAAFAPENNJO, [Out] string HLFOJCNGCCB, [Out] int KPEONFBADJH, [Out] object[] BNOPOAPPFBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x84AEEA0", Offset = "0x84ADCA0", VA = "0x1884AEEA0", Slot = "6")]
	public void AHNCGJOBPPM(ViewId LNFCNKMMELP, string HLFOJCNGCCB, DPFDMEKAHAN MAPCIGBDCJI, AFLCFHLHEHB GLMBLPAKFLM, GLEJGGGOBBK MHHBNPCINHM, object[] ONHEEOKCMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x84AF4D0", Offset = "0x84AE2D0", VA = "0x1884AF4D0", Slot = "8")]
	public void EMLPGEIJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x84AF570", Offset = "0x84AE370", VA = "0x1884AF570", Slot = "7")]
	public void KMPPGKNEJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public CKAOEALOLCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PAPAOFPLCBE
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x84C2E60", Offset = "0x84C1C60", VA = "0x1884C2E60")]
	public static AFLCFHLHEHB BCIMNJCNOKD(this JCHCDPDFDDM GAILPBKIIHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x84C2EF0", Offset = "0x84C1CF0", VA = "0x1884C2EF0")]
	public static JCHCDPDFDDM IGDHMEOAKPH(this AFLCFHLHEHB GLMBLPAKFLM)
	{
		return default(JCHCDPDFDDM);
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class RRNetworkBehavior : MonoBehaviour, ODPDCNAIMOG, NKDNONFKBGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool networkedViewInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private RRNetworkView networkedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private List<LLGLLKLFDPG> destroyHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool isForwarderRegistered;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId GJIOGDANHOL
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x84C8B30", Offset = "0x84C7930", VA = "0x1884C8B30")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId BDMDIAKJPEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x84C8B30", Offset = "0x84C7930", VA = "0x1884C8B30", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView IOPMDOAOFME
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x84C8BB0", Offset = "0x84C79B0", VA = "0x1884C8BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView ECNDCIBHKPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x84C8BB0", Offset = "0x84C79B0", VA = "0x1884C8BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AFLCFHLHEHB BJGNPLBCFNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x84C8CB0", Offset = "0x84C7AB0", VA = "0x1884C8CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public AFLCFHLHEHB KINIEEOGPPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x84C9010", Offset = "0x84C7E10", VA = "0x1884C9010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool JGGFMHEILFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x84C8E10", Offset = "0x84C7C10", VA = "0x1884C8E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HEDEJIBBELM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x84C8F80", Offset = "0x84C7D80", VA = "0x1884C8F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool MKCKBIIBIEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x84C8A60", Offset = "0x84C7860", VA = "0x1884C8A60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool NHDIEFLFNJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x84C8D40", Offset = "0x84C7B40", VA = "0x1884C8D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool JDDLFMMGINL
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x84C8A60", Offset = "0x84C7860", VA = "0x1884C8A60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool ODDLEODHFFP
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x84C8AE0", Offset = "0x84C78E0", VA = "0x1884C8AE0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string LOGPJIIDGIK
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x84C8C20", Offset = "0x84C7A20", VA = "0x1884C8C20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool HEEEAKKFLDH
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x84C89E0", Offset = "0x84C77E0", VA = "0x1884C89E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<AFLCFHLHEHB> HCNDJJLDAFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x84C88B0", Offset = "0x84C76B0", VA = "0x1884C88B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x84C90A0", Offset = "0x84C7EA0", VA = "0x1884C90A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x84C8810", Offset = "0x84C7610", VA = "0x1884C8810")]
		public bool WasSpawnedForPlayer(int CDKJGNGLHJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x77BB260", Offset = "0x77BA060", VA = "0x1877BB260")]
		private void MMKNCFHLLJG(RRNetworkView OGPILIPEPKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x84C8440", Offset = "0x84C7240", VA = "0x1884C8440", Slot = "9")]
		public void RegisterDestroyHandler(LLGLLKLFDPG PMJKNCNKPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x84C8640", Offset = "0x84C7440", VA = "0x1884C8640", Slot = "10")]
		public void UnregisterDestroyHandler(LLGLLKLFDPG PMJKNCNKPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x84C8420", Offset = "0x84C7220", VA = "0x1884C8420", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public RRNetworkBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class PMMHDOLGMMO
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void KMEMMNNKJDK([In] FJBBMIPBAAJ ONHEEOKCMKO, bool DOBAJNECPEA, bool MGJHBBPMNPM, bool FPBNADDKFMO);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void KCLHEBOGIOC(GameObject OADMNNJGFJI);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void NGNAMNGIAED(GameObject OADMNNJGFJI);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void CIMFJCDOONG(RRNetworkView LNFCNKMMELP, string HLFOJCNGCCB, AFLCFHLHEHB NPKICFNLIBN, DPFDMEKAHAN? BNIHAACOHPG, bool HNFKMBDIAJJ, GLEJGGGOBBK CJLHNJBNBIM, object[] ONHEEOKCMKO, string DMFPOMPACMO);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void BBAKKDJJOLO(RRNetworkView LNFCNKMMELP, string HLFOJCNGCCB, AFLCFHLHEHB NPKICFNLIBN, DPFDMEKAHAN? BNIHAACOHPG, bool HNFKMBDIAJJ, GLEJGGGOBBK CJLHNJBNBIM, object[] ONHEEOKCMKO, string DMFPOMPACMO);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate void ILDLEOBPCCE(RRNetworkView LNFCNKMMELP, string HLFOJCNGCCB, object[] BNOPOAPPFBM, string HEIIAEGIPBK);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void PIHHGDAGBAL(RRNetworkView LNFCNKMMELP, AFLCFHLHEHB FEKNKDEFGLP);

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[CompilerGenerated]
	private static KCLHEBOGIOC NMEFKDCPAJL;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event KMEMMNNKJDK HANPKILEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x84C7310", Offset = "0x84C6110", VA = "0x1884C7310")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x84C8000", Offset = "0x84C6E00", VA = "0x1884C8000")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public static event KCLHEBOGIOC PDNNPNEMFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x84C80C0", Offset = "0x84C6EC0", VA = "0x1884C80C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x84C7250", Offset = "0x84C6050", VA = "0x1884C7250")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event NGNAMNGIAED HGKMCDDNGFN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x84C7DF0", Offset = "0x84C6BF0", VA = "0x1884C7DF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x84C78E0", Offset = "0x84C66E0", VA = "0x1884C78E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public static event NGNAMNGIAED NKDDLFNPAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x84C7190", Offset = "0x84C5F90", VA = "0x1884C7190")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x84C7720", Offset = "0x84C6520", VA = "0x1884C7720")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public static event CIMFJCDOONG GPOOHBEEEBA
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x84C7010", Offset = "0x84C5E10", VA = "0x1884C7010")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x84C8210", Offset = "0x84C7010", VA = "0x1884C8210")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public static event BBAKKDJJOLO FGMBELPAIJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x84C7C70", Offset = "0x84C6A70", VA = "0x1884C7C70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x84C7A30", Offset = "0x84C6830", VA = "0x1884C7A30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public static event ILDLEOBPCCE JBPNDCFMOOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x84C75A0", Offset = "0x84C63A0", VA = "0x1884C75A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x84C7660", Offset = "0x84C6460", VA = "0x1884C7660")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public static event PIHHGDAGBAL LBJCLOHOIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x84C7BB0", Offset = "0x84C69B0", VA = "0x1884C7BB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x84C82D0", Offset = "0x84C70D0", VA = "0x1884C82D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event PIHHGDAGBAL EJJFGJNPIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x84C7D30", Offset = "0x84C6B30", VA = "0x1884C7D30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x84C7AF0", Offset = "0x84C68F0", VA = "0x1884C7AF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x84C70D0", Offset = "0x84C5ED0", VA = "0x1884C70D0")]
	public static void BDKBICAFKBP([In] FJBBMIPBAAJ ONHEEOKCMKO, bool DOBAJNECPEA, bool MGJHBBPMNPM, bool FPBNADDKFMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x84C8390", Offset = "0x84C7190", VA = "0x1884C8390")]
	public static void PHIAGNPOBEL(GameObject OADMNNJGFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x84C73D0", Offset = "0x84C61D0", VA = "0x1884C73D0")]
	public static void EOHGKBIFFFF(GameObject OADMNNJGFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x84C79A0", Offset = "0x84C67A0", VA = "0x1884C79A0")]
	public static void HNKOEILEHJC(GameObject OADMNNJGFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x84C8180", Offset = "0x84C6F80", VA = "0x1884C8180")]
	public static void LHCCPPJHNFI(GameObject OADMNNJGFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x84C7EB0", Offset = "0x84C6CB0", VA = "0x1884C7EB0")]
	public static void LDNOEMCNODA(RRNetworkView LNFCNKMMELP, string HLFOJCNGCCB, AFLCFHLHEHB NPKICFNLIBN, DPFDMEKAHAN? BNIHAACOHPG, bool HNFKMBDIAJJ, GLEJGGGOBBK CJLHNJBNBIM, object[] ONHEEOKCMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x84C7460", Offset = "0x84C6260", VA = "0x1884C7460")]
	public static void FACBBACODCJ(RRNetworkView LNFCNKMMELP, string HLFOJCNGCCB, int AFAKFPMPHEI, object[] BNOPOAPPFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x84C77E0", Offset = "0x84C65E0", VA = "0x1884C77E0")]
	public static void GHIDMMBJDHL(int IAAFAPENNJO, int GAILPBKIIHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class ILFPPDJGBHE
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x84BDFE0", Offset = "0x84BCDE0", VA = "0x1884BDFE0")]
	[CanBeNull]
	private static bool KCAJPMKJEOB(ViewId FMFDAFLDAAK, [Out] RRNetworkView LNFCNKMMELP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x84BDE30", Offset = "0x84BCC30", VA = "0x1884BDE30")]
	[CanBeNull]
	public static Component AOEJGELPGDP(this ViewId LNFCNKMMELP, Type MPNOOBCJBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3D4E210", Offset = "0x3D4D010", VA = "0x183D4E210")]
	[CanBeNull]
	public static T AOEJGELPGDP<T>(this ViewId LNFCNKMMELP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3D4E210", Offset = "0x3D4D010", VA = "0x183D4E210")]
	[CanBeNull]
	public static T MCCOKBNANKJ<T>(this ViewId LNFCNKMMELP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D4E260", Offset = "0x3D4D060", VA = "0x183D4E260")]
	public static bool GLDLFHFAFHP<T>(this ViewId LNFCNKMMELP, [Out] T MOBFLOHJOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x84BDF10", Offset = "0x84BCD10", VA = "0x1884BDF10")]
	[CanBeNull]
	public static RRNetworkView CFEOMGKIDFG(this ViewId LNFCNKMMELP)
	{
		return null;
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static RRNetworkHandler HNKFODIAFKO;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler MOIOIMEFPHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x84C9210", Offset = "0x84C8010", VA = "0x1884C9210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x84C9380", Offset = "0x84C8180", VA = "0x1884C9380")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x84C91D0", Offset = "0x84C7FD0", VA = "0x1884C91D0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public RRNetworkHandler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[RegisterService(typeof(EGIBNOOGCKN), new string[] { "Photon" })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public sealed class EGIBNOOGCKN : FMBCLCKDHDA, CGBKAEJPINJ, JDBGEACJNEG, MLOBALCJPKH, NCBGAICBELD
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ILNPMLBNIOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int requestedViewId;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public ILNPMLBNIOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x84BE090", Offset = "0x84BCE90", VA = "0x1884BE090")]
		internal object GANAJHMGOAP((int requestedViewId, int newOwnerId, int senderId) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static ALMLLDBPKBM CLGLNLFABJI;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static ALMLLDBPKBM KJOEONBKPKK;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static Dictionary<int, HashSet<int>> NKFFDCBBNII;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static Dictionary<int, int> NBDANAKBAKH;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly List<(GameObject GameObject, int ParentCount)> HIINKLIOHNB;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static readonly List<GameObject> JFIACJOAGBE;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static List<int> KLLLDILPJAN;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly List<RRNetworkView> KIOGCEMBALI;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly ACKMCIEAMDG HAAHHBDFNHA;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static readonly ACKMCIEAMDG AHKNOKOPCOD;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x84B5A00", Offset = "0x84B4800", VA = "0x1884B5A00", Slot = "8")]
	public void KMPPGKNEJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x84B2870", Offset = "0x84B1670", VA = "0x1884B2870", Slot = "9")]
	public void EMLPGEIJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x84B48F0", Offset = "0x84B36F0", VA = "0x1884B48F0", Slot = "10")]
	public void InitExternal(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x84B26A0", Offset = "0x84B14A0", VA = "0x1884B26A0", Slot = "11")]
	public void EIBFHHFGNJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x84B3D60", Offset = "0x84B2B60", VA = "0x1884B3D60")]
	private void HBLCLHBGDOF(NAOOMPNBCKE HPJKJMICCLM, NAOOMPNBCKE GKGDEKNIOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x84B62D0", Offset = "0x84B50D0", VA = "0x1884B62D0")]
	private void LFBFDLOPFGH(CNPGGIPBJKJ JAJILKGJHJJ, CNPGGIPBJKJ GPDHKICKCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x84B12C0", Offset = "0x84B00C0", VA = "0x1884B12C0")]
	public GameObject DIPAEGMMGGP(string PFLDDMDPCBI, Vector3 FLAPAOJCDCM, Quaternion GKEKGHNHKDP, Vector3 KBAEKIALOKB, ViewId IAAFAPENNJO, BFDLJFNDJKD ONHEEOKCMKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x84B7060", Offset = "0x84B5E60", VA = "0x1884B7060")]
	public GameObject OEDCNEIGEOJ(string PFLDDMDPCBI, Vector3 FLAPAOJCDCM, Quaternion GKEKGHNHKDP, float KBAEKIALOKB, object[] ONHEEOKCMKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x84B36C0", Offset = "0x84B24C0", VA = "0x1884B36C0")]
	public GameObject FHDDGGHAKPC(string PFLDDMDPCBI, Vector3 FLAPAOJCDCM, Quaternion GKEKGHNHKDP, Vector3 KBAEKIALOKB, ViewId LNFCNKMMELP, BFDLJFNDJKD ONHEEOKCMKO, bool FPBNADDKFMO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x84B0380", Offset = "0x84AF180", VA = "0x1884B0380")]
	public GameObject CFODKFDOFLB(FJBBMIPBAAJ ONHEEOKCMKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x84B4840", Offset = "0x84B3640", VA = "0x1884B4840", Slot = "6")]
	public void IIJMBEFKNNL(GameObject OADMNNJGFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x84AFE40", Offset = "0x84AEC40", VA = "0x1884AFE40")]
	public void ALNDILHGBFN(GameObject DFFAMKHOIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x84B84B0", Offset = "0x84B72B0", VA = "0x1884B84B0", Slot = "7")]
	public void PPCNILDMIEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x84B5FA0", Offset = "0x84B4DA0", VA = "0x1884B5FA0", Slot = "4")]
	public GameObject[] KPDFNCGDIMK(IList<FCLGJEKKKPG> JJPHDMFIAJE, bool DNOMNHCPKOJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x84B77A0", Offset = "0x84B65A0", VA = "0x1884B77A0", Slot = "5")]
	public void PBNMCNMBBJO(List<GameObject> EBCPGCCPGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x84B35E0", Offset = "0x84B23E0", VA = "0x1884B35E0")]
	public void FEFANPOGMAO(GameObject DFFAMKHOIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x84AFEB0", Offset = "0x84AECB0", VA = "0x1884AFEB0")]
	private void AOBCGIPOFAN(HPHHANMLLNF PEKEABNFGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x84B01B0", Offset = "0x84AEFB0", VA = "0x1884B01B0")]
	private void BABGGAHBGIC(HPHHANMLLNF PEKEABNFGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x84B3AB0", Offset = "0x84B28B0", VA = "0x1884B3AB0")]
	private void GIEBOHIFAJA(HPHHANMLLNF PEKEABNFGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x84B2C10", Offset = "0x84B1A10", VA = "0x1884B2C10")]
	private void FCJFOFALCOD(HPHHANMLLNF PEKEABNFGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x84B0F10", Offset = "0x84AFD10", VA = "0x1884B0F10")]
	private void CPIPCNFCMGE(HPHHANMLLNF PEKEABNFGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x84B3E80", Offset = "0x84B2C80", VA = "0x1884B3E80")]
	private void HCLEBPCDIMF(HPHHANMLLNF PEKEABNFGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x84B7150", Offset = "0x84B5F50", VA = "0x1884B7150")]
	private void ONBFDLFBDIP(HPHHANMLLNF PEKEABNFGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x84B20B0", Offset = "0x84B0EB0", VA = "0x1884B20B0")]
	private GameObject DKAGOHGEPHA(string MLPOJPAGPBH, Vector3 FLAPAOJCDCM, Quaternion GKEKGHNHKDP, Vector3 KBAEKIALOKB, byte EBICCMLJNEM = 0, [Optional] object[] KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x84B2EF0", Offset = "0x84B1CF0", VA = "0x1884B2EF0")]
	private GameObject FDKCONCFIMO(FJBBMIPBAAJ ONHEEOKCMKO, bool DOBAJNECPEA = false, bool MGJHBBPMNPM = false, bool FPBNADDKFMO = true, bool JLFOCCNKFEP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x84B4280", Offset = "0x84B3080", VA = "0x1884B4280")]
	private static GameObject HKCBANHGKFL(string MLPOJPAGPBH, bool JEPDCEADMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x84AFC30", Offset = "0x84AEA30", VA = "0x1884AFC30")]
	private static GameObject AFEDNENIMLB(GameObject BLNABJHHOFA, FJBBMIPBAAJ ONHEEOKCMKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x84B6C10", Offset = "0x84B5A10", VA = "0x1884B6C10")]
	private static void MMMFAADBANH(GameObject OADMNNJGFJI, RRNetworkView LNFCNKMMELP, [In] FJBBMIPBAAJ ONHEEOKCMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x84B7C60", Offset = "0x84B6A60", VA = "0x1884B7C60")]
	private GameObject[] PKAECOMODIP(IList<FCLGJEKKKPG> JJPHDMFIAJE, bool DNOMNHCPKOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x84B6DC0", Offset = "0x84B5BC0", VA = "0x1884B6DC0")]
	private GameObject[] NKNDOLHCGAD(FJBBMIPBAAJ[] CCCOBHOHKNB, int JBONNNNENLL, AFLCFHLHEHB GLMBLPAKFLM, GameObject[] CAMOCOIDBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x84B6800", Offset = "0x84B5600", VA = "0x1884B6800")]
	private GameObject MJJCNJKLJLB([In] FJBBMIPBAAJ ONHEEOKCMKO, GameObject BLNABJHHOFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x778EE00", Offset = "0x778DC00", VA = "0x18778EE00")]
	private static bool EDJHDMCKCOG(bool DOBAJNECPEA, bool FPBNADDKFMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x84B1490", Offset = "0x84B0290", VA = "0x1884B1490")]
	private void DJOBICABPAE(IEnumerable<GameObject> EBCPGCCPGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x84B4AC0", Offset = "0x84B38C0", VA = "0x1884B4AC0")]
	private void KBMMHLEDMLO(GameObject OADMNNJGFJI, bool JLFOCCNKFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x84B22A0", Offset = "0x84B10A0", VA = "0x1884B22A0")]
	private static void EEDINEEFNCH(IEnumerable<GameObject> LIFGOJFHPBJ, List<(GameObject GameObject, int ParentCount)> HFFHJDFBOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x84B3950", Offset = "0x84B2750", VA = "0x1884B3950")]
	private void FJLHMBIIMNM(int AIKCBCGMFCA, int JBONNNNENLL, bool JLFOCCNKFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x84B4850", Offset = "0x84B3650", VA = "0x1884B4850")]
	private static int IJCODOCPBKD(int AIKCBCGMFCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x84B59A0", Offset = "0x84B47A0", VA = "0x1884B59A0")]
	private void KFGLCCCNGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x84B4300", Offset = "0x84B3100", VA = "0x1884B4300")]
	private void IFLCODPELNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x84B66A0", Offset = "0x84B54A0", VA = "0x1884B66A0")]
	private static int MACFKMKPBHL(int OHBBHEMPKFB, bool FPBNADDKFMO = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x84B0E30", Offset = "0x84AFC30", VA = "0x1884B0E30")]
	private static int[] CKDOAIHBMBL(int NEPPDBOBKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x84B7B60", Offset = "0x84B6960", VA = "0x1884B7B60")]
	private static int[] PGBEGCFCAEB(int KINIEEOGPPI, int NEPPDBOBKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x84B2BD0", Offset = "0x84B19D0", VA = "0x1884B2BD0")]
	private void FAAGDJAINLF(AFLCFHLHEHB HJOAMDGBOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x84B03B0", Offset = "0x84AF1B0", VA = "0x1884B03B0")]
	private void CGEPGDFMABB(AFLCFHLHEHB GLMBLPAKFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x84B63D0", Offset = "0x84B51D0", VA = "0x1884B63D0")]
	private void LLDAPNGCJMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x84B5D60", Offset = "0x84B4B60", VA = "0x1884B5D60")]
	private void KONBFBGIGFF(AFLCFHLHEHB GLMBLPAKFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x84B6D20", Offset = "0x84B5B20", VA = "0x1884B6D20")]
	private static void NIBBBBPEGMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x84B6700", Offset = "0x84B5500", VA = "0x1884B6700")]
	private void MDKOFMOMOGM(int[] OFBNKGLIEAD, int MGNFKHOIIGO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public EGIBNOOGCKN()
	{
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public RRNetworkProfiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(PKKDMPENNIN), new string[] { "Photon" })]
public class PKKDMPENNIN : CGBKAEJPINJ, JDBGEACJNEG, BCKOGJGFJLK
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct JHIJFGFAEAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public readonly MethodInfo DIHHBOLMAOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly Func<MonoBehaviour, object> LGPGIBGLGBE;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xC55370", Offset = "0xC54170", VA = "0x180C55370")]
		public JHIJFGFAEAB(MethodInfo DIHHBOLMAOC, [Optional] Func<MonoBehaviour, object> LGPGIBGLGBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7787440", Offset = "0x7786240", VA = "0x187787440")]
		public object JOFHBGLINID(MonoBehaviour JNNDKLMHGMP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class GCKPGPNMFDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public FieldInfo instanceAccessFromField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Func<MonoBehaviour, object> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public GCKPGPNMFDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x84B8880", Offset = "0x84B7680", VA = "0x1884B8880")]
		internal JHIJFGFAEAB NBBDOKFKFEH(MethodInfo methodInfo)
		{
			return default(JHIJFGFAEAB);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4AE7740", Offset = "0x4AE6540", VA = "0x184AE7740")]
		internal object MIICPDEKDAE(MonoBehaviour mb)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JBEPACGIACO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Func<MonoBehaviour, object> accessor;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public JBEPACGIACO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x77A5030", Offset = "0x77A3E30", VA = "0x1877A5030")]
		internal JHIJFGFAEAB HBMNCAPFPJH(MethodInfo methodInfo)
		{
			return default(JHIJFGFAEAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class DLMMFHLEDDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Type attributeType;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DLMMFHLEDDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x84AFBF0", Offset = "0x84AE9F0", VA = "0x1884AFBF0")]
		internal bool NLOEHKBMEBI(MethodInfo m)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static Dictionary<string, int> LHAGMEHELOK;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static List<string> COIHFMBMJEF;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static int EFPJKEMOFKO;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly Stopwatch LGGFHPMOHDE;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static Dictionary<MethodInfo, ParameterInfo[]> PLKDMIIHLGL;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly Dictionary<Type, List<JHIJFGFAEAB>> OPAFGGNHNLC;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x84C6410", Offset = "0x84C5210", VA = "0x1884C6410", Slot = "4")]
	public void KMPPGKNEJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x84C33E0", Offset = "0x84C21E0", VA = "0x1884C33E0", Slot = "5")]
	public void EMLPGEIJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x84C4980", Offset = "0x84C3780", VA = "0x1884C4980")]
	public static bool IMLJDPJLBHO(string HLFOJCNGCCB, [Out] int EHGNNCKNHCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x84C3300", Offset = "0x84C2100", VA = "0x1884C3300")]
	public static bool CHBGGJBMFPH(int EHGNNCKNHCO, [Out] string HLFOJCNGCCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x84C3050", Offset = "0x84C1E50", VA = "0x1884C3050")]
	private void AOBCGIPOFAN(HPHHANMLLNF PEKEABNFGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x84C6BA0", Offset = "0x84C59A0", VA = "0x1884C6BA0", Slot = "9")]
	public string NLECANLDILA(HPHHANMLLNF PEKEABNFGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x84C6BD0", Offset = "0x84C59D0", VA = "0x1884C6BD0", Slot = "8")]
	public void OAPDKEJBGHB(ViewId IAAFAPENNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x84C42E0", Offset = "0x84C30E0", VA = "0x1884C42E0", Slot = "6")]
	public void GCEOJOMECMD(ViewId LNFCNKMMELP, string HLFOJCNGCCB, AFLCFHLHEHB GLMBLPAKFLM, GLEJGGGOBBK CJLHNJBNBIM, params object[] ONHEEOKCMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x84C43B0", Offset = "0x84C31B0", VA = "0x1884C43B0", Slot = "7")]
	public void GCEOJOMECMD(ViewId LNFCNKMMELP, string HLFOJCNGCCB, DPFDMEKAHAN BNIHAACOHPG, GLEJGGGOBBK CJLHNJBNBIM, params object[] ONHEEOKCMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x84C3E00", Offset = "0x84C2C00", VA = "0x1884C3E00")]
	private void GCEOJOMECMD(ViewId LNFCNKMMELP, string HLFOJCNGCCB, DPFDMEKAHAN BNIHAACOHPG, AFLCFHLHEHB GLMBLPAKFLM, GLEJGGGOBBK CJLHNJBNBIM, params object[] ONHEEOKCMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x84C4A10", Offset = "0x84C3810", VA = "0x1884C4A10")]
	private void KCPKHHDMHLK(ViewId IAAFAPENNJO, string HLFOJCNGCCB, AFLCFHLHEHB JFKPMDJNDHF, int KPEONFBADJH, object[] BNOPOAPPFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x84C44F0", Offset = "0x84C32F0", VA = "0x1884C44F0")]
	private static void IEFELAEGEOL(JHIJFGFAEAB BBGEIKGKENC, MonoBehaviour FPFFMHMGONL, object[] NPIEBNDMCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x84C6970", Offset = "0x84C5770", VA = "0x1884C6970")]
	private static bool LPHMJPCLCMI(ParameterInfo[] BDJKEPNIHAI, Type[] MJHGINONKIO, [Out] bool PNMHMNDLOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x84C3530", Offset = "0x84C2330", VA = "0x1884C3530")]
	private List<JHIJFGFAEAB> FHNIIBAAEDB(MonoBehaviour FPFFMHMGONL, Type AHALOBBNEMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x84C6CB0", Offset = "0x84C5AB0", VA = "0x1884C6CB0")]
	private static IEnumerable<MethodInfo> PFMJAGNDGJB(Type ADGMECOLKNH, Type MPMALODOHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x84C43E0", Offset = "0x84C31E0", VA = "0x1884C43E0")]
	public static ParameterInfo[] HNALMJFJIBA(MethodInfo KDMPJFDMMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public PKKDMPENNIN()
	{
	}
}
namespace RecRoom.Networking
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RRNetworkSettings : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public const string RRNetworkSettingsFileName = "RRNetworkSettings";

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static RRNetworkSettings instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("RPC name list.\nUsed as shortcut when sending calls.")]
		public List<string> RpcList;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static RRNetworkSettings Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x84C9450", Offset = "0x84C8250", VA = "0x1884C9450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x84C93C0", Offset = "0x84C81C0", VA = "0x1884C93C0")]
		public RRNetworkSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, CBMAMJCDIJM, BNKOHIGCCOA, NCICGCMNPDN, DNAFFEFDHCK, OAHJJJLMEEF
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum EIADOJDKGIA
		{
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			False,
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			True_SetInSceneForRoom,
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			True_ManuallySetInPrefab
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class JEFECOFNKEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public int actorNumber;

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public JEFECOFNKEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x84BE150", Offset = "0x84BCF50", VA = "0x1884BE150")]
			internal bool DOCPBKAIBMN(RRNetworkView view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static Dictionary<int, RRNetworkView> CHFMEAIFNEC;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static ACKMCIEAMDG GPAGKCHGEPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private int viewIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private int instantiationIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private bool HMBADCFDKHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		internal bool GIBLFOOIKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		[SerializeField]
		public EIADOJDKGIA hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool AAAGOBAOMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private bool JAKFBFHLHCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int BCLNOCAMNGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private bool POPMFNBGADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int MKADMHNNDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private AFLCFHLHEHB KINIEEOGPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private AFLCFHLHEHB PIJLJMOEGFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool? BEAMDJOMPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private bool HAAJCLJDPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal bool ENJMCCBEKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		internal MonoBehaviour[] AHHFCDACOEM;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly ALMLLDBPKBM CECAHFJCOMH;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ViewId BDMDIAKJPEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x84CDA90", Offset = "0x84CC890", VA = "0x1884CDA90")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId NBONIIEIKNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x84CDA90", Offset = "0x84CC890", VA = "0x1884CDA90", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ViewId GJIOGDANHOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x84CDA90", Offset = "0x84CC890", VA = "0x1884CDA90")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int LEDFEKIIMGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int PDNAINNLJHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xABCF70", Offset = "0xABBD70", VA = "0x180ABCF70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xED7EC0", Offset = "0xED6CC0", VA = "0x180ED7EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public ViewId BJABIIBCICE
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x84CD900", Offset = "0x84CC700", VA = "0x1884CD900")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool NIDNIGNHKMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xA98D20", Offset = "0xA97B20", VA = "0x180A98D20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xA98C40", Offset = "0xA97A40", VA = "0x180A98C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool MGNALHIBMNF
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x84CD910", Offset = "0x84CC710", VA = "0x1884CD910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool ILMNCIICEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xC38800", Offset = "0xC37600", VA = "0x180C38800")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xC01980", Offset = "0xC00780", VA = "0x180C01980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int PECILACCBJF
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xAE48E0", Offset = "0xAE36E0", VA = "0x180AE48E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int CCBGFIEDFMH
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x84CD8A0", Offset = "0x84CC6A0", VA = "0x1884CD8A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public AFLCFHLHEHB LKEPGLHDENI
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x84CDAA0", Offset = "0x84CC8A0", VA = "0x1884CDAA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public AFLCFHLHEHB CKNPDPIIHDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x84CD870", Offset = "0x84CC670", VA = "0x1884CD870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public AFLCFHLHEHB BJGNPLBCFNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x84CD870", Offset = "0x84CC670", VA = "0x1884CD870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public AFLCFHLHEHB EIHNABGBOBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x84CD870", Offset = "0x84CC670", VA = "0x1884CD870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool HAIFCCOECMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x84CD9E0", Offset = "0x84CC7E0", VA = "0x1884CD9E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int NMOBPCPGONB
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x84CD8D0", Offset = "0x84CC6D0", VA = "0x1884CD8D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public object[] IHFNPGGDEGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xA98AD0", Offset = "0xA978D0", VA = "0x180A98AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool JGGFMHEILFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x84CDAD0", Offset = "0x84CC8D0", VA = "0x1884CDAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool MNFLDOBMFAB
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x84CDA60", Offset = "0x84CC860", VA = "0x1884CDA60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool AOICDAFDFKM
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xEA0FB0", Offset = "0xE9FDB0", VA = "0x180EA0FB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x101CDA0", Offset = "0x101BBA0", VA = "0x18101CDA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool CIGHLHEBGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xD3B1E0", Offset = "0xD39FE0", VA = "0x180D3B1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> CIAOIFKHFFL
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x84CD710", Offset = "0x84CC510", VA = "0x1884CD710")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x84CDC90", Offset = "0x84CCA90", VA = "0x1884CDC90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<AFLCFHLHEHB> BKFJHHKENIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x84CAD90", Offset = "0x84C9B90", VA = "0x1884CAD90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x84C9670", Offset = "0x84C8470", VA = "0x1884C9670")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<AFLCFHLHEHB> KMBAHNBAFBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x84CAD90", Offset = "0x84C9B90", VA = "0x1884CAD90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x84C9670", Offset = "0x84C8470", VA = "0x1884C9670")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> BEHPDINICIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x84CAC40", Offset = "0x84C9A40", VA = "0x1884CAC40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x84C95C0", Offset = "0x84C83C0", VA = "0x1884C95C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> ICNNADNGLBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x84CAC40", Offset = "0x84C9A40", VA = "0x1884CAC40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x84C95C0", Offset = "0x84C83C0", VA = "0x1884C95C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> KIENFCHBMAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x84CD7C0", Offset = "0x84CC5C0", VA = "0x1884CD7C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x84CDD40", Offset = "0x84CCB40", VA = "0x1884CDD40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action JNALKJLLGKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x84CD660", Offset = "0x84CC460", VA = "0x1884CD660")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x84CDBE0", Offset = "0x84CC9E0", VA = "0x1884CDBE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x84CD4A0", Offset = "0x84CC2A0", VA = "0x1884CD4A0")]
		public static bool TryGetNetworkView(int IAAFAPENNJO, [Out] RRNetworkView LNFCNKMMELP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x84CA310", Offset = "0x84C9110", VA = "0x1884CA310")]
		public static RRNetworkView Find(int IAAFAPENNJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x84CA600", Offset = "0x84C9400", VA = "0x1884CA600")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int OACBKGLNCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x84CA590", Offset = "0x84C9390", VA = "0x1884CA590")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x84CB900", Offset = "0x84CA700", VA = "0x1884CB900")]
		public static bool RemoveNetworkView(RRNetworkView LNFCNKMMELP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x84CB6D0", Offset = "0x84CA4D0", VA = "0x1884CB6D0")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x84CB0D0", Offset = "0x84C9ED0", VA = "0x1884CB0D0")]
		public static void OnPlayerJoinedRoom(AFLCFHLHEHB DKNBBLLPJCH, List<int> OFBNKGLIEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x84CA740", Offset = "0x84C9540", VA = "0x1884CA740")]
		public static RRNetworkView Get(Component PGJHFGMMOON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x84CA7A0", Offset = "0x84C95A0", VA = "0x1884CA7A0")]
		public static RRNetworkView Get(GameObject KBNJMGOEFOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x84CA1B0", Offset = "0x84C8FB0", VA = "0x1884CA1B0")]
		private void DNLKCHJCANJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x84C9C00", Offset = "0x84C8A00", VA = "0x1884C9C00")]
		public bool CreatedBy(AFLCFHLHEHB GLMBLPAKFLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x84CD2B0", Offset = "0x84CC0B0", VA = "0x1884CD2B0")]
		public void TransferOwnership(int JAJMOILGIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x84CD250", Offset = "0x84CC050", VA = "0x1884CD250")]
		public void TransferOwnership(AFLCFHLHEHB FEKNKDEFGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x84CAA20", Offset = "0x84C9820", VA = "0x1884CAA20", Slot = "4")]
		public void Initialize(ViewId IIDGAOMDGBD, ViewId PEIHIJMHIFA, Dictionary<int, object> IMNNEOMDPNB, JCHCDPDFDDM KINIEEOGPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x84CA9C0", Offset = "0x84C97C0", VA = "0x1884CA9C0")]
		public void Initialize(ViewId IIDGAOMDGBD, ViewId PEIHIJMHIFA, object[] CDCCKIHJCDK, JCHCDPDFDDM KINIEEOGPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x84C9790", Offset = "0x84C8590", VA = "0x1884C9790")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x84CA3A0", Offset = "0x84C91A0", VA = "0x1884CA3A0")]
		private void GCINAKEAGKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2082F90", Offset = "0x2081D90", VA = "0x182082F90")]
		internal void ENFNPHLCHAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x84C98D0", Offset = "0x84C86D0", VA = "0x1884C98D0", Slot = "6")]
		private void COFHPMIGFBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x84C9720", Offset = "0x84C8520", VA = "0x1884C9720")]
		internal bool AFLBFBDOAFN(RRNetworkView APCCHPNBMCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x84CAF30", Offset = "0x84C9D30", VA = "0x1884CAF30")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x84C97F0", Offset = "0x84C85F0", VA = "0x1884C97F0")]
		internal void BGPDJFLCCGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x84C98C0", Offset = "0x84C86C0", VA = "0x1884C98C0")]
		private void CLKFLMHLFLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x84CA0F0", Offset = "0x84C8EF0", VA = "0x1884CA0F0")]
		internal void DKCNNOAMPKB(AFLCFHLHEHB FEKNKDEFGLP, int JAJMOILGIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x84CB860", Offset = "0x84CA660", VA = "0x1884CB860")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x84CB980", Offset = "0x84CA780", VA = "0x1884CB980")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x84CACF0", Offset = "0x84C9AF0", VA = "0x1884CACF0")]
		private void MEPCJAOIJKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x84CAE40", Offset = "0x84C9C40", VA = "0x1884CAE40")]
		private void OOHABMMIIEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x84CB5B0", Offset = "0x84CA3B0", VA = "0x1884CB5B0")]
		public void RPC(string HLFOJCNGCCB, DPFDMEKAHAN BNIHAACOHPG, params object[] ONHEEOKCMKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x84CB640", Offset = "0x84CA440", VA = "0x1884CB640")]
		public void RPC(string HLFOJCNGCCB, AFLCFHLHEHB NPKICFNLIBN, params object[] ONHEEOKCMKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x84CB8B0", Offset = "0x84CA6B0", VA = "0x1884CB8B0")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x84C9850", Offset = "0x84C8650", VA = "0x1884C9850", Slot = "8")]
		public void Bake(LDEHODDHNKL KKBNGKDBMPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x84CA290", Offset = "0x84C9090", VA = "0x1884CA290")]
		private static void FAJHPIOBOII(AFLCFHLHEHB EAJPHPMCNGA, [Out] AFLCFHLHEHB MBABEJBFODJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x84C9C80", Offset = "0x84C8A80", VA = "0x1884C9C80")]
		private static void DJEAAAEKGKL(RRNetworkView IOPMDOAOFME, Delegate BBGEIKGKENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x84CB410", Offset = "0x84CA210", VA = "0x1884CB410")]
		private static PDCFLIPGAOH PGEDJGIJACK(RRNetworkView IOPMDOAOFME)
		{
			return default(PDCFLIPGAOH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x84CA800", Offset = "0x84C9600", VA = "0x1884CA800")]
		private static void IACHONNOJJA(RRNetworkView IOPMDOAOFME, Delegate BBGEIKGKENC, AFLCFHLHEHB CNKKHAFANFB, params object[] ONHEEOKCMKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x84CA8E0", Offset = "0x84C96E0", VA = "0x1884CA8E0")]
		private static void IACHONNOJJA(RRNetworkView IOPMDOAOFME, Delegate BBGEIKGKENC, DPFDMEKAHAN CNKKHAFANFB, params object[] ONHEEOKCMKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x84C9FA0", Offset = "0x84C8DA0", VA = "0x1884C9FA0")]
		private static void DJEGAAOLKGN(RRNetworkView IOPMDOAOFME, Delegate BBGEIKGKENC, DPFDMEKAHAN CNKKHAFANFB, JIJBAEDNDIK HFNLPCNBACF, params object[] ONHEEOKCMKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x84CB4B0", Offset = "0x84CA2B0", VA = "0x1884CB4B0")]
		public void RPCBuffered(string HLFOJCNGCCB, DPFDMEKAHAN BNIHAACOHPG, JIJBAEDNDIK CJLHNJBNBIM, params object[] ONHEEOKCMKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x84CABA0", Offset = "0x84C99A0", VA = "0x1884CABA0")]
		private static bool JAFMPADCHJF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x84CBE30", Offset = "0x84CAC30", VA = "0x1884CBE30", Slot = "26")]
		public void RpcAll(NAFLBDGBKOF.POFBNIMHNMI BBGEIKGKENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3FB14E0", Offset = "0x3FB02E0", VA = "0x183FB14E0", Slot = "9")]
		public void RpcAll<T1>(NAFLBDGBKOF.NJOADKFMIIG<T1> BBGEIKGKENC, T1 EKCMFHDCCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0D60", Offset = "0x3FAFB60", VA = "0x183FB0D60", Slot = "10")]
		public void RpcAll<T1, T2>(NAFLBDGBKOF.EFCAJNPJLMA<T1, T2> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3FB3AD0", Offset = "0x3FB28D0", VA = "0x183FB3AD0", Slot = "27")]
		public void RpcAll<T1, T2, T3>(NAFLBDGBKOF.ELNOMOFNMLK<T1, T2, T3> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0F70", Offset = "0x3FAFD70", VA = "0x183FB0F70", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(NAFLBDGBKOF.LDOPGPLDMLG<T1, T2, T3, T4> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3FB1BA0", Offset = "0x3FB09A0", VA = "0x183FB1BA0", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(NAFLBDGBKOF.LEKCFFJMKHF<T1, T2, T3, T4, T5> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3FB3FD0", Offset = "0x3FB2DD0", VA = "0x183FB3FD0", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(NAFLBDGBKOF.FCGHOLLFOFN<T1, T2, T3, T4, T5, T6> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3FB1670", Offset = "0x3FB0470", VA = "0x183FB1670", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(NAFLBDGBKOF.HBEDNBJHCEL<T1, T2, T3, T4, T5, T6, T7> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3FB8AF0", Offset = "0x3FB78F0", VA = "0x183FB8AF0", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(NAFLBDGBKOF.MGNAHDGCOKF<T1, T2, T3, T4, T5, T6, T7, T8> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3FB4470", Offset = "0x3FB3270", VA = "0x183FB4470", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NAFLBDGBKOF.GHOEJKMGLLL<T1, T2, T3, T4, T5, T6, T7, T8, T9> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3FB28B0", Offset = "0x3FB16B0", VA = "0x183FB28B0", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(AOLMJMLLCJD BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3FBE320", Offset = "0x3FBD120", VA = "0x183FBE320", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(FGKHHEDOJOG BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3FBD800", Offset = "0x3FBC600", VA = "0x183FBD800", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(EPOGPDCDKGP BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3FBCC00", Offset = "0x3FBBA00", VA = "0x183FBCC00", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LKKAJFLFAIB BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3FB1FE0", Offset = "0x3FB0DE0", VA = "0x183FB1FE0", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CFGMMMBMKLM BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH, T14 DIFAOHDKCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x84CBFA0", Offset = "0x84CADA0", VA = "0x1884CBFA0", Slot = "36")]
		public void RpcAll(NAFLBDGBKOF.NJOADKFMIIG<PDCFLIPGAOH> BBGEIKGKENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3FB6AB0", Offset = "0x3FB58B0", VA = "0x183FB6AB0", Slot = "37")]
		public void RpcAll<T1>(NAFLBDGBKOF.EFCAJNPJLMA<T1, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3FB76B0", Offset = "0x3FB64B0", VA = "0x183FB76B0", Slot = "38")]
		public void RpcAll<T1, T2>(NAFLBDGBKOF.ELNOMOFNMLK<T1, T2, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3FB3180", Offset = "0x3FB1F80", VA = "0x183FB3180", Slot = "39")]
		public void RpcAll<T1, T2, T3>(NAFLBDGBKOF.LDOPGPLDMLG<T1, T2, T3, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3FC1AC0", Offset = "0x3FC08C0", VA = "0x183FC1AC0", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(NAFLBDGBKOF.LEKCFFJMKHF<T1, T2, T3, T4, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3FC17C0", Offset = "0x3FC05C0", VA = "0x183FC17C0", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(NAFLBDGBKOF.FCGHOLLFOFN<T1, T2, T3, T4, T5, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3FC0E90", Offset = "0x3FBFC90", VA = "0x183FC0E90", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(NAFLBDGBKOF.HBEDNBJHCEL<T1, T2, T3, T4, T5, T6, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3FC0770", Offset = "0x3FBF570", VA = "0x183FC0770", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(NAFLBDGBKOF.MGNAHDGCOKF<T1, T2, T3, T4, T5, T6, T7, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3FC0360", Offset = "0x3FBF160", VA = "0x183FC0360", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(NAFLBDGBKOF.GHOEJKMGLLL<T1, T2, T3, T4, T5, T6, T7, T8, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3FBFB10", Offset = "0x3FBE910", VA = "0x183FBFB10", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AOLMJMLLCJD BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3FBF1F0", Offset = "0x3FBDFF0", VA = "0x183FBF1F0", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(FGKHHEDOJOG BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3FBE810", Offset = "0x3FBD610", VA = "0x183FBE810", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EPOGPDCDKGP BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3FBDD70", Offset = "0x3FBCB70", VA = "0x183FBDD70", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LKKAJFLFAIB BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3FBD1E0", Offset = "0x3FBBFE0", VA = "0x183FBD1E0", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CFGMMMBMKLM BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3FBC580", Offset = "0x3FBB380", VA = "0x183FBC580", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PAGDOKABHBN BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH, T14 DIFAOHDKCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x84CBD00", Offset = "0x84CAB00", VA = "0x1884CBD00", Slot = "51")]
		public void RpcAllViaServer(NAFLBDGBKOF.POFBNIMHNMI BBGEIKGKENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0B60", Offset = "0x3FAF960", VA = "0x183FB0B60", Slot = "52")]
		public void RpcAllViaServer<T1>(NAFLBDGBKOF.NJOADKFMIIG<T1> BBGEIKGKENC, T1 EKCMFHDCCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3FAB470", Offset = "0x3FAA270", VA = "0x183FAB470", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(NAFLBDGBKOF.EFCAJNPJLMA<T1, T2> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0540", Offset = "0x3FAF340", VA = "0x183FB0540", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(NAFLBDGBKOF.ELNOMOFNMLK<T1, T2, T3> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0140", Offset = "0x3FAEF40", VA = "0x183FB0140", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(NAFLBDGBKOF.LDOPGPLDMLG<T1, T2, T3, T4> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3FAFEF0", Offset = "0x3FAECF0", VA = "0x183FAFEF0", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(NAFLBDGBKOF.LEKCFFJMKHF<T1, T2, T3, T4, T5> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3FAFA10", Offset = "0x3FAE810", VA = "0x183FAFA10", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(NAFLBDGBKOF.FCGHOLLFOFN<T1, T2, T3, T4, T5, T6> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3FAF1C0", Offset = "0x3FADFC0", VA = "0x183FAF1C0", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(NAFLBDGBKOF.HBEDNBJHCEL<T1, T2, T3, T4, T5, T6, T7> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3FAEB60", Offset = "0x3FAD960", VA = "0x183FAEB60", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(NAFLBDGBKOF.MGNAHDGCOKF<T1, T2, T3, T4, T5, T6, T7, T8> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3FAE460", Offset = "0x3FAD260", VA = "0x183FAE460", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NAFLBDGBKOF.GHOEJKMGLLL<T1, T2, T3, T4, T5, T6, T7, T8, T9> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3FADCC0", Offset = "0x3FACAC0", VA = "0x183FADCC0", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(AOLMJMLLCJD BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3FAD480", Offset = "0x3FAC280", VA = "0x183FAD480", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(FGKHHEDOJOG BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3FAD010", Offset = "0x3FABE10", VA = "0x183FAD010", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(EPOGPDCDKGP BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3FAC6E0", Offset = "0x3FAB4E0", VA = "0x183FAC6E0", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LKKAJFLFAIB BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3FABD00", Offset = "0x3FAAB00", VA = "0x183FABD00", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CFGMMMBMKLM BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH, T14 DIFAOHDKCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x84CBBD0", Offset = "0x84CA9D0", VA = "0x1884CBBD0", Slot = "65")]
		public void RpcAllViaServer(NAFLBDGBKOF.NJOADKFMIIG<PDCFLIPGAOH> BBGEIKGKENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0C60", Offset = "0x3FAFA60", VA = "0x183FB0C60", Slot = "66")]
		public void RpcAllViaServer<T1>(NAFLBDGBKOF.EFCAJNPJLMA<T1, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3FB08A0", Offset = "0x3FAF6A0", VA = "0x183FB08A0", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(NAFLBDGBKOF.ELNOMOFNMLK<T1, T2, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3FB06F0", Offset = "0x3FAF4F0", VA = "0x183FB06F0", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(NAFLBDGBKOF.LDOPGPLDMLG<T1, T2, T3, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0340", Offset = "0x3FAF140", VA = "0x183FB0340", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(NAFLBDGBKOF.LEKCFFJMKHF<T1, T2, T3, T4, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3FAFCA0", Offset = "0x3FAEAA0", VA = "0x183FAFCA0", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(NAFLBDGBKOF.FCGHOLLFOFN<T1, T2, T3, T4, T5, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3FAF780", Offset = "0x3FAE580", VA = "0x183FAF780", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(NAFLBDGBKOF.HBEDNBJHCEL<T1, T2, T3, T4, T5, T6, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3FAF4A0", Offset = "0x3FAE2A0", VA = "0x183FAF4A0", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(NAFLBDGBKOF.MGNAHDGCOKF<T1, T2, T3, T4, T5, T6, T7, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3FAEE90", Offset = "0x3FADC90", VA = "0x183FAEE90", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(NAFLBDGBKOF.GHOEJKMGLLL<T1, T2, T3, T4, T5, T6, T7, T8, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3FAE7E0", Offset = "0x3FAD5E0", VA = "0x183FAE7E0", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AOLMJMLLCJD BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3FAE090", Offset = "0x3FACE90", VA = "0x183FAE090", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(FGKHHEDOJOG BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3FAD8A0", Offset = "0x3FAC6A0", VA = "0x183FAD8A0", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EPOGPDCDKGP BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3FACBA0", Offset = "0x3FAB9A0", VA = "0x183FACBA0", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LKKAJFLFAIB BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3FAC220", Offset = "0x3FAB020", VA = "0x183FAC220", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CFGMMMBMKLM BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3FAB7E0", Offset = "0x3FAA5E0", VA = "0x183FAB7E0", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PAGDOKABHBN BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH, T14 DIFAOHDKCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x84CCC40", Offset = "0x84CBA40", VA = "0x1884CCC40", Slot = "80")]
		public void RpcOthers(NAFLBDGBKOF.POFBNIMHNMI BBGEIKGKENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3FEAC00", Offset = "0x3FE9A00", VA = "0x183FEAC00", Slot = "15")]
		public void RpcOthers<T1>(NAFLBDGBKOF.NJOADKFMIIG<T1> BBGEIKGKENC, T1 EKCMFHDCCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3FEB4B0", Offset = "0x3FEA2B0", VA = "0x183FEB4B0", Slot = "81")]
		public void RpcOthers<T1, T2>(NAFLBDGBKOF.EFCAJNPJLMA<T1, T2> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3FEA980", Offset = "0x3FE9780", VA = "0x183FEA980", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(NAFLBDGBKOF.ELNOMOFNMLK<T1, T2, T3> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1850", Offset = "0x3FF0650", VA = "0x183FF1850", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(NAFLBDGBKOF.LDOPGPLDMLG<T1, T2, T3, T4> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1150", Offset = "0x3FEFF50", VA = "0x183FF1150", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(NAFLBDGBKOF.LEKCFFJMKHF<T1, T2, T3, T4, T5> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3FEC210", Offset = "0x3FEB010", VA = "0x183FEC210", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(NAFLBDGBKOF.FCGHOLLFOFN<T1, T2, T3, T4, T5, T6> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3FF08C0", Offset = "0x3FEF6C0", VA = "0x183FF08C0", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(NAFLBDGBKOF.HBEDNBJHCEL<T1, T2, T3, T4, T5, T6, T7> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3FEFEF0", Offset = "0x3FEECF0", VA = "0x183FEFEF0", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(NAFLBDGBKOF.MGNAHDGCOKF<T1, T2, T3, T4, T5, T6, T7, T8> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF790", Offset = "0x3FEE590", VA = "0x183FEF790", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NAFLBDGBKOF.GHOEJKMGLLL<T1, T2, T3, T4, T5, T6, T7, T8, T9> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF3A0", Offset = "0x3FEE1A0", VA = "0x183FEF3A0", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(AOLMJMLLCJD BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3FEEB70", Offset = "0x3FED970", VA = "0x183FEEB70", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(FGKHHEDOJOG BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3FEE2A0", Offset = "0x3FED0A0", VA = "0x183FEE2A0", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(EPOGPDCDKGP BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3FED430", Offset = "0x3FEC230", VA = "0x183FED430", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LKKAJFLFAIB BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3FEC9B0", Offset = "0x3FEB7B0", VA = "0x183FEC9B0", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CFGMMMBMKLM BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH, T14 DIFAOHDKCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x84CCAF0", Offset = "0x84CB8F0", VA = "0x1884CCAF0", Slot = "93")]
		public void RpcOthers(NAFLBDGBKOF.NJOADKFMIIG<PDCFLIPGAOH> BBGEIKGKENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3FEB210", Offset = "0x3FEA010", VA = "0x183FEB210", Slot = "94")]
		public void RpcOthers<T1>(NAFLBDGBKOF.EFCAJNPJLMA<T1, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3FEB030", Offset = "0x3FE9E30", VA = "0x183FEB030", Slot = "95")]
		public void RpcOthers<T1, T2>(NAFLBDGBKOF.ELNOMOFNMLK<T1, T2, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3FF2410", Offset = "0x3FF1210", VA = "0x183FF2410", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(NAFLBDGBKOF.LDOPGPLDMLG<T1, T2, T3, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3FEAD50", Offset = "0x3FE9B50", VA = "0x183FEAD50", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(NAFLBDGBKOF.LEKCFFJMKHF<T1, T2, T3, T4, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3FEB9A0", Offset = "0x3FEA7A0", VA = "0x183FEB9A0", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(NAFLBDGBKOF.FCGHOLLFOFN<T1, T2, T3, T4, T5, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3FEBCE0", Offset = "0x3FEAAE0", VA = "0x183FEBCE0", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(NAFLBDGBKOF.HBEDNBJHCEL<T1, T2, T3, T4, T5, T6, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3FF05B0", Offset = "0x3FEF3B0", VA = "0x183FF05B0", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(NAFLBDGBKOF.MGNAHDGCOKF<T1, T2, T3, T4, T5, T6, T7, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3FF0250", Offset = "0x3FEF050", VA = "0x183FF0250", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(NAFLBDGBKOF.GHOEJKMGLLL<T1, T2, T3, T4, T5, T6, T7, T8, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3FEFB40", Offset = "0x3FEE940", VA = "0x183FEFB40", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AOLMJMLLCJD BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3FEEFB0", Offset = "0x3FEDDB0", VA = "0x183FEEFB0", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(FGKHHEDOJOG BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3FEE730", Offset = "0x3FED530", VA = "0x183FEE730", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EPOGPDCDKGP BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3FEDE10", Offset = "0x3FECC10", VA = "0x183FEDE10", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LKKAJFLFAIB BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3FED920", Offset = "0x3FEC720", VA = "0x183FED920", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CFGMMMBMKLM BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3FECEF0", Offset = "0x3FEBCF0", VA = "0x183FECEF0", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PAGDOKABHBN BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH, T14 DIFAOHDKCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x84CC5E0", Offset = "0x84CB3E0", VA = "0x1884CC5E0", Slot = "108")]
		public void RpcMaster(NAFLBDGBKOF.POFBNIMHNMI BBGEIKGKENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3FD5770", Offset = "0x3FD4570", VA = "0x183FD5770", Slot = "109")]
		public void RpcMaster<T1>(NAFLBDGBKOF.NJOADKFMIIG<T1> BBGEIKGKENC, T1 EKCMFHDCCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3FD5910", Offset = "0x3FD4710", VA = "0x183FD5910", Slot = "17")]
		public void RpcMaster<T1, T2>(NAFLBDGBKOF.EFCAJNPJLMA<T1, T2> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3FD52C0", Offset = "0x3FD40C0", VA = "0x183FD52C0", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(NAFLBDGBKOF.ELNOMOFNMLK<T1, T2, T3> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3FD4F70", Offset = "0x3FD3D70", VA = "0x183FD4F70", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(NAFLBDGBKOF.LDOPGPLDMLG<T1, T2, T3, T4> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3FD8F90", Offset = "0x3FD7D90", VA = "0x183FD8F90", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(NAFLBDGBKOF.LEKCFFJMKHF<T1, T2, T3, T4, T5> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3FDB360", Offset = "0x3FDA160", VA = "0x183FDB360", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(NAFLBDGBKOF.FCGHOLLFOFN<T1, T2, T3, T4, T5, T6> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3FE1300", Offset = "0x3FE0100", VA = "0x183FE1300", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(NAFLBDGBKOF.HBEDNBJHCEL<T1, T2, T3, T4, T5, T6, T7> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3FE0B10", Offset = "0x3FDF910", VA = "0x183FE0B10", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(NAFLBDGBKOF.MGNAHDGCOKF<T1, T2, T3, T4, T5, T6, T7, T8> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3FDFDB0", Offset = "0x3FDEBB0", VA = "0x183FDFDB0", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NAFLBDGBKOF.GHOEJKMGLLL<T1, T2, T3, T4, T5, T6, T7, T8, T9> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3FD8760", Offset = "0x3FD7560", VA = "0x183FD8760", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(AOLMJMLLCJD BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3FD7390", Offset = "0x3FD6190", VA = "0x183FD7390", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(FGKHHEDOJOG BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3FDDE10", Offset = "0x3FDCC10", VA = "0x183FDDE10", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(EPOGPDCDKGP BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3FDD830", Offset = "0x3FDC630", VA = "0x183FDD830", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LKKAJFLFAIB BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3FDCBC0", Offset = "0x3FDB9C0", VA = "0x183FDCBC0", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CFGMMMBMKLM BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH, T14 DIFAOHDKCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x84CC770", Offset = "0x84CB570", VA = "0x1884CC770", Slot = "122")]
		public void RpcMaster(NAFLBDGBKOF.NJOADKFMIIG<PDCFLIPGAOH> BBGEIKGKENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3FD5580", Offset = "0x3FD4380", VA = "0x183FD5580", Slot = "123")]
		public void RpcMaster<T1>(NAFLBDGBKOF.EFCAJNPJLMA<T1, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3FD63B0", Offset = "0x3FD51B0", VA = "0x183FD63B0", Slot = "124")]
		public void RpcMaster<T1, T2>(NAFLBDGBKOF.ELNOMOFNMLK<T1, T2, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3FD5B60", Offset = "0x3FD4960", VA = "0x183FD5B60", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(NAFLBDGBKOF.LDOPGPLDMLG<T1, T2, T3, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3FE2380", Offset = "0x3FE1180", VA = "0x183FE2380", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(NAFLBDGBKOF.LEKCFFJMKHF<T1, T2, T3, T4, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3FD99B0", Offset = "0x3FD87B0", VA = "0x183FD99B0", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(NAFLBDGBKOF.FCGHOLLFOFN<T1, T2, T3, T4, T5, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3FE16A0", Offset = "0x3FE04A0", VA = "0x183FE16A0", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(NAFLBDGBKOF.HBEDNBJHCEL<T1, T2, T3, T4, T5, T6, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3FE0F10", Offset = "0x3FDFD10", VA = "0x183FE0F10", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(NAFLBDGBKOF.MGNAHDGCOKF<T1, T2, T3, T4, T5, T6, T7, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3FE06C0", Offset = "0x3FDF4C0", VA = "0x183FE06C0", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(NAFLBDGBKOF.GHOEJKMGLLL<T1, T2, T3, T4, T5, T6, T7, T8, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3FE0210", Offset = "0x3FDF010", VA = "0x183FE0210", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AOLMJMLLCJD BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3FDF8A0", Offset = "0x3FDE6A0", VA = "0x183FDF8A0", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(FGKHHEDOJOG BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3FDE950", Offset = "0x3FDD750", VA = "0x183FDE950", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EPOGPDCDKGP BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3FDE380", Offset = "0x3FDD180", VA = "0x183FDE380", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LKKAJFLFAIB BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3FDD200", Offset = "0x3FDC000", VA = "0x183FDD200", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CFGMMMBMKLM BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3FDC530", Offset = "0x3FDB330", VA = "0x183FDC530", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PAGDOKABHBN BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH, T14 DIFAOHDKCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x84CC1D0", Offset = "0x84CAFD0", VA = "0x1884CC1D0", Slot = "137")]
		public void RpcAuthority(NAFLBDGBKOF.POFBNIMHNMI BBGEIKGKENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3FC8FF0", Offset = "0x3FC7DF0", VA = "0x183FC8FF0", Slot = "138")]
		public void RpcAuthority<T1>(NAFLBDGBKOF.NJOADKFMIIG<T1> BBGEIKGKENC, T1 EKCMFHDCCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3FCA1A0", Offset = "0x3FC8FA0", VA = "0x183FCA1A0", Slot = "139")]
		public void RpcAuthority<T1, T2>(NAFLBDGBKOF.EFCAJNPJLMA<T1, T2> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3FCA950", Offset = "0x3FC9750", VA = "0x183FCA950", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(NAFLBDGBKOF.ELNOMOFNMLK<T1, T2, T3> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3FC9E70", Offset = "0x3FC8C70", VA = "0x183FC9E70", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(NAFLBDGBKOF.LDOPGPLDMLG<T1, T2, T3, T4> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3FC8BF0", Offset = "0x3FC79F0", VA = "0x183FC8BF0", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(NAFLBDGBKOF.LEKCFFJMKHF<T1, T2, T3, T4, T5> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3FCBDB0", Offset = "0x3FCABB0", VA = "0x183FCBDB0", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(NAFLBDGBKOF.FCGHOLLFOFN<T1, T2, T3, T4, T5, T6> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3FCB5F0", Offset = "0x3FCA3F0", VA = "0x183FCB5F0", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(NAFLBDGBKOF.HBEDNBJHCEL<T1, T2, T3, T4, T5, T6, T7> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3FD4460", Offset = "0x3FD3260", VA = "0x183FD4460", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(NAFLBDGBKOF.MGNAHDGCOKF<T1, T2, T3, T4, T5, T6, T7, T8> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3FD3B30", Offset = "0x3FD2930", VA = "0x183FD3B30", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(NAFLBDGBKOF.GHOEJKMGLLL<T1, T2, T3, T4, T5, T6, T7, T8, T9> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3FD3660", Offset = "0x3FD2460", VA = "0x183FD3660", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(AOLMJMLLCJD BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3FD2690", Offset = "0x3FD1490", VA = "0x183FD2690", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(FGKHHEDOJOG BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3FCFB00", Offset = "0x3FCE900", VA = "0x183FCFB00", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(EPOGPDCDKGP BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3FD0EF0", Offset = "0x3FCFCF0", VA = "0x183FD0EF0", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LKKAJFLFAIB BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3FD0200", Offset = "0x3FCF000", VA = "0x183FD0200", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(CFGMMMBMKLM BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH, T14 DIFAOHDKCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x84CC380", Offset = "0x84CB180", VA = "0x1884CC380", Slot = "152")]
		public void RpcAuthority(NAFLBDGBKOF.NJOADKFMIIG<PDCFLIPGAOH> BBGEIKGKENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3FCDDD0", Offset = "0x3FCCBD0", VA = "0x183FCDDD0", Slot = "153")]
		public void RpcAuthority<T1>(NAFLBDGBKOF.EFCAJNPJLMA<T1, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3FCD7A0", Offset = "0x3FCC5A0", VA = "0x183FCD7A0", Slot = "154")]
		public void RpcAuthority<T1, T2>(NAFLBDGBKOF.ELNOMOFNMLK<T1, T2, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3FCD2B0", Offset = "0x3FCC0B0", VA = "0x183FCD2B0", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(NAFLBDGBKOF.LDOPGPLDMLG<T1, T2, T3, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3FCCB00", Offset = "0x3FCB900", VA = "0x183FCCB00", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(NAFLBDGBKOF.LEKCFFJMKHF<T1, T2, T3, T4, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3FCC7B0", Offset = "0x3FCB5B0", VA = "0x183FCC7B0", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(NAFLBDGBKOF.FCGHOLLFOFN<T1, T2, T3, T4, T5, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3FCC100", Offset = "0x3FCAF00", VA = "0x183FCC100", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(NAFLBDGBKOF.HBEDNBJHCEL<T1, T2, T3, T4, T5, T6, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3FCB9B0", Offset = "0x3FCA7B0", VA = "0x183FCB9B0", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(NAFLBDGBKOF.MGNAHDGCOKF<T1, T2, T3, T4, T5, T6, T7, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3FCB190", Offset = "0x3FC9F90", VA = "0x183FCB190", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(NAFLBDGBKOF.GHOEJKMGLLL<T1, T2, T3, T4, T5, T6, T7, T8, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3FD3FA0", Offset = "0x3FD2DA0", VA = "0x183FD3FA0", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AOLMJMLLCJD BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3FD3140", Offset = "0x3FD1F40", VA = "0x183FD3140", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(FGKHHEDOJOG BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3FD2BC0", Offset = "0x3FD19C0", VA = "0x183FD2BC0", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(EPOGPDCDKGP BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3FD1B20", Offset = "0x3FD0920", VA = "0x183FD1B20", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LKKAJFLFAIB BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3FD14E0", Offset = "0x3FD02E0", VA = "0x183FD14E0", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(CFGMMMBMKLM BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3FD0850", Offset = "0x3FCF650", VA = "0x183FD0850", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(PAGDOKABHBN BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH, T14 DIFAOHDKCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x84CCD90", Offset = "0x84CBB90", VA = "0x1884CCD90", Slot = "18")]
		public void RpcPlayer(AFLCFHLHEHB GLMBLPAKFLM, NAFLBDGBKOF.POFBNIMHNMI BBGEIKGKENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3FF3890", Offset = "0x3FF2690", VA = "0x183FF3890", Slot = "19")]
		public void RpcPlayer<T1>(AFLCFHLHEHB GLMBLPAKFLM, NAFLBDGBKOF.NJOADKFMIIG<T1> BBGEIKGKENC, T1 EKCMFHDCCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3FF4600", Offset = "0x3FF3400", VA = "0x183FF4600", Slot = "20")]
		public void RpcPlayer<T1, T2>(AFLCFHLHEHB GLMBLPAKFLM, NAFLBDGBKOF.EFCAJNPJLMA<T1, T2> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3FF4020", Offset = "0x3FF2E20", VA = "0x183FF4020", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(AFLCFHLHEHB GLMBLPAKFLM, NAFLBDGBKOF.ELNOMOFNMLK<T1, T2, T3> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3FF3A60", Offset = "0x3FF2860", VA = "0x183FF3A60", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(AFLCFHLHEHB GLMBLPAKFLM, NAFLBDGBKOF.LDOPGPLDMLG<T1, T2, T3, T4> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3FF8060", Offset = "0x3FF6E60", VA = "0x183FF8060", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(AFLCFHLHEHB GLMBLPAKFLM, NAFLBDGBKOF.LEKCFFJMKHF<T1, T2, T3, T4, T5> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7C00", Offset = "0x3FF6A00", VA = "0x183FF7C00", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(AFLCFHLHEHB GLMBLPAKFLM, NAFLBDGBKOF.FCGHOLLFOFN<T1, T2, T3, T4, T5, T6> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3FF8440", Offset = "0x3FF7240", VA = "0x183FF8440", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(AFLCFHLHEHB GLMBLPAKFLM, NAFLBDGBKOF.HBEDNBJHCEL<T1, T2, T3, T4, T5, T6, T7> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3FF8900", Offset = "0x3FF7700", VA = "0x183FF8900", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(AFLCFHLHEHB GLMBLPAKFLM, NAFLBDGBKOF.MGNAHDGCOKF<T1, T2, T3, T4, T5, T6, T7, T8> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3FFEFC0", Offset = "0x3FFDDC0", VA = "0x183FFEFC0", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AFLCFHLHEHB GLMBLPAKFLM, NAFLBDGBKOF.GHOEJKMGLLL<T1, T2, T3, T4, T5, T6, T7, T8, T9> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3FFE600", Offset = "0x3FFD400", VA = "0x183FFE600", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(AFLCFHLHEHB GLMBLPAKFLM, AOLMJMLLCJD BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3FF4EC0", Offset = "0x3FF3CC0", VA = "0x183FF4EC0", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(AFLCFHLHEHB GLMBLPAKFLM, FGKHHEDOJOG BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3FFD060", Offset = "0x3FFBE60", VA = "0x183FFD060", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AFLCFHLHEHB GLMBLPAKFLM, EPOGPDCDKGP BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3FFC460", Offset = "0x3FFB260", VA = "0x183FFC460", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(AFLCFHLHEHB GLMBLPAKFLM, LKKAJFLFAIB BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3FFB0E0", Offset = "0x3FF9EE0", VA = "0x183FFB0E0", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(AFLCFHLHEHB GLMBLPAKFLM, CFGMMMBMKLM BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH, T14 DIFAOHDKCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x84CCF90", Offset = "0x84CBD90", VA = "0x1884CCF90", Slot = "176")]
		public void RpcPlayer(AFLCFHLHEHB GLMBLPAKFLM, NAFLBDGBKOF.NJOADKFMIIG<PDCFLIPGAOH> BBGEIKGKENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3FF3DF0", Offset = "0x3FF2BF0", VA = "0x183FF3DF0", Slot = "177")]
		public void RpcPlayer<T1>(AFLCFHLHEHB GLMBLPAKFLM, NAFLBDGBKOF.EFCAJNPJLMA<T1, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3FF4BE0", Offset = "0x3FF39E0", VA = "0x183FF4BE0", Slot = "24")]
		public void RpcPlayer<T1, T2>(AFLCFHLHEHB GLMBLPAKFLM, NAFLBDGBKOF.ELNOMOFNMLK<T1, T2, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3FF4870", Offset = "0x3FF3670", VA = "0x183FF4870", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(AFLCFHLHEHB GLMBLPAKFLM, NAFLBDGBKOF.LDOPGPLDMLG<T1, T2, T3, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3FF66A0", Offset = "0x3FF54A0", VA = "0x183FF66A0", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(AFLCFHLHEHB GLMBLPAKFLM, NAFLBDGBKOF.LEKCFFJMKHF<T1, T2, T3, T4, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x4000EF0", Offset = "0x3FFFCF0", VA = "0x184000EF0", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(AFLCFHLHEHB GLMBLPAKFLM, NAFLBDGBKOF.FCGHOLLFOFN<T1, T2, T3, T4, T5, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x4000830", Offset = "0x3FFF630", VA = "0x184000830", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(AFLCFHLHEHB GLMBLPAKFLM, NAFLBDGBKOF.HBEDNBJHCEL<T1, T2, T3, T4, T5, T6, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3FFFCF0", Offset = "0x3FFEAF0", VA = "0x183FFFCF0", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(AFLCFHLHEHB GLMBLPAKFLM, NAFLBDGBKOF.MGNAHDGCOKF<T1, T2, T3, T4, T5, T6, T7, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3FFF450", Offset = "0x3FFE250", VA = "0x183FFF450", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(AFLCFHLHEHB GLMBLPAKFLM, NAFLBDGBKOF.GHOEJKMGLLL<T1, T2, T3, T4, T5, T6, T7, T8, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3FFEAF0", Offset = "0x3FFD8F0", VA = "0x183FFEAF0", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(AFLCFHLHEHB GLMBLPAKFLM, AOLMJMLLCJD BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3FFE0D0", Offset = "0x3FFCED0", VA = "0x183FFE0D0", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(AFLCFHLHEHB GLMBLPAKFLM, FGKHHEDOJOG BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3FFD600", Offset = "0x3FFC400", VA = "0x183FFD600", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(AFLCFHLHEHB GLMBLPAKFLM, EPOGPDCDKGP BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3FFCA70", Offset = "0x3FFB870", VA = "0x183FFCA70", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(AFLCFHLHEHB GLMBLPAKFLM, LKKAJFLFAIB BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3FFBE10", Offset = "0x3FFAC10", VA = "0x183FFBE10", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(AFLCFHLHEHB GLMBLPAKFLM, CFGMMMBMKLM BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3FFB750", Offset = "0x3FFA550", VA = "0x183FFB750", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(AFLCFHLHEHB GLMBLPAKFLM, PAGDOKABHBN BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH, T14 DIFAOHDKCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x84CBB30", Offset = "0x84CA930", VA = "0x1884CBB30", Slot = "189")]
		public void RpcAllBuffered(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.POFBNIMHNMI BBGEIKGKENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3FAB350", Offset = "0x3FAA150", VA = "0x183FAB350", Slot = "190")]
		public void RpcAllBuffered<T1>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.NJOADKFMIIG<T1> BBGEIKGKENC, T1 EKCMFHDCCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3FAAF50", Offset = "0x3FA9D50", VA = "0x183FAAF50", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.EFCAJNPJLMA<T1, T2> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3FAAD90", Offset = "0x3FA9B90", VA = "0x183FAAD90", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.ELNOMOFNMLK<T1, T2, T3> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3FAA9C0", Offset = "0x3FA97C0", VA = "0x183FAA9C0", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.LDOPGPLDMLG<T1, T2, T3, T4> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3FAA560", Offset = "0x3FA9360", VA = "0x183FAA560", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.LEKCFFJMKHF<T1, T2, T3, T4, T5> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3FA9DD0", Offset = "0x3FA8BD0", VA = "0x183FA9DD0", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.FCGHOLLFOFN<T1, T2, T3, T4, T5, T6> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3FA9AE0", Offset = "0x3FA88E0", VA = "0x183FA9AE0", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.HBEDNBJHCEL<T1, T2, T3, T4, T5, T6, T7> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3FA9170", Offset = "0x3FA7F70", VA = "0x183FA9170", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.MGNAHDGCOKF<T1, T2, T3, T4, T5, T6, T7, T8> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3FA8DE0", Offset = "0x3FA7BE0", VA = "0x183FA8DE0", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.GHOEJKMGLLL<T1, T2, T3, T4, T5, T6, T7, T8, T9> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3FA8670", Offset = "0x3FA7470", VA = "0x183FA8670", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JIJBAEDNDIK CJLHNJBNBIM, AOLMJMLLCJD BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3FA7E60", Offset = "0x3FA6C60", VA = "0x183FA7E60", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(JIJBAEDNDIK CJLHNJBNBIM, FGKHHEDOJOG BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3FA7130", Offset = "0x3FA5F30", VA = "0x183FA7130", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JIJBAEDNDIK CJLHNJBNBIM, EPOGPDCDKGP BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3FA6790", Offset = "0x3FA5590", VA = "0x183FA6790", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JIJBAEDNDIK CJLHNJBNBIM, LKKAJFLFAIB BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3FA5D50", Offset = "0x3FA4B50", VA = "0x183FA5D50", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JIJBAEDNDIK CJLHNJBNBIM, CFGMMMBMKLM BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH, T14 DIFAOHDKCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x84CBA90", Offset = "0x84CA890", VA = "0x1884CBA90", Slot = "204")]
		public void RpcAllBuffered(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.NJOADKFMIIG<PDCFLIPGAOH> BBGEIKGKENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3FAB230", Offset = "0x3FAA030", VA = "0x183FAB230", Slot = "205")]
		public void RpcAllBuffered<T1>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.EFCAJNPJLMA<T1, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3FAB0C0", Offset = "0x3FA9EC0", VA = "0x183FAB0C0", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.ELNOMOFNMLK<T1, T2, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3FAABD0", Offset = "0x3FA99D0", VA = "0x183FAABD0", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.LDOPGPLDMLG<T1, T2, T3, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3FAA7B0", Offset = "0x3FA95B0", VA = "0x183FAA7B0", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.LEKCFFJMKHF<T1, T2, T3, T4, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3FAA310", Offset = "0x3FA9110", VA = "0x183FAA310", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.FCGHOLLFOFN<T1, T2, T3, T4, T5, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3FAA070", Offset = "0x3FA8E70", VA = "0x183FAA070", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.HBEDNBJHCEL<T1, T2, T3, T4, T5, T6, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3FA97F0", Offset = "0x3FA85F0", VA = "0x183FA97F0", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.MGNAHDGCOKF<T1, T2, T3, T4, T5, T6, T7, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3FA94B0", Offset = "0x3FA82B0", VA = "0x183FA94B0", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.GHOEJKMGLLL<T1, T2, T3, T4, T5, T6, T7, T8, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3FA8A50", Offset = "0x3FA7850", VA = "0x183FA8A50", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JIJBAEDNDIK CJLHNJBNBIM, AOLMJMLLCJD BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3FA8290", Offset = "0x3FA7090", VA = "0x183FA8290", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JIJBAEDNDIK CJLHNJBNBIM, FGKHHEDOJOG BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3FA7A30", Offset = "0x3FA6830", VA = "0x183FA7A30", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(JIJBAEDNDIK CJLHNJBNBIM, EPOGPDCDKGP BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3FA75B0", Offset = "0x3FA63B0", VA = "0x183FA75B0", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JIJBAEDNDIK CJLHNJBNBIM, LKKAJFLFAIB BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3FA6C60", Offset = "0x3FA5A60", VA = "0x183FA6C60", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JIJBAEDNDIK CJLHNJBNBIM, CFGMMMBMKLM BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3FA6270", Offset = "0x3FA5070", VA = "0x183FA6270", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JIJBAEDNDIK CJLHNJBNBIM, PAGDOKABHBN BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH, T14 DIFAOHDKCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x84CC9B0", Offset = "0x84CB7B0", VA = "0x1884CC9B0", Slot = "219")]
		public void RpcOthersBuffered(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.POFBNIMHNMI BBGEIKGKENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3FEA860", Offset = "0x3FE9660", VA = "0x183FEA860", Slot = "220")]
		public void RpcOthersBuffered<T1>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.NJOADKFMIIG<T1> BBGEIKGKENC, T1 EKCMFHDCCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3FEA460", Offset = "0x3FE9260", VA = "0x183FEA460", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.EFCAJNPJLMA<T1, T2> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3FEA2A0", Offset = "0x3FE90A0", VA = "0x183FEA2A0", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.ELNOMOFNMLK<T1, T2, T3> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3FE9ED0", Offset = "0x3FE8CD0", VA = "0x183FE9ED0", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.LDOPGPLDMLG<T1, T2, T3, T4> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3FE9A70", Offset = "0x3FE8870", VA = "0x183FE9A70", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.LEKCFFJMKHF<T1, T2, T3, T4, T5> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3FE92E0", Offset = "0x3FE80E0", VA = "0x183FE92E0", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.FCGHOLLFOFN<T1, T2, T3, T4, T5, T6> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3FE8D00", Offset = "0x3FE7B00", VA = "0x183FE8D00", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.HBEDNBJHCEL<T1, T2, T3, T4, T5, T6, T7> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3FE8680", Offset = "0x3FE7480", VA = "0x183FE8680", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.MGNAHDGCOKF<T1, T2, T3, T4, T5, T6, T7, T8> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7F60", Offset = "0x3FE6D60", VA = "0x183FE7F60", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.GHOEJKMGLLL<T1, T2, T3, T4, T5, T6, T7, T8, T9> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3FE77A0", Offset = "0x3FE65A0", VA = "0x183FE77A0", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JIJBAEDNDIK CJLHNJBNBIM, AOLMJMLLCJD BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7370", Offset = "0x3FE6170", VA = "0x183FE7370", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(JIJBAEDNDIK CJLHNJBNBIM, FGKHHEDOJOG BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3FE6AC0", Offset = "0x3FE58C0", VA = "0x183FE6AC0", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JIJBAEDNDIK CJLHNJBNBIM, EPOGPDCDKGP BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3FE5CA0", Offset = "0x3FE4AA0", VA = "0x183FE5CA0", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JIJBAEDNDIK CJLHNJBNBIM, LKKAJFLFAIB BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3FE5780", Offset = "0x3FE4580", VA = "0x183FE5780", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JIJBAEDNDIK CJLHNJBNBIM, CFGMMMBMKLM BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH, T14 DIFAOHDKCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x84CCA50", Offset = "0x84CB850", VA = "0x1884CCA50", Slot = "234")]
		public void RpcOthersBuffered(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.NJOADKFMIIG<PDCFLIPGAOH> BBGEIKGKENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3FEA740", Offset = "0x3FE9540", VA = "0x183FEA740", Slot = "235")]
		public void RpcOthersBuffered<T1>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.EFCAJNPJLMA<T1, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3FEA5D0", Offset = "0x3FE93D0", VA = "0x183FEA5D0", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.ELNOMOFNMLK<T1, T2, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3FEA0E0", Offset = "0x3FE8EE0", VA = "0x183FEA0E0", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.LDOPGPLDMLG<T1, T2, T3, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3FE9CC0", Offset = "0x3FE8AC0", VA = "0x183FE9CC0", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.LEKCFFJMKHF<T1, T2, T3, T4, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3FE9820", Offset = "0x3FE8620", VA = "0x183FE9820", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.FCGHOLLFOFN<T1, T2, T3, T4, T5, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3FE9580", Offset = "0x3FE8380", VA = "0x183FE9580", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.HBEDNBJHCEL<T1, T2, T3, T4, T5, T6, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3FE8FF0", Offset = "0x3FE7DF0", VA = "0x183FE8FF0", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.MGNAHDGCOKF<T1, T2, T3, T4, T5, T6, T7, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3FE89C0", Offset = "0x3FE77C0", VA = "0x183FE89C0", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(JIJBAEDNDIK CJLHNJBNBIM, NAFLBDGBKOF.GHOEJKMGLLL<T1, T2, T3, T4, T5, T6, T7, T8, PDCFLIPGAOH> BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3FE82F0", Offset = "0x3FE70F0", VA = "0x183FE82F0", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JIJBAEDNDIK CJLHNJBNBIM, AOLMJMLLCJD BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3FE7B80", Offset = "0x3FE6980", VA = "0x183FE7B80", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JIJBAEDNDIK CJLHNJBNBIM, FGKHHEDOJOG BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3FE6F40", Offset = "0x3FE5D40", VA = "0x183FE6F40", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(JIJBAEDNDIK CJLHNJBNBIM, EPOGPDCDKGP BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3FE6640", Offset = "0x3FE5440", VA = "0x183FE6640", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JIJBAEDNDIK CJLHNJBNBIM, LKKAJFLFAIB BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3FE6170", Offset = "0x3FE4F70", VA = "0x183FE6170", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JIJBAEDNDIK CJLHNJBNBIM, CFGMMMBMKLM BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3FE5260", Offset = "0x3FE4060", VA = "0x183FE5260", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JIJBAEDNDIK CJLHNJBNBIM, PAGDOKABHBN BBGEIKGKENC, T1 EKCMFHDCCCA, T2 GAHEJIOAJLG, T3 HHLPIMIKPDL, T4 JCCIKKOOLLO, T5 FKLDONIMJBF, T6 FEFEIDDDKDP, T7 OKCCDHFOIOA, T8 DFLFDNHLOJH, T9 DOGIHGFFEOK, T10 GKPPEKKKOOJ, T11 ENEMECDPHMB, T12 FCAPIPPHHFN, T13 CBDNODJFJDH, T14 DIFAOHDKCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x84C9990", Offset = "0x84C8790", VA = "0x1884C9990", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x84C9BA0", Offset = "0x84C89A0", VA = "0x1884C9BA0", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x20D46B0", Offset = "0x20D34B0", VA = "0x1820D46B0")]
		public RRNetworkView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class HDCDFDOKCAO
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x84BB8E0", Offset = "0x84BA6E0", VA = "0x1884BB8E0")]
	private static bool PPBILPCPCNF(ViewId FMFDAFLDAAK, [Out] RRNetworkView LNFCNKMMELP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3D0B030", Offset = "0x3D09E30", VA = "0x183D0B030")]
	[CanBeNull]
	public static T EAAMDIIOGJL<T>(this ViewId IAAFAPENNJO)
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
		private sealed class PDKNNBCHAEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public AFLCFHLHEHB[] sorted;

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public PDKNNBCHAEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x84C2F40", Offset = "0x84C1D40", VA = "0x1884C2F40")]
			internal int LCDPJKAIOBG(int index)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x84C2FC0", Offset = "0x84C1DC0", VA = "0x1884C2FC0")]
			internal void LEPKLNGGFNC(int index, int number)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly ALMLLDBPKBM IPEKLICENHF;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static AFLCFHLHEHB[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		internal int JGCMGNKFGLB;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x84CDF40", Offset = "0x84CCD40", VA = "0x1884CDF40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x84CE550", Offset = "0x84CD350", VA = "0x1884CE550")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x84CE900", Offset = "0x84CD700", VA = "0x1884CE900")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x84CE970", Offset = "0x84CD770", VA = "0x1884CE970")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x84CE360", Offset = "0x84CD160", VA = "0x1884CE360")]
		private void PODBJMNJHOP(AFLCFHLHEHB DKNBBLLPJCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x84CE360", Offset = "0x84CD160", VA = "0x1884CE360")]
		private void CGEPGDFMABB(AFLCFHLHEHB FLAEMMEHDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x84CE460", Offset = "0x84CD260", VA = "0x1884CE460")]
		private void NPNKFBFANBG(AFLCFHLHEHB NPKICFNLIBN, IDictionary<object, object> BMHEBFHGLHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x84CDDF0", Offset = "0x84CCBF0", VA = "0x1884CDDF0")]
		public static void AssignPlayerNumbers(int GFCIILPOGOG, int DHHLLBFABGD, Func<int, int> OEPMELMDCNG, Action<int, int> PBDJOMFODDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x84CEA10", Offset = "0x84CD810", VA = "0x1884CEA10")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x84CE370", Offset = "0x84CD170", VA = "0x1884CE370")]
		private void CGKCLPIOIGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xAA5870", Offset = "0xAA4670", VA = "0x180AA5870")]
		public RRPlayerNumbering()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class MMIIIBFAJLO
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x84C2270", Offset = "0x84C1070", VA = "0x1884C2270")]
	public static int EAGDHLIMLEJ(this AFLCFHLHEHB GLMBLPAKFLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x84C2410", Offset = "0x84C1210", VA = "0x1884C2410")]
	public static void OODAOIJCNCJ(this AFLCFHLHEHB GLMBLPAKFLM, int DKFAMDEFHJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class OCAFAJAAIEB
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void KNOBCBECNOJ(Hashtable EAHIEHKAAEI);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate void FHNPHCFHDCP(AFLCFHLHEHB GLMBLPAKFLM, Hashtable EAHIEHKAAEI);

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public static event KNOBCBECNOJ JGNFFFOKALD
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x84C2C20", Offset = "0x84C1A20", VA = "0x1884C2C20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x84C2B60", Offset = "0x84C1960", VA = "0x1884C2B60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public static event KNOBCBECNOJ GNLCBCJLNJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x84C2920", Offset = "0x84C1720", VA = "0x1884C2920")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x84C2CE0", Offset = "0x84C1AE0", VA = "0x1884C2CE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public static event FHNPHCFHDCP CKCADNIAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x84C2AA0", Offset = "0x84C18A0", VA = "0x1884C2AA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x84C2DA0", Offset = "0x84C1BA0", VA = "0x1884C2DA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public static event FHNPHCFHDCP KODNOBPMLBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x84C2860", Offset = "0x84C1660", VA = "0x1884C2860")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x84C29E0", Offset = "0x84C17E0", VA = "0x1884C29E0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class JFNFANHOLFA
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int APDNJHGOHOP;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int EHDCOCPKCGM;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int HDEBBKAJDHN;

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x84BE290", Offset = "0x84BD090", VA = "0x1884BE290")]
	public static void GBEGIGFAIGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x84BE1B0", Offset = "0x84BCFB0", VA = "0x1884BE1B0")]
	public static void EIMKIHKKJIO(int[] MMNNEPOAAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x84BE2E0", Offset = "0x84BD0E0", VA = "0x1884BE2E0")]
	public static int MACFKMKPBHL(int OHBBHEMPKFB, bool FPBNADDKFMO = true)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[RegisterService(typeof(JLBLLDMDIGG), new string[] { })]
[ServiceLifetime(Lifetime.Application)]
public class JLBLLDMDIGG : LECKNKNKPIF, CGBKAEJPINJ, JDBGEACJNEG
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static readonly Dictionary<object, object> JEEDCIMCDKD;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Dictionary<object, object> DMPFOAEFGJL;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly Dictionary<object, object> JPEIAPPKBEE;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly ACKMCIEAMDG JALHBENJDIF;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly ACKMCIEAMDG AJLCHLPCAFC;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly ACKMCIEAMDG AONCHAGJKHB;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly ACKMCIEAMDG HAAHHBDFNHA;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static readonly ACKMCIEAMDG AHKNOKOPCOD;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static int JCKCGGGHHKG;

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x84C0780", Offset = "0x84BF580", VA = "0x1884C0780", Slot = "18")]
	public void KMPPGKNEJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x84BEAE0", Offset = "0x84BD8E0", VA = "0x1884BEAE0", Slot = "19")]
	public void EMLPGEIJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x84BFEE0", Offset = "0x84BECE0", VA = "0x1884BFEE0", Slot = "4")]
	public bool IOLJFIKOHJM(FJBBMIPBAAJ ONHEEOKCMKO, bool DCPMAGCIKCO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x84C0360", Offset = "0x84BF160", VA = "0x1884C0360", Slot = "5")]
	public int KKDPCMFBEBP(FJBBMIPBAAJ[] CCCOBHOHKNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x84BEB80", Offset = "0x84BD980", VA = "0x1884BEB80", Slot = "6")]
	public bool EPFAPPBNPEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x84C0B60", Offset = "0x84BF960", VA = "0x1884C0B60", Slot = "7")]
	public bool LOJBPICLCAF(int IAAFAPENNJO, int AIKCBCGMFCA, bool NIDNIGNHKMM, GameObject DFFAMKHOIDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x84BFB30", Offset = "0x84BE930", VA = "0x1884BFB30", Slot = "8")]
	public void HJCOMKBMHPH(int AIKCBCGMFCA, [Optional] int? CIOBDCBACEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x84BEF70", Offset = "0x84BDD70", VA = "0x1884BEF70", Slot = "9")]
	public bool GBDNHNDDCGF(HPHHANMLLNF PEKEABNFGOF, [Out] FJBBMIPBAAJ IBNCJKAIFNB, bool AHLIEEGNPGA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x84C0820", Offset = "0x84BF620", VA = "0x1884C0820", Slot = "10")]
	public bool LDDAAAJMGEF(HPHHANMLLNF PEKEABNFGOF, [Out] int JBONNNNENLL, [Out] FJBBMIPBAAJ[] CCCOBHOHKNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x84BED00", Offset = "0x84BDB00", VA = "0x1884BED00", Slot = "11")]
	public bool FHOJHMOLEHD(HPHHANMLLNF PEKEABNFGOF, [Out] int AIKCBCGMFCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x84C0100", Offset = "0x84BEF00", VA = "0x1884C0100", Slot = "12")]
	public void KANEIMGKDDP(HPHHANMLLNF PEKEABNFGOF, [Out] int LCLGLNFGEMD, [Out] int[] LNHEMGNBEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x84C0D20", Offset = "0x84BFB20", VA = "0x1884C0D20", Slot = "13")]
	public void MNMNGACACLJ(int JBONNNNENLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x84BFD60", Offset = "0x84BEB60", VA = "0x1884BFD60", Slot = "14")]
	public void IDLJDNEEGEO(int JBONNNNENLL, int[] LNHEMGNBEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x84BEC10", Offset = "0x84BDA10", VA = "0x1884BEC10", Slot = "15")]
	public void FDHKFIMIDFM(int[] LNHEMGNBEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x84BEE50", Offset = "0x84BDC50", VA = "0x1884BEE50", Slot = "16")]
	public void FIPADKLICBM(int[] LNHEMGNBEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x84BF960", Offset = "0x84BE760", VA = "0x1884BF960", Slot = "17")]
	public void HHKHBIMGHPC(int JBONNNNENLL, int AIKCBCGMFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x84BE580", Offset = "0x84BD380", VA = "0x1884BE580")]
	private static void EGJLGKJGBEA(FJBBMIPBAAJ ONHEEOKCMKO, Dictionary<object, object> MGJHBBPMNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x84BF0E0", Offset = "0x84BDEE0", VA = "0x1884BF0E0")]
	private static bool GBDNHNDDCGF(Dictionary<object, object> MGJHBBPMNPM, AFLCFHLHEHB IJIAOFHPIOC, [Out] FJBBMIPBAAJ IBNCJKAIFNB, bool AHLIEEGNPGA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x84C0010", Offset = "0x84BEE10", VA = "0x1884C0010")]
	private static bool JFHKMJAEIHI(int AIKCBCGMFCA, FJBBMIPBAAJ MGJHBBPMNPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x84C0F00", Offset = "0x84BFD00", VA = "0x1884C0F00")]
	private static int OCJJEJPMMBL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public JLBLLDMDIGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.Application)]
[RegisterService(typeof(MHBOJJGGOKA), new string[] { })]
public class MHBOJJGGOKA : LIFJFAPADPH, CGBKAEJPINJ, JDBGEACJNEG
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static Hashtable ELHDGFKHBMM;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static Hashtable OGGCLPDAJHD;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static ACKMCIEAMDG HECPKAIEFFJ;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static readonly ACKMCIEAMDG AFGGFAIBPHJ;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x84C1B50", Offset = "0x84C0950", VA = "0x1884C1B50", Slot = "8")]
	public void EMLPGEIJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x84C1BF0", Offset = "0x84C09F0", VA = "0x1884C1BF0", Slot = "7")]
	public void KMPPGKNEJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x84C1C90", Offset = "0x84C0A90", VA = "0x1884C1C90", Slot = "4")]
	public void OAPDKEJBGHB(ViewId IAAFAPENNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x84C1D80", Offset = "0x84C0B80", VA = "0x1884C1D80", Slot = "5")]
	public bool PJPGAFFAOII(HPHHANMLLNF PEKEABNFGOF, [Out] ViewId IAAFAPENNJO, [Out] string HLFOJCNGCCB, [Out] int KPEONFBADJH, [Out] object[] BNOPOAPPFBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x84C1520", Offset = "0x84C0320", VA = "0x1884C1520", Slot = "6")]
	public void AHNCGJOBPPM(ViewId LNFCNKMMELP, string HLFOJCNGCCB, DPFDMEKAHAN MAPCIGBDCJI, AFLCFHLHEHB GLMBLPAKFLM, GLEJGGGOBBK MHHBNPCINHM, object[] ONHEEOKCMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public MHBOJJGGOKA()
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
