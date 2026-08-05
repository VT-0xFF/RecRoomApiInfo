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
	public class LogRegistrationIndex : ONLGCKOFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BA5C70", Offset = "0x7BA4470", VA = "0x187BA5C70", Slot = "4")]
		public override void JNEAPGDNFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BA5DE0", Offset = "0x7BA45E0", VA = "0x187BA5DE0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2612DF0", Offset = "0x26115F0", VA = "0x182612DF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum APGOEALACMH
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
public interface EBAGPIOENCD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NIMBLHJFCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? MPAMLFPPLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? HEAPAFMOHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? DAPOBEBKLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? JJJOEKFAAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	FCHCNNNINOK LLHPHFKPOHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FCIKKKJFIOH(APGOEALACMH LLNIPANPIOA);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NPIOKLMMDIH();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NELGLGGDHLO();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LBOJHGLJJLO(string EEELONGPGHO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<FCHCNNNINOK> KGNHKNCFCJP([Optional] CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ECMCCJKMFMF();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IAEIPGMJDMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GPHDFCMNCJC : EBAGPIOENCD
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private enum BILEFFEINCA
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void HILKGCAIMBG(string AMPMOBIOLAD);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private delegate int NNMNEJPBOCI();

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct GNENCKAAOPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<FCHCNNNINOK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public GPHDFCMNCJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskCompletionSource<FCHCNNNINOK> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter<FCHCNNNINOK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7BA40A0", Offset = "0x7BA28A0", VA = "0x187BA40A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7BA46E0", Offset = "0x7BA2EE0", VA = "0x187BA46E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly LLPKKNNAIAE BAOGIJBMDME;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static GPHDFCMNCJC CHKHGNKGCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly MKLIBFLPPKJ MGGLOLEOKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly OEPOFEFGNLH PDDIDNNDHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly OENJEDALNGL ALIFGIPKJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool ECGEFBLOPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool DFDBGOOGNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool FHLCOLDPOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? EJNHGFLBLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool DLCNDPKFPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? IKEFOODEELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool GFNNIOGIHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? ICHFAKLPAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private APGOEALACMH GDIPCPOLOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly object JMGHKOBDIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Queue<FCHCNNNINOK> OOJBIFBJOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private TaskCompletionSource<FCHCNNNINOK> BODAFBPHOPP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NIMBLHJFCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? MPAMLFPPLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7BA57A0", Offset = "0x7BA3FA0", VA = "0x187BA57A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? HEAPAFMOHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7BA5280", Offset = "0x7BA3A80", VA = "0x187BA5280", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? DAPOBEBKLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BA5530", Offset = "0x7BA3D30", VA = "0x187BA5530", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? JJJOEKFAAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4750", Offset = "0x7BA2F50", VA = "0x187BA4750", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public FCHCNNNINOK LLHPHFKPOHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xBCAEE0", Offset = "0xBC96E0", VA = "0x180BCAEE0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x12B1DD0", Offset = "0x12B05D0", VA = "0x1812B1DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5AF0", Offset = "0x7BA42F0", VA = "0x187BA5AF0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GPHDFCMNCJC([LDAFGEHKDJK(null)] MKLIBFLPPKJ MGGLOLEOKFF, [LDAFGEHKDJK(null)] OEPOFEFGNLH PDDIDNNDHKL, [LDAFGEHKDJK(null)] OENJEDALNGL ALIFGIPKJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5910", Offset = "0x7BA4110", VA = "0x187BA5910", Slot = "11")]
	public void NPIOKLMMDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7BA4880", Offset = "0x7BA3080", VA = "0x187BA4880", Slot = "16")]
	public void CHBBNHLNJJB(string CMILDFDBCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5720", Offset = "0x7BA3F20", VA = "0x187BA5720", Slot = "12")]
	public void NELGLGGDHLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5720", Offset = "0x7BA3F20", VA = "0x187BA5720", Slot = "17")]
	public void PJNKJKLPDLC([Optional] string DHIANGJENMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5720", Offset = "0x7BA3F20", VA = "0x187BA5720", Slot = "13")]
	public void LBOJHGLJJLO(string EEELONGPGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7BA4DC0", Offset = "0x7BA35C0", VA = "0x187BA4DC0", Slot = "10")]
	public void FCIKKKJFIOH(APGOEALACMH LLNIPANPIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7BA4CA0", Offset = "0x7BA34A0", VA = "0x187BA4CA0", Slot = "15")]
	public void ECMCCJKMFMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7BA55C0", Offset = "0x7BA3DC0", VA = "0x187BA55C0", Slot = "14")]
	[AsyncStateMachine(typeof(GNENCKAAOPI))]
	public Task<FCHCNNNINOK> KGNHKNCFCJP(CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7BA4F90", Offset = "0x7BA3790", VA = "0x187BA4F90")]
	private void HFJPAEJNCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5820", Offset = "0x7BA4020", VA = "0x187BA5820")]
	[MonoPInvokeCallback(typeof(HILKGCAIMBG))]
	private static void MENCFENFDCB(string CMILDFDBCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5300", Offset = "0x7BA3B00", VA = "0x187BA5300")]
	[MonoPInvokeCallback(typeof(NNMNEJPBOCI))]
	private static int HPADPNOHBBO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5890", Offset = "0x7BA4090", VA = "0x187BA5890")]
	private void NLNHOIPFEII(string BJOAONJFDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7BA56E0", Offset = "0x7BA3EE0", VA = "0x187BA56E0")]
	private void KNNDEHMNJLA(HILKGCAIMBG NELMOECDPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7BA54F0", Offset = "0x7BA3CF0", VA = "0x187BA54F0")]
	private void JCDHBEOGJED(NNMNEJPBOCI NELMOECDPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5720", Offset = "0x7BA3F20", VA = "0x187BA5720")]
	private void NELGLGGDHLO(BILEFFEINCA NLGEMFKLFCF, string ELFFLBADDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5760", Offset = "0x7BA3F60", VA = "0x187BA5760")]
	private void LBOLIHNLLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5430", Offset = "0x7BA3C30", VA = "0x187BA5430")]
	private long? IGDCCDBFENL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5490", Offset = "0x7BA3C90", VA = "0x187BA5490")]
	private long? IKIGHJCNILH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7BA4810", Offset = "0x7BA3010", VA = "0x187BA4810")]
	private Guid? CDMHBHPMEAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5220", Offset = "0x7BA3A20", VA = "0x187BA5220")]
	private double? HKLDPKFEGHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5360", Offset = "0x7BA3B60", VA = "0x187BA5360")]
	internal static void ICAIDEJIFEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7BA4E10", Offset = "0x7BA3610", VA = "0x187BA4E10")]
	private void HCGJGJBNJIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class EJFCCCLGFFG
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3EA0", Offset = "0x7BA26A0", VA = "0x187BA3EA0")]
	[PJMOOJOMMCC.OJAOBFKEEAO]
	internal static void NBFJIMGACKJ(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3FA0", Offset = "0x7BA27A0", VA = "0x187BA3FA0")]
	[KBINEFBNEHG.IPHNODGJKFI]
	internal static void NIENHLDEKFE()
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
