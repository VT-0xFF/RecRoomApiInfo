using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DefaultMember("Item")]
public interface ONCHIGHBCLK : IEnumerable<BHEOFHMFIKM>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BHEOFHMFIKM : global::HLBOCHKIFEM<Entity>, LCNLFHMFGHB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DGDDKHEFDLH<T> : global::BPHMCLOOBEH<Entity, T>, global::HLBOCHKIFEM<Entity>, LCNLFHMFGHB, IDisposable, BHEOFHMFIKM where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface CBHILLHFNPB : BHEOFHMFIKM, global::HLBOCHKIFEM<Entity>, LCNLFHMFGHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	new int IKFDKJCKIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FKEDFHKNABD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2E20", Offset = "0x2FC2220", VA = "0x182FC2E20")]
	public static T EJNKBGFGIOK<T>(this global::DGDDKHEFDLH<T> MMNEFCOHNGA, Entity HHCOBCONNMJ, [Optional] T BICCJELLHLH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1A4D470", Offset = "0x1A4C870", VA = "0x181A4D470")]
	public static T IHBHDLPBOOO<T>(this global::HLBOCHKIFEM<Entity> MMNEFCOHNGA, Entity HHCOBCONNMJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2CA0", Offset = "0x2FC20A0", VA = "0x182FC2CA0")]
	public static bool BHKFGKHNKPG<T>(this global::HLBOCHKIFEM<Entity> MMNEFCOHNGA, Entity HHCOBCONNMJ, in T IGHGGFJEGCJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FEMEEEFLEPL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int GANJOFDJNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int ABBJGFLHJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Type PABJJAHPFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BHEOFHMFIKM[] OIPPKMDLCCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	(uint, uint) CHMBHGHBPNC(Entity HHCOBCONNMJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NNKNCNJJDHP(Entity HHCOBCONNMJ, (uint order, uint change) EGPHDEMHMDI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class OOEDMGJMLAO : CBHILLHFNPB, BHEOFHMFIKM, global::HLBOCHKIFEM<Entity>, LCNLFHMFGHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type KEFHMMCGAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract FEMEEEFLEPL IABMJLBFHHL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract LOCFHGIFEJD KDJPDLGGLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string EKGMLAPMPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x811A60", Offset = "0x810E60", VA = "0x180811A60")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int IKFDKJCKIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x80EC90", Offset = "0x80E090", VA = "0x18080EC90", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x80EE40", Offset = "0x80E240", VA = "0x18080EE40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event global::FJDMDFOKKFG<Entity> FLPEAEPONAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x170A230", Offset = "0x1709630", VA = "0x18170A230", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x170A190", Offset = "0x1709590", VA = "0x18170A190", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract bool JOIGBPFEMLO(Entity HHCOBCONNMJ);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool MGGBABNLJDA(Entity HHCOBCONNMJ, in object IGHGGFJEGCJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void LLPKLFBKNII(Entity HHCOBCONNMJ, in FKDDJKLFJDM EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract bool BCHEBCENJDG(Entity HHCOBCONNMJ, in GGCEFKOAKOD IGHGGFJEGCJ);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract bool HCDFGKMKPJF(Entity LOLIOKKJLEH, in GGCEFKOAKOD IGHGGFJEGCJ);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract void FAHCLIHABHM(MPGGIEDELKB BDKGFKBHNID, [Optional] object GEKPLLKAIKG);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract bool EADENLHKLFK(Entity ADPDPMGCAGF, Entity PMOIDBEHJHP);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	public abstract void OAGJEKOOFKN(EntityManager CLFAKBGHDNF);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x24D0300", Offset = "0x24CF700", VA = "0x1824D0300")]
	protected void CEDJJJICAMN<T>(Entity HHCOBCONNMJ, in T FELIJOLFGOE, in T IGHGGFJEGCJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	public abstract string NACLNNOLPLH(in GGCEFKOAKOD IBHKJCHAOOH);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	protected OOEDMGJMLAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public class AEKIACDKMJL<T> : OOEDMGJMLAO, global::DGDDKHEFDLH<T>, global::BPHMCLOOBEH<Entity, T>, global::HLBOCHKIFEM<Entity>, LCNLFHMFGHB, IDisposable, BHEOFHMFIKM, LOCFHGIFEJD where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate bool EKIAMFMFBMO(Entity HHCOBCONNMJ, in T IGHGGFJEGCJ);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void KEHIHJFINOE(Entity HHCOBCONNMJ, in T FELIJOLFGOE, in T IGHGGFJEGCJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly FEMEEEFLEPL DKHCFGEENMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FieldInfo MCCOIPHPCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly int POFPJBOBPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int OKCABOJFCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int ABBKELIMEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EKIAMFMFBMO AFIIKCJDNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private KEHIHJFINOE ECNPJCNMBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private KEHIHJFINOE FAGNEKOCIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private World MKIMPHJOKAN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override Type KEFHMMCGAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5F45410", Offset = "0x5F44810", VA = "0x185F45410", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override FEMEEEFLEPL IABMJLBFHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B00", Offset = "0x7F7F00", VA = "0x1807F8B00", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override LOCFHGIFEJD KDJPDLGGLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x991BC0", Offset = "0x990FC0", VA = "0x180991BC0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private FieldInfo JABFEGIOINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7F1280", Offset = "0x7F0680", VA = "0x1807F1280", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private int HNFJOOKGLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x89ECB0", Offset = "0x89E0B0", VA = "0x18089ECB0", Slot = "39")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int KGGACEOAJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x940490", Offset = "0x93F890", VA = "0x180940490", Slot = "40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EntityManager CPFDJDFIGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3403150", Offset = "0x3402550", VA = "0x183403150")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5F485F0", Offset = "0x5F479F0", VA = "0x185F485F0")]
	public AEKIACDKMJL(string LMAOKJPAKEM, FEMEEEFLEPL DKHCFGEENMO, FieldInfo MCCOIPHPCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3403470", Offset = "0x3402870", VA = "0x183403470", Slot = "33")]
	public override void OAGJEKOOFKN(EntityManager CLFAKBGHDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x34034A0", Offset = "0x34028A0", VA = "0x1834034A0")]
	public global::AEKIACDKMJL<T> PJKLLMDJCLF(EKIAMFMFBMO AFIIKCJDNIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x34030D0", Offset = "0x34024D0", VA = "0x1834030D0")]
	public global::AEKIACDKMJL<T> JIOJCEHDBNF(KEHIHJFINOE ECNPJCNMBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3403170", Offset = "0x3402570", VA = "0x183403170")]
	public global::AEKIACDKMJL<T> KIHBOBLMPNK(KEHIHJFINOE FAGNEKOCIBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5F464C0", Offset = "0x5F458C0", VA = "0x185F464C0", Slot = "35")]
	public T LLPKLFBKNII(Entity HHCOBCONNMJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5F43FA0", Offset = "0x5F433A0", VA = "0x185F43FA0")]
	public bool BCHEBCENJDG(Entity HHCOBCONNMJ, in T IGHGGFJEGCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3403000", Offset = "0x3402400", VA = "0x183403000")]
	public bool HCDFGKMKPJF(Entity HHCOBCONNMJ, in T IGHGGFJEGCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x34030F0", Offset = "0x34024F0", VA = "0x1834030F0", Slot = "25")]
	public override bool JOIGBPFEMLO(Entity HHCOBCONNMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5F468E0", Offset = "0x5F45CE0", VA = "0x185F468E0", Slot = "26")]
	public override bool MGGBABNLJDA(Entity HHCOBCONNMJ, in object IGHGGFJEGCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5F45FE0", Offset = "0x5F453E0", VA = "0x185F45FE0", Slot = "27")]
	public override void LLPKLFBKNII(Entity HHCOBCONNMJ, in FKDDJKLFJDM EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5F3F9C0", Offset = "0x5F3EDC0", VA = "0x185F3F9C0", Slot = "28")]
	public override bool BCHEBCENJDG(Entity HHCOBCONNMJ, in GGCEFKOAKOD IGHGGFJEGCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5F45060", Offset = "0x5F44460", VA = "0x185F45060", Slot = "29")]
	public override bool HCDFGKMKPJF(Entity HHCOBCONNMJ, in GGCEFKOAKOD IGHGGFJEGCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5F44BF0", Offset = "0x5F43FF0", VA = "0x185F44BF0", Slot = "30")]
	public override void FAHCLIHABHM(MPGGIEDELKB BDKGFKBHNID, [Optional] object GEKPLLKAIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5F44740", Offset = "0x5F43B40", VA = "0x185F44740", Slot = "31")]
	public override bool EADENLHKLFK(Entity ADPDPMGCAGF, Entity PMOIDBEHJHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "32")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5F475B0", Offset = "0x5F469B0", VA = "0x185F475B0", Slot = "34")]
	public override string NACLNNOLPLH(in GGCEFKOAKOD IBHKJCHAOOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3403310", Offset = "0x3402710", VA = "0x183403310")]
	private bool MAJHKDDMOKI(ref T FELIJOLFGOE, ref T IGHGGFJEGCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3402FA0", Offset = "0x34023A0", VA = "0x183402FA0", Slot = "36")]
	private bool GGOGOMDMNPD(Entity LOLIOKKJLEH, in T IGHGGFJEGCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3402FD0", Offset = "0x34023D0", VA = "0x183402FD0", Slot = "37")]
	private bool HBEPPBMGCDK(Entity LOLIOKKJLEH, in T IGHGGFJEGCJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void FJDMDFOKKFG<TKey>(TKey GHHNOPFOGCC, in GGCEFKOAKOD FELIJOLFGOE, in GGCEFKOAKOD IGHGGFJEGCJ);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class OLHPAKKOOIC
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x24CD810", Offset = "0x24CCC10", VA = "0x1824CD810")]
	public static void NKHICBNDNPN<TKey, T>(this global::FJDMDFOKKFG<TKey> PBFNEJHKGJA, TKey GHHNOPFOGCC, T FELIJOLFGOE, T IGHGGFJEGCJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MPGGIEDELKB
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJOFNKPMANL<TKey, T>(global::BPHMCLOOBEH<TKey, T> MMNEFCOHNGA, [Optional] object GEKPLLKAIKG) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JBEMNCNOCBO
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJOFNKPMANL(LCNLFHMFGHB MMNEFCOHNGA, in GGCEFKOAKOD EOEKGHMNIDN, [Optional] object GEKPLLKAIKG);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LOCFHGIFEJD
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FieldInfo DLPJBPNPCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int KOJCAHIFAGE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int PKAEOJAKEFH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LCNLFHMFGHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string EKGMLAPMPFM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Type KEFHMMCGAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	LOCFHGIFEJD KDJPDLGGLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	FEMEEEFLEPL IABMJLBFHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int IKFDKJCKIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FAHCLIHABHM(MPGGIEDELKB BDKGFKBHNID, [Optional] object GEKPLLKAIKG);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HLBOCHKIFEM<TKey> : LCNLFHMFGHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event global::FJDMDFOKKFG<TKey> FLPEAEPONAM;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JOIGBPFEMLO(TKey LOLIOKKJLEH);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MGGBABNLJDA(TKey LOLIOKKJLEH, in object IGHGGFJEGCJ);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LLPKLFBKNII(TKey LOLIOKKJLEH, in FKDDJKLFJDM EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BCHEBCENJDG(TKey LOLIOKKJLEH, in GGCEFKOAKOD IGHGGFJEGCJ);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HCDFGKMKPJF(TKey LOLIOKKJLEH, in GGCEFKOAKOD IGHGGFJEGCJ);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EADENLHKLFK(TKey ADPDPMGCAGF, TKey PMOIDBEHJHP);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string NACLNNOLPLH(in GGCEFKOAKOD EOEKGHMNIDN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface BPHMCLOOBEH<TKey, T> : global::HLBOCHKIFEM<TKey>, LCNLFHMFGHB, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T LLPKLFBKNII(TKey LOLIOKKJLEH);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BCHEBCENJDG(TKey LOLIOKKJLEH, in T IGHGGFJEGCJ);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HCDFGKMKPJF(TKey LOLIOKKJLEH, in T IGHGGFJEGCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HABOOLPEJEO
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9BD0", Offset = "0x2CE8FD0", VA = "0x182CE9BD0")]
	public static bool EPJAPKGCCDE<TKey, T>(this global::HLBOCHKIFEM<TKey> MMNEFCOHNGA, TKey LOLIOKKJLEH, out T EOEKGHMNIDN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA400", Offset = "0x2CE9800", VA = "0x182CEA400")]
	public static T LLPKLFBKNII<T, TKey>(this global::HLBOCHKIFEM<TKey> MMNEFCOHNGA, TKey LOLIOKKJLEH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9360", Offset = "0x2CE8760", VA = "0x182CE9360")]
	public static bool BCHEBCENJDG<TKey, T>(this global::HLBOCHKIFEM<TKey> MMNEFCOHNGA, TKey LOLIOKKJLEH, T IGHGGFJEGCJ) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9D70", Offset = "0x2CE9170", VA = "0x182CE9D70")]
	public static bool HCDFGKMKPJF<TKey, T>(this global::HLBOCHKIFEM<TKey> MMNEFCOHNGA, TKey LOLIOKKJLEH, T IGHGGFJEGCJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct GPHNDJBMNHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly Type ONBHBHIHHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly string LMAOKJPAKEM;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA1F0E0", Offset = "0xA1E4E0", VA = "0x180A1F0E0")]
	public GPHNDJBMNHN(Type ONBHBHIHHNE, string LMAOKJPAKEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct BLOOENFJLDB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly Type ONBHBHIHHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly string LMAOKJPAKEM;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA1F0E0", Offset = "0xA1E4E0", VA = "0x180A1F0E0")]
	public BLOOENFJLDB(Type ONBHBHIHHNE, string LMAOKJPAKEM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x37E96C0", Offset = "0x37E8AC0", VA = "0x1837E96C0")]
	public static GPHNDJBMNHN CHCALEAGEKJ(global::BLOOENFJLDB<T> IIMLJGGDHEG)
	{
		return default(GPHNDJBMNHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum DMGGKMKPCOO
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	CreateObject = -2,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DestroyObject = -3,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	BeginTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	EndTransaction = -5,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	External = -6
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class GFJHCHNKAKB : ONCHIGHBCLK, IEnumerable<BHEOFHMFIKM>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly List<BHEOFHMFIKM> AKADJEAPPMF;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int KLCJBBHGHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x170A110", Offset = "0x1709510", VA = "0x18170A110", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BHEOFHMFIKM KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x170A030", Offset = "0x1709430", VA = "0x18170A030", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x170A150", Offset = "0x1709550", VA = "0x18170A150")]
	public GFJHCHNKAKB(IEnumerable<FEMEEEFLEPL> MGJECDACHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1709B40", Offset = "0x1708F40", VA = "0x181709B40")]
	private List<BHEOFHMFIKM> AHJAEBIIJPC(IEnumerable<FEMEEEFLEPL> MGJECDACHNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x170A090", Offset = "0x1709490", VA = "0x18170A090", Slot = "4")]
	public IEnumerator<BHEOFHMFIKM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x170A090", Offset = "0x1709490", VA = "0x18170A090", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class AOIEPJGNBNP
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public AOIEPJGNBNP()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
