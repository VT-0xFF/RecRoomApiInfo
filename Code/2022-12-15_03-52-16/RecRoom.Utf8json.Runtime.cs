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
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40")]
	public FIFCIGOMJED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class CDKIJKLNCBO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40")]
	public CDKIJKLNCBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class OFHMNJDAJIL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40")]
	public OFHMNJDAJIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class NDKHIDOICBL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40")]
	public NDKHIDOICBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class DOFCGMBENCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4608D20", Offset = "0x4607720", VA = "0x184608D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695B30", VA = "0x180697130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] PJMKMENPPEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6926F0", Offset = "0x6910F0", VA = "0x1806926F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x19E0DC0", Offset = "0x19DF7C0", VA = "0x1819E0DC0")]
	public static global::AMLJDOHMGLI<T> JOFCKJJNFGN<T>(this OLGPDOHAJDG KMBIIPHHOMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x45F2390", Offset = "0x45F0D90", VA = "0x1845F2390")]
	public static object AHOBHECGJFD(this OLGPDOHAJDG KMBIIPHHOMB, Type MCLMFJEAHEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AOEEHBLBCMP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x45F4310", Offset = "0x45F2D10", VA = "0x1845F4310")]
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
		[Cpp2IlInjected.Address(RVA = "0x52E4580", Offset = "0x52E2F80", VA = "0x1852E4580")]
		public static byte[] ODOMBKDHBOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x52E44F0", Offset = "0x52E2EF0", VA = "0x1852E44F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x52E8400", Offset = "0x52E6E00", VA = "0x1852E8400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x52E90B0", Offset = "0x52E7AB0", VA = "0x1852E90B0")]
	public PLJMADAGCJN(byte[] PPJLGCLGPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x52E90C0", Offset = "0x52E7AC0", VA = "0x1852E90C0")]
	public PLJMADAGCJN(byte[] PPJLGCLGPJE, int ADDILPEFEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x52E7A70", Offset = "0x52E6470", VA = "0x1852E7A70")]
	private HDOENCDNONA EIFHGNCKLPD(string BGANFPDCCAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x52E6DB0", Offset = "0x52E57B0", VA = "0x1852E6DB0")]
	private HDOENCDNONA BFBDPMLAIHM(string DIDMFBHHIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x50095E0", Offset = "0x5007FE0", VA = "0x1850095E0")]
	public void BJIANFMJHLF(int ADDILPEFEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675A00", VA = "0x180677000")]
	public byte[] LLHNBEEPOGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7765E0", Offset = "0x774FE0", VA = "0x1807765E0")]
	public int LPBDAPHCOHB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x52E8C70", Offset = "0x52E7670", VA = "0x1852E8C70")]
	public IIGHGFKMPAH PEHJGHBPGDM()
	{
		return default(IIGHGFKMPAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x52E74C0", Offset = "0x52E5EC0", VA = "0x1852E74C0")]
	public void DEGPPJKMELK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x52E7910", Offset = "0x52E6310", VA = "0x1852E7910")]
	public bool EELDJKNLCMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x52E8A30", Offset = "0x52E7430", VA = "0x1852E8A30")]
	public bool NKHAIEMKIHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x52E8DF0", Offset = "0x52E77F0", VA = "0x1852E8DF0")]
	public void PHKFHKHDHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x52E8830", Offset = "0x52E7230", VA = "0x1852E8830")]
	public bool MKGEFJJHLHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x52E8420", Offset = "0x52E6E20", VA = "0x1852E8420")]
	public bool JILLIPIONNE(ref int FPLNDBJJHMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x52E7220", Offset = "0x52E5C20", VA = "0x1852E7220")]
	public bool CGKIGMCCFJE(ref int FPLNDBJJHMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x52E8F50", Offset = "0x52E7950", VA = "0x1852E8F50")]
	public bool PJLJBNJELBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x52E70C0", Offset = "0x52E5AC0", VA = "0x1852E70C0")]
	public void BOIMLFPBLJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x52E6FD0", Offset = "0x52E59D0", VA = "0x1852E6FD0")]
	public bool BMALKKEANCO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x52E7660", Offset = "0x52E6060", VA = "0x1852E7660")]
	public bool DMIIFCHPGGA(ref int FPLNDBJJHMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x52E8030", Offset = "0x52E6A30", VA = "0x1852E8030")]
	public bool FJOMAFFMING(ref int FPLNDBJJHMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x52E64B0", Offset = "0x52E4EB0", VA = "0x1852E64B0")]
	public bool AEOCEMAHPHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x52E6F40", Offset = "0x52E5940", VA = "0x1852E6F40")]
	public void BKHBJKPDJNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x52E7A10", Offset = "0x52E6410", VA = "0x1852E7A10")]
	public bool EGFGEHIKKBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x52E7030", Offset = "0x52E5A30", VA = "0x1852E7030")]
	public void BOEIIKEJCLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x52E6590", Offset = "0x52E4F90", VA = "0x1852E6590")]
	private void AIGEMBAKKIP(out byte[] NDCAHLOEJEM, out int FFNKCGPCHMO, out int LDICMAOLBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x52E6E90", Offset = "0x52E5890", VA = "0x1852E6E90")]
	private static int BGFFBMMCOBO(char IKAMJBDPPHG, char LKLEFAIICIC, char KOIHHAIHBKH, char OECCBELLJIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x52E8900", Offset = "0x52E7300", VA = "0x1852E8900")]
	private static int MOJHEKHPFGD(char FBHIPILAOBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x52E80F0", Offset = "0x52E6AF0", VA = "0x1852E80F0")]
	public ArraySegment<byte> GIGNKOEHKHF()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x52E76E0", Offset = "0x52E60E0", VA = "0x1852E76E0")]
	public string DNFLMNKHFIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x52E7F80", Offset = "0x52E6980", VA = "0x1852E7F80")]
	public string EJMIHLIGNDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x52E81F0", Offset = "0x52E6BF0", VA = "0x1852E81F0")]
	public ArraySegment<byte> HJDMFPBMDPG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x52E83C0", Offset = "0x52E6DC0", VA = "0x1852E83C0")]
	public ArraySegment<byte> HPHBDFKMCBD()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x52E85F0", Offset = "0x52E6FF0", VA = "0x1852E85F0")]
	public bool MCFMJGNKPCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x52E8A90", Offset = "0x52E7490", VA = "0x1852E8A90")]
	private static bool ODPDMBELCME(byte KOIHHAIHBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x52E72E0", Offset = "0x52E5CE0", VA = "0x1852E72E0")]
	private void CNLAKJHMCOL(IIGHGFKMPAH HKLDIENGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x52E8890", Offset = "0x52E7290", VA = "0x1852E8890")]
	public void MMOGBPMNDOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x52E8E80", Offset = "0x52E7880", VA = "0x1852E8E80")]
	private void PHPLPNPBKHI(int DCIFPJJANLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x52E8B50", Offset = "0x52E7550", VA = "0x1852E8B50")]
	public sbyte OEJIODCFHFI()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x52E88A0", Offset = "0x52E72A0", VA = "0x1852E88A0")]
	public short MNOELAFOIJN()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x52E8590", Offset = "0x52E6F90", VA = "0x1852E8590")]
	public int MAMJGCIBBDI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x52E6510", Offset = "0x52E4F10", VA = "0x1852E6510")]
	public long AGKJMAEDDIA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x52E6D50", Offset = "0x52E5750", VA = "0x1852E6D50")]
	public byte ALLOGFBOPJE()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x52E7600", Offset = "0x52E6000", VA = "0x1852E7600")]
	public ushort DJNLHIBIHAN()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x52E89D0", Offset = "0x52E73D0", VA = "0x1852E89D0")]
	public uint NHJCJHDIGJH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x52E7FB0", Offset = "0x52E69B0", VA = "0x1852E7FB0")]
	public ulong FJLNLLKGCDA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x52E7150", Offset = "0x52E5B50", VA = "0x1852E7150")]
	public float CBDLDEMIBAL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x52E8BA0", Offset = "0x52E75A0", VA = "0x1852E8BA0")]
	public double OJFCEJPLDPM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x52E84A0", Offset = "0x52E6EA0", VA = "0x1852E84A0")]
	public ArraySegment<byte> KDGJCOJADMM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x52E7780", Offset = "0x52E6180", VA = "0x1852E7780")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C79FA0", Offset = "0x1C789A0", VA = "0x181C79FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string NGJLKPOCOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x913EA0", Offset = "0x9128A0", VA = "0x180913EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9550", Offset = "0x4FF7F50", VA = "0x184FF9550")]
	public HDOENCDNONA(string DIDMFBHHIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9470", Offset = "0x4FF7E70", VA = "0x184FF9470")]
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
				[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
				public AABFIECDBPM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x37E0420", Offset = "0x37DEE20", VA = "0x1837E0420")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x52D86B0", Offset = "0x52D70B0", VA = "0x1852D86B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x52D9030", Offset = "0x52D7A30", VA = "0x1852D9030")]
			public EALBCEEBAFE(Type MCLMFJEAHEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x609FBA0", Offset = "0x609E5A0", VA = "0x18609FBA0")]
			private static T BFNBMIEKGLG<T>(DynamicMethod LNIDBLPKFFA)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x52D8DE0", Offset = "0x52D77E0", VA = "0x1852D8DE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x52DB110", Offset = "0x52D9B10", VA = "0x1852DB110")]
		static EHAEDILPELC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x52DADD0", Offset = "0x52D97D0", VA = "0x1852DADD0")]
		private static EALBCEEBAFE GIKDDENMNIA(Type MCLMFJEAHEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x52DAE60", Offset = "0x52D9860", VA = "0x1852DAE60")]
		public static void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, object MAKFNMHIJIF, OLGPDOHAJDG KMBIIPHHOMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x52DAFF0", Offset = "0x52D99F0", VA = "0x1852DAFF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x52E4460", Offset = "0x52E2E60", VA = "0x1852E4460")]
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
		[Cpp2IlInjected.Address(RVA = "0x45F4F30", Offset = "0x45F3930", VA = "0x1845F4F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool MGEAADBCNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x45F5510", Offset = "0x45F3F10", VA = "0x1845F5510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x45F49D0", Offset = "0x45F33D0", VA = "0x1845F49D0")]
	public static void HDFAMIHGKFI(OLGPDOHAJDG KMBIIPHHOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x25E3970", Offset = "0x25E2370", VA = "0x1825E3970")]
	public static byte[] HGEKGOKJCDE<T>(T LGKNNMGLNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x25E36A0", Offset = "0x25E20A0", VA = "0x1825E36A0")]
	public static byte[] HGEKGOKJCDE<T>(T MAKFNMHIJIF, OLGPDOHAJDG KMBIIPHHOMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x25E3610", Offset = "0x25E2010", VA = "0x1825E3610")]
	public static void HGEKGOKJCDE<T>(ref NADLEEAJGKF IEEJJNDPOHK, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x25E3800", Offset = "0x25E2200", VA = "0x1825E3800")]
	public static void HGEKGOKJCDE<T>(ref NADLEEAJGKF IEEJJNDPOHK, T MAKFNMHIJIF, OLGPDOHAJDG KMBIIPHHOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x25E38E0", Offset = "0x25E22E0", VA = "0x1825E38E0")]
	public static void HGEKGOKJCDE<T>(Stream FJEDANIIFJL, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x25E34F0", Offset = "0x25E1EF0", VA = "0x1825E34F0")]
	public static void HGEKGOKJCDE<T>(Stream FJEDANIIFJL, T MAKFNMHIJIF, OLGPDOHAJDG KMBIIPHHOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x25E3B70", Offset = "0x25E2570", VA = "0x1825E3B70")]
	public static ArraySegment<byte> KFNLLNOPPFP<T>(T LGKNNMGLNIA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x25E39F0", Offset = "0x25E23F0", VA = "0x1825E39F0")]
	public static ArraySegment<byte> KFNLLNOPPFP<T>(T MAKFNMHIJIF, OLGPDOHAJDG KMBIIPHHOMB)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x25E1EF0", Offset = "0x25E08F0", VA = "0x1825E1EF0")]
	public static string FEKPKJBNCOA<T>(T MAKFNMHIJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x25E1F70", Offset = "0x25E0970", VA = "0x1825E1F70")]
	public static string FEKPKJBNCOA<T>(T MAKFNMHIJIF, OLGPDOHAJDG KMBIIPHHOMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x25E2D20", Offset = "0x25E1720", VA = "0x1825E2D20")]
	public static T FFFJLEEKFAK<T>(string KCOMGIPFPJM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x25E2C30", Offset = "0x25E1630", VA = "0x1825E2C30")]
	public static T FFFJLEEKFAK<T>(string KCOMGIPFPJM, OLGPDOHAJDG KMBIIPHHOMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x25E3140", Offset = "0x25E1B40", VA = "0x1825E3140")]
	public static T FFFJLEEKFAK<T>(byte[] PPJLGCLGPJE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x25E2B90", Offset = "0x25E1590", VA = "0x1825E2B90")]
	public static T FFFJLEEKFAK<T>(byte[] PPJLGCLGPJE, OLGPDOHAJDG KMBIIPHHOMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x25E2F00", Offset = "0x25E1900", VA = "0x1825E2F00")]
	public static T FFFJLEEKFAK<T>(byte[] PPJLGCLGPJE, int ADDILPEFEHP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x25E2A30", Offset = "0x25E1430", VA = "0x1825E2A30")]
	public static T FFFJLEEKFAK<T>(byte[] PPJLGCLGPJE, int ADDILPEFEHP, OLGPDOHAJDG KMBIIPHHOMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x25E31C0", Offset = "0x25E1BC0", VA = "0x1825E31C0")]
	public static T FFFJLEEKFAK<T>(ref PLJMADAGCJN ILDGEJAOOHJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x25E32C0", Offset = "0x25E1CC0", VA = "0x1825E32C0")]
	public static T FFFJLEEKFAK<T>(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG KMBIIPHHOMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x25E3470", Offset = "0x25E1E70", VA = "0x1825E3470")]
	public static T FFFJLEEKFAK<T>(Stream FJEDANIIFJL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x25E3010", Offset = "0x25E1A10", VA = "0x1825E3010")]
	public static T FFFJLEEKFAK<T>(Stream FJEDANIIFJL, OLGPDOHAJDG KMBIIPHHOMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x45F51D0", Offset = "0x45F3BD0", VA = "0x1845F51D0")]
	public static string MEMBIABHPIF(byte[] KCOMGIPFPJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x45F5050", Offset = "0x45F3A50", VA = "0x1845F5050")]
	public static string MEMBIABHPIF(byte[] KCOMGIPFPJM, int ADDILPEFEHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x45F5100", Offset = "0x45F3B00", VA = "0x1845F5100")]
	public static string MEMBIABHPIF(string KCOMGIPFPJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x45F5380", Offset = "0x45F3D80", VA = "0x1845F5380")]
	public static byte[] NAGOEHCMNLP(byte[] KCOMGIPFPJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x45F5460", Offset = "0x45F3E60", VA = "0x1845F5460")]
	public static byte[] NAGOEHCMNLP(byte[] KCOMGIPFPJM, int ADDILPEFEHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x45F52B0", Offset = "0x45F3CB0", VA = "0x1845F52B0")]
	public static byte[] NAGOEHCMNLP(string KCOMGIPFPJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x45F4A40", Offset = "0x45F3440", VA = "0x1845F4A40")]
	private static void JBMEIFHPCBC(ref PLJMADAGCJN ILDGEJAOOHJ, ref NADLEEAJGKF IEEJJNDPOHK, int IFJOKNDLBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x45F4930", Offset = "0x45F3330", VA = "0x1845F4930")]
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
		[Cpp2IlInjected.Address(RVA = "0x7765E0", Offset = "0x774FE0", VA = "0x1807765E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x50095E0", Offset = "0x5007FE0", VA = "0x1850095E0")]
	public void BJIANFMJHLF(int ADDILPEFEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5009D00", Offset = "0x5008700", VA = "0x185009D00")]
	public static byte[] GJJPHGNDPJL(string MABBPMMEACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5009F00", Offset = "0x5008900", VA = "0x185009F00")]
	public static byte[] IICDKHCHLJC(string MABBPMMEACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5009250", Offset = "0x5007C50", VA = "0x185009250")]
	public static byte[] AGJMAKIAPNH(string MABBPMMEACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x50095F0", Offset = "0x5007FF0", VA = "0x1850095F0")]
	public static byte[] BJMKLLBBABP(string MABBPMMEACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xCB1340", Offset = "0xCAFD40", VA = "0x180CB1340")]
	public NADLEEAJGKF(byte[] JDGAOCMHEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x500A320", Offset = "0x5008D20", VA = "0x18500A320")]
	public ArraySegment<byte> ODOMBKDHBOE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5009E30", Offset = "0x5008830", VA = "0x185009E30")]
	public byte[] HNKDGNKJJFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x500A410", Offset = "0x5008E10", VA = "0x18500A410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x500A3D0", Offset = "0x5008DD0", VA = "0x18500A3D0")]
	public void OLOLAGONDMO(int BLLNGOIDILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4609300", Offset = "0x4607D00", VA = "0x184609300")]
	public void NJPHEILFIAB(byte DMCLNBMJJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x500A270", Offset = "0x5008C70", VA = "0x18500A270")]
	public void NJPHEILFIAB(byte[] DMCLNBMJJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5009C70", Offset = "0x5008670", VA = "0x185009C70")]
	public void FMPJGAGIPPF(byte DMCLNBMJJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5009CB0", Offset = "0x50086B0", VA = "0x185009CB0")]
	public void FNGFOONPFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5009770", Offset = "0x5008170", VA = "0x185009770")]
	public void CHJMEKOBGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5009DE0", Offset = "0x50087E0", VA = "0x185009DE0")]
	public void HCIAODGFCJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x500A040", Offset = "0x5008A40", VA = "0x18500A040")]
	public void IPBCBDGPOOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5009EB0", Offset = "0x50088B0", VA = "0x185009EB0")]
	public void IAOKICAGGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x500A2D0", Offset = "0x5008CD0", VA = "0x18500A2D0")]
	public void NOOJLEHCKHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x50097C0", Offset = "0x50081C0", VA = "0x1850097C0")]
	public void DFNNIDECCIC(string MABBPMMEACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x500A220", Offset = "0x5008C20", VA = "0x18500A220")]
	public void LANLNFLAEFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x500A120", Offset = "0x5008B20", VA = "0x18500A120")]
	public void JNOPNCHKEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x50093C0", Offset = "0x5007DC0", VA = "0x1850093C0")]
	public void BAKFLJLNHDL(bool MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x50091D0", Offset = "0x5007BD0", VA = "0x1850091D0")]
	public void ACNDFOPIFEA(float MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5009BF0", Offset = "0x50085F0", VA = "0x185009BF0")]
	public void EIHGJMAAJCB(double MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x50095B0", Offset = "0x5007FB0", VA = "0x1850095B0")]
	public void BEJIBHPLPOD(byte MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x500A1F0", Offset = "0x5008BF0", VA = "0x18500A1F0")]
	public void KIEPAGDODBC(ushort MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5009740", Offset = "0x5008140", VA = "0x185009740")]
	public void BKPBPJKBDCF(uint MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x500A090", Offset = "0x5008A90", VA = "0x18500A090")]
	public void JHCKALKHKFD(ulong MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x500A0C0", Offset = "0x5008AC0", VA = "0x18500A0C0")]
	public void JJHLHIKLJOI(sbyte MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x500A0F0", Offset = "0x5008AF0", VA = "0x18500A0F0")]
	public void JLMEIAAHHMM(short MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x500A3E0", Offset = "0x5008DE0", VA = "0x18500A3E0")]
	public void OMJOOMJOMOE(int MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5009390", Offset = "0x5007D90", VA = "0x185009390")]
	public void AGLANPICECC(long MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5009820", Offset = "0x5008220", VA = "0x185009820")]
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
		[Cpp2IlInjected.Address(RVA = "0x3B2C0F0", Offset = "0x3B2AAF0", VA = "0x183B2C0F0")]
		static ONDHHFBNOII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private AIAFJNMIKGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FFF870", Offset = "0x4FFE270", VA = "0x184FFF870")]
	static JPOMPHDBNLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4FFF160", Offset = "0x4FFDB60", VA = "0x184FFF160")]
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
	[Cpp2IlInjected.Address(RVA = "0x5003D80", Offset = "0x5002780", VA = "0x185003D80")]
	public KLELDGJDODE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5003BD0", Offset = "0x50025D0", VA = "0x185003BD0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Vector2 MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5003A50", Offset = "0x5002450", VA = "0x185003A50", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4604690", Offset = "0x4603090", VA = "0x184604690")]
	public CJGNNIGLNCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4604570", Offset = "0x4602F70", VA = "0x184604570", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Vector3 MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4604340", Offset = "0x4602D40", VA = "0x184604340", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FFECA0", Offset = "0x4FFD6A0", VA = "0x184FFECA0")]
	public JPCBMCPKDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4FFD9B0", Offset = "0x4FFC3B0", VA = "0x184FFD9B0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Vector4 MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4FFEA80", Offset = "0x4FFD480", VA = "0x184FFEA80", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4609CF0", Offset = "0x46086F0", VA = "0x184609CF0")]
	public EKNCBDIJENH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4609BA0", Offset = "0x46085A0", VA = "0x184609BA0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Quaternion MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4609910", Offset = "0x4608310", VA = "0x184609910", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FFDD10", Offset = "0x4FFC710", VA = "0x184FFDD10")]
	public JEGPKHLHFEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4FFD9B0", Offset = "0x4FFC3B0", VA = "0x184FFD9B0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Color MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4FFD790", Offset = "0x4FFC190", VA = "0x184FFD790", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x45F5BC0", Offset = "0x45F45C0", VA = "0x1845F5BC0")]
	public BGHPFBOMGON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x45F5A20", Offset = "0x45F4420", VA = "0x1845F5A20", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Bounds MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x45F56F0", Offset = "0x45F40F0", VA = "0x1845F56F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FF8C80", Offset = "0x4FF7680", VA = "0x184FF8C80")]
	public GKBJGPONBFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4FF88D0", Offset = "0x4FF72D0", VA = "0x184FF88D0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Rect MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4FF8690", Offset = "0x4FF7090", VA = "0x184FF8690", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F30F70", Offset = "0x3F2F970", VA = "0x183F30F70")]
		static HGPOHCDPAAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private DFAJFEENNMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2784DA0", Offset = "0x27837A0", VA = "0x182784DA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x52DCFE0", Offset = "0x52DB9E0", VA = "0x1852DCFE0")]
		internal static object PBCJPIJEMHM(Type KHJLEOILJMF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private GOGNLHMBBAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3195350", Offset = "0x3193D50", VA = "0x183195350")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private MHAOPIEFFDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x50056F0", Offset = "0x50040F0", VA = "0x1850056F0")]
	public static void KOEBKPOFGOP(params OLGPDOHAJDG[] ONOMODABNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x50057D0", Offset = "0x50041D0", VA = "0x1850057D0")]
	public static void KOEBKPOFGOP(params HAOPHHJJNOJ[] IJCEIOMGAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5005460", Offset = "0x5003E60", VA = "0x185005460")]
	public static void CNNFIDCDEDG(HAOPHHJJNOJ[] IJCEIOMGAAB, OLGPDOHAJDG[] ONOMODABNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A7D480", Offset = "0x2A7BE80", VA = "0x182A7D480")]
		static GIGDEKMKIGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private FIABIBCICPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x46061C0", Offset = "0x4604BC0", VA = "0x1846061C0")]
	internal static object PBCJPIJEMHM(Type KHJLEOILJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4606180", Offset = "0x4604B80", VA = "0x184606180")]
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
		[Cpp2IlInjected.Address(RVA = "0x3437C00", Offset = "0x3436600", VA = "0x183437C00")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FFB190", Offset = "0x4FF9B90", VA = "0x184FFB190")]
	static IJGFMABODFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private IJGFMABODFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2919EB0", Offset = "0x29188B0", VA = "0x182919EB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x52E5840", Offset = "0x52E4240", VA = "0x1852E5840")]
	static OPOMMPEJLFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private OPOMMPEJLFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x35C5F50", Offset = "0x35C4950", VA = "0x1835C5F50")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FF8560", Offset = "0x4FF6F60", VA = "0x184FF8560")]
	static GJEBLDGBIKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private GJEBLDGBIKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x26465E0", Offset = "0x2644FE0", VA = "0x1826465E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4608BF0", Offset = "0x46075F0", VA = "0x184608BF0")]
	static DNPLMOOJHBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private DNPLMOOJHBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2258D90", Offset = "0x2257790", VA = "0x182258D90")]
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
	[Cpp2IlInjected.Address(RVA = "0x5004E10", Offset = "0x5003810", VA = "0x185004E10")]
	static LLLNACHGBLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private LLLNACHGBLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x24BDB70", Offset = "0x24BC570", VA = "0x1824BDB70")]
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
	[Cpp2IlInjected.Address(RVA = "0x500E3A0", Offset = "0x500CDA0", VA = "0x18500E3A0")]
	static OJFOGIEFOKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private OJFOGIEFOKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x265D3E0", Offset = "0x265BDE0", VA = "0x18265D3E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x3AE5460", Offset = "0x3AE3E60", VA = "0x183AE5460")]
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
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F273C0", Offset = "0x2F25DC0", VA = "0x182F273C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x317AC50", Offset = "0x3179650", VA = "0x18317AC50")]
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
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x343B750", Offset = "0x343A150", VA = "0x18343B750")]
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
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CFC170", Offset = "0x3CFAB70", VA = "0x183CFC170")]
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
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
	public global::AMLJDOHMGLI<T> PBCJPIJEMHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x52E4610", Offset = "0x52E3010", VA = "0x1852E4610")]
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
			[Cpp2IlInjected.Address(RVA = "0x52E2310", Offset = "0x52E0D10", VA = "0x1852E2310")]
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
		[Cpp2IlInjected.Address(RVA = "0x52DFDC0", Offset = "0x52DE7C0", VA = "0x1852DFDC0")]
		public static MethodInfo HGEKGOKJCDE(Type MCLMFJEAHEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x52DFB50", Offset = "0x52DE550", VA = "0x1852DFB50")]
		public static MethodInfo FFFJLEEKFAK(Type MCLMFJEAHEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x52E0090", Offset = "0x52DEA90", VA = "0x1852E0090")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public ENCGPIBKPGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x52DB250", Offset = "0x52D9C50", VA = "0x1852DB250")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x52DB290", Offset = "0x52D9C90", VA = "0x1852DB290")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public EGKIOEJOBPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x52DAD30", Offset = "0x52D9730", VA = "0x1852DAD30")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public KCAGOEIPALE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x52DC870", Offset = "0x52DB270", VA = "0x1852DC870")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public IAMNGCLNEGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x52DC810", Offset = "0x52DB210", VA = "0x1852DC810")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public KJAAJACMMNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x52DF110", Offset = "0x52DDB10", VA = "0x1852DF110")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x52DF120", Offset = "0x52DDB20", VA = "0x1852DF120")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public FHCCEPBLDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x52DB780", Offset = "0x52DA180", VA = "0x1852DB780")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public LOEEDBODDJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x6A1FD0", Offset = "0x6A09D0", VA = "0x1806A1FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public AIPGCKEADEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x52D88B0", Offset = "0x52D72B0", VA = "0x1852D88B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public KLALEILOOMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x52DF2C0", Offset = "0x52DDCC0", VA = "0x1852DF2C0")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x52DF570", Offset = "0x52DDF70", VA = "0x1852DF570")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public OFEHFELGBJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x1125FB0", Offset = "0x11249B0", VA = "0x181125FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public MAJAJDLBMIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x1125FB0", Offset = "0x11249B0", VA = "0x181125FB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2DAC910", Offset = "0x2DAB310", VA = "0x182DAC910")]
	public static object PKNHOJGCDMC<T>(IBELCNMFHJB POKEBAHAKOL, OLGPDOHAJDG LIIGMHMLBHA, Func<string, string> BPDELMJNELN, bool OHLDEPKBDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1F50", Offset = "0x2DA0950", VA = "0x182DA1F50")]
	public static object AMMJFPLENFL<T>(OLGPDOHAJDG LIIGMHMLBHA, Func<string, string> BPDELMJNELN, bool OHLDEPKBDNJ, bool GJDLJHDGNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x45FCC70", Offset = "0x45FB670", VA = "0x1845FCC70")]
	private static TypeInfo GELEEGPAPDH(IBELCNMFHJB POKEBAHAKOL, Type MCLMFJEAHEC, Func<string, string> BPDELMJNELN, bool OHLDEPKBDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x45FAC20", Offset = "0x45F9620", VA = "0x1845FAC20")]
	public static object FGGAFNJAJBH(Type MCLMFJEAHEC, Func<string, string> BPDELMJNELN, bool OHLDEPKBDNJ, bool GJDLJHDGNIC, bool PCLMBAINJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x45FA120", Offset = "0x45F8B20", VA = "0x1845FA120")]
	private static Dictionary<IFOAMENKCOO, FieldInfo> AAAOACDNCKA(TypeBuilder JPMPOFBDABO, BJNFMKPBJKP LLEGACMOBNC, ConstructorInfo BOIFLMIGBFI, FieldBuilder ELIDDIBLOIH, ILGenerator CMJHMCJLHOK, bool OHLDEPKBDNJ, bool MJKFHBCHKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4602B50", Offset = "0x4601550", VA = "0x184602B50")]
	private static Dictionary<IFOAMENKCOO, FieldInfo> OCGNGCBHNGI(TypeBuilder JPMPOFBDABO, BJNFMKPBJKP LLEGACMOBNC, ILGenerator CMJHMCJLHOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x45FD700", Offset = "0x45FC100", VA = "0x1845FD700")]
	private static void IDHIMFBDJCF(Type MCLMFJEAHEC, BJNFMKPBJKP LLEGACMOBNC, ILGenerator CMJHMCJLHOK, Action LLOMHFMFKFC, Func<int, IFOAMENKCOO, bool> MHNAFJGOGLF, bool OHLDEPKBDNJ, bool MJKFHBCHKEG, int OPLAOOMIBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x45FF540", Offset = "0x45FDF40", VA = "0x1845FF540")]
	private static void IOMNHJELCOG(TypeInfo MCLMFJEAHEC, IFOAMENKCOO BALNNNGOGIF, ILGenerator CMJHMCJLHOK, int EBBLFLFCHFB, Func<int, IFOAMENKCOO, bool> MHNAFJGOGLF, FFEAOMNFHOI IEEJJNDPOHK, FFEAOMNFHOI LDBEKNBKHCD, FFEAOMNFHOI EPMDOPDPDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x45FFA90", Offset = "0x45FE490", VA = "0x1845FFA90")]
	private static void KJLDCICKDOF(Type MCLMFJEAHEC, BJNFMKPBJKP LLEGACMOBNC, ILGenerator CMJHMCJLHOK, Func<int, IFOAMENKCOO, bool> MHNAFJGOGLF, bool BFCAMKOJGBM, int OPLAOOMIBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x45FC7A0", Offset = "0x45FB1A0", VA = "0x1845FC7A0")]
	private static void FNIEDLEDEBH(ILGenerator CMJHMCJLHOK, PAMMMIPIMPG LLEGACMOBNC, int EBBLFLFCHFB, Func<int, IFOAMENKCOO, bool> MHNAFJGOGLF, FFEAOMNFHOI ILDGEJAOOHJ, FFEAOMNFHOI EPMDOPDPDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4601BE0", Offset = "0x46005E0", VA = "0x184601BE0")]
	private static LocalBuilder NHKEFJJCFCP(ILGenerator CMJHMCJLHOK, Type MCLMFJEAHEC, BJNFMKPBJKP LLEGACMOBNC, PAMMMIPIMPG[] MOHOFDFLPJJ, bool DJFAKAHEPBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x46014E0", Offset = "0x45FFEE0", VA = "0x1846014E0")]
	private static bool KPNJNBAKDKI(ConstructorInfo CGBEAPFNACB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x45FAA70", Offset = "0x45F9470", VA = "0x1845FAA70")]
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
	[Cpp2IlInjected.Address(RVA = "0x2586AD0", Offset = "0x25854D0", VA = "0x182586AD0")]
	public POONGPGEPNI(byte[][] ELIDDIBLOIH, object[] KKMDHOKJAIG, object[] LEMCLHILLMH, global::AKBJDGGDHBH<T> LJAGGIBNJPB, global::DEIHKICMOFH<T> OCPLBEBMNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x25869F0", Offset = "0x25853F0", VA = "0x1825869F0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2586920", Offset = "0x2585320", VA = "0x182586920", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x268C2B0", Offset = "0x268ACB0", VA = "0x18268C2B0")]
		static KJDMCPIHFEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private EMBJFLGFJKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3188420", Offset = "0x3186E20", VA = "0x183188420")]
		static PKNHNMFBLBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly OLGPDOHAJDG LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private EDNGNPOHPHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A694F0", Offset = "0x2A67EF0", VA = "0x182A694F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A6BCC0", Offset = "0x2A6A6C0", VA = "0x182A6BCC0")]
			static GDBHNHOGDKE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		private MHFBMDFJJIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private ICFNKMFHLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x40E42A0", Offset = "0x40E2CA0", VA = "0x1840E42A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2EEC3C0", Offset = "0x2EEADC0", VA = "0x182EEC3C0")]
			static MMPOHOOKJDF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		private NCIGCBLFEBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private PLLPFIGAIED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C1E9D0", Offset = "0x2C1D3D0", VA = "0x182C1E9D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BF0DC0", Offset = "0x2BEF7C0", VA = "0x182BF0DC0")]
			static FAPHAPGGLKI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		private GODDEBJIELC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private HPGMMJCOJAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x24C1980", Offset = "0x24C0380", VA = "0x1824C1980")]
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
			[Cpp2IlInjected.Address(RVA = "0x2564570", Offset = "0x2562F70", VA = "0x182564570")]
			static EKLPFMAFPEN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		private KIINEGCLAOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private JGKDFNPKNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x342F8A0", Offset = "0x342E2A0", VA = "0x18342F8A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x331CC50", Offset = "0x331B650", VA = "0x18331CC50")]
			static JOBLBNPOONC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		private KLHGJLKJLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private KPAIIMDPFBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F3C2C0", Offset = "0x3F3ACC0", VA = "0x183F3C2C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x225F120", Offset = "0x225DB20", VA = "0x18225F120")]
			static LKKHMCODKPK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		private DHJBLGDOAEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private IANIIDEHBBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2652AA0", Offset = "0x26514A0", VA = "0x182652AA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x35C0F00", Offset = "0x35BF900", VA = "0x1835C0F00")]
			static GKGJNJBKINE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		private FMHGGHHLNEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private PICHBALMKFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x24C8DE0", Offset = "0x24C77E0", VA = "0x1824C8DE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C11870", Offset = "0x2C10270", VA = "0x182C11870")]
			static NFNLNBECOAO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		private BKEKGHGPPBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private ONPKKKDCPDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E85940", Offset = "0x3E84340", VA = "0x183E85940")]
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
			[Cpp2IlInjected.Address(RVA = "0x2E9A900", Offset = "0x2E99300", VA = "0x182E9A900")]
			static MHLLLGNJOCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		private FAPHPNFHPNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private PPMNPKGCJNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x321E140", Offset = "0x321CB40", VA = "0x18321E140")]
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
			[Cpp2IlInjected.Address(RVA = "0x239AF30", Offset = "0x2399930", VA = "0x18239AF30")]
			static NDCAMMOHGCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		private KOHEJGFDADD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private PNNOFBBLGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3185FB0", Offset = "0x31849B0", VA = "0x183185FB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x31A0610", Offset = "0x319F010", VA = "0x1831A0610")]
			static JAKHLHLOBMC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		private PPGNGEGCADL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private PFLKMLPDBJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3228490", Offset = "0x3226E90", VA = "0x183228490")]
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
			[Cpp2IlInjected.Address(RVA = "0x40EA550", Offset = "0x40E8F50", VA = "0x1840EA550")]
			static PCDLKGEBBIN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly OLGPDOHAJDG LOGBPMLPMIM;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly OLGPDOHAJDG[] ONOMODABNOH;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		private GDICNPAFIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	private IMMNIFIMMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x19E21D0", Offset = "0x19E0BD0", VA = "0x1819E21D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x34271B0", Offset = "0x3425BB0", VA = "0x1834271B0")]
	public BIMCCMIHDOH(int OBNABJCFIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3426D70", Offset = "0x3425770", VA = "0x183426D70")]
	public void MFMCNFFMIAP(T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3426CE0", Offset = "0x34256E0", VA = "0x183426CE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FF8510", Offset = "0x4FF6F10", VA = "0x184FF8510")]
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
	[Cpp2IlInjected.Address(RVA = "0x342EE50", Offset = "0x342D850", VA = "0x18342EE50")]
	public BLONFAEJJNB(int LCDGPJFKJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x342DC10", Offset = "0x342C610", VA = "0x18342DC10")]
	public T[] HCPJDJDHODP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x342DE00", Offset = "0x342C800", VA = "0x18342DE00")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E7E10", VA = "0x1808E9410")]
			[DebuggerHidden]
			public MJPLKOHMPCO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x52E19F0", Offset = "0x52E03F0", VA = "0x1852E19F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x52E1B20", Offset = "0x52E0520", VA = "0x1852E1B20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x52E1A80", Offset = "0x52E0480", VA = "0x1852E1A80", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NNICOABICHJ> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x52E1A80", Offset = "0x52E0480", VA = "0x1852E1A80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public IOCLCEAMLIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x6A1FD0", Offset = "0x6A09D0", VA = "0x1806A1FD0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x6A1FD0", Offset = "0x6A09D0", VA = "0x1806A1FD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD68C20", Offset = "0xD67620", VA = "0x180D68C20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x52E43A0", Offset = "0x52E2DA0", VA = "0x1852E43A0")]
		public NNICOABICHJ(ulong AIGAKEKDKHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x52E3220", Offset = "0x52E1C20", VA = "0x1852E3220")]
		public NNICOABICHJ MFMCNFFMIAP(ulong AIGAKEKDKHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x52E31D0", Offset = "0x52E1BD0", VA = "0x1852E31D0")]
		public NNICOABICHJ MFMCNFFMIAP(ulong AIGAKEKDKHM, int MAKFNMHIJIF, string EOKNIMPGNHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x52E2FB0", Offset = "0x52E19B0", VA = "0x1852E2FB0")]
		public NNICOABICHJ FLJMHMGMFEK(byte[] GODDPHBMKAO, ref int ADDILPEFEHP, ref int DEMLHIHNHGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x52E2F30", Offset = "0x52E1930", VA = "0x1852E2F30")]
		internal static int EOJDIFJMOPK(ulong[] HEONDDEAIBL, int EBBLFLFCHFB, int JKABHKIANJL, ulong MAKFNMHIJIF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x52E2F00", Offset = "0x52E1900", VA = "0x1852E2F00", Slot = "4")]
		public int CompareTo(NNICOABICHJ OANENNOJEBB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x52E3160", Offset = "0x52E1B60", VA = "0x1852E3160")]
		[IteratorStateMachine(typeof(MJPLKOHMPCO))]
		public IEnumerable<NNICOABICHJ> LIBHCAAGHCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x52E41D0", Offset = "0x52E2BD0", VA = "0x1852E41D0")]
		public void NKFILAGBNAG(ILGenerator CMJHMCJLHOK, LocalBuilder GODDPHBMKAO, LocalBuilder DEMLHIHNHGM, LocalBuilder AIGAKEKDKHM, Action<KeyValuePair<string, int>> OEDLMDJPHGA, Action OCELLLNEBML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x52E34E0", Offset = "0x52E1EE0", VA = "0x1852E34E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x698040", Offset = "0x696A40", VA = "0x180698040", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x52DCE10", Offset = "0x52DB810", VA = "0x1852DCE10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA97B60", Offset = "0xA96560", VA = "0x180A97B60")]
		[DebuggerHidden]
		public KCKIBHOIJBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x52DCE60", Offset = "0x52DB860", VA = "0x1852DCE60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x52DC8D0", Offset = "0x52DB2D0", VA = "0x1852DC8D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x52DCF40", Offset = "0x52DB940", VA = "0x1852DCF40")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x52DCF90", Offset = "0x52DB990", VA = "0x1852DCF90")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x52DCDD0", Offset = "0x52DB7D0", VA = "0x1852DCDD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x52DCD30", Offset = "0x52DB730", VA = "0x1852DCD30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x52DCD30", Offset = "0x52DB730", VA = "0x1852DCD30", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x460C550", Offset = "0x460AF50", VA = "0x18460C550")]
	public GBDCNECDJKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x460C3A0", Offset = "0x460ADA0", VA = "0x18460C3A0")]
	public void MFMCNFFMIAP(byte[] PPJLGCLGPJE, int MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x460C270", Offset = "0x460AC70", VA = "0x18460C270")]
	public bool JDAHANPANHE(ArraySegment<byte> AIGAKEKDKHM, out int MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x460C4C0", Offset = "0x460AEC0", VA = "0x18460C4C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x460BFD0", Offset = "0x460A9D0", VA = "0x18460BFD0")]
	private static void IJLAMJPPGMG(IEnumerable<NNICOABICHJ> LAJIBKENJMO, StringBuilder CCLNHPOEGCA, int IFJOKNDLBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x460BF20", Offset = "0x460A920", VA = "0x18460BF20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x460BF20", Offset = "0x460A920", VA = "0x18460BF20", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x460C330", Offset = "0x460AD30", VA = "0x18460C330")]
	[IteratorStateMachine(typeof(KCKIBHOIJBA))]
	private static IEnumerable<KeyValuePair<string, int>> JIPCDODMEHD(IEnumerable<NNICOABICHJ> LAJIBKENJMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x460BEF0", Offset = "0x460A8F0", VA = "0x18460BEF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x500AFE0", Offset = "0x50099E0", VA = "0x18500AFE0")]
	public static ulong JKDHKJKOONK(byte[] PPJLGCLGPJE, ref int ADDILPEFEHP, ref int DEMLHIHNHGM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class PKFDHKCDGHM
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x52E6250", Offset = "0x52E4C50", VA = "0x1852E6250")]
	public static void OLOLAGONDMO(ref byte[] PPJLGCLGPJE, int ADDILPEFEHP, int BLLNGOIDILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x52E6140", Offset = "0x52E4B40", VA = "0x1852E6140")]
	public static void JNMGIBMEIOK(ref byte[] HEONDDEAIBL, int PJNHBAIDLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x52E6390", Offset = "0x52E4D90", VA = "0x1852E6390")]
	public static byte[] OOBPNEDGINM(byte[] EIAMEKHGGAJ, int PJNHBAIDLOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class CGCOODDFDMP
{
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x4603DE0", Offset = "0x46027E0", VA = "0x184603DE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E93460", Offset = "0x2E91E60", VA = "0x182E93460", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x698040", Offset = "0x696A40", VA = "0x180698040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x14A4AC0", Offset = "0x14A34C0", VA = "0x1814A4AC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x14A4C10", Offset = "0x14A3610", VA = "0x1814A4C10")]
		[DebuggerHidden]
		public EPPBENAIFAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x257C230", Offset = "0x257AC30", VA = "0x18257C230", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x257C4D0", Offset = "0x257AED0", VA = "0x18257C4D0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E5E4E0", Offset = "0x2E5CEE0", VA = "0x182E5E4E0")]
	public HGAEACDDEIG(int FHGNFGIEADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x2E5E510", Offset = "0x2E5CF10", VA = "0x182E5E510")]
	public HGAEACDDEIG(int FHGNFGIEADL, float LGNIFOODLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x2E5DB90", Offset = "0x2E5C590", VA = "0x182E5DB90")]
	public void MFMCNFFMIAP(byte[] AIGAKEKDKHM, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BFC0", Offset = "0x2E5A9C0", VA = "0x182E5BFC0")]
	private bool INHDNHEEEFI(byte[] AIGAKEKDKHM, T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x2E59F70", Offset = "0x2E58970", VA = "0x182E59F70")]
	public bool IDEDABPJLGL(ArraySegment<byte> AIGAKEKDKHM, out T MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x2E581A0", Offset = "0x2E56BA0", VA = "0x182E581A0")]
	private static ulong BDPPPICAIHN(byte[] FBHIPILAOBE, int ADDILPEFEHP, int FPLNDBJJHMM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x2E5D730", Offset = "0x2E5C130", VA = "0x182E5D730")]
	private static int MFFHFOHJCPH(int KDPBEKDPKLC, float LGNIFOODLEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2E58200", Offset = "0x2E56C00", VA = "0x182E58200", Slot = "4")]
	[IteratorStateMachine(typeof(global::HGAEACDDEIG<>.EPPBENAIFAH))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2571AE0", Offset = "0x25704E0", VA = "0x182571AE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x500D9C0", Offset = "0x500C3C0", VA = "0x18500D9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x500DB30", Offset = "0x500C530", VA = "0x18500DB30")]
	static OECBPBHIPIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x500DDB0", Offset = "0x500C7B0", VA = "0x18500DDB0")]
	public OECBPBHIPIE(byte[] KLGIPPDLHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x500DA10", Offset = "0x500C410", VA = "0x18500DA10")]
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
	[Cpp2IlInjected.Address(RVA = "0x5003190", Offset = "0x5001B90", VA = "0x185003190")]
	public KCDEOLKDJHM(ref Guid MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x5001D40", Offset = "0x5000740", VA = "0x185001D40")]
	public KCDEOLKDJHM(ref ArraySegment<byte> CBMJJGCKMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x5001BB0", Offset = "0x50005B0", VA = "0x185001BB0")]
	private static byte NHDEPCMECAP(byte[] PPJLGCLGPJE, int LCDIKANDMDG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5000750", Offset = "0x4FFF150", VA = "0x185000750")]
	private static byte IFPGNLFLJOA(byte LKLEFAIICIC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5000860", Offset = "0x4FFF260", VA = "0x185000860")]
	public void ILGFNCIGIKC(byte[] DICKNCEHGPP, int ADDILPEFEHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class JEDEFDCIFMM
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4FFD2D0", Offset = "0x4FFBCD0", VA = "0x184FFD2D0")]
	public static bool LAKDPHAOAJK(byte KOIHHAIHBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x4FFD260", Offset = "0x4FFBC60", VA = "0x184FFD260")]
	public static bool JMFBDHPKPOJ(byte KOIHHAIHBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x4FFD6B0", Offset = "0x4FFC0B0", VA = "0x184FFD6B0")]
	public static sbyte OEJIODCFHFI(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x4FFD5C0", Offset = "0x4FFBFC0", VA = "0x184FFD5C0")]
	public static short MNOELAFOIJN(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x4FFD2E0", Offset = "0x4FFBCE0", VA = "0x184FFD2E0")]
	public static int MAMJGCIBBDI(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x4FFBB50", Offset = "0x4FFA550", VA = "0x184FFBB50")]
	public static long AGKJMAEDDIA(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x4FFC830", Offset = "0x4FFB230", VA = "0x184FFC830")]
	public static byte ALLOGFBOPJE(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x4FFC910", Offset = "0x4FFB310", VA = "0x184FFC910")]
	public static ushort DJNLHIBIHAN(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x4FFD630", Offset = "0x4FFC030", VA = "0x184FFD630")]
	public static uint NHJCJHDIGJH(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x4FFC980", Offset = "0x4FFB380", VA = "0x184FFC980")]
	public static ulong FJLNLLKGCDA(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x4FFC8A0", Offset = "0x4FFB2A0", VA = "0x184FFC8A0")]
	public static float CBDLDEMIBAL(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x4FFD720", Offset = "0x4FFC120", VA = "0x184FFD720")]
	public static double OJFCEJPLDPM(byte[] PPJLGCLGPJE, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x4FFCA90", Offset = "0x4FFB490", VA = "0x184FFCA90")]
	public static int JHCKALKHKFD(ref byte[] DICKNCEHGPP, int ADDILPEFEHP, ulong MAKFNMHIJIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x4FFBC00", Offset = "0x4FFA600", VA = "0x184FFBC00")]
	public static int AGLANPICECC(ref byte[] DICKNCEHGPP, int ADDILPEFEHP, long MAKFNMHIJIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x4FFD350", Offset = "0x4FFBD50", VA = "0x184FFD350")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E7E10", VA = "0x1808E9410")]
		[DebuggerHidden]
		public NDGPIGDDAGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x52E2180", Offset = "0x52E0B80", VA = "0x1852E2180", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x52E1D20", Offset = "0x52E0720", VA = "0x1852E1D20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x52E2270", Offset = "0x52E0C70", VA = "0x1852E2270")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x52E22C0", Offset = "0x52E0CC0", VA = "0x1852E22C0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x52E2140", Offset = "0x52E0B40", VA = "0x1852E2140", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x52E2090", Offset = "0x52E0A90", VA = "0x1852E2090", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x52E2090", Offset = "0x52E0A90", VA = "0x1852E2090", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E7E10", VA = "0x1808E9410")]
		[DebuggerHidden]
		public GEBPAICNHPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x52DC100", Offset = "0x52DAB00", VA = "0x1852DC100", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x52DBCA0", Offset = "0x52DA6A0", VA = "0x1852DBCA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x52DC1F0", Offset = "0x52DABF0", VA = "0x1852DC1F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x52DC240", Offset = "0x52DAC40", VA = "0x1852DC240")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x52DC0C0", Offset = "0x52DAAC0", VA = "0x1852DC0C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x52DC010", Offset = "0x52DAA10", VA = "0x1852DC010", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x52DC010", Offset = "0x52DAA10", VA = "0x1852DC010", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x45F9FD0", Offset = "0x45F89D0", VA = "0x1845F9FD0")]
	public static bool MOCHLHJENHC(this TypeInfo MCLMFJEAHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x45F9E20", Offset = "0x45F8820", VA = "0x1845F9E20")]
	public static bool JPHPGOJJCIL(this TypeInfo MCLMFJEAHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x45F9D50", Offset = "0x45F8750", VA = "0x1845F9D50")]
	public static IEnumerable<PropertyInfo> DJAHMPABLDD(this Type MCLMFJEAHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x45F9F40", Offset = "0x45F8940", VA = "0x1845F9F40")]
	[IteratorStateMachine(typeof(NDGPIGDDAGM))]
	private static IEnumerable<PropertyInfo> KBONBIOPIJC(Type MCLMFJEAHEC, HashSet<string> EMFGAMIJJAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x45F9C80", Offset = "0x45F8680", VA = "0x1845F9C80")]
	public static IEnumerable<FieldInfo> DAAIANIPAMG(this Type MCLMFJEAHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x45FA090", Offset = "0x45F8A90", VA = "0x1845FA090")]
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
	[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x772F00", VA = "0x180774500")]
	public static string JFNIIILAJDC(string BBFEACHCBCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x52E5BD0", Offset = "0x52E45D0", VA = "0x1852E5BD0")]
	public static string IJODMBEICHF(string BBFEACHCBCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x52E59E0", Offset = "0x52E43E0", VA = "0x1852E59E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2681A60", Offset = "0x2680460", VA = "0x182681A60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x26819E0", Offset = "0x26803E0", VA = "0x1826819E0")]
		private int ICNBMEOIEJL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public BLFJMLAHMMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xD6AC50", Offset = "0xD69650", VA = "0x180D6AC50")]
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
	[Cpp2IlInjected.Address(RVA = "0x38A90D0", Offset = "0x38A7AD0", VA = "0x1838A90D0")]
	public AAONIJFMFPJ(int FHGNFGIEADL = 4, float LGNIFOODLEA = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x38A7DB0", Offset = "0x38A67B0", VA = "0x1838A7DB0")]
	public bool FKGKAEHMBPL(Type AIGAKEKDKHM, TValue MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x38A7D70", Offset = "0x38A6770", VA = "0x1838A7D70")]
	public bool FKGKAEHMBPL(Type AIGAKEKDKHM, Func<Type, TValue> PEPHABGEAMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x38A82B0", Offset = "0x38A6CB0", VA = "0x1838A82B0")]
	private bool INHDNHEEEFI(Type AIGAKEKDKHM, Func<Type, TValue> PEPHABGEAMJ, out TValue LECMNGJOLLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x38A8BF0", Offset = "0x38A75F0", VA = "0x1838A8BF0")]
	private bool PEIEDGPICCB(KIOGJLHJDDH[] BNKOKGFLPBI, Type DAMNFPONOLM, KIOGJLHJDDH MJGFMHKOBPD, Func<Type, TValue> PEPHABGEAMJ, out TValue LECMNGJOLLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x38A8010", Offset = "0x38A6A10", VA = "0x1838A8010")]
	public bool IDEDABPJLGL(Type AIGAKEKDKHM, out TValue MAKFNMHIJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x38A7EC0", Offset = "0x38A68C0", VA = "0x1838A7EC0")]
	public TValue GIKDDENMNIA(Type AIGAKEKDKHM, Func<Type, TValue> PEPHABGEAMJ)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2E5D730", Offset = "0x2E5C130", VA = "0x182E5D730")]
	private static int MFFHFOHJCPH(int KDPBEKDPKLC, float LGNIFOODLEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x38A8FB0", Offset = "0x38A79B0", VA = "0x1838A8FB0")]
	private static void PGNGJHEHCHH(ref KIOGJLHJDDH OBFHICHOBMG, KIOGJLHJDDH MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x38A8FB0", Offset = "0x38A79B0", VA = "0x1838A8FB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FFA4D0", Offset = "0x4FF8ED0", VA = "0x184FFA4D0")]
	public TypeBuilder BPDHHPJNGMI(string NBODBMLPNJA, TypeAttributes HCLFAPPIEMP, Type LFAIGCEGCPL, Type[] HODPCFFHCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x4FFA5A0", Offset = "0x4FF8FA0", VA = "0x184FFA5A0")]
	public IBELCNMFHJB(string OGFIIBBFPHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class DJBEOAADMBD
{
	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x4608250", Offset = "0x4606C50", VA = "0x184608250")]
	private static MethodInfo CMHMNIGOHEL(LambdaExpression FLFKCKCBIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x1C50010", Offset = "0x1C4EA10", VA = "0x181C50010")]
	public static MethodInfo FJMGBMMJEMO<T>(Expression<Func<T>> FLFKCKCBIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x1C50010", Offset = "0x1C4EA10", VA = "0x181C50010")]
	public static MethodInfo FJMGBMMJEMO<T, TR>(Expression<Func<T, TR>> FLFKCKCBIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x1C50010", Offset = "0x1C4EA10", VA = "0x181C50010")]
	public static MethodInfo FJMGBMMJEMO<T>(Expression<Action<T>> FLFKCKCBIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x1C50010", Offset = "0x1C4EA10", VA = "0x181C50010")]
	public static MethodInfo FJMGBMMJEMO<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> FLFKCKCBIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x1C50020", Offset = "0x1C4EA20", VA = "0x181C50020")]
	private static MemberInfo NHIOIBMEGIC<T>(Expression<T> CELBLIIOMDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x1C4FFB0", Offset = "0x1C4E9B0", VA = "0x181C4FFB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x460A4C0", Offset = "0x4608EC0", VA = "0x18460A4C0")]
	public FFEAOMNFHOI(ILGenerator CMJHMCJLHOK, int LJOFAPCHBHE, bool MMNGCKFNIJL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x460A430", Offset = "0x4608E30", VA = "0x18460A430")]
	public FFEAOMNFHOI(ILGenerator CMJHMCJLHOK, int LJOFAPCHBHE, Type MCLMFJEAHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x460A310", Offset = "0x4608D10", VA = "0x18460A310")]
	public void HGAAPDFKBMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class AINFFKKMKDG
{
	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x45F3360", Offset = "0x45F1D60", VA = "0x1845F3360")]
	public static void GPFCLAFKGBI(this ILGenerator CMJHMCJLHOK, int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x45F3590", Offset = "0x45F1F90", VA = "0x1845F3590")]
	public static void GPFCLAFKGBI(this ILGenerator CMJHMCJLHOK, LocalBuilder HDDHEKBJGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x45F2DD0", Offset = "0x45F17D0", VA = "0x1845F2DD0")]
	public static void BAAEHGBDCFB(this ILGenerator CMJHMCJLHOK, int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x45F3000", Offset = "0x45F1A00", VA = "0x1845F3000")]
	public static void BAAEHGBDCFB(this ILGenerator CMJHMCJLHOK, LocalBuilder HDDHEKBJGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x45F30C0", Offset = "0x45F1AC0", VA = "0x1845F30C0")]
	public static void DLMKCGBLPGL(this ILGenerator CMJHMCJLHOK, int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x45F31B0", Offset = "0x45F1BB0", VA = "0x1845F31B0")]
	public static void DLMKCGBLPGL(this ILGenerator CMJHMCJLHOK, LocalBuilder HDDHEKBJGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x45F3D50", Offset = "0x45F2750", VA = "0x1845F3D50")]
	public static void OENKLIGHBHM(this ILGenerator CMJHMCJLHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x45F32C0", Offset = "0x45F1CC0", VA = "0x1845F32C0")]
	public static void EBJLODLPFPB(this ILGenerator CMJHMCJLHOK, bool MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x45F35D0", Offset = "0x45F1FD0", VA = "0x1845F35D0")]
	public static void IMFJPNCFPFC(this ILGenerator CMJHMCJLHOK, int MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x45F2CE0", Offset = "0x45F16E0", VA = "0x1845F2CE0")]
	public static void AKIMOJHIPHA(this ILGenerator CMJHMCJLHOK, Type MCLMFJEAHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x45F3C10", Offset = "0x45F2610", VA = "0x1845F3C10")]
	public static void OAPIJAHHAOM(this ILGenerator CMJHMCJLHOK, Type MCLMFJEAHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x45F3D60", Offset = "0x45F2760", VA = "0x1845F3D60")]
	public static void PNNAKLFBMNB(this ILGenerator CMJHMCJLHOK, int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x45F3040", Offset = "0x45F1A40", VA = "0x1845F3040")]
	public static void DILJNAHOAGL(this ILGenerator CMJHMCJLHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x45F3B20", Offset = "0x45F2520", VA = "0x1845F3B20")]
	public static void LJHAAIGBEON(this ILGenerator CMJHMCJLHOK, int EBBLFLFCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x45F3A20", Offset = "0x45F2420", VA = "0x1845F3A20")]
	public static void KFLNKMFMBJL(this ILGenerator CMJHMCJLHOK, MethodInfo KKBIFPGOODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x45F3CC0", Offset = "0x45F26C0", VA = "0x1845F3CC0")]
	public static void OBICIGOEAFA(this ILGenerator CMJHMCJLHOK, FieldInfo EDJIGPKMFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x45F32D0", Offset = "0x45F1CD0", VA = "0x1845F32D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public LEKMKDLHOPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x52DFA40", Offset = "0x52DE440", VA = "0x1852DFA40")]
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
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695B30", VA = "0x180697130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string NBFIMHBMOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x697140", Offset = "0x695B40", VA = "0x180697140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IPLGHFJKMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x4FFAC10", Offset = "0x4FF9610", VA = "0x184FFAC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MPEIKBLCJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6923D0", Offset = "0x690DD0", VA = "0x1806923D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782040", VA = "0x180783640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool AIEGLBKLNDD
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6923E0", Offset = "0x690DE0", VA = "0x1806923E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xCF4680", Offset = "0xCF3080", VA = "0x180CF4680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type PJDKMJMOPHN
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6902E0", VA = "0x1806918E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6B91C0", Offset = "0x6B7BC0", VA = "0x1806B91C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo ABDHCIBKNGB
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C0F0", VA = "0x18068D6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x70FAE0", Offset = "0x70E4E0", VA = "0x18070FAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo DPIKBEILBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x67E570", Offset = "0x67CF70", VA = "0x18067E570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x67E590", Offset = "0x67CF90", VA = "0x18067E590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo NMJKHDJLAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x67E580", Offset = "0x67CF80", VA = "0x18067E580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x67E5A0", Offset = "0x67CFA0", VA = "0x18067E5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x4FFAF60", Offset = "0x4FF9960", VA = "0x184FFAF60")]
	protected IFOAMENKCOO(Type MCLMFJEAHEC, string NBODBMLPNJA, string CHAHHBDIPFA, bool LOLENBCPOOF, bool ICDAINBFCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x4FFAE50", Offset = "0x4FF9850", VA = "0x184FFAE50")]
	public IFOAMENKCOO(FieldInfo LLEGACMOBNC, string NBODBMLPNJA, bool GJDLJHDGNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x4FFAFE0", Offset = "0x4FF99E0", VA = "0x184FFAFE0")]
	public IFOAMENKCOO(PropertyInfo LLEGACMOBNC, string NBODBMLPNJA, bool GJDLJHDGNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x4FFACE0", Offset = "0x4FF96E0", VA = "0x184FFACE0")]
	private static MethodInfo NPJMLEIPGOP(MemberInfo LLEGACMOBNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x25F0350", Offset = "0x25EED50", VA = "0x1825F0350")]
	public T FAGMMCJHJMN<T>(bool NMHKPEOPNLB) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x4FFAC20", Offset = "0x4FF9620", VA = "0x184FFAC20", Slot = "4")]
	public virtual void NKHBGKDKJID(ILGenerator CMJHMCJLHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x4FFAB50", Offset = "0x4FF9550", VA = "0x184FFAB50", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x500E2C0", Offset = "0x500CCC0", VA = "0x18500E2C0")]
	public OEJNOGBKBBO(string NBODBMLPNJA, string ICOCCBBOKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x500E200", Offset = "0x500CC00", VA = "0x18500E200", Slot = "4")]
	public override void NKHBGKDKJID(ILGenerator CMJHMCJLHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x500E1C0", Offset = "0x500CBC0", VA = "0x18500E1C0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FF73E0", Offset = "0x4FF5DE0", VA = "0x184FF73E0")]
	public GGHHLOOJILA(string NBODBMLPNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6DC0", Offset = "0x4FF57C0", VA = "0x184FF6DC0", Slot = "4")]
	public override void NKHBGKDKJID(ILGenerator CMJHMCJLHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6C60", Offset = "0x4FF5660", VA = "0x184FF6C60", Slot = "5")]
	public override void DKFELECIFNP(ILGenerator CMJHMCJLHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6CA0", Offset = "0x4FF56A0", VA = "0x184FF6CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695B30", VA = "0x180697130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool JNNCIFLOGLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6918D0", Offset = "0x6902D0", VA = "0x1806918D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6B3000", Offset = "0x6B1A00", VA = "0x1806B3000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool HABFNJAAJBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x80EFB0", Offset = "0x80D9B0", VA = "0x18080EFB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xCC3B70", Offset = "0xCC2570", VA = "0x180CC3B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo BENEBDNCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676B30", VA = "0x180678130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IFOAMENKCOO[] BNCBCAJGGHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6902E0", VA = "0x1806918E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6B91C0", Offset = "0x6B7BC0", VA = "0x1806B91C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public IFOAMENKCOO[] CJMLECFAHHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C0F0", VA = "0x18068D6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x70FAE0", Offset = "0x70E4E0", VA = "0x18070FAE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x45F61D0", Offset = "0x45F4BD0", VA = "0x1845F61D0")]
	public BJNFMKPBJKP(Type MCLMFJEAHEC, Func<string, string> JCBDNGCBGOP, bool GJDLJHDGNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x45F60E0", Offset = "0x45F4AE0", VA = "0x1845F60E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1E23EB0", Offset = "0x1E228B0", VA = "0x181E23EB0")]
	public OBBBGHPOLIJ(ulong DBMIFPDCJCG, int JDLIPKOKKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x500D9B0", Offset = "0x500C3B0", VA = "0x18500D9B0")]
	public void OKBPINBPKJA(ref OBBBGHPOLIJ OANENNOJEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x500D900", Offset = "0x500C300", VA = "0x18500D900")]
	public static OBBBGHPOLIJ GPBMEDNCLBL(ref OBBBGHPOLIJ IKAMJBDPPHG, ref OBBBGHPOLIJ LKLEFAIICIC)
	{
		return default(OBBBGHPOLIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x500D870", Offset = "0x500C270", VA = "0x18500D870")]
	public void GIKIAOHNAED(ref OBBBGHPOLIJ OANENNOJEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x500D910", Offset = "0x500C310", VA = "0x18500D910")]
	public static OBBBGHPOLIJ ODEKOCBCJCH(ref OBBBGHPOLIJ IKAMJBDPPHG, ref OBBBGHPOLIJ LKLEFAIICIC)
	{
		return default(OBBBGHPOLIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x500D7E0", Offset = "0x500C1E0", VA = "0x18500D7E0")]
	public void FFLFILBHPNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x500D820", Offset = "0x500C220", VA = "0x18500D820")]
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
	[Cpp2IlInjected.Address(RVA = "0x7765B0", Offset = "0x774FB0", VA = "0x1807765B0")]
	public EHAIFLPLHKN(byte[] DICKNCEHGPP, int EINGNKDKDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x4609300", Offset = "0x4607D00", VA = "0x184609300")]
	public void BMHPGGHJEAE(byte FLFBAMENJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x46094E0", Offset = "0x4607EE0", VA = "0x1846094E0")]
	public void KBGKLICOPBA(byte[] FLFBAMENJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x46091B0", Offset = "0x4607BB0", VA = "0x1846091B0")]
	public void BEACDIAEDKB(byte[] FLFBAMENJLF, int JKABHKIANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x4609250", Offset = "0x4607C50", VA = "0x184609250")]
	public void BEACDIAEDKB(byte[] FLFBAMENJLF, int LJECKBCMELA, int JKABHKIANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x4609460", Offset = "0x4607E60", VA = "0x184609460")]
	public void JOCCDODMKIH(byte KOIHHAIHBKH, int FPLNDBJJHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x4609360", Offset = "0x4607D60", VA = "0x184609360")]
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
	[Cpp2IlInjected.Address(RVA = "0x45F8410", Offset = "0x45F6E10", VA = "0x1845F8410")]
	private static byte[] EFPAHKMPJIH(int JLMAIAGOBFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x45F7CF0", Offset = "0x45F66F0", VA = "0x1845F7CF0")]
	private static byte[] DLAHLFFJEHP(int JLMAIAGOBFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x45F8F20", Offset = "0x45F7920", VA = "0x1845F8F20")]
	public static int KCDBGMIDMMC(ref byte[] DICKNCEHGPP, int ADDILPEFEHP, float MAKFNMHIJIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x45F8E00", Offset = "0x45F7800", VA = "0x1845F8E00")]
	public static int KCDBGMIDMMC(ref byte[] DICKNCEHGPP, int ADDILPEFEHP, double MAKFNMHIJIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x45F9480", Offset = "0x45F7E80", VA = "0x1845F9480")]
	private static bool PDDHAIEDEGG(byte[] DICKNCEHGPP, int JKABHKIANJL, ulong JCFOKFICIME, ulong DJAOOKCDEPA, ulong DEMLHIHNHGM, ulong PMOIGPHCNIB, ulong HKOGNEKGKGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x45F9360", Offset = "0x45F7D60", VA = "0x1845F9360")]
	private static void OPHAMHLJGFH(uint IGDJCLNCEKA, int FELIHPCMDDO, out uint CEMPLPOIHPN, out int EHCPBFPHIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x45F88E0", Offset = "0x45F72E0", VA = "0x1845F88E0")]
	private static bool JAEBNHOKBFG(OBBBGHPOLIJ PDOCAJOFLNF, OBBBGHPOLIJ JNLBJEDABNH, OBBBGHPOLIJ GFKAHIKNEOM, byte[] DICKNCEHGPP, out int JKABHKIANJL, out int IKHHFJJOGJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x45F8600", Offset = "0x45F7000", VA = "0x1845F8600")]
	private static bool GHMLFNJKJGO(double HIGLPPEBKMI, DFBCEMFOJAK OLBBMHHLPIG, byte[] DICKNCEHGPP, out int JKABHKIANJL, out int IKJDKJANJNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x45F84F0", Offset = "0x45F6EF0", VA = "0x1845F84F0")]
	private static bool GBEEIGILGLP(double HIGLPPEBKMI, DFBCEMFOJAK OLBBMHHLPIG, byte[] DICKNCEHGPP, out int JKABHKIANJL, out int FLMCCCJLBNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x45F9040", Offset = "0x45F7A40", VA = "0x1845F9040")]
	private static bool KOPOBODMLJF(double MAKFNMHIJIF, ref EHAIFLPLHKN HFKLAMKHHHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x45F7DD0", Offset = "0x45F67D0", VA = "0x1845F7DD0")]
	private static bool DMMMHJOEDDN(double MAKFNMHIJIF, ref EHAIFLPLHKN HFKLAMKHHHE, EPOCIMJNMEK OLBBMHHLPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x45F9580", Offset = "0x45F7F80", VA = "0x1845F9580")]
	private static void PPLCCOLNKFL(byte[] DCJBFFJEKPP, int JKABHKIANJL, int FLMCCCJLBNJ, int EHEIGMMMBEC, ref EHAIFLPLHKN HFKLAMKHHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x45F77C0", Offset = "0x45F61C0", VA = "0x1845F77C0")]
	private static void BCJPNCLKMLB(byte[] DCJBFFJEKPP, int JKABHKIANJL, int JDLIPKOKKNG, ref EHAIFLPLHKN HFKLAMKHHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x45F91D0", Offset = "0x45F7BD0", VA = "0x1845F91D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4608B40", Offset = "0x4607540", VA = "0x184608B40")]
	public DNIKOOHCJFG(double OECCBELLJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x4608B50", Offset = "0x4607550", VA = "0x184608B50")]
	public DNIKOOHCJFG(OBBBGHPOLIJ OECCBELLJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4608630", Offset = "0x4607030", VA = "0x184608630")]
	public OBBBGHPOLIJ DCKGCDNAEEN()
	{
		return default(OBBBGHPOLIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x46088A0", Offset = "0x46072A0", VA = "0x1846088A0")]
	public OBBBGHPOLIJ GFPILIIMKEL()
	{
		return default(OBBBGHPOLIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675A00", VA = "0x180677000")]
	public ulong NNEFHHKICNI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x46085A0", Offset = "0x4606FA0", VA = "0x1846085A0")]
	public double CGOEKCAMIJI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x46089F0", Offset = "0x46073F0", VA = "0x1846089F0")]
	public double LBGIIACKNLB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x4608A90", Offset = "0x4607490", VA = "0x184608A90")]
	public int LIPBBACIPMO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x4608550", Offset = "0x4606F50", VA = "0x184608550")]
	public ulong AENNAIHPIHM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x4608AC0", Offset = "0x46074C0", VA = "0x184608AC0")]
	public bool MAIKOGKLIOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x4608AF0", Offset = "0x46074F0", VA = "0x184608AF0")]
	public bool MGNBGMPLNGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x4608700", Offset = "0x4607100", VA = "0x184608700")]
	public bool FPOIGBKBACL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x4608B10", Offset = "0x4607510", VA = "0x184608B10")]
	public bool NAKMEBBFKCH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x46089D0", Offset = "0x46073D0", VA = "0x1846089D0")]
	public int JPMGOLKMJJH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x4608730", Offset = "0x4607130", VA = "0x184608730")]
	public void GCJCGOHCADJ(out OBBBGHPOLIJ JEHCANNCAJH, out OBBBGHPOLIJ FAEHHLILMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x46086B0", Offset = "0x46070B0", VA = "0x1846086B0")]
	public bool DEOOLJMBGLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x4608AE0", Offset = "0x46074E0", VA = "0x184608AE0")]
	public double MAKFNMHIJIF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x4608580", Offset = "0x4606F80", VA = "0x184608580")]
	public static int BPIJAOICMAB(int CNCOAGMOALJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x4608A80", Offset = "0x4607480", VA = "0x184608A80")]
	public static double LGJPDJOELKM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x4608930", Offset = "0x4607330", VA = "0x184608930")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CE3040", Offset = "0x2CE1A40", VA = "0x182CE3040")]
	public MDHFOOCIBAI(float FAHPBJHMFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x5004F60", Offset = "0x5003960", VA = "0x185004F60")]
	public OBBBGHPOLIJ DCKGCDNAEEN()
	{
		return default(OBBBGHPOLIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x728E20", Offset = "0x727820", VA = "0x180728E20")]
	public uint KOCHFOCAODJ()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5005130", Offset = "0x5003B30", VA = "0x185005130")]
	public int LIPBBACIPMO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x5004F40", Offset = "0x5003940", VA = "0x185004F40")]
	public uint AENNAIHPIHM()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x5005150", Offset = "0x5003B50", VA = "0x185005150")]
	public bool MAIKOGKLIOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5005000", Offset = "0x5003A00", VA = "0x185005000")]
	public void GCJCGOHCADJ(out OBBBGHPOLIJ JEHCANNCAJH, out OBBBGHPOLIJ FAEHHLILMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5004FC0", Offset = "0x50039C0", VA = "0x185004FC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FFA6A0", Offset = "0x4FF90A0", VA = "0x184FFA6A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5007890", Offset = "0x5006290", VA = "0x185007890")]
	public static void GNIKPDPOKBE(int IDPGABJGIHL, int IEKFJNGHAIB, out OBBBGHPOLIJ CEMPLPOIHPN, out int IKJDKJANJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x50077A0", Offset = "0x50061A0", VA = "0x1850077A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x45F2160", Offset = "0x45F0B60", VA = "0x1845F2160")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0xCB2250", Offset = "0xCB0C50", VA = "0x180CB2250")]
	public AAJJPCMHHOE(byte[] PPJLGCLGPJE, int LJECKBCMELA, int JKABHKIANJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x76FA40", Offset = "0x76E440", VA = "0x18076FA40")]
	public int JKABHKIANJL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x45F21A0", Offset = "0x45F0BA0", VA = "0x1845F21A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x500C040", Offset = "0x500AA40", VA = "0x18500C040")]
	private static byte[] AOFDOAJCGBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x500CA00", Offset = "0x500B400", VA = "0x18500CA00")]
	private static AAJJPCMHHOE KJOPPKMAFKO(AAJJPCMHHOE DICKNCEHGPP)
	{
		return default(AAJJPCMHHOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x500D290", Offset = "0x500BC90", VA = "0x18500D290")]
	private static AAJJPCMHHOE NGGJGPAGDJA(AAJJPCMHHOE DICKNCEHGPP)
	{
		return default(AAJJPCMHHOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x500C6D0", Offset = "0x500B0D0", VA = "0x18500C6D0")]
	private static void FOMANHLCAKI(AAJJPCMHHOE DICKNCEHGPP, int JDLIPKOKKNG, byte[] BGCGGOOEPFB, out int BJGNHGFKALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x500C250", Offset = "0x500AC50", VA = "0x18500C250")]
	private static void EEFKHMNECGN(AAJJPCMHHOE DICKNCEHGPP, int JDLIPKOKKNG, byte[] FJEGAJOCFPD, int LAEDAPMLMLG, out AAJJPCMHHOE CEDLKAOONBP, out int BDJGHNLLJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x500D070", Offset = "0x500BA70", VA = "0x18500D070")]
	private static ulong MLJCBPFHJLA(AAJJPCMHHOE DICKNCEHGPP, out int FCICOPIKGNE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x500C790", Offset = "0x500B190", VA = "0x18500C790")]
	private static void HEOADANKCDH(AAJJPCMHHOE DICKNCEHGPP, out OBBBGHPOLIJ BIDLMNEFHJM, out int BHNEKBECJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x500D340", Offset = "0x500BD40", VA = "0x18500D340")]
	private static bool OFFCKAPPDOH(AAJJPCMHHOE CEDLKAOONBP, int JDLIPKOKKNG, out double BIDLMNEFHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x500D100", Offset = "0x500BB00", VA = "0x18500D100")]
	private static OBBBGHPOLIJ NFLPCIKEAOA(int JDLIPKOKKNG)
	{
		return default(OBBBGHPOLIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x500CAB0", Offset = "0x500B4B0", VA = "0x18500CAB0")]
	private static bool LLDJFEJNLDC(AAJJPCMHHOE DICKNCEHGPP, int JDLIPKOKKNG, out double BIDLMNEFHJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x500C8C0", Offset = "0x500B2C0", VA = "0x18500C8C0")]
	private static bool IGKJAACBFPO(AAJJPCMHHOE CEDLKAOONBP, int JDLIPKOKKNG, out double HDMJNBAOCEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x500C130", Offset = "0x500AB30", VA = "0x18500C130")]
	public static double? CPMGPCIOHAO(AAJJPCMHHOE DICKNCEHGPP, int JDLIPKOKKNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x500C4F0", Offset = "0x500AEF0", VA = "0x18500C4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x45F5EA0", Offset = "0x45F48A0", VA = "0x1845F5EA0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7765B0", Offset = "0x774FB0", VA = "0x1807765B0")]
	public BIJCEJCICKB(byte[] DICKNCEHGPP, int ADDILPEFEHP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x45F6010", Offset = "0x45F4A10", VA = "0x1845F6010")]
	public static BIJCEJCICKB KAOMIEDAFGL(BIJCEJCICKB DKOFBKPNBJK)
	{
		return default(BIJCEJCICKB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x45F5E50", Offset = "0x45F4850", VA = "0x1845F5E50")]
	public static BIJCEJCICKB CPMGNAGFNGK(BIJCEJCICKB DKOFBKPNBJK, int JKABHKIANJL)
	{
		return default(BIJCEJCICKB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x45F6070", Offset = "0x45F4A70", VA = "0x1845F6070")]
	public static int NBCCFCPLHOF(BIJCEJCICKB OLACFPEGPAG, BIJCEJCICKB GLLCOOLKDAC)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x45F5FF0", Offset = "0x45F49F0", VA = "0x1845F5FF0")]
	public static bool GBIPOJBPNDJ(BIJCEJCICKB OLACFPEGPAG, BIJCEJCICKB GLLCOOLKDAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x45F5EE0", Offset = "0x45F48E0", VA = "0x1845F5EE0")]
	public static bool EOCJAGBGMLJ(BIJCEJCICKB OLACFPEGPAG, BIJCEJCICKB GLLCOOLKDAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x45F5FA0", Offset = "0x45F49A0", VA = "0x1845F5FA0")]
	public static bool GBIPOJBPNDJ(BIJCEJCICKB OLACFPEGPAG, char GLLCOOLKDAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x45F5F00", Offset = "0x45F4900", VA = "0x1845F5F00")]
	public static bool EOCJAGBGMLJ(BIJCEJCICKB OLACFPEGPAG, char GLLCOOLKDAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x45F5F00", Offset = "0x45F4900", VA = "0x1845F5F00")]
	public static bool EOCJAGBGMLJ(BIJCEJCICKB OLACFPEGPAG, byte GLLCOOLKDAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x45F6020", Offset = "0x45F4A20", VA = "0x1845F6020")]
	public static bool MAJJADLIHIE(BIJCEJCICKB OLACFPEGPAG, char GLLCOOLKDAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x45F5F50", Offset = "0x45F4950", VA = "0x1845F5F50")]
	public static bool FLEEJIFHDMB(BIJCEJCICKB OLACFPEGPAG, char GLLCOOLKDAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x45F6090", Offset = "0x45F4A90", VA = "0x1845F6090")]
	public static bool NDLMCDHDFOE(BIJCEJCICKB OLACFPEGPAG, char GLLCOOLKDAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x45F5E00", Offset = "0x45F4800", VA = "0x1845F5E00")]
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
	[Cpp2IlInjected.Address(RVA = "0x460B9B0", Offset = "0x460A3B0", VA = "0x18460B9B0")]
	private static byte[] ODOMBKDHBOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x460B680", Offset = "0x460A080", VA = "0x18460B680")]
	private static byte[] ECHFODJGDOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x460B8F0", Offset = "0x460A2F0", VA = "0x18460B8F0")]
	public static double HKELMFEFMPC(byte[] DICKNCEHGPP, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x460BBC0", Offset = "0x460A5C0", VA = "0x18460BBC0")]
	public static float PNKBNOOBFCG(byte[] DICKNCEHGPP, int ADDILPEFEHP, out int EECJBCMCEBK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x460B500", Offset = "0x4609F00", VA = "0x18460B500")]
	private static bool DLOHLHONGGG(int FBHIPILAOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x460B7D0", Offset = "0x460A1D0", VA = "0x18460B7D0")]
	private static bool GNKEDODFEHE(ref BIJCEJCICKB OBFMOAOGODB, BIJCEJCICKB EAJAFIHJLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x460BAA0", Offset = "0x460A4A0", VA = "0x18460BAA0")]
	private static bool OEBCGPKNODE(ref BIJCEJCICKB OBFMOAOGODB, BIJCEJCICKB EAJAFIHJLHG, byte[] JPIJPAFCBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x460B770", Offset = "0x460A170", VA = "0x18460B770")]
	private static bool GEMAPPEHEPJ(ref BIJCEJCICKB IHBKJCKEAHH, byte[] FLFBAMENJLF, int ADDILPEFEHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x460B4E0", Offset = "0x4609EE0", VA = "0x18460B4E0")]
	private static double DAEENBOFIII(bool DFGBDOPACOO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x460A560", Offset = "0x4608F60", VA = "0x18460A560")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C19AC0", Offset = "0x2C184C0", VA = "0x182C19AC0")]
	public NIBIMJBILFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x14A4C10", Offset = "0x14A3610", VA = "0x1814A4C10")]
	public NIBIMJBILFH(HCMHKFNLMLF OOIPMPKNHAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2C19780", Offset = "0x2C18180", VA = "0x182C19780", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2C18720", Offset = "0x2C17120", VA = "0x182C18720", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C19AC0", Offset = "0x2C184C0", VA = "0x182C19AC0")]
	public JJJCNFLMMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x14A4C10", Offset = "0x14A3610", VA = "0x1814A4C10")]
	public JJJCNFLMMLJ(HCMHKFNLMLF OOIPMPKNHAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x33142E0", Offset = "0x3312CE0", VA = "0x1833142E0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, List<T> MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3313CD0", Offset = "0x33126D0", VA = "0x183313CD0", Slot = "5")]
	public List<T> FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class EIANHLKFFNI<TElement, TIntermediate, TEnumerator, TCollection> : global::AMLJDOHMGLI<TCollection>, HAOPHHJJNOJ where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x290C230", Offset = "0x290AC30", VA = "0x18290C230", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, TCollection MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x290C030", Offset = "0x290AA30", VA = "0x18290C030", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
	protected EIANHLKFFNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class IELPNHCIPOF<TElement, TIntermediate, TCollection> : global::EIANHLKFFNI<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2796630", Offset = "0x2795030", VA = "0x182796630", Slot = "6")]
	protected override IEnumerator<TElement> HHAKIOELJAB(TCollection CELBLIIOMDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x1562240", Offset = "0x1560C40", VA = "0x181562240")]
	protected IELPNHCIPOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class DLGJPJHKNPN<TElement, TCollection> : global::IELPNHCIPOF<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x101E930", Offset = "0x101D330", VA = "0x18101E930", Slot = "9")]
	protected sealed override TCollection ADFDICGOODJ(ref TCollection MCLDBIFAHBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class MGCMBEPOFOA<TElement, TCollection> : global::DLGJPJHKNPN<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2E976B0", Offset = "0x2E960B0", VA = "0x182E976B0", Slot = "7")]
	protected override TCollection CBFHJGEFJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2E976D0", Offset = "0x2E960D0", VA = "0x182E976D0", Slot = "8")]
	protected override void MFMCNFFMIAP(ref TCollection JAMIHJHDKEO, int EBBLFLFCHFB, TElement MAKFNMHIJIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class AJEIIEFFNHF<T> : global::EIANHLKFFNI<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2E95FF0", Offset = "0x2E949F0", VA = "0x182E95FF0", Slot = "8")]
	protected override void MFMCNFFMIAP(ref LinkedList<T> JAMIHJHDKEO, int EBBLFLFCHFB, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x101E930", Offset = "0x101D330", VA = "0x18101E930", Slot = "9")]
	protected override LinkedList<T> ADFDICGOODJ(ref LinkedList<T> MCLDBIFAHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B400", Offset = "0x1E29E00", VA = "0x181E2B400", Slot = "7")]
	protected override LinkedList<T> CBFHJGEFJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B4B0", Offset = "0x1E29EB0", VA = "0x181E2B4B0", Slot = "6")]
	protected override LinkedList<T>.Enumerator HHAKIOELJAB(LinkedList<T> CELBLIIOMDE)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class AGJDIPMPBIJ<T> : global::EIANHLKFFNI<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2E95FF0", Offset = "0x2E949F0", VA = "0x182E95FF0", Slot = "8")]
	protected override void MFMCNFFMIAP(ref Queue<T> JAMIHJHDKEO, int EBBLFLFCHFB, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B400", Offset = "0x1E29E00", VA = "0x181E2B400", Slot = "7")]
	protected override Queue<T> CBFHJGEFJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2E95FA0", Offset = "0x2E949A0", VA = "0x182E95FA0", Slot = "6")]
	protected override Queue<T>.Enumerator HHAKIOELJAB(Queue<T> CELBLIIOMDE)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x101E930", Offset = "0x101D330", VA = "0x18101E930", Slot = "9")]
	protected override Queue<T> ADFDICGOODJ(ref Queue<T> MCLDBIFAHBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class MLFNAGLIOGG<T> : global::EIANHLKFFNI<T, global::BIMCCMIHDOH<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x1E26D10", Offset = "0x1E25710", VA = "0x181E26D10", Slot = "8")]
	protected override void MFMCNFFMIAP(ref global::BIMCCMIHDOH<T> JAMIHJHDKEO, int EBBLFLFCHFB, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x1E26CD0", Offset = "0x1E256D0", VA = "0x181E26CD0", Slot = "7")]
	protected override global::BIMCCMIHDOH<T> CBFHJGEFJHE()
	{
		return default(global::BIMCCMIHDOH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2E95FA0", Offset = "0x2E949A0", VA = "0x182E95FA0", Slot = "6")]
	protected override Stack<T>.Enumerator HHAKIOELJAB(Stack<T> CELBLIIOMDE)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x2EACD10", Offset = "0x2EAB710", VA = "0x182EACD10", Slot = "9")]
	protected override Stack<T> ADFDICGOODJ(ref global::BIMCCMIHDOH<T> MCLDBIFAHBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class MDPLEIABDKH<T> : global::EIANHLKFFNI<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2E95FF0", Offset = "0x2E949F0", VA = "0x182E95FF0", Slot = "8")]
	protected override void MFMCNFFMIAP(ref HashSet<T> JAMIHJHDKEO, int EBBLFLFCHFB, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x101E930", Offset = "0x101D330", VA = "0x18101E930", Slot = "9")]
	protected override HashSet<T> ADFDICGOODJ(ref HashSet<T> MCLDBIFAHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B400", Offset = "0x1E29E00", VA = "0x181E2B400", Slot = "7")]
	protected override HashSet<T> CBFHJGEFJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2E95FA0", Offset = "0x2E949A0", VA = "0x182E95FA0", Slot = "6")]
	protected override HashSet<T>.Enumerator HHAKIOELJAB(HashSet<T> CELBLIIOMDE)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class PKCPKKPNKJL<T> : global::IELPNHCIPOF<T, global::BIMCCMIHDOH<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x1E26D10", Offset = "0x1E25710", VA = "0x181E26D10", Slot = "8")]
	protected override void MFMCNFFMIAP(ref global::BIMCCMIHDOH<T> JAMIHJHDKEO, int EBBLFLFCHFB, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x317CE10", Offset = "0x317B810", VA = "0x18317CE10", Slot = "9")]
	protected override ReadOnlyCollection<T> ADFDICGOODJ(ref global::BIMCCMIHDOH<T> MCLDBIFAHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x317CEA0", Offset = "0x317B8A0", VA = "0x18317CEA0", Slot = "7")]
	protected override global::BIMCCMIHDOH<T> CBFHJGEFJHE()
	{
		return default(global::BIMCCMIHDOH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class JKKJNKIKJNK<T> : global::IELPNHCIPOF<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2E95FF0", Offset = "0x2E949F0", VA = "0x182E95FF0", Slot = "8")]
	protected override void MFMCNFFMIAP(ref List<T> JAMIHJHDKEO, int EBBLFLFCHFB, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B400", Offset = "0x1E29E00", VA = "0x181E2B400", Slot = "7")]
	protected override List<T> CBFHJGEFJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x101E930", Offset = "0x101D330", VA = "0x18101E930", Slot = "9")]
	protected override IList<T> ADFDICGOODJ(ref List<T> MCLDBIFAHBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class HKKMDPPMNDL<T> : global::IELPNHCIPOF<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2E95FF0", Offset = "0x2E949F0", VA = "0x182E95FF0", Slot = "8")]
	protected override void MFMCNFFMIAP(ref List<T> JAMIHJHDKEO, int EBBLFLFCHFB, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B400", Offset = "0x1E29E00", VA = "0x181E2B400", Slot = "7")]
	protected override List<T> CBFHJGEFJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x101E930", Offset = "0x101D330", VA = "0x18101E930", Slot = "9")]
	protected override ICollection<T> ADFDICGOODJ(ref List<T> MCLDBIFAHBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class LECGAGBOLNP<T> : global::IELPNHCIPOF<T, global::BIMCCMIHDOH<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x1E26D10", Offset = "0x1E25710", VA = "0x181E26D10", Slot = "8")]
	protected override void MFMCNFFMIAP(ref global::BIMCCMIHDOH<T> JAMIHJHDKEO, int EBBLFLFCHFB, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x1E26CD0", Offset = "0x1E256D0", VA = "0x181E26CD0", Slot = "7")]
	protected override global::BIMCCMIHDOH<T> CBFHJGEFJHE()
	{
		return default(global::BIMCCMIHDOH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x1E26CB0", Offset = "0x1E256B0", VA = "0x181E26CB0", Slot = "9")]
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
	[Cpp2IlInjected.Address(RVA = "0x290B980", Offset = "0x290A380", VA = "0x18290B980", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x290B770", Offset = "0x290A170", VA = "0x18290B770", Slot = "5")]
	public T FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
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
	[Cpp2IlInjected.Address(RVA = "0x4608F00", Offset = "0x4607900", VA = "0x184608F00", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, IEnumerable MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x4608D50", Offset = "0x4607750", VA = "0x184608D50", Slot = "5")]
	public IEnumerable FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x500A9C0", Offset = "0x50093C0", VA = "0x18500A9C0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, ICollection MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x500A810", Offset = "0x5009210", VA = "0x18500A810", Slot = "5")]
	public ICollection FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4604020", Offset = "0x4602A20", VA = "0x184604020", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, IList MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x4603E70", Offset = "0x4602870", VA = "0x184603E70", Slot = "5")]
	public IList FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public CIIGOFOCBKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class LIBNDNEPJGJ<T> : global::IELPNHCIPOF<T, global::BIMCCMIHDOH<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x22562E0", Offset = "0x2254CE0", VA = "0x1822562E0", Slot = "8")]
	protected override void MFMCNFFMIAP(ref global::BIMCCMIHDOH<T> JAMIHJHDKEO, int EBBLFLFCHFB, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x1E26CD0", Offset = "0x1E256D0", VA = "0x181E26CD0", Slot = "7")]
	protected override global::BIMCCMIHDOH<T> CBFHJGEFJHE()
	{
		return default(global::BIMCCMIHDOH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x22562A0", Offset = "0x2254CA0", VA = "0x1822562A0", Slot = "9")]
	protected override IReadOnlyList<T> ADFDICGOODJ(ref global::BIMCCMIHDOH<T> MCLDBIFAHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x220F690", Offset = "0x220E090", VA = "0x18220F690")]
	public LIBNDNEPJGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class OKMMPMCHBLP
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x500E4D0", Offset = "0x500CED0", VA = "0x18500E4D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x460DA10", Offset = "0x460C410", VA = "0x18460DA10", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, DateTime MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x460CAB0", Offset = "0x460B4B0", VA = "0x18460CAB0", Slot = "5")]
	public DateTime FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5006860", Offset = "0x5005260", VA = "0x185006860", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, DateTimeOffset MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x5005990", Offset = "0x5004390", VA = "0x185005990", Slot = "5")]
	public DateTimeOffset FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x500EF90", Offset = "0x500D990", VA = "0x18500EF90", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, TimeSpan MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x500E6D0", Offset = "0x500D0D0", VA = "0x18500E6D0", Slot = "5")]
	public TimeSpan FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public OOINCALGFPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class OOPMNGMGNHB<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::AMLJDOHMGLI<TDictionary>, HAOPHHJJNOJ where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3B31E70", Offset = "0x3B30870", VA = "0x183B31E70", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, TDictionary MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x3B30A10", Offset = "0x3B2F410", VA = "0x183B30A10", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
	protected OOPMNGMGNHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class FKHOBFFCOAF<TKey, TValue, TIntermediate, TDictionary> : global::OOPMNGMGNHB<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2796630", Offset = "0x2795030", VA = "0x182796630", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> HHAKIOELJAB(TDictionary CELBLIIOMDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class GDPNACEIHOA<TKey, TValue, TDictionary> : global::FKHOBFFCOAF<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x101E930", Offset = "0x101D330", VA = "0x18101E930", Slot = "9")]
	protected override TDictionary ADFDICGOODJ(ref TDictionary MCLDBIFAHBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class LELIHNAFBCO<TKey, TValue> : global::OOPMNGMGNHB<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B510", Offset = "0x1E29F10", VA = "0x181E2B510", Slot = "8")]
	protected override void MFMCNFFMIAP(ref Dictionary<TKey, TValue> JAMIHJHDKEO, int EBBLFLFCHFB, TKey AIGAKEKDKHM, TValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x101E930", Offset = "0x101D330", VA = "0x18101E930", Slot = "9")]
	protected override Dictionary<TKey, TValue> ADFDICGOODJ(ref Dictionary<TKey, TValue> MCLDBIFAHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B400", Offset = "0x1E29E00", VA = "0x181E2B400", Slot = "7")]
	protected override Dictionary<TKey, TValue> CBFHJGEFJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B460", Offset = "0x1E29E60", VA = "0x181E2B460", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator HHAKIOELJAB(Dictionary<TKey, TValue> CELBLIIOMDE)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x1552730", Offset = "0x1551130", VA = "0x181552730")]
	public LELIHNAFBCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class GGAOLPAJDAK<TKey, TValue, TDictionary> : global::GDPNACEIHOA<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2A76120", Offset = "0x2A74B20", VA = "0x182A76120", Slot = "8")]
	protected override void MFMCNFFMIAP(ref TDictionary JAMIHJHDKEO, int EBBLFLFCHFB, TKey AIGAKEKDKHM, TValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD350", Offset = "0x1FDBD50", VA = "0x181FDD350", Slot = "7")]
	protected override TDictionary CBFHJGEFJHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class DPANMJEIFEB<TKey, TValue> : global::FKHOBFFCOAF<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B550", Offset = "0x1E29F50", VA = "0x181E2B550", Slot = "8")]
	protected override void MFMCNFFMIAP(ref Dictionary<TKey, TValue> JAMIHJHDKEO, int EBBLFLFCHFB, TKey AIGAKEKDKHM, TValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B400", Offset = "0x1E29E00", VA = "0x181E2B400", Slot = "7")]
	protected override Dictionary<TKey, TValue> CBFHJGEFJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x101E930", Offset = "0x101D330", VA = "0x18101E930", Slot = "9")]
	protected override IDictionary<TKey, TValue> ADFDICGOODJ(ref Dictionary<TKey, TValue> MCLDBIFAHBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class DGDKBKKOBHO<TKey, TValue> : global::GDPNACEIHOA<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B550", Offset = "0x1E29F50", VA = "0x181E2B550", Slot = "8")]
	protected override void MFMCNFFMIAP(ref SortedList<TKey, TValue> JAMIHJHDKEO, int EBBLFLFCHFB, TKey AIGAKEKDKHM, TValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B400", Offset = "0x1E29E00", VA = "0x181E2B400", Slot = "7")]
	protected override SortedList<TKey, TValue> CBFHJGEFJHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class GNHKLHNFAJP<TKey, TValue> : global::OOPMNGMGNHB<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B550", Offset = "0x1E29F50", VA = "0x181E2B550", Slot = "8")]
	protected override void MFMCNFFMIAP(ref SortedDictionary<TKey, TValue> JAMIHJHDKEO, int EBBLFLFCHFB, TKey AIGAKEKDKHM, TValue MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x101E930", Offset = "0x101D330", VA = "0x18101E930", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> ADFDICGOODJ(ref SortedDictionary<TKey, TValue> MCLDBIFAHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B400", Offset = "0x1E29E00", VA = "0x181E2B400", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> CBFHJGEFJHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x35C9EE0", Offset = "0x35C88E0", VA = "0x1835C9EE0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator HHAKIOELJAB(SortedDictionary<TKey, TValue> CELBLIIOMDE)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class NIMOGNNFLHL<T> : global::AMLJDOHMGLI<T>, HAOPHHJJNOJ where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x2C19F60", Offset = "0x2C18960", VA = "0x182C19F60", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2C19D30", Offset = "0x2C18730", VA = "0x182C19D30", Slot = "5")]
	public T FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
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
	[Cpp2IlInjected.Address(RVA = "0x5000240", Offset = "0x4FFEC40", VA = "0x185000240", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, IDictionary MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x5000070", Offset = "0x4FFEA70", VA = "0x185000070", Slot = "5")]
	public IDictionary FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FF83F0", Offset = "0x4FF6DF0", VA = "0x184FF83F0")]
	public GHJEFPIIALJ(params OLGPDOHAJDG[] BHNCFOAHEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7990", Offset = "0x4FF6390", VA = "0x184FF7990", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, object MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x4FF78F0", Offset = "0x4FF62F0", VA = "0x184FF78F0", Slot = "5")]
	public object FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class CNBJOLNPGPN
{
	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x4604C50", Offset = "0x4603650", VA = "0x184604C50")]
	public static object HCMCCELICBE(Type MCLMFJEAHEC, out bool GOFJCKJHGEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x4605570", Offset = "0x4603F70", VA = "0x184605570")]
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
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public PAFOGPMENDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x40E0190", Offset = "0x40DEB90", VA = "0x1840E0190")]
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
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public FPKJLOOADHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x325DBD0", Offset = "0x325C5D0", VA = "0x18325DBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
		public EPCDBHDAIMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x257A560", Offset = "0x2578F60", VA = "0x18257A560")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E9D920", Offset = "0x3E9C320", VA = "0x183E9D920")]
	static COHKKJGAHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3356440", Offset = "0x3354E40", VA = "0x183356440")]
	public COHKKJGAHPE(bool DBNAICJMNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x3E8F420", Offset = "0x3E8DE20", VA = "0x183E8F420", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x3E8A260", Offset = "0x3E88C60", VA = "0x183E8A260", Slot = "5")]
	public T FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x3E90B80", Offset = "0x3E8F580", VA = "0x183E90B80", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, T MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x3E8D1A0", Offset = "0x3E8BBA0", VA = "0x183E8D1A0", Slot = "7")]
	public T GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class IPJBNHNONBN<T> : global::AMLJDOHMGLI<T[,]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x24C7420", Offset = "0x24C5E20", VA = "0x1824C7420", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T[,] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x24C7150", Offset = "0x24C5B50", VA = "0x1824C7150", Slot = "5")]
	public T[,] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
	public IPJBNHNONBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class OIFMGJFIOOF<T> : global::AMLJDOHMGLI<T[,,]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x32CAFB0", Offset = "0x32C99B0", VA = "0x1832CAFB0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T[,,] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x32CABD0", Offset = "0x32C95D0", VA = "0x1832CABD0", Slot = "5")]
	public T[,,] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
	public OIFMGJFIOOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class HEHFLEJCMPE<T> : global::AMLJDOHMGLI<T[,,,]>, HAOPHHJJNOJ
{
	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2E54000", Offset = "0x2E52A00", VA = "0x182E54000", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T[,,,] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2E53B00", Offset = "0x2E52500", VA = "0x182E53B00", Slot = "5")]
	public T[,,,] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
	public HEHFLEJCMPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class GDNHIKEJADP<T> : global::AMLJDOHMGLI<T?>, HAOPHHJJNOJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A71020", Offset = "0x2A6FA20", VA = "0x182A71020", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A70D70", Offset = "0x2A6F770", VA = "0x182A70D70", Slot = "5")]
	public T? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
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
	[Cpp2IlInjected.Address(RVA = "0x257A080", Offset = "0x2578A80", VA = "0x18257A080")]
	public DLBLDNCCNAM(global::AMLJDOHMGLI<T> FJPJMKCCOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x265BDE0", Offset = "0x265A7E0", VA = "0x18265BDE0")]
	public DLBLDNCCNAM(Type MKPLIADKLAP, object[] MFGCCBLNNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x265AE00", Offset = "0x2659800", VA = "0x18265AE00", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, T? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2659940", Offset = "0x2658340", VA = "0x182659940", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5005300", Offset = "0x5003D00", VA = "0x185005300", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, sbyte MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x5005240", Offset = "0x5003C40", VA = "0x185005240", Slot = "5")]
	public sbyte FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x5005340", Offset = "0x5003D40", VA = "0x185005340", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, sbyte MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5005250", Offset = "0x5003C50", VA = "0x185005250", Slot = "7")]
	public sbyte GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5004C10", Offset = "0x5003610", VA = "0x185004C10", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, sbyte? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x5004AA0", Offset = "0x50034A0", VA = "0x185004AA0", Slot = "5")]
	public sbyte? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5004CA0", Offset = "0x50036A0", VA = "0x185004CA0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, sbyte? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5004B10", Offset = "0x5003510", VA = "0x185004B10", Slot = "7")]
	public sbyte? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x460C700", Offset = "0x460B100", VA = "0x18460C700", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, sbyte[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x460C5C0", Offset = "0x460AFC0", VA = "0x18460C5C0", Slot = "5")]
	public sbyte[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x52E6080", Offset = "0x52E4A80", VA = "0x1852E6080", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, short MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x52E5FA0", Offset = "0x52E49A0", VA = "0x1852E5FA0", Slot = "5")]
	public short FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x52E60A0", Offset = "0x52E4AA0", VA = "0x1852E60A0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, short MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x52E6000", Offset = "0x52E4A00", VA = "0x1852E6000", Slot = "7")]
	public short GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FFE1A0", Offset = "0x4FFCBA0", VA = "0x184FFE1A0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, short? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x4FFE040", Offset = "0x4FFCA40", VA = "0x184FFE040", Slot = "5")]
	public short? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x4FFE230", Offset = "0x4FFCC30", VA = "0x184FFE230", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, short? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x4FFE0B0", Offset = "0x4FFCAB0", VA = "0x184FFE0B0", Slot = "7")]
	public short? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FF9C20", Offset = "0x4FF8620", VA = "0x184FF9C20", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, short[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9AE0", Offset = "0x4FF84E0", VA = "0x184FF9AE0", Slot = "5")]
	public short[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4605F20", Offset = "0x4604920", VA = "0x184605F20", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, int MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x4605E90", Offset = "0x4604890", VA = "0x184605E90", Slot = "5")]
	public int FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x4605F30", Offset = "0x4604930", VA = "0x184605F30", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, int MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x4605EA0", Offset = "0x46048A0", VA = "0x184605EA0", Slot = "7")]
	public int GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5008FD0", Offset = "0x50079D0", VA = "0x185008FD0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, int? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x5008E70", Offset = "0x5007870", VA = "0x185008E70", Slot = "5")]
	public int? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x5009060", Offset = "0x5007A60", VA = "0x185009060", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, int? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x5008EE0", Offset = "0x50078E0", VA = "0x185008EE0", Slot = "7")]
	public int? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x45F4810", Offset = "0x45F3210", VA = "0x1845F4810", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, int[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x45F46D0", Offset = "0x45F30D0", VA = "0x1845F46D0", Slot = "5")]
	public int[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x500AE90", Offset = "0x5009890", VA = "0x18500AE90", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, long MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x500ADA0", Offset = "0x50097A0", VA = "0x18500ADA0", Slot = "5")]
	public long FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x500AEC0", Offset = "0x50098C0", VA = "0x18500AEC0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, long MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x500ADB0", Offset = "0x50097B0", VA = "0x18500ADB0", Slot = "7")]
	public long GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4604AE0", Offset = "0x46034E0", VA = "0x184604AE0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, long? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x4604970", Offset = "0x4603370", VA = "0x184604970", Slot = "5")]
	public long? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x4604B60", Offset = "0x4603560", VA = "0x184604B60", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, long? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x4604A00", Offset = "0x4603400", VA = "0x184604A00", Slot = "7")]
	public long? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x46097F0", Offset = "0x46081F0", VA = "0x1846097F0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, long[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x46096B0", Offset = "0x46080B0", VA = "0x1846096B0", Slot = "5")]
	public long[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5004940", Offset = "0x5003340", VA = "0x185004940", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, byte MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5004880", Offset = "0x5003280", VA = "0x185004880", Slot = "5")]
	public byte FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5004980", Offset = "0x5003380", VA = "0x185004980", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, byte MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5004890", Offset = "0x5003290", VA = "0x185004890", Slot = "7")]
	public byte GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FFB430", Offset = "0x4FF9E30", VA = "0x184FFB430", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, byte? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x4FFB2C0", Offset = "0x4FF9CC0", VA = "0x184FFB2C0", Slot = "5")]
	public byte? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x4FFB4C0", Offset = "0x4FF9EC0", VA = "0x184FFB4C0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, byte? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x4FFB330", Offset = "0x4FF9D30", VA = "0x184FFB330", Slot = "7")]
	public byte? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4606060", Offset = "0x4604A60", VA = "0x184606060", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, ushort MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x4605FD0", Offset = "0x46049D0", VA = "0x184605FD0", Slot = "5")]
	public ushort FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x4606080", Offset = "0x4604A80", VA = "0x184606080", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, ushort MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x4605FE0", Offset = "0x46049E0", VA = "0x184605FE0", Slot = "7")]
	public ushort GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x460C950", Offset = "0x460B350", VA = "0x18460C950", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, ushort? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x460C820", Offset = "0x460B220", VA = "0x18460C820", Slot = "5")]
	public ushort? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x460C9D0", Offset = "0x460B3D0", VA = "0x18460C9D0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, ushort? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x460C890", Offset = "0x460B290", VA = "0x18460C890", Slot = "7")]
	public ushort? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x45F2A20", Offset = "0x45F1420", VA = "0x1845F2A20", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, ushort[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x45F28E0", Offset = "0x45F12E0", VA = "0x1845F28E0", Slot = "5")]
	public ushort[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x45F2BD0", Offset = "0x45F15D0", VA = "0x1845F2BD0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, uint MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x45F2B40", Offset = "0x45F1540", VA = "0x1845F2B40", Slot = "5")]
	public uint FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x45F2BE0", Offset = "0x45F15E0", VA = "0x1845F2BE0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, uint MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x45F2B50", Offset = "0x45F1550", VA = "0x1845F2B50", Slot = "7")]
	public uint GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5003850", Offset = "0x5002250", VA = "0x185003850", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, uint? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x50036F0", Offset = "0x50020F0", VA = "0x1850036F0", Slot = "5")]
	public uint? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x50038E0", Offset = "0x50022E0", VA = "0x1850038E0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, uint? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x5003760", Offset = "0x5002160", VA = "0x185003760", Slot = "7")]
	public uint? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FFA950", Offset = "0x4FF9350", VA = "0x184FFA950", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, uint[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x4FFA810", Offset = "0x4FF9210", VA = "0x184FFA810", Slot = "5")]
	public uint[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FF9320", Offset = "0x4FF7D20", VA = "0x184FF9320", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, ulong MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9290", Offset = "0x4FF7C90", VA = "0x184FF9290", Slot = "5")]
	public ulong FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9350", Offset = "0x4FF7D50", VA = "0x184FF9350", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, ulong MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x4FF92A0", Offset = "0x4FF7CA0", VA = "0x184FF92A0", Slot = "7")]
	public ulong GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x50034F0", Offset = "0x5001EF0", VA = "0x1850034F0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, ulong? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5003380", Offset = "0x5001D80", VA = "0x185003380", Slot = "5")]
	public ulong? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x5003580", Offset = "0x5001F80", VA = "0x185003580", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, ulong? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5003410", Offset = "0x5001E10", VA = "0x185003410", Slot = "7")]
	public ulong? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FF76F0", Offset = "0x4FF60F0", VA = "0x184FF76F0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, ulong[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x4FF75B0", Offset = "0x4FF5FB0", VA = "0x184FF75B0", Slot = "5")]
	public ulong[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x52E96E0", Offset = "0x52E80E0", VA = "0x1852E96E0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, float MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x52E9650", Offset = "0x52E8050", VA = "0x1852E9650", Slot = "5")]
	public float FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x52E96F0", Offset = "0x52E80F0", VA = "0x1852E96F0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, float MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x52E9660", Offset = "0x52E8060", VA = "0x1852E9660", Slot = "7")]
	public float GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x50046A0", Offset = "0x50030A0", VA = "0x1850046A0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, float? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x5004540", Offset = "0x5002F40", VA = "0x185004540", Slot = "5")]
	public float? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x5004720", Offset = "0x5003120", VA = "0x185004720", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, float? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x50045B0", Offset = "0x5002FB0", VA = "0x1850045B0", Slot = "7")]
	public float? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5004300", Offset = "0x5002D00", VA = "0x185004300", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, float[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x50041C0", Offset = "0x5002BC0", VA = "0x1850041C0", Slot = "5")]
	public float[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5003260", Offset = "0x5001C60", VA = "0x185003260", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, double MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x50031A0", Offset = "0x5001BA0", VA = "0x1850031A0", Slot = "5")]
	public double FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x5003270", Offset = "0x5001C70", VA = "0x185003270", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, double MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x50031B0", Offset = "0x5001BB0", VA = "0x1850031B0", Slot = "7")]
	public double GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x500DFD0", Offset = "0x500C9D0", VA = "0x18500DFD0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, double? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x500DE30", Offset = "0x500C830", VA = "0x18500DE30", Slot = "5")]
	public double? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x500E050", Offset = "0x500CA50", VA = "0x18500E050", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, double? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x500DEC0", Offset = "0x500C8C0", VA = "0x18500DEC0", Slot = "7")]
	public double? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FFE640", Offset = "0x4FFD040", VA = "0x184FFE640", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, double[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x4FFE500", Offset = "0x4FFCF00", VA = "0x184FFE500", Slot = "5")]
	public double[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4608490", Offset = "0x4606E90", VA = "0x184608490", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, bool MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x4608400", Offset = "0x4606E00", VA = "0x184608400", Slot = "5")]
	public bool FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x46084B0", Offset = "0x4606EB0", VA = "0x1846084B0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, bool MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x4608410", Offset = "0x4606E10", VA = "0x184608410", Slot = "7")]
	public bool GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FFFE90", Offset = "0x4FFE890", VA = "0x184FFFE90", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, bool? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x4FFFD60", Offset = "0x4FFE760", VA = "0x184FFFD60", Slot = "5")]
	public bool? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x4FFFF10", Offset = "0x4FFE910", VA = "0x184FFFF10", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, bool? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x4FFFDD0", Offset = "0x4FFE7D0", VA = "0x184FFFDD0", Slot = "7")]
	public bool? GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x50075C0", Offset = "0x5005FC0", VA = "0x1850075C0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, bool[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x5007480", Offset = "0x5005E80", VA = "0x185007480", Slot = "5")]
	public bool[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x52E9C00", Offset = "0x52E8600", VA = "0x1852E9C00", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, object MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x52E9790", Offset = "0x52E8190", VA = "0x1852E9790", Slot = "5")]
	public object FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FFBA60", Offset = "0x4FFA460", VA = "0x184FFBA60", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, byte[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x4FFB9E0", Offset = "0x4FFA3E0", VA = "0x184FFB9E0", Slot = "5")]
	public byte[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FFE960", Offset = "0x4FFD360", VA = "0x184FFE960", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, ArraySegment<byte> MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x4FFE880", Offset = "0x4FFD280", VA = "0x184FFE880", Slot = "5")]
	public ArraySegment<byte> FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FFA2F0", Offset = "0x4FF8CF0", VA = "0x184FFA2F0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, string MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x4FFA2E0", Offset = "0x4FF8CE0", VA = "0x184FFA2E0", Slot = "5")]
	public string FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x4FFA2F0", Offset = "0x4FF8CF0", VA = "0x184FFA2F0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, string MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x4FFA2E0", Offset = "0x4FF8CE0", VA = "0x184FFA2E0", Slot = "7")]
	public string GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x500A640", Offset = "0x5009040", VA = "0x18500A640", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, string[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x500A4D0", Offset = "0x5008ED0", VA = "0x18500A4D0", Slot = "5")]
	public string[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FF74D0", Offset = "0x4FF5ED0", VA = "0x184FF74D0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, char MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x4FF74A0", Offset = "0x4FF5EA0", VA = "0x184FF74A0", Slot = "5")]
	public char FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FFB860", Offset = "0x4FFA260", VA = "0x184FFB860", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, char? MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x4FFB790", Offset = "0x4FFA190", VA = "0x184FFB790", Slot = "5")]
	public char? FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x45F4130", Offset = "0x45F2B30", VA = "0x1845F4130", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, char[] MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x45F3F90", Offset = "0x45F2990", VA = "0x1845F3F90", Slot = "5")]
	public char[] FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x460A110", Offset = "0x4608B10", VA = "0x18460A110", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Guid MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x460A0C0", Offset = "0x4608AC0", VA = "0x18460A0C0", Slot = "5")]
	public Guid FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x460A1E0", Offset = "0x4608BE0", VA = "0x18460A1E0", Slot = "6")]
	public void MCCFOGKFCHI(ref NADLEEAJGKF IEEJJNDPOHK, Guid MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x460A0C0", Offset = "0x4608AC0", VA = "0x18460A0C0", Slot = "7")]
	public Guid GKEBJLLDPCK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x8DB980", Offset = "0x8DA380", VA = "0x1808DB980")]
	public AFLBDMMGODM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x13990C0", Offset = "0x1397AC0", VA = "0x1813990C0")]
	public AFLBDMMGODM(bool CJLHAMPEJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x45F2730", Offset = "0x45F1130", VA = "0x1845F2730", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, decimal MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x45F2500", Offset = "0x45F0F00", VA = "0x1845F2500", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FFF050", Offset = "0x4FFDA50", VA = "0x184FFF050", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Uri MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x4FFEFD0", Offset = "0x4FFD9D0", VA = "0x184FFEFD0", Slot = "5")]
	public Uri FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x45F2280", Offset = "0x45F0C80", VA = "0x1845F2280", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Version MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x45F2200", Offset = "0x45F0C00", VA = "0x1845F2200", Slot = "5")]
	public Version FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4609600", Offset = "0x4608000", VA = "0x184609600", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, StringBuilder MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x4609580", Offset = "0x4607F80", VA = "0x184609580", Slot = "5")]
	public StringBuilder FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FF90D0", Offset = "0x4FF7AD0", VA = "0x184FF90D0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, BitArray MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x4FF8FB0", Offset = "0x4FF79B0", VA = "0x184FF8FB0", Slot = "5")]
	public BitArray FFFJLEEKFAK(ref PLJMADAGCJN ILDGEJAOOHJ, OLGPDOHAJDG OHNDENCEHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x45F4660", Offset = "0x45F3060", VA = "0x1845F4660")]
	public BCEANKBFCEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x45F4680", Offset = "0x45F3080", VA = "0x1845F4680")]
	public BCEANKBFCEC(bool LAPGEGMJEKG, bool DNDGOIAFPJG, bool DOJMHOECGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x45F44B0", Offset = "0x45F2EB0", VA = "0x1845F44B0", Slot = "4")]
	public void HGEKGOKJCDE(ref NADLEEAJGKF IEEJJNDPOHK, Type MAKFNMHIJIF, OLGPDOHAJDG OHNDENCEHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x45F4380", Offset = "0x45F2D80", VA = "0x1845F4380", Slot = "5")]
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
