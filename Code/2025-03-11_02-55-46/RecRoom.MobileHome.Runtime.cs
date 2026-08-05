using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_MobileHome_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : KENHJELJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7660390", Offset = "0x765F790", VA = "0x187660390", Slot = "4")]
		public override void ICLMLJMBJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_MobileHome_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7661A20", Offset = "0x7660E20", VA = "0x187661A20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2491CF0", Offset = "0x24910F0", VA = "0x182491CF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum PGCKDNAHHJK
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
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JCBBFCLKCFP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HKCIJDIIJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? DNOJKFACNBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? DCHBMEBKIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? PAMFHKJGAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? JHFLPKCILJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	EPMPMINPGPF OCFMBIPAACL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LHFFDOIEMCF(PGCKDNAHHJK MLIDEILJAJE);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OBBALIPJEND();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FIKGPLGJPKI();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HMGDPALMEFO(string IFKPMNDGIBE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<EPMPMINPGPF> KMNEJJENGMD([Optional] CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HFDLDPDHCFJ();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AAOPIOCDAMH
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class PLDBOFFJOIG : JCBBFCLKCFP
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private enum IMPCALMOFBC
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void DFJCKBDCGAM(string POHDLOHEIEB);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private delegate int IGCBAEMNNBL();

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct BMBIIHGFGLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<EPMPMINPGPF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public PLDBOFFJOIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskCompletionSource<EPMPMINPGPF> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter<EPMPMINPGPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x765FAF0", Offset = "0x765EEF0", VA = "0x18765FAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7660130", Offset = "0x765F530", VA = "0x187660130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly HLBHMADGLFA COHAOGFFGHO;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static PLDBOFFJOIG HCADPGAHONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HKNCEKAFBLB LBNAMGPBCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EHMJCCEKJHN CIBOJIKFCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly BKJMAIOCHPI GCPKGLCAIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool MINJEGBCBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool AFMIMILEMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool HKPKBAKKAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? JLPPOIEFOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool IEHAODINMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? FFHCGPBENKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool FFFAHKJIANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? CNEBAEKBMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private PGCKDNAHHJK CAGEGJKGNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly object MIPNLEKANJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Queue<EPMPMINPGPF> EHPJOCAHKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private TaskCompletionSource<EPMPMINPGPF> GKBGDJBJPMD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool HKCIJDIIJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? DNOJKFACNBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7661370", Offset = "0x7660770", VA = "0x187661370", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? DCHBMEBKIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7660BD0", Offset = "0x765FFD0", VA = "0x187660BD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? PAMFHKJGAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7661550", Offset = "0x7660950", VA = "0x187661550", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? JHFLPKCILJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7660420", Offset = "0x765F820", VA = "0x187660420", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public EPMPMINPGPF OCFMBIPAACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xACC560", Offset = "0xACB960", VA = "0x180ACC560", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1179AC0", Offset = "0x1178EC0", VA = "0x181179AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x76617C0", Offset = "0x7660BC0", VA = "0x1876617C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public PLDBOFFJOIG([PNFCCJKFMBH(null)] HKNCEKAFBLB LBNAMGPBCAE, [PNFCCJKFMBH(null)] EHMJCCEKJHN CIBOJIKFCJN, [PNFCCJKFMBH(null)] BKJMAIOCHPI GCPKGLCAIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x76615E0", Offset = "0x76609E0", VA = "0x1876615E0", Slot = "11")]
	public void OBBALIPJEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7660520", Offset = "0x765F920", VA = "0x187660520", Slot = "16")]
	public void CALJMMMGADA(string KHLDHLKIDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7660D10", Offset = "0x7660110", VA = "0x187660D10", Slot = "12")]
	public void FIKGPLGJPKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7660D10", Offset = "0x7660110", VA = "0x187660D10", Slot = "17")]
	public void FNFLJIGDDPL([Optional] string BONFDILPNOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7660D10", Offset = "0x7660110", VA = "0x187660D10", Slot = "13")]
	public void HMGDPALMEFO(string IFKPMNDGIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7661450", Offset = "0x7660850", VA = "0x187661450", Slot = "10")]
	public void LHFFDOIEMCF(PGCKDNAHHJK MLIDEILJAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7661000", Offset = "0x7660400", VA = "0x187661000", Slot = "15")]
	public void HFDLDPDHCFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7661250", Offset = "0x7660650", VA = "0x187661250", Slot = "14")]
	[AsyncStateMachine(typeof(BMBIIHGFGLM))]
	public Task<EPMPMINPGPF> KMNEJJENGMD(CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7660940", Offset = "0x765FD40", VA = "0x187660940")]
	private void DKJMPFGEGPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x76614A0", Offset = "0x76608A0", VA = "0x1876614A0")]
	[MonoPInvokeCallback(typeof(DFJCKBDCGAM))]
	private static void LKMIKDAELOG(string KHLDHLKIDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7660ED0", Offset = "0x76602D0", VA = "0x187660ED0")]
	[MonoPInvokeCallback(typeof(IGCBAEMNNBL))]
	private static int GBEADDDLFBC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7661160", Offset = "0x7660560", VA = "0x187661160")]
	private void IOBPHIDFFHA(string KOPLHBMBIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7661120", Offset = "0x7660520", VA = "0x187661120")]
	private void IEMPDAMNIOM(DFJCKBDCGAM LOGLEICCEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7661510", Offset = "0x7660910", VA = "0x187661510")]
	private void LPNEDPJDMBI(IGCBAEMNNBL LOGLEICCEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7660D10", Offset = "0x7660110", VA = "0x187660D10")]
	private void FIKGPLGJPKI(IMPCALMOFBC BBAJBLJIPLG, string BAGDCJMHGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x76604E0", Offset = "0x765F8E0", VA = "0x1876604E0")]
	private void BAOBINCNLAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7660C50", Offset = "0x7660050", VA = "0x187660C50")]
	private long? DNFJPLBMKJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x76613F0", Offset = "0x76607F0", VA = "0x1876613F0")]
	private long? LCLNCGFMGNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x76611E0", Offset = "0x76605E0", VA = "0x1876611E0")]
	private Guid? KBNNJCOJJAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7660CB0", Offset = "0x76600B0", VA = "0x187660CB0")]
	private double? FCLJJEMFEKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7660F30", Offset = "0x7660330", VA = "0x187660F30")]
	internal static void GPKEIOJGLJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7660D50", Offset = "0x7660150", VA = "0x187660D50")]
	private void FKHDJLHECNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GMOINHEMKPG
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x76601A0", Offset = "0x765F5A0", VA = "0x1876601A0")]
	[AEDFFNEEAKJ.AMNMLEGDOCC]
	internal static void CONODCJLAKA(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7660290", Offset = "0x765F690", VA = "0x187660290")]
	[BOHPIAAADDL.CCCKKBFCOMP]
	internal static void EMNIKBIIBFA()
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
