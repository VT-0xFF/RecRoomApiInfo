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
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E3F8E0", Offset = "0x6E3ECE0", VA = "0x186E3F8E0", Slot = "8")]
		public override void JFOOIIGPHCJ(GHGEJHAEAMC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x648F4C0", Offset = "0x648E8C0", VA = "0x18648F4C0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum CKAGPLOBBCD
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
public interface LJHIGLBCDBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KMDMMCAKGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? EONPJAHICCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? EKMJGBDHIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? IGBDFLDHMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? LMLEBFEHCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	BKMJMIHMJID MBEBBFICNFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> MLHOGKOPKLP;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GPLDPAMAIJO(CKAGPLOBBCD NMAIGNOENJN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CGCFJDLGJFP();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KGPLLAHBJKO();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KIAFGAGMEGO(string MOHONHDGABF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EHLPAKNNHLL();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JBELPLBJPOD
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FLNAGDPHEBG(BKMJMIHMJID NKFKMHNHCAN, [Optional] CancellationToken NBBCMDKGJKI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IHIOOAHDDFD : LJHIGLBCDBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private enum CJHOHJCMMFL
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void CNFKAACDOJH(string NKFKMHNHCAN);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate int OGLNIAPJHLJ();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static IHIOOAHDDFD BHCLGMHGMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly GCDLIECIJNL MOLCPLLLGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly PIAOMMOEIOD NEGEGILOMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool AOHJCBGJBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool PFAJMNKKAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool OMPPKGLAAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool GGLMFKDHFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? INEFMGMEMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool CCHCNJGKNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? DGIAFOMCADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool EGPMGMKKKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? HONCOMNJLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private CKAGPLOBBCD CGGKPHHFAMO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KMDMMCAKGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? EONPJAHICCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6E3F650", Offset = "0x6E3EA50", VA = "0x186E3F650", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? EKMJGBDHIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6E3E530", Offset = "0x6E3D930", VA = "0x186E3E530", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? IGBDFLDHMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6E3EB20", Offset = "0x6E3DF20", VA = "0x186E3EB20", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? LMLEBFEHCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6E3EE20", Offset = "0x6E3E220", VA = "0x186E3EE20", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public BKMJMIHMJID MBEBBFICNFD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8AFCC0", Offset = "0x8AF0C0", VA = "0x1808AFCC0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8AFD20", Offset = "0x8AF120", VA = "0x1808AFD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> MLHOGKOPKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6E3E620", Offset = "0x6E3DA20", VA = "0x186E3E620", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6E3E950", Offset = "0x6E3DD50", VA = "0x186E3E950", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6E3F2B0", Offset = "0x6E3E6B0", VA = "0x186E3F2B0")]
	private void NGJBKADECDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6E3F750", Offset = "0x6E3EB50", VA = "0x186E3F750")]
	[RecRoom.NoEngine.Common.Preserve]
	public IHIOOAHDDFD([CCLHMIDBCEM(null)] GCDLIECIJNL MOLCPLLLGOH, [CCLHMIDBCEM(null)] PIAOMMOEIOD NEGEGILOMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E3E3D0", Offset = "0x6E3D7D0", VA = "0x186E3E3D0", Slot = "13")]
	public void CGCFJDLGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E3E760", Offset = "0x6E3DB60", VA = "0x186E3E760", Slot = "16")]
	public void EHLPAKNNHLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6E3EC20", Offset = "0x6E3E020", VA = "0x186E3EC20", Slot = "17")]
	public void JFGJLAIDICA(string COGDDKFANGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6E3F070", Offset = "0x6E3E470", VA = "0x186E3F070", Slot = "14")]
	public void KGPLLAHBJKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E3F740", Offset = "0x6E3EB40", VA = "0x186E3F740", Slot = "18")]
	public void OMAGDKLHJNH([Optional] string OIGBJFDGOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E3F080", Offset = "0x6E3E480", VA = "0x186E3F080", Slot = "15")]
	public void KIAFGAGMEGO(string MOHONHDGABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E3EA50", Offset = "0x6E3DE50", VA = "0x186E3EA50", Slot = "12")]
	public void GPLDPAMAIJO(CKAGPLOBBCD NMAIGNOENJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E3F330", Offset = "0x6E3E730", VA = "0x186E3F330")]
	private void OCCGFELAEOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6E3EA00", Offset = "0x6E3DE00", VA = "0x186E3EA00")]
	[MonoPInvokeCallback(typeof(CNFKAACDOJH))]
	private static void GNEFBBNJAGD(string COGDDKFANGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6E3F140", Offset = "0x6E3E540", VA = "0x186E3F140")]
	[MonoPInvokeCallback(typeof(OGLNIAPJHLJ))]
	private static int MGGJLLDCILI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6E3E830", Offset = "0x6E3DC30", VA = "0x186E3E830")]
	private void GBFOLAPOGEA(string EFHIBPABMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6E3E340", Offset = "0x6E3D740", VA = "0x186E3E340")]
	private void BDCICPDHEPJ(CNFKAACDOJH JMKLCPOKHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6E3E3F0", Offset = "0x6E3D7F0", VA = "0x186E3E3F0")]
	private void CMKNJBPEKJI(OGLNIAPJHLJ JMKLCPOKHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6E3EFE0", Offset = "0x6E3E3E0", VA = "0x186E3EFE0")]
	private void KGPLLAHBJKO(CJHOHJCMMFL ENJPANJMAJE, string KGLEFJGJKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6E3E6D0", Offset = "0x6E3DAD0", VA = "0x186E3E6D0")]
	private void EGHAIAAADBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6E3E480", Offset = "0x6E3D880", VA = "0x186E3E480")]
	private long? DFBJOHIMMDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E3EF30", Offset = "0x6E3E330", VA = "0x186E3EF30")]
	private long? JKFAEBNIEEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E3E8A0", Offset = "0x6E3DCA0", VA = "0x186E3E8A0")]
	private Guid? GIBFIOHJFHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6E3F090", Offset = "0x6E3E490", VA = "0x186E3F090")]
	private double? MCHJFJNPHOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E3E770", Offset = "0x6E3DB70", VA = "0x186E3E770")]
	internal static void EPBAMOCFHMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E3F190", Offset = "0x6E3E590", VA = "0x186E3F190")]
	private void MKBOOABFBFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IJENELOOBAO
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6E3F7F0", Offset = "0x6E3EBF0", VA = "0x186E3F7F0")]
	[OAJAKDHKADM.LHNCMMKCKFL]
	internal static void KHFJJNELCMN(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E3E770", Offset = "0x6E3DB70", VA = "0x186E3E770")]
	[GEPLGCINGLB.DNOGLPMHBOB]
	internal static void PDDEBFDPIGM()
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
