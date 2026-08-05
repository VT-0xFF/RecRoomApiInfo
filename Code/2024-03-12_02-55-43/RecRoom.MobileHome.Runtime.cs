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
public enum IHOMNDNMHPM
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
public interface JKINOHHAGHA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DKDCKGGOCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? ICPDOGMIMJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? NKCHIKACNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? HOMJEPJLMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? HKPIJLJJEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HECJPDELHMA(IHOMNDNMHPM MJCOPLGCMGI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AKCGAJHNOGB();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BKHDCIFFHLF();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MJGENCMIACD(string CBGCCJELKCD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BJDNMMEHCPL();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BILHDFLAKAM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KHJDJKNONIA(ICKHOOMIKAC AOBMCLDMLGA, [Optional] CancellationToken OBNOJDAGGOE);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MEOAALIOIEH : JKINOHHAGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum JILJMMCOLAA
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void CHFIPIIKNJP(string AOBMCLDMLGA);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int AJHHNGGIKPJ();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static MEOAALIOIEH PHLEALHFEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly DHHKPNDEBCG JOELEBPBHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool AKDHBNELFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool HLFEKPJIBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool IPPNLHEEIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool POBGGCHPHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long? OAOFNJMMLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool EEFGLCJBBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private long? BIFONDNCNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool NONJEKILEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private Guid? MHAIFLIAMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private IHOMNDNMHPM BCDDMGEABHE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool DKDCKGGOCNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? ICPDOGMIMJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x61A8D10", Offset = "0x61A7F10", VA = "0x1861A8D10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? NKCHIKACNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61A8E00", Offset = "0x61A8000", VA = "0x1861A8E00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Guid? HOMJEPJLMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x61A8F00", Offset = "0x61A8100", VA = "0x1861A8F00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float? HKPIJLJJEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x61A8130", Offset = "0x61A7330", VA = "0x1861A8130", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ICKHOOMIKAC DCHOJEBHNIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7BDF70", Offset = "0x7BD170", VA = "0x1807BDF70", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7BDF90", Offset = "0x7BD190", VA = "0x1807BDF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x61A9340", Offset = "0x61A8540", VA = "0x1861A9340")]
	[Preserve]
	public MEOAALIOIEH([BALLJMBCNAE(null)] DHHKPNDEBCG JOELEBPBHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x61A8110", Offset = "0x61A7310", VA = "0x1861A8110", Slot = "10")]
	public void AKCGAJHNOGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x61A8240", Offset = "0x61A7440", VA = "0x1861A8240", Slot = "13")]
	public void BJDNMMEHCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x61A8AF0", Offset = "0x61A7CF0", VA = "0x1861A8AF0", Slot = "15")]
	public void IFPHKAOHBKM(string KAHGBHMMKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x61A82E0", Offset = "0x61A74E0", VA = "0x1861A82E0", Slot = "11")]
	public void BKHDCIFFHLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x61A8EF0", Offset = "0x61A80F0", VA = "0x1861A8EF0", Slot = "16")]
	public void KIJAAIAGFKN([Optional] string JENOPJIHIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x61A9000", Offset = "0x61A8200", VA = "0x1861A9000", Slot = "12")]
	public void MJGENCMIACD(string CBGCCJELKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x61A8920", Offset = "0x61A7B20", VA = "0x1861A8920", Slot = "9")]
	public void HECJPDELHMA(IHOMNDNMHPM MJCOPLGCMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61A83A0", Offset = "0x61A75A0", VA = "0x1861A83A0")]
	private void EDDGFNAEIJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x61A9080", Offset = "0x61A8280", VA = "0x1861A9080")]
	[MonoPInvokeCallback(typeof(CHFIPIIKNJP))]
	private static void OHEGCKJLGJA(string KAHGBHMMKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x61A8AA0", Offset = "0x61A7CA0", VA = "0x1861A8AA0")]
	[MonoPInvokeCallback(typeof(AJHHNGGIKPJ))]
	private static int HNLOCKDKFDB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x61A9010", Offset = "0x61A8210", VA = "0x1861A9010")]
	private void OAFDNKCNMHA(string BCOHMDGLHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x61A8890", Offset = "0x61A7A90", VA = "0x1861A8890")]
	private void GLPKBHDCKHF(CHFIPIIKNJP FPMNHFJNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61A8750", Offset = "0x61A7950", VA = "0x1861A8750")]
	private void FLBNBLGEJLF(AJHHNGGIKPJ FPMNHFJNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x61A8250", Offset = "0x61A7450", VA = "0x1861A8250")]
	private void BKHDCIFFHLF(JILJMMCOLAA GJNAIKENJBL, string PNOECKFPCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x61A86C0", Offset = "0x61A78C0", VA = "0x1861A86C0")]
	private void EOKKDMEOHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x61A82F0", Offset = "0x61A74F0", VA = "0x1861A82F0")]
	private long? CELJPOHLNOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x61A89F0", Offset = "0x61A7BF0", VA = "0x1861A89F0")]
	private long? HGLFMODDGFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61A8C60", Offset = "0x61A7E60", VA = "0x1861A8C60")]
	private Guid? IGPDCCHHDCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x61A87E0", Offset = "0x61A79E0", VA = "0x1861A87E0")]
	private double? GJDFLLHJMDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61A8050", Offset = "0x61A7250", VA = "0x1861A8050")]
	internal static void GKAICCAFKIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x61A9220", Offset = "0x61A8420", VA = "0x1861A9220")]
	private void PKHLNMEBCAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class INHOCPPDGHI
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x61A7F50", Offset = "0x61A7150", VA = "0x1861A7F50")]
	[JKGCDNJCKNE(LIEILBDPEFI.None)]
	private static void INDOBKPKHOD(IAIHJGNDPNA DEFANHHPGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x61A8050", Offset = "0x61A7250", VA = "0x1861A8050")]
	[NHKJGMGAMEG(BDNMCGCKBGD.Unity_BeforeSceneLoad)]
	private static void NPKGFKLJDKD()
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
