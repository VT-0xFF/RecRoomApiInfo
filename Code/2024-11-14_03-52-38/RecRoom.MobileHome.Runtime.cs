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
	public class _AssemblyIndex : KNLEODIDJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6DBA520", Offset = "0x6DB9920", VA = "0x186DBA520", Slot = "8")]
		public override void LFFFLDDGBMJ(GFPLBLFDLJF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63F5FE0", Offset = "0x63F53E0", VA = "0x1863F5FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KIACBMICFHL
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
public interface NKJPDPOAFNC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MMHDDGFGIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? EFAKEOLJMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? DPEDIHPIPKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? MEFOOBBDPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? LPPHGKKNMFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	PIEPDHEMJPN KOOJPJNBNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> DOIFIHNJLND;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HEIMMNAIAID(KIACBMICFHL GCJJLPMGMAA);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NOCOEJHJFAP();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CADJKNPMHCG();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GLKOPFJNMPE(string HFDIBGJPADI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BOIODEBLDDK();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ALGAAJPOCML
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MOHNBIPCGHG(PIEPDHEMJPN BDPLPODBGPD, [Optional] CancellationToken GBOOEEMCFEA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MKLHNPLGFDA : NKJPDPOAFNC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private enum FCCBOEBCNPB
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void GGLJOJCHNEL(string BDPLPODBGPD);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate int DBKMEHCNCOL();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static MKLHNPLGFDA NAEMIMNOMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly KOFDFCJMCJL NMFCIKPGLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KHJDNEDCJOF CAHDIIHLNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool EEPPPPGAMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool ODPHGANGKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool FKNONCCNKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool PMCCGBGJBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? AIHOJNONIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool MGDGHGPCMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? LJHKPCCDGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool KDIDBAIOLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? GLMHPMPDELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private KIACBMICFHL MEBPNFFAAKK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool MMHDDGFGIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? EFAKEOLJMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6DB9CA0", Offset = "0x6DB90A0", VA = "0x186DB9CA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? DPEDIHPIPKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6DB98A0", Offset = "0x6DB8CA0", VA = "0x186DB98A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? MEFOOBBDPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6DBA380", Offset = "0x6DB9780", VA = "0x186DBA380", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? LPPHGKKNMFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6DB9470", Offset = "0x6DB8870", VA = "0x186DB9470", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public PIEPDHEMJPN KOOJPJNBNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x89FC50", Offset = "0x89F050", VA = "0x18089FC50", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x89FCD0", Offset = "0x89F0D0", VA = "0x18089FCD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> DOIFIHNJLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6DBA0B0", Offset = "0x6DB94B0", VA = "0x186DBA0B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6DB9630", Offset = "0x6DB8A30", VA = "0x186DB9630", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6DBA250", Offset = "0x6DB9650", VA = "0x186DBA250")]
	private void NMGFOHKODCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6DBA480", Offset = "0x6DB9880", VA = "0x186DBA480")]
	[RecRoom.NoEngine.Common.Preserve]
	public MKLHNPLGFDA([NDMEANGLJKD(null)] KOFDFCJMCJL NMFCIKPGLMI, [NDMEANGLJKD(null)] KHJDNEDCJOF CAHDIIHLNGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6DBA2D0", Offset = "0x6DB96D0", VA = "0x186DBA2D0", Slot = "13")]
	public void NOCOEJHJFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6DB96E0", Offset = "0x6DB8AE0", VA = "0x186DB96E0", Slot = "16")]
	public void BOIODEBLDDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6DB91C0", Offset = "0x6DB85C0", VA = "0x186DB91C0", Slot = "17")]
	public void ABLBJCABBFE(string HGMADJKKGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6DB96F0", Offset = "0x6DB8AF0", VA = "0x186DB96F0", Slot = "14")]
	public void CADJKNPMHCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6DB9800", Offset = "0x6DB8C00", VA = "0x186DB9800", Slot = "18")]
	public void CGCHHECOHGN([Optional] string ABFKJLNAOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6DB9A90", Offset = "0x6DB8E90", VA = "0x186DB9A90", Slot = "15")]
	public void GLKOPFJNMPE(string HFDIBGJPADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6DB9BD0", Offset = "0x6DB8FD0", VA = "0x186DB9BD0", Slot = "12")]
	public void HEIMMNAIAID(KIACBMICFHL GCJJLPMGMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6DB9D90", Offset = "0x6DB9190", VA = "0x186DB9D90")]
	private void HKOKEBCMBOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6DBA1F0", Offset = "0x6DB95F0", VA = "0x186DBA1F0")]
	[MonoPInvokeCallback(typeof(GGLJOJCHNEL))]
	private static void JEKGCDDEALF(string HGMADJKKGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6DB9A40", Offset = "0x6DB8E40", VA = "0x186DB9A40")]
	[MonoPInvokeCallback(typeof(DBKMEHCNCOL))]
	private static int FOMLJCKKCJI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6DB9790", Offset = "0x6DB8B90", VA = "0x186DB9790")]
	private void CDCOONCKNKG(string PONLKBHGBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6DB9810", Offset = "0x6DB8C10", VA = "0x186DB9810")]
	private void CJBCHNJKKCK(GGLJOJCHNEL NEDFJOJDIHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6DBA2F0", Offset = "0x6DB96F0", VA = "0x186DBA2F0")]
	private void ODLIPGJELBJ(DBKMEHCNCOL NEDFJOJDIHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6DB9700", Offset = "0x6DB8B00", VA = "0x186DB9700")]
	private void CADJKNPMHCG(FCCBOEBCNPB BNIDPJNMOLO, string AEKDIKFECOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6DBA160", Offset = "0x6DB9560", VA = "0x186DBA160")]
	private void IOHBEEFLIFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6DB93C0", Offset = "0x6DB87C0", VA = "0x186DB93C0")]
	private long? AJJGEKIHPBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6DB9580", Offset = "0x6DB8980", VA = "0x186DB9580")]
	private long? BDMMNEBIBND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6DB9110", Offset = "0x6DB8510", VA = "0x186DB9110")]
	private Guid? AAOECHBKAOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6DB9990", Offset = "0x6DB8D90", VA = "0x186DB9990")]
	private double? FJBCLOKNGNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6DB9050", Offset = "0x6DB8450", VA = "0x186DB9050")]
	internal static void NIFEDDNPFEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6DB9AA0", Offset = "0x6DB8EA0", VA = "0x186DB9AA0")]
	private void HAJMBJMEBEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class JCJEBEHKKHP
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6DB8F60", Offset = "0x6DB8360", VA = "0x186DB8F60")]
	[GOEIKLHOLGG.KCHBNNLNADK]
	internal static void NFLBKLEFKFJ(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6DB9050", Offset = "0x6DB8450", VA = "0x186DB9050")]
	[BEJKEFNNDNF.CFCIHHIGGAH]
	internal static void PKACLMCJOAP()
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
