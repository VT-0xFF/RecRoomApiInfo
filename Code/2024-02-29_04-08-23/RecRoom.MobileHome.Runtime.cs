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
public enum MMJGODCHCHD
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
public interface FELMHPOPHNI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IIGHFDKICBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? MBBALGFNBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? CLJJKGBDPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? HLPOCEIOAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? GMFPDBODEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MHCEADCGHAO(MMJGODCHCHD DCBJOKKHJFC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FCIFMHNEBDM();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GLNNGGCNPOJ();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OKFLBCJCFOI(string LPMAAHFLADH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IIKJAMKHBBL();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ECKCKJONDOH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EGGAAIJFJMG(LBNLFGCHCOM MELFLNOCHOA, [Optional] CancellationToken HHBHDBLGMFA);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BJJJMKLCNEH : FELMHPOPHNI
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum BBMBCLPEDLF
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void NLILJINDMDA(string MELFLNOCHOA);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int OAHOOFGPBAA();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static BJJJMKLCNEH NNOMIIGCPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly LPDDOMPGFNK ANAOKJFEELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool KIJCJIOJIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool NGFIIOBNCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool HENNOLGPOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool ELIHBNPGNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long? OBFCCJKEDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool LLEHEADMBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private long? HBAKNMAHGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool MFGLDHHDNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private Guid? IBMNOEPJNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private MMJGODCHCHD IGBPGHPDLBF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool IIGHFDKICBK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? MBBALGFNBBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x604EEB0", Offset = "0x604DCB0", VA = "0x18604EEB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? CLJJKGBDPMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x604E280", Offset = "0x604D080", VA = "0x18604E280", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Guid? HLPOCEIOAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x604EB70", Offset = "0x604D970", VA = "0x18604EB70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float? GMFPDBODEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x604E170", Offset = "0x604CF70", VA = "0x18604E170", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LBNLFGCHCOM LJNONEKCAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C90", Offset = "0x7A7A90", VA = "0x1807A8C90", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CA0", Offset = "0x7A7AA0", VA = "0x1807A8CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x604F3A0", Offset = "0x604E1A0", VA = "0x18604F3A0")]
	[Preserve]
	public BJJJMKLCNEH([LICAMFFCLCL(null)] LPDDOMPGFNK ANAOKJFEELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x604E5C0", Offset = "0x604D3C0", VA = "0x18604E5C0", Slot = "10")]
	public void FCIFMHNEBDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x604E960", Offset = "0x604D760", VA = "0x18604E960", Slot = "13")]
	public void IIKJAMKHBBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x604EFA0", Offset = "0x604DDA0", VA = "0x18604EFA0", Slot = "15")]
	public void OIIAGKOOOFK(string JOBAFOLKIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x604E780", Offset = "0x604D580", VA = "0x18604E780", Slot = "11")]
	public void GLNNGGCNPOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x604ED20", Offset = "0x604DB20", VA = "0x18604ED20", Slot = "16")]
	public void LPNLIKDJPMC([Optional] string NFPEHAHGCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x604F110", Offset = "0x604DF10", VA = "0x18604F110", Slot = "12")]
	public void OKFLBCJCFOI(string LPMAAHFLADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x604EDE0", Offset = "0x604DBE0", VA = "0x18604EDE0", Slot = "9")]
	public void MHCEADCGHAO(MMJGODCHCHD DCBJOKKHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x604DDA0", Offset = "0x604CBA0", VA = "0x18604DDA0")]
	private void BHJHLPMAJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x604F200", Offset = "0x604E000", VA = "0x18604F200")]
	[MonoPInvokeCallback(typeof(NLILJINDMDA))]
	private static void POEFBHMOOFL(string JOBAFOLKIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x604F1B0", Offset = "0x604DFB0", VA = "0x18604F1B0")]
	[MonoPInvokeCallback(typeof(OAHOOFGPBAA))]
	private static int PIAPINMBAHJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x604E430", Offset = "0x604D230", VA = "0x18604E430")]
	private void EKDJDBEIPFA(string AGPLIIIBKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x604F120", Offset = "0x604DF20", VA = "0x18604F120")]
	private void OPIJLGGBHJG(NLILJINDMDA IDFHKFHMFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x604E840", Offset = "0x604D640", VA = "0x18604E840")]
	private void HKGDJDLKDGP(OAHOOFGPBAA IDFHKFHMFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x604E6F0", Offset = "0x604D4F0", VA = "0x18604E6F0")]
	private void GLNNGGCNPOJ(BBMBCLPEDLF IIMECKHJEHG, string DFLPAGIBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x604E8D0", Offset = "0x604D6D0", VA = "0x18604E8D0")]
	private void IGNBHNCFIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x604ED30", Offset = "0x604DB30", VA = "0x18604ED30")]
	private long? LPPKKFFNABC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x604E790", Offset = "0x604D590", VA = "0x18604E790")]
	private long? HEIHHCKBPEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x604E0C0", Offset = "0x604CEC0", VA = "0x18604E0C0")]
	private Guid? BMCGEGIDOCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x604EC70", Offset = "0x604DA70", VA = "0x18604EC70")]
	private double? LEKEEDKLLGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x604E370", Offset = "0x604D170", VA = "0x18604E370")]
	internal static void EIMBPLNIBPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x604E4A0", Offset = "0x604D2A0", VA = "0x18604E4A0")]
	private void EMPMJHPDGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x604E970", Offset = "0x604D770", VA = "0x18604E970")]
	[CompilerGenerated]
	private void JJFNCBFBKPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KCLHALGJJMJ
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x604F420", Offset = "0x604E220", VA = "0x18604F420")]
	[NAAAALLPNIA(PBKIGNPNCFO.None)]
	private static void OJLJIBMHFJA(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x604E370", Offset = "0x604D170", VA = "0x18604E370")]
	[FIGCBHDOGLN(HCIPOEFGANF.Unity_BeforeSceneLoad)]
	private static void BOKMCBIIJHB()
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
