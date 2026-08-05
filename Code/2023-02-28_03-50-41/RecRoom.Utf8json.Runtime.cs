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
internal static class AGDLDJBGCHC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4D02710", Offset = "0x4D01110", VA = "0x184D02710")]
	public static bool EKGCODHMBPD(this TypeInfo MAHAMGBPDNB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class EEMGMIOKAHC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type DAKJFNIMDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6DFB30", VA = "0x1806E1130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] MOGBMEJMEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6F0", Offset = "0x6DB0F0", VA = "0x1806DC6F0")]
	public EEMGMIOKAHC(Type DDCLMECEMGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor)]
public class CJGNJJABFNC : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void ONPFKBKFLPP<T>(ref KBHFHFFPFEJ LHGJJBFKNCG, T MNIAGKNOHEJ, HEOIHOEGOKA JECLFPNEMPA);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T DDLFGJOMMMC<T>(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JECLFPNEMPA);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DHGBFBDHANB
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MMFDCMJAOJA<T> : DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, T MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IFPGMOGFAMI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, T MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum JDFHGBIEECI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::MMFDCMJAOJA<T> BHKKNAEHNON<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MHCEALDLHFM
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x260E260", Offset = "0x260CC60", VA = "0x18260E260")]
	public static global::MMFDCMJAOJA<T> OPMBHFOEHIE<T>(this HEOIHOEGOKA JECLFPNEMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x53BEFA0", Offset = "0x53BD9A0", VA = "0x1853BEFA0")]
	public static object GLPLJCOHONH(this HEOIHOEGOKA JECLFPNEMPA, Type MAHAMGBPDNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AEPFKJPDOLC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D01B80", Offset = "0x4D00580", VA = "0x184D01B80")]
	public AEPFKJPDOLC(string EJEIJOMMNGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct NIGKCAJBBED
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class DKDIHIOKMMK
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] DFIIPKJNKEL;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] IIDBOMFBJKH;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x52E5E40", Offset = "0x52E4840", VA = "0x1852E5E40")]
		public static byte[] DLLNMKCAGGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x52E5ED0", Offset = "0x52E48D0", VA = "0x1852E5ED0")]
		public static char[] FDHCGOAMKCA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> NPHPIJNLLOL;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] KNEKPJPEAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] FMIGDHLBIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int JFKBHBKKACD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool JBEKDKCNELG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x53C9FC0", Offset = "0x53C89C0", VA = "0x1853C9FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x53CA8A0", Offset = "0x53C92A0", VA = "0x1853CA8A0")]
	public NIGKCAJBBED(byte[] FMIGDHLBIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x53CA8B0", Offset = "0x53C92B0", VA = "0x1853CA8B0")]
	public NIGKCAJBBED(byte[] FMIGDHLBIKP, int JFKBHBKKACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x53C8BB0", Offset = "0x53C75B0", VA = "0x1853C8BB0")]
	private PJBCAMJIFFI IFJKLNMBOIB(string OLFHPKNHJOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x53C84E0", Offset = "0x53C6EE0", VA = "0x1853C84E0")]
	private PJBCAMJIFFI EEDNNANABBP(string EJEIJOMMNGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x53B6A10", Offset = "0x53B5410", VA = "0x1853B6A10")]
	public void OGAFHPCCLLF(int JFKBHBKKACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C1000", Offset = "0x6BFA00", VA = "0x1806C1000")]
	public byte[] ABEFIEKALGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E1EE0", Offset = "0x7E08E0", VA = "0x1807E1EE0")]
	public int CANMJODMANF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x53C87C0", Offset = "0x53C71C0", VA = "0x1853C87C0")]
	public MFBIHEHKJJP EOLPHPDFFEH()
	{
		return default(MFBIHEHKJJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x53C8680", Offset = "0x53C7080", VA = "0x1853C8680")]
	public void EHICBMCMKFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x53C7FB0", Offset = "0x53C69B0", VA = "0x1853C7FB0")]
	public bool CDJDMCOBFGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x53C81B0", Offset = "0x53C6BB0", VA = "0x1853C81B0")]
	public bool COGEONJHEIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x53C7D30", Offset = "0x53C6730", VA = "0x1853C7D30")]
	public void BCGDDGMJBBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x53C9B50", Offset = "0x53C8550", VA = "0x1853C9B50")]
	public bool NDPPJLCCNFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x53C8210", Offset = "0x53C6C10", VA = "0x1853C8210")]
	public bool DCOALJBBBDL(ref int JOBJIONNEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x53C7E90", Offset = "0x53C6890", VA = "0x1853C7E90")]
	public bool BGDCOGIIKDG(ref int JOBJIONNEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x53C9AF0", Offset = "0x53C84F0", VA = "0x1853C9AF0")]
	public bool NDJDGEEJIMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x53C8440", Offset = "0x53C6E40", VA = "0x1853C8440")]
	public void DOHJDJPODIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x53C7F50", Offset = "0x53C6950", VA = "0x1853C7F50")]
	public bool BNAEDLIOCKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x53C9BB0", Offset = "0x53C85B0", VA = "0x1853C9BB0")]
	public bool OAIFADLLMMC(ref int JOBJIONNEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x53C9510", Offset = "0x53C7F10", VA = "0x1853C9510")]
	public bool LJIDIDJLJEH(ref int JOBJIONNEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x53C8940", Offset = "0x53C7340", VA = "0x1853C8940")]
	public bool FEABGNMOMFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x53C89D0", Offset = "0x53C73D0", VA = "0x1853C89D0")]
	public void HEGCGLDKHJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x53C93B0", Offset = "0x53C7DB0", VA = "0x1853C93B0")]
	public bool KODDEGIKFCM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x53C7CA0", Offset = "0x53C66A0", VA = "0x1853C7CA0")]
	public void BBOLMMNFLBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x53C9FE0", Offset = "0x53C89E0", VA = "0x1853C9FE0")]
	private void PNNOFHKGBPD(out byte[] FHKOALIMNJD, out int HNPHDALOBEO, out int KJFFCNMDHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x53C9860", Offset = "0x53C8260", VA = "0x1853C9860")]
	private static int NBCIGJFAEHC(char PKEMCIANHMO, char DLAMIJMLOOE, char LKLPGHLLEIM, char FLLMGCJHMCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x53C8AE0", Offset = "0x53C74E0", VA = "0x1853C8AE0")]
	private static int HPBCAPIALBA(char MEALLDFELFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x53C9760", Offset = "0x53C8160", VA = "0x1853C9760")]
	public ArraySegment<byte> MAMLCKJJMDI()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x53C9470", Offset = "0x53C7E70", VA = "0x1853C9470")]
	public string LFBIMADCPBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x53C89A0", Offset = "0x53C73A0", VA = "0x1853C89A0")]
	public string FGPIJLNDKPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x53C9D00", Offset = "0x53C8700", VA = "0x1853C9D00")]
	public ArraySegment<byte> OHLIAHICCPL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x53C8110", Offset = "0x53C6B10", VA = "0x1853C8110")]
	public ArraySegment<byte> CJLEDFNIOCN()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x53C90C0", Offset = "0x53C7AC0", VA = "0x1853C90C0")]
	public bool IOECAAFFALL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x53C85C0", Offset = "0x53C6FC0", VA = "0x1853C85C0")]
	private static bool EGHMGIMGJNE(byte LKLPGHLLEIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x53C9910", Offset = "0x53C8310", VA = "0x1853C9910")]
	private void NDBACNFNGNO(MFBIHEHKJJP DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x53C84D0", Offset = "0x53C6ED0", VA = "0x1853C84D0")]
	public void ECCNBAAKBBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x53C9C30", Offset = "0x53C8630", VA = "0x1853C9C30")]
	private void OBHHOEHMHMO(int JCPBEMMHIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x53C9300", Offset = "0x53C7D00", VA = "0x1853C9300")]
	public sbyte IOGJLJPMMDC()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x53C8290", Offset = "0x53C6C90", VA = "0x1853C8290")]
	public short DGMBKGLOMFI()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x53C9350", Offset = "0x53C7D50", VA = "0x1853C9350")]
	public int JCEBCKEIGNH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x53C8A60", Offset = "0x53C7460", VA = "0x1853C8A60")]
	public long HJNGEGNHOEN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x53C8150", Offset = "0x53C6B50", VA = "0x1853C8150")]
	public byte CKHLGCAEBBJ()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x53C9410", Offset = "0x53C7E10", VA = "0x1853C9410")]
	public ushort KPJOAFICANE()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x53C80B0", Offset = "0x53C6AB0", VA = "0x1853C80B0")]
	public uint CEHMCCPJBMG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x53C82F0", Offset = "0x53C6CF0", VA = "0x1853C82F0")]
	public ulong DJMEFCKLPPK()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x53C7DC0", Offset = "0x53C67C0", VA = "0x1853C7DC0")]
	public float BDCOMDNFGNF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x53C8370", Offset = "0x53C6D70", VA = "0x1853C8370")]
	public double DNBFCIOFPPF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x53C9ED0", Offset = "0x53C88D0", VA = "0x1853C9ED0")]
	public ArraySegment<byte> OPBIBMDPCCO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x53C95D0", Offset = "0x53C7FD0", VA = "0x1853C95D0")]
	private static int MAGHHOFCFMF(byte[] FMIGDHLBIKP, int JFKBHBKKACD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PJBCAMJIFFI : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference AIAONAEAMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int LPDCKFGCOOD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int NLCNHBLGDIA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1763980", Offset = "0x1762380", VA = "0x181763980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string OJPAAOMLCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8CB4D0", Offset = "0x8C9ED0", VA = "0x1808CB4D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x52F3710", Offset = "0x52F2110", VA = "0x1852F3710")]
	public PJBCAMJIFFI(string EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x52F3630", Offset = "0x52F2030", VA = "0x1852F3630")]
	public PJBCAMJIFFI(string EJEIJOMMNGK, byte[] GMFONIPLHPL, int JFKBHBKKACD, int LPDCKFGCOOD, string DOPEBEACAPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PIBMEBILKML
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class MKJDBMLAHJE
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private delegate void JKDFEJHPDBI(ref KBHFHFFPFEJ LHGJJBFKNCG, object MNIAGKNOHEJ, HEOIHOEGOKA JECLFPNEMPA);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private delegate object PFBHKHKHGJG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JECLFPNEMPA);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private class CKPOEKIGOIM
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			[CompilerGenerated]
			private sealed class MHLNMHAJBIE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
				public MHLNMHAJBIE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x3962F30", Offset = "0x3961930", VA = "0x183962F30")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x52EAA30", Offset = "0x52E9430", VA = "0x1852EAA30")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, HEOIHOEGOKA, byte[]> KOIEPMKGEJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, HEOIHOEGOKA> JGBCMFPBHLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly JKDFEJHPDBI OKABGGBLIKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, HEOIHOEGOKA, ArraySegment<byte>> LKLBJDCLCHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, HEOIHOEGOKA, string> CFBPKJKHGJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, HEOIHOEGOKA, object> GLELBIFOOHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, HEOIHOEGOKA, object> EJAIPCHBLAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, HEOIHOEGOKA, object> ALOPNKDHLME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly PFBHKHKHGJG MEANOAHJAHG;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x52E1FB0", Offset = "0x52E09B0", VA = "0x1852E1FB0")]
			public CKPOEKIGOIM(Type MAHAMGBPDNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x343E460", Offset = "0x343CE60", VA = "0x18343E460")]
			private static T FDDAPLFHAAL<T>(DynamicMethod EKGAEJNPCEB)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x52E1D60", Offset = "0x52E0760", VA = "0x1852E1D60")]
			private static MethodInfo OPONLEIBKGK(Type MAHAMGBPDNB, string ANJJEPIBAGI, Type[] HONMKKBCKFD)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, CKPOEKIGOIM> ILGMJDAKECP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::IDGGJAMGONM<CKPOEKIGOIM> FOJGKCIHGFP;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x52EB130", Offset = "0x52E9B30", VA = "0x1852EB130")]
		static MKJDBMLAHJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x52EADF0", Offset = "0x52E97F0", VA = "0x1852EADF0")]
		private static CKPOEKIGOIM FGPIIJFONFI(Type MAHAMGBPDNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x52EAE80", Offset = "0x52E9880", VA = "0x1852EAE80")]
		public static void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, object MNIAGKNOHEJ, HEOIHOEGOKA JECLFPNEMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x52EB010", Offset = "0x52E9A10", VA = "0x1852EB010")]
		public static void JHPOCMCIPNJ(Type MAHAMGBPDNB, ref KBHFHFFPFEJ LHGJJBFKNCG, object MNIAGKNOHEJ, HEOIHOEGOKA JECLFPNEMPA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class BLPPLIIOPHI
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] DFIIPKJNKEL;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x52E0930", Offset = "0x52DF330", VA = "0x1852E0930")]
		public static byte[] DLLNMKCAGGI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static HEOIHOEGOKA HEINHNEGGHA;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] LDHLGBCIINP;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] JGOBEELJKDH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static HEOIHOEGOKA FCIJJIIOBDF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x52F2EA0", Offset = "0x52F18A0", VA = "0x1852F2EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool HNCHBAEIKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x52F2B40", Offset = "0x52F1540", VA = "0x1852F2B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x52F2870", Offset = "0x52F1270", VA = "0x1852F2870")]
	public static void BAJMPABHCKP(HEOIHOEGOKA JECLFPNEMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x291C690", Offset = "0x291B090", VA = "0x18291C690")]
	public static byte[] JHPOCMCIPNJ<T>(T LAFPICAOEAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x291C7A0", Offset = "0x291B1A0", VA = "0x18291C7A0")]
	public static byte[] JHPOCMCIPNJ<T>(T MNIAGKNOHEJ, HEOIHOEGOKA JECLFPNEMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x291C600", Offset = "0x291B000", VA = "0x18291C600")]
	public static void JHPOCMCIPNJ<T>(ref KBHFHFFPFEJ LHGJJBFKNCG, T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x291CA20", Offset = "0x291B420", VA = "0x18291CA20")]
	public static void JHPOCMCIPNJ<T>(ref KBHFHFFPFEJ LHGJJBFKNCG, T MNIAGKNOHEJ, HEOIHOEGOKA JECLFPNEMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x291C710", Offset = "0x291B110", VA = "0x18291C710")]
	public static void JHPOCMCIPNJ<T>(Stream BODAGHDNFBD, T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x291C900", Offset = "0x291B300", VA = "0x18291C900")]
	public static void JHPOCMCIPNJ<T>(Stream BODAGHDNFBD, T MNIAGKNOHEJ, HEOIHOEGOKA JECLFPNEMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x291CCE0", Offset = "0x291B6E0", VA = "0x18291CCE0")]
	public static ArraySegment<byte> OMFNMKOIPAA<T>(T LAFPICAOEAI)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x291CD80", Offset = "0x291B780", VA = "0x18291CD80")]
	public static ArraySegment<byte> OMFNMKOIPAA<T>(T MNIAGKNOHEJ, HEOIHOEGOKA JECLFPNEMPA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x291CB00", Offset = "0x291B500", VA = "0x18291CB00")]
	public static string MGKHEJNNNLB<T>(T MNIAGKNOHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x291CB80", Offset = "0x291B580", VA = "0x18291CB80")]
	public static string MGKHEJNNNLB<T>(T MNIAGKNOHEJ, HEOIHOEGOKA JECLFPNEMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x291BCA0", Offset = "0x291A6A0", VA = "0x18291BCA0")]
	public static T AJGJBLGJHIK<T>(string DNCBHLOFDLJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x291BD40", Offset = "0x291A740", VA = "0x18291BD40")]
	public static T AJGJBLGJHIK<T>(string DNCBHLOFDLJ, HEOIHOEGOKA JECLFPNEMPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x291C420", Offset = "0x291AE20", VA = "0x18291C420")]
	public static T AJGJBLGJHIK<T>(byte[] FMIGDHLBIKP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x291BE30", Offset = "0x291A830", VA = "0x18291BE30")]
	public static T AJGJBLGJHIK<T>(byte[] FMIGDHLBIKP, HEOIHOEGOKA JECLFPNEMPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x291C1D0", Offset = "0x291ABD0", VA = "0x18291C1D0")]
	public static T AJGJBLGJHIK<T>(byte[] FMIGDHLBIKP, int JFKBHBKKACD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x291BB40", Offset = "0x291A540", VA = "0x18291BB40")]
	public static T AJGJBLGJHIK<T>(byte[] FMIGDHLBIKP, int JFKBHBKKACD, HEOIHOEGOKA JECLFPNEMPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x291BED0", Offset = "0x291A8D0", VA = "0x18291BED0")]
	public static T AJGJBLGJHIK<T>(ref NIGKCAJBBED ALGAFFHCPAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x291BF50", Offset = "0x291A950", VA = "0x18291BF50")]
	public static T AJGJBLGJHIK<T>(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JECLFPNEMPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x291C580", Offset = "0x291AF80", VA = "0x18291C580")]
	public static T AJGJBLGJHIK<T>(Stream BODAGHDNFBD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x291C0A0", Offset = "0x291AAA0", VA = "0x18291C0A0")]
	public static T AJGJBLGJHIK<T>(Stream BODAGHDNFBD, HEOIHOEGOKA JECLFPNEMPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x52F2C50", Offset = "0x52F1650", VA = "0x1852F2C50")]
	public static string JFMAAFBAHPC(byte[] DNCBHLOFDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x52F2BA0", Offset = "0x52F15A0", VA = "0x1852F2BA0")]
	public static string JFMAAFBAHPC(byte[] DNCBHLOFDLJ, int JFKBHBKKACD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x52F2D30", Offset = "0x52F1730", VA = "0x1852F2D30")]
	public static string JFMAAFBAHPC(string DNCBHLOFDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x52F2A60", Offset = "0x52F1460", VA = "0x1852F2A60")]
	public static byte[] BJCEJPLONBG(byte[] DNCBHLOFDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x52F29B0", Offset = "0x52F13B0", VA = "0x1852F29B0")]
	public static byte[] BJCEJPLONBG(byte[] DNCBHLOFDLJ, int JFKBHBKKACD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x52F28E0", Offset = "0x52F12E0", VA = "0x1852F28E0")]
	public static byte[] BJCEJPLONBG(string DNCBHLOFDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x52F2FC0", Offset = "0x52F19C0", VA = "0x1852F2FC0")]
	private static void NIBANBLCKBI(ref NIGKCAJBBED ALGAFFHCPAP, ref KBHFHFFPFEJ LHGJJBFKNCG, int GLPDCHNEBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x52F2E00", Offset = "0x52F1800", VA = "0x1852F2E00")]
	private static int KEJFDOPEAGC(Stream CAADCBIMIIP, ref byte[] DFIIPKJNKEL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum MFBIHEHKJJP : byte
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
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KBHFHFFPFEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] BHFIOPAMEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] DFIIPKJNKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int JFKBHBKKACD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DKCKENHPCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7E1EE0", Offset = "0x7E08E0", VA = "0x1807E1EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x53B6A10", Offset = "0x53B5410", VA = "0x1853B6A10")]
	public void OGAFHPCCLLF(int JFKBHBKKACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x53B5E40", Offset = "0x53B4840", VA = "0x1853B5E40")]
	public static byte[] IBDHIGJMDBL(string IJEJFFCLBDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x53B5AE0", Offset = "0x53B44E0", VA = "0x1853B5AE0")]
	public static byte[] DMKOFKELIPI(string IJEJFFCLBDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x53B65E0", Offset = "0x53B4FE0", VA = "0x1853B65E0")]
	public static byte[] LLMHKDKLODO(string IJEJFFCLBDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x53B5CF0", Offset = "0x53B46F0", VA = "0x1853B5CF0")]
	public static byte[] HLFNFILCMNI(string IJEJFFCLBDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xC0CFC0", Offset = "0xC0B9C0", VA = "0x180C0CFC0")]
	public KBHFHFFPFEJ(byte[] LGPKLKFCEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x53B5A30", Offset = "0x53B4430", VA = "0x1853B5A30")]
	public ArraySegment<byte> DLLNMKCAGGI()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x53B5C20", Offset = "0x53B4620", VA = "0x1853B5C20")]
	public byte[] FKIHLJABHKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x53B6B20", Offset = "0x53B5520", VA = "0x1853B6B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x53B64B0", Offset = "0x53B4EB0", VA = "0x1853B64B0")]
	public void KMGAMBDOMKB(int ELHOOJHBHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4D04910", Offset = "0x4D03310", VA = "0x184D04910")]
	public void COFJBHNFCHL(byte DFBNOFJNJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x53B59D0", Offset = "0x53B43D0", VA = "0x1853B59D0")]
	public void COFJBHNFCHL(byte[] DFBNOFJNJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x53B6320", Offset = "0x53B4D20", VA = "0x1853B6320")]
	public void IJDJGIEGOCF(byte DFBNOFJNJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x53B5CA0", Offset = "0x53B46A0", VA = "0x1853B5CA0")]
	public void GDCBDLFDLCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x53B6720", Offset = "0x53B5120", VA = "0x1853B6720")]
	public void NFHAFFLGNEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x53B6430", Offset = "0x53B4E30", VA = "0x1853B6430")]
	public void JKBDNGHMIPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x53B6360", Offset = "0x53B4D60", VA = "0x1853B6360")]
	public void JAAPIIPCADC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x53B6A80", Offset = "0x53B5480", VA = "0x1853B6A80")]
	public void PNPCLDIKOHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x53B6590", Offset = "0x53B4F90", VA = "0x1853B6590")]
	public void LJJAAIMNJNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x53B5940", Offset = "0x53B4340", VA = "0x1853B5940")]
	public void CAJCCMKCLFP(string IJEJFFCLBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x53B6AD0", Offset = "0x53B54D0", VA = "0x1853B6AD0")]
	public void PPPLLONGKOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x53B64C0", Offset = "0x53B4EC0", VA = "0x1853B64C0")]
	public void LIILAMICEHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x53B6770", Offset = "0x53B5170", VA = "0x1853B6770")]
	public void NMNAIFEODOK(bool MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x53B6990", Offset = "0x53B5390", VA = "0x1853B6990")]
	public void OEPFCKGABDP(float MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x53B63B0", Offset = "0x53B4DB0", VA = "0x1853B63B0")]
	public void JBJOOAKCIJN(double MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x53B59A0", Offset = "0x53B43A0", VA = "0x1853B59A0")]
	public void CHFNGIBBJBP(byte MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x53B5910", Offset = "0x53B4310", VA = "0x1853B5910")]
	public void BPLBOMLOANK(ushort MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x53B6480", Offset = "0x53B4E80", VA = "0x1853B6480")]
	public void JLCIJKEHDLL(uint MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x53B6960", Offset = "0x53B5360", VA = "0x1853B6960")]
	public void OAHHMJJKBIB(ulong MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x53B58E0", Offset = "0x53B42E0", VA = "0x1853B58E0")]
	public void AIHDJMJGFHE(sbyte MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x53B6A50", Offset = "0x53B5450", VA = "0x1853B6A50")]
	public void PLCGAPCLHDE(short MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x53B5F20", Offset = "0x53B4920", VA = "0x1853B5F20")]
	public void IDHNBECMPML(int MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x53B6A20", Offset = "0x53B5420", VA = "0x1853B6A20")]
	public void OMGKGDHCDNN(long MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x53B5F50", Offset = "0x53B4950", VA = "0x1853B5F50")]
	public void IIEOIJAGMLB(string MNIAGKNOHEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JHFMLPJPPLF : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private static class OAHOLKBCHAK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2EA2DB0", Offset = "0x2EA17B0", VA = "0x182EA2DB0")]
		static OAHOLKBCHAK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private JHFMLPJPPLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class JNIPLJGLKBB
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> DKAGJCMHGBB;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4D1A040", Offset = "0x4D18A40", VA = "0x184D1A040")]
	static JNIPLJGLKBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4D19930", Offset = "0x4D18330", VA = "0x184D19930")]
	internal static object BHKKNAEHNON(Type KNGDLMLNDII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class NPAAHKJKLML : global::MMFDCMJAOJA<Vector2>, DHGBFBDHANB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly AEEKLCBFHNL NGBEICIICLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] MHKBHHKMOGK;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x52EBBD0", Offset = "0x52EA5D0", VA = "0x1852EBBD0")]
	public NPAAHKJKLML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x52EBB20", Offset = "0x52EA520", VA = "0x1852EBB20", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, Vector2 MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x52EB9A0", Offset = "0x52EA3A0", VA = "0x1852EB9A0", Slot = "5")]
	public Vector2 AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class KBGKKCICHLG : global::MMFDCMJAOJA<Vector3>, DHGBFBDHANB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly AEEKLCBFHNL NGBEICIICLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] MHKBHHKMOGK;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x53B5640", Offset = "0x53B4040", VA = "0x1853B5640")]
	public KBGKKCICHLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x53B53A0", Offset = "0x53B3DA0", VA = "0x1853B53A0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, Vector3 MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x53B5080", Offset = "0x53B3A80", VA = "0x1853B5080", Slot = "5")]
	public Vector3 AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class EPOMHNAOLIB : global::MMFDCMJAOJA<Vector4>, DHGBFBDHANB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly AEEKLCBFHNL NGBEICIICLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] MHKBHHKMOGK;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4D0AE50", Offset = "0x4D09850", VA = "0x184D0AE50")]
	public EPOMHNAOLIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4D0AD00", Offset = "0x4D09700", VA = "0x184D0AD00", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, Vector4 MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4D0AA70", Offset = "0x4D09470", VA = "0x184D0AA70", Slot = "5")]
	public Vector4 AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class GEPLJNFCCMK : global::MMFDCMJAOJA<Quaternion>, DHGBFBDHANB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly AEEKLCBFHNL NGBEICIICLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] MHKBHHKMOGK;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4D10000", Offset = "0x4D0EA00", VA = "0x184D10000")]
	public GEPLJNFCCMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4D0AD00", Offset = "0x4D09700", VA = "0x184D0AD00", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, Quaternion MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4D0FD70", Offset = "0x4D0E770", VA = "0x184D0FD70", Slot = "5")]
	public Quaternion AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class LGIBFGDBAKO : global::MMFDCMJAOJA<Color>, DHGBFBDHANB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly AEEKLCBFHNL NGBEICIICLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] MHKBHHKMOGK;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x53B8DD0", Offset = "0x53B77D0", VA = "0x1853B8DD0")]
	public LGIBFGDBAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x53B8A70", Offset = "0x53B7470", VA = "0x1853B8A70", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, Color MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x53B86F0", Offset = "0x53B70F0", VA = "0x1853B86F0", Slot = "5")]
	public Color AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class EEMFPMLOCKB : global::MMFDCMJAOJA<Bounds>, DHGBFBDHANB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly AEEKLCBFHNL NGBEICIICLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] MHKBHHKMOGK;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4D08740", Offset = "0x4D07140", VA = "0x184D08740")]
	public EEMFPMLOCKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4D085A0", Offset = "0x4D06FA0", VA = "0x184D085A0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, Bounds MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4D08270", Offset = "0x4D06C70", VA = "0x184D08270", Slot = "5")]
	public Bounds AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class COJEGIGFANA : global::MMFDCMJAOJA<Rect>, DHGBFBDHANB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly AEEKLCBFHNL NGBEICIICLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] MHKBHHKMOGK;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4D06AE0", Offset = "0x4D054E0", VA = "0x184D06AE0")]
	public COJEGIGFANA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4D06970", Offset = "0x4D05370", VA = "0x184D06970", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, Rect MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4D066C0", Offset = "0x4D050C0", VA = "0x184D066C0", Slot = "5")]
	public Rect AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class ONNDLEGFLII : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private static class CEJCKDFEEAE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x37A1870", Offset = "0x37A0270", VA = "0x1837A1870")]
		static CEJCKDFEEAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private ONNDLEGFLII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class NBGFEODHLHO : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private static class IAGJKAADNLH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4452DA0", Offset = "0x44517A0", VA = "0x184452DA0")]
		static IAGJKAADNLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class CPELLGPLDAP
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> MNLGNGEIANH;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x52E3CB0", Offset = "0x52E26B0", VA = "0x1852E3CB0")]
		internal static object BHKKNAEHNON(Type KNGDLMLNDII)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private NBGFEODHLHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class EJAHIAOGAHH : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class IDCFJJJLPKI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2209630", Offset = "0x2208030", VA = "0x182209630")]
		static IDCFJJJLPKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly EJAHIAOGAHH FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool FOGFBELPLAM;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static DHGBFBDHANB[] DMNMCLHOAME;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static HEOIHOEGOKA[] JCNGDBBDGCA;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private EJAHIAOGAHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4D092B0", Offset = "0x4D07CB0", VA = "0x184D092B0")]
	public static void OGMDKKEHOIN(params HEOIHOEGOKA[] JCNGDBBDGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4D09390", Offset = "0x4D07D90", VA = "0x184D09390")]
	public static void OGMDKKEHOIN(params DHGBFBDHANB[] DMNMCLHOAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4D09020", Offset = "0x4D07A20", VA = "0x184D09020")]
	public static void MHHOAKLKOGA(DHGBFBDHANB[] DMNMCLHOAME, HEOIHOEGOKA[] JCNGDBBDGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class DHMKGPNHPBN : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private static class DOLAJCMBCGI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x32A3470", Offset = "0x32A1E70", VA = "0x1832A3470")]
		static DOLAJCMBCGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private DHMKGPNHPBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class CCMBDELAIFN
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly HEOIHOEGOKA JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly HEOIHOEGOKA DKJKLJJOJOA;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly HEOIHOEGOKA MHOJOJDPLCP;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly HEOIHOEGOKA CCCGMJLLIGH;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly HEOIHOEGOKA DILMBOIMFGD;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly HEOIHOEGOKA BGEDKAJBAKI;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly HEOIHOEGOKA KNFDOMIJCFO;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly HEOIHOEGOKA HBNBFPAGGCH;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly HEOIHOEGOKA HCPMBMLHLEG;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly HEOIHOEGOKA FFKNHCFJDNC;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly HEOIHOEGOKA CCJIGPOFIKC;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly HEOIHOEGOKA KOFELEBIJEK;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HGJKJPPHFPI
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly HEOIHOEGOKA JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly HEOIHOEGOKA LLMPEEDJBIL;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class OBLLCIEELMI
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly HEOIHOEGOKA JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly HEOIHOEGOKA DKJKLJJOJOA;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly HEOIHOEGOKA MHOJOJDPLCP;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly HEOIHOEGOKA CCCGMJLLIGH;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly HEOIHOEGOKA DILMBOIMFGD;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly HEOIHOEGOKA BGEDKAJBAKI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly HEOIHOEGOKA KNFDOMIJCFO;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly HEOIHOEGOKA HBNBFPAGGCH;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly HEOIHOEGOKA HCPMBMLHLEG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly HEOIHOEGOKA FFKNHCFJDNC;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly HEOIHOEGOKA CCJIGPOFIKC;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly HEOIHOEGOKA KOFELEBIJEK;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class LGKHJBCPMPC
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> MNLGNGEIANH;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x53B9100", Offset = "0x53B7B00", VA = "0x1853B9100")]
	internal static object BHKKNAEHNON(Type KNGDLMLNDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x53BAA60", Offset = "0x53B9460", VA = "0x1853BAA60")]
	private static object FBCBOOBGBMP(Type NFJMDJKNHFB, Type[] MIGGBMOLHDL, params object[] HONMKKBCKFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class FHJNFMLNFOF : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private static class IMHEIHNHAKF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x23A93D0", Offset = "0x23A7DD0", VA = "0x1823A93D0")]
		static IMHEIHNHAKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> PCADEEOHDJC;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool HNBKEHFBPNC;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly LKACFIKFAMI FIOGECEPGBM;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B290", Offset = "0x4D09C90", VA = "0x184D0B290")]
	static FHJNFMLNFOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private FHJNFMLNFOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class DBKJBECHILB : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private static class OCCJKADCGHM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2EA5190", Offset = "0x2EA3B90", VA = "0x182EA5190")]
		static OCCJKADCGHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> PCADEEOHDJC;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool HNBKEHFBPNC;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly LKACFIKFAMI FIOGECEPGBM;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4D06FD0", Offset = "0x4D059D0", VA = "0x184D06FD0")]
	static DBKJBECHILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private DBKJBECHILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class GKHGCOAFEAI : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class EOIADJENFEC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x17A2F40", Offset = "0x17A1940", VA = "0x1817A2F40")]
		static EOIADJENFEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> PCADEEOHDJC;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool HNBKEHFBPNC;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly LKACFIKFAMI FIOGECEPGBM;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4D104D0", Offset = "0x4D0EED0", VA = "0x184D104D0")]
	static GKHGCOAFEAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private GKHGCOAFEAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class OFFLNFDJGIB : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class JPMDFGEPGCJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x340C660", Offset = "0x340B060", VA = "0x18340C660")]
		static JPMDFGEPGCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> PCADEEOHDJC;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool HNBKEHFBPNC;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly LKACFIKFAMI FIOGECEPGBM;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x52EEE20", Offset = "0x52ED820", VA = "0x1852EEE20")]
	static OFFLNFDJGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private OFFLNFDJGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class OLBICJIHMKN : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class COLFMGCDJAE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x24EE3E0", Offset = "0x24ECDE0", VA = "0x1824EE3E0")]
		static COLFMGCDJAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> PCADEEOHDJC;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool HNBKEHFBPNC;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly LKACFIKFAMI FIOGECEPGBM;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x52F1030", Offset = "0x52EFA30", VA = "0x1852F1030")]
	static OLBICJIHMKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private OLBICJIHMKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class LKHNKNMOPLE : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class JFILNPKJCNC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x30C6BF0", Offset = "0x30C55F0", VA = "0x1830C6BF0")]
		static JFILNPKJCNC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> PCADEEOHDJC;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool HNBKEHFBPNC;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly LKACFIKFAMI FIOGECEPGBM;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x53BB4C0", Offset = "0x53B9EC0", VA = "0x1853BB4C0")]
	static LKHNKNMOPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private LKHNKNMOPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class HODOGGAJHHC : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class AFHNGGGOBMG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x35A8810", Offset = "0x35A7210", VA = "0x1835A8810")]
		static AFHNGGGOBMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> PCADEEOHDJC;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool HNBKEHFBPNC;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public HODOGGAJHHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class LDBGODIPKEH : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class BBCLGJCCDMG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4AC2370", Offset = "0x4AC0D70", VA = "0x184AC2370")]
		static BBCLGJCCDMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> PCADEEOHDJC;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool HNBKEHFBPNC;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public LDBGODIPKEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class GPGNKCPPKCC : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class EMKHFGALJOL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2442480", Offset = "0x2440E80", VA = "0x182442480")]
		static EMKHFGALJOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> PCADEEOHDJC;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool HNBKEHFBPNC;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public GPGNKCPPKCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class KMJAPDPNHPO : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class AIABLGFCLCB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3073360", Offset = "0x3071D60", VA = "0x183073360")]
		static AIABLGFCLCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> PCADEEOHDJC;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool HNBKEHFBPNC;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KMJAPDPNHPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class DINCIHIOOOC : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class MKMCGPDPBNI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2B20240", Offset = "0x2B1EC40", VA = "0x182B20240")]
		static MKMCGPDPBNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> PCADEEOHDJC;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool HNBKEHFBPNC;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public DINCIHIOOOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class MCHHBMJGBBG : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class ICCMOLJKAEL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x445CBE0", Offset = "0x445B5E0", VA = "0x18445CBE0")]
		static ICCMOLJKAEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> PCADEEOHDJC;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool HNBKEHFBPNC;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public MCHHBMJGBBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal static class NHPONDABIGC
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private struct HCKJBDCEOLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public JKKLHIONLJF LGGJNDNJNFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder JNGALIELEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder FLCMFHAOKEC;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class OGDFCIDEPFA
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		internal static class IEFLPIMODNI
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo LLMHKDKLODO;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo DMKOFKELIPI;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo HLFNFILCMNI;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo IBDHIGJMDBL;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo LIILAMICEHL;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo COFJBHNFCHL;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo JKBDNGHMIPK;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo JAAPIIPCADC;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo PNPCLDIKOHK;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x52E8FA0", Offset = "0x52E79A0", VA = "0x1852E8FA0")]
			static IEFLPIMODNI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		internal static class CDBGIKKAFEC
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo CDJDMCOBFGI;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo DOHJDJPODIA;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo OAIFADLLMMC;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo OBCOJILMENJ;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo ECCNBAAKBBH;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo ABEFIEKALGK;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo CANMJODMANF;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x52E0FB0", Offset = "0x52DF9B0", VA = "0x1852E0FB0")]
			static CDBGIKKAFEC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class LNJIIHAILJJ
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo DAKJFNIMDOI;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo MOGBMEJMEGI;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo GIJNJGDGLJD;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo OPMBHFOEHIE;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo HOFMNKMBJCA;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo AABCLJBMAJC;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo IHAAPPHMMMP;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo FGADAJOEMBK;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo CMEBJCIIOHK;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo CLLLLLHJJCM;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo FMKKNBBDKCF;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo IDKPAGNLMEG;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo PBLKEPIIDCO;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo DNJAHDJBJEA;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x52EF300", Offset = "0x52EDD00", VA = "0x1852EF300")]
		public static MethodInfo JHPOCMCIPNJ(Type MAHAMGBPDNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x52EEF50", Offset = "0x52ED950", VA = "0x1852EEF50")]
		public static MethodInfo AJGJBLGJHIK(Type MAHAMGBPDNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x52EF1C0", Offset = "0x52EDBC0", VA = "0x1852EF1C0")]
		public static MethodInfo CKCNJDLHLMH(Type MAHAMGBPDNB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class MDHNHMGHEMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<JKKLHIONLJF, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public MDHNHMGHEMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class NOFJGPJMAHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public MDHNHMGHEMC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public NOFJGPJMAHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x52EB8C0", Offset = "0x52EA2C0", VA = "0x1852EB8C0")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x52EB900", Offset = "0x52EA300", VA = "0x1852EB900")]
		internal bool <BuildType>b__2(int index, JKKLHIONLJF member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class AIPFKEFHFPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public MDHNHMGHEMC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public AIPFKEFHFPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x52E0890", Offset = "0x52DF290", VA = "0x1852E0890")]
		internal bool <BuildType>b__3(int index, JKKLHIONLJF member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class FDBKOCLEIOF
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

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public FDBKOCLEIOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x52E6100", Offset = "0x52E4B00", VA = "0x1852E6100")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class CPNNCFEIGPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public CPNNCFEIGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x52E5C20", Offset = "0x52E4620", VA = "0x1852E5C20")]
		internal bool <BuildAnonymousFormatter>b__2(JKKLHIONLJF x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class FLLAEGMFKEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public FDBKOCLEIOF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public FLLAEGMFKEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x52E6A30", Offset = "0x52E5430", VA = "0x1852E6A30")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x52E6A40", Offset = "0x52E5440", VA = "0x1852E6A40")]
		internal bool <BuildAnonymousFormatter>b__6(int index, JKKLHIONLJF member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class EMOMLDKGBDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public FDBKOCLEIOF CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public EMOMLDKGBDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x52E5F60", Offset = "0x52E4960", VA = "0x1852E5F60")]
		internal bool <BuildAnonymousFormatter>b__7(int index, JKKLHIONLJF member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class JHJEJDKMGFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public JHJEJDKMGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6EBFD0", Offset = "0x6EA9D0", VA = "0x1806EBFD0")]
		internal Label <BuildSerialize>b__1(JKKLHIONLJF _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class KDAFLJKBEMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public HCKJBDCEOLC[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, JKKLHIONLJF, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public FIGCPDMOHNH argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public FIGCPDMOHNH argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public KDAFLJKBEMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x52EA010", Offset = "0x52E8A10", VA = "0x1852EA010")]
		internal HCKJBDCEOLC <BuildDeserialize>b__0(JKKLHIONLJF item)
		{
			return default(HCKJBDCEOLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class MPFBECPGKBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public KDAFLJKBEMA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public MPFBECPGKBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x52EB430", Offset = "0x52E9E30", VA = "0x1852EB430")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x52EB6E0", Offset = "0x52EA0E0", VA = "0x1852EB6E0")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class OFEGBOEKPML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public JKKLHIONLJF item;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public OFEGBOEKPML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x10CC340", Offset = "0x10CAD40", VA = "0x1810CC340")]
		internal bool <EmitNewObject>b__0(HCKJBDCEOLC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class MODCALPJNGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public JKKLHIONLJF item;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public MODCALPJNGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x10CC340", Offset = "0x10CAD40", VA = "0x1810CC340")]
		internal bool <EmitNewObject>b__2(HCKJBDCEOLC x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex NAOKAECJMMG;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int NJFJHNJOMJP;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> EJBFACGLPMK;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> CDDGDGLGGDG;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x331F740", Offset = "0x331E140", VA = "0x18331F740")]
	public static object DFJKEAJOCLE<T>(LKACFIKFAMI FIOGECEPGBM, HEOIHOEGOKA HOEDMLOGEGA, Func<string, string> PCADEEOHDJC, bool HNBKEHFBPNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3314D80", Offset = "0x3313780", VA = "0x183314D80")]
	public static object AIPENLFAOJN<T>(HEOIHOEGOKA HOEDMLOGEGA, Func<string, string> PCADEEOHDJC, bool HNBKEHFBPNC, bool EOJNBAAOOGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x53C4350", Offset = "0x53C2D50", VA = "0x1853C4350")]
	private static TypeInfo IKJJAFDICOM(LKACFIKFAMI FIOGECEPGBM, Type MAHAMGBPDNB, Func<string, string> PCADEEOHDJC, bool HNBKEHFBPNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x53BFA60", Offset = "0x53BE460", VA = "0x1853BFA60")]
	public static object ADCGAFMCMCJ(Type MAHAMGBPDNB, Func<string, string> PCADEEOHDJC, bool HNBKEHFBPNC, bool EOJNBAAOOGF, bool LIPOMCHNIPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x53C1AA0", Offset = "0x53C04A0", VA = "0x1853C1AA0")]
	private static Dictionary<JKKLHIONLJF, FieldInfo> EEIMHMNOFBC(TypeBuilder CEIJDEMPIGI, MAIDJPBEJBH BKNGKBHJGHC, ConstructorInfo IHAILABECFO, FieldBuilder CANPDBJHOPJ, ILGenerator NICPIDGMOCD, bool HNBKEHFBPNC, bool JMNEFMLOPOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x53C68E0", Offset = "0x53C52E0", VA = "0x1853C68E0")]
	private static Dictionary<JKKLHIONLJF, FieldInfo> MGBKNJDCCAB(TypeBuilder CEIJDEMPIGI, MAIDJPBEJBH BKNGKBHJGHC, ILGenerator NICPIDGMOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x53C2E30", Offset = "0x53C1830", VA = "0x1853C2E30")]
	private static void GMKGMLAEINJ(Type MAHAMGBPDNB, MAIDJPBEJBH BKNGKBHJGHC, ILGenerator NICPIDGMOCD, Action FGOIFAHDPFH, Func<int, JKKLHIONLJF, bool> INJEGFFCECI, bool HNBKEHFBPNC, bool JMNEFMLOPOC, int PDJJHCIIGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x53C6F60", Offset = "0x53C5960", VA = "0x1853C6F60")]
	private static void NHBPHBNDCHC(TypeInfo MAHAMGBPDNB, JKKLHIONLJF KINEECOIOBG, ILGenerator NICPIDGMOCD, int GFDMFLGCBKB, Func<int, JKKLHIONLJF, bool> INJEGFFCECI, FIGCPDMOHNH LHGJJBFKNCG, FIGCPDMOHNH IBOHNKMEDOP, FIGCPDMOHNH JNEIAFLCFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x53C4DE0", Offset = "0x53C37E0", VA = "0x1853C4DE0")]
	private static void JLMKDPCOGJF(Type MAHAMGBPDNB, MAIDJPBEJBH BKNGKBHJGHC, ILGenerator NICPIDGMOCD, Func<int, JKKLHIONLJF, bool> INJEGFFCECI, bool NPNIBGMOOOG, int PDJJHCIIGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x53C15E0", Offset = "0x53BFFE0", VA = "0x1853C15E0")]
	private static void BIAEJLOMKLL(ILGenerator NICPIDGMOCD, HCKJBDCEOLC BKNGKBHJGHC, int GFDMFLGCBKB, Func<int, JKKLHIONLJF, bool> INJEGFFCECI, FIGCPDMOHNH ALGAFFHCPAP, FIGCPDMOHNH JNEIAFLCFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x53C2180", Offset = "0x53C0B80", VA = "0x1853C2180")]
	private static LocalBuilder EMFHNMGBHFI(ILGenerator NICPIDGMOCD, Type MAHAMGBPDNB, MAIDJPBEJBH BKNGKBHJGHC, HCKJBDCEOLC[] CHIDFCOKGPH, bool NPEPEDDDGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x53C61E0", Offset = "0x53C4BE0", VA = "0x1853C61E0")]
	private static bool KMNJPLNGAAJ(ConstructorInfo JKLIOAOBKLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x53C74B0", Offset = "0x53C5EB0", VA = "0x1853C74B0")]
	private static bool OGMKBKKNHIN(Type MAHAMGBPDNB, out Type ANNPNGLPFHK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal delegate void PPMNIHGMNGF<T>(byte[][] CANPDBJHOPJ, object[] GDFGHFJLPPE, ref KBHFHFFPFEJ LHGJJBFKNCG, T MNIAGKNOHEJ, HEOIHOEGOKA JECLFPNEMPA);
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal delegate T HLJGPMILPPA<T>(object[] GDFGHFJLPPE, ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JECLFPNEMPA);
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class IMNLLACOOBJ<T> : global::MMFDCMJAOJA<T>, DHGBFBDHANB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] CANPDBJHOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] PEAIFJPJGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] FPEABJAMEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly global::PPMNIHGMNGF<T> MNCMPMDGFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly global::HLJGPMILPPA<T> OHLACLDAPOC;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x23AC060", Offset = "0x23AAA60", VA = "0x1823AC060")]
	public IMNLLACOOBJ(byte[][] CANPDBJHOPJ, object[] PEAIFJPJGHO, object[] FPEABJAMEBP, global::PPMNIHGMNGF<T> MNCMPMDGFID, global::HLJGPMILPPA<T> OHLACLDAPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x23ABF80", Offset = "0x23AA980", VA = "0x1823ABF80", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, T MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x23ABEB0", Offset = "0x23AA8B0", VA = "0x1823ABEB0", Slot = "5")]
	public T AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal sealed class APJOGLIKDED : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private static class AILDNADDEJO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3077DA0", Offset = "0x30767A0", VA = "0x183077DA0")]
		static AILDNADDEJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private APJOGLIKDED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class MIKHHJGENPK : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private static class EIAHAGOFLBM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2432840", Offset = "0x2431240", VA = "0x182432840")]
		static EIAHAGOFLBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private MIKHHJGENPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal static class ALIAHPLGHEF
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly HEOIHOEGOKA[] MGFIECMBNFA;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal sealed class AGPAGPCNNBA : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private static class BAKFLGMMJCF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x4ABEC50", Offset = "0x4ABD650", VA = "0x184ABEC50")]
		static BAKFLGMMJCF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private sealed class DGMAAOFLEFI : HEOIHOEGOKA
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		private static class KBGPCJDIFBN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x34B9E30", Offset = "0x34B8830", VA = "0x1834B9E30")]
			static KBGPCJDIFBN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly HEOIHOEGOKA[] JCNGDBBDGCA;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		private DGMAAOFLEFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
		public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly global::MMFDCMJAOJA<object> AGMOANLDGOE;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private AGPAGPCNNBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class MPACEHFGIOI : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class KHEEKOFCIHC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3110D90", Offset = "0x310F790", VA = "0x183110D90")]
		static KHEEKOFCIHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class GJHJJBAKNEK : HEOIHOEGOKA
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class PJHEIDADHGM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x2A53200", Offset = "0x2A51C00", VA = "0x182A53200")]
			static PJHEIDADHGM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly HEOIHOEGOKA[] JCNGDBBDGCA;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		private GJHJJBAKNEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
		public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly global::MMFDCMJAOJA<object> AGMOANLDGOE;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private MPACEHFGIOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class AIMKBPKLPAE : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class BFHCKIIPECA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x26D6050", Offset = "0x26D4A50", VA = "0x1826D6050")]
		static BFHCKIIPECA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class IBAAMOGOOFD : HEOIHOEGOKA
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class AOAGEJJKCHF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x3093100", Offset = "0x3091B00", VA = "0x183093100")]
			static AOAGEJJKCHF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly HEOIHOEGOKA[] JCNGDBBDGCA;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		private IBAAMOGOOFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
		public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly global::MMFDCMJAOJA<object> AGMOANLDGOE;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private AIMKBPKLPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class DJIMLAONJOK : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class EFDEJPOLMPK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5950", Offset = "0x2AA4350", VA = "0x182AA5950")]
		static EFDEJPOLMPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class FHOLHDALANO : HEOIHOEGOKA
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class HOPJKDPMAON<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x3600B20", Offset = "0x35FF520", VA = "0x183600B20")]
			static HOPJKDPMAON()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly HEOIHOEGOKA[] JCNGDBBDGCA;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		private FHOLHDALANO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
		public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly global::MMFDCMJAOJA<object> AGMOANLDGOE;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private DJIMLAONJOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class ELBKAFJOEAL : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class AJIMONHJGLM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3085170", Offset = "0x3083B70", VA = "0x183085170")]
		static AJIMONHJGLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class GPMKFGBGCKK : HEOIHOEGOKA
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class DNNHHDCHKHP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x32A1A40", Offset = "0x32A0440", VA = "0x1832A1A40")]
			static DNNHHDCHKHP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly HEOIHOEGOKA[] JCNGDBBDGCA;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		private GPMKFGBGCKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
		public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly global::MMFDCMJAOJA<object> AGMOANLDGOE;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private ELBKAFJOEAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class IEDOMOILGJA : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class JEMLDBJCCLA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x30BFF90", Offset = "0x30BE990", VA = "0x1830BFF90")]
		static JEMLDBJCCLA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class CDOALDOPMGO : HEOIHOEGOKA
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class JJGCDLPGMAL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x3165910", Offset = "0x3164310", VA = "0x183165910")]
			static JJGCDLPGMAL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly HEOIHOEGOKA[] JCNGDBBDGCA;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		private CDOALDOPMGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
		public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly global::MMFDCMJAOJA<object> AGMOANLDGOE;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private IEDOMOILGJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class KIEDHLOEGML : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class IAAGDKAKLCF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x444FB40", Offset = "0x444E540", VA = "0x18444FB40")]
		static IAAGDKAKLCF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class ACBBOJJDJML : HEOIHOEGOKA
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class EEMANBMBODF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x2A9FD50", Offset = "0x2A9E750", VA = "0x182A9FD50")]
			static EEMANBMBODF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly HEOIHOEGOKA[] JCNGDBBDGCA;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		private ACBBOJJDJML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
		public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly global::MMFDCMJAOJA<object> AGMOANLDGOE;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private KIEDHLOEGML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class OMJCGMNINHI : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class AILJFBEKHPL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3080EF0", Offset = "0x307F8F0", VA = "0x183080EF0")]
		static AILJFBEKHPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class LPKPOLJMDNI : HEOIHOEGOKA
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class GDOKIBODEGH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x2A86160", Offset = "0x2A84B60", VA = "0x182A86160")]
			static GDOKIBODEGH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly HEOIHOEGOKA[] JCNGDBBDGCA;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		private LPKPOLJMDNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
		public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly global::MMFDCMJAOJA<object> AGMOANLDGOE;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private OMJCGMNINHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class IOPGBBEJDCO : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class JECOHCPEAPK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x30B72E0", Offset = "0x30B5CE0", VA = "0x1830B72E0")]
		static JECOHCPEAPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class KDJDCLFAKIE : HEOIHOEGOKA
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class NCDEJHJJJFN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x2300940", Offset = "0x22FF340", VA = "0x182300940")]
			static NCDEJHJJJFN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly HEOIHOEGOKA[] JCNGDBBDGCA;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		private KDJDCLFAKIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
		public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly global::MMFDCMJAOJA<object> AGMOANLDGOE;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private IOPGBBEJDCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class GJGJCJNABMF : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class JGNKGOKBMNL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x315D4F0", Offset = "0x315BEF0", VA = "0x18315D4F0")]
		static JGNKGOKBMNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class MJBOKDODMAM : HEOIHOEGOKA
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class ALAPBKHLKAB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x308BE60", Offset = "0x308A860", VA = "0x18308BE60")]
			static ALAPBKHLKAB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly HEOIHOEGOKA[] JCNGDBBDGCA;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		private MJBOKDODMAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
		public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly global::MMFDCMJAOJA<object> AGMOANLDGOE;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private GJGJCJNABMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class BBCFFABBOOM : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class FNKACGMHKKO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2FA5440", Offset = "0x2FA3E40", VA = "0x182FA5440")]
		static FNKACGMHKKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class MKKOJJCBFIP : HEOIHOEGOKA
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class GNBFPKLPEBD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x31379E0", Offset = "0x31363E0", VA = "0x1831379E0")]
			static GNBFPKLPEBD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly HEOIHOEGOKA[] JCNGDBBDGCA;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		private MKKOJJCBFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
		public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly global::MMFDCMJAOJA<object> AGMOANLDGOE;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private BBCFFABBOOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class JLMCFLLCBND : HEOIHOEGOKA
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class KKNNKHMIIHA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x311ADC0", Offset = "0x31197C0", VA = "0x18311ADC0")]
		static KKNNKHMIIHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class KHHHHAKGPKI : HEOIHOEGOKA
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class FCANEOEKJAL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly global::MMFDCMJAOJA<T> OCPCBIJPACB;

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x2A00800", Offset = "0x29FF200", VA = "0x182A00800")]
			static FCANEOEKJAL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly HEOIHOEGOKA[] JCNGDBBDGCA;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		private KHHHHAKGPKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
		public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly HEOIHOEGOKA FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly global::MMFDCMJAOJA<object> AGMOANLDGOE;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	private JLMCFLLCBND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1D62920", Offset = "0x1D61320", VA = "0x181D62920", Slot = "4")]
	public global::MMFDCMJAOJA<T> BHKKNAEHNON<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct CIDIOMLJFEN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] PHDIOEGCLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int PFDAMFBILGD;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x24E1460", Offset = "0x24DFE60", VA = "0x1824E1460")]
	public CIDIOMLJFEN(int MKLBKBICADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x24E0F90", Offset = "0x24DF990", VA = "0x1824E0F90")]
	public void CPLOAHMOJFD(T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x24E13D0", Offset = "0x24DFDD0", VA = "0x1824E13D0")]
	public T[] PCHEOIJAOFM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
internal sealed class HCAOPMHDOAM : global::EGBHIGBHKHD<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly HCAOPMHDOAM JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4D14420", Offset = "0x4D12E20", VA = "0x184D14420")]
	public HCAOPMHDOAM(int OHAIMBMCBIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal class EGBHIGBHKHD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int OHAIMBMCBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object HALNGEGGAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int GFDMFLGCBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] EMJPPKHONLA;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2425A80", Offset = "0x2424480", VA = "0x182425A80")]
	public EGBHIGBHKHD(int OHAIMBMCBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2424C00", Offset = "0x2423600", VA = "0x182424C00")]
	public T[] JDINMDPOMNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2425720", Offset = "0x2424120", VA = "0x182425720")]
	public void ONGMKKAGFAD(T[] GNPHBMKMMCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class AEEKLCBFHNL : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private class IEELDNBEANF : IComparable<IEELDNBEANF>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class HEEHCDEAJCB : IEnumerable<IEELDNBEANF>, IEnumerable, IEnumerator<IEELDNBEANF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private IEELDNBEANF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public IEELDNBEANF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private IEELDNBEANF System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F0")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F2")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x89C150", Offset = "0x89AB50", VA = "0x18089C150")]
			[DebuggerHidden]
			public HEEHCDEAJCB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x52E7600", Offset = "0x52E6000", VA = "0x1852E7600", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x52E7730", Offset = "0x52E6130", VA = "0x1852E7730", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x52E7690", Offset = "0x52E6090", VA = "0x1852E7690", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<IEELDNBEANF> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x52E7690", Offset = "0x52E6090", VA = "0x1852E7690", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class OIEEJIJOLDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public OIEEJIJOLDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x6EBFD0", Offset = "0x6EA9D0", VA = "0x1806EBFD0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x6EBFD0", Offset = "0x6EA9D0", VA = "0x1806EBFD0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly IEELDNBEANF[] DHGMCMMLICK;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] PJEHNOAOKPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong OKLKOGDIKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int ACPLDDIHALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string FDMIDDILODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IEELDNBEANF[] FAAPELAAGDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] ANCIGLBHNEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int JOBJIONNEHK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool PGLFAMNGCBA
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xCC4F00", Offset = "0xCC3900", VA = "0x180CC4F00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x52E8EE0", Offset = "0x52E78E0", VA = "0x1852E8EE0")]
		public IEELDNBEANF(ulong AJPNMLHDHNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x52E7AC0", Offset = "0x52E64C0", VA = "0x1852E7AC0")]
		public IEELDNBEANF CPLOAHMOJFD(ulong AJPNMLHDHNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x52E7D80", Offset = "0x52E6780", VA = "0x1852E7D80")]
		public IEELDNBEANF CPLOAHMOJFD(ulong AJPNMLHDHNM, int MNIAGKNOHEJ, string FDMIDDILODH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x52E8C30", Offset = "0x52E7630", VA = "0x1852E8C30")]
		public IEELDNBEANF OJPANCKMJBP(byte[] LHIIFNPNDIA, ref int JFKBHBKKACD, ref int GFKJMJOENMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x52E7A40", Offset = "0x52E6440", VA = "0x1852E7A40")]
		internal static int CFCPNPBEFIM(ulong[] GNPHBMKMMCM, int GFDMFLGCBKB, int KHNOOLPHJPF, ulong MNIAGKNOHEJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x52E7DD0", Offset = "0x52E67D0", VA = "0x1852E7DD0", Slot = "4")]
		public int CompareTo(IEELDNBEANF DFHJPOKNFFB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x52E8DE0", Offset = "0x52E77E0", VA = "0x1852E8DE0")]
		[IteratorStateMachine(typeof(HEEHCDEAJCB))]
		public IEnumerable<IEELDNBEANF> OLCIKFENBBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x52E7E00", Offset = "0x52E6800", VA = "0x1852E7E00")]
		public void IFJKHKJPMEP(ILGenerator NICPIDGMOCD, LocalBuilder LHIIFNPNDIA, LocalBuilder GFKJMJOENMM, LocalBuilder AJPNMLHDHNM, Action<KeyValuePair<string, int>> KOCHOJPBLAF, Action IAPOMGKCJIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x52E7F40", Offset = "0x52E6940", VA = "0x1852E7F40")]
		private static void NHBLONDINEO(ILGenerator NICPIDGMOCD, LocalBuilder LHIIFNPNDIA, LocalBuilder GFKJMJOENMM, LocalBuilder AJPNMLHDHNM, Action<KeyValuePair<string, int>> KOCHOJPBLAF, Action IAPOMGKCJIN, IEELDNBEANF[] FAAPELAAGDC, int JOBJIONNEHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class FILIPEFGOLD : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<IEELDNBEANF> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<IEELDNBEANF> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<IEELDNBEANF> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private IEELDNBEANF <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x6E2040", Offset = "0x6E0A40", VA = "0x1806E2040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x52E6860", Offset = "0x52E5260", VA = "0x1852E6860", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x968EC0", Offset = "0x9678C0", VA = "0x180968EC0")]
		[DebuggerHidden]
		public FILIPEFGOLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x52E68B0", Offset = "0x52E52B0", VA = "0x1852E68B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x52E6320", Offset = "0x52E4D20", VA = "0x1852E6320", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x52E6990", Offset = "0x52E5390", VA = "0x1852E6990")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x52E69E0", Offset = "0x52E53E0", VA = "0x1852E69E0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x52E6820", Offset = "0x52E5220", VA = "0x1852E6820", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x52E6780", Offset = "0x52E5180", VA = "0x1852E6780", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x52E6780", Offset = "0x52E5180", VA = "0x1852E6780", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly IEELDNBEANF OFMDHDILEHM;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4D01B10", Offset = "0x4D00510", VA = "0x184D01B10")]
	public AEEKLCBFHNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4D014C0", Offset = "0x4CFFEC0", VA = "0x184D014C0")]
	public void CPLOAHMOJFD(byte[] FMIGDHLBIKP, int MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4D01600", Offset = "0x4D00000", VA = "0x184D01600")]
	public bool FFHMHJCIIGC(ArraySegment<byte> AJPNMLHDHNM, out int MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4D01A80", Offset = "0x4D00480", VA = "0x184D01A80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4D016C0", Offset = "0x4D000C0", VA = "0x184D016C0")]
	private static void FJCADIOMBHE(IEnumerable<IEELDNBEANF> FAAPELAAGDC, StringBuilder JGCNNCLKHIA, int GLPDCHNEBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4D019D0", Offset = "0x4D003D0", VA = "0x184D019D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4D019D0", Offset = "0x4D003D0", VA = "0x184D019D0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4D01960", Offset = "0x4D00360", VA = "0x184D01960")]
	[IteratorStateMachine(typeof(FILIPEFGOLD))]
	private static IEnumerable<KeyValuePair<string, int>> GGDJMHLENAC(IEnumerable<IEELDNBEANF> FAAPELAAGDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4D015D0", Offset = "0x4CFFFD0", VA = "0x184D015D0")]
	public void FBAGHJEGDHF(ILGenerator NICPIDGMOCD, LocalBuilder LHIIFNPNDIA, LocalBuilder GFKJMJOENMM, LocalBuilder AJPNMLHDHNM, Action<KeyValuePair<string, int>> KOCHOJPBLAF, Action IAPOMGKCJIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public static class BPLHKHJLOLE
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo FGBJJDOFMKB;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4D049F0", Offset = "0x4D033F0", VA = "0x184D049F0")]
	public static ulong GKGGBFKFAFK(byte[] FMIGDHLBIKP, ref int JFKBHBKKACD, ref int GFKJMJOENMM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class CBANGBFALDO
{
	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4D06020", Offset = "0x4D04A20", VA = "0x184D06020")]
	public static void KMGAMBDOMKB(ref byte[] FMIGDHLBIKP, int JFKBHBKKACD, int ELHOOJHBHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4D06160", Offset = "0x4D04B60", VA = "0x184D06160")]
	public static void PCDEKLPBDPF(ref byte[] GNPHBMKMMCM, int IEOCOKIDJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4D05F00", Offset = "0x4D04900", VA = "0x184D05F00")]
	public static byte[] KAFOJCGNJPE(byte[] APKDOIJAGNF, int IEOCOKIDJIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class ODOKKFMPCBM
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x52ED6B0", Offset = "0x52EC0B0", VA = "0x1852ED6B0")]
	public static bool IHGPCKFDMJE(byte[] FIIGLPFBKBJ, int ECHLDGCHLCN, int DLEGCNNDGNF, byte[] PJCLCFAIEFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class KDLJMIMKEDI<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private struct LGPBKELPEOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] OKLKOGDIKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T ACPLDDIHALN;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x255D420", Offset = "0x255BE20", VA = "0x18255D420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class GEJEFPGCMCM : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public global::KDLJMIMKEDI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private LGPBKELPEOA[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private LGPBKELPEOA[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x6E2040", Offset = "0x6E0A40", VA = "0x1806E2040", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2A8C2D0", Offset = "0x2A8ACD0", VA = "0x182A8C2D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1D687B0", Offset = "0x1D671B0", VA = "0x181D687B0")]
		[DebuggerHidden]
		public GEJEFPGCMCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B590", Offset = "0x2A89F90", VA = "0x182A8B590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2A8BE50", Offset = "0x2A8A850", VA = "0x182A8BE50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly LGPBKELPEOA[][] GJNJJDFBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong ECDCBFAIKPI;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x3108B50", Offset = "0x3107550", VA = "0x183108B50")]
	public KDLJMIMKEDI(int ADCMDGEMNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x3108A90", Offset = "0x3107490", VA = "0x183108A90")]
	public KDLJMIMKEDI(int ADCMDGEMNDH, float NHBMGAOKCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x34C0A40", Offset = "0x34BF440", VA = "0x1834C0A40")]
	public void CPLOAHMOJFD(byte[] AJPNMLHDHNM, T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x34C53F0", Offset = "0x34C3DF0", VA = "0x1834C53F0")]
	private bool FBMOOFONAPF(byte[] AJPNMLHDHNM, T MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x34BE830", Offset = "0x34BD230", VA = "0x1834BE830")]
	public bool CKMNFEFPOIP(ArraySegment<byte> AJPNMLHDHNM, out T MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3108A30", Offset = "0x3107430", VA = "0x183108A30")]
	private static ulong KNAJEOAMBFC(byte[] MEALLDFELFM, int JFKBHBKKACD, int JOBJIONNEHK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x22136D0", Offset = "0x22120D0", VA = "0x1822136D0")]
	private static int EAACGHLPNHP(int JBGLKEHOKLH, float NHBMGAOKCJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3108910", Offset = "0x3107310", VA = "0x183108910", Slot = "4")]
	[IteratorStateMachine(typeof(global::KDLJMIMKEDI<>.GEJEFPGCMCM))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x22045B0", Offset = "0x2202FB0", VA = "0x1822045B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
internal class BNGJGHANFKO : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] NGOFNKCMJGN;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] JEPDFNAEHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int PIACLJADEJI;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool LFDNNPDEGBD
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x4D041B0", Offset = "0x4D02BB0", VA = "0x184D041B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4D04320", Offset = "0x4D02D20", VA = "0x184D04320")]
	static BNGJGHANFKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4D045A0", Offset = "0x4D02FA0", VA = "0x184D045A0")]
	public BNGJGHANFKO(byte[] PAPFHMAKGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4D04200", Offset = "0x4D02C00", VA = "0x184D04200")]
	public OpCode NOKCKKICHBE()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal struct GPAGNLODPEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid ACPLDDIHALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte FFPBEGHPLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte ADOBIDBDBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte LJOLDAOHDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte LJJANCOPINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte IPJEGFANAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte MMEBICHPEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte EOMIGNAHMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte CDFBGIEOOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte EMKPPPJMBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte HPHLGEGDIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte HDOCMACNMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte INOIGOJJKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte NLAHBDLGHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte BLCOPHJIOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte JCFAOIGLFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte NJFKACGNMDH;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] EJKGCJKIKOE;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] PEBMEJHECJE;

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x4D133C0", Offset = "0x4D11DC0", VA = "0x184D133C0")]
	public GPAGNLODPEB(ref Guid MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4D11F70", Offset = "0x4D10970", VA = "0x184D11F70")]
	public GPAGNLODPEB(ref ArraySegment<byte> BMIKKBIHPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4D11DE0", Offset = "0x4D107E0", VA = "0x184D11DE0")]
	private static byte JHAIEFHFNJO(byte[] FMIGDHLBIKP, int FNGFGPJLDON)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4D11CD0", Offset = "0x4D106D0", VA = "0x184D11CD0")]
	private static byte DNDDCHGOIAP(byte DLAMIJMLOOE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x4D10980", Offset = "0x4D0F380", VA = "0x184D10980")]
	public void BPBNENCMAFM(byte[] DFIIPKJNKEL, int JFKBHBKKACD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class JLNEAFMEAML
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4D17C50", Offset = "0x4D16650", VA = "0x184D17C50")]
	public static bool DOOODFAODEC(byte LKLPGHLLEIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4D18060", Offset = "0x4D16A60", VA = "0x184D18060")]
	public static bool KEJPAOEEOLC(byte LKLPGHLLEIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4D17F80", Offset = "0x4D16980", VA = "0x184D17F80")]
	public static sbyte IOGJLJPMMDC(byte[] FMIGDHLBIKP, int JFKBHBKKACD, out int CLMNOEGMEHE)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x4D179E0", Offset = "0x4D163E0", VA = "0x184D179E0")]
	public static short DGMBKGLOMFI(byte[] FMIGDHLBIKP, int JFKBHBKKACD, out int CLMNOEGMEHE)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4D17FF0", Offset = "0x4D169F0", VA = "0x184D17FF0")]
	public static int JCEBCKEIGNH(byte[] FMIGDHLBIKP, int JFKBHBKKACD, out int CLMNOEGMEHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x4D17C60", Offset = "0x4D16660", VA = "0x184D17C60")]
	public static long HJNGEGNHOEN(byte[] FMIGDHLBIKP, int JFKBHBKKACD, out int CLMNOEGMEHE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x4D17970", Offset = "0x4D16370", VA = "0x184D17970")]
	public static byte CKHLGCAEBBJ(byte[] FMIGDHLBIKP, int JFKBHBKKACD, out int CLMNOEGMEHE)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x4D180D0", Offset = "0x4D16AD0", VA = "0x184D180D0")]
	public static ushort KPJOAFICANE(byte[] FMIGDHLBIKP, int JFKBHBKKACD, out int CLMNOEGMEHE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x4D178F0", Offset = "0x4D162F0", VA = "0x184D178F0")]
	public static uint CEHMCCPJBMG(byte[] FMIGDHLBIKP, int JFKBHBKKACD, out int CLMNOEGMEHE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x4D17A50", Offset = "0x4D16450", VA = "0x184D17A50")]
	public static ulong DJMEFCKLPPK(byte[] FMIGDHLBIKP, int JFKBHBKKACD, out int CLMNOEGMEHE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x4D17800", Offset = "0x4D16200", VA = "0x184D17800")]
	public static float BDCOMDNFGNF(byte[] FMIGDHLBIKP, int JFKBHBKKACD, out int CLMNOEGMEHE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x4D17B60", Offset = "0x4D16560", VA = "0x184D17B60")]
	public static double DNBFCIOFPPF(byte[] FMIGDHLBIKP, int JFKBHBKKACD, out int CLMNOEGMEHE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x4D18140", Offset = "0x4D16B40", VA = "0x184D18140")]
	public static int OAHHMJJKBIB(ref byte[] DFIIPKJNKEL, int JFKBHBKKACD, ulong MNIAGKNOHEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x4D18910", Offset = "0x4D17310", VA = "0x184D18910")]
	public static int OMGKGDHCDNN(ref byte[] DFIIPKJNKEL, int JFKBHBKKACD, long MNIAGKNOHEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x4D17D10", Offset = "0x4D16710", VA = "0x184D17D10")]
	public static bool IOECAAFFALL(byte[] FMIGDHLBIKP, int JFKBHBKKACD, out int CLMNOEGMEHE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class AGDAEHBGLAB
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class HBILMINKBMD : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x89C150", Offset = "0x89AB50", VA = "0x18089C150")]
		[DebuggerHidden]
		public HBILMINKBMD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x52E73C0", Offset = "0x52E5DC0", VA = "0x1852E73C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x52E6F60", Offset = "0x52E5960", VA = "0x1852E6F60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x52E74B0", Offset = "0x52E5EB0", VA = "0x1852E74B0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x52E7500", Offset = "0x52E5F00", VA = "0x1852E7500")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x52E7380", Offset = "0x52E5D80", VA = "0x1852E7380", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x52E72D0", Offset = "0x52E5CD0", VA = "0x1852E72D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x52E72D0", Offset = "0x52E5CD0", VA = "0x1852E72D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class BPAGIBPCHKF : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x89C150", Offset = "0x89AB50", VA = "0x18089C150")]
		[DebuggerHidden]
		public BPAGIBPCHKF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x52E0E20", Offset = "0x52DF820", VA = "0x1852E0E20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x52E09C0", Offset = "0x52DF3C0", VA = "0x1852E09C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x52E0F10", Offset = "0x52DF910", VA = "0x1852E0F10")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x52E0F60", Offset = "0x52DF960", VA = "0x1852E0F60")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x52E0DE0", Offset = "0x52DF7E0", VA = "0x1852E0DE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x52E0D30", Offset = "0x52DF730", VA = "0x1852E0D30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x52E0D30", Offset = "0x52DF730", VA = "0x1852E0D30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x4D02270", Offset = "0x4D00C70", VA = "0x184D02270")]
	public static bool CAIEDKMLDJB(this TypeInfo MAHAMGBPDNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x4D02450", Offset = "0x4D00E50", VA = "0x184D02450")]
	public static bool KADLAMKDFJP(this TypeInfo MAHAMGBPDNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x4D02570", Offset = "0x4D00F70", VA = "0x184D02570")]
	public static IEnumerable<PropertyInfo> NAGKDOEEDLN(this Type MAHAMGBPDNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x4D02330", Offset = "0x4D00D30", VA = "0x184D02330")]
	[IteratorStateMachine(typeof(HBILMINKBMD))]
	private static IEnumerable<PropertyInfo> EEJPGDAPKKL(Type MAHAMGBPDNB, HashSet<string> KBNIKJCIJBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x4D02640", Offset = "0x4D01040", VA = "0x184D02640")]
	public static IEnumerable<FieldInfo> NEOFGAAMDIF(this Type MAHAMGBPDNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x4D023C0", Offset = "0x4D00DC0", VA = "0x184D023C0")]
	[IteratorStateMachine(typeof(BPAGIBPCHKF))]
	private static IEnumerable<FieldInfo> JJIJMOFAAHD(Type MAHAMGBPDNB, HashSet<string> KBNIKJCIJBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal static class OCFCNECPHIP
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding INNKIKCHBAC;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class CAFLFCDLEEA
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE00", Offset = "0x7DE800", VA = "0x1807DFE00")]
	public static string JPCMKHFDFOB(string GECCBCJHLMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x4D05C00", Offset = "0x4D04600", VA = "0x184D05C00")]
	public static string ACLPBMEBDDB(string GECCBCJHLMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x4D05D10", Offset = "0x4D04710", VA = "0x184D05D10")]
	public static string OPHLPBBHAJF(string GECCBCJHLMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class IDGGJAMGONM<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private class GIHONKMDJGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type OKLKOGDIKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue ACPLDDIHALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int IBJPOPKEFFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public GIHONKMDJGD HIKMHHABHLP;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3128D60", Offset = "0x3127760", VA = "0x183128D60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3128C60", Offset = "0x3127660", VA = "0x183128C60")]
		private int HPEOPAJJAFB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public GIHONKMDJGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class OHPMCPBFHFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public OHPMCPBFHFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xCC7400", Offset = "0xCC5E00", VA = "0x180CC7400")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private GIHONKMDJGD[] GJNJJDFBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int HGBOOPNCHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object FKMLGMEMDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float NHBMGAOKCJN;

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x2214910", Offset = "0x2213310", VA = "0x182214910")]
	public IDGGJAMGONM(int ADCMDGEMNDH = 4, float NHBMGAOKCJN = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x2214710", Offset = "0x2213110", VA = "0x182214710")]
	public bool MMAIIPOKGMB(Type AJPNMLHDHNM, TValue MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x2214690", Offset = "0x2213090", VA = "0x182214690")]
	public bool MMAIIPOKGMB(Type AJPNMLHDHNM, Func<Type, TValue> MJILIBCJBHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x22139D0", Offset = "0x22123D0", VA = "0x1822139D0")]
	private bool FBMOOFONAPF(Type AJPNMLHDHNM, Func<Type, TValue> MJILIBCJBHN, out TValue IPPIIGBAMCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x2213E20", Offset = "0x2212820", VA = "0x182213E20")]
	private bool LKFNFOEBPBI(GIHONKMDJGD[] GJNJJDFBKKO, Type NGEMJENFKON, GIHONKMDJGD LKBAIEPGNOG, Func<Type, TValue> MJILIBCJBHN, out TValue IPPIIGBAMCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x2213580", Offset = "0x2211F80", VA = "0x182213580")]
	public bool CKMNFEFPOIP(Type AJPNMLHDHNM, out TValue MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x2213D40", Offset = "0x2212740", VA = "0x182213D40")]
	public TValue FGPIIJFONFI(Type AJPNMLHDHNM, Func<Type, TValue> MJILIBCJBHN)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x22136D0", Offset = "0x22120D0", VA = "0x1822136D0")]
	private static int EAACGHLPNHP(int JBGLKEHOKLH, float NHBMGAOKCJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2213DF0", Offset = "0x22127F0", VA = "0x182213DF0")]
	private static void HOFMFIALBEL(ref GIHONKMDJGD FMIKCCJGKCO, GIHONKMDJGD MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2213DF0", Offset = "0x22127F0", VA = "0x182213DF0")]
	private static void HOFMFIALBEL(ref GIHONKMDJGD[] FMIKCCJGKCO, GIHONKMDJGD[] MNIAGKNOHEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class LKACFIKFAMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder BBAJGABFEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder EBDBMAHDBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object HALNGEGGAPH;

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x53BAFE0", Offset = "0x53B99E0", VA = "0x1853BAFE0")]
	public TypeBuilder CNAIJLDJIMC(string ANJJEPIBAGI, TypeAttributes JDDIFDAEKHL, Type ELGBIOMPEHN, Type[] DMNBBBDIHCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x53BB0B0", Offset = "0x53B9AB0", VA = "0x1853BB0B0")]
	public LKACFIKFAMI(string IILDMMLDOAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal static class FHAGNDABGMN
{
	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B1C0", Offset = "0x4D09BC0", VA = "0x184D0B1C0")]
	private static MethodInfo JEPJKILKNIP(LambdaExpression ENDADPEPOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x273F980", Offset = "0x273E380", VA = "0x18273F980")]
	public static MethodInfo GINEDPBMKHE<T>(Expression<Func<T>> ENDADPEPOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x273F980", Offset = "0x273E380", VA = "0x18273F980")]
	public static MethodInfo GINEDPBMKHE<T, TR>(Expression<Func<T, TR>> ENDADPEPOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x273F980", Offset = "0x273E380", VA = "0x18273F980")]
	public static MethodInfo GINEDPBMKHE<T>(Expression<Action<T>> ENDADPEPOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x273F980", Offset = "0x273E380", VA = "0x18273F980")]
	public static MethodInfo GINEDPBMKHE<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> ENDADPEPOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x273F9F0", Offset = "0x273E3F0", VA = "0x18273F9F0")]
	private static MemberInfo MECJKPCFOOM<T>(Expression<T> MMPIIAHIKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x273F990", Offset = "0x273E390", VA = "0x18273F990")]
	public static PropertyInfo JGILEIGLCHM<T, TR>(Expression<Func<T, TR>> ENDADPEPOJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct FIGCPDMOHNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int ALJNHCKDPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool KBJHIJIEKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator NICPIDGMOCD;

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B570", Offset = "0x4D09F70", VA = "0x184D0B570")]
	public FIGCPDMOHNH(ILGenerator NICPIDGMOCD, int ALJNHCKDPKB, bool KBJHIJIEKJC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B4E0", Offset = "0x4D09EE0", VA = "0x184D0B4E0")]
	public FIGCPDMOHNH(ILGenerator NICPIDGMOCD, int ALJNHCKDPKB, Type MAHAMGBPDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B3C0", Offset = "0x4D09DC0", VA = "0x184D0B3C0")]
	public void NBIDEPGHHBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class ACJLGKKLAEA
{
	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x4D006D0", Offset = "0x4CFF0D0", VA = "0x184D006D0")]
	public static void IAPJEPHLOHB(this ILGenerator NICPIDGMOCD, int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4D00690", Offset = "0x4CFF090", VA = "0x184D00690")]
	public static void IAPJEPHLOHB(this ILGenerator NICPIDGMOCD, LocalBuilder KHEAKMKCEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4D00320", Offset = "0x4CFED20", VA = "0x184D00320")]
	public static void GOHEKHIBHGP(this ILGenerator NICPIDGMOCD, int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x4D00550", Offset = "0x4CFEF50", VA = "0x184D00550")]
	public static void GOHEKHIBHGP(this ILGenerator NICPIDGMOCD, LocalBuilder KHEAKMKCEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x4D001A0", Offset = "0x4CFEBA0", VA = "0x184D001A0")]
	public static void BJBGKKPCKIP(this ILGenerator NICPIDGMOCD, int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x4D00090", Offset = "0x4CFEA90", VA = "0x184D00090")]
	public static void BJBGKKPCKIP(this ILGenerator NICPIDGMOCD, LocalBuilder KHEAKMKCEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x4D00990", Offset = "0x4CFF390", VA = "0x184D00990")]
	public static void LBOAJGKPEMK(this ILGenerator NICPIDGMOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x4D01020", Offset = "0x4CFFA20", VA = "0x184D01020")]
	public static void NFMKCGGOAAE(this ILGenerator NICPIDGMOCD, bool MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x4D009A0", Offset = "0x4CFF3A0", VA = "0x184D009A0")]
	public static void LGLFMJBDDLF(this ILGenerator NICPIDGMOCD, int MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x4D01030", Offset = "0x4CFFA30", VA = "0x184D01030")]
	public static void NGHIEBFOFOL(this ILGenerator NICPIDGMOCD, Type MAHAMGBPDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x4D01210", Offset = "0x4CFFC10", VA = "0x184D01210")]
	public static void PCAMKFBOFCP(this ILGenerator NICPIDGMOCD, Type MAHAMGBPDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x4D00DF0", Offset = "0x4CFF7F0", VA = "0x184D00DF0")]
	public static void MGEAIDIHKNO(this ILGenerator NICPIDGMOCD, int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4D012C0", Offset = "0x4CFFCC0", VA = "0x184D012C0")]
	public static void PFKEJLDBJCA(this ILGenerator NICPIDGMOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x4D01120", Offset = "0x4CFFB20", VA = "0x184D01120")]
	public static void OGCJJAJKHHL(this ILGenerator NICPIDGMOCD, int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x4D00590", Offset = "0x4CFEF90", VA = "0x184D00590")]
	public static void HIGDHHGDENB(this ILGenerator NICPIDGMOCD, MethodInfo OMMEMGJEKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x4D00290", Offset = "0x4CFEC90", VA = "0x184D00290")]
	public static void FMHKDJOOACC(this ILGenerator NICPIDGMOCD, FieldInfo NMHFNLOFLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x4D00900", Offset = "0x4CFF300", VA = "0x184D00900")]
	public static void KGKCJMGNFMP(this ILGenerator NICPIDGMOCD, ulong MNIAGKNOHEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class JKKLHIONLJF
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class HJPIBMHKBDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public HJPIBMHKBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x52E7770", Offset = "0x52E6170", VA = "0x1852E7770")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo EJJMPLAHPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo LACOLFFMJJA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string AECGGMKOOEO
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6DFB30", VA = "0x1806E1130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string EDBGNCPJGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6E1140", Offset = "0x6DFB40", VA = "0x1806E1140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MEFONOJKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x4D17350", Offset = "0x4D15D50", VA = "0x184D17350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool GELDLGEJMNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3D0", Offset = "0x6DADD0", VA = "0x1806DC3D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7EEAF0", Offset = "0x7ED4F0", VA = "0x1807EEAF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool LOEBEAEBBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3E0", Offset = "0x6DADE0", VA = "0x1806DC3E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xC50310", Offset = "0xC4ED10", VA = "0x180C50310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type LMEMDFLMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7031C0", Offset = "0x701BC0", VA = "0x1807031C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo GJODMMFJGMB
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x759AE0", Offset = "0x7584E0", VA = "0x180759AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo LBLMKBMNKCF
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8570", Offset = "0x6C6F70", VA = "0x1806C8570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8590", Offset = "0x6C6F90", VA = "0x1806C8590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo EFEOBGDGOOB
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8580", Offset = "0x6C6F80", VA = "0x1806C8580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6C85A0", Offset = "0x6C6FA0", VA = "0x1806C85A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x4D17620", Offset = "0x4D16020", VA = "0x184D17620")]
	protected JKKLHIONLJF(Type MAHAMGBPDNB, string ANJJEPIBAGI, string MLMCPJPAMFK, bool GGCPEMANKDM, bool FMDLGEPGEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x4D17360", Offset = "0x4D15D60", VA = "0x184D17360")]
	public JKKLHIONLJF(FieldInfo BKNGKBHJGHC, string ANJJEPIBAGI, bool EOJNBAAOOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x4D17470", Offset = "0x4D15E70", VA = "0x184D17470")]
	public JKKLHIONLJF(PropertyInfo BKNGKBHJGHC, string ANJJEPIBAGI, bool EOJNBAAOOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4D171E0", Offset = "0x4D15BE0", VA = "0x184D171E0")]
	private static MethodInfo HDOKOGIPPCC(MemberInfo BKNGKBHJGHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x25BEE70", Offset = "0x25BD870", VA = "0x1825BEE70")]
	public T EOKFHBDFNOD<T>(bool LMLCLFDFAPF) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x4D17060", Offset = "0x4D15A60", VA = "0x184D17060", Slot = "4")]
	public virtual void ADCACHAJMOM(ILGenerator NICPIDGMOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x4D17120", Offset = "0x4D15B20", VA = "0x184D17120", Slot = "5")]
	public virtual void CGCHNGKMEDH(ILGenerator NICPIDGMOCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class BIODCIGKKPL : JKKLHIONLJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string ANAOOBPGOMK;

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x4D03C80", Offset = "0x4D02680", VA = "0x184D03C80")]
	public BIODCIGKKPL(string ANJJEPIBAGI, string ANAOOBPGOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x4D03B80", Offset = "0x4D02580", VA = "0x184D03B80", Slot = "4")]
	public override void ADCACHAJMOM(ILGenerator NICPIDGMOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x4D03C40", Offset = "0x4D02640", VA = "0x184D03C40", Slot = "5")]
	public override void CGCHNGKMEDH(ILGenerator NICPIDGMOCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class DPHEOGMJPDM : JKKLHIONLJF
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo PHECCACABIJ;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo ENKHPOBLLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal FIGCPDMOHNH KIEKOJIGJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal FIGCPDMOHNH IBOHNKMEDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal FIGCPDMOHNH JNEIAFLCFCM;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x4D07F50", Offset = "0x4D06950", VA = "0x184D07F50")]
	public DPHEOGMJPDM(string ANJJEPIBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x4D07700", Offset = "0x4D06100", VA = "0x184D07700", Slot = "4")]
	public override void ADCACHAJMOM(ILGenerator NICPIDGMOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x4D079C0", Offset = "0x4D063C0", VA = "0x184D079C0", Slot = "5")]
	public override void CGCHNGKMEDH(ILGenerator NICPIDGMOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x4D077D0", Offset = "0x4D061D0", VA = "0x184D077D0")]
	public void BMEIIHDNOKB(ILGenerator NICPIDGMOCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class MAIDJPBEJBH
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type LMEMDFLMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6DFB30", VA = "0x1806E1130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool KDPBPEDDKBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8D0", Offset = "0x6DA2D0", VA = "0x1806DB8D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6FD000", Offset = "0x6FBA00", VA = "0x1806FD000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool BNAEBJGOLCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xC1F7E0", Offset = "0xC1E1E0", VA = "0x180C1F7E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xC1F800", Offset = "0xC1E200", VA = "0x180C1F800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo DDKOPBFDDHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6C2130", Offset = "0x6C0B30", VA = "0x1806C2130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public JKKLHIONLJF[] HAIEDGLCCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7031C0", Offset = "0x701BC0", VA = "0x1807031C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public JKKLHIONLJF[] BDAMOADECGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x759AE0", Offset = "0x7584E0", VA = "0x180759AE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x53BD7C0", Offset = "0x53BC1C0", VA = "0x1853BD7C0")]
	public MAIDJPBEJBH(Type MAHAMGBPDNB, Func<string, string> NOPNIGLNBNK, bool EOJNBAAOOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x53BD6D0", Offset = "0x53BC0D0", VA = "0x1853BD6D0")]
	private static bool LMGAHOHPHKB(IEnumerator<ConstructorInfo> GHLNJNDNBJP, ref ConstructorInfo IHPAALIFDLL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct FIHCJIIMCLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong IOFOPGHCAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int NJOLKOHDHLL;

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x1FE45D0", Offset = "0x1FE2FD0", VA = "0x181FE45D0")]
	public FIHCJIIMCLA(ulong OEINJBDLJLM, int HDMOLIHDCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B6F0", Offset = "0x4D0A0F0", VA = "0x184D0B6F0")]
	public void LDDFBFOGKLP(ref FIHCJIIMCLA DFHJPOKNFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B5B0", Offset = "0x4D09FB0", VA = "0x184D0B5B0")]
	public static FIHCJIIMCLA AABGHNCPIPG(ref FIHCJIIMCLA PKEMCIANHMO, ref FIHCJIIMCLA DLAMIJMLOOE)
	{
		return default(FIHCJIIMCLA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B700", Offset = "0x4D0A100", VA = "0x184D0B700")]
	public void NEEJMPICNLC(ref FIHCJIIMCLA DFHJPOKNFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B5C0", Offset = "0x4D09FC0", VA = "0x184D0B5C0")]
	public static FIHCJIIMCLA GOIHEFJLMEH(ref FIHCJIIMCLA PKEMCIANHMO, ref FIHCJIIMCLA DLAMIJMLOOE)
	{
		return default(FIHCJIIMCLA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B660", Offset = "0x4D0A060", VA = "0x184D0B660")]
	public void KFDHNGNKFDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B6A0", Offset = "0x4D0A0A0", VA = "0x184D0B6A0")]
	public static FIHCJIIMCLA KFDHNGNKFDA(ref FIHCJIIMCLA PKEMCIANHMO)
	{
		return default(FIHCJIIMCLA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct BOLIIKNFFGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] DFIIPKJNKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int JFKBHBKKACD;

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7E1EB0", Offset = "0x7E08B0", VA = "0x1807E1EB0")]
	public BOLIIKNFFGK(byte[] DFIIPKJNKEL, int OAALNDIAAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x4D04910", Offset = "0x4D03310", VA = "0x184D04910")]
	public void LGHACCBFLBM(byte OMLJENAFGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x4D04720", Offset = "0x4D03120", VA = "0x184D04720")]
	public void GGONDMKFINC(byte[] OMLJENAFGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x4D047C0", Offset = "0x4D031C0", VA = "0x184D047C0")]
	public void HPGDOJMJBAL(byte[] OMLJENAFGNM, int KHNOOLPHJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x4D04860", Offset = "0x4D03260", VA = "0x184D04860")]
	public void HPGDOJMJBAL(byte[] OMLJENAFGNM, int AGNHLFMCFOJ, int KHNOOLPHJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x4D04970", Offset = "0x4D03370", VA = "0x184D04970")]
	public void LICAJJKBBFJ(byte LKLPGHLLEIM, int JOBJIONNEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x4D04620", Offset = "0x4D03020", VA = "0x184D04620")]
	public void EBFMAPNOKOH(string OMLJENAFGNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class GDIOBBLCAJN
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private enum ILDJNGKDMOK
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private enum PJBHJJEMALB
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum PMKBCMMBGFG
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
	private static byte[] HILHGMAMKKI;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] KIEADCFCKHG;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] NCBLJCJJNEJ;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] BCBMKBANBAL;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly PMKBCMMBGFG MNAKGHALNPP;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char GFIPJNFGDOP;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int NEGNNIEOAPJ;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int DMMFDCNHFLB;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] CJOFDEBKMHA;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x4D0CCC0", Offset = "0x4D0B6C0", VA = "0x184D0CCC0")]
	private static byte[] GJCEPHCDMFA(int HGBOOPNCHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x4D0C840", Offset = "0x4D0B240", VA = "0x184D0C840")]
	private static byte[] BLIMLBGBBKH(int HGBOOPNCHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x4D0D8B0", Offset = "0x4D0C2B0", VA = "0x184D0D8B0")]
	public static int KBBIEGIFNEJ(ref byte[] DFIIPKJNKEL, int JFKBHBKKACD, float MNIAGKNOHEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x4D0D790", Offset = "0x4D0C190", VA = "0x184D0D790")]
	public static int KBBIEGIFNEJ(ref byte[] DFIIPKJNKEL, int JFKBHBKKACD, double MNIAGKNOHEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x4D0C920", Offset = "0x4D0B320", VA = "0x184D0C920")]
	private static bool BLNPFDMMPNO(byte[] DFIIPKJNKEL, int KHNOOLPHJPF, ulong ALJNMGMCCJI, ulong NNFENEPBHKJ, ulong GFKJMJOENMM, ulong FMKIMICJACC, ulong HNLAADLCLJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x4D0C720", Offset = "0x4D0B120", VA = "0x184D0C720")]
	private static void BGOIJONIMMD(uint PCIIIDDBKKF, int MFHFEPLDGCI, out uint DFNLKCIKNLB, out int OKJFLAFEDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x4D0D140", Offset = "0x4D0BB40", VA = "0x184D0D140")]
	private static bool INHNDNLEEPE(FIHCJIIMCLA JMJGBNFIBFH, FIHCJIIMCLA FJOCGIOEKMK, FIHCJIIMCLA PNIIHINMIBM, byte[] DFIIPKJNKEL, out int KHNOOLPHJPF, out int KPJOGAFPODD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x4D0CDA0", Offset = "0x4D0B7A0", VA = "0x184D0CDA0")]
	private static bool GKOHHIFADFI(double ELMMBEILPIG, ILDJNGKDMOK HLAMMHNAHAB, byte[] DFIIPKJNKEL, out int KHNOOLPHJPF, out int IFIFAAKNJMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x4D0CBB0", Offset = "0x4D0B5B0", VA = "0x184D0CBB0")]
	private static bool CMMDBKMIHPJ(double ELMMBEILPIG, ILDJNGKDMOK HLAMMHNAHAB, byte[] DFIIPKJNKEL, out int KHNOOLPHJPF, out int CAMIJABMIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x4D0CA20", Offset = "0x4D0B420", VA = "0x184D0CA20")]
	private static bool CGMKMABIHFC(double MNIAGKNOHEJ, ref BOLIIKNFFGK IFKCOCCKBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x4D0D9D0", Offset = "0x4D0C3D0", VA = "0x184D0D9D0")]
	private static bool MCGMGHPBJDE(double MNIAGKNOHEJ, ref BOLIIKNFFGK IFKCOCCKBMI, PJBHJJEMALB HLAMMHNAHAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x4D0C250", Offset = "0x4D0AC50", VA = "0x184D0C250")]
	private static void BDHFFOGMICM(byte[] BNAMIIFDBBG, int KHNOOLPHJPF, int CAMIJABMIMO, int CELAGCFNEFE, ref BOLIIKNFFGK IFKCOCCKBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x4D0BD20", Offset = "0x4D0A720", VA = "0x184D0BD20")]
	private static void AJNCPGMEOGO(byte[] BNAMIIFDBBG, int KHNOOLPHJPF, int HDMOLIHDCNK, ref BOLIIKNFFGK IFKCOCCKBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x4D0D600", Offset = "0x4D0C000", VA = "0x184D0D600")]
	private static bool JAKLGKFFJFA(double ELMMBEILPIG, PJBHJJEMALB HLAMMHNAHAB, int JMIKJLEIJKP, byte[] DCLJOPAECKB, out bool HJIBBPJECBH, out int KHNOOLPHJPF, out int OMMEPJAJELH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal struct BOJIEDCEDIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double FLLMGCJHMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong BOBBAFDPBCC;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal struct EKDKIGGKDJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float IOFOPGHCAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint BPCLCOFMCHF;
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct AFHEFEFIOOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong DKCAKOHBDMO;

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x4D021C0", Offset = "0x4D00BC0", VA = "0x184D021C0")]
	public AFHEFEFIOOH(double FLLMGCJHMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4D021D0", Offset = "0x4D00BD0", VA = "0x184D021D0")]
	public AFHEFEFIOOH(FIHCJIIMCLA FLLMGCJHMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4D01C40", Offset = "0x4D00640", VA = "0x184D01C40")]
	public FIHCJIIMCLA CKBDNPDOBPA()
	{
		return default(FIHCJIIMCLA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x4D01F50", Offset = "0x4D00950", VA = "0x184D01F50")]
	public FIHCJIIMCLA GIOCLNGCGLM()
	{
		return default(FIHCJIIMCLA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6C1000", Offset = "0x6BFA00", VA = "0x1806C1000")]
	public ulong LLDKFHDLMCH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x4D02040", Offset = "0x4D00A40", VA = "0x184D02040")]
	public double KJKFNAGDCHG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4D02100", Offset = "0x4D00B00", VA = "0x184D02100")]
	public double OFMFCDHAOCO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x4D01CC0", Offset = "0x4D006C0", VA = "0x184D01CC0")]
	public int CKNGEBOAFEK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x4D01FE0", Offset = "0x4D009E0", VA = "0x184D01FE0")]
	public ulong HEFCPOPOFKI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4D01CF0", Offset = "0x4D006F0", VA = "0x184D01CF0")]
	public bool DEBLODFELCH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4D021A0", Offset = "0x4D00BA0", VA = "0x184D021A0")]
	public bool PONPLMHMEJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x4D02010", Offset = "0x4D00A10", VA = "0x184D02010")]
	public bool HOKJNNDLDAM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x4D01BF0", Offset = "0x4D005F0", VA = "0x184D01BF0")]
	public bool CBEAGPAGJLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x4D020D0", Offset = "0x4D00AD0", VA = "0x184D020D0")]
	public int LGKFFKPHMDL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x4D01E00", Offset = "0x4D00800", VA = "0x184D01E00")]
	public void GFAIGBDENED(out FIHCJIIMCLA CFKNPPFLFJD, out FIHCJIIMCLA EDJMKDGIDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x4D01DB0", Offset = "0x4D007B0", VA = "0x184D01DB0")]
	public bool FEHHGCGFFOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x4D020F0", Offset = "0x4D00AF0", VA = "0x184D020F0")]
	public double MNIAGKNOHEJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x4D01C20", Offset = "0x4D00620", VA = "0x184D01C20")]
	public static int CHKOPEKIOON(int KLHFOLMNGNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x4D02190", Offset = "0x4D00B90", VA = "0x184D02190")]
	public static double PCBPJKLMAAP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x4D01D10", Offset = "0x4D00710", VA = "0x184D01D10")]
	public static ulong DGFNNHJMJPA(FIHCJIIMCLA IKAGFJJAHCJ)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct GBDIOCJHOBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint OMDBCOICHME;

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9A20", Offset = "0x2EC8420", VA = "0x182EC9A20")]
	public GBDIOCJHOBJ(float IOFOPGHCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x4D0BA60", Offset = "0x4D0A460", VA = "0x184D0BA60")]
	public FIHCJIIMCLA CKBDNPDOBPA()
	{
		return default(FIHCJIIMCLA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x772E20", Offset = "0x771820", VA = "0x180772E20")]
	public uint NLPHEBFAJNM()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x4D0BAC0", Offset = "0x4D0A4C0", VA = "0x184D0BAC0")]
	public int CKNGEBOAFEK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x4D0BC60", Offset = "0x4D0A660", VA = "0x184D0BC60")]
	public uint HEFCPOPOFKI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x4D0BAE0", Offset = "0x4D0A4E0", VA = "0x184D0BAE0")]
	public bool DEBLODFELCH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x4D0BB30", Offset = "0x4D0A530", VA = "0x184D0BB30")]
	public void GFAIGBDENED(out FIHCJIIMCLA CFKNPPFLFJD, out FIHCJIIMCLA EDJMKDGIDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x4D0BAF0", Offset = "0x4D0A4F0", VA = "0x184D0BAF0")]
	public bool FEHHGCGFFOJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct PAMJNMMHAKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong OEINJBDLJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short JIFMENNKGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short IFIFAAKNJMK;

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x52F13A0", Offset = "0x52EFDA0", VA = "0x1852F13A0")]
	public PAMJNMMHAKD(ulong OEINJBDLJLM, short JIFMENNKGKA, short IFIFAAKNJMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal static class LLIHMCJNMFJ
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly PAMJNMMHAKD[] MKGFALCNDBP;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x53BB6D0", Offset = "0x53BA0D0", VA = "0x1853BB6D0")]
	public static void CGKGPOAIDEG(int HAAIJGIMHDE, int MPONLIBHDKK, out FIHCJIIMCLA DFNLKCIKNLB, out int IFIFAAKNJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x53BB810", Offset = "0x53BA210", VA = "0x1853BB810")]
	public static void CKJAPCOCLLD(int MFIJBLHMEEI, out FIHCJIIMCLA DFNLKCIKNLB, out int AOMNDCOICHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[DefaultMember("Item")]
internal struct KLCELMMPJNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] FMIGDHLBIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int AGNHLFMCFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int OBFFLOJIDGD;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x53B75E0", Offset = "0x53B5FE0", VA = "0x1853B75E0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0xC0DED0", Offset = "0xC0C8D0", VA = "0x180C0DED0")]
	public KLCELMMPJNO(byte[] FMIGDHLBIKP, int AGNHLFMCFOJ, int KHNOOLPHJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7DB340", Offset = "0x7D9D40", VA = "0x1807DB340")]
	public int KHNOOLPHJPF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x53B7620", Offset = "0x53B6020", VA = "0x1853B7620")]
	public KLCELMMPJNO CNECBKDKANF(int KJCIFPEICMG, int BBPFPCFMEIH)
	{
		return default(KLCELMMPJNO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal static class OFADINBOHDM
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] PFBOHIDONIP;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] JLJCAAPNNIN;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int EALBPPPALPM;

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x52EE260", Offset = "0x52ECC60", VA = "0x1852EE260")]
	private static byte[] EOHLNKPKDEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x52EDA90", Offset = "0x52EC490", VA = "0x1852EDA90")]
	private static KLCELMMPJNO CGNDIMHKJEH(KLCELMMPJNO DFIIPKJNKEL)
	{
		return default(KLCELMMPJNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x52ED740", Offset = "0x52EC140", VA = "0x1852ED740")]
	private static KLCELMMPJNO AGAFEEEBPBC(KLCELMMPJNO DFIIPKJNKEL)
	{
		return default(KLCELMMPJNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x52EEA50", Offset = "0x52ED450", VA = "0x1852EEA50")]
	private static void HNEEDKJFIPP(KLCELMMPJNO DFIIPKJNKEL, int HDMOLIHDCNK, byte[] IHPDGPDHKOP, out int IGCLHIBACDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x52ED7F0", Offset = "0x52EC1F0", VA = "0x1852ED7F0")]
	private static void BHBAMPJGDAJ(KLCELMMPJNO DFIIPKJNKEL, int HDMOLIHDCNK, byte[] FKHLDHPBBLL, int OGKMFOFMFNK, out KLCELMMPJNO GEAJOMABCNG, out int NAFEJKMBDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x52EE9C0", Offset = "0x52ED3C0", VA = "0x1852EE9C0")]
	private static ulong GEILLLHHOGP(KLCELMMPJNO DFIIPKJNKEL, out int HNNFEMFNPIK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x52EDB40", Offset = "0x52EC540", VA = "0x1852EDB40")]
	private static void CPAFKGFJBMI(KLCELMMPJNO DFIIPKJNKEL, out FIHCJIIMCLA OAFMFLFMLNI, out int IHFIBCEAKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x52EDC90", Offset = "0x52EC690", VA = "0x1852EDC90")]
	private static bool CPBJDMCLHKN(KLCELMMPJNO GEAJOMABCNG, int HDMOLIHDCNK, out double OAFMFLFMLNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x52EE350", Offset = "0x52ECD50", VA = "0x1852EE350")]
	private static FIHCJIIMCLA FNOECCAMDMC(int HDMOLIHDCNK)
	{
		return default(FIHCJIIMCLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x52EE500", Offset = "0x52ECF00", VA = "0x1852EE500")]
	private static bool GBEENPMIJJL(KLCELMMPJNO DFIIPKJNKEL, int HDMOLIHDCNK, out double OAFMFLFMLNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x52EEB10", Offset = "0x52ED510", VA = "0x1852EEB10")]
	private static bool PAJILBAKNGE(KLCELMMPJNO GEAJOMABCNG, int HDMOLIHDCNK, out double PBJCKKBOEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x52EEC50", Offset = "0x52ED650", VA = "0x1852EEC50")]
	public static double? PCIPKEOMIPG(KLCELMMPJNO DFIIPKJNKEL, int HDMOLIHDCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x52EE080", Offset = "0x52ECA80", VA = "0x1852EE080")]
	public static float? EIKPODDLPKJ(KLCELMMPJNO DFIIPKJNKEL, int HDMOLIHDCNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct POKLCHBCLHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] DFIIPKJNKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int JFKBHBKKACD;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte ACPLDDIHALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x52F3C70", Offset = "0x52F2670", VA = "0x1852F3C70")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7E1EB0", Offset = "0x7E08B0", VA = "0x1807E1EB0")]
	public POKLCHBCLHE(byte[] DFIIPKJNKEL, int JFKBHBKKACD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x52F3B00", Offset = "0x52F2500", VA = "0x1852F3B00")]
	public static POKLCHBCLHE CKLMDFGFFIE(POKLCHBCLHE DCIIOIKIJFP)
	{
		return default(POKLCHBCLHE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x52F3B10", Offset = "0x52F2510", VA = "0x1852F3B10")]
	public static POKLCHBCLHE GAMHLIOKLMA(POKLCHBCLHE DCIIOIKIJFP, int KHNOOLPHJPF)
	{
		return default(POKLCHBCLHE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x52F3D20", Offset = "0x52F2720", VA = "0x1852F3D20")]
	public static int PBCOCCEPJGF(POKLCHBCLHE CIEDPJMPBGL, POKLCHBCLHE FAJJLJONDOF)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x52F3D00", Offset = "0x52F2700", VA = "0x1852F3D00")]
	public static bool NENBKMMGKMN(POKLCHBCLHE CIEDPJMPBGL, POKLCHBCLHE FAJJLJONDOF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x52F3C50", Offset = "0x52F2650", VA = "0x1852F3C50")]
	public static bool HCCIHOFGPHE(POKLCHBCLHE CIEDPJMPBGL, POKLCHBCLHE FAJJLJONDOF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x52F3CB0", Offset = "0x52F26B0", VA = "0x1852F3CB0")]
	public static bool NENBKMMGKMN(POKLCHBCLHE CIEDPJMPBGL, char FAJJLJONDOF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x52F3C00", Offset = "0x52F2600", VA = "0x1852F3C00")]
	public static bool HCCIHOFGPHE(POKLCHBCLHE CIEDPJMPBGL, char FAJJLJONDOF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x52F3C00", Offset = "0x52F2600", VA = "0x1852F3C00")]
	public static bool HCCIHOFGPHE(POKLCHBCLHE CIEDPJMPBGL, byte FAJJLJONDOF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x52F3AB0", Offset = "0x52F24B0", VA = "0x1852F3AB0")]
	public static bool BBLIGMBECEK(POKLCHBCLHE CIEDPJMPBGL, char FAJJLJONDOF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x52F3BB0", Offset = "0x52F25B0", VA = "0x1852F3BB0")]
	public static bool GPEGLIKKMJE(POKLCHBCLHE CIEDPJMPBGL, char FAJJLJONDOF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x52F3B60", Offset = "0x52F2560", VA = "0x1852F3B60")]
	public static bool GMHJBIPPGPM(POKLCHBCLHE CIEDPJMPBGL, char FAJJLJONDOF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x52F3A60", Offset = "0x52F2460", VA = "0x1852F3A60")]
	public static bool AGAPNDLJPCM(POKLCHBCLHE CIEDPJMPBGL, char FAJJLJONDOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class GDPOCKFHKBJ
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] ICHBKOOPKMA;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] PJKJJNPNFPB;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] NCBLJCJJNEJ;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] BCBMKBANBAL;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] NNGOPGFGNGD;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int ILLGMOCMDEC;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] HBOLINEICBD;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int DGKJKBILMLM;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x4D0E470", Offset = "0x4D0CE70", VA = "0x184D0E470")]
	private static byte[] DLLNMKCAGGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x4D0E560", Offset = "0x4D0CF60", VA = "0x184D0E560")]
	private static byte[] JKMDGDJKPJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x4D0E240", Offset = "0x4D0CC40", VA = "0x184D0E240")]
	public static double AFNBGMDEGMF(byte[] DFIIPKJNKEL, int JFKBHBKKACD, out int CLMNOEGMEHE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x4D0E650", Offset = "0x4D0D050", VA = "0x184D0E650")]
	public static float KLDBEELAGOP(byte[] DFIIPKJNKEL, int JFKBHBKKACD, out int CLMNOEGMEHE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x4D0E2F0", Offset = "0x4D0CCF0", VA = "0x184D0E2F0")]
	private static bool CEJLEHGJGMF(int MEALLDFELFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x4D0E710", Offset = "0x4D0D110", VA = "0x184D0E710")]
	private static bool LCGNBALKKAK(ref POKLCHBCLHE AIAOJCAJMCP, POKLCHBCLHE PGDLDMBJJEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x4D0E870", Offset = "0x4D0D270", VA = "0x184D0E870")]
	private static bool LNIOGMCOAHN(ref POKLCHBCLHE AIAOJCAJMCP, POKLCHBCLHE PGDLDMBJJEP, byte[] BKEOBJFEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x4D0E820", Offset = "0x4D0D220", VA = "0x184D0E820")]
	private static bool LNIDPFMKKPC(ref POKLCHBCLHE HFDAOFFGGPH, byte[] OMLJENAFGNM, int JFKBHBKKACD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x4D0E980", Offset = "0x4D0D380", VA = "0x184D0E980")]
	private static double OPLKLKCLKKP(bool HJIBBPJECBH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x4D0E9A0", Offset = "0x4D0D3A0", VA = "0x184D0E9A0")]
	private static double PFPPHDIBHFB(POKLCHBCLHE CAADCBIMIIP, int KHNOOLPHJPF, bool HAIKELFJHAO, out int NEGIAHJEGAF)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class EJBLHCDEGOC<T> : global::MMFDCMJAOJA<T[]>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly global::EGBHIGBHKHD<T> KMHFGCCOLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly JDFHGBIEECI JECBNHGNNFK;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x243A4F0", Offset = "0x2438EF0", VA = "0x18243A4F0")]
	public EJBLHCDEGOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x1D687B0", Offset = "0x1D671B0", VA = "0x181D687B0")]
	public EJBLHCDEGOC(JDFHGBIEECI JECBNHGNNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2439F90", Offset = "0x2438990", VA = "0x182439F90", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, T[] MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x24384C0", Offset = "0x2436EC0", VA = "0x1824384C0", Slot = "5")]
	public T[] AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class OINPBNADBPG<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly global::EGBHIGBHKHD<T> KMHFGCCOLBA;
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class KDMDCFKOFJE<T> : global::MMFDCMJAOJA<List<T>>, DHGBFBDHANB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly JDFHGBIEECI JECBNHGNNFK;

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x243A4F0", Offset = "0x2438EF0", VA = "0x18243A4F0")]
	public KDMDCFKOFJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x1D687B0", Offset = "0x1D671B0", VA = "0x181D687B0")]
	public KDMDCFKOFJE(JDFHGBIEECI JECBNHGNNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x3109940", Offset = "0x3108340", VA = "0x183109940", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, List<T> MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x3108FB0", Offset = "0x31079B0", VA = "0x183108FB0", Slot = "5")]
	public List<T> AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public abstract class NKCKGJECKKM<TElement, TIntermediate, TEnumerator, TCollection> : global::MMFDCMJAOJA<TCollection>, DHGBFBDHANB where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x231A100", Offset = "0x2318B00", VA = "0x18231A100", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, TCollection MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2318AE0", Offset = "0x23174E0", VA = "0x182318AE0", Slot = "5")]
	public TCollection AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator KLGGKIIFINN(TCollection MMPIIAHIKHE);

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate GANMJPNFBJN();

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void CPLOAHMOJFD(ref TIntermediate JBEHLAHMLFK, int GFDMFLGCBKB, TElement MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection MILDGAMNMFE(ref TIntermediate PDHEGMLBNBA);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
	protected NKCKGJECKKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class AFCCNPPIKLG<TElement, TIntermediate, TCollection> : global::NKCKGJECKKM<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x311A060", Offset = "0x3118A60", VA = "0x18311A060", Slot = "6")]
	protected override IEnumerator<TElement> KLGGKIIFINN(TCollection MMPIIAHIKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2435F60", Offset = "0x2434960", VA = "0x182435F60")]
	protected AFCCNPPIKLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class DODHEAAEIDC<TElement, TCollection> : global::AFCCNPPIKLG<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x10E4B30", Offset = "0x10E3530", VA = "0x1810E4B30", Slot = "9")]
	protected sealed override TCollection MILDGAMNMFE(ref TCollection PDHEGMLBNBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class DGIPLAODBGE<TElement, TCollection> : global::DODHEAAEIDC<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2595AD0", Offset = "0x25944D0", VA = "0x182595AD0", Slot = "7")]
	protected override TCollection GANMJPNFBJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x25959F0", Offset = "0x25943F0", VA = "0x1825959F0", Slot = "8")]
	protected override void CPLOAHMOJFD(ref TCollection JBEHLAHMLFK, int GFDMFLGCBKB, TElement MNIAGKNOHEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class OELFJLGMGGK<T> : global::NKCKGJECKKM<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x23AFAC0", Offset = "0x23AE4C0", VA = "0x1823AFAC0", Slot = "8")]
	protected override void CPLOAHMOJFD(ref LinkedList<T> JBEHLAHMLFK, int GFDMFLGCBKB, T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x10E4B30", Offset = "0x10E3530", VA = "0x1810E4B30", Slot = "9")]
	protected override LinkedList<T> MILDGAMNMFE(ref LinkedList<T> PDHEGMLBNBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x23AFB00", Offset = "0x23AE500", VA = "0x1823AFB00", Slot = "7")]
	protected override LinkedList<T> GANMJPNFBJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x25924D0", Offset = "0x2590ED0", VA = "0x1825924D0", Slot = "6")]
	protected override LinkedList<T>.Enumerator KLGGKIIFINN(LinkedList<T> MMPIIAHIKHE)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class AKMEPPPJFKO<T> : global::NKCKGJECKKM<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x23AFAC0", Offset = "0x23AE4C0", VA = "0x1823AFAC0", Slot = "8")]
	protected override void CPLOAHMOJFD(ref Queue<T> JBEHLAHMLFK, int GFDMFLGCBKB, T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x23AFB00", Offset = "0x23AE500", VA = "0x1823AFB00", Slot = "7")]
	protected override Queue<T> GANMJPNFBJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x230AE00", Offset = "0x2309800", VA = "0x18230AE00", Slot = "6")]
	protected override Queue<T>.Enumerator KLGGKIIFINN(Queue<T> MMPIIAHIKHE)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x10E4B30", Offset = "0x10E3530", VA = "0x1810E4B30", Slot = "9")]
	protected override Queue<T> MILDGAMNMFE(ref Queue<T> PDHEGMLBNBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class NGDBKMMFLDI<T> : global::NKCKGJECKKM<T, global::CIDIOMLJFEN<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x17A10F0", Offset = "0x179FAF0", VA = "0x1817A10F0", Slot = "8")]
	protected override void CPLOAHMOJFD(ref global::CIDIOMLJFEN<T> JBEHLAHMLFK, int GFDMFLGCBKB, T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x17A1120", Offset = "0x179FB20", VA = "0x1817A1120", Slot = "7")]
	protected override global::CIDIOMLJFEN<T> GANMJPNFBJN()
	{
		return default(global::CIDIOMLJFEN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x230AE00", Offset = "0x2309800", VA = "0x18230AE00", Slot = "6")]
	protected override Stack<T>.Enumerator KLGGKIIFINN(Stack<T> MMPIIAHIKHE)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x230AE50", Offset = "0x2309850", VA = "0x18230AE50", Slot = "9")]
	protected override Stack<T> MILDGAMNMFE(ref global::CIDIOMLJFEN<T> PDHEGMLBNBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class CMPHIAEHPLM<T> : global::NKCKGJECKKM<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x23AFAC0", Offset = "0x23AE4C0", VA = "0x1823AFAC0", Slot = "8")]
	protected override void CPLOAHMOJFD(ref HashSet<T> JBEHLAHMLFK, int GFDMFLGCBKB, T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x10E4B30", Offset = "0x10E3530", VA = "0x1810E4B30", Slot = "9")]
	protected override HashSet<T> MILDGAMNMFE(ref HashSet<T> PDHEGMLBNBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x23AFB00", Offset = "0x23AE500", VA = "0x1823AFB00", Slot = "7")]
	protected override HashSet<T> GANMJPNFBJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x230AE00", Offset = "0x2309800", VA = "0x18230AE00", Slot = "6")]
	protected override HashSet<T>.Enumerator KLGGKIIFINN(HashSet<T> MMPIIAHIKHE)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class NLOFNKOEFBN<T> : global::AFCCNPPIKLG<T, global::CIDIOMLJFEN<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x17A10F0", Offset = "0x179FAF0", VA = "0x1817A10F0", Slot = "8")]
	protected override void CPLOAHMOJFD(ref global::CIDIOMLJFEN<T> JBEHLAHMLFK, int GFDMFLGCBKB, T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x231A540", Offset = "0x2318F40", VA = "0x18231A540", Slot = "9")]
	protected override ReadOnlyCollection<T> MILDGAMNMFE(ref global::CIDIOMLJFEN<T> PDHEGMLBNBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x231A500", Offset = "0x2318F00", VA = "0x18231A500", Slot = "7")]
	protected override global::CIDIOMLJFEN<T> GANMJPNFBJN()
	{
		return default(global::CIDIOMLJFEN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class FNEGEMGKBDC<T> : global::AFCCNPPIKLG<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x23AFAC0", Offset = "0x23AE4C0", VA = "0x1823AFAC0", Slot = "8")]
	protected override void CPLOAHMOJFD(ref List<T> JBEHLAHMLFK, int GFDMFLGCBKB, T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x23AFB00", Offset = "0x23AE500", VA = "0x1823AFB00", Slot = "7")]
	protected override List<T> GANMJPNFBJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x10E4B30", Offset = "0x10E3530", VA = "0x1810E4B30", Slot = "9")]
	protected override IList<T> MILDGAMNMFE(ref List<T> PDHEGMLBNBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class IPNLHDDFNAI<T> : global::AFCCNPPIKLG<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x23AFAC0", Offset = "0x23AE4C0", VA = "0x1823AFAC0", Slot = "8")]
	protected override void CPLOAHMOJFD(ref List<T> JBEHLAHMLFK, int GFDMFLGCBKB, T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x23AFB00", Offset = "0x23AE500", VA = "0x1823AFB00", Slot = "7")]
	protected override List<T> GANMJPNFBJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x10E4B30", Offset = "0x10E3530", VA = "0x1810E4B30", Slot = "9")]
	protected override ICollection<T> MILDGAMNMFE(ref List<T> PDHEGMLBNBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class EOHHBBBJCGD<T> : global::AFCCNPPIKLG<T, global::CIDIOMLJFEN<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x17A10F0", Offset = "0x179FAF0", VA = "0x1817A10F0", Slot = "8")]
	protected override void CPLOAHMOJFD(ref global::CIDIOMLJFEN<T> JBEHLAHMLFK, int GFDMFLGCBKB, T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x17A1120", Offset = "0x179FB20", VA = "0x1817A1120", Slot = "7")]
	protected override global::CIDIOMLJFEN<T> GANMJPNFBJN()
	{
		return default(global::CIDIOMLJFEN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x17A1160", Offset = "0x179FB60", VA = "0x1817A1160", Slot = "9")]
	protected override IEnumerable<T> MILDGAMNMFE(ref global::CIDIOMLJFEN<T> PDHEGMLBNBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class EDLDCMNLIAN<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class GELMGGCDDGL<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class PIJDHJCHMPG<T> : global::MMFDCMJAOJA<T>, DHGBFBDHANB where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x314C950", Offset = "0x314B350", VA = "0x18314C950", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, T MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x314C740", Offset = "0x314B140", VA = "0x18314C740", Slot = "5")]
	public T AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
	public PIJDHJCHMPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class JOPLPFJOFKG : global::MMFDCMJAOJA<IEnumerable>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::MMFDCMJAOJA<IEnumerable> JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x53B2EE0", Offset = "0x53B18E0", VA = "0x1853B2EE0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, IEnumerable MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x53B2C50", Offset = "0x53B1650", VA = "0x1853B2C50", Slot = "5")]
	public IEnumerable AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public JOPLPFJOFKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class HOFICLDCMOP : global::MMFDCMJAOJA<ICollection>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	public static readonly global::MMFDCMJAOJA<ICollection> JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x4D14BF0", Offset = "0x4D135F0", VA = "0x184D14BF0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, ICollection MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x4D14A40", Offset = "0x4D13440", VA = "0x184D14A40", Slot = "5")]
	public ICollection AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public HOFICLDCMOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class KPBOLDFEKPC : global::MMFDCMJAOJA<IList>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::MMFDCMJAOJA<IList> JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x53B8240", Offset = "0x53B6C40", VA = "0x1853B8240", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, IList MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x53B7FB0", Offset = "0x53B69B0", VA = "0x1853B7FB0", Slot = "5")]
	public IList AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KPBOLDFEKPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class MHPFJOFFBDM<T> : global::AFCCNPPIKLG<T, global::CIDIOMLJFEN<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x2B18D60", Offset = "0x2B17760", VA = "0x182B18D60", Slot = "8")]
	protected override void CPLOAHMOJFD(ref global::CIDIOMLJFEN<T> JBEHLAHMLFK, int GFDMFLGCBKB, T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x17A1120", Offset = "0x179FB20", VA = "0x1817A1120", Slot = "7")]
	protected override global::CIDIOMLJFEN<T> GANMJPNFBJN()
	{
		return default(global::CIDIOMLJFEN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x2B18DC0", Offset = "0x2B177C0", VA = "0x182B18DC0", Slot = "9")]
	protected override IReadOnlyList<T> MILDGAMNMFE(ref global::CIDIOMLJFEN<T> PDHEGMLBNBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x1FEAF70", Offset = "0x1FE9970", VA = "0x181FEAF70")]
	public MHPFJOFFBDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public static class GBDPJOPEKPE
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x4D0BC80", Offset = "0x4D0A680", VA = "0x184D0BC80")]
	public static DateTime NIDCNDGNPEB(DateTime OEOMCLKIOPH)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class NPOFNHHNBPE : global::MMFDCMJAOJA<DateTime>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly global::MMFDCMJAOJA<DateTime> JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x52ECD30", Offset = "0x52EB730", VA = "0x1852ECD30", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, DateTime MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x52EBDD0", Offset = "0x52EA7D0", VA = "0x1852EBDD0", Slot = "5")]
	public DateTime AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public NPOFNHHNBPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class JPHDFMGAEHJ : global::MMFDCMJAOJA<DateTimeOffset>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly global::MMFDCMJAOJA<DateTimeOffset> JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x53B40F0", Offset = "0x53B2AF0", VA = "0x1853B40F0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, DateTimeOffset MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x53B31B0", Offset = "0x53B1BB0", VA = "0x1853B31B0", Slot = "5")]
	public DateTimeOffset AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public JPHDFMGAEHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class HBNEMFODCEE : global::MMFDCMJAOJA<TimeSpan>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly global::MMFDCMJAOJA<TimeSpan> JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static byte[] EMCFNAHELIE;

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x4D13F80", Offset = "0x4D12980", VA = "0x184D13F80", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, TimeSpan MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x4D136C0", Offset = "0x4D120C0", VA = "0x184D136C0", Slot = "5")]
	public TimeSpan AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public HBNEMFODCEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public abstract class OLAGEHGCKGE<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::MMFDCMJAOJA<TDictionary>, DHGBFBDHANB where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2EB7D30", Offset = "0x2EB6730", VA = "0x182EB7D30", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, TDictionary MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2EB52C0", Offset = "0x2EB3CC0", VA = "0x182EB52C0", Slot = "5")]
	public TDictionary AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator KLGGKIIFINN(TDictionary MMPIIAHIKHE);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate GANMJPNFBJN();

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void CPLOAHMOJFD(ref TIntermediate JBEHLAHMLFK, int GFDMFLGCBKB, TKey AJPNMLHDHNM, TValue MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary MILDGAMNMFE(ref TIntermediate PDHEGMLBNBA);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
	protected OLAGEHGCKGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public abstract class KJOBGOILPCE<TKey, TValue, TIntermediate, TDictionary> : global::OLAGEHGCKGE<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x311A060", Offset = "0x3118A60", VA = "0x18311A060", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> KLGGKIIFINN(TDictionary MMPIIAHIKHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public abstract class INOJDHKIDLK<TKey, TValue, TDictionary> : global::KJOBGOILPCE<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x10E4B30", Offset = "0x10E3530", VA = "0x1810E4B30", Slot = "9")]
	protected override TDictionary MILDGAMNMFE(ref TDictionary PDHEGMLBNBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class DDPOAEJHIEF<TKey, TValue> : global::OLAGEHGCKGE<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2592490", Offset = "0x2590E90", VA = "0x182592490", Slot = "8")]
	protected override void CPLOAHMOJFD(ref Dictionary<TKey, TValue> JBEHLAHMLFK, int GFDMFLGCBKB, TKey AJPNMLHDHNM, TValue MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x10E4B30", Offset = "0x10E3530", VA = "0x1810E4B30", Slot = "9")]
	protected override Dictionary<TKey, TValue> MILDGAMNMFE(ref Dictionary<TKey, TValue> PDHEGMLBNBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x23AFB00", Offset = "0x23AE500", VA = "0x1823AFB00", Slot = "7")]
	protected override Dictionary<TKey, TValue> GANMJPNFBJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2592530", Offset = "0x2590F30", VA = "0x182592530", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator KLGGKIIFINN(Dictionary<TKey, TValue> MMPIIAHIKHE)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0xF630F0", Offset = "0xF61AF0", VA = "0x180F630F0")]
	public DDPOAEJHIEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public sealed class ADJNFDKEEIH<TKey, TValue, TDictionary> : global::INOJDHKIDLK<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x35A7130", Offset = "0x35A5B30", VA = "0x1835A7130", Slot = "8")]
	protected override void CPLOAHMOJFD(ref TDictionary JBEHLAHMLFK, int GFDMFLGCBKB, TKey AJPNMLHDHNM, TValue MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x1D6E630", Offset = "0x1D6D030", VA = "0x181D6E630", Slot = "7")]
	protected override TDictionary GANMJPNFBJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public sealed class PBOGKAPJLPP<TKey, TValue> : global::KJOBGOILPCE<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x24E4560", Offset = "0x24E2F60", VA = "0x1824E4560", Slot = "8")]
	protected override void CPLOAHMOJFD(ref Dictionary<TKey, TValue> JBEHLAHMLFK, int GFDMFLGCBKB, TKey AJPNMLHDHNM, TValue MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x23AFB00", Offset = "0x23AE500", VA = "0x1823AFB00", Slot = "7")]
	protected override Dictionary<TKey, TValue> GANMJPNFBJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x10E4B30", Offset = "0x10E3530", VA = "0x1810E4B30", Slot = "9")]
	protected override IDictionary<TKey, TValue> MILDGAMNMFE(ref Dictionary<TKey, TValue> PDHEGMLBNBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class JMOPOBECJDN<TKey, TValue> : global::INOJDHKIDLK<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x24E4560", Offset = "0x24E2F60", VA = "0x1824E4560", Slot = "8")]
	protected override void CPLOAHMOJFD(ref SortedList<TKey, TValue> JBEHLAHMLFK, int GFDMFLGCBKB, TKey AJPNMLHDHNM, TValue MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x23AFB00", Offset = "0x23AE500", VA = "0x1823AFB00", Slot = "7")]
	protected override SortedList<TKey, TValue> GANMJPNFBJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class CKFLAKEFPIA<TKey, TValue> : global::OLAGEHGCKGE<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x24E4560", Offset = "0x24E2F60", VA = "0x1824E4560", Slot = "8")]
	protected override void CPLOAHMOJFD(ref SortedDictionary<TKey, TValue> JBEHLAHMLFK, int GFDMFLGCBKB, TKey AJPNMLHDHNM, TValue MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x10E4B30", Offset = "0x10E3530", VA = "0x1810E4B30", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> MILDGAMNMFE(ref SortedDictionary<TKey, TValue> PDHEGMLBNBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x23AFB00", Offset = "0x23AE500", VA = "0x1823AFB00", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> GANMJPNFBJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x24E45A0", Offset = "0x24E2FA0", VA = "0x1824E45A0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator KLGGKIIFINN(SortedDictionary<TKey, TValue> MMPIIAHIKHE)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class ELMJCANBAIF<T> : global::MMFDCMJAOJA<T>, DHGBFBDHANB where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x243F680", Offset = "0x243E080", VA = "0x18243F680", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, T MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x243F450", Offset = "0x243DE50", VA = "0x18243F450", Slot = "5")]
	public T AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
	public ELMJCANBAIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class BFHBNHKONJC : global::MMFDCMJAOJA<IDictionary>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly global::MMFDCMJAOJA<IDictionary> JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x4D034C0", Offset = "0x4D01EC0", VA = "0x184D034C0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, IDictionary MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x4D032F0", Offset = "0x4D01CF0", VA = "0x184D032F0", Slot = "5")]
	public IDictionary AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public BFHBNHKONJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class PFNLHDLHCOD : global::MMFDCMJAOJA<object>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private delegate void HDAGIELHPGC(object EINLGGGPEEI, ref KBHFHFFPFEJ LHGJJBFKNCG, object MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly global::IDGGJAMGONM<KeyValuePair<object, HDAGIELHPGC>> NMBOIKOFMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly HEOIHOEGOKA[] HAEPBNOPABD;

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x52F21E0", Offset = "0x52F0BE0", VA = "0x1852F21E0")]
	public PFNLHDLHCOD(params HEOIHOEGOKA[] HAEPBNOPABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x52F1800", Offset = "0x52F0200", VA = "0x1852F1800", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, object MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x52F1760", Offset = "0x52F0160", VA = "0x1852F1760", Slot = "5")]
	public object AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public static class HPGMKMIHNFG
{
	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x4D15830", Offset = "0x4D14230", VA = "0x184D15830")]
	public static object FFDCAINPENH(Type MAHAMGBPDNB, out bool GAPHKDGEHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x4D14F10", Offset = "0x4D13910", VA = "0x184D14F10")]
	public static object ENKJOIFPDCN(Type MAHAMGBPDNB, out bool GAPHKDGEHLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public class BIHOLCGOCJA<T> : global::MMFDCMJAOJA<T>, DHGBFBDHANB, global::IFPGMOGFAMI<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class BNBOCEEJGJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public BNBOCEEJGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x270A8E0", Offset = "0x27092E0", VA = "0x18270A8E0")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class KNBJNILHJLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public global::ONPFKBKFLPP<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public KNBJNILHJLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x31233B0", Offset = "0x3121DB0", VA = "0x1831233B0")]
		internal void <.cctor>b__1(ref KBHFHFFPFEJ writer, T value, HEOIHOEGOKA _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class GJMLBLDCJPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public global::DDLFGJOMMMC<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public GJMLBLDCJPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x312D420", Offset = "0x312BE20", VA = "0x18312D420")]
		internal T <.cctor>b__2(ref NIGKCAJBBED reader, HEOIHOEGOKA _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static readonly global::KDLJMIMKEDI<T> CHKMIAOJGLJ;

	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private static readonly Dictionary<T, string> OCIJKPJOEAE;

	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private static readonly global::ONPFKBKFLPP<T> CJLALFFNAKK;

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly global::DDLFGJOMMMC<T> MLHKBGAJGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private readonly bool PBMKCELHKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private readonly global::ONPFKBKFLPP<T> LLNHDILOMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::DDLFGJOMMMC<T> GOKJFICKLED;

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x3E7DEC0", Offset = "0x3E7C8C0", VA = "0x183E7DEC0")]
	static BIHOLCGOCJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x31863F0", Offset = "0x3184DF0", VA = "0x1831863F0")]
	public BIHOLCGOCJA(bool PBMKCELHKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C4E0", Offset = "0x3E7AEE0", VA = "0x183E7C4E0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, T MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3E74CC0", Offset = "0x3E736C0", VA = "0x183E74CC0", Slot = "5")]
	public T AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CDE0", Offset = "0x3E7B7E0", VA = "0x183E7CDE0", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, T MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3E78320", Offset = "0x3E76D20", VA = "0x183E78320", Slot = "7")]
	public T EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class DHAIEJOBKJA<T> : global::MMFDCMJAOJA<T[,]>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x2595E70", Offset = "0x2594870", VA = "0x182595E70", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, T[,] MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x2595BA0", Offset = "0x25945A0", VA = "0x182595BA0", Slot = "5")]
	public T[,] AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
	public DHAIEJOBKJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class CKCEILEIPLO<T> : global::MMFDCMJAOJA<T[,,]>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x24E4350", Offset = "0x24E2D50", VA = "0x1824E4350", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, T[,,] MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x24E3F30", Offset = "0x24E2930", VA = "0x1824E3F30", Slot = "5")]
	public T[,,] AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
	public CKCEILEIPLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class MDLLAIHFJGI<T> : global::MMFDCMJAOJA<T[,,,]>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x37BF790", Offset = "0x37BE190", VA = "0x1837BF790", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, T[,,,] MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x37BF290", Offset = "0x37BDC90", VA = "0x1837BF290", Slot = "5")]
	public T[,,,] AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
	public MDLLAIHFJGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class ECEKNLMNHNB<T> : global::MMFDCMJAOJA<T?>, DHGBFBDHANB where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BEC0", Offset = "0x2A9A8C0", VA = "0x182A9BEC0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, T? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BD70", Offset = "0x2A9A770", VA = "0x182A9BD70", Slot = "5")]
	public T? AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
	public ECEKNLMNHNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class FKLCALFLHBG<T> : global::MMFDCMJAOJA<T?>, DHGBFBDHANB where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private readonly global::MMFDCMJAOJA<T> HEGDLCCJBPO;

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE890", Offset = "0x1FDD290", VA = "0x181FDE890")]
	public FKLCALFLHBG(global::MMFDCMJAOJA<T> HEGDLCCJBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x28AE950", Offset = "0x28AD350", VA = "0x1828AE950")]
	public FKLCALFLHBG(Type DDCLMECEMGG, object[] NPOJMAKHDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x28ADE30", Offset = "0x28AC830", VA = "0x1828ADE30", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, T? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x28AD290", Offset = "0x28ABC90", VA = "0x1828AD290", Slot = "5")]
	public T? AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class DAHELEBKDDE : global::MMFDCMJAOJA<sbyte>, DHGBFBDHANB, global::IFPGMOGFAMI<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly DAHELEBKDDE JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x4D06F10", Offset = "0x4D05910", VA = "0x184D06F10", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, sbyte MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x4D06E50", Offset = "0x4D05850", VA = "0x184D06E50", Slot = "5")]
	public sbyte AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x4D06F30", Offset = "0x4D05930", VA = "0x184D06F30", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, sbyte MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x4D06E60", Offset = "0x4D05860", VA = "0x184D06E60", Slot = "7")]
	public sbyte EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public DAHELEBKDDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class IEKMFCAJFOD : global::MMFDCMJAOJA<sbyte?>, DHGBFBDHANB, global::IFPGMOGFAMI<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly IEKMFCAJFOD JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x4D16700", Offset = "0x4D15100", VA = "0x184D16700", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, sbyte? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x4D16590", Offset = "0x4D14F90", VA = "0x184D16590", Slot = "5")]
	public sbyte? AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x4D16780", Offset = "0x4D15180", VA = "0x184D16780", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, sbyte? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x4D16600", Offset = "0x4D15000", VA = "0x184D16600", Slot = "7")]
	public sbyte? EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public IEKMFCAJFOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class BMEFJKJPKCK : global::MMFDCMJAOJA<sbyte[]>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly BMEFJKJPKCK JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x4D04090", Offset = "0x4D02A90", VA = "0x184D04090", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, sbyte[] MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x4D03F50", Offset = "0x4D02950", VA = "0x184D03F50", Slot = "5")]
	public sbyte[] AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public BMEFJKJPKCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class ACMIDCIPNFM : global::MMFDCMJAOJA<short>, DHGBFBDHANB, global::IFPGMOGFAMI<short>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly ACMIDCIPNFM JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x4D01400", Offset = "0x4CFFE00", VA = "0x184D01400", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, short MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x4D01340", Offset = "0x4CFFD40", VA = "0x184D01340", Slot = "5")]
	public short AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x4D01420", Offset = "0x4CFFE20", VA = "0x184D01420", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, short MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x4D01350", Offset = "0x4CFFD50", VA = "0x184D01350", Slot = "7")]
	public short EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public ACMIDCIPNFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class EHFFBILDFNF : global::MMFDCMJAOJA<short?>, DHGBFBDHANB, global::IFPGMOGFAMI<short?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly EHFFBILDFNF JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x4D08EC0", Offset = "0x4D078C0", VA = "0x184D08EC0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, short? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x4D08D60", Offset = "0x4D07760", VA = "0x184D08D60", Slot = "5")]
	public short? AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x4D08F40", Offset = "0x4D07940", VA = "0x184D08F40", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, short? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x4D08DD0", Offset = "0x4D077D0", VA = "0x184D08DD0", Slot = "7")]
	public short? EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public EHFFBILDFNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class KLGIAPAFEEL : global::MMFDCMJAOJA<short[]>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly KLGIAPAFEEL JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x53B78B0", Offset = "0x53B62B0", VA = "0x1853B78B0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, short[] MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x53B7680", Offset = "0x53B6080", VA = "0x1853B7680", Slot = "5")]
	public short[] AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KLGIAPAFEEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class NMGAIHELOFE : global::MMFDCMJAOJA<int>, DHGBFBDHANB, global::IFPGMOGFAMI<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly NMGAIHELOFE JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x52EB810", Offset = "0x52EA210", VA = "0x1852EB810", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, int MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x52EB780", Offset = "0x52EA180", VA = "0x1852EB780", Slot = "5")]
	public int AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x52EB820", Offset = "0x52EA220", VA = "0x1852EB820", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, int MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x52EB790", Offset = "0x52EA190", VA = "0x1852EB790", Slot = "7")]
	public int EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public NMGAIHELOFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class BHBHJOJMIMM : global::MMFDCMJAOJA<int?>, DHGBFBDHANB, global::IFPGMOGFAMI<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly BHBHJOJMIMM JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x4D03A30", Offset = "0x4D02430", VA = "0x184D03A30", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, int? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x4D038D0", Offset = "0x4D022D0", VA = "0x184D038D0", Slot = "5")]
	public int? AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x4D03AA0", Offset = "0x4D024A0", VA = "0x184D03AA0", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, int? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x4D03940", Offset = "0x4D02340", VA = "0x184D03940", Slot = "7")]
	public int? EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public BHBHJOJMIMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class KCDPOJEDLGA : global::MMFDCMJAOJA<int[]>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly KCDPOJEDLGA JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x53B6E10", Offset = "0x53B5810", VA = "0x1853B6E10", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, int[] MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x53B6BE0", Offset = "0x53B55E0", VA = "0x1853B6BE0", Slot = "5")]
	public int[] AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KCDPOJEDLGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class BPOFBKAKLFP : global::MMFDCMJAOJA<long>, DHGBFBDHANB, global::IFPGMOGFAMI<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly BPOFBKAKLFP JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x4D05B40", Offset = "0x4D04540", VA = "0x184D05B40", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, long MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x4D05A50", Offset = "0x4D04450", VA = "0x184D05A50", Slot = "5")]
	public long AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x4D05B60", Offset = "0x4D04560", VA = "0x184D05B60", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, long MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x4D05A60", Offset = "0x4D04460", VA = "0x184D05A60", Slot = "7")]
	public long EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public BPOFBKAKLFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class PLHBGPCPNBI : global::MMFDCMJAOJA<long?>, DHGBFBDHANB, global::IFPGMOGFAMI<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly PLHBGPCPNBI JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x52F38F0", Offset = "0x52F22F0", VA = "0x1852F38F0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, long? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x52F3780", Offset = "0x52F2180", VA = "0x1852F3780", Slot = "5")]
	public long? AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x52F3970", Offset = "0x52F2370", VA = "0x1852F3970", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, long? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x52F3810", Offset = "0x52F2210", VA = "0x1852F3810", Slot = "7")]
	public long? EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public PLHBGPCPNBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class IJBMFNCIBAE : global::MMFDCMJAOJA<long[]>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly IJBMFNCIBAE JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x4D16C00", Offset = "0x4D15600", VA = "0x184D16C00", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, long[] MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x4D16AC0", Offset = "0x4D154C0", VA = "0x184D16AC0", Slot = "5")]
	public long[] AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public IJBMFNCIBAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class INAALPHFBIG : global::MMFDCMJAOJA<byte>, DHGBFBDHANB, global::IFPGMOGFAMI<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly INAALPHFBIG JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x4D16DE0", Offset = "0x4D157E0", VA = "0x184D16DE0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, byte MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x4D16D20", Offset = "0x4D15720", VA = "0x184D16D20", Slot = "5")]
	public byte AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x4D16E00", Offset = "0x4D15800", VA = "0x184D16E00", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, byte MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x4D16D30", Offset = "0x4D15730", VA = "0x184D16D30", Slot = "7")]
	public byte EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public INAALPHFBIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class FPAAJHFDKGF : global::MMFDCMJAOJA<byte?>, DHGBFBDHANB, global::IFPGMOGFAMI<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly FPAAJHFDKGF JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B900", Offset = "0x4D0A300", VA = "0x184D0B900", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, byte? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B790", Offset = "0x4D0A190", VA = "0x184D0B790", Slot = "5")]
	public byte? AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B980", Offset = "0x4D0A380", VA = "0x184D0B980", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, byte? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B800", Offset = "0x4D0A200", VA = "0x184D0B800", Slot = "7")]
	public byte? EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public FPAAJHFDKGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class MCFKLNGKDBK : global::MMFDCMJAOJA<ushort>, DHGBFBDHANB, global::IFPGMOGFAMI<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly MCFKLNGKDBK JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x53BED60", Offset = "0x53BD760", VA = "0x1853BED60", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, ushort MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x53BEC80", Offset = "0x53BD680", VA = "0x1853BEC80", Slot = "5")]
	public ushort AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x53BEDA0", Offset = "0x53BD7A0", VA = "0x1853BEDA0", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, ushort MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x53BECE0", Offset = "0x53BD6E0", VA = "0x1853BECE0", Slot = "7")]
	public ushort EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public MCFKLNGKDBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class JMHMFDEHEMN : global::MMFDCMJAOJA<ushort?>, DHGBFBDHANB, global::IFPGMOGFAMI<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly JMHMFDEHEMN JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x4D196A0", Offset = "0x4D180A0", VA = "0x184D196A0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, ushort? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x4D19540", Offset = "0x4D17F40", VA = "0x184D19540", Slot = "5")]
	public ushort? AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x4D19720", Offset = "0x4D18120", VA = "0x184D19720", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, ushort? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x4D195B0", Offset = "0x4D17FB0", VA = "0x184D195B0", Slot = "7")]
	public ushort? EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public JMHMFDEHEMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class PGNEKMOBKHD : global::MMFDCMJAOJA<ushort[]>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly PGNEKMOBKHD JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x52F2750", Offset = "0x52F1150", VA = "0x1852F2750", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, ushort[] MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x52F2610", Offset = "0x52F1010", VA = "0x1852F2610", Slot = "5")]
	public ushort[] AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public PGNEKMOBKHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class DDGNFIPBHAC : global::MMFDCMJAOJA<uint>, DHGBFBDHANB, global::IFPGMOGFAMI<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly DDGNFIPBHAC JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x4D071C0", Offset = "0x4D05BC0", VA = "0x184D071C0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, uint MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x4D07100", Offset = "0x4D05B00", VA = "0x184D07100", Slot = "5")]
	public uint AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x4D071D0", Offset = "0x4D05BD0", VA = "0x184D071D0", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, uint MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x4D07110", Offset = "0x4D05B10", VA = "0x184D07110", Slot = "7")]
	public uint EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public DDGNFIPBHAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class PFPLIKIBKIH : global::MMFDCMJAOJA<uint?>, DHGBFBDHANB, global::IFPGMOGFAMI<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly PFPLIKIBKIH JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x52F23B0", Offset = "0x52F0DB0", VA = "0x1852F23B0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, uint? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x52F2280", Offset = "0x52F0C80", VA = "0x1852F2280", Slot = "5")]
	public uint? AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x52F2420", Offset = "0x52F0E20", VA = "0x1852F2420", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, uint? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x52F22F0", Offset = "0x52F0CF0", VA = "0x1852F22F0", Slot = "7")]
	public uint? EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public PFPLIKIBKIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class BCGNAMLNHGJ : global::MMFDCMJAOJA<uint[]>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly BCGNAMLNHGJ JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x4D031D0", Offset = "0x4D01BD0", VA = "0x184D031D0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, uint[] MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x4D03090", Offset = "0x4D01A90", VA = "0x184D03090", Slot = "5")]
	public uint[] AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public BCGNAMLNHGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class MNOOJMOONGM : global::MMFDCMJAOJA<ulong>, DHGBFBDHANB, global::IFPGMOGFAMI<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly MNOOJMOONGM JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x53BF550", Offset = "0x53BDF50", VA = "0x1853BF550", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, ulong MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x53BF4C0", Offset = "0x53BDEC0", VA = "0x1853BF4C0", Slot = "5")]
	public ulong AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x53BF580", Offset = "0x53BDF80", VA = "0x1853BF580", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, ulong MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x53BF4D0", Offset = "0x53BDED0", VA = "0x1853BF4D0", Slot = "7")]
	public ulong EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public MNOOJMOONGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class KBGBCFNBBOA : global::MMFDCMJAOJA<ulong?>, DHGBFBDHANB, global::IFPGMOGFAMI<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly KBGBCFNBBOA JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x53B4E80", Offset = "0x53B3880", VA = "0x1853B4E80", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, ulong? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x53B4D10", Offset = "0x53B3710", VA = "0x1853B4D10", Slot = "5")]
	public ulong? AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x53B4F10", Offset = "0x53B3910", VA = "0x1853B4F10", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, ulong? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x53B4DA0", Offset = "0x53B37A0", VA = "0x1853B4DA0", Slot = "7")]
	public ulong? EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KBGBCFNBBOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class EBKPOILMFCD : global::MMFDCMJAOJA<ulong[]>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly EBKPOILMFCD JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x4D08150", Offset = "0x4D06B50", VA = "0x184D08150", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, ulong[] MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x4D08010", Offset = "0x4D06A10", VA = "0x184D08010", Slot = "5")]
	public ulong[] AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public EBKPOILMFCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class BKGCNJJGDHK : global::MMFDCMJAOJA<float>, DHGBFBDHANB, global::IFPGMOGFAMI<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly BKGCNJJGDHK JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x4D03EA0", Offset = "0x4D028A0", VA = "0x184D03EA0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, float MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x4D03D60", Offset = "0x4D02760", VA = "0x184D03D60", Slot = "5")]
	public float AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x4D03EB0", Offset = "0x4D028B0", VA = "0x184D03EB0", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, float MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x4D03D70", Offset = "0x4D02770", VA = "0x184D03D70", Slot = "7")]
	public float EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public BKGCNJJGDHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class HMIELCCHIFG : global::MMFDCMJAOJA<float?>, DHGBFBDHANB, global::IFPGMOGFAMI<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly HMIELCCHIFG JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x4D14800", Offset = "0x4D13200", VA = "0x184D14800", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, float? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x4D146D0", Offset = "0x4D130D0", VA = "0x184D146D0", Slot = "5")]
	public float? AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x4D14880", Offset = "0x4D13280", VA = "0x184D14880", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, float? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x4D14740", Offset = "0x4D13140", VA = "0x184D14740", Slot = "7")]
	public float? EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public HMIELCCHIFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class KGAOJBIMGMB : global::MMFDCMJAOJA<float[]>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly KGAOJBIMGMB JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x53B7240", Offset = "0x53B5C40", VA = "0x1853B7240", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, float[] MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x53B7010", Offset = "0x53B5A10", VA = "0x1853B7010", Slot = "5")]
	public float[] AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KGAOJBIMGMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class DOKAOIJONBF : global::MMFDCMJAOJA<double>, DHGBFBDHANB, global::IFPGMOGFAMI<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly DOKAOIJONBF JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x4D07650", Offset = "0x4D06050", VA = "0x184D07650", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, double MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x4D07510", Offset = "0x4D05F10", VA = "0x184D07510", Slot = "5")]
	public double AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x4D07660", Offset = "0x4D06060", VA = "0x184D07660", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, double MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x4D07520", Offset = "0x4D05F20", VA = "0x184D07520", Slot = "7")]
	public double EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public DOKAOIJONBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class IEBDPBMBKIN : global::MMFDCMJAOJA<double?>, DHGBFBDHANB, global::IFPGMOGFAMI<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly IEBDPBMBKIN JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x4D162C0", Offset = "0x4D14CC0", VA = "0x184D162C0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, double? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x4D16150", Offset = "0x4D14B50", VA = "0x184D16150", Slot = "5")]
	public double? AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x4D16340", Offset = "0x4D14D40", VA = "0x184D16340", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, double? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x4D161E0", Offset = "0x4D14BE0", VA = "0x184D161E0", Slot = "7")]
	public double? EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public IEBDPBMBKIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class IIFEFHDAJKG : global::MMFDCMJAOJA<double[]>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly IIFEFHDAJKG JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x4D169A0", Offset = "0x4D153A0", VA = "0x184D169A0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, double[] MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x4D16860", Offset = "0x4D15260", VA = "0x184D16860", Slot = "5")]
	public double[] AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public IIFEFHDAJKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class KNNDPFHDABK : global::MMFDCMJAOJA<bool>, DHGBFBDHANB, global::IFPGMOGFAMI<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly KNNDPFHDABK JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x53B7E80", Offset = "0x53B6880", VA = "0x1853B7E80", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, bool MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x53B7DF0", Offset = "0x53B67F0", VA = "0x1853B7DF0", Slot = "5")]
	public bool AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x53B7EA0", Offset = "0x53B68A0", VA = "0x1853B7EA0", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, bool MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x53B7E00", Offset = "0x53B6800", VA = "0x1853B7E00", Slot = "7")]
	public bool EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KNNDPFHDABK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class LKDHKLACCBK : global::MMFDCMJAOJA<bool?>, DHGBFBDHANB, global::IFPGMOGFAMI<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly LKDHKLACCBK JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x53BB2E0", Offset = "0x53B9CE0", VA = "0x1853BB2E0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, bool? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x53BB1B0", Offset = "0x53B9BB0", VA = "0x1853BB1B0", Slot = "5")]
	public bool? AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x53BB360", Offset = "0x53B9D60", VA = "0x1853BB360", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, bool? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x53BB220", Offset = "0x53B9C20", VA = "0x1853BB220", Slot = "7")]
	public bool? EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public LKDHKLACCBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class OIHMMIPCFBA : global::MMFDCMJAOJA<bool[]>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly OIHMMIPCFBA JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x52F0F00", Offset = "0x52EF900", VA = "0x1852F0F00", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, bool[] MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x52F0DC0", Offset = "0x52EF7C0", VA = "0x1852F0DC0", Slot = "5")]
	public bool[] AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public OIHMMIPCFBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class EPJFJKAFHCJ : global::MMFDCMJAOJA<object>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly global::MMFDCMJAOJA<object> JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly Dictionary<Type, int> BBEDICHLFJC;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x4D09C00", Offset = "0x4D08600", VA = "0x184D09C00", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, object MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x4D098D0", Offset = "0x4D082D0", VA = "0x184D098D0", Slot = "5")]
	public object AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public EPJFJKAFHCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class AOCFALOHLHE : global::MMFDCMJAOJA<byte[]>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly global::MMFDCMJAOJA<byte[]> JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x4D02DE0", Offset = "0x4D017E0", VA = "0x184D02DE0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, byte[] MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x4D02D60", Offset = "0x4D01760", VA = "0x184D02D60", Slot = "5")]
	public byte[] AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public AOCFALOHLHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class NHEHGKBOIKH : global::MMFDCMJAOJA<ArraySegment<byte>>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly global::MMFDCMJAOJA<ArraySegment<byte>> JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x53BF940", Offset = "0x53BE340", VA = "0x1853BF940", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, ArraySegment<byte> MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x53BF860", Offset = "0x53BE260", VA = "0x1853BF860", Slot = "5")]
	public ArraySegment<byte> AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public NHEHGKBOIKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class PDMDDPJHCIJ : global::MMFDCMJAOJA<string>, DHGBFBDHANB, global::IFPGMOGFAMI<string>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::MMFDCMJAOJA<string> JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x52F1650", Offset = "0x52F0050", VA = "0x1852F1650", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, string MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x52F1640", Offset = "0x52F0040", VA = "0x1852F1640", Slot = "5")]
	public string AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x52F1650", Offset = "0x52F0050", VA = "0x1852F1650", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, string MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x52F1640", Offset = "0x52F0040", VA = "0x1852F1640", Slot = "7")]
	public string EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public PDMDDPJHCIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class PDHIDHJCOCA : global::MMFDCMJAOJA<string[]>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly PDHIDHJCOCA JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x52F1520", Offset = "0x52EFF20", VA = "0x1852F1520", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, string[] MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x52F13B0", Offset = "0x52EFDB0", VA = "0x1852F13B0", Slot = "5")]
	public string[] AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public PDHIDHJCOCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class PGFAPAHCDCI : global::MMFDCMJAOJA<char>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly PGFAPAHCDCI JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x52F2530", Offset = "0x52F0F30", VA = "0x1852F2530", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, char MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x52F2500", Offset = "0x52F0F00", VA = "0x1852F2500", Slot = "5")]
	public char AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public PGFAPAHCDCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class ENHEACGKAMF : global::MMFDCMJAOJA<char?>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly ENHEACGKAMF JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x4D09780", Offset = "0x4D08180", VA = "0x184D09780", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, char? MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x4D096B0", Offset = "0x4D080B0", VA = "0x184D096B0", Slot = "5")]
	public char? AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public ENHEACGKAMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class GNFPHBGPNGD : global::MMFDCMJAOJA<char[]>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly GNFPHBGPNGD JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x4D107A0", Offset = "0x4D0F1A0", VA = "0x184D107A0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, char[] MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x4D10600", Offset = "0x4D0F000", VA = "0x184D10600", Slot = "5")]
	public char[] AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public GNFPHBGPNGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class KLKFIHJIJKI : global::MMFDCMJAOJA<Guid>, DHGBFBDHANB, global::IFPGMOGFAMI<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::MMFDCMJAOJA<Guid> JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x53B7B00", Offset = "0x53B6500", VA = "0x1853B7B00", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, Guid MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x53B7AB0", Offset = "0x53B64B0", VA = "0x1853B7AB0", Slot = "5")]
	public Guid AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x53B7C80", Offset = "0x53B6680", VA = "0x1853B7C80", Slot = "6")]
	public void KDNPBPCCOLH(ref KBHFHFFPFEJ LHGJJBFKNCG, Guid MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x53B7AB0", Offset = "0x53B64B0", VA = "0x1853B7AB0", Slot = "7")]
	public Guid EBGDJGIGMKG(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KLKFIHJIJKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class EFPFGHBJGBN : global::MMFDCMJAOJA<decimal>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::MMFDCMJAOJA<decimal> JPMFPEEJFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private readonly bool KHBAEMKAONL;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x892FA0", Offset = "0x8919A0", VA = "0x180892FA0")]
	public EFPFGHBJGBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x1297DA0", Offset = "0x12967A0", VA = "0x181297DA0")]
	public EFPFGHBJGBN(bool KHBAEMKAONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x4D08BB0", Offset = "0x4D075B0", VA = "0x184D08BB0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, decimal MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x4D08980", Offset = "0x4D07380", VA = "0x184D08980", Slot = "5")]
	public decimal AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class OHENBHNIFBM : global::MMFDCMJAOJA<Uri>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly global::MMFDCMJAOJA<Uri> JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x52F0CB0", Offset = "0x52EF6B0", VA = "0x1852F0CB0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, Uri MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x52F0C30", Offset = "0x52EF630", VA = "0x1852F0C30", Slot = "5")]
	public Uri AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public OHENBHNIFBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class HMCFBAPFAMF : global::MMFDCMJAOJA<Version>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly global::MMFDCMJAOJA<Version> JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x4D145C0", Offset = "0x4D12FC0", VA = "0x184D145C0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, Version MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x4D14540", Offset = "0x4D12F40", VA = "0x184D14540", Slot = "5")]
	public Version AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public HMCFBAPFAMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class DDHHPMJPCDE<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class JNFNOPFIBDP : global::MMFDCMJAOJA<StringBuilder>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly global::MMFDCMJAOJA<StringBuilder> JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x4D19880", Offset = "0x4D18280", VA = "0x184D19880", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, StringBuilder MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x4D19800", Offset = "0x4D18200", VA = "0x184D19800", Slot = "5")]
	public StringBuilder AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public JNFNOPFIBDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class HAGBKDDPHON : global::MMFDCMJAOJA<BitArray>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly global::MMFDCMJAOJA<BitArray> JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x4D135D0", Offset = "0x4D11FD0", VA = "0x184D135D0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, BitArray MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x4D134B0", Offset = "0x4D11EB0", VA = "0x184D134B0", Slot = "5")]
	public BitArray AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public HAGBKDDPHON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class MKBBJOGCIHE : global::MMFDCMJAOJA<Type>, DHGBFBDHANB
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly MKBBJOGCIHE JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly Regex NAOKAECJMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool JKPAILNDJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private bool DHNHEJMEPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private bool KBMPJHNKLCK;

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x53BF4A0", Offset = "0x53BDEA0", VA = "0x1853BF4A0")]
	public MKBBJOGCIHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x53BF450", Offset = "0x53BDE50", VA = "0x1853BF450")]
	public MKBBJOGCIHE(bool JKPAILNDJDL, bool DHNHEJMEPHJ, bool KBMPJHNKLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x53BF2A0", Offset = "0x53BDCA0", VA = "0x1853BF2A0", Slot = "4")]
	public void JHPOCMCIPNJ(ref KBHFHFFPFEJ LHGJJBFKNCG, Type MNIAGKNOHEJ, HEOIHOEGOKA JEKCDBAHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x53BF170", Offset = "0x53BDB70", VA = "0x1853BF170", Slot = "5")]
	public Type AJGJBLGJHIK(ref NIGKCAJBBED ALGAFFHCPAP, HEOIHOEGOKA JEKCDBAHJII)
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
