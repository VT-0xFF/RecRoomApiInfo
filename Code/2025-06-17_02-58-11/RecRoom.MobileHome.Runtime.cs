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
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DC8DB0", Offset = "0x7DC77B0", VA = "0x187DC8DB0", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DC95D0", Offset = "0x7DC7FD0", VA = "0x187DC95D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HPGGDNFJDJP
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
public interface KPPLOMLAEOO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CJMGFBODDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? JFMDNGJCMFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? MMOIFCHFKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? ICHOJELIFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? CLLICHDEAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	OHNADEGPBEM BOAFNBNOLHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ABJNGFECBIH(HPGGDNFJDJP LOPOEJHIPKN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DBILOAODCDE();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BGPHBDMACGM();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HEDJGGHLINI(string DJGLMHAPDBP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<OHNADEGPBEM> NPCHOJCIJHN([Optional] CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OCIDDBBEABK();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KKNCHIJFDCE
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BLHGKCBPHEF : KPPLOMLAEOO
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private enum LBCCGADEMGL
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void EAOCJHMMILH(string EEELFJPGFBJ);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private delegate int BMIAHONLCMM();

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct OPPJHMKJEMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<OHNADEGPBEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public BLHGKCBPHEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskCompletionSource<OHNADEGPBEM> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter<OHNADEGPBEM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7DC8E40", Offset = "0x7DC7840", VA = "0x187DC8E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7DC9480", Offset = "0x7DC7E80", VA = "0x187DC9480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly COJJKFBGGKB NLLEOCMFOCP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static BLHGKCBPHEF NMGHOHCNINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly NDICJCLBPMH CAKGJHFCICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly OPEDNILAGEF EAJOJDHHGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly AGOOMDFKBHO JEOAMINEGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool PKODEGPKGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool EBKDIHIPMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool FEEFJCDPHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? OHIOAPBCKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool KJGFMBOMJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? IFLHDJALHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool CFEBHPLCIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? EKCPDCOJNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private HPGGDNFJDJP CCAODOPMCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly object HKHMJGHKFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Queue<OHNADEGPBEM> JAPPHDFOJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private TaskCompletionSource<OHNADEGPBEM> GPPNDKINBMP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool CJMGFBODDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? JFMDNGJCMFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7DC7DD0", Offset = "0x7DC67D0", VA = "0x187DC7DD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? MMOIFCHFKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7DC7C30", Offset = "0x7DC6630", VA = "0x187DC7C30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? ICHOJELIFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7DC7770", Offset = "0x7DC6170", VA = "0x187DC7770", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? CLLICHDEAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7DC7CB0", Offset = "0x7DC66B0", VA = "0x187DC7CB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public OHNADEGPBEM BOAFNBNOLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA6E210", Offset = "0xA6CC10", VA = "0x180A6E210", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA6B540", Offset = "0xA69F40", VA = "0x180A6B540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8A40", Offset = "0x7DC7440", VA = "0x187DC8A40")]
	[RecRoom.NoEngine.Common.Preserve]
	public BLHGKCBPHEF([CNHMBDDCGKB(null)] NDICJCLBPMH CAKGJHFCICK, [CNHMBDDCGKB(null)] OPEDNILAGEF EAJOJDHHGBI, [CNHMBDDCGKB(null)] AGOOMDFKBHO JEOAMINEGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7940", Offset = "0x7DC6340", VA = "0x187DC7940", Slot = "11")]
	public void DBILOAODCDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8180", Offset = "0x7DC6B80", VA = "0x187DC8180", Slot = "16")]
	public void JFKBJGBKFMB(string NHMDGMFGHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC76F0", Offset = "0x7DC60F0", VA = "0x187DC76F0", Slot = "12")]
	public void BGPHBDMACGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC76F0", Offset = "0x7DC60F0", VA = "0x187DC76F0", Slot = "17")]
	public void BMMHLALCBLE([Optional] string FMLPCLBKFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC76F0", Offset = "0x7DC60F0", VA = "0x187DC76F0", Slot = "13")]
	public void HEDJGGHLINI(string DJGLMHAPDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC76A0", Offset = "0x7DC60A0", VA = "0x187DC76A0", Slot = "10")]
	public void ABJNGFECBIH(HPGGDNFJDJP LOPOEJHIPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC88B0", Offset = "0x7DC72B0", VA = "0x187DC88B0", Slot = "15")]
	public void OCIDDBBEABK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8790", Offset = "0x7DC7190", VA = "0x187DC8790", Slot = "14")]
	[AsyncStateMachine(typeof(OPPJHMKJEMF))]
	public Task<OHNADEGPBEM> NPCHOJCIJHN(CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7EF0", Offset = "0x7DC68F0", VA = "0x187DC7EF0")]
	private void JEBGPHGENFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7DC78D0", Offset = "0x7DC62D0", VA = "0x187DC78D0")]
	[MonoPInvokeCallback(typeof(EAOCJHMMILH))]
	private static void CPFMDDLJFEA(string NHMDGMFGHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7800", Offset = "0x7DC6200", VA = "0x187DC7800")]
	[MonoPInvokeCallback(typeof(BMIAHONLCMM))]
	private static int CNLFHCBABNE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DC86B0", Offset = "0x7DC70B0", VA = "0x187DC86B0")]
	private void KCGLBDBKCLO(string NHDAAMPGHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7E50", Offset = "0x7DC6850", VA = "0x187DC7E50")]
	private void IHEJPOHKPPI(EAOCJHMMILH DMDJELFGCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7730", Offset = "0x7DC6130", VA = "0x187DC7730")]
	private void BHEOBHHBGEP(BMIAHONLCMM DMDJELFGCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7DC76F0", Offset = "0x7DC60F0", VA = "0x187DC76F0")]
	private void BGPHBDMACGM(LBCCGADEMGL CHGJGNFMEJJ, string FFIFOKINEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7DC85A0", Offset = "0x7DC6FA0", VA = "0x187DC85A0")]
	private void JNJEJEMIODL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7E90", Offset = "0x7DC6890", VA = "0x187DC7E90")]
	private long? IJAEANLFKIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7D70", Offset = "0x7DC6770", VA = "0x187DC7D70")]
	private long? GNCAGHOAMGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7860", Offset = "0x7DC6260", VA = "0x187DC7860")]
	private Guid? COLJKDNKPEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8730", Offset = "0x7DC7130", VA = "0x187DC8730")]
	private double? LKMNMHKLOND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC85E0", Offset = "0x7DC6FE0", VA = "0x187DC85E0")]
	internal static void JOJJIECKEML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7AB0", Offset = "0x7DC64B0", VA = "0x187DC7AB0")]
	private void GFKGLDPPGHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GFCKGNECEOL
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8CC0", Offset = "0x7DC76C0", VA = "0x187DC8CC0")]
	[CGLGNCLDKHN.CKJOAALDIOP]
	internal static void PKGIHPLBPEI(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8BC0", Offset = "0x7DC75C0", VA = "0x187DC8BC0")]
	[HHPMDADMJLL.MBALOIBONAL]
	internal static void MCCNGCNNCFH()
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
