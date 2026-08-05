using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
internal static class FDAKMEAKFAE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x639AC60", Offset = "0x6399A60", VA = "0x18639AC60")]
	public static bool PGALIKGJDGH(this TypeInfo FLHOFPAHPKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class EDFBGAHAHDM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type LHFIHJINMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7619C0", Offset = "0x7607C0", VA = "0x1807619C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] EBKOGHOAIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x789560", Offset = "0x788360", VA = "0x180789560")]
	public EDFBGAHAHDM(Type NJPMINJIGEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class GOKAOCIOGJI : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void LKGODANHIHH<T>(NLOIOJJEBDP FNEJOGEIEJN, T POACLGOFKAJ, MCCKOEMPDHO OLADLCMFMKB);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T NFHGGGAFIJL<T>(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO OLADLCMFMKB);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MFIMACLDDLI
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GPNCMEICHNB<T> : MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, T POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DINHDFDPHCC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, T POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum HFHHFBGNHEH
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class NDHGOGBBAKP
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x24DCDD0", Offset = "0x24DBBD0", VA = "0x1824DCDD0")]
	public static string MLNPIHCCCMD<T>(this GPNCMEICHNB<T> FBINFECPCAG, T POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GPNCMEICHNB<T> BBKJBDIPCIA<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LLEOANCELHD
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x245BAC0", Offset = "0x245A8C0", VA = "0x18245BAC0")]
	public static GPNCMEICHNB<T> OJGIKMPHJPG<T>(this MCCKOEMPDHO OLADLCMFMKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x63AA6E0", Offset = "0x63A94E0", VA = "0x1863AA6E0")]
	public static object IPOEJJLELMM(this MCCKOEMPDHO OLADLCMFMKB, Type FLHOFPAHPKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class AFBPFPBFJPL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6394F80", Offset = "0x6393D80", VA = "0x186394F80")]
	public AFBPFPBFJPL(string BLAOEBOMGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct MABBDDGCPLD
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class IGHICFADEOB
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] BLPPMOBNKNN;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] MJEIBDPHKBL;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x639D290", Offset = "0x639C090", VA = "0x18639D290")]
		public static byte[] DHPCOENMKHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x639D330", Offset = "0x639C130", VA = "0x18639D330")]
		public static char[] IANEIFCAJJL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> AHGDKDEOKPN;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] IJKPBBDEBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] LKHDKNBOMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int NNACFOFLCKF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool CILMLEOGDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x63AC3D0", Offset = "0x63AB1D0", VA = "0x1863AC3D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x63ADB20", Offset = "0x63AC920", VA = "0x1863ADB20")]
	public MABBDDGCPLD(byte[] LKHDKNBOMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x63ADB80", Offset = "0x63AC980", VA = "0x1863ADB80")]
	public MABBDDGCPLD(byte[] LKHDKNBOMJD, int NNACFOFLCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x63AB3D0", Offset = "0x63AA1D0", VA = "0x1863AB3D0")]
	private HAGMHEMNEHG EIJOJOJAHCM(string KGNHAOBOCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x63ABD50", Offset = "0x63AAB50", VA = "0x1863ABD50")]
	private HAGMHEMNEHG FOBFLEIGLMO(string BLAOEBOMGGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x63AC610", Offset = "0x63AB410", VA = "0x1863AC610")]
	public void LCFPCMIABFG(int NNACFOFLCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0xAADA00", Offset = "0xAAC800", VA = "0x180AADA00")]
	public byte[] IPHMDBADFHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1C77C70", Offset = "0x1C76A70", VA = "0x181C77C70")]
	public int OJNBGIHKEGF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x63AC780", Offset = "0x63AB580", VA = "0x1863AC780")]
	public GECAPOANNBB LNOBGHOJGEK()
	{
		return default(GECAPOANNBB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x63AC930", Offset = "0x63AB730", VA = "0x1863AC930")]
	public void LOKPIAHMHEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x63ABC30", Offset = "0x63AAA30", VA = "0x1863ABC30")]
	public bool FMKIEGLIEIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x63AD030", Offset = "0x63ABE30", VA = "0x1863AD030")]
	public bool OFFHFEPKJBD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x63AAE20", Offset = "0x63A9C20", VA = "0x1863AAE20")]
	public void CAMPPAMJNGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x63AD1D0", Offset = "0x63ABFD0", VA = "0x1863AD1D0")]
	public bool PBPGEOCPCBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x63AA9E0", Offset = "0x63A97E0", VA = "0x1863AA9E0")]
	public bool BGHCBKLOFPJ(int NENAAIFMEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x63AC6B0", Offset = "0x63AB4B0", VA = "0x1863AC6B0")]
	public bool LJKOCIOIMMH(int NENAAIFMEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x63AC440", Offset = "0x63AB240", VA = "0x1863AC440")]
	public bool JLOGCNCMOFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x63AD130", Offset = "0x63ABF30", VA = "0x1863AD130")]
	public void OGNGFABBCLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x63AC620", Offset = "0x63AB420", VA = "0x1863AC620")]
	public bool LDJJMFPIHCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x63ACE90", Offset = "0x63ABC90", VA = "0x1863ACE90")]
	public bool OBAOIJMMHFN(int NENAAIFMEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x63ACF60", Offset = "0x63ABD60", VA = "0x1863ACF60")]
	public bool OCEMOGNAMNP(int NENAAIFMEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x63AC1A0", Offset = "0x63AAFA0", VA = "0x1863AC1A0")]
	public bool IEFGPHFNLJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x63AA840", Offset = "0x63A9640", VA = "0x1863AA840")]
	public void AMDDHHCAPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x63AB290", Offset = "0x63AA090", VA = "0x1863AB290")]
	public bool EECLICGGIBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x63AAAB0", Offset = "0x63A98B0", VA = "0x1863AAAB0")]
	public void BHEGCNJOKNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x63AD260", Offset = "0x63AC060", VA = "0x1863AD260")]
	private void PFGIDGNBMFM([Out] byte[] IOJNPHMOKJJ, [Out] int GEHGFIBKDHG, [Out] int KDLEMAIHHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x63AB320", Offset = "0x63AA120", VA = "0x1863AB320")]
	private static int EGNPJKCAEGP(char APOJANFJHJO, char DFBIFCHBAHF, char BOGFMIDGHHG, char GBNHGJEMKMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x63ACDB0", Offset = "0x63ABBB0", VA = "0x1863ACDB0")]
	private static int NJLKABPCCOK(char NPDPLEIHBMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x63ABEC0", Offset = "0x63AACC0", VA = "0x1863ABEC0")]
	public ArraySegment<byte> GGNJHCFLJAM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x63AC230", Offset = "0x63AB030", VA = "0x1863AC230")]
	public string IGOAJJAIOLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x63AB920", Offset = "0x63AA720", VA = "0x1863AB920")]
	public string EOPLHANDGGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x63ABA10", Offset = "0x63AA810", VA = "0x1863ABA10")]
	public ArraySegment<byte> FACBHGOPEML()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x63AD0C0", Offset = "0x63ABEC0", VA = "0x1863AD0C0")]
	public ArraySegment<byte> OGFAMOPEMKH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x63ACB60", Offset = "0x63AB960", VA = "0x1863ACB60")]
	public bool NHLCGFIELPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x63AC550", Offset = "0x63AB350", VA = "0x1863AC550")]
	private static bool KMKOEDADNOD(byte BOGFMIDGHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x63AAFC0", Offset = "0x63A9DC0", VA = "0x1863AAFC0")]
	private void DBIKAGBKDNP(GECAPOANNBB EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x63AC3F0", Offset = "0x63AB1F0", VA = "0x1863AC3F0")]
	public void JGPIFJJDHHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x63AACC0", Offset = "0x63A9AC0", VA = "0x1863AACC0")]
	private void BNCPMNHLMDO(int IDKILBMAJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x63AC120", Offset = "0x63AAF20", VA = "0x1863AC120")]
	public sbyte IBKLHJHPNGN()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x63AC4D0", Offset = "0x63AB2D0", VA = "0x1863AC4D0")]
	public short KACKGBACKND()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x63AC0A0", Offset = "0x63AAEA0", VA = "0x1863AC0A0")]
	public int HJGDGJACEPB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x63AC310", Offset = "0x63AB110", VA = "0x1863AC310")]
	public long IHMPIBCMHAH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x63ABE40", Offset = "0x63AAC40", VA = "0x1863ABE40")]
	public byte GDGCDLKBFFI()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x63AB210", Offset = "0x63AA010", VA = "0x1863AB210")]
	public ushort DNMFBIFKNHG()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x63AB990", Offset = "0x63AA790", VA = "0x1863AB990")]
	public uint EPBLHNALCLH()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x63ABFE0", Offset = "0x63AADE0", VA = "0x1863ABFE0")]
	public ulong HBJJICCKMMN()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x63AA8E0", Offset = "0x63A96E0", VA = "0x1863AA8E0")]
	public float BCGMNLACHPJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x63ACA60", Offset = "0x63AB860", VA = "0x1863ACA60")]
	public double NDALBMEFLKP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x63AAEC0", Offset = "0x63A9CC0", VA = "0x1863AAEC0")]
	public ArraySegment<byte> CGLFPKNNFLJ()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x63AAB50", Offset = "0x63A9950", VA = "0x1863AAB50")]
	private static int BJCKGKABAPJ(byte[] LKHDKNBOMJD, int NNACFOFLCKF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HAGMHEMNEHG : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference BKGHGICGBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int AAHPJJCPBHL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int IKKFEAHBANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xAE67D0", Offset = "0xAE55D0", VA = "0x180AE67D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string JHBFMBGLIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x89FCC0", Offset = "0x89EAC0", VA = "0x18089FCC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x639C410", Offset = "0x639B210", VA = "0x18639C410")]
	public HAGMHEMNEHG(string BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x639C470", Offset = "0x639B270", VA = "0x18639C470")]
	public HAGMHEMNEHG(string BLAOEBOMGGP, byte[] MHHLHFOHJBE, int NNACFOFLCKF, int AAHPJJCPBHL, string MHDANGDAGOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class FLDHKNAJAOL
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class DDGFCHFIPED
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] BLPPMOBNKNN;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6399C00", Offset = "0x6398A00", VA = "0x186399C00")]
		public static byte[] DHPCOENMKHN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class PLIKOCJLDOI
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void ACBJOGBMFAN(NLOIOJJEBDP FNEJOGEIEJN, object POACLGOFKAJ, MCCKOEMPDHO OLADLCMFMKB);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object DDKKPFKDDHI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO OLADLCMFMKB);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class CELIKJHPGJG
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class KLHFAKNKCFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
				public KLHFAKNKCFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x388EFD0", Offset = "0x388DDD0", VA = "0x18388EFD0")]
				internal bool GAAEPCGOKFH(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x63A0410", Offset = "0x639F210", VA = "0x1863A0410")]
				internal bool KKDNNIPHAFO(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, MCCKOEMPDHO, byte[]> ICNGBIPPCFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, MCCKOEMPDHO> LPGPANALHNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly ACBJOGBMFAN JEELLNGFBJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, MCCKOEMPDHO, ArraySegment<byte>> PCKGGIFHEGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, MCCKOEMPDHO, string> CEBAAPOEJJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, MCCKOEMPDHO, object> MHPLELCOAEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, MCCKOEMPDHO, object> KDBFEPBMIPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, MCCKOEMPDHO, object> KFODCAJNAOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly DDKKPFKDDHI MKDAEGHCJLO;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6396390", Offset = "0x6395190", VA = "0x186396390")]
			public CELIKJHPGJG(Type FLHOFPAHPKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2998D60", Offset = "0x2997B60", VA = "0x182998D60")]
			private static T DCHENJLNCJI<T>(DynamicMethod JPGINHJGBOP)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6396140", Offset = "0x6394F40", VA = "0x186396140")]
			private static MethodInfo HKADFHJHMBN(Type FLHOFPAHPKL, string MEBBBIMBIJO, Type[] GOHNIOIALBE)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, CELIKJHPGJG> GPBDMEKGGBC;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly NDELOLJPHPH<CELIKJHPGJG> AELBJEPICIF;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x63B1C30", Offset = "0x63B0A30", VA = "0x1863B1C30")]
		static PLIKOCJLDOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x63B1BB0", Offset = "0x63B09B0", VA = "0x1863B1BB0")]
		private static CELIKJHPGJG PHONIDHHJMI(Type FLHOFPAHPKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x63B1A30", Offset = "0x63B0830", VA = "0x1863B1A30")]
		public static void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, object POACLGOFKAJ, MCCKOEMPDHO OLADLCMFMKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x63B1920", Offset = "0x63B0720", VA = "0x1863B1920")]
		public static void LJOKGFFEJKK(Type FLHOFPAHPKL, NLOIOJJEBDP FNEJOGEIEJN, object POACLGOFKAJ, MCCKOEMPDHO OLADLCMFMKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static MCCKOEMPDHO DLLOCKMAHNG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] HAPCBGKDJKE;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] HAMKLEGIGMF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static MCCKOEMPDHO COGPOJGBPDF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x639BBF0", Offset = "0x639A9F0", VA = "0x18639BBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool NCHMLMBHEAA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x639C120", Offset = "0x639AF20", VA = "0x18639C120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x639AE30", Offset = "0x6399C30", VA = "0x18639AE30")]
	public static void CHEDPBIEAMJ(MCCKOEMPDHO OLADLCMFMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2391B20", Offset = "0x2390920", VA = "0x182391B20")]
	public static byte[] LJOKGFFEJKK<T>(T DGPHOMINFCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x23919A0", Offset = "0x23907A0", VA = "0x1823919A0")]
	public static byte[] LJOKGFFEJKK<T>(T POACLGOFKAJ, MCCKOEMPDHO OLADLCMFMKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2391BA0", Offset = "0x23909A0", VA = "0x182391BA0")]
	public static void LJOKGFFEJKK<T>(NLOIOJJEBDP FNEJOGEIEJN, T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2391C30", Offset = "0x2390A30", VA = "0x182391C30")]
	public static void LJOKGFFEJKK<T>(NLOIOJJEBDP FNEJOGEIEJN, T POACLGOFKAJ, MCCKOEMPDHO OLADLCMFMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2391910", Offset = "0x2390710", VA = "0x182391910")]
	public static void LJOKGFFEJKK<T>(Stream PLOOMBBCGBH, T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x23917D0", Offset = "0x23905D0", VA = "0x1823917D0")]
	public static void LJOKGFFEJKK<T>(Stream PLOOMBBCGBH, T POACLGOFKAJ, MCCKOEMPDHO OLADLCMFMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x23915B0", Offset = "0x23903B0", VA = "0x1823915B0")]
	public static ArraySegment<byte> CFOKHOJNFFJ<T>(T DGPHOMINFCK)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2391640", Offset = "0x2390440", VA = "0x182391640")]
	public static ArraySegment<byte> CFOKHOJNFFJ<T>(T POACLGOFKAJ, MCCKOEMPDHO OLADLCMFMKB)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2391E90", Offset = "0x2390C90", VA = "0x182391E90")]
	public static string MLNPIHCCCMD<T>(T POACLGOFKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2391D10", Offset = "0x2390B10", VA = "0x182391D10")]
	public static string MLNPIHCCCMD<T>(T POACLGOFKAJ, MCCKOEMPDHO OLADLCMFMKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2392A50", Offset = "0x2391850", VA = "0x182392A50")]
	public static T NLOFGFEMKNI<T>(string HLEOIHDHEEB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x23928D0", Offset = "0x23916D0", VA = "0x1823928D0")]
	public static T NLOFGFEMKNI<T>(string HLEOIHDHEEB, MCCKOEMPDHO OLADLCMFMKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2392EC0", Offset = "0x2391CC0", VA = "0x182392EC0")]
	public static T NLOFGFEMKNI<T>(byte[] LKHDKNBOMJD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x23929C0", Offset = "0x23917C0", VA = "0x1823929C0")]
	public static T NLOFGFEMKNI<T>(byte[] LKHDKNBOMJD, MCCKOEMPDHO OLADLCMFMKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x23931F0", Offset = "0x2391FF0", VA = "0x1823931F0")]
	public static T NLOFGFEMKNI<T>(byte[] LKHDKNBOMJD, int NNACFOFLCKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2392AE0", Offset = "0x23918E0", VA = "0x182392AE0")]
	public static T NLOFGFEMKNI<T>(byte[] LKHDKNBOMJD, int NNACFOFLCKF, MCCKOEMPDHO OLADLCMFMKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2392DC0", Offset = "0x2391BC0", VA = "0x182392DC0")]
	public static T NLOFGFEMKNI<T>(MABBDDGCPLD GFNJLJABMCF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2392C70", Offset = "0x2391A70", VA = "0x182392C70")]
	public static T NLOFGFEMKNI<T>(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO OLADLCMFMKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2392E40", Offset = "0x2391C40", VA = "0x182392E40")]
	public static T NLOFGFEMKNI<T>(Stream PLOOMBBCGBH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x23930B0", Offset = "0x2391EB0", VA = "0x1823930B0")]
	public static T NLOFGFEMKNI<T>(Stream PLOOMBBCGBH, MCCKOEMPDHO OLADLCMFMKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x639BFC0", Offset = "0x639ADC0", VA = "0x18639BFC0")]
	public static string MIGECOCMFBK(byte[] HLEOIHDHEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x639BCF0", Offset = "0x639AAF0", VA = "0x18639BCF0")]
	public static string MIGECOCMFBK(byte[] HLEOIHDHEEB, int NNACFOFLCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x639BE30", Offset = "0x639AC30", VA = "0x18639BE30")]
	public static string MIGECOCMFBK(string HLEOIHDHEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x639AEA0", Offset = "0x6399CA0", VA = "0x18639AEA0")]
	public static byte[] FODEEIDIBIO(byte[] HLEOIHDHEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x639B1D0", Offset = "0x6399FD0", VA = "0x18639B1D0")]
	public static byte[] FODEEIDIBIO(byte[] HLEOIHDHEEB, int NNACFOFLCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x639B020", Offset = "0x6399E20", VA = "0x18639B020")]
	public static byte[] FODEEIDIBIO(string HLEOIHDHEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x639B320", Offset = "0x639A120", VA = "0x18639B320")]
	private static void KFHDBFNLEAM(MABBDDGCPLD GFNJLJABMCF, NLOIOJJEBDP FNEJOGEIEJN, int OBEANJHCKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x639AD90", Offset = "0x6399B90", VA = "0x18639AD90")]
	private static int CGGOHCLBLNI(Stream KHNEEJJPNNH, byte[] BLPPMOBNKNN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum GECAPOANNBB : byte
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
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct NLOIOJJEBDP
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] EEANHJKACMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] BLPPMOBNKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int NNACFOFLCKF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NPBGNNJCGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1C77C70", Offset = "0x1C76A70", VA = "0x181C77C70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x63AC610", Offset = "0x63AB410", VA = "0x1863AC610")]
	public void LCFPCMIABFG(int NNACFOFLCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x63AF310", Offset = "0x63AE110", VA = "0x1863AF310")]
	public static byte[] JCCKEPNEFAL(string CJKMAIBCGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x63AF150", Offset = "0x63ADF50", VA = "0x1863AF150")]
	public static byte[] HKBGMBLIEMD(string CJKMAIBCGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x63AF440", Offset = "0x63AE240", VA = "0x1863AF440")]
	public static byte[] JDKOLABMEKP(string CJKMAIBCGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x63AF5B0", Offset = "0x63AE3B0", VA = "0x1863AF5B0")]
	public static byte[] JGBIFCDLKJG(string CJKMAIBCGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x520E910", Offset = "0x520D710", VA = "0x18520E910")]
	public NLOIOJJEBDP(byte[] GCHHBDACHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x63AEE80", Offset = "0x63ADC80", VA = "0x1863AEE80")]
	public ArraySegment<byte> DHPCOENMKHN()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x63AF070", Offset = "0x63ADE70", VA = "0x1863AF070")]
	public byte[] GFAFEEBNLHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x63B00A0", Offset = "0x63AEEA0", VA = "0x1863B00A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x63AEC90", Offset = "0x63ADA90", VA = "0x1863AEC90")]
	public void AMFLFFMLCMA(int EJMPKIBPAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x63AECA0", Offset = "0x63ADAA0", VA = "0x1863AECA0")]
	public void BJEIMDICOIP(byte GMEDEMHPDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x63AED00", Offset = "0x63ADB00", VA = "0x1863AED00")]
	public void BJEIMDICOIP(byte[] GMEDEMHPDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x63AEF70", Offset = "0x63ADD70", VA = "0x1863AEF70")]
	public void ENBILLBEBHJ(byte GMEDEMHPDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x63AFFB0", Offset = "0x63AEDB0", VA = "0x1863AFFB0")]
	public void PKFOOCGOJEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x63AFDF0", Offset = "0x63AEBF0", VA = "0x1863AFDF0")]
	public void NNIAMDFPGOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x63AFE40", Offset = "0x63AEC40", VA = "0x1863AFE40")]
	public void NOEADMPBPAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x63AF2C0", Offset = "0x63AE0C0", VA = "0x1863AF2C0")]
	public void HPPMDHNBFBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x63AEF20", Offset = "0x63ADD20", VA = "0x1863AEF20")]
	public void DJPOCGIBGDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x63AFCC0", Offset = "0x63AEAC0", VA = "0x1863AFCC0")]
	public void LJDGLHKDEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x63AED60", Offset = "0x63ADB60", VA = "0x1863AED60")]
	public void BNGHMNOJOCL(string CJKMAIBCGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x63AEFB0", Offset = "0x63ADDB0", VA = "0x1863AEFB0")]
	public void EODNPFLLHAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x63AFAC0", Offset = "0x63AE8C0", VA = "0x1863AFAC0")]
	public void KBPAEJBBEFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x63AFB60", Offset = "0x63AE960", VA = "0x1863AFB60")]
	public void KNLEMKIKJIE(bool POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x63AFE90", Offset = "0x63AEC90", VA = "0x1863AFE90")]
	public void NOIAINJBBFN(float POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x63AEE00", Offset = "0x63ADC00", VA = "0x1863AEE00")]
	public void DHLOLAFPDNA(double POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x63AFD80", Offset = "0x63AEB80", VA = "0x1863AFD80")]
	public void NGAHBEIGHDO(byte POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x63AFD10", Offset = "0x63AEB10", VA = "0x1863AFD10")]
	public void MMCHDCIJCDF(ushort POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x63AFF40", Offset = "0x63AED40", VA = "0x1863AFF40")]
	public void OJLMFJEBAOH(uint POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x63AFF10", Offset = "0x63AED10", VA = "0x1863AFF10")]
	public void OBIPIJACEOE(ulong POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x63B0000", Offset = "0x63AEE00", VA = "0x1863B0000")]
	public void PLDKBANKMFM(sbyte POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x63AF000", Offset = "0x63ADE00", VA = "0x1863AF000")]
	public void FGCBJEIPPAG(short POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x63AF0E0", Offset = "0x63ADEE0", VA = "0x1863AF0E0")]
	public void HFFHPEOIOOM(int POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x63B0070", Offset = "0x63AEE70", VA = "0x1863B0070")]
	public void PMNINOMDNAG(long POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x63AF730", Offset = "0x63AE530", VA = "0x1863AF730")]
	public void JPDLKAGFEBP(string POACLGOFKAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CGNEEGLPHGD : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class KHEBOGJKAEK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x38B50B0", Offset = "0x38B3EB0", VA = "0x1838B50B0")]
		static KHEBOGJKAEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private CGNEEGLPHGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal static class EPPJMDHHGBM
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> NINPIKNDBKP;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x639A770", Offset = "0x6399570", VA = "0x18639A770")]
	static EPPJMDHHGBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6399F80", Offset = "0x6398D80", VA = "0x186399F80")]
	internal static object BBKJBDIPCIA(Type EGGPNONKPNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class JIJKMKLGAIM : GPNCMEICHNB<Vector2>, MFIMACLDDLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DDABGEBFIOI IGPPBNBOEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] HMPKPGGOLLO;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x63A00C0", Offset = "0x639EEC0", VA = "0x1863A00C0")]
	public JIJKMKLGAIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x639FBE0", Offset = "0x639E9E0", VA = "0x18639FBE0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, Vector2 POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x639FDD0", Offset = "0x639EBD0", VA = "0x18639FDD0", Slot = "5")]
	public Vector2 NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class PBJGEKLEIGD : GPNCMEICHNB<Vector3>, MFIMACLDDLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly DDABGEBFIOI IGPPBNBOEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] HMPKPGGOLLO;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x63B1220", Offset = "0x63B0020", VA = "0x1863B1220")]
	public PBJGEKLEIGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x63B0C30", Offset = "0x63AFA30", VA = "0x1863B0C30", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, Vector3 POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x63B0ED0", Offset = "0x63AFCD0", VA = "0x1863B0ED0", Slot = "5")]
	public Vector3 NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class PAEHKFEEDMP : GPNCMEICHNB<Vector4>, MFIMACLDDLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly DDABGEBFIOI IGPPBNBOEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] HMPKPGGOLLO;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x63B0940", Offset = "0x63AF740", VA = "0x1863B0940")]
	public PAEHKFEEDMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x63B0270", Offset = "0x63AF070", VA = "0x1863B0270", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, Vector4 POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x63B05B0", Offset = "0x63AF3B0", VA = "0x1863B05B0", Slot = "5")]
	public Vector4 NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class MFLHEBAOJLC : GPNCMEICHNB<Quaternion>, MFIMACLDDLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly DDABGEBFIOI IGPPBNBOEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] HMPKPGGOLLO;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x63AE3B0", Offset = "0x63AD1B0", VA = "0x1863AE3B0")]
	public MFLHEBAOJLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x63ADCE0", Offset = "0x63ACAE0", VA = "0x1863ADCE0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, Quaternion POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x63AE020", Offset = "0x63ACE20", VA = "0x1863AE020", Slot = "5")]
	public Quaternion NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JFADMOOJPAL : GPNCMEICHNB<Color>, MFIMACLDDLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly DDABGEBFIOI IGPPBNBOEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] HMPKPGGOLLO;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x639DC00", Offset = "0x639CA00", VA = "0x18639DC00")]
	public JFADMOOJPAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x639D530", Offset = "0x639C330", VA = "0x18639D530", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, Color POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x639D870", Offset = "0x639C670", VA = "0x18639D870", Slot = "5")]
	public Color NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class HELBIMKJOMK : GPNCMEICHNB<Bounds>, MFIMACLDDLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly DDABGEBFIOI IGPPBNBOEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] HMPKPGGOLLO;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x639CC60", Offset = "0x639BA60", VA = "0x18639CC60")]
	public HELBIMKJOMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x639C560", Offset = "0x639B360", VA = "0x18639C560", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, Bounds POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x639C880", Offset = "0x639B680", VA = "0x18639C880", Slot = "5")]
	public Bounds NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class BAPHDHNAOAI : GPNCMEICHNB<Rect>, MFIMACLDDLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly DDABGEBFIOI IGPPBNBOEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] HMPKPGGOLLO;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x63957C0", Offset = "0x63945C0", VA = "0x1863957C0")]
	public BAPHDHNAOAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6395060", Offset = "0x6393E60", VA = "0x186395060", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, Rect POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x63953D0", Offset = "0x63941D0", VA = "0x1863953D0", Slot = "5")]
	public Rect NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class IKDLABCNNCF : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private static class GADEEHNCKPB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x346E310", Offset = "0x346D110", VA = "0x18346E310")]
		static GADEEHNCKPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private IKDLABCNNCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class MLHMNBIABMK : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private static class OLMPHJOHFOP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3CE6A10", Offset = "0x3CE5810", VA = "0x183CE6A10")]
		static OLMPHJOHFOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class LABMCCCCHJN
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> KNJAAOGHHON;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x63A88B0", Offset = "0x63A76B0", VA = "0x1863A88B0")]
		internal static object BBKJBDIPCIA(Type EGGPNONKPNJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private MLHMNBIABMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class MKFFHANFIJJ : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class DJDGHFGCGPM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4C733D0", Offset = "0x4C721D0", VA = "0x184C733D0")]
		static DJDGHFGCGPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly MKFFHANFIJJ IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool FEOBCHHLDCF;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static MFIMACLDDLI[] DPCJKFJBIMJ;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static MCCKOEMPDHO[] GNPCGMJHJMA;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private MKFFHANFIJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x63AE780", Offset = "0x63AD580", VA = "0x1863AE780")]
	public static void LAPCBGMBHPD(params MCCKOEMPDHO[] GNPCGMJHJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x63AE6A0", Offset = "0x63AD4A0", VA = "0x1863AE6A0")]
	public static void LAPCBGMBHPD(params MFIMACLDDLI[] DPCJKFJBIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x63AE860", Offset = "0x63AD660", VA = "0x1863AE860")]
	public static void MBIAHCOBHED(MFIMACLDDLI[] DPCJKFJBIMJ, MCCKOEMPDHO[] GNPCGMJHJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class AJCBBFPNJJA : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private static class FJBCIDCCIPJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x33B7C30", Offset = "0x33B6A30", VA = "0x1833B7C30")]
		static FJBCIDCCIPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private AJCBBFPNJJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class BBJPJNIMIHK
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly MCCKOEMPDHO IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly MCCKOEMPDHO LDDGCFHNJGE;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly MCCKOEMPDHO PPOEACAFGJA;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly MCCKOEMPDHO ENAFOPJJNOO;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly MCCKOEMPDHO DCEIOKHJMDL;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly MCCKOEMPDHO JIPLIKGNNEL;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly MCCKOEMPDHO HELKFJDJIMP;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly MCCKOEMPDHO GFEHENHOCPC;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly MCCKOEMPDHO FFJJONBOJJO;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly MCCKOEMPDHO CJKHDDIOMJK;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly MCCKOEMPDHO HOKPEGDAJNJ;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly MCCKOEMPDHO FHDKLEOIHCB;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class IJEFFELENJN
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly MCCKOEMPDHO IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly MCCKOEMPDHO IJLBBDOIJNL;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class PDJPLDOABEM
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly MCCKOEMPDHO IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly MCCKOEMPDHO LDDGCFHNJGE;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly MCCKOEMPDHO PPOEACAFGJA;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly MCCKOEMPDHO ENAFOPJJNOO;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly MCCKOEMPDHO DCEIOKHJMDL;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly MCCKOEMPDHO JIPLIKGNNEL;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly MCCKOEMPDHO HELKFJDJIMP;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly MCCKOEMPDHO GFEHENHOCPC;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly MCCKOEMPDHO FFJJONBOJJO;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly MCCKOEMPDHO CJKHDDIOMJK;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly MCCKOEMPDHO HOKPEGDAJNJ;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly MCCKOEMPDHO FHDKLEOIHCB;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class JFBMKCNGCBC
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> KNJAAOGHHON;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x639DEF0", Offset = "0x639CCF0", VA = "0x18639DEF0")]
	internal static object BBKJBDIPCIA(Type EGGPNONKPNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x639F650", Offset = "0x639E450", VA = "0x18639F650")]
	private static object CPJIMLKJGNM(Type LOFPJLCLFMA, Type[] MNFMECBOOGO, params object[] GOHNIOIALBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class HIOHPHHOIFO : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class NPCABBFIDCA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3BF93F0", Offset = "0x3BF81F0", VA = "0x183BF93F0")]
		static NPCABBFIDCA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> ALPKGJCHNNB;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool PFMEGOFNJJN;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly ECDGPKEMNBJ ICCMEABNCCA;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x639CE40", Offset = "0x639BC40", VA = "0x18639CE40")]
	static HIOHPHHOIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private HIOHPHHOIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class HIPNNABFCAD : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class NEGIBFNMOJL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3BDDDC0", Offset = "0x3BDCBC0", VA = "0x183BDDDC0")]
		static NEGIBFNMOJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> ALPKGJCHNNB;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool PFMEGOFNJJN;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly ECDGPKEMNBJ ICCMEABNCCA;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x639CFB0", Offset = "0x639BDB0", VA = "0x18639CFB0")]
	static HIPNNABFCAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private HIPNNABFCAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class DMDINCEGAPN : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class OEAJODKPFPI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3CC8FC0", Offset = "0x3CC7DC0", VA = "0x183CC8FC0")]
		static OEAJODKPFPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> ALPKGJCHNNB;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool PFMEGOFNJJN;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly ECDGPKEMNBJ ICCMEABNCCA;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6399CA0", Offset = "0x6398AA0", VA = "0x186399CA0")]
	static DMDINCEGAPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private DMDINCEGAPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class ECBAMKBGIAG : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class MGHFKGJODNH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3B69010", Offset = "0x3B67E10", VA = "0x183B69010")]
		static MGHFKGJODNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> ALPKGJCHNNB;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool PFMEGOFNJJN;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly ECDGPKEMNBJ ICCMEABNCCA;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6399E10", Offset = "0x6398C10", VA = "0x186399E10")]
	static ECBAMKBGIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private ECBAMKBGIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class IAGMGDACIKC : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class IKLFMKKMMFI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x369E300", Offset = "0x369D100", VA = "0x18369E300")]
		static IKLFMKKMMFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> ALPKGJCHNNB;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool PFMEGOFNJJN;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly ECDGPKEMNBJ ICCMEABNCCA;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x639D120", Offset = "0x639BF20", VA = "0x18639D120")]
	static IAGMGDACIKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private IAGMGDACIKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class KHPNIBCGAFM : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class DMLMDKEMEMF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4C93DB0", Offset = "0x4C92BB0", VA = "0x184C93DB0")]
		static DMLMDKEMEMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> ALPKGJCHNNB;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool PFMEGOFNJJN;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly ECDGPKEMNBJ ICCMEABNCCA;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x63A02A0", Offset = "0x639F0A0", VA = "0x1863A02A0")]
	static KHPNIBCGAFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private KHPNIBCGAFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class BGOBLGOEGDJ : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class GKHMGOFLCBK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3528690", Offset = "0x3527490", VA = "0x183528690")]
		static GKHMGOFLCBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> ALPKGJCHNNB;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool PFMEGOFNJJN;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public BGOBLGOEGDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class GLJFJCOKJEH : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private static class NFLKPIJCKJD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3BE5350", Offset = "0x3BE4150", VA = "0x183BE5350")]
		static NFLKPIJCKJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> ALPKGJCHNNB;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool PFMEGOFNJJN;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public GLJFJCOKJEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal sealed class OGPDOEEAFFB : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private static class DMEJDAGMHBO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4C8B9C0", Offset = "0x4C8A7C0", VA = "0x184C8B9C0")]
		static DMEJDAGMHBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> ALPKGJCHNNB;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool PFMEGOFNJJN;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public OGPDOEEAFFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class FIEHOIPJCCL : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private static class PNIMIHEGAMC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3DE04B0", Offset = "0x3DDF2B0", VA = "0x183DE04B0")]
		static PNIMIHEGAMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> ALPKGJCHNNB;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool PFMEGOFNJJN;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public FIEHOIPJCCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class CJEMANAPHPP : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private static class PMMEKNLBFJI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7320", Offset = "0x3DD6120", VA = "0x183DD7320")]
		static PMMEKNLBFJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> ALPKGJCHNNB;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool PFMEGOFNJJN;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public CJEMANAPHPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class BELLFHHMJNJ : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private static class APAMDKCLPNK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x36ED860", Offset = "0x36EC660", VA = "0x1836ED860")]
		static APAMDKCLPNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> ALPKGJCHNNB;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool PFMEGOFNJJN;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public BELLFHHMJNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal static class KMNIOCNCJKO
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct FMMPCFCJIDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public NHHOBMACAON BDLMHOCPPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder JLKJKHEOIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder DOPEBJDGNFE;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal static class DDFDGFMEENB
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		internal static class FJDDCFGKNIK
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo JDKOLABMEKP;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo HKBGMBLIEMD;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo JGBIFCDLKJG;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo JCCKEPNEFAL;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo KBPAEJBBEFB;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo BJEIMDICOIP;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo NOEADMPBPAN;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo HPPMDHNBFBN;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo DJPOCGIBGDJ;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x63B58C0", Offset = "0x63B46C0", VA = "0x1863B58C0")]
			static FJDDCFGKNIK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class NNGEBLICDGH
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo FMKIEGLIEIM;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo OGNGFABBCLO;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo OBAOIJMMHFN;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo CPKJPGBAELG;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo JGPIFJJDHHB;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo IPHMDBADFHC;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo OJNBGIHKEGF;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x63C6090", Offset = "0x63C4E90", VA = "0x1863C6090")]
			static NNGEBLICDGH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		internal static class NMGICPFCGAH
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo LHFIHJINMLC;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo EBKOGHOAIHP;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo NELFFAHPACN;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo OJGIKMPHJPG;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo GKMMHJPPKGB;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo GIDAEIKEBAK;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo BGFFDNLPFCB;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo GIHOPPOEAPL;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo EANNFBJBMPD;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo GPHCEMLIGLA;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo JKGPJHGIBMJ;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo NKHJHIGKOCM;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo EBOGEFPKKMF;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo MMAOCCANCHC;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6398140", Offset = "0x6396F40", VA = "0x186398140")]
		public static MethodInfo LJOKGFFEJKK(Type FLHOFPAHPKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x63983D0", Offset = "0x63971D0", VA = "0x1863983D0")]
		public static MethodInfo NLOFGFEMKNI(Type FLHOFPAHPKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6398010", Offset = "0x6396E10", VA = "0x186398010")]
		public static MethodInfo APLDJNFJFNJ(Type FLHOFPAHPKL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class HLGIEBFDNJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<NHHOBMACAON, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public HLGIEBFDNJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class GEIAKJCFCGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public HLGIEBFDNJO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public GEIAKJCFCGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x63B9860", Offset = "0x63B8660", VA = "0x1863B9860")]
		internal void POJKDOANKDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x63B9700", Offset = "0x63B8500", VA = "0x1863B9700")]
		internal bool ABCHKCIFIBL(int index, NHHOBMACAON member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class CGEDPGPJPIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public HLGIEBFDNJO CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public CGEDPGPJPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x63B2F00", Offset = "0x63B1D00", VA = "0x1863B2F00")]
		internal bool KAJGOLEGMMG(int index, NHHOBMACAON member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class BICLBDOPGCE
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

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public BICLBDOPGCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x34B7B40", Offset = "0x34B6940", VA = "0x1834B7B40")]
		internal string AIKPAGOMOBM(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class GBHIIMHKCAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public GBHIIMHKCAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x63B8100", Offset = "0x63B6F00", VA = "0x1863B8100")]
		internal bool DLKDAKFBBHL(NHHOBMACAON x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class IFGAOKICBNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public BICLBDOPGCE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public IFGAOKICBNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x63BCA50", Offset = "0x63BB850", VA = "0x1863BCA50")]
		internal void HMAKEBLJOBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x63BCAD0", Offset = "0x63BB8D0", VA = "0x1863BCAD0")]
		internal bool NPCBCEIECEE(int index, NHHOBMACAON member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class LFKNFCKDONJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public BICLBDOPGCE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public LFKNFCKDONJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x63C0720", Offset = "0x63BF520", VA = "0x1863C0720")]
		internal bool IHIAOJJBPGJ(int index, NHHOBMACAON member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class AGKEIBBCIBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public AGKEIBBCIBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x63B2590", Offset = "0x63B1390", VA = "0x1863B2590")]
		internal Label DECHPIMKIHB(NHHOBMACAON _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class LBBLJCAJLHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public FMMPCFCJIDM[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, NHHOBMACAON, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public LANENKHNAMM argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public LANENKHNAMM argResolver;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public LBBLJCAJLHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x63C0430", Offset = "0x63BF230", VA = "0x1863C0430")]
		internal FMMPCFCJIDM IAMCBINENHO(NHHOBMACAON item)
		{
			return default(FMMPCFCJIDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class BIHPDMNPMNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public LBBLJCAJLHA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public BIHPDMNPMNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x63B2BB0", Offset = "0x63B19B0", VA = "0x1863B2BB0")]
		internal void FACPGBOKIOG(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x63B2E60", Offset = "0x63B1C60", VA = "0x1863B2E60")]
		internal void ICMPCPHGLOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class HLFAEIHGINL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public NHHOBMACAON item;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public HLFAEIHGINL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA7C510", Offset = "0xA7B310", VA = "0x180A7C510")]
		internal bool HPCMDOAJGIL(FMMPCFCJIDM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class JLECMKLNGBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public NHHOBMACAON item;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public JLECMKLNGBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA7C510", Offset = "0xA7B310", VA = "0x180A7C510")]
		internal bool CCAAEPIMOAN(FMMPCFCJIDM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex ELALPODJFNL;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int MLHDLKBLIPO;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> JJKOMKJODKM;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> NINPLIBEGNJ;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2439A50", Offset = "0x2438850", VA = "0x182439A50")]
	public static object CEINNCNIDOL<T>(ECDGPKEMNBJ ICCMEABNCCA, MCCKOEMPDHO FMLJCDFLPMN, Func<string, string> ALPKGJCHNNB, bool PFMEGOFNJJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2444CD0", Offset = "0x2443AD0", VA = "0x182444CD0")]
	public static object GHOJNFFEDPM<T>(MCCKOEMPDHO FMLJCDFLPMN, Func<string, string> ALPKGJCHNNB, bool PFMEGOFNJJN, bool JAPDPMLPPLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x63A6E70", Offset = "0x63A5C70", VA = "0x1863A6E70")]
	private static TypeInfo KOHLIIOBGNL(ECDGPKEMNBJ ICCMEABNCCA, Type FLHOFPAHPKL, Func<string, string> ALPKGJCHNNB, bool PFMEGOFNJJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x63A3D00", Offset = "0x63A2B00", VA = "0x1863A3D00")]
	public static object IEKKFFGEJAL(Type FLHOFPAHPKL, Func<string, string> ALPKGJCHNNB, bool PFMEGOFNJJN, bool JAPDPMLPPLG, bool BCJCHIMLAAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x63A59B0", Offset = "0x63A47B0", VA = "0x1863A59B0")]
	private static Dictionary<NHHOBMACAON, FieldInfo> IHNNIGFHKMF(TypeBuilder PFMAJOMEKKO, GCJHOLKGDGA NIKGGMJCPGD, ConstructorInfo ONHFPAJIPEK, FieldBuilder JPONGICHNHJ, ILGenerator LCMJKNCPEII, bool PFMEGOFNJJN, bool EFPPFKCKOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x63A05D0", Offset = "0x639F3D0", VA = "0x1863A05D0")]
	private static Dictionary<NHHOBMACAON, FieldInfo> ECJNALJCGGA(TypeBuilder PFMAJOMEKKO, GCJHOLKGDGA NIKGGMJCPGD, ILGenerator LCMJKNCPEII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x63A1390", Offset = "0x63A0190", VA = "0x1863A1390")]
	private static void HCODAIPNHCC(Type FLHOFPAHPKL, GCJHOLKGDGA NIKGGMJCPGD, ILGenerator LCMJKNCPEII, Action IPFIAPMPDEK, Func<int, NHHOBMACAON, bool> HMLHKHPCLJK, bool PFMEGOFNJJN, bool EFPPFKCKOHL, int NNNLLOKKACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x63A7890", Offset = "0x63A6690", VA = "0x1863A7890")]
	private static void OADBJILLBAA(TypeInfo FLHOFPAHPKL, NHHOBMACAON KOJDOEOOJLG, ILGenerator LCMJKNCPEII, int OCMJNDDMDAL, Func<int, NHHOBMACAON, bool> HMLHKHPCLJK, LANENKHNAMM FNEJOGEIEJN, LANENKHNAMM KMPMEPFCPHD, LANENKHNAMM DKIPKMNFFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x63A29D0", Offset = "0x63A17D0", VA = "0x1863A29D0")]
	private static void HMJHHLFJPDA(Type FLHOFPAHPKL, GCJHOLKGDGA NIKGGMJCPGD, ILGenerator LCMJKNCPEII, Func<int, NHHOBMACAON, bool> HMLHKHPCLJK, bool CMANDLIHBEK, int NNNLLOKKACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x63A7DD0", Offset = "0x63A6BD0", VA = "0x1863A7DD0")]
	private static void OAIFGIHBLMM(ILGenerator LCMJKNCPEII, FMMPCFCJIDM NIKGGMJCPGD, int OCMJNDDMDAL, Func<int, NHHOBMACAON, bool> HMLHKHPCLJK, LANENKHNAMM GFNJLJABMCF, LANENKHNAMM DKIPKMNFFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x63A60E0", Offset = "0x63A4EE0", VA = "0x1863A60E0")]
	private static LocalBuilder JOMHPPEEJPB(ILGenerator LCMJKNCPEII, Type FLHOFPAHPKL, GCJHOLKGDGA NIKGGMJCPGD, FMMPCFCJIDM[] HAGLEPEGODO, bool AMKPIFFAPPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x63A0CB0", Offset = "0x639FAB0", VA = "0x1863A0CB0")]
	private static bool FJGFKFJBDJF(ConstructorInfo DFJCNKKFKCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x63A5830", Offset = "0x63A4630", VA = "0x1863A5830")]
	private static bool IELGPOFDDHA(Type FLHOFPAHPKL, [Out] Type OHDOIEMJAHP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal delegate void PGBAMEKJCCL<T>(byte[][] JPONGICHNHJ, object[] EIGIILBHCHJ, NLOIOJJEBDP FNEJOGEIEJN, T POACLGOFKAJ, MCCKOEMPDHO OLADLCMFMKB);
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal delegate T BFGICJDCIGG<T>(object[] EIGIILBHCHJ, MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO OLADLCMFMKB);
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class DGODCJDLOAB<T> : GPNCMEICHNB<T>, MFIMACLDDLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] JPONGICHNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] IHDCJLBDLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] IIIKFJGOCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly PGBAMEKJCCL<T> HEICDHHOEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly BFGICJDCIGG<T> NKCMIGKKOOM;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1C4FB70", Offset = "0x1C4E970", VA = "0x181C4FB70")]
	public DGODCJDLOAB(byte[][] JPONGICHNHJ, object[] IHDCJLBDLCP, object[] IIIKFJGOCJD, PGBAMEKJCCL<T> HEICDHHOEOE, BFGICJDCIGG<T> NKCMIGKKOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4C632F0", Offset = "0x4C620F0", VA = "0x184C632F0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, T POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4C633E0", Offset = "0x4C621E0", VA = "0x184C633E0", Slot = "5")]
	public T NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class CNAGLKKLIBC : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private static class IENPGPCIFPL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x368B8B0", Offset = "0x368A6B0", VA = "0x18368B8B0")]
		static IENPGPCIFPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private CNAGLKKLIBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class AICHIJIBGGP : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private static class JEMHKFFCKNK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3849F10", Offset = "0x3848D10", VA = "0x183849F10")]
		static JEMHKFFCKNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private AICHIJIBGGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal static class PLCJFNJNHDN
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly MCCKOEMPDHO[] MMLKPDBLEFC;
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class CIJNJKCNABP : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class FHMDHMALDLA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x33A6590", Offset = "0x33A5390", VA = "0x1833A6590")]
		static FHMDHMALDLA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private sealed class IFBFBGCINIL : MCCKOEMPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		private static class EKPEBMOEAMK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly GPNCMEICHNB<T> FBINFECPCAG;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3043610", Offset = "0x3042410", VA = "0x183043610")]
			static EKPEBMOEAMK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly MCCKOEMPDHO IFFGEIGBEEG;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly MCCKOEMPDHO[] GNPCGMJHJMA;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		private IFBFBGCINIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
		public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly GPNCMEICHNB<object> OBHLGAHPEHD;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private CIJNJKCNABP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class ABFPDIKPCFE : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private static class ADCLFFDAOAI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3444B30", Offset = "0x3443930", VA = "0x183444B30")]
		static ADCLFFDAOAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private sealed class NNOEAPDMFEI : MCCKOEMPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		private static class KLGFCLJMHHK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly GPNCMEICHNB<T> FBINFECPCAG;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x38CC6D0", Offset = "0x38CB4D0", VA = "0x1838CC6D0")]
			static KLGFCLJMHHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly MCCKOEMPDHO IFFGEIGBEEG;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly MCCKOEMPDHO[] GNPCGMJHJMA;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		private NNOEAPDMFEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
		public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly GPNCMEICHNB<object> OBHLGAHPEHD;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private ABFPDIKPCFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal sealed class NIMLFIPFELM : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private static class JBMPGIBJDFE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3831DC0", Offset = "0x3830BC0", VA = "0x183831DC0")]
		static JBMPGIBJDFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class NNIFFJEICCJ : MCCKOEMPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private static class CKHKFPCLELD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly GPNCMEICHNB<T> FBINFECPCAG;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4958E00", Offset = "0x4957C00", VA = "0x184958E00")]
			static CKHKFPCLELD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly MCCKOEMPDHO IFFGEIGBEEG;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly MCCKOEMPDHO[] GNPCGMJHJMA;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		private NNIFFJEICCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
		public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly GPNCMEICHNB<object> OBHLGAHPEHD;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private NIMLFIPFELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal sealed class AGPFNLFBPGN : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private static class DLPCMNDDEDC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4C8AB90", Offset = "0x4C89990", VA = "0x184C8AB90")]
		static DLPCMNDDEDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class GIIGLFNPPGC : MCCKOEMPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		private static class HCMCGGCANGJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly GPNCMEICHNB<T> FBINFECPCAG;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x35AFE80", Offset = "0x35AEC80", VA = "0x1835AFE80")]
			static HCMCGGCANGJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly MCCKOEMPDHO IFFGEIGBEEG;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly MCCKOEMPDHO[] GNPCGMJHJMA;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		private GIIGLFNPPGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
		public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly GPNCMEICHNB<object> OBHLGAHPEHD;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private AGPFNLFBPGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class DJJCDCGIIAF : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private static class DIJLJECNJHK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4C6D610", Offset = "0x4C6C410", VA = "0x184C6D610")]
		static DIJLJECNJHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private sealed class AHJPPLOMENC : MCCKOEMPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		private static class NHMALDKJFIK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly GPNCMEICHNB<T> FBINFECPCAG;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3BEBDE0", Offset = "0x3BEABE0", VA = "0x183BEBDE0")]
			static NHMALDKJFIK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly MCCKOEMPDHO IFFGEIGBEEG;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly MCCKOEMPDHO[] GNPCGMJHJMA;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		private AHJPPLOMENC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
		public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly GPNCMEICHNB<object> OBHLGAHPEHD;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private DJJCDCGIIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class MNOJLFAOCBD : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private static class OAFABILOFIH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3CBCBC0", Offset = "0x3CBB9C0", VA = "0x183CBCBC0")]
		static OAFABILOFIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private sealed class LDJFFNPKMGJ : MCCKOEMPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		private static class DFJMIHCHNDO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly GPNCMEICHNB<T> FBINFECPCAG;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x4C59870", Offset = "0x4C58670", VA = "0x184C59870")]
			static DFJMIHCHNDO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly MCCKOEMPDHO IFFGEIGBEEG;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly MCCKOEMPDHO[] GNPCGMJHJMA;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		private LDJFFNPKMGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
		public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly GPNCMEICHNB<object> OBHLGAHPEHD;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private MNOJLFAOCBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal sealed class PNAOPJOJDGB : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private static class EJHDJMPOHHM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3038020", Offset = "0x3036E20", VA = "0x183038020")]
		static EJHDJMPOHHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private sealed class PJGIEHNNCHP : MCCKOEMPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		private static class DOOOFAEMIMC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly GPNCMEICHNB<T> FBINFECPCAG;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x4C9AE60", Offset = "0x4C99C60", VA = "0x184C9AE60")]
			static DOOOFAEMIMC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly MCCKOEMPDHO IFFGEIGBEEG;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly MCCKOEMPDHO[] GNPCGMJHJMA;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		private PJGIEHNNCHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
		public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly GPNCMEICHNB<object> OBHLGAHPEHD;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private PNAOPJOJDGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal sealed class DPDJDINMLBI : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private static class BDEBLIIGLCN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4437FA0", Offset = "0x4436DA0", VA = "0x184437FA0")]
		static BDEBLIIGLCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private sealed class NJMMCNCFGEK : MCCKOEMPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private static class MBKMOOFODMG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly GPNCMEICHNB<T> FBINFECPCAG;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3B588A0", Offset = "0x3B576A0", VA = "0x183B588A0")]
			static MBKMOOFODMG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly MCCKOEMPDHO IFFGEIGBEEG;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly MCCKOEMPDHO[] GNPCGMJHJMA;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		private NJMMCNCFGEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
		public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly GPNCMEICHNB<object> OBHLGAHPEHD;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private DPDJDINMLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal sealed class HCJCAAKOMML : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private static class HDOHBDGLNFN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x35D23C0", Offset = "0x35D11C0", VA = "0x1835D23C0")]
		static HDOHBDGLNFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private sealed class GBEAONBNGPK : MCCKOEMPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		private static class GINEENMOPDO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly GPNCMEICHNB<T> FBINFECPCAG;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3522A20", Offset = "0x3521820", VA = "0x183522A20")]
			static GINEENMOPDO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly MCCKOEMPDHO IFFGEIGBEEG;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly MCCKOEMPDHO[] GNPCGMJHJMA;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		private GBEAONBNGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
		public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly GPNCMEICHNB<object> OBHLGAHPEHD;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private HCJCAAKOMML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
internal sealed class IBJMAPDANKB : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private static class OACOEGIIKBE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3CB94D0", Offset = "0x3CB82D0", VA = "0x183CB94D0")]
		static OACOEGIIKBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private sealed class PMCHLFKLGPA : MCCKOEMPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		private static class BFFCALJCDFJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly GPNCMEICHNB<T> FBINFECPCAG;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x4441480", Offset = "0x4440280", VA = "0x184441480")]
			static BFFCALJCDFJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly MCCKOEMPDHO IFFGEIGBEEG;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly MCCKOEMPDHO[] GNPCGMJHJMA;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		private PMCHLFKLGPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
		public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly GPNCMEICHNB<object> OBHLGAHPEHD;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private IBJMAPDANKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal sealed class FAOAOKCBICJ : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private static class CHAHBBMLKKC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x478A300", Offset = "0x4789100", VA = "0x18478A300")]
		static CHAHBBMLKKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private sealed class LIKHJBFPKGH : MCCKOEMPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		private static class JDFBNMGPHJF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly GPNCMEICHNB<T> FBINFECPCAG;

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x3837820", Offset = "0x3836620", VA = "0x183837820")]
			static JDFBNMGPHJF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly MCCKOEMPDHO IFFGEIGBEEG;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly MCCKOEMPDHO[] GNPCGMJHJMA;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		private LIKHJBFPKGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
		public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly GPNCMEICHNB<object> OBHLGAHPEHD;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private FAOAOKCBICJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
internal sealed class ELMOOHAHOFP : MCCKOEMPDHO
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private static class IEHCJKPIBCO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly GPNCMEICHNB<T> FBINFECPCAG;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3678160", Offset = "0x3676F60", VA = "0x183678160")]
		static IEHCJKPIBCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private sealed class FOBLKHPLABB : MCCKOEMPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		private static class OCCAGICIDPA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly GPNCMEICHNB<T> FBINFECPCAG;

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3CC4960", Offset = "0x3CC3760", VA = "0x183CC4960")]
			static OCCAGICIDPA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly MCCKOEMPDHO IFFGEIGBEEG;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly MCCKOEMPDHO[] GNPCGMJHJMA;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		private FOBLKHPLABB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
		public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly MCCKOEMPDHO IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly GPNCMEICHNB<object> OBHLGAHPEHD;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	private ELMOOHAHOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	public GPNCMEICHNB<T> BBKJBDIPCIA<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct JJMLCBMAIBL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] BKFDNLGBLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int MGLJLKOIJDH;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x38576C0", Offset = "0x38564C0", VA = "0x1838576C0")]
	public JJMLCBMAIBL(int JBAAECKLFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3857460", Offset = "0x3856260", VA = "0x183857460")]
	public void EJEJBLJEAIN(T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3857630", Offset = "0x3856430", VA = "0x183857630")]
	public T[] MLPHCNLCDBJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal sealed class ODIJKFHPPJD : HCBAMPOPHHF<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly ODIJKFHPPJD IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x63C7900", Offset = "0x63C6700", VA = "0x1863C7900")]
	public ODIJKFHPPJD(int KDLOFHAIPLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class HCBAMPOPHHF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int KDLOFHAIPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object NBJCNHACLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int OCMJNDDMDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] FHKPMDOLPOB;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x35AC9F0", Offset = "0x35AB7F0", VA = "0x1835AC9F0")]
	public HCBAMPOPHHF(int KDLOFHAIPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x35AC630", Offset = "0x35AB430", VA = "0x1835AC630")]
	public T[] MJEBFBLCCCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x35AC330", Offset = "0x35AB130", VA = "0x1835AC330")]
	public void JLHCBIGDMLG(T[] OBEMKDLNKLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class DDABGEBFIOI : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private class FJKPKPHODFC : IComparable<FJKPKPHODFC>
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class DKFJNBJEHLH : IEnumerable<FJKPKPHODFC>, IEnumerable, IEnumerator<FJKPKPHODFC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private FJKPKPHODFC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public FJKPKPHODFC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private FJKPKPHODFC System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x86F050", Offset = "0x86DE50", VA = "0x18086F050")]
			[DebuggerHidden]
			public DKFJNBJEHLH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x63B4C10", Offset = "0x63B3A10", VA = "0x1863B4C10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x63B4D40", Offset = "0x63B3B40", VA = "0x1863B4D40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x63B4C90", Offset = "0x63B3A90", VA = "0x1863B4C90", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<FJKPKPHODFC> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x63B4C90", Offset = "0x63B3A90", VA = "0x1863B4C90", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private sealed class ACNHNHGCGDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public ACNHNHGCGDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x63B2590", Offset = "0x63B1390", VA = "0x1863B2590")]
			internal Label BIHLACIDEGB(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x63B2590", Offset = "0x63B1390", VA = "0x1863B2590")]
			internal Label KFLODEEADCP(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly FJKPKPHODFC[] CHEKOLGFKCN;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] CKKCIJKHBKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong OBPJFFDCAMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int CAGIMKNDHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string CCPKOCBIPGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private FJKPKPHODFC[] CLOJEDFDNIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] EODHCELGMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int NENAAIFMEME;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool JOBNCOGCNNO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x4F3EFC0", Offset = "0x4F3DDC0", VA = "0x184F3EFC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x63B7CA0", Offset = "0x63B6AA0", VA = "0x1863B7CA0")]
		public FJKPKPHODFC(ulong GMOPMNAPKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x63B6790", Offset = "0x63B5590", VA = "0x1863B6790")]
		public FJKPKPHODFC EJEJBLJEAIN(ulong GMOPMNAPKBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x63B6730", Offset = "0x63B5530", VA = "0x1863B6730")]
		public FJKPKPHODFC EJEJBLJEAIN(ulong GMOPMNAPKBE, int POACLGOFKAJ, string CCPKOCBIPGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x63B6D90", Offset = "0x63B5B90", VA = "0x1863B6D90")]
		public FJKPKPHODFC HPEHEOGKMGF(byte[] ADKJANDCMME, int NNACFOFLCKF, int EEPIAGCBEIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x63B66A0", Offset = "0x63B54A0", VA = "0x1863B66A0")]
		internal static int DFAFPANBCKH(ulong[] OBEMKDLNKLE, int OCMJNDDMDAL, int JGMNJBPPKGP, ulong POACLGOFKAJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x63B6670", Offset = "0x63B5470", VA = "0x1863B6670", Slot = "4")]
		public int CompareTo(FJKPKPHODFC LKMMHIOOCMN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x63B6990", Offset = "0x63B5790", VA = "0x1863B6990")]
		[IteratorStateMachine(typeof(DKFJNBJEHLH))]
		public IEnumerable<FJKPKPHODFC> ENEFEFDEBNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x63B6A10", Offset = "0x63B5810", VA = "0x1863B6A10")]
		public void EOCFOKEIDGA(ILGenerator LCMJKNCPEII, LocalBuilder ADKJANDCMME, LocalBuilder EEPIAGCBEIL, LocalBuilder GMOPMNAPKBE, Action<KeyValuePair<string, int>> DAKOPKNPJPC, Action IMDIOABKOBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x63B6F10", Offset = "0x63B5D10", VA = "0x1863B6F10")]
		private static void OGJAPCBIBOO(ILGenerator LCMJKNCPEII, LocalBuilder ADKJANDCMME, LocalBuilder EEPIAGCBEIL, LocalBuilder GMOPMNAPKBE, Action<KeyValuePair<string, int>> DAKOPKNPJPC, Action IMDIOABKOBA, FJKPKPHODFC[] CLOJEDFDNIJ, int NENAAIFMEME)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class JLAMOLJMPKE : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<FJKPKPHODFC> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<FJKPKPHODFC> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<FJKPKPHODFC> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private FJKPKPHODFC <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x95F230", Offset = "0x95E030", VA = "0x18095F230", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x63BEBF0", Offset = "0x63BD9F0", VA = "0x1863BEBF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1B673D0", Offset = "0x1B661D0", VA = "0x181B673D0")]
		[DebuggerHidden]
		public JLAMOLJMPKE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x63BEC40", Offset = "0x63BDA40", VA = "0x1863BEC40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x63BE690", Offset = "0x63BD490", VA = "0x1863BE690", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x63BE640", Offset = "0x63BD440", VA = "0x1863BE640")]
		private void LAJOCHINEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x63BE5F0", Offset = "0x63BD3F0", VA = "0x1863BE5F0")]
		private void KMKNJEPJJNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x63BEBA0", Offset = "0x63BD9A0", VA = "0x1863BEBA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x63BEAF0", Offset = "0x63BD8F0", VA = "0x1863BEAF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x63BEAF0", Offset = "0x63BD8F0", VA = "0x1863BEAF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly FJKPKPHODFC PHNFANHCONA;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x63B4A10", Offset = "0x63B3810", VA = "0x1863B4A10")]
	public DDABGEBFIOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x63B4680", Offset = "0x63B3480", VA = "0x1863B4680")]
	public void EJEJBLJEAIN(byte[] LKHDKNBOMJD, int POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x63B47C0", Offset = "0x63B35C0", VA = "0x1863B47C0")]
	public bool GCNGLGHPFLA(ArraySegment<byte> GMOPMNAPKBE, [Out] int POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x63B4980", Offset = "0x63B3780", VA = "0x1863B4980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x63B43A0", Offset = "0x63B31A0", VA = "0x1863B43A0")]
	private static void CLAILDLKMJA(IEnumerable<FJKPKPHODFC> CLOJEDFDNIJ, StringBuilder GPMCJPHJCFI, int OBEANJHCKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x63B48A0", Offset = "0x63B36A0", VA = "0x1863B48A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x63B48A0", Offset = "0x63B36A0", VA = "0x1863B48A0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x63B4900", Offset = "0x63B3700", VA = "0x1863B4900")]
	[IteratorStateMachine(typeof(JLAMOLJMPKE))]
	private static IEnumerable<KeyValuePair<string, int>> JBJKGLBKGCH(IEnumerable<FJKPKPHODFC> CLOJEDFDNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x63B4790", Offset = "0x63B3590", VA = "0x1863B4790")]
	public void FJLPKIOIDPK(ILGenerator LCMJKNCPEII, LocalBuilder ADKJANDCMME, LocalBuilder EEPIAGCBEIL, LocalBuilder GMOPMNAPKBE, Action<KeyValuePair<string, int>> DAKOPKNPJPC, Action IMDIOABKOBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class KAIOPPPFGOP
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo AGALEMLGGPL;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x63BF3D0", Offset = "0x63BE1D0", VA = "0x1863BF3D0")]
	public static ulong AGAKPDIEDFM(byte[] LKHDKNBOMJD, int NNACFOFLCKF, int EEPIAGCBEIL)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class GKFFDPEJIBP
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x63B9B30", Offset = "0x63B8930", VA = "0x1863B9B30")]
	public static void AMFLFFMLCMA(byte[] LKHDKNBOMJD, int NNACFOFLCKF, int EJMPKIBPAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x63B9C70", Offset = "0x63B8A70", VA = "0x1863B9C70")]
	public static void BDLOKGJOCKK(byte[] OBEMKDLNKLE, int FFKAIEDDKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x63B9D90", Offset = "0x63B8B90", VA = "0x1863B9D90")]
	public static byte[] MAKLEGIILAI(byte[] ECAFGEFAJGI, int FFKAIEDDKPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class MADOEEJIDFG
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x63C0B60", Offset = "0x63BF960", VA = "0x1863C0B60")]
	public static bool LHMKAMGHECE(byte[] AGFIPFCILKH, int KLCIJOIOMDC, int ILIEJKANGBL, byte[] OIJAAOLANIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal class KGFLFOKEFIM<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private struct MODNGDBMIDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] OBPJFFDCAMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T CAGIMKNDHKH;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3B9C480", Offset = "0x3B9B280", VA = "0x183B9C480", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class GEJLPHKLHEN : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public KGFLFOKEFIM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private MODNGDBMIDC[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private MODNGDBMIDC[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x95F230", Offset = "0x95E030", VA = "0x18095F230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x3403410", Offset = "0x3402210", VA = "0x183403410", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
		[DebuggerHidden]
		public GEJLPHKLHEN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x34849A0", Offset = "0x34837A0", VA = "0x1834849A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3485020", Offset = "0x3483E20", VA = "0x183485020", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly MODNGDBMIDC[][] CFOFFEFBOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong BBNLKIMDKEK;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x38B1E10", Offset = "0x38B0C10", VA = "0x1838B1E10")]
	public KGFLFOKEFIM(int LCFOKPAENOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x38B1D50", Offset = "0x38B0B50", VA = "0x1838B1D50")]
	public KGFLFOKEFIM(int LCFOKPAENOI, float MHGEPIGHLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x38A2810", Offset = "0x38A1610", VA = "0x1838A2810")]
	public void EJEJBLJEAIN(byte[] GMOPMNAPKBE, T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x38A7080", Offset = "0x38A5E80", VA = "0x1838A7080")]
	private bool GDMHCADPBML(byte[] GMOPMNAPKBE, T POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x38AF7E0", Offset = "0x38AE5E0", VA = "0x1838AF7E0")]
	public bool HOKMFLFGDOM(ArraySegment<byte> GMOPMNAPKBE, [Out] T POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x38AC760", Offset = "0x38AB560", VA = "0x1838AC760")]
	private static ulong GPNCCHICKLL(byte[] NPDPLEIHBMM, int NNACFOFLCKF, int NENAAIFMEME)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x38B1D20", Offset = "0x38B0B20", VA = "0x1838B1D20")]
	private static int KPKJMIKAIOE(int GCEOKCELPOC, float MHGEPIGHLCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x38AC7B0", Offset = "0x38AB5B0", VA = "0x1838AC7B0", Slot = "4")]
	[IteratorStateMachine(typeof(KGFLFOKEFIM<>.GEJLPHKLHEN))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x31A9D20", Offset = "0x31A8B20", VA = "0x1831A9D20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class OBJAIPFPOKD : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] DADBHNKNPOP;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] JJGMPMMBFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int DDPMJDDJPCL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool LHMFDCPJLBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x63C7420", Offset = "0x63C6220", VA = "0x1863C7420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x63C7570", Offset = "0x63C6370", VA = "0x1863C7570")]
	static OBJAIPFPOKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x63C77D0", Offset = "0x63C65D0", VA = "0x1863C77D0")]
	public OBJAIPFPOKD(byte[] AEAJKPPJPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x63C7470", Offset = "0x63C6270", VA = "0x1863C7470")]
	public OpCode HICNEHONMHC()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal struct GKONJEFNLAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid CAGIMKNDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte PKOCDIGAMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte EGFJLECIOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte FPAIPMJOKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte PGFMLAIPPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte JOBGOAJKFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte DPOGMLIECON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte NNEKAEMNMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte LMFDLBBLNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte FNLIGDFMFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte GLGGPCKHBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte DIFEEICHNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte OIMHBJAIONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte AIAFOPCFNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte BHGJMDOOHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte GDOHDLLAIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte AMMOAMELFIG;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] ICEMDJOMNAN;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] PJEFKHPNABC;

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x63BAE20", Offset = "0x63B9C20", VA = "0x1863BAE20")]
	public GKONJEFNLAA(Guid POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x63BAE30", Offset = "0x63B9C30", VA = "0x1863BAE30")]
	public GKONJEFNLAA(ArraySegment<byte> FKGPEGDDDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x63BAC90", Offset = "0x63B9A90", VA = "0x1863BAC90")]
	private static byte FNOGLPJAIFH(byte[] LKHDKNBOMJD, int LHLKIPDKCGP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x63B9EC0", Offset = "0x63B8CC0", VA = "0x1863B9EC0")]
	private static byte EEIOMPEPBMN(byte DFBIFCHBAHF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x63B9FE0", Offset = "0x63B8DE0", VA = "0x1863B9FE0")]
	public void FFKIDNKHFEK(byte[] BLPPMOBNKNN, int NNACFOFLCKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class OMPKMLLNBOM
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x63C86C0", Offset = "0x63C74C0", VA = "0x1863C86C0")]
	public static bool ICNFFEMLCLO(byte BOGFMIDGHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x63C8B00", Offset = "0x63C7900", VA = "0x1863C8B00")]
	public static bool NOAGGBABDGE(byte BOGFMIDGHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x63C85E0", Offset = "0x63C73E0", VA = "0x1863C85E0")]
	public static sbyte IBKLHJHPNGN(byte[] LKHDKNBOMJD, int NNACFOFLCKF, [Out] int GCLHHAGNNLA)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x63C8770", Offset = "0x63C7570", VA = "0x1863C8770")]
	public static short KACKGBACKND(byte[] LKHDKNBOMJD, int NNACFOFLCKF, [Out] int GCLHHAGNNLA)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x63C84F0", Offset = "0x63C72F0", VA = "0x1863C84F0")]
	public static int HJGDGJACEPB(byte[] LKHDKNBOMJD, int NNACFOFLCKF, [Out] int GCLHHAGNNLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x63C86D0", Offset = "0x63C74D0", VA = "0x1863C86D0")]
	public static long IHMPIBCMHAH(byte[] LKHDKNBOMJD, int NNACFOFLCKF, [Out] int GCLHHAGNNLA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x63C8360", Offset = "0x63C7160", VA = "0x1863C8360")]
	public static byte GDGCDLKBFFI(byte[] LKHDKNBOMJD, int NNACFOFLCKF, [Out] int GCLHHAGNNLA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x63C8260", Offset = "0x63C7060", VA = "0x1863C8260")]
	public static ushort DNMFBIFKNHG(byte[] LKHDKNBOMJD, int NNACFOFLCKF, [Out] int GCLHHAGNNLA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x63C82E0", Offset = "0x63C70E0", VA = "0x1863C82E0")]
	public static uint EPBLHNALCLH(byte[] LKHDKNBOMJD, int NNACFOFLCKF, [Out] int GCLHHAGNNLA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x63C83E0", Offset = "0x63C71E0", VA = "0x1863C83E0")]
	public static ulong HBJJICCKMMN(byte[] LKHDKNBOMJD, int NNACFOFLCKF, [Out] int GCLHHAGNNLA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x63C81F0", Offset = "0x63C6FF0", VA = "0x1863C81F0")]
	public static float BCGMNLACHPJ(byte[] LKHDKNBOMJD, int NNACFOFLCKF, [Out] int GCLHHAGNNLA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x63C8860", Offset = "0x63C7660", VA = "0x1863C8860")]
	public static double NDALBMEFLKP(byte[] LKHDKNBOMJD, int NNACFOFLCKF, [Out] int GCLHHAGNNLA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x63C8B70", Offset = "0x63C7970", VA = "0x1863C8B70")]
	public static int OBIPIJACEOE(byte[] BLPPMOBNKNN, int NNACFOFLCKF, ulong POACLGOFKAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x63C9210", Offset = "0x63C8010", VA = "0x1863C9210")]
	public static int PMNINOMDNAG(byte[] BLPPMOBNKNN, int NNACFOFLCKF, long POACLGOFKAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x63C88D0", Offset = "0x63C76D0", VA = "0x1863C88D0")]
	public static bool NHLCGFIELPG(byte[] LKHDKNBOMJD, int NNACFOFLCKF, [Out] int GCLHHAGNNLA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class OABGBOGLMJJ
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class IGADEIFLJFN : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x86F050", Offset = "0x86DE50", VA = "0x18086F050")]
		[DebuggerHidden]
		public IGADEIFLJFN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x63BD290", Offset = "0x63BC090", VA = "0x1863BD290", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x63BCD50", Offset = "0x63BBB50", VA = "0x1863BCD50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x63BCD00", Offset = "0x63BBB00", VA = "0x1863BCD00")]
		private void LAJOCHINEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x63BCCB0", Offset = "0x63BBAB0", VA = "0x1863BCCB0")]
		private void KMKNJEPJJNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x63BD240", Offset = "0x63BC040", VA = "0x1863BD240", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x63BD180", Offset = "0x63BBF80", VA = "0x1863BD180", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x63BD180", Offset = "0x63BBF80", VA = "0x1863BD180", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class NBLGCKJEPNA : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x86F050", Offset = "0x86DE50", VA = "0x18086F050")]
		[DebuggerHidden]
		public NBLGCKJEPNA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x63C5090", Offset = "0x63C3E90", VA = "0x1863C5090", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x63C4B50", Offset = "0x63C3950", VA = "0x1863C4B50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x63C4B00", Offset = "0x63C3900", VA = "0x1863C4B00")]
		private void LAJOCHINEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x63C4AB0", Offset = "0x63C38B0", VA = "0x1863C4AB0")]
		private void KMKNJEPJJNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x63C5040", Offset = "0x63C3E40", VA = "0x1863C5040", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x63C4F80", Offset = "0x63C3D80", VA = "0x1863C4F80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x63C4F80", Offset = "0x63C3D80", VA = "0x1863C4F80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x63C72C0", Offset = "0x63C60C0", VA = "0x1863C72C0")]
	public static bool MJLJIPKPDNE(this TypeInfo FLHOFPAHPKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x63C7190", Offset = "0x63C5F90", VA = "0x1863C7190")]
	public static bool LFHOKOPCOMK(this TypeInfo FLHOFPAHPKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x63C6FF0", Offset = "0x63C5DF0", VA = "0x1863C6FF0")]
	public static IEnumerable<PropertyInfo> EEFMGFCOLCG(this Type FLHOFPAHPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x63C7380", Offset = "0x63C6180", VA = "0x1863C7380")]
	[IteratorStateMachine(typeof(IGADEIFLJFN))]
	private static IEnumerable<PropertyInfo> PDJFJNGHNNO(Type FLHOFPAHPKL, HashSet<string> CKNCHHOFDJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x63C7110", Offset = "0x63C5F10", VA = "0x1863C7110")]
	public static IEnumerable<FieldInfo> IPAEDAGLCDH(this Type FLHOFPAHPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x63C7070", Offset = "0x63C5E70", VA = "0x1863C7070")]
	[IteratorStateMachine(typeof(NBLGCKJEPNA))]
	private static IEnumerable<FieldInfo> INAOPJEIIHD(Type FLHOFPAHPKL, HashSet<string> CKNCHHOFDJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class LMJBBBEKOKG
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding MGMMMEMMPLL;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal static class KPGNADLOKCH
{
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0xA2B7C0", Offset = "0xA2A5C0", VA = "0x180A2B7C0")]
	public static string KLOCEOEMKBK(string LKLGJOPBKIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x63C0180", Offset = "0x63BEF80", VA = "0x1863C0180")]
	public static string OICGLJFEOJL(string LKLGJOPBKIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x63BFFF0", Offset = "0x63BEDF0", VA = "0x1863BFFF0")]
	public static string ALOADEEFONH(string LKLGJOPBKIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class NDELOLJPHPH<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class JDLONOAPEBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type OBPJFFDCAMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue CAGIMKNDHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int LGOMHKNINIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public JDLONOAPEBM FKIKGLFLOCI;

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x38383A0", Offset = "0x38371A0", VA = "0x1838383A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3838360", Offset = "0x3837160", VA = "0x183838360")]
		private int GJPDNICHPHI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public JDLONOAPEBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class GJLNEECDCOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public GJLNEECDCOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99990", VA = "0x180A9AB90")]
		internal TValue HENDFHPKLBD(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private JDLONOAPEBM[] CFOFFEFBOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int GINFBCJKIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object JCDFHDIOMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float MHGEPIGHLCA;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x3BD6830", Offset = "0x3BD5630", VA = "0x183BD6830")]
	public NDELOLJPHPH(int LCFOKPAENOI = 4, float MHGEPIGHLCA = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x3BD5C80", Offset = "0x3BD4A80", VA = "0x183BD5C80")]
	public bool LIKNKLMMDGB(Type GMOPMNAPKBE, TValue POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x3BD5DB0", Offset = "0x3BD4BB0", VA = "0x183BD5DB0")]
	public bool LIKNKLMMDGB(Type GMOPMNAPKBE, Func<Type, TValue> NAAIABDDIFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3BD51D0", Offset = "0x3BD3FD0", VA = "0x183BD51D0")]
	private bool GDMHCADPBML(Type GMOPMNAPKBE, Func<Type, TValue> NAAIABDDIFL, [Out] TValue LNCIBFGMKGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3BD5E20", Offset = "0x3BD4C20", VA = "0x183BD5E20")]
	private bool PGIHLBBDHCD(JDLONOAPEBM[] CFOFFEFBOIF, Type FIJCAEKEJML, JDLONOAPEBM MPPOIHEPPIK, Func<Type, TValue> NAAIABDDIFL, [Out] TValue LNCIBFGMKGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3BD59C0", Offset = "0x3BD47C0", VA = "0x183BD59C0")]
	public bool HOKMFLFGDOM(Type GMOPMNAPKBE, [Out] TValue POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3BD65D0", Offset = "0x3BD53D0", VA = "0x183BD65D0")]
	public TValue PHONIDHHJMI(Type GMOPMNAPKBE, Func<Type, TValue> NAAIABDDIFL)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x38B1D20", Offset = "0x38B0B20", VA = "0x1838B1D20")]
	private static int KPKJMIKAIOE(int GCEOKCELPOC, float MHGEPIGHLCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3BD5DF0", Offset = "0x3BD4BF0", VA = "0x183BD5DF0")]
	private static void OMKAOKFBKCO(JDLONOAPEBM IPLJFCBLLJK, JDLONOAPEBM POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3BD5DF0", Offset = "0x3BD4BF0", VA = "0x183BD5DF0")]
	private static void OMKAOKFBKCO(JDLONOAPEBM[] IPLJFCBLLJK, JDLONOAPEBM[] POACLGOFKAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class ECDGPKEMNBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder GONEAGOKKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder NBFDLKALCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object NBJCNHACLLE;

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x63B4FF0", Offset = "0x63B3DF0", VA = "0x1863B4FF0")]
	public TypeBuilder JOGOCKFGEFM(string MEBBBIMBIJO, TypeAttributes BGKCGMOALLF, Type LPDGANJNOMK, Type[] OBHLMBFEFMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x63B50F0", Offset = "0x63B3EF0", VA = "0x1863B50F0")]
	public ECDGPKEMNBJ(string FICAFFLACFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal static class DMCLHELFHOO
{
	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x63B4D90", Offset = "0x63B3B90", VA = "0x1863B4D90")]
	private static MethodInfo BELALGGCGBJ(LambdaExpression PDPCDBCBFLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x221F1A0", Offset = "0x221DFA0", VA = "0x18221F1A0")]
	public static MethodInfo PEPHENIFIFJ<T>(Expression<Func<T>> PDPCDBCBFLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x221F1A0", Offset = "0x221DFA0", VA = "0x18221F1A0")]
	public static MethodInfo PEPHENIFIFJ<T, TR>(Expression<Func<T, TR>> PDPCDBCBFLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x221F1A0", Offset = "0x221DFA0", VA = "0x18221F1A0")]
	public static MethodInfo PEPHENIFIFJ<T>(Expression<Action<T>> PDPCDBCBFLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x221F1A0", Offset = "0x221DFA0", VA = "0x18221F1A0")]
	public static MethodInfo PEPHENIFIFJ<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> PDPCDBCBFLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x221F0C0", Offset = "0x221DEC0", VA = "0x18221F0C0")]
	private static MemberInfo KFBLKOBMBJG<T>(Expression<T> PGGBKFCMLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x221F020", Offset = "0x221DE20", VA = "0x18221F020")]
	public static PropertyInfo AJCEJKGEPAJ<T, TR>(Expression<Func<T, TR>> PDPCDBCBFLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal struct LANENKHNAMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int NAKKFLBPDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool JBAFMBOMJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator LCMJKNCPEII;

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x63C03F0", Offset = "0x63BF1F0", VA = "0x1863C03F0")]
	public LANENKHNAMM(ILGenerator LCMJKNCPEII, int NAKKFLBPDCC, bool JBAFMBOMJKI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x63C0360", Offset = "0x63BF160", VA = "0x1863C0360")]
	public LANENKHNAMM(ILGenerator LCMJKNCPEII, int NAKKFLBPDCC, Type FLHOFPAHPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x63C0260", Offset = "0x63BF060", VA = "0x1863C0260")]
	public void LJOJEFMCBDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class IHKHLMAJBLC
{
	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x63BDB10", Offset = "0x63BC910", VA = "0x1863BDB10")]
	public static void MGLGGKMGIFP(this ILGenerator LCMJKNCPEII, int OCMJNDDMDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x63BDD00", Offset = "0x63BCB00", VA = "0x1863BDD00")]
	public static void MGLGGKMGIFP(this ILGenerator LCMJKNCPEII, LocalBuilder NLKDHDGPOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x63BE120", Offset = "0x63BCF20", VA = "0x1863BE120")]
	public static void NJEOGOFJLAJ(this ILGenerator LCMJKNCPEII, int OCMJNDDMDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x63BE310", Offset = "0x63BD110", VA = "0x1863BE310")]
	public static void NJEOGOFJLAJ(this ILGenerator LCMJKNCPEII, LocalBuilder NLKDHDGPOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x63BD6B0", Offset = "0x63BC4B0", VA = "0x1863BD6B0")]
	public static void CDPPCDPCOGA(this ILGenerator LCMJKNCPEII, int OCMJNDDMDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x63BD5B0", Offset = "0x63BC3B0", VA = "0x1863BD5B0")]
	public static void CDPPCDPCOGA(this ILGenerator LCMJKNCPEII, LocalBuilder NLKDHDGPOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x63BDA10", Offset = "0x63BC810", VA = "0x1863BDA10")]
	public static void KAEOKAFGABO(this ILGenerator LCMJKNCPEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x63BE350", Offset = "0x63BD150", VA = "0x1863BE350")]
	public static void PGKGIDPFLJF(this ILGenerator LCMJKNCPEII, bool POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x63BDD40", Offset = "0x63BCB40", VA = "0x1863BDD40")]
	public static void NJECCDAJMHD(this ILGenerator LCMJKNCPEII, int POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x63BD8B0", Offset = "0x63BC6B0", VA = "0x1863BD8B0")]
	public static void HLAINMMNNBM(this ILGenerator LCMJKNCPEII, Type FLHOFPAHPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x63BE440", Offset = "0x63BD240", VA = "0x1863BE440")]
	public static void POKKBFLMINN(this ILGenerator LCMJKNCPEII, Type FLHOFPAHPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x63BD3C0", Offset = "0x63BC1C0", VA = "0x1863BD3C0")]
	public static void CABPPPHLDHE(this ILGenerator LCMJKNCPEII, int OCMJNDDMDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x63BD990", Offset = "0x63BC790", VA = "0x1863BD990")]
	public static void IIDJACEOFHE(this ILGenerator LCMJKNCPEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x63BE360", Offset = "0x63BD160", VA = "0x1863BE360")]
	public static void PKLLBIGPGGK(this ILGenerator LCMJKNCPEII, int OCMJNDDMDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x63BDA20", Offset = "0x63BC820", VA = "0x1863BDA20")]
	public static void LJJDMHCMOBF(this ILGenerator LCMJKNCPEII, MethodInfo AFGGLLKDDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x63BD790", Offset = "0x63BC590", VA = "0x1863BD790")]
	public static void CHHMNNPJPAK(this ILGenerator LCMJKNCPEII, FieldInfo DJBJFENHKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x63BD820", Offset = "0x63BC620", VA = "0x1863BD820")]
	public static void FKEKDIDPBBP(this ILGenerator LCMJKNCPEII, ulong POACLGOFKAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class NHHOBMACAON
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class JADPNBAPGEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public JADPNBAPGEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x63BE4E0", Offset = "0x63BD2E0", VA = "0x1863BE4E0")]
		internal bool AIINLPFAOPP(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo BDDOHEMJIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo KJOLPDIMNAJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string FJPKIFMMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7619C0", Offset = "0x7607C0", VA = "0x1807619C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string AGKLBDOLLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x760C60", Offset = "0x75FA60", VA = "0x180760C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AGIGGBJBJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x63C54B0", Offset = "0x63C42B0", VA = "0x1863C54B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool CMMLNLGBGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7656C0", Offset = "0x7644C0", VA = "0x1807656C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x765470", Offset = "0x764270", VA = "0x180765470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool INPOBGEBBCP
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3B0", Offset = "0x7FB1B0", VA = "0x1807FC3B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0A0", Offset = "0x7FAEA0", VA = "0x1807FC0A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type HHINMKNAKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7654C0", Offset = "0x7642C0", VA = "0x1807654C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x766E40", Offset = "0x765C40", VA = "0x180766E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo BKOLLDLEPCI
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x763890", Offset = "0x762690", VA = "0x180763890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo AHAFGBBFNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7654A0", Offset = "0x7642A0", VA = "0x1807654A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x765480", Offset = "0x764280", VA = "0x180765480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo NNOOFFDLFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x769880", Offset = "0x768680", VA = "0x180769880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x765490", Offset = "0x764290", VA = "0x180765490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x63C5800", Offset = "0x63C4600", VA = "0x1863C5800")]
	protected NHHOBMACAON(Type FLHOFPAHPKL, string MEBBBIMBIJO, string DAADODGEGPB, bool EKAJADLNAMH, bool BHBNGCHGPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x63C5880", Offset = "0x63C4680", VA = "0x1863C5880")]
	public NHHOBMACAON(FieldInfo NIKGGMJCPGD, string MEBBBIMBIJO, bool JAPDPMLPPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x63C5640", Offset = "0x63C4440", VA = "0x1863C5640")]
	public NHHOBMACAON(PropertyInfo NIKGGMJCPGD, string MEBBBIMBIJO, bool JAPDPMLPPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x63C5340", Offset = "0x63C4140", VA = "0x1863C5340")]
	private static MethodInfo BCMLLLMBNOE(MemberInfo NIKGGMJCPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x24E2A30", Offset = "0x24E1830", VA = "0x1824E2A30")]
	public T OJLKOGAGJJO<T>(bool GDFHMOGBGHI) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x63C54C0", Offset = "0x63C42C0", VA = "0x1863C54C0", Slot = "4")]
	public virtual void LDDDBLKHCEN(ILGenerator LCMJKNCPEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x63C51C0", Offset = "0x63C3FC0", VA = "0x1863C51C0", Slot = "5")]
	public virtual void AIIPKHOELDP(ILGenerator LCMJKNCPEII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class PJBIDFCHLDB : NHHOBMACAON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string LCCEGLNMGOD;

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x63C9CD0", Offset = "0x63C8AD0", VA = "0x1863C9CD0")]
	public PJBIDFCHLDB(string MEBBBIMBIJO, string LCCEGLNMGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x63C9C20", Offset = "0x63C8A20", VA = "0x1863C9C20", Slot = "4")]
	public override void LDDDBLKHCEN(ILGenerator LCMJKNCPEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x63C9BD0", Offset = "0x63C89D0", VA = "0x1863C9BD0", Slot = "5")]
	public override void AIIPKHOELDP(ILGenerator LCMJKNCPEII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class OEGIPDHLNFD : NHHOBMACAON
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo JLDCKABMIPL;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo BEPPCDDGAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal LANENKHNAMM PCOHMIOAJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal LANENKHNAMM KMPMEPFCPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal LANENKHNAMM DKIPKMNFFCP;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x63C8130", Offset = "0x63C6F30", VA = "0x1863C8130")]
	public OEGIPDHLNFD(string MEBBBIMBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x63C79A0", Offset = "0x63C67A0", VA = "0x1863C79A0", Slot = "4")]
	public override void LDDDBLKHCEN(ILGenerator LCMJKNCPEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x63C7950", Offset = "0x63C6750", VA = "0x1863C7950", Slot = "5")]
	public override void AIIPKHOELDP(ILGenerator LCMJKNCPEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x63C7A60", Offset = "0x63C6860", VA = "0x1863C7A60")]
	public void OKICFDBOAPO(ILGenerator LCMJKNCPEII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class GCJHOLKGDGA
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type HHINMKNAKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7619C0", Offset = "0x7607C0", VA = "0x1807619C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool OOACDJEOOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7D58B0", Offset = "0x7D46B0", VA = "0x1807D58B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x764CB0", Offset = "0x763AB0", VA = "0x180764CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool PBKBFFOGNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7F5B80", Offset = "0x7F4980", VA = "0x1807F5B80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7F5580", Offset = "0x7F4380", VA = "0x1807F5580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo OENDCAGKJBN
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x760C70", Offset = "0x75FA70", VA = "0x180760C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public NHHOBMACAON[] EFJDEGEPNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7654C0", Offset = "0x7642C0", VA = "0x1807654C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x766E40", Offset = "0x765C40", VA = "0x180766E40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public NHHOBMACAON[] CFDANHOKACM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x763890", Offset = "0x762690", VA = "0x180763890")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x63B8240", Offset = "0x63B7040", VA = "0x1863B8240")]
	public GCJHOLKGDGA(Type FLHOFPAHPKL, Func<string, string> NCDJMBBPJIP, bool JAPDPMLPPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x63B8160", Offset = "0x63B6F60", VA = "0x1863B8160")]
	private static bool IINOHMEAMBC(IEnumerator<ConstructorInfo> IAOCNMEJONC, ConstructorInfo DHKNENAJBCI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct MCABMLMCHFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong JHLLJPIPCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int KHAMCNNBIHA;

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x1C81570", Offset = "0x1C80370", VA = "0x181C81570")]
	public MCABMLMCHFH(ulong FDIHEMLGBPG, int KCDMOLGDEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x63C0BE0", Offset = "0x63BF9E0", VA = "0x1863C0BE0")]
	public void GIEJDFLIIGH(MCABMLMCHFH LKMMHIOOCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x63C0BD0", Offset = "0x63BF9D0", VA = "0x1863C0BD0")]
	public static MCABMLMCHFH CADJFJFJFBA(MCABMLMCHFH APOJANFJHJO, MCABMLMCHFH DFBIFCHBAHF)
	{
		return default(MCABMLMCHFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x63C0D20", Offset = "0x63BFB20", VA = "0x1863C0D20")]
	public void OHLBADAFINM(MCABMLMCHFH LKMMHIOOCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x63C0BF0", Offset = "0x63BF9F0", VA = "0x1863C0BF0")]
	public static MCABMLMCHFH KCFGADBOOKG(MCABMLMCHFH APOJANFJHJO, MCABMLMCHFH DFBIFCHBAHF)
	{
		return default(MCABMLMCHFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x63C0C90", Offset = "0x63BFA90", VA = "0x1863C0C90")]
	public void OCAINNCFPEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x63C0CD0", Offset = "0x63BFAD0", VA = "0x1863C0CD0")]
	public static MCABMLMCHFH OCAINNCFPEO(MCABMLMCHFH APOJANFJHJO)
	{
		return default(MCABMLMCHFH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal struct FHHJGEFEOFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] BLPPMOBNKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int NNACFOFLCKF;

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x168FF50", Offset = "0x168ED50", VA = "0x18168FF50")]
	public FHHJGEFEOFP(byte[] BLPPMOBNKNN, int CMKBDFOJBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x63AECA0", Offset = "0x63ADAA0", VA = "0x1863AECA0")]
	public void EJJJFLLGMIN(byte MNCMCPLICPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x63B55A0", Offset = "0x63B43A0", VA = "0x1863B55A0")]
	public void BKIJIKNACAB(byte[] MNCMCPLICPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x63B57A0", Offset = "0x63B45A0", VA = "0x1863B57A0")]
	public void HMDDGBCADDC(byte[] MNCMCPLICPL, int JGMNJBPPKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x63B5820", Offset = "0x63B4620", VA = "0x1863B5820")]
	public void HMDDGBCADDC(byte[] MNCMCPLICPL, int IHNKLCGMFDI, int JGMNJBPPKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x63B5720", Offset = "0x63B4520", VA = "0x1863B5720")]
	public void GGAMLBGEBNF(byte BOGFMIDGHHG, int NENAAIFMEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x63B5620", Offset = "0x63B4420", VA = "0x1863B5620")]
	public void DEIEBGIFCNJ(string MNCMCPLICPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal static class MDJOLEHOBNI
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private enum MFNJABBMMEI
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum NJHEDFLENJB
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private enum MNOMEHANIOI
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
	private static byte[] BMLCCDBHGGA;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] FKPFJCOCONN;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] DIGAOJKDOHO;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] KDFEOEJLAAB;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly MNOMEHANIOI CFMOPODKAKM;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char NPGJIMOLODN;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int IJIAJBGNBHM;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int FCOBKHHPLLC;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] CLGBOLDBKPP;

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x63C2AC0", Offset = "0x63C18C0", VA = "0x1863C2AC0")]
	private static byte[] OAKOGGGFADC(int GINFBCJKIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x63C13A0", Offset = "0x63C01A0", VA = "0x1863C13A0")]
	private static byte[] DOBFCLMMFNO(int GINFBCJKIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x63C29A0", Offset = "0x63C17A0", VA = "0x1863C29A0")]
	public static int NPPDOIBJFIL(byte[] BLPPMOBNKNN, int NNACFOFLCKF, float POACLGOFKAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x63C2880", Offset = "0x63C1680", VA = "0x1863C2880")]
	public static int NPPDOIBJFIL(byte[] BLPPMOBNKNN, int NNACFOFLCKF, double POACLGOFKAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x63C1E30", Offset = "0x63C0C30", VA = "0x1863C1E30")]
	private static bool MCAHLNHNAFE(byte[] BLPPMOBNKNN, int JGMNJBPPKGP, ulong FOIAHMBBMDN, ulong BEHLDHFLMOD, ulong EEPIAGCBEIL, ulong HALIPKHNDNA, ulong KKAJBJGDIDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x63C0DB0", Offset = "0x63BFBB0", VA = "0x1863C0DB0")]
	private static void AGNCEBMJPOJ(uint LAIECOKBJPH, int IOMDOFLKHPK, [Out] uint IIEJNPGBGKO, [Out] int MFCOKGJLMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x63C0FB0", Offset = "0x63BFDB0", VA = "0x1863C0FB0")]
	private static bool DKDBHCNMNFK(MCABMLMCHFH INOAHMKDIKN, MCABMLMCHFH NHNDDOIAEPK, MCABMLMCHFH EPNLAPNPMEP, byte[] BLPPMOBNKNN, [Out] int JGMNJBPPKGP, [Out] int MAOPMEONBCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x63C1F20", Offset = "0x63C0D20", VA = "0x1863C1F20")]
	private static bool MCKHMAEMJNH(double ABBNPGBNHJD, MFNJABBMMEI BPBBIDFIPLA, byte[] BLPPMOBNKNN, [Out] int JGMNJBPPKGP, [Out] int CAKAHJGPJFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x63C0EA0", Offset = "0x63BFCA0", VA = "0x1863C0EA0")]
	private static bool BLBKNAGGCDL(double ABBNPGBNHJD, MFNJABBMMEI BPBBIDFIPLA, byte[] BLPPMOBNKNN, [Out] int JGMNJBPPKGP, [Out] int JHOILOHDOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x63C2B90", Offset = "0x63C1990", VA = "0x1863C2B90")]
	private static bool PPMKJCNNEEN(double POACLGOFKAJ, FHHJGEFEOFP FLINFGFCIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x63C23A0", Offset = "0x63C11A0", VA = "0x1863C23A0")]
	private static bool NPBMMNKDHMD(double POACLGOFKAJ, FHHJGEFEOFP FLINFGFCIML, NJHEDFLENJB BPBBIDFIPLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x63C1480", Offset = "0x63C0280", VA = "0x1863C1480")]
	private static void EOIKCHKBJBJ(byte[] JGLPCBPMPBM, int JGMNJBPPKGP, int JHOILOHDOJF, int LFONEPLOJOL, FHHJGEFEOFP FLINFGFCIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x63C1A00", Offset = "0x63C0800", VA = "0x1863C1A00")]
	private static void IEOKAOAJCDO(byte[] JGLPCBPMPBM, int JGMNJBPPKGP, int KCDMOLGDEFI, FHHJGEFEOFP FLINFGFCIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x63C1810", Offset = "0x63C0610", VA = "0x1863C1810")]
	private static bool FJOBAFIPNIK(double ABBNPGBNHJD, NJHEDFLENJB BPBBIDFIPLA, int NJNDIHBOCFG, byte[] HEHABFBDEGK, [Out] bool IIOJIEHDJBD, [Out] int JGMNJBPPKGP, [Out] int HPBLMHBHKBO)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal struct OEKJNBOJELM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double GBNHGJEMKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong OFLFABOKDOC;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct PCLEJEHDJAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float JHLLJPIPCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint GDJOJKFPDNG;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct JOKIFCOFKMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong IDGLBLINCME;

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x63BF3C0", Offset = "0x63BE1C0", VA = "0x1863BF3C0")]
	public JOKIFCOFKMM(double GBNHGJEMKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x63BF320", Offset = "0x63BE120", VA = "0x1863BF320")]
	public JOKIFCOFKMM(MCABMLMCHFH GBNHGJEMKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x63BEEA0", Offset = "0x63BDCA0", VA = "0x1863BEEA0")]
	public MCABMLMCHFH EEMNBGPHEIC()
	{
		return default(MCABMLMCHFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x63BEFD0", Offset = "0x63BDDD0", VA = "0x1863BEFD0")]
	public MCABMLMCHFH MCHEOBJIPOB()
	{
		return default(MCABMLMCHFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xAADA00", Offset = "0xAAC800", VA = "0x180AADA00")]
	public ulong HINNADAMOJO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x63BED90", Offset = "0x63BDB90", VA = "0x1863BED90")]
	public double ACKJDCEHDFH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x63BF0E0", Offset = "0x63BDEE0", VA = "0x1863BF0E0")]
	public double OIOMIKEHMDO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x63BEF10", Offset = "0x63BDD10", VA = "0x1863BEF10")]
	public int EFJMLJPFIFF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x63BEF60", Offset = "0x63BDD60", VA = "0x1863BEF60")]
	public ulong FBEIFCPGKED()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x63BF180", Offset = "0x63BDF80", VA = "0x1863BF180")]
	public bool OKOCKOCFNDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x63BEF90", Offset = "0x63BDD90", VA = "0x1863BEF90")]
	public bool GHGJLHPBLMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x63BEE10", Offset = "0x63BDC10", VA = "0x1863BEE10")]
	public bool ACMHCAIPBAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x63BF2F0", Offset = "0x63BE0F0", VA = "0x1863BF2F0")]
	public bool PIGFIHLKIBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x63BEFB0", Offset = "0x63BDDB0", VA = "0x1863BEFB0")]
	public int JLMJHOKBFLN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x63BF1A0", Offset = "0x63BDFA0", VA = "0x1863BF1A0")]
	public void PHGJOGGJJJP([Out] MCABMLMCHFH ICMMBHGGJAB, [Out] MCABMLMCHFH NKBIIGMHKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x63BEE50", Offset = "0x63BDC50", VA = "0x1863BEE50")]
	public bool DNFBFHEAECM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2976A80", Offset = "0x2975880", VA = "0x182976A80")]
	public double POACLGOFKAJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x63BEF40", Offset = "0x63BDD40", VA = "0x1863BEF40")]
	public static int EODFFEDBAOO(int NDNHDKGPLFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x63BEE40", Offset = "0x63BDC40", VA = "0x1863BEE40")]
	public static double ANCHNHONGBK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x63BF050", Offset = "0x63BDE50", VA = "0x1863BF050")]
	public static ulong NAPPJCHKLLC(MCABMLMCHFH EFMLLOHFDJA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct ANJEGLCFBPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint OGPIJGELMMM;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x1F4F770", Offset = "0x1F4E570", VA = "0x181F4F770")]
	public ANJEGLCFBPN(float JHLLJPIPCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x63B29E0", Offset = "0x63B17E0", VA = "0x1863B29E0")]
	public MCABMLMCHFH EEMNBGPHEIC()
	{
		return default(MCABMLMCHFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7D5330", Offset = "0x7D4130", VA = "0x1807D5330")]
	public uint PHODBKCKCDB()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x63B2A30", Offset = "0x63B1830", VA = "0x1863B2A30")]
	public int EFJMLJPFIFF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x63B2A50", Offset = "0x63B1850", VA = "0x1863B2A50")]
	public uint FBEIFCPGKED()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x63B2A70", Offset = "0x63B1870", VA = "0x1863B2A70")]
	public bool OKOCKOCFNDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x63B2A80", Offset = "0x63B1880", VA = "0x1863B2A80")]
	public void PHGJOGGJJJP([Out] MCABMLMCHFH ICMMBHGGJAB, [Out] MCABMLMCHFH NKBIIGMHKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x63B29A0", Offset = "0x63B17A0", VA = "0x1863B29A0")]
	public bool DNFBFHEAECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct AKGIFLACMAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong FDIHEMLGBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short EBFLCOHGPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short CAKAHJGPJFD;

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x63B2990", Offset = "0x63B1790", VA = "0x1863B2990")]
	public AKGIFLACMAH(ulong FDIHEMLGBPG, short EBFLCOHGPOM, short CAKAHJGPJFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal static class CNNHMBBMNOM
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly AKGIFLACMAH[] MLBCMOKGHOK;

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x63B3260", Offset = "0x63B2060", VA = "0x1863B3260")]
	public static void MDNBILMKEEJ(int PJBEPIKIMCP, int ABMNPIPCAAD, [Out] MCABMLMCHFH IIEJNPGBGKO, [Out] int CAKAHJGPJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x63B3370", Offset = "0x63B2170", VA = "0x1863B3370")]
	public static void NEPOAHNJFBK(int JLOMILDHHIJ, [Out] MCABMLMCHFH IIEJNPGBGKO, [Out] int JOIAELPPCMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[DefaultMember("Item")]
internal struct EFHNNIDHAAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] LKHDKNBOMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int IHNKLCGMFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int BINJCGDFKBI;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte CNLGKPLLPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x63B5200", Offset = "0x63B4000", VA = "0x1863B5200")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x33C23B0", Offset = "0x33C11B0", VA = "0x1833C23B0")]
	public EFHNNIDHAAH(byte[] LKHDKNBOMJD, int IHNKLCGMFDI, int JGMNJBPPKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x1F775B0", Offset = "0x1F763B0", VA = "0x181F775B0")]
	public int JGMNJBPPKGP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x63B5240", Offset = "0x63B4040", VA = "0x1863B5240")]
	public EFHNNIDHAAH KFPLDCNJNLC(int OPCHNAJGPIG, int NCEKPMLHDJO)
	{
		return default(EFHNNIDHAAH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class MJFLCBJGHHO
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] EAAJKHPLNDO;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] HLFKGBCLLJL;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int GMLJDCIENLP;

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x63C4700", Offset = "0x63C3500", VA = "0x1863C4700")]
	private static byte[] OJFOPHEKBHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x63C3F90", Offset = "0x63C2D90", VA = "0x1863C3F90")]
	private static EFHNNIDHAAH IIFJPPNFBPO(EFHNNIDHAAH BLPPMOBNKNN)
	{
		return default(EFHNNIDHAAH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x63C3160", Offset = "0x63C1F60", VA = "0x1863C3160")]
	private static EFHNNIDHAAH CAFHBJCNKLJ(EFHNNIDHAAH BLPPMOBNKNN)
	{
		return default(EFHNNIDHAAH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x63C2FB0", Offset = "0x63C1DB0", VA = "0x1863C2FB0")]
	private static void ABIGBGICCJP(EFHNNIDHAAH BLPPMOBNKNN, int KCDMOLGDEFI, byte[] FPHECCEMNNH, [Out] int PPNEAOOFPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x63C3240", Offset = "0x63C2040", VA = "0x1863C3240")]
	private static void CHFIPAJBMMM(EFHNNIDHAAH BLPPMOBNKNN, int KCDMOLGDEFI, byte[] PJPOKNBDEKD, int GABICKKLNII, [Out] EFHNNIDHAAH BJFOLBILKBJ, [Out] int FLOJAPIPOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x63C47E0", Offset = "0x63C35E0", VA = "0x1863C47E0")]
	private static ulong PDLHHPADCFF(EFHNNIDHAAH BLPPMOBNKNN, [Out] int NDNCNFFGNBG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x63C3530", Offset = "0x63C2330", VA = "0x1863C3530")]
	private static void DGNGMONBDKG(EFHNNIDHAAH BLPPMOBNKNN, [Out] MCABMLMCHFH CGIMAKAECOA, [Out] int CMOGHNLODPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x63C4330", Offset = "0x63C3130", VA = "0x1863C4330")]
	private static bool MKBGHCBANNE(EFHNNIDHAAH BJFOLBILKBJ, int KCDMOLGDEFI, [Out] double CGIMAKAECOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x63C4190", Offset = "0x63C2F90", VA = "0x1863C4190")]
	private static MCABMLMCHFH KGACGPJPAIM(int KCDMOLGDEFI)
	{
		return default(MCABMLMCHFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x63C3670", Offset = "0x63C2470", VA = "0x1863C3670")]
	private static bool ECPANKGPBAJ(EFHNNIDHAAH BLPPMOBNKNN, int KCDMOLGDEFI, [Out] double CGIMAKAECOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x63C3040", Offset = "0x63C1E40", VA = "0x1863C3040")]
	private static bool AIBMFOEEKGP(EFHNNIDHAAH BJFOLBILKBJ, int KCDMOLGDEFI, [Out] double BIBLBIHONHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x63C4070", Offset = "0x63C2E70", VA = "0x1863C4070")]
	public static double? JNLJODIMDPJ(EFHNNIDHAAH BLPPMOBNKNN, int KCDMOLGDEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x63C3CC0", Offset = "0x63C2AC0", VA = "0x1863C3CC0")]
	public static float? FNBOILNMHLP(EFHNNIDHAAH BLPPMOBNKNN, int KCDMOLGDEFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal struct PMILADMBBDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] BLPPMOBNKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int NNACFOFLCKF;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte CAGIMKNDHKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x63DDA20", Offset = "0x63DC820", VA = "0x1863DDA20")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x168FF50", Offset = "0x168ED50", VA = "0x18168FF50")]
	public PMILADMBBDC(byte[] BLPPMOBNKNN, int NNACFOFLCKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x63DD950", Offset = "0x63DC750", VA = "0x1863DD950")]
	public static PMILADMBBDC IGOEMNJMALC(PMILADMBBDC PECKHAMCEFO)
	{
		return default(PMILADMBBDC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x63DD9D0", Offset = "0x63DC7D0", VA = "0x1863DD9D0")]
	public static PMILADMBBDC JBOMEKIAFFI(PMILADMBBDC PECKHAMCEFO, int JGMNJBPPKGP)
	{
		return default(PMILADMBBDC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x63DD940", Offset = "0x63DC740", VA = "0x1863DD940")]
	public static int GNMMJMJKAMO(PMILADMBBDC MNLOCDHFJKE, PMILADMBBDC CHEKOKJNNFE)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x63DDAE0", Offset = "0x63DC8E0", VA = "0x1863DDAE0")]
	public static bool PNFEPLLEJJK(PMILADMBBDC MNLOCDHFJKE, PMILADMBBDC CHEKOKJNNFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x63DD990", Offset = "0x63DC790", VA = "0x1863DD990")]
	public static bool IJDMLBHKDLI(PMILADMBBDC MNLOCDHFJKE, PMILADMBBDC CHEKOKJNNFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x63DDAF0", Offset = "0x63DC8F0", VA = "0x1863DDAF0")]
	public static bool PNFEPLLEJJK(PMILADMBBDC MNLOCDHFJKE, char CHEKOKJNNFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x63DD960", Offset = "0x63DC760", VA = "0x1863DD960")]
	public static bool IJDMLBHKDLI(PMILADMBBDC MNLOCDHFJKE, char CHEKOKJNNFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x63DD960", Offset = "0x63DC760", VA = "0x1863DD960")]
	public static bool IJDMLBHKDLI(PMILADMBBDC MNLOCDHFJKE, byte CHEKOKJNNFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x63DDA80", Offset = "0x63DC880", VA = "0x1863DDA80")]
	public static bool LPCEEALGKJN(PMILADMBBDC MNLOCDHFJKE, char CHEKOKJNNFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x63DD9A0", Offset = "0x63DC7A0", VA = "0x1863DD9A0")]
	public static bool IKDKMIIMCHG(PMILADMBBDC MNLOCDHFJKE, char CHEKOKJNNFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x63DDA50", Offset = "0x63DC850", VA = "0x1863DDA50")]
	public static bool LHPDIKLJGAB(PMILADMBBDC MNLOCDHFJKE, char CHEKOKJNNFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x63DDAB0", Offset = "0x63DC8B0", VA = "0x1863DDAB0")]
	public static bool NPMIJCIMEJA(PMILADMBBDC MNLOCDHFJKE, char CHEKOKJNNFE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal static class PFEPNKBHJCI
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] EPDLPOCCNDK;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] LIEODBNCLAH;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] DIGAOJKDOHO;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] KDFEOEJLAAB;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] NPIILDHILID;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int AKDBKELMGKA;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] ILIPKCBBEMF;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int DBEOJFPEILK;

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x63DBC00", Offset = "0x63DAA00", VA = "0x1863DBC00")]
	private static byte[] DHPCOENMKHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x63DCDC0", Offset = "0x63DBBC0", VA = "0x1863DCDC0")]
	private static byte[] NHLLPHPJFCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x63DCFE0", Offset = "0x63DBDE0", VA = "0x1863DCFE0")]
	public static double PEOEGHFKNOD(byte[] BLPPMOBNKNN, int NNACFOFLCKF, [Out] int GCLHHAGNNLA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x63DBA80", Offset = "0x63DA880", VA = "0x1863DBA80")]
	public static float BGKDIHACPJF(byte[] BLPPMOBNKNN, int NNACFOFLCKF, [Out] int GCLHHAGNNLA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x63DCEA0", Offset = "0x63DBCA0", VA = "0x1863DCEA0")]
	private static bool OPAECMIENKK(int NPDPLEIHBMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x63DCB80", Offset = "0x63DB980", VA = "0x1863DCB80")]
	private static bool JFNNPFKLKBC(PMILADMBBDC IKBIAFEOEKJ, PMILADMBBDC MBGJPMIDMIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x63DBB30", Offset = "0x63DA930", VA = "0x1863DBB30")]
	private static bool CDCCNLLHKFL(PMILADMBBDC IKBIAFEOEKJ, PMILADMBBDC MBGJPMIDMIA, byte[] EGJDFABODPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x63DCD70", Offset = "0x63DBB70", VA = "0x1863DCD70")]
	private static bool LKGBGFNOGFB(PMILADMBBDC DHIPOGOGEHM, byte[] MNCMCPLICPL, int NNACFOFLCKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x63DBCE0", Offset = "0x63DAAE0", VA = "0x1863DBCE0")]
	private static double FHLBMPLJGPF(bool IIOJIEHDJBD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x63DBD00", Offset = "0x63DAB00", VA = "0x1863DBD00")]
	private static double HDAHIONEFLC(PMILADMBBDC KHNEEJJPNNH, int JGMNJBPPKGP, bool KKLACBAKPLJ, [Out] int JDFGKAIJCMK)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class EFCCHKKAKNA<T> : GPNCMEICHNB<T[]>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly HCBAMPOPHHF<T> DFLHALNKMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly HFHHFBGNHEH JIPHJBJAMFI;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3024540", Offset = "0x3023340", VA = "0x183024540")]
	public EFCCHKKAKNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
	public EFCCHKKAKNA(HFHHFBGNHEH JIPHJBJAMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x30222C0", Offset = "0x30210C0", VA = "0x1830222C0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, T[] POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x30230F0", Offset = "0x3021EF0", VA = "0x1830230F0", Slot = "5")]
	public T[] NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class FNPPNCGCPGM<T> : GPNCMEICHNB<ArraySegment<T>>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly HCBAMPOPHHF<T> DFLHALNKMGI;

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x33D3BA0", Offset = "0x33D29A0", VA = "0x1833D3BA0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, ArraySegment<T> POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x33D3EC0", Offset = "0x33D2CC0", VA = "0x1833D3EC0", Slot = "5")]
	public ArraySegment<T> NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class IBAFOGLNKDO<T> : GPNCMEICHNB<List<T>>, MFIMACLDDLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly HFHHFBGNHEH JIPHJBJAMFI;

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3024540", Offset = "0x3023340", VA = "0x183024540")]
	public IBAFOGLNKDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
	public IBAFOGLNKDO(HFHHFBGNHEH JIPHJBJAMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x36688F0", Offset = "0x36676F0", VA = "0x1836688F0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, List<T> POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x36694B0", Offset = "0x36682B0", VA = "0x1836694B0", Slot = "5")]
	public List<T> NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class MKLNMOBINAF<TElement, TIntermediate, TEnumerator, TCollection> : GPNCMEICHNB<TCollection>, MFIMACLDDLI where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3B70C40", Offset = "0x3B6FA40", VA = "0x183B70C40", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, TCollection POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3B71AA0", Offset = "0x3B708A0", VA = "0x183B71AA0", Slot = "5")]
	public TCollection NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator JCJGEIFOIAD(TCollection PGGBKFCMLMO);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate FLMMCOJOBIA();

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void EJEJBLJEAIN(TIntermediate KEALJPCKHHL, int OCMJNDDMDAL, TElement POACLGOFKAJ);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection MLCJINNMNAJ(TIntermediate APHKJAAFJME);

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	protected MKLNMOBINAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class LMNOJIPJEEA<TElement, TIntermediate, TCollection> : MKLNMOBINAF<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x3855240", Offset = "0x3854040", VA = "0x183855240", Slot = "6")]
	protected override IEnumerator<TElement> JCJGEIFOIAD(TCollection PGGBKFCMLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2FF0890", Offset = "0x2FEF690", VA = "0x182FF0890")]
	protected LMNOJIPJEEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public abstract class JLBFFKABCGH<TElement, TCollection> : LMNOJIPJEEA<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0xC91D60", Offset = "0xC90B60", VA = "0x180C91D60", Slot = "9")]
	protected sealed override TCollection MLCJINNMNAJ(TCollection APHKJAAFJME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class EIMNBPCFJFE<TElement, TCollection> : JLBFFKABCGH<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3034A60", Offset = "0x3033860", VA = "0x183034A60", Slot = "7")]
	protected override TCollection FLMMCOJOBIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3034A00", Offset = "0x3033800", VA = "0x183034A00", Slot = "8")]
	protected override void EJEJBLJEAIN(TCollection KEALJPCKHHL, int OCMJNDDMDAL, TElement POACLGOFKAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class ECOHPLJJOAM<T> : MKLNMOBINAF<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x300A990", Offset = "0x3009790", VA = "0x18300A990", Slot = "8")]
	protected override void EJEJBLJEAIN(LinkedList<T> KEALJPCKHHL, int OCMJNDDMDAL, T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0xC91D60", Offset = "0xC90B60", VA = "0x180C91D60", Slot = "9")]
	protected override LinkedList<T> MLCJINNMNAJ(LinkedList<T> APHKJAAFJME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x300A9D0", Offset = "0x30097D0", VA = "0x18300A9D0", Slot = "7")]
	protected override LinkedList<T> FLMMCOJOBIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x300AA40", Offset = "0x3009840", VA = "0x18300AA40", Slot = "6")]
	protected override LinkedList<T>.Enumerator JCJGEIFOIAD(LinkedList<T> PGGBKFCMLMO)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class IADHCEDCHEM<T> : MKLNMOBINAF<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x300A990", Offset = "0x3009790", VA = "0x18300A990", Slot = "8")]
	protected override void EJEJBLJEAIN(Queue<T> KEALJPCKHHL, int OCMJNDDMDAL, T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x300A9D0", Offset = "0x30097D0", VA = "0x18300A9D0", Slot = "7")]
	protected override Queue<T> FLMMCOJOBIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x33A4380", Offset = "0x33A3180", VA = "0x1833A4380", Slot = "6")]
	protected override Queue<T>.Enumerator JCJGEIFOIAD(Queue<T> PGGBKFCMLMO)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0xC91D60", Offset = "0xC90B60", VA = "0x180C91D60", Slot = "9")]
	protected override Queue<T> MLCJINNMNAJ(Queue<T> APHKJAAFJME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class KPLFLCCCIFL<T> : MKLNMOBINAF<T, JJMLCBMAIBL<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x34AAEF0", Offset = "0x34A9CF0", VA = "0x1834AAEF0", Slot = "8")]
	protected override void EJEJBLJEAIN(JJMLCBMAIBL<T> KEALJPCKHHL, int OCMJNDDMDAL, T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3896250", Offset = "0x3895050", VA = "0x183896250", Slot = "7")]
	protected override JJMLCBMAIBL<T> FLMMCOJOBIA()
	{
		return default(JJMLCBMAIBL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x38D2A50", Offset = "0x38D1850", VA = "0x1838D2A50", Slot = "6")]
	protected override Stack<T>.Enumerator JCJGEIFOIAD(Stack<T> PGGBKFCMLMO)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x38D2AB0", Offset = "0x38D18B0", VA = "0x1838D2AB0", Slot = "9")]
	protected override Stack<T> MLCJINNMNAJ(JJMLCBMAIBL<T> APHKJAAFJME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class FFGLMLCHPHJ<T> : MKLNMOBINAF<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x300A990", Offset = "0x3009790", VA = "0x18300A990", Slot = "8")]
	protected override void EJEJBLJEAIN(HashSet<T> KEALJPCKHHL, int OCMJNDDMDAL, T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0xC91D60", Offset = "0xC90B60", VA = "0x180C91D60", Slot = "9")]
	protected override HashSet<T> MLCJINNMNAJ(HashSet<T> APHKJAAFJME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x300A9D0", Offset = "0x30097D0", VA = "0x18300A9D0", Slot = "7")]
	protected override HashSet<T> FLMMCOJOBIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x33A4380", Offset = "0x33A3180", VA = "0x1833A4380", Slot = "6")]
	protected override HashSet<T>.Enumerator JCJGEIFOIAD(HashSet<T> PGGBKFCMLMO)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class AIDDPMIMOIJ<T> : LMNOJIPJEEA<T, JJMLCBMAIBL<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x34AAEF0", Offset = "0x34A9CF0", VA = "0x1834AAEF0", Slot = "8")]
	protected override void EJEJBLJEAIN(JJMLCBMAIBL<T> KEALJPCKHHL, int OCMJNDDMDAL, T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x34AAF60", Offset = "0x34A9D60", VA = "0x1834AAF60", Slot = "9")]
	protected override ReadOnlyCollection<T> MLCJINNMNAJ(JJMLCBMAIBL<T> APHKJAAFJME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x34AAF20", Offset = "0x34A9D20", VA = "0x1834AAF20", Slot = "7")]
	protected override JJMLCBMAIBL<T> FLMMCOJOBIA()
	{
		return default(JJMLCBMAIBL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class LGCJIEFAFCG<T> : LMNOJIPJEEA<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x300A990", Offset = "0x3009790", VA = "0x18300A990", Slot = "8")]
	protected override void EJEJBLJEAIN(List<T> KEALJPCKHHL, int OCMJNDDMDAL, T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x300A9D0", Offset = "0x30097D0", VA = "0x18300A9D0", Slot = "7")]
	protected override List<T> FLMMCOJOBIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0xC91D60", Offset = "0xC90B60", VA = "0x180C91D60", Slot = "9")]
	protected override IList<T> MLCJINNMNAJ(List<T> APHKJAAFJME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class CEPBHJHJPEL<T> : LMNOJIPJEEA<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x300A990", Offset = "0x3009790", VA = "0x18300A990", Slot = "8")]
	protected override void EJEJBLJEAIN(List<T> KEALJPCKHHL, int OCMJNDDMDAL, T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x300A9D0", Offset = "0x30097D0", VA = "0x18300A9D0", Slot = "7")]
	protected override List<T> FLMMCOJOBIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0xC91D60", Offset = "0xC90B60", VA = "0x180C91D60", Slot = "9")]
	protected override ICollection<T> MLCJINNMNAJ(List<T> APHKJAAFJME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class KCOKPHJCPHA<T> : LMNOJIPJEEA<T, JJMLCBMAIBL<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x34AAEF0", Offset = "0x34A9CF0", VA = "0x1834AAEF0", Slot = "8")]
	protected override void EJEJBLJEAIN(JJMLCBMAIBL<T> KEALJPCKHHL, int OCMJNDDMDAL, T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x3896250", Offset = "0x3895050", VA = "0x183896250", Slot = "7")]
	protected override JJMLCBMAIBL<T> FLMMCOJOBIA()
	{
		return default(JJMLCBMAIBL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x3896290", Offset = "0x3895090", VA = "0x183896290", Slot = "9")]
	protected override IEnumerable<T> MLCJINNMNAJ(JJMLCBMAIBL<T> APHKJAAFJME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2FFCB10", Offset = "0x2FFB910", VA = "0x182FFCB10")]
	public KCOKPHJCPHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class MLBMHPIFLEH<TKey, TElement> : GPNCMEICHNB<IGrouping<TKey, TElement>>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x3B727F0", Offset = "0x3B715F0", VA = "0x183B727F0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, IGrouping<TKey, TElement> POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3B72A70", Offset = "0x3B71870", VA = "0x183B72A70", Slot = "5")]
	public IGrouping<TKey, TElement> NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class PFGFKMFFNKK<TKey, TElement> : GPNCMEICHNB<ILookup<TKey, TElement>>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3D97470", Offset = "0x3D96270", VA = "0x183D97470", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, ILookup<TKey, TElement> POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3D97610", Offset = "0x3D96410", VA = "0x183D97610", Slot = "5")]
	public ILookup<TKey, TElement> NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class IINDMHDHICM<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly TKey GMOPMNAPKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly IEnumerable<TElement> KJFBOMAGMGG;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey OBPJFFDCAMB
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x7604C0", Offset = "0x75F2C0", VA = "0x1807604C0")]
	public IINDMHDHICM(TKey GMOPMNAPKBE, IEnumerable<TElement> KJFBOMAGMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x369C780", Offset = "0x369B580", VA = "0x18369C780", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x30956E0", Offset = "0x30944E0", VA = "0x1830956E0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[DefaultMember("Item")]
internal class BPOAAFEAILD<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> AKENHKNDDEJ;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> CNLGKPLLPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x33BCE50", Offset = "0x33BBC50", VA = "0x1833BCE50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	public BPOAAFEAILD(Dictionary<TKey, IGrouping<TKey, TElement>> AKENHKNDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x34BBD90", Offset = "0x34BAB90", VA = "0x1834BBD90", Slot = "5")]
	public bool Contains(TKey GMOPMNAPKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x44A96D0", Offset = "0x44A84D0", VA = "0x1844A96D0", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x44A96D0", Offset = "0x44A84D0", VA = "0x1844A96D0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class OLCCKEIFFAI<T> : GPNCMEICHNB<T>, MFIMACLDDLI where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x3CDB690", Offset = "0x3CDA490", VA = "0x183CDB690", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, T POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x3CDB9C0", Offset = "0x3CDA7C0", VA = "0x183CDB9C0", Slot = "5")]
	public T NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public OLCCKEIFFAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class IHMALLAJNOL : GPNCMEICHNB<IEnumerable>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly GPNCMEICHNB<IEnumerable> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x63D49D0", Offset = "0x63D37D0", VA = "0x1863D49D0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, IEnumerable POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x63D4C80", Offset = "0x63D3A80", VA = "0x1863D4C80", Slot = "5")]
	public IEnumerable NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public IHMALLAJNOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class ILFCEACHIOK : GPNCMEICHNB<ICollection>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly GPNCMEICHNB<ICollection> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x63D5340", Offset = "0x63D4140", VA = "0x1863D5340", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, ICollection POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x63D56E0", Offset = "0x63D44E0", VA = "0x1863D56E0", Slot = "5")]
	public ICollection NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public ILFCEACHIOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class PMDJBDFDLAK : GPNCMEICHNB<IList>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly GPNCMEICHNB<IList> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x63DD340", Offset = "0x63DC140", VA = "0x1863DD340", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, IList POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x63DD670", Offset = "0x63DC470", VA = "0x1863DD670", Slot = "5")]
	public IList NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public PMDJBDFDLAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class OJIIKDJAEME<T> : LMNOJIPJEEA<T, JJMLCBMAIBL<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x3CDA420", Offset = "0x3CD9220", VA = "0x183CDA420", Slot = "8")]
	protected override void EJEJBLJEAIN(JJMLCBMAIBL<T> KEALJPCKHHL, int OCMJNDDMDAL, T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3896250", Offset = "0x3895050", VA = "0x183896250", Slot = "7")]
	protected override JJMLCBMAIBL<T> FLMMCOJOBIA()
	{
		return default(JJMLCBMAIBL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3CDA480", Offset = "0x3CD9280", VA = "0x183CDA480", Slot = "9")]
	protected override IReadOnlyList<T> MLCJINNMNAJ(JJMLCBMAIBL<T> APHKJAAFJME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x2FFC4B0", Offset = "0x2FFB2B0", VA = "0x182FFC4B0")]
	public OJIIKDJAEME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class HJKGBDHAJAM
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x63D39C0", Offset = "0x63D27C0", VA = "0x1863D39C0")]
	public static DateTime KBIJKIHIIIF(DateTime KHGBCOFNFEB)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class GKCCBFFAHMD : GPNCMEICHNB<DateTime>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public static readonly GPNCMEICHNB<DateTime> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x63D18B0", Offset = "0x63D06B0", VA = "0x1863D18B0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, DateTime POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x63D2060", Offset = "0x63D0E60", VA = "0x1863D2060", Slot = "5")]
	public DateTime NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public GKCCBFFAHMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class OKBMDJDFBIB : GPNCMEICHNB<DateTimeOffset>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly GPNCMEICHNB<DateTimeOffset> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x63DA740", Offset = "0x63D9540", VA = "0x1863DA740", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, DateTimeOffset POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x63DADE0", Offset = "0x63D9BE0", VA = "0x1863DADE0", Slot = "5")]
	public DateTimeOffset NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public OKBMDJDFBIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class OJLNFEEKPBJ : GPNCMEICHNB<TimeSpan>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public static readonly GPNCMEICHNB<TimeSpan> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private static byte[] GINGHLONOED;

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x63D98F0", Offset = "0x63D86F0", VA = "0x1863D98F0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, TimeSpan POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x63D9CD0", Offset = "0x63D8AD0", VA = "0x1863D9CD0", Slot = "5")]
	public TimeSpan NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public OJLNFEEKPBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public abstract class BCDCNLHCBJJ<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : GPNCMEICHNB<TDictionary>, MFIMACLDDLI where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x442DC90", Offset = "0x442CA90", VA = "0x18442DC90", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, TDictionary POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x442FE20", Offset = "0x442EC20", VA = "0x18442FE20", Slot = "5")]
	public TDictionary NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator JCJGEIFOIAD(TDictionary PGGBKFCMLMO);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate FLMMCOJOBIA();

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void EJEJBLJEAIN(TIntermediate KEALJPCKHHL, int OCMJNDDMDAL, TKey GMOPMNAPKBE, TValue POACLGOFKAJ);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary MLCJINNMNAJ(TIntermediate APHKJAAFJME);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	protected BCDCNLHCBJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class JIJOJFOPJGL<TKey, TValue, TIntermediate, TDictionary> : BCDCNLHCBJJ<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x3855240", Offset = "0x3854040", VA = "0x183855240", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> JCJGEIFOIAD(TDictionary PGGBKFCMLMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class PDGDBMCPBJB<TKey, TValue, TDictionary> : JIJOJFOPJGL<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0xC91D60", Offset = "0xC90B60", VA = "0x180C91D60", Slot = "9")]
	protected override TDictionary MLCJINNMNAJ(TDictionary APHKJAAFJME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class JJEPHAPDLBN<TKey, TValue> : BCDCNLHCBJJ<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x38554D0", Offset = "0x38542D0", VA = "0x1838554D0", Slot = "8")]
	protected override void EJEJBLJEAIN(Dictionary<TKey, TValue> KEALJPCKHHL, int OCMJNDDMDAL, TKey GMOPMNAPKBE, TValue POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0xC91D60", Offset = "0xC90B60", VA = "0x180C91D60", Slot = "9")]
	protected override Dictionary<TKey, TValue> MLCJINNMNAJ(Dictionary<TKey, TValue> APHKJAAFJME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x300A9D0", Offset = "0x30097D0", VA = "0x18300A9D0", Slot = "7")]
	protected override Dictionary<TKey, TValue> FLMMCOJOBIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x3855600", Offset = "0x3854400", VA = "0x183855600", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator JCJGEIFOIAD(Dictionary<TKey, TValue> PGGBKFCMLMO)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2FEFB80", Offset = "0x2FEE980", VA = "0x182FEFB80")]
	public JJEPHAPDLBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class NPOEGGFPJHN<TKey, TValue, TDictionary> : PDGDBMCPBJB<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x3C13C00", Offset = "0x3C12A00", VA = "0x183C13C00", Slot = "8")]
	protected override void EJEJBLJEAIN(TDictionary KEALJPCKHHL, int OCMJNDDMDAL, TKey GMOPMNAPKBE, TValue POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2EBE140", Offset = "0x2EBCF40", VA = "0x182EBE140", Slot = "7")]
	protected override TDictionary FLMMCOJOBIA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class PINNCOFBECB<TKey, TValue> : JIJOJFOPJGL<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x302D770", Offset = "0x302C570", VA = "0x18302D770", Slot = "8")]
	protected override void EJEJBLJEAIN(Dictionary<TKey, TValue> KEALJPCKHHL, int OCMJNDDMDAL, TKey GMOPMNAPKBE, TValue POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x300A9D0", Offset = "0x30097D0", VA = "0x18300A9D0", Slot = "7")]
	protected override Dictionary<TKey, TValue> FLMMCOJOBIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0xC91D60", Offset = "0xC90B60", VA = "0x180C91D60", Slot = "9")]
	protected override IDictionary<TKey, TValue> MLCJINNMNAJ(Dictionary<TKey, TValue> APHKJAAFJME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class EHCENGBLKFP<TKey, TValue> : PDGDBMCPBJB<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x302D770", Offset = "0x302C570", VA = "0x18302D770", Slot = "8")]
	protected override void EJEJBLJEAIN(SortedList<TKey, TValue> KEALJPCKHHL, int OCMJNDDMDAL, TKey GMOPMNAPKBE, TValue POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x300A9D0", Offset = "0x30097D0", VA = "0x18300A9D0", Slot = "7")]
	protected override SortedList<TKey, TValue> FLMMCOJOBIA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class MLELONDJGNH<TKey, TValue> : BCDCNLHCBJJ<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x302D770", Offset = "0x302C570", VA = "0x18302D770", Slot = "8")]
	protected override void EJEJBLJEAIN(SortedDictionary<TKey, TValue> KEALJPCKHHL, int OCMJNDDMDAL, TKey GMOPMNAPKBE, TValue POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0xC91D60", Offset = "0xC90B60", VA = "0x180C91D60", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> MLCJINNMNAJ(SortedDictionary<TKey, TValue> APHKJAAFJME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x300A9D0", Offset = "0x30097D0", VA = "0x18300A9D0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> FLMMCOJOBIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3855600", Offset = "0x3854400", VA = "0x183855600", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator JCJGEIFOIAD(SortedDictionary<TKey, TValue> PGGBKFCMLMO)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class AACKBJJDMJG<T> : GPNCMEICHNB<T>, MFIMACLDDLI where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x343B2B0", Offset = "0x343A0B0", VA = "0x18343B2B0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, T POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x343B790", Offset = "0x343A590", VA = "0x18343B790", Slot = "5")]
	public T NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public AACKBJJDMJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class IHIDFBPPKGL : GPNCMEICHNB<IDictionary>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public static readonly GPNCMEICHNB<IDictionary> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x63D4240", Offset = "0x63D3040", VA = "0x1863D4240", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, IDictionary POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x63D4720", Offset = "0x63D3520", VA = "0x1863D4720", Slot = "5")]
	public IDictionary NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public IHIDFBPPKGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class FMFKILHFDCG : GPNCMEICHNB<object>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private delegate void HHINOOOBKKF(object NPFIOBGAMOO, NLOIOJJEBDP FNEJOGEIEJN, object POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private readonly NDELOLJPHPH<KeyValuePair<object, HHINOOOBKKF>> GBGFPCMIGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private readonly MCCKOEMPDHO[] ACJABJGKBFF;

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x63D0800", Offset = "0x63CF600", VA = "0x1863D0800")]
	public FMFKILHFDCG(params MCCKOEMPDHO[] ACJABJGKBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x63CFDB0", Offset = "0x63CEBB0", VA = "0x1863CFDB0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, object POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x63D0770", Offset = "0x63CF570", VA = "0x1863D0770", Slot = "5")]
	public object NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class AACBCCOCNDP
{
	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x63CB400", Offset = "0x63CA200", VA = "0x1863CB400")]
	public static object HJMDNJFHMAD(Type FLHOFPAHPKL, [Out] bool CKHCNMLAAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x63CAB10", Offset = "0x63C9910", VA = "0x1863CAB10")]
	public static object BJHGAHHFCAL(Type FLHOFPAHPKL, [Out] bool CKHCNMLAAJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public class HAECEOODFOA<T> : GPNCMEICHNB<T>, MFIMACLDDLI, DINHDFDPHCC<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class ECFMDLEIIAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public ECFMDLEIIAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x3009C50", Offset = "0x3008A50", VA = "0x183009C50")]
		internal bool GAHBPAPIGCD(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class KAGFJPFBEHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public KAGFJPFBEHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x388EFD0", Offset = "0x388DDD0", VA = "0x18388EFD0")]
		internal bool CGACIMAOMPJ(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class GDGKBNPGLFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public LKGODANHIHH<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public GDGKBNPGLFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x3480670", Offset = "0x347F470", VA = "0x183480670")]
		internal void GCCAIMHAIKB(NLOIOJJEBDP writer, T value, MCCKOEMPDHO _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class GDBOFGJLLDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public NFHGGGAFIJL<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public GDBOFGJLLDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x347E730", Offset = "0x347D530", VA = "0x18347E730")]
		internal T DJMINAGLOIG(MABBDDGCPLD reader, MCCKOEMPDHO _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly KGFLFOKEFIM<T> HKPBIFJJEEL;

	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private static readonly Dictionary<T, string> NIHMGHMMGOH;

	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private static readonly LKGODANHIHH<T> GHGMEPEHHCG;

	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private static readonly NFHGGGAFIJL<T> FJMNKOODAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private readonly bool DKJCMOFLLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private readonly LKGODANHIHH<T> MKLIMCHBKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private readonly NFHGGGAFIJL<T> IFNNNIKGPIL;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3584EA0", Offset = "0x3583CA0", VA = "0x183584EA0")]
	static HAECEOODFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x358A9E0", Offset = "0x35897E0", VA = "0x18358A9E0")]
	public HAECEOODFOA(bool DKJCMOFLLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x356D660", Offset = "0x356C460", VA = "0x18356D660", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, T POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x356ECA0", Offset = "0x356DAA0", VA = "0x18356ECA0", Slot = "5")]
	public T NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x3573730", Offset = "0x3572530", VA = "0x183573730", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, T POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x356AF10", Offset = "0x3569D10", VA = "0x18356AF10", Slot = "7")]
	public T FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class FNAEACBHOPB<T> : GPNCMEICHNB<T[,]>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x33C63B0", Offset = "0x33C51B0", VA = "0x1833C63B0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, T[,] POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x33C6620", Offset = "0x33C5420", VA = "0x1833C6620", Slot = "5")]
	public T[,] NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public FNAEACBHOPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class NHLJCMILKHO<T> : GPNCMEICHNB<T[,,]>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x3BE8BE0", Offset = "0x3BE79E0", VA = "0x183BE8BE0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, T[,,] POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x3BE8F00", Offset = "0x3BE7D00", VA = "0x183BE8F00", Slot = "5")]
	public T[,,] NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public NHLJCMILKHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class DKHMKPACMLP<T> : GPNCMEICHNB<T[,,,]>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x4C82960", Offset = "0x4C81760", VA = "0x184C82960", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, T[,,,] POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x4C82D40", Offset = "0x4C81B40", VA = "0x184C82D40", Slot = "5")]
	public T[,,,] NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public DKHMKPACMLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class GKPKGFILBEE<T> : GPNCMEICHNB<T?>, MFIMACLDDLI where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x352F910", Offset = "0x352E710", VA = "0x18352F910", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, T? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x352FA90", Offset = "0x352E890", VA = "0x18352FA90", Slot = "5")]
	public T? NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public GKPKGFILBEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class ACMKKEEBHJM<T> : GPNCMEICHNB<T?>, MFIMACLDDLI where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly GPNCMEICHNB<T> OJBGEOGBFGB;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	public ACMKKEEBHJM(GPNCMEICHNB<T> OJBGEOGBFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x343DA70", Offset = "0x343C870", VA = "0x18343DA70", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, T? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x343E300", Offset = "0x343D100", VA = "0x18343E300", Slot = "5")]
	public T? NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class KPCPBLPPMKL : GPNCMEICHNB<sbyte>, MFIMACLDDLI, DINHDFDPHCC<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly KPCPBLPPMKL IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x63D6AB0", Offset = "0x63D58B0", VA = "0x1863D6AB0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, sbyte POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x63D6B10", Offset = "0x63D5910", VA = "0x1863D6B10", Slot = "5")]
	public sbyte NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x63D6B60", Offset = "0x63D5960", VA = "0x1863D6B60", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, sbyte POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x63D69F0", Offset = "0x63D57F0", VA = "0x1863D69F0", Slot = "7")]
	public sbyte FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public KPCPBLPPMKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class MOKMKAKLCPA : GPNCMEICHNB<sbyte?>, MFIMACLDDLI, DINHDFDPHCC<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly MOKMKAKLCPA IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x63D87C0", Offset = "0x63D75C0", VA = "0x1863D87C0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, sbyte? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x63D8880", Offset = "0x63D7680", VA = "0x1863D8880", Slot = "5")]
	public sbyte? NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x63D8930", Offset = "0x63D7730", VA = "0x1863D8930", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, sbyte? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x63D86A0", Offset = "0x63D74A0", VA = "0x1863D86A0", Slot = "7")]
	public sbyte? FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public MOKMKAKLCPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class LDIIOHKDMNE : GPNCMEICHNB<sbyte[]>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly LDIIOHKDMNE IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x63D6EB0", Offset = "0x63D5CB0", VA = "0x1863D6EB0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, sbyte[] POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x63D6FE0", Offset = "0x63D5DE0", VA = "0x1863D6FE0", Slot = "5")]
	public sbyte[] NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public LDIIOHKDMNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class GAFGDMBJOHC : GPNCMEICHNB<short>, MFIMACLDDLI, DINHDFDPHCC<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly GAFGDMBJOHC IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x63D13D0", Offset = "0x63D01D0", VA = "0x1863D13D0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, short POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x63D1430", Offset = "0x63D0230", VA = "0x1863D1430", Slot = "5")]
	public short NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x63D1480", Offset = "0x63D0280", VA = "0x1863D1480", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, short POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x63D1310", Offset = "0x63D0110", VA = "0x1863D1310", Slot = "7")]
	public short FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public GAFGDMBJOHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class FHNAOLKNNCB : GPNCMEICHNB<short?>, MFIMACLDDLI, DINHDFDPHCC<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly FHNAOLKNNCB IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x63CF730", Offset = "0x63CE530", VA = "0x1863CF730", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, short? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x63CF7F0", Offset = "0x63CE5F0", VA = "0x1863CF7F0", Slot = "5")]
	public short? NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x63CF8A0", Offset = "0x63CE6A0", VA = "0x1863CF8A0", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, short? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x63CF610", Offset = "0x63CE410", VA = "0x1863CF610", Slot = "7")]
	public short? FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public FHNAOLKNNCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class FPFFHJFPAML : GPNCMEICHNB<short[]>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly FPFFHJFPAML IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x63D0CB0", Offset = "0x63CFAB0", VA = "0x1863D0CB0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, short[] POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x63D0DE0", Offset = "0x63CFBE0", VA = "0x1863D0DE0", Slot = "5")]
	public short[] NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public FPFFHJFPAML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class BCHJOMDDIGB : GPNCMEICHNB<int>, MFIMACLDDLI, DINHDFDPHCC<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly BCHJOMDDIGB IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x63CC6E0", Offset = "0x63CB4E0", VA = "0x1863CC6E0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, int POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x63CC740", Offset = "0x63CB540", VA = "0x1863CC740", Slot = "5")]
	public int NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x63CC790", Offset = "0x63CB590", VA = "0x1863CC790", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, int POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x63CC620", Offset = "0x63CB420", VA = "0x1863CC620", Slot = "7")]
	public int FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public BCHJOMDDIGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class NBGMJGDHMAD : GPNCMEICHNB<int?>, MFIMACLDDLI, DINHDFDPHCC<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly NBGMJGDHMAD IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x63D8B90", Offset = "0x63D7990", VA = "0x1863D8B90", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, int? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x63D8C50", Offset = "0x63D7A50", VA = "0x1863D8C50", Slot = "5")]
	public int? NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x63D8D00", Offset = "0x63D7B00", VA = "0x1863D8D00", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, int? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x63D8A70", Offset = "0x63D7870", VA = "0x1863D8A70", Slot = "7")]
	public int? FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public NBGMJGDHMAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class IPJKJLMNPBO : GPNCMEICHNB<int[]>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly IPJKJLMNPBO IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x63D59B0", Offset = "0x63D47B0", VA = "0x1863D59B0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, int[] POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x63D5AE0", Offset = "0x63D48E0", VA = "0x1863D5AE0", Slot = "5")]
	public int[] NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public IPJKJLMNPBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class DOAKGFPANHG : GPNCMEICHNB<long>, MFIMACLDDLI, DINHDFDPHCC<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly DOAKGFPANHG IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x63CEEA0", Offset = "0x63CDCA0", VA = "0x1863CEEA0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, long POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x63CEF00", Offset = "0x63CDD00", VA = "0x1863CEF00", Slot = "5")]
	public long NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x63CEF50", Offset = "0x63CDD50", VA = "0x1863CEF50", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, long POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x63CEDE0", Offset = "0x63CDBE0", VA = "0x1863CEDE0", Slot = "7")]
	public long FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public DOAKGFPANHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class MMHGANFKMCI : GPNCMEICHNB<long?>, MFIMACLDDLI, DINHDFDPHCC<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly MMHGANFKMCI IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x63D83E0", Offset = "0x63D71E0", VA = "0x1863D83E0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, long? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x63D84A0", Offset = "0x63D72A0", VA = "0x1863D84A0", Slot = "5")]
	public long? NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x63D8560", Offset = "0x63D7360", VA = "0x1863D8560", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, long? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x63D82A0", Offset = "0x63D70A0", VA = "0x1863D82A0", Slot = "7")]
	public long? FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public MMHGANFKMCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class GIFPCIJLBFD : GPNCMEICHNB<long[]>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly GIFPCIJLBFD IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x63D1570", Offset = "0x63D0370", VA = "0x1863D1570", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, long[] POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x63D16A0", Offset = "0x63D04A0", VA = "0x1863D16A0", Slot = "5")]
	public long[] NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public GIFPCIJLBFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class KEIEGKBLOAL : GPNCMEICHNB<byte>, MFIMACLDDLI, DINHDFDPHCC<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly KEIEGKBLOAL IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x63D64D0", Offset = "0x63D52D0", VA = "0x1863D64D0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, byte POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x63D6530", Offset = "0x63D5330", VA = "0x1863D6530", Slot = "5")]
	public byte NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x63D6580", Offset = "0x63D5380", VA = "0x1863D6580", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, byte POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x63D6410", Offset = "0x63D5210", VA = "0x1863D6410", Slot = "7")]
	public byte FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public KEIEGKBLOAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class FJNLGKJJBGE : GPNCMEICHNB<byte?>, MFIMACLDDLI, DINHDFDPHCC<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly FJNLGKJJBGE IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x63CFB00", Offset = "0x63CE900", VA = "0x1863CFB00", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, byte? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x63CFBC0", Offset = "0x63CE9C0", VA = "0x1863CFBC0", Slot = "5")]
	public byte? NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x63CFC70", Offset = "0x63CEA70", VA = "0x1863CFC70", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, byte? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x63CF9E0", Offset = "0x63CE7E0", VA = "0x1863CF9E0", Slot = "7")]
	public byte? FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public FJNLGKJJBGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class IDLGHJNDKMK : GPNCMEICHNB<ushort>, MFIMACLDDLI, DINHDFDPHCC<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly IDLGHJNDKMK IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x63D3D50", Offset = "0x63D2B50", VA = "0x1863D3D50", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, ushort POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x63D3DB0", Offset = "0x63D2BB0", VA = "0x1863D3DB0", Slot = "5")]
	public ushort NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x63D3E00", Offset = "0x63D2C00", VA = "0x1863D3E00", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, ushort POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x63D3C90", Offset = "0x63D2A90", VA = "0x1863D3C90", Slot = "7")]
	public ushort FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public IDLGHJNDKMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class MJCOCDINLCD : GPNCMEICHNB<ushort?>, MFIMACLDDLI, DINHDFDPHCC<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly MJCOCDINLCD IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x63D7FF0", Offset = "0x63D6DF0", VA = "0x1863D7FF0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, ushort? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x63D80B0", Offset = "0x63D6EB0", VA = "0x1863D80B0", Slot = "5")]
	public ushort? NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x63D8160", Offset = "0x63D6F60", VA = "0x1863D8160", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, ushort? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x63D7ED0", Offset = "0x63D6CD0", VA = "0x1863D7ED0", Slot = "7")]
	public ushort? FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public MJCOCDINLCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class BBEAMOGELOM : GPNCMEICHNB<ushort[]>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly BBEAMOGELOM IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x63CC2E0", Offset = "0x63CB0E0", VA = "0x1863CC2E0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, ushort[] POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x63CC410", Offset = "0x63CB210", VA = "0x1863CC410", Slot = "5")]
	public ushort[] NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public BBEAMOGELOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class LCNLPBFCMNK : GPNCMEICHNB<uint>, MFIMACLDDLI, DINHDFDPHCC<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly LCNLPBFCMNK IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x63D6D10", Offset = "0x63D5B10", VA = "0x1863D6D10", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, uint POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x63D6D70", Offset = "0x63D5B70", VA = "0x1863D6D70", Slot = "5")]
	public uint NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x63D6DC0", Offset = "0x63D5BC0", VA = "0x1863D6DC0", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, uint POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x63D6C50", Offset = "0x63D5A50", VA = "0x1863D6C50", Slot = "7")]
	public uint FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public LCNLPBFCMNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class HFEPDAHFGBI : GPNCMEICHNB<uint?>, MFIMACLDDLI, DINHDFDPHCC<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly HFEPDAHFGBI IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x63D3280", Offset = "0x63D2080", VA = "0x1863D3280", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, uint? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x63D3340", Offset = "0x63D2140", VA = "0x1863D3340", Slot = "5")]
	public uint? NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x63D33F0", Offset = "0x63D21F0", VA = "0x1863D33F0", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, uint? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x63D3160", Offset = "0x63D1F60", VA = "0x1863D3160", Slot = "7")]
	public uint? FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public HFEPDAHFGBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class CANPIKLIEOI : GPNCMEICHNB<uint[]>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly CANPIKLIEOI IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x63CCC70", Offset = "0x63CBA70", VA = "0x1863CCC70", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, uint[] POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x63CCDA0", Offset = "0x63CBBA0", VA = "0x1863CCDA0", Slot = "5")]
	public uint[] NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public CANPIKLIEOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class LDKDLEKBBNK : GPNCMEICHNB<ulong>, MFIMACLDDLI, DINHDFDPHCC<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly LDKDLEKBBNK IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x63D72B0", Offset = "0x63D60B0", VA = "0x1863D72B0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, ulong POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x63D7310", Offset = "0x63D6110", VA = "0x1863D7310", Slot = "5")]
	public ulong NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x63D7360", Offset = "0x63D6160", VA = "0x1863D7360", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, ulong POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x63D71F0", Offset = "0x63D5FF0", VA = "0x1863D71F0", Slot = "7")]
	public ulong FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public LDKDLEKBBNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class MDIFNCENBKF : GPNCMEICHNB<ulong?>, MFIMACLDDLI, DINHDFDPHCC<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly MDIFNCENBKF IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x63D7C10", Offset = "0x63D6A10", VA = "0x1863D7C10", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, ulong? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x63D7CD0", Offset = "0x63D6AD0", VA = "0x1863D7CD0", Slot = "5")]
	public ulong? NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x63D7D90", Offset = "0x63D6B90", VA = "0x1863D7D90", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, ulong? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x63D7AD0", Offset = "0x63D68D0", VA = "0x1863D7AD0", Slot = "7")]
	public ulong? FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public MDIFNCENBKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class HJEDPPAMLLJ : GPNCMEICHNB<ulong[]>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly HJEDPPAMLLJ IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x63D3680", Offset = "0x63D2480", VA = "0x1863D3680", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, ulong[] POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x63D37B0", Offset = "0x63D25B0", VA = "0x1863D37B0", Slot = "5")]
	public ulong[] NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public HJEDPPAMLLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class NBJAINGIMPD : GPNCMEICHNB<float>, MFIMACLDDLI, DINHDFDPHCC<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly NBJAINGIMPD IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x63D8F00", Offset = "0x63D7D00", VA = "0x1863D8F00", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, float POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x63D8F60", Offset = "0x63D7D60", VA = "0x1863D8F60", Slot = "5")]
	public float NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x63D8FB0", Offset = "0x63D7DB0", VA = "0x1863D8FB0", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, float POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x63D8E40", Offset = "0x63D7C40", VA = "0x1863D8E40", Slot = "7")]
	public float FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public NBJAINGIMPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class JFEIKMOOIJK : GPNCMEICHNB<float?>, MFIMACLDDLI, DINHDFDPHCC<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly JFEIKMOOIJK IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x63D5E10", Offset = "0x63D4C10", VA = "0x1863D5E10", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, float? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x63D5ED0", Offset = "0x63D4CD0", VA = "0x1863D5ED0", Slot = "5")]
	public float? NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x63D5F80", Offset = "0x63D4D80", VA = "0x1863D5F80", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, float? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x63D5CF0", Offset = "0x63D4AF0", VA = "0x1863D5CF0", Slot = "7")]
	public float? FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public JFEIKMOOIJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class JMKNDIEIKEO : GPNCMEICHNB<float[]>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly JMKNDIEIKEO IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x63D60C0", Offset = "0x63D4EC0", VA = "0x1863D60C0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, float[] POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x63D6200", Offset = "0x63D5000", VA = "0x1863D6200", Slot = "5")]
	public float[] NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public JMKNDIEIKEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class NFHPFIBKEIK : GPNCMEICHNB<double>, MFIMACLDDLI, DINHDFDPHCC<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly NFHPFIBKEIK IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x63D9400", Offset = "0x63D8200", VA = "0x1863D9400", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, double POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x63D9460", Offset = "0x63D8260", VA = "0x1863D9460", Slot = "5")]
	public double NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x63D94B0", Offset = "0x63D82B0", VA = "0x1863D94B0", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, double POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x63D9340", Offset = "0x63D8140", VA = "0x1863D9340", Slot = "7")]
	public double FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public NFHPFIBKEIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class FOJNMKPEHDH : GPNCMEICHNB<double?>, MFIMACLDDLI, DINHDFDPHCC<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly FOJNMKPEHDH IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x63D09F0", Offset = "0x63CF7F0", VA = "0x1863D09F0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, double? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x63D0AB0", Offset = "0x63CF8B0", VA = "0x1863D0AB0", Slot = "5")]
	public double? NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x63D0B70", Offset = "0x63CF970", VA = "0x1863D0B70", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, double? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x63D08B0", Offset = "0x63CF6B0", VA = "0x1863D08B0", Slot = "7")]
	public double? FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public FOJNMKPEHDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class NOAOMNFCDCM : GPNCMEICHNB<double[]>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly NOAOMNFCDCM IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x63D95A0", Offset = "0x63D83A0", VA = "0x1863D95A0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, double[] POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x63D96E0", Offset = "0x63D84E0", VA = "0x1863D96E0", Slot = "5")]
	public double[] NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public NOAOMNFCDCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class LLHMKKPHGEE : GPNCMEICHNB<bool>, MFIMACLDDLI, DINHDFDPHCC<bool>
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly LLHMKKPHGEE IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x63D7510", Offset = "0x63D6310", VA = "0x1863D7510", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, bool POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x63D7570", Offset = "0x63D6370", VA = "0x1863D7570", Slot = "5")]
	public bool NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x63D75C0", Offset = "0x63D63C0", VA = "0x1863D75C0", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, bool POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x63D7450", Offset = "0x63D6250", VA = "0x1863D7450", Slot = "7")]
	public bool FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public LLHMKKPHGEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class BBBABDPDGLO : GPNCMEICHNB<bool?>, MFIMACLDDLI, DINHDFDPHCC<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly BBBABDPDGLO IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x63CC030", Offset = "0x63CAE30", VA = "0x1863CC030", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, bool? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x63CC0F0", Offset = "0x63CAEF0", VA = "0x1863CC0F0", Slot = "5")]
	public bool? NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x63CC1A0", Offset = "0x63CAFA0", VA = "0x1863CC1A0", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, bool? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x63CBF10", Offset = "0x63CAD10", VA = "0x1863CBF10", Slot = "7")]
	public bool? FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public BBBABDPDGLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class IGLJBBAHANN : GPNCMEICHNB<bool[]>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly IGLJBBAHANN IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x63D3EF0", Offset = "0x63D2CF0", VA = "0x1863D3EF0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, bool[] POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x63D4030", Offset = "0x63D2E30", VA = "0x1863D4030", Slot = "5")]
	public bool[] NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public IGLJBBAHANN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class DEMKJJBLGCC : GPNCMEICHNB<object>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly GPNCMEICHNB<object> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly Dictionary<Type, int> JGPAKBMPAFG;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x63CD8F0", Offset = "0x63CC6F0", VA = "0x1863CD8F0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, object POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x63CE590", Offset = "0x63CD390", VA = "0x1863CE590", Slot = "5")]
	public object NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public DEMKJJBLGCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class BJKOKJAGPBH : GPNCMEICHNB<byte[]>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly GPNCMEICHNB<byte[]> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x63CCA80", Offset = "0x63CB880", VA = "0x1863CCA80", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, byte[] POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x63CCB40", Offset = "0x63CB940", VA = "0x1863CCB40", Slot = "5")]
	public byte[] NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public BJKOKJAGPBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class CLOEJCAFBCG : GPNCMEICHNB<ArraySegment<byte>>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly GPNCMEICHNB<ArraySegment<byte>> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x63CD630", Offset = "0x63CC430", VA = "0x1863CD630", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, ArraySegment<byte> POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x63CD760", Offset = "0x63CC560", VA = "0x1863CD760", Slot = "5")]
	public ArraySegment<byte> NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public CLOEJCAFBCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class IJMIGKENOHP : GPNCMEICHNB<string>, MFIMACLDDLI, DINHDFDPHCC<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly GPNCMEICHNB<string> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x63D4FA0", Offset = "0x63D3DA0", VA = "0x1863D4FA0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, string POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x63D5000", Offset = "0x63D3E00", VA = "0x1863D5000", Slot = "5")]
	public string NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x63D5050", Offset = "0x63D3E50", VA = "0x1863D5050", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, string POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x63D4F50", Offset = "0x63D3D50", VA = "0x1863D4F50", Slot = "7")]
	public string FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public IJMIGKENOHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class KHGLDIHNBGG : GPNCMEICHNB<string[]>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly KHGLDIHNBGG IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x63D6670", Offset = "0x63D5470", VA = "0x1863D6670", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, string[] POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x63D67A0", Offset = "0x63D55A0", VA = "0x1863D67A0", Slot = "5")]
	public string[] NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public KHGLDIHNBGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class CEAOOLNJJKI : GPNCMEICHNB<char>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly CEAOOLNJJKI IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x63CCFB0", Offset = "0x63CBDB0", VA = "0x1863CCFB0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, char POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x63CD070", Offset = "0x63CBE70", VA = "0x1863CD070", Slot = "5")]
	public char NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public CEAOOLNJJKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class NDEKAFBDIDE : GPNCMEICHNB<char?>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly NDEKAFBDIDE IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x63D90A0", Offset = "0x63D7EA0", VA = "0x1863D90A0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, char? POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x63D91A0", Offset = "0x63D7FA0", VA = "0x1863D91A0", Slot = "5")]
	public char? NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public NDEKAFBDIDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class DODJNDEFJGC : GPNCMEICHNB<char[]>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly DODJNDEFJGC IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x63CF040", Offset = "0x63CDE40", VA = "0x1863CF040", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, char[] POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x63CF1F0", Offset = "0x63CDFF0", VA = "0x1863CF1F0", Slot = "5")]
	public char[] NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public DODJNDEFJGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class LMBPMDEGPOM : GPNCMEICHNB<Guid>, MFIMACLDDLI, DINHDFDPHCC<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly GPNCMEICHNB<Guid> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x63D7750", Offset = "0x63D6550", VA = "0x1863D7750", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, Guid POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x63D7880", Offset = "0x63D6680", VA = "0x1863D7880", Slot = "5")]
	public Guid NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x63D7910", Offset = "0x63D6710", VA = "0x1863D7910", Slot = "6")]
	public void PAHOFCDHAEN(NLOIOJJEBDP FNEJOGEIEJN, Guid POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x63D76B0", Offset = "0x63D64B0", VA = "0x1863D76B0", Slot = "7")]
	public Guid FFGIDBDGDPE(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public LMBPMDEGPOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class CFDFDICBPND : GPNCMEICHNB<decimal>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly GPNCMEICHNB<decimal> IKMLLOOIGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private readonly bool KCIIAMHLNKG;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x4EAE7F0", Offset = "0x4EAD5F0", VA = "0x184EAE7F0")]
	public CFDFDICBPND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x160D2E0", Offset = "0x160C0E0", VA = "0x18160D2E0")]
	public CFDFDICBPND(bool KCIIAMHLNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x63CD160", Offset = "0x63CBF60", VA = "0x1863CD160", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, decimal POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x63CD310", Offset = "0x63CC110", VA = "0x1863CD310", Slot = "5")]
	public decimal NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class ANBPMJAKIMK : GPNCMEICHNB<Uri>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly GPNCMEICHNB<Uri> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x63CBCF0", Offset = "0x63CAAF0", VA = "0x1863CBCF0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, Uri POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x63CBDD0", Offset = "0x63CABD0", VA = "0x1863CBDD0", Slot = "5")]
	public Uri NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public ANBPMJAKIMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class BGHJJOKBGCD : GPNCMEICHNB<Version>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly GPNCMEICHNB<Version> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x63CC880", Offset = "0x63CB680", VA = "0x1863CC880", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, Version POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x63CC940", Offset = "0x63CB740", VA = "0x1863CC940", Slot = "5")]
	public Version NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public BGHJJOKBGCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class BMODOEHBAOL<TKey, TValue> : GPNCMEICHNB<KeyValuePair<TKey, TValue>>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x449D5F0", Offset = "0x449C3F0", VA = "0x18449D5F0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, KeyValuePair<TKey, TValue> POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x449D7E0", Offset = "0x449C5E0", VA = "0x18449D7E0", Slot = "5")]
	public KeyValuePair<TKey, TValue> NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class EADCPKDDIDH : GPNCMEICHNB<StringBuilder>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly GPNCMEICHNB<StringBuilder> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x63CF430", Offset = "0x63CE230", VA = "0x1863CF430", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, StringBuilder POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x63CF4D0", Offset = "0x63CE2D0", VA = "0x1863CF4D0", Slot = "5")]
	public StringBuilder NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public EADCPKDDIDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class FPOPMCIJNID : GPNCMEICHNB<BitArray>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly GPNCMEICHNB<BitArray> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x63D0FF0", Offset = "0x63CFDF0", VA = "0x1863D0FF0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, BitArray POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x63D1110", Offset = "0x63CFF10", VA = "0x1863D1110", Slot = "5")]
	public BitArray NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public FPOPMCIJNID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class GMANIHJNELC : GPNCMEICHNB<Type>, MFIMACLDDLI
{
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly GMANIHJNELC IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static readonly Regex ELALPODJFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private bool AMBNIKPNHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private bool BKDKLKDJBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private bool JPPJKECKMNL;

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x63D3140", Offset = "0x63D1F40", VA = "0x1863D3140")]
	public GMANIHJNELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x5BA8A10", Offset = "0x5BA7810", VA = "0x185BA8A10")]
	public GMANIHJNELC(bool AMBNIKPNHJG, bool BKDKLKDJBFA, bool JPPJKECKMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x63D2DF0", Offset = "0x63D1BF0", VA = "0x1863D2DF0", Slot = "4")]
	public void LJOKGFFEJKK(NLOIOJJEBDP FNEJOGEIEJN, Type POACLGOFKAJ, MCCKOEMPDHO BDHONDKBMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x63D2F00", Offset = "0x63D1D00", VA = "0x1863D2F00", Slot = "5")]
	public Type NLOFGFEMKNI(MABBDDGCPLD GFNJLJABMCF, MCCKOEMPDHO BDHONDKBMBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal static class IKABHICNOHI
{
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal static readonly byte[][] NADDPIGONMP;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal static readonly DDABGEBFIOI PFLMGPAFKLJ;

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x63D5130", Offset = "0x63D3F30", VA = "0x1863D5130")]
	static IKABHICNOHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class IAJDHGKKJPE
{
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal static readonly byte[][] EHNLEIKELJN;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal static readonly DDABGEBFIOI JCPJNDOMEOJ;

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x63D3A80", Offset = "0x63D2880", VA = "0x1863D3A80")]
	static IAJDHGKKJPE()
	{
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
