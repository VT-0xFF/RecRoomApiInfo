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
	public class LogRegistrationIndex : IMPGLFODBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7061C50", Offset = "0x7061050", VA = "0x187061C50", Slot = "4")]
		public override void EMOBGIHOLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7063510", Offset = "0x7062910", VA = "0x187063510", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum NEECKBPLJKJ
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
public interface EKBADNMCBAN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ALNLPPALCGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? BALKCIKPMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? MEHDKJOOKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? OIHEIJGLFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? HMAGAHGBJEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	BKPAEFDIMCK GMDOACOLBAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> EEINKEFNLID;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KKGKCOFMHGO(NEECKBPLJKJ MPLALBADMNL);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OOJJEJPOBFE();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GDFBKCCBFMK();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ODLKDCENKLM(string PFKGJDDEPJK);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JOPAEBIHEFK();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<BKPAEFDIMCK> OHMBIPHLKHK([Optional] CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GIIDCEKOMFK
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task IEILDODLCAG(BKPAEFDIMCK GBNJPBGLBGJ, [Optional] CancellationToken FHGIOBPPFHG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MEGGMHBLEHG : EKBADNMCBAN
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private enum LIKGMMGFJOC
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void NOKLHKKLPNM(string GBNJPBGLBGJ);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private delegate int ALKEJDKDFPO();

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct JLCNFAENFPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<BKPAEFDIMCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public MEGGMHBLEHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskCompletionSource<BKPAEFDIMCK> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<BKPAEFDIMCK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x70615A0", Offset = "0x70609A0", VA = "0x1870615A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7061BE0", Offset = "0x7060FE0", VA = "0x187061BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly GKOKEEMOOFG LDCMEBNGNBB;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static MEGGMHBLEHG JHHLONNMNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly PBMDMFNAGKG CIFOJJAKJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly ELDCPMFDOPF FOOKADLJLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly CIAOODONNGG CBKLIAEFLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool JKJJHKAOIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool OBFIKNCOIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool BCMMHBAKODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool JCJBPMMDBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? JGNEFANHJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool HGKMICKFNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private long? DPBDDLLEGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private bool PDMPMAPBNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Guid? NAPILHMHNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private NEECKBPLJKJ IHILIMMBFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly object BHDOHIDAGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Queue<BKPAEFDIMCK> ILAMBNMOGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private TaskCompletionSource<BKPAEFDIMCK> BOHDIJDGONE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool ALNLPPALCGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? BALKCIKPMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7062260", Offset = "0x7061660", VA = "0x187062260", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? MEHDKJOOKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7061F80", Offset = "0x7061380", VA = "0x187061F80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? OIHEIJGLFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7061CE0", Offset = "0x70610E0", VA = "0x187061CE0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? HMAGAHGBJEN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7061E20", Offset = "0x7061220", VA = "0x187061E20", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public BKPAEFDIMCK GMDOACOLBAG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB40", Offset = "0x8CEF40", VA = "0x1808CFB40", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB70", Offset = "0x8CEF70", VA = "0x1808CFB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> EEINKEFNLID
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7062000", Offset = "0x7061400", VA = "0x187062000", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7061D70", Offset = "0x7061170", VA = "0x187061D70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x70623A0", Offset = "0x70617A0", VA = "0x1870623A0")]
	private void JOCADDDCPFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x70632B0", Offset = "0x70626B0", VA = "0x1870632B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public MEGGMHBLEHG([CNGCCDLPGOD(null)] PBMDMFNAGKG CIFOJJAKJJE, [CNGCCDLPGOD(null)] ELDCPMFDOPF FOOKADLJLBI, [CNGCCDLPGOD(null)] CIAOODONNGG CBKLIAEFLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7062E80", Offset = "0x7062280", VA = "0x187062E80", Slot = "13")]
	public void OOJJEJPOBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7062420", Offset = "0x7061820", VA = "0x187062420", Slot = "16")]
	public void JOPAEBIHEFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x70628E0", Offset = "0x7061CE0", VA = "0x1870628E0", Slot = "18")]
	public void NBNGDAJOCPI(string BIKEOAKOLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7061F40", Offset = "0x7061340", VA = "0x187061F40", Slot = "14")]
	public void GDFBKCCBFMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7061F40", Offset = "0x7061340", VA = "0x187061F40", Slot = "19")]
	public void CHFDGPMOPMH([Optional] string FBMJIEMPGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7061F40", Offset = "0x7061340", VA = "0x187061F40", Slot = "15")]
	public void ODLKDCENKLM(string PFKGJDDEPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7062470", Offset = "0x7061870", VA = "0x187062470", Slot = "12")]
	public void KKGKCOFMHGO(NEECKBPLJKJ MPLALBADMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7062D60", Offset = "0x7062160", VA = "0x187062D60", Slot = "17")]
	[AsyncStateMachine(typeof(JLCNFAENFPO))]
	public Task<BKPAEFDIMCK> OHMBIPHLKHK(CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7062610", Offset = "0x7061A10", VA = "0x187062610")]
	private void LCBBDHDMEPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x70620B0", Offset = "0x70614B0", VA = "0x1870620B0")]
	[MonoPInvokeCallback(typeof(NOKLHKKLPNM))]
	private static void GFJFHCHFIBO(string BIKEOAKOLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7061EE0", Offset = "0x70612E0", VA = "0x187061EE0")]
	[MonoPInvokeCallback(typeof(ALKEJDKDFPO))]
	private static int CFPKIBDAHCK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7063180", Offset = "0x7062580", VA = "0x187063180")]
	private void PMHLPCPAJEA(string BOEDBMNLCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x70628A0", Offset = "0x7061CA0", VA = "0x1870628A0")]
	private void LIPNJCCPHPP(NOKLHKKLPNM CPIKECCHPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7062430", Offset = "0x7061830", VA = "0x187062430")]
	private void KBNEIFFMEPP(ALKEJDKDFPO CPIKECCHPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7061F40", Offset = "0x7061340", VA = "0x187061F40")]
	private void GDFBKCCBFMK(LIKGMMGFJOC OCIFOIBHPJJ, string KMMOFBAEHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7063200", Offset = "0x7062600", VA = "0x187063200")]
	private void POJLFECFJKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x70622E0", Offset = "0x70616E0", VA = "0x1870622E0")]
	private long? JKOEEAGKIKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7062340", Offset = "0x7061740", VA = "0x187062340")]
	private long? JLCHBHFCGFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x70621F0", Offset = "0x70615F0", VA = "0x1870621F0")]
	private Guid? IGCFMPOMLEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7063120", Offset = "0x7062520", VA = "0x187063120")]
	private double? PLLKBIJOOCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7062120", Offset = "0x7061520", VA = "0x187062120")]
	internal static void HLFFLCILNKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7062FA0", Offset = "0x70623A0", VA = "0x187062FA0")]
	private void PIIPPLGGPHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CJMFFDIJDBM
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x70614B0", Offset = "0x70608B0", VA = "0x1870614B0")]
	[AGCFNMIICNN.OGAOPBBDHOG]
	internal static void IPMBADGOCPB(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x70613B0", Offset = "0x70607B0", VA = "0x1870613B0")]
	[FEALGOFKPAD.NCEOPNKGCMA]
	internal static void IEPNBOKMEGN()
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
