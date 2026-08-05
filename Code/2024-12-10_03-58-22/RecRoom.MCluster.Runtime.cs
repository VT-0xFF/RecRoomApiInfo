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
public struct DLGAKHDANIN
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] HIGNLBAEMGA;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] GIBHKPDIJCH;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] LIFADLPKKNO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1552660", Offset = "0x1551260", VA = "0x181552660")]
	public static int NACIBFIBGAF(NIKFMFDBOID HLHOBJEODLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E080", Offset = "0x6C9CC80", VA = "0x186C9E080")]
	public static int OAOFJEAOIAM(NIKFMFDBOID HLHOBJEODLD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KKMJGFAKLIB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int OMEPACLHMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KPNMDEFAGFM LHACGACFLLA(int LAIJAICKIEF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 PHDPCLMFFMK(int LAIJAICKIEF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FJFKEFAPLLG NFNAAPAAGBN();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BOCMGAIAAHF LFMFOPDLHJE();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BBDKMOFBNNB : GCANMKAGBNG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private FJFKEFAPLLG OHCKGBMFMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform IADHHBHHJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<LDBOFOJPIGN> BPPEMNPENEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private EBHPDFIEKAI JIOIMIMENFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private DBMIFKGHODE JDGOPNIFABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool NIDFKKFNGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private KKMJGFAKLIB OEJCFGOJCDJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float DPCAGOIBPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x91A520", Offset = "0x919120", VA = "0x18091A520")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB9DCD0", Offset = "0xB9C8D0", VA = "0x180B9DCD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NIMAJAGEJJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x908600", Offset = "0x907200", VA = "0x180908600")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x908610", Offset = "0x907210", VA = "0x180908610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool MEAKAHKKGGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB87A00", Offset = "0xB86600", VA = "0x180B87A00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xBE7E40", Offset = "0xBE6A40", VA = "0x180BE7E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BNAOOFMMBLM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1568990", Offset = "0x1567590", VA = "0x181568990", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1568740", Offset = "0x1567340", VA = "0x181568740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MCAOFJPLDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x164C5F0", Offset = "0x164B1F0", VA = "0x18164C5F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C9D110", Offset = "0x6C9BD10", VA = "0x186C9D110")]
	public BBDKMOFBNNB(KKMJGFAKLIB ODPJPJLEOIN, bool PBACBMGKBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C9CEF0", Offset = "0x6C9BAF0", VA = "0x186C9CEF0")]
	private bool NNBDIADOCGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C9C0F0", Offset = "0x6C9ACF0", VA = "0x186C9C0F0", Slot = "4")]
	public bool CMCAIIEBGOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C9CD20", Offset = "0x6C9B920", VA = "0x186C9CD20", Slot = "5")]
	public bool HMDNBLCBPCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C9BED0", Offset = "0x6C9AAD0", VA = "0x186C9BED0", Slot = "6")]
	public void CEFMELNJEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C9CD10", Offset = "0x6C9B910", VA = "0x186C9CD10", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PCLIKHPFENP
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HILFJFLIKGD(CommandBuffer EKFBBEMKDNF);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct DJLCCGFLIOC : PCLIKHPFENP
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int HJABBJLNKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier NBELKKBEGID
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4354E70", Offset = "0x4353A70", VA = "0x184354E70")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E060", Offset = "0x6C9CC60", VA = "0x186C9E060")]
	public DJLCCGFLIOC(int MJDOIIBKEKN, RenderTargetIdentifier BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E010", Offset = "0x6C9CC10", VA = "0x186C9E010", Slot = "4")]
	public void HILFJFLIKGD(CommandBuffer EKFBBEMKDNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct AEJMNJAGFFO : PCLIKHPFENP
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int HJABBJLNKKC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] FPGJHNLECOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA644E0", Offset = "0xA630E0", VA = "0x180A644E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xF963E0", Offset = "0xF94FE0", VA = "0x180F963E0")]
	public AEJMNJAGFFO(int MJDOIIBKEKN, Vector4[] BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C9BEA0", Offset = "0x6C9AAA0", VA = "0x186C9BEA0", Slot = "4")]
	public void HILFJFLIKGD(CommandBuffer EKFBBEMKDNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct KHDKIFMHCNC : PCLIKHPFENP
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int HJABBJLNKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] IKDMOCEGMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA644E0", Offset = "0xA630E0", VA = "0x180A644E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xF963E0", Offset = "0xF94FE0", VA = "0x180F963E0")]
	public KHDKIFMHCNC(int MJDOIIBKEKN, float[] BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1CB0", Offset = "0x6CA08B0", VA = "0x186CA1CB0", Slot = "4")]
	public void HILFJFLIKGD(CommandBuffer EKFBBEMKDNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HMLOMDOEAOP : PCLIKHPFENP
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string IHBMAHBKJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool ONEKHMHADID
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1EA1600", Offset = "0x1EA0200", VA = "0x181EA1600")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x10BF1C0", Offset = "0x10BDDC0", VA = "0x1810BF1C0")]
	public HMLOMDOEAOP(string GMBAACDNNFI, bool DHKFDKHEAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0380", Offset = "0x6C9EF80", VA = "0x186CA0380", Slot = "4")]
	public void HILFJFLIKGD(CommandBuffer EKFBBEMKDNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct BOCMGAIAAHF
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 NHDJOKBOJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 IKEAGOFKFBB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9624D0", Offset = "0x9610D0", VA = "0x1809624D0")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int HIHIMMCGAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FA0", Offset = "0x8E8BA0", VA = "0x1808E9FA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int EEDDJKDPKCO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DC0", Offset = "0x8C79C0", VA = "0x1808C8DC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float IKCABHHJFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x91A540", Offset = "0x919140", VA = "0x18091A540")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6C9DB40", Offset = "0x6C9C740", VA = "0x186C9DB40")]
	public BOCMGAIAAHF(Color NKKLIFIFGAP, int FGLHPIPFODM, int FPOAMEDFGKO, float BBCJMFLPHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xAFDDF0", Offset = "0xAFC9F0", VA = "0x180AFDDF0")]
	private static float4 GHHLMINLPJN(Color NKKLIFIFGAP)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C9DAB0", Offset = "0x6C9C6B0", VA = "0x186C9DAB0")]
	private static Hash128 HAEDKEFFAED(BOCMGAIAAHF ODPJPJLEOIN)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class EBHPDFIEKAI : GCANMKAGBNG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string LEEEKMJLMGD;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string AEIAPPEIHMM;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string EHJPONDGPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private BOCMGAIAAHF KKPHAJLLAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private BIPJANHJGHN OFCNJEFMNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 PMBJKBDENMJ;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public DBMIFKGHODE BPNAFGPBBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB10", Offset = "0x8AE710", VA = "0x1808AFB10")]
		[CompilerGenerated]
		get
		{
			return default(DBMIFKGHODE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xC7C640", Offset = "0xC7B240", VA = "0x180C7C640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool NIMAJAGEJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5C3C2E0", Offset = "0x5C3AEE0", VA = "0x185C3C2E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5C3C2F0", Offset = "0x5C3AEF0", VA = "0x185C3C2F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool MEAKAHKKGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x20D2940", Offset = "0x20D1540", VA = "0x1820D2940")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6C18240", Offset = "0x6C16E40", VA = "0x186C18240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MCAOFJPLDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool BNAOOFMMBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5CF21E0", Offset = "0x5CF0DE0", VA = "0x185CF21E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6C9ECC0", Offset = "0x6C9D8C0", VA = "0x186C9ECC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int NAJFJJKNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E9C0", Offset = "0x6C9D5C0", VA = "0x186C9E9C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C9EDB0", Offset = "0x6C9D9B0", VA = "0x186C9EDB0")]
	public EBHPDFIEKAI(BOCMGAIAAHF KLFPHNCMLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C9EBC0", Offset = "0x6C9D7C0", VA = "0x186C9EBC0")]
	private bool NNBDIADOCGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E870", Offset = "0x6C9D470", VA = "0x186C9E870", Slot = "4")]
	public bool CMCAIIEBGOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E830", Offset = "0x6C9D430", VA = "0x186C9E830")]
	private static BIPJANHJGHN CHEMGPOKFFG(BOCMGAIAAHF ODPJPJLEOIN)
	{
		return default(BIPJANHJGHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6C9EA10", Offset = "0x6C9D610", VA = "0x186C9EA10", Slot = "5")]
	public bool HMDNBLCBPCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E730", Offset = "0x6C9D330", VA = "0x186C9E730", Slot = "6")]
	public void CEFMELNJEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6CA3AA0", Offset = "0x6CA26A0", VA = "0x186CA3AA0", Slot = "0")]
		public override bool Equals(object FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6CA3CA0", Offset = "0x6CA28A0", VA = "0x186CA3CA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8F3410", Offset = "0x8F2010", VA = "0x1808F3410")]
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
		private POAODBLAEBD opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static NAAMHAAMILN CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6CA4360", Offset = "0x6CA2F60", VA = "0x186CA4360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6CA43A0", Offset = "0x6CA2FA0", VA = "0x186CA43A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6CA3D80", Offset = "0x6CA2980", VA = "0x186CA3D80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6CA3D50", Offset = "0x6CA2950", VA = "0x186CA3D50", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HKFOEGKIJPH, RenderingData LMNAFHEGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6CA41D0", Offset = "0x6CA2DD0", VA = "0x186CA41D0")]
		public void EAJCEBIHJBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xF71DD0", Offset = "0xF709D0", VA = "0x180F71DD0")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KJEKFHEDBLF<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private DBBLHICKCAH KELKAKDMGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private DBBLHICKCAH PALIAPHCKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer MMMPPIOAMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture FHNDIFBNGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int JNFJNKAAMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int CHMLNJIKJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string DANLLOOENLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string BMCEFEABCAE;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x893E00", Offset = "0x892A00", VA = "0x180893E00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int PIAKAPEMEIH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xCD79B0", Offset = "0xCD65B0", VA = "0x180CD79B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int CODIFLHFKMF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8A6460", Offset = "0x8A5060", VA = "0x1808A6460")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x42C3FD0", Offset = "0x42C2BD0", VA = "0x1842C3FD0")]
	public KJEKFHEDBLF(string GMBAACDNNFI, int EACGBIMLGFM, [Optional] RenderTextureFormat? DNBEJMJLODH, bool FBPCAOIKFDC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x42C24A0", Offset = "0x42C10A0", VA = "0x1842C24A0")]
	public void HMDNBLCBPCK(CommandBuffer EKFBBEMKDNF, NativeArray<ValType> BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x42C2C30", Offset = "0x42C1830", VA = "0x1842C2C30")]
	public void JKOLLEIMKIN(CommandBuffer EKFBBEMKDNF, ComputeShader KIIHKCMENJA, int CABAGMODFBI, int FJEOBKJLADM = -1, int AGGDFJEGPFA = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x42C37A0", Offset = "0x42C23A0", VA = "0x1842C37A0")]
	public void JKOLLEIMKIN(Material OFCNJEFMNEM, int FJEOBKJLADM = -1, int AGGDFJEGPFA = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x42C1E50", Offset = "0x42C0A50", VA = "0x1842C1E50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FNDJBMINDIA
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JKOLLEIMKIN(Material KLFPHNCMLPC);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FCNNEFCGMJM<SrcEntry, DstEntry> : FNDJBMINDIA, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] DDJDFLMGEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected DBBLHICKCAH CFAMGOPHGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected DBBLHICKCAH PDGIOBNNJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> NAKGEKIDPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> PKJEOHHHGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int OBOKOGGCLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int OKJIJBPOBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected KJEKFHEDBLF<int> EKKNPKJCDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected KJEKFHEDBLF<SrcEntry> KLHDLJLDLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected KJEKFHEDBLF<DstEntry> PDBHJCKIDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader CAFJGAIFHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int EMGBBFAIKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int BGLFIPNGLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int AGDHLCCAEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int BKOOHKOIGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int GPHAPJEAAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int DAFJOLNLCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int IKKPPCLKJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int NENFIGAFEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int HKEHLJLCKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int EMHADNPKKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int FOMHANAGLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int KMNLHNKAFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string BOPIPPILKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] BIHLLOOPCNE;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int HAKLGKNKAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3DEAD50", Offset = "0x3DE9950", VA = "0x183DEAD50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string EODMNHHJLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB770", Offset = "0x3DEA370", VA = "0x183DEB770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3DEBA40", Offset = "0x3DEA640", VA = "0x183DEBA40")]
	public FCNNEFCGMJM(string GMBAACDNNFI, int HENBLCHJNJP, int FLJAKIALHAA, RenderTextureFormat DNBEJMJLODH, ComputeShader HPCKNECEADI, int NCCOKCHANKL = 0, int MCICAPGIMIG = 0, int HFACLCNOHKF = 0, int JIAIMHGHEEG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3DEA710", Offset = "0x3DE9310", VA = "0x183DEA710")]
	public int GDHJMJDPCFG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3DEAAF0", Offset = "0x3DE96F0", VA = "0x183DEAAF0")]
	protected void IAEDEPANBAG(int MFJLAMOCOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3DEA1E0", Offset = "0x3DE8DE0", VA = "0x183DEA1E0")]
	public DBMIFKGHODE CMCAIIEBGOH(SrcEntry BFLLAIFBMAJ)
	{
		return default(DBMIFKGHODE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3DEA780", Offset = "0x3DE9380", VA = "0x183DEA780")]
	public bool HMDNBLCBPCK(DBMIFKGHODE JBFBMCPGKHE, SrcEntry BFLLAIFBMAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3DEA160", Offset = "0x3DE8D60", VA = "0x183DEA160")]
	public bool CEFMELNJEMA(DBMIFKGHODE JBFBMCPGKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "6")]
	protected virtual void HCADMIKBMHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB0D0", Offset = "0x3DE9CD0", VA = "0x183DEB0D0", Slot = "7")]
	public void LPGBFBFLGDO(CommandBuffer EKFBBEMKDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB130", Offset = "0x3DE9D30", VA = "0x183DEB130", Slot = "8")]
	public void LPGBFBFLGDO(CommandBuffer EKFBBEMKDNF, ComputeShader HPCKNECEADI, int NCCOKCHANKL = -1, int MCICAPGIMIG = -1, int HFACLCNOHKF = -1, int JIAIMHGHEEG = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3DEABB0", Offset = "0x3DE97B0", VA = "0x183DEABB0", Slot = "9")]
	public void JKOLLEIMKIN(CommandBuffer EKFBBEMKDNF, ComputeShader HPCKNECEADI, int NCCOKCHANKL = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3DEAB40", Offset = "0x3DE9740", VA = "0x183DEAB40", Slot = "4")]
	public void JKOLLEIMKIN(Material OFCNJEFMNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3DEA510", Offset = "0x3DE9110", VA = "0x183DEA510", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DBBLHICKCAH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong JEGOGMNDAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong FIEHEAKCCGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class BKFGFLEOAPF
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct DIDEDGOPHII : DBBLHICKCAH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable NDBPGFIPMNE;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong JEGOGMNDAPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA644E0", Offset = "0xA630E0", VA = "0x180A644E0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xB227E0", Offset = "0xB213E0", VA = "0x180B227E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong FIEHEAKCCGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xB71B80", Offset = "0xB70780", VA = "0x180B71B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DFD0", Offset = "0x6C9CBD0", VA = "0x186C9DFD0")]
		internal DIDEDGOPHII(IDisposable PIKEGPCCOBJ, ulong DLICIEDFFPB, ulong MEOHHELJFOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DF50", Offset = "0x6C9CB50", VA = "0x186C9DF50", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct PHNKOPHBHLN : DBBLHICKCAH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture KFBFLGILNDH;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong JEGOGMNDAPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA644E0", Offset = "0xA630E0", VA = "0x180A644E0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xB227E0", Offset = "0xB213E0", VA = "0x180B227E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong FIEHEAKCCGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xB71B80", Offset = "0xB70780", VA = "0x180B71B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6CABB10", Offset = "0x6CAA710", VA = "0x186CABB10")]
		public PHNKOPHBHLN(RenderTexture NKCDINKPPDP, ulong FPJPKAIJMKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6CABA70", Offset = "0x6CAA670", VA = "0x186CABA70", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong NNINJIMFHFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D8B0", Offset = "0x6C9C4B0", VA = "0x186C9D8B0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D8F0", Offset = "0x6C9C4F0", VA = "0x186C9D8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong BCGMADJBOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DA70", Offset = "0x6C9C670", VA = "0x186C9DA70")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D870", Offset = "0x6C9C470", VA = "0x186C9D870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C9D310", Offset = "0x6C9BF10", VA = "0x186C9D310")]
	public static ComputeBuffer ELGDCMPCLII(int KNHHBEFLJAF, int LAMKIHNFKFL, ComputeBufferType FIFJJNIIAPF, [Out] DBBLHICKCAH JBFBMCPGKHE, ComputeBufferMode DCNHCLKJAMO = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6C9D4E0", Offset = "0x6C9C0E0", VA = "0x186C9D4E0")]
	public static RenderTexture ELGDCMPCLII(int DEKKEALBCEP, int MBNEPKJJCNM, int DOMLIDIMPPO, RenderTextureFormat DNBEJMJLODH, [Out] DBBLHICKCAH JBFBMCPGKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2B91570", Offset = "0x2B90170", VA = "0x182B91570")]
	public static NativeArray<T> ENINAOMNHCC<T>(NativeArray<T> NDBPGFIPMNE, ulong OLBMNABBGHI, [Out] DBBLHICKCAH JBFBMCPGKHE) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2B914B0", Offset = "0x2B900B0", VA = "0x182B914B0")]
	public static NativeArray<T> ELGDCMPCLII<T>(int OLBMNABBGHI, Allocator ICLGONBNBJO, [Out] DBBLHICKCAH JBFBMCPGKHE, NativeArrayOptions OGIKBJOPPCP = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6C9D930", Offset = "0x6C9C530", VA = "0x186C9D930")]
	public static void PAMNEBLPMKL(DBBLHICKCAH NDBPGFIPMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6C9D200", Offset = "0x6C9BE00", VA = "0x186C9D200")]
	public static uint EJDOFDLKPBF(RenderTextureFormat DNBEJMJLODH)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HBMGJGMFCBP : FCNNEFCGMJM<JGFCKDAKMAD, JGFCKDAKMAD>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct GNIPPJLLGEK : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> FIHFCFHGLBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> HLGJOICLHLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> CLKKKPIBLFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> IDIIJBDPMAO;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6C9FA10", Offset = "0x6C9E610", VA = "0x186C9FA10")]
		public GNIPPJLLGEK(NativeArray<int> MGLKNEFFHCK, NativeArray<float> HLBODPANLAI, NativeArray<float4x4> EPJAHKHPOJF, NativeArray<float4> PJCIJONPKAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6C9F850", Offset = "0x6C9E450", VA = "0x186C9F850", Slot = "4")]
		public void Execute(int MFJLAMOCOBC, TransformAccess OHCKGBMFMEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct NLIPOOCLGFN : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> FIHFCFHGLBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> KKOJIOJBFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> JEBFJAMOCMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<JGFCKDAKMAD> HBOOCCGOLKN;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6C9FA10", Offset = "0x6C9E610", VA = "0x186C9FA10")]
		public NLIPOOCLGFN(NativeArray<int> MGLKNEFFHCK, NativeArray<float4x4> GPOADEAOBDK, NativeArray<float4> ADILNGENOJA, NativeArray<JGFCKDAKMAD> LMJFOHKAJHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB8A0", Offset = "0x6CAA4A0", VA = "0x186CAB8A0", Slot = "4")]
		public void Execute(int MFJLAMOCOBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte FGFKCKOLADM = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray GLPICMEHEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> NJBPMDHEFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> OIBNLLPKAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> PCGBNKFEDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> HGIDHGEPLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> MFKHLNDFAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private DBBLHICKCAH BAHLPEOANIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private DBBLHICKCAH GGANCAHPCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private DBBLHICKCAH FEGAHLNPDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private DBBLHICKCAH HNKNJNHDOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private DBBLHICKCAH LOJMCKNMPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform HMCGCDOPDNF;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA00A0", Offset = "0x6C9ECA0", VA = "0x186CA00A0")]
	public HBMGJGMFCBP(int HENBLCHJNJP, int FLJAKIALHAA, ComputeShader HPCKNECEADI, int NCCOKCHANKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6C9FC70", Offset = "0x6C9E870", VA = "0x186C9FC70", Slot = "6")]
	protected override void HCADMIKBMHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6C9FE80", Offset = "0x6C9EA80", VA = "0x186C9FE80")]
	private void IKDHKFOBJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6C9FF40", Offset = "0x6C9EB40", VA = "0x186C9FF40")]
	public bool JGAKEDJGOPK(DBMIFKGHODE JBFBMCPGKHE, Transform OHCKGBMFMEE, float GNLJBCNNDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6C9FAF0", Offset = "0x6C9E6F0", VA = "0x186C9FAF0")]
	public void DHHELAHENPM(DBMIFKGHODE JBFBMCPGKHE, float GNLJBCNNDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6C9FA40", Offset = "0x6C9E640", VA = "0x186C9FA40")]
	public void BAMOMOPJLDP(DBMIFKGHODE JBFBMCPGKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C9FBD0", Offset = "0x6C9E7D0", VA = "0x186C9FBD0", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface KPNMDEFAGFM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GKPKFCDGCEK LIIAHFFMFKK();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface NDMAKNLBGAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 NHDJOKBOJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int ACCPFFNJLOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int NCHNHNDHOON
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> FIKECJKJAAD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> IHGGCBNMEKB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> ELBFFNCHLOP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> FBMJDLPDKEL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> DGEJIBKLMID
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> FELCFFAPMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int MEEEHFDFMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int LFLLHKJINAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int GPKPMECAIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool IKHLKPGKLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LPGBFBFLGDO();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FAEJNCAKLHO : NDMAKNLBGAM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private KPNMDEFAGFM DOHAMDJFBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private GKPKFCDGCEK OOKDOLDBLMJ;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 NHDJOKBOJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9624D0", Offset = "0x9610D0", VA = "0x1809624D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9622C0", Offset = "0x960EC0", VA = "0x1809622C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool IOKEENPFJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x88C5E0", Offset = "0x88B1E0", VA = "0x18088C5E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int ACCPFFNJLOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DC0", Offset = "0x8C79C0", VA = "0x1808C8DC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8C8970", Offset = "0x8C7570", VA = "0x1808C8970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int NCHNHNDHOON
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x887AC0", Offset = "0x8866C0", VA = "0x180887AC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x887B00", Offset = "0x886700", VA = "0x180887B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int IPICNHJBHKP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xD1B3C0", Offset = "0xD19FC0", VA = "0x180D1B3C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> FIKECJKJAAD
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6C9EF50", Offset = "0x6C9DB50", VA = "0x186C9EF50", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> IHGGCBNMEKB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6C9F090", Offset = "0x6C9DC90", VA = "0x186C9F090", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> ELBFFNCHLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6C9F0F0", Offset = "0x6C9DCF0", VA = "0x186C9F0F0", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> FBMJDLPDKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6C9F250", Offset = "0x6C9DE50", VA = "0x186C9F250", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> DGEJIBKLMID
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6C9F050", Offset = "0x6C9DC50", VA = "0x186C9F050", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> FELCFFAPMBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6C9F0C0", Offset = "0x6C9DCC0", VA = "0x186C9F0C0", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool IKHLKPGKLNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8B6010", Offset = "0x8B4C10", VA = "0x1808B6010", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8B5D90", Offset = "0x8B4990", VA = "0x1808B5D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int MEEEHFDFMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6C9F080", Offset = "0x6C9DC80", VA = "0x186C9F080", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int LFLLHKJINAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6C9F120", Offset = "0x6C9DD20", VA = "0x186C9F120", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int GPKPMECAIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6C9F2C0", Offset = "0x6C9DEC0", VA = "0x186C9F2C0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F2E0", Offset = "0x6C9DEE0", VA = "0x186C9F2E0")]
	public FAEJNCAKLHO(Hash128 IGABCIKOEOA, KPNMDEFAGFM DOHAMDJFBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F140", Offset = "0x6C9DD40", VA = "0x186C9F140", Slot = "16")]
	public void LPGBFBFLGDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6C9EFC0", Offset = "0x6C9DBC0", VA = "0x186C9EFC0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct DBMIFKGHODE : IEquatable<DBMIFKGHODE>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly DBMIFKGHODE LPNKNEBEAHM;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int NAJFJJKNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xB227D0", Offset = "0xB213D0", VA = "0x180B227D0")]
	public DBMIFKGHODE(int MFJLAMOCOBC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6C9DDA0", Offset = "0x6C9C9A0", VA = "0x186C9DDA0", Slot = "4")]
	public bool Equals(DBMIFKGHODE FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6C9DDF0", Offset = "0x6C9C9F0", VA = "0x186C9DDF0", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6C9DEC0", Offset = "0x6C9CAC0", VA = "0x186C9DEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LDBOFOJPIGN : GCANMKAGBNG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool NIDFKKFNGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NDMAKNLBGAM GODFJLKHLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<DBMIFKGHODE> OFEJAKLNIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<DBMIFKGHODE> LJIGBBIIOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<DBMIFKGHODE> EDJMMGCKPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> HKDLPCIAOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int JCNHMGBINFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int CCHNADPHIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int FFOGLIOKLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int DGKDAMKGFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int AKCGENNBPBB;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int NAJFJJKNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6CA3290", Offset = "0x6CA1E90", VA = "0x186CA3290")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6CA2330", Offset = "0x6CA0F30", VA = "0x186CA2330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool NIMAJAGEJJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x935C80", Offset = "0x934880", VA = "0x180935C80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xBA1690", Offset = "0xBA0290", VA = "0x180BA1690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool MEAKAHKKGGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xD4B480", Offset = "0xD4A080", VA = "0x180D4B480")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xD4B470", Offset = "0xD4A070", VA = "0x180D4B470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool MCAOFJPLDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool BNAOOFMMBLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4CB0210", Offset = "0x4CAEE10", VA = "0x184CB0210", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1C4EBF0", Offset = "0x1C4D7F0", VA = "0x181C4EBF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float DPCAGOIBPPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8F45D0", Offset = "0x8F31D0", VA = "0x1808F45D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8F45C0", Offset = "0x8F31C0", VA = "0x1808F45C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3930", Offset = "0x6CA2530", VA = "0x186CA3930")]
	public LDBOFOJPIGN(NDMAKNLBGAM OOKDOLDBLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2DB0", Offset = "0x6CA19B0", VA = "0x186CA2DB0")]
	private void FAFFJHDIGOK(NDMAKNLBGAM OOKDOLDBLMJ, int JCNHMGBINFM, int OEOPHGCAFPN, int MFJLAMOCOBC, int HGAABFOLPEJ, OBODAEPKLJB BFLLAIFBMAJ, float GEBKCBFEBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6CA33C0", Offset = "0x6CA1FC0", VA = "0x186CA33C0")]
	private void KPOGLOJJPFK(NDMAKNLBGAM OOKDOLDBLMJ, int IMAEMBMGPLC, int MFJLAMOCOBC, uint3 ILNBMFNICBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3690", Offset = "0x6CA2290", VA = "0x186CA3690")]
	private bool NNBDIADOCGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2370", Offset = "0x6CA0F70", VA = "0x186CA2370", Slot = "4")]
	public bool CMCAIIEBGOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3340", Offset = "0x6CA1F40", VA = "0x186CA3340", Slot = "5")]
	public bool HMDNBLCBPCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1CE0", Offset = "0x6CA08E0", VA = "0x186CA1CE0", Slot = "6")]
	public void CEFMELNJEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2D50", Offset = "0x6CA1950", VA = "0x186CA2D50")]
	public void HPCJNCALNPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2D50", Offset = "0x6CA1950", VA = "0x186CA2D50", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GCANMKAGBNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool MCAOFJPLDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool BNAOOFMMBLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CMCAIIEBGOH();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HMDNBLCBPCK();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CEFMELNJEMA();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IJBOBBAIOEA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float BGCPHJIGMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, LDBOFOJPIGN> FFFHMNMMHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, EBHPDFIEKAI> IAPHLLONIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<GCANMKAGBNG> DOBNPBEOLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<GCANMKAGBNG> HEDEJDMDONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<GCANMKAGBNG> NELKODGOAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int FCBBJBCNHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int HBBEDNMPGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float CEJCJLGKDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool OMKCDJPOCGB;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool AHPGANJOFND
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xF9AC70", Offset = "0xF99870", VA = "0x180F9AC70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xFB7720", Offset = "0xFB6320", VA = "0x180FB7720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool DJHNJAJGBHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0C10", Offset = "0x6C9F810", VA = "0x186CA0C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string EODMNHHJLEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0C60", Offset = "0x6C9F860", VA = "0x186CA0C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0560", Offset = "0x6C9F160", VA = "0x186CA0560")]
	public void BPONCAJNNPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0730", Offset = "0x6C9F330", VA = "0x186CA0730")]
	public void LBGMMJPKNOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6CA15C0", Offset = "0x6CA01C0", VA = "0x186CA15C0")]
	public IJBOBBAIOEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1000", Offset = "0x6C9FC00", VA = "0x186CA1000")]
	public BBDKMOFBNNB PEGPHNFMEDB(KKMJGFAKLIB CMIAKAKADAG, bool PBACBMGKBGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1130", Offset = "0x6C9FD30", VA = "0x186CA1130")]
	public EBHPDFIEKAI PEGPHNFMEDB(BOCMGAIAAHF OFCNJEFMNEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0470", Offset = "0x6C9F070", VA = "0x186CA0470")]
	public bool ABPJGKOLPME(Hash128 MJDOIIBKEKN, [Out] LDBOFOJPIGN IAOAJGHFENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1270", Offset = "0x6C9FE70", VA = "0x186CA1270")]
	public LDBOFOJPIGN PEGPHNFMEDB(NDMAKNLBGAM OOKDOLDBLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1560", Offset = "0x6CA0160", VA = "0x186CA1560")]
	private void PNOEOJEEGFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6CA04E0", Offset = "0x6C9F0E0", VA = "0x186CA04E0")]
	private bool BIOLNFPFKCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0740", Offset = "0x6C9F340", VA = "0x186CA0740")]
	public void LPGBFBFLGDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0570", Offset = "0x6C9F170", VA = "0x186CA0570", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0680", Offset = "0x6C9F280", VA = "0x186CA0680")]
	public void FCCPBBAAIAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EEAKOBDJFHB : FCNNEFCGMJM<MLMMPMIFMPH, MLMMPMIFMPH>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6C9EDF0", Offset = "0x6C9D9F0", VA = "0x186C9EDF0")]
	public EEAKOBDJFHB(int HENBLCHJNJP, int FLJAKIALHAA, ComputeShader HPCKNECEADI, int NCCOKCHANKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OKKBIMGLLLI : FCNNEFCGMJM<BIPJANHJGHN, BIPJANHJGHN>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB910", Offset = "0x6CAA510", VA = "0x186CAB910")]
	public OKKBIMGLLLI(int HENBLCHJNJP, int FLJAKIALHAA, ComputeShader HPCKNECEADI, int NCCOKCHANKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class MDMONGBKNIN : FCNNEFCGMJM<EHOPGPMJBEN, EHOPGPMJBEN>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6CA43F0", Offset = "0x6CA2FF0", VA = "0x186CA43F0")]
	public MDMONGBKNIN(int HENBLCHJNJP, int FLJAKIALHAA, ComputeShader HPCKNECEADI, int NCCOKCHANKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class COLAMOIDMKC : FCNNEFCGMJM<NPHIDIBELME, LIIKNCFJJBJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6C9DCF0", Offset = "0x6C9C8F0", VA = "0x186C9DCF0")]
	public COLAMOIDMKC(int HENBLCHJNJP, int FLJAKIALHAA, ComputeShader HPCKNECEADI, int NCCOKCHANKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class HPCFBPELPIB : FCNNEFCGMJM<JMMALOEEKEM, JMMALOEEKEM>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6CA03C0", Offset = "0x6C9EFC0", VA = "0x186CA03C0")]
	public HPCFBPELPIB(int HENBLCHJNJP, int FLJAKIALHAA, ComputeShader HPCKNECEADI, int NCCOKCHANKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class POAODBLAEBD : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private NAAMHAAMILN DGODMPCJMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool DHKFDKHEAMG;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool DHOBAJOGOPB;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6CABF40", Offset = "0x6CAAB40", VA = "0x186CABF40")]
	public POAODBLAEBD(NAAMHAAMILN DAIOIIMGHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6CABDB0", Offset = "0x6CAA9B0", VA = "0x186CABDB0", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer EKFBBEMKDNF, RenderingData LMNAFHEGHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6CABB40", Offset = "0x6CAA740", VA = "0x186CABB40", Slot = "6")]
	public override void Configure(CommandBuffer EKFBBEMKDNF, RenderTextureDescriptor ANDGIMNIHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6CABB80", Offset = "0x6CAA780", VA = "0x186CABB80", Slot = "9")]
	public override void Execute(ScriptableRenderContext PDMONEGPHPK, RenderingData LMNAFHEGHMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class GKHFHLLGEJF
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct NBGNPEGMFBE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string GMBAACDNNFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer EKFBBEMKDNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext PDMONEGPHPK;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB790", Offset = "0x6CAA390", VA = "0x186CAB790")]
		public NBGNPEGMFBE(string AOBFEPCNIFB, ScriptableRenderContext DJLJMAFPEEJ, [Out] CommandBuffer AALAJLOJOLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB6E0", Offset = "0x6CAA2E0", VA = "0x186CAB6E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F560", Offset = "0x6C9E160", VA = "0x186C9F560")]
	public static bool MCKMIPMPODA(RenderingData LMNAFHEGHMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F6B0", Offset = "0x6C9E2B0", VA = "0x186C9F6B0")]
	public static void MDKLGKODOBH(CommandBuffer EKFBBEMKDNF, ScriptableRenderContext PDMONEGPHPK, ShadowDrawingSettings ILNMHLLMEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F330", Offset = "0x6C9DF30", VA = "0x186C9F330")]
	public static void ECBCCCHONAG(CommandBuffer EKFBBEMKDNF, ScriptableRenderContext PDMONEGPHPK, RenderingData LMNAFHEGHMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class NAAMHAAMILN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class CEPIHJBAGKL
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int HJDDJDNNLDI;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int DIGPNEABGGD;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static KJEKFHEDBLF<OLPMAENCAJK> LNBCPPGFEGP;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static KJEKFHEDBLF<uint> FNOGKFJHLNK;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static DBBLHICKCAH EFDCPNBKBAJ;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer HJCINBPCMNI;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<FNDJBMINDIA> DAOFKFEOOND;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int HCEEKPEONBM;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int CPGLGHGNPGP;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int DDJOFKDEHMG;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int CJLPFLPGKBC;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] DGKLDGDNEKD;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] LKGMFIEKKEK;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static PCLIKHPFENP[][] PCNBPMOGMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] MMEKCCBJAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int LONJHABNDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int HLGABGALOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int LGMBGGNLEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int DGFFCGNGOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int OFBJENGIDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int HJHPFJLGNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int DOIGHAFAINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int PDICHILKGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int BGPCOBMDLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int HCMHAIKGEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int INHODDDPNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int EMNODABLFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int EIBPEJEAAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int OIHKCKMEJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int DPAPLGCIBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int FBAKDOBMKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int FGIDLPMNABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int MNMLCFGGHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] CEFJEEFCBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private IJBOBBAIOEA GMLPIPHEJLE;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool FOLDLMBMPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9F10", Offset = "0x6CA8B10", VA = "0x186CA9F10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6CA6900", Offset = "0x6CA5500", VA = "0x186CA6900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool CMIPDKDHLPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6CA6960", Offset = "0x6CA5560", VA = "0x186CA6960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6CA49A0", Offset = "0x6CA35A0", VA = "0x186CA49A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData HCNDAPMGMCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6CA67D0", Offset = "0x6CA53D0", VA = "0x186CA67D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6CA69B0", Offset = "0x6CA55B0", VA = "0x186CA69B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static HBMGJGMFCBP KGJHJIAGEPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9FB0", Offset = "0x6CA8BB0", VA = "0x186CA9FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6CA4930", Offset = "0x6CA3530", VA = "0x186CA4930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static EEAKOBDJFHB BHHEHENHAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6CA4AA0", Offset = "0x6CA36A0", VA = "0x186CA4AA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6CA93B0", Offset = "0x6CA7FB0", VA = "0x186CA93B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static OKKBIMGLLLI GHFHMEECENH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9EC0", Offset = "0x6CA8AC0", VA = "0x186CA9EC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5140", Offset = "0x6CA3D40", VA = "0x186CA5140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static MDMONGBKNIN NMHOEDGAECK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6CA6780", Offset = "0x6CA5380", VA = "0x186CA6780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6CA48C0", Offset = "0x6CA34C0", VA = "0x186CA48C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static COLAMOIDMKC DGHKKBOCCJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6CA4820", Offset = "0x6CA3420", VA = "0x186CA4820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB380", Offset = "0x6CA9F80", VA = "0x186CAB380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static HPCFBPELPIB EJDFFNPFJOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9430", Offset = "0x6CA8030", VA = "0x186CA9430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6CA50D0", Offset = "0x6CA3CD0", VA = "0x186CA50D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material JCMHAJONJEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6CA47D0", Offset = "0x6CA33D0", VA = "0x186CA47D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6CA6280", Offset = "0x6CA4E80", VA = "0x186CA6280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material LMEGMHGNFBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9F60", Offset = "0x6CA8B60", VA = "0x186CA9F60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6CA6400", Offset = "0x6CA5000", VA = "0x186CA6400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material EKEKGDPOFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6CA96B0", Offset = "0x6CA82B0", VA = "0x186CA96B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9700", Offset = "0x6CA8300", VA = "0x186CA9700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material KBOKHBIIEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6CA4870", Offset = "0x6CA3470", VA = "0x186CA4870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6CA7AE0", Offset = "0x6CA66E0", VA = "0x186CA7AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool JKFLDGOIPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6CA4A00", Offset = "0x6CA3600", VA = "0x186CA4A00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5C70", Offset = "0x6CA4870", VA = "0x186CA5C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool DJHNJAJGBHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9650", Offset = "0x6CA8250", VA = "0x186CA9650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string EODMNHHJLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9770", Offset = "0x6CA8370", VA = "0x186CA9770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB480", Offset = "0x6CAA080", VA = "0x186CAB480")]
	internal NAAMHAAMILN([Optional] MClusterData BLJMGBNNBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7B50", Offset = "0x6CA6750", VA = "0x186CA7B50")]
	public void KMAKNPIEEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9E20", Offset = "0x6CA8A20", VA = "0x186CA9E20")]
	public void NAAEKGFAGIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9420", Offset = "0x6CA8020", VA = "0x186CA9420")]
	public void LKOIMLEPIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA62F0", Offset = "0x6CA4EF0", VA = "0x186CA62F0")]
	public bool GBGLKKNLKJA(Hash128 IGABCIKOEOA, [Out] LDBOFOJPIGN OOKDOLDBLMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB0D0", Offset = "0x6CA9CD0", VA = "0x186CAB0D0")]
	public LDBOFOJPIGN PEGPHNFMEDB(NDMAKNLBGAM BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB190", Offset = "0x6CA9D90", VA = "0x186CAB190")]
	public EBHPDFIEKAI PEGPHNFMEDB(BOCMGAIAAHF OFCNJEFMNEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6CAAF10", Offset = "0x6CA9B10", VA = "0x186CAAF10")]
	public BBDKMOFBNNB PEGPHNFMEDB(KKMJGFAKLIB CMIAKAKADAG, bool PBACBMGKBGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4A50", Offset = "0x6CA3650", VA = "0x186CA4A50")]
	public void CEFMELNJEMA(GCANMKAGBNG APFPONLDBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6820", Offset = "0x6CA5420", VA = "0x186CA6820")]
	public static void JIIANDFALAO(NIKFMFDBOID HLHOBJEODLD, PCLIKHPFENP[] BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6CA53A0", Offset = "0x6CA3FA0", VA = "0x186CA53A0")]
	private void ECDLFNHMBJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6A20", Offset = "0x6CA5620", VA = "0x186CA6A20")]
	private static void KFLNLEDJPMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6470", Offset = "0x6CA5070", VA = "0x186CA6470")]
	public void IGABOOFCCMB(CommandBuffer EKFBBEMKDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9480", Offset = "0x6CA8080", VA = "0x186CA9480")]
	public void LOOBGDJLAPN([Optional] ScriptableRenderContext? PDMONEGPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5FB0", Offset = "0x6CA4BB0", VA = "0x186CA5FB0")]
	public void FFMKDNFAGKJ(CommandBuffer EKFBBEMKDNF, ShadowSplitData OGHLJKIOOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5CD0", Offset = "0x6CA48D0", VA = "0x186CA5CD0")]
	public void FFMKDNFAGKJ(CommandBuffer EKFBBEMKDNF, CameraData JGPIOACDIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8E70", Offset = "0x6CA7A70", VA = "0x186CA8E70")]
	public void LEBJAJLBACJ(CommandBuffer EKFBBEMKDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6390", Offset = "0x6CA4F90", VA = "0x186CA6390")]
	public void HKBOMEFOEDN(CommandBuffer EKFBBEMKDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7660", Offset = "0x6CA6260", VA = "0x186CA7660")]
	public void KIHKAOPKBGN(CommandBuffer EKFBBEMKDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4AF0", Offset = "0x6CA36F0", VA = "0x186CA4AF0")]
	public void CGCBFFAOCOH(CommandBuffer EKFBBEMKDNF, NIKFMFDBOID ECJAECHKAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA52C0", Offset = "0x6CA3EC0", VA = "0x186CA52C0")]
	public void EAJCEBIHJBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA000", Offset = "0x6CA8C00", VA = "0x186CAA000")]
	public void PAMNEBLPMKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA51B0", Offset = "0x6CA3DB0", VA = "0x186CA51B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class NDNIOIOKPEO
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x20C0A70", Offset = "0x20BF670", VA = "0x1820C0A70")]
	public static int DLDMCICFMJE(int EKJHOCEPHIA, int AEPNOOPMHKL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct JGFCKDAKMAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 CPJJMMJEEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 OMEMOLFGGBG;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly JGFCKDAKMAD DCLABAMMPBF;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly JGFCKDAKMAD LPNKNEBEAHM;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x435C2A0", Offset = "0x435AEA0", VA = "0x18435C2A0")]
	public JGFCKDAKMAD(float4x4 BLHEBLOHEIA, float4 FFHKIKAHNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1750", Offset = "0x6CA0350", VA = "0x186CA1750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct OBODAEPKLJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 GKJAMFFKDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 DJCDKMIHKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 BDBPBPFJEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 BNHKHELIBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 OGGHEBOHLPO;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct FFJGKCFKLCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 GKJAMFFKDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 DJCDKMIHKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 BDBPBPFJEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 BNHKHELIBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 OGGHEBOHLPO;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct LIIKNCFJJBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public FFJGKCFKLCD MLNDJFOCOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public FFJGKCFKLCD GNPMMOJFIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public FFJGKCFKLCD CNJAHGAEDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public FFJGKCFKLCD LAOGMFGHLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public FFJGKCFKLCD ICBGAFBOMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public FFJGKCFKLCD EGLLJEACPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public FFJGKCFKLCD PLEJFEKJCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public FFJGKCFKLCD CAHFFDAFBDK;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct NPHIDIBELME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public OBODAEPKLJB MLNDJFOCOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public OBODAEPKLJB GNPMMOJFIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public OBODAEPKLJB CNJAHGAEDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public OBODAEPKLJB LAOGMFGHLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public OBODAEPKLJB ICBGAFBOMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public OBODAEPKLJB EGLLJEACPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public OBODAEPKLJB PLEJFEKJCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public OBODAEPKLJB CAHFFDAFBDK;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct BIPJANHJGHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 EDPBFFGGELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint FGLHPIPFODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint FPOAMEDFGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float BBCJMFLPHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint BFDCKNNOCHJ;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6C9D1D0", Offset = "0x6C9BDD0", VA = "0x186C9D1D0")]
	public BIPJANHJGHN(BOCMGAIAAHF OFCNJEFMNEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct OLPMAENCAJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint BCNNONKAJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint GIJBNDALLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint HGAABFOLPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint BFDCKNNOCHJ;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB9C0", Offset = "0x6CAA5C0", VA = "0x186CAB9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct EHOPGPMJBEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint OEOPHGCAFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint AFEKGLGBIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint CCHNADPHIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint BFDCKNNOCHJ;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6C9EEA0", Offset = "0x6C9DAA0", VA = "0x186C9EEA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct MLMMPMIFMPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint PFCHKADCENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint HHBHALGHMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint NCPDGPPPMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint OJCNOEGGHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint BIOHGAIKDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint KJCHGLHBGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint AAOIBAHJJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint BFDCKNNOCHJ;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6CA44A0", Offset = "0x6CA30A0", VA = "0x186CA44A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct JMMALOEEKEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 LIMFAEIMDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 HNGIJKPNENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 ODEFEKLIHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 NGGPKEOCLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 EPHKDLFJABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 JPANOFBBCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 FOIEPLIONOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 HMEMBNFDFKH;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA18B0", Offset = "0x6CA04B0", VA = "0x186CA18B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum NIKFMFDBOID
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
