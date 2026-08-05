using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum CEBANMFKJIC
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
public interface PFHHCLPDHCM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FBOBHLEMKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? PLJCLIILDAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? HPKAEEGPFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? BOJDKLBFBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AMEKFJHALAL(CEBANMFKJIC CGABFKIJBOC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OMELHDOHHCI();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MPOONLNLOOB();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KCLJNMKJIBP(string BCBCBAEOENM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FAMEOEKMNLI
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FMIFPKHHEEG(JHMECPOHMLC IIMPIKNDFPK, [Optional] CancellationToken OMFABMCIOAC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GOJFKMDCAFL : PFHHCLPDHCM
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum FCEJKHCLOGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void DNBIEMOAGEA(string IIMPIKNDFPK);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int MJPIJCBCBOE();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static GOJFKMDCAFL CLFOAALEFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool JBFGLAHFDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool COMHOKDBICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool POLECALMJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private long? IIBAAPAOLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? FFLIHCJNLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private Guid? ICFCKHHJPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly OEDPDKKLCHP HLBGIEFOBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CEBANMFKJIC HEIEAOKOOIH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool FBOBHLEMKMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long? PLJCLIILDAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D154E0", Offset = "0x5D148E0", VA = "0x185D154E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? HPKAEEGPFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D14FA0", Offset = "0x5D143A0", VA = "0x185D14FA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Guid? BOJDKLBFBNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D14FE0", Offset = "0x5D143E0", VA = "0x185D14FE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5D159C0", Offset = "0x5D14DC0", VA = "0x185D159C0")]
	[Preserve]
	public GOJFKMDCAFL([LMAFJMDCBJO(null)] OEDPDKKLCHP HLBGIEFOBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D156E0", Offset = "0x5D14AE0", VA = "0x185D156E0", Slot = "9")]
	public void OMELHDOHHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5D155B0", Offset = "0x5D149B0", VA = "0x185D155B0", Slot = "10")]
	public void MPOONLNLOOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D150C0", Offset = "0x5D144C0", VA = "0x185D150C0", Slot = "12")]
	public void HIKADMFFJLB([Optional] string IHJIBKMMBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D154D0", Offset = "0x5D148D0", VA = "0x185D154D0", Slot = "11")]
	public void KCLJNMKJIBP(string BCBCBAEOENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D14A70", Offset = "0x5D13E70", VA = "0x185D14A70", Slot = "8")]
	public void AMEKFJHALAL(CEBANMFKJIC CGABFKIJBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D14B30", Offset = "0x5D13F30", VA = "0x185D14B30")]
	private void CBHPOCHHPGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D14860", Offset = "0x5D13C60", VA = "0x185D14860")]
	private void ADOBJDKJJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D150D0", Offset = "0x5D144D0", VA = "0x185D150D0")]
	[MonoPInvokeCallback(typeof(DNBIEMOAGEA))]
	private static void HIMKNFAJKFH(string KDFJNCGEEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D14A20", Offset = "0x5D13E20", VA = "0x185D14A20")]
	[MonoPInvokeCallback(typeof(MJPIJCBCBOE))]
	private static int AININMEJGLC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D155C0", Offset = "0x5D149C0", VA = "0x185D155C0")]
	private void NEPDMGJIHNI(string NBOPEOGONNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D15030", Offset = "0x5D14430", VA = "0x185D15030")]
	private void HDJNLLAHEMA(DNBIEMOAGEA AIBILCAOCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D15820", Offset = "0x5D14C20", VA = "0x185D15820")]
	private void OMIGIHNODLL(MJPIJCBCBOE AIBILCAOCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D15520", Offset = "0x5D14920", VA = "0x185D15520")]
	private void MPOONLNLOOB(FCEJKHCLOGM GDMNFOHPCNM, string HNCMCOLFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D15220", Offset = "0x5D14620", VA = "0x185D15220")]
	private void HJGMGGCGHHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D15630", Offset = "0x5D14A30", VA = "0x185D15630")]
	private long? NIKNAGBEHML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D15360", Offset = "0x5D14760", VA = "0x185D15360")]
	private long? ILNEIMJIEBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D152B0", Offset = "0x5D146B0", VA = "0x185D152B0")]
	private Guid? IDCKGPFPGMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D15410", Offset = "0x5D14810", VA = "0x185D15410")]
	internal static void JHJFBENHNBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D158B0", Offset = "0x5D14CB0", VA = "0x185D158B0")]
	private void PILDPMBINKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D14E50", Offset = "0x5D14250", VA = "0x185D14E50")]
	[CompilerGenerated]
	private void CIGBFIFNIMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HKHBIHLCEEO
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D15A40", Offset = "0x5D14E40", VA = "0x185D15A40")]
	[DCEDJGMCFCN(IIPPAMCLFBJ.None)]
	private static void PBPAAPNGPLG(BFGBHKPNKEI MIPCMNILFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D15410", Offset = "0x5D14810", VA = "0x185D15410")]
	[LADHGFOOMDP(MEEEIBLMBLE.Unity_BeforeSceneLoad)]
	private static void CMPGCKBMGAN()
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
