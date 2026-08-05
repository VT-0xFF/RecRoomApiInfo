using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Logging.Attributes;
using RecRoom.MCluster;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_MCluster_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : ONLGCKOFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B96240", Offset = "0x7B94A40", VA = "0x187B96240", Slot = "4")]
		public override void JNEAPGDNFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct KNCJBLCNOJC
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] KCHDBAFNKFB;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] CAIEGLIBLIP;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] FHFKBIMNHIM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E1CD20", Offset = "0x1E1B520", VA = "0x181E1CD20")]
	public static int BPCIFGHAKFJ(KOGDDMONJHO JGBCIPMOKIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7B95B90", Offset = "0x7B94390", VA = "0x187B95B90")]
	public static int OONFOMPFMFH(KOGDDMONJHO JGBCIPMOKIK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JPAAENCCKEB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int LLABJPCMKNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AABPLJEMGFP GAFOJDCPHKL(int BIPGHKPGBAC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 AAPOGCKAEOL(int BIPGHKPGBAC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AIFAFFNBDPH CJMHOGGLPLM();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EHNFNFAJIED KEAAMMIGINA();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PIPELENMMAH : ENPHCCANGLJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private AIFAFFNBDPH POFBAOBKAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform EPMIBJKMFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<BPFFPBMKHCE> HGMNOLEKLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private DKNFNBIEBLL BKNFJNDLIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private GNEOEFINEON FAJEEAHEBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool NKEJDFAENEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private JPAAENCCKEB FHNCLDBMOCF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float IFEDPIJACGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBD7A50", Offset = "0xBD6250", VA = "0x180BD7A50")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xBD7A60", Offset = "0xBD6260", VA = "0x180BD7A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EBPKKAAMJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xBFD9F0", Offset = "0xBFC1F0", VA = "0x180BFD9F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xCC7800", Offset = "0xCC6000", VA = "0x180CC7800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool PEHHLACIIPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xD52010", Offset = "0xD50810", VA = "0x180D52010")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xD50A40", Offset = "0xD4F240", VA = "0x180D50A40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool DJIPACMCJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1E23E20", Offset = "0x1E22620", VA = "0x181E23E20", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1E23300", Offset = "0x1E21B00", VA = "0x181E23300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KNDFNNNGHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1F101E0", Offset = "0x1F0E9E0", VA = "0x181F101E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7B98F30", Offset = "0x7B97730", VA = "0x187B98F30")]
	public PIPELENMMAH(JPAAENCCKEB DMLFPKLKPFK, bool FKPOLOPPCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7B97F00", Offset = "0x7B96700", VA = "0x187B97F00")]
	private bool JPEJJOMEFOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7B982F0", Offset = "0x7B96AF0", VA = "0x187B982F0", Slot = "4")]
	public bool OIHLAKEIFNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7B98120", Offset = "0x7B96920", VA = "0x187B98120", Slot = "5")]
	public bool MAEEPMKIKNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7B97CD0", Offset = "0x7B964D0", VA = "0x187B97CD0", Slot = "6")]
	public void AHELLINFOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7B97EF0", Offset = "0x7B966F0", VA = "0x187B97EF0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PMMAEJMDMAG
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AABNGIOAGLH(CommandBuffer NOACLCGHLMN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct KDAALEOPCNE : PMMAEJMDMAG
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int NGHJMEDCGPM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier PPIFCFIECMO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4FB7560", Offset = "0x4FB5D60", VA = "0x184FB7560")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B95B70", Offset = "0x7B94370", VA = "0x187B95B70")]
	public KDAALEOPCNE(int MLBCMOLHELH, RenderTargetIdentifier NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B95B20", Offset = "0x7B94320", VA = "0x187B95B20", Slot = "4")]
	public void AABNGIOAGLH(CommandBuffer NOACLCGHLMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct MHLLHFOEDBL : PMMAEJMDMAG
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int NGHJMEDCGPM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] DPCFACOLIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xD68560", Offset = "0xD66D60", VA = "0x180D68560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1618B10", Offset = "0x1617310", VA = "0x181618B10")]
	public MHLLHFOEDBL(int MLBCMOLHELH, Vector4[] NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7B96F50", Offset = "0x7B95750", VA = "0x187B96F50", Slot = "4")]
	public void AABNGIOAGLH(CommandBuffer NOACLCGHLMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct DCMPPNHBIFI : PMMAEJMDMAG
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int NGHJMEDCGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] FCAMAILMIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xD68560", Offset = "0xD66D60", VA = "0x180D68560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1618B10", Offset = "0x1617310", VA = "0x181618B10")]
	public DCMPPNHBIFI(int MLBCMOLHELH, float[] NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7B8C990", Offset = "0x7B8B190", VA = "0x187B8C990", Slot = "4")]
	public void AABNGIOAGLH(CommandBuffer NOACLCGHLMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct ENLDLMFLNCE : PMMAEJMDMAG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool ACOHCKOENBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE70", Offset = "0xCEC670", VA = "0x180CEDE70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1774470", Offset = "0x1772C70", VA = "0x181774470")]
	public ENLDLMFLNCE(string GLGOHIJMLFB, bool BCOFJMBGKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7B8DE30", Offset = "0x7B8C630", VA = "0x187B8DE30", Slot = "4")]
	public void AABNGIOAGLH(CommandBuffer NOACLCGHLMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct EHNFNFAJIED
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 KLMGAAOGPNK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 DJCDHMBPGDC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xF63890", Offset = "0xF62090", VA = "0x180F63890")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int GLMOPJHGKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int FJKKGDPMFDO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xCE6F70", Offset = "0xCE5770", VA = "0x180CE6F70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float BJPFMJIFKML
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xF14BE0", Offset = "0xF133E0", VA = "0x180F14BE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7B8DBD0", Offset = "0x7B8C3D0", VA = "0x187B8DBD0")]
	public EHNFNFAJIED(Color AGNHOOELDII, int MENIDKIJFPO, int HHKKDJCOGMF, float ONPIOFPINIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1122170", Offset = "0x1120970", VA = "0x181122170")]
	private static float4 MPBBDOPAFPB(Color AGNHOOELDII)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7B8DB40", Offset = "0x7B8C340", VA = "0x187B8DB40")]
	private static Hash128 FAMODOPMIKD(EHNFNFAJIED DMLFPKLKPFK)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DKNFNBIEBLL : ENPHCCANGLJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string PAJCFCNFDNN;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string OFJJFHLAJIJ;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string KBOAOKDBNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private EHNFNFAJIED PJPNFOBNABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private IOCFMNEEHEH OALKCGACMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 FGLONDPCKNA;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public GNEOEFINEON DHGCEDJLMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA06680", Offset = "0xA04E80", VA = "0x180A06680")]
		[CompilerGenerated]
		get
		{
			return default(GNEOEFINEON);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x12C7F40", Offset = "0x12C6740", VA = "0x1812C7F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool EBPKKAAMJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x110B5B0", Offset = "0x1109DB0", VA = "0x18110B5B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6970EC0", Offset = "0x696F6C0", VA = "0x186970EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool PEHHLACIIPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x26AB7A0", Offset = "0x26A9FA0", VA = "0x1826AB7A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8EE0", Offset = "0x7AF76E0", VA = "0x187AF8EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool KNDFNNNGHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DJIPACMCJML
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E400", Offset = "0x6A8CC00", VA = "0x186A8E400", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CB70", Offset = "0x7B8B370", VA = "0x187B8CB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int NHCKMLOFHLI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CFC0", Offset = "0x7B8B7C0", VA = "0x187B8CFC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7B8D0F0", Offset = "0x7B8B8F0", VA = "0x187B8D0F0")]
	public DKNFNBIEBLL(EHNFNFAJIED PPGPACPMKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7B8CBC0", Offset = "0x7B8B3C0", VA = "0x187B8CBC0")]
	private bool JPEJJOMEFOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7B8CE70", Offset = "0x7B8B670", VA = "0x187B8CE70", Slot = "4")]
	public bool OIHLAKEIFNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7B8CB80", Offset = "0x7B8B380", VA = "0x187B8CB80")]
	private static IOCFMNEEHEH JGJJJDKEAJP(EHNFNFAJIED DMLFPKLKPFK)
	{
		return default(IOCFMNEEHEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7B8CCC0", Offset = "0x7B8B4C0", VA = "0x187B8CCC0", Slot = "5")]
	public bool MAEEPMKIKNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7B8CA70", Offset = "0x7B8B270", VA = "0x187B8CA70", Slot = "6")]
	public void AHELLINFOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "9")]
	public void Dispose()
	{
	}
}
namespace RecRoom.MCluster
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MClusterData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			[Reload("Shaders/ClusterUpdate.compute", ReloadAttribute.Package.Root)]
			public ComputeShader UpdateShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			[Reload("Shaders/ClusterRaster.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ClusterRasterShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			[Reload("Shaders/ClusterCoarseCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader CoarseCullShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			[Reload("Shaders/ClusterFineCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader FineCullShader;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7B96490", Offset = "0x7B94C90", VA = "0x187B96490", Slot = "0")]
		public override bool Equals(object PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B96690", Offset = "0x7B94E90", VA = "0x187B96690", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB90A50", Offset = "0xB8F250", VA = "0x180B90A50")]
		public MClusterData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleRendererFeature(null)]
	public class MClusterRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly LLPKKNNAIAE log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private IKALDOFLFBE opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static JGMHACMIELE CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7B96E90", Offset = "0x7B95690", VA = "0x187B96E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7B96EE0", Offset = "0x7B956E0", VA = "0x187B96EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7B96770", Offset = "0x7B94F70", VA = "0x187B96770", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7B96740", Offset = "0x7B94F40", VA = "0x187B96740", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JGPHFKDOCBN, RenderingData HNEGCPHIBHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7B96C40", Offset = "0x7B95440", VA = "0x187B96C40")]
		public void MLJIHDLBHEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1623F00", Offset = "0x1622700", VA = "0x181623F00")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class CALJHGPCNBK<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private ALPFPGFLLFK AMNNGFBLHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ALPFPGFLLFK IFGLOGPEOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private ComputeBuffer EPDALFMNFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private RenderTexture KEGIBBEKOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int KEKKKAFHGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int LBACFDOIAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string FKJPBCIDNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private string AIBKNCFBOBL;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9E4120", Offset = "0x9E2920", VA = "0x1809E4120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int HDCCJBLJENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA1F270", Offset = "0xA1DA70", VA = "0x180A1F270")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int KKICLAIGLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9FCF80", Offset = "0x9FB780", VA = "0x1809FCF80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6303750", Offset = "0x6301F50", VA = "0x186303750")]
	public CALJHGPCNBK(string GLGOHIJMLFB, int LFAICPJEILI, [Optional] RenderTextureFormat? CGJBGKAIMNA, bool AAFKFGGPJLE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6302E20", Offset = "0x6301620", VA = "0x186302E20")]
	public void MAEEPMKIKNH(CommandBuffer NOACLCGHLMN, NativeArray<ValType> NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x63019E0", Offset = "0x63001E0", VA = "0x1863019E0")]
	public void GDPGNPDDAFO(CommandBuffer NOACLCGHLMN, ComputeShader BAAEOBBAOLG, int IHILIAKMBMM, int LCJOKEEDIEC = -1, int GFEMGJDMADD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6302000", Offset = "0x6300800", VA = "0x186302000")]
	public void GDPGNPDDAFO(Material OALKCGACMLD, int LCJOKEEDIEC = -1, int GFEMGJDMADD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6300EA0", Offset = "0x62FF6A0", VA = "0x186300EA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ECOCFONILKM
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDPGNPDDAFO(Material PPGPACPMKJK);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CNBPDEAIEFH<SrcEntry, DstEntry> : ECOCFONILKM, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected bool[] NAECEBAJLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected ALPFPGFLLFK DNJAOJHFBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected ALPFPGFLLFK DHHCMLFBJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<int> NMDMBDIPJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected NativeArray<SrcEntry> BEOMGIAPLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int ONDBOFLJJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected int BJIDDNLNGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected CALJHGPCNBK<int> CILKBEELCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected CALJHGPCNBK<SrcEntry> CFGLANKNFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected CALJHGPCNBK<DstEntry> DAMHAIOOBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected ComputeShader ICECPNBAGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int DNMGFNAIMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int GKOHDNJMMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int NOENOADMBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int HFJPNHECKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int KEGEKGNAILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int EHDKKIKPEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int BPAPGCIIMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int FMBCPBLGDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int PEIFDAIEOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int CPNCNOPILDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int DNGBBHAABFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected int BLJGOBNNPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected string EDNCOOLIIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected float[] NAPIDGMMJAL;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int EHFFNOLNOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x64D6DB0", Offset = "0x64D55B0", VA = "0x1864D6DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string AKHPACECPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x64D8B40", Offset = "0x64D7340", VA = "0x1864D8B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x64DCB00", Offset = "0x64DB300", VA = "0x1864DCB00")]
	public CNBPDEAIEFH(string GLGOHIJMLFB, int GMCEBJMCMHB, int FDNENPJLAIF, RenderTextureFormat CGJBGKAIMNA, ComputeShader NMBCGPIDIJE, int IGFIFPMOINN = 0, int DALMDCCHEBI = 0, int FCEBDNLAANP = 0, int OIIEMMPDBGK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x64D88C0", Offset = "0x64D70C0", VA = "0x1864D88C0")]
	public int GCFGKFIBMNC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x64DB250", Offset = "0x64D9A50", VA = "0x1864DB250")]
	protected void OJPNEOKFECI(int FPEOONOJHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x64DABC0", Offset = "0x64D93C0", VA = "0x1864DABC0")]
	public GNEOEFINEON OIHLAKEIFNH(SrcEntry NFNBKNAJBPN)
	{
		return default(GNEOEFINEON);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x64DA240", Offset = "0x64D8A40", VA = "0x1864DA240")]
	public bool MAEEPMKIKNH(GNEOEFINEON EKNJAMPDKID, SrcEntry NFNBKNAJBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x64D6AB0", Offset = "0x64D52B0", VA = "0x1864D6AB0")]
	public bool AHELLINFOCL(GNEOEFINEON EKNJAMPDKID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "6")]
	protected virtual void FECNIFBIKIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x64D73C0", Offset = "0x64D5BC0", VA = "0x1864D73C0", Slot = "7")]
	public void EBNLGHHADJG(CommandBuffer NOACLCGHLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x64D7790", Offset = "0x64D5F90", VA = "0x1864D7790", Slot = "8")]
	public void EBNLGHHADJG(CommandBuffer NOACLCGHLMN, ComputeShader NMBCGPIDIJE, int IGFIFPMOINN = -1, int DALMDCCHEBI = -1, int FCEBDNLAANP = -1, int OIIEMMPDBGK = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x64D89A0", Offset = "0x64D71A0", VA = "0x1864D89A0", Slot = "9")]
	public void GDPGNPDDAFO(CommandBuffer NOACLCGHLMN, ComputeShader NMBCGPIDIJE, int IGFIFPMOINN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x64D8930", Offset = "0x64D7130", VA = "0x1864D8930", Slot = "4")]
	public void GDPGNPDDAFO(Material OALKCGACMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x64D6DC0", Offset = "0x64D55C0", VA = "0x1864D6DC0", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ALPFPGFLLFK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong HJFLMIKIEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong OALHFJNGHLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class MIJGGHBLPKA
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct PDJFIMPEPGO : ALPFPGFLLFK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private IDisposable KAMABMPPAPM;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong HJFLMIKIEAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD68560", Offset = "0xD66D60", VA = "0x180D68560", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7224010", Offset = "0x7222810", VA = "0x187224010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong OALHFJNGHLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7B97BE0", Offset = "0x7B963E0", VA = "0x187B97BE0")]
		internal PDJFIMPEPGO(IDisposable LLDHPDJJOMI, ulong MAPMFJDGMBB, ulong NLNCNDOFLDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7B97B60", Offset = "0x7B96360", VA = "0x187B97B60", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct EHAIGAIPPOF : ALPFPGFLLFK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private RenderTexture PNHGGLOJLAG;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong HJFLMIKIEAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xD68560", Offset = "0xD66D60", VA = "0x180D68560", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7224010", Offset = "0x7222810", VA = "0x187224010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong OALHFJNGHLF
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7B8DB10", Offset = "0x7B8C310", VA = "0x187B8DB10")]
		public EHAIGAIPPOF(RenderTexture OAGLIKEGCPE, ulong JGOCMONBGJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7B8DA70", Offset = "0x7B8C270", VA = "0x187B8DA70", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong FDNECEGDCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7B97140", Offset = "0x7B95940", VA = "0x187B97140")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7B977F0", Offset = "0x7B95FF0", VA = "0x187B977F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong OCBDMHIEMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7B96FC0", Offset = "0x7B957C0", VA = "0x187B96FC0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7B96F80", Offset = "0x7B95780", VA = "0x187B96F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7B97620", Offset = "0x7B95E20", VA = "0x187B97620")]
	public static ComputeBuffer NKIHIDGHACP(int PCFOAHIEPDL, int IFKNDEFBDJC, ComputeBufferType PIJHKCJDAHO, [Out] ALPFPGFLLFK EKNJAMPDKID, ComputeBufferMode MGNGIPCHJJA = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7B97290", Offset = "0x7B95A90", VA = "0x187B97290")]
	public static RenderTexture NKIHIDGHACP(int OKDHCGBPBDJ, int AJBHLEPGOLA, int CAHCGLMGIAO, RenderTextureFormat CGJBGKAIMNA, [Out] ALPFPGFLLFK EKNJAMPDKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x38C1CD0", Offset = "0x38C04D0", VA = "0x1838C1CD0")]
	public static NativeArray<T> BEGABHHOAJM<T>(NativeArray<T> KAMABMPPAPM, ulong IMNFCKGEMOH, [Out] ALPFPGFLLFK EKNJAMPDKID) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x38C2BD0", Offset = "0x38C13D0", VA = "0x1838C2BD0")]
	public static NativeArray<T> NKIHIDGHACP<T>(int IMNFCKGEMOH, Allocator KKCJNCNIICO, [Out] ALPFPGFLLFK EKNJAMPDKID, NativeArrayOptions AKIEDMONOFM = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7B97000", Offset = "0x7B95800", VA = "0x187B97000")]
	public static void KNAKPKDGKOD(ALPFPGFLLFK KAMABMPPAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7B97180", Offset = "0x7B95980", VA = "0x187B97180")]
	public static uint NDKGGCPFKJC(RenderTextureFormat CGJBGKAIMNA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class EAGBPJFJNLM : CNBPDEAIEFH<FAEGJKJFOCE, FAEGJKJFOCE>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct CJPCFPGACPK : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<int> IEOJPNHFEEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[ReadOnly]
		private NativeArray<float> GBCFNKGJBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4x4> AOECMPGKIBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[WriteOnly]
		private NativeArray<float4> LJOBDFONLOA;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A600", Offset = "0x7B88E00", VA = "0x187B8A600")]
		public CJPCFPGACPK(NativeArray<int> ANPHDBBAOMK, NativeArray<float> PPMNKBFCPHI, NativeArray<float4x4> MKJCJLJJGFM, NativeArray<float4> BCIIBBAGHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7B8C7D0", Offset = "0x7B8AFD0", VA = "0x187B8C7D0", Slot = "4")]
		public void Execute(int FPEOONOJHML, TransformAccess POFBAOBKAGL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[BurstCompile]
	public struct BDOIMBOEMIA : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<int> IEOJPNHFEEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4x4> BKIBMJIHEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[ReadOnly]
		private NativeArray<float4> CFJHIPEENMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[WriteOnly]
		private NativeArray<FAEGJKJFOCE> KEODKBJBDFH;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A600", Offset = "0x7B88E00", VA = "0x187B8A600")]
		public BDOIMBOEMIA(NativeArray<int> ANPHDBBAOMK, NativeArray<float4x4> PNANOBOMEDK, NativeArray<float4> EFPHDJPDAJL, NativeArray<FAEGJKJFOCE> EFGFBKMBCFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7B8A590", Offset = "0x7B88D90", VA = "0x187B8A590", Slot = "4")]
		public void Execute(int FPEOONOJHML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private const byte FFDFEBOHPDL = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private TransformAccessArray LDIJNIGCOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> GKNAAHNFBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4x4> MOPHDEAONKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float4> JNJLLCDEGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> KCNALIPFAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> JPBIGCEALAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private ALPFPGFLLFK FGHACMEBFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private ALPFPGFLLFK DHPMIPMIMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private ALPFPGFLLFK OOMPFMNJBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private ALPFPGFLLFK HNGNOIMGJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private ALPFPGFLLFK CIBNIACKOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private Transform FBIKLBJHBBN;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7B8D790", Offset = "0x7B8BF90", VA = "0x187B8D790")]
	public EAGBPJFJNLM(int GMCEBJMCMHB, int FDNENPJLAIF, ComputeShader NMBCGPIDIJE, int IGFIFPMOINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7B8D1D0", Offset = "0x7B8B9D0", VA = "0x187B8D1D0", Slot = "6")]
	protected override void FECNIFBIKIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7B8D6D0", Offset = "0x7B8BED0", VA = "0x187B8D6D0")]
	private void OCCKJLPDLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7B8D570", Offset = "0x7B8BD70", VA = "0x187B8D570")]
	public bool NDCKCHGCDEK(GNEOEFINEON EKNJAMPDKID, Transform POFBAOBKAGL, float OOLHIAJCELA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7B8D490", Offset = "0x7B8BC90", VA = "0x187B8D490")]
	public void MNAFAOACBIE(GNEOEFINEON EKNJAMPDKID, float OOLHIAJCELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7B8D3E0", Offset = "0x7B8BBE0", VA = "0x187B8D3E0")]
	public void HGMAFABEMPI(GNEOEFINEON EKNJAMPDKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7B8D130", Offset = "0x7B8B930", VA = "0x187B8D130", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface AABPLJEMGFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PKKNLFDDHKF OOJHFJBDPKE();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface LLBPKPBLDNB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 KLMGAAOGPNK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int EEBNJGNDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int ADDMENBCPDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> COFBFGOOFOF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> FEAICKLKFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> FKNPFNCGIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> ECHNJBEGEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> OJPPJHDDNKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> KKACFCNCLCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int JELHHAJGLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int GBFPJKEFJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int IFILEIHAEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool EKGKAMAPBEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EBNLGHHADJG();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FMJBAFAIDFM : LLBPKPBLDNB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private AABPLJEMGFP EPMEICEPPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private PKKNLFDDHKF ABAPBBKNPBC;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 KLMGAAOGPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xF63890", Offset = "0xF62090", VA = "0x180F63890", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xF63950", Offset = "0xF62150", VA = "0x180F63950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool KKLCGOMDJEO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9E0E10", Offset = "0x9DF610", VA = "0x1809E0E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int EEBNJGNDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xCE6F70", Offset = "0xCE5770", VA = "0x180CE6F70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xEF7300", Offset = "0xEF5B00", VA = "0x180EF7300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int ADDMENBCPDG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF90", Offset = "0x9EA790", VA = "0x1809EBF90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF70", Offset = "0x9EA770", VA = "0x1809EBF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int IIKHHAHHALN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1388660", Offset = "0x1386E60", VA = "0x181388660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> COFBFGOOFOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B8E370", Offset = "0x7B8CB70", VA = "0x187B8E370", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> FEAICKLKFBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7B8E410", Offset = "0x7B8CC10", VA = "0x187B8E410", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> FKNPFNCGIBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7B8E0B0", Offset = "0x7B8C8B0", VA = "0x187B8E0B0", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> ECHNJBEGEIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B8E300", Offset = "0x7B8CB00", VA = "0x187B8E300", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> OJPPJHDDNKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B8E2D0", Offset = "0x7B8CAD0", VA = "0x187B8E2D0", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> KKACFCNCLCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B8E0E0", Offset = "0x7B8C8E0", VA = "0x187B8E0E0", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool EKGKAMAPBEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA0BF30", Offset = "0xA0A730", VA = "0x180A0BF30", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA0BCB0", Offset = "0xA0A4B0", VA = "0x180A0BCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int JELHHAJGLLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7B8E400", Offset = "0x7B8CC00", VA = "0x187B8E400", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int GBFPJKEFJGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B8E3E0", Offset = "0x7B8CBE0", VA = "0x187B8E3E0", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int IFILEIHAEPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B8E110", Offset = "0x7B8C910", VA = "0x187B8E110", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E440", Offset = "0x7B8CC40", VA = "0x187B8E440")]
	public FMJBAFAIDFM(Hash128 EGAIPBFBDLP, AABPLJEMGFP EPMEICEPPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E1C0", Offset = "0x7B8C9C0", VA = "0x187B8E1C0", Slot = "16")]
	public void EBNLGHHADJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E130", Offset = "0x7B8C930", VA = "0x187B8E130", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct GNEOEFINEON : IEquatable<GNEOEFINEON>
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly GNEOEFINEON HCANDHABHHO;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int NHCKMLOFHLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x127A100", Offset = "0x1278900", VA = "0x18127A100")]
	public GNEOEFINEON(int FPEOONOJHML = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E490", Offset = "0x7B8CC90", VA = "0x187B8E490", Slot = "4")]
	public bool Equals(GNEOEFINEON PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E4E0", Offset = "0x7B8CCE0", VA = "0x187B8E4E0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E5B0", Offset = "0x7B8CDB0", VA = "0x187B8E5B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BPFFPBMKHCE : ENPHCCANGLJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private bool NKEJDFAENEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private LLBPKPBLDNB LKAAFEMOHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<GNEOEFINEON> EJEJKCBMKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<GNEOEFINEON> AONNHOHBOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private List<GNEOEFINEON> JMAILHIFOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Dictionary<int, uint> INLAAEDIJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int PKBFIOIHAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int EKBBKNBDGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int ADPKJCOAGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int FIEIAKIBIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private int BIOJFPIDPCG;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int NHCKMLOFHLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7B8C2F0", Offset = "0x7B8AAF0", VA = "0x187B8C2F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B550", Offset = "0x7B89D50", VA = "0x187B8B550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool EBPKKAAMJOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xC47930", Offset = "0xC46130", VA = "0x180C47930")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xC466E0", Offset = "0xC44EE0", VA = "0x180C466E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool PEHHLACIIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xC46E20", Offset = "0xC45620", VA = "0x180C46E20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC466C0", Offset = "0xC44EC0", VA = "0x180C466C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool KNDFNNNGHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool DJIPACMCJML
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x26FADB0", Offset = "0x26F95B0", VA = "0x1826FADB0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x25C56E0", Offset = "0x25C3EE0", VA = "0x1825C56E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float IFEDPIJACGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xE99CD0", Offset = "0xE984D0", VA = "0x180E99CD0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xE99E00", Offset = "0xE98600", VA = "0x180E99E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7B8C660", Offset = "0x7B8AE60", VA = "0x187B8C660")]
	public BPFFPBMKHCE(LLBPKPBLDNB ABAPBBKNPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7B8B080", Offset = "0x7B89880", VA = "0x187B8B080")]
	private void AONMIEBGDKE(LLBPKPBLDNB ABAPBBKNPBC, int PKBFIOIHAOL, int JFFKDIELMDL, int FPEOONOJHML, int FPBGLNPLCIJ, JGIECEPLAMJ NFNBKNAJBPN, float LDCMCKPCAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7B8C3A0", Offset = "0x7B8ABA0", VA = "0x187B8C3A0")]
	private void PDCCBODJCDO(LLBPKPBLDNB ABAPBBKNPBC, int APHHKLBMHPF, int FPEOONOJHML, uint3 BAHDBJICCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7B8B5F0", Offset = "0x7B89DF0", VA = "0x187B8B5F0")]
	private bool JPEJJOMEFOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7B8B910", Offset = "0x7B8A110", VA = "0x187B8B910", Slot = "4")]
	public bool OIHLAKEIFNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7B8B890", Offset = "0x7B8A090", VA = "0x187B8B890", Slot = "5")]
	public bool MAEEPMKIKNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7B8AA30", Offset = "0x7B89230", VA = "0x187B8AA30", Slot = "6")]
	public void AHELLINFOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7B8B590", Offset = "0x7B89D90", VA = "0x187B8B590")]
	public void IAEOFLELKBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7B8B590", Offset = "0x7B89D90", VA = "0x187B8B590", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface ENPHCCANGLJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool KNDFNNNGHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool DJIPACMCJML
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OIHLAKEIFNH();

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MAEEPMKIKNH();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AHELLINFOCL();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PJCOJMKNOHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly float DGCIFFMKICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, BPFFPBMKHCE> MIMFDIPIGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Dictionary<Hash128, DKNFNBIEBLL> EPMAIIDHNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<ENPHCCANGLJ> OECONPCHHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<ENPHCCANGLJ> LIMAJBEIHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Queue<ENPHCCANGLJ> PDHJGBJNFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int IJKHCKFGLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private int MNCOFMHFBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private float HANEGCBNPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public bool KPKEBICDNLK;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool LIHGACHKCJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1647D70", Offset = "0x1646570", VA = "0x181647D70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1655DA0", Offset = "0x16545A0", VA = "0x181655DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool CPCOKNCJFOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7B9A010", Offset = "0x7B98810", VA = "0x187B9A010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string AKHPACECPBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7B99670", Offset = "0x7B97E70", VA = "0x187B99670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7B995E0", Offset = "0x7B97DE0", VA = "0x187B995E0")]
	public void HLMDJDEDFPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7B98FF0", Offset = "0x7B977F0", VA = "0x187B98FF0")]
	public void BMHGODJCKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A110", Offset = "0x7B98910", VA = "0x187B9A110")]
	public PJCOJMKNOHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7B99AC0", Offset = "0x7B982C0", VA = "0x187B99AC0")]
	public PIPELENMMAH JNEAPGDNFGC(JPAAENCCKEB CHKHGNKGCIE, bool FKPOLOPPCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7B99ED0", Offset = "0x7B986D0", VA = "0x187B99ED0")]
	public DKNFNBIEBLL JNEAPGDNFGC(EHNFNFAJIED OALKCGACMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7B9A060", Offset = "0x7B98860", VA = "0x187B9A060")]
	public bool NOHCBFFOAMK(Hash128 MLBCMOLHELH, [Out] BPFFPBMKHCE PPDCOFENPJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7B99BF0", Offset = "0x7B983F0", VA = "0x187B99BF0")]
	public BPFFPBMKHCE JNEAPGDNFGC(LLBPKPBLDNB ABAPBBKNPBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7B99000", Offset = "0x7B97800", VA = "0x187B99000")]
	private void CBMOPFCKEJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7B995F0", Offset = "0x7B97DF0", VA = "0x187B995F0")]
	private bool IFCLPMJFIDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7B99130", Offset = "0x7B97930", VA = "0x187B99130")]
	public void EBNLGHHADJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7B99020", Offset = "0x7B97820", VA = "0x187B99020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7B99A10", Offset = "0x7B98210", VA = "0x187B99A10")]
	public void IMAIJACFOFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IPHDHBCMOFL : CNBPDEAIEFH<NNCLEAAKOPI, NNCLEAAKOPI>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7B8EAB0", Offset = "0x7B8D2B0", VA = "0x187B8EAB0")]
	public IPHDHBCMOFL(int GMCEBJMCMHB, int FDNENPJLAIF, ComputeShader NMBCGPIDIJE, int IGFIFPMOINN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class AJOKCCKFOAK : CNBPDEAIEFH<IOCFMNEEHEH, IOCFMNEEHEH>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7B8A4E0", Offset = "0x7B88CE0", VA = "0x187B8A4E0")]
	public AJOKCCKFOAK(int GMCEBJMCMHB, int FDNENPJLAIF, ComputeShader NMBCGPIDIJE, int IGFIFPMOINN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class EMGOMJILPHO : CNBPDEAIEFH<JEOKDHJNBEG, JEOKDHJNBEG>
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7B8DD80", Offset = "0x7B8C580", VA = "0x187B8DD80")]
	public EMGOMJILPHO(int GMCEBJMCMHB, int FDNENPJLAIF, ComputeShader NMBCGPIDIJE, int IGFIFPMOINN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class PGECKDDPACI : CNBPDEAIEFH<EKOLAKAEDGL, EKIDHMEIGMH>
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7B97C20", Offset = "0x7B96420", VA = "0x187B97C20")]
	public PGECKDDPACI(int GMCEBJMCMHB, int FDNENPJLAIF, ComputeShader NMBCGPIDIJE, int IGFIFPMOINN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class DFNADAFNJKC : CNBPDEAIEFH<BMDINKPDPBE, BMDINKPDPBE>
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7B8C9C0", Offset = "0x7B8B1C0", VA = "0x187B8C9C0")]
	public DFNADAFNJKC(int GMCEBJMCMHB, int FDNENPJLAIF, ComputeShader NMBCGPIDIJE, int IGFIFPMOINN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class IKALDOFLFBE : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private JGMHACMIELE ELMEHJNBAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool BCOFJMBGKOE;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static bool BABGFAMEDCA;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7B8EA40", Offset = "0x7B8D240", VA = "0x187B8EA40")]
	public IKALDOFLFBE(JGMHACMIELE LGJOEICNGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E8B0", Offset = "0x7B8D0B0", VA = "0x187B8E8B0", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer NOACLCGHLMN, RenderingData HNEGCPHIBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E640", Offset = "0x7B8CE40", VA = "0x187B8E640", Slot = "6")]
	public override void Configure(CommandBuffer NOACLCGHLMN, RenderTextureDescriptor OJNEODAENCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E680", Offset = "0x7B8CE80", VA = "0x187B8E680", Slot = "9")]
	public override void Execute(ScriptableRenderContext KLNHOILIBHH, RenderingData HNEGCPHIBHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class AJBPPGLPLBB
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public readonly struct MCAECIEABCE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly string GLGOHIJMLFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CommandBuffer NOACLCGHLMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly ScriptableRenderContext KLNHOILIBHH;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7B96380", Offset = "0x7B94B80", VA = "0x187B96380")]
		public MCAECIEABCE(string BIFAJBDAPIK, ScriptableRenderContext DJAIKDANNKB, [Out] CommandBuffer BNAKLNFGBFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7B962D0", Offset = "0x7B94AD0", VA = "0x187B962D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7B8A390", Offset = "0x7B88B90", VA = "0x187B8A390")]
	public static bool PPEHCAANDHB(RenderingData HNEGCPHIBHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7B89F60", Offset = "0x7B88760", VA = "0x187B89F60")]
	public static void IGIKMECMBGD(CommandBuffer NOACLCGHLMN, ScriptableRenderContext KLNHOILIBHH, ShadowDrawingSettings MOMLNLMLNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7B8A130", Offset = "0x7B88930", VA = "0x187B8A130")]
	public static void LMMEOLAEJAM(CommandBuffer NOACLCGHLMN, ScriptableRenderContext KLNHOILIBHH, RenderingData HNEGCPHIBHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class JGMHACMIELE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class ELJCGDMILKI
	{
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int AHGPDFNPGNM;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public static readonly int PLKBJKALEPM;
	}

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static CALJHGPCNBK<EPFHBAPPHJK> AJGNINEKFDJ;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static CALJHGPCNBK<uint> INECAIKDOKE;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ALPFPGFLLFK JMNBFBIBNLM;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static ComputeBuffer DKICGKOHDAK;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static List<ECOCFONILKM> IMPHIFGJLOD;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int ALBIPMCPBMH;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int BENGDJAHBEB;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int ALJBKGGKMIL;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int IMEPOEAPHDL;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static int[] DGIOIIGFNMA;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static Material[] AEBHIFHOEHN;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static PMMAEJMDMAG[][] HDDADNIIGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Plane[] IKICHAIAMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int ALNOOAMNKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int GDDGCOGAIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int FPMOALDLFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int KJKJCHOENCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int BEDBLBHJKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int FHBMBEFANFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int IIBOKILBGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int IIJGFOIMAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int ENCIFIOHLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int NJHNPGONJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int KCABCEMDFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int JEONEAALPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int GAPFEJPIDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int DPIEAPCLKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int GGJDCEONBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int BEFEOAMKOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int ADBGHFHCGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int CMEGLCAECLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private float[] FEHHMIFCJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private PJCOJMKNOHM LDHHDMLNFMM;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool OPOBCCMHEMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7B931A0", Offset = "0x7B919A0", VA = "0x187B931A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B91990", Offset = "0x7B90190", VA = "0x187B91990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool CGEBLJMNOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B8EE00", Offset = "0x7B8D600", VA = "0x187B8EE00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B8EC60", Offset = "0x7B8D460", VA = "0x187B8EC60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData BADLMALNNLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7B919F0", Offset = "0x7B901F0", VA = "0x187B919F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7B93820", Offset = "0x7B92020", VA = "0x187B93820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static EAGBPJFJNLM GCAGCLLFMAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B94BB0", Offset = "0x7B933B0", VA = "0x187B94BB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7B933C0", Offset = "0x7B91BC0", VA = "0x187B933C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static IPHDHBCMOFL HBPINGKIBHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B90CE0", Offset = "0x7B8F4E0", VA = "0x187B90CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7B93740", Offset = "0x7B91F40", VA = "0x187B93740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static AJOKCCKFOAK CJFIHLLFCCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7B95200", Offset = "0x7B93A00", VA = "0x187B95200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7B90750", Offset = "0x7B8EF50", VA = "0x187B90750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static EMGOMJILPHO EBFGAHJFEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B8FE30", Offset = "0x7B8E630", VA = "0x187B8FE30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7B8EFB0", Offset = "0x7B8D7B0", VA = "0x187B8EFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static PGECKDDPACI OCGGEHBLOLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F1A0", Offset = "0x7B8D9A0", VA = "0x187B8F1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7B94C00", Offset = "0x7B93400", VA = "0x187B94C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static DFNADAFNJKC ELFFFBDLIMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7B93260", Offset = "0x7B91A60", VA = "0x187B93260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7B93300", Offset = "0x7B91B00", VA = "0x187B93300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material BHFBAMCKIMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7B932B0", Offset = "0x7B91AB0", VA = "0x187B932B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7B8EF40", Offset = "0x7B8D740", VA = "0x187B8EF40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material IEBKICHGGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7B8EEF0", Offset = "0x7B8D6F0", VA = "0x187B8EEF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F020", Offset = "0x7B8D820", VA = "0x187B8F020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material KHALHOAKNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7B93370", Offset = "0x7B91B70", VA = "0x187B93370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7B91EB0", Offset = "0x7B906B0", VA = "0x187B91EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material CGNFMBMOMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7B93140", Offset = "0x7B91940", VA = "0x187B93140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7B937B0", Offset = "0x7B91FB0", VA = "0x187B937B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool NHEFPJBAKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7B94C70", Offset = "0x7B93470", VA = "0x187B94C70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7B8EDA0", Offset = "0x7B8D5A0", VA = "0x187B8EDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool CPCOKNCJFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7B936E0", Offset = "0x7B91EE0", VA = "0x187B936E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string AKHPACECPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7B90D30", Offset = "0x7B8F530", VA = "0x187B90D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7B958C0", Offset = "0x7B940C0", VA = "0x187B958C0")]
	internal JGMHACMIELE([Optional] MClusterData GLPIMIHBMPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7B93890", Offset = "0x7B92090", VA = "0x187B93890")]
	public void NPIOKLMMDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7B8EE50", Offset = "0x7B8D650", VA = "0x187B8EE50")]
	public void DEAJNLGPDBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7B93190", Offset = "0x7B91990", VA = "0x187B93190")]
	public void LAFAAHPGDND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7B90C40", Offset = "0x7B8F440", VA = "0x187B90C40")]
	public bool GOOHAMLHDPP(Hash128 EGAIPBFBDLP, [Out] BPFFPBMKHCE ABAPBBKNPBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7B91C30", Offset = "0x7B90430", VA = "0x187B91C30")]
	public BPFFPBMKHCE JNEAPGDNFGC(LLBPKPBLDNB NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7B91A40", Offset = "0x7B90240", VA = "0x187B91A40")]
	public DKNFNBIEBLL JNEAPGDNFGC(EHNFNFAJIED OALKCGACMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7B91CF0", Offset = "0x7B904F0", VA = "0x187B91CF0")]
	public PIPELENMMAH JNEAPGDNFGC(JPAAENCCKEB CHKHGNKGCIE, bool FKPOLOPPCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7B8EC10", Offset = "0x7B8D410", VA = "0x187B8EC10")]
	public void AHELLINFOCL(ENPHCCANGLJ IJHICJECDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7B8ECC0", Offset = "0x7B8D4C0", VA = "0x187B8ECC0")]
	public static void BALIGCMNPDA(KOGDDMONJHO JGBCIPMOKIK, PMMAEJMDMAG[] NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7B8FE80", Offset = "0x7B8E680", VA = "0x187B8FE80")]
	private void FEJILNEBFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7B8F1F0", Offset = "0x7B8D9F0", VA = "0x187B8F1F0")]
	private static void EHPCPPDMACI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7B91F20", Offset = "0x7B90720", VA = "0x187B91F20")]
	public void KIHFIJNJLCA(CommandBuffer NOACLCGHLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7B93430", Offset = "0x7B91C30", VA = "0x187B93430")]
	public void MGMIKPOBOAK([Optional] ScriptableRenderContext? KLNHOILIBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7B916C0", Offset = "0x7B8FEC0", VA = "0x187B916C0")]
	public void JEOIGMCDADP(CommandBuffer NOACLCGHLMN, ShadowSplitData PAHFBOHKEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7B913E0", Offset = "0x7B8FBE0", VA = "0x187B913E0")]
	public void JEOIGMCDADP(CommandBuffer NOACLCGHLMN, CameraData JPKLHEDKCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7B94CC0", Offset = "0x7B934C0", VA = "0x187B94CC0")]
	public void PBMDEFODODG(CommandBuffer NOACLCGHLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7B931F0", Offset = "0x7B919F0", VA = "0x187B931F0")]
	public void LHGAPIBKGNL(CommandBuffer NOACLCGHLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7B907C0", Offset = "0x7B8EFC0", VA = "0x187B907C0")]
	public void GMMNCDHPNGI(CommandBuffer NOACLCGHLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7B95250", Offset = "0x7B93A50", VA = "0x187B95250")]
	public void PKKGMMCHFBG(CommandBuffer NOACLCGHLMN, KOGDDMONJHO NDHJKKIJKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7B93600", Offset = "0x7B91E00", VA = "0x187B93600")]
	public void MLJIHDLBHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7B92230", Offset = "0x7B90A30", VA = "0x187B92230")]
	public void KNAKPKDGKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7B8F090", Offset = "0x7B8D890", VA = "0x187B8F090", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class LOEFCAKGMCE
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x26998E0", Offset = "0x26980E0", VA = "0x1826998E0")]
	public static int OGENMPPDBPO(int JEGIFICJAGL, int BCAJPJPHEAI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct FAEGJKJFOCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4x4 BKOOFGKMPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float4 CHFCFDDDAGF;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly FAEGJKJFOCE GKGCPMOGJCG;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly FAEGJKJFOCE HCANDHABHHO;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7B8E080", Offset = "0x7B8C880", VA = "0x187B8E080")]
	public FAEGJKJFOCE(float4x4 HOGAHMDODPA, float4 FJLFBNBJLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7B8DF20", Offset = "0x7B8C720", VA = "0x187B8DF20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct JGIECEPLAMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 NCGKJMOKFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 GLANACDLEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 EFPHCCMNKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 KLFPJOMCLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 DIOCBLELHJH;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct NLNCONMLGAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public float4 NCGKJMOKFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 GLANACDLEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 EFPHCCMNKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 KLFPJOMCLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public half4 DIOCBLELHJH;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct EKIDHMEIGMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public NLNCONMLGAD OFFCKPDIGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public NLNCONMLGAD HAOJPHKCBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public NLNCONMLGAD CPPFPEINHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public NLNCONMLGAD LFBDBIHLBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public NLNCONMLGAD ANFCNNJPMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public NLNCONMLGAD JHBOIFAFIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public NLNCONMLGAD KBHNOAMPJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public NLNCONMLGAD FKMHDMMEHJM;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct EKOLAKAEDGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public JGIECEPLAMJ OFFCKPDIGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public JGIECEPLAMJ HAOJPHKCBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public JGIECEPLAMJ CPPFPEINHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public JGIECEPLAMJ LFBDBIHLBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public JGIECEPLAMJ ANFCNNJPMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public JGIECEPLAMJ JHBOIFAFIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public JGIECEPLAMJ KBHNOAMPJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public JGIECEPLAMJ FKMHDMMEHJM;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct IOCFMNEEHEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float4 FPFEOKGHPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint MENIDKIJFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public uint HHKKDJCOGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public float ONPIOFPINIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint EHKLHOMEBBA;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7B8EA80", Offset = "0x7B8D280", VA = "0x187B8EA80")]
	public IOCFMNEEHEH(EHNFNFAJIED OALKCGACMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct EPFHBAPPHJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint FIEMEPBDLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint BEOGEJIDEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint FPBGLNPLCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint EHKLHOMEBBA;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7B8DE70", Offset = "0x7B8C670", VA = "0x187B8DE70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct JEOKDHJNBEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint JFFKDIELMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint KDPNINKHEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint EKBBKNBDGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint EHKLHOMEBBA;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7B8EB60", Offset = "0x7B8D360", VA = "0x187B8EB60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct NNCLEAAKOPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint JNNOAPGEOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint ENDOJMLPGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint KHLOHKLLBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint KPKILENIAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint NLHNHLPFAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint LBGPDPHEKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint GIBGJMKALIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint EHKLHOMEBBA;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7B97830", Offset = "0x7B96030", VA = "0x187B97830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct BMDINKPDPBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 KIJJMLICNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 JPOKDJDCCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 FILMDODJOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 EKGNKMCPPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 DAMJOLBNBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 ILDPKDNPLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 ABFDADANKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public uint3 AFGEIJADBPH;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7B8A630", Offset = "0x7B88E30", VA = "0x187B8A630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum KOGDDMONJHO
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	Opaque,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	DepthOnly,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Transparent,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Shadow
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
