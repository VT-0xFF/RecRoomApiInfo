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
	[Cpp2IlInjected.Address(RVA = "0x202B280", Offset = "0x2029E80", VA = "0x18202B280")]
	public static T HHJBLJEFAKG<T>(this global::OMNMPKLMELI<T> PIKMJGOIABL, Entity CMBJDMJHALL, [Optional] T IGBKLJLDCLC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x202B170", Offset = "0x2029D70", VA = "0x18202B170")]
	public static T GCHGIFGBMBE<T>(this global::BADCGGCOPPF<Entity> PIKMJGOIABL, Entity CMBJDMJHALL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x202B3F0", Offset = "0x2029FF0", VA = "0x18202B3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F3030", Offset = "0x7F1C30", VA = "0x1807F3030")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int GEOBAFLMIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F0230", Offset = "0x7EEE30", VA = "0x1807F0230", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F03F0", Offset = "0x7EEFF0", VA = "0x1807F03F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event global::IAFEPFCMIPE<Entity> JFOOFDKLBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5E60", Offset = "0x6FD4A60", VA = "0x186FD5E60", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5DC0", Offset = "0x6FD49C0", VA = "0x186FD5DC0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E65CB0", Offset = "0x4E648B0", VA = "0x184E65CB0")]
	protected void MEOKPGFBPDB<T>(Entity CMBJDMJHALL, in T ILHPLIOAKIK, in T PHMLIFLNFDO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	public abstract string AHOIENBLHDM(in CCENOJCALNE LOMABJDBEAJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x51D81C0", Offset = "0x51D6DC0", VA = "0x1851D81C0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override PHIGEONMPOB FEOJPOAINBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7F0240", Offset = "0x7EEE40", VA = "0x1807F0240", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override IMPHGGCICNN NMCOIOMABBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8D5ED0", Offset = "0x8D4AD0", VA = "0x1808D5ED0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private FieldInfo EBMJBHHFKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x84D780", Offset = "0x84C380", VA = "0x18084D780", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private int NOFFDJLMOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xB77200", Offset = "0xB75E00", VA = "0x180B77200", Slot = "39")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int GDPDJKEDMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x884740", Offset = "0x883340", VA = "0x180884740", Slot = "40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EntityManager EHBCKOIMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2EB2DB0", Offset = "0x2EB19B0", VA = "0x182EB2DB0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4E60", Offset = "0x2EB3A60", VA = "0x182EB4E60")]
	public HIDJNHIEDBL(string BPOKAAOBIOI, PHIGEONMPOB IAHKGFLACPN, FieldInfo CKLMJLCBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2EB48B0", Offset = "0x2EB34B0", VA = "0x182EB48B0", Slot = "33")]
	public override void PBAELFIBGFO(EntityManager LMJGFJDJJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2EB3380", Offset = "0x2EB1F80", VA = "0x182EB3380")]
	public global::HIDJNHIEDBL<T> HMEFICDIDBP(HCEHJPKBHIB OFGBKBMOOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2EB33C0", Offset = "0x2EB1FC0", VA = "0x182EB33C0")]
	public global::HIDJNHIEDBL<T> LMGHLBPKMDP(KMEPIDLFPDB NEAEPOEIIHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2EB33A0", Offset = "0x2EB1FA0", VA = "0x182EB33A0")]
	public global::HIDJNHIEDBL<T> LBACAFOBHCO(KMEPIDLFPDB CNAPAEHHBOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4AC0", Offset = "0x2EB36C0", VA = "0x182EB4AC0", Slot = "35")]
	public T PNBJHLBKMLC(Entity CMBJDMJHALL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x51D9910", Offset = "0x51D8510", VA = "0x1851D9910")]
	public bool OLBGCODNBJK(Entity CMBJDMJHALL, in T PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2EB2DD0", Offset = "0x2EB19D0", VA = "0x182EB2DD0")]
	public bool FKEIONKDNMA(Entity CMBJDMJHALL, in T PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2EB48E0", Offset = "0x2EB34E0", VA = "0x182EB48E0", Slot = "25")]
	public override bool PFHINLDLMKG(Entity CMBJDMJHALL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2EB2780", Offset = "0x2EB1380", VA = "0x182EB2780", Slot = "26")]
	public override bool BHBEDFKCKIO(Entity CMBJDMJHALL, in object PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4A40", Offset = "0x2EB3640", VA = "0x182EB4A40", Slot = "27")]
	public override void PNBJHLBKMLC(Entity CMBJDMJHALL, in EGEPCBOCIHN ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4230", Offset = "0x2EB2E30", VA = "0x182EB4230", Slot = "28")]
	public override bool OLBGCODNBJK(Entity CMBJDMJHALL, in CCENOJCALNE PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2EB2E10", Offset = "0x2EB1A10", VA = "0x182EB2E10", Slot = "29")]
	public override bool FKEIONKDNMA(Entity CMBJDMJHALL, in CCENOJCALNE PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2EB2D80", Offset = "0x2EB1980", VA = "0x182EB2D80", Slot = "30")]
	public override void CIPFBNJMJCJ(CCPEEPIKMJA OJEIGCLOKPD, [Optional] object JFDMKPDIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2EB2CB0", Offset = "0x2EB18B0", VA = "0x182EB2CB0", Slot = "31")]
	public override bool BOIMNMIKDGA(Entity EBICJNCHIIB, Entity LBADBCNNFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "32")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x51D6A00", Offset = "0x51D5600", VA = "0x1851D6A00", Slot = "34")]
	public override string AHOIENBLHDM(in CCENOJCALNE LOMABJDBEAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2EB3090", Offset = "0x2EB1C90", VA = "0x182EB3090")]
	private bool FMOLALLCICL(ref T ILHPLIOAKIK, ref T PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2EB33E0", Offset = "0x2EB1FE0", VA = "0x182EB33E0", Slot = "36")]
	private bool LPHCPBNNJDH(Entity BDFCACLHAFA, in T PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2EB3060", Offset = "0x2EB1C60", VA = "0x182EB3060", Slot = "37")]
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
	[Cpp2IlInjected.Address(RVA = "0x1956A20", Offset = "0x1955620", VA = "0x181956A20")]
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
	[Cpp2IlInjected.Address(RVA = "0x262D8D0", Offset = "0x262C4D0", VA = "0x18262D8D0")]
	public static bool PFLIDDOFNIB<TKey, T>(this global::BADCGGCOPPF<TKey> PIKMJGOIABL, TKey BDFCACLHAFA, out T ECNGHFJBIJL) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x262DA70", Offset = "0x262C670", VA = "0x18262DA70")]
	public static T PNBJHLBKMLC<T, TKey>(this global::BADCGGCOPPF<TKey> PIKMJGOIABL, TKey BDFCACLHAFA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x262D060", Offset = "0x262BC60", VA = "0x18262D060")]
	public static bool OLBGCODNBJK<TKey, T>(this global::BADCGGCOPPF<TKey> PIKMJGOIABL, TKey BDFCACLHAFA, T PHMLIFLNFDO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x262C9D0", Offset = "0x262B5D0", VA = "0x18262C9D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x96B830", Offset = "0x96A430", VA = "0x18096B830")]
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
	[Cpp2IlInjected.Address(RVA = "0x96B830", Offset = "0x96A430", VA = "0x18096B830")]
	public MDFMNLBADDB(Type FIJCKHKKDCC, string BPOKAAOBIOI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x38594C0", Offset = "0x38580C0", VA = "0x1838594C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FD64D0", Offset = "0x6FD50D0", VA = "0x186FD64D0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public DAEIOAAPCOE OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5F00", Offset = "0x6FD4B00", VA = "0x186FD5F00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6510", Offset = "0x6FD5110", VA = "0x186FD6510")]
	public ICBNDMJBEDL(IEnumerable<PHIGEONMPOB> HCHCLBKCAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5FE0", Offset = "0x6FD4BE0", VA = "0x186FD5FE0")]
	private List<DAEIOAAPCOE> JLOKPKEOGGI(IEnumerable<PHIGEONMPOB> HCHCLBKCAJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5F60", Offset = "0x6FD4B60", VA = "0x186FD5F60", Slot = "4")]
	public IEnumerator<DAEIOAAPCOE> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5F60", Offset = "0x6FD4B60", VA = "0x186FD5F60", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
