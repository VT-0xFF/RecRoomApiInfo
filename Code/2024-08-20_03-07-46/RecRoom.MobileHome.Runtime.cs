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
public enum HOKCMHPFCFF
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
public interface ACNGFHOOEDG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AFOBKHEDLFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? CEOIFEIJEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? ANHGBKOELMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? PLIPKPBKGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? BCNMPOHMKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	ABNGIEBHILH LCCBLPAIANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> MPJFEKGOCHA;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PCNIPAALHKE(HOKCMHPFCFF JKKAFCBPEPF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LFNNOPDGNGK();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GMLBDIAHCHN();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NJCNPAILDKO(string OGMBGKKMGPO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CGMCPKIJKKA();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EKGFLEHEHMF
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AFEGDFCHJNO(ABNGIEBHILH DHPBJGGFDOM, [Optional] CancellationToken LABHBAHABKB);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CAMBGALLGEM : ACNGFHOOEDG
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum JIPLLFKDELO
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void BMADHKPKAKK(string DHPBJGGFDOM);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int PJODLEODPPD();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static CAMBGALLGEM KCAPGDAGEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly NLFAAHGJLCJ NKGGNLLFDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly FIGAGNKDKHP GGFKGAEGNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool JCMANHMLPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool OFPNDPBJAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool HHPGJCFNIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool BPMALOKAPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? DMBPHENPBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool LIHODJNMGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? PFGNPPHAOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool HNMDCEGMIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? MBJOFFLLENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private HOKCMHPFCFF HOHOCAHLMHH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool AFOBKHEDLFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? CEOIFEIJEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x69DAA20", Offset = "0x69D9A20", VA = "0x1869DAA20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? ANHGBKOELMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x69DA000", Offset = "0x69D9000", VA = "0x1869DA000", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? PLIPKPBKGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x69D99E0", Offset = "0x69D89E0", VA = "0x1869D99E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? BCNMPOHMKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69D9EF0", Offset = "0x69D8EF0", VA = "0x1869D9EF0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ABNGIEBHILH LCCBLPAIANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x85FB20", Offset = "0x85EB20", VA = "0x18085FB20", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85FB30", Offset = "0x85EB30", VA = "0x18085FB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> MPJFEKGOCHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69DA770", Offset = "0x69D9770", VA = "0x1869DA770", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x69DAB10", Offset = "0x69D9B10", VA = "0x1869DAB10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69D9B50", Offset = "0x69D8B50", VA = "0x1869D9B50")]
	private void DNCBGIMNBPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69DADE0", Offset = "0x69D9DE0", VA = "0x1869DADE0")]
	[Preserve]
	public CAMBGALLGEM([JONIFKKOOAA(null)] NLFAAHGJLCJ NKGGNLLFDPF, [JONIFKKOOAA(null)] FIGAGNKDKHP GGFKGAEGNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x69DA820", Offset = "0x69D9820", VA = "0x1869DA820", Slot = "13")]
	public void LFNNOPDGNGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69D99D0", Offset = "0x69D89D0", VA = "0x1869D99D0", Slot = "16")]
	public void CGMCPKIJKKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69DA0F0", Offset = "0x69D90F0", VA = "0x1869DA0F0", Slot = "17")]
	public void GFIMJDHLFLF(string CNGHMHMFNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69DA2D0", Offset = "0x69D92D0", VA = "0x1869DA2D0", Slot = "14")]
	public void GMLBDIAHCHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69DA840", Offset = "0x69D9840", VA = "0x1869DA840", Slot = "18")]
	public void LHANPJOBFLG([Optional] string OMDLBMMCAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69DABC0", Offset = "0x69D9BC0", VA = "0x1869DABC0", Slot = "15")]
	public void NJCNPAILDKO(string OGMBGKKMGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69DAD10", Offset = "0x69D9D10", VA = "0x1869DAD10", Slot = "12")]
	public void PCNIPAALHKE(HOKCMHPFCFF JKKAFCBPEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69D9BD0", Offset = "0x69D8BD0", VA = "0x1869D9BD0")]
	private void DNMOGMHBNAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69DA900", Offset = "0x69D9900", VA = "0x1869DA900")]
	[MonoPInvokeCallback(typeof(BMADHKPKAKK))]
	private static void MBHOLMMMFIA(string CNGHMHMFNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x69DA370", Offset = "0x69D9370", VA = "0x1869DA370")]
	[MonoPInvokeCallback(typeof(PJODLEODPPD))]
	private static int HHEDGLHBJMP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x69D9AE0", Offset = "0x69D8AE0", VA = "0x1869D9AE0")]
	private void DHIPILJHFJF(string PKJLFKPINLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69DABD0", Offset = "0x69D9BD0", VA = "0x1869DABD0")]
	private void OGFJONMAKPO(BMADHKPKAKK IPCEAEAAIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x69DA470", Offset = "0x69D9470", VA = "0x1869DA470")]
	private void HMBFACIFFFJ(PJODLEODPPD IPCEAEAAIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x69DA2E0", Offset = "0x69D92E0", VA = "0x1869DA2E0")]
	private void GMLBDIAHCHN(JIPLLFKDELO JMFILHLKOGK, string GFJGCAFMICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x69DA6E0", Offset = "0x69D96E0", VA = "0x1869DA6E0")]
	private void LBLJGJCHDJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x69DAC60", Offset = "0x69D9C60", VA = "0x1869DAC60")]
	private long? OJHEDKBAJFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69DA3C0", Offset = "0x69D93C0", VA = "0x1869DA3C0")]
	private long? HJKJCOBABMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x69DA850", Offset = "0x69D9850", VA = "0x1869DA850")]
	private Guid? LOKDECMGDLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x69DA630", Offset = "0x69D9630", VA = "0x1869DA630")]
	private double? KGPKIOJAKJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x69DA960", Offset = "0x69D9960", VA = "0x1869DA960")]
	internal static void MEEPFHENBIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x69DA500", Offset = "0x69D9500", VA = "0x1869DA500")]
	private void IOAJBGDPOPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HJNKKEOEPPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x69DAE80", Offset = "0x69D9E80", VA = "0x1869DAE80")]
	[ONAOIKEPAJE(IKAJKCKEGIH.None)]
	private static void EHAAFPDEPGI(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x69DA960", Offset = "0x69D9960", VA = "0x1869DA960")]
	[JHNEDNDFJPF(JOFJHDAEEPM.Unity_BeforeSceneLoad)]
	private static void LPIABOBDDMI()
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
