using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_MobileHome_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PFMKOBANMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F17000", Offset = "0x6F16000", VA = "0x186F17000", Slot = "8")]
		public override void NCHGKCJDJHF(GLGFPKOIELC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6565350", Offset = "0x6564350", VA = "0x186565350")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum OBJLCNDIHEP
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
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FLHGBJJPBMI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DMJBCHMPEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? NPDNIEHGGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? BAPEJDBDJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? GNGCMDFAKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? PCGHIGPDFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IBNHPEBGKBE MMNPBIAIPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> LHHJBIGLEOB;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DHBNOKNLALF(OBJLCNDIHEP LNHGKEAKACI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CPDDJGLEDNE();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DPNMHFFGMNP();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HHKDKJINDGA(string JPPIGCHNINA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void APIJKEPFGNJ();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ANNCABEJPKH
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NJCGADPMHNO(IBNHPEBGKBE NDCAJIOOANK, [Optional] CancellationToken CLIKNEKJHEI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OILGNPKMMBF : FLHGBJJPBMI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private enum BHNPDONPAEH
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void FDFDKGPKPDC(string NDCAJIOOANK);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate int KCEIOGLBBAA();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static OILGNPKMMBF DKOIJBOMAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly NIFDEMPMOFN BPOONMHGPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly GPDKLGMMOKA KBFHKAAONMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool CFIPCMPJOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool BGCJNKJIMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool AJIGPBMNFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool ELDEGKJGNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? MKAPKOOEGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool FELPHGBKMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? GEKJABOCDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool CKCNAMCOAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? JEALOGDJPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private OBJLCNDIHEP KDLLANAJDPH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool DMJBCHMPEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? NPDNIEHGGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F15D30", Offset = "0x6F14D30", VA = "0x186F15D30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? BAPEJDBDJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6F162C0", Offset = "0x6F152C0", VA = "0x186F162C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? GNGCMDFAKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F16780", Offset = "0x6F15780", VA = "0x186F16780", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? PCGHIGPDFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6F15C10", Offset = "0x6F14C10", VA = "0x186F15C10", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IBNHPEBGKBE MMNPBIAIPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8B81A0", Offset = "0x8B71A0", VA = "0x1808B81A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8B8320", Offset = "0x8B7320", VA = "0x1808B8320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> LHHJBIGLEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F16200", Offset = "0x6F15200", VA = "0x186F16200", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F16150", Offset = "0x6F15150", VA = "0x186F16150", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F15ED0", Offset = "0x6F14ED0", VA = "0x186F15ED0")]
	private void DGPFAGBAFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F16F60", Offset = "0x6F15F60", VA = "0x186F16F60")]
	[RecRoom.NoEngine.Common.Preserve]
	public OILGNPKMMBF([GAHPILLNNBL(null)] NIFDEMPMOFN BPOONMHGPCO, [GAHPILLNNBL(null)] GPDKLGMMOKA KBFHKAAONMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F15EB0", Offset = "0x6F14EB0", VA = "0x186F15EB0", Slot = "13")]
	public void CPDDJGLEDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6F15D20", Offset = "0x6F14D20", VA = "0x186F15D20", Slot = "16")]
	public void APIJKEPFGNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6F16CB0", Offset = "0x6F15CB0", VA = "0x186F16CB0", Slot = "17")]
	public void NLPHOGCDHHB(string GDKHICLDMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6F16140", Offset = "0x6F15140", VA = "0x186F16140", Slot = "14")]
	public void DPNMHFFGMNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F16880", Offset = "0x6F15880", VA = "0x186F16880", Slot = "18")]
	public void MNGPNPBOFOH([Optional] string IHIAFFLLJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F162B0", Offset = "0x6F152B0", VA = "0x186F162B0", Slot = "15")]
	public void HHKDKJINDGA(string JPPIGCHNINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6F15F50", Offset = "0x6F14F50", VA = "0x186F15F50", Slot = "12")]
	public void DHBNOKNLALF(OBJLCNDIHEP LNHGKEAKACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F168E0", Offset = "0x6F158E0", VA = "0x186F168E0")]
	private void NDPBCNCPEHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F16890", Offset = "0x6F15890", VA = "0x186F16890")]
	[MonoPInvokeCallback(typeof(FDFDKGPKPDC))]
	private static void MOJLBEEHHMD(string GDKHICLDMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6F166A0", Offset = "0x6F156A0", VA = "0x186F166A0")]
	[MonoPInvokeCallback(typeof(KCEIOGLBBAA))]
	private static int JBLAELEMGHG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6F16580", Offset = "0x6F15580", VA = "0x186F16580")]
	private void IOPNBPEPLDB(string AEBOAKBIPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6F15E20", Offset = "0x6F14E20", VA = "0x186F15E20")]
	private void CCFIKPNLACB(FDFDKGPKPDC BLNJHEMNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6F166F0", Offset = "0x6F156F0", VA = "0x186F166F0")]
	private void KLKKIMOBEMM(KCEIOGLBBAA BLNJHEMNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6F160B0", Offset = "0x6F150B0", VA = "0x186F160B0")]
	private void DPNMHFFGMNP(BHNPDONPAEH BMAADIIMEEA, string BEGBOECIAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F16020", Offset = "0x6F15020", VA = "0x186F16020")]
	private void DNPJFMOCGCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F16C00", Offset = "0x6F15C00", VA = "0x186F16C00")]
	private long? NEACPJJMDHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6F165F0", Offset = "0x6F155F0", VA = "0x186F165F0")]
	private long? JBEEBLLMGNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F164D0", Offset = "0x6F154D0", VA = "0x186F164D0")]
	private Guid? ILIGPCPPHKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6F16EB0", Offset = "0x6F15EB0", VA = "0x186F16EB0")]
	private double? PPCGAFAIIHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F15B50", Offset = "0x6F14B50", VA = "0x186F15B50")]
	internal static void NLKBEDOCAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F163B0", Offset = "0x6F153B0", VA = "0x186F163B0")]
	private void IHLIFDNGNCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FLJPNOCCHBM
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6F15A50", Offset = "0x6F14A50", VA = "0x186F15A50")]
	[AEDCCIMPEFD.GIGKNHONDJE]
	internal static void AANLPAMKFCI(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6F15B50", Offset = "0x6F14B50", VA = "0x186F15B50")]
	[GMOOIMKJNLJ.LMIOIOHLELG]
	internal static void KAOBIPEADIO()
	{
	}
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
