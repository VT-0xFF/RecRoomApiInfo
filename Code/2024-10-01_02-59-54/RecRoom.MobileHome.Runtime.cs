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
	public class _AssemblyIndex : GADMOBJFAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E500C0", Offset = "0x6E4F4C0", VA = "0x186E500C0", Slot = "8")]
		public override void NALDPPFDOAA(JBGBENDLNHF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x64A1D70", Offset = "0x64A1170", VA = "0x1864A1D70")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum OLJPOHPAGKK
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
public interface LGGLJANPOEH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NMOEMCHKKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? KHAJHBLGDHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? NBIEODDCFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? MAAPLIJEKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? LJLFKHMOEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	OPKCICJGJNO IJJMBGIDALG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> LJALPLDCCNF;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OKFJALADPBL(OLJPOHPAGKK NOGEMBGGBHJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JLABJFAHLGH();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LGGOBADMHMJ();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EODLDFDFDIB(string IJCJJCBDAMK);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MFIKIKAPGIM();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CKOOAIOMCJG
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FDEHBDGDFFK(OPKCICJGJNO EGDFLEHGKNF, [Optional] CancellationToken EEHACKMODLA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PJKKJLBDOBH : LGGLJANPOEH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private enum KEOHMLMMLKB
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void CFPDPLLAIDE(string EGDFLEHGKNF);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate int OIMFHICNFKP();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static PJKKJLBDOBH FECLIDFMLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly ENFDNHEGPKN CJCCIKLGINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly OLDAHMACOMH PPMPIHEKIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool KKFEGHBICAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool IMFMDNLMFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool ECNFFOJOFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool PHFLNBJPPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? NJDODIIPHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool KPNIFIBDOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? EFMALAKOIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool GNLPGKBAIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? MNOMEHJGCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private OLJPOHPAGKK MNLBFGHBONF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NMOEMCHKKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? KHAJHBLGDHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F760", Offset = "0x6E4EB60", VA = "0x186E4F760", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? NBIEODDCFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6E4FAF0", Offset = "0x6E4EEF0", VA = "0x186E4FAF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? MAAPLIJEKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6E4FE10", Offset = "0x6E4F210", VA = "0x186E4FE10", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? LJLFKHMOEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6E4FF10", Offset = "0x6E4F310", VA = "0x186E4FF10", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public OPKCICJGJNO IJJMBGIDALG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB20", Offset = "0x8AEF20", VA = "0x1808AFB20", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8AFAA0", Offset = "0x8AEEA0", VA = "0x1808AFAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> LJALPLDCCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6E4ED50", Offset = "0x6E4E150", VA = "0x186E4ED50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F6B0", Offset = "0x6E4EAB0", VA = "0x186E4F6B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6E4ECD0", Offset = "0x6E4E0D0", VA = "0x186E4ECD0")]
	private void AGBIBABPHOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6E50020", Offset = "0x6E4F420", VA = "0x186E50020")]
	[RecRoom.NoEngine.Common.Preserve]
	public PJKKJLBDOBH([ACGOIOBGIEE(null)] ENFDNHEGPKN CJCCIKLGINN, [ACGOIOBGIEE(null)] OLDAHMACOMH PPMPIHEKIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F970", Offset = "0x6E4ED70", VA = "0x186E4F970", Slot = "13")]
	public void JLABJFAHLGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FAE0", Offset = "0x6E4EEE0", VA = "0x186E4FAE0", Slot = "16")]
	public void MFIKIKAPGIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F1A0", Offset = "0x6E4E5A0", VA = "0x186E4F1A0", Slot = "17")]
	public void DCIEFGBHDNF(string CNIMFFNPBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FA20", Offset = "0x6E4EE20", VA = "0x186E4FA20", Slot = "14")]
	public void LGGOBADMHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F190", Offset = "0x6E4E590", VA = "0x186E4F190", Slot = "18")]
	public void COBNCIAFKBI([Optional] string PJIPAFKNGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F430", Offset = "0x6E4E830", VA = "0x186E4F430", Slot = "15")]
	public void EODLDFDFDIB(string IJCJJCBDAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FC90", Offset = "0x6E4F090", VA = "0x186E4FC90", Slot = "12")]
	public void OKFJALADPBL(OLJPOHPAGKK NOGEMBGGBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E4EE70", Offset = "0x6E4E270", VA = "0x186E4EE70")]
	private void CGOONBBBNKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F660", Offset = "0x6E4EA60", VA = "0x186E4F660")]
	[MonoPInvokeCallback(typeof(CFPDPLLAIDE))]
	private static void HPBEIAFOJIA(string CNIMFFNPBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F560", Offset = "0x6E4E960", VA = "0x186E4F560")]
	[MonoPInvokeCallback(typeof(OIMFHICNFKP))]
	private static int GJBDHOAIFOD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6E4EE00", Offset = "0x6E4E200", VA = "0x186E4EE00")]
	private void AOPIKIBCJBL(string CCPOJJAMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F440", Offset = "0x6E4E840", VA = "0x186E4F440")]
	private void FAMADELAAFH(CFPDPLLAIDE BNNBDLHMCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F4D0", Offset = "0x6E4E8D0", VA = "0x186E4F4D0")]
	private void FNAPOABABAA(OIMFHICNFKP BNNBDLHMCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F990", Offset = "0x6E4ED90", VA = "0x186E4F990")]
	private void LGGOBADMHMJ(KEOHMLMMLKB POKPBEJPBMH, string EKHHOAHIIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F3A0", Offset = "0x6E4E7A0", VA = "0x186E4F3A0")]
	private void DGEEJNCOLPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FBE0", Offset = "0x6E4EFE0", VA = "0x186E4FBE0")]
	private long? OHHOLKFFMBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F5B0", Offset = "0x6E4E9B0", VA = "0x186E4F5B0")]
	private long? GNKCDEELPDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FD60", Offset = "0x6E4F160", VA = "0x186E4FD60")]
	private Guid? PEDGLBNACEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FA30", Offset = "0x6E4EE30", VA = "0x186E4FA30")]
	private double? MEOBGFKAKIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E4EB10", Offset = "0x6E4DF10", VA = "0x186E4EB10")]
	internal static void NPOAOMBBMKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F850", Offset = "0x6E4EC50", VA = "0x186E4F850")]
	private void JIDPHLFPPGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FKBGIAAEOFO
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6E4EBD0", Offset = "0x6E4DFD0", VA = "0x186E4EBD0")]
	[FHFMOACGLML.PCGBCKINAAE]
	internal static void EFFHABGGDNG(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E4EB10", Offset = "0x6E4DF10", VA = "0x186E4EB10")]
	[ELFOKGBJCKN.DLMFIDLPKPF]
	internal static void AHMCGDEDPHI()
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
