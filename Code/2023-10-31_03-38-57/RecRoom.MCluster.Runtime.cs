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
public struct DBNLJFKNGJA
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] KCEMCKBCBOD;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] AKLGKADNMIH;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] AAJHEFNINFE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xBC9740", Offset = "0xBC8B40", VA = "0x180BC9740")]
	public static int CLLALMNDCLB(ADFILICAFNJ ALDHADGKGIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD7E0", Offset = "0x5CACBE0", VA = "0x185CAD7E0")]
	public static int NEMEDLPEBDC(ADFILICAFNJ ALDHADGKGIB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GIPOLAABKBF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int LIIOLAMOBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FNADCPGHPGD GJBBMKPIING(int FJPBEGOLMMB);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 CHBBILBKDOI(int FJPBEGOLMMB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FJPDIMNMGMC IMJFGLOPGCJ();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MMGCNEEHMCO EGIDCBFGMKK();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AGKKNENMDIF : BENEJPEBDBD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private FJPDIMNMGMC OLPLDGDFGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform KHNDDADCEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<KGAFOEBHBHH> CLPHGJKCCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private CIBIFCCLMKO MNHJMIMHHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IJJHJEEIBOL NOFCNNDHGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool PNLAKCHENAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private GIPOLAABKBF DJJHBPNMEGI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float OHPEPFDLMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8010F0", Offset = "0x8004F0", VA = "0x1808010F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA14130", Offset = "0xA13530", VA = "0x180A14130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CCLOMNLNDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8010D0", Offset = "0x8004D0", VA = "0x1808010D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAF1070", Offset = "0xAF0470", VA = "0x180AF1070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool EEMKCEPNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7A9E90", Offset = "0x7A9290", VA = "0x1807A9E90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7A9B60", Offset = "0x7A8F60", VA = "0x1807A9B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool ENMLFMOLLEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CACE80", Offset = "0x5CAC280", VA = "0x185CACE80", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5CACE90", Offset = "0x5CAC290", VA = "0x185CACE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool IPBJOPBIFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x104D4D0", Offset = "0x104C8D0", VA = "0x18104D4D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CACEA0", Offset = "0x5CAC2A0", VA = "0x185CACEA0")]
	public AGKKNENMDIF(GIPOLAABKBF BCOICEBLMNF, bool MHFIFPODFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CABE50", Offset = "0x5CAB250", VA = "0x185CABE50")]
	private bool CHNHCFFACPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC250", Offset = "0x5CAB650", VA = "0x185CAC250", Slot = "4")]
	public bool INMJBKGEACO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC080", Offset = "0x5CAB480", VA = "0x185CAC080", Slot = "5")]
	public bool GFEAHGHFDLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CABC20", Offset = "0x5CAB020", VA = "0x185CABC20", Slot = "6")]
	public void BLFHNKIOGCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC070", Offset = "0x5CAB470", VA = "0x185CAC070", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KIKIAICDCLK
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BOILAEEPCIL(CommandBuffer LNCOGBLJJNB);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OJJHCGLOIEN : KIKIAICDCLK
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int FPOLJBGEJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAD0", Offset = "0x7DEED0", VA = "0x1807DFAD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier IFJDJOICJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3955090", Offset = "0x3954490", VA = "0x183955090")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBA70", Offset = "0x5CBAE70", VA = "0x185CBBA70")]
	public OJJHCGLOIEN(int PIKCMFPLBNL, RenderTargetIdentifier GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBA20", Offset = "0x5CBAE20", VA = "0x185CBBA20", Slot = "4")]
	public void BOILAEEPCIL(CommandBuffer LNCOGBLJJNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct OGJHHEKIAAA : KIKIAICDCLK
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int FPOLJBGEJBC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAD0", Offset = "0x7DEED0", VA = "0x1807DFAD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] DECFAEKHFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x998C40", Offset = "0x998040", VA = "0x180998C40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xAE29E0", Offset = "0xAE1DE0", VA = "0x180AE29E0")]
	public OGJHHEKIAAA(int PIKCMFPLBNL, Vector4[] GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CBB9F0", Offset = "0x5CBADF0", VA = "0x185CBB9F0", Slot = "4")]
	public void BOILAEEPCIL(CommandBuffer LNCOGBLJJNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct PLKOMCLBJMF : KIKIAICDCLK
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int FPOLJBGEJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAD0", Offset = "0x7DEED0", VA = "0x1807DFAD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] FPKGNMGIKDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x998C40", Offset = "0x998040", VA = "0x180998C40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xAE29E0", Offset = "0xAE1DE0", VA = "0x180AE29E0")]
	public PLKOMCLBJMF(int PIKCMFPLBNL, float[] GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBD00", Offset = "0x5CBB100", VA = "0x185CBBD00", Slot = "4")]
	public void BOILAEEPCIL(CommandBuffer LNCOGBLJJNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct LKOPPJAGINA : KIKIAICDCLK
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string PCDEPGOAGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool FGAOPKACOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x178B900", Offset = "0x178AD00", VA = "0x18178B900")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x395D010", Offset = "0x395C410", VA = "0x18395D010")]
	public LKOPPJAGINA(string LFAIHEECJFK, bool EGKJFJONNCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CBA460", Offset = "0x5CB9860", VA = "0x185CBA460", Slot = "4")]
	public void BOILAEEPCIL(CommandBuffer LNCOGBLJJNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct MMGCNEEHMCO
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 CJEBEBOFCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA9D3F0", Offset = "0xA9C7F0", VA = "0x180A9D3F0")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 CPPPLPPMGFP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA9D400", Offset = "0xA9C800", VA = "0x180A9D400")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int FNHEFMEPKEM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8124E0", Offset = "0x8118E0", VA = "0x1808124E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int MKBNEHLPCIK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x79E250", Offset = "0x79D650", VA = "0x18079E250")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float HAKLDKPFLGD
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7B2030", Offset = "0x7B1430", VA = "0x1807B2030")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5CBAF50", Offset = "0x5CBA350", VA = "0x185CBAF50")]
	public MMGCNEEHMCO(Color DJDNAMFLFCL, int DBELPICKLDB, int PIEALCBDGOA, float EGEHCFDEJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x528DD10", Offset = "0x528D110", VA = "0x18528DD10")]
	private static float4 OPMLCAJNJLF(Color DJDNAMFLFCL)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5CBAEC0", Offset = "0x5CBA2C0", VA = "0x185CBAEC0")]
	private static Hash128 JOLPNOMIJHP(MMGCNEEHMCO BCOICEBLMNF)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CIBIFCCLMKO : BENEJPEBDBD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string MMNEPABJMAA;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string EBCJBHGMHMG;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string CNOIJELFNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private MMGCNEEHMCO JCHDBPLKJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private CBKBPMOMGCB JGKNCBCEPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 HKIJBNBDHNF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public IJJHJEEIBOL IPBJJAEFLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x784EF0", Offset = "0x7842F0", VA = "0x180784EF0")]
		[CompilerGenerated]
		get
		{
			return default(IJJHJEEIBOL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x809A30", Offset = "0x808E30", VA = "0x180809A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool CCLOMNLNDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1930030", Offset = "0x192F430", VA = "0x181930030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x192F330", Offset = "0x192E730", VA = "0x18192F330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool EEMKCEPNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x192E580", Offset = "0x192D980", VA = "0x18192E580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x192FBE0", Offset = "0x192EFE0", VA = "0x18192FBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IPBJOPBIFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7785F0", Offset = "0x7779F0", VA = "0x1807785F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool ENMLFMOLLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4ECF940", Offset = "0x4ECED40", VA = "0x184ECF940", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5AE0AC0", Offset = "0x5ADFEC0", VA = "0x185AE0AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int CBNNNKAIBOB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5CAD100", Offset = "0x5CAC500", VA = "0x185CAD100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD7A0", Offset = "0x5CACBA0", VA = "0x185CAD7A0")]
	public CIBIFCCLMKO(MMGCNEEHMCO KIJFOJEHAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD260", Offset = "0x5CAC660", VA = "0x185CAD260")]
	private bool CHNHCFFACPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD520", Offset = "0x5CAC920", VA = "0x185CAD520", Slot = "4")]
	public bool INMJBKGEACO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD670", Offset = "0x5CACA70", VA = "0x185CAD670")]
	private static CBKBPMOMGCB KGCLPDOEIJL(MMGCNEEHMCO BCOICEBLMNF)
	{
		return default(CBKBPMOMGCB);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD370", Offset = "0x5CAC770", VA = "0x185CAD370", Slot = "5")]
	public bool GFEAHGHFDLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD150", Offset = "0x5CAC550", VA = "0x185CAD150", Slot = "6")]
	public void BLFHNKIOGCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5CBA550", Offset = "0x5CB9950", VA = "0x185CBA550", Slot = "0")]
		public override bool Equals(object LJIBJAOOGGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5CBA750", Offset = "0x5CB9B50", VA = "0x185CBA750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84D6E0", Offset = "0x84CAE0", VA = "0x18084D6E0")]
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
		private GJEGJDNKHIK opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static DLDFFLBLKNJ CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5CBAE20", Offset = "0x5CBA220", VA = "0x185CBAE20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5CBAE60", Offset = "0x5CBA260", VA = "0x185CBAE60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5CBA9C0", Offset = "0x5CB9DC0", VA = "0x185CBA9C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5CBA800", Offset = "0x5CB9C00", VA = "0x185CBA800", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AOGGKMLJCIM, RenderingData MIMMFKGHJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5CBA830", Offset = "0x5CB9C30", VA = "0x185CBA830")]
		public void CGGIBHHMBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xAC3410", Offset = "0xAC2810", VA = "0x180AC3410")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JIOIIOAPENJ<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private PLMPKGFLMFA EFINMBPMLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private PLMPKGFLMFA CFKALKJPOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer IMOFLFEPPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture KPNGHJEFECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int DKAMJCPJPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int ENGFBNIIJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string AAGHMCNBMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string KHPHOJDFMBH;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x764F00", Offset = "0x764300", VA = "0x180764F00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int BIHCINEODON
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xAE4260", Offset = "0xAE3660", VA = "0x180AE4260")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int GJIIMBPJMND
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x77B8E0", Offset = "0x77ACE0", VA = "0x18077B8E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3843F30", Offset = "0x3843330", VA = "0x183843F30")]
	public JIOIIOAPENJ(string LFAIHEECJFK, int PJHBIMBPHON, [Optional] RenderTextureFormat? LFCIMIBPFKO, bool LBHNMMIKABE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3842A70", Offset = "0x3841E70", VA = "0x183842A70")]
	public void GFEAHGHFDLK(CommandBuffer LNCOGBLJJNB, NativeArray<ValType> GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3841000", Offset = "0x3840400", VA = "0x183841000")]
	public void ADJADLDGLFM(CommandBuffer LNCOGBLJJNB, ComputeShader CFKEHAHIJHG, int NOCAIFBEJNI, int FCLKHDKKLKA = -1, int MENHNOPDKGJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x38415C0", Offset = "0x38409C0", VA = "0x1838415C0")]
	public void ADJADLDGLFM(Material JGKNCBCEPPI, int FCLKHDKKLKA = -1, int MENHNOPDKGJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3841C10", Offset = "0x3841010", VA = "0x183841C10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PBLNMAAGFAG
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADJADLDGLFM(Material KIJFOJEHAKL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OPHKDCKCHJO<SrcEntry, DstEntry> : PBLNMAAGFAG, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] BJBKCCJEOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected PLMPKGFLMFA BNOCJAAGCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected PLMPKGFLMFA LBDBECCKOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> JLFPKPLEBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> CEIAGOHBBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int IEOEHOFKDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int OJMFHGKJLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected JIOIIOAPENJ<int> KKDFCKGECFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected JIOIIOAPENJ<SrcEntry> ONFNOAONIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected JIOIIOAPENJ<DstEntry> NNGFMAKCMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader DDKJMNGCEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int KBCJBBKGCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int NJHGPFDMPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int GADJBFHCJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int CFNEOALDLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int FKEOFMDKGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int IHLDGFCJMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int GDNBHIJCEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int BMKDFBDGJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int OJPCJNDFPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int HMIEAEHJELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int CJFLHMBEDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int JLLFEFDLECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string IHKHCFFBPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] ONDFNNJMIBF;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int EKKOAOPJJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3D0A610", Offset = "0x3D09A10", VA = "0x183D0A610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string LCENEMEPMLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3D0ABF0", Offset = "0x3D09FF0", VA = "0x183D0ABF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3D0F960", Offset = "0x3D0ED60", VA = "0x183D0F960")]
	public OPHKDCKCHJO(string LFAIHEECJFK, int IFICPNKPIOB, int BAGBFDHNOPH, RenderTextureFormat LFCIMIBPFKO, ComputeShader CPBEBKPJLCI, int EFEDCMIIANP = 0, int ONOADIHKBIB = 0, int HGGOBICMIFF = 0, int DPBAMHMIEBL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3D0DC60", Offset = "0x3D0D060", VA = "0x183D0DC60")]
	public int IFLEAOGNDBL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3D0E690", Offset = "0x3D0DA90", VA = "0x183D0E690")]
	protected void JAIODKMKBHK(int APOENOPNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3D0DCD0", Offset = "0x3D0D0D0", VA = "0x183D0DCD0")]
	public IJJHJEEIBOL INMJBKGEACO(SrcEntry GHFAAPNAFDE)
	{
		return default(IJJHJEEIBOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3D0D670", Offset = "0x3D0CA70", VA = "0x183D0D670")]
	public bool GFEAHGHFDLK(IJJHJEEIBOL DELBIPHKFDD, SrcEntry GHFAAPNAFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A7A0", Offset = "0x3D09BA0", VA = "0x183D0A7A0")]
	public bool BLFHNKIOGCM(IJJHJEEIBOL DELBIPHKFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "6")]
	protected virtual void EIMMMKPLADO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3D0BD10", Offset = "0x3D0B110", VA = "0x183D0BD10", Slot = "7")]
	public void CJLBLNKPHHN(CommandBuffer LNCOGBLJJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C070", Offset = "0x3D0B470", VA = "0x183D0C070", Slot = "8")]
	public void CJLBLNKPHHN(CommandBuffer LNCOGBLJJNB, ComputeShader CPBEBKPJLCI, int EFEDCMIIANP = -1, int ONOADIHKBIB = -1, int HGGOBICMIFF = -1, int DPBAMHMIEBL = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A450", Offset = "0x3D09850", VA = "0x183D0A450", Slot = "9")]
	public void ADJADLDGLFM(CommandBuffer LNCOGBLJJNB, ComputeShader CPBEBKPJLCI, int EFEDCMIIANP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A5C0", Offset = "0x3D099C0", VA = "0x183D0A5C0", Slot = "4")]
	public void ADJADLDGLFM(Material JGKNCBCEPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3D0CE30", Offset = "0x3D0C230", VA = "0x183D0CE30", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PLMPKGFLMFA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong NBJLMHOEKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong DAEAAFKCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GKPLFOBOIPF
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct AMPOCPINMLE : PLMPKGFLMFA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable HAMLMPEDKMB;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong NBJLMHOEKFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x998C40", Offset = "0x998040", VA = "0x180998C40", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5555240", Offset = "0x5554640", VA = "0x185555240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong DAEAAFKCNDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x11802D0", Offset = "0x117F6D0", VA = "0x1811802D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5CAD090", Offset = "0x5CAC490", VA = "0x185CAD090")]
		internal AMPOCPINMLE(IDisposable OKBCHDJAHCO, ulong KNFDHFLMGJD, ulong DFCABBNOOIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5CAD010", Offset = "0x5CAC410", VA = "0x185CAD010", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct JKDLLEALEDN : PLMPKGFLMFA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture INJOMBFGBPI;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong NBJLMHOEKFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x998C40", Offset = "0x998040", VA = "0x180998C40", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5555240", Offset = "0x5554640", VA = "0x185555240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong DAEAAFKCNDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x11802D0", Offset = "0x117F6D0", VA = "0x1811802D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5CB7E80", Offset = "0x5CB7280", VA = "0x185CB7E80")]
		public JKDLLEALEDN(RenderTexture NKMJMDLAGMO, ulong DHKJDBLHEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5CB7DE0", Offset = "0x5CB71E0", VA = "0x185CB7DE0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong DEBLIAMEPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5CB66D0", Offset = "0x5CB5AD0", VA = "0x185CB66D0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5CB6690", Offset = "0x5CB5A90", VA = "0x185CB6690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong OMDNFFCHLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5CB6610", Offset = "0x5CB5A10", VA = "0x185CB6610")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5CB6650", Offset = "0x5CB5A50", VA = "0x185CB6650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5CB5F40", Offset = "0x5CB5340", VA = "0x185CB5F40")]
	public static ComputeBuffer EECJKDKEFDC(int OGEHFGGOGMJ, int NJHBDKFLLDN, ComputeBufferType IJFAMCPOKBO, [Out] PLMPKGFLMFA DELBIPHKFDD, ComputeBufferMode DGDIMEGBJJP = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5CB6120", Offset = "0x5CB5520", VA = "0x185CB6120")]
	public static RenderTexture EECJKDKEFDC(int JLHCJGALPIM, int DFFLJOMMBKP, int MOLHCHBGJAP, RenderTextureFormat LFCIMIBPFKO, [Out] PLMPKGFLMFA DELBIPHKFDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2393150", Offset = "0x2392550", VA = "0x182393150")]
	public static NativeArray<T> GHGEENPGHHO<T>(NativeArray<T> HAMLMPEDKMB, ulong KIHHOMBMMEI, [Out] PLMPKGFLMFA DELBIPHKFDD) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x23930B0", Offset = "0x23924B0", VA = "0x1823930B0")]
	public static NativeArray<T> EECJKDKEFDC<T>(int KIHHOMBMMEI, Allocator KIKFOGPECEC, [Out] PLMPKGFLMFA DELBIPHKFDD, NativeArrayOptions PHAIIGMLKHM = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5CB64C0", Offset = "0x5CB58C0", VA = "0x185CB64C0")]
	public static void FOEGEAAAFMJ(PLMPKGFLMFA HAMLMPEDKMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CB6710", Offset = "0x5CB5B10", VA = "0x185CB6710")]
	public static uint LPPBOGJBPOJ(RenderTextureFormat LFCIMIBPFKO)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GBFAMGBDNCH : OPHKDCKCHJO<KKCGKCNNKMF, KKCGKCNNKMF>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct OOGCBPPPBPO : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> CCAJIFANEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> GAOGCIOEAFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> NDJIECGIJDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> PLDMDKCDICG;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5B9B9A0", Offset = "0x5B9ADA0", VA = "0x185B9B9A0")]
		public OOGCBPPPBPO(NativeArray<int> JBHHONHAGNI, NativeArray<float> CIALLFHJNAF, NativeArray<float4x4> AEAPJBLCFMO, NativeArray<float4> JMHKGOKHNNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5CBBA90", Offset = "0x5CBAE90", VA = "0x185CBBA90", Slot = "4")]
		public void Execute(int APOENOPNHBG, TransformAccess OLPLDGDFGHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct NMOBMCKELFK : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> CCAJIFANEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> LFNBNPOMMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> NLDGAIAABJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<KKCGKCNNKMF> OLLGNOPDDBL;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5B9B9A0", Offset = "0x5B9ADA0", VA = "0x185B9B9A0")]
		public NMOBMCKELFK(NativeArray<int> JBHHONHAGNI, NativeArray<float4x4> BEPANJNBPIG, NativeArray<float4> IFJIODBPAFL, NativeArray<KKCGKCNNKMF> DCAHFNCPDMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5CBB080", Offset = "0x5CBA480", VA = "0x185CBB080", Slot = "4")]
		public void Execute(int APOENOPNHBG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte KOGEIFCALJE = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray GANKKBEDMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> GHGHKMFDNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> BPJPOGMOLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> NBJKCCNOGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> BMBDCDCNJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> KLKCJCJCGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private PLMPKGFLMFA IOMCHJDFIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private PLMPKGFLMFA COMPPCLHKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private PLMPKGFLMFA GAOIIBPNOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private PLMPKGFLMFA GJFAMCGKFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private PLMPKGFLMFA MNLHBBNCJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform KDOCGFCOLGH;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5CB5820", Offset = "0x5CB4C20", VA = "0x185CB5820")]
	public GBFAMGBDNCH(int IFICPNKPIOB, int BAGBFDHNOPH, ComputeShader CPBEBKPJLCI, int EFEDCMIIANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5CB53D0", Offset = "0x5CB47D0", VA = "0x185CB53D0", Slot = "6")]
	protected override void EIMMMKPLADO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5CB55D0", Offset = "0x5CB49D0", VA = "0x185CB55D0")]
	private void FJNJCKEIGIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5CB51D0", Offset = "0x5CB45D0", VA = "0x185CB51D0")]
	public bool DFEGDJBAKBI(IJJHJEEIBOL DELBIPHKFDD, Transform OLPLDGDFGHL, float EPEFKLHJHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5CB5690", Offset = "0x5CB4A90", VA = "0x185CB5690")]
	public void FKLDABOELII(IJJHJEEIBOL DELBIPHKFDD, float EPEFKLHJHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5CB5770", Offset = "0x5CB4B70", VA = "0x185CB5770")]
	public void IBAIPBHHELD(IJJHJEEIBOL DELBIPHKFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5CB5330", Offset = "0x5CB4730", VA = "0x185CB5330", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FNADCPGHPGD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EMENJBKKDBD GPDBOMJNGBN();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface JPGGKBGCIGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 CJEBEBOFCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int OHBANGANJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int DLKNAEBHFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> AFLOHMGJCHI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> NFCBNHOGKDC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> HDHMKNJKGPO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> GBOOKHFGOBD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> KPCPKPKJKMC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> CEBNIHGFCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int MNIDJNNDKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int BLNPKCACIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int MEIELDOILCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool DAGHKHKPNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CJLBLNKPHHN();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class ADBMIAKFAEP : JPGGKBGCIGF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private FNADCPGHPGD JGICKLPGAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private EMENJBKKDBD PACIGNFPLIB;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 CJEBEBOFCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA9D400", Offset = "0xA9C800", VA = "0x180A9D400", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1A94150", Offset = "0x1A93550", VA = "0x181A94150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool PHBKMAGDNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x75C570", Offset = "0x75B970", VA = "0x18075C570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int OHBANGANJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x79E250", Offset = "0x79D650", VA = "0x18079E250", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x79DE80", Offset = "0x79D280", VA = "0x18079DE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int DLKNAEBHFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x766ED0", Offset = "0x7662D0", VA = "0x180766ED0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x766EB0", Offset = "0x7662B0", VA = "0x180766EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int ABCEKHKKBAC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8891D0", Offset = "0x8885D0", VA = "0x1808891D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> AFLOHMGJCHI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5CABA60", Offset = "0x5CAAE60", VA = "0x185CABA60", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> NFCBNHOGKDC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5CAB840", Offset = "0x5CAAC40", VA = "0x185CAB840", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> HDHMKNJKGPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5CABB30", Offset = "0x5CAAF30", VA = "0x185CABB30", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> GBOOKHFGOBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5CABB60", Offset = "0x5CAAF60", VA = "0x185CABB60", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> KPCPKPKJKMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5CABAD0", Offset = "0x5CAAED0", VA = "0x185CABAD0", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> CEBNIHGFCEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5CAB890", Offset = "0x5CAAC90", VA = "0x185CAB890", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool DAGHKHKPNNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C80", Offset = "0x7B1080", VA = "0x1807B1C80", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B10B0", VA = "0x1807B1CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int MNIDJNNDKMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5CABB20", Offset = "0x5CAAF20", VA = "0x185CABB20", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int BLNPKCACIND
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5CABB00", Offset = "0x5CAAF00", VA = "0x185CABB00", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int MEIELDOILCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5CAB870", Offset = "0x5CAAC70", VA = "0x185CAB870", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5CABBD0", Offset = "0x5CAAFD0", VA = "0x185CABBD0")]
	public ADBMIAKFAEP(Hash128 KKHNLPKBFJI, FNADCPGHPGD JGICKLPGAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB8C0", Offset = "0x5CAACC0", VA = "0x185CAB8C0", Slot = "16")]
	public void CJLBLNKPHHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5CAB9D0", Offset = "0x5CAADD0", VA = "0x185CAB9D0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct IJJHJEEIBOL : IEquatable<IJJHJEEIBOL>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly IJJHJEEIBOL JCNACNONIMC;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int CBNNNKAIBOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAD0", Offset = "0x7DEED0", VA = "0x1807DFAD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7DFAC0", Offset = "0x7DEEC0", VA = "0x1807DFAC0")]
	public IJJHJEEIBOL(int APOENOPNHBG = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5CB7C30", Offset = "0x5CB7030", VA = "0x185CB7C30", Slot = "4")]
	public bool Equals(IJJHJEEIBOL LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5CB7C80", Offset = "0x5CB7080", VA = "0x185CB7C80", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5CB7D50", Offset = "0x5CB7150", VA = "0x185CB7D50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KGAFOEBHBHH : BENEJPEBDBD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool PNLAKCHENAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private JPGGKBGCIGF MBPMLNPAKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<IJJHJEEIBOL> CHLPBEICOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<IJJHJEEIBOL> MBBODOLDEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<IJJHJEEIBOL> OODIGCLHCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> LONJJJNGMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int FKEMHPOHBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int IIACCFFIKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int JPMPLNBBDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int DFGBEHFHGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int OEGJLKDJEPN;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int CBNNNKAIBOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5CB7F60", Offset = "0x5CB7360", VA = "0x185CB7F60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5CB8680", Offset = "0x5CB7A80", VA = "0x185CB8680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool CCLOMNLNDKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7AEE20", Offset = "0x7AE220", VA = "0x1807AEE20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x89C9F0", Offset = "0x89BDF0", VA = "0x18089C9F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool EEMKCEPNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA02580", Offset = "0xA01980", VA = "0x180A02580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA02590", Offset = "0xA01990", VA = "0x180A02590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool IPBJOPBIFAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7785F0", Offset = "0x7779F0", VA = "0x1807785F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool ENMLFMOLLEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x15609F0", Offset = "0x155FDF0", VA = "0x1815609F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1560A50", Offset = "0x155FE50", VA = "0x181560A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float OHPEPFDLMFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1A0BA00", Offset = "0x1A0AE00", VA = "0x181A0BA00")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x203FD90", Offset = "0x203F190", VA = "0x18203FD90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5CB9B90", Offset = "0x5CB8F90", VA = "0x185CB9B90")]
	public KGAFOEBHBHH(JPGGKBGCIGF PACIGNFPLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5CB8A40", Offset = "0x5CB7E40", VA = "0x185CB8A40")]
	private void IJOIGHBPABI(JPGGKBGCIGF PACIGNFPLIB, int FKEMHPOHBOG, int PHKGBABDANH, int APOENOPNHBG, int JLLICDEBGPJ, LOFJDIOLFLB GHFAAPNAFDE, float BOPPLCLGHLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5CB98C0", Offset = "0x5CB8CC0", VA = "0x185CB98C0")]
	private void PKNIKOAJGCI(JPGGKBGCIGF PACIGNFPLIB, int OMIIKOIDEOP, int APOENOPNHBG, uint3 OFGNONJJAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5CB86C0", Offset = "0x5CB7AC0", VA = "0x185CB86C0")]
	private bool CHNHCFFACPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5CB8F20", Offset = "0x5CB8320", VA = "0x185CB8F20", Slot = "4")]
	public bool INMJBKGEACO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5CB89C0", Offset = "0x5CB7DC0", VA = "0x185CB89C0", Slot = "5")]
	public bool GFEAHGHFDLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5CB8010", Offset = "0x5CB7410", VA = "0x185CB8010", Slot = "6")]
	public void BLFHNKIOGCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5CB8960", Offset = "0x5CB7D60", VA = "0x185CB8960")]
	public void KIFPFCBBOFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5CB8960", Offset = "0x5CB7D60", VA = "0x185CB8960", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BENEJPEBDBD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool IPBJOPBIFAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool ENMLFMOLLEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INMJBKGEACO();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GFEAHGHFDLK();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BLFHNKIOGCM();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HHHELOIOLJB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float EHMMDBPKINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, KGAFOEBHBHH> PBDGCIGAPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, CIBIFCCLMKO> CGOMDBKOJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<BENEJPEBDBD> GAJPFHDMLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<BENEJPEBDBD> CNCEPHFBHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<BENEJPEBDBD> IMPJAFKOIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int LKILHJJBLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int LHMNHGMJJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float CFONDKBLJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool DBLPKKGMLFP;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool FDKIDCFGHFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xAE9470", Offset = "0xAE8870", VA = "0x180AE9470")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xB0ADA0", Offset = "0xB0A1A0", VA = "0x180B0ADA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool NFADMJLMMFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5CB72B0", Offset = "0x5CB66B0", VA = "0x185CB72B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string LCENEMEPMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5CB68A0", Offset = "0x5CB5CA0", VA = "0x185CB68A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5CB7920", Offset = "0x5CB6D20", VA = "0x185CB7920")]
	public void PDJDFLEIFDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5CB7860", Offset = "0x5CB6C60", VA = "0x185CB7860")]
	public void MDKBEJGKEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5CB7970", Offset = "0x5CB6D70", VA = "0x185CB7970")]
	public HHHELOIOLJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5CB7730", Offset = "0x5CB6B30", VA = "0x185CB7730")]
	public AGKKNENMDIF KIPDOAILNDA(GIPOLAABKBF LDFPHDMIKMC, bool MHFIFPODFDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5CB75F0", Offset = "0x5CB69F0", VA = "0x185CB75F0")]
	public CIBIFCCLMKO KIPDOAILNDA(MMGCNEEHMCO JGKNCBCEPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5CB7220", Offset = "0x5CB6620", VA = "0x185CB7220")]
	public bool EAGIDCMCGHJ(Hash128 PIKCMFPLBNL, [Out] KGAFOEBHBHH ILDCDMFLHCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5CB7300", Offset = "0x5CB6700", VA = "0x185CB7300")]
	public KGAFOEBHBHH KIPDOAILNDA(JPGGKBGCIGF PACIGNFPLIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5CB7290", Offset = "0x5CB6690", VA = "0x185CB7290")]
	private void JLLDFJDDFHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5CB6810", Offset = "0x5CB5C10", VA = "0x185CB6810")]
	private bool CHCBAIHDIBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5CB6C40", Offset = "0x5CB6040", VA = "0x185CB6C40")]
	public void CJLBLNKPHHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5CB7110", Offset = "0x5CB6510", VA = "0x185CB7110", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5CB7870", Offset = "0x5CB6C70", VA = "0x185CB7870")]
	public void OEPMPEMKAFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LLCGGLPEMMC : OPHKDCKCHJO<NOAFMFMHOFM, NOAFMFMHOFM>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5CBA4A0", Offset = "0x5CB98A0", VA = "0x185CBA4A0")]
	public LLCGGLPEMMC(int IFICPNKPIOB, int BAGBFDHNOPH, ComputeShader CPBEBKPJLCI, int EFEDCMIIANP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KCLMNDKFBLA : OPHKDCKCHJO<CBKBPMOMGCB, CBKBPMOMGCB>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5CB7EB0", Offset = "0x5CB72B0", VA = "0x185CB7EB0")]
	public KCLMNDKFBLA(int IFICPNKPIOB, int BAGBFDHNOPH, ComputeShader CPBEBKPJLCI, int EFEDCMIIANP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NOEEJIHEPHA : OPHKDCKCHJO<AJFGPPJIBHG, AJFGPPJIBHG>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5CBB420", Offset = "0x5CBA820", VA = "0x185CBB420")]
	public NOEEJIHEPHA(int IFICPNKPIOB, int BAGBFDHNOPH, ComputeShader CPBEBKPJLCI, int EFEDCMIIANP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class IALHCLCOANM : OPHKDCKCHJO<IGMCPFLCBAH, ONCLFLEGMJN>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5CB7B80", Offset = "0x5CB6F80", VA = "0x185CB7B80")]
	public IALHCLCOANM(int IFICPNKPIOB, int BAGBFDHNOPH, ComputeShader CPBEBKPJLCI, int EFEDCMIIANP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class PKIJNDBOPEP : OPHKDCKCHJO<LIEFIIJJNFP, LIEFIIJJNFP>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5CBBC50", Offset = "0x5CBB050", VA = "0x185CBBC50")]
	public PKIJNDBOPEP(int IFICPNKPIOB, int BAGBFDHNOPH, ComputeShader CPBEBKPJLCI, int EFEDCMIIANP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class GJEGJDNKHIK : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private DLDFFLBLKNJ KCGGAOMEJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool EGKJFJONNCD;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool HOGNJHABDDH;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5CB5F00", Offset = "0x5CB5300", VA = "0x185CB5F00")]
	public GJEGJDNKHIK(DLDFFLBLKNJ DEGMGGFMONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5CB5D70", Offset = "0x5CB5170", VA = "0x185CB5D70", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer LNCOGBLJJNB, RenderingData MIMMFKGHJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5CB5B00", Offset = "0x5CB4F00", VA = "0x185CB5B00", Slot = "6")]
	public override void Configure(CommandBuffer LNCOGBLJJNB, RenderTextureDescriptor FDEKOBCEGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5CB5B40", Offset = "0x5CB4F40", VA = "0x185CB5B40", Slot = "9")]
	public override void Execute(ScriptableRenderContext FJHKACIMEOO, RenderingData MIMMFKGHJDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class OBOMFBEAJEB
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct KMCIJEPBBML : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string LFAIHEECJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer LNCOGBLJJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext FJHKACIMEOO;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5CB9F50", Offset = "0x5CB9350", VA = "0x185CB9F50")]
		public KMCIJEPBBML(string CBOPGHNAICM, ScriptableRenderContext NJJIEKACDHC, [Out] CommandBuffer MELEALLNLLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5CB9EA0", Offset = "0x5CB92A0", VA = "0x185CB9EA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5CBB8A0", Offset = "0x5CBACA0", VA = "0x185CBB8A0")]
	public static bool OFLDEFHHKIM(RenderingData MIMMFKGHJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5CBB4D0", Offset = "0x5CBA8D0", VA = "0x185CBB4D0")]
	public static void CLHIMGGAKFA(CommandBuffer LNCOGBLJJNB, ScriptableRenderContext FJHKACIMEOO, ShadowDrawingSettings LFFIOALMHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5CBB670", Offset = "0x5CBAA70", VA = "0x185CBB670")]
	public static void MCFECNMONIP(CommandBuffer LNCOGBLJJNB, ScriptableRenderContext FJHKACIMEOO, RenderingData MIMMFKGHJDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DLDFFLBLKNJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class HIOBGEJGMHF
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int BMJLHHABLMP;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int PMBHIMCDAJE;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static JIOIIOAPENJ<DGGECEKFIDL> BJIFPCDNGMO;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static JIOIIOAPENJ<uint> CCDGJGGNECI;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static PLMPKGFLMFA LKKLLDNAMKG;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer CAKNBAHFFIF;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<PBLNMAAGFAG> HIPDEMFLNHF;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int KOEMGEGNCJB;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int OPBAMFDKNBA;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int GLCDIFOHBDM;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int NLJFNHLFAAC;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] LBDGIAOPDMG;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] GIIEHMBNHGJ;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static KIKIAICDCLK[][] FALHDOGGLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] NOAJAHLNHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int HPMGIABHNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int FNEPAIMDKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int EKDPKEBEHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int FGANKIOGEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int OIBALAOHCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int BBPBCHKAAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int LFDFNEFJCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int MDFIDHLMNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int EGAFKNDOOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int OIBMLFPMNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int JPHILMFPFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int LDHPPJPFPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int OKFIMNJPBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int BGENIEFJKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int DHJGKFHANHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int JNPPBDGPAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int FOIHKGJOMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int ECGJOBKFELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] OCFDBPBOCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private HHHELOIOLJB LCJFJLDDDFK;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool LKGDLFIICDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5CB4E80", Offset = "0x5CB4280", VA = "0x185CB4E80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5CB3D70", Offset = "0x5CB3170", VA = "0x185CB3D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool DPECMAGJFLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5CB38E0", Offset = "0x5CB2CE0", VA = "0x185CB38E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5CB3CB0", Offset = "0x5CB30B0", VA = "0x185CB3CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData AABHDJGOCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE280", Offset = "0x5CAD680", VA = "0x185CAE280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5CAFAC0", Offset = "0x5CAEEC0", VA = "0x185CAFAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static GBFAMGBDNCH PGMDGEAJLPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE910", Offset = "0x5CADD10", VA = "0x185CAE910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE7F0", Offset = "0x5CADBF0", VA = "0x185CAE7F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static LLCGGLPEMMC JFNLMLGKBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5CAFC50", Offset = "0x5CAF050", VA = "0x185CAFC50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5CB3B20", Offset = "0x5CB2F20", VA = "0x185CB3B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static KCLMNDKFBLA JFHAJMDABNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5CB42F0", Offset = "0x5CB36F0", VA = "0x185CB42F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5CB39B0", Offset = "0x5CB2DB0", VA = "0x185CB39B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static NOEEJIHEPHA HOHENHGHPJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5CB3C60", Offset = "0x5CB3060", VA = "0x185CB3C60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5CB4C60", Offset = "0x5CB4060", VA = "0x185CB4C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static IALHCLCOANM ACEJFKCLCGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5CB4CD0", Offset = "0x5CB40D0", VA = "0x185CB4CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5CB3A20", Offset = "0x5CB2E20", VA = "0x185CB3A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static PKIJNDBOPEP GICKGFJJHJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5CAFCA0", Offset = "0x5CAF0A0", VA = "0x185CAFCA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE2D0", Offset = "0x5CAD6D0", VA = "0x185CAE2D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material LBIJFKPNCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5CB3C00", Offset = "0x5CB3000", VA = "0x185CB3C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5CB3930", Offset = "0x5CB2D30", VA = "0x185CB3930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material KLLBBAIDIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5CB4E20", Offset = "0x5CB4220", VA = "0x185CB4E20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5CB3AA0", Offset = "0x5CB2EA0", VA = "0x185CB3AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material PIJADDHOFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5CAF2C0", Offset = "0x5CAE6C0", VA = "0x185CAF2C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE200", Offset = "0x5CAD600", VA = "0x185CAE200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material ELPPFMAINNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5CAF260", Offset = "0x5CAE660", VA = "0x185CAF260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5CADFB0", Offset = "0x5CAD3B0", VA = "0x185CADFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool DPGFNIMOEBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5CAE860", Offset = "0x5CADC60", VA = "0x185CAE860")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5CADF50", Offset = "0x5CAD350", VA = "0x185CADF50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool NFADMJLMMFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5CB3D10", Offset = "0x5CB3110", VA = "0x185CB3D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string LCENEMEPMLF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5CAF400", Offset = "0x5CAE800", VA = "0x185CAF400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5CB4F70", Offset = "0x5CB4370", VA = "0x185CB4F70")]
	internal DLDFFLBLKNJ([Optional] MClusterData ICFOEDEBLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5CAFD00", Offset = "0x5CAF100", VA = "0x185CAFD00")]
	public void FGBNJEBGKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5CB4250", Offset = "0x5CB3650", VA = "0x185CB4250")]
	public void LDNKOLBFMEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5CAFB30", Offset = "0x5CAEF30", VA = "0x185CAFB30")]
	public void DJIAPKFOBDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5CB3840", Offset = "0x5CB2C40", VA = "0x185CB3840")]
	public bool GMBPLLJFFPD(Hash128 KKHNLPKBFJI, [Out] KGAFOEBHBHH PACIGNFPLIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5CB4190", Offset = "0x5CB3590", VA = "0x185CB4190")]
	public KGAFOEBHBHH KIPDOAILNDA(JPGGKBGCIGF GHFAAPNAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5CB3DD0", Offset = "0x5CB31D0", VA = "0x185CB3DD0")]
	public CIBIFCCLMKO KIPDOAILNDA(MMGCNEEHMCO JGKNCBCEPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5CB3FD0", Offset = "0x5CB33D0", VA = "0x185CB3FD0")]
	public AGKKNENMDIF KIPDOAILNDA(GIPOLAABKBF LDFPHDMIKMC, bool MHFIFPODFDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE8C0", Offset = "0x5CADCC0", VA = "0x185CAE8C0")]
	public void BLFHNKIOGCM(BENEJPEBDBD KGBLNECAAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5CB4D30", Offset = "0x5CB4130", VA = "0x185CB4D30")]
	public static void NLDOBPINEPB(ADFILICAFNJ ALDHADGKGIB, KIKIAICDCLK[] GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE960", Offset = "0x5CADD60", VA = "0x185CAE960")]
	private void CBMIGMAKHCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5CB10B0", Offset = "0x5CB04B0", VA = "0x185CB10B0")]
	private static void FLHDFIAGIEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5CB4940", Offset = "0x5CB3D40", VA = "0x185CB4940")]
	public void MKBHDLMPILO(CommandBuffer LNCOGBLJJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE030", Offset = "0x5CAD430", VA = "0x185CAE030")]
	public void AINHDIOAMJF([Optional] ScriptableRenderContext? FJHKACIMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5CB3280", Offset = "0x5CB2680", VA = "0x185CB3280")]
	public void GHGPOHPADGD(CommandBuffer LNCOGBLJJNB, ShadowSplitData DFINAKDMHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5CB3560", Offset = "0x5CB2960", VA = "0x185CB3560")]
	public void GHGPOHPADGD(CommandBuffer LNCOGBLJJNB, CameraData CCEEFCJHKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5CB2D20", Offset = "0x5CB2120", VA = "0x185CB2D20")]
	public void FOIAHGLNPMG(CommandBuffer LNCOGBLJJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5CB3B90", Offset = "0x5CB2F90", VA = "0x185CB3B90")]
	public void JDPHCNKOANK(CommandBuffer LNCOGBLJJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE350", Offset = "0x5CAD750", VA = "0x185CAE350")]
	public void BGHJDDBJOFO(CommandBuffer LNCOGBLJJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5CB4340", Offset = "0x5CB3740", VA = "0x185CB4340")]
	public void MAPAABNMLDD(CommandBuffer LNCOGBLJJNB, ADFILICAFNJ MFJGKJMOCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5CAF320", Offset = "0x5CAE720", VA = "0x185CAF320")]
	public void CGGIBHHMBIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5CB1D70", Offset = "0x5CB1170", VA = "0x185CB1D70")]
	public void FOEGEAAAFMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5CAFB40", Offset = "0x5CAEF40", VA = "0x185CAFB40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class LHDIMOJAFNE
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1BEF1A0", Offset = "0x1BEE5A0", VA = "0x181BEF1A0")]
	public static int LIEBEOKJIOJ(int KEFLNPGBJEJ, int JONMEAOGFPH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct KKCGKCNNKMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 PECFFFKKANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 INDECBJFHHH;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly KKCGKCNNKMF PHLAGKLFKOK;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly KKCGKCNNKMF JCNACNONIMC;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5CB9E70", Offset = "0x5CB9270", VA = "0x185CB9E70")]
	public KKCGKCNNKMF(float4x4 ILNJOKEJFPP, float4 IOMKAJFNDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5CB9D00", Offset = "0x5CB9100", VA = "0x185CB9D00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct LOFJDIOLFLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 LPAPEIIOLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 MBCOBAGMLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 IKDCMIMDMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 CDJMLKNPGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 DIEECHCMLLE;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct JMIGMEIBHDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 LPAPEIIOLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 MBCOBAGMLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 IKDCMIMDMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 CDJMLKNPGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 DIEECHCMLLE;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct ONCLFLEGMJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public JMIGMEIBHDL KJPMDDHFKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public JMIGMEIBHDL GBNNFDFODGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public JMIGMEIBHDL HDKFPNELDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public JMIGMEIBHDL BNALGPDIPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public JMIGMEIBHDL FLBCBBJLFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public JMIGMEIBHDL CEGIMFKGKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public JMIGMEIBHDL FEMKOICBMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public JMIGMEIBHDL HBHMJBDMOCE;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct IGMCPFLCBAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public LOFJDIOLFLB KJPMDDHFKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public LOFJDIOLFLB GBNNFDFODGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public LOFJDIOLFLB HDKFPNELDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public LOFJDIOLFLB BNALGPDIPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public LOFJDIOLFLB FLBCBBJLFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public LOFJDIOLFLB CEGIMFKGKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public LOFJDIOLFLB FEMKOICBMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public LOFJDIOLFLB HBHMJBDMOCE;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct CBKBPMOMGCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 HBIHFLPBJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint DBELPICKLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint PIEALCBDGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float EGEHCFDEJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint BLKMGDOEMLH;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD0D0", Offset = "0x5CAC4D0", VA = "0x185CAD0D0")]
	public CBKBPMOMGCB(MMGCNEEHMCO JGKNCBCEPPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct DGGECEKFIDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint CDHEGIEAAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint FIHDKEFDMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint JLLICDEBGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint BLKMGDOEMLH;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5CADEA0", Offset = "0x5CAD2A0", VA = "0x185CADEA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct AJFGPPJIBHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint PHKGBABDANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint BJJMPBALBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint IIACCFFIKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint BLKMGDOEMLH;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5CACF60", Offset = "0x5CAC360", VA = "0x185CACF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct NOAFMFMHOFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint IMFJMHOMBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint CFNLIKDELHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint AKKAPPFAEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint JHDNIBNFAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint HCDPEGEDDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint CFDIDFNFNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint ODDDOIACHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint BLKMGDOEMLH;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5CBB0F0", Offset = "0x5CBA4F0", VA = "0x185CBB0F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct LIEFIIJJNFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 HNGJOBNLNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 NJCCNCNMLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 MOLPGFIGCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 APFDMNFIMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 BNFIEHOGAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 ECGAOHMALBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 GHCFEDKJDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 JIEKEOBACJM;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5CBA060", Offset = "0x5CB9460", VA = "0x185CBA060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum ADFILICAFNJ
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
