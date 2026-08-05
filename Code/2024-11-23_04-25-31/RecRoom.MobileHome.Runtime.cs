using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_MobileHome_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E5FEA0", Offset = "0x6E5E8A0", VA = "0x186E5FEA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2164780", Offset = "0x2163180", VA = "0x182164780")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum AFEGEJGDOFP
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
public interface KFGDFKIMKAN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EDNGBHFHNGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? ALNJPDABEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? OLDOPIPNJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? EAJHFEKLIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? MBDHHAECELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	OBJLMCEEACJ PKLKGHKJGHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> DJENHDBJAKF;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ELDBLNLOILL(AFEGEJGDOFP DPGCKOGOMEN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GCHKJEOLKFE();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CPPLPFLAKDK();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CAMDOHLIEIF(string HEJCCGDENJJ);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HGCKJDIICOM();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DJEKGLMIKIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LLJNMBAPIKJ(OBJLMCEEACJ GEPEFDLOELG, [Optional] CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ICFAJEEHHLI : KFGDFKIMKAN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private enum AHLMDMEJJMB
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void MLNBCMHCABC(string GEPEFDLOELG);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate int DOGHLLDMKAD();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static ICFAJEEHHLI NGPNBABCJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly NBJKPJCPFJP ADPHLOBKJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CPFOEKFFEAJ NBGOLGMDODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool CEPECNNKEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool OIJICAOHIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool JPHBLPAIHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool FKEJGHDIKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? HBBJGNFPFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool AMJMLHNNIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? OMBEGKDPELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool KMCGGOGHBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? IMDBHDJGMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private AFEGEJGDOFP GOKAOPCKHDP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool EDNGBHFHNGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? ALNJPDABEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6E5F180", Offset = "0x6E5DB80", VA = "0x186E5F180", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? OLDOPIPNJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6E5EDD0", Offset = "0x6E5D7D0", VA = "0x186E5EDD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? EAJHFEKLIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6E5FB50", Offset = "0x6E5E550", VA = "0x186E5FB50", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? MBDHHAECELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6E5EEC0", Offset = "0x6E5D8C0", VA = "0x186E5EEC0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public OBJLMCEEACJ PKLKGHKJGHD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8B96F0", Offset = "0x8B80F0", VA = "0x1808B96F0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8B9690", Offset = "0x8B8090", VA = "0x1808B9690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> DJENHDBJAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6E5F6C0", Offset = "0x6E5E0C0", VA = "0x186E5F6C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6E5F0D0", Offset = "0x6E5DAD0", VA = "0x186E5F0D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F820", Offset = "0x6E5E220", VA = "0x186E5F820")]
	private void IPJGEJOKABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6E5FE00", Offset = "0x6E5E800", VA = "0x186E5FE00")]
	[RecRoom.NoEngine.Common.Preserve]
	public ICFAJEEHHLI([CCLEDEMDDDH(null)] NBJKPJCPFJP ADPHLOBKJHB, [CCLEDEMDDDH(null)] CPFOEKFFEAJ NBGOLGMDODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F510", Offset = "0x6E5DF10", VA = "0x186E5F510", Slot = "13")]
	public void GCHKJEOLKFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F590", Offset = "0x6E5DF90", VA = "0x186E5F590", Slot = "16")]
	public void HGCKJDIICOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F950", Offset = "0x6E5E350", VA = "0x186E5F950", Slot = "17")]
	public void LGLLMAEJOIN(string MOGFIFILNKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F310", Offset = "0x6E5DD10", VA = "0x186E5F310", Slot = "14")]
	public void CPPLPFLAKDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F580", Offset = "0x6E5DF80", VA = "0x186E5F580", Slot = "18")]
	public void GPJBFLLFLDE([Optional] string BEOJAMBEHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F270", Offset = "0x6E5DC70", VA = "0x186E5F270", Slot = "15")]
	public void CAMDOHLIEIF(string HEJCCGDENJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F3B0", Offset = "0x6E5DDB0", VA = "0x186E5F3B0", Slot = "12")]
	public void ELDBLNLOILL(AFEGEJGDOFP DPGCKOGOMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E5EAB0", Offset = "0x6E5D4B0", VA = "0x186E5EAB0")]
	private void AAJLBCPPHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F530", Offset = "0x6E5DF30", VA = "0x186E5F530")]
	[MonoPInvokeCallback(typeof(MLNBCMHCABC))]
	private static void GGOGNDINCIO(string MOGFIFILNKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6E5FD00", Offset = "0x6E5E700", VA = "0x186E5FD00")]
	[MonoPInvokeCallback(typeof(DOGHLLDMKAD))]
	private static int NJHJDLEJJLI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6E5EFD0", Offset = "0x6E5D9D0", VA = "0x186E5EFD0")]
	private void AMPADAHLIFF(string EPHNEEBHMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F480", Offset = "0x6E5DE80", VA = "0x186E5F480")]
	private void FHILAMCPNGD(MLNBCMHCABC HFJNADOBPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F280", Offset = "0x6E5DC80", VA = "0x186E5F280")]
	private void CKOGABKGEFP(DOGHLLDMKAD HFJNADOBPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F320", Offset = "0x6E5DD20", VA = "0x186E5F320")]
	private void CPPLPFLAKDK(AHLMDMEJJMB OMJKCNAHEJC, string BFCBLOCMMCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F040", Offset = "0x6E5DA40", VA = "0x186E5F040")]
	private void APFBMNAFOKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6E5FD50", Offset = "0x6E5E750", VA = "0x186E5FD50")]
	private long? OPAJJLIOICH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E5FC50", Offset = "0x6E5E650", VA = "0x186E5FC50")]
	private long? NHCPBCGBMLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F770", Offset = "0x6E5E170", VA = "0x186E5F770")]
	private Guid? IOEMJKNAEEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F8A0", Offset = "0x6E5E2A0", VA = "0x186E5F8A0")]
	private double? JCOOJFLLABO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E5E8F0", Offset = "0x6E5D2F0", VA = "0x186E5E8F0")]
	internal static void ANOGMAKLODF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F5A0", Offset = "0x6E5DFA0", VA = "0x186E5F5A0")]
	private void IHEBALNHAFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EDLDIKFPACB
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6E5E9B0", Offset = "0x6E5D3B0", VA = "0x186E5E9B0")]
	[EPFHFFCDLIN.KOJNBNLGEPK]
	internal static void HHMIMJNDBON(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E5E8F0", Offset = "0x6E5D2F0", VA = "0x186E5E8F0")]
	[DJHNLGFKBFK.PIFNMABAPCA]
	internal static void HDEMNDJCOBK()
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
