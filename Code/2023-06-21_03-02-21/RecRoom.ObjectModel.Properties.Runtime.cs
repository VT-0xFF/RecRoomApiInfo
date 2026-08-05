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
public interface BNHABKGDABN : IEnumerable<HBGGGACDKNF>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HBGGGACDKNF : HEIHDOIHLCP<Entity>, JKEGKIMHFBI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KMAEHNPNKPE<T> : LDGDMCJHABE<Entity, T>, HEIHDOIHLCP<Entity>, JKEGKIMHFBI, IDisposable, HBGGGACDKNF where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface JOIHGHEOKPL : HBGGGACDKNF, HEIHDOIHLCP<Entity>, JKEGKIMHFBI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	new int DPODIOBCBIF
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
public static class OGHJCMICDNF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x34C65B0", Offset = "0x34C57B0", VA = "0x1834C65B0")]
	public static T IEHODMHIBOE<T>(this KMAEHNPNKPE<T> CKAKOJLMGFA, Entity FADPOFMJIJF, [Optional] T DDGOMDBNGFF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2AB0", Offset = "0x2AE1CB0", VA = "0x182AE2AB0")]
	public static T APPLNLCEBGC<T>(this HEIHDOIHLCP<Entity> CKAKOJLMGFA, Entity FADPOFMJIJF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x34C6430", Offset = "0x34C5630", VA = "0x1834C6430")]
	public static bool FAEEFOMAPPM<T>(this HEIHDOIHLCP<Entity> CKAKOJLMGFA, Entity FADPOFMJIJF, in T GFFDBEMENLA) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface INNOJNEKDJI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int MFGHJPFHFEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int IFFGAKEDHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Type INKNMGBPMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HBGGGACDKNF[] BFIJMMBMBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	(uint, uint) LNEPHPEGANN(Entity FADPOFMJIJF);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MMMAGGLADCL(Entity FADPOFMJIJF, (uint order, uint change) EJEDLELNMDA);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class LGKODIIKIGF : JOIHGHEOKPL, HBGGGACDKNF, HEIHDOIHLCP<Entity>, JKEGKIMHFBI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type PDFLIGHJGJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract INNOJNEKDJI CLGPBLBFGDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract HAJIABECHDJ MOGEJFKCLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string AOPINHAKJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x844AA0", Offset = "0x843CA0", VA = "0x180844AA0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int DPODIOBCBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x841C90", Offset = "0x840E90", VA = "0x180841C90", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x841E40", Offset = "0x841040", VA = "0x180841E40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event FDFIGJBJJAA<Entity> KMNFKMHHLGA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x15A57A0", Offset = "0x15A49A0", VA = "0x1815A57A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x15A5700", Offset = "0x15A4900", VA = "0x1815A5700", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract bool KMMKKFEGNCC(Entity FADPOFMJIJF);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool ICMJNMIGGKC(Entity FADPOFMJIJF, in object GFFDBEMENLA);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void MEINKDCJHDP(Entity FADPOFMJIJF, in JBLKIPLPNJE ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract bool EBIKLMMGLOI(Entity FADPOFMJIJF, in GMFPPNNBHJB GFFDBEMENLA);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract bool MAFAHIFMJOB(Entity PPNIGBBPGOI, in GMFPPNNBHJB GFFDBEMENLA);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract void NBJPEMCMJHM(BNEGEINEKAN CCINPGDJMFK, [Optional] object APPLJOFCBIB);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract bool DJIGAFGLBEH(Entity BLDOOIAGGHO, Entity KDAGJHGAEFN);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	public abstract void OHLMLHJNBAL(EntityManager NBACICFMHBN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3341DB0", Offset = "0x3340FB0", VA = "0x183341DB0")]
	protected void PBGHILNACBP<T>(Entity FADPOFMJIJF, in T FINDDEHFBJE, in T GFFDBEMENLA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	public abstract string CAJKKPCMFBO(in GMFPPNNBHJB CJFFCKBCPGJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	protected LGKODIIKIGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public class FDCHMMDAPPH<T> : LGKODIIKIGF, KMAEHNPNKPE<T>, LDGDMCJHABE<Entity, T>, HEIHDOIHLCP<Entity>, JKEGKIMHFBI, IDisposable, HBGGGACDKNF, HAJIABECHDJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate bool OJNBJMJHGNP(Entity FADPOFMJIJF, in T GFFDBEMENLA);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void ELNCNJFKMOO(Entity FADPOFMJIJF, in T FINDDEHFBJE, in T GFFDBEMENLA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly INNOJNEKDJI ALDLAHDGHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FieldInfo GKDLHGBGLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly int JIFLFJEBLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int ADLHMCAGLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int KOIBEABAMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private OJNBJMJHGNP HDDEHJKGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private ELNCNJFKMOO CDKJPDHIJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private ELNCNJFKMOO PCCMONFPJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private World EIAHLMIGNAE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override Type PDFLIGHJGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5584A60", Offset = "0x5583C60", VA = "0x185584A60", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override INNOJNEKDJI CLGPBLBFGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x82A5F0", Offset = "0x8297F0", VA = "0x18082A5F0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override HAJIABECHDJ MOGEJFKCLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9A16E0", Offset = "0x9A08E0", VA = "0x1809A16E0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private FieldInfo LEEMKOFLPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x825260", Offset = "0x824460", VA = "0x180825260", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private int OFKKHEFACCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99B050", Offset = "0x99A250", VA = "0x18099B050", Slot = "39")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int IJMNEELGHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9234A0", Offset = "0x9226A0", VA = "0x1809234A0", Slot = "40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EntityManager GLHEACEJGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4C366D0", Offset = "0x4C358D0", VA = "0x184C366D0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5585660", Offset = "0x5584860", VA = "0x185585660")]
	public FDCHMMDAPPH(string PCKMHBLNCII, INNOJNEKDJI ALDLAHDGHFH, FieldInfo GKDLHGBGLCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4C36B20", Offset = "0x4C35D20", VA = "0x184C36B20", Slot = "33")]
	public override void OHLMLHJNBAL(EntityManager NBACICFMHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x38F1BB0", Offset = "0x38F0DB0", VA = "0x1838F1BB0")]
	public FDCHMMDAPPH<T> LIAIIAMIEFP(OJNBJMJHGNP HDDEHJKGCMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x38F1C10", Offset = "0x38F0E10", VA = "0x1838F1C10")]
	public FDCHMMDAPPH<T> EMBIGMOMLML(ELNCNJFKMOO CDKJPDHIJKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x38F1B90", Offset = "0x38F0D90", VA = "0x1838F1B90")]
	public FDCHMMDAPPH<T> OKPEHMMNMOK(ELNCNJFKMOO PCCMONFPJEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4C36990", Offset = "0x4C35B90", VA = "0x184C36990", Slot = "35")]
	public T MEINKDCJHDP(Entity FADPOFMJIJF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x55827D0", Offset = "0x55819D0", VA = "0x1855827D0")]
	public bool EBIKLMMGLOI(Entity FADPOFMJIJF, in T GFFDBEMENLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4C36820", Offset = "0x4C35A20", VA = "0x184C36820")]
	public bool MAFAHIFMJOB(Entity FADPOFMJIJF, in T GFFDBEMENLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4C36670", Offset = "0x4C35870", VA = "0x184C36670", Slot = "25")]
	public override bool KMMKKFEGNCC(Entity FADPOFMJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4C36550", Offset = "0x4C35750", VA = "0x184C36550", Slot = "26")]
	public override bool ICMJNMIGGKC(Entity FADPOFMJIJF, in object GFFDBEMENLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4C36860", Offset = "0x4C35A60", VA = "0x184C36860", Slot = "27")]
	public override void MEINKDCJHDP(Entity FADPOFMJIJF, in JBLKIPLPNJE ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4C35B20", Offset = "0x4C34D20", VA = "0x184C35B20", Slot = "28")]
	public override bool EBIKLMMGLOI(Entity FADPOFMJIJF, in GMFPPNNBHJB GFFDBEMENLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4C36780", Offset = "0x4C35980", VA = "0x184C36780", Slot = "29")]
	public override bool MAFAHIFMJOB(Entity FADPOFMJIJF, in GMFPPNNBHJB GFFDBEMENLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4C36AC0", Offset = "0x4C35CC0", VA = "0x184C36AC0", Slot = "30")]
	public override void NBJPEMCMJHM(BNEGEINEKAN CCINPGDJMFK, [Optional] object APPLJOFCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4C356C0", Offset = "0x4C348C0", VA = "0x184C356C0", Slot = "31")]
	public override bool DJIGAFGLBEH(Entity BLDOOIAGGHO, Entity KDAGJHGAEFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "32")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x557DF20", Offset = "0x557D120", VA = "0x18557DF20", Slot = "34")]
	public override string CAJKKPCMFBO(in GMFPPNNBHJB CJFFCKBCPGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4C36620", Offset = "0x4C35820", VA = "0x184C36620")]
	private bool KKBGDLBHIFL(ref T FINDDEHFBJE, ref T GFFDBEMENLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4C36AF0", Offset = "0x4C35CF0", VA = "0x184C36AF0", Slot = "36")]
	private bool NLIDJPNDDBF(Entity PPNIGBBPGOI, in T GFFDBEMENLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4C36460", Offset = "0x4C35660", VA = "0x184C36460", Slot = "37")]
	private bool FIIPHMAICPJ(Entity PPNIGBBPGOI, in T GFFDBEMENLA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void FDFIGJBJJAA<TKey>(TKey BHEOHCEHIBM, in GMFPPNNBHJB FINDDEHFBJE, in GMFPPNNBHJB GFFDBEMENLA);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class CADCACPONML
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x322C580", Offset = "0x322B780", VA = "0x18322C580")]
	public static void OGNFCKBDNLK<TKey, T>(this FDFIGJBJJAA<TKey> FOJNDMIMLDK, TKey BHEOHCEHIBM, T FINDDEHFBJE, T GFFDBEMENLA) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BNEGEINEKAN
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKEFIMFBNIJ<TKey, T>(LDGDMCJHABE<TKey, T> CKAKOJLMGFA, [Optional] object APPLJOFCBIB) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AHPKBGEFLPN
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKEFIMFBNIJ(JKEGKIMHFBI CKAKOJLMGFA, in GMFPPNNBHJB ACKOJNNBEBO, [Optional] object APPLJOFCBIB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HAJIABECHDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FieldInfo JIGMAHAPKEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int OAELCJGKCDE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int DAIIDNNJCOE
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JKEGKIMHFBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string AOPINHAKJMP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Type PDFLIGHJGJP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	HAJIABECHDJ MOGEJFKCLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	INNOJNEKDJI CLGPBLBFGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int DPODIOBCBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NBJPEMCMJHM(BNEGEINEKAN CCINPGDJMFK, [Optional] object APPLJOFCBIB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HEIHDOIHLCP<TKey> : JKEGKIMHFBI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event FDFIGJBJJAA<TKey> KMNFKMHHLGA;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KMMKKFEGNCC(TKey PPNIGBBPGOI);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ICMJNMIGGKC(TKey PPNIGBBPGOI, in object GFFDBEMENLA);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MEINKDCJHDP(TKey PPNIGBBPGOI, in JBLKIPLPNJE ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EBIKLMMGLOI(TKey PPNIGBBPGOI, in GMFPPNNBHJB GFFDBEMENLA);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MAFAHIFMJOB(TKey PPNIGBBPGOI, in GMFPPNNBHJB GFFDBEMENLA);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DJIGAFGLBEH(TKey BLDOOIAGGHO, TKey KDAGJHGAEFN);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string CAJKKPCMFBO(in GMFPPNNBHJB ACKOJNNBEBO);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface LDGDMCJHABE<TKey, T> : HEIHDOIHLCP<TKey>, JKEGKIMHFBI, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T MEINKDCJHDP(TKey PPNIGBBPGOI);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EBIKLMMGLOI(TKey PPNIGBBPGOI, in T GFFDBEMENLA);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MAFAHIFMJOB(TKey PPNIGBBPGOI, in T GFFDBEMENLA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class MAHLGPOKPGI
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x38A6F00", Offset = "0x38A6100", VA = "0x1838A6F00")]
	public static bool IDJOIMMOOEO<TKey, T>(this HEIHDOIHLCP<TKey> CKAKOJLMGFA, TKey PPNIGBBPGOI, out T ACKOJNNBEBO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x38A7720", Offset = "0x38A6920", VA = "0x1838A7720")]
	public static T MEINKDCJHDP<T, TKey>(this HEIHDOIHLCP<TKey> CKAKOJLMGFA, TKey PPNIGBBPGOI) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x38A66A0", Offset = "0x38A58A0", VA = "0x1838A66A0")]
	public static bool EBIKLMMGLOI<TKey, T>(this HEIHDOIHLCP<TKey> CKAKOJLMGFA, TKey PPNIGBBPGOI, T GFFDBEMENLA) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x38A7090", Offset = "0x38A6290", VA = "0x1838A7090")]
	public static bool MAFAHIFMJOB<TKey, T>(this HEIHDOIHLCP<TKey> CKAKOJLMGFA, TKey PPNIGBBPGOI, T GFFDBEMENLA) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct GFNBJKOODOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly Type JAACLLLIGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly string PCKMHBLNCII;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA5F7B0", Offset = "0xA5E9B0", VA = "0x180A5F7B0")]
	public GFNBJKOODOI(Type JAACLLLIGMF, string PCKMHBLNCII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct FPAOGPJBAPF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly Type JAACLLLIGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly string PCKMHBLNCII;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA5F7B0", Offset = "0xA5E9B0", VA = "0x180A5F7B0")]
	public FPAOGPJBAPF(Type JAACLLLIGMF, string PCKMHBLNCII)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3AA19C0", Offset = "0x3AA0BC0", VA = "0x183AA19C0")]
	public static GFNBJKOODOI JMAOMMKGDBP(FPAOGPJBAPF<T> IPGCNJJCOBF)
	{
		return default(GFNBJKOODOI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum JEPFFDGOHFA
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
public class EBKBJAOFPDB : BNHABKGDABN, IEnumerable<HBGGGACDKNF>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly List<HBGGGACDKNF> CDKKKDOCLDE;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x15A5190", Offset = "0x15A4390", VA = "0x1815A5190", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public HBGGGACDKNF LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x15A5130", Offset = "0x15A4330", VA = "0x1815A5130", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x15A56C0", Offset = "0x15A48C0", VA = "0x1815A56C0")]
	public EBKBJAOFPDB(IEnumerable<INNOJNEKDJI> ODGPCADBHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x15A51D0", Offset = "0x15A43D0", VA = "0x1815A51D0")]
	private List<HBGGGACDKNF> PGOOKLIGBIP(IEnumerable<INNOJNEKDJI> ODGPCADBHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x15A50B0", Offset = "0x15A42B0", VA = "0x1815A50B0", Slot = "4")]
	public IEnumerator<HBGGGACDKNF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x15A50B0", Offset = "0x15A42B0", VA = "0x1815A50B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
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
