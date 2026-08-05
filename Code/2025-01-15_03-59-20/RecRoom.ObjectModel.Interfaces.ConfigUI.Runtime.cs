using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.ObjectModel;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Class)]
public class MMPABJFEHKO : MFHFEMMJIPA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type KBPCMAIENME
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7138E40", Offset = "0x7138240", VA = "0x187138E40")]
	public MMPABJFEHKO(Type KBPCMAIENME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7138E80", Offset = "0x7138280", VA = "0x187138E80")]
	public MMPABJFEHKO(Type KBPCMAIENME, int HAKPHKPNEMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class)]
public abstract class MFHFEMMJIPA : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HAKPHKPNEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8C51A0", Offset = "0x8C45A0", VA = "0x1808C51A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E04F90", Offset = "0x6E04390", VA = "0x186E04F90")]
	public MFHFEMMJIPA(int HPFPPNDKBPG = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class BMAIEDNDGPI : MFHFEMMJIPA
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6E04F90", Offset = "0x6E04390", VA = "0x186E04F90")]
	public BMAIEDNDGPI(int HAKPHKPNEMN = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class DADINLFPFGM : MFHFEMMJIPA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E04F90", Offset = "0x6E04390", VA = "0x186E04F90")]
	public DADINLFPFGM(int HAKPHKPNEMN = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LOIMCLNPHOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string DKCJKHANLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NPJNGPAAGID
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OBGLMNKFCEH BBEKALPAGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Type KBPCMAIENME
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action CGOMLACNPPJ;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AFFELPLAAIM(EPEJGOLLHIL HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KJLAKIGFJAC(ENJMHHOFLCB HCPAOILCJCB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class LJAEOALEBKN
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3117A70", Offset = "0x3116E70", VA = "0x183117A70")]
	public static T AFFELPLAAIM<T>(this LOIMCLNPHOM LKGPHBHEBBE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x31184E0", Offset = "0x31178E0", VA = "0x1831184E0")]
	public static void KJLAKIGFJAC<T>(this LOIMCLNPHOM LKGPHBHEBBE, T HCPAOILCJCB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3118410", Offset = "0x3117810", VA = "0x183118410")]
	public static T FMCLDHFEANJ<T>(this LOIMCLNPHOM LKGPHBHEBBE) where T : Enum
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3118DE0", Offset = "0x31181E0", VA = "0x183118DE0")]
	public static void OAGACINLKCP<T>(this LOIMCLNPHOM LKGPHBHEBBE, T HCPAOILCJCB) where T : Enum
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x71389F0", Offset = "0x7137DF0", VA = "0x1871389F0")]
	public static Enum FMCLDHFEANJ(this LOIMCLNPHOM LKGPHBHEBBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7138C10", Offset = "0x7138010", VA = "0x187138C10")]
	public static void OAGACINLKCP(this LOIMCLNPHOM LKGPHBHEBBE, Enum HCPAOILCJCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface BLIIBAONGBK
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	DFMAFHIFHME IHELNDFIDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMMNKIMGEKK(DFMAFHIFHME LADGDNIBDEA);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LIDBHOEHIJH<T> : GCEPACACNHA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Func<T> AFFENMAIGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Action<T> AJGPNDJEGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Func<T> NPNIBKPLBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GCEPACACNHA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string DKCJKHANLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Func<bool> KJHIOLPIMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NKJEKPHJAME();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface GNMPBAMPNOC
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKOIGPCFEMK(object BOJGOIDEENI, object DIDCPCJBMHM, Action ADDDDIHOJPH);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDMKLDGEKPL();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NKPACMGEDLB(string LJAGHAHCFHJ, int HPFPPNDKBPG = 0);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LEGNBIJCEGI();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBEBFGJNBJB();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LIDBHOEHIJH<bool> AJEEHPCCLBG();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LIDBHOEHIJH<float> HDIGLJHDGBH();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LIDBHOEHIJH<int> IIGPLCNOOOD();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LIDBHOEHIJH<string> AKFIIEDGKJH();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LIDBHOEHIJH<int> EJLKNPFKBND();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LIDBHOEHIJH<Enum> OMAAKNBFHCM(Type IFBDJLKPHIG);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LIDBHOEHIJH<Enum> EEJONPCILGO(Type IFBDJLKPHIG);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LIDBHOEHIJH<(int, int)> KOGHKEHBHGO();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GMNPOPJPEAO : FEBJKNPNDKM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HFFALABIPJN[] JEHEMNLEALB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	HFFALABIPJN[] BPONPCEEFLP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MAJMJCONDIK(LOIMCLNPHOM LKGPHBHEBBE, BLIIBAONGBK JCJAKDGGIEA, NIOCDOKHNKK KGEDIHCLOBM, GNMPBAMPNOC IMELNDMPIDE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FEBJKNPNDKM
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EHFDEMOIJMP : FIFPKIPNLNH, FEBJKNPNDKM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	HFFALABIPJN MHDHCLENANM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PMELNBNDICC : FIFPKIPNLNH, FEBJKNPNDKM
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HILFNMJKMKD(Type IFBDJLKPHIG);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FIFPKIPNLNH : FEBJKNPNDKM
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MAJMJCONDIK(LOIMCLNPHOM LKGPHBHEBBE, GNMPBAMPNOC IMELNDMPIDE);
}
namespace Cpp2IlInjected;

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
