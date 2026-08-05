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
public interface DAEIOAAPCOE : BADCGGCOPPF<Entity>, BEOGCACODJA, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OMNMPKLMELI<T> : DNKKAPAMMED<Entity, T>, BADCGGCOPPF<Entity>, BEOGCACODJA, IDisposable, DAEIOAAPCOE where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface JKDIPAKADCG : DAEIOAAPCOE, BADCGGCOPPF<Entity>, BEOGCACODJA, IDisposable
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
	[Cpp2IlInjected.Address(RVA = "0x1E0E030", Offset = "0x1E0CC30", VA = "0x181E0E030")]
	public static T HHJBLJEFAKG<T>(this OMNMPKLMELI<T> PIKMJGOIABL, Entity CMBJDMJHALL, [Optional] T IGBKLJLDCLC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1E0DF20", Offset = "0x1E0CB20", VA = "0x181E0DF20")]
	public static T GCHGIFGBMBE<T>(this BADCGGCOPPF<Entity> PIKMJGOIABL, Entity CMBJDMJHALL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1E0E1A0", Offset = "0x1E0CDA0", VA = "0x181E0E1A0")]
	public static bool MNBHKBFFHBK<T>(this BADCGGCOPPF<Entity> PIKMJGOIABL, Entity CMBJDMJHALL, in T PHMLIFLNFDO) where T : struct
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
public abstract class BNHNLLOLFLI : JKDIPAKADCG, DAEIOAAPCOE, BADCGGCOPPF<Entity>, BEOGCACODJA, IDisposable
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
		[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F6030", Offset = "0x7F4C30", VA = "0x1807F6030")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int GEOBAFLMIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F3230", Offset = "0x7F1E30", VA = "0x1807F3230", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F33F0", Offset = "0x7F1FF0", VA = "0x1807F33F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event IAFEPFCMIPE<Entity> JFOOFDKLBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1260", Offset = "0x6FEFE60", VA = "0x186FF1260", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF11C0", Offset = "0x6FEFDC0", VA = "0x186FF11C0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x4C949E0", Offset = "0x4C935E0", VA = "0x184C949E0")]
	protected void MEOKPGFBPDB<T>(Entity CMBJDMJHALL, in T ILHPLIOAKIK, in T PHMLIFLNFDO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	public abstract string AHOIENBLHDM(in CCENOJCALNE LOMABJDBEAJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	protected BNHNLLOLFLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public class HIDJNHIEDBL<T> : BNHNLLOLFLI, OMNMPKLMELI<T>, DNKKAPAMMED<Entity, T>, BADCGGCOPPF<Entity>, BEOGCACODJA, IDisposable, DAEIOAAPCOE, IMPHGGCICNN where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate bool CBJOIJBOCPB(Entity CMBJDMJHALL, in T PHMLIFLNFDO);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void EDPNCGLIFMO(Entity CMBJDMJHALL, in T ILHPLIOAKIK, in T PHMLIFLNFDO);

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
	private CBJOIJBOCPB OFGBKBMOOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private EDPNCGLIFMO NEAEPOEIIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private EDPNCGLIFMO CNAPAEHHBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private World GPEEKLGBDDJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override Type JFINBJKLHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x45089D0", Offset = "0x45075D0", VA = "0x1845089D0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override PHIGEONMPOB FEOJPOAINBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7F3240", Offset = "0x7F1E40", VA = "0x1807F3240", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override IMPHGGCICNN NMCOIOMABBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9C6D70", Offset = "0x9C5970", VA = "0x1809C6D70", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private FieldInfo EBMJBHHFKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x838FF0", Offset = "0x837BF0", VA = "0x180838FF0", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private int NOFFDJLMOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xB00880", Offset = "0xAFF480", VA = "0x180B00880", Slot = "39")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int GDPDJKEDMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x870100", Offset = "0x86ED00", VA = "0x180870100", Slot = "40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EntityManager EHBCKOIMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3FFBAA0", Offset = "0x3FFA6A0", VA = "0x183FFBAA0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4001AF0", Offset = "0x40006F0", VA = "0x184001AF0")]
	public HIDJNHIEDBL(string BPOKAAOBIOI, PHIGEONMPOB IAHKGFLACPN, FieldInfo CKLMJLCBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4000220", Offset = "0x3FFEE20", VA = "0x184000220", Slot = "33")]
	public override void PBAELFIBGFO(EntityManager LMJGFJDJJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3FFC840", Offset = "0x3FFB440", VA = "0x183FFC840")]
	public HIDJNHIEDBL<T> HMEFICDIDBP(CBJOIJBOCPB OFGBKBMOOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3FFC880", Offset = "0x3FFB480", VA = "0x183FFC880")]
	public HIDJNHIEDBL<T> LMGHLBPKMDP(EDPNCGLIFMO NEAEPOEIIHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3FFC860", Offset = "0x3FFB460", VA = "0x183FFC860")]
	public HIDJNHIEDBL<T> LBACAFOBHCO(EDPNCGLIFMO CNAPAEHHBOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x40007B0", Offset = "0x3FFF3B0", VA = "0x1840007B0", Slot = "35")]
	public T PNBJHLBKMLC(Entity CMBJDMJHALL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4508A90", Offset = "0x4507690", VA = "0x184508A90")]
	public bool OLBGCODNBJK(Entity CMBJDMJHALL, in T PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3FFBB50", Offset = "0x3FFA750", VA = "0x183FFBB50")]
	public bool FKEIONKDNMA(Entity CMBJDMJHALL, in T PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4000250", Offset = "0x3FFEE50", VA = "0x184000250", Slot = "25")]
	public override bool PFHINLDLMKG(Entity CMBJDMJHALL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3FFAFD0", Offset = "0x3FF9BD0", VA = "0x183FFAFD0", Slot = "26")]
	public override bool BHBEDFKCKIO(Entity CMBJDMJHALL, in object PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4000900", Offset = "0x3FFF500", VA = "0x184000900", Slot = "27")]
	public override void PNBJHLBKMLC(Entity CMBJDMJHALL, in EGEPCBOCIHN ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3FFCFC0", Offset = "0x3FFBBC0", VA = "0x183FFCFC0", Slot = "28")]
	public override bool OLBGCODNBJK(Entity CMBJDMJHALL, in CCENOJCALNE PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3FFBE80", Offset = "0x3FFAA80", VA = "0x183FFBE80", Slot = "29")]
	public override bool FKEIONKDNMA(Entity CMBJDMJHALL, in CCENOJCALNE PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3FFBA70", Offset = "0x3FFA670", VA = "0x183FFBA70", Slot = "30")]
	public override void CIPFBNJMJCJ(CCPEEPIKMJA OJEIGCLOKPD, [Optional] object JFDMKPDIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3FFB5B0", Offset = "0x3FFA1B0", VA = "0x183FFB5B0", Slot = "31")]
	public override bool BOIMNMIKDGA(Entity EBICJNCHIIB, Entity LBADBCNNFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "32")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4507F50", Offset = "0x4506B50", VA = "0x184507F50", Slot = "34")]
	public override string AHOIENBLHDM(in CCENOJCALNE LOMABJDBEAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3FFC070", Offset = "0x3FFAC70", VA = "0x183FFC070")]
	private bool FMOLALLCICL(ref T ILHPLIOAKIK, ref T PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3FFC8A0", Offset = "0x3FFB4A0", VA = "0x183FFC8A0", Slot = "36")]
	private bool LPHCPBNNJDH(Entity BDFCACLHAFA, in T PHMLIFLNFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3FFC040", Offset = "0x3FFAC40", VA = "0x183FFC040", Slot = "37")]
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
	[Cpp2IlInjected.Address(RVA = "0x174CE10", Offset = "0x174BA10", VA = "0x18174CE10")]
	public static void MKOHINBGHOB<TKey, T>(this IAFEPFCMIPE<TKey> NMPOOPDGJFD, TKey HHNPCHNMLMA, T ILHPLIOAKIK, T PHMLIFLNFDO) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CCPEEPIKMJA
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AONDHCPDGOF<TKey, T>(DNKKAPAMMED<TKey, T> PIKMJGOIABL, [Optional] object JFDMKPDIBDL) where T : struct;
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
	event IAFEPFCMIPE<TKey> JFOOFDKLBEJ;

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
public interface DNKKAPAMMED<TKey, T> : BADCGGCOPPF<TKey>, BEOGCACODJA, IDisposable where T : struct
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
	[Cpp2IlInjected.Address(RVA = "0x236FBB0", Offset = "0x236E7B0", VA = "0x18236FBB0")]
	public static bool PFLIDDOFNIB<TKey, T>(this BADCGGCOPPF<TKey> PIKMJGOIABL, TKey BDFCACLHAFA, out T ECNGHFJBIJL) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x236FD50", Offset = "0x236E950", VA = "0x18236FD50")]
	public static T PNBJHLBKMLC<T, TKey>(this BADCGGCOPPF<TKey> PIKMJGOIABL, TKey BDFCACLHAFA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x236F340", Offset = "0x236DF40", VA = "0x18236F340")]
	public static bool OLBGCODNBJK<TKey, T>(this BADCGGCOPPF<TKey> PIKMJGOIABL, TKey BDFCACLHAFA, T PHMLIFLNFDO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x236ECB0", Offset = "0x236D8B0", VA = "0x18236ECB0")]
	public static bool FKEIONKDNMA<TKey, T>(this BADCGGCOPPF<TKey> PIKMJGOIABL, TKey BDFCACLHAFA, T PHMLIFLNFDO) where T : struct
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
	[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D0D0", VA = "0x18091E4D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D0D0", VA = "0x18091E4D0")]
	public MDFMNLBADDB(Type FIJCKHKKDCC, string BPOKAAOBIOI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3503430", Offset = "0x3502030", VA = "0x183503430")]
	public static GGIKBJPJGCF DKPIGINFCAE(MDFMNLBADDB<T> GOBHOIOANDE)
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
		[Cpp2IlInjected.Address(RVA = "0x6FF18D0", Offset = "0x6FF04D0", VA = "0x186FF18D0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public DAEIOAAPCOE OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1300", Offset = "0x6FEFF00", VA = "0x186FF1300", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1910", Offset = "0x6FF0510", VA = "0x186FF1910")]
	public ICBNDMJBEDL(IEnumerable<PHIGEONMPOB> HCHCLBKCAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF13E0", Offset = "0x6FEFFE0", VA = "0x186FF13E0")]
	private List<DAEIOAAPCOE> JLOKPKEOGGI(IEnumerable<PHIGEONMPOB> HCHCLBKCAJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1360", Offset = "0x6FEFF60", VA = "0x186FF1360", Slot = "4")]
	public IEnumerator<DAEIOAAPCOE> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1360", Offset = "0x6FEFF60", VA = "0x186FF1360", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public PFBBJKPLBFC()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
