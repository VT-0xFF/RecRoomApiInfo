using System;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum JBBCPFNGLJG
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
public interface HEKECBDOGAF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PIOPKDCIGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMECLHJFIFG(JBBCPFNGLJG DMJFIAAGODA);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ODGJJHFNDHJ();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BCLDENGMMKA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FKMGCDLLEIP(string JFENPBGFEBI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BDMHJGIADGM([Optional] string DLNKHNOOBAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PKPIPODNDIM
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDBHCEGKGDC(DMGLLAODCOP EOFBJCFCHNP);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OIONEFONLJN : HEKECBDOGAF, GJPJNMEJCHB
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum LHJOPMDGNCF
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void MHHKLALIMBI(string EOFBJCFCHNP);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int AEIOEPBAOPJ();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static OIONEFONLJN HBJDGFDOIDP;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static bool EBPKGHJBBLA;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static bool BBGDLOPPHDL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static bool GLFGDEEFKHE;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static long? EBLGHLOADEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CGJGFNPNNOI ILDEFCBGFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private JBBCPFNGLJG DGOEBDGBBEM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long JIGGJBIMDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x65E97E0", Offset = "0x65E7FE0", VA = "0x1865E97E0", Slot = "10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PIOPKDCIGAA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D00", Offset = "0x6D7500", VA = "0x1806D8D00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x65E9F10", Offset = "0x65E8710", VA = "0x1865E9F10")]
	[Preserve]
	public OIONEFONLJN([LJAGOLJKNEF(null)] CGJGFNPNNOI ILDEFCBGFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x65E9AB0", Offset = "0x65E82B0", VA = "0x1865E9AB0", Slot = "6")]
	public void ODGJJHFNDHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x65E9370", Offset = "0x65E7B70", VA = "0x1865E9370", Slot = "7")]
	public void BCLDENGMMKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x65E9370", Offset = "0x65E7B70", VA = "0x1865E9370", Slot = "9")]
	public void BDMHJGIADGM([Optional] string DLNKHNOOBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x65E9370", Offset = "0x65E7B70", VA = "0x1865E9370", Slot = "8")]
	public void FKMGCDLLEIP(string JFENPBGFEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x65E93F0", Offset = "0x65E7BF0", VA = "0x1865E93F0", Slot = "5")]
	public void BMECLHJFIFG(JBBCPFNGLJG DMJFIAAGODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x65E96D0", Offset = "0x65E7ED0", VA = "0x1865E96D0")]
	private void JPNGMDCPKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x65E98B0", Offset = "0x65E80B0", VA = "0x1865E98B0")]
	private void LJGKLAPLBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x65E9D90", Offset = "0x65E8590", VA = "0x1865E9D90")]
	[MonoPInvokeCallback(typeof(MHHKLALIMBI))]
	private static void OILHPFBMHGC(string CEHGEOFPDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x65E94A0", Offset = "0x65E7CA0", VA = "0x1865E94A0")]
	[MonoPInvokeCallback(typeof(AEIOEPBAOPJ))]
	private static int CFBCKIPCAKD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x65E95F0", Offset = "0x65E7DF0", VA = "0x1865E95F0")]
	private void FJFFABKLFDG(string BMIILJCCJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x65E95B0", Offset = "0x65E7DB0", VA = "0x1865E95B0")]
	private void EAKABKAIBKF(MHHKLALIMBI MKOFIMIHGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x65E93B0", Offset = "0x65E7BB0", VA = "0x1865E93B0")]
	private void BHNMLJFFFNC(AEIOEPBAOPJ MKOFIMIHGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x65E9370", Offset = "0x65E7B70", VA = "0x1865E9370")]
	private void BCLDENGMMKA(LHJOPMDGNCF ILIPAMEJBLH, string ALFJJGNMOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x65E9570", Offset = "0x65E7D70", VA = "0x1865E9570")]
	private void DAOECLCMBNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x65E9670", Offset = "0x65E7E70", VA = "0x1865E9670")]
	private long? HINAKAEJGIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x65E9510", Offset = "0x65E7D10", VA = "0x1865E9510")]
	private long? CLBOIJBMHLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x65E9A20", Offset = "0x65E8220", VA = "0x1865E9A20")]
	internal static void NPEFEDOCKFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x65E99B0", Offset = "0x65E81B0", VA = "0x1865E99B0")]
	private static void NAKHIJIADCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DOPGJCPHICK
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x65E91B0", Offset = "0x65E79B0", VA = "0x1865E91B0")]
	[HAHBDBPNEOA(MDCFJLLNHDJ.None)]
	private static void AAFDAINMAIC(BENLBCJOMLF NDEFPJDAEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x65E92A0", Offset = "0x65E7AA0", VA = "0x1865E92A0")]
	[FKLAFGEGFDL(FBKMDIMHGAB.Unity_BeforeSceneLoad)]
	private static void BDEGEMCEMAM()
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
