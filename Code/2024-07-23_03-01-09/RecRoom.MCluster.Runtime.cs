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
	[Cpp2IlInjected.Address(RVA = "0xE13840", Offset = "0xE12A40", VA = "0x180E13840")]
	public static int OPKIABJJOFM(DMPHLCEHPCF JLMHPKHAOHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6942DA0", Offset = "0x6941FA0", VA = "0x186942DA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BE880", Offset = "0x8BDA80", VA = "0x1808BE880")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAB0B70", Offset = "0xAAFD70", VA = "0x180AB0B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BAODLBMPKDC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9BD160", Offset = "0x9BC360", VA = "0x1809BD160")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9BD210", Offset = "0x9BC410", VA = "0x1809BD210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KMCDGNKLMAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1242020", Offset = "0x1241220", VA = "0x181242020")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1241B40", Offset = "0x1240D40", VA = "0x181241B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CKCBOLCFHPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FD56A0", Offset = "0x5FD48A0", VA = "0x185FD56A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5FD5610", Offset = "0x5FD4810", VA = "0x185FD5610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MACBJJDFLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x13CFC90", Offset = "0x13CEE90", VA = "0x1813CFC90", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6944BF0", Offset = "0x6943DF0", VA = "0x186944BF0")]
	public JMPHHMHALMM(ONHAEABAMOA OGHLFHGIOLB, bool ALFNIAGOAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69439A0", Offset = "0x6942BA0", VA = "0x1869439A0")]
	private bool CNBAGEGEKLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6943FD0", Offset = "0x69431D0", VA = "0x186943FD0", Slot = "4")]
	public bool PBLNBBGFGAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6943BD0", Offset = "0x6942DD0", VA = "0x186943BD0", Slot = "5")]
	public bool LHGGKPHIKGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6943DA0", Offset = "0x6942FA0", VA = "0x186943DA0", Slot = "6")]
	public void MFKDEBIIBOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6943BC0", Offset = "0x6942DC0", VA = "0x186943BC0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7CFA0", Offset = "0xA7C1A0", VA = "0x180A7CFA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4236340", Offset = "0x4235540", VA = "0x184236340")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6946D20", Offset = "0x6945F20", VA = "0x186946D20")]
	public KOGKOIKIJMA(int DKFNFHGODON, RenderTargetIdentifier LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6946CD0", Offset = "0x6945ED0", VA = "0x186946CD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7CFA0", Offset = "0xA7C1A0", VA = "0x180A7CFA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C3F40", Offset = "0x8C3140", VA = "0x1808C3F40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xD891C0", Offset = "0xD883C0", VA = "0x180D891C0")]
	public FLGMKJOJFNC(int DKFNFHGODON, Vector4[] LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6941A80", Offset = "0x6940C80", VA = "0x186941A80", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7CFA0", Offset = "0xA7C1A0", VA = "0x180A7CFA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C3F40", Offset = "0x8C3140", VA = "0x1808C3F40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xD891C0", Offset = "0xD883C0", VA = "0x180D891C0")]
	public NJFOBBNJNLE(int DKFNFHGODON, float[] LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x69487F0", Offset = "0x69479F0", VA = "0x1869487F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C3F50", Offset = "0x8C3150", VA = "0x1808C3F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1BC44D0", Offset = "0x1BC36D0", VA = "0x181BC44D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4238720", Offset = "0x4237920", VA = "0x184238720")]
	public GICCMOJBNFD(string BHFPKCCDEEC, bool CKPMODOEIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6942D60", Offset = "0x6941F60", VA = "0x186942D60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C7800", Offset = "0x9C6A00", VA = "0x1809C7800")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C9BF0", Offset = "0x8C8DF0", VA = "0x1808C9BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8CD9B0", Offset = "0x8CCBB0", VA = "0x1808CD9B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x891DC0", Offset = "0x890FC0", VA = "0x180891DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BE8E0", Offset = "0x8BDAE0", VA = "0x1808BE8E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6943870", Offset = "0x6942A70", VA = "0x186943870")]
	public JBIJECILNPO(Color KIJNHGNFMMA, int FMODHEJNHJB, int ILLCBJEFNGA, float FHKFKMGNGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x92ED40", Offset = "0x92DF40", VA = "0x18092ED40")]
	private static float4 LMKHHILFJMH(Color KIJNHGNFMMA)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69437E0", Offset = "0x69429E0", VA = "0x1869437E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x879C50", Offset = "0x878E50", VA = "0x180879C50")]
		[CompilerGenerated]
		get
		{
			return default(JOPJAFKGMOD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xACA390", Offset = "0xAC9590", VA = "0x180ACA390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool BAODLBMPKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5941050", Offset = "0x5940250", VA = "0x185941050")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5941060", Offset = "0x5940260", VA = "0x185941060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool KMCDGNKLMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1F3C830", Offset = "0x1F3BA30", VA = "0x181F3C830")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68CACA0", Offset = "0x68C9EA0", VA = "0x1868CACA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MACBJJDFLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool CKCBOLCFHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x59F8CC0", Offset = "0x59F7EC0", VA = "0x1859F8CC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6946E50", Offset = "0x6946050", VA = "0x186946E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int LINJEMEJAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6946E60", Offset = "0x6946060", VA = "0x186946E60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x69473F0", Offset = "0x69465F0", VA = "0x1869473F0")]
	public LJDNNAOKEDK(JBIJECILNPO CEKCEFDOFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6946D40", Offset = "0x6945F40", VA = "0x186946D40")]
	private bool CNBAGEGEKLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x69471B0", Offset = "0x69463B0", VA = "0x1869471B0", Slot = "4")]
	public bool PBLNBBGFGAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6947060", Offset = "0x6946260", VA = "0x186947060")]
	private static NPEDHCHHCHP MDOLEEACALL(JBIJECILNPO OGHLFHGIOLB)
	{
		return default(NPEDHCHHCHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6946EB0", Offset = "0x69460B0", VA = "0x186946EB0", Slot = "5")]
	public bool LHGGKPHIKGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x69470A0", Offset = "0x69462A0", VA = "0x1869470A0", Slot = "6")]
	public void MFKDEBIIBOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x69474A0", Offset = "0x69466A0", VA = "0x1869474A0", Slot = "0")]
		public override bool Equals(object OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x69476A0", Offset = "0x69468A0", VA = "0x1869476A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8BE920", Offset = "0x8BDB20", VA = "0x1808BE920")]
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
			[Cpp2IlInjected.Address(RVA = "0x6947D70", Offset = "0x6946F70", VA = "0x186947D70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6947DB0", Offset = "0x6946FB0", VA = "0x186947DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6947780", Offset = "0x6946980", VA = "0x186947780", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6947750", Offset = "0x6946950", VA = "0x186947750", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GHBIMLIJLGK, RenderingData JOOKFIIMNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6947BE0", Offset = "0x6946DE0", VA = "0x186947BE0")]
		public void DOLDFDIHOOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xD96590", Offset = "0xD95790", VA = "0x180D96590")]
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
		[Cpp2IlInjected.Address(RVA = "0x858FA0", Offset = "0x8581A0", VA = "0x180858FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xDB64C0", Offset = "0xDB56C0", VA = "0x180DB64C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x870660", Offset = "0x86F860", VA = "0x180870660")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x51F22F0", Offset = "0x51F14F0", VA = "0x1851F22F0")]
	public CINCOLGGFJI(string BHFPKCCDEEC, int DDHEDMECBDP, [Optional] RenderTextureFormat? BGOCEECJDJL, bool LMDAPAIDBLJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x51F2020", Offset = "0x51F1220", VA = "0x1851F2020")]
	public void LHGGKPHIKGE(CommandBuffer GLEICJJMPEC, NativeArray<ValType> LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x51F0310", Offset = "0x51EF510", VA = "0x1851F0310")]
	public void KEPICDLKMMO(CommandBuffer GLEICJJMPEC, ComputeShader OCDMKMGEEEJ, int OPECBIAMCAG, int DNFAGJMAIJK = -1, int JMLMPALEFDO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x51F0550", Offset = "0x51EF750", VA = "0x1851F0550")]
	public void KEPICDLKMMO(Material GIIKGEKINDH, int DNFAGJMAIJK = -1, int JMLMPALEFDO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x51EFF00", Offset = "0x51EF100", VA = "0x1851EFF00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x419ED60", Offset = "0x419DF60", VA = "0x18419ED60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string NHEMIDKFCGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x41A1760", Offset = "0x41A0960", VA = "0x1841A1760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x41A28B0", Offset = "0x41A1AB0", VA = "0x1841A28B0")]
	public KLBHENNAMEG(string BHFPKCCDEEC, int KKAMIMGMJOF, int NPPHAMGPIAG, RenderTextureFormat BGOCEECJDJL, ComputeShader CLHMHPCLOHK, int OINLMJLEMKH = 0, int MENBNICCEGF = 0, int JPPEGHGPNME = 0, int AEPELGOHEEP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x419FE00", Offset = "0x419F000", VA = "0x18419FE00")]
	public int NHCCGNCLKON()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x419ED10", Offset = "0x419DF10", VA = "0x18419ED10")]
	protected void FPNCHFOJOHD(int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x41A0030", Offset = "0x419F230", VA = "0x1841A0030")]
	public JOPJAFKGMOD PBLNBBGFGAP(SrcEntry LINJEFIAFHO)
	{
		return default(JOPJAFKGMOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x419F310", Offset = "0x419E510", VA = "0x18419F310")]
	public bool LHGGKPHIKGE(JOPJAFKGMOD IIMJMBJHGDI, SrcEntry LINJEFIAFHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x419FB80", Offset = "0x419ED80", VA = "0x18419FB80")]
	public bool MFKDEBIIBOM(JOPJAFKGMOD IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "6")]
	protected virtual void LAHPHNDFKIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x419D270", Offset = "0x419C470", VA = "0x18419D270", Slot = "7")]
	public void CHIIBACHCCL(CommandBuffer GLEICJJMPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x419DCF0", Offset = "0x419CEF0", VA = "0x18419DCF0", Slot = "8")]
	public void CHIIBACHCCL(CommandBuffer GLEICJJMPEC, ComputeShader CLHMHPCLOHK, int OINLMJLEMKH = -1, int MENBNICCEGF = -1, int JPPEGHGPNME = -1, int AEPELGOHEEP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x419EDF0", Offset = "0x419DFF0", VA = "0x18419EDF0", Slot = "9")]
	public void KEPICDLKMMO(CommandBuffer GLEICJJMPEC, ComputeShader CLHMHPCLOHK, int OINLMJLEMKH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x419ED70", Offset = "0x419DF70", VA = "0x18419ED70", Slot = "4")]
	public void KEPICDLKMMO(Material GIIKGEKINDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x419E710", Offset = "0x419D910", VA = "0x18419E710", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x8C3F40", Offset = "0x8C3140", VA = "0x1808C3F40", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6102DD0", Offset = "0x6101FD0", VA = "0x186102DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong MCBEEGCCLFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x15015F0", Offset = "0x15007F0", VA = "0x1815015F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4CB5C40", Offset = "0x4CB4E40", VA = "0x184CB5C40")]
		internal AHBHPPJFCJI(IDisposable COAEDMPNFJB, ulong DKJDJIIEMAP, ulong HEPBKGOLGNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6939980", Offset = "0x6938B80", VA = "0x186939980", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8C3F40", Offset = "0x8C3140", VA = "0x1808C3F40", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6102DD0", Offset = "0x6101FD0", VA = "0x186102DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong MCBEEGCCLFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x15015F0", Offset = "0x15007F0", VA = "0x1815015F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x69488C0", Offset = "0x6947AC0", VA = "0x1869488C0")]
		public NNBIOCGEOEF(RenderTexture IPABEBMKKAM, ulong MLOPNMMLMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6948820", Offset = "0x6947A20", VA = "0x186948820", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong PAKCKEDIGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x69423B0", Offset = "0x69415B0", VA = "0x1869423B0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6941CF0", Offset = "0x6940EF0", VA = "0x186941CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong JHAOJAGGGEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6941CB0", Offset = "0x6940EB0", VA = "0x186941CB0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69423F0", Offset = "0x69415F0", VA = "0x1869423F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x69420D0", Offset = "0x69412D0", VA = "0x1869420D0")]
	public static ComputeBuffer JGIIBNEOBDO(int IHGHLPOONHD, int BAILPPBNEOE, ComputeBufferType NCMHJNKFAGH, [Out] APNJCOCCDKF IIMJMBJHGDI, ComputeBufferMode DNCAOAEPAKK = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6941D30", Offset = "0x6940F30", VA = "0x186941D30")]
	public static RenderTexture JGIIBNEOBDO(int IJAJOPPBLCP, int FNKAMPFNBJB, int EIGOHCGBEGP, RenderTextureFormat BGOCEECJDJL, [Out] APNJCOCCDKF IIMJMBJHGDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2B33170", Offset = "0x2B32370", VA = "0x182B33170")]
	public static NativeArray<T> KFOJLOIIIPO<T>(NativeArray<T> GDBEHNBLALJ, ulong OMJPDIKPOLO, [Out] APNJCOCCDKF IIMJMBJHGDI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2B330B0", Offset = "0x2B322B0", VA = "0x182B330B0")]
	public static NativeArray<T> JGIIBNEOBDO<T>(int OMJPDIKPOLO, Allocator CHDJMCMMMLJ, [Out] APNJCOCCDKF IIMJMBJHGDI, NativeArrayOptions FDGBBGJEJMA = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6941B60", Offset = "0x6940D60", VA = "0x186941B60")]
	public static void CKOHIKCJKJA(APNJCOCCDKF GDBEHNBLALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69422B0", Offset = "0x69414B0", VA = "0x1869422B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6939FA0", Offset = "0x69391A0", VA = "0x186939FA0")]
		public CIKCPHGGEFO(NativeArray<int> BLADFIIDJNK, NativeArray<float> PNNBEODNIHJ, NativeArray<float4x4> BJGEMDDDDFC, NativeArray<float4> BFPMJMDDAIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6939DE0", Offset = "0x6938FE0", VA = "0x186939DE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6939FA0", Offset = "0x69391A0", VA = "0x186939FA0")]
		public LOLCIACLPEE(NativeArray<int> BLADFIIDJNK, NativeArray<float4x4> KBJIPJHNGMD, NativeArray<float4> GPGCIIAJKHI, NativeArray<PHKFGPAMGNO> BCCFKHCCLFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6947430", Offset = "0x6946630", VA = "0x186947430", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6942A80", Offset = "0x6941C80", VA = "0x186942A80")]
	public GHMGGBOFFKE(int KKAMIMGMJOF, int NPPHAMGPIAG, ComputeShader CLHMHPCLOHK, int OINLMJLEMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6942670", Offset = "0x6941870", VA = "0x186942670", Slot = "6")]
	protected override void LAHPHNDFKIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6942430", Offset = "0x6941630", VA = "0x186942430")]
	private void AGPGDDICNED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6942920", Offset = "0x6941B20", VA = "0x186942920")]
	public bool PLBOCBLAIJH(JOPJAFKGMOD IIMJMBJHGDI, Transform FMAJPAMCPCL, float AGMKDHBOCAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6942590", Offset = "0x6941790", VA = "0x186942590")]
	public void GKFEPNPAAOJ(JOPJAFKGMOD IIMJMBJHGDI, float AGMKDHBOCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6942870", Offset = "0x6941A70", VA = "0x186942870")]
	public void PFNHLOKDILH(JOPJAFKGMOD IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x69424F0", Offset = "0x69416F0", VA = "0x1869424F0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C9BF0", Offset = "0x8C8DF0", VA = "0x1808C9BF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x98EF30", Offset = "0x98E130", VA = "0x18098EF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool LONEJKONMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8569C0", Offset = "0x855BC0", VA = "0x1808569C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int JGHJDPGMBEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x891DC0", Offset = "0x890FC0", VA = "0x180891DC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8913C0", Offset = "0x8905C0", VA = "0x1808913C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int GOHGHPNIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x852880", Offset = "0x851A80", VA = "0x180852880", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8528D0", Offset = "0x851AD0", VA = "0x1808528D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int BJIBOLIHFFK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xB499E0", Offset = "0xB48BE0", VA = "0x180B499E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> PHJFFHJCDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6939BC0", Offset = "0x6938DC0", VA = "0x186939BC0", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> HIKGGMOMAFA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6939CC0", Offset = "0x6938EC0", VA = "0x186939CC0", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> AMBHMAAPEIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6939CF0", Offset = "0x6938EF0", VA = "0x186939CF0", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> LNLLIHFLAPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6939B50", Offset = "0x6938D50", VA = "0x186939B50", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> MBODMHHCGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6939D30", Offset = "0x6938F30", VA = "0x186939D30", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> JFNADOODDJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6939D60", Offset = "0x6938F60", VA = "0x186939D60", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool HDMNHKNGLFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9C14D0", Offset = "0x9C06D0", VA = "0x1809C14D0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA17490", Offset = "0xA16690", VA = "0x180A17490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int LEACNAEMLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6939D20", Offset = "0x6938F20", VA = "0x186939D20", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int BCHIJPGLELM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6939A00", Offset = "0x6938C00", VA = "0x186939A00", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int CEMIBEANIKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6939A20", Offset = "0x6938C20", VA = "0x186939A20", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6939D90", Offset = "0x6938F90", VA = "0x186939D90")]
	public BLELMJPNJEN(Hash128 BGMAOMLOOIC, HIJDLNMAIDB BCHLKOMDDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6939A40", Offset = "0x6938C40", VA = "0x186939A40", Slot = "16")]
	public void CHIIBACHCCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6939C30", Offset = "0x6938E30", VA = "0x186939C30", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7CFA0", Offset = "0xA7C1A0", VA = "0x180A7CFA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xA7CFB0", Offset = "0xA7C1B0", VA = "0x180A7CFB0")]
	public JOPJAFKGMOD(int DHNLEFJCEAH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6944D60", Offset = "0x6943F60", VA = "0x186944D60", Slot = "4")]
	public bool Equals(JOPJAFKGMOD OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6944DB0", Offset = "0x6943FB0", VA = "0x186944DB0", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6944E80", Offset = "0x6944080", VA = "0x186944E80", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x69456E0", Offset = "0x69448E0", VA = "0x1869456E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6945E80", Offset = "0x6945080", VA = "0x186945E80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool BAODLBMPKDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8A6350", Offset = "0x8A5550", VA = "0x1808A6350")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9AE710", Offset = "0x9AD910", VA = "0x1809AE710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool KMCDGNKLMAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xB80600", Offset = "0xB7F800", VA = "0x180B80600")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xB805F0", Offset = "0xB7F7F0", VA = "0x180B805F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool MACBJJDFLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool CKCBOLCFHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4AA4AC0", Offset = "0x4AA3CC0", VA = "0x184AA4AC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x197C2C0", Offset = "0x197B4C0", VA = "0x18197C2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float BKLIGEBDFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF80", Offset = "0x8BE180", VA = "0x1808BEF80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1D442A0", Offset = "0x1D434A0", VA = "0x181D442A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6946B60", Offset = "0x6945D60", VA = "0x186946B60")]
	public KNFOOLIHBPA(BCFKPANGLHP DICFBCCFLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6945210", Offset = "0x6944410", VA = "0x186945210")]
	private void FDPFMCMGBHA(BCFKPANGLHP DICFBCCFLEI, int BHPOFKEKDPM, int DHFPIOJDCMP, int DHNLEFJCEAH, int DFKMKFCJDLL, ENEGNDCEPAI LINJEFIAFHO, float NFOAOKAEGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6945EC0", Offset = "0x69450C0", VA = "0x186945EC0")]
	private void PAIKNHHJAJB(BCFKPANGLHP DICFBCCFLEI, int CJJJGHMBDLE, int DHNLEFJCEAH, uint3 AGNLKBKPJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6944F10", Offset = "0x6944110", VA = "0x186944F10")]
	private bool CNBAGEGEKLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6946180", Offset = "0x6945380", VA = "0x186946180", Slot = "4")]
	public bool PBLNBBGFGAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6945790", Offset = "0x6944990", VA = "0x186945790", Slot = "5")]
	public bool LHGGKPHIKGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6945810", Offset = "0x6944A10", VA = "0x186945810", Slot = "6")]
	public void MFKDEBIIBOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x69451B0", Offset = "0x69443B0", VA = "0x1869451B0")]
	public void OBIHBOAALDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x69451B0", Offset = "0x69443B0", VA = "0x1869451B0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0xDBBDB0", Offset = "0xDBAFB0", VA = "0x180DBBDB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xDDECF0", Offset = "0xDDDEF0", VA = "0x180DDECF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool FNGBJCJNGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x69490C0", Offset = "0x69482C0", VA = "0x1869490C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string NHEMIDKFCGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6949720", Offset = "0x6948920", VA = "0x186949720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6949710", Offset = "0x6948910", VA = "0x186949710")]
	public void OLNLHDFKAOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x69489D0", Offset = "0x6947BD0", VA = "0x1869489D0")]
	public void AJNADNONHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6949B10", Offset = "0x6948D10", VA = "0x186949B10")]
	public PCBFKFADJAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6949550", Offset = "0x6948750", VA = "0x186949550")]
	public JMPHHMHALMM JGBCFAKMKJN(ONHAEABAMOA BOLGDNNEFAC, bool ALFNIAGOAEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6949130", Offset = "0x6948330", VA = "0x186949130")]
	public LJDNNAOKEDK JGBCFAKMKJN(JBIJECILNPO GIIKGEKINDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x69489E0", Offset = "0x6947BE0", VA = "0x1869489E0")]
	public bool BEACNPBIPNG(Hash128 DKFNFHGODON, [Out] KNFOOLIHBPA ILIHHIBNPDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6949270", Offset = "0x6948470", VA = "0x186949270")]
	public KNFOOLIHBPA JGBCFAKMKJN(BCFKPANGLHP DICFBCCFLEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6949110", Offset = "0x6948310", VA = "0x186949110")]
	private void FIFEAJLOGPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6949680", Offset = "0x6948880", VA = "0x186949680")]
	private bool KCDNAJGMBKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6948B00", Offset = "0x6947D00", VA = "0x186948B00")]
	public void CHIIBACHCCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6948FB0", Offset = "0x69481B0", VA = "0x186948FB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6948A50", Offset = "0x6947C50", VA = "0x186948A50")]
	public void BPGAAPNDOCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GACGJCAJBBC : KLBHENNAMEG<HLAMOEEBJLO, HLAMOEEBJLO>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6941AB0", Offset = "0x6940CB0", VA = "0x186941AB0")]
	public GACGJCAJBBC(int KKAMIMGMJOF, int NPPHAMGPIAG, ComputeShader CLHMHPCLOHK, int OINLMJLEMKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JOEFEBDFGDN : KLBHENNAMEG<NPEDHCHHCHP, NPEDHCHHCHP>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6944CB0", Offset = "0x6943EB0", VA = "0x186944CB0")]
	public JOEFEBDFGDN(int KKAMIMGMJOF, int NPPHAMGPIAG, ComputeShader CLHMHPCLOHK, int OINLMJLEMKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class OJINGJKFNGN : KLBHENNAMEG<CKPIFCHGINI, CKPIFCHGINI>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6948920", Offset = "0x6947B20", VA = "0x186948920")]
	public OJINGJKFNGN(int KKAMIMGMJOF, int NPPHAMGPIAG, ComputeShader CLHMHPCLOHK, int OINLMJLEMKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class DNFDDNNHBAP : KLBHENNAMEG<CECAFOEADHH, CBILNFCFBJH>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x69419D0", Offset = "0x6940BD0", VA = "0x1869419D0")]
	public DNFDDNNHBAP(int KKAMIMGMJOF, int NPPHAMGPIAG, ComputeShader CLHMHPCLOHK, int OINLMJLEMKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class DIKJBMLPOII : KLBHENNAMEG<NHBNFJPEFIO, NHBNFJPEFIO>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6941320", Offset = "0x6940520", VA = "0x186941320")]
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
	[Cpp2IlInjected.Address(RVA = "0x6941990", Offset = "0x6940B90", VA = "0x186941990")]
	public DMIKJHKALAG(DEAIGIECMIF CLOMILMHHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6941800", Offset = "0x6940A00", VA = "0x186941800", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer GLEICJJMPEC, RenderingData JOOKFIIMNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6941590", Offset = "0x6940790", VA = "0x186941590", Slot = "6")]
	public override void Configure(CommandBuffer GLEICJJMPEC, RenderTextureDescriptor MAFOPCMGPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x69415D0", Offset = "0x69407D0", VA = "0x1869415D0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x6941480", Offset = "0x6940680", VA = "0x186941480")]
		public DMGOGCLKILE(string MIPPAJFOFDN, ScriptableRenderContext KCIPFDAONKD, [Out] CommandBuffer FEGAKLGEDDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x69413D0", Offset = "0x69405D0", VA = "0x1869413D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6947E10", Offset = "0x6947010", VA = "0x186947E10")]
	public static bool FAACPPLHKDH(RenderingData JOOKFIIMNNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6948190", Offset = "0x6947390", VA = "0x186948190")]
	public static void NMKBCEIBOML(CommandBuffer GLEICJJMPEC, ScriptableRenderContext CNBJCJOALNK, ShadowDrawingSettings EMGFDJGDLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6947F60", Offset = "0x6947160", VA = "0x186947F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x693A600", Offset = "0x6939800", VA = "0x18693A600")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x693A080", Offset = "0x6939280", VA = "0x18693A080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool FGMEHJIGBFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x693AC90", Offset = "0x6939E90", VA = "0x18693AC90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x693BFC0", Offset = "0x693B1C0", VA = "0x18693BFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData CPPCAMCFLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6940850", Offset = "0x693FA50", VA = "0x186940850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x693F380", Offset = "0x693E580", VA = "0x18693F380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static GHMGGBOFFKE IMBACGJFJFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6940FD0", Offset = "0x69401D0", VA = "0x186940FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x693CAD0", Offset = "0x693BCD0", VA = "0x18693CAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static GACGJCAJBBC HKMHMGMMCJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x693C3A0", Offset = "0x693B5A0", VA = "0x18693C3A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x693F3F0", Offset = "0x693E5F0", VA = "0x18693F3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static JOEFEBDFGDN NHKNFLNKBHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x693F4B0", Offset = "0x693E6B0", VA = "0x18693F4B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x693C2C0", Offset = "0x693B4C0", VA = "0x18693C2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static OJINGJKFNGN OPKAICGGLAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x69408A0", Offset = "0x693FAA0", VA = "0x1869408A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x693C330", Offset = "0x693B530", VA = "0x18693C330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static DNFDDNNHBAP LKMKCBIONCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x693C260", Offset = "0x693B460", VA = "0x18693C260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x693AC10", Offset = "0x6939E10", VA = "0x18693AC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static DIKJBMLPOII BHGBFOOILOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x693C080", Offset = "0x693B280", VA = "0x18693C080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x693ACE0", Offset = "0x6939EE0", VA = "0x18693ACE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material CHBLNICKOJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x693F240", Offset = "0x693E440", VA = "0x18693F240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x693A0E0", Offset = "0x69392E0", VA = "0x18693A0E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material KMFJKCJCBOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x693C0E0", Offset = "0x693B2E0", VA = "0x18693C0E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x693F2A0", Offset = "0x693E4A0", VA = "0x18693F2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material OBOAPFCOEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x693AD60", Offset = "0x6939F60", VA = "0x18693AD60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x693C140", Offset = "0x693B340", VA = "0x18693C140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material LNNGKFDNJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x693F320", Offset = "0x693E520", VA = "0x18693F320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x693F1C0", Offset = "0x693E3C0", VA = "0x18693F1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool PLCNHEDCFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x693CB40", Offset = "0x693BD40", VA = "0x18693CB40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x693BD70", Offset = "0x693AF70", VA = "0x18693BD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool FNGBJCJNGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x693C020", Offset = "0x693B220", VA = "0x18693C020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string NHEMIDKFCGC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x69408F0", Offset = "0x693FAF0", VA = "0x1869408F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x69410C0", Offset = "0x69402C0", VA = "0x1869410C0")]
	internal DEAIGIECMIF([Optional] MClusterData OBIPGOMKFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x693CBA0", Offset = "0x693BDA0", VA = "0x18693CBA0")]
	public void HMCGAKKBHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x69407B0", Offset = "0x693F9B0", VA = "0x1869407B0")]
	public void ONMEDEKPMOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x693F570", Offset = "0x693E770", VA = "0x18693F570")]
	public void NGDMFNICEEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x693C1C0", Offset = "0x693B3C0", VA = "0x18693C1C0")]
	public bool FMFHMIEPDID(Hash128 BGMAOMLOOIC, [Out] KNFOOLIHBPA DICFBCCFLEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x693EF00", Offset = "0x693E100", VA = "0x18693EF00")]
	public KNFOOLIHBPA JGBCFAKMKJN(BCFKPANGLHP LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x693EFC0", Offset = "0x693E1C0", VA = "0x18693EFC0")]
	public LJDNNAOKEDK JGBCFAKMKJN(JBIJECILNPO GIIKGEKINDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x693ED40", Offset = "0x693DF40", VA = "0x18693ED40")]
	public JMPHHMHALMM JGBCFAKMKJN(ONHAEABAMOA BOLGDNNEFAC, bool ALFNIAGOAEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x693F460", Offset = "0x693E660", VA = "0x18693F460")]
	public void MFKDEBIIBOM(LKEFLEKLEHO EEEMMJKAAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x693C9E0", Offset = "0x693BBE0", VA = "0x18693C9E0")]
	public static void HEFCLGPEAHP(DMPHLCEHPCF JLMHPKHAOHJ, MADCKBCBLHE[] LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x693E120", Offset = "0x693D320", VA = "0x18693E120")]
	private void IICNHMFGEGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x693F580", Offset = "0x693E780", VA = "0x18693F580")]
	private static void NJDBOAIIFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x693EA20", Offset = "0x693DC20", VA = "0x18693EA20")]
	public void ILADMMHKCDJ(CommandBuffer GLEICJJMPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x693DF50", Offset = "0x693D150", VA = "0x18693DF50")]
	public void IDKLDONECLM([Optional] ScriptableRenderContext? CNBJCJOALNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x693A650", Offset = "0x6939850", VA = "0x18693A650")]
	public void ANEDJAKIIMI(CommandBuffer GLEICJJMPEC, ShadowSplitData GOAJFLELIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x693A930", Offset = "0x6939B30", VA = "0x18693A930")]
	public void ANEDJAKIIMI(CommandBuffer GLEICJJMPEC, CameraData HJDNLOCCFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6940250", Offset = "0x693F450", VA = "0x186940250")]
	public void OGPFGPMJPHP(CommandBuffer GLEICJJMPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x693F500", Offset = "0x693E700", VA = "0x18693F500")]
	public void MPEGOPJDKEJ(CommandBuffer GLEICJJMPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x693A160", Offset = "0x6939360", VA = "0x18693A160")]
	public void AEOPJMCJNJP(CommandBuffer GLEICJJMPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x693C3F0", Offset = "0x693B5F0", VA = "0x18693C3F0")]
	public void GNNKNDOMJJJ(CommandBuffer GLEICJJMPEC, DMPHLCEHPCF NBBLFMLBODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x693BDD0", Offset = "0x693AFD0", VA = "0x18693BDD0")]
	public void DOLDFDIHOOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x693ADC0", Offset = "0x6939FC0", VA = "0x18693ADC0")]
	public void CKOHIKCJKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x693BEB0", Offset = "0x693B0B0", VA = "0x18693BEB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class GDACIIDGCDE
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1F2A5D0", Offset = "0x1F297D0", VA = "0x181F2A5D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6949E10", Offset = "0x6949010", VA = "0x186949E10")]
	public PHKFGPAMGNO(float4x4 PKFEBECABLE, float4 FICFHDILBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6949CA0", Offset = "0x6948EA0", VA = "0x186949CA0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x69488F0", Offset = "0x6947AF0", VA = "0x1869488F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6948330", Offset = "0x6947530", VA = "0x186948330", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x6939FD0", Offset = "0x69391D0", VA = "0x186939FD0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x6943490", Offset = "0x6942690", VA = "0x186943490", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x69483E0", Offset = "0x69475E0", VA = "0x1869483E0", Slot = "3")]
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
