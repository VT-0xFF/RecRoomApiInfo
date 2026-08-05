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
	public class _AssemblyIndex : MGJKNLCKGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6C0AE50", Offset = "0x6C09850", VA = "0x186C0AE50", Slot = "8")]
		public override void KLIFGJHDPHO(DIMDGJNLMOK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6283490", Offset = "0x6281E90", VA = "0x186283490")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum NHFODBCLPMF
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
public interface PJGFFJFDOGD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EBNACAKHPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? IOPJDEDMKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? KLBPCPKIHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? KOELPKKBLNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? OPCONBEOGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	PLBJGHKNGFI KCGGAJMNLEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> JNJOKFEOCKP;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JNBPOBNFJPF(NHFODBCLPMF ACEEMNFHFMB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PCEEADECCDH();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EFHLHOEAPKO();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MDOAFONFJEI(string MNKHJCJHKNO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AHIMBFHMBIL();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KOOIFCOIEML
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HKPFHNHCEII(PLBJGHKNGFI HHBGNJGEEKD, [Optional] CancellationToken OGJIGALEPCA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BKNABGJMBKD : PJGFFJFDOGD
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private enum AKJCFAECPBK
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void AAMHGFPDJOD(string HHBGNJGEEKD);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate int PDBJKIPNJOI();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static BKNABGJMBKD NKEOLIFBNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly MADEEJNOHNA IJFLBOFJGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly BJLBEEMGDKC ICNPKGOEKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool FMGBICOONKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool GKFHIPDCION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool BPAEEDJOIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool OHECGMOMOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? EIAONEENPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool KMAGGPANMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? OFLNHGIADMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool CGBCPMGEHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? ONLFKKFICFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private NHFODBCLPMF GGNOGBHNDFN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool EBNACAKHPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? IOPJDEDMKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C0A790", Offset = "0x6C09190", VA = "0x186C0A790", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? KLBPCPKIHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C0AAA0", Offset = "0x6C094A0", VA = "0x186C0AAA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? KOELPKKBLNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C0A480", Offset = "0x6C08E80", VA = "0x186C0A480", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? OPCONBEOGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C09DB0", Offset = "0x6C087B0", VA = "0x186C09DB0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public PLBJGHKNGFI KCGGAJMNLEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88C870", Offset = "0x88B270", VA = "0x18088C870", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x88C8A0", Offset = "0x88B2A0", VA = "0x18088C8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> JNJOKFEOCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6C0A580", Offset = "0x6C08F80", VA = "0x186C0A580", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C09C60", Offset = "0x6C08660", VA = "0x186C09C60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C099E0", Offset = "0x6C083E0", VA = "0x186C099E0")]
	private void DMHGDNDKENC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C0ACB0", Offset = "0x6C096B0", VA = "0x186C0ACB0")]
	[RecRoom.NoEngine.Common.Preserve]
	public BKNABGJMBKD([CNNDHKODGDP(null)] MADEEJNOHNA IJFLBOFJGGE, [CNNDHKODGDP(null)] BJLBEEMGDKC ICNPKGOEKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C0AC00", Offset = "0x6C09600", VA = "0x186C0AC00", Slot = "13")]
	public void PCEEADECCDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C098A0", Offset = "0x6C082A0", VA = "0x186C098A0", Slot = "16")]
	public void AHIMBFHMBIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6C09A60", Offset = "0x6C08460", VA = "0x186C09A60", Slot = "17")]
	public void DOHMDMGJJMK(string NKIKBIEJINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C09DA0", Offset = "0x6C087A0", VA = "0x186C09DA0", Slot = "14")]
	public void EFHLHOEAPKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C099D0", Offset = "0x6C083D0", VA = "0x186C099D0", Slot = "18")]
	public void BAGAFDDJBCL([Optional] string MMGDJMJCJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A9E0", Offset = "0x6C093E0", VA = "0x186C0A9E0", Slot = "15")]
	public void MDOAFONFJEI(string MNKHJCJHKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A630", Offset = "0x6C09030", VA = "0x186C0A630", Slot = "12")]
	public void JNBPOBNFJPF(NHFODBCLPMF ACEEMNFHFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A160", Offset = "0x6C08B60", VA = "0x186C0A160")]
	private void IHFOKCADNMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A080", Offset = "0x6C08A80", VA = "0x186C0A080")]
	[MonoPInvokeCallback(typeof(AAMHGFPDJOD))]
	private static void HMEIANFGFBB(string NKIKBIEJINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C09F70", Offset = "0x6C08970", VA = "0x186C09F70")]
	[MonoPInvokeCallback(typeof(PDBJKIPNJOI))]
	private static int FJLBNONPAGN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C0AB90", Offset = "0x6C09590", VA = "0x186C0AB90")]
	private void NCGEALNIPID(string AOKOEFNLEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A0D0", Offset = "0x6C08AD0", VA = "0x186C0A0D0")]
	private void ICGNBLLLEDL(AAMHGFPDJOD DKOPNCNMOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A700", Offset = "0x6C09100", VA = "0x186C0A700")]
	private void JOINNGBBFIF(PDBJKIPNJOI DKOPNCNMOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6C09D10", Offset = "0x6C08710", VA = "0x186C09D10")]
	private void EFHLHOEAPKO(AKJCFAECPBK NDHIDCDGEGF, string GAIDCJAAPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C0AC20", Offset = "0x6C09620", VA = "0x186C0AC20")]
	private void PJIMKCFCLJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A930", Offset = "0x6C09330", VA = "0x186C0A930")]
	private long? KKEJBBFHIKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A880", Offset = "0x6C09280", VA = "0x186C0A880")]
	private long? KFANBKFONMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A9F0", Offset = "0x6C093F0", VA = "0x186C0A9F0")]
	private Guid? MHIJFEMHCHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6C09EC0", Offset = "0x6C088C0", VA = "0x186C09EC0")]
	private double? EJKKIEJDKIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C09FC0", Offset = "0x6C089C0", VA = "0x186C09FC0")]
	internal static void FPAFLBLODNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C098B0", Offset = "0x6C082B0", VA = "0x186C098B0")]
	private void AIFDMPBMODO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LFNDDGBHDNA
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C0AD50", Offset = "0x6C09750", VA = "0x186C0AD50")]
	[POCMGODEOKB.GGOFPJDKHFE]
	internal static void HPJGKMOFOOB(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C09FC0", Offset = "0x6C089C0", VA = "0x186C09FC0")]
	[NBPHLMAPGPJ.LCAAJBOOONB]
	internal static void KECOGBHHKIH()
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
