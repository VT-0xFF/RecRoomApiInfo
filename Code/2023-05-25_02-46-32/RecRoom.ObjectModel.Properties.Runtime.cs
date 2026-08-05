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
public interface CGGAALKGBJJ : IEnumerable<DAEIOAAPCOE>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DAEIOAAPCOE : global::BADCGGCOPPF<Entity>, BEOGCACODJA, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OMNMPKLMELI<T> : global::DNKKAPAMMED<Entity, T>, global::BADCGGCOPPF<Entity>, BEOGCACODJA, IDisposable, DAEIOAAPCOE where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface JKDIPAKADCG : DAEIOAAPCOE, global::BADCGGCOPPF<Entity>, BEOGCACODJA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	new int GEOBAFLMIGN
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
public static class FKNLNFIIJJB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x240E3A0", Offset = "0x240CBA0", VA = "0x18240E3A0")]
	public static T HHJBLJEFAKG<T>(this global::OMNMPKLMELI<T> PIKMJGOIABL, Entity CMBJDMJHALL, [Optional] T IGBKLJLDCLC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x240E290", Offset = "0x240CA90", VA = "0x18240E290")]
	public static T GCHGIFGBMBE<T>(this global::BADCGGCOPPF<Entity> PIKMJGOIABL, Entity CMBJDMJHALL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x240E510", Offset = "0x240CD10", VA = "0x18240E510")]
	public static bool MNBHKBFFHBK<T>(this global::BADCGGCOPPF<Entity> PIKMJGOIABL, Entity CMBJDMJHALL, in T PHMLIFLNFDO) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PHIGEONMPOB
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int GNHFECBNMGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int KKDFANILMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Type EEJHOAPKJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DAEIOAAPCOE[] IMGJKIMNGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	(uint, uint) ILHBPGJKDMF(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MFIELPFAIPE(Entity CMBJDMJHALL, (uint order, uint change) FPBNFBFIPHI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class BNHNLLOLFLI : JKDIPAKADCG, DAEIOAAPCOE, global::BADCGGCOPPF<Entity>, BEOGCACODJA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type JFINBJKLHCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract PHIGEONMPOB FEOJPOAINBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract IMPHGGCICNN NMCOIOMABBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string EKPDCEFJBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x811A70", Offset = "0x810270", VA = "0x180811A70")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int GEOBAFLMIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x80ECA0", Offset = "0x80D4A0", VA = "0x18080ECA0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x80EE50", Offset = "0x80D650", VA = "0x18080EE50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event global::IAFEPFCMIPE<Entity> JFOOFDKLBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1689830", Offset = "0x1688030", VA = "0x181689830", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1689790", Offset = "0x1687F90", VA = "0x181689790", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract bool PFHINLDLMKG(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool BHBEDFKCKIO(Entity CMBJDMJHALL, in object PHMLIFLNFDO);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void PNBJHLBKMLC(Entity CMBJDMJHALL, in EGEPCBOCIHN ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract bool OLBGCODNBJK(Entity CMBJDMJHALL, in CCENOJCALNE PHMLIFLNFDO);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract bool FKEIONKDNMA(Entity BDFCACLHAFA, in CCENOJCALNE PHMLIFLNFDO);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract void CIPFBNJMJCJ(CCPEEPIKMJA OJEIGCLOKPD, [Optional] object JFDMKPDIBDL);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract bool BOIMNMIKDGA(Entity EBICJNCHIIB, Entity LBADBCNNFAH);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	public abstract void PBAELFIBGFO(EntityManager LMJGFJDJJLA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4BB38A0", Offset = "0x4BB20A0", VA = "0x184BB38A0")]
	protected void MEOKPGFBPDB<T>(Entity CMBJDMJHALL, in T ILHPLIOAKIK, in T PHMLIFLNFDO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	public abstract string AHOIENBLHDM(in CCENOJCALNE LOMABJDBEAJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	protected BNHNLLOLFLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public class HIDJNHIEDBL<T> : BNHNLLOLFLI, global::OMNMPKLMELI<T>, global::DNKKAPAMMED<Entity, T>, global::BADCGGCOPPF<Entity>, BEOGCACODJA, IDisposable, DAEIOAAPCOE, IMPHGGCICNN where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate bool HCEHJPKBHIB(Entity CMBJDMJHALL, in T PHMLIFLNFDO);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void KMEPIDLFPDB(Entity CMBJDMJHALL, in T ILHPLIOAKIK, in T PHMLIFLNFDO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly PHIGEONMPOB IAHKGFLACPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FieldInfo CKLMJLCBLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly int GJCJMGJCOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int MCMFGBNCCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int GEFPLPIBMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HCEHJPKBHIB OFGBKBMOOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private KMEPIDLFPDB NEAEPOEIIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private KMEPIDLFPDB CNAPAEHHBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private World GPEEKLGBDDJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override Type JFINBJKLHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4938820", Offset = "0x4937020", VA = "0x184938820", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override PHIGEONMPOB FEOJPOAINBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CE0", Offset = "0x7F14E0", VA = "0x1807F2CE0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override IMPHGGCICNN NMCOIOMABBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x94BA40", Offset = "0x94A240", VA = "0x18094BA40", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private FieldInfo EBMJBHHFKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A40", Offset = "0x7F1240", VA = "0x1807F2A40", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private int NOFFDJLMOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC25B90", Offset = "0xC24390", VA = "0x180C25B90", Slot = "39")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int GDPDJKEDMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2B0", Offset = "0x8F8AB0", VA = "0x1808FA2B0", Slot = "40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EntityManager EHBCKOIMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4529640", Offset = "0x4527E40", VA = "0x184529640")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x452E880", Offset = "0x452D080", VA = "0x18452E880")]
	public HIDJNHIEDBL(string BPOKAAOBIOI, PHIGEONMPOB IAHKGFLACPN, FieldInfo CKLMJLCBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x452DDC0", Offset = "0x452C5C0", VA = "0x18452DDC0", Slot = "33")]
	public override void PBAELFIBGFO(EntityManager LMJGFJDJJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x452A3E0", Offset = "0x4528BE0", VA = "0x18452A3E0")]
	public global::HIDJNHIEDBL<T> HMEFICDIDBP(HCEHJPKBHIB OFGBKBMOOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x452A420", Offset = "0x4528C20", VA = "0x18452A420")]
	public global::HIDJNHIEDBL<T> LMGHLBPKMDP(KMEPIDLFPDB NEAEPOEIIHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x452A400", Offset = "0x4528C00", VA = "0x18452A400")]
	public global::HIDJNHIEDBL<T> LBACAFOBHCO(KMEPIDLFPDB CNAPAEHHBOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x452E1D0", Offset = "0x452C9D0", VA = "0x18452E1D0", Slot = "35")]
	public T PNBJHLBKMLC(Entity CMBJDMJHALL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4939360", Offset = "0x4937B60", VA = "0x184939360")]
	public bool OLBGCODNBJK(Entity CMBJDMJHALL, in T PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4529660", Offset = "0x4527E60", VA = "0x184529660")]
	public bool FKEIONKDNMA(Entity CMBJDMJHALL, in T PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x452DDF0", Offset = "0x452C5F0", VA = "0x18452DDF0", Slot = "25")]
	public override bool PFHINLDLMKG(Entity CMBJDMJHALL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4528CF0", Offset = "0x45274F0", VA = "0x184528CF0", Slot = "26")]
	public override bool BHBEDFKCKIO(Entity CMBJDMJHALL, in object PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x452E0B0", Offset = "0x452C8B0", VA = "0x18452E0B0", Slot = "27")]
	public override void PNBJHLBKMLC(Entity CMBJDMJHALL, in EGEPCBOCIHN ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x452C490", Offset = "0x452AC90", VA = "0x18452C490", Slot = "28")]
	public override bool OLBGCODNBJK(Entity CMBJDMJHALL, in CCENOJCALNE PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4529730", Offset = "0x4527F30", VA = "0x184529730", Slot = "29")]
	public override bool FKEIONKDNMA(Entity CMBJDMJHALL, in CCENOJCALNE PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4529610", Offset = "0x4527E10", VA = "0x184529610", Slot = "30")]
	public override void CIPFBNJMJCJ(CCPEEPIKMJA OJEIGCLOKPD, [Optional] object JFDMKPDIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4529460", Offset = "0x4527C60", VA = "0x184529460", Slot = "31")]
	public override bool BOIMNMIKDGA(Entity EBICJNCHIIB, Entity LBADBCNNFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "32")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4937E30", Offset = "0x4936630", VA = "0x184937E30", Slot = "34")]
	public override string AHOIENBLHDM(in CCENOJCALNE LOMABJDBEAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4529C10", Offset = "0x4528410", VA = "0x184529C10")]
	private bool FMOLALLCICL(ref T ILHPLIOAKIK, ref T PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x452A440", Offset = "0x4528C40", VA = "0x18452A440", Slot = "36")]
	private bool LPHCPBNNJDH(Entity BDFCACLHAFA, in T PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4529BE0", Offset = "0x45283E0", VA = "0x184529BE0", Slot = "37")]
	private bool FKOBKINKBAG(Entity BDFCACLHAFA, in T PHMLIFLNFDO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void IAFEPFCMIPE<TKey>(TKey HHNPCHNMLMA, in CCENOJCALNE ILHPLIOAKIK, in CCENOJCALNE PHMLIFLNFDO);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class ADEKPDGCCOO
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1C3EB30", Offset = "0x1C3D330", VA = "0x181C3EB30")]
	public static void MKOHINBGHOB<TKey, T>(this global::IAFEPFCMIPE<TKey> NMPOOPDGJFD, TKey HHNPCHNMLMA, T ILHPLIOAKIK, T PHMLIFLNFDO) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CCPEEPIKMJA
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AONDHCPDGOF<TKey, T>(global::DNKKAPAMMED<TKey, T> PIKMJGOIABL, [Optional] object JFDMKPDIBDL) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GEGNLMFOEIB
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AONDHCPDGOF(BEOGCACODJA PIKMJGOIABL, in CCENOJCALNE ECNGHFJBIJL, [Optional] object JFDMKPDIBDL);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IMPHGGCICNN
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FieldInfo KIAJICNDNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int OIABMDMAMBN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int NPEKKJBJFOP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface BEOGCACODJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string EKPDCEFJBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Type JFINBJKLHCN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	IMPHGGCICNN NMCOIOMABBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	PHIGEONMPOB FEOJPOAINBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int GEOBAFLMIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CIPFBNJMJCJ(CCPEEPIKMJA OJEIGCLOKPD, [Optional] object JFDMKPDIBDL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BADCGGCOPPF<TKey> : BEOGCACODJA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event global::IAFEPFCMIPE<TKey> JFOOFDKLBEJ;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PFHINLDLMKG(TKey BDFCACLHAFA);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BHBEDFKCKIO(TKey BDFCACLHAFA, in object PHMLIFLNFDO);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PNBJHLBKMLC(TKey BDFCACLHAFA, in EGEPCBOCIHN ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OLBGCODNBJK(TKey BDFCACLHAFA, in CCENOJCALNE PHMLIFLNFDO);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FKEIONKDNMA(TKey BDFCACLHAFA, in CCENOJCALNE PHMLIFLNFDO);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BOIMNMIKDGA(TKey EBICJNCHIIB, TKey LBADBCNNFAH);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string AHOIENBLHDM(in CCENOJCALNE ECNGHFJBIJL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface DNKKAPAMMED<TKey, T> : global::BADCGGCOPPF<TKey>, BEOGCACODJA, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T PNBJHLBKMLC(TKey BDFCACLHAFA);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OLBGCODNBJK(TKey BDFCACLHAFA, in T PHMLIFLNFDO);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FKEIONKDNMA(TKey BDFCACLHAFA, in T PHMLIFLNFDO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class LCHDDKLMDEM
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x28F7330", Offset = "0x28F5B30", VA = "0x1828F7330")]
	public static bool PFLIDDOFNIB<TKey, T>(this global::BADCGGCOPPF<TKey> PIKMJGOIABL, TKey BDFCACLHAFA, out T ECNGHFJBIJL) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x28F74D0", Offset = "0x28F5CD0", VA = "0x1828F74D0")]
	public static T PNBJHLBKMLC<T, TKey>(this global::BADCGGCOPPF<TKey> PIKMJGOIABL, TKey BDFCACLHAFA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28F6AC0", Offset = "0x28F52C0", VA = "0x1828F6AC0")]
	public static bool OLBGCODNBJK<TKey, T>(this global::BADCGGCOPPF<TKey> PIKMJGOIABL, TKey BDFCACLHAFA, T PHMLIFLNFDO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x28F6430", Offset = "0x28F4C30", VA = "0x1828F6430")]
	public static bool FKEIONKDNMA<TKey, T>(this global::BADCGGCOPPF<TKey> PIKMJGOIABL, TKey BDFCACLHAFA, T PHMLIFLNFDO) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct GGIKBJPJGCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly Type FIJCKHKKDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly string BPOKAAOBIOI;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9E1370", Offset = "0x9DFB70", VA = "0x1809E1370")]
	public GGIKBJPJGCF(Type FIJCKHKKDCC, string BPOKAAOBIOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MDFMNLBADDB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly Type FIJCKHKKDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly string BPOKAAOBIOI;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9E1370", Offset = "0x9DFB70", VA = "0x1809E1370")]
	public MDFMNLBADDB(Type FIJCKHKKDCC, string BPOKAAOBIOI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x365B490", Offset = "0x3659C90", VA = "0x18365B490")]
	public static GGIKBJPJGCF DKPIGINFCAE(global::MDFMNLBADDB<T> GOBHOIOANDE)
	{
		return default(GGIKBJPJGCF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum MMJJEFFJJAJ
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
public class ICBNDMJBEDL : CGGAALKGBJJ, IEnumerable<DAEIOAAPCOE>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly List<DAEIOAAPCOE> CMLDHGKDOMA;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1689EA0", Offset = "0x16886A0", VA = "0x181689EA0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public DAEIOAAPCOE OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x16898D0", Offset = "0x16880D0", VA = "0x1816898D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1689EE0", Offset = "0x16886E0", VA = "0x181689EE0")]
	public ICBNDMJBEDL(IEnumerable<PHIGEONMPOB> HCHCLBKCAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x16899B0", Offset = "0x16881B0", VA = "0x1816899B0")]
	private List<DAEIOAAPCOE> JLOKPKEOGGI(IEnumerable<PHIGEONMPOB> HCHCLBKCAJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1689930", Offset = "0x1688130", VA = "0x181689930", Slot = "4")]
	public IEnumerator<DAEIOAAPCOE> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1689930", Offset = "0x1688130", VA = "0x181689930", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
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
