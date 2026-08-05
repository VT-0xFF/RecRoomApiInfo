using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.MCluster;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct GIKBDFFBEJI
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] JLBEMEJNNIB;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] FGCCKADBHCH;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] FBACNOLMKMP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xE11F10", Offset = "0xE10910", VA = "0x180E11F10")]
	public static int OPKIABJJOFM(DMPHLCEHPCF JLMHPKHAOHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6927EB0", Offset = "0x69268B0", VA = "0x186927EB0")]
	public static int OBOAKGBNKKM(DMPHLCEHPCF JLMHPKHAOHJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ONHAEABAMOA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int JNKANDDCELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HIJDLNMAIDB KNBDEOEBCOJ(int JMKELNHPPCF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 GLJLINEAPKO(int JMKELNHPPCF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HLEMAOPCIDE FJGJGIBGDDH();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JBIJECILNPO JHMANHDKBMO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class JMPHHMHALMM : LKEFLEKLEHO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private HLEMAOPCIDE FMAJPAMCPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform FFHJLFJJDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<KNFOOLIHBPA> LOIIHBMFFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private LJDNNAOKEDK BKFOHKINJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private JOPJAFKGMOD MKCAMNDBNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool IFFLCOOAIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private ONHAEABAMOA MJELDNBEBNF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float BKLIGEBDFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA40", Offset = "0x8BD440", VA = "0x1808BEA40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAAFAC0", Offset = "0xAAE4C0", VA = "0x180AAFAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BAODLBMPKDC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B0", Offset = "0x9BADB0", VA = "0x1809BC3B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9BC460", Offset = "0x9BAE60", VA = "0x1809BC460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KMCDGNKLMAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x123EAE0", Offset = "0x123D4E0", VA = "0x18123EAE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x123E600", Offset = "0x123D000", VA = "0x18123E600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CKCBOLCFHPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FBBF70", Offset = "0x5FBA970", VA = "0x185FBBF70", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5FBBEE0", Offset = "0x5FBA8E0", VA = "0x185FBBEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MACBJJDFLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x13EF7B0", Offset = "0x13EE1B0", VA = "0x1813EF7B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6929D00", Offset = "0x6928700", VA = "0x186929D00")]
	public JMPHHMHALMM(ONHAEABAMOA OGHLFHGIOLB, bool ALFNIAGOAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6928AB0", Offset = "0x69274B0", VA = "0x186928AB0")]
	private bool CNBAGEGEKLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69290E0", Offset = "0x6927AE0", VA = "0x1869290E0", Slot = "4")]
	public bool PBLNBBGFGAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6928CE0", Offset = "0x69276E0", VA = "0x186928CE0", Slot = "5")]
	public bool LHGGKPHIKGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6928EB0", Offset = "0x69278B0", VA = "0x186928EB0", Slot = "6")]
	public void MFKDEBIIBOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6928CD0", Offset = "0x69276D0", VA = "0x186928CD0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MADCKBCBLHE
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EPMEGEHFDGN(CommandBuffer GLEICJJMPEC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KOGKOIKIJMA : MADCKBCBLHE
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int CODEDOIEGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A900", VA = "0x180A7BF00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier FILIFCKICEL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x421A750", Offset = "0x4219150", VA = "0x18421A750")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x692BE30", Offset = "0x692A830", VA = "0x18692BE30")]
	public KOGKOIKIJMA(int DKFNFHGODON, RenderTargetIdentifier LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x692BDE0", Offset = "0x692A7E0", VA = "0x18692BDE0", Slot = "4")]
	public void EPMEGEHFDGN(CommandBuffer GLEICJJMPEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct FLGMKJOJFNC : MADCKBCBLHE
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int CODEDOIEGGD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A900", VA = "0x180A7BF00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] MCMFIBBHPLA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4100", Offset = "0x8C2B00", VA = "0x1808C4100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xD87910", Offset = "0xD86310", VA = "0x180D87910")]
	public FLGMKJOJFNC(int DKFNFHGODON, Vector4[] LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6926B90", Offset = "0x6925590", VA = "0x186926B90", Slot = "4")]
	public void EPMEGEHFDGN(CommandBuffer GLEICJJMPEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct NJFOBBNJNLE : MADCKBCBLHE
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int CODEDOIEGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A900", VA = "0x180A7BF00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] JAOGBJGDPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8C4100", Offset = "0x8C2B00", VA = "0x1808C4100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xD87910", Offset = "0xD86310", VA = "0x180D87910")]
	public NJFOBBNJNLE(int DKFNFHGODON, float[] LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x692D900", Offset = "0x692C300", VA = "0x18692D900", Slot = "4")]
	public void EPMEGEHFDGN(CommandBuffer GLEICJJMPEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct GICCMOJBNFD : MADCKBCBLHE
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string KHJLONLFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2B10", VA = "0x1808C4110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool INMPDDDBHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1BBA5A0", Offset = "0x1BB8FA0", VA = "0x181BBA5A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4221960", Offset = "0x4220360", VA = "0x184221960")]
	public GICCMOJBNFD(string BHFPKCCDEEC, bool CKPMODOEIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6927E70", Offset = "0x6926870", VA = "0x186927E70", Slot = "4")]
	public void EPMEGEHFDGN(CommandBuffer GLEICJJMPEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct JBIJECILNPO
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 NAHJHKDBKCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 HGANMAIEAJH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8C9DB0", Offset = "0x8C87B0", VA = "0x1808C9DB0")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int HKHEDPDIPJP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8CDB30", Offset = "0x8CC530", VA = "0x1808CDB30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int GAKEOFDMGOI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x891F80", Offset = "0x890980", VA = "0x180891F80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float PLJDHOGHDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAA0", Offset = "0x8BD4A0", VA = "0x1808BEAA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6928980", Offset = "0x6927380", VA = "0x186928980")]
	public JBIJECILNPO(Color KIJNHGNFMMA, int FMODHEJNHJB, int ILLCBJEFNGA, float FHKFKMGNGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x92DF90", Offset = "0x92C990", VA = "0x18092DF90")]
	private static float4 LMKHHILFJMH(Color KIJNHGNFMMA)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69288F0", Offset = "0x69272F0", VA = "0x1869288F0")]
	private static Hash128 ADLKCNMBPKB(JBIJECILNPO OGHLFHGIOLB)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LJDNNAOKEDK : LKEFLEKLEHO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string AHLLEHGBNCK;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string CMNFNCAGLLI;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string EIFDDNLJPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private JBIJECILNPO MABHJANOEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NPEDHCHHCHP GIIKGEKINDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 JFLDOGDHBJN;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public JOPJAFKGMOD CLJMJHBOAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x879D40", Offset = "0x878740", VA = "0x180879D40")]
		[CompilerGenerated]
		get
		{
			return default(JOPJAFKGMOD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAC92E0", Offset = "0xAC7CE0", VA = "0x180AC92E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool BAODLBMPKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5929040", Offset = "0x5927A40", VA = "0x185929040")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5929050", Offset = "0x5927A50", VA = "0x185929050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool KMCDGNKLMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1F31870", Offset = "0x1F30270", VA = "0x181F31870")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68B09B0", Offset = "0x68AF3B0", VA = "0x1868B09B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MACBJJDFLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BFA0", VA = "0x18086D5A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool CKCBOLCFHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x59E0CD0", Offset = "0x59DF6D0", VA = "0x1859E0CD0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x692BF60", Offset = "0x692A960", VA = "0x18692BF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int LINJEMEJAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x692BF70", Offset = "0x692A970", VA = "0x18692BF70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x692C500", Offset = "0x692AF00", VA = "0x18692C500")]
	public LJDNNAOKEDK(JBIJECILNPO CEKCEFDOFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x692BE50", Offset = "0x692A850", VA = "0x18692BE50")]
	private bool CNBAGEGEKLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x692C2C0", Offset = "0x692ACC0", VA = "0x18692C2C0", Slot = "4")]
	public bool PBLNBBGFGAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x692C170", Offset = "0x692AB70", VA = "0x18692C170")]
	private static NPEDHCHHCHP MDOLEEACALL(JBIJECILNPO OGHLFHGIOLB)
	{
		return default(NPEDHCHHCHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x692BFC0", Offset = "0x692A9C0", VA = "0x18692BFC0", Slot = "5")]
	public bool LHGGKPHIKGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x692C1B0", Offset = "0x692ABB0", VA = "0x18692C1B0", Slot = "6")]
	public void MFKDEBIIBOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "9")]
	public void Dispose()
	{
	}
}
namespace RecRoom.MCluster
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MClusterData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			[Reload("Shaders/ClusterUpdate.compute", ReloadAttribute.Package.Root)]
			public ComputeShader UpdateShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			[Reload("Shaders/ClusterRaster.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ClusterRasterShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			[Reload("Shaders/ClusterCoarseCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader CoarseCullShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			[Reload("Shaders/ClusterFineCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader FineCullShader;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x692C5B0", Offset = "0x692AFB0", VA = "0x18692C5B0", Slot = "0")]
		public override bool Equals(object OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x692C7B0", Offset = "0x692B1B0", VA = "0x18692C7B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAE0", Offset = "0x8BD4E0", VA = "0x1808BEAE0")]
		public MClusterData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleRendererFeature(null)]
	public class MClusterRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private DMIKJHKALAG opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static DEAIGIECMIF CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x692CE80", Offset = "0x692B880", VA = "0x18692CE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x692CEC0", Offset = "0x692B8C0", VA = "0x18692CEC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x692C890", Offset = "0x692B290", VA = "0x18692C890", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x692C860", Offset = "0x692B260", VA = "0x18692C860", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GHBIMLIJLGK, RenderingData JOOKFIIMNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x692CCF0", Offset = "0x692B6F0", VA = "0x18692CCF0")]
		public void DOLDFDIHOOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xD94CE0", Offset = "0xD936E0", VA = "0x180D94CE0")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CINCOLGGFJI<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private APNJCOCCDKF GPLIBJJNECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private APNJCOCCDKF KKBMJABPKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer PMOPDBAGAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture KDLJJKKFJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int HJHPKBNEEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int BDOCHCBJFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string BCGNBKLIMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string PDGPCIJECKJ;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x858FA0", Offset = "0x8579A0", VA = "0x180858FA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int BGKMOMENCFF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xDB4C10", Offset = "0xDB3610", VA = "0x180DB4C10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int MFLPAHNPAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x870750", Offset = "0x86F150", VA = "0x180870750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x51ED630", Offset = "0x51EC030", VA = "0x1851ED630")]
	public CINCOLGGFJI(string BHFPKCCDEEC, int DDHEDMECBDP, [Optional] RenderTextureFormat? BGOCEECJDJL, bool LMDAPAIDBLJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x51ED360", Offset = "0x51EBD60", VA = "0x1851ED360")]
	public void LHGGKPHIKGE(CommandBuffer GLEICJJMPEC, NativeArray<ValType> LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x51EB650", Offset = "0x51EA050", VA = "0x1851EB650")]
	public void KEPICDLKMMO(CommandBuffer GLEICJJMPEC, ComputeShader OCDMKMGEEEJ, int OPECBIAMCAG, int DNFAGJMAIJK = -1, int JMLMPALEFDO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x51EB890", Offset = "0x51EA290", VA = "0x1851EB890")]
	public void KEPICDLKMMO(Material GIIKGEKINDH, int DNFAGJMAIJK = -1, int JMLMPALEFDO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x51EB240", Offset = "0x51E9C40", VA = "0x1851EB240", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OKDNAGFFDJO
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KEPICDLKMMO(Material CEKCEFDOFME);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KLBHENNAMEG<SrcEntry, DstEntry> : OKDNAGFFDJO, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] KBAPKAFDMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected APNJCOCCDKF PBIODNGMKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected APNJCOCCDKF EKCEIJCNGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> FIJKKKIOGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> KHLBGOJLAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int DGGDPLIGOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int ANFJFFLMFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected CINCOLGGFJI<int> HOKHBICPLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected CINCOLGGFJI<SrcEntry> HFEONHPHKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected CINCOLGGFJI<DstEntry> CPHFDCDBMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader GPEDOFOFKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int NOCJGOILFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int PHHCOALLKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int ACPGAIMBLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int EOIMKFFELHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int HCMKEJGOABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int FOHLJLPPDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int ABIANJENINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int BJBOKKCLHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int MJLLNKFEIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int DFGIAMJGBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int AMHKCEBLEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int FPOAFDGJHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string DIFAJAAOHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] NLJBFHINKJD;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int DBFNDBELIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4189180", Offset = "0x4187B80", VA = "0x184189180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string NHEMIDKFCGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x418B480", Offset = "0x4189E80", VA = "0x18418B480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x418C100", Offset = "0x418AB00", VA = "0x18418C100")]
	public KLBHENNAMEG(string BHFPKCCDEEC, int KKAMIMGMJOF, int NPPHAMGPIAG, RenderTextureFormat BGOCEECJDJL, ComputeShader CLHMHPCLOHK, int OINLMJLEMKH = 0, int MENBNICCEGF = 0, int JPPEGHGPNME = 0, int AEPELGOHEEP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4189FC0", Offset = "0x41889C0", VA = "0x184189FC0")]
	public int NHCCGNCLKON()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4189130", Offset = "0x4187B30", VA = "0x184189130")]
	protected void FPNCHFOJOHD(int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x418A1F0", Offset = "0x4188BF0", VA = "0x18418A1F0")]
	public JOPJAFKGMOD PBLNBBGFGAP(SrcEntry LINJEFIAFHO)
	{
		return default(JOPJAFKGMOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4189730", Offset = "0x4188130", VA = "0x184189730")]
	public bool LHGGKPHIKGE(JOPJAFKGMOD IIMJMBJHGDI, SrcEntry LINJEFIAFHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4189DC0", Offset = "0x41887C0", VA = "0x184189DC0")]
	public bool MFKDEBIIBOM(JOPJAFKGMOD IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "6")]
	protected virtual void LAHPHNDFKIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4187AF0", Offset = "0x41864F0", VA = "0x184187AF0", Slot = "7")]
	public void CHIIBACHCCL(CommandBuffer GLEICJJMPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4188210", Offset = "0x4186C10", VA = "0x184188210", Slot = "8")]
	public void CHIIBACHCCL(CommandBuffer GLEICJJMPEC, ComputeShader CLHMHPCLOHK, int OINLMJLEMKH = -1, int MENBNICCEGF = -1, int JPPEGHGPNME = -1, int AEPELGOHEEP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4189210", Offset = "0x4187C10", VA = "0x184189210", Slot = "9")]
	public void KEPICDLKMMO(CommandBuffer GLEICJJMPEC, ComputeShader CLHMHPCLOHK, int OINLMJLEMKH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4189190", Offset = "0x4187B90", VA = "0x184189190", Slot = "4")]
	public void KEPICDLKMMO(Material GIIKGEKINDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4188C30", Offset = "0x4187630", VA = "0x184188C30", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface APNJCOCCDKF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong COPPHHIHJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong MCBEEGCCLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GGJGBBGKOAK
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct AHBHPPJFCJI : APNJCOCCDKF, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable GDBEHNBLALJ;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong COPPHHIHJMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8C4100", Offset = "0x8C2B00", VA = "0x1808C4100", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x60E69F0", Offset = "0x60E53F0", VA = "0x1860E69F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong MCBEEGCCLFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x14FAAE0", Offset = "0x14F94E0", VA = "0x1814FAAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4C945C0", Offset = "0x4C92FC0", VA = "0x184C945C0")]
		internal AHBHPPJFCJI(IDisposable COAEDMPNFJB, ulong DKJDJIIEMAP, ulong HEPBKGOLGNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x691EA90", Offset = "0x691D490", VA = "0x18691EA90", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct NNBIOCGEOEF : APNJCOCCDKF, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture LHBPPPBOGCG;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong COPPHHIHJMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8C4100", Offset = "0x8C2B00", VA = "0x1808C4100", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x60E69F0", Offset = "0x60E53F0", VA = "0x1860E69F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong MCBEEGCCLFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x14FAAE0", Offset = "0x14F94E0", VA = "0x1814FAAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x692D9D0", Offset = "0x692C3D0", VA = "0x18692D9D0")]
		public NNBIOCGEOEF(RenderTexture IPABEBMKKAM, ulong MLOPNMMLMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x692D930", Offset = "0x692C330", VA = "0x18692D930", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong PAKCKEDIGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x69274C0", Offset = "0x6925EC0", VA = "0x1869274C0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6926E00", Offset = "0x6925800", VA = "0x186926E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong JHAOJAGGGEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6926DC0", Offset = "0x69257C0", VA = "0x186926DC0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6927500", Offset = "0x6925F00", VA = "0x186927500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x69271E0", Offset = "0x6925BE0", VA = "0x1869271E0")]
	public static ComputeBuffer JGIIBNEOBDO(int IHGHLPOONHD, int BAILPPBNEOE, ComputeBufferType NCMHJNKFAGH, [Out] APNJCOCCDKF IIMJMBJHGDI, ComputeBufferMode DNCAOAEPAKK = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6926E40", Offset = "0x6925840", VA = "0x186926E40")]
	public static RenderTexture JGIIBNEOBDO(int IJAJOPPBLCP, int FNKAMPFNBJB, int EIGOHCGBEGP, RenderTextureFormat BGOCEECJDJL, [Out] APNJCOCCDKF IIMJMBJHGDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2B24A00", Offset = "0x2B23400", VA = "0x182B24A00")]
	public static NativeArray<T> KFOJLOIIIPO<T>(NativeArray<T> GDBEHNBLALJ, ulong OMJPDIKPOLO, [Out] APNJCOCCDKF IIMJMBJHGDI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2B24940", Offset = "0x2B23340", VA = "0x182B24940")]
	public static NativeArray<T> JGIIBNEOBDO<T>(int OMJPDIKPOLO, Allocator CHDJMCMMMLJ, [Out] APNJCOCCDKF IIMJMBJHGDI, NativeArrayOptions FDGBBGJEJMA = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6926C70", Offset = "0x6925670", VA = "0x186926C70")]
	public static void CKOHIKCJKJA(APNJCOCCDKF GDBEHNBLALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69273C0", Offset = "0x6925DC0", VA = "0x1869273C0")]
	public static uint JMBILKKGFOE(RenderTextureFormat BGOCEECJDJL)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GHMGGBOFFKE : KLBHENNAMEG<PHKFGPAMGNO, PHKFGPAMGNO>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct CIKCPHGGEFO : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> OFPNLOBMNHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> LIAKGFBEHIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> IJDBOCDLHKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> JKFMHHEAOLK;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x691F0B0", Offset = "0x691DAB0", VA = "0x18691F0B0")]
		public CIKCPHGGEFO(NativeArray<int> BLADFIIDJNK, NativeArray<float> PNNBEODNIHJ, NativeArray<float4x4> BJGEMDDDDFC, NativeArray<float4> BFPMJMDDAIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x691EEF0", Offset = "0x691D8F0", VA = "0x18691EEF0", Slot = "4")]
		public void Execute(int DHNLEFJCEAH, TransformAccess FMAJPAMCPCL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct LOLCIACLPEE : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> OFPNLOBMNHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> BPKJEOCKLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> BHBHIKNGMHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<PHKFGPAMGNO> NNMCHLMEJNA;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x691F0B0", Offset = "0x691DAB0", VA = "0x18691F0B0")]
		public LOLCIACLPEE(NativeArray<int> BLADFIIDJNK, NativeArray<float4x4> KBJIPJHNGMD, NativeArray<float4> GPGCIIAJKHI, NativeArray<PHKFGPAMGNO> BCCFKHCCLFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x692C540", Offset = "0x692AF40", VA = "0x18692C540", Slot = "4")]
		public void Execute(int DHNLEFJCEAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte DDKBHBNEPHF = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray MHHJLGBILFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> GJNMDNLCLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> DMDGOKJHPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> APIEOMOLMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> LMKLJACJIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> AICPNPDBIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private APNJCOCCDKF IEAACBELDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private APNJCOCCDKF HGKDHLGGCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private APNJCOCCDKF MGDMECOAEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private APNJCOCCDKF NLFABHAFJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private APNJCOCCDKF LBAMHBOBHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform OCHEDDJDJBD;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6927B90", Offset = "0x6926590", VA = "0x186927B90")]
	public GHMGGBOFFKE(int KKAMIMGMJOF, int NPPHAMGPIAG, ComputeShader CLHMHPCLOHK, int OINLMJLEMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6927780", Offset = "0x6926180", VA = "0x186927780", Slot = "6")]
	protected override void LAHPHNDFKIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6927540", Offset = "0x6925F40", VA = "0x186927540")]
	private void AGPGDDICNED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6927A30", Offset = "0x6926430", VA = "0x186927A30")]
	public bool PLBOCBLAIJH(JOPJAFKGMOD IIMJMBJHGDI, Transform FMAJPAMCPCL, float AGMKDHBOCAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x69276A0", Offset = "0x69260A0", VA = "0x1869276A0")]
	public void GKFEPNPAAOJ(JOPJAFKGMOD IIMJMBJHGDI, float AGMKDHBOCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6927980", Offset = "0x6926380", VA = "0x186927980")]
	public void PFNHLOKDILH(JOPJAFKGMOD IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6927600", Offset = "0x6926000", VA = "0x186927600", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HIJDLNMAIDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NAJBPEBBKNG LCJDPHEAJHF();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface BCFKPANGLHP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 NAHJHKDBKCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int JGHJDPGMBEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int GOHGHPNIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> PHJFFHJCDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> HIKGGMOMAFA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> AMBHMAAPEIF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> LNLLIHFLAPN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> MBODMHHCGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> JFNADOODDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int LEACNAEMLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int BCHIJPGLELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int CEMIBEANIKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool HDMNHKNGLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CHIIBACHCCL();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BLELMJPNJEN : BCFKPANGLHP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private HIJDLNMAIDB BCHLKOMDDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NAJBPEBBKNG DICFBCCFLEI;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 NAHJHKDBKCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8C9DB0", Offset = "0x8C87B0", VA = "0x1808C9DB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x98E180", Offset = "0x98CB80", VA = "0x18098E180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool LONEJKONMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8569C0", Offset = "0x8553C0", VA = "0x1808569C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int JGHJDPGMBEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x891F80", Offset = "0x890980", VA = "0x180891F80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x891580", Offset = "0x88FF80", VA = "0x180891580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int GOHGHPNIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x852880", Offset = "0x851280", VA = "0x180852880", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8528D0", Offset = "0x8512D0", VA = "0x1808528D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int BJIBOLIHFFK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xB48890", Offset = "0xB47290", VA = "0x180B48890")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> PHJFFHJCDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x691ECD0", Offset = "0x691D6D0", VA = "0x18691ECD0", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> HIKGGMOMAFA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x691EDD0", Offset = "0x691D7D0", VA = "0x18691EDD0", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> AMBHMAAPEIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x691EE00", Offset = "0x691D800", VA = "0x18691EE00", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> LNLLIHFLAPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x691EC60", Offset = "0x691D660", VA = "0x18691EC60", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> MBODMHHCGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x691EE40", Offset = "0x691D840", VA = "0x18691EE40", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> JFNADOODDJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x691EE70", Offset = "0x691D870", VA = "0x18691EE70", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool HDMNHKNGLFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9C0720", Offset = "0x9BF120", VA = "0x1809C0720", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA16600", Offset = "0xA15000", VA = "0x180A16600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int LEACNAEMLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x691EE30", Offset = "0x691D830", VA = "0x18691EE30", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int BCHIJPGLELM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x691EB10", Offset = "0x691D510", VA = "0x18691EB10", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int CEMIBEANIKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x691EB30", Offset = "0x691D530", VA = "0x18691EB30", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x691EEA0", Offset = "0x691D8A0", VA = "0x18691EEA0")]
	public BLELMJPNJEN(Hash128 BGMAOMLOOIC, HIJDLNMAIDB BCHLKOMDDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x691EB50", Offset = "0x691D550", VA = "0x18691EB50", Slot = "16")]
	public void CHIIBACHCCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x691ED40", Offset = "0x691D740", VA = "0x18691ED40", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct JOPJAFKGMOD : IEquatable<JOPJAFKGMOD>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly JOPJAFKGMOD ADOHMNBGCKE;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int LINJEMEJAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A900", VA = "0x180A7BF00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xA7BF10", Offset = "0xA7A910", VA = "0x180A7BF10")]
	public JOPJAFKGMOD(int DHNLEFJCEAH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6929E70", Offset = "0x6928870", VA = "0x186929E70", Slot = "4")]
	public bool Equals(JOPJAFKGMOD OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6929EC0", Offset = "0x69288C0", VA = "0x186929EC0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6929F90", Offset = "0x6928990", VA = "0x186929F90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KNFOOLIHBPA : LKEFLEKLEHO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool IFFLCOOAIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private BCFKPANGLHP FCJPHADHJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<JOPJAFKGMOD> PPFNHOANNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<JOPJAFKGMOD> KKAONGEHDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<JOPJAFKGMOD> IOFCOIODOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> CLMFGOEEKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int BHPOFKEKDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int HOLGDCGDMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int BCBOPEPHFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int APMEFFHHEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int MFFNPDINOOG;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int LINJEMEJAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x692A7F0", Offset = "0x69291F0", VA = "0x18692A7F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x692AF90", Offset = "0x6929990", VA = "0x18692AF90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool BAODLBMPKDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8A6510", Offset = "0x8A4F10", VA = "0x1808A6510")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9AD960", Offset = "0x9AC360", VA = "0x1809AD960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool KMCDGNKLMAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xB7F4B0", Offset = "0xB7DEB0", VA = "0x180B7F4B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xB7F4A0", Offset = "0xB7DEA0", VA = "0x180B7F4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool MACBJJDFLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BFA0", VA = "0x18086D5A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool CKCBOLCFHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4A8D920", Offset = "0x4A8C320", VA = "0x184A8D920", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1972F30", Offset = "0x1971930", VA = "0x181972F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float BKLIGEBDFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8BF140", Offset = "0x8BDB40", VA = "0x1808BF140")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1D39DA0", Offset = "0x1D387A0", VA = "0x181D39DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x692BC70", Offset = "0x692A670", VA = "0x18692BC70")]
	public KNFOOLIHBPA(BCFKPANGLHP DICFBCCFLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x692A320", Offset = "0x6928D20", VA = "0x18692A320")]
	private void FDPFMCMGBHA(BCFKPANGLHP DICFBCCFLEI, int BHPOFKEKDPM, int DHFPIOJDCMP, int DHNLEFJCEAH, int DFKMKFCJDLL, ENEGNDCEPAI LINJEFIAFHO, float NFOAOKAEGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x692AFD0", Offset = "0x69299D0", VA = "0x18692AFD0")]
	private void PAIKNHHJAJB(BCFKPANGLHP DICFBCCFLEI, int CJJJGHMBDLE, int DHNLEFJCEAH, uint3 AGNLKBKPJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x692A020", Offset = "0x6928A20", VA = "0x18692A020")]
	private bool CNBAGEGEKLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x692B290", Offset = "0x6929C90", VA = "0x18692B290", Slot = "4")]
	public bool PBLNBBGFGAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x692A8A0", Offset = "0x69292A0", VA = "0x18692A8A0", Slot = "5")]
	public bool LHGGKPHIKGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x692A920", Offset = "0x6929320", VA = "0x18692A920", Slot = "6")]
	public void MFKDEBIIBOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x692A2C0", Offset = "0x6928CC0", VA = "0x18692A2C0")]
	public void OBIHBOAALDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x692A2C0", Offset = "0x6928CC0", VA = "0x18692A2C0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface LKEFLEKLEHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool MACBJJDFLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool CKCBOLCFHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBLNBBGFGAP();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LHGGKPHIKGE();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MFKDEBIIBOM();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PCBFKFADJAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float KDBIGEAPACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, KNFOOLIHBPA> CDNHECNBKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, LJDNNAOKEDK> POPOOJMAJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<LKEFLEKLEHO> PCIPPEPDIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<LKEFLEKLEHO> HJEKKDHDBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<LKEFLEKLEHO> EIFCMPFOAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int PCMLOCEAHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int PCJLHEMMHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float MDGCELMJHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool FBEAMMMPMBB;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool AAKMKFIMMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xDBA500", Offset = "0xDB8F00", VA = "0x180DBA500")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xDDD410", Offset = "0xDDBE10", VA = "0x180DDD410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool FNGBJCJNGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x692E1D0", Offset = "0x692CBD0", VA = "0x18692E1D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string NHEMIDKFCGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x692E830", Offset = "0x692D230", VA = "0x18692E830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x692E820", Offset = "0x692D220", VA = "0x18692E820")]
	public void OLNLHDFKAOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x692DAE0", Offset = "0x692C4E0", VA = "0x18692DAE0")]
	public void AJNADNONHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x692EC20", Offset = "0x692D620", VA = "0x18692EC20")]
	public PCBFKFADJAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x692E660", Offset = "0x692D060", VA = "0x18692E660")]
	public JMPHHMHALMM JGBCFAKMKJN(ONHAEABAMOA BOLGDNNEFAC, bool ALFNIAGOAEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x692E240", Offset = "0x692CC40", VA = "0x18692E240")]
	public LJDNNAOKEDK JGBCFAKMKJN(JBIJECILNPO GIIKGEKINDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x692DAF0", Offset = "0x692C4F0", VA = "0x18692DAF0")]
	public bool BEACNPBIPNG(Hash128 DKFNFHGODON, [Out] KNFOOLIHBPA ILIHHIBNPDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x692E380", Offset = "0x692CD80", VA = "0x18692E380")]
	public KNFOOLIHBPA JGBCFAKMKJN(BCFKPANGLHP DICFBCCFLEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x692E220", Offset = "0x692CC20", VA = "0x18692E220")]
	private void FIFEAJLOGPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x692E790", Offset = "0x692D190", VA = "0x18692E790")]
	private bool KCDNAJGMBKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x692DC10", Offset = "0x692C610", VA = "0x18692DC10")]
	public void CHIIBACHCCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x692E0C0", Offset = "0x692CAC0", VA = "0x18692E0C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x692DB60", Offset = "0x692C560", VA = "0x18692DB60")]
	public void BPGAAPNDOCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GACGJCAJBBC : KLBHENNAMEG<HLAMOEEBJLO, HLAMOEEBJLO>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6926BC0", Offset = "0x69255C0", VA = "0x186926BC0")]
	public GACGJCAJBBC(int KKAMIMGMJOF, int NPPHAMGPIAG, ComputeShader CLHMHPCLOHK, int OINLMJLEMKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JOEFEBDFGDN : KLBHENNAMEG<NPEDHCHHCHP, NPEDHCHHCHP>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6929DC0", Offset = "0x69287C0", VA = "0x186929DC0")]
	public JOEFEBDFGDN(int KKAMIMGMJOF, int NPPHAMGPIAG, ComputeShader CLHMHPCLOHK, int OINLMJLEMKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class OJINGJKFNGN : KLBHENNAMEG<CKPIFCHGINI, CKPIFCHGINI>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x692DA30", Offset = "0x692C430", VA = "0x18692DA30")]
	public OJINGJKFNGN(int KKAMIMGMJOF, int NPPHAMGPIAG, ComputeShader CLHMHPCLOHK, int OINLMJLEMKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class DNFDDNNHBAP : KLBHENNAMEG<CECAFOEADHH, CBILNFCFBJH>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6926AE0", Offset = "0x69254E0", VA = "0x186926AE0")]
	public DNFDDNNHBAP(int KKAMIMGMJOF, int NPPHAMGPIAG, ComputeShader CLHMHPCLOHK, int OINLMJLEMKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class DIKJBMLPOII : KLBHENNAMEG<NHBNFJPEFIO, NHBNFJPEFIO>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6926430", Offset = "0x6924E30", VA = "0x186926430")]
	public DIKJBMLPOII(int KKAMIMGMJOF, int NPPHAMGPIAG, ComputeShader CLHMHPCLOHK, int OINLMJLEMKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class DMIKJHKALAG : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private DEAIGIECMIF PIMIDHIOHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool CKPMODOEIJG;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool MJCKBGDLCPK;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6926AA0", Offset = "0x69254A0", VA = "0x186926AA0")]
	public DMIKJHKALAG(DEAIGIECMIF CLOMILMHHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6926910", Offset = "0x6925310", VA = "0x186926910", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer GLEICJJMPEC, RenderingData JOOKFIIMNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x69266A0", Offset = "0x69250A0", VA = "0x1869266A0", Slot = "6")]
	public override void Configure(CommandBuffer GLEICJJMPEC, RenderTextureDescriptor MAFOPCMGPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x69266E0", Offset = "0x69250E0", VA = "0x1869266E0", Slot = "9")]
	public override void Execute(ScriptableRenderContext CNBJCJOALNK, RenderingData JOOKFIIMNNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class MNMLDLIABIG
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct DMGOGCLKILE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string BHFPKCCDEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer GLEICJJMPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext CNBJCJOALNK;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6926590", Offset = "0x6924F90", VA = "0x186926590")]
		public DMGOGCLKILE(string MIPPAJFOFDN, ScriptableRenderContext KCIPFDAONKD, [Out] CommandBuffer FEGAKLGEDDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x69264E0", Offset = "0x6924EE0", VA = "0x1869264E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x692CF20", Offset = "0x692B920", VA = "0x18692CF20")]
	public static bool FAACPPLHKDH(RenderingData JOOKFIIMNNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x692D2A0", Offset = "0x692BCA0", VA = "0x18692D2A0")]
	public static void NMKBCEIBOML(CommandBuffer GLEICJJMPEC, ScriptableRenderContext CNBJCJOALNK, ShadowDrawingSettings EMGFDJGDLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x692D070", Offset = "0x692BA70", VA = "0x18692D070")]
	public static void KLKNFNHIIMG(CommandBuffer GLEICJJMPEC, ScriptableRenderContext CNBJCJOALNK, RenderingData JOOKFIIMNNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DEAIGIECMIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class ABJPPJLJGGP
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int MPOBHFIEEHE;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int BIOAKKPOBPC;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static CINCOLGGFJI<NDBNMDBNGHO> AOHGMJPANCJ;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static CINCOLGGFJI<uint> GEHDEGLJPDE;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static APNJCOCCDKF CDBLAIPNPEL;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer CLDELHFLKAD;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<OKDNAGFFDJO> FDOLGMLNBDO;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int LAKDHPANKNL;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int GMFGLFPNICF;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int AOCJJKGIMMJ;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int ONBNAPBMLPH;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] EMFDPHCPBDL;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] MPKNHNAEBCC;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static MADCKBCBLHE[][] BCENFFCBHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] HIJDLFHBBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int FMFADOGCMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int OFBCNGPHCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int GCEDBKLBFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int JEBKIPOBCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int BCMOFALIMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int JAGAMEGAIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int AEPLJAFLFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int AHIGCGFOCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int DACBBAHINKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int NHFFNIBOMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int NEPDFENMGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int CIMHPMJIFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int OFBBLBMJPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int FILBJLGGDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int EJEOEMPKPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int LLMGPOFCEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int LGGKFMFKHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int CHNFGNDGHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] CGNHOKILGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private PCBFKFADJAD GKNHOMPJCFC;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool AGCIBBBIDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x691F710", Offset = "0x691E110", VA = "0x18691F710")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x691F190", Offset = "0x691DB90", VA = "0x18691F190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool FGMEHJIGBFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x691FDA0", Offset = "0x691E7A0", VA = "0x18691FDA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x69210D0", Offset = "0x691FAD0", VA = "0x1869210D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData CPPCAMCFLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6925960", Offset = "0x6924360", VA = "0x186925960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6924490", Offset = "0x6922E90", VA = "0x186924490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static GHMGGBOFFKE IMBACGJFJFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x69260E0", Offset = "0x6924AE0", VA = "0x1869260E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6921BE0", Offset = "0x69205E0", VA = "0x186921BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static GACGJCAJBBC HKMHMGMMCJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x69214B0", Offset = "0x691FEB0", VA = "0x1869214B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6924500", Offset = "0x6922F00", VA = "0x186924500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static JOEFEBDFGDN NHKNFLNKBHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x69245C0", Offset = "0x6922FC0", VA = "0x1869245C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x69213D0", Offset = "0x691FDD0", VA = "0x1869213D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static OJINGJKFNGN OPKAICGGLAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x69259B0", Offset = "0x69243B0", VA = "0x1869259B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6921440", Offset = "0x691FE40", VA = "0x186921440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static DNFDDNNHBAP LKMKCBIONCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6921370", Offset = "0x691FD70", VA = "0x186921370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x691FD20", Offset = "0x691E720", VA = "0x18691FD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static DIKJBMLPOII BHGBFOOILOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6921190", Offset = "0x691FB90", VA = "0x186921190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x691FDF0", Offset = "0x691E7F0", VA = "0x18691FDF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material CHBLNICKOJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6924350", Offset = "0x6922D50", VA = "0x186924350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x691F1F0", Offset = "0x691DBF0", VA = "0x18691F1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material KMFJKCJCBOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x69211F0", Offset = "0x691FBF0", VA = "0x1869211F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x69243B0", Offset = "0x6922DB0", VA = "0x1869243B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material OBOAPFCOEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x691FE70", Offset = "0x691E870", VA = "0x18691FE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6921250", Offset = "0x691FC50", VA = "0x186921250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material LNNGKFDNJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6924430", Offset = "0x6922E30", VA = "0x186924430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x69242D0", Offset = "0x6922CD0", VA = "0x1869242D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool PLCNHEDCFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6921C50", Offset = "0x6920650", VA = "0x186921C50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6920E80", Offset = "0x691F880", VA = "0x186920E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool FNGBJCJNGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6921130", Offset = "0x691FB30", VA = "0x186921130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string NHEMIDKFCGC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6925A00", Offset = "0x6924400", VA = "0x186925A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x69261D0", Offset = "0x6924BD0", VA = "0x1869261D0")]
	internal DEAIGIECMIF([Optional] MClusterData OBIPGOMKFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6921CB0", Offset = "0x69206B0", VA = "0x186921CB0")]
	public void HMCGAKKBHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x69258C0", Offset = "0x69242C0", VA = "0x1869258C0")]
	public void ONMEDEKPMOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6924680", Offset = "0x6923080", VA = "0x186924680")]
	public void NGDMFNICEEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x69212D0", Offset = "0x691FCD0", VA = "0x1869212D0")]
	public bool FMFHMIEPDID(Hash128 BGMAOMLOOIC, [Out] KNFOOLIHBPA DICFBCCFLEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6924010", Offset = "0x6922A10", VA = "0x186924010")]
	public KNFOOLIHBPA JGBCFAKMKJN(BCFKPANGLHP LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x69240D0", Offset = "0x6922AD0", VA = "0x1869240D0")]
	public LJDNNAOKEDK JGBCFAKMKJN(JBIJECILNPO GIIKGEKINDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6923E50", Offset = "0x6922850", VA = "0x186923E50")]
	public JMPHHMHALMM JGBCFAKMKJN(ONHAEABAMOA BOLGDNNEFAC, bool ALFNIAGOAEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6924570", Offset = "0x6922F70", VA = "0x186924570")]
	public void MFKDEBIIBOM(LKEFLEKLEHO EEEMMJKAAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6921AF0", Offset = "0x69204F0", VA = "0x186921AF0")]
	public static void HEFCLGPEAHP(DMPHLCEHPCF JLMHPKHAOHJ, MADCKBCBLHE[] LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6923230", Offset = "0x6921C30", VA = "0x186923230")]
	private void IICNHMFGEGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6924690", Offset = "0x6923090", VA = "0x186924690")]
	private static void NJDBOAIIFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6923B30", Offset = "0x6922530", VA = "0x186923B30")]
	public void ILADMMHKCDJ(CommandBuffer GLEICJJMPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6923060", Offset = "0x6921A60", VA = "0x186923060")]
	public void IDKLDONECLM([Optional] ScriptableRenderContext? CNBJCJOALNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x691F760", Offset = "0x691E160", VA = "0x18691F760")]
	public void ANEDJAKIIMI(CommandBuffer GLEICJJMPEC, ShadowSplitData GOAJFLELIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x691FA40", Offset = "0x691E440", VA = "0x18691FA40")]
	public void ANEDJAKIIMI(CommandBuffer GLEICJJMPEC, CameraData HJDNLOCCFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6925360", Offset = "0x6923D60", VA = "0x186925360")]
	public void OGPFGPMJPHP(CommandBuffer GLEICJJMPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6924610", Offset = "0x6923010", VA = "0x186924610")]
	public void MPEGOPJDKEJ(CommandBuffer GLEICJJMPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x691F270", Offset = "0x691DC70", VA = "0x18691F270")]
	public void AEOPJMCJNJP(CommandBuffer GLEICJJMPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6921500", Offset = "0x691FF00", VA = "0x186921500")]
	public void GNNKNDOMJJJ(CommandBuffer GLEICJJMPEC, DMPHLCEHPCF NBBLFMLBODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6920EE0", Offset = "0x691F8E0", VA = "0x186920EE0")]
	public void DOLDFDIHOOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x691FED0", Offset = "0x691E8D0", VA = "0x18691FED0")]
	public void CKOHIKCJKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6920FC0", Offset = "0x691F9C0", VA = "0x186920FC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class GDACIIDGCDE
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1F1F610", Offset = "0x1F1E010", VA = "0x181F1F610")]
	public static int PFENNEIFLFK(int HCDMGOGKHKP, int BDAGKKHHCJL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct PHKFGPAMGNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 FGMADAMOLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 HFNAFHIHMEF;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly PHKFGPAMGNO KGIEKLPIOEC;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly PHKFGPAMGNO ADOHMNBGCKE;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x692EF20", Offset = "0x692D920", VA = "0x18692EF20")]
	public PHKFGPAMGNO(float4x4 PKFEBECABLE, float4 FICFHDILBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x692EDB0", Offset = "0x692D7B0", VA = "0x18692EDB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct ENEGNDCEPAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 HGDCPNGLIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 NFFLDAHKGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 AKIMOBCHKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 PFLEIPDHLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 JDHKBMKCLKH;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct NHEIOLBDBOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 HGDCPNGLIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 NFFLDAHKGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 AKIMOBCHKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 PFLEIPDHLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 JDHKBMKCLKH;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct CBILNFCFBJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public NHEIOLBDBOD IBAOGPKJLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public NHEIOLBDBOD JOAFLLCBCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public NHEIOLBDBOD HNDHLBELEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public NHEIOLBDBOD KKGPBBDHDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public NHEIOLBDBOD IIMMGBBAEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public NHEIOLBDBOD FCNONDLDFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public NHEIOLBDBOD OJEICCCOJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public NHEIOLBDBOD LEANCPPICCN;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct CECAFOEADHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public ENEGNDCEPAI IBAOGPKJLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public ENEGNDCEPAI JOAFLLCBCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public ENEGNDCEPAI HNDHLBELEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public ENEGNDCEPAI KKGPBBDHDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public ENEGNDCEPAI IIMMGBBAEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public ENEGNDCEPAI FCNONDLDFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public ENEGNDCEPAI OJEICCCOJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public ENEGNDCEPAI LEANCPPICCN;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct NPEDHCHHCHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 FDNIDKGGKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint FMODHEJNHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint ILLCBJEFNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float FHKFKMGNGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint HNKEANNLDMA;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x692DA00", Offset = "0x692C400", VA = "0x18692DA00")]
	public NPEDHCHHCHP(JBIJECILNPO GIIKGEKINDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct NDBNMDBNGHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint FHDABMECLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint ICLMJMLJCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint DFKMKFCJDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint HNKEANNLDMA;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x692D440", Offset = "0x692BE40", VA = "0x18692D440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct CKPIFCHGINI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint DHFPIOJDCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint EFBDIHHADFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint HOLGDCGDMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint HNKEANNLDMA;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x691F0E0", Offset = "0x691DAE0", VA = "0x18691F0E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct HLAMOEEBJLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint ABEOMGGAPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint NGBMCPGMEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint KOGCBFHOFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint PKDLELOJFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint CPGHPKANNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint MHAGDGPFHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint LECEKAMHCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint HNKEANNLDMA;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x69285A0", Offset = "0x6926FA0", VA = "0x1869285A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct NHBNFJPEFIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 HFMDAAINGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 DJHBIPEBMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 DEKGFLECFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 DKNPDPOEAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 KCDHDPBBKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 CDONJCLJHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 JNEDHFHHBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 IINGFIFLMDC;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x692D4F0", Offset = "0x692BEF0", VA = "0x18692D4F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum DMPHLCEHPCF
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Opaque,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	DepthOnly,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Transparent,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Shadow
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
