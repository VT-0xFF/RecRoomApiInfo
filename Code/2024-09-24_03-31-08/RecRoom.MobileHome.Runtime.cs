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
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6BF8410", Offset = "0x6BF6E10", VA = "0x186BF8410", Slot = "8")]
		public override void CPJKPCOPIOF(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum OCKFGNHEHDD
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
public interface ANOLHELEAIA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HJCMKGAAFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? CBOBLCEJICH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? OOOEMJDGBFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? ABEPNDGCMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? MKLEGOOOADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	JPDHJCCDBDN MPHLJBPFBEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> JIFCDLHMCOP;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BOBIAGILKOO(OCKFGNHEHDD PFFGBBPKGJN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HINDDHMAHAN();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GFNDEKCNOKD();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NJICAGONJDG(string HJEKPEEDGCE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OODCFBMIICP();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JBCPHNOOBNM
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EKGMDGDNGBF(JPDHJCCDBDN JEFLEHIJEIO, [Optional] CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JAMIBJNDBKJ : ANOLHELEAIA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private enum BOMKGGGKJNL
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void NCNJLEGAPOD(string JEFLEHIJEIO);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate int HNJFIOLEFJC();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static JAMIBJNDBKJ MHOPBKMJKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly DGMMCJOACNP BGENFLEHPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly AIBCFNAPCDM LDOKHKPFMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool LAALHFICKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool PKHFDLCDHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool GFOODMMDDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool LCIBJDFINCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? DIECINEBCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool DKMEMMLFNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? DNEPMOABOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool NNPFKBCMDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? JCPFHHJCNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private OCKFGNHEHDD JILOKKDBLCB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool HJCMKGAAFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? CBOBLCEJICH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6BF7DE0", Offset = "0x6BF67E0", VA = "0x186BF7DE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? OOOEMJDGBFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6BF7310", Offset = "0x6BF5D10", VA = "0x186BF7310", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? ABEPNDGCMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6BF8270", Offset = "0x6BF6C70", VA = "0x186BF8270", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? MKLEGOOOADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6BF7980", Offset = "0x6BF6380", VA = "0x186BF7980", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JPDHJCCDBDN MPHLJBPFBEF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x883D40", Offset = "0x882740", VA = "0x180883D40", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x883E00", Offset = "0x882800", VA = "0x180883E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> JIFCDLHMCOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6BF74B0", Offset = "0x6BF5EB0", VA = "0x186BF74B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6BF7560", Offset = "0x6BF5F60", VA = "0x186BF7560", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7A90", Offset = "0x6BF6490", VA = "0x186BF7A90")]
	private void LAKHGIMAIPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8370", Offset = "0x6BF6D70", VA = "0x186BF8370")]
	[RecRoom.NoEngine.Common.Preserve]
	public JAMIBJNDBKJ([LKKACOOMNBP(null)] DGMMCJOACNP BGENFLEHPFB, [LKKACOOMNBP(null)] AIBCFNAPCDM LDOKHKPFMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6BF76B0", Offset = "0x6BF60B0", VA = "0x186BF76B0", Slot = "13")]
	public void HINDDHMAHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7F30", Offset = "0x6BF6930", VA = "0x186BF7F30", Slot = "16")]
	public void OODCFBMIICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7780", Offset = "0x6BF6180", VA = "0x186BF7780", Slot = "17")]
	public void IMFIJMJDDEK(string GCHCIFHPIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7610", Offset = "0x6BF6010", VA = "0x186BF7610", Slot = "14")]
	public void GFNDEKCNOKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8260", Offset = "0x6BF6C60", VA = "0x186BF8260", Slot = "18")]
	public void PFFNKEHNIGC([Optional] string MAKDBOJJNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7F20", Offset = "0x6BF6920", VA = "0x186BF7F20", Slot = "15")]
	public void NJICAGONJDG(string HJEKPEEDGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6BF70B0", Offset = "0x6BF5AB0", VA = "0x186BF70B0", Slot = "12")]
	public void BOBIAGILKOO(OCKFGNHEHDD PFFGBBPKGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7F40", Offset = "0x6BF6940", VA = "0x186BF7F40")]
	private void PDKMJPPDNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7210", Offset = "0x6BF5C10", VA = "0x186BF7210")]
	[MonoPInvokeCallback(typeof(NCNJLEGAPOD))]
	private static void DGKFOMGCGPL(string GCHCIFHPIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7ED0", Offset = "0x6BF68D0", VA = "0x186BF7ED0")]
	[MonoPInvokeCallback(typeof(HNJFIOLEFJC))]
	private static int NDHIBBHLJPB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7B10", Offset = "0x6BF6510", VA = "0x186BF7B10")]
	private void LDJCBMODCKP(string BAKGMDKMBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7020", Offset = "0x6BF5A20", VA = "0x186BF7020")]
	private void BHEKIJGDJKI(NCNJLEGAPOD AGMLFHLAIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7D50", Offset = "0x6BF6750", VA = "0x186BF7D50")]
	private void MPIAEKLIOON(HNJFIOLEFJC AGMLFHLAIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7620", Offset = "0x6BF6020", VA = "0x186BF7620")]
	private void GFNDEKCNOKD(BOMKGGGKJNL NOJDLJBPIDL, string OONJAPDDHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7180", Offset = "0x6BF5B80", VA = "0x186BF7180")]
	private void CNACFGHFFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6BF76D0", Offset = "0x6BF60D0", VA = "0x186BF76D0")]
	private long? HJKLLAHKNAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7CA0", Offset = "0x6BF66A0", VA = "0x186BF7CA0")]
	private long? LJPJBGMGNHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7260", Offset = "0x6BF5C60", VA = "0x186BF7260")]
	private Guid? EJOAHEBKBOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7400", Offset = "0x6BF5E00", VA = "0x186BF7400")]
	private double? ELINJFIOCAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6F60", Offset = "0x6BF5960", VA = "0x186BF6F60")]
	internal static void HINCGMNIGBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7B80", Offset = "0x6BF6580", VA = "0x186BF7B80")]
	private void LIDGDNFKKGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FGJKMGMDHNM
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6E60", Offset = "0x6BF5860", VA = "0x186BF6E60")]
	[MDINNNLEANF.FIHKBCJDGBK]
	internal static void AABKCNFOEAJ(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6F60", Offset = "0x6BF5960", VA = "0x186BF6F60")]
	[MDEOHLLDIMG.HGKMINFPIJL]
	internal static void IBEACPBBPEC()
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
