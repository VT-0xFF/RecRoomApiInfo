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
	public class LogRegistrationIndex : LGGBAGMLBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7673530", Offset = "0x7672730", VA = "0x187673530", Slot = "4")]
		public override void COGNOIDNGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7673D50", Offset = "0x7672F50", VA = "0x187673D50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2493E30", Offset = "0x2493030", VA = "0x182493E30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum FKLHKBMGIAB
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
public interface DBPLLNJPCNB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NAPKPBMIMHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? AFGIIECALBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? BGMFNCNIIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? OODCMKMDPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? IGHPINKCCBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	MFBGPJFKEEN NPDEHEMPFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KICCNFAKMLE(FKLHKBMGIAB LEOMHHEDCFC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PDAIGIIELDH();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PGKGHHLFEGN();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PJOLCDPDEIE(string NGDINNOFNDP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<MFBGPJFKEEN> ABCPMGMMNPA([Optional] CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CGLEPEKKMGJ();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GPMFOIMHOMN
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class EEAPKEMMAAN : DBPLLNJPCNB
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private enum MLPKPPPDNHH
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void DCCLNEHGFBD(string JEBJMIGPDJK);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private delegate int DKAKLBIAMAO();

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct PDOFHHDHMCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<MFBGPJFKEEN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public EEAPKEMMAAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskCompletionSource<MFBGPJFKEEN> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter<MFBGPJFKEEN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x76735C0", Offset = "0x76727C0", VA = "0x1876735C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7673C00", Offset = "0x7672E00", VA = "0x187673C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly PBBCGFNIILA IPKFDHIOJFD;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static EEAPKEMMAAN IMMKPGPNBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly FHHIANONFNH LMOKBMFNOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KDCKECJKIIM HNAPEDABKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HOHILFLCNNI FJDPADGCJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool AHNPJNIENHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool PCDJOMBGLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool HNILMDAOGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? MBMCEABMOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool HGKCEBOEFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? NKBLEMJCNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool LELCGCNGGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? OMGKHLOCFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private FKLHKBMGIAB KEKLMGFLFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly object COMALHGAJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Queue<MFBGPJFKEEN> BPEKJCFALLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private TaskCompletionSource<MFBGPJFKEEN> NNOBBKAPIHF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NAPKPBMIMHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? AFGIIECALBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7672590", Offset = "0x7671790", VA = "0x187672590", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? BGMFNCNIIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7672D60", Offset = "0x7671F60", VA = "0x187672D60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? OODCMKMDPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7672AC0", Offset = "0x7671CC0", VA = "0x187672AC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? IGHPINKCCBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7672C20", Offset = "0x7671E20", VA = "0x187672C20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public MFBGPJFKEEN NPDEHEMPFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAD2120", Offset = "0xAD1320", VA = "0x180AD2120", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x117A830", Offset = "0x1179A30", VA = "0x18117A830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x76731B0", Offset = "0x76723B0", VA = "0x1876731B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public EEAPKEMMAAN([KMMHIEIDBEA(null)] FHHIANONFNH LMOKBMFNOFB, [KMMHIEIDBEA(null)] KDCKECJKIIM HNAPEDABKEK, [KMMHIEIDBEA(null)] HOHILFLCNNI FJDPADGCJMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7672FD0", Offset = "0x76721D0", VA = "0x187672FD0", Slot = "11")]
	public void PDAIGIIELDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7671F70", Offset = "0x7671170", VA = "0x187671F70", Slot = "16")]
	public void BBCNJJFDNEG(string MHJCBHGCHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7672390", Offset = "0x7671590", VA = "0x187672390", Slot = "12")]
	public void PGKGHHLFEGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7672390", Offset = "0x7671590", VA = "0x187672390", Slot = "17")]
	public void BFBNBBHHLNG([Optional] string HDKKBCJNDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7672390", Offset = "0x7671590", VA = "0x187672390", Slot = "13")]
	public void PJOLCDPDEIE(string NGDINNOFNDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7672EA0", Offset = "0x76720A0", VA = "0x187672EA0", Slot = "10")]
	public void KICCNFAKMLE(FKLHKBMGIAB LEOMHHEDCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x76723D0", Offset = "0x76715D0", VA = "0x1876723D0", Slot = "15")]
	public void CGLEPEKKMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7671E50", Offset = "0x7671050", VA = "0x187671E50", Slot = "14")]
	[AsyncStateMachine(typeof(PDOFHHDHMCJ))]
	public Task<MFBGPJFKEEN> ABCPMGMMNPA(CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7672610", Offset = "0x7671810", VA = "0x187672610")]
	private void EEOPKKOFKFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7672F60", Offset = "0x7672160", VA = "0x187672F60")]
	[MonoPInvokeCallback(typeof(DCCLNEHGFBD))]
	private static void NBELEBAONBI(string MHJCBHGCHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x76724F0", Offset = "0x76716F0", VA = "0x1876724F0")]
	[MonoPInvokeCallback(typeof(DKAKLBIAMAO))]
	private static int DBHNMPKOMCJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7672CE0", Offset = "0x7671EE0", VA = "0x187672CE0")]
	private void IAIIMJDBMNK(string IHLEKDPBGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7671E10", Offset = "0x7671010", VA = "0x187671E10")]
	private void AAJMEDAAIGO(DCCLNEHGFBD GIIPLELNBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7672900", Offset = "0x7671B00", VA = "0x187672900")]
	private void EICNBBPLMGO(DKAKLBIAMAO GIIPLELNBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7672390", Offset = "0x7671590", VA = "0x187672390")]
	private void PGKGHHLFEGN(MLPKPPPDNHH HIIOCAFDBNN, string HCKPGHBPLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7672550", Offset = "0x7671750", VA = "0x187672550")]
	private void DFGALLAHLCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x76728A0", Offset = "0x7671AA0", VA = "0x1876728A0")]
	private long? EHDDAJBBPBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7672E40", Offset = "0x7672040", VA = "0x187672E40")]
	private long? JMICHDEJNHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7672EF0", Offset = "0x76720F0", VA = "0x187672EF0")]
	private Guid? LLEEHEBAFAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7672DE0", Offset = "0x7671FE0", VA = "0x187672DE0")]
	private double? JMEMKCAAEPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7672B50", Offset = "0x7671D50", VA = "0x187672B50")]
	internal static void GMBCIFADOEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7672940", Offset = "0x7671B40", VA = "0x187672940")]
	private void ELMPEACOLMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LOHKOHBCMEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7673430", Offset = "0x7672630", VA = "0x187673430")]
	[LDKBBAENJDF.JPBGCAANJAC]
	internal static void KIDJFLKGIEO(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7673330", Offset = "0x7672530", VA = "0x187673330")]
	[AEGEAJMGHGA.LGPOCIOLIAD]
	internal static void BPPGGBEBHKL()
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
