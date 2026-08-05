using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class FIFCIGOMJED : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020")]
	public FIFCIGOMJED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class CDKIJKLNCBO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020")]
	public CDKIJKLNCBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class OFHMNJDAJIL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020")]
	public OFHMNJDAJIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class NDKHIDOICBL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020")]
	public NDKHIDOICBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class DOFCGMBENCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x11F7380", Offset = "0x11F5980", VA = "0x1811F7380")]
	public static bool OIMDDOBPFMG(this TypeInfo MCLMFJEAHEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class DLJBOAMMMBH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type IAAMNKAPKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71E880", Offset = "0x71CE80", VA = "0x18071E880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] PJMKMENPPEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x723370", Offset = "0x721970", VA = "0x180723370")]
	public DLJBOAMMMBH(Type MKPLIADKLAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class BGBAEKJNLBO : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void FJGAKNNEING<T>(ref NADLEEAJGKF IEEJJNDPOHK, T MAKFNMHIJIF, OLGPDOHAJDG KMBIIPHHOMB);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T BBNBBHDPEAG<T>(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG KMBIIPHHOMB);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HAOPHHJJNOJ
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AMLJDOHMGLI<T> : HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HINADFJMEID<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, T MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum HCMHKFNLMLF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AEHMCJCLJBP
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x27D24E0", Offset = "0x27D0AE0", VA = "0x1827D24E0")]
	public static global::AMLJDOHMGLI<T> JOFCKJJNFGN<T>(this OLGPDOHAJDG KMBIIPHHOMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x11E09F0", Offset = "0x11DEFF0", VA = "0x1811E09F0")]
	public static object AHOBHECGJFD(this OLGPDOHAJDG KMBIIPHHOMB, Type MCLMFJEAHEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AOEEHBLBCMP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x11E2970", Offset = "0x11E0F70", VA = "0x1811E2970")]
	public AOEEHBLBCMP(string DIDMFBHHIEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct PLJMADAGCJN
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class OAAFHPHAGFE
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] DICKNCEHGPP;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] CEOBFPGJKJA;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x18A4F40", Offset = "0x18A3540", VA = "0x1818A4F40")]
		public static byte[] ODOMBKDHBOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x18A4EB0", Offset = "0x18A34B0", VA = "0x1818A4EB0")]
		public static char[] DABKKPBILKH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> KKFNIEGFOMF;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] INOFDCHBILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] PPJLGCLGPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int ADDILPEFEHP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool AMECLKLBNHN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x18A8DC0", Offset = "0x18A73C0", VA = "0x1818A8DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x18A9A70", Offset = "0x18A8070", VA = "0x1818A9A70")]
	public PLJMADAGCJN(byte[] PPJLGCLGPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x18A9A80", Offset = "0x18A8080", VA = "0x1818A9A80")]
	public PLJMADAGCJN(byte[] PPJLGCLGPJE, int ADDILPEFEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x18A8430", Offset = "0x18A6A30", VA = "0x1818A8430")]
	private HDOENCDNONA EIFHGNCKLPD(string BGANFPDCCAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x18A7770", Offset = "0x18A5D70", VA = "0x1818A7770")]
	private HDOENCDNONA BFBDPMLAIHM(string DIDMFBHHIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1708030", Offset = "0x1706630", VA = "0x181708030")]
	public void BJIANFMJHLF(int ADDILPEFEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x72F7B0", Offset = "0x72DDB0", VA = "0x18072F7B0")]
	public byte[] LLHNBEEPOGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x677CF0", Offset = "0x6762F0", VA = "0x180677CF0")]
	public int LPBDAPHCOHB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x18A9630", Offset = "0x18A7C30", VA = "0x1818A9630")]
	public IIGHGFKMPAH PEHJGHBPGDM()
	{
		return default(IIGHGFKMPAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x18A7E80", Offset = "0x18A6480", VA = "0x1818A7E80")]
	public void DEGPPJKMELK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x18A82D0", Offset = "0x18A68D0", VA = "0x1818A82D0")]
	public bool EELDJKNLCMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x18A93F0", Offset = "0x18A79F0", VA = "0x1818A93F0")]
	public bool NKHAIEMKIHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x18A97B0", Offset = "0x18A7DB0", VA = "0x1818A97B0")]
	public void PHKFHKHDHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x18A91F0", Offset = "0x18A77F0", VA = "0x1818A91F0")]
	public bool MKGEFJJHLHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x18A8DE0", Offset = "0x18A73E0", VA = "0x1818A8DE0")]
	public bool JILLIPIONNE(ref int FPLNDBJJHMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x18A7BE0", Offset = "0x18A61E0", VA = "0x1818A7BE0")]
	public bool CGKIGMCCFJE(ref int FPLNDBJJHMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x18A9910", Offset = "0x18A7F10", VA = "0x1818A9910")]
	public bool PJLJBNJELBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x18A7A80", Offset = "0x18A6080", VA = "0x1818A7A80")]
	public void BOIMLFPBLJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x18A7990", Offset = "0x18A5F90", VA = "0x1818A7990")]
	public bool BMALKKEANCO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x18A8020", Offset = "0x18A6620", VA = "0x1818A8020")]
	public bool DMIIFCHPGGA(ref int FPLNDBJJHMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x18A89F0", Offset = "0x18A6FF0", VA = "0x1818A89F0")]
	public bool FJOMAFFMING(ref int FPLNDBJJHMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x18A6E70", Offset = "0x18A5470", VA = "0x1818A6E70")]
	public bool AEOCEMAHPHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x18A7900", Offset = "0x18A5F00", VA = "0x1818A7900")]
	public void BKHBJKPDJNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x18A83D0", Offset = "0x18A69D0", VA = "0x1818A83D0")]
	public bool EGFGEHIKKBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x18A79F0", Offset = "0x18A5FF0", VA = "0x1818A79F0")]
	public void BOEIIKEJCLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x18A6F50", Offset = "0x18A5550", VA = "0x1818A6F50")]
	private void AIGEMBAKKIP(out byte[] NDCAHLOEJEM, out int FFNKCGPCHMO, out int LDICMAOLBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x18A7850", Offset = "0x18A5E50", VA = "0x1818A7850")]
	private static int BGFFBMMCOBO(char IKAMJBDPPHG, char LKLEFAIICIC, char KOIHHAIHBKH, char OECCBELLJIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x18A92C0", Offset = "0x18A78C0", VA = "0x1818A92C0")]
	private static int MOJHEKHPFGD(char FBHIPILAOBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x18A8AB0", Offset = "0x18A70B0", VA = "0x1818A8AB0")]
	public ArraySegment<byte> GIGNKOEHKHF()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x18A80A0", Offset = "0x18A66A0", VA = "0x1818A80A0")]
	public string DNFLMNKHFIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x18A8940", Offset = "0x18A6F40", VA = "0x1818A8940")]
	public string EJMIHLIGNDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x18A8BB0", Offset = "0x18A71B0", VA = "0x1818A8BB0")]
	public ArraySegment<byte> HJDMFPBMDPG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x18A8D80", Offset = "0x18A7380", VA = "0x1818A8D80")]
	public ArraySegment<byte> HPHBDFKMCBD()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x18A8FB0", Offset = "0x18A75B0", VA = "0x1818A8FB0")]
	public bool MCFMJGNKPCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x18A9450", Offset = "0x18A7A50", VA = "0x1818A9450")]
	private static bool ODPDMBELCME(byte KOIHHAIHBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x18A7CA0", Offset = "0x18A62A0", VA = "0x1818A7CA0")]
	private void CNLAKJHMCOL(IIGHGFKMPAH HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x18A9250", Offset = "0x18A7850", VA = "0x1818A9250")]
	public void MMOGBPMNDOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x18A9840", Offset = "0x18A7E40", VA = "0x1818A9840")]
	private void PHPLPNPBKHI(int DCIFPJJANLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x18A9510", Offset = "0x18A7B10", VA = "0x1818A9510")]
	public sbyte OEJIODCFHFI()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x18A9260", Offset = "0x18A7860", VA = "0x1818A9260")]
	public short MNOELAFOIJN()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x18A8F50", Offset = "0x18A7550", VA = "0x1818A8F50")]
	public int MAMJGCIBBDI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x18A6ED0", Offset = "0x18A54D0", VA = "0x1818A6ED0")]
	public long AGKJMAEDDIA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x18A7710", Offset = "0x18A5D10", VA = "0x1818A7710")]
	public byte ALLOGFBOPJE()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x18A7FC0", Offset = "0x18A65C0", VA = "0x1818A7FC0")]
	public ushort DJNLHIBIHAN()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x18A9390", Offset = "0x18A7990", VA = "0x1818A9390")]
	public uint NHJCJHDIGJH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x18A8970", Offset = "0x18A6F70", VA = "0x1818A8970")]
	public ulong FJLNLLKGCDA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x18A7B10", Offset = "0x18A6110", VA = "0x1818A7B10")]
	public float CBDLDEMIBAL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x18A9560", Offset = "0x18A7B60", VA = "0x1818A9560")]
	public double OJFCEJPLDPM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x18A8E60", Offset = "0x18A7460", VA = "0x1818A8E60")]
	public ArraySegment<byte> KDGJCOJADMM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x18A8140", Offset = "0x18A6740", VA = "0x1818A8140")]
	private static int EAMPOJAGDLA(byte[] PPJLGCLGPJE, int ADDILPEFEHP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HDOENCDNONA : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference DPKDNHBKKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int IIEGBBGOHPK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int OOBFCPKIKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C10", Offset = "0x7E4210", VA = "0x1807E5C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string NGJLKPOCOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x744B40", Offset = "0x743140", VA = "0x180744B40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x16F7F90", Offset = "0x16F6590", VA = "0x1816F7F90")]
	public HDOENCDNONA(string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x16F7EB0", Offset = "0x16F64B0", VA = "0x1816F7EB0")]
	public HDOENCDNONA(string DIDMFBHHIEC, byte[] KGDKDGBHIHA, int ADDILPEFEHP, int IIEGBBGOHPK, string COINMNFPCMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class BFANMEHDCBH
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class EHAEDILPELC
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void FEGGEIEEPMI(ref NADLEEAJGKF IEEJJNDPOHK, object MAKFNMHIJIF, OLGPDOHAJDG KMBIIPHHOMB);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object ALBFGIDANJB(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG KMBIIPHHOMB);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class EALBCEEBAFE
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class AABFIECDBPM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
				public AABFIECDBPM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0xAEF4E0", Offset = "0xAEDAE0", VA = "0x180AEF4E0")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x1898D80", Offset = "0x1897380", VA = "0x181898D80")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, OLGPDOHAJDG, byte[]> BECOJIJFHFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, OLGPDOHAJDG> PMBDEGHAFLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly FEGGEIEEPMI GOHNPLGEPAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, OLGPDOHAJDG, ArraySegment<byte>> NICLADIJADK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, OLGPDOHAJDG, string> HPJBGOKELHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, OLGPDOHAJDG, object> APNMEICIHOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, OLGPDOHAJDG, object> KEIOMJEEGGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, OLGPDOHAJDG, object> NBMKBLAELGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly ALBFGIDANJB LPINIPKKKJC;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x18999D0", Offset = "0x1897FD0", VA = "0x1818999D0")]
			public EALBCEEBAFE(Type MCLMFJEAHEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x60A30A0", Offset = "0x60A16A0", VA = "0x1860A30A0")]
			private static T BFNBMIEKGLG<T>(DynamicMethod LNIDBLPKFFA)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x1899780", Offset = "0x1897D80", VA = "0x181899780")]
			private static MethodInfo JIHBCEMEKHP(Type MCLMFJEAHEC, string NBODBMLPNJA, Type[] KPJOKBJOCEO)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, EALBCEEBAFE> AAMHAMEIPEG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::AAONIJFMFPJ<EALBCEEBAFE> KGODNJLNIBI;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x189BAB0", Offset = "0x189A0B0", VA = "0x18189BAB0")]
		static EHAEDILPELC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x189B770", Offset = "0x1899D70", VA = "0x18189B770")]
		private static EALBCEEBAFE GIKDDENMNIA(Type MCLMFJEAHEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x189B800", Offset = "0x1899E00", VA = "0x18189B800")]
		public static void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, object MAKFNMHIJIF, OLGPDOHAJDG KMBIIPHHOMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x189B990", Offset = "0x1899F90", VA = "0x18189B990")]
		public static void HGEKGOKJCDE(Type MCLMFJEAHEC, ref NADLEEAJGKF IEEJJNDPOHK, object MAKFNMHIJIF, OLGPDOHAJDG KMBIIPHHOMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class NOLBONAOFPH
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] DICKNCEHGPP;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x18A4E20", Offset = "0x18A3420", VA = "0x1818A4E20")]
		public static byte[] ODOMBKDHBOE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static OLGPDOHAJDG EHNOBPHGHBN;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] BNDGOHBFEAI;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] OHFNIFGDNAL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static OLGPDOHAJDG FKDADKKOCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x11E3590", Offset = "0x11E1B90", VA = "0x1811E3590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool MGEAADBCNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x11E3B70", Offset = "0x11E2170", VA = "0x1811E3B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x11E3030", Offset = "0x11E1630", VA = "0x1811E3030")]
	public static void HDFAMIHGKFI(OLGPDOHAJDG KMBIIPHHOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x33B21B0", Offset = "0x33B07B0", VA = "0x1833B21B0")]
	public static byte[] HGEKGOKJCDE<T>(T LGKNNMGLNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x33B1EE0", Offset = "0x33B04E0", VA = "0x1833B1EE0")]
	public static byte[] HGEKGOKJCDE<T>(T MAKFNMHIJIF, OLGPDOHAJDG KMBIIPHHOMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x33B1E50", Offset = "0x33B0450", VA = "0x1833B1E50")]
	public static void HGEKGOKJCDE<T>(ref NADLEEAJGKF IEEJJNDPOHK, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x33B2040", Offset = "0x33B0640", VA = "0x1833B2040")]
	public static void HGEKGOKJCDE<T>(ref NADLEEAJGKF IEEJJNDPOHK, T MAKFNMHIJIF, OLGPDOHAJDG KMBIIPHHOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x33B2120", Offset = "0x33B0720", VA = "0x1833B2120")]
	public static void HGEKGOKJCDE<T>(Stream FJEDANIIFJL, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x33B1D30", Offset = "0x33B0330", VA = "0x1833B1D30")]
	public static void HGEKGOKJCDE<T>(Stream FJEDANIIFJL, T MAKFNMHIJIF, OLGPDOHAJDG KMBIIPHHOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x33B23B0", Offset = "0x33B09B0", VA = "0x1833B23B0")]
	public static ArraySegment<byte> KFNLLNOPPFP<T>(T LGKNNMGLNIA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x33B2230", Offset = "0x33B0830", VA = "0x1833B2230")]
	public static ArraySegment<byte> KFNLLNOPPFP<T>(T MAKFNMHIJIF, OLGPDOHAJDG KMBIIPHHOMB)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x33B0730", Offset = "0x33AED30", VA = "0x1833B0730")]
	public static string FEKPKJBNCOA<T>(T MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x33B07B0", Offset = "0x33AEDB0", VA = "0x1833B07B0")]
	public static string FEKPKJBNCOA<T>(T MAKFNMHIJIF, OLGPDOHAJDG KMBIIPHHOMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x33B1560", Offset = "0x33AFB60", VA = "0x1833B1560")]
	public static T FFFJLEEKFAK<T>(string KCOMGIPFPJM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x33B1470", Offset = "0x33AFA70", VA = "0x1833B1470")]
	public static T FFFJLEEKFAK<T>(string KCOMGIPFPJM, OLGPDOHAJDG KMBIIPHHOMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x33B1980", Offset = "0x33AFF80", VA = "0x1833B1980")]
	public static T FFFJLEEKFAK<T>(byte[] PPJLGCLGPJE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x33B13D0", Offset = "0x33AF9D0", VA = "0x1833B13D0")]
	public static T FFFJLEEKFAK<T>(byte[] PPJLGCLGPJE, OLGPDOHAJDG KMBIIPHHOMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x33B1740", Offset = "0x33AFD40", VA = "0x1833B1740")]
	public static T FFFJLEEKFAK<T>(byte[] PPJLGCLGPJE, int ADDILPEFEHP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x33B1270", Offset = "0x33AF870", VA = "0x1833B1270")]
	public static T FFFJLEEKFAK<T>(byte[] PPJLGCLGPJE, int ADDILPEFEHP, OLGPDOHAJDG KMBIIPHHOMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x33B1A00", Offset = "0x33B0000", VA = "0x1833B1A00")]
	public static T FFFJLEEKFAK<T>(ref PLJMADAGCJN ILDGEJAOOHJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x33B1B00", Offset = "0x33B0100", VA = "0x1833B1B00")]
	public static T FFFJLEEKFAK<T>(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG KMBIIPHHOMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x33B1CB0", Offset = "0x33B02B0", VA = "0x1833B1CB0")]
	public static T FFFJLEEKFAK<T>(Stream FJEDANIIFJL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x33B1850", Offset = "0x33AFE50", VA = "0x1833B1850")]
	public static T FFFJLEEKFAK<T>(Stream FJEDANIIFJL, OLGPDOHAJDG KMBIIPHHOMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x11E3830", Offset = "0x11E1E30", VA = "0x1811E3830")]
	public static string MEMBIABHPIF(byte[] KCOMGIPFPJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x11E36B0", Offset = "0x11E1CB0", VA = "0x1811E36B0")]
	public static string MEMBIABHPIF(byte[] KCOMGIPFPJM, int ADDILPEFEHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x11E3760", Offset = "0x11E1D60", VA = "0x1811E3760")]
	public static string MEMBIABHPIF(string KCOMGIPFPJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x11E39E0", Offset = "0x11E1FE0", VA = "0x1811E39E0")]
	public static byte[] NAGOEHCMNLP(byte[] KCOMGIPFPJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x11E3AC0", Offset = "0x11E20C0", VA = "0x1811E3AC0")]
	public static byte[] NAGOEHCMNLP(byte[] KCOMGIPFPJM, int ADDILPEFEHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x11E3910", Offset = "0x11E1F10", VA = "0x1811E3910")]
	public static byte[] NAGOEHCMNLP(string KCOMGIPFPJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x11E30A0", Offset = "0x11E16A0", VA = "0x1811E30A0")]
	private static void JBMEIFHPCBC(ref PLJMADAGCJN ILDGEJAOOHJ, ref NADLEEAJGKF IEEJJNDPOHK, int IFJOKNDLBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x11E2F90", Offset = "0x11E1590", VA = "0x1811E2F90")]
	private static int BIOEEFNHOHL(Stream OHEHJIBMMJC, ref byte[] DICKNCEHGPP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum IIGHGFKMPAH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BeginObject,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	EndObject,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BeginArray,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	EndArray,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Number,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	String,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	True,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	False,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Null,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ValueSeparator,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	NameSeparator
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct NADLEEAJGKF
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] NAJGAJEEJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] DICKNCEHGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int ADDILPEFEHP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NCOECDLCNNL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x677CF0", Offset = "0x6762F0", VA = "0x180677CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1708030", Offset = "0x1706630", VA = "0x181708030")]
	public void BJIANFMJHLF(int ADDILPEFEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1708750", Offset = "0x1706D50", VA = "0x181708750")]
	public static byte[] GJJPHGNDPJL(string MABBPMMEACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1708950", Offset = "0x1706F50", VA = "0x181708950")]
	public static byte[] IICDKHCHLJC(string MABBPMMEACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1707CA0", Offset = "0x17062A0", VA = "0x181707CA0")]
	public static byte[] AGJMAKIAPNH(string MABBPMMEACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1708040", Offset = "0x1706640", VA = "0x181708040")]
	public static byte[] BJMKLLBBABP(string MABBPMMEACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1708F20", Offset = "0x1707520", VA = "0x181708F20")]
	public NADLEEAJGKF(byte[] JDGAOCMHEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1708D70", Offset = "0x1707370", VA = "0x181708D70")]
	public ArraySegment<byte> ODOMBKDHBOE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1708880", Offset = "0x1706E80", VA = "0x181708880")]
	public byte[] HNKDGNKJJFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1708E60", Offset = "0x1707460", VA = "0x181708E60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1708E20", Offset = "0x1707420", VA = "0x181708E20")]
	public void OLOLAGONDMO(int BLLNGOIDILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x11F7960", Offset = "0x11F5F60", VA = "0x1811F7960")]
	public void NJPHEILFIAB(byte DMCLNBMJJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1708CC0", Offset = "0x17072C0", VA = "0x181708CC0")]
	public void NJPHEILFIAB(byte[] DMCLNBMJJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x17086C0", Offset = "0x1706CC0", VA = "0x1817086C0")]
	public void FMPJGAGIPPF(byte DMCLNBMJJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1708700", Offset = "0x1706D00", VA = "0x181708700")]
	public void FNGFOONPFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x17081C0", Offset = "0x17067C0", VA = "0x1817081C0")]
	public void CHJMEKOBGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1708830", Offset = "0x1706E30", VA = "0x181708830")]
	public void HCIAODGFCJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1708A90", Offset = "0x1707090", VA = "0x181708A90")]
	public void IPBCBDGPOOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1708900", Offset = "0x1706F00", VA = "0x181708900")]
	public void IAOKICAGGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1708D20", Offset = "0x1707320", VA = "0x181708D20")]
	public void NOOJLEHCKHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1708210", Offset = "0x1706810", VA = "0x181708210")]
	public void DFNNIDECCIC(string MABBPMMEACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1708C70", Offset = "0x1707270", VA = "0x181708C70")]
	public void LANLNFLAEFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1708B70", Offset = "0x1707170", VA = "0x181708B70")]
	public void JNOPNCHKEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1707E10", Offset = "0x1706410", VA = "0x181707E10")]
	public void BAKFLJLNHDL(bool MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1707C20", Offset = "0x1706220", VA = "0x181707C20")]
	public void ACNDFOPIFEA(float MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1708640", Offset = "0x1706C40", VA = "0x181708640")]
	public void EIHGJMAAJCB(double MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1708000", Offset = "0x1706600", VA = "0x181708000")]
	public void BEJIBHPLPOD(byte MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1708C40", Offset = "0x1707240", VA = "0x181708C40")]
	public void KIEPAGDODBC(ushort MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1708190", Offset = "0x1706790", VA = "0x181708190")]
	public void BKPBPJKBDCF(uint MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1708AE0", Offset = "0x17070E0", VA = "0x181708AE0")]
	public void JHCKALKHKFD(ulong MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1708B10", Offset = "0x1707110", VA = "0x181708B10")]
	public void JJHLHIKLJOI(sbyte MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1708B40", Offset = "0x1707140", VA = "0x181708B40")]
	public void JLMEIAAHHMM(short MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1708E30", Offset = "0x1707430", VA = "0x181708E30")]
	public void OMJOOMJOMOE(int MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1707DE0", Offset = "0x17063E0", VA = "0x181707DE0")]
	public void AGLANPICECC(long MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1708270", Offset = "0x1706870", VA = "0x181708270")]
	public void DKNICIIPFOI(string MAKFNMHIJIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AIAFJNMIKGM : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class ONDHHFBNOII<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x44231D0", Offset = "0x44217D0", VA = "0x1844231D0")]
		static ONDHHFBNOII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private AIAFJNMIKGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class JPOMPHDBNLO
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> CJBOPBJLIHN;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x16FE2C0", Offset = "0x16FC8C0", VA = "0x1816FE2C0")]
	static JPOMPHDBNLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x16FDBB0", Offset = "0x16FC1B0", VA = "0x1816FDBB0")]
	internal static object PBCJPIJEMHM(Type KHJLEOILJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class KLELDGJDODE : global::AMLJDOHMGLI<Vector2>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GBDCNECDJKO KFFMDJLEHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] JEPIODCCEIN;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x17027D0", Offset = "0x1700DD0", VA = "0x1817027D0")]
	public KLELDGJDODE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1702620", Offset = "0x1700C20", VA = "0x181702620", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Vector2 MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x17024A0", Offset = "0x1700AA0", VA = "0x1817024A0", Slot = "5")]
	public Vector2 FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class CJGNNIGLNCM : global::AMLJDOHMGLI<Vector3>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly GBDCNECDJKO KFFMDJLEHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] JEPIODCCEIN;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x11F2CF0", Offset = "0x11F12F0", VA = "0x1811F2CF0")]
	public CJGNNIGLNCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x11F2BD0", Offset = "0x11F11D0", VA = "0x1811F2BD0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Vector3 MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x11F29A0", Offset = "0x11F0FA0", VA = "0x1811F29A0", Slot = "5")]
	public Vector3 FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class JPCBMCPKDHM : global::AMLJDOHMGLI<Vector4>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly GBDCNECDJKO KFFMDJLEHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] JEPIODCCEIN;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x16FD6F0", Offset = "0x16FBCF0", VA = "0x1816FD6F0")]
	public JPCBMCPKDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x16FC400", Offset = "0x16FAA00", VA = "0x1816FC400", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Vector4 MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x16FD4D0", Offset = "0x16FBAD0", VA = "0x1816FD4D0", Slot = "5")]
	public Vector4 FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class EKNCBDIJENH : global::AMLJDOHMGLI<Quaternion>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly GBDCNECDJKO KFFMDJLEHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] JEPIODCCEIN;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x11F8350", Offset = "0x11F6950", VA = "0x1811F8350")]
	public EKNCBDIJENH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x11F8200", Offset = "0x11F6800", VA = "0x1811F8200", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Quaternion MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x11F7F70", Offset = "0x11F6570", VA = "0x1811F7F70", Slot = "5")]
	public Quaternion FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class JEGPKHLHFEF : global::AMLJDOHMGLI<Color>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly GBDCNECDJKO KFFMDJLEHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] JEPIODCCEIN;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x16FC760", Offset = "0x16FAD60", VA = "0x1816FC760")]
	public JEGPKHLHFEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x16FC400", Offset = "0x16FAA00", VA = "0x1816FC400", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Color MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x16FC1E0", Offset = "0x16FA7E0", VA = "0x1816FC1E0", Slot = "5")]
	public Color FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class BGHPFBOMGON : global::AMLJDOHMGLI<Bounds>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly GBDCNECDJKO KFFMDJLEHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] JEPIODCCEIN;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x11E4220", Offset = "0x11E2820", VA = "0x1811E4220")]
	public BGHPFBOMGON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x11E4080", Offset = "0x11E2680", VA = "0x1811E4080", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Bounds MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x11E3D50", Offset = "0x11E2350", VA = "0x1811E3D50", Slot = "5")]
	public Bounds FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class GKBJGPONBFG : global::AMLJDOHMGLI<Rect>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly GBDCNECDJKO KFFMDJLEHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] JEPIODCCEIN;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x16F76C0", Offset = "0x16F5CC0", VA = "0x1816F76C0")]
	public GKBJGPONBFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x16F7310", Offset = "0x16F5910", VA = "0x1816F7310", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Rect MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x16F70D0", Offset = "0x16F56D0", VA = "0x1816F70D0", Slot = "5")]
	public Rect FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class DFAJFEENNMN : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class HGPOHCDPAAP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x46D56E0", Offset = "0x46D3CE0", VA = "0x1846D56E0")]
		static HGPOHCDPAAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private DFAJFEENNMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class GOGNLHMBBAN : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class IBEECNMHPMC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3552B40", Offset = "0x3551140", VA = "0x183552B40")]
		static IBEECNMHPMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class KEIEMPNDDLO
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> PCDDJKNDOIA;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x189D980", Offset = "0x189BF80", VA = "0x18189D980")]
		internal static object PBCJPIJEMHM(Type KHJLEOILJMF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private GOGNLHMBBAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class MHAOPIEFFDM : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class PLFIAGHBNLA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3DAA0D0", Offset = "0x3DA86D0", VA = "0x183DAA0D0")]
		static PLFIAGHBNLA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly MHAOPIEFFDM LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool NNAGHMKLCDG;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static HAOPHHJJNOJ[] IJCEIOMGAAB;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static OLGPDOHAJDG[] ONOMODABNOH;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private MHAOPIEFFDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1704140", Offset = "0x1702740", VA = "0x181704140")]
	public static void KOEBKPOFGOP(params OLGPDOHAJDG[] ONOMODABNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1704220", Offset = "0x1702820", VA = "0x181704220")]
	public static void KOEBKPOFGOP(params HAOPHHJJNOJ[] IJCEIOMGAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1703EB0", Offset = "0x17024B0", VA = "0x181703EB0")]
	public static void CNNFIDCDEDG(HAOPHHJJNOJ[] IJCEIOMGAAB, OLGPDOHAJDG[] ONOMODABNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class FIABIBCICPE : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class GIGDEKMKIGC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x37D7FD0", Offset = "0x37D65D0", VA = "0x1837D7FD0")]
		static GIGDEKMKIGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private FIABIBCICPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class HGCEDGJHKHP
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly OLGPDOHAJDG MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly OLGPDOHAJDG EHKLICKEJEN;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly OLGPDOHAJDG BNCAJEJDGLP;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly OLGPDOHAJDG HNCIJBHEFDN;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly OLGPDOHAJDG PKHCJFCNGOP;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly OLGPDOHAJDG DDGOMPBHKMM;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly OLGPDOHAJDG HOHLHJOMJJC;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly OLGPDOHAJDG KOIHOMLMFHA;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly OLGPDOHAJDG EKEMONNDIAB;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly OLGPDOHAJDG FNDIMFCJPIB;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly OLGPDOHAJDG BGMKHDDIKML;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly OLGPDOHAJDG KOHMGIANEAE;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class HFOAGFHMBOM
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly OLGPDOHAJDG MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly OLGPDOHAJDG FGPBDGNFIKC;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class OPGDGOAJPHO
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly OLGPDOHAJDG MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly OLGPDOHAJDG EHKLICKEJEN;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly OLGPDOHAJDG BNCAJEJDGLP;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly OLGPDOHAJDG HNCIJBHEFDN;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly OLGPDOHAJDG PKHCJFCNGOP;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly OLGPDOHAJDG DDGOMPBHKMM;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly OLGPDOHAJDG HOHLHJOMJJC;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly OLGPDOHAJDG KOIHOMLMFHA;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly OLGPDOHAJDG EKEMONNDIAB;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly OLGPDOHAJDG FNDIMFCJPIB;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly OLGPDOHAJDG BGMKHDDIKML;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly OLGPDOHAJDG KOHMGIANEAE;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class DFGBAPHKFLH
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> PCDDJKNDOIA;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x11F4820", Offset = "0x11F2E20", VA = "0x1811F4820")]
	internal static object PBCJPIJEMHM(Type KHJLEOILJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x11F47E0", Offset = "0x11F2DE0", VA = "0x1811F47E0")]
	private static object ENDPNBMFPMA(Type KAGJIFJNHPM, Type[] POAEHFBFGPN, params object[] KPJOKBJOCEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class IJGFMABODFA : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class BMKFLFGEMFP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3FB15E0", Offset = "0x3FAFBE0", VA = "0x183FB15E0")]
		static BMKFLFGEMFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> BPDELMJNELN;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool OHLDEPKBDNJ;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly IBELCNMFHJB POKEBAHAKOL;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x16F9BE0", Offset = "0x16F81E0", VA = "0x1816F9BE0")]
	static IJGFMABODFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private IJGFMABODFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class OPOMMPEJLFG : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class EKKFCGEEGHE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x36CCB30", Offset = "0x36CB130", VA = "0x1836CCB30")]
		static EKKFCGEEGHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> BPDELMJNELN;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool OHLDEPKBDNJ;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly IBELCNMFHJB POKEBAHAKOL;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x18A6200", Offset = "0x18A4800", VA = "0x1818A6200")]
	static OPOMMPEJLFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private OPOMMPEJLFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class GJEBLDGBIKK : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class GLGOBMMLCHJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x40828C0", Offset = "0x4080EC0", VA = "0x1840828C0")]
		static GLGOBMMLCHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> BPDELMJNELN;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool OHLDEPKBDNJ;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly IBELCNMFHJB POKEBAHAKOL;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x16F6FA0", Offset = "0x16F55A0", VA = "0x1816F6FA0")]
	static GJEBLDGBIKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private GJEBLDGBIKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class DNPLMOOJHBL : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class DFLMBMCLNHL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3414A60", Offset = "0x3413060", VA = "0x183414A60")]
		static DFLMBMCLNHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> BPDELMJNELN;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool OHLDEPKBDNJ;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly IBELCNMFHJB POKEBAHAKOL;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x11F7250", Offset = "0x11F5850", VA = "0x1811F7250")]
	static DNPLMOOJHBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private DNPLMOOJHBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class LLLNACHGBLG : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class LJEKHJCGCOJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3046A00", Offset = "0x3045000", VA = "0x183046A00")]
		static LJEKHJCGCOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> BPDELMJNELN;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool OHLDEPKBDNJ;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly IBELCNMFHJB POKEBAHAKOL;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1703860", Offset = "0x1701E60", VA = "0x181703860")]
	static LLLNACHGBLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private LLLNACHGBLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class OJFOGIEFOKE : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class IOFHOGPABFD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x328C3A0", Offset = "0x328A9A0", VA = "0x18328C3A0")]
		static IOFHOGPABFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> BPDELMJNELN;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool OHLDEPKBDNJ;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly IBELCNMFHJB POKEBAHAKOL;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x170CE20", Offset = "0x170B420", VA = "0x18170CE20")]
	static OJFOGIEFOKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private OJFOGIEFOKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class DFKCLFLNPIM : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class DMEMNKOEPBH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x342B4E0", Offset = "0x3429AE0", VA = "0x18342B4E0")]
		static DMEMNKOEPBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> BPDELMJNELN;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool OHLDEPKBDNJ;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public DFKCLFLNPIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class LALOINHDOJL : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class HAIOLGAALOK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x43FC530", Offset = "0x43FAB30", VA = "0x1843FC530")]
		static HAIOLGAALOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> BPDELMJNELN;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool OHLDEPKBDNJ;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public LALOINHDOJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class DJIOJNABNNI : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class CAIHBCDIHMJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3BD1240", Offset = "0x3BCF840", VA = "0x183BD1240")]
		static CAIHBCDIHMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> BPDELMJNELN;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool OHLDEPKBDNJ;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public DJIOJNABNNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class MGEBANMDBIO : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class PIOPLCLNDIC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3D8F9D0", Offset = "0x3D8DFD0", VA = "0x183D8F9D0")]
		static PIOPLCLNDIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> BPDELMJNELN;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool OHLDEPKBDNJ;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MGEBANMDBIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class PNBGPJGEPMF : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class BMMIPKEECCP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3FB5130", Offset = "0x3FB3730", VA = "0x183FB5130")]
		static BMMIPKEECCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> BPDELMJNELN;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool OHLDEPKBDNJ;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public PNBGPJGEPMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class DIFNLLMHBIL : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class MCJDPNBMKMO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4530CF0", Offset = "0x452F2F0", VA = "0x184530CF0")]
		static MCJDPNBMKMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> BPDELMJNELN;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool OHLDEPKBDNJ;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public DIFNLLMHBIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class CEGAKCBCNBK
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct PAMMMIPIMPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public IFOAMENKCOO OIAGBKMCLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder EKCGABAGNPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder AAENJEKIFKA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class MCHMFNLFEGA
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class OLEFJGFFEFN
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo AGJMAKIAPNH;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo IICDKHCHLJC;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo BJMKLLBBABP;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo GJJPHGNDPJL;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo JNOPNCHKEHI;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo NJPHEILFIAB;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo HCIAODGFCJH;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo IPBCBDGPOOH;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo IAOKICAGGAB;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x18A4FD0", Offset = "0x18A35D0", VA = "0x1818A4FD0")]
			static OLEFJGFFEFN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class NLEBGFOIMHK
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo EELDJKNLCMO;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo BOIMLFPBLJE;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo DMIIFCHPGGA;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo FCEAECBEMGF;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo MMOGBPMNDOK;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo LLHNBEEPOGP;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo LPBDAPHCOHB;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x18A2CC0", Offset = "0x18A12C0", VA = "0x1818A2CC0")]
			static NLEBGFOIMHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class GOPDLPGOPMF
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo IAAMNKAPKLB;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo PJMKMENPPEB;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo KCKBPIIKOKB;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo JOFCKJJNFGN;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo PHJAJBGCDDK;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo NGPGFIEGPHJ;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo JKGICOGIKMK;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo AODAONCFGIB;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo NOOOPMEMJBP;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo CDLMJAHIGDH;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo FFEONLJMEAE;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo LICFOHLPKCN;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo MBGLFFLFOMO;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo GAMHEMLJMKL;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x18A0770", Offset = "0x189ED70", VA = "0x1818A0770")]
		public static MethodInfo HGEKGOKJCDE(Type MCLMFJEAHEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x18A0500", Offset = "0x189EB00", VA = "0x1818A0500")]
		public static MethodInfo FFFJLEEKFAK(Type MCLMFJEAHEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x18A0A40", Offset = "0x189F040", VA = "0x1818A0A40")]
		public static MethodInfo IIHNBGHGGNH(Type MCLMFJEAHEC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class EBBBMNHDOLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<IFOAMENKCOO, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public EBBBMNHDOLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class ENCGPIBKPGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public EBBBMNHDOLH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public ENCGPIBKPGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x189BBF0", Offset = "0x189A1F0", VA = "0x18189BBF0")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x189BC30", Offset = "0x189A230", VA = "0x18189BC30")]
		internal bool <BuildType>b__2(int index, IFOAMENKCOO member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class EGKIOEJOBPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public EBBBMNHDOLH CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public EGKIOEJOBPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x189B6D0", Offset = "0x1899CD0", VA = "0x18189B6D0")]
		internal bool <BuildType>b__3(int index, IFOAMENKCOO member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class KCAGOEIPALE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Func<string, string> nameMutator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public List<object> serializeCustomFormatters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public List<object> deserializeCustomFormatters;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public KCAGOEIPALE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x189D210", Offset = "0x189B810", VA = "0x18189D210")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class IAMNGCLNEGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public IAMNGCLNEGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x189D1B0", Offset = "0x189B7B0", VA = "0x18189D1B0")]
		internal bool <BuildAnonymousFormatter>b__2(IFOAMENKCOO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class KJAAJACMMNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public KCAGOEIPALE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public KJAAJACMMNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x189FAB0", Offset = "0x189E0B0", VA = "0x18189FAB0")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x189FAC0", Offset = "0x189E0C0", VA = "0x18189FAC0")]
		internal bool <BuildAnonymousFormatter>b__6(int index, IFOAMENKCOO member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class FHCCEPBLDOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public KCAGOEIPALE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public FHCCEPBLDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x189C120", Offset = "0x189A720", VA = "0x18189C120")]
		internal bool <BuildAnonymousFormatter>b__7(int index, IFOAMENKCOO member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class LOEEDBODDJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public LOEEDBODDJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F00", Offset = "0x8D1500", VA = "0x1808D2F00")]
		internal Label <BuildSerialize>b__1(IFOAMENKCOO _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class AIPGCKEADEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public PAMMMIPIMPG[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, IFOAMENKCOO, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public FFEAOMNFHOI argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public FFEAOMNFHOI argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public AIPGCKEADEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x1898F80", Offset = "0x1897580", VA = "0x181898F80")]
		internal PAMMMIPIMPG <BuildDeserialize>b__0(IFOAMENKCOO item)
		{
			return default(PAMMMIPIMPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class KLALEILOOMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AIPGCKEADEC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public KLALEILOOMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x189FC60", Offset = "0x189E260", VA = "0x18189FC60")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x189FF10", Offset = "0x189E510", VA = "0x18189FF10")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class OFEHFELGBJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public IFOAMENKCOO item;

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public OFEHFELGBJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x18A04F0", Offset = "0x189EAF0", VA = "0x1818A04F0")]
		internal bool <EmitNewObject>b__0(PAMMMIPIMPG x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class MAJAJDLBMIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public IFOAMENKCOO item;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public MAJAJDLBMIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x18A04F0", Offset = "0x189EAF0", VA = "0x1818A04F0")]
		internal bool <EmitNewObject>b__2(PAMMMIPIMPG x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex OPMMKLKJBBP;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int CANNABEHCFH;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> JMAABJNNDCM;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> JGGNHLEHEJM;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3A7EA40", Offset = "0x3A7D040", VA = "0x183A7EA40")]
	public static object PKNHOJGCDMC<T>(IBELCNMFHJB POKEBAHAKOL, OLGPDOHAJDG LIIGMHMLBHA, Func<string, string> BPDELMJNELN, bool OHLDEPKBDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3A74080", Offset = "0x3A72680", VA = "0x183A74080")]
	public static object AMMJFPLENFL<T>(OLGPDOHAJDG LIIGMHMLBHA, Func<string, string> BPDELMJNELN, bool OHLDEPKBDNJ, bool GJDLJHDGNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x11EB2D0", Offset = "0x11E98D0", VA = "0x1811EB2D0")]
	private static TypeInfo GELEEGPAPDH(IBELCNMFHJB POKEBAHAKOL, Type MCLMFJEAHEC, Func<string, string> BPDELMJNELN, bool OHLDEPKBDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x11E9280", Offset = "0x11E7880", VA = "0x1811E9280")]
	public static object FGGAFNJAJBH(Type MCLMFJEAHEC, Func<string, string> BPDELMJNELN, bool OHLDEPKBDNJ, bool GJDLJHDGNIC, bool PCLMBAINJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x11E8780", Offset = "0x11E6D80", VA = "0x1811E8780")]
	private static Dictionary<IFOAMENKCOO, FieldInfo> AAAOACDNCKA(TypeBuilder JPMPOFBDABO, BJNFMKPBJKP LLEGACMOBNC, ConstructorInfo BOIFLMIGBFI, FieldBuilder ELIDDIBLOIH, ILGenerator CMJHMCJLHOK, bool OHLDEPKBDNJ, bool MJKFHBCHKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x11F11B0", Offset = "0x11EF7B0", VA = "0x1811F11B0")]
	private static Dictionary<IFOAMENKCOO, FieldInfo> OCGNGCBHNGI(TypeBuilder JPMPOFBDABO, BJNFMKPBJKP LLEGACMOBNC, ILGenerator CMJHMCJLHOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x11EBD60", Offset = "0x11EA360", VA = "0x1811EBD60")]
	private static void IDHIMFBDJCF(Type MCLMFJEAHEC, BJNFMKPBJKP LLEGACMOBNC, ILGenerator CMJHMCJLHOK, Action LLOMHFMFKFC, Func<int, IFOAMENKCOO, bool> MHNAFJGOGLF, bool OHLDEPKBDNJ, bool MJKFHBCHKEG, int OPLAOOMIBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x11EDBA0", Offset = "0x11EC1A0", VA = "0x1811EDBA0")]
	private static void IOMNHJELCOG(TypeInfo MCLMFJEAHEC, IFOAMENKCOO BALNNNGOGIF, ILGenerator CMJHMCJLHOK, int EBBLFLFCHFB, Func<int, IFOAMENKCOO, bool> MHNAFJGOGLF, FFEAOMNFHOI IEEJJNDPOHK, FFEAOMNFHOI LDBEKNBKHCD, FFEAOMNFHOI EPMDOPDPDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x11EE0F0", Offset = "0x11EC6F0", VA = "0x1811EE0F0")]
	private static void KJLDCICKDOF(Type MCLMFJEAHEC, BJNFMKPBJKP LLEGACMOBNC, ILGenerator CMJHMCJLHOK, Func<int, IFOAMENKCOO, bool> MHNAFJGOGLF, bool BFCAMKOJGBM, int OPLAOOMIBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x11EAE00", Offset = "0x11E9400", VA = "0x1811EAE00")]
	private static void FNIEDLEDEBH(ILGenerator CMJHMCJLHOK, PAMMMIPIMPG LLEGACMOBNC, int EBBLFLFCHFB, Func<int, IFOAMENKCOO, bool> MHNAFJGOGLF, FFEAOMNFHOI ILDGEJAOOHJ, FFEAOMNFHOI EPMDOPDPDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x11F0240", Offset = "0x11EE840", VA = "0x1811F0240")]
	private static LocalBuilder NHKEFJJCFCP(ILGenerator CMJHMCJLHOK, Type MCLMFJEAHEC, BJNFMKPBJKP LLEGACMOBNC, PAMMMIPIMPG[] MOHOFDFLPJJ, bool DJFAKAHEPBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x11EFB40", Offset = "0x11EE140", VA = "0x1811EFB40")]
	private static bool KPNJNBAKDKI(ConstructorInfo CGBEAPFNACB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x11E90D0", Offset = "0x11E76D0", VA = "0x1811E90D0")]
	private static bool CHNIAKPBKMH(Type MCLMFJEAHEC, out Type EGMEHOFBMPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void AKBJDGGDHBH<T>(byte[][] ELIDDIBLOIH, object[] HPGOEBMODHC, ref NADLEEAJGKF IEEJJNDPOHK, T MAKFNMHIJIF, OLGPDOHAJDG KMBIIPHHOMB);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T DEIHKICMOFH<T>(object[] HPGOEBMODHC, ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG KMBIIPHHOMB);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class POONGPGEPNI<T> : global::AMLJDOHMGLI<T>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] ELIDDIBLOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] KKMDHOKJAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] LEMCLHILLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly global::AKBJDGGDHBH<T> LJAGGIBNJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly global::DEIHKICMOFH<T> OCPLBEBMNGD;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3355230", Offset = "0x3353830", VA = "0x183355230")]
	public POONGPGEPNI(byte[][] ELIDDIBLOIH, object[] KKMDHOKJAIG, object[] LEMCLHILLMH, global::AKBJDGGDHBH<T> LJAGGIBNJPB, global::DEIHKICMOFH<T> OCPLBEBMNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3355150", Offset = "0x3353750", VA = "0x183355150", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3355080", Offset = "0x3353680", VA = "0x183355080", Slot = "5")]
	public T FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class EMBJFLGFJKN : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class KJDMCPIHFEC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x345A3B0", Offset = "0x34589B0", VA = "0x18345A3B0")]
		static KJDMCPIHFEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private EMBJFLGFJKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class EDNGNPOHPHL : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class PKNHNMFBLBA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D1A0", Offset = "0x3D9B7A0", VA = "0x183D9D1A0")]
		static PKNHNMFBLBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private EDNGNPOHPHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class HNBCBLOACKA
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly OLGPDOHAJDG[] HEBNAKHJJPO;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class ICFNKMFHLNG : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class GCBCAOMBEJP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x37C45C0", Offset = "0x37C2BC0", VA = "0x1837C45C0")]
		static GCBCAOMBEJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class MHFBMDFJJIG : OLGPDOHAJDG
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class GDBHNHOGDKE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x37C6D90", Offset = "0x37C5390", VA = "0x1837C6D90")]
			static GDBHNHOGDKE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		private MHFBMDFJJIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
		public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly global::AMLJDOHMGLI<object> CLCPDNAIOLJ;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private ICFNKMFHLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class PLLPFIGAIED : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class PAPMMFGPIPJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x47D0BB0", Offset = "0x47CF1B0", VA = "0x1847D0BB0")]
		static PAPMMFGPIPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class NCIGCBLFEBG : OLGPDOHAJDG
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class MMPOHOOKJDF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x3B96250", Offset = "0x3B94850", VA = "0x183B96250")]
			static MMPOHOOKJDF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		private NCIGCBLFEBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
		public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly global::AMLJDOHMGLI<object> CLCPDNAIOLJ;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private PLLPFIGAIED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class HPGMMJCOJAB : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class NLCEIILNONN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3954390", Offset = "0x3952990", VA = "0x183954390")]
		static NLCEIILNONN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class GODDEBJIELC : OLGPDOHAJDG
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class FAPHAPGGLKI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x39267E0", Offset = "0x3924DE0", VA = "0x1839267E0")]
			static FAPHAPGGLKI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		private GODDEBJIELC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
		public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly global::AMLJDOHMGLI<object> CLCPDNAIOLJ;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private HPGMMJCOJAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class JGKDFNPKNGN : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class IPHIMOAGEDJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x32901B0", Offset = "0x328E7B0", VA = "0x1832901B0")]
		static IPHIMOAGEDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class KIINEGCLAOE : OLGPDOHAJDG
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class EKLPFMAFPEN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x3332CF0", Offset = "0x33312F0", VA = "0x183332CF0")]
			static EKLPFMAFPEN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		private KIINEGCLAOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
		public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly global::AMLJDOHMGLI<object> CLCPDNAIOLJ;

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private JGKDFNPKNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class KPAIIMDPFBH : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class BMBENOGJANI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3FA9280", Offset = "0x3FA7880", VA = "0x183FA9280")]
		static BMBENOGJANI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class KLHGJLKJLEN : OLGPDOHAJDG
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class JOBLBNPOONC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3EF9040", Offset = "0x3EF7640", VA = "0x183EF9040")]
			static JOBLBNPOONC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		private KLHGJLKJLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
		public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly global::AMLJDOHMGLI<object> CLCPDNAIOLJ;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private KPAIIMDPFBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class IANIIDEHBBI : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class HJLLGNJHEHB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x46E0A30", Offset = "0x46DF030", VA = "0x1846E0A30")]
		static HJLLGNJHEHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class DHJBLGDOAEP : OLGPDOHAJDG
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class LKKHMCODKPK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x304CD90", Offset = "0x304B390", VA = "0x18304CD90")]
			static LKKHMCODKPK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		private DHJBLGDOAEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
		public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly global::AMLJDOHMGLI<object> CLCPDNAIOLJ;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private IANIIDEHBBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class PICHBALMKFN : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class DIIHOGPKEHI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3420F20", Offset = "0x341F520", VA = "0x183420F20")]
		static DIIHOGPKEHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class FMHGGHHLNEP : OLGPDOHAJDG
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class GKGJNJBKINE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x407D870", Offset = "0x407BE70", VA = "0x18407D870")]
			static GKGJNJBKINE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		private FMHGGHHLNEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
		public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly global::AMLJDOHMGLI<object> CLCPDNAIOLJ;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private PICHBALMKFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class ONPKKKDCPDK : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class IPLMOLJINGP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3297610", Offset = "0x3295C10", VA = "0x183297610")]
		static IPLMOLJINGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class BKEKGHGPPBK : OLGPDOHAJDG
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class NFNLNBECOAO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x3947230", Offset = "0x3945830", VA = "0x183947230")]
			static NFNLNBECOAO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		private BKEKGHGPPBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
		public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly global::AMLJDOHMGLI<object> CLCPDNAIOLJ;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private ONPKKKDCPDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class PPMNPKGCJNL : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class CNIJFBLADHA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x46893E0", Offset = "0x46879E0", VA = "0x1846893E0")]
		static CNIJFBLADHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class FAPHPNFHPNK : OLGPDOHAJDG
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class MHLLLGNJOCM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x3B44AD0", Offset = "0x3B430D0", VA = "0x183B44AD0")]
			static MHLLLGNJOCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		private FAPHPNFHPNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
		public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly global::AMLJDOHMGLI<object> CLCPDNAIOLJ;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private PPMNPKGCJNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class PNNOFBBLGBI : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class AEEEJHGKCIE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3E16080", Offset = "0x3E14680", VA = "0x183E16080")]
		static AEEEJHGKCIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class KOHEJGFDADD : OLGPDOHAJDG
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class NDCAMMOHGCM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x3169860", Offset = "0x3167E60", VA = "0x183169860")]
			static NDCAMMOHGCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		private KOHEJGFDADD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
		public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly global::AMLJDOHMGLI<object> CLCPDNAIOLJ;

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private PNNOFBBLGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class PFLKMLPDBJM : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class PKJINGEMJDO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3D9AD30", Offset = "0x3D99330", VA = "0x183D9AD30")]
		static PKJINGEMJDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class PPGNGEGCADL : OLGPDOHAJDG
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class JAKHLHLOBMC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x3DB5340", Offset = "0x3DB3940", VA = "0x183DB5340")]
			static JAKHLHLOBMC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		private PPGNGEGCADL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
		public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly global::AMLJDOHMGLI<object> CLCPDNAIOLJ;

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private PFLKMLPDBJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class IMMNIFIMMGI : OLGPDOHAJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class AEELCBAEFFF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3E203D0", Offset = "0x3E1E9D0", VA = "0x183E203D0")]
		static AEELCBAEFFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class GDICNPAFIFG : OLGPDOHAJDG
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class PCDLKGEBBIN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly global::AMLJDOHMGLI<T> OMEGIKGPCIC;

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x47D6E60", Offset = "0x47D5460", VA = "0x1847D6E60")]
			static PCDLKGEBBIN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		private GDICNPAFIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
		public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly global::AMLJDOHMGLI<object> CLCPDNAIOLJ;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	private IMMNIFIMMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x27D38F0", Offset = "0x27D1EF0", VA = "0x1827D38F0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct BIMCCMIHDOH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] LHJGEBEPCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int DAPJFJMMFBP;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0BA0", Offset = "0x3F9F1A0", VA = "0x183FA0BA0")]
	public BIMCCMIHDOH(int OBNABJCFIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0760", Offset = "0x3F9ED60", VA = "0x183FA0760")]
	public void MFMCNFFMIAP(T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3FA06D0", Offset = "0x3F9ECD0", VA = "0x183FA06D0")]
	public T[] EGJGLNFOKNO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class GHKPOCCOAMK : global::BLONFAEJJNB<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly GHKPOCCOAMK MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x16F6F50", Offset = "0x16F5550", VA = "0x1816F6F50")]
	public GHKPOCCOAMK(int LCDGPJFKJPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class BLONFAEJJNB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int LCDGPJFKJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object DHOCKEIFBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int EBBLFLFCHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] MPIGIGDGACI;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3FA8830", Offset = "0x3FA6E30", VA = "0x183FA8830")]
	public BLONFAEJJNB(int LCDGPJFKJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3FA75F0", Offset = "0x3FA5BF0", VA = "0x183FA75F0")]
	public T[] HCPJDJDHODP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3FA77E0", Offset = "0x3FA5DE0", VA = "0x183FA77E0")]
	public void IACONLNJNIC(T[] HEONDDEAIBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class GBDCNECDJKO : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class NNICOABICHJ : IComparable<NNICOABICHJ>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class MJPLKOHMPCO : IEnumerable<NNICOABICHJ>, IEnumerable, IEnumerator<NNICOABICHJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private NNICOABICHJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public NNICOABICHJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private NNICOABICHJ System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F4")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F6")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x7BB650", Offset = "0x7B9C50", VA = "0x1807BB650")]
			[DebuggerHidden]
			public MJPLKOHMPCO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x18A23A0", Offset = "0x18A09A0", VA = "0x1818A23A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x18A24D0", Offset = "0x18A0AD0", VA = "0x1818A24D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x18A2430", Offset = "0x18A0A30", VA = "0x1818A2430", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NNICOABICHJ> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x18A2430", Offset = "0x18A0A30", VA = "0x1818A2430", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class IOCLCEAMLIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public IOCLCEAMLIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x8D2F00", Offset = "0x8D1500", VA = "0x1808D2F00")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x8D2F00", Offset = "0x8D1500", VA = "0x1808D2F00")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly NNICOABICHJ[] OGKOMOHKIHK;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] JFDJNHCNPEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong LLHJHGGBGGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int OIHHNPGGOMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string EOKNIMPGNHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private NNICOABICHJ[] LAJIBKENJMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] PBEFECCAECG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int FPLNDBJJHMM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool LDOFFKLHDLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x18A3960", Offset = "0x18A1F60", VA = "0x1818A3960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x18A4D60", Offset = "0x18A3360", VA = "0x1818A4D60")]
		public NNICOABICHJ(ulong AIGAKEKDKHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x18A3BE0", Offset = "0x18A21E0", VA = "0x1818A3BE0")]
		public NNICOABICHJ MFMCNFFMIAP(ulong AIGAKEKDKHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x18A3B90", Offset = "0x18A2190", VA = "0x1818A3B90")]
		public NNICOABICHJ MFMCNFFMIAP(ulong AIGAKEKDKHM, int MAKFNMHIJIF, string EOKNIMPGNHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x18A3970", Offset = "0x18A1F70", VA = "0x1818A3970")]
		public NNICOABICHJ FLJMHMGMFEK(byte[] GODDPHBMKAO, ref int ADDILPEFEHP, ref int DEMLHIHNHGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x18A38E0", Offset = "0x18A1EE0", VA = "0x1818A38E0")]
		internal static int EOJDIFJMOPK(ulong[] HEONDDEAIBL, int EBBLFLFCHFB, int JKABHKIANJL, ulong MAKFNMHIJIF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x18A38B0", Offset = "0x18A1EB0", VA = "0x1818A38B0", Slot = "4")]
		public int CompareTo(NNICOABICHJ OANENNOJEBB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x18A3B20", Offset = "0x18A2120", VA = "0x1818A3B20")]
		[IteratorStateMachine(typeof(MJPLKOHMPCO))]
		public IEnumerable<NNICOABICHJ> LIBHCAAGHCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x18A4B90", Offset = "0x18A3190", VA = "0x1818A4B90")]
		public void NKFILAGBNAG(ILGenerator CMJHMCJLHOK, LocalBuilder GODDPHBMKAO, LocalBuilder DEMLHIHNHGM, LocalBuilder AIGAKEKDKHM, Action<KeyValuePair<string, int>> OEDLMDJPHGA, Action OCELLLNEBML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x18A3EA0", Offset = "0x18A24A0", VA = "0x1818A3EA0")]
		private static void MJCJBENJPAM(ILGenerator CMJHMCJLHOK, LocalBuilder GODDPHBMKAO, LocalBuilder DEMLHIHNHGM, LocalBuilder AIGAKEKDKHM, Action<KeyValuePair<string, int>> OEDLMDJPHGA, Action OCELLLNEBML, NNICOABICHJ[] LAJIBKENJMO, int FPLNDBJJHMM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class KCKIBHOIJBA : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private IEnumerable<NNICOABICHJ> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<NNICOABICHJ> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<NNICOABICHJ> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private NNICOABICHJ <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x776CA0", Offset = "0x7752A0", VA = "0x180776CA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x189D7B0", Offset = "0x189BDB0", VA = "0x18189D7B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x776EB0", Offset = "0x7754B0", VA = "0x180776EB0")]
		[DebuggerHidden]
		public KCKIBHOIJBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x189D800", Offset = "0x189BE00", VA = "0x18189D800", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x189D270", Offset = "0x189B870", VA = "0x18189D270", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x189D8E0", Offset = "0x189BEE0", VA = "0x18189D8E0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x189D930", Offset = "0x189BF30", VA = "0x18189D930")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x189D770", Offset = "0x189BD70", VA = "0x18189D770", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x189D6D0", Offset = "0x189BCD0", VA = "0x18189D6D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x189D6D0", Offset = "0x189BCD0", VA = "0x18189D6D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly NNICOABICHJ COMPFMNMPEI;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x11FABB0", Offset = "0x11F91B0", VA = "0x1811FABB0")]
	public GBDCNECDJKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x11FAA00", Offset = "0x11F9000", VA = "0x1811FAA00")]
	public void MFMCNFFMIAP(byte[] PPJLGCLGPJE, int MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x11FA8D0", Offset = "0x11F8ED0", VA = "0x1811FA8D0")]
	public bool JDAHANPANHE(ArraySegment<byte> AIGAKEKDKHM, out int MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x11FAB20", Offset = "0x11F9120", VA = "0x1811FAB20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x11FA630", Offset = "0x11F8C30", VA = "0x1811FA630")]
	private static void IJLAMJPPGMG(IEnumerable<NNICOABICHJ> LAJIBKENJMO, StringBuilder CCLNHPOEGCA, int IFJOKNDLBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x11FA580", Offset = "0x11F8B80", VA = "0x1811FA580", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x11FA580", Offset = "0x11F8B80", VA = "0x1811FA580", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x11FA990", Offset = "0x11F8F90", VA = "0x1811FA990")]
	[IteratorStateMachine(typeof(KCKIBHOIJBA))]
	private static IEnumerable<KeyValuePair<string, int>> JIPCDODMEHD(IEnumerable<NNICOABICHJ> LAJIBKENJMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x11FA550", Offset = "0x11F8B50", VA = "0x1811FA550")]
	public void BDLGABBKNKD(ILGenerator CMJHMCJLHOK, LocalBuilder GODDPHBMKAO, LocalBuilder DEMLHIHNHGM, LocalBuilder AIGAKEKDKHM, Action<KeyValuePair<string, int>> OEDLMDJPHGA, Action OCELLLNEBML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class NOJNGFNDEOM
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo NFNJPMKAPLD;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x1709A50", Offset = "0x1708050", VA = "0x181709A50")]
	public static ulong JKDHKJKOONK(byte[] PPJLGCLGPJE, ref int ADDILPEFEHP, ref int DEMLHIHNHGM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class PKFDHKCDGHM
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x18A6C10", Offset = "0x18A5210", VA = "0x1818A6C10")]
	public static void OLOLAGONDMO(ref byte[] PPJLGCLGPJE, int ADDILPEFEHP, int BLLNGOIDILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x18A6B00", Offset = "0x18A5100", VA = "0x1818A6B00")]
	public static void JNMGIBMEIOK(ref byte[] HEONDDEAIBL, int PJNHBAIDLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x18A6D50", Offset = "0x18A5350", VA = "0x1818A6D50")]
	public static byte[] OOBPNEDGINM(byte[] EIAMEKHGGAJ, int PJNHBAIDLOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class CGCOODDFDMP
{
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x11F2440", Offset = "0x11F0A40", VA = "0x1811F2440")]
	public static bool PEGCDPIHGIH(byte[] NILLCLJNGGI, int MIFDPMJAFPJ, int CLEECMLCEBA, byte[] NGJMECAJFLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class HGAEACDDEIG<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct MDKPMKHHOFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] LLHJHGGBGGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T OIHHNPGGOMC;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3B3D640", Offset = "0x3B3BC40", VA = "0x183B3D640", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class EPPBENAIFAH : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public global::HGAEACDDEIG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private MDKPMKHHOFN[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private MDKPMKHHOFN[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x776CA0", Offset = "0x7752A0", VA = "0x180776CA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x2297440", Offset = "0x2295A40", VA = "0x182297440", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2297590", Offset = "0x2295B90", VA = "0x182297590")]
		[DebuggerHidden]
		public EPPBENAIFAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x334A990", Offset = "0x3348F90", VA = "0x18334A990", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x334AC30", Offset = "0x3349230", VA = "0x18334AC30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly MDKPMKHHOFN[][] BNKOKGFLPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong IACMFMDEHAI;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x3B086C0", Offset = "0x3B06CC0", VA = "0x183B086C0")]
	public HGAEACDDEIG(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3B086F0", Offset = "0x3B06CF0", VA = "0x183B086F0")]
	public HGAEACDDEIG(int FHGNFGIEADL, float LGNIFOODLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3B07D70", Offset = "0x3B06370", VA = "0x183B07D70")]
	public void MFMCNFFMIAP(byte[] AIGAKEKDKHM, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3B061A0", Offset = "0x3B047A0", VA = "0x183B061A0")]
	private bool INHDNHEEEFI(byte[] AIGAKEKDKHM, T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x3B04150", Offset = "0x3B02750", VA = "0x183B04150")]
	public bool IDEDABPJLGL(ArraySegment<byte> AIGAKEKDKHM, out T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x3B02380", Offset = "0x3B00980", VA = "0x183B02380")]
	private static ulong BDPPPICAIHN(byte[] FBHIPILAOBE, int ADDILPEFEHP, int FPLNDBJJHMM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x3B07910", Offset = "0x3B05F10", VA = "0x183B07910")]
	private static int MFFHFOHJCPH(int KDPBEKDPKLC, float LGNIFOODLEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x3B023E0", Offset = "0x3B009E0", VA = "0x183B023E0", Slot = "4")]
	[IteratorStateMachine(typeof(global::HGAEACDDEIG<>.EPPBENAIFAH))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x3340260", Offset = "0x333E860", VA = "0x183340260", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class OECBPBHIPIE : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] CIHLIGDEHLA;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] JFCFELMLOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int AJLPJEGLIKG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool HGJIDGDFEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x170C440", Offset = "0x170AA40", VA = "0x18170C440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x170C5B0", Offset = "0x170ABB0", VA = "0x18170C5B0")]
	static OECBPBHIPIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x170C830", Offset = "0x170AE30", VA = "0x18170C830")]
	public OECBPBHIPIE(byte[] KLGIPPDLHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x170C490", Offset = "0x170AA90", VA = "0x18170C490")]
	public OpCode OBNNJBODEFJ()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct KCDEOLKDJHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid OIHHNPGGOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte EFFHLOPNGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte GCODJJMBKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte JGMCIHACKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte CDLDLGHAICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte OOHKADKNDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte HMDLDCJELPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte HLBFHBAODOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte LCOGPKDMNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte EHLDNPEAPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte LKNPBHAPJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte FDBAFKAODHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte MBIIJKLEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte LFKKIANELIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte BEKNABNJBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte LGDLHBDEEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte BPKNNLLAMNI;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] IKEOAAMMIDH;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] NNGHOGAGPAO;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x1701BE0", Offset = "0x17001E0", VA = "0x181701BE0")]
	public KCDEOLKDJHM(ref Guid MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x1700790", Offset = "0x16FED90", VA = "0x181700790")]
	public KCDEOLKDJHM(ref ArraySegment<byte> CBMJJGCKMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x1700600", Offset = "0x16FEC00", VA = "0x181700600")]
	private static byte NHDEPCMECAP(byte[] PPJLGCLGPJE, int LCDIKANDMDG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x16FF1A0", Offset = "0x16FD7A0", VA = "0x1816FF1A0")]
	private static byte IFPGNLFLJOA(byte LKLEFAIICIC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x16FF2B0", Offset = "0x16FD8B0", VA = "0x1816FF2B0")]
	public void ILGFNCIGIKC(byte[] DICKNCEHGPP, int ADDILPEFEHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class JEDEFDCIFMM
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x16FBD20", Offset = "0x16FA320", VA = "0x1816FBD20")]
	public static bool LAKDPHAOAJK(byte KOIHHAIHBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x16FBCB0", Offset = "0x16FA2B0", VA = "0x1816FBCB0")]
	public static bool JMFBDHPKPOJ(byte KOIHHAIHBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x16FC100", Offset = "0x16FA700", VA = "0x1816FC100")]
	public static sbyte OEJIODCFHFI(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x16FC010", Offset = "0x16FA610", VA = "0x1816FC010")]
	public static short MNOELAFOIJN(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x16FBD30", Offset = "0x16FA330", VA = "0x1816FBD30")]
	public static int MAMJGCIBBDI(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x16FA5A0", Offset = "0x16F8BA0", VA = "0x1816FA5A0")]
	public static long AGKJMAEDDIA(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x16FB280", Offset = "0x16F9880", VA = "0x1816FB280")]
	public static byte ALLOGFBOPJE(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x16FB360", Offset = "0x16F9960", VA = "0x1816FB360")]
	public static ushort DJNLHIBIHAN(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x16FC080", Offset = "0x16FA680", VA = "0x1816FC080")]
	public static uint NHJCJHDIGJH(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x16FB3D0", Offset = "0x16F99D0", VA = "0x1816FB3D0")]
	public static ulong FJLNLLKGCDA(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x16FB2F0", Offset = "0x16F98F0", VA = "0x1816FB2F0")]
	public static float CBDLDEMIBAL(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x16FC170", Offset = "0x16FA770", VA = "0x1816FC170")]
	public static double OJFCEJPLDPM(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x16FB4E0", Offset = "0x16F9AE0", VA = "0x1816FB4E0")]
	public static int JHCKALKHKFD(ref byte[] DICKNCEHGPP, int ADDILPEFEHP, ulong MAKFNMHIJIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x16FA650", Offset = "0x16F8C50", VA = "0x1816FA650")]
	public static int AGLANPICECC(ref byte[] DICKNCEHGPP, int ADDILPEFEHP, long MAKFNMHIJIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x16FBDA0", Offset = "0x16FA3A0", VA = "0x1816FBDA0")]
	public static bool MCFMJGNKPCJ(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class CAONBHCMOCE
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class NDGPIGDDAGM : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private PropertyInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private IEnumerator<PropertyInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		PropertyInfo IEnumerator<PropertyInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7BB650", Offset = "0x7B9C50", VA = "0x1807BB650")]
		[DebuggerHidden]
		public NDGPIGDDAGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x18A2B30", Offset = "0x18A1130", VA = "0x1818A2B30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x18A26D0", Offset = "0x18A0CD0", VA = "0x1818A26D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x18A2C20", Offset = "0x18A1220", VA = "0x1818A2C20")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x18A2C70", Offset = "0x18A1270", VA = "0x1818A2C70")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x18A2AF0", Offset = "0x18A10F0", VA = "0x1818A2AF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x18A2A40", Offset = "0x18A1040", VA = "0x1818A2A40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x18A2A40", Offset = "0x18A1040", VA = "0x1818A2A40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class GEBPAICNHPK : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private FieldInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private IEnumerator<FieldInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		FieldInfo IEnumerator<FieldInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7BB650", Offset = "0x7B9C50", VA = "0x1807BB650")]
		[DebuggerHidden]
		public GEBPAICNHPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x189CAA0", Offset = "0x189B0A0", VA = "0x18189CAA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x189C640", Offset = "0x189AC40", VA = "0x18189C640", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x189CB90", Offset = "0x189B190", VA = "0x18189CB90")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x189CBE0", Offset = "0x189B1E0", VA = "0x18189CBE0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x189CA60", Offset = "0x189B060", VA = "0x18189CA60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x189C9B0", Offset = "0x189AFB0", VA = "0x18189C9B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x189C9B0", Offset = "0x189AFB0", VA = "0x18189C9B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x11E8630", Offset = "0x11E6C30", VA = "0x1811E8630")]
	public static bool MOCHLHJENHC(this TypeInfo MCLMFJEAHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x11E8480", Offset = "0x11E6A80", VA = "0x1811E8480")]
	public static bool JPHPGOJJCIL(this TypeInfo MCLMFJEAHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x11E83B0", Offset = "0x11E69B0", VA = "0x1811E83B0")]
	public static IEnumerable<PropertyInfo> DJAHMPABLDD(this Type MCLMFJEAHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x11E85A0", Offset = "0x11E6BA0", VA = "0x1811E85A0")]
	[IteratorStateMachine(typeof(NDGPIGDDAGM))]
	private static IEnumerable<PropertyInfo> KBONBIOPIJC(Type MCLMFJEAHEC, HashSet<string> EMFGAMIJJAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x11E82E0", Offset = "0x11E68E0", VA = "0x1811E82E0")]
	public static IEnumerable<FieldInfo> DAAIANIPAMG(this Type MCLMFJEAHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x11E86F0", Offset = "0x11E6CF0", VA = "0x1811E86F0")]
	[IteratorStateMachine(typeof(GEBPAICNHPK))]
	private static IEnumerable<FieldInfo> PJNKPBFFOKH(Type MCLMFJEAHEC, HashSet<string> EMFGAMIJJAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class PAPAEEPLIFA
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding JGIMGAHOBBN;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class PFHCPCGJAHK
{
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x71E890", Offset = "0x71CE90", VA = "0x18071E890")]
	public static string JFNIIILAJDC(string BBFEACHCBCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x18A6590", Offset = "0x18A4B90", VA = "0x1818A6590")]
	public static string IJODMBEICHF(string BBFEACHCBCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x18A63A0", Offset = "0x18A49A0", VA = "0x1818A63A0")]
	public static string EPEMJIDCAAN(string BBFEACHCBCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class AAONIJFMFPJ<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class KIOGJLHJDDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type LLHJHGGBGGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue OIHHNPGGOMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int MDGECIAABEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public KIOGJLHJDDH MJCEALLDFPC;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x344FB60", Offset = "0x344E160", VA = "0x18344FB60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x344FAE0", Offset = "0x344E0E0", VA = "0x18344FAE0")]
		private int ICNBMEOIEJL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public KIOGJLHJDDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class BLFJMLAHMMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public BLFJMLAHMMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x792CB0", Offset = "0x7912B0", VA = "0x180792CB0")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private KIOGJLHJDDH[] BNKOKGFLPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int JLMAIAGOBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object CKPHLHMABIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float LGNIFOODLEA;

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x4279380", Offset = "0x4277980", VA = "0x184279380")]
	public AAONIJFMFPJ(int FHGNFGIEADL = 4, float LGNIFOODLEA = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x4278060", Offset = "0x4276660", VA = "0x184278060")]
	public bool FKGKAEHMBPL(Type AIGAKEKDKHM, TValue MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x4278020", Offset = "0x4276620", VA = "0x184278020")]
	public bool FKGKAEHMBPL(Type AIGAKEKDKHM, Func<Type, TValue> PEPHABGEAMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x4278560", Offset = "0x4276B60", VA = "0x184278560")]
	private bool INHDNHEEEFI(Type AIGAKEKDKHM, Func<Type, TValue> PEPHABGEAMJ, out TValue LECMNGJOLLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x4278EA0", Offset = "0x42774A0", VA = "0x184278EA0")]
	private bool PEIEDGPICCB(KIOGJLHJDDH[] BNKOKGFLPBI, Type DAMNFPONOLM, KIOGJLHJDDH MJGFMHKOBPD, Func<Type, TValue> PEPHABGEAMJ, out TValue LECMNGJOLLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x42782C0", Offset = "0x42768C0", VA = "0x1842782C0")]
	public bool IDEDABPJLGL(Type AIGAKEKDKHM, out TValue MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x4278170", Offset = "0x4276770", VA = "0x184278170")]
	public TValue GIKDDENMNIA(Type AIGAKEKDKHM, Func<Type, TValue> PEPHABGEAMJ)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x3B07910", Offset = "0x3B05F10", VA = "0x183B07910")]
	private static int MFFHFOHJCPH(int KDPBEKDPKLC, float LGNIFOODLEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4279260", Offset = "0x4277860", VA = "0x184279260")]
	private static void PGNGJHEHCHH(ref KIOGJLHJDDH OBFHICHOBMG, KIOGJLHJDDH MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x4279260", Offset = "0x4277860", VA = "0x184279260")]
	private static void PGNGJHEHCHH(ref KIOGJLHJDDH[] OBFHICHOBMG, KIOGJLHJDDH[] MAKFNMHIJIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class IBELCNMFHJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder JNNCENCKCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder PODPJGGOOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object DHOCKEIFBHC;

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x16F8F10", Offset = "0x16F7510", VA = "0x1816F8F10")]
	public TypeBuilder BPDHHPJNGMI(string NBODBMLPNJA, TypeAttributes HCLFAPPIEMP, Type LFAIGCEGCPL, Type[] HODPCFFHCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x16F8FE0", Offset = "0x16F75E0", VA = "0x1816F8FE0")]
	public IBELCNMFHJB(string OGFIIBBFPHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class DJBEOAADMBD
{
	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x11F68B0", Offset = "0x11F4EB0", VA = "0x1811F68B0")]
	private static MethodInfo CMHMNIGOHEL(LambdaExpression FLFKCKCBIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x2A40DC0", Offset = "0x2A3F3C0", VA = "0x182A40DC0")]
	public static MethodInfo FJMGBMMJEMO<T>(Expression<Func<T>> FLFKCKCBIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x2A40DC0", Offset = "0x2A3F3C0", VA = "0x182A40DC0")]
	public static MethodInfo FJMGBMMJEMO<T, TR>(Expression<Func<T, TR>> FLFKCKCBIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x2A40DC0", Offset = "0x2A3F3C0", VA = "0x182A40DC0")]
	public static MethodInfo FJMGBMMJEMO<T>(Expression<Action<T>> FLFKCKCBIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x2A40DC0", Offset = "0x2A3F3C0", VA = "0x182A40DC0")]
	public static MethodInfo FJMGBMMJEMO<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> FLFKCKCBIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x2A40DD0", Offset = "0x2A3F3D0", VA = "0x182A40DD0")]
	private static MemberInfo NHIOIBMEGIC<T>(Expression<T> CELBLIIOMDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x2A40D60", Offset = "0x2A3F360", VA = "0x182A40D60")]
	public static PropertyInfo CEMEAFLJMGP<T, TR>(Expression<Func<T, TR>> FLFKCKCBIKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct FFEAOMNFHOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int LJOFAPCHBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool MMNGCKFNIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator CMJHMCJLHOK;

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x11F8B20", Offset = "0x11F7120", VA = "0x1811F8B20")]
	public FFEAOMNFHOI(ILGenerator CMJHMCJLHOK, int LJOFAPCHBHE, bool MMNGCKFNIJL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x11F8A90", Offset = "0x11F7090", VA = "0x1811F8A90")]
	public FFEAOMNFHOI(ILGenerator CMJHMCJLHOK, int LJOFAPCHBHE, Type MCLMFJEAHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x11F8970", Offset = "0x11F6F70", VA = "0x1811F8970")]
	public void HGAAPDFKBMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class AINFFKKMKDG
{
	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x11E19C0", Offset = "0x11DFFC0", VA = "0x1811E19C0")]
	public static void GPFCLAFKGBI(this ILGenerator CMJHMCJLHOK, int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x11E1BF0", Offset = "0x11E01F0", VA = "0x1811E1BF0")]
	public static void GPFCLAFKGBI(this ILGenerator CMJHMCJLHOK, LocalBuilder HDDHEKBJGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x11E1430", Offset = "0x11DFA30", VA = "0x1811E1430")]
	public static void BAAEHGBDCFB(this ILGenerator CMJHMCJLHOK, int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x11E1660", Offset = "0x11DFC60", VA = "0x1811E1660")]
	public static void BAAEHGBDCFB(this ILGenerator CMJHMCJLHOK, LocalBuilder HDDHEKBJGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x11E1720", Offset = "0x11DFD20", VA = "0x1811E1720")]
	public static void DLMKCGBLPGL(this ILGenerator CMJHMCJLHOK, int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x11E1810", Offset = "0x11DFE10", VA = "0x1811E1810")]
	public static void DLMKCGBLPGL(this ILGenerator CMJHMCJLHOK, LocalBuilder HDDHEKBJGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x11E23B0", Offset = "0x11E09B0", VA = "0x1811E23B0")]
	public static void OENKLIGHBHM(this ILGenerator CMJHMCJLHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x11E1920", Offset = "0x11DFF20", VA = "0x1811E1920")]
	public static void EBJLODLPFPB(this ILGenerator CMJHMCJLHOK, bool MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x11E1C30", Offset = "0x11E0230", VA = "0x1811E1C30")]
	public static void IMFJPNCFPFC(this ILGenerator CMJHMCJLHOK, int MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x11E1340", Offset = "0x11DF940", VA = "0x1811E1340")]
	public static void AKIMOJHIPHA(this ILGenerator CMJHMCJLHOK, Type MCLMFJEAHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x11E2270", Offset = "0x11E0870", VA = "0x1811E2270")]
	public static void OAPIJAHHAOM(this ILGenerator CMJHMCJLHOK, Type MCLMFJEAHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x11E23C0", Offset = "0x11E09C0", VA = "0x1811E23C0")]
	public static void PNNAKLFBMNB(this ILGenerator CMJHMCJLHOK, int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x11E16A0", Offset = "0x11DFCA0", VA = "0x1811E16A0")]
	public static void DILJNAHOAGL(this ILGenerator CMJHMCJLHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x11E2180", Offset = "0x11E0780", VA = "0x1811E2180")]
	public static void LJHAAIGBEON(this ILGenerator CMJHMCJLHOK, int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x11E2080", Offset = "0x11E0680", VA = "0x1811E2080")]
	public static void KFLNKMFMBJL(this ILGenerator CMJHMCJLHOK, MethodInfo KKBIFPGOODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x11E2320", Offset = "0x11E0920", VA = "0x1811E2320")]
	public static void OBICIGOEAFA(this ILGenerator CMJHMCJLHOK, FieldInfo EDJIGPKMFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x11E1930", Offset = "0x11DFF30", VA = "0x1811E1930")]
	public static void FPHLLMPBJGN(this ILGenerator CMJHMCJLHOK, ulong MAKFNMHIJIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class IFOAMENKCOO
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class LEKMKDLHOPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public LEKMKDLHOPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x18A03E0", Offset = "0x189E9E0", VA = "0x1818A03E0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo JJDMHDIJLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo CONKAANGIAL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string FACJFEGFGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x71E880", Offset = "0x71CE80", VA = "0x18071E880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string NBFIMHBMOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x728F30", Offset = "0x727530", VA = "0x180728F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IPLGHFJKMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x16F9660", Offset = "0x16F7C60", VA = "0x1816F9660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MPEIKBLCJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8C3430", Offset = "0x8C1A30", VA = "0x1808C3430")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x9D2BB0", Offset = "0x9D11B0", VA = "0x1809D2BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool AIEGLBKLNDD
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8C3440", Offset = "0x8C1A40", VA = "0x1808C3440")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x16F9590", Offset = "0x16F7B90", VA = "0x1816F9590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type PJDKMJMOPHN
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x681C00", Offset = "0x680200", VA = "0x180681C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x77C760", Offset = "0x77AD60", VA = "0x18077C760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo ABDHCIBKNGB
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x67A0D0", Offset = "0x6786D0", VA = "0x18067A0D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D70", Offset = "0x7E4370", VA = "0x1807E5D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo DPIKBEILBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x722690", Offset = "0x720C90", VA = "0x180722690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo NMJKHDJLAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x684420", Offset = "0x682A20", VA = "0x180684420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x731D00", Offset = "0x730300", VA = "0x180731D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x16F99B0", Offset = "0x16F7FB0", VA = "0x1816F99B0")]
	protected IFOAMENKCOO(Type MCLMFJEAHEC, string NBODBMLPNJA, string CHAHHBDIPFA, bool LOLENBCPOOF, bool ICDAINBFCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x16F98A0", Offset = "0x16F7EA0", VA = "0x1816F98A0")]
	public IFOAMENKCOO(FieldInfo LLEGACMOBNC, string NBODBMLPNJA, bool GJDLJHDGNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x16F9A30", Offset = "0x16F8030", VA = "0x1816F9A30")]
	public IFOAMENKCOO(PropertyInfo LLEGACMOBNC, string NBODBMLPNJA, bool GJDLJHDGNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x16F9730", Offset = "0x16F7D30", VA = "0x1816F9730")]
	private static MethodInfo NPJMLEIPGOP(MemberInfo LLEGACMOBNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x33BEB90", Offset = "0x33BD190", VA = "0x1833BEB90")]
	public T FAGMMCJHJMN<T>(bool NMHKPEOPNLB) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x16F9670", Offset = "0x16F7C70", VA = "0x1816F9670", Slot = "4")]
	public virtual void NKHBGKDKJID(ILGenerator CMJHMCJLHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x16F95A0", Offset = "0x16F7BA0", VA = "0x1816F95A0", Slot = "5")]
	public virtual void DKFELECIFNP(ILGenerator CMJHMCJLHOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class OEJNOGBKBBO : IFOAMENKCOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string ICOCCBBOKBJ;

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x170CD40", Offset = "0x170B340", VA = "0x18170CD40")]
	public OEJNOGBKBBO(string NBODBMLPNJA, string ICOCCBBOKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x170CC80", Offset = "0x170B280", VA = "0x18170CC80", Slot = "4")]
	public override void NKHBGKDKJID(ILGenerator CMJHMCJLHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x170CC40", Offset = "0x170B240", VA = "0x18170CC40", Slot = "5")]
	public override void DKFELECIFNP(ILGenerator CMJHMCJLHOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class GGHHLOOJILA : IFOAMENKCOO
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo BDGNIJKFEGH;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo NGEMGNMNPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal FFEAOMNFHOI JONJACJEKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal FFEAOMNFHOI LDBEKNBKHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal FFEAOMNFHOI EPMDOPDPDBO;

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x16F5E20", Offset = "0x16F4420", VA = "0x1816F5E20")]
	public GGHHLOOJILA(string NBODBMLPNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x16F5800", Offset = "0x16F3E00", VA = "0x1816F5800", Slot = "4")]
	public override void NKHBGKDKJID(ILGenerator CMJHMCJLHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x16F56A0", Offset = "0x16F3CA0", VA = "0x1816F56A0", Slot = "5")]
	public override void DKFELECIFNP(ILGenerator CMJHMCJLHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x16F56E0", Offset = "0x16F3CE0", VA = "0x1816F56E0")]
	public void GMHDKPGNAMN(ILGenerator CMJHMCJLHOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class BJNFMKPBJKP
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type PJDKMJMOPHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x71E880", Offset = "0x71CE80", VA = "0x18071E880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool JNNCIFLOGLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7834A0", Offset = "0x781AA0", VA = "0x1807834A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7834B0", Offset = "0x781AB0", VA = "0x1807834B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool HABFNJAAJBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x820440", Offset = "0x81EA40", VA = "0x180820440")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x9F8690", Offset = "0x9F6C90", VA = "0x1809F8690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo BENEBDNCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x70DB30", Offset = "0x70C130", VA = "0x18070DB30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IFOAMENKCOO[] BNCBCAJGGHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x681C00", Offset = "0x680200", VA = "0x180681C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x77C760", Offset = "0x77AD60", VA = "0x18077C760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public IFOAMENKCOO[] CJMLECFAHHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x67A0D0", Offset = "0x6786D0", VA = "0x18067A0D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D70", Offset = "0x7E4370", VA = "0x1807E5D70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x11E4830", Offset = "0x11E2E30", VA = "0x1811E4830")]
	public BJNFMKPBJKP(Type MCLMFJEAHEC, Func<string, string> JCBDNGCBGOP, bool GJDLJHDGNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x11E4740", Offset = "0x11E2D40", VA = "0x1811E4740")]
	private static bool LLEGPHHHBJK(IEnumerator<ConstructorInfo> KKPNEMILKCO, ref ConstructorInfo IJFODAGBNDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct OBBBGHPOLIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong FAHPBJHMFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int CNABBHHIHOO;

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x170C430", Offset = "0x170AA30", VA = "0x18170C430")]
	public OBBBGHPOLIJ(ulong DBMIFPDCJCG, int JDLIPKOKKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x170C420", Offset = "0x170AA20", VA = "0x18170C420")]
	public void OKBPINBPKJA(ref OBBBGHPOLIJ OANENNOJEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x170C370", Offset = "0x170A970", VA = "0x18170C370")]
	public static OBBBGHPOLIJ GPBMEDNCLBL(ref OBBBGHPOLIJ IKAMJBDPPHG, ref OBBBGHPOLIJ LKLEFAIICIC)
	{
		return default(OBBBGHPOLIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x170C2E0", Offset = "0x170A8E0", VA = "0x18170C2E0")]
	public void GIKIAOHNAED(ref OBBBGHPOLIJ OANENNOJEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x170C380", Offset = "0x170A980", VA = "0x18170C380")]
	public static OBBBGHPOLIJ ODEKOCBCJCH(ref OBBBGHPOLIJ IKAMJBDPPHG, ref OBBBGHPOLIJ LKLEFAIICIC)
	{
		return default(OBBBGHPOLIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x170C250", Offset = "0x170A850", VA = "0x18170C250")]
	public void FFLFILBHPNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x170C290", Offset = "0x170A890", VA = "0x18170C290")]
	public static OBBBGHPOLIJ FFLFILBHPNA(ref OBBBGHPOLIJ IKAMJBDPPHG)
	{
		return default(OBBBGHPOLIJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct EHAIFLPLHKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] DICKNCEHGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int ADDILPEFEHP;

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x849E00", Offset = "0x848400", VA = "0x180849E00")]
	public EHAIFLPLHKN(byte[] DICKNCEHGPP, int EINGNKDKDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x11F7960", Offset = "0x11F5F60", VA = "0x1811F7960")]
	public void BMHPGGHJEAE(byte FLFBAMENJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x11F7B40", Offset = "0x11F6140", VA = "0x1811F7B40")]
	public void KBGKLICOPBA(byte[] FLFBAMENJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x11F7810", Offset = "0x11F5E10", VA = "0x1811F7810")]
	public void BEACDIAEDKB(byte[] FLFBAMENJLF, int JKABHKIANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x11F78B0", Offset = "0x11F5EB0", VA = "0x1811F78B0")]
	public void BEACDIAEDKB(byte[] FLFBAMENJLF, int LJECKBCMELA, int JKABHKIANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x11F7AC0", Offset = "0x11F60C0", VA = "0x1811F7AC0")]
	public void JOCCDODMKIH(byte KOIHHAIHBKH, int FPLNDBJJHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x11F79C0", Offset = "0x11F5FC0", VA = "0x1811F79C0")]
	public void GMFOAMFHMLD(string FLFBAMENJLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class BKDFIHOOPJC
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum DFBCEMFOJAK
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum EPOCIMJNMEK
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum NPAALBDADCN
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	[ThreadStatic]
	private static byte[] EAPFFCDCFGD;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] EKBLCINDFNA;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] PJNCNEBKDIK;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] KOEJEEFLLEK;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly NPAALBDADCN DNLJGNGHIAO;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char NPICNHLOHCH;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int HGHANLBFCDM;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int LMPFNJMKMDB;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] BJGHDINMHJK;

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x11E6A70", Offset = "0x11E5070", VA = "0x1811E6A70")]
	private static byte[] EFPAHKMPJIH(int JLMAIAGOBFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x11E6350", Offset = "0x11E4950", VA = "0x1811E6350")]
	private static byte[] DLAHLFFJEHP(int JLMAIAGOBFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x11E7580", Offset = "0x11E5B80", VA = "0x1811E7580")]
	public static int KCDBGMIDMMC(ref byte[] DICKNCEHGPP, int ADDILPEFEHP, float MAKFNMHIJIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x11E7460", Offset = "0x11E5A60", VA = "0x1811E7460")]
	public static int KCDBGMIDMMC(ref byte[] DICKNCEHGPP, int ADDILPEFEHP, double MAKFNMHIJIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x11E7AE0", Offset = "0x11E60E0", VA = "0x1811E7AE0")]
	private static bool PDDHAIEDEGG(byte[] DICKNCEHGPP, int JKABHKIANJL, ulong JCFOKFICIME, ulong DJAOOKCDEPA, ulong DEMLHIHNHGM, ulong PMOIGPHCNIB, ulong HKOGNEKGKGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x11E79C0", Offset = "0x11E5FC0", VA = "0x1811E79C0")]
	private static void OPHAMHLJGFH(uint IGDJCLNCEKA, int FELIHPCMDDO, out uint CEMPLPOIHPN, out int EHCPBFPHIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x11E6F40", Offset = "0x11E5540", VA = "0x1811E6F40")]
	private static bool JAEBNHOKBFG(OBBBGHPOLIJ PDOCAJOFLNF, OBBBGHPOLIJ JNLBJEDABNH, OBBBGHPOLIJ GFKAHIKNEOM, byte[] DICKNCEHGPP, out int JKABHKIANJL, out int IKHHFJJOGJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x11E6C60", Offset = "0x11E5260", VA = "0x1811E6C60")]
	private static bool GHMLFNJKJGO(double HIGLPPEBKMI, DFBCEMFOJAK OLBBMHHLPIG, byte[] DICKNCEHGPP, out int JKABHKIANJL, out int IKJDKJANJNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x11E6B50", Offset = "0x11E5150", VA = "0x1811E6B50")]
	private static bool GBEEIGILGLP(double HIGLPPEBKMI, DFBCEMFOJAK OLBBMHHLPIG, byte[] DICKNCEHGPP, out int JKABHKIANJL, out int FLMCCCJLBNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x11E76A0", Offset = "0x11E5CA0", VA = "0x1811E76A0")]
	private static bool KOPOBODMLJF(double MAKFNMHIJIF, ref EHAIFLPLHKN HFKLAMKHHHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x11E6430", Offset = "0x11E4A30", VA = "0x1811E6430")]
	private static bool DMMMHJOEDDN(double MAKFNMHIJIF, ref EHAIFLPLHKN HFKLAMKHHHE, EPOCIMJNMEK OLBBMHHLPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x11E7BE0", Offset = "0x11E61E0", VA = "0x1811E7BE0")]
	private static void PPLCCOLNKFL(byte[] DCJBFFJEKPP, int JKABHKIANJL, int FLMCCCJLBNJ, int EHEIGMMMBEC, ref EHAIFLPLHKN HFKLAMKHHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x11E5E20", Offset = "0x11E4420", VA = "0x1811E5E20")]
	private static void BCJPNCLKMLB(byte[] DCJBFFJEKPP, int JKABHKIANJL, int JDLIPKOKKNG, ref EHAIFLPLHKN HFKLAMKHHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x11E7830", Offset = "0x11E5E30", VA = "0x1811E7830")]
	private static bool NFIDABBDGCO(double HIGLPPEBKMI, EPOCIMJNMEK OLBBMHHLPIG, int AKAOKJDAKFE, byte[] GBJMAPINBHD, out bool DFGBDOPACOO, out int JKABHKIANJL, out int IGAJPNPGFIA)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct FLPIHLGCBAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double OECCBELLJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong GHMILDADOAP;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct EFLLHGNCBHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float FAHPBJHMFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint KADIAMPEHEK;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct DNIKOOHCJFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong ECACOGBAFBN;

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x11F71A0", Offset = "0x11F57A0", VA = "0x1811F71A0")]
	public DNIKOOHCJFG(double OECCBELLJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x11F71B0", Offset = "0x11F57B0", VA = "0x1811F71B0")]
	public DNIKOOHCJFG(OBBBGHPOLIJ OECCBELLJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x11F6C90", Offset = "0x11F5290", VA = "0x1811F6C90")]
	public OBBBGHPOLIJ DCKGCDNAEEN()
	{
		return default(OBBBGHPOLIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x11F6F00", Offset = "0x11F5500", VA = "0x1811F6F00")]
	public OBBBGHPOLIJ GFPILIIMKEL()
	{
		return default(OBBBGHPOLIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x72F7B0", Offset = "0x72DDB0", VA = "0x18072F7B0")]
	public ulong NNEFHHKICNI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x11F6C00", Offset = "0x11F5200", VA = "0x1811F6C00")]
	public double CGOEKCAMIJI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x11F7050", Offset = "0x11F5650", VA = "0x1811F7050")]
	public double LBGIIACKNLB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x11F70F0", Offset = "0x11F56F0", VA = "0x1811F70F0")]
	public int LIPBBACIPMO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x11F6BB0", Offset = "0x11F51B0", VA = "0x1811F6BB0")]
	public ulong AENNAIHPIHM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x11F7120", Offset = "0x11F5720", VA = "0x1811F7120")]
	public bool MAIKOGKLIOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x11F7150", Offset = "0x11F5750", VA = "0x1811F7150")]
	public bool MGNBGMPLNGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x11F6D60", Offset = "0x11F5360", VA = "0x1811F6D60")]
	public bool FPOIGBKBACL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x11F7170", Offset = "0x11F5770", VA = "0x1811F7170")]
	public bool NAKMEBBFKCH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x11F7030", Offset = "0x11F5630", VA = "0x1811F7030")]
	public int JPMGOLKMJJH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x11F6D90", Offset = "0x11F5390", VA = "0x1811F6D90")]
	public void GCJCGOHCADJ(out OBBBGHPOLIJ JEHCANNCAJH, out OBBBGHPOLIJ FAEHHLILMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x11F6D10", Offset = "0x11F5310", VA = "0x1811F6D10")]
	public bool DEOOLJMBGLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x11F7140", Offset = "0x11F5740", VA = "0x1811F7140")]
	public double MAKFNMHIJIF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x11F6BE0", Offset = "0x11F51E0", VA = "0x1811F6BE0")]
	public static int BPIJAOICMAB(int CNCOAGMOALJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x11F70E0", Offset = "0x11F56E0", VA = "0x1811F70E0")]
	public static double LGJPDJOELKM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x11F6F90", Offset = "0x11F5590", VA = "0x1811F6F90")]
	public static ulong IOBIOGDHMIN(OBBBGHPOLIJ BPLFIKDIFHD)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct MDHFOOCIBAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint PIEMJPDEEKE;

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x74C1E0", Offset = "0x74A7E0", VA = "0x18074C1E0")]
	public MDHFOOCIBAI(float FAHPBJHMFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x17039B0", Offset = "0x1701FB0", VA = "0x1817039B0")]
	public OBBBGHPOLIJ DCKGCDNAEEN()
	{
		return default(OBBBGHPOLIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x792CD0", Offset = "0x7912D0", VA = "0x180792CD0")]
	public uint KOCHFOCAODJ()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x1703B80", Offset = "0x1702180", VA = "0x181703B80")]
	public int LIPBBACIPMO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x1703990", Offset = "0x1701F90", VA = "0x181703990")]
	public uint AENNAIHPIHM()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x1703BA0", Offset = "0x17021A0", VA = "0x181703BA0")]
	public bool MAIKOGKLIOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x1703A50", Offset = "0x1702050", VA = "0x181703A50")]
	public void GCJCGOHCADJ(out OBBBGHPOLIJ JEHCANNCAJH, out OBBBGHPOLIJ FAEHHLILMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x1703A10", Offset = "0x1702010", VA = "0x181703A10")]
	public bool DEOOLJMBGLO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct IBKFPJCCAFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong DBMIFPDCJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short AHIOCBJLCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short IKJDKJANJNP;

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x16F90E0", Offset = "0x16F76E0", VA = "0x1816F90E0")]
	public IBKFPJCCAFM(ulong DBMIFPDCJCG, short AHIOCBJLCHN, short IKJDKJANJNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class MNCIJFHBLFA
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly IBKFPJCCAFM[] CHEHJMIJIHC;

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x17062E0", Offset = "0x17048E0", VA = "0x1817062E0")]
	public static void GNIKPDPOKBE(int IDPGABJGIHL, int IEKFJNGHAIB, out OBBBGHPOLIJ CEMPLPOIHPN, out int IKJDKJANJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x17061F0", Offset = "0x17047F0", VA = "0x1817061F0")]
	public static void CFDJAILALEO(int ILADLIDPIAH, out OBBBGHPOLIJ CEMPLPOIHPN, out int LIMPAPFNEDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct AAJJPCMHHOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] PPJLGCLGPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int LJECKBCMELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int MGPJFKCBLHF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte EAAIOELEIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x11E07C0", Offset = "0x11DEDC0", VA = "0x1811E07C0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0xC25490", Offset = "0xC23A90", VA = "0x180C25490")]
	public AAJJPCMHHOE(byte[] PPJLGCLGPJE, int LJECKBCMELA, int JKABHKIANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x792CE0", Offset = "0x7912E0", VA = "0x180792CE0")]
	public int JKABHKIANJL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x11E0800", Offset = "0x11DEE00", VA = "0x1811E0800")]
	public AAJJPCMHHOE MMFMLDCEKKP(int PHEBOHLEEKJ, int KCHHIMPOGLA)
	{
		return default(AAJJPCMHHOE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class OAOGDJFPOKO
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] PJOKFFBOGGA;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] JMFMMOLGHJG;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int LHGHKKGEEMB;

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x170AAB0", Offset = "0x17090B0", VA = "0x18170AAB0")]
	private static byte[] AOFDOAJCGBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x170B470", Offset = "0x1709A70", VA = "0x18170B470")]
	private static AAJJPCMHHOE KJOPPKMAFKO(AAJJPCMHHOE DICKNCEHGPP)
	{
		return default(AAJJPCMHHOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x170BD00", Offset = "0x170A300", VA = "0x18170BD00")]
	private static AAJJPCMHHOE NGGJGPAGDJA(AAJJPCMHHOE DICKNCEHGPP)
	{
		return default(AAJJPCMHHOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x170B140", Offset = "0x1709740", VA = "0x18170B140")]
	private static void FOMANHLCAKI(AAJJPCMHHOE DICKNCEHGPP, int JDLIPKOKKNG, byte[] BGCGGOOEPFB, out int BJGNHGFKALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x170ACC0", Offset = "0x17092C0", VA = "0x18170ACC0")]
	private static void EEFKHMNECGN(AAJJPCMHHOE DICKNCEHGPP, int JDLIPKOKKNG, byte[] FJEGAJOCFPD, int LAEDAPMLMLG, out AAJJPCMHHOE CEDLKAOONBP, out int BDJGHNLLJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x170BAE0", Offset = "0x170A0E0", VA = "0x18170BAE0")]
	private static ulong MLJCBPFHJLA(AAJJPCMHHOE DICKNCEHGPP, out int FCICOPIKGNE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x170B200", Offset = "0x1709800", VA = "0x18170B200")]
	private static void HEOADANKCDH(AAJJPCMHHOE DICKNCEHGPP, out OBBBGHPOLIJ BIDLMNEFHJM, out int BHNEKBECJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x170BDB0", Offset = "0x170A3B0", VA = "0x18170BDB0")]
	private static bool OFFCKAPPDOH(AAJJPCMHHOE CEDLKAOONBP, int JDLIPKOKKNG, out double BIDLMNEFHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x170BB70", Offset = "0x170A170", VA = "0x18170BB70")]
	private static OBBBGHPOLIJ NFLPCIKEAOA(int JDLIPKOKKNG)
	{
		return default(OBBBGHPOLIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x170B520", Offset = "0x1709B20", VA = "0x18170B520")]
	private static bool LLDJFEJNLDC(AAJJPCMHHOE DICKNCEHGPP, int JDLIPKOKKNG, out double BIDLMNEFHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x170B330", Offset = "0x1709930", VA = "0x18170B330")]
	private static bool IGKJAACBFPO(AAJJPCMHHOE CEDLKAOONBP, int JDLIPKOKKNG, out double HDMJNBAOCEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x170ABA0", Offset = "0x17091A0", VA = "0x18170ABA0")]
	public static double? CPMGPCIOHAO(AAJJPCMHHOE DICKNCEHGPP, int JDLIPKOKKNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x170AF60", Offset = "0x1709560", VA = "0x18170AF60")]
	public static float? EGKIPMDDHCI(AAJJPCMHHOE DICKNCEHGPP, int JDLIPKOKKNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct BIJCEJCICKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] DICKNCEHGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int ADDILPEFEHP;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte OIHHNPGGOMC
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x11E4500", Offset = "0x11E2B00", VA = "0x1811E4500")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x849E00", Offset = "0x848400", VA = "0x180849E00")]
	public BIJCEJCICKB(byte[] DICKNCEHGPP, int ADDILPEFEHP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x11E4670", Offset = "0x11E2C70", VA = "0x1811E4670")]
	public static BIJCEJCICKB KAOMIEDAFGL(BIJCEJCICKB DKOFBKPNBJK)
	{
		return default(BIJCEJCICKB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x11E44B0", Offset = "0x11E2AB0", VA = "0x1811E44B0")]
	public static BIJCEJCICKB CPMGNAGFNGK(BIJCEJCICKB DKOFBKPNBJK, int JKABHKIANJL)
	{
		return default(BIJCEJCICKB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x11E46D0", Offset = "0x11E2CD0", VA = "0x1811E46D0")]
	public static int NBCCFCPLHOF(BIJCEJCICKB OLACFPEGPAG, BIJCEJCICKB GLLCOOLKDAC)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x11E4650", Offset = "0x11E2C50", VA = "0x1811E4650")]
	public static bool GBIPOJBPNDJ(BIJCEJCICKB OLACFPEGPAG, BIJCEJCICKB GLLCOOLKDAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x11E4540", Offset = "0x11E2B40", VA = "0x1811E4540")]
	public static bool EOCJAGBGMLJ(BIJCEJCICKB OLACFPEGPAG, BIJCEJCICKB GLLCOOLKDAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x11E4600", Offset = "0x11E2C00", VA = "0x1811E4600")]
	public static bool GBIPOJBPNDJ(BIJCEJCICKB OLACFPEGPAG, char GLLCOOLKDAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x11E4560", Offset = "0x11E2B60", VA = "0x1811E4560")]
	public static bool EOCJAGBGMLJ(BIJCEJCICKB OLACFPEGPAG, char GLLCOOLKDAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x11E4560", Offset = "0x11E2B60", VA = "0x1811E4560")]
	public static bool EOCJAGBGMLJ(BIJCEJCICKB OLACFPEGPAG, byte GLLCOOLKDAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x11E4680", Offset = "0x11E2C80", VA = "0x1811E4680")]
	public static bool MAJJADLIHIE(BIJCEJCICKB OLACFPEGPAG, char GLLCOOLKDAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x11E45B0", Offset = "0x11E2BB0", VA = "0x1811E45B0")]
	public static bool FLEEJIFHDMB(BIJCEJCICKB OLACFPEGPAG, char GLLCOOLKDAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x11E46F0", Offset = "0x11E2CF0", VA = "0x1811E46F0")]
	public static bool NDLMCDHDFOE(BIJCEJCICKB OLACFPEGPAG, char GLLCOOLKDAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x11E4460", Offset = "0x11E2A60", VA = "0x1811E4460")]
	public static bool BLJINMMIKEO(BIJCEJCICKB OLACFPEGPAG, char GLLCOOLKDAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class FNEALAMJHOE
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] GEGLEGPJMDK;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] IBBPCNICLOD;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] PJNCNEBKDIK;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] KOEJEEFLLEK;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] MLMAANOELMB;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int HMOEEEBENLK;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] CHDAALECHNF;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int JJDHNPPHFLP;

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x11FA010", Offset = "0x11F8610", VA = "0x1811FA010")]
	private static byte[] ODOMBKDHBOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x11F9CE0", Offset = "0x11F82E0", VA = "0x1811F9CE0")]
	private static byte[] ECHFODJGDOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x11F9F50", Offset = "0x11F8550", VA = "0x1811F9F50")]
	public static double HKELMFEFMPC(byte[] DICKNCEHGPP, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x11FA220", Offset = "0x11F8820", VA = "0x1811FA220")]
	public static float PNKBNOOBFCG(byte[] DICKNCEHGPP, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x11F9B60", Offset = "0x11F8160", VA = "0x1811F9B60")]
	private static bool DLOHLHONGGG(int FBHIPILAOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x11F9E30", Offset = "0x11F8430", VA = "0x1811F9E30")]
	private static bool GNKEDODFEHE(ref BIJCEJCICKB OBFMOAOGODB, BIJCEJCICKB EAJAFIHJLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x11FA100", Offset = "0x11F8700", VA = "0x1811FA100")]
	private static bool OEBCGPKNODE(ref BIJCEJCICKB OBFMOAOGODB, BIJCEJCICKB EAJAFIHJLHG, byte[] JPIJPAFCBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x11F9DD0", Offset = "0x11F83D0", VA = "0x1811F9DD0")]
	private static bool GEMAPPEHEPJ(ref BIJCEJCICKB IHBKJCKEAHH, byte[] FLFBAMENJLF, int ADDILPEFEHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x11F9B40", Offset = "0x11F8140", VA = "0x1811F9B40")]
	private static double DAEENBOFIII(bool DFGBDOPACOO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x11F8BC0", Offset = "0x11F71C0", VA = "0x1811F8BC0")]
	private static double AFDMBLOECCH(BIJCEJCICKB OHEHJIBMMJC, int JKABHKIANJL, bool MJKINKIBFML, out int OKECELGFEEK)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class NIBIMJBILFH<T> : global::AMLJDOHMGLI<T[]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly global::BLONFAEJJNB<T> MFHFCMIPIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly HCMHKFNLMLF OOIPMPKNHAD;

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x394F480", Offset = "0x394DA80", VA = "0x18394F480")]
	public NIBIMJBILFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2297590", Offset = "0x2295B90", VA = "0x182297590")]
	public NIBIMJBILFH(HCMHKFNLMLF OOIPMPKNHAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x394F140", Offset = "0x394D740", VA = "0x18394F140", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x394E0E0", Offset = "0x394C6E0", VA = "0x18394E0E0", Slot = "5")]
	public T[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class OLLNAAEFGAG<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly global::BLONFAEJJNB<T> MFHFCMIPIGM;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class JJJCNFLMMLJ<T> : global::AMLJDOHMGLI<List<T>>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly HCMHKFNLMLF OOIPMPKNHAD;

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x394F480", Offset = "0x394DA80", VA = "0x18394F480")]
	public JJJCNFLMMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2297590", Offset = "0x2295B90", VA = "0x182297590")]
	public JJJCNFLMMLJ(HCMHKFNLMLF OOIPMPKNHAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0990", Offset = "0x3EEEF90", VA = "0x183EF0990", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, List<T> MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0380", Offset = "0x3EEE980", VA = "0x183EF0380", Slot = "5")]
	public List<T> FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class EIANHLKFFNI<TElement, TIntermediate, TEnumerator, TCollection> : global::AMLJDOHMGLI<TCollection>, HAOPHHJJNOJ where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x36BEEB0", Offset = "0x36BD4B0", VA = "0x1836BEEB0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, TCollection MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x36BECB0", Offset = "0x36BD2B0", VA = "0x1836BECB0", Slot = "5")]
	public TCollection FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator HHAKIOELJAB(TCollection CELBLIIOMDE);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate CBFHJGEFJHE();

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void MFMCNFFMIAP(ref TIntermediate JAMIHJHDKEO, int EBBLFLFCHFB, TElement MAKFNMHIJIF);

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection ADFDICGOODJ(ref TIntermediate MCLDBIFAHBO);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
	protected EIANHLKFFNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class IELPNHCIPOF<TElement, TIntermediate, TCollection> : global::EIANHLKFFNI<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x3564350", Offset = "0x3562950", VA = "0x183564350", Slot = "6")]
	protected override IEnumerator<TElement> HHAKIOELJAB(TCollection CELBLIIOMDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2354870", Offset = "0x2352E70", VA = "0x182354870")]
	protected IELPNHCIPOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class DLGJPJHKNPN<TElement, TCollection> : global::IELPNHCIPOF<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x1CCCF40", Offset = "0x1CCB540", VA = "0x181CCCF40", Slot = "9")]
	protected sealed override TCollection ADFDICGOODJ(ref TCollection MCLDBIFAHBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class MGCMBEPOFOA<TElement, TCollection> : global::DLGJPJHKNPN<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x3B41880", Offset = "0x3B3FE80", VA = "0x183B41880", Slot = "7")]
	protected override TCollection CBFHJGEFJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x3B418A0", Offset = "0x3B3FEA0", VA = "0x183B418A0", Slot = "8")]
	protected override void MFMCNFFMIAP(ref TCollection JAMIHJHDKEO, int EBBLFLFCHFB, TElement MAKFNMHIJIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class AJEIIEFFNHF<T> : global::EIANHLKFFNI<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x3B401D0", Offset = "0x3B3E7D0", VA = "0x183B401D0", Slot = "8")]
	protected override void MFMCNFFMIAP(ref LinkedList<T> JAMIHJHDKEO, int EBBLFLFCHFB, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1CCCF40", Offset = "0x1CCB540", VA = "0x181CCCF40", Slot = "9")]
	protected override LinkedList<T> ADFDICGOODJ(ref LinkedList<T> MCLDBIFAHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B140", Offset = "0x2C19740", VA = "0x182C1B140", Slot = "7")]
	protected override LinkedList<T> CBFHJGEFJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B1F0", Offset = "0x2C197F0", VA = "0x182C1B1F0", Slot = "6")]
	protected override LinkedList<T>.Enumerator HHAKIOELJAB(LinkedList<T> CELBLIIOMDE)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class AGJDIPMPBIJ<T> : global::EIANHLKFFNI<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x3B401D0", Offset = "0x3B3E7D0", VA = "0x183B401D0", Slot = "8")]
	protected override void MFMCNFFMIAP(ref Queue<T> JAMIHJHDKEO, int EBBLFLFCHFB, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B140", Offset = "0x2C19740", VA = "0x182C1B140", Slot = "7")]
	protected override Queue<T> CBFHJGEFJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x3B40180", Offset = "0x3B3E780", VA = "0x183B40180", Slot = "6")]
	protected override Queue<T>.Enumerator HHAKIOELJAB(Queue<T> CELBLIIOMDE)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x1CCCF40", Offset = "0x1CCB540", VA = "0x181CCCF40", Slot = "9")]
	protected override Queue<T> ADFDICGOODJ(ref Queue<T> MCLDBIFAHBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class MLFNAGLIOGG<T> : global::EIANHLKFFNI<T, global::BIMCCMIHDOH<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2C16A50", Offset = "0x2C15050", VA = "0x182C16A50", Slot = "8")]
	protected override void MFMCNFFMIAP(ref global::BIMCCMIHDOH<T> JAMIHJHDKEO, int EBBLFLFCHFB, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2C16A10", Offset = "0x2C15010", VA = "0x182C16A10", Slot = "7")]
	protected override global::BIMCCMIHDOH<T> CBFHJGEFJHE()
	{
		return default(global::BIMCCMIHDOH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3B40180", Offset = "0x3B3E780", VA = "0x183B40180", Slot = "6")]
	protected override Stack<T>.Enumerator HHAKIOELJAB(Stack<T> CELBLIIOMDE)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3B56EE0", Offset = "0x3B554E0", VA = "0x183B56EE0", Slot = "9")]
	protected override Stack<T> ADFDICGOODJ(ref global::BIMCCMIHDOH<T> MCLDBIFAHBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class MDPLEIABDKH<T> : global::EIANHLKFFNI<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x3B401D0", Offset = "0x3B3E7D0", VA = "0x183B401D0", Slot = "8")]
	protected override void MFMCNFFMIAP(ref HashSet<T> JAMIHJHDKEO, int EBBLFLFCHFB, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x1CCCF40", Offset = "0x1CCB540", VA = "0x181CCCF40", Slot = "9")]
	protected override HashSet<T> ADFDICGOODJ(ref HashSet<T> MCLDBIFAHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B140", Offset = "0x2C19740", VA = "0x182C1B140", Slot = "7")]
	protected override HashSet<T> CBFHJGEFJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x3B40180", Offset = "0x3B3E780", VA = "0x183B40180", Slot = "6")]
	protected override HashSet<T>.Enumerator HHAKIOELJAB(HashSet<T> CELBLIIOMDE)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class PKCPKKPNKJL<T> : global::IELPNHCIPOF<T, global::BIMCCMIHDOH<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x2C16A50", Offset = "0x2C15050", VA = "0x182C16A50", Slot = "8")]
	protected override void MFMCNFFMIAP(ref global::BIMCCMIHDOH<T> JAMIHJHDKEO, int EBBLFLFCHFB, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3D91B90", Offset = "0x3D90190", VA = "0x183D91B90", Slot = "9")]
	protected override ReadOnlyCollection<T> ADFDICGOODJ(ref global::BIMCCMIHDOH<T> MCLDBIFAHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3D91C20", Offset = "0x3D90220", VA = "0x183D91C20", Slot = "7")]
	protected override global::BIMCCMIHDOH<T> CBFHJGEFJHE()
	{
		return default(global::BIMCCMIHDOH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class JKKJNKIKJNK<T> : global::IELPNHCIPOF<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3B401D0", Offset = "0x3B3E7D0", VA = "0x183B401D0", Slot = "8")]
	protected override void MFMCNFFMIAP(ref List<T> JAMIHJHDKEO, int EBBLFLFCHFB, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B140", Offset = "0x2C19740", VA = "0x182C1B140", Slot = "7")]
	protected override List<T> CBFHJGEFJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x1CCCF40", Offset = "0x1CCB540", VA = "0x181CCCF40", Slot = "9")]
	protected override IList<T> ADFDICGOODJ(ref List<T> MCLDBIFAHBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class HKKMDPPMNDL<T> : global::IELPNHCIPOF<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x3B401D0", Offset = "0x3B3E7D0", VA = "0x183B401D0", Slot = "8")]
	protected override void MFMCNFFMIAP(ref List<T> JAMIHJHDKEO, int EBBLFLFCHFB, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B140", Offset = "0x2C19740", VA = "0x182C1B140", Slot = "7")]
	protected override List<T> CBFHJGEFJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x1CCCF40", Offset = "0x1CCB540", VA = "0x181CCCF40", Slot = "9")]
	protected override ICollection<T> ADFDICGOODJ(ref List<T> MCLDBIFAHBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class LECGAGBOLNP<T> : global::IELPNHCIPOF<T, global::BIMCCMIHDOH<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x2C16A50", Offset = "0x2C15050", VA = "0x182C16A50", Slot = "8")]
	protected override void MFMCNFFMIAP(ref global::BIMCCMIHDOH<T> JAMIHJHDKEO, int EBBLFLFCHFB, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x2C16A10", Offset = "0x2C15010", VA = "0x182C16A10", Slot = "7")]
	protected override global::BIMCCMIHDOH<T> CBFHJGEFJHE()
	{
		return default(global::BIMCCMIHDOH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2C169F0", Offset = "0x2C14FF0", VA = "0x182C169F0", Slot = "9")]
	protected override IEnumerable<T> ADFDICGOODJ(ref global::BIMCCMIHDOH<T> MCLDBIFAHBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class GMGFEOINJBP<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class LDBJOBLMKIH<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class EHLNLIGPNDG<T> : global::AMLJDOHMGLI<T>, HAOPHHJJNOJ where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x36BE600", Offset = "0x36BCC00", VA = "0x1836BE600", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x36BE3F0", Offset = "0x36BC9F0", VA = "0x1836BE3F0", Slot = "5")]
	public T FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
	public EHLNLIGPNDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class EBJHCDFCNDD : global::AMLJDOHMGLI<IEnumerable>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::AMLJDOHMGLI<IEnumerable> MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x11F7560", Offset = "0x11F5B60", VA = "0x1811F7560", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, IEnumerable MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x11F73B0", Offset = "0x11F59B0", VA = "0x1811F73B0", Slot = "5")]
	public IEnumerable FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public EBJHCDFCNDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class NGMMJNNMIIK : global::AMLJDOHMGLI<ICollection>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	public static readonly global::AMLJDOHMGLI<ICollection> MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x1709430", Offset = "0x1707A30", VA = "0x181709430", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, ICollection MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x1709280", Offset = "0x1707880", VA = "0x181709280", Slot = "5")]
	public ICollection FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public NGMMJNNMIIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class CIIGOFOCBKB : global::AMLJDOHMGLI<IList>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::AMLJDOHMGLI<IList> MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x11F2680", Offset = "0x11F0C80", VA = "0x1811F2680", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, IList MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x11F24D0", Offset = "0x11F0AD0", VA = "0x1811F24D0", Slot = "5")]
	public IList FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public CIIGOFOCBKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class LIBNDNEPJGJ<T> : global::IELPNHCIPOF<T, global::BIMCCMIHDOH<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x3043F50", Offset = "0x3042550", VA = "0x183043F50", Slot = "8")]
	protected override void MFMCNFFMIAP(ref global::BIMCCMIHDOH<T> JAMIHJHDKEO, int EBBLFLFCHFB, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x2C16A10", Offset = "0x2C15010", VA = "0x182C16A10", Slot = "7")]
	protected override global::BIMCCMIHDOH<T> CBFHJGEFJHE()
	{
		return default(global::BIMCCMIHDOH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3043F10", Offset = "0x3042510", VA = "0x183043F10", Slot = "9")]
	protected override IReadOnlyList<T> ADFDICGOODJ(ref global::BIMCCMIHDOH<T> MCLDBIFAHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x2FFD450", Offset = "0x2FFBA50", VA = "0x182FFD450")]
	public LIBNDNEPJGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class OKMMPMCHBLP
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x170CF50", Offset = "0x170B550", VA = "0x18170CF50")]
	public static DateTime MPHBFHHEGFL(DateTime EDLCNJAEKPC)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class GFEFFIENKCD : global::AMLJDOHMGLI<DateTime>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly global::AMLJDOHMGLI<DateTime> MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x11FC070", Offset = "0x11FA670", VA = "0x1811FC070", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, DateTime MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x11FB110", Offset = "0x11F9710", VA = "0x1811FB110", Slot = "5")]
	public DateTime FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public GFEFFIENKCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class MHFALMGMBJI : global::AMLJDOHMGLI<DateTimeOffset>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly global::AMLJDOHMGLI<DateTimeOffset> MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x17052B0", Offset = "0x17038B0", VA = "0x1817052B0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, DateTimeOffset MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x17043E0", Offset = "0x17029E0", VA = "0x1817043E0", Slot = "5")]
	public DateTimeOffset FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MHFALMGMBJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class OOINCALGFPM : global::AMLJDOHMGLI<TimeSpan>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly global::AMLJDOHMGLI<TimeSpan> MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static byte[] IEMINMEGKCD;

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x170DA10", Offset = "0x170C010", VA = "0x18170DA10", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, TimeSpan MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x170D150", Offset = "0x170B750", VA = "0x18170D150", Slot = "5")]
	public TimeSpan FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public OOINCALGFPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class OOPMNGMGNHB<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::AMLJDOHMGLI<TDictionary>, HAOPHHJJNOJ where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x4428F50", Offset = "0x4427550", VA = "0x184428F50", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, TDictionary MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x4427AF0", Offset = "0x44260F0", VA = "0x184427AF0", Slot = "5")]
	public TDictionary FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator HHAKIOELJAB(TDictionary CELBLIIOMDE);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate CBFHJGEFJHE();

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void MFMCNFFMIAP(ref TIntermediate JAMIHJHDKEO, int EBBLFLFCHFB, TKey AIGAKEKDKHM, TValue MAKFNMHIJIF);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary ADFDICGOODJ(ref TIntermediate MCLDBIFAHBO);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
	protected OOPMNGMGNHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class FKHOBFFCOAF<TKey, TValue, TIntermediate, TDictionary> : global::OOPMNGMGNHB<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x3564350", Offset = "0x3562950", VA = "0x183564350", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> HHAKIOELJAB(TDictionary CELBLIIOMDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class GDPNACEIHOA<TKey, TValue, TDictionary> : global::FKHOBFFCOAF<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x1CCCF40", Offset = "0x1CCB540", VA = "0x181CCCF40", Slot = "9")]
	protected override TDictionary ADFDICGOODJ(ref TDictionary MCLDBIFAHBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class LELIHNAFBCO<TKey, TValue> : global::OOPMNGMGNHB<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B250", Offset = "0x2C19850", VA = "0x182C1B250", Slot = "8")]
	protected override void MFMCNFFMIAP(ref Dictionary<TKey, TValue> JAMIHJHDKEO, int EBBLFLFCHFB, TKey AIGAKEKDKHM, TValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x1CCCF40", Offset = "0x1CCB540", VA = "0x181CCCF40", Slot = "9")]
	protected override Dictionary<TKey, TValue> ADFDICGOODJ(ref Dictionary<TKey, TValue> MCLDBIFAHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B140", Offset = "0x2C19740", VA = "0x182C1B140", Slot = "7")]
	protected override Dictionary<TKey, TValue> CBFHJGEFJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B1A0", Offset = "0x2C197A0", VA = "0x182C1B1A0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator HHAKIOELJAB(Dictionary<TKey, TValue> CELBLIIOMDE)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x2344D60", Offset = "0x2343360", VA = "0x182344D60")]
	public LELIHNAFBCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class GGAOLPAJDAK<TKey, TValue, TDictionary> : global::GDPNACEIHOA<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x37D11F0", Offset = "0x37CF7F0", VA = "0x1837D11F0", Slot = "8")]
	protected override void MFMCNFFMIAP(ref TDictionary JAMIHJHDKEO, int EBBLFLFCHFB, TKey AIGAKEKDKHM, TValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2DCCC20", Offset = "0x2DCB220", VA = "0x182DCCC20", Slot = "7")]
	protected override TDictionary CBFHJGEFJHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class DPANMJEIFEB<TKey, TValue> : global::FKHOBFFCOAF<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B290", Offset = "0x2C19890", VA = "0x182C1B290", Slot = "8")]
	protected override void MFMCNFFMIAP(ref Dictionary<TKey, TValue> JAMIHJHDKEO, int EBBLFLFCHFB, TKey AIGAKEKDKHM, TValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B140", Offset = "0x2C19740", VA = "0x182C1B140", Slot = "7")]
	protected override Dictionary<TKey, TValue> CBFHJGEFJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x1CCCF40", Offset = "0x1CCB540", VA = "0x181CCCF40", Slot = "9")]
	protected override IDictionary<TKey, TValue> ADFDICGOODJ(ref Dictionary<TKey, TValue> MCLDBIFAHBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class DGDKBKKOBHO<TKey, TValue> : global::GDPNACEIHOA<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B290", Offset = "0x2C19890", VA = "0x182C1B290", Slot = "8")]
	protected override void MFMCNFFMIAP(ref SortedList<TKey, TValue> JAMIHJHDKEO, int EBBLFLFCHFB, TKey AIGAKEKDKHM, TValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B140", Offset = "0x2C19740", VA = "0x182C1B140", Slot = "7")]
	protected override SortedList<TKey, TValue> CBFHJGEFJHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class GNHKLHNFAJP<TKey, TValue> : global::OOPMNGMGNHB<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B290", Offset = "0x2C19890", VA = "0x182C1B290", Slot = "8")]
	protected override void MFMCNFFMIAP(ref SortedDictionary<TKey, TValue> JAMIHJHDKEO, int EBBLFLFCHFB, TKey AIGAKEKDKHM, TValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x1CCCF40", Offset = "0x1CCB540", VA = "0x181CCCF40", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> ADFDICGOODJ(ref SortedDictionary<TKey, TValue> MCLDBIFAHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B140", Offset = "0x2C19740", VA = "0x182C1B140", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> CBFHJGEFJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x4086850", Offset = "0x4084E50", VA = "0x184086850", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator HHAKIOELJAB(SortedDictionary<TKey, TValue> CELBLIIOMDE)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class NIMOGNNFLHL<T> : global::AMLJDOHMGLI<T>, HAOPHHJJNOJ where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x394F920", Offset = "0x394DF20", VA = "0x18394F920", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x394F6F0", Offset = "0x394DCF0", VA = "0x18394F6F0", Slot = "5")]
	public T FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
	public NIMOGNNFLHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class KCBAGPIBBNI : global::AMLJDOHMGLI<IDictionary>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly global::AMLJDOHMGLI<IDictionary> MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x16FEC90", Offset = "0x16FD290", VA = "0x1816FEC90", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, IDictionary MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x16FEAC0", Offset = "0x16FD0C0", VA = "0x1816FEAC0", Slot = "5")]
	public IDictionary FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public KCBAGPIBBNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class GHJEFPIIALJ : global::AMLJDOHMGLI<object>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void LEJFMHKJLAJ(object NOFKOJCABJD, ref NADLEEAJGKF IEEJJNDPOHK, object MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly global::AAONIJFMFPJ<KeyValuePair<object, LEJFMHKJLAJ>> HLCNJFHNKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly OLGPDOHAJDG[] BHNCFOAHEKO;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x16F6E30", Offset = "0x16F5430", VA = "0x1816F6E30")]
	public GHJEFPIIALJ(params OLGPDOHAJDG[] BHNCFOAHEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x16F63D0", Offset = "0x16F49D0", VA = "0x1816F63D0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, object MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x16F6330", Offset = "0x16F4930", VA = "0x1816F6330", Slot = "5")]
	public object FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class CNBJOLNPGPN
{
	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x11F32B0", Offset = "0x11F18B0", VA = "0x1811F32B0")]
	public static object HCMCCELICBE(Type MCLMFJEAHEC, out bool GOFJCKJHGEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x11F3BD0", Offset = "0x11F21D0", VA = "0x1811F3BD0")]
	public static object JCGLPMADKKM(Type MCLMFJEAHEC, out bool GOFJCKJHGEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class COHKKJGAHPE<T> : global::AMLJDOHMGLI<T>, HAOPHHJJNOJ, global::HINADFJMEID<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class PAFOGPMENDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public PAFOGPMENDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x47CCAA0", Offset = "0x47CB0A0", VA = "0x1847CCAA0")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class FPKJLOOADHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public global::FJGAKNNEING<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public FPKJLOOADHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x3E55B10", Offset = "0x3E54110", VA = "0x183E55B10")]
		internal void <.cctor>b__1(ref NADLEEAJGKF writer, T value, OLGPDOHAJDG _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class EPCDBHDAIMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public global::BBNBBHDPEAG<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public EPCDBHDAIMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x3348CC0", Offset = "0x33472C0", VA = "0x183348CC0")]
		internal T <.cctor>b__2(ref PLJMADAGCJN reader, OLGPDOHAJDG _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static readonly global::HGAEACDDEIG<T> AAKHCOCKNLO;

	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private static readonly Dictionary<T, string> LBPBBFLGPKI;

	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private static readonly global::FJGAKNNEING<T> DHGHIDGLELD;

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly global::BBNBBHDPEAG<T> GKAHDEPAPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private readonly bool DBNAICJMNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private readonly global::FJGAKNNEING<T> DLBAHKCLBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::BBNBBHDPEAG<T> NPGMLIDOHHH;

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x46A13C0", Offset = "0x469F9C0", VA = "0x1846A13C0")]
	static COHKKJGAHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3F152F0", Offset = "0x3F138F0", VA = "0x183F152F0")]
	public COHKKJGAHPE(bool DBNAICJMNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x4692EC0", Offset = "0x46914C0", VA = "0x184692EC0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x468DD00", Offset = "0x468C300", VA = "0x18468DD00", Slot = "5")]
	public T FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x4694620", Offset = "0x4692C20", VA = "0x184694620", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, T MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x4690C40", Offset = "0x468F240", VA = "0x184690C40", Slot = "7")]
	public T GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class IPJBNHNONBN<T> : global::AMLJDOHMGLI<T[,]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x3295C50", Offset = "0x3294250", VA = "0x183295C50", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T[,] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3295980", Offset = "0x3293F80", VA = "0x183295980", Slot = "5")]
	public T[,] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
	public IPJBNHNONBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class OIFMGJFIOOF<T> : global::AMLJDOHMGLI<T[,,]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x3EA7700", Offset = "0x3EA5D00", VA = "0x183EA7700", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T[,,] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x3EA7320", Offset = "0x3EA5920", VA = "0x183EA7320", Slot = "5")]
	public T[,,] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
	public OIFMGJFIOOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class HEHFLEJCMPE<T> : global::AMLJDOHMGLI<T[,,,]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE1E0", Offset = "0x3AFC7E0", VA = "0x183AFE1E0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T[,,,] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x3AFDCE0", Offset = "0x3AFC2E0", VA = "0x183AFDCE0", Slot = "5")]
	public T[,,,] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
	public HEHFLEJCMPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class GDNHIKEJADP<T> : global::AMLJDOHMGLI<T?>, HAOPHHJJNOJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x37CC0F0", Offset = "0x37CA6F0", VA = "0x1837CC0F0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x37CBE40", Offset = "0x37CA440", VA = "0x1837CBE40", Slot = "5")]
	public T? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
	public GDNHIKEJADP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class DLBLDNCCNAM<T> : global::AMLJDOHMGLI<T?>, HAOPHHJJNOJ where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private readonly global::AMLJDOHMGLI<T> FJPJMKCCOBH;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x33487E0", Offset = "0x3346DE0", VA = "0x1833487E0")]
	public DLBLDNCCNAM(global::AMLJDOHMGLI<T> FJPJMKCCOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x3429EE0", Offset = "0x34284E0", VA = "0x183429EE0")]
	public DLBLDNCCNAM(Type MKPLIADKLAP, object[] MFGCCBLNNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3428F00", Offset = "0x3427500", VA = "0x183428F00", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3427A40", Offset = "0x3426040", VA = "0x183427A40", Slot = "5")]
	public T? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class MGLOCNCFLLP : global::AMLJDOHMGLI<sbyte>, HAOPHHJJNOJ, global::HINADFJMEID<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly MGLOCNCFLLP MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x1703D50", Offset = "0x1702350", VA = "0x181703D50", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, sbyte MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x1703C90", Offset = "0x1702290", VA = "0x181703C90", Slot = "5")]
	public sbyte FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x1703D90", Offset = "0x1702390", VA = "0x181703D90", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, sbyte MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x1703CA0", Offset = "0x17022A0", VA = "0x181703CA0", Slot = "7")]
	public sbyte GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MGLOCNCFLLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class LLAMNCMFAFH : global::AMLJDOHMGLI<sbyte?>, HAOPHHJJNOJ, global::HINADFJMEID<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly LLAMNCMFAFH MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x1703660", Offset = "0x1701C60", VA = "0x181703660", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, sbyte? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x17034F0", Offset = "0x1701AF0", VA = "0x1817034F0", Slot = "5")]
	public sbyte? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x17036F0", Offset = "0x1701CF0", VA = "0x1817036F0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, sbyte? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x1703560", Offset = "0x1701B60", VA = "0x181703560", Slot = "7")]
	public sbyte? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public LLAMNCMFAFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class GEGMGJGGKPM : global::AMLJDOHMGLI<sbyte[]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly GEGMGJGGKPM MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x11FAD60", Offset = "0x11F9360", VA = "0x1811FAD60", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, sbyte[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x11FAC20", Offset = "0x11F9220", VA = "0x1811FAC20", Slot = "5")]
	public sbyte[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public GEGMGJGGKPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class PJAHKFGBHJJ : global::AMLJDOHMGLI<short>, HAOPHHJJNOJ, global::HINADFJMEID<short>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly PJAHKFGBHJJ MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x18A6A40", Offset = "0x18A5040", VA = "0x1818A6A40", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, short MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x18A6960", Offset = "0x18A4F60", VA = "0x1818A6960", Slot = "5")]
	public short FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x18A6A60", Offset = "0x18A5060", VA = "0x1818A6A60", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, short MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x18A69C0", Offset = "0x18A4FC0", VA = "0x1818A69C0", Slot = "7")]
	public short GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public PJAHKFGBHJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class JGHCMBINOMI : global::AMLJDOHMGLI<short?>, HAOPHHJJNOJ, global::HINADFJMEID<short?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly JGHCMBINOMI MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x16FCBF0", Offset = "0x16FB1F0", VA = "0x1816FCBF0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, short? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x16FCA90", Offset = "0x16FB090", VA = "0x1816FCA90", Slot = "5")]
	public short? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x16FCC80", Offset = "0x16FB280", VA = "0x1816FCC80", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, short? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x16FCB00", Offset = "0x16FB100", VA = "0x1816FCB00", Slot = "7")]
	public short? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public JGHCMBINOMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class HHLLDDHFLAJ : global::AMLJDOHMGLI<short[]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly HHLLDDHFLAJ MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x16F8660", Offset = "0x16F6C60", VA = "0x1816F8660", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, short[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x16F8520", Offset = "0x16F6B20", VA = "0x1816F8520", Slot = "5")]
	public short[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public HHLLDDHFLAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class CPNPLCMCFNH : global::AMLJDOHMGLI<int>, HAOPHHJJNOJ, global::HINADFJMEID<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly CPNPLCMCFNH MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x11F4580", Offset = "0x11F2B80", VA = "0x1811F4580", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, int MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x11F44F0", Offset = "0x11F2AF0", VA = "0x1811F44F0", Slot = "5")]
	public int FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x11F4590", Offset = "0x11F2B90", VA = "0x1811F4590", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, int MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x11F4500", Offset = "0x11F2B00", VA = "0x1811F4500", Slot = "7")]
	public int GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public CPNPLCMCFNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class NAAGNPCKBDA : global::AMLJDOHMGLI<int?>, HAOPHHJJNOJ, global::HINADFJMEID<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly NAAGNPCKBDA MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x1707A20", Offset = "0x1706020", VA = "0x181707A20", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, int? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x17078C0", Offset = "0x1705EC0", VA = "0x1817078C0", Slot = "5")]
	public int? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x1707AB0", Offset = "0x17060B0", VA = "0x181707AB0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, int? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x1707930", Offset = "0x1705F30", VA = "0x181707930", Slot = "7")]
	public int? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public NAAGNPCKBDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class BCMPJCGMIOH : global::AMLJDOHMGLI<int[]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly BCMPJCGMIOH MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x11E2E70", Offset = "0x11E1470", VA = "0x1811E2E70", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, int[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x11E2D30", Offset = "0x11E1330", VA = "0x1811E2D30", Slot = "5")]
	public int[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public BCMPJCGMIOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class NOFIENCOMBJ : global::AMLJDOHMGLI<long>, HAOPHHJJNOJ, global::HINADFJMEID<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly NOFIENCOMBJ MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x1709900", Offset = "0x1707F00", VA = "0x181709900", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, long MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x1709810", Offset = "0x1707E10", VA = "0x181709810", Slot = "5")]
	public long FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x1709930", Offset = "0x1707F30", VA = "0x181709930", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, long MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x1709820", Offset = "0x1707E20", VA = "0x181709820", Slot = "7")]
	public long GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public NOFIENCOMBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class CJIIJADLPGJ : global::AMLJDOHMGLI<long?>, HAOPHHJJNOJ, global::HINADFJMEID<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly CJIIJADLPGJ MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x11F3140", Offset = "0x11F1740", VA = "0x1811F3140", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, long? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x11F2FD0", Offset = "0x11F15D0", VA = "0x1811F2FD0", Slot = "5")]
	public long? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x11F31C0", Offset = "0x11F17C0", VA = "0x1811F31C0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, long? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x11F3060", Offset = "0x11F1660", VA = "0x1811F3060", Slot = "7")]
	public long? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public CJIIJADLPGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class EJIIFDFFOPC : global::AMLJDOHMGLI<long[]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly EJIIFDFFOPC MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x11F7E50", Offset = "0x11F6450", VA = "0x1811F7E50", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, long[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x11F7D10", Offset = "0x11F6310", VA = "0x1811F7D10", Slot = "5")]
	public long[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public EJIIFDFFOPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class LHCFDPLLAKH : global::AMLJDOHMGLI<byte>, HAOPHHJJNOJ, global::HINADFJMEID<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly LHCFDPLLAKH MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x1703390", Offset = "0x1701990", VA = "0x181703390", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, byte MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x17032D0", Offset = "0x17018D0", VA = "0x1817032D0", Slot = "5")]
	public byte FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x17033D0", Offset = "0x17019D0", VA = "0x1817033D0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, byte MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x17032E0", Offset = "0x17018E0", VA = "0x1817032E0", Slot = "7")]
	public byte GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public LHCFDPLLAKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class IJMFMOBNFEH : global::AMLJDOHMGLI<byte?>, HAOPHHJJNOJ, global::HINADFJMEID<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly IJMFMOBNFEH MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x16F9E80", Offset = "0x16F8480", VA = "0x1816F9E80", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, byte? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x16F9D10", Offset = "0x16F8310", VA = "0x1816F9D10", Slot = "5")]
	public byte? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x16F9F10", Offset = "0x16F8510", VA = "0x1816F9F10", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, byte? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x16F9D80", Offset = "0x16F8380", VA = "0x1816F9D80", Slot = "7")]
	public byte? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public IJMFMOBNFEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class DCFFEPHOCFC : global::AMLJDOHMGLI<ushort>, HAOPHHJJNOJ, global::HINADFJMEID<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly DCFFEPHOCFC MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x11F46C0", Offset = "0x11F2CC0", VA = "0x1811F46C0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, ushort MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x11F4630", Offset = "0x11F2C30", VA = "0x1811F4630", Slot = "5")]
	public ushort FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x11F46E0", Offset = "0x11F2CE0", VA = "0x1811F46E0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, ushort MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x11F4640", Offset = "0x11F2C40", VA = "0x1811F4640", Slot = "7")]
	public ushort GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public DCFFEPHOCFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class GFECECDDJHG : global::AMLJDOHMGLI<ushort?>, HAOPHHJJNOJ, global::HINADFJMEID<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly GFECECDDJHG MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x11FAFB0", Offset = "0x11F95B0", VA = "0x1811FAFB0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, ushort? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x11FAE80", Offset = "0x11F9480", VA = "0x1811FAE80", Slot = "5")]
	public ushort? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x11FB030", Offset = "0x11F9630", VA = "0x1811FB030", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, ushort? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x11FAEF0", Offset = "0x11F94F0", VA = "0x1811FAEF0", Slot = "7")]
	public ushort? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public GFECECDDJHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class AFMFJFKAJHJ : global::AMLJDOHMGLI<ushort[]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly AFMFJFKAJHJ MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x11E1080", Offset = "0x11DF680", VA = "0x1811E1080", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, ushort[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x11E0F40", Offset = "0x11DF540", VA = "0x1811E0F40", Slot = "5")]
	public ushort[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public AFMFJFKAJHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class AHIMFLBLPBH : global::AMLJDOHMGLI<uint>, HAOPHHJJNOJ, global::HINADFJMEID<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly AHIMFLBLPBH MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x11E1230", Offset = "0x11DF830", VA = "0x1811E1230", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, uint MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x11E11A0", Offset = "0x11DF7A0", VA = "0x1811E11A0", Slot = "5")]
	public uint FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x11E1240", Offset = "0x11DF840", VA = "0x1811E1240", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, uint MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x11E11B0", Offset = "0x11DF7B0", VA = "0x1811E11B0", Slot = "7")]
	public uint GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public AHIMFLBLPBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class KKMNNPICCGL : global::AMLJDOHMGLI<uint?>, HAOPHHJJNOJ, global::HINADFJMEID<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly KKMNNPICCGL MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x17022A0", Offset = "0x17008A0", VA = "0x1817022A0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, uint? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x1702140", Offset = "0x1700740", VA = "0x181702140", Slot = "5")]
	public uint? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x1702330", Offset = "0x1700930", VA = "0x181702330", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, uint? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x17021B0", Offset = "0x17007B0", VA = "0x1817021B0", Slot = "7")]
	public uint? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public KKMNNPICCGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class IFBJPJCAADL : global::AMLJDOHMGLI<uint[]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly IFBJPJCAADL MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x16F9390", Offset = "0x16F7990", VA = "0x1816F9390", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, uint[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x16F9250", Offset = "0x16F7850", VA = "0x1816F9250", Slot = "5")]
	public uint[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public IFBJPJCAADL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class HCKAKACLIKA : global::AMLJDOHMGLI<ulong>, HAOPHHJJNOJ, global::HINADFJMEID<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly HCKAKACLIKA MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x16F7D60", Offset = "0x16F6360", VA = "0x1816F7D60", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, ulong MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x16F7CD0", Offset = "0x16F62D0", VA = "0x1816F7CD0", Slot = "5")]
	public ulong FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x16F7D90", Offset = "0x16F6390", VA = "0x1816F7D90", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, ulong MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x16F7CE0", Offset = "0x16F62E0", VA = "0x1816F7CE0", Slot = "7")]
	public ulong GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public HCKAKACLIKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class KIPEIMHIEHE : global::AMLJDOHMGLI<ulong?>, HAOPHHJJNOJ, global::HINADFJMEID<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly KIPEIMHIEHE MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x1701F40", Offset = "0x1700540", VA = "0x181701F40", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, ulong? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x1701DD0", Offset = "0x17003D0", VA = "0x181701DD0", Slot = "5")]
	public ulong? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x1701FD0", Offset = "0x17005D0", VA = "0x181701FD0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, ulong? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x1701E60", Offset = "0x1700460", VA = "0x181701E60", Slot = "7")]
	public ulong? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public KIPEIMHIEHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class GHGOHJGPJFM : global::AMLJDOHMGLI<ulong[]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly GHGOHJGPJFM MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x16F6130", Offset = "0x16F4730", VA = "0x1816F6130", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, ulong[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x16F5FF0", Offset = "0x16F45F0", VA = "0x1816F5FF0", Slot = "5")]
	public ulong[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public GHGOHJGPJFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class POCBIDDNDJC : global::AMLJDOHMGLI<float>, HAOPHHJJNOJ, global::HINADFJMEID<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly POCBIDDNDJC MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x18AA0A0", Offset = "0x18A86A0", VA = "0x1818AA0A0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, float MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x18AA010", Offset = "0x18A8610", VA = "0x1818AA010", Slot = "5")]
	public float FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x18AA0B0", Offset = "0x18A86B0", VA = "0x1818AA0B0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, float MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x18AA020", Offset = "0x18A8620", VA = "0x1818AA020", Slot = "7")]
	public float GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public POCBIDDNDJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class LGPIICOJCHA : global::AMLJDOHMGLI<float?>, HAOPHHJJNOJ, global::HINADFJMEID<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly LGPIICOJCHA MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x17030F0", Offset = "0x17016F0", VA = "0x1817030F0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, float? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x1702F90", Offset = "0x1701590", VA = "0x181702F90", Slot = "5")]
	public float? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x1703170", Offset = "0x1701770", VA = "0x181703170", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, float? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x1703000", Offset = "0x1701600", VA = "0x181703000", Slot = "7")]
	public float? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public LGPIICOJCHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class LCJPMBMJOEL : global::AMLJDOHMGLI<float[]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly LCJPMBMJOEL MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x1702D50", Offset = "0x1701350", VA = "0x181702D50", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, float[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x1702C10", Offset = "0x1701210", VA = "0x181702C10", Slot = "5")]
	public float[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public LCJPMBMJOEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class KEAHKGJKBIO : global::AMLJDOHMGLI<double>, HAOPHHJJNOJ, global::HINADFJMEID<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly KEAHKGJKBIO MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x1701CB0", Offset = "0x17002B0", VA = "0x181701CB0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, double MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x1701BF0", Offset = "0x17001F0", VA = "0x181701BF0", Slot = "5")]
	public double FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x1701CC0", Offset = "0x17002C0", VA = "0x181701CC0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, double MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x1701C00", Offset = "0x1700200", VA = "0x181701C00", Slot = "7")]
	public double GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public KEAHKGJKBIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class OEJIHHKBOOB : global::AMLJDOHMGLI<double?>, HAOPHHJJNOJ, global::HINADFJMEID<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly OEJIHHKBOOB MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x170CA50", Offset = "0x170B050", VA = "0x18170CA50", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, double? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x170C8B0", Offset = "0x170AEB0", VA = "0x18170C8B0", Slot = "5")]
	public double? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x170CAD0", Offset = "0x170B0D0", VA = "0x18170CAD0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, double? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x170C940", Offset = "0x170AF40", VA = "0x18170C940", Slot = "7")]
	public double? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public OEJIHHKBOOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class JGNKBKAELLF : global::AMLJDOHMGLI<double[]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly JGNKBKAELLF MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x16FD090", Offset = "0x16FB690", VA = "0x1816FD090", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, double[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x16FCF50", Offset = "0x16FB550", VA = "0x1816FCF50", Slot = "5")]
	public double[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public JGNKBKAELLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class DMHOGKBIPEO : global::AMLJDOHMGLI<bool>, HAOPHHJJNOJ, global::HINADFJMEID<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly DMHOGKBIPEO MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x11F6AF0", Offset = "0x11F50F0", VA = "0x1811F6AF0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, bool MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x11F6A60", Offset = "0x11F5060", VA = "0x1811F6A60", Slot = "5")]
	public bool FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x11F6B10", Offset = "0x11F5110", VA = "0x1811F6B10", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, bool MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x11F6A70", Offset = "0x11F5070", VA = "0x1811F6A70", Slot = "7")]
	public bool GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public DMHOGKBIPEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class KBJDFCIKPGD : global::AMLJDOHMGLI<bool?>, HAOPHHJJNOJ, global::HINADFJMEID<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly KBJDFCIKPGD MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x16FE8E0", Offset = "0x16FCEE0", VA = "0x1816FE8E0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, bool? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x16FE7B0", Offset = "0x16FCDB0", VA = "0x1816FE7B0", Slot = "5")]
	public bool? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x16FE960", Offset = "0x16FCF60", VA = "0x1816FE960", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, bool? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x16FE820", Offset = "0x16FCE20", VA = "0x1816FE820", Slot = "7")]
	public bool? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public KBJDFCIKPGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class MHJDANNPPGL : global::AMLJDOHMGLI<bool[]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly MHJDANNPPGL MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x1706010", Offset = "0x1704610", VA = "0x181706010", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, bool[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x1705ED0", Offset = "0x17044D0", VA = "0x181705ED0", Slot = "5")]
	public bool[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MHJDANNPPGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class POMIEIHJFLL : global::AMLJDOHMGLI<object>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly global::AMLJDOHMGLI<object> MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly Dictionary<Type, int> KNLKENLLFJE;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x18AA5C0", Offset = "0x18A8BC0", VA = "0x1818AA5C0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, object MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x18AA150", Offset = "0x18A8750", VA = "0x1818AA150", Slot = "5")]
	public object FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public POMIEIHJFLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class IPFCGACGCJN : global::AMLJDOHMGLI<byte[]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly global::AMLJDOHMGLI<byte[]> MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x16FA4B0", Offset = "0x16F8AB0", VA = "0x1816FA4B0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, byte[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x16FA430", Offset = "0x16F8A30", VA = "0x1816FA430", Slot = "5")]
	public byte[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public IPFCGACGCJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class JICMDAKDOKA : global::AMLJDOHMGLI<ArraySegment<byte>>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly global::AMLJDOHMGLI<ArraySegment<byte>> MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x16FD3B0", Offset = "0x16FB9B0", VA = "0x1816FD3B0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, ArraySegment<byte> MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x16FD2D0", Offset = "0x16FB8D0", VA = "0x1816FD2D0", Slot = "5")]
	public ArraySegment<byte> FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public JICMDAKDOKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class IAGLNBPKPBK : global::AMLJDOHMGLI<string>, HAOPHHJJNOJ, global::HINADFJMEID<string>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::AMLJDOHMGLI<string> MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x16F8D30", Offset = "0x16F7330", VA = "0x1816F8D30", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, string MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x16F8D20", Offset = "0x16F7320", VA = "0x1816F8D20", Slot = "5")]
	public string FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x16F8D30", Offset = "0x16F7330", VA = "0x1816F8D30", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, string MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x16F8D20", Offset = "0x16F7320", VA = "0x1816F8D20", Slot = "7")]
	public string GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public IAGLNBPKPBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class NBLEAOCAEOG : global::AMLJDOHMGLI<string[]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly NBLEAOCAEOG MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x17090B0", Offset = "0x17076B0", VA = "0x1817090B0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, string[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x1708F40", Offset = "0x1707540", VA = "0x181708F40", Slot = "5")]
	public string[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public NBLEAOCAEOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class GHFNKBHOGCL : global::AMLJDOHMGLI<char>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly GHFNKBHOGCL MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x16F5F10", Offset = "0x16F4510", VA = "0x1816F5F10", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, char MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x16F5EE0", Offset = "0x16F44E0", VA = "0x1816F5EE0", Slot = "5")]
	public char FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public GHFNKBHOGCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class IPBMFIPMPEC : global::AMLJDOHMGLI<char?>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly IPBMFIPMPEC MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x16FA2B0", Offset = "0x16F88B0", VA = "0x1816FA2B0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, char? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x16FA1E0", Offset = "0x16F87E0", VA = "0x1816FA1E0", Slot = "5")]
	public char? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public IPBMFIPMPEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class AKNNOPIKFOJ : global::AMLJDOHMGLI<char[]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly AKNNOPIKFOJ MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x11E2790", Offset = "0x11E0D90", VA = "0x1811E2790", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, char[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x11E25F0", Offset = "0x11E0BF0", VA = "0x1811E25F0", Slot = "5")]
	public char[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public AKNNOPIKFOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class FCDGIIMFCGB : global::AMLJDOHMGLI<Guid>, HAOPHHJJNOJ, global::HINADFJMEID<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::AMLJDOHMGLI<Guid> MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x11F8770", Offset = "0x11F6D70", VA = "0x1811F8770", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Guid MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x11F8720", Offset = "0x11F6D20", VA = "0x1811F8720", Slot = "5")]
	public Guid FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x11F8840", Offset = "0x11F6E40", VA = "0x1811F8840", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, Guid MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x11F8720", Offset = "0x11F6D20", VA = "0x1811F8720", Slot = "7")]
	public Guid GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public FCDGIIMFCGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class AFLBDMMGODM : global::AMLJDOHMGLI<decimal>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::AMLJDOHMGLI<decimal> MKNJDLGIAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private readonly bool CJLHAMPEJGG;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0xFDE100", Offset = "0xFDC700", VA = "0x180FDE100")]
	public AFLBDMMGODM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0xADA9A0", Offset = "0xAD8FA0", VA = "0x180ADA9A0")]
	public AFLBDMMGODM(bool CJLHAMPEJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x11E0D90", Offset = "0x11DF390", VA = "0x1811E0D90", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, decimal MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x11E0B60", Offset = "0x11DF160", VA = "0x1811E0B60", Slot = "5")]
	public decimal FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class JPFHEGDAHPM : global::AMLJDOHMGLI<Uri>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly global::AMLJDOHMGLI<Uri> MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x16FDAA0", Offset = "0x16FC0A0", VA = "0x1816FDAA0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Uri MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x16FDA20", Offset = "0x16FC020", VA = "0x1816FDA20", Slot = "5")]
	public Uri FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public JPFHEGDAHPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class ADMPEBEKLDF : global::AMLJDOHMGLI<Version>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly global::AMLJDOHMGLI<Version> MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x11E08E0", Offset = "0x11DEEE0", VA = "0x1811E08E0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Version MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x11E0860", Offset = "0x11DEE60", VA = "0x1811E0860", Slot = "5")]
	public Version FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public ADMPEBEKLDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class NKADDKBIFJG<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class EHOBMNKFEEC : global::AMLJDOHMGLI<StringBuilder>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly global::AMLJDOHMGLI<StringBuilder> MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x11F7C60", Offset = "0x11F6260", VA = "0x1811F7C60", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, StringBuilder MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x11F7BE0", Offset = "0x11F61E0", VA = "0x1811F7BE0", Slot = "5")]
	public StringBuilder FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public EHOBMNKFEEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class GKMJFOEFIEA : global::AMLJDOHMGLI<BitArray>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly global::AMLJDOHMGLI<BitArray> MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x16F7B10", Offset = "0x16F6110", VA = "0x1816F7B10", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, BitArray MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x16F79F0", Offset = "0x16F5FF0", VA = "0x1816F79F0", Slot = "5")]
	public BitArray FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public GKMJFOEFIEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class BCEANKBFCEC : global::AMLJDOHMGLI<Type>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly BCEANKBFCEC MKNJDLGIAOG;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly Regex OPMMKLKJBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool LAPGEGMJEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private bool DNDGOIAFPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private bool DOJMHOECGPK;

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x11E2CC0", Offset = "0x11E12C0", VA = "0x1811E2CC0")]
	public BCEANKBFCEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x11E2CE0", Offset = "0x11E12E0", VA = "0x1811E2CE0")]
	public BCEANKBFCEC(bool LAPGEGMJEKG, bool DNDGOIAFPJG, bool DOJMHOECGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x11E2B10", Offset = "0x11E1110", VA = "0x1811E2B10", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Type MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x11E29E0", Offset = "0x11E0FE0", VA = "0x1811E29E0", Slot = "5")]
	public Type FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}
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
