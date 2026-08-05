using System;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum GFGAMOJMLKG
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
public interface GCLANALOAPO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NKIBOGENAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? MCLCFHNFCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? FFKKLAFBJJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BOBAPJHCEOP(GFGAMOJMLKG DADHJJNJEFA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IHEKMEOIBOI();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HOKLNGCAMFG();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OGIGKKPCGFB(string PEOLHGGDCPN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GIAMEHCADHK([Optional] string LNJEKPIKGEF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ONIMCMMPJIP
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHAEBOGFHAP(BMCGMLFFLBN ICDMMGNFMAF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DHEKKGMHGDD : GCLANALOAPO
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum KAFFJMLIBOP
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void JFFHBMECNIG(string ICDMMGNFMAF);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int LJJAPEPMDJI();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static DHEKKGMHGDD CMDPMJBEBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool EMEFDPDDBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool OEAONLGBBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool JBOGEFGENLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private long? EKKNKHLGIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? JOJPLLPGAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private GFGAMOJMLKG GPEKOMBKGOB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool NKIBOGENAMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long? MCLCFHNFCMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x680EF50", Offset = "0x680E150", VA = "0x18680EF50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long? FFKKLAFBJJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x680ED60", Offset = "0x680DF60", VA = "0x18680ED60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x680F340", Offset = "0x680E540", VA = "0x18680F340")]
	[Preserve]
	public DHEKKGMHGDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x680F010", Offset = "0x680E210", VA = "0x18680F010", Slot = "8")]
	public void IHEKMEOIBOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x680EEB0", Offset = "0x680E0B0", VA = "0x18680EEB0", Slot = "9")]
	public void HOKLNGCAMFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x680EEB0", Offset = "0x680E0B0", VA = "0x18680EEB0", Slot = "11")]
	public void GIAMEHCADHK([Optional] string LNJEKPIKGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x680EEB0", Offset = "0x680E0B0", VA = "0x18680EEB0", Slot = "10")]
	public void OGIGKKPCGFB(string PEOLHGGDCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x680EC40", Offset = "0x680DE40", VA = "0x18680EC40", Slot = "7")]
	public void BOBAPJHCEOP(GFGAMOJMLKG DADHJJNJEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x680EDA0", Offset = "0x680DFA0", VA = "0x18680EDA0")]
	private void GGEKDLHKGDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x680F280", Offset = "0x680E480", VA = "0x18680F280")]
	private void OFLEHNFCJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x680EB20", Offset = "0x680DD20", VA = "0x18680EB20")]
	[MonoPInvokeCallback(typeof(JFFHBMECNIG))]
	private static void BAHEGBNCDDP(string PHHLDLJKMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x680ED10", Offset = "0x680DF10", VA = "0x18680ED10")]
	[MonoPInvokeCallback(typeof(LJJAPEPMDJI))]
	private static int DJMGECPBHKI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x680EC90", Offset = "0x680DE90", VA = "0x18680EC90")]
	private void DHMJLOKPGNI(string ICFHHMECDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x680F300", Offset = "0x680E500", VA = "0x18680F300")]
	private void PAKEHFAJCLD(JFFHBMECNIG ONAFALABHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x680EF90", Offset = "0x680E190", VA = "0x18680EF90")]
	private void HBEAFPDKNCO(LJJAPEPMDJI ONAFALABHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x680EEB0", Offset = "0x680E0B0", VA = "0x18680EEB0")]
	private void HOKLNGCAMFG(KAFFJMLIBOP CKHHGBNHHCK, string JDBHABEFGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x680EFD0", Offset = "0x680E1D0", VA = "0x18680EFD0")]
	private void HPDNDEGOABN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x680EEF0", Offset = "0x680E0F0", VA = "0x18680EEF0")]
	private long? GLLDDKKGFOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x680F150", Offset = "0x680E350", VA = "0x18680F150")]
	private long? JAPNBAPAAPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x680F1B0", Offset = "0x680E3B0", VA = "0x18680F1B0")]
	internal static void JCMIMPEPHNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x680F270", Offset = "0x680E470", VA = "0x18680F270")]
	private void MCMPMCBDPLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JMBKBAPIAOL
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x680F3A0", Offset = "0x680E5A0", VA = "0x18680F3A0")]
	[IOFOCEAPGPD(NPBJMIOJGOK.None)]
	private static void FHCJHIEHNLG(MNALHHOLFGL FMPHDMAKDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x680F1B0", Offset = "0x680E3B0", VA = "0x18680F1B0")]
	[LCHGFDCANEE(CHIHMKPMNLF.Unity_BeforeSceneLoad)]
	private static void NIIKMJABPBA()
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
