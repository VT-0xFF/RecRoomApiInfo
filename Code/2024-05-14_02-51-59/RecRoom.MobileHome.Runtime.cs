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
public enum IMAMIHMHNBP
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
	PlayerCustomization = 34,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	RoomLoading = 64,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	InOrientation = 65,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	InDorm = 66,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	InRoom = 67,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	InEvent = 68,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Logout = 128,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	ExitingClient = 129
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OPNJPNNHMOP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BMIMIMLPBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? PFALOEHMCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? GEADLJJLFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? MGIGCBGEEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? DPPDNFPECBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	DNCAMNFMAKH FMMDDHPJNDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> MNLIKEBFFFO;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DGEJNHBGKNA(IMAMIHMHNBP MLJADEFEEPB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MPOMBMILLLK();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DPGEJGIPIBA();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BAAOIMJLNLG(string ILKDLNCOGIL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AOELLFNMKIM();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FPEBIFGELCA
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ELFAEOAOEPH(DNCAMNFMAKH NNABMNLNJGH, [Optional] CancellationToken CFAFANOFDNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AOBOBGEAAPK : OPNJPNNHMOP
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum NBNJGGHHCJH
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void JGFLFLLGOFD(string NNABMNLNJGH);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int LPKFAGOGAPB();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static AOBOBGEAAPK CCFMNFKDGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly PNBPIKBDKFG CCCIPJLEGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool FGAGGOADMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool ENMCBOCEAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool FCFPAJCJGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool FKDPGNBNCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private long? PFGJPJHDAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool MDBLNKNBHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private long? APNNLKLNCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool KFEHMJDEPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Guid? PAHBEFJEAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private IMAMIHMHNBP BPNKIAJNOAE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool BMIMIMLPBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? PFALOEHMCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6396260", Offset = "0x6394C60", VA = "0x186396260", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? GEADLJJLFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6396600", Offset = "0x6395000", VA = "0x186396600", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? MGIGCBGEEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6395F40", Offset = "0x6394940", VA = "0x186395F40", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? DPPDNFPECBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x63966F0", Offset = "0x63950F0", VA = "0x1863966F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public DNCAMNFMAKH FMMDDHPJNDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C68D0", Offset = "0x7C52D0", VA = "0x1807C68D0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C6900", Offset = "0x7C5300", VA = "0x1807C6900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> MNLIKEBFFFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6395E90", Offset = "0x6394890", VA = "0x186395E90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6396040", Offset = "0x6394A40", VA = "0x186396040", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6395AF0", Offset = "0x63944F0", VA = "0x186395AF0")]
	private void DPHLBCOEIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6396C60", Offset = "0x6395660", VA = "0x186396C60")]
	[Preserve]
	public AOBOBGEAAPK([JDJLHBHAJCP(null)] PNBPIKBDKFG CCCIPJLEGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6396B10", Offset = "0x6395510", VA = "0x186396B10", Slot = "13")]
	public void MPOMBMILLLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6395860", Offset = "0x6394260", VA = "0x186395860", Slot = "16")]
	public void AOELLFNMKIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x63963B0", Offset = "0x6394DB0", VA = "0x1863963B0", Slot = "17")]
	public void IHFACGAFLPP(string GKIDBJDLFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6395A50", Offset = "0x6394450", VA = "0x186395A50", Slot = "14")]
	public void DPGEJGIPIBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6396C50", Offset = "0x6395650", VA = "0x186396C50", Slot = "18")]
	public void OINFAACDKEA([Optional] string LHOPJIGCDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6395870", Offset = "0x6394270", VA = "0x186395870", Slot = "15")]
	public void BAAOIMJLNLG(string ILKDLNCOGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6395980", Offset = "0x6394380", VA = "0x186395980", Slot = "12")]
	public void DGEJNHBGKNA(IMAMIHMHNBP MLJADEFEEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6395B70", Offset = "0x6394570", VA = "0x186395B70")]
	private void FBBLNABNCEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6396350", Offset = "0x6394D50", VA = "0x186396350")]
	[MonoPInvokeCallback(typeof(JGFLFLLGOFD))]
	private static void HNKGNBKLGLC(string GKIDBJDLFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6395930", Offset = "0x6394330", VA = "0x186395930")]
	[MonoPInvokeCallback(typeof(LPKFAGOGAPB))]
	private static int DDKCLHEEIKE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6396590", Offset = "0x6394F90", VA = "0x186396590")]
	private void IJFAGCOELOO(string BBDEMJDGKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6396890", Offset = "0x6395290", VA = "0x186396890")]
	private void LBJPBEKIBON(JGFLFLLGOFD JNDJHGKPENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6396800", Offset = "0x6395200", VA = "0x186396800")]
	private void JONGBELGLCH(LPKFAGOGAPB JNDJHGKPENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6395A60", Offset = "0x6394460", VA = "0x186395A60")]
	private void DPGEJGIPIBA(NBNJGGHHCJH FKOGKDPANPE, string ODMHLCFFLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x63969D0", Offset = "0x63953D0", VA = "0x1863969D0")]
	private void MHGGADNBBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6396A60", Offset = "0x6395460", VA = "0x186396A60")]
	private long? MHKBMJLGDPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x63961B0", Offset = "0x6394BB0", VA = "0x1863961B0")]
	private long? HHMOMFOJOAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6395880", Offset = "0x6394280", VA = "0x186395880")]
	private Guid? DBNOPBLEPAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6396920", Offset = "0x6395320", VA = "0x186396920")]
	private double? LEPNKJPEOPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x63960F0", Offset = "0x6394AF0", VA = "0x1863960F0")]
	internal static void GFBKPLABJMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6396B30", Offset = "0x6395530", VA = "0x186396B30")]
	private void NJMBCFHCBEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MJLKNEIKMCI
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6396CE0", Offset = "0x63956E0", VA = "0x186396CE0")]
	[JCOMPLNHMEG(AOHDMBIABEL.None)]
	private static void PCICJDLANGM(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x63960F0", Offset = "0x6394AF0", VA = "0x1863960F0")]
	[APKIKNFAKCC(HAIMIFDEJBI.Unity_BeforeSceneLoad)]
	private static void EIKOBOLKBNE()
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
