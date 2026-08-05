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
	public class LogRegistrationIndex : CGFLIBNDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72EDCF0", Offset = "0x72ECAF0", VA = "0x1872EDCF0", Slot = "4")]
		public override void EHDMJEMLBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72EDE70", Offset = "0x72ECC70", VA = "0x1872EDE70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JFFGOMLIGFF
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
public interface JMNMNNGMOGK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NKADHKIEKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? IEKBFCLLLAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? PKOIGIKMGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? EFMMNOIBMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? EDAPGNKBCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	NGNHBPMDKFA CLEIKMDGBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DBPMGOBJLJA(JFFGOMLIGFF DKNLFDPIIII);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JEELJGCJJCO();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GNJHEICBOEH();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IAPBPEDJKEM(string PGIAAHGDEIH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<NGNHBPMDKFA> PBMIKIPAGJE([Optional] CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HNIDPCAHGHB();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LHDHBMADEGN
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OHBKCLDAIHH(NGNHBPMDKFA FHHJCHPLOFO, [Optional] CancellationToken FEHCANHDGHE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class LNGNMGHMMNP : JMNMNNGMOGK
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private enum HKHFNPLPHKE
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void OLIHFDAGBEC(string FHHJCHPLOFO);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private delegate int ONDJCPDDFBB();

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct AIONICEBCOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<NGNHBPMDKFA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public LNGNMGHMMNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskCompletionSource<NGNHBPMDKFA> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter<NGNHBPMDKFA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x72EBF00", Offset = "0x72EAD00", VA = "0x1872EBF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x72EC540", Offset = "0x72EB340", VA = "0x1872EC540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly IMOCAMGHNDM KAMAHCNLDOK;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static LNGNMGHMMNP PMGDCKPCODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly JGLLKCGMCOF HINHBOEEECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly ACMBNDJDLEG FBALLOOIDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly EAFPFOIDFDM NHKPGNJAOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool AJBNHKFNEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool KCMFPDEHACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool ECAENJIKPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? FKANGEADEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool ACJCMMFEIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? DBAKMDFGGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool APOGLBEFCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? PMNMLDLMBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private JFFGOMLIGFF FOICJDIIJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly object NJJCIFNGPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Queue<NGNHBPMDKFA> JNOKBIJKEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private TaskCompletionSource<NGNHBPMDKFA> FAFLAELEFAB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NKADHKIEKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? IEKBFCLLLAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72EC990", Offset = "0x72EB790", VA = "0x1872EC990", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? PKOIGIKMGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x72EC640", Offset = "0x72EB440", VA = "0x1872EC640", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? EFMMNOIBMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x72EC820", Offset = "0x72EB620", VA = "0x1872EC820", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? EDAPGNKBCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x72EC6C0", Offset = "0x72EB4C0", VA = "0x1872EC6C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public NGNHBPMDKFA CLEIKMDGBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA9F410", Offset = "0xA9E210", VA = "0x180A9F410", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1133CC0", Offset = "0x1132AC0", VA = "0x181133CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x72ED980", Offset = "0x72EC780", VA = "0x1872ED980")]
	[RecRoom.NoEngine.Common.Preserve]
	public LNGNMGHMMNP([MHFJPMCEEAM(null)] JGLLKCGMCOF HINHBOEEECM, [MHFJPMCEEAM(null)] ACMBNDJDLEG FBALLOOIDLL, [MHFJPMCEEAM(null)] EAFPFOIDFDM NHKPGNJAOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x72ECE80", Offset = "0x72EBC80", VA = "0x1872ECE80", Slot = "11")]
	public void JEELJGCJJCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x72ED060", Offset = "0x72EBE60", VA = "0x1872ED060", Slot = "16")]
	public void MBJKKMKNFLP(string CMHLCIPPLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x72EC7E0", Offset = "0x72EB5E0", VA = "0x1872EC7E0", Slot = "12")]
	public void GNJHEICBOEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x72EC7E0", Offset = "0x72EB5E0", VA = "0x1872EC7E0", Slot = "17")]
	public void MJEMPHAHMAF([Optional] string IIGNNKAGLEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x72EC7E0", Offset = "0x72EB5E0", VA = "0x1872EC7E0", Slot = "13")]
	public void IAPBPEDJKEM(string PGIAAHGDEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x72EC5B0", Offset = "0x72EB3B0", VA = "0x1872EC5B0", Slot = "10")]
	public void DBPMGOBJLJA(JFFGOMLIGFF DKNLFDPIIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x72ECA10", Offset = "0x72EB810", VA = "0x1872ECA10", Slot = "15")]
	public void HNIDPCAHGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x72ED790", Offset = "0x72EC590", VA = "0x1872ED790", Slot = "14")]
	[AsyncStateMachine(typeof(AIONICEBCOK))]
	public Task<NGNHBPMDKFA> PBMIKIPAGJE(CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x72ECBF0", Offset = "0x72EB9F0", VA = "0x1872ECBF0")]
	private void IKNELFJPBGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x72ED490", Offset = "0x72EC290", VA = "0x1872ED490")]
	[MonoPInvokeCallback(typeof(OLIHFDAGBEC))]
	private static void MHEPAPAMMJK(string CMHLCIPPLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x72ED8B0", Offset = "0x72EC6B0", VA = "0x1872ED8B0")]
	[MonoPInvokeCallback(typeof(ONDJCPDDFBB))]
	private static int PFHGLFKMECB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x72ED710", Offset = "0x72EC510", VA = "0x1872ED710")]
	private void OKBNJPMAHFB(string BLIFPNIMAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x72EC600", Offset = "0x72EB400", VA = "0x1872EC600")]
	private void DHFKCKCJJOI(OLIHFDAGBEC JMGOMJNPFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72ED500", Offset = "0x72EC300", VA = "0x1872ED500")]
	private void NNCFIMBPLAB(ONDJCPDDFBB JMGOMJNPFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x72EC7E0", Offset = "0x72EB5E0", VA = "0x1872EC7E0")]
	private void GNJHEICBOEH(HKHFNPLPHKE ADJDIHDFFBH, string JJOJJKBIJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x72ED540", Offset = "0x72EC340", VA = "0x1872ED540")]
	private void OGPADHFGIFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x72ECB30", Offset = "0x72EB930", VA = "0x1872ECB30")]
	private long? IGMMJPJGGOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x72ECB90", Offset = "0x72EB990", VA = "0x1872ECB90")]
	private long? IHOIBEMPONC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x72ECFF0", Offset = "0x72EBDF0", VA = "0x1872ECFF0")]
	private Guid? LGHHBJIMGLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x72EC780", Offset = "0x72EB580", VA = "0x1872EC780")]
	private double? GBDBNGCALHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x72EC8B0", Offset = "0x72EB6B0", VA = "0x1872EC8B0")]
	internal static void HCPDLDDPHAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x72ED580", Offset = "0x72EC380", VA = "0x1872ED580")]
	private void OIOHBMOMAEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LOBPCGKBLCH
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x72EDB00", Offset = "0x72EC900", VA = "0x1872EDB00")]
	[FOLINPJCBJN.HMBDLNHFFEJ]
	internal static void DIFEJPOBKHM(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x72EDBF0", Offset = "0x72EC9F0", VA = "0x1872EDBF0")]
	[IGIDCNKGIJD.GHJADADFOEE]
	internal static void MHKPNJJHBBH()
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
