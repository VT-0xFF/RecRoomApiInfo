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
internal static class JCFLCNHNJPC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5197A70", Offset = "0x5196870", VA = "0x185197A70")]
	public static bool MPBJFFPEEOJ(this TypeInfo LEDIIMFEFLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class HPNKDFAKLCP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type INLKBPFHNKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7612C0", Offset = "0x7600C0", VA = "0x1807612C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] ENBNCBMHEHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x75C880", Offset = "0x75B680", VA = "0x18075C880")]
	public HPNKDFAKLCP(Type EJEDDCFCCLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor)]
public class FMDDIENJPHD : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void IJBGJMMNNHD<T>(ref FDOCIEKIOGE IMGJFGGFPOC, T MGFMONLLLPD, FJOMMFMGKED KGHKAFFNKHL);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T HNFJOCCCBML<T>(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED KGHKAFFNKHL);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BBDBBGCPFMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HBFNKAIDHHG<T> : BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, T MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DDPAFIBFIKL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, T MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum HAILMNOEJFB
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BOCKLOPNMOI
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x26676F0", Offset = "0x26664F0", VA = "0x1826676F0")]
	public static global::HBFNKAIDHHG<T> DICNINJDPHH<T>(this FJOMMFMGKED KGHKAFFNKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5901470", Offset = "0x5900270", VA = "0x185901470")]
	public static object LHKHGCAJPIN(this FJOMMFMGKED KGHKAFFNKHL, Type LEDIIMFEFLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JCAFBCAHPEH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5197A00", Offset = "0x5196800", VA = "0x185197A00")]
	public JCAFBCAHPEH(string GPAOLHFLBHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct JDAEFHPGJAL
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class CGNBONMHIDK
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] MMBEBPNKEHD;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] KGLIDCKMADB;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5645460", Offset = "0x5644260", VA = "0x185645460")]
		public static byte[] LOGHFHCNLFB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x56453D0", Offset = "0x56441D0", VA = "0x1856453D0")]
		public static char[] LHNFNLKHADP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> GCENDAFPDND;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] DIELLOAHKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] EMGPHLLIACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int NGOMPMICLHJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool FMIIOOPBHDM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5198BE0", Offset = "0x51979E0", VA = "0x185198BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x519A990", Offset = "0x5199790", VA = "0x18519A990")]
	public JDAEFHPGJAL(byte[] EMGPHLLIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x519A7A0", Offset = "0x51995A0", VA = "0x18519A7A0")]
	public JDAEFHPGJAL(byte[] EMGPHLLIACG, int NGOMPMICLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x51991C0", Offset = "0x5197FC0", VA = "0x1851991C0")]
	private NNBJIDBJIPH IMBPAEFFOFH(string IIEJCKFDDHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5199040", Offset = "0x5197E40", VA = "0x185199040")]
	private NNBJIDBJIPH HHOIIPIHEKL(string GPAOLHFLBHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5197FE0", Offset = "0x5196DE0", VA = "0x185197FE0")]
	public void BMBGKCIIHCN(int NGOMPMICLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x740000", Offset = "0x73EE00", VA = "0x180740000")]
	public byte[] BMHGMFHEMOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C8AD0", Offset = "0x7C78D0", VA = "0x1807C8AD0")]
	public int EGMBGAACDBJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5199E50", Offset = "0x5198C50", VA = "0x185199E50")]
	public HOBNOBEFPJI MAALOCNJNAG()
	{
		return default(HOBNOBEFPJI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5197FF0", Offset = "0x5196DF0", VA = "0x185197FF0")]
	public void BMKADNFFMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5198DA0", Offset = "0x5197BA0", VA = "0x185198DA0")]
	public bool GACDPIALJJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5199FD0", Offset = "0x5198DD0", VA = "0x185199FD0")]
	public bool MBJCBNNPBFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5198A00", Offset = "0x5197800", VA = "0x185198A00")]
	public void CMHIMCCNMJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x519A400", Offset = "0x5199200", VA = "0x18519A400")]
	public bool NBPACDGNMNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5198C90", Offset = "0x5197A90", VA = "0x185198C90")]
	public bool ENIMGAOKDGP(ref int MNBBKKLFBKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5197AA0", Offset = "0x51968A0", VA = "0x185197AA0")]
	public bool AABNLBPIJAM(ref int MNBBKKLFBKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5197BA0", Offset = "0x51969A0", VA = "0x185197BA0")]
	public bool AIDDCOOMNOE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5198C00", Offset = "0x5197A00", VA = "0x185198C00")]
	public void ELJIDGOJMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5198EA0", Offset = "0x5197CA0", VA = "0x185198EA0")]
	public bool GAFCHDLMHPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5198B60", Offset = "0x5197960", VA = "0x185198B60")]
	public bool DENJAFJCOCL(ref int MNBBKKLFBKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5199D90", Offset = "0x5198B90", VA = "0x185199D90")]
	public bool LMDCBEBPIKC(ref int MNBBKKLFBKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x519A030", Offset = "0x5198E30", VA = "0x18519A030")]
	public bool MBPOLLANHMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5199130", Offset = "0x5197F30", VA = "0x185199130")]
	public void ILDGBGDCOAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5197C00", Offset = "0x5196A00", VA = "0x185197C00")]
	public bool ALKDGMDCKOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5198D10", Offset = "0x5197B10", VA = "0x185198D10")]
	public void ENNNOMGJBDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5198190", Offset = "0x5196F90", VA = "0x185198190")]
	private void CFJMDAHFOIB(out byte[] JOOJPGJEJEG, out int IMILLHNJMHB, out int EKMNKEMHLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5198950", Offset = "0x5197750", VA = "0x185198950")]
	private static int CFLDIKDGPFJ(char GCKGDDMIIDO, char EJKHFJILHAC, char ICHEJPHGAEP, char EIBINODMDGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5198A90", Offset = "0x5197890", VA = "0x185198A90")]
	private static int CMLMLMLBBBP(char NHKCICGBPMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x519A220", Offset = "0x5199020", VA = "0x18519A220")]
	public ArraySegment<byte> MNJLGILMJND()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5199A90", Offset = "0x5198890", VA = "0x185199A90")]
	public string JOIAOHOIIDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5199B90", Offset = "0x5198990", VA = "0x185199B90")]
	public string KLMMPNEECKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5199BC0", Offset = "0x51989C0", VA = "0x185199BC0")]
	public ArraySegment<byte> KOFGNDFFCJC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5197B60", Offset = "0x5196960", VA = "0x185197B60")]
	public ArraySegment<byte> AANEIEFGFBO()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5197DA0", Offset = "0x5196BA0", VA = "0x185197DA0")]
	public bool BJAGLNEBANL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5199800", Offset = "0x5198600", VA = "0x185199800")]
	private static bool JJAFNBPPMPL(byte ICHEJPHGAEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x519A460", Offset = "0x5199260", VA = "0x18519A460")]
	private void PKCAECDPHHL(HOBNOBEFPJI AMBDKIOJFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5199120", Offset = "0x5197F20", VA = "0x185199120")]
	public void HMACHLLNCFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x51996D0", Offset = "0x51984D0", VA = "0x1851996D0")]
	private void IMFEPOHFAPL(int KKGMPFIAEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5197D50", Offset = "0x5196B50", VA = "0x185197D50")]
	public sbyte BIGBPNGJELO()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x51997A0", Offset = "0x51985A0", VA = "0x1851997A0")]
	public short JEAGHINNOCE()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5199B30", Offset = "0x5198930", VA = "0x185199B30")]
	public int KBAMKNKGPAE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x519A380", Offset = "0x5199180", VA = "0x18519A380")]
	public long NBGOEHDMJCC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5198130", Offset = "0x5196F30", VA = "0x185198130")]
	public byte CAOKMNICONM()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x519A640", Offset = "0x5199440", VA = "0x18519A640")]
	public ushort POGKLFOCFDJ()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x519A320", Offset = "0x5199120", VA = "0x18519A320")]
	public uint NBCCNMAELEI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x51998C0", Offset = "0x51986C0", VA = "0x1851998C0")]
	public ulong JJNGFLEFMDC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5199940", Offset = "0x5198740", VA = "0x185199940")]
	public float JLCKFEHPEOO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5198F00", Offset = "0x5197D00", VA = "0x185198F00")]
	public double HBBNEJPJBAE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5197C60", Offset = "0x5196A60", VA = "0x185197C60")]
	public ArraySegment<byte> BANEMDFOMFF()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x519A090", Offset = "0x5198E90", VA = "0x18519A090")]
	private static int MEOKPNJFABG(byte[] EMGPHLLIACG, int NGOMPMICLHJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NNBJIDBJIPH : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference LEFAFHDPGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int GJPPPGOHKEB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int HGFOBPAJBEK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x13AB2B0", Offset = "0x13AA0B0", VA = "0x1813AB2B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string GPIJPDBJLOH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x94C560", Offset = "0x94B360", VA = "0x18094C560")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x564F9D0", Offset = "0x564E7D0", VA = "0x18564F9D0")]
	public NNBJIDBJIPH(string GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x564F8F0", Offset = "0x564E6F0", VA = "0x18564F8F0")]
	public NNBJIDBJIPH(string GPAOLHFLBHD, byte[] PFFHEPHACMI, int NGOMPMICLHJ, int GJPPPGOHKEB, string PBIMIHPPPJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AOLOBKFCKCE
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class LCHHEPFKBDM
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private delegate void AAOCKCHKDFE(ref FDOCIEKIOGE IMGJFGGFPOC, object MGFMONLLLPD, FJOMMFMGKED KGHKAFFNKHL);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private delegate object DCAJEHOECGH(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED KGHKAFFNKHL);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private class DEAAGGDCLIK
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			[CompilerGenerated]
			private sealed class AFMJFBJEJDP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
				public AFMJFBJEJDP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x3D63200", Offset = "0x3D62000", VA = "0x183D63200")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x5644420", Offset = "0x5643220", VA = "0x185644420")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, FJOMMFMGKED, byte[]> CLAHLHOCMEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, FJOMMFMGKED> CGCBLEAFOFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly AAOCKCHKDFE MHPHANDDNMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, FJOMMFMGKED, ArraySegment<byte>> DLPDBIDILGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, FJOMMFMGKED, string> LFJAMAIEODP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, FJOMMFMGKED, object> GEFBMOCEPBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, FJOMMFMGKED, object> EHEACKBNCPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, FJOMMFMGKED, object> NLIBFKFLOIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly DCAJEHOECGH JABKELNOPEJ;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5645C60", Offset = "0x5644A60", VA = "0x185645C60")]
			public DEAAGGDCLIK(Type LEDIIMFEFLP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x5961190", Offset = "0x595FF90", VA = "0x185961190")]
			private static T ACLIIBMNCAG<T>(DynamicMethod PFHMOINOONH)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x5645A10", Offset = "0x5644810", VA = "0x185645A10")]
			private static MethodInfo FGDJNCEPOLE(Type LEDIIMFEFLP, string ICIEGOLHGJN, Type[] DFIBGBEICJH)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, DEAAGGDCLIK> JPJCBPCIIPN;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::JKPKDNKLJAG<DEAAGGDCLIK> COPMHIJCJLN;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x564A8F0", Offset = "0x56496F0", VA = "0x18564A8F0")]
		static LCHHEPFKBDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x564A5B0", Offset = "0x56493B0", VA = "0x18564A5B0")]
		private static DEAAGGDCLIK EEILMIDAPKF(Type LEDIIMFEFLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x564A760", Offset = "0x5649560", VA = "0x18564A760")]
		public static void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, object MGFMONLLLPD, FJOMMFMGKED KGHKAFFNKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x564A640", Offset = "0x5649440", VA = "0x18564A640")]
		public static void EPOBOPBJBKM(Type LEDIIMFEFLP, ref FDOCIEKIOGE IMGJFGGFPOC, object MGFMONLLLPD, FJOMMFMGKED KGHKAFFNKHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class KLMCHLDENGJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] MMBEBPNKEHD;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x564A250", Offset = "0x5649050", VA = "0x18564A250")]
		public static byte[] LOGHFHCNLFB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static FJOMMFMGKED FJCKHNCCILP;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] IHCECLAGBEL;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] EEEABALLHDK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static FJOMMFMGKED LEMPLJGJOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x58FD930", Offset = "0x58FC730", VA = "0x1858FD930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool PBGELHMIIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x58FDAF0", Offset = "0x58FC8F0", VA = "0x1858FDAF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x58FD2F0", Offset = "0x58FC0F0", VA = "0x1858FD2F0")]
	public static void AJFHKLHIEHI(FJOMMFMGKED KGHKAFFNKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2304A50", Offset = "0x2303850", VA = "0x182304A50")]
	public static byte[] EPOBOPBJBKM<T>(T OJGAEOFIMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2304B60", Offset = "0x2303960", VA = "0x182304B60")]
	public static byte[] EPOBOPBJBKM<T>(T MGFMONLLLPD, FJOMMFMGKED KGHKAFFNKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2304AD0", Offset = "0x23038D0", VA = "0x182304AD0")]
	public static void EPOBOPBJBKM<T>(ref FDOCIEKIOGE IMGJFGGFPOC, T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2304CC0", Offset = "0x2303AC0", VA = "0x182304CC0")]
	public static void EPOBOPBJBKM<T>(ref FDOCIEKIOGE IMGJFGGFPOC, T MGFMONLLLPD, FJOMMFMGKED KGHKAFFNKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x23048A0", Offset = "0x23036A0", VA = "0x1823048A0")]
	public static void EPOBOPBJBKM<T>(Stream KHIILPEBNKK, T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2304930", Offset = "0x2303730", VA = "0x182304930")]
	public static void EPOBOPBJBKM<T>(Stream KHIILPEBNKK, T MGFMONLLLPD, FJOMMFMGKED KGHKAFFNKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2304F20", Offset = "0x2303D20", VA = "0x182304F20")]
	public static ArraySegment<byte> HFEJLOHFDCF<T>(T OJGAEOFIMPK)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2304DA0", Offset = "0x2303BA0", VA = "0x182304DA0")]
	public static ArraySegment<byte> HFEJLOHFDCF<T>(T MGFMONLLLPD, FJOMMFMGKED KGHKAFFNKHL)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2304FC0", Offset = "0x2303DC0", VA = "0x182304FC0")]
	public static string JOOIHHAJPBD<T>(T MGFMONLLLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2305040", Offset = "0x2303E40", VA = "0x182305040")]
	public static string JOOIHHAJPBD<T>(T MGFMONLLLPD, FJOMMFMGKED KGHKAFFNKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2303DE0", Offset = "0x2302BE0", VA = "0x182303DE0")]
	public static T BPPOCFBLMGN<T>(string DNAIGHGJNFN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2303F20", Offset = "0x2302D20", VA = "0x182303F20")]
	public static T BPPOCFBLMGN<T>(string DNAIGHGJNFN, FJOMMFMGKED KGHKAFFNKHL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2304820", Offset = "0x2303620", VA = "0x182304820")]
	public static T BPPOCFBLMGN<T>(byte[] EMGPHLLIACG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2303E80", Offset = "0x2302C80", VA = "0x182303E80")]
	public static T BPPOCFBLMGN<T>(byte[] EMGPHLLIACG, FJOMMFMGKED KGHKAFFNKHL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2304430", Offset = "0x2303230", VA = "0x182304430")]
	public static T BPPOCFBLMGN<T>(byte[] EMGPHLLIACG, int NGOMPMICLHJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2304010", Offset = "0x2302E10", VA = "0x182304010")]
	public static T BPPOCFBLMGN<T>(byte[] EMGPHLLIACG, int NGOMPMICLHJ, FJOMMFMGKED KGHKAFFNKHL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x23042B0", Offset = "0x23030B0", VA = "0x1823042B0")]
	public static T BPPOCFBLMGN<T>(ref JDAEFHPGJAL IDIEIECFGPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x23045A0", Offset = "0x23033A0", VA = "0x1823045A0")]
	public static T BPPOCFBLMGN<T>(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED KGHKAFFNKHL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x23043B0", Offset = "0x23031B0", VA = "0x1823043B0")]
	public static T BPPOCFBLMGN<T>(Stream KHIILPEBNKK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x23046F0", Offset = "0x23034F0", VA = "0x1823046F0")]
	public static T BPPOCFBLMGN<T>(Stream KHIILPEBNKK, FJOMMFMGKED KGHKAFFNKHL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x58FD5F0", Offset = "0x58FC3F0", VA = "0x1858FD5F0")]
	public static string EIGILKEJKNM(byte[] DNAIGHGJNFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x58FD830", Offset = "0x58FC630", VA = "0x1858FD830")]
	public static string EIGILKEJKNM(byte[] DNAIGHGJNFN, int NGOMPMICLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x58FD720", Offset = "0x58FC520", VA = "0x1858FD720")]
	public static string EIGILKEJKNM(string DNAIGHGJNFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x58FD500", Offset = "0x58FC300", VA = "0x1858FD500")]
	public static byte[] CHCCKIFPMID(byte[] DNAIGHGJNFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x58FD440", Offset = "0x58FC240", VA = "0x1858FD440")]
	public static byte[] CHCCKIFPMID(byte[] DNAIGHGJNFN, int NGOMPMICLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x58FD360", Offset = "0x58FC160", VA = "0x1858FD360")]
	public static byte[] CHCCKIFPMID(string DNAIGHGJNFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x58FDB50", Offset = "0x58FC950", VA = "0x1858FDB50")]
	private static void NHCIMBCMEOA(ref JDAEFHPGJAL IDIEIECFGPN, ref FDOCIEKIOGE IMGJFGGFPOC, int JDFNCOHPHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x58FDA50", Offset = "0x58FC850", VA = "0x1858FDA50")]
	private static int IAFCPNLDHDM(Stream KOHCAKAAIGA, ref byte[] MMBEBPNKEHD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum HOBNOBEFPJI : byte
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
public struct FDOCIEKIOGE
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] BGHFCEILFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] MMBEBPNKEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int NGOMPMICLHJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int GBFDNAFECOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C8AD0", Offset = "0x7C78D0", VA = "0x1807C8AD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5197FE0", Offset = "0x5196DE0", VA = "0x185197FE0")]
	public void BMBGKCIIHCN(int NGOMPMICLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x590A560", Offset = "0x5909360", VA = "0x18590A560")]
	public static byte[] LNADDDMBMKA(string HANNKCHKNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x590AB50", Offset = "0x5909950", VA = "0x18590AB50")]
	public static byte[] OOOAAOCAONE(string HANNKCHKNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x590A3F0", Offset = "0x59091F0", VA = "0x18590A3F0")]
	public static byte[] LEMFJKJKIBL(string HANNKCHKNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x590A750", Offset = "0x5909550", VA = "0x18590A750")]
	public static byte[] ODNPDGKBEPA(string HANNKCHKNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xCAE460", Offset = "0xCAD260", VA = "0x180CAE460")]
	public FDOCIEKIOGE(byte[] NMMFCLGDABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x590A5E0", Offset = "0x59093E0", VA = "0x18590A5E0")]
	public ArraySegment<byte> LOGHFHCNLFB()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x590A8A0", Offset = "0x59096A0", VA = "0x18590A8A0")]
	public byte[] OIJMLFHHGEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x590AC70", Offset = "0x5909A70", VA = "0x18590AC70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5909D10", Offset = "0x5908B10", VA = "0x185909D10")]
	public void JCEMMEAGOBB(int ODHCAKALKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5655100", Offset = "0x5653F00", VA = "0x185655100")]
	public void OJLIOEMAOCO(byte HNKJDJNINLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x590AA70", Offset = "0x5909870", VA = "0x18590AA70")]
	public void OJLIOEMAOCO(byte[] HNKJDJNINLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5909B30", Offset = "0x5908930", VA = "0x185909B30")]
	public void EPFJEHBLEOM(byte HNKJDJNINLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5909AB0", Offset = "0x59088B0", VA = "0x185909AB0")]
	public void CIBFPKGDFEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5909B70", Offset = "0x5908970", VA = "0x185909B70")]
	public void FNNPBGGKDFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x590A510", Offset = "0x5909310", VA = "0x18590A510")]
	public void LJEJJHEMIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x590A4C0", Offset = "0x59092C0", VA = "0x18590A4C0")]
	public void LIMGNOMJAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x590AA20", Offset = "0x5909820", VA = "0x18590AA20")]
	public void OIKHEMJGPDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5909BC0", Offset = "0x59089C0", VA = "0x185909BC0")]
	public void GFBHNOFLAGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x590A6F0", Offset = "0x59094F0", VA = "0x18590A6F0")]
	public void NKEKDOICBLN(string HANNKCHKNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x590AC20", Offset = "0x5909A20", VA = "0x18590AC20")]
	public void PPKBHNCMJIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5909C10", Offset = "0x5908A10", VA = "0x185909C10")]
	public void GNLEMFEEAOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x590A0F0", Offset = "0x5908EF0", VA = "0x18590A0F0")]
	public void JPHINHMACGG(bool MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x590A370", Offset = "0x5909170", VA = "0x18590A370")]
	public void KKFCHJJCDCD(float MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x590AAD0", Offset = "0x59098D0", VA = "0x18590AAD0")]
	public void OJOFCABPIBL(double MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x590A340", Offset = "0x5909140", VA = "0x18590A340")]
	public void KHNEGKEIAAI(byte MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5909CE0", Offset = "0x5908AE0", VA = "0x185909CE0")]
	public void HPFGOJHNKKK(ushort MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x590A690", Offset = "0x5909490", VA = "0x18590A690")]
	public void MCOKPLDALMJ(uint MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5909A80", Offset = "0x5908880", VA = "0x185909A80")]
	public void BECPMGAMNCE(ulong MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x590A310", Offset = "0x5909110", VA = "0x18590A310")]
	public void KDIGGBOHKAK(sbyte MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x590A6C0", Offset = "0x59094C0", VA = "0x18590A6C0")]
	public void MIMHCOJGHON(short MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x590A2E0", Offset = "0x59090E0", VA = "0x18590A2E0")]
	public void KBIFDMKBNPP(int MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5909B00", Offset = "0x5908900", VA = "0x185909B00")]
	public void DANIMNEMHMI(long MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5909D20", Offset = "0x5908B20", VA = "0x185909D20")]
	public void JNNGHEFBBKF(string MGFMONLLLPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PAFFIOJJFKO : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private static class MDNHBDBIEFJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2CE0CA0", Offset = "0x2CDFAA0", VA = "0x182CE0CA0")]
		static MDNHBDBIEFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private PAFFIOJJFKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class HILMNAJCGNN
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> JJCLPMKLBBD;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5192C90", Offset = "0x5191A90", VA = "0x185192C90")]
	static HILMNAJCGNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5192580", Offset = "0x5191380", VA = "0x185192580")]
	internal static object KFBIJFEAFLN(Type DJCNOMGFLPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class CMLOOGGJBEK : global::HBFNKAIDHHG<Vector2>, BBDBBGCPFMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly OOEJKOKKMBP BIGIMIMIPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] ACKEPDHMKCI;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x59023E0", Offset = "0x59011E0", VA = "0x1859023E0")]
	public CMLOOGGJBEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5902230", Offset = "0x5901030", VA = "0x185902230", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, Vector2 MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x59020B0", Offset = "0x5900EB0", VA = "0x1859020B0", Slot = "5")]
	public Vector2 BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class LNEMJICFPCD : global::HBFNKAIDHHG<Vector3>, BBDBBGCPFMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly OOEJKOKKMBP BIGIMIMIPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] ACKEPDHMKCI;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x51A6A30", Offset = "0x51A5830", VA = "0x1851A6A30")]
	public LNEMJICFPCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x51A6910", Offset = "0x51A5710", VA = "0x1851A6910", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, Vector3 MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x51A65F0", Offset = "0x51A53F0", VA = "0x1851A65F0", Slot = "5")]
	public Vector3 BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class PHIHMFEGNPH : global::HBFNKAIDHHG<Vector4>, BBDBBGCPFMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly OOEJKOKKMBP BIGIMIMIPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] ACKEPDHMKCI;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x56562C0", Offset = "0x56550C0", VA = "0x1856562C0")]
	public PHIHMFEGNPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x51A7050", Offset = "0x51A5E50", VA = "0x1851A7050", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, Vector4 MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5656030", Offset = "0x5654E30", VA = "0x185656030", Slot = "5")]
	public Vector4 BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class COABCKACHFP : global::HBFNKAIDHHG<Quaternion>, BBDBBGCPFMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly OOEJKOKKMBP BIGIMIMIPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] ACKEPDHMKCI;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5902CC0", Offset = "0x5901AC0", VA = "0x185902CC0")]
	public COABCKACHFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5902960", Offset = "0x5901760", VA = "0x185902960", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, Quaternion MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5902740", Offset = "0x5901540", VA = "0x185902740", Slot = "5")]
	public Quaternion BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class LNGJDKNDNAB : global::HBFNKAIDHHG<Color>, BBDBBGCPFMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly OOEJKOKKMBP BIGIMIMIPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] ACKEPDHMKCI;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x51A71A0", Offset = "0x51A5FA0", VA = "0x1851A71A0")]
	public LNGJDKNDNAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x51A7050", Offset = "0x51A5E50", VA = "0x1851A7050", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, Color MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x51A6CD0", Offset = "0x51A5AD0", VA = "0x1851A6CD0", Slot = "5")]
	public Color BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class IIMLDJIBPOK : global::HBFNKAIDHHG<Bounds>, BBDBBGCPFMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly OOEJKOKKMBP BIGIMIMIPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] ACKEPDHMKCI;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x51963C0", Offset = "0x51951C0", VA = "0x1851963C0")]
	public IIMLDJIBPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5196220", Offset = "0x5195020", VA = "0x185196220", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, Bounds MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5195E00", Offset = "0x5194C00", VA = "0x185195E00", Slot = "5")]
	public Bounds BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class PHBKDGDPNKG : global::HBFNKAIDHHG<Rect>, BBDBBGCPFMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly OOEJKOKKMBP BIGIMIMIPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] ACKEPDHMKCI;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5655CC0", Offset = "0x5654AC0", VA = "0x185655CC0")]
	public PHBKDGDPNKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5655B50", Offset = "0x5654950", VA = "0x185655B50", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, Rect MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x56558A0", Offset = "0x56546A0", VA = "0x1856558A0", Slot = "5")]
	public Rect BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class BONJFJBHBLH : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private static class EFFLMOPDCDL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3224630", Offset = "0x3223430", VA = "0x183224630")]
		static EFFLMOPDCDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private BONJFJBHBLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class HFMNIFGEIAD : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private static class NLMCNFEICOB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x36FD5E0", Offset = "0x36FC3E0", VA = "0x1836FD5E0")]
		static NLMCNFEICOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class POBKJNNHIPN
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> FDFJIFMLEEA;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x56570C0", Offset = "0x5655EC0", VA = "0x1856570C0")]
		internal static object KFBIJFEAFLN(Type DJCNOMGFLPK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private HFMNIFGEIAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class MKGFPKPKMHK : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class KPABPGNCKEH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x465EB90", Offset = "0x465D990", VA = "0x18465EB90")]
		static KPABPGNCKEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly MKGFPKPKMHK NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool IBONGAKDDMK;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static BBDBBGCPFMC[] LPLLJCLAENK;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static FJOMMFMGKED[] OPGPKJJNFLP;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private MKGFPKPKMHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x564CC20", Offset = "0x564BA20", VA = "0x18564CC20")]
	public static void GLJEDJEGGBC(params FJOMMFMGKED[] OPGPKJJNFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x564CD00", Offset = "0x564BB00", VA = "0x18564CD00")]
	public static void GLJEDJEGGBC(params BBDBBGCPFMC[] LPLLJCLAENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x564CDE0", Offset = "0x564BBE0", VA = "0x18564CDE0")]
	public static void LIHECFMKIGO(BBDBBGCPFMC[] LPLLJCLAENK, FJOMMFMGKED[] OPGPKJJNFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class GHBAIIHDOEM : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private static class CLHNDCCBPFH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2DC9290", Offset = "0x2DC8090", VA = "0x182DC9290")]
		static CLHNDCCBPFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private GHBAIIHDOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class NCFKDJKDBLH
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly FJOMMFMGKED ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly FJOMMFMGKED ICKHFAFLMMK;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly FJOMMFMGKED FJEBPLHKNEG;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly FJOMMFMGKED PNBDKNIFAHA;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly FJOMMFMGKED OBLDOPNGOBK;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly FJOMMFMGKED NJFLADIGHJI;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly FJOMMFMGKED NCJGKJDDGLK;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly FJOMMFMGKED DIPNMHALDDJ;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly FJOMMFMGKED KEPGFOOIODI;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly FJOMMFMGKED JIBJCDCAOPC;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly FJOMMFMGKED KHKIACIPHKG;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly FJOMMFMGKED DEJJJHIKOAG;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class ODCLFMLICGN
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly FJOMMFMGKED ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly FJOMMFMGKED HHICDPMONON;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class DFHFNLNFMMA
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly FJOMMFMGKED ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly FJOMMFMGKED ICKHFAFLMMK;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly FJOMMFMGKED FJEBPLHKNEG;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly FJOMMFMGKED PNBDKNIFAHA;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly FJOMMFMGKED OBLDOPNGOBK;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly FJOMMFMGKED NJFLADIGHJI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly FJOMMFMGKED NCJGKJDDGLK;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly FJOMMFMGKED DIPNMHALDDJ;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly FJOMMFMGKED KEPGFOOIODI;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly FJOMMFMGKED JIBJCDCAOPC;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly FJOMMFMGKED KHKIACIPHKG;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly FJOMMFMGKED DEJJJHIKOAG;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class LNONJIIMNLO
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> FDFJIFMLEEA;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x51A75F0", Offset = "0x51A63F0", VA = "0x1851A75F0")]
	internal static object KFBIJFEAFLN(Type DJCNOMGFLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x51A75B0", Offset = "0x51A63B0", VA = "0x1851A75B0")]
	private static object EFBGEKADCPB(Type NKIMLIHAJAL, Type[] KHMGHAIIPON, params object[] DFIBGBEICJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class HIJBEJEBEJP : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private static class JHJAMDMPOJO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2A532E0", Offset = "0x2A520E0", VA = "0x182A532E0")]
		static JHJAMDMPOJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> AJCMALHBONO;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool OBCAIOPCBBA;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly HNBNHHJBCAE PJCHMBMFLGD;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5192450", Offset = "0x5191250", VA = "0x185192450")]
	static HIJBEJEBEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private HIJBEJEBEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class FNMMNEFLEOO : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private static class FECILANFJOB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A5F850", Offset = "0x2A5E650", VA = "0x182A5F850")]
		static FECILANFJOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> AJCMALHBONO;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool OBCAIOPCBBA;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly HNBNHHJBCAE PJCHMBMFLGD;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x590C900", Offset = "0x590B700", VA = "0x18590C900")]
	static FNMMNEFLEOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private FNMMNEFLEOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class JNNDGCMFGNO : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class LPMOLIJKHPG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3A9F1E0", Offset = "0x3A9DFE0", VA = "0x183A9F1E0")]
		static LPMOLIJKHPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> AJCMALHBONO;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool OBCAIOPCBBA;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly HNBNHHJBCAE PJCHMBMFLGD;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x519B890", Offset = "0x519A690", VA = "0x18519B890")]
	static JNNDGCMFGNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private JNNDGCMFGNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class JIJEFAKKAAE : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class IIFOFPMIOAL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1E039C0", Offset = "0x1E027C0", VA = "0x181E039C0")]
		static IIFOFPMIOAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> AJCMALHBONO;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool OBCAIOPCBBA;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly HNBNHHJBCAE PJCHMBMFLGD;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x519AFB0", Offset = "0x5199DB0", VA = "0x18519AFB0")]
	static JIJEFAKKAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private JIJEFAKKAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class PPHCFHLPAKK : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class ADMOKJGMIAJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1C60", Offset = "0x2BA0A60", VA = "0x182BA1C60")]
		static ADMOKJGMIAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> AJCMALHBONO;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool OBCAIOPCBBA;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly HNBNHHJBCAE PJCHMBMFLGD;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5659030", Offset = "0x5657E30", VA = "0x185659030")]
	static PPHCFHLPAKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private PPHCFHLPAKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class FKGFLODEAOE : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class ADHLAOCIOBA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C810", Offset = "0x2B9B610", VA = "0x182B9C810")]
		static ADHLAOCIOBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> AJCMALHBONO;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool OBCAIOPCBBA;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly HNBNHHJBCAE PJCHMBMFLGD;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x590C670", Offset = "0x590B470", VA = "0x18590C670")]
	static FKGFLODEAOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private FKGFLODEAOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class NODCKMBAOJF : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class PFOCNDEIODC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2005200", Offset = "0x2004000", VA = "0x182005200")]
		static PFOCNDEIODC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> AJCMALHBONO;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool OBCAIOPCBBA;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public NODCKMBAOJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class BCLPCBPMJDK : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class NLNPOPBNAHB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x36FEBF0", Offset = "0x36FD9F0", VA = "0x1836FEBF0")]
		static NLNPOPBNAHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> AJCMALHBONO;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool OBCAIOPCBBA;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public BCLPCBPMJDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class GIABLHJIGKA : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class LEFJKHENNOB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2852520", Offset = "0x2851320", VA = "0x182852520")]
		static LEFJKHENNOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> AJCMALHBONO;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool OBCAIOPCBBA;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public GIABLHJIGKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class LNLDOPLFFFM : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class DPLCAHHEKBB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x419BEF0", Offset = "0x419ACF0", VA = "0x18419BEF0")]
		static DPLCAHHEKBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> AJCMALHBONO;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool OBCAIOPCBBA;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public LNLDOPLFFFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class DEMPPPCDFNM : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class LENPEMNFNME<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2854890", Offset = "0x2853690", VA = "0x182854890")]
		static LENPEMNFNME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> AJCMALHBONO;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool OBCAIOPCBBA;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public DEMPPPCDFNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class KDMLBJIMBED : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class LMHHFCDADPG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3A98720", Offset = "0x3A97520", VA = "0x183A98720")]
		static LMHHFCDADPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> AJCMALHBONO;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool OBCAIOPCBBA;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KDMLBJIMBED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal static class LKKIFMHJBOF
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private struct ODEOFNIGCKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public IJEPCDCELDM NALJONFKLDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder HBCEOPLFIHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder NACNKGPFHCJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class OACOFKDEEJL
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		internal static class IBLLEDPPIFI
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo LEMFJKJKIBL;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo OOOAAOCAONE;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo ODNPDGKBEPA;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo LNADDDMBMKA;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo GNLEMFEEAOL;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo OJLIOEMAOCO;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo LJEJJHEMIHO;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo LIMGNOMJAJC;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo OIKHEMJGPDK;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x5648E50", Offset = "0x5647C50", VA = "0x185648E50")]
			static IBLLEDPPIFI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		internal static class BGPLCKGLEEO
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo GACDPIALJJA;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo ELJIDGOJMLN;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo DENJAFJCOCL;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo EKIDBKJGPNL;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo HMACHLLNCFC;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo BMHGMFHEMOM;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo EGMBGAACDBJ;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x56447E0", Offset = "0x56435E0", VA = "0x1856447E0")]
			static BGPLCKGLEEO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class LCLJOHOFMAO
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo INLKBPFHNKL;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo ENBNCBMHEHO;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo ILCHDGDKEEL;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo DICNINJDPHH;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo HJLBLDNPOOG;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo KBKOJEIGNFI;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo PMIJPLBLDPP;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo KGOEEEKBHEL;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo LAIGBEHIBOP;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo IDLIJLFBGDO;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo DHLOLDLJCLA;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo EPCJBIBHNOG;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo FJNMEPAELKP;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo FHGNCHPBOBB;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5650220", Offset = "0x564F020", VA = "0x185650220")]
		public static MethodInfo EPOBOPBJBKM(Type LEDIIMFEFLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x564FFB0", Offset = "0x564EDB0", VA = "0x18564FFB0")]
		public static MethodInfo BPPOCFBLMGN(Type LEDIIMFEFLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x564FE70", Offset = "0x564EC70", VA = "0x18564FE70")]
		public static MethodInfo BEBFKNMDHIA(Type LEDIIMFEFLP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class PJFHCNGLBHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<IJEPCDCELDM, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public PJFHCNGLBHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class JKBDCOFGCDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public PJFHCNGLBHM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public JKBDCOFGCDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5649DF0", Offset = "0x5648BF0", VA = "0x185649DF0")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5649E30", Offset = "0x5648C30", VA = "0x185649E30")]
		internal bool <BuildType>b__2(int index, IJEPCDCELDM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class NHANJGELJEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public PJFHCNGLBHM CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public NHANJGELJEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x564ED80", Offset = "0x564DB80", VA = "0x18564ED80")]
		internal bool <BuildType>b__3(int index, IJEPCDCELDM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class GMJKFHABPKO
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
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public GMJKFHABPKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5648C50", Offset = "0x5647A50", VA = "0x185648C50")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class CJEPGJHDBME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public CJEPGJHDBME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x56454F0", Offset = "0x56442F0", VA = "0x1856454F0")]
		internal bool <BuildAnonymousFormatter>b__2(IJEPCDCELDM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class PCIMLFGGMCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public GMJKFHABPKO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public PCIMLFGGMCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5655300", Offset = "0x5654100", VA = "0x185655300")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5655310", Offset = "0x5654110", VA = "0x185655310")]
		internal bool <BuildAnonymousFormatter>b__6(int index, IJEPCDCELDM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class HBBFJONLANB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public GMJKFHABPKO CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public HBBFJONLANB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5648CB0", Offset = "0x5647AB0", VA = "0x185648CB0")]
		internal bool <BuildAnonymousFormatter>b__7(int index, IJEPCDCELDM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class IEOIHOJCPPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public IEOIHOJCPPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x76C160", Offset = "0x76AF60", VA = "0x18076C160")]
		internal Label <BuildSerialize>b__1(IJEPCDCELDM _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class GAKGEOPODOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public ODEOFNIGCKK[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, IJEPCDCELDM, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public EBNHNFAJOBH argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public EBNHNFAJOBH argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public GAKGEOPODOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5648110", Offset = "0x5646F10", VA = "0x185648110")]
		internal ODEOFNIGCKK <BuildDeserialize>b__0(IJEPCDCELDM item)
		{
			return default(ODEOFNIGCKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class NPIKLFFPBCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public GAKGEOPODOH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public NPIKLFFPBCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x564FB20", Offset = "0x564E920", VA = "0x18564FB20")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x564FDD0", Offset = "0x564EBD0", VA = "0x18564FDD0")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class GPLKAEMGDEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public IJEPCDCELDM item;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public GPLKAEMGDEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x11FA3A0", Offset = "0x11F91A0", VA = "0x1811FA3A0")]
		internal bool <EmitNewObject>b__0(ODEOFNIGCKK x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class HHDKKFGECCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public IJEPCDCELDM item;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public HHDKKFGECCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x11FA3A0", Offset = "0x11F91A0", VA = "0x1811FA3A0")]
		internal bool <EmitNewObject>b__2(ODEOFNIGCKK x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex IGJEOIGACHM;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int OGMHKDBGEEP;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> HIFBAONOIKE;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> FBECHNLAHDB;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x27C56D0", Offset = "0x27C44D0", VA = "0x1827C56D0")]
	public static object GMCMLLEOLOI<T>(HNBNHHJBCAE PJCHMBMFLGD, FJOMMFMGKED IENCECDKDAP, Func<string, string> AJCMALHBONO, bool OBCAIOPCBBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x27D10D0", Offset = "0x27CFED0", VA = "0x1827D10D0")]
	public static object IHKAAKPLDHB<T>(FJOMMFMGKED IENCECDKDAP, Func<string, string> AJCMALHBONO, bool OBCAIOPCBBA, bool ILJPPMKCCFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x519F8D0", Offset = "0x519E6D0", VA = "0x18519F8D0")]
	private static TypeInfo BDKCJNMGIPC(HNBNHHJBCAE PJCHMBMFLGD, Type LEDIIMFEFLP, Func<string, string> AJCMALHBONO, bool OBCAIOPCBBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x51A3BA0", Offset = "0x51A29A0", VA = "0x1851A3BA0")]
	public static object NFDNKPHMNBN(Type LEDIIMFEFLP, Func<string, string> AJCMALHBONO, bool OBCAIOPCBBA, bool ILJPPMKCCFH, bool GFDEFCOBIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x51A58D0", Offset = "0x51A46D0", VA = "0x1851A58D0")]
	private static Dictionary<IJEPCDCELDM, FieldInfo> OLENADFPILA(TypeBuilder KPCPDPHAFKL, ANGMAPOMDLF PFBGGFHJPLL, ConstructorInfo LECLKHHDNBM, FieldBuilder JDENKCJJAKF, ILGenerator CKMPJBHDCMK, bool OBCAIOPCBBA, bool GAIFCGMNMBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x51A3520", Offset = "0x51A2320", VA = "0x1851A3520")]
	private static Dictionary<IJEPCDCELDM, FieldInfo> KLIHKJMHPDA(TypeBuilder KPCPDPHAFKL, ANGMAPOMDLF PFBGGFHJPLL, ILGenerator CKMPJBHDCMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x519E3B0", Offset = "0x519D1B0", VA = "0x18519E3B0")]
	private static void AIFENCOEIEG(Type LEDIIMFEFLP, ANGMAPOMDLF PFBGGFHJPLL, ILGenerator CKMPJBHDCMK, Action ADGJHPAFGNH, Func<int, IJEPCDCELDM, bool> JGDLAAMGJIJ, bool OBCAIOPCBBA, bool GAIFCGMNMBB, int CPBOIECMCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x51A2410", Offset = "0x51A1210", VA = "0x1851A2410")]
	private static void CIIJIJJBPDG(TypeInfo LEDIIMFEFLP, IJEPCDCELDM DNFACCLDKEC, ILGenerator CKMPJBHDCMK, int NNHNOIMLALG, Func<int, IJEPCDCELDM, bool> JGDLAAMGJIJ, EBNHNFAJOBH IMGJFGGFPOC, EBNHNFAJOBH DFNLNJAEEIN, EBNHNFAJOBH CBPPIDJDHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x51A1010", Offset = "0x519FE10", VA = "0x1851A1010")]
	private static void CHHCNLMCEBN(Type LEDIIMFEFLP, ANGMAPOMDLF PFBGGFHJPLL, ILGenerator CKMPJBHDCMK, Func<int, IJEPCDCELDM, bool> JGDLAAMGJIJ, bool PIOIGMFAHCN, int CPBOIECMCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x51A2960", Offset = "0x51A1760", VA = "0x1851A2960")]
	private static void GLFPANNEMOM(ILGenerator CKMPJBHDCMK, ODEOFNIGCKK PFBGGFHJPLL, int NNHNOIMLALG, Func<int, IJEPCDCELDM, bool> JGDLAAMGJIJ, EBNHNFAJOBH IDIEIECFGPN, EBNHNFAJOBH CBPPIDJDHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x51A0360", Offset = "0x519F160", VA = "0x1851A0360")]
	private static LocalBuilder CELAJLDKHAG(ILGenerator CKMPJBHDCMK, Type LEDIIMFEFLP, ANGMAPOMDLF PFBGGFHJPLL, ODEOFNIGCKK[] NNDDFFAOIBD, bool MCEEHNHHHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x51A2E20", Offset = "0x51A1C20", VA = "0x1851A2E20")]
	private static bool IAKKADHNHBO(ConstructorInfo AIKGPIINDNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x51A5720", Offset = "0x51A4520", VA = "0x1851A5720")]
	private static bool OFKKMHAJBKC(Type LEDIIMFEFLP, out Type MCNAKOGJGPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal delegate void JCBHMAMDHEE<T>(byte[][] JDENKCJJAKF, object[] CLLOCINGMJJ, ref FDOCIEKIOGE IMGJFGGFPOC, T MGFMONLLLPD, FJOMMFMGKED KGHKAFFNKHL);
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal delegate T PBAKKFKJFEP<T>(object[] CLLOCINGMJJ, ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED KGHKAFFNKHL);
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class HMHPCJKJEGB<T> : global::HBFNKAIDHHG<T>, BBDBBGCPFMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] JDENKCJJAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] CCBIMLCMFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] PNACMHFKCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly global::JCBHMAMDHEE<T> MCALMAAGBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly global::PBAKKFKJFEP<T> LKNLKLMOPFA;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2E182E0", Offset = "0x2E170E0", VA = "0x182E182E0")]
	public HMHPCJKJEGB(byte[][] JDENKCJJAKF, object[] CCBIMLCMFLP, object[] PNACMHFKCML, global::JCBHMAMDHEE<T> MCALMAAGBHP, global::PBAKKFKJFEP<T> LKNLKLMOPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x35F2560", Offset = "0x35F1360", VA = "0x1835F2560", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, T MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x35F2490", Offset = "0x35F1290", VA = "0x1835F2490", Slot = "5")]
	public T BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal sealed class DGJENCEDOLG : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private static class ELJKFDMHKED<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x434B570", Offset = "0x434A370", VA = "0x18434B570")]
		static ELJKFDMHKED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private DGJENCEDOLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class AMMJNDKMNBL : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private static class HCDLKDBLBOO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3DB1A00", Offset = "0x3DB0800", VA = "0x183DB1A00")]
		static HCDLKDBLBOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private AMMJNDKMNBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal static class NKBECPOLAME
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly FJOMMFMGKED[] HDENMPMJBNM;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal sealed class CFEHDIHEEJF : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private static class MLKHBLKJAGD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x30D41D0", Offset = "0x30D2FD0", VA = "0x1830D41D0")]
		static MLKHBLKJAGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private sealed class GHNFIDPAPIH : FJOMMFMGKED
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		private static class KHAGBMIKJOF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x23580B0", Offset = "0x2356EB0", VA = "0x1823580B0")]
			static KHAGBMIKJOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly FJOMMFMGKED NHLDGJJELOO;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly FJOMMFMGKED[] OPGPKJJNFLP;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		private GHNFIDPAPIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
		public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly global::HBFNKAIDHHG<object> DBGPKMFMAEF;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private CFEHDIHEEJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class JFJELLNLCPF : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class GBHPAHDLLOP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3C93C70", Offset = "0x3C92A70", VA = "0x183C93C70")]
		static GBHPAHDLLOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class LENAJOFIGLH : FJOMMFMGKED
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class OLPIJGLOEAA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x2547990", Offset = "0x2546790", VA = "0x182547990")]
			static OLPIJGLOEAA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly FJOMMFMGKED NHLDGJJELOO;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly FJOMMFMGKED[] OPGPKJJNFLP;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		private LENAJOFIGLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
		public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly global::HBFNKAIDHHG<object> DBGPKMFMAEF;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private JFJELLNLCPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class JGBAHBHJLJF : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class BBBEJINLGFL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x38DA120", Offset = "0x38D8F20", VA = "0x1838DA120")]
		static BBBEJINLGFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class KMFNGKAFPCI : FJOMMFMGKED
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class BEDJMMJEFIG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x38E5DC0", Offset = "0x38E4BC0", VA = "0x1838E5DC0")]
			static BEDJMMJEFIG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly FJOMMFMGKED NHLDGJJELOO;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly FJOMMFMGKED[] OPGPKJJNFLP;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		private KMFNGKAFPCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
		public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly global::HBFNKAIDHHG<object> DBGPKMFMAEF;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private JGBAHBHJLJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class AALPEKDHEHE : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class KKNIPDMDLDH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3010F50", Offset = "0x300FD50", VA = "0x183010F50")]
		static KKNIPDMDLDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class MIBCPJDCIOH : FJOMMFMGKED
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class KMNDHCNMNEO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x301A320", Offset = "0x3019120", VA = "0x18301A320")]
			static KMNDHCNMNEO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly FJOMMFMGKED NHLDGJJELOO;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly FJOMMFMGKED[] OPGPKJJNFLP;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		private MIBCPJDCIOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
		public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly global::HBFNKAIDHHG<object> DBGPKMFMAEF;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private AALPEKDHEHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class MJMMJJMFGGC : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class CEMFOLGKLIB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2DA8A80", Offset = "0x2DA7880", VA = "0x182DA8A80")]
		static CEMFOLGKLIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class IDHPJCAAPJB : FJOMMFMGKED
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class AOJNLBMKHBI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x34D9510", Offset = "0x34D8310", VA = "0x1834D9510")]
			static AOJNLBMKHBI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly FJOMMFMGKED NHLDGJJELOO;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly FJOMMFMGKED[] OPGPKJJNFLP;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		private IDHPJCAAPJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
		public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly global::HBFNKAIDHHG<object> DBGPKMFMAEF;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private MJMMJJMFGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class GIMNFFNIEDO : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class HAGIBHAGNFM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3DAB5C0", Offset = "0x3DAA3C0", VA = "0x183DAB5C0")]
		static HAGIBHAGNFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class PMEPFNNIDOB : FJOMMFMGKED
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class JKBFMCIBJLJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x26C1360", Offset = "0x26C0160", VA = "0x1826C1360")]
			static JKBFMCIBJLJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly FJOMMFMGKED NHLDGJJELOO;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly FJOMMFMGKED[] OPGPKJJNFLP;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		private PMEPFNNIDOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
		public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly global::HBFNKAIDHHG<object> DBGPKMFMAEF;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private GIMNFFNIEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class FLJIINOOHOE : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class ILAOHBDBEGM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x1E13020", Offset = "0x1E11E20", VA = "0x181E13020")]
		static ILAOHBDBEGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class DCCMDMAHAKC : FJOMMFMGKED
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class LJFHDJNJMKG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x3A92C30", Offset = "0x3A91A30", VA = "0x183A92C30")]
			static LJFHDJNJMKG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly FJOMMFMGKED NHLDGJJELOO;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly FJOMMFMGKED[] OPGPKJJNFLP;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		private DCCMDMAHAKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
		public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly global::HBFNKAIDHHG<object> DBGPKMFMAEF;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private FLJIINOOHOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class KBPCKHIKLLH : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class DCNBALIJLFA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2F89CB0", Offset = "0x2F88AB0", VA = "0x182F89CB0")]
		static DCNBALIJLFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class GEJGIANBNHA : FJOMMFMGKED
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class GCPOIKJOHMI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x3C95940", Offset = "0x3C94740", VA = "0x183C95940")]
			static GCPOIKJOHMI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly FJOMMFMGKED NHLDGJJELOO;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly FJOMMFMGKED[] OPGPKJJNFLP;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		private GEJGIANBNHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
		public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly global::HBFNKAIDHHG<object> DBGPKMFMAEF;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private KBPCKHIKLLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class AGPPNGKCBMI : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class PJKNDEADAAM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2010B50", Offset = "0x200F950", VA = "0x182010B50")]
		static PJKNDEADAAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class AHFLPMCLAAO : FJOMMFMGKED
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class NIABLLNCEFC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x31B7C70", Offset = "0x31B6A70", VA = "0x1831B7C70")]
			static NIABLLNCEFC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly FJOMMFMGKED NHLDGJJELOO;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly FJOMMFMGKED[] OPGPKJJNFLP;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		private AHFLPMCLAAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
		public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly global::HBFNKAIDHHG<object> DBGPKMFMAEF;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private AGPPNGKCBMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class AJGNEONJMIG : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class HHHJGGOPCFK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x35E0FA0", Offset = "0x35DFDA0", VA = "0x1835E0FA0")]
		static HHHJGGOPCFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class JNODODEHFFH : FJOMMFMGKED
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class NGGAPBDMMDB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x31B51B0", Offset = "0x31B3FB0", VA = "0x1831B51B0")]
			static NGGAPBDMMDB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly FJOMMFMGKED NHLDGJJELOO;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly FJOMMFMGKED[] OPGPKJJNFLP;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		private JNODODEHFFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
		public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly global::HBFNKAIDHHG<object> DBGPKMFMAEF;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private AJGNEONJMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class PFMGHDONAOB : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class CKOGLBDBMJM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2DC46F0", Offset = "0x2DC34F0", VA = "0x182DC46F0")]
		static CKOGLBDBMJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class KJOALPEFLKI : FJOMMFMGKED
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class KKKDNEMJABL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x300D6B0", Offset = "0x300C4B0", VA = "0x18300D6B0")]
			static KKKDNEMJABL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly FJOMMFMGKED NHLDGJJELOO;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly FJOMMFMGKED[] OPGPKJJNFLP;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		private KJOALPEFLKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
		public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly global::HBFNKAIDHHG<object> DBGPKMFMAEF;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private PFMGHDONAOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class CNGKMNLJLNN : FJOMMFMGKED
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class AKPNFFBBAEA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x24EB260", Offset = "0x24EA060", VA = "0x1824EB260")]
		static AKPNFFBBAEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class NEFEMMNFGJP : FJOMMFMGKED
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class GGCIJJODEKM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly global::HBFNKAIDHHG<T> LHPLKAEGJJO;

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x32CE8E0", Offset = "0x32CD6E0", VA = "0x1832CE8E0")]
			static GGCIJJODEKM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly FJOMMFMGKED NHLDGJJELOO;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly FJOMMFMGKED[] OPGPKJJNFLP;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		private NEFEMMNFGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
		public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly FJOMMFMGKED NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly global::HBFNKAIDHHG<object> DBGPKMFMAEF;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	private CNGKMNLJLNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x16436E0", Offset = "0x16424E0", VA = "0x1816436E0", Slot = "4")]
	public global::HBFNKAIDHHG<T> KFBIJFEAFLN<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct MAIHNKKODJD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] FEAOENNEFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int OGFGLCKEPLA;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA980", Offset = "0x2CD9780", VA = "0x182CDA980")]
	public MAIHNKKODJD(int OPKOKMOCMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA540", Offset = "0x2CD9340", VA = "0x182CDA540")]
	public void OEECIDDHIAM(T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA4B0", Offset = "0x2CD92B0", VA = "0x182CDA4B0")]
	public T[] NEECKNOMDLH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
internal sealed class MNJPKDGDPED : global::CDJDHMILGMC<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly MNJPKDGDPED ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x564DAE0", Offset = "0x564C8E0", VA = "0x18564DAE0")]
	public MNJPKDGDPED(int NBECFOLNOPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal class CDJDHMILGMC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int NBECFOLNOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object AFAHPKPIMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int NNHNOIMLALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] MGGJHHKKMMJ;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x316F540", Offset = "0x316E340", VA = "0x18316F540")]
	public CDJDHMILGMC(int NBECFOLNOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x316EE10", Offset = "0x316DC10", VA = "0x18316EE10")]
	public T[] GKNAKCHKNGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x316EA20", Offset = "0x316D820", VA = "0x18316EA20")]
	public void GGOOBADMCCO(T[] PALKODKBAJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class OOEJKOKKMBP : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private class MAECHMDDLKL : IComparable<MAECHMDDLKL>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class FOHIDKHLPFA : IEnumerable<MAECHMDDLKL>, IEnumerable, IEnumerator<MAECHMDDLKL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private MAECHMDDLKL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public MAECHMDDLKL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private MAECHMDDLKL System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F0")]
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x91D1E0", Offset = "0x91BFE0", VA = "0x18091D1E0")]
			[DebuggerHidden]
			public FOHIDKHLPFA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x5647960", Offset = "0x5646760", VA = "0x185647960", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x5647A90", Offset = "0x5646890", VA = "0x185647A90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x56479F0", Offset = "0x56467F0", VA = "0x1856479F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<MAECHMDDLKL> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x56479F0", Offset = "0x56467F0", VA = "0x1856479F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class PAELMEJGHPF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public PAELMEJGHPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x76C160", Offset = "0x76AF60", VA = "0x18076C160")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x76C160", Offset = "0x76AF60", VA = "0x18076C160")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly MAECHMDDLKL[] BDGLPBNGIPB;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] CONEEOPFNDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong MPJCJINPOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int KCKILJPPPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string FDDNLDAECCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private MAECHMDDLKL[] PDAICEMPNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] KGLFIBNCLLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int MNBBKKLFBKD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool IKJPJMIKCLH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xD58460", Offset = "0xD57260", VA = "0x180D58460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x564C3C0", Offset = "0x564B1C0", VA = "0x18564C3C0")]
		public MAECHMDDLKL(ulong JHANOPJHOLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x564BF50", Offset = "0x564AD50", VA = "0x18564BF50")]
		public MAECHMDDLKL OEECIDDHIAM(ulong JHANOPJHOLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x564BF00", Offset = "0x564AD00", VA = "0x18564BF00")]
		public MAECHMDDLKL OEECIDDHIAM(ulong JHANOPJHOLP, int MGFMONLLLPD, string FDDNLDAECCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x564AFB0", Offset = "0x5649DB0", VA = "0x18564AFB0")]
		public MAECHMDDLKL CLDMLMKGJMP(byte[] NDFOGNBCBPD, ref int NGOMPMICLHJ, ref int HOHKJGEMBGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x564B190", Offset = "0x5649F90", VA = "0x18564B190")]
		internal static int HFLOMLFMJFB(ulong[] PALKODKBAJM, int NNHNOIMLALG, int PFLGNDMCMIN, ulong MGFMONLLLPD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x564B160", Offset = "0x5649F60", VA = "0x18564B160", Slot = "4")]
		public int CompareTo(MAECHMDDLKL IDBPJJAKCBN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x564C2C0", Offset = "0x564B0C0", VA = "0x18564C2C0")]
		[IteratorStateMachine(typeof(FOHIDKHLPFA))]
		public IEnumerable<MAECHMDDLKL> PANKLBPDMFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x564C180", Offset = "0x564AF80", VA = "0x18564C180")]
		public void OIHFLHJHODF(ILGenerator CKMPJBHDCMK, LocalBuilder NDFOGNBCBPD, LocalBuilder HOHKJGEMBGM, LocalBuilder JHANOPJHOLP, Action<KeyValuePair<string, int>> FAEMCIBCCAO, Action ABGMOJIBNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x564B210", Offset = "0x564A010", VA = "0x18564B210")]
		private static void IKHNAJCGMNK(ILGenerator CKMPJBHDCMK, LocalBuilder NDFOGNBCBPD, LocalBuilder HOHKJGEMBGM, LocalBuilder JHANOPJHOLP, Action<KeyValuePair<string, int>> FAEMCIBCCAO, Action ABGMOJIBNEB, MAECHMDDLKL[] PDAICEMPNFJ, int MNBBKKLFBKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class GAHEOKEANMG : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<MAECHMDDLKL> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<MAECHMDDLKL> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<MAECHMDDLKL> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private MAECHMDDLKL <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x7621D0", Offset = "0x760FD0", VA = "0x1807621D0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5647F40", Offset = "0x5646D40", VA = "0x185647F40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x9D05F0", Offset = "0x9CF3F0", VA = "0x1809D05F0")]
		[DebuggerHidden]
		public GAHEOKEANMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x5647F90", Offset = "0x5646D90", VA = "0x185647F90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5647AD0", Offset = "0x56468D0", VA = "0x185647AD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x5648070", Offset = "0x5646E70", VA = "0x185648070")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x56480C0", Offset = "0x5646EC0", VA = "0x1856480C0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x5647F00", Offset = "0x5646D00", VA = "0x185647F00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5647E60", Offset = "0x5646C60", VA = "0x185647E60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5647E60", Offset = "0x5646C60", VA = "0x185647E60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly MAECHMDDLKL LFLMFMLCFKL;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5654DC0", Offset = "0x5653BC0", VA = "0x185654DC0")]
	public OOEJKOKKMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5654C10", Offset = "0x5653A10", VA = "0x185654C10")]
	public void OEECIDDHIAM(byte[] EMGPHLLIACG, int MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x56547B0", Offset = "0x56535B0", VA = "0x1856547B0")]
	public bool DPHEMFJODLP(ArraySegment<byte> JHANOPJHOLP, out int MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5654D30", Offset = "0x5653B30", VA = "0x185654D30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5654870", Offset = "0x5653670", VA = "0x185654870")]
	private static void EFNLDIBCJHD(IEnumerable<MAECHMDDLKL> PDAICEMPNFJ, StringBuilder NELGNHHJHBG, int JDFNCOHPHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5654B10", Offset = "0x5653910", VA = "0x185654B10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5654B10", Offset = "0x5653910", VA = "0x185654B10", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5654B70", Offset = "0x5653970", VA = "0x185654B70")]
	[IteratorStateMachine(typeof(GAHEOKEANMG))]
	private static IEnumerable<KeyValuePair<string, int>> HLPNEGFCOBA(IEnumerable<MAECHMDDLKL> PDAICEMPNFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5654BE0", Offset = "0x56539E0", VA = "0x185654BE0")]
	public void KDHOAKMJDDA(ILGenerator CKMPJBHDCMK, LocalBuilder NDFOGNBCBPD, LocalBuilder HOHKJGEMBGM, LocalBuilder JHANOPJHOLP, Action<KeyValuePair<string, int>> FAEMCIBCCAO, Action ABGMOJIBNEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public static class FGDEFODGDFP
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo JLAJLJPLMGA;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x590AD30", Offset = "0x5909B30", VA = "0x18590AD30")]
	public static ulong EPHBCPNFPCD(byte[] EMGPHLLIACG, ref int NGOMPMICLHJ, ref int HOHKJGEMBGM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class FANPBOBHPKF
{
	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5909830", Offset = "0x5908630", VA = "0x185909830")]
	public static void JCEMMEAGOBB(ref byte[] EMGPHLLIACG, int NGOMPMICLHJ, int ODHCAKALKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5909970", Offset = "0x5908770", VA = "0x185909970")]
	public static void NHDNGMIOKHC(ref byte[] PALKODKBAJM, int EPJNKNCDEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5909710", Offset = "0x5908510", VA = "0x185909710")]
	public static byte[] FNMLNAHEHCO(byte[] EKDHPMHGKLM, int EPJNKNCDEGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class BIDEPOCJJGF
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5900A10", Offset = "0x58FF810", VA = "0x185900A10")]
	public static bool JBPDPAIMCKC(byte[] NNJHFAIICLP, int ECLGFJODINK, int NLIOKPFNPGM, byte[] OOPBFPEHIOB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class DGEAHOGJKBB<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private struct AIOCPCIHNJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] MPJCJINPOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T KCKILJPPPGI;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x24D8740", Offset = "0x24D7540", VA = "0x1824D8740", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class HNJCLMBGEEG : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public global::DGEAHOGJKBB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private AIOCPCIHNJG[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private AIOCPCIHNJG[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x7621D0", Offset = "0x760FD0", VA = "0x1807621D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E0A620", Offset = "0x3E09420", VA = "0x183E0A620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1D036E0", Offset = "0x1D024E0", VA = "0x181D036E0")]
		[DebuggerHidden]
		public HNJCLMBGEEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3E08DC0", Offset = "0x3E07BC0", VA = "0x183E08DC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A2A0", Offset = "0x3E090A0", VA = "0x183E0A2A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly AIOCPCIHNJG[][] NGDOCMAADLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong KDDLLNGACPA;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4CAED80", Offset = "0x4CADB80", VA = "0x184CAED80")]
	public DGEAHOGJKBB(int JNGKGNOBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4CAECC0", Offset = "0x4CADAC0", VA = "0x184CAECC0")]
	public DGEAHOGJKBB(int JNGKGNOBDKI, float LLGLMNMGDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4CAE1C0", Offset = "0x4CACFC0", VA = "0x184CAE1C0")]
	public void OEECIDDHIAM(byte[] JHANOPJHOLP, T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x4CA88B0", Offset = "0x4CA76B0", VA = "0x184CA88B0")]
	private bool FLNOIHHPHCC(byte[] JHANOPJHOLP, T MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x4CA3A80", Offset = "0x4CA2880", VA = "0x184CA3A80")]
	public bool BOAPLFBFGDK(ArraySegment<byte> JHANOPJHOLP, out T MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x4CA0F60", Offset = "0x4C9FD60", VA = "0x184CA0F60")]
	private static ulong AEALFCIMADG(byte[] NHKCICGBPMI, int NGOMPMICLHJ, int MNBBKKLFBKD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x26C4A10", Offset = "0x26C3810", VA = "0x1826C4A10")]
	private static int LKKLJNNCNPE(int FIAGBFBGBLF, float LLGLMNMGDCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x4CACC00", Offset = "0x4CABA00", VA = "0x184CACC00", Slot = "4")]
	[IteratorStateMachine(typeof(global::DGEAHOGJKBB<>.HNJCLMBGEEG))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x26BC4D0", Offset = "0x26BB2D0", VA = "0x1826BC4D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
internal class EGJMHKKMCEK : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] CLLEBMDBBPI;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] MPDKCCHKNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int JICLJGOGLPK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool GGLLNFIOKLI
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x5908DD0", Offset = "0x5907BD0", VA = "0x185908DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5908E20", Offset = "0x5907C20", VA = "0x185908E20")]
	static EGJMHKKMCEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x59090A0", Offset = "0x5907EA0", VA = "0x1859090A0")]
	public EGJMHKKMCEK(byte[] PCGBFFNFCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5908CB0", Offset = "0x5907AB0", VA = "0x185908CB0")]
	public OpCode FKPIDODNIOC()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal struct HCAOICAILJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid KCKILJPPPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte JKLDEHFAKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte MFBGJLFGDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte PEDOJPHJNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte AEJGEGFNLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte FPABNMLEJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte ANEIKEPPLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte BNECAINMDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte CLDGDGMACKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte MIDLBIKPACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte DCNJHHNHLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte FNCNJFJNIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte MCEAONOKLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte GCHDNHMFLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte ACHFOMABMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte IMJLKJIDEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte AOOCGADNJEC;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] CLELOPOBHDM;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] DNOJNIDEMGF;

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5911280", Offset = "0x5910080", VA = "0x185911280")]
	public HCAOICAILJB(ref Guid MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5911290", Offset = "0x5910090", VA = "0x185911290")]
	public HCAOICAILJB(ref ArraySegment<byte> FKIEIKLILLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x590FC90", Offset = "0x590EA90", VA = "0x18590FC90")]
	private static byte BLIOPCDNFID(byte[] EMGPHLLIACG, int LLHEIJNHJKK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x590FD50", Offset = "0x590EB50", VA = "0x18590FD50")]
	private static byte FAPGOMDHKIG(byte EJKHFJILHAC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x590FE60", Offset = "0x590EC60", VA = "0x18590FE60")]
	public void LONJBINGFMO(byte[] MMBEBPNKEHD, int NGOMPMICLHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class DMFINCLEBGH
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x5908930", Offset = "0x5907730", VA = "0x185908930")]
	public static bool POFHCAFGIDC(byte ICHEJPHGAEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x59084C0", Offset = "0x59072C0", VA = "0x1859084C0")]
	public static bool EFNLJIJLAPH(byte ICHEJPHGAEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5907540", Offset = "0x5906340", VA = "0x185907540")]
	public static sbyte BIGBPNGJELO(byte[] EMGPHLLIACG, int NGOMPMICLHJ, out int KJJPGOOCFBH)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x59085A0", Offset = "0x59073A0", VA = "0x1859085A0")]
	public static short JEAGHINNOCE(byte[] EMGPHLLIACG, int NGOMPMICLHJ, out int KJJPGOOCFBH)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x5908790", Offset = "0x5907590", VA = "0x185908790")]
	public static int KBAMKNKGPAE(byte[] EMGPHLLIACG, int NGOMPMICLHJ, out int KJJPGOOCFBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5908880", Offset = "0x5907680", VA = "0x185908880")]
	public static long NBGOEHDMJCC(byte[] EMGPHLLIACG, int NGOMPMICLHJ, out int KJJPGOOCFBH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x5907820", Offset = "0x5906620", VA = "0x185907820")]
	public static byte CAOKMNICONM(byte[] EMGPHLLIACG, int NGOMPMICLHJ, out int KJJPGOOCFBH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x5908940", Offset = "0x5907740", VA = "0x185908940")]
	public static ushort POGKLFOCFDJ(byte[] EMGPHLLIACG, int NGOMPMICLHJ, out int KJJPGOOCFBH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x5908800", Offset = "0x5907600", VA = "0x185908800")]
	public static uint NBCCNMAELEI(byte[] EMGPHLLIACG, int NGOMPMICLHJ, out int KJJPGOOCFBH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x5908610", Offset = "0x5907410", VA = "0x185908610")]
	public static ulong JJNGFLEFMDC(byte[] EMGPHLLIACG, int NGOMPMICLHJ, out int KJJPGOOCFBH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x5908720", Offset = "0x5907520", VA = "0x185908720")]
	public static float JLCKFEHPEOO(byte[] EMGPHLLIACG, int NGOMPMICLHJ, out int KJJPGOOCFBH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x5908530", Offset = "0x5907330", VA = "0x185908530")]
	public static double HBBNEJPJBAE(byte[] EMGPHLLIACG, int NGOMPMICLHJ, out int KJJPGOOCFBH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x5906D70", Offset = "0x5905B70", VA = "0x185906D70")]
	public static int BECPMGAMNCE(ref byte[] MMBEBPNKEHD, int NGOMPMICLHJ, ulong MGFMONLLLPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x5907890", Offset = "0x5906690", VA = "0x185907890")]
	public static int DANIMNEMHMI(ref byte[] MMBEBPNKEHD, int NGOMPMICLHJ, long MGFMONLLLPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x59075B0", Offset = "0x59063B0", VA = "0x1859075B0")]
	public static bool BJAGLNEBANL(byte[] EMGPHLLIACG, int NGOMPMICLHJ, out int KJJPGOOCFBH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class IONDAKBMEKC
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class GEANFMONJFN : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x91D1E0", Offset = "0x91BFE0", VA = "0x18091D1E0")]
		[DebuggerHidden]
		public GEANFMONJFN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5648740", Offset = "0x5647540", VA = "0x185648740", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x56482E0", Offset = "0x56470E0", VA = "0x1856482E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5648830", Offset = "0x5647630", VA = "0x185648830")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x5648880", Offset = "0x5647680", VA = "0x185648880")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5648700", Offset = "0x5647500", VA = "0x185648700", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5648650", Offset = "0x5647450", VA = "0x185648650", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5648650", Offset = "0x5647450", VA = "0x185648650", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class PLDLKMMAGFJ : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x91D1E0", Offset = "0x91BFE0", VA = "0x18091D1E0")]
		[DebuggerHidden]
		public PLDLKMMAGFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5656D70", Offset = "0x5655B70", VA = "0x185656D70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x5656910", Offset = "0x5655710", VA = "0x185656910", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x5656E60", Offset = "0x5655C60", VA = "0x185656E60")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x5656EB0", Offset = "0x5655CB0", VA = "0x185656EB0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5656D30", Offset = "0x5655B30", VA = "0x185656D30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5656C80", Offset = "0x5655A80", VA = "0x185656C80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x5656C80", Offset = "0x5655A80", VA = "0x185656C80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5197940", Offset = "0x5196740", VA = "0x185197940")]
	public static bool PDHLBFFHGHI(this TypeInfo LEDIIMFEFLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x51976C0", Offset = "0x51964C0", VA = "0x1851976C0")]
	public static bool FLONKFGNGAA(this TypeInfo LEDIIMFEFLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x51975F0", Offset = "0x51963F0", VA = "0x1851975F0")]
	public static IEnumerable<PropertyInfo> CEAPBOODIID(this Type LEDIIMFEFLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x51978B0", Offset = "0x51966B0", VA = "0x1851978B0")]
	[IteratorStateMachine(typeof(GEANFMONJFN))]
	private static IEnumerable<PropertyInfo> NJICLINOHOJ(Type LEDIIMFEFLP, HashSet<string> HKIDGPPNJNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x51977E0", Offset = "0x51965E0", VA = "0x1851977E0")]
	public static IEnumerable<FieldInfo> JMBFENPGDDA(this Type LEDIIMFEFLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x5197560", Offset = "0x5196360", VA = "0x185197560")]
	[IteratorStateMachine(typeof(PLDLKMMAGFJ))]
	private static IEnumerable<FieldInfo> AENGPKNLBIK(Type LEDIIMFEFLP, HashSet<string> HKIDGPPNJNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal static class AKBPBFBDFLG
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding EIPLKJCMPPK;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class IDELLGDPJOD
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7C69F0", Offset = "0x7C57F0", VA = "0x1807C69F0")]
	public static string GCNJIDCBPNI(string NNDKGIFLHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x5195AF0", Offset = "0x51948F0", VA = "0x185195AF0")]
	public static string IPKNFFFIMBN(string NNDKGIFLHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x5195900", Offset = "0x5194700", VA = "0x185195900")]
	public static string FLCFDCIJGAN(string NNDKGIFLHME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class JKPKDNKLJAG<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private class DINKNJEMCHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type MPJCJINPOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue KCKILJPPPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int NNOPHPKLOOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public DINKNJEMCHI IAEBPIKIFIC;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x2B098C0", Offset = "0x2B086C0", VA = "0x182B098C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2B097C0", Offset = "0x2B085C0", VA = "0x182B097C0")]
		private int JKIABPBFIHG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public DINKNJEMCHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class CFFEHINKIIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public CFFEHINKIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xD5A960", Offset = "0xD59760", VA = "0x180D5A960")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private DINKNJEMCHI[] NGDOCMAADLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int MKGODNJCKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object NGFGELGLCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float LLGLMNMGDCI;

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x26C4DD0", Offset = "0x26C3BD0", VA = "0x1826C4DD0")]
	public JKPKDNKLJAG(int JNGKGNOBDKI = 4, float LLGLMNMGDCI = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x26C4BD0", Offset = "0x26C39D0", VA = "0x1826C4BD0")]
	public bool NEHFKMKGDBM(Type JHANOPJHOLP, TValue MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x26C4A40", Offset = "0x26C3840", VA = "0x1826C4A40")]
	public bool NEHFKMKGDBM(Type JHANOPJHOLP, Func<Type, TValue> JALBOPJKCNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x26C4710", Offset = "0x26C3510", VA = "0x1826C4710")]
	private bool FLNOIHHPHCC(Type JHANOPJHOLP, Func<Type, TValue> JALBOPJKCNE, out TValue ICAOJAEOKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x26C3B90", Offset = "0x26C2990", VA = "0x1826C3B90")]
	private bool DEOJGDIDAPL(DINKNJEMCHI[] NGDOCMAADLN, Type BBNKAKPKLJH, DINKNJEMCHI DPIJNJAECPB, Func<Type, TValue> JALBOPJKCNE, out TValue ICAOJAEOKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x26C38F0", Offset = "0x26C26F0", VA = "0x1826C38F0")]
	public bool BOAPLFBFGDK(Type JHANOPJHOLP, out TValue MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x26C42F0", Offset = "0x26C30F0", VA = "0x1826C42F0")]
	public TValue EEILMIDAPKF(Type JHANOPJHOLP, Func<Type, TValue> JALBOPJKCNE)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x26C4A10", Offset = "0x26C3810", VA = "0x1826C4A10")]
	private static int LKKLJNNCNPE(int FIAGBFBGBLF, float LLGLMNMGDCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x26C49E0", Offset = "0x26C37E0", VA = "0x1826C49E0")]
	private static void KNKENCPEMNH(ref DINKNJEMCHI OCCDMBDHBFJ, DINKNJEMCHI MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x26C49E0", Offset = "0x26C37E0", VA = "0x1826C49E0")]
	private static void KNKENCPEMNH(ref DINKNJEMCHI[] OCCDMBDHBFJ, DINKNJEMCHI[] MGFMONLLLPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class HNBNHHJBCAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder PPNPACIHHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder HJNIJPCBCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object AFAHPKPIMDB;

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x5193460", Offset = "0x5192260", VA = "0x185193460")]
	public TypeBuilder BHHBPAOILBD(string ICIEGOLHGJN, TypeAttributes GFGMBPKFFHN, Type GANAMHNGMGO, Type[] NIKEGAACFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x5193530", Offset = "0x5192330", VA = "0x185193530")]
	public HNBNHHJBCAE(string BOCCOMHDDHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal static class CEDKKNLOOKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x5901E80", Offset = "0x5900C80", VA = "0x185901E80")]
	private static MethodInfo DPDOCLIJKDE(LambdaExpression KKCGFDCPCMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x2608540", Offset = "0x2607340", VA = "0x182608540")]
	public static MethodInfo PLNCFPAADLB<T>(Expression<Func<T>> KKCGFDCPCMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x2608540", Offset = "0x2607340", VA = "0x182608540")]
	public static MethodInfo PLNCFPAADLB<T, TR>(Expression<Func<T, TR>> KKCGFDCPCMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x2608540", Offset = "0x2607340", VA = "0x182608540")]
	public static MethodInfo PLNCFPAADLB<T>(Expression<Action<T>> KKCGFDCPCMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x2608540", Offset = "0x2607340", VA = "0x182608540")]
	public static MethodInfo PLNCFPAADLB<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> KKCGFDCPCMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x2608430", Offset = "0x2607230", VA = "0x182608430")]
	private static MemberInfo DCIOMCIAFCL<T>(Expression<T> NFJHHMHDKEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x26084E0", Offset = "0x26072E0", VA = "0x1826084E0")]
	public static PropertyInfo FPGNFEOIOPH<T, TR>(Expression<Func<T, TR>> KKCGFDCPCMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct EBNHNFAJOBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int FCPPLBLBJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool HNPCALEMDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator CKMPJBHDCMK;

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x5908B60", Offset = "0x5907960", VA = "0x185908B60")]
	public EBNHNFAJOBH(ILGenerator CKMPJBHDCMK, int FCPPLBLBJIC, bool HNPCALEMDHM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x5908AD0", Offset = "0x59078D0", VA = "0x185908AD0")]
	public EBNHNFAJOBH(ILGenerator CKMPJBHDCMK, int FCPPLBLBJIC, Type LEDIIMFEFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x59089B0", Offset = "0x59077B0", VA = "0x1859089B0")]
	public void PANKCHKAPLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class DKOCDNGNGOJ
{
	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x59068C0", Offset = "0x59056C0", VA = "0x1859068C0")]
	public static void LGBOBPHODCO(this ILGenerator CKMPJBHDCMK, int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x5906AF0", Offset = "0x59058F0", VA = "0x185906AF0")]
	public static void LGBOBPHODCO(this ILGenerator CKMPJBHDCMK, LocalBuilder KNLEBLILKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x5905F70", Offset = "0x5904D70", VA = "0x185905F70")]
	public static void DLGIKJMONHI(this ILGenerator CKMPJBHDCMK, int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x5905F30", Offset = "0x5904D30", VA = "0x185905F30")]
	public static void DLGIKJMONHI(this ILGenerator CKMPJBHDCMK, LocalBuilder KNLEBLILKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x5905AC0", Offset = "0x59048C0", VA = "0x185905AC0")]
	public static void AGNHPMLBEOB(this ILGenerator CKMPJBHDCMK, int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x5905BB0", Offset = "0x59049B0", VA = "0x185905BB0")]
	public static void AGNHPMLBEOB(this ILGenerator CKMPJBHDCMK, LocalBuilder KNLEBLILKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x59065F0", Offset = "0x59053F0", VA = "0x1859065F0")]
	public static void HHMGCLMMBAD(this ILGenerator CKMPJBHDCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x5906B30", Offset = "0x5905930", VA = "0x185906B30")]
	public static void MCJJJPGCABE(this ILGenerator CKMPJBHDCMK, bool MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x59061A0", Offset = "0x5904FA0", VA = "0x1859061A0")]
	public static void ENPPLMOPGJD(this ILGenerator CKMPJBHDCMK, int MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x5905E40", Offset = "0x5904C40", VA = "0x185905E40")]
	public static void COBGHHHFECC(this ILGenerator CKMPJBHDCMK, Type LEDIIMFEFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x5906710", Offset = "0x5905510", VA = "0x185906710")]
	public static void IGNLGDHIDCC(this ILGenerator CKMPJBHDCMK, Type LEDIIMFEFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x5906B40", Offset = "0x5905940", VA = "0x185906B40")]
	public static void NMAIIJOLLMA(this ILGenerator CKMPJBHDCMK, int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x5906690", Offset = "0x5905490", VA = "0x185906690")]
	public static void IFMBFKFDFHN(this ILGenerator CKMPJBHDCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x5905CC0", Offset = "0x5904AC0", VA = "0x185905CC0")]
	public static void ANJKFPPELIJ(this ILGenerator CKMPJBHDCMK, int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x59067C0", Offset = "0x59055C0", VA = "0x1859067C0")]
	public static void JOGKNKFBFDO(this ILGenerator CKMPJBHDCMK, MethodInfo APKLEGEBOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5905DB0", Offset = "0x5904BB0", VA = "0x185905DB0")]
	public static void CGMLKEGPMNI(this ILGenerator CKMPJBHDCMK, FieldInfo OODDFPHCBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x5906600", Offset = "0x5905400", VA = "0x185906600")]
	public static void IBOJFJPLBCO(this ILGenerator CKMPJBHDCMK, ulong MGFMONLLLPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class IJEPCDCELDM
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class KMABHJJGEAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public KMABHJJGEAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x564A2E0", Offset = "0x56490E0", VA = "0x18564A2E0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo EEMAJJAEIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo OFBEACCFKDO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string JAGOKEMFLBL
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7612C0", Offset = "0x7600C0", VA = "0x1807612C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string AFOCLNIKPKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7612D0", Offset = "0x7600D0", VA = "0x1807612D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool FEBPJIIADJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x51967F0", Offset = "0x51955F0", VA = "0x1851967F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool EPDLOGMOPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x75C560", Offset = "0x75B360", VA = "0x18075C560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7D64C0", Offset = "0x7D52C0", VA = "0x1807D64C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool HJFPONEALGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x75C570", Offset = "0x75B370", VA = "0x18075C570")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xAF0C40", Offset = "0xAEFA40", VA = "0x180AF0C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type FKLLKDBMLDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x75BA70", Offset = "0x75A870", VA = "0x18075BA70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7833A0", Offset = "0x7821A0", VA = "0x1807833A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo MGLIHKAHEOL
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7F11E0", Offset = "0x7EFFE0", VA = "0x1807F11E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo KIFGELAEGOA
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x748BA0", Offset = "0x7479A0", VA = "0x180748BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x748BC0", Offset = "0x7479C0", VA = "0x180748BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo MNMLIAOIIPO
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x748BB0", Offset = "0x7479B0", VA = "0x180748BB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x748BD0", Offset = "0x7479D0", VA = "0x180748BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x51969D0", Offset = "0x51957D0", VA = "0x1851969D0")]
	protected IJEPCDCELDM(Type LEDIIMFEFLP, string ICIEGOLHGJN, string HKIMNJFCDEB, bool MILAFBCJOAN, bool MJLGAJMMNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x51968C0", Offset = "0x51956C0", VA = "0x1851968C0")]
	public IJEPCDCELDM(FieldInfo PFBGGFHJPLL, string ICIEGOLHGJN, bool ILJPPMKCCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5196A50", Offset = "0x5195850", VA = "0x185196A50")]
	public IJEPCDCELDM(PropertyInfo PFBGGFHJPLL, string ICIEGOLHGJN, bool ILJPPMKCCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x5196680", Offset = "0x5195480", VA = "0x185196680")]
	private static MethodInfo BKNPFLHOPHO(MemberInfo PFBGGFHJPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x29352E0", Offset = "0x29340E0", VA = "0x1829352E0")]
	public T CIEGCCMLNIA<T>(bool PFPDMKIEEOO) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x51965C0", Offset = "0x51953C0", VA = "0x1851965C0", Slot = "4")]
	public virtual void AMGOEMDNANL(ILGenerator CKMPJBHDCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x5196800", Offset = "0x5195600", VA = "0x185196800", Slot = "5")]
	public virtual void KGEODDDGDMB(ILGenerator CKMPJBHDCMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class BHEOJKIOIHH : IJEPCDCELDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string DBIKNJBPIJB;

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x5900950", Offset = "0x58FF750", VA = "0x185900950")]
	public BHEOJKIOIHH(string ICIEGOLHGJN, string DBIKNJBPIJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x5900850", Offset = "0x58FF650", VA = "0x185900850", Slot = "4")]
	public override void AMGOEMDNANL(ILGenerator CKMPJBHDCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x5900910", Offset = "0x58FF710", VA = "0x185900910", Slot = "5")]
	public override void KGEODDDGDMB(ILGenerator CKMPJBHDCMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class NBFPIGMMLCC : IJEPCDCELDM
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo KGMFNHPKGOF;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo IJODNOLPPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal EBNHNFAJOBH DJPLCAPEJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal EBNHNFAJOBH DFNLNJAEEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal EBNHNFAJOBH CBPPIDJDHAC;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x564E590", Offset = "0x564D390", VA = "0x18564E590")]
	public NBFPIGMMLCC(string ICIEGOLHGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x564DE10", Offset = "0x564CC10", VA = "0x18564DE10", Slot = "4")]
	public override void AMGOEMDNANL(ILGenerator CKMPJBHDCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x564E000", Offset = "0x564CE00", VA = "0x18564E000", Slot = "5")]
	public override void KGEODDDGDMB(ILGenerator CKMPJBHDCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x564DEE0", Offset = "0x564CCE0", VA = "0x18564DEE0")]
	public void DGGGMHJDJAB(ILGenerator CKMPJBHDCMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class ANGMAPOMDLF
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type FKLLKDBMLDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7612C0", Offset = "0x7600C0", VA = "0x1807612C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool JEGPHALILML
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x75BA60", Offset = "0x75A860", VA = "0x18075BA60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x77D190", Offset = "0x77BF90", VA = "0x18077D190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool CLLEPONBEGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xCC0C80", Offset = "0xCBFA80", VA = "0x180CC0C80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xCC0CA0", Offset = "0xCBFAA0", VA = "0x180CC0CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo DBEHNHIFFFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x741130", Offset = "0x73FF30", VA = "0x180741130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IJEPCDCELDM[] GGEJMPICAFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x75BA70", Offset = "0x75A870", VA = "0x18075BA70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7833A0", Offset = "0x7821A0", VA = "0x1807833A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public IJEPCDCELDM[] DGMECBFNJHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7F11E0", Offset = "0x7EFFE0", VA = "0x1807F11E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x58F9F60", Offset = "0x58F8D60", VA = "0x1858F9F60")]
	public ANGMAPOMDLF(Type LEDIIMFEFLP, Func<string, string> GBLHNFCPNNP, bool ILJPPMKCCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x58F9E70", Offset = "0x58F8C70", VA = "0x1858F9E70")]
	private static bool IAFJJLKPJEC(IEnumerator<ConstructorInfo> EPEFNNBKPCG, ref ConstructorInfo PGBBLKJDMGL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct MKNOHLCDFKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong EKLPJLEIPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int EBHODPHNEOL;

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2568CE0", Offset = "0x2567AE0", VA = "0x182568CE0")]
	public MKNOHLCDFKE(ulong IOGGNCPKOPM, int NPMKACBFFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x564D200", Offset = "0x564C000", VA = "0x18564D200")]
	public void GLFNDNGOAKN(ref MKNOHLCDFKE IDBPJJAKCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x564D150", Offset = "0x564BF50", VA = "0x18564D150")]
	public static MKNOHLCDFKE DKCFLPENIKM(ref MKNOHLCDFKE GCKGDDMIIDO, ref MKNOHLCDFKE EJKHFJILHAC)
	{
		return default(MKNOHLCDFKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x564D210", Offset = "0x564C010", VA = "0x18564D210")]
	public void NDLIDAPLOIE(ref MKNOHLCDFKE IDBPJJAKCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x564D160", Offset = "0x564BF60", VA = "0x18564D160")]
	public static MKNOHLCDFKE EFLPDJDPLNA(ref MKNOHLCDFKE GCKGDDMIIDO, ref MKNOHLCDFKE EJKHFJILHAC)
	{
		return default(MKNOHLCDFKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x564D2A0", Offset = "0x564C0A0", VA = "0x18564D2A0")]
	public void PPFIPMGNHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x564D2E0", Offset = "0x564C0E0", VA = "0x18564D2E0")]
	public static MKNOHLCDFKE PPFIPMGNHDA(ref MKNOHLCDFKE GCKGDDMIIDO)
	{
		return default(MKNOHLCDFKE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct OPELIHLCFDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] MMBEBPNKEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int NGOMPMICLHJ;

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7C8AA0", Offset = "0x7C78A0", VA = "0x1807C8AA0")]
	public OPELIHLCFDJ(byte[] MMBEBPNKEHD, int DNPAJCANFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x5655100", Offset = "0x5653F00", VA = "0x185655100")]
	public void MABLJBACBBB(byte MDIBKHINKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x5655160", Offset = "0x5653F60", VA = "0x185655160")]
	public void MEOAFHJBOAM(byte[] MDIBKHINKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x5654FE0", Offset = "0x5653DE0", VA = "0x185654FE0")]
	public void FLHDFIBOBCH(byte[] MDIBKHINKGB, int PFLGNDMCMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x5654F30", Offset = "0x5653D30", VA = "0x185654F30")]
	public void FLHDFIBOBCH(byte[] MDIBKHINKGB, int CKCLNMMLENB, int PFLGNDMCMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x5655080", Offset = "0x5653E80", VA = "0x185655080")]
	public void KCFHHHNMMOO(byte ICHEJPHGAEP, int MNBBKKLFBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x5654E30", Offset = "0x5653C30", VA = "0x185654E30")]
	public void BOGKALCFJHO(string MDIBKHINKGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class OBBKOEMLPPF
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private enum IHDPANODEGA
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private enum FKJJGNGLBLI
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum FKDENCLFAGL
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
	private static byte[] OGFEHFKABPK;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] CNLMLHFMOOF;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] NEPIEEHAIDG;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] CBIINOPDBHO;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly FKDENCLFAGL OHDGKOPJKOC;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char EOKKCJHJCBM;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int BELFDNILDCG;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int BHNODGIMHPJ;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] BOFMKMABEGF;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5652EF0", Offset = "0x5651CF0", VA = "0x185652EF0")]
	private static byte[] GAENLOOMLMK(int MKGODNJCKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x56532A0", Offset = "0x56520A0", VA = "0x1856532A0")]
	private static byte[] HHPHFBIOJHO(int MKGODNJCKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5652CB0", Offset = "0x5651AB0", VA = "0x185652CB0")]
	public static int FNJHNEINGCN(ref byte[] MMBEBPNKEHD, int NGOMPMICLHJ, float MGFMONLLLPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x5652DD0", Offset = "0x5651BD0", VA = "0x185652DD0")]
	public static int FNJHNEINGCN(ref byte[] MMBEBPNKEHD, int NGOMPMICLHJ, double MGFMONLLLPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x5652910", Offset = "0x5651710", VA = "0x185652910")]
	private static bool CKACAMBJMLB(byte[] MMBEBPNKEHD, int PFLGNDMCMIN, ulong GAHOPDEEJKL, ulong NHMNIOCIALG, ulong HOHKJGEMBGM, ulong ODAAOCAGKHB, ulong FMAEGBMBJMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x5652FD0", Offset = "0x5651DD0", VA = "0x185652FD0")]
	private static void GIOFPEAAFLI(uint JDAMBEPNLFP, int JHPHIKJNGAA, out uint DFGBACCHDBA, out int AEFFHKGLIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x5653380", Offset = "0x5652180", VA = "0x185653380")]
	private static bool JLINFFAHAKJ(MKNOHLCDFKE IHHIEAABBFI, MKNOHLCDFKE DAHBJHMBLLC, MKNOHLCDFKE PPLIJNJFHGP, byte[] MMBEBPNKEHD, out int PFLGNDMCMIN, out int PNIMBPONFAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x5652020", Offset = "0x5650E20", VA = "0x185652020")]
	private static bool AMFJEAPDJFL(double LABLHNPANGA, IHDPANODEGA LHDFDDPEACL, byte[] MMBEBPNKEHD, out int PFLGNDMCMIN, out int GHNJJBLNMIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x5652A10", Offset = "0x5651810", VA = "0x185652A10")]
	private static bool DOEAPEAPEBF(double LABLHNPANGA, IHDPANODEGA LHDFDDPEACL, byte[] MMBEBPNKEHD, out int PFLGNDMCMIN, out int IJLGCHFAOMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x5652B20", Offset = "0x5651920", VA = "0x185652B20")]
	private static bool FJNDJDEDEAO(double MGFMONLLLPD, ref OPELIHLCFDJ KJPFNEPLNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x5653840", Offset = "0x5652640", VA = "0x185653840")]
	private static bool LLOBGNALCJO(double MGFMONLLLPD, ref OPELIHLCFDJ KJPFNEPLNKA, FKJJGNGLBLI LHDFDDPEACL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x5651B50", Offset = "0x5650950", VA = "0x185651B50")]
	private static void ABDHPNBKGIF(byte[] BDENKKGLJJN, int PFLGNDMCMIN, int IJLGCHFAOMI, int CCMKIOCMBAO, ref OPELIHLCFDJ KJPFNEPLNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x56523E0", Offset = "0x56511E0", VA = "0x1856523E0")]
	private static void BPCEEJCOIJL(byte[] BDENKKGLJJN, int PFLGNDMCMIN, int NPMKACBFFHH, ref OPELIHLCFDJ KJPFNEPLNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x56530F0", Offset = "0x5651EF0", VA = "0x1856530F0")]
	private static bool GKHIHHHIIFD(double LABLHNPANGA, FKJJGNGLBLI LHDFDDPEACL, int AHMABJCCBIL, byte[] LIDDEBKPNEA, out bool CFNKJONMHOH, out int PFLGNDMCMIN, out int LOFCJGHDJHE)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal struct BPHEFABFCKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double EIBINODMDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong AOBJNDBKAOF;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal struct CANCAOAJLIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float EKLPJLEIPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint DJMJLPJNABI;
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct DGPKJIJBPHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong INFKHHLLNCP;

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x5903F60", Offset = "0x5902D60", VA = "0x185903F60")]
	public DGPKJIJBPHA(double EIBINODMDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x5903F70", Offset = "0x5902D70", VA = "0x185903F70")]
	public DGPKJIJBPHA(MKNOHLCDFKE EIBINODMDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x5903C10", Offset = "0x5902A10", VA = "0x185903C10")]
	public MKNOHLCDFKE EOMCIEGHMNI()
	{
		return default(MKNOHLCDFKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5903B60", Offset = "0x5902960", VA = "0x185903B60")]
	public MKNOHLCDFKE DAMBAJFMCNG()
	{
		return default(MKNOHLCDFKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x740000", Offset = "0x73EE00", VA = "0x180740000")]
	public ulong NLCHNAPMOAI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5903CD0", Offset = "0x5902AD0", VA = "0x185903CD0")]
	public double FPGKHHFOHLF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x5903E00", Offset = "0x5902C00", VA = "0x185903E00")]
	public double LNDAGOGODBM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x5903CA0", Offset = "0x5902AA0", VA = "0x185903CA0")]
	public int FMALFANDILH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x5903DB0", Offset = "0x5902BB0", VA = "0x185903DB0")]
	public ulong ICLLHAAMMGI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x5903F40", Offset = "0x5902D40", VA = "0x185903F40")]
	public bool NIKABBHHFNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x5903B10", Offset = "0x5902910", VA = "0x185903B10")]
	public bool BIMJLOMMPPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x5903AE0", Offset = "0x59028E0", VA = "0x185903AE0")]
	public bool AILFFBJAGKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x5903B30", Offset = "0x5902930", VA = "0x185903B30")]
	public bool CPELPAAHEKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5903DE0", Offset = "0x5902BE0", VA = "0x185903DE0")]
	public int LLCLFKNAHKC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5903970", Offset = "0x5902770", VA = "0x185903970")]
	public void AGILIABKJGE(out MKNOHLCDFKE NDOINOBNKAO, out MKNOHLCDFKE JKAAFEDOBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x5903D60", Offset = "0x5902B60", VA = "0x185903D60")]
	public bool HHJMPPLJDDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x5903E90", Offset = "0x5902C90", VA = "0x185903E90")]
	public double MGFMONLLLPD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x5903BF0", Offset = "0x59029F0", VA = "0x185903BF0")]
	public static int ECEFCBNGAHF(int AELDILNFOHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x5903C90", Offset = "0x5902A90", VA = "0x185903C90")]
	public static double FCIIMMOBBOL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x5903EA0", Offset = "0x5902CA0", VA = "0x185903EA0")]
	public static ulong NDPKPPEBHGN(MKNOHLCDFKE KLODEPCIGAI)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct LDGPAIGJPOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint MGAJLBGOHHD;

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x31E0100", Offset = "0x31DEF00", VA = "0x1831E0100")]
	public LDGPAIGJPOP(float EKLPJLEIPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x519E2B0", Offset = "0x519D0B0", VA = "0x18519E2B0")]
	public MKNOHLCDFKE EOMCIEGHMNI()
	{
		return default(MKNOHLCDFKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7D54E0", Offset = "0x7D42E0", VA = "0x1807D54E0")]
	public uint CPJIIHIODPM()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x519E320", Offset = "0x519D120", VA = "0x18519E320")]
	public int FMALFANDILH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x519E380", Offset = "0x519D180", VA = "0x18519E380")]
	public uint ICLLHAAMMGI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x519E3A0", Offset = "0x519D1A0", VA = "0x18519E3A0")]
	public bool NIKABBHHFNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x519E150", Offset = "0x519CF50", VA = "0x18519E150")]
	public void AGILIABKJGE(out MKNOHLCDFKE NDOINOBNKAO, out MKNOHLCDFKE JKAAFEDOBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x519E340", Offset = "0x519D140", VA = "0x18519E340")]
	public bool HHJMPPLJDDC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct NIDBDFNDPDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong IOGGNCPKOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short KDMACHHLHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short GHNJJBLNMIP;

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x564F0B0", Offset = "0x564DEB0", VA = "0x18564F0B0")]
	public NIDBDFNDPDD(ulong IOGGNCPKOPM, short KDMACHHLHCP, short GHNJJBLNMIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal static class BGDLFDNMPEO
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly NIDBDFNDPDD[] CAFNCNHJHHD;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x58FE950", Offset = "0x58FD750", VA = "0x1858FE950")]
	public static void CNKNCFHDOMC(int AOHMIGOCDKJ, int CPLGBDHAAMG, out MKNOHLCDFKE DFGBACCHDBA, out int GHNJJBLNMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x58FE850", Offset = "0x58FD650", VA = "0x1858FE850")]
	public static void AJIFNDDDBKL(int BKLOCBCKHJO, out MKNOHLCDFKE DFGBACCHDBA, out int BELKFLHIKBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[DefaultMember("Item")]
internal struct OPPMFNBGMHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] EMGPHLLIACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int CKCLNMMLENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int PGJHPOOPBBP;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x5655260", Offset = "0x5654060", VA = "0x185655260")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0xCAF370", Offset = "0xCAE170", VA = "0x180CAF370")]
	public OPPMFNBGMHI(byte[] EMGPHLLIACG, int CKCLNMMLENB, int PFLGNDMCMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F30", Offset = "0x7C0D30", VA = "0x1807C1F30")]
	public int PFLGNDMCMIN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5655200", Offset = "0x5654000", VA = "0x185655200")]
	public OPPMFNBGMHI FIKKGKEMBLD(int KOIBMJMNGNL, int PJKMLKEDHEC)
	{
		return default(OPPMFNBGMHI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal static class DHJJFPGBPDG
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] CNMJGEOHIGI;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] EBCJMKBMBLP;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int PLAGJCNDDPP;

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x59041D0", Offset = "0x5902FD0", VA = "0x1859041D0")]
	private static byte[] BMICBHPKMKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x59042C0", Offset = "0x59030C0", VA = "0x1859042C0")]
	private static OPPMFNBGMHI EGHJICDMPHM(OPPMFNBGMHI MMBEBPNKEHD)
	{
		return default(OPPMFNBGMHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5904AD0", Offset = "0x59038D0", VA = "0x185904AD0")]
	private static OPPMFNBGMHI KMBDACJLPMG(OPPMFNBGMHI MMBEBPNKEHD)
	{
		return default(OPPMFNBGMHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5905380", Offset = "0x5904180", VA = "0x185905380")]
	private static void PDFAAEDDNFD(OPPMFNBGMHI MMBEBPNKEHD, int NPMKACBFFHH, byte[] FGFCGEMLLIJ, out int NMEHLEJPOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x5904F30", Offset = "0x5903D30", VA = "0x185904F30")]
	private static void NJLIFJONBEK(OPPMFNBGMHI MMBEBPNKEHD, int NPMKACBFFHH, byte[] EAJEEPDFFJH, int NMEAAIAKKOP, out OPPMFNBGMHI DMGIALKCBAG, out int GADKGGBGIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5904A40", Offset = "0x5903840", VA = "0x185904A40")]
	private static ulong KJPPEHPJDIO(OPPMFNBGMHI MMBEBPNKEHD, out int KDHCGHLFDHD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5904DE0", Offset = "0x5903BE0", VA = "0x185904DE0")]
	private static void NJHCCFLIAGL(OPPMFNBGMHI MMBEBPNKEHD, out MKNOHLCDFKE AJCHMFJLMGE, out int KEGMDMHLCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5904650", Offset = "0x5903450", VA = "0x185904650")]
	private static bool JJKFLGOHBLH(OPPMFNBGMHI DMGIALKCBAG, int NPMKACBFFHH, out double AJCHMFJLMGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x59051D0", Offset = "0x5903FD0", VA = "0x1859051D0")]
	private static MKNOHLCDFKE NPFAFNFPBAB(int NPMKACBFFHH)
	{
		return default(MKNOHLCDFKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5905440", Offset = "0x5904240", VA = "0x185905440")]
	private static bool POPPNCMJFLJ(OPPMFNBGMHI MMBEBPNKEHD, int NPMKACBFFHH, out double AJCHMFJLMGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5904B80", Offset = "0x5903980", VA = "0x185904B80")]
	private static bool KNMALHLPFEO(OPPMFNBGMHI DMGIALKCBAG, int NPMKACBFFHH, out double LDILHLNDKAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5904CC0", Offset = "0x5903AC0", VA = "0x185904CC0")]
	public static double? MABJHJPIKNB(OPPMFNBGMHI MMBEBPNKEHD, int NPMKACBFFHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x5904370", Offset = "0x5903170", VA = "0x185904370")]
	public static float? GFNCFPGBNIF(OPPMFNBGMHI MMBEBPNKEHD, int NPMKACBFFHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct BPJPBLOHGOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] MMBEBPNKEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int NGOMPMICLHJ;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte KCKILJPPPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x59017D0", Offset = "0x59005D0", VA = "0x1859017D0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7C8AA0", Offset = "0x7C78A0", VA = "0x1807C8AA0")]
	public BPJPBLOHGOF(byte[] MMBEBPNKEHD, int NGOMPMICLHJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x59017C0", Offset = "0x59005C0", VA = "0x1859017C0")]
	public static BPJPBLOHGOF HAAHAAKIICL(BPJPBLOHGOF LCNEHOGIJPK)
	{
		return default(BPJPBLOHGOF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x59018D0", Offset = "0x59006D0", VA = "0x1859018D0")]
	public static BPJPBLOHGOF LDHDNDGLKBP(BPJPBLOHGOF LCNEHOGIJPK, int PFLGNDMCMIN)
	{
		return default(BPJPBLOHGOF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5901690", Offset = "0x5900490", VA = "0x185901690")]
	public static int AOOKPENIMMF(BPJPBLOHGOF JGEPMPFGKOG, BPJPBLOHGOF CPIBOCOHLLI)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x5901750", Offset = "0x5900550", VA = "0x185901750")]
	public static bool EJGLOGBEPOL(BPJPBLOHGOF JGEPMPFGKOG, BPJPBLOHGOF CPIBOCOHLLI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x5901860", Offset = "0x5900660", VA = "0x185901860")]
	public static bool IKFCAHNLBFO(BPJPBLOHGOF JGEPMPFGKOG, BPJPBLOHGOF CPIBOCOHLLI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x5901700", Offset = "0x5900500", VA = "0x185901700")]
	public static bool EJGLOGBEPOL(BPJPBLOHGOF JGEPMPFGKOG, char CPIBOCOHLLI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x5901810", Offset = "0x5900610", VA = "0x185901810")]
	public static bool IKFCAHNLBFO(BPJPBLOHGOF JGEPMPFGKOG, char CPIBOCOHLLI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x5901810", Offset = "0x5900610", VA = "0x185901810")]
	public static bool IKFCAHNLBFO(BPJPBLOHGOF JGEPMPFGKOG, byte CPIBOCOHLLI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x5901880", Offset = "0x5900680", VA = "0x185901880")]
	public static bool INLNLDLJILA(BPJPBLOHGOF JGEPMPFGKOG, char CPIBOCOHLLI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x5901770", Offset = "0x5900570", VA = "0x185901770")]
	public static bool FGGDILADIFP(BPJPBLOHGOF JGEPMPFGKOG, char CPIBOCOHLLI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x5901640", Offset = "0x5900440", VA = "0x185901640")]
	public static bool AOFAKGPCAKP(BPJPBLOHGOF JGEPMPFGKOG, char CPIBOCOHLLI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x59016B0", Offset = "0x59004B0", VA = "0x1859016B0")]
	public static bool CHLJBDDBCLG(BPJPBLOHGOF JGEPMPFGKOG, char CPIBOCOHLLI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class LAKELLIPEDG
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] AMKLMIICCBG;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] OFJKFMAEKOM;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] NEPIEEHAIDG;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] CBIINOPDBHO;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] KBCBBHFKGJL;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int IKHNHEKHAHM;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] GBCGODPHHAL;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int JKLBPDDONLD;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x519D990", Offset = "0x519C790", VA = "0x18519D990")]
	private static byte[] LOGHFHCNLFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x519DB40", Offset = "0x519C940", VA = "0x18519DB40")]
	private static byte[] PAMICGACBAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x519C480", Offset = "0x519B280", VA = "0x18519C480")]
	public static double BCJOGBHFHIE(byte[] MMBEBPNKEHD, int NGOMPMICLHJ, out int KJJPGOOCFBH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x519DA80", Offset = "0x519C880", VA = "0x18519DA80")]
	public static float OFAGFCCDNAE(byte[] MMBEBPNKEHD, int NGOMPMICLHJ, out int KJJPGOOCFBH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x519C530", Offset = "0x519B330", VA = "0x18519C530")]
	private static bool BCOFPJGANEP(int NHKCICGBPMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x519DC30", Offset = "0x519CA30", VA = "0x18519DC30")]
	private static bool PCKPMJOAEPJ(ref BPJPBLOHGOF KAHIPMIDNOL, BPJPBLOHGOF KHILBFLOBFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x519D810", Offset = "0x519C610", VA = "0x18519D810")]
	private static bool HKMEIBOHGHJ(ref BPJPBLOHGOF KAHIPMIDNOL, BPJPBLOHGOF KHILBFLOBFB, byte[] HFEEAPEFBLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x519D920", Offset = "0x519C720", VA = "0x18519D920")]
	private static bool KEJNBEIGFHM(ref BPJPBLOHGOF OBKDOEHDAGB, byte[] MDIBKHINKGB, int NGOMPMICLHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x519D970", Offset = "0x519C770", VA = "0x18519D970")]
	private static double KFOHKHNCGKB(bool CFNKJONMHOH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x519C6B0", Offset = "0x519B4B0", VA = "0x18519C6B0")]
	private static double FCAACOCCGFN(BPJPBLOHGOF KOHCAKAAIGA, int PFLGNDMCMIN, bool BJJLAKDOABG, out int IIIHKICCEBE)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class LHJNPEFEOHL<T> : global::HBFNKAIDHHG<T[]>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly global::CDJDHMILGMC<T> MGOHFCADPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly HAILMNOEJFB OFHJOIEDNCA;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2BF9B40", Offset = "0x2BF8940", VA = "0x182BF9B40")]
	public LHJNPEFEOHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x1D036E0", Offset = "0x1D024E0", VA = "0x181D036E0")]
	public LHJNPEFEOHL(HAILMNOEJFB OFHJOIEDNCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2BF9800", Offset = "0x2BF8600", VA = "0x182BF9800", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, T[] MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2BF7AE0", Offset = "0x2BF68E0", VA = "0x182BF7AE0", Slot = "5")]
	public T[] BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class DHDOEJBOHLA<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly global::CDJDHMILGMC<T> MGOHFCADPFI;
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class AGNPMPMHFCP<T> : global::HBFNKAIDHHG<List<T>>, BBDBBGCPFMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly HAILMNOEJFB OFHJOIEDNCA;

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2BF9B40", Offset = "0x2BF8940", VA = "0x182BF9B40")]
	public AGNPMPMHFCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x1D036E0", Offset = "0x1D024E0", VA = "0x181D036E0")]
	public AGNPMPMHFCP(HAILMNOEJFB OFHJOIEDNCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x33FADF0", Offset = "0x33F9BF0", VA = "0x1833FADF0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, List<T> MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x33FA830", Offset = "0x33F9630", VA = "0x1833FA830", Slot = "5")]
	public List<T> BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public abstract class GNHFINFEDMP<TElement, TIntermediate, TEnumerator, TCollection> : global::HBFNKAIDHHG<TCollection>, BBDBBGCPFMC where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x3ABAB30", Offset = "0x3AB9930", VA = "0x183ABAB30", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, TCollection MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3ABA930", Offset = "0x3AB9730", VA = "0x183ABA930", Slot = "5")]
	public TCollection BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator JBBAAOCMMAH(TCollection NFJHHMHDKEL);

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate CJALKNOJAHB();

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void OEECIDDHIAM(ref TIntermediate BFJIAFJFPDF, int NNHNOIMLALG, TElement MGFMONLLLPD);

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection IFBNIOMHDFI(ref TIntermediate PADMLIBHHBL);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
	protected GNHFINFEDMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class OHPNEPADEJF<TElement, TIntermediate, TCollection> : global::GNHFINFEDMP<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2538FC0", Offset = "0x2537DC0", VA = "0x182538FC0", Slot = "6")]
	protected override IEnumerator<TElement> JBBAAOCMMAH(TCollection NFJHHMHDKEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x1FFAD00", Offset = "0x1FF9B00", VA = "0x181FFAD00")]
	protected OHPNEPADEJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class MIBPENJJIPK<TElement, TCollection> : global::OHPNEPADEJF<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x1187780", Offset = "0x1186580", VA = "0x181187780", Slot = "9")]
	protected sealed override TCollection IFBNIOMHDFI(ref TCollection PADMLIBHHBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class JAIHBHIEMEH<TElement, TCollection> : global::MIBPENJJIPK<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x35F9D70", Offset = "0x35F8B70", VA = "0x1835F9D70", Slot = "7")]
	protected override TCollection CJALKNOJAHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x35F9D90", Offset = "0x35F8B90", VA = "0x1835F9D90", Slot = "8")]
	protected override void OEECIDDHIAM(ref TCollection BFJIAFJFPDF, int NNHNOIMLALG, TElement MGFMONLLLPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class OCCAJIKFGNJ<T> : global::GNHFINFEDMP<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x26C0750", Offset = "0x26BF550", VA = "0x1826C0750", Slot = "8")]
	protected override void OEECIDDHIAM(ref LinkedList<T> BFJIAFJFPDF, int NNHNOIMLALG, T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x1187780", Offset = "0x1186580", VA = "0x181187780", Slot = "9")]
	protected override LinkedList<T> IFBNIOMHDFI(ref LinkedList<T> PADMLIBHHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x26C06A0", Offset = "0x26BF4A0", VA = "0x1826C06A0", Slot = "7")]
	protected override LinkedList<T> CJALKNOJAHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x316D670", Offset = "0x316C470", VA = "0x18316D670", Slot = "6")]
	protected override LinkedList<T>.Enumerator JBBAAOCMMAH(LinkedList<T> NFJHHMHDKEL)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class DPKAGPCBGKP<T> : global::GNHFINFEDMP<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x26C0750", Offset = "0x26BF550", VA = "0x1826C0750", Slot = "8")]
	protected override void OEECIDDHIAM(ref Queue<T> BFJIAFJFPDF, int NNHNOIMLALG, T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x26C06A0", Offset = "0x26BF4A0", VA = "0x1826C06A0", Slot = "7")]
	protected override Queue<T> CJALKNOJAHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x26C0700", Offset = "0x26BF500", VA = "0x1826C0700", Slot = "6")]
	protected override Queue<T>.Enumerator JBBAAOCMMAH(Queue<T> NFJHHMHDKEL)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x1187780", Offset = "0x1186580", VA = "0x181187780", Slot = "9")]
	protected override Queue<T> IFBNIOMHDFI(ref Queue<T> PADMLIBHHBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class CEDCFDFOGFA<T> : global::GNHFINFEDMP<T, global::MAIHNKKODJD<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2352030", Offset = "0x2350E30", VA = "0x182352030", Slot = "8")]
	protected override void OEECIDDHIAM(ref global::MAIHNKKODJD<T> BFJIAFJFPDF, int NNHNOIMLALG, T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x2351FD0", Offset = "0x2350DD0", VA = "0x182351FD0", Slot = "7")]
	protected override global::MAIHNKKODJD<T> CJALKNOJAHB()
	{
		return default(global::MAIHNKKODJD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x26C0700", Offset = "0x26BF500", VA = "0x1826C0700", Slot = "6")]
	protected override Stack<T>.Enumerator JBBAAOCMMAH(Stack<T> NFJHHMHDKEL)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x316FCD0", Offset = "0x316EAD0", VA = "0x18316FCD0", Slot = "9")]
	protected override Stack<T> IFBNIOMHDFI(ref global::MAIHNKKODJD<T> PADMLIBHHBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class JJPCKAAEANA<T> : global::GNHFINFEDMP<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x26C0750", Offset = "0x26BF550", VA = "0x1826C0750", Slot = "8")]
	protected override void OEECIDDHIAM(ref HashSet<T> BFJIAFJFPDF, int NNHNOIMLALG, T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x1187780", Offset = "0x1186580", VA = "0x181187780", Slot = "9")]
	protected override HashSet<T> IFBNIOMHDFI(ref HashSet<T> PADMLIBHHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x26C06A0", Offset = "0x26BF4A0", VA = "0x1826C06A0", Slot = "7")]
	protected override HashSet<T> CJALKNOJAHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x26C0700", Offset = "0x26BF500", VA = "0x1826C0700", Slot = "6")]
	protected override HashSet<T>.Enumerator JBBAAOCMMAH(HashSet<T> NFJHHMHDKEL)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class GOJGFDENLON<T> : global::OHPNEPADEJF<T, global::MAIHNKKODJD<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2352030", Offset = "0x2350E30", VA = "0x182352030", Slot = "8")]
	protected override void OEECIDDHIAM(ref global::MAIHNKKODJD<T> BFJIAFJFPDF, int NNHNOIMLALG, T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x4792F00", Offset = "0x4791D00", VA = "0x184792F00", Slot = "9")]
	protected override ReadOnlyCollection<T> IFBNIOMHDFI(ref global::MAIHNKKODJD<T> PADMLIBHHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x4792EC0", Offset = "0x4791CC0", VA = "0x184792EC0", Slot = "7")]
	protected override global::MAIHNKKODJD<T> CJALKNOJAHB()
	{
		return default(global::MAIHNKKODJD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class ACGMNHPNGHG<T> : global::OHPNEPADEJF<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x26C0750", Offset = "0x26BF550", VA = "0x1826C0750", Slot = "8")]
	protected override void OEECIDDHIAM(ref List<T> BFJIAFJFPDF, int NNHNOIMLALG, T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x26C06A0", Offset = "0x26BF4A0", VA = "0x1826C06A0", Slot = "7")]
	protected override List<T> CJALKNOJAHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x1187780", Offset = "0x1186580", VA = "0x181187780", Slot = "9")]
	protected override IList<T> IFBNIOMHDFI(ref List<T> PADMLIBHHBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class HOPOKLJOEHH<T> : global::OHPNEPADEJF<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x26C0750", Offset = "0x26BF550", VA = "0x1826C0750", Slot = "8")]
	protected override void OEECIDDHIAM(ref List<T> BFJIAFJFPDF, int NNHNOIMLALG, T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x26C06A0", Offset = "0x26BF4A0", VA = "0x1826C06A0", Slot = "7")]
	protected override List<T> CJALKNOJAHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x1187780", Offset = "0x1186580", VA = "0x181187780", Slot = "9")]
	protected override ICollection<T> IFBNIOMHDFI(ref List<T> PADMLIBHHBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class KDNLIIJDCMN<T> : global::OHPNEPADEJF<T, global::MAIHNKKODJD<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x2352030", Offset = "0x2350E30", VA = "0x182352030", Slot = "8")]
	protected override void OEECIDDHIAM(ref global::MAIHNKKODJD<T> BFJIAFJFPDF, int NNHNOIMLALG, T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2351FD0", Offset = "0x2350DD0", VA = "0x182351FD0", Slot = "7")]
	protected override global::MAIHNKKODJD<T> CJALKNOJAHB()
	{
		return default(global::MAIHNKKODJD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2352010", Offset = "0x2350E10", VA = "0x182352010", Slot = "9")]
	protected override IEnumerable<T> IFBNIOMHDFI(ref global::MAIHNKKODJD<T> PADMLIBHHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x109AEF0", Offset = "0x1099CF0", VA = "0x18109AEF0")]
	public KDNLIIJDCMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class JJPKDHCAKDN<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class ILEGMPLHDPE<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class EOALNDOJAHB<T> : global::HBFNKAIDHHG<T>, BBDBBGCPFMC where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x10509C0", Offset = "0x104F7C0", VA = "0x1810509C0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, T MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x10507B0", Offset = "0x104F5B0", VA = "0x1810507B0", Slot = "5")]
	public T BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
	public EOALNDOJAHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class EOEOMLICPGK : global::HBFNKAIDHHG<IEnumerable>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::HBFNKAIDHHG<IEnumerable> ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x59092D0", Offset = "0x59080D0", VA = "0x1859092D0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, IEnumerable MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x5909120", Offset = "0x5907F20", VA = "0x185909120", Slot = "5")]
	public IEnumerable BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public EOEOMLICPGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class NIKKBPJHJDP : global::HBFNKAIDHHG<ICollection>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	public static readonly global::HBFNKAIDHHG<ICollection> ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x564F270", Offset = "0x564E070", VA = "0x18564F270", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, ICollection MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x564F0C0", Offset = "0x564DEC0", VA = "0x18564F0C0", Slot = "5")]
	public ICollection BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public NIKKBPJHJDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class MLLALGKEIGG : global::HBFNKAIDHHG<IList>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::HBFNKAIDHHG<IList> ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x564D740", Offset = "0x564C540", VA = "0x18564D740", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, IList MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x564D590", Offset = "0x564C390", VA = "0x18564D590", Slot = "5")]
	public IList BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public MLLALGKEIGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class BMDBJAKAPBJ<T> : global::OHPNEPADEJF<T, global::MAIHNKKODJD<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1220", Offset = "0x2CA0020", VA = "0x182CA1220", Slot = "8")]
	protected override void OEECIDDHIAM(ref global::MAIHNKKODJD<T> BFJIAFJFPDF, int NNHNOIMLALG, T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x2351FD0", Offset = "0x2350DD0", VA = "0x182351FD0", Slot = "7")]
	protected override global::MAIHNKKODJD<T> CJALKNOJAHB()
	{
		return default(global::MAIHNKKODJD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x2CA11B0", Offset = "0x2C9FFB0", VA = "0x182CA11B0", Slot = "9")]
	protected override IReadOnlyList<T> IFBNIOMHDFI(ref global::MAIHNKKODJD<T> PADMLIBHHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x1DFFFF0", Offset = "0x1DFEDF0", VA = "0x181DFFFF0")]
	public BMDBJAKAPBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public static class BAKLJHDPKKL
{
	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x58FE4F0", Offset = "0x58FD2F0", VA = "0x1858FE4F0")]
	public static DateTime NEIPNPFCDKK(DateTime KGCNLKKGAEG)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class ICAOHCHJBIP : global::HBFNKAIDHHG<DateTime>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly global::HBFNKAIDHHG<DateTime> ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x5194590", Offset = "0x5193390", VA = "0x185194590", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, DateTime MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x5193630", Offset = "0x5192430", VA = "0x185193630", Slot = "5")]
	public DateTime BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public ICAOHCHJBIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class ANNHDIJGDLI : global::HBFNKAIDHHG<DateTimeOffset>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly global::HBFNKAIDHHG<DateTimeOffset> ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x58FC6D0", Offset = "0x58FB4D0", VA = "0x1858FC6D0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, DateTimeOffset MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x58FB800", Offset = "0x58FA600", VA = "0x1858FB800", Slot = "5")]
	public DateTimeOffset BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public ANNHDIJGDLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class ICLNEDPNMFM : global::HBFNKAIDHHG<TimeSpan>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly global::HBFNKAIDHHG<TimeSpan> ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static byte[] IAGPCNKKMGO;

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x51954E0", Offset = "0x51942E0", VA = "0x1851954E0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, TimeSpan MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x5194A50", Offset = "0x5193850", VA = "0x185194A50", Slot = "5")]
	public TimeSpan BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public ICLNEDPNMFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public abstract class DEJPDFOCHEB<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::HBFNKAIDHHG<TDictionary>, BBDBBGCPFMC where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2F9CBB0", Offset = "0x2F9B9B0", VA = "0x182F9CBB0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, TDictionary MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x2F9B650", Offset = "0x2F9A450", VA = "0x182F9B650", Slot = "5")]
	public TDictionary BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator JBBAAOCMMAH(TDictionary NFJHHMHDKEL);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate CJALKNOJAHB();

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void OEECIDDHIAM(ref TIntermediate BFJIAFJFPDF, int NNHNOIMLALG, TKey JHANOPJHOLP, TValue MGFMONLLLPD);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary IFBNIOMHDFI(ref TIntermediate PADMLIBHHBL);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
	protected DEJPDFOCHEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public abstract class OJLKBBKNDHL<TKey, TValue, TIntermediate, TDictionary> : global::DEJPDFOCHEB<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2538FC0", Offset = "0x2537DC0", VA = "0x182538FC0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> JBBAAOCMMAH(TDictionary NFJHHMHDKEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public abstract class FCEGCFDPBIL<TKey, TValue, TDictionary> : global::OJLKBBKNDHL<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x1187780", Offset = "0x1186580", VA = "0x181187780", Slot = "9")]
	protected override TDictionary IFBNIOMHDFI(ref TDictionary PADMLIBHHBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class CDFMIBLGCLF<TKey, TValue> : global::DEJPDFOCHEB<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x316D6D0", Offset = "0x316C4D0", VA = "0x18316D6D0", Slot = "8")]
	protected override void OEECIDDHIAM(ref Dictionary<TKey, TValue> BFJIAFJFPDF, int NNHNOIMLALG, TKey JHANOPJHOLP, TValue MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x1187780", Offset = "0x1186580", VA = "0x181187780", Slot = "9")]
	protected override Dictionary<TKey, TValue> IFBNIOMHDFI(ref Dictionary<TKey, TValue> PADMLIBHHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x26C06A0", Offset = "0x26BF4A0", VA = "0x1826C06A0", Slot = "7")]
	protected override Dictionary<TKey, TValue> CJALKNOJAHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B2F0", Offset = "0x2A6A0F0", VA = "0x182A6B2F0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator JBBAAOCMMAH(Dictionary<TKey, TValue> NFJHHMHDKEL)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x109AEF0", Offset = "0x1099CF0", VA = "0x18109AEF0")]
	public CDFMIBLGCLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public sealed class OHKKMGDBFGB<TKey, TValue, TDictionary> : global::FCEGCFDPBIL<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x3B51EC0", Offset = "0x3B50CC0", VA = "0x183B51EC0", Slot = "8")]
	protected override void OEECIDDHIAM(ref TDictionary BFJIAFJFPDF, int NNHNOIMLALG, TKey JHANOPJHOLP, TValue MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x1D0C4D0", Offset = "0x1D0B2D0", VA = "0x181D0C4D0", Slot = "7")]
	protected override TDictionary CJALKNOJAHB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public sealed class AEAJKJLNCEJ<TKey, TValue> : global::OJLKBBKNDHL<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B350", Offset = "0x2A6A150", VA = "0x182A6B350", Slot = "8")]
	protected override void OEECIDDHIAM(ref Dictionary<TKey, TValue> BFJIAFJFPDF, int NNHNOIMLALG, TKey JHANOPJHOLP, TValue MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x26C06A0", Offset = "0x26BF4A0", VA = "0x1826C06A0", Slot = "7")]
	protected override Dictionary<TKey, TValue> CJALKNOJAHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x1187780", Offset = "0x1186580", VA = "0x181187780", Slot = "9")]
	protected override IDictionary<TKey, TValue> IFBNIOMHDFI(ref Dictionary<TKey, TValue> PADMLIBHHBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class MGCFANKAPPI<TKey, TValue> : global::FCEGCFDPBIL<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B350", Offset = "0x2A6A150", VA = "0x182A6B350", Slot = "8")]
	protected override void OEECIDDHIAM(ref SortedList<TKey, TValue> BFJIAFJFPDF, int NNHNOIMLALG, TKey JHANOPJHOLP, TValue MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x26C06A0", Offset = "0x26BF4A0", VA = "0x1826C06A0", Slot = "7")]
	protected override SortedList<TKey, TValue> CJALKNOJAHB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class FJJAAHLIIHG<TKey, TValue> : global::DEJPDFOCHEB<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B350", Offset = "0x2A6A150", VA = "0x182A6B350", Slot = "8")]
	protected override void OEECIDDHIAM(ref SortedDictionary<TKey, TValue> BFJIAFJFPDF, int NNHNOIMLALG, TKey JHANOPJHOLP, TValue MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x1187780", Offset = "0x1186580", VA = "0x181187780", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> IFBNIOMHDFI(ref SortedDictionary<TKey, TValue> PADMLIBHHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x26C06A0", Offset = "0x26BF4A0", VA = "0x1826C06A0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> CJALKNOJAHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B2F0", Offset = "0x2A6A0F0", VA = "0x182A6B2F0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator JBBAAOCMMAH(SortedDictionary<TKey, TValue> NFJHHMHDKEL)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class COCIEFOGFNC<T> : global::HBFNKAIDHHG<T>, BBDBBGCPFMC where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x32DBF60", Offset = "0x32DAD60", VA = "0x1832DBF60", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, T MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x32DBD30", Offset = "0x32DAB30", VA = "0x1832DBD30", Slot = "5")]
	public T BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
	public COCIEFOGFNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class JIKDGLABOHE : global::HBFNKAIDHHG<IDictionary>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly global::HBFNKAIDHHG<IDictionary> ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x519B480", Offset = "0x519A280", VA = "0x18519B480", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, IDictionary MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x519B0E0", Offset = "0x5199EE0", VA = "0x18519B0E0", Slot = "5")]
	public IDictionary BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public JIKDGLABOHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class AIGGBPFLILN : global::HBFNKAIDHHG<object>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private delegate void GBOCFKCOPJI(object MFEAAIMOMAK, ref FDOCIEKIOGE IMGJFGGFPOC, object MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly global::JKPKDNKLJAG<KeyValuePair<object, GBOCFKCOPJI>> LACPOBNLJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly FJOMMFMGKED[] PIOHINMFDNC;

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x58F9BA0", Offset = "0x58F89A0", VA = "0x1858F9BA0")]
	public AIGGBPFLILN(params FJOMMFMGKED[] PIOHINMFDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x58F8D30", Offset = "0x58F7B30", VA = "0x1858F8D30", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, object MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x58F8C90", Offset = "0x58F7A90", VA = "0x1858F8C90", Slot = "5")]
	public object BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public static class GMIIDPAENJC
{
	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x590DCA0", Offset = "0x590CAA0", VA = "0x18590DCA0")]
	public static object EAGEFFBMGIO(Type LEDIIMFEFLP, out bool GAPBOFJMEKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x590D380", Offset = "0x590C180", VA = "0x18590D380")]
	public static object BCGJPPJGHIC(Type LEDIIMFEFLP, out bool GAPBOFJMEKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public class KOKHEPDPDIP<T> : global::HBFNKAIDHHG<T>, BBDBBGCPFMC, global::DDPAFIBFIKL<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class NMCHBDJNPEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public NMCHBDJNPEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x3703F40", Offset = "0x3702D40", VA = "0x183703F40")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class IMIMAEHMGOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public global::IJBGJMMNNHD<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public IMIMAEHMGOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x2756DA0", Offset = "0x2755BA0", VA = "0x182756DA0")]
		internal void <.cctor>b__1(ref FDOCIEKIOGE writer, T value, FJOMMFMGKED _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class CEGOKKPGDAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public global::HNFJOCCCBML<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public CEGOKKPGDAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x2DA2270", Offset = "0x2DA1070", VA = "0x182DA2270")]
		internal T <.cctor>b__2(ref JDAEFHPGJAL reader, FJOMMFMGKED _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static readonly global::DGEAHOGJKBB<T> PMMEHIEOMKF;

	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private static readonly Dictionary<T, string> JFBMOKMMNJO;

	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private static readonly global::IJBGJMMNNHD<T> PJONHJKEPCE;

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly global::HNFJOCCCBML<T> EGCGHBFLGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private readonly bool KOKHFBNPGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private readonly global::IJBGJMMNNHD<T> JGBBBDLLOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::HNFJOCCCBML<T> LBLPJHLEAEN;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x3C3DD60", Offset = "0x3C3CB60", VA = "0x183C3DD60")]
	static KOKHEPDPDIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x3C4D750", Offset = "0x3C4C550", VA = "0x183C4D750")]
	public KOKHEPDPDIP(bool KOKHFBNPGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3C37900", Offset = "0x3C36700", VA = "0x183C37900", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, T MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3C317A0", Offset = "0x3C305A0", VA = "0x183C317A0", Slot = "5")]
	public T BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x3C38CB0", Offset = "0x3C37AB0", VA = "0x183C38CB0", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, T MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x3C35890", Offset = "0x3C34690", VA = "0x183C35890", Slot = "7")]
	public T DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class BCHJILGEMPJ<T> : global::HBFNKAIDHHG<T[,]>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x38E3360", Offset = "0x38E2160", VA = "0x1838E3360", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, T[,] MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x38E3090", Offset = "0x38E1E90", VA = "0x1838E3090", Slot = "5")]
	public T[,] BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
	public BCHJILGEMPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class NBGGPABPHGF<T> : global::HBFNKAIDHHG<T[,,]>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x31AAA30", Offset = "0x31A9830", VA = "0x1831AAA30", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, T[,,] MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x31AA650", Offset = "0x31A9450", VA = "0x1831AA650", Slot = "5")]
	public T[,,] BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
	public NBGGPABPHGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class MHFGFGIHFEB<T> : global::HBFNKAIDHHG<T[,,,]>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2CF61E0", Offset = "0x2CF4FE0", VA = "0x182CF61E0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, T[,,,] MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5CA0", Offset = "0x2CF4AA0", VA = "0x182CF5CA0", Slot = "5")]
	public T[,,,] BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
	public MHFGFGIHFEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class JFPIKEHLIPO<T> : global::HBFNKAIDHHG<T?>, BBDBBGCPFMC where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2A4E410", Offset = "0x2A4D210", VA = "0x182A4E410", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, T? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A4E160", Offset = "0x2A4CF60", VA = "0x182A4E160", Slot = "5")]
	public T? BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
	public JFPIKEHLIPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class FLJGNLHABIE<T> : global::HBFNKAIDHHG<T?>, BBDBBGCPFMC where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private readonly global::HBFNKAIDHHG<T> DKPKPFONJIP;

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x1050770", Offset = "0x104F570", VA = "0x181050770")]
	public FLJGNLHABIE(global::HBFNKAIDHHG<T> DKPKPFONJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A706A0", Offset = "0x2A6F4A0", VA = "0x182A706A0")]
	public FLJGNLHABIE(Type EJEDDCFCCLK, object[] LCIPCKMAANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x2A6FA10", Offset = "0x2A6E810", VA = "0x182A6FA10", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, T? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F3A0", Offset = "0x2A6E1A0", VA = "0x182A6F3A0", Slot = "5")]
	public T? BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class BMGLCJNHIEO : global::HBFNKAIDHHG<sbyte>, BBDBBGCPFMC, global::DDPAFIBFIKL<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly BMGLCJNHIEO ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x5901180", Offset = "0x58FFF80", VA = "0x185901180", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, sbyte MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x59010C0", Offset = "0x58FFEC0", VA = "0x1859010C0", Slot = "5")]
	public sbyte BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x59011C0", Offset = "0x58FFFC0", VA = "0x1859011C0", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, sbyte MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x59010D0", Offset = "0x58FFED0", VA = "0x1859010D0", Slot = "7")]
	public sbyte DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public BMGLCJNHIEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class GMEANJNPFHF : global::HBFNKAIDHHG<sbyte?>, BBDBBGCPFMC, global::DDPAFIBFIKL<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly GMEANJNPFHF ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x590D180", Offset = "0x590BF80", VA = "0x18590D180", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, sbyte? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x590D010", Offset = "0x590BE10", VA = "0x18590D010", Slot = "5")]
	public sbyte? BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x590D210", Offset = "0x590C010", VA = "0x18590D210", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, sbyte? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x590D080", Offset = "0x590BE80", VA = "0x18590D080", Slot = "7")]
	public sbyte? DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public GMEANJNPFHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class JDMDDBDFKHO : global::HBFNKAIDHHG<sbyte[]>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly JDMDDBDFKHO ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x519ABD0", Offset = "0x51999D0", VA = "0x18519ABD0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, sbyte[] MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x519A9A0", Offset = "0x51997A0", VA = "0x18519A9A0", Slot = "5")]
	public sbyte[] BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public JDMDDBDFKHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class LCAAFLIKMFC : global::HBFNKAIDHHG<short>, BBDBBGCPFMC, global::DDPAFIBFIKL<short>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly LCAAFLIKMFC ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x519E090", Offset = "0x519CE90", VA = "0x18519E090", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, short MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x519DFB0", Offset = "0x519CDB0", VA = "0x18519DFB0", Slot = "5")]
	public short BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x519E0B0", Offset = "0x519CEB0", VA = "0x18519E0B0", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, short MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x519E010", Offset = "0x519CE10", VA = "0x18519E010", Slot = "7")]
	public short DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public LCAAFLIKMFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class KDDIEDKCBBK : global::HBFNKAIDHHG<short?>, BBDBBGCPFMC, global::DDPAFIBFIKL<short?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly KDDIEDKCBBK ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x519BF60", Offset = "0x519AD60", VA = "0x18519BF60", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, short? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x519BDF0", Offset = "0x519ABF0", VA = "0x18519BDF0", Slot = "5")]
	public short? BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x519BFE0", Offset = "0x519ADE0", VA = "0x18519BFE0", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, short? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x519BEA0", Offset = "0x519ACA0", VA = "0x18519BEA0", Slot = "7")]
	public short? DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KDDIEDKCBBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class GHNMGFAAOIM : global::HBFNKAIDHHG<short[]>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly GHNMGFAAOIM ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x590CBD0", Offset = "0x590B9D0", VA = "0x18590CBD0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, short[] MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x590CA90", Offset = "0x590B890", VA = "0x18590CA90", Slot = "5")]
	public short[] BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public GHNMGFAAOIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class BLLKFFAFBLI : global::HBFNKAIDHHG<int>, BBDBBGCPFMC, global::DDPAFIBFIKL<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly BLLKFFAFBLI ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5900F70", Offset = "0x58FFD70", VA = "0x185900F70", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, int MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5900EB0", Offset = "0x58FFCB0", VA = "0x185900EB0", Slot = "5")]
	public int BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5900FA0", Offset = "0x58FFDA0", VA = "0x185900FA0", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, int MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x5900EC0", Offset = "0x58FFCC0", VA = "0x185900EC0", Slot = "7")]
	public int DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public BLLKFFAFBLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class GOFICFJDDJM : global::HBFNKAIDHHG<int?>, BBDBBGCPFMC, global::DDPAFIBFIKL<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly GOFICFJDDJM ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x590E720", Offset = "0x590D520", VA = "0x18590E720", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, int? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x590E5C0", Offset = "0x590D3C0", VA = "0x18590E5C0", Slot = "5")]
	public int? BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x590E7B0", Offset = "0x590D5B0", VA = "0x18590E7B0", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, int? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x590E630", Offset = "0x590D430", VA = "0x18590E630", Slot = "7")]
	public int? DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public GOFICFJDDJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class OLFOIEHIFAG : global::HBFNKAIDHHG<int[]>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly OLFOIEHIFAG ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x5654690", Offset = "0x5653490", VA = "0x185654690", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, int[] MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x5654550", Offset = "0x5653350", VA = "0x185654550", Slot = "5")]
	public int[] BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public OLFOIEHIFAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class HJJCOPKBDLI : global::HBFNKAIDHHG<long>, BBDBBGCPFMC, global::DDPAFIBFIKL<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly HJJCOPKBDLI ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x5193210", Offset = "0x5192010", VA = "0x185193210", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, long MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x5193180", Offset = "0x5191F80", VA = "0x185193180", Slot = "5")]
	public long BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x5193230", Offset = "0x5192030", VA = "0x185193230", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, long MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x5193190", Offset = "0x5191F90", VA = "0x185193190", Slot = "7")]
	public long DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public HJJCOPKBDLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class ANLPFHMBDAA : global::HBFNKAIDHHG<long?>, BBDBBGCPFMC, global::DDPAFIBFIKL<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly ANLPFHMBDAA ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x58FB600", Offset = "0x58FA400", VA = "0x1858FB600", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, long? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x58FB420", Offset = "0x58FA220", VA = "0x1858FB420", Slot = "5")]
	public long? BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x58FB690", Offset = "0x58FA490", VA = "0x1858FB690", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, long? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x58FB4B0", Offset = "0x58FA2B0", VA = "0x1858FB4B0", Slot = "7")]
	public long? DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public ANLPFHMBDAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class MLGLIMKHBGJ : global::HBFNKAIDHHG<long[]>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly MLGLIMKHBGJ ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x564D470", Offset = "0x564C270", VA = "0x18564D470", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, long[] MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x564D330", Offset = "0x564C130", VA = "0x18564D330", Slot = "5")]
	public long[] BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public MLGLIMKHBGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class CBCLJNJIEKH : global::HBFNKAIDHHG<byte>, BBDBBGCPFMC, global::DDPAFIBFIKL<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly CBCLJNJIEKH ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x59019E0", Offset = "0x59007E0", VA = "0x1859019E0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, byte MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5901920", Offset = "0x5900720", VA = "0x185901920", Slot = "5")]
	public byte BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5901A20", Offset = "0x5900820", VA = "0x185901A20", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, byte MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5901930", Offset = "0x5900730", VA = "0x185901930", Slot = "7")]
	public byte DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public CBCLJNJIEKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class JOBFONLFAKB : global::HBFNKAIDHHG<byte?>, BBDBBGCPFMC, global::DDPAFIBFIKL<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly JOBFONLFAKB ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x519BB30", Offset = "0x519A930", VA = "0x18519BB30", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, byte? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x519B9C0", Offset = "0x519A7C0", VA = "0x18519B9C0", Slot = "5")]
	public byte? BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x519BBB0", Offset = "0x519A9B0", VA = "0x18519BBB0", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, byte? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x519BA70", Offset = "0x519A870", VA = "0x18519BA70", Slot = "7")]
	public byte? DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public JOBFONLFAKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class KDPNPODCANK : global::HBFNKAIDHHG<ushort>, BBDBBGCPFMC, global::DDPAFIBFIKL<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly KDPNPODCANK ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x519C280", Offset = "0x519B080", VA = "0x18519C280", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, ushort MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x519C1A0", Offset = "0x519AFA0", VA = "0x18519C1A0", Slot = "5")]
	public ushort BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x519C2A0", Offset = "0x519B0A0", VA = "0x18519C2A0", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, ushort MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x519C200", Offset = "0x519B000", VA = "0x18519C200", Slot = "7")]
	public ushort DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KDPNPODCANK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class DFIFKFNKKMJ : global::HBFNKAIDHHG<ushort?>, BBDBBGCPFMC, global::DDPAFIBFIKL<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly DFIFKFNKKMJ ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x5903710", Offset = "0x5902510", VA = "0x185903710", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, ushort? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x59035B0", Offset = "0x59023B0", VA = "0x1859035B0", Slot = "5")]
	public ushort? BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x59037A0", Offset = "0x59025A0", VA = "0x1859037A0", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, ushort? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x5903620", Offset = "0x5902420", VA = "0x185903620", Slot = "7")]
	public ushort? DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public DFIFKFNKKMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class ILIAKPGEGEJ : global::HBFNKAIDHHG<ushort[]>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly ILIAKPGEGEJ ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5197180", Offset = "0x5195F80", VA = "0x185197180", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, ushort[] MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x5196F50", Offset = "0x5195D50", VA = "0x185196F50", Slot = "5")]
	public ushort[] BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public ILIAKPGEGEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class NBMNMCMJHDE : global::HBFNKAIDHHG<uint>, BBDBBGCPFMC, global::DDPAFIBFIKL<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly NBMNMCMJHDE ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x564E6C0", Offset = "0x564D4C0", VA = "0x18564E6C0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, uint MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x564E630", Offset = "0x564D430", VA = "0x18564E630", Slot = "5")]
	public uint BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x564E6D0", Offset = "0x564D4D0", VA = "0x18564E6D0", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, uint MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x564E640", Offset = "0x564D440", VA = "0x18564E640", Slot = "7")]
	public uint DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public NBMNMCMJHDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class IOFGOFDFHAM : global::HBFNKAIDHHG<uint?>, BBDBBGCPFMC, global::DDPAFIBFIKL<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly IOFGOFDFHAM ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x5197410", Offset = "0x5196210", VA = "0x185197410", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, uint? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x51972A0", Offset = "0x51960A0", VA = "0x1851972A0", Slot = "5")]
	public uint? BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x5197480", Offset = "0x5196280", VA = "0x185197480", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, uint? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x5197350", Offset = "0x5196150", VA = "0x185197350", Slot = "7")]
	public uint? DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public IOFGOFDFHAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class MJBNKFDDADN : global::HBFNKAIDHHG<uint[]>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly MJBNKFDDADN ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x564C9A0", Offset = "0x564B7A0", VA = "0x18564C9A0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, uint[] MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x564C860", Offset = "0x564B660", VA = "0x18564C860", Slot = "5")]
	public uint[] BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public MJBNKFDDADN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class OIBFEDBMJBD : global::HBFNKAIDHHG<ulong>, BBDBBGCPFMC, global::DDPAFIBFIKL<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly OIBFEDBMJBD ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x5654230", Offset = "0x5653030", VA = "0x185654230", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, ulong MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x56541A0", Offset = "0x5652FA0", VA = "0x1856541A0", Slot = "5")]
	public ulong BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5654250", Offset = "0x5653050", VA = "0x185654250", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, ulong MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x56541B0", Offset = "0x5652FB0", VA = "0x1856541B0", Slot = "7")]
	public ulong DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public OIBFEDBMJBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class PIKIFFCAJKP : global::HBFNKAIDHHG<ulong?>, BBDBBGCPFMC, global::DDPAFIBFIKL<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly PIKIFFCAJKP ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x56567A0", Offset = "0x56555A0", VA = "0x1856567A0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, ulong? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x5656630", Offset = "0x5655430", VA = "0x185656630", Slot = "5")]
	public ulong? BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5656820", Offset = "0x5655620", VA = "0x185656820", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, ulong? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x56566C0", Offset = "0x56554C0", VA = "0x1856566C0", Slot = "7")]
	public ulong? DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public PIKIFFCAJKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class CECPKIAHPFD : global::HBFNKAIDHHG<ulong[]>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly CECPKIAHPFD ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5901C80", Offset = "0x5900A80", VA = "0x185901C80", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, ulong[] MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x5901B40", Offset = "0x5900940", VA = "0x185901B40", Slot = "5")]
	public ulong[] BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public CECPKIAHPFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class BFDPBCPICEA : global::HBFNKAIDHHG<float>, BBDBBGCPFMC, global::DDPAFIBFIKL<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly BFDPBCPICEA ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x58FE730", Offset = "0x58FD530", VA = "0x1858FE730", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, float MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x58FE670", Offset = "0x58FD470", VA = "0x1858FE670", Slot = "5")]
	public float BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x58FE740", Offset = "0x58FD540", VA = "0x1858FE740", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, float MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x58FE680", Offset = "0x58FD480", VA = "0x1858FE680", Slot = "7")]
	public float DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public BFDPBCPICEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class PCLKEOADINM : global::HBFNKAIDHHG<float?>, BBDBBGCPFMC, global::DDPAFIBFIKL<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly PCLKEOADINM ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x56555E0", Offset = "0x56543E0", VA = "0x1856555E0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, float? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x56554B0", Offset = "0x56542B0", VA = "0x1856554B0", Slot = "5")]
	public float? BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x5655660", Offset = "0x5654460", VA = "0x185655660", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, float? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x5655520", Offset = "0x5654320", VA = "0x185655520", Slot = "7")]
	public float? DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public PCLKEOADINM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class ILFBJIBIIBM : global::HBFNKAIDHHG<float[]>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly ILFBJIBIIBM ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x5196E30", Offset = "0x5195C30", VA = "0x185196E30", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, float[] MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x5196C00", Offset = "0x5195A00", VA = "0x185196C00", Slot = "5")]
	public float[] BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public ILFBJIBIIBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class KJOANJANJOJ : global::HBFNKAIDHHG<double>, BBDBBGCPFMC, global::DDPAFIBFIKL<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly KJOANJANJOJ ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x519C3D0", Offset = "0x519B1D0", VA = "0x18519C3D0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, double MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x519C340", Offset = "0x519B140", VA = "0x18519C340", Slot = "5")]
	public double BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x519C3E0", Offset = "0x519B1E0", VA = "0x18519C3E0", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, double MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x519C350", Offset = "0x519B150", VA = "0x18519C350", Slot = "7")]
	public double DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KJOANJANJOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class NAJEJCCLBIL : global::HBFNKAIDHHG<double?>, BBDBBGCPFMC, global::DDPAFIBFIKL<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly NAJEJCCLBIL ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x564DCA0", Offset = "0x564CAA0", VA = "0x18564DCA0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, double? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x564DB30", Offset = "0x564C930", VA = "0x18564DB30", Slot = "5")]
	public double? BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x564DD20", Offset = "0x564CB20", VA = "0x18564DD20", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, double? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x564DBC0", Offset = "0x564C9C0", VA = "0x18564DBC0", Slot = "7")]
	public double? DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public NAJEJCCLBIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class OKAFBLFCDHH : global::HBFNKAIDHHG<double[]>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly OKAFBLFCDHH ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x5654430", Offset = "0x5653230", VA = "0x185654430", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, double[] MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x56542F0", Offset = "0x56530F0", VA = "0x1856542F0", Slot = "5")]
	public double[] BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public OKAFBLFCDHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class DHCPDKDKPIE : global::HBFNKAIDHHG<bool>, BBDBBGCPFMC, global::DDPAFIBFIKL<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly DHCPDKDKPIE ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x59040A0", Offset = "0x5902EA0", VA = "0x1859040A0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, bool MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x5904010", Offset = "0x5902E10", VA = "0x185904010", Slot = "5")]
	public bool BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x59040C0", Offset = "0x5902EC0", VA = "0x1859040C0", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, bool MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x5904020", Offset = "0x5902E20", VA = "0x185904020", Slot = "7")]
	public bool DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public DHCPDKDKPIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class FJIPJKDGKPD : global::HBFNKAIDHHG<bool?>, BBDBBGCPFMC, global::DDPAFIBFIKL<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly FJIPJKDGKPD ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x590C490", Offset = "0x590B290", VA = "0x18590C490", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, bool? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x590C360", Offset = "0x590B160", VA = "0x18590C360", Slot = "5")]
	public bool? BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x590C510", Offset = "0x590B310", VA = "0x18590C510", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, bool? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x590C3D0", Offset = "0x590B1D0", VA = "0x18590C3D0", Slot = "7")]
	public bool? DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public FJIPJKDGKPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class HDPNELLNFGL : global::HBFNKAIDHHG<bool[]>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly HDPNELLNFGL ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x5192070", Offset = "0x5190E70", VA = "0x185192070", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, bool[] MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x5191E40", Offset = "0x5190C40", VA = "0x185191E40", Slot = "5")]
	public bool[] BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public HDPNELLNFGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class HBHGBKKLEBH : global::HBFNKAIDHHG<object>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly global::HBFNKAIDHHG<object> ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly Dictionary<Type, int> LHECHLEDPMK;

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x590ED80", Offset = "0x590DB80", VA = "0x18590ED80", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, object MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x590EA50", Offset = "0x590D850", VA = "0x18590EA50", Slot = "5")]
	public object BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public HBHGBKKLEBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class FACFNFMCAPE : global::HBFNKAIDHHG<byte[]>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly global::HBFNKAIDHHG<byte[]> ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x5909620", Offset = "0x5908420", VA = "0x185909620", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, byte[] MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x59095A0", Offset = "0x59083A0", VA = "0x1859095A0", Slot = "5")]
	public byte[] BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public FACFNFMCAPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class IIIHENJGLNN : global::HBFNKAIDHHG<ArraySegment<byte>>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly global::HBFNKAIDHHG<ArraySegment<byte>> ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x5195CE0", Offset = "0x5194AE0", VA = "0x185195CE0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, ArraySegment<byte> MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x5195C00", Offset = "0x5194A00", VA = "0x185195C00", Slot = "5")]
	public ArraySegment<byte> BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public IIIHENJGLNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class COCEKOLOCHD : global::HBFNKAIDHHG<string>, BBDBBGCPFMC, global::DDPAFIBFIKL<string>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::HBFNKAIDHHG<string> ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x5903000", Offset = "0x5901E00", VA = "0x185903000", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, string MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x5902FF0", Offset = "0x5901DF0", VA = "0x185902FF0", Slot = "5")]
	public string BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x5903000", Offset = "0x5901E00", VA = "0x185903000", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, string MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x5902FF0", Offset = "0x5901DF0", VA = "0x185902FF0", Slot = "7")]
	public string DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public COCEKOLOCHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class NHPKJHBLNJC : global::HBFNKAIDHHG<string[]>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly NHPKJHBLNJC ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x564EF90", Offset = "0x564DD90", VA = "0x18564EF90", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, string[] MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x564EE20", Offset = "0x564DC20", VA = "0x18564EE20", Slot = "5")]
	public string[] BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public NHPKJHBLNJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class ECLLKAGPKEJ : global::HBFNKAIDHHG<char>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly ECLLKAGPKEJ ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x5908BD0", Offset = "0x59079D0", VA = "0x185908BD0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, char MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x5908BA0", Offset = "0x59079A0", VA = "0x185908BA0", Slot = "5")]
	public char BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public ECLLKAGPKEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class MELIDJNFMJH : global::HBFNKAIDHHG<char?>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly MELIDJNFMJH ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x564C550", Offset = "0x564B350", VA = "0x18564C550", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, char? MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x564C480", Offset = "0x564B280", VA = "0x18564C480", Slot = "5")]
	public char? BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public MELIDJNFMJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class MANAFLAHGEF : global::HBFNKAIDHHG<char[]>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly MANAFLAHGEF ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x51A96C0", Offset = "0x51A84C0", VA = "0x1851A96C0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, char[] MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x51A94C0", Offset = "0x51A82C0", VA = "0x1851A94C0", Slot = "5")]
	public char[] BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public MANAFLAHGEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class HHDHILGDPII : global::HBFNKAIDHHG<Guid>, BBDBBGCPFMC, global::DDPAFIBFIKL<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::HBFNKAIDHHG<Guid> ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x5192250", Offset = "0x5191050", VA = "0x185192250", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, Guid MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x5192200", Offset = "0x5191000", VA = "0x185192200", Slot = "5")]
	public Guid BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x5192320", Offset = "0x5191120", VA = "0x185192320", Slot = "6")]
	public void NAAGLPKBEBP(ref FDOCIEKIOGE IMGJFGGFPOC, Guid MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x5192200", Offset = "0x5191000", VA = "0x185192200", Slot = "7")]
	public Guid DJKEPMDCBOI(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public HHDHILGDPII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class BIGFAOHMOGF : global::HBFNKAIDHHG<decimal>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::HBFNKAIDHHG<decimal> ONJMHIPHCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private readonly bool EHCJHPMKMHE;

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x914030", Offset = "0x912E30", VA = "0x180914030")]
	public BIGFAOHMOGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x110F570", Offset = "0x110E370", VA = "0x18110F570")]
	public BIGFAOHMOGF(bool EHCJHPMKMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x5900CD0", Offset = "0x58FFAD0", VA = "0x185900CD0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, decimal MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x5900AA0", Offset = "0x58FF8A0", VA = "0x185900AA0", Slot = "5")]
	public decimal BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class BMJANDIELAH : global::HBFNKAIDHHG<Uri>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly global::HBFNKAIDHHG<Uri> ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x5901360", Offset = "0x5900160", VA = "0x185901360", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, Uri MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x59012E0", Offset = "0x59000E0", VA = "0x1859012E0", Slot = "5")]
	public Uri BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public BMJANDIELAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class HMBNHFIEGFN : global::HBFNKAIDHHG<Version>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly global::HBFNKAIDHHG<Version> ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x5193350", Offset = "0x5192150", VA = "0x185193350", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, Version MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x51932D0", Offset = "0x51920D0", VA = "0x1851932D0", Slot = "5")]
	public Version BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public HMBNHFIEGFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class NDLANKMKABL<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class GOJDHKJHMLF : global::HBFNKAIDHHG<StringBuilder>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly global::HBFNKAIDHHG<StringBuilder> ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x590E9A0", Offset = "0x590D7A0", VA = "0x18590E9A0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, StringBuilder MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x590E920", Offset = "0x590D720", VA = "0x18590E920", Slot = "5")]
	public StringBuilder BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public GOJDHKJHMLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class FIINNELNEHG : global::HBFNKAIDHHG<BitArray>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly global::HBFNKAIDHHG<BitArray> ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x590BEB0", Offset = "0x590ACB0", VA = "0x18590BEB0", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, BitArray MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x590BD90", Offset = "0x590AB90", VA = "0x18590BD90", Slot = "5")]
	public BitArray BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public FIINNELNEHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class FJDGBDPOGOK : global::HBFNKAIDHHG<Type>, BBDBBGCPFMC
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly FJDGBDPOGOK ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly Regex IGJEOIGACHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool JFEDCIKEOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private bool DIFEEGHFFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private bool PBKECCPNFPB;

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x590C2F0", Offset = "0x590B0F0", VA = "0x18590C2F0")]
	public FJDGBDPOGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x590C310", Offset = "0x590B110", VA = "0x18590C310")]
	public FJDGBDPOGOK(bool JFEDCIKEOPN, bool DIFEEGHFFGO, bool PBKECCPNFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x590C140", Offset = "0x590AF40", VA = "0x18590C140", Slot = "4")]
	public void EPOBOPBJBKM(ref FDOCIEKIOGE IMGJFGGFPOC, Type MGFMONLLLPD, FJOMMFMGKED CMOJLEGEDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x590C010", Offset = "0x590AE10", VA = "0x18590C010", Slot = "5")]
	public Type BPPOCFBLMGN(ref JDAEFHPGJAL IDIEIECFGPN, FJOMMFMGKED CMOJLEGEDCH)
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
