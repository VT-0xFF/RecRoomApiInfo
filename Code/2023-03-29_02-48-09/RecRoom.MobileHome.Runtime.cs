using System;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum MHLFOFPFCKC
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
public interface HCLMGAICKOM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AHCDJMPJBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHEPKJKJHEN(MHLFOFPFCKC NNMLCFCBKLN);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GIHONBOCKDC();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MEIOHEGFBPN();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JBKNOAFJPBP(string NCNFOLMLPIN);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EGDIEJFEDNB([Optional] string EDNMCOOOJBO);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AHDOAJJLGGK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HJFABMOFAKE(KBNDNIPKLCC BNDGLPJHAOC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DNNJJIPPALP : HCLMGAICKOM, JCDGMGMGHMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum NNMIPFCENAH
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void IKHLPFDLIAG(string BNDGLPJHAOC);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int NJOKMHPCLDP();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static DNNJJIPPALP JKPACBEDIJD;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static bool PHGPCDBAGEE;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static bool JFPDNAPNICG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static bool DBICHJEIJPG;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static long? BIMPODMKAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly BOHGMEODGFJ JDJAEPLFMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private MHLFOFPFCKC NNKOFLHCDGO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long HGDHJNEOCDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6639770", Offset = "0x6638570", VA = "0x186639770", Slot = "10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AHCDJMPJBKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x70F8E0", Offset = "0x70E6E0", VA = "0x18070F8E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6639C70", Offset = "0x6638A70", VA = "0x186639C70")]
	[Preserve]
	public DNNJJIPPALP([KIJADEHPJBH(null)] BOHGMEODGFJ JDJAEPLFMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6639450", Offset = "0x6638250", VA = "0x186639450", Slot = "6")]
	public void GIHONBOCKDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6639360", Offset = "0x6638160", VA = "0x186639360", Slot = "7")]
	public void MEIOHEGFBPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6639360", Offset = "0x6638160", VA = "0x186639360", Slot = "9")]
	public void EGDIEJFEDNB([Optional] string EDNMCOOOJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6639360", Offset = "0x6638160", VA = "0x186639360", Slot = "8")]
	public void JBKNOAFJPBP(string NCNFOLMLPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x66393A0", Offset = "0x66381A0", VA = "0x1866393A0", Slot = "5")]
	public void FHEPKJKJHEN(MHLFOFPFCKC NNMLCFCBKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x66390D0", Offset = "0x6637ED0", VA = "0x1866390D0")]
	private void BPNJAALFNDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6639AD0", Offset = "0x66388D0", VA = "0x186639AD0")]
	private void PEFLHILCBEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6639240", Offset = "0x6638040", VA = "0x186639240")]
	[MonoPInvokeCallback(typeof(IKHLPFDLIAG))]
	private static void EBILOGALLAH(string CAACPHPCAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6639970", Offset = "0x6638770", VA = "0x186639970")]
	[MonoPInvokeCallback(typeof(NJOKMHPCLDP))]
	private static int MFAPILIGIBM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x66398F0", Offset = "0x66386F0", VA = "0x1866398F0")]
	private void JODPBGKCHLE(string JIBDJAHOFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6639BD0", Offset = "0x66389D0", VA = "0x186639BD0")]
	private void PLGJINPDGLL(IKHLPFDLIAG JDLJMIHPPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6639840", Offset = "0x6638640", VA = "0x186639840")]
	private void GOLICGDCMOE(NJOKMHPCLDP JDLJMIHPPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6639360", Offset = "0x6638160", VA = "0x186639360")]
	private void MEIOHEGFBPN(NNMIPFCENAH DAFNIKIEOHD, string FHJGEHOPOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6639730", Offset = "0x6638530", VA = "0x186639730")]
	private void GKIMDDHALMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6639A70", Offset = "0x6638870", VA = "0x186639A70")]
	private long? NPDODBMOBBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x66391E0", Offset = "0x6637FE0", VA = "0x1866391E0")]
	private long? DHBEKNKPFAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x66399E0", Offset = "0x66387E0", VA = "0x1866399E0")]
	internal static void NIHIJIODDGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6639880", Offset = "0x6638680", VA = "0x186639880")]
	private static void JHPCELDMIPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class NAEPCDEMPCO
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6639DD0", Offset = "0x6638BD0", VA = "0x186639DD0")]
	[NPBDMCLHPNM(AIJEIIPHIJH.None)]
	private static void GNNMKHGNMNO(HKDBAIGILEN DHPFLPHCDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6639D00", Offset = "0x6638B00", VA = "0x186639D00")]
	[KOIFHKBOHLF(NIJEKHCIIFG.Unity_BeforeSceneLoad)]
	private static void EBDIOKIBPDH()
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
