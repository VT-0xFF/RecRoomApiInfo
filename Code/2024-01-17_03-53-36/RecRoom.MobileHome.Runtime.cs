using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HBLPGHOIEDK
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Unknown = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Initializing = 1,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ReadyForLogin = 2,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	PlayerLoading = 32,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	PlayerLoaded = 33,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	RoomLoading = 64,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	InOrientation = 65,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	InDorm = 66,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	InRoom = 67,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	InEvent = 68,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Logout = 128,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	ExitingClient = 129
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LCMIMIBNMHA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AMLNMNFBPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? LADEAPHDHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? LBOBGOMFFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? NPDMNPCDLII
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? JKAFBGOJLPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BKLMEIFEKMC(HBLPGHOIEDK AEMBMKHDECA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CGDOOEBPPMG();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PPGFNHFLHFO();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NDIDALGJICA(string CPHLJEKFBPB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JPAKGBADCAF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NKNMIEBEFEG
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KGJHHGFKOML(EGGHGOPGFOC KBJKPBBBFNM, [Optional] CancellationToken EHAEIHNIHFM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LAJNCHJIGIK : LCMIMIBNMHA
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum EFFELAKLPHF
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void EKGMLFDGCCG(string KBJKPBBBFNM);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int OAABBGIIFEB();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static LAJNCHJIGIK PICGAENFGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool MLADHKPLHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool GLHIFFPHEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool CNJNHFGLMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool KLDMKKIBIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? DNGKMKOACFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool MLIPKCKJBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private long? DOFCGPHDNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool DDJLHNNCOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Guid? EDLINNLACHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly CEGGMEIFBDJ LMNLEOEGOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private HBLPGHOIEDK CLMNEALHEHJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool AMLNMNFBPDM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? LADEAPHDHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6019FA0", Offset = "0x6018DA0", VA = "0x186019FA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? LBOBGOMFFJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x601A2D0", Offset = "0x60190D0", VA = "0x18601A2D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Guid? NPDMNPCDLII
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x601A3C0", Offset = "0x60191C0", VA = "0x18601A3C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float? JKAFBGOJLPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x601A0A0", Offset = "0x6018EA0", VA = "0x18601A0A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x601AF10", Offset = "0x6019D10", VA = "0x18601AF10")]
	[Preserve]
	public LAJNCHJIGIK([MCCEMKLKAEE(null)] CEGGMEIFBDJ LMNLEOEGOMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6019E70", Offset = "0x6018C70", VA = "0x186019E70", Slot = "10")]
	public void CGDOOEBPPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x335F3A0", Offset = "0x335E1A0", VA = "0x18335F3A0", Slot = "13")]
	public void JPAKGBADCAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x601AE70", Offset = "0x6019C70", VA = "0x18601AE70", Slot = "11")]
	public void PPGFNHFLHFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x601A090", Offset = "0x6018E90", VA = "0x18601A090", Slot = "14")]
	public void DJEONKKIHGD([Optional] string IPJGFNFBGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x601ADB0", Offset = "0x6019BB0", VA = "0x18601ADB0", Slot = "12")]
	public void NDIDALGJICA(string CPHLJEKFBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6019DB0", Offset = "0x6018BB0", VA = "0x186019DB0", Slot = "9")]
	public void BKLMEIFEKMC(HBLPGHOIEDK AEMBMKHDECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x601A900", Offset = "0x6019700", VA = "0x18601A900")]
	private void KMOEMIKGOKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x601A4C0", Offset = "0x60192C0", VA = "0x18601A4C0")]
	[MonoPInvokeCallback(typeof(EKGMLFDGCCG))]
	private static void HPEKGIOEHFP(string HMDLECAFOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x601A6C0", Offset = "0x60194C0", VA = "0x18601A6C0")]
	[MonoPInvokeCallback(typeof(OAABBGIIFEB))]
	private static int IBMNKGCKGPN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x601AC20", Offset = "0x6019A20", VA = "0x18601AC20")]
	private void LIHNPJLLPFJ(string PCJEKDOKBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x601AC90", Offset = "0x6019A90", VA = "0x18601AC90")]
	private void MALBKOIPIMG(EKGMLFDGCCG EAGOMMNFHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x601A870", Offset = "0x6019670", VA = "0x18601A870")]
	private void JAAKKKLFFCA(OAABBGIIFEB EAGOMMNFHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x601AE80", Offset = "0x6019C80", VA = "0x18601AE80")]
	private void PPGFNHFLHFO(EFFELAKLPHF LEMNLAKPKCD, string LBPJBIBFPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x601AD20", Offset = "0x6019B20", VA = "0x18601AD20")]
	private void MCPDEGNLBNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x601ADC0", Offset = "0x6019BC0", VA = "0x18601ADC0")]
	private long? PHHJEHECJDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x601A710", Offset = "0x6019510", VA = "0x18601A710")]
	private long? ILMDNFNBADP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x601A610", Offset = "0x6019410", VA = "0x18601A610")]
	private Guid? IBFCCCIKJNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x601A7C0", Offset = "0x60195C0", VA = "0x18601A7C0")]
	private double? IPFBCGIAFEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6019AA0", Offset = "0x60188A0", VA = "0x186019AA0")]
	internal static void LCBKIEIICLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x601A1B0", Offset = "0x6018FB0", VA = "0x18601A1B0")]
	private void EDGFEGMMMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6019C60", Offset = "0x6018A60", VA = "0x186019C60")]
	[CompilerGenerated]
	private void ACMAPPCNGNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BPFEFPPMJCB
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6019B60", Offset = "0x6018960", VA = "0x186019B60")]
	[OKINHFAHPEJ(FNGNILODNLI.None)]
	private static void ONCLOCEJPOI(LPFNGCMIAEC KDNLDLIFDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6019AA0", Offset = "0x60188A0", VA = "0x186019AA0")]
	[GEDGJALKBHL(HNLGNAJIJHC.Unity_BeforeSceneLoad)]
	private static void DHPLENJCBHB()
	{
	}
}
namespace Cpp2IlInjected;

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
