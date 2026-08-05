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
public class MOLKMLGPCAH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x58D480", Offset = "0x58C480", VA = "0x18058D480")]
	public MOLKMLGPCAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class MOIOCJADBMN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x58D480", Offset = "0x58C480", VA = "0x18058D480")]
	public MOIOCJADBMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class CNIDIAELIPB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x58D480", Offset = "0x58C480", VA = "0x18058D480")]
	public CNIDIAELIPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class JCEJMFFGDGO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x58D480", Offset = "0x58C480", VA = "0x18058D480")]
	public JCEJMFFGDGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class BBIOLKMJPHO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x34EE2F0", Offset = "0x34ED2F0", VA = "0x1834EE2F0")]
	public static bool NAAOBCCCAJJ(this TypeInfo JFEPPDBLNIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class LHPFNGMPIHE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type DPFAKEOINEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x58D490", Offset = "0x58C490", VA = "0x18058D490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] PGKLGFJEGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6CE7D0", Offset = "0x6CD7D0", VA = "0x1806CE7D0")]
	public LHPFNGMPIHE(Type BGAPKNDGPOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class LCJMNPHAHDE : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void MDJBEFEKPNE<T>(ref KGFCABFEODL LMBCAOJBJPJ, T GGAFBKIEDPG, AJMMOEDPFDO AIAGOPPIPMF);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T HCHHAEDJHDL<T>(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO AIAGOPPIPMF);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MFPFDMIAIBB
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GBPOCNIAKNN<T> : MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, T GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PBDCCPEPJIO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, T GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum BJAAJMHKOAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IENEKIPMAMC
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x210C360", Offset = "0x210B360", VA = "0x18210C360")]
	public static global::GBPOCNIAKNN<T> HLNAPLDOCDP<T>(this AJMMOEDPFDO AIAGOPPIPMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2FA13E0", Offset = "0x2FA03E0", VA = "0x182FA13E0")]
	public static object NPGHAOBHFGI(this AJMMOEDPFDO AIAGOPPIPMF, Type JFEPPDBLNIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PAHJDJKNLID : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x505DAE0", Offset = "0x505CAE0", VA = "0x18505DAE0")]
	public PAHJDJKNLID(string ADIELDAOJPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DMMPAKHNCHE
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class IHLPKMHGIIO
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] NMENBHGBOOL;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] ECKKECIMAHD;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3504230", Offset = "0x3503230", VA = "0x183504230")]
		public static byte[] NGLJDJIGEIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x35041A0", Offset = "0x35031A0", VA = "0x1835041A0")]
		public static char[] JGMIDJDKIMM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> EADFOKGLBEG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] PNDJHMOHHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] LNCIHJHIBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int GPILAGKEABD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool DLFEPCNPFCB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x34FD4A0", Offset = "0x34FC4A0", VA = "0x1834FD4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x34FED10", Offset = "0x34FDD10", VA = "0x1834FED10")]
	public DMMPAKHNCHE(byte[] LNCIHJHIBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x34FED20", Offset = "0x34FDD20", VA = "0x1834FED20")]
	public DMMPAKHNCHE(byte[] LNCIHJHIBKD, int GPILAGKEABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x34FE6F0", Offset = "0x34FD6F0", VA = "0x1834FE6F0")]
	private HALBBJCBOIC PMBDGMALGOL(string KCIKPCCJAJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x34FE310", Offset = "0x34FD310", VA = "0x1834FE310")]
	private HALBBJCBOIC OBBOLJANCJD(string ADIELDAOJPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2FA81A0", Offset = "0x2FA71A0", VA = "0x182FA81A0")]
	public void LGFJGKLGBMH(int GPILAGKEABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7630E0", Offset = "0x7620E0", VA = "0x1807630E0")]
	public byte[] AMGNDFLAMNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84C1B0", Offset = "0x84B1B0", VA = "0x18084C1B0")]
	public int COPNNBMMMPM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x34FDE70", Offset = "0x34FCE70", VA = "0x1834FDE70")]
	public BAIHAMKMFCC LLDMCJHHJKN()
	{
		return default(BAIHAMKMFCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x34FE450", Offset = "0x34FD450", VA = "0x1834FE450")]
	public void OMAAONLPEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x34FE150", Offset = "0x34FD150", VA = "0x1834FE150")]
	public bool MOAHKMGPDHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x34FC840", Offset = "0x34FB840", VA = "0x1834FC840")]
	public bool CEAKAJEFBKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x34FDCA0", Offset = "0x34FCCA0", VA = "0x1834FDCA0")]
	public void LDNMJLNBIAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x34FE0C0", Offset = "0x34FD0C0", VA = "0x1834FE0C0")]
	public bool MBLNNKCGAOG(ref int GLCMJLMDOEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x34FD520", Offset = "0x34FC520", VA = "0x1834FD520")]
	public bool HCKPNBLBIJH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x34FD590", Offset = "0x34FC590", VA = "0x1834FD590")]
	public void HDHAHPHLDJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x34FD700", Offset = "0x34FC700", VA = "0x1834FD700")]
	public bool JENIKNNEJIG(ref int GLCMJLMDOEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x34FE680", Offset = "0x34FD680", VA = "0x1834FE680")]
	public bool PLGFJMEBJDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x34FEB90", Offset = "0x34FDB90", VA = "0x1834FEB90")]
	public void PNGPPGEEOBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x34FE2A0", Offset = "0x34FD2A0", VA = "0x1834FE2A0")]
	public bool NEEPCGLLPBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x34FD140", Offset = "0x34FC140", VA = "0x1834FD140")]
	public void EANLIKJOPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x34FC8B0", Offset = "0x34FB8B0", VA = "0x1834FC8B0")]
	private void CGMPKNBOOBN(out byte[] AJCFHANJNKO, out int LLHAKPKAELA, out int MHHDHLFLKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x34FDDC0", Offset = "0x34FCDC0", VA = "0x1834FDDC0")]
	private static int LJKOFPMAIJE(char INIPPOEHOLP, char BMEGDOGJIKK, char HEMCNHOJBJG, char LPFPPCBAAAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x34FD630", Offset = "0x34FC630", VA = "0x1834FD630")]
	private static int HLOPFPDLPGF(char BIBNBCIJJEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x34FD1E0", Offset = "0x34FC1E0", VA = "0x1834FD1E0")]
	public ArraySegment<byte> EBGLNJKLEIH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x34FD040", Offset = "0x34FC040", VA = "0x1834FD040")]
	public string CLFFCDBNAEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x34FE270", Offset = "0x34FD270", VA = "0x1834FE270")]
	public string NDDKFIFPFJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x34FC450", Offset = "0x34FB450", VA = "0x1834FC450")]
	public ArraySegment<byte> ALNAHBKKEJN()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x34FDB20", Offset = "0x34FCB20", VA = "0x1834FDB20")]
	public ArraySegment<byte> KGCPMFHDHLN()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x34FD7F0", Offset = "0x34FC7F0", VA = "0x1834FD7F0")]
	public bool JMJLPLIOJGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x34FDB60", Offset = "0x34FCB60", VA = "0x1834FDB60")]
	private static bool KODMEJJEGNC(byte HEMCNHOJBJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x34FD2D0", Offset = "0x34FC2D0", VA = "0x1834FD2D0")]
	private void EDACBBDBJGF(BAIHAMKMFCC CNJNFLKBLCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x34FD510", Offset = "0x34FC510", VA = "0x1834FD510")]
	public void GPJEAODENMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x34FDA50", Offset = "0x34FCA50", VA = "0x1834FDA50")]
	private void JOCLIBBPGHF(int ALNKACMNJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x34FD4C0", Offset = "0x34FC4C0", VA = "0x1834FD4C0")]
	public sbyte GOJABGJJLKK()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x34FD0E0", Offset = "0x34FC0E0", VA = "0x1834FD0E0")]
	public short DHBJJOFHCEI()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x34FD790", Offset = "0x34FC790", VA = "0x1834FD790")]
	public int JKLAKMIJBJJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x34FDD40", Offset = "0x34FCD40", VA = "0x1834FDD40")]
	public long LHBDDBOINMM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x34FC7E0", Offset = "0x34FB7E0", VA = "0x1834FC7E0")]
	public byte CBJILPGBGNE()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x34FE3F0", Offset = "0x34FD3F0", VA = "0x1834FE3F0")]
	public ushort ODABAKJPHNF()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x34FC780", Offset = "0x34FB780", VA = "0x1834FC780")]
	public uint CALKOKLBNAL()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x34FDC20", Offset = "0x34FCC20", VA = "0x1834FDC20")]
	public ulong LCMMOMAEFPB()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x34FE000", Offset = "0x34FD000", VA = "0x1834FE000")]
	public float LODJJBMFKGC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x34FC390", Offset = "0x34FB390", VA = "0x1834FC390")]
	public double AIBIHJFDNJM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x34FE590", Offset = "0x34FD590", VA = "0x1834FE590")]
	public ArraySegment<byte> PIEMBDGOPLB()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x34FC600", Offset = "0x34FB600", VA = "0x1834FC600")]
	private static int BEAOPBJOEAB(byte[] LNCIHJHIBKD, int GPILAGKEABD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HALBBJCBOIC : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference AMPPNHIFNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int BOOIIAPGIBH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int HIKMIJOIHPB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1122370", Offset = "0x1121370", VA = "0x181122370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string KIKCBKAFKLI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x627E10", Offset = "0x626E10", VA = "0x180627E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2F9EBF0", Offset = "0x2F9DBF0", VA = "0x182F9EBF0")]
	public HALBBJCBOIC(string ADIELDAOJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2F9EB20", Offset = "0x2F9DB20", VA = "0x182F9EB20")]
	public HALBBJCBOIC(string ADIELDAOJPG, byte[] DKBHKHLJBFF, int GPILAGKEABD, int BOOIIAPGIBH, string MHAMNLEIPPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class NCBOKBEJBFF
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class GIKPFAJEDHE
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void LKBELBJBELC(ref KGFCABFEODL LMBCAOJBJPJ, object GGAFBKIEDPG, AJMMOEDPFDO AIAGOPPIPMF);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object DNHJGGFCGBP(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO AIAGOPPIPMF);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class PHCIKGJNJIP
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class IMNBIBIPAGK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
				public IMNBIBIPAGK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x5054650", Offset = "0x5053650", VA = "0x185054650")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x5054690", Offset = "0x5053690", VA = "0x185054690")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, AJMMOEDPFDO, byte[]> CIBLIGAHOLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, AJMMOEDPFDO> IIIOKACCPBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly LKBELBJBELC BPGFKFIOLNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, AJMMOEDPFDO, ArraySegment<byte>> EDPKPGHHLEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, AJMMOEDPFDO, string> PIFEBICPIKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, AJMMOEDPFDO, object> KJNJHGKLLAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, AJMMOEDPFDO, object> AACJKEPCNNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, AJMMOEDPFDO, object> KPOMGOOGPBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly DNHJGGFCGBP EHFNBOPBJCH;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x505EAA0", Offset = "0x505DAA0", VA = "0x18505EAA0")]
			public PHCIKGJNJIP(Type JFEPPDBLNIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1F752B0", Offset = "0x1F742B0", VA = "0x181F752B0")]
			private static T HMKBEPLHAPP<T>(DynamicMethod CIJJBGIFHJH)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x505E8B0", Offset = "0x505D8B0", VA = "0x18505E8B0")]
			private static MethodInfo CPLPJGLFOKA(Type JFEPPDBLNIJ, string IPJBPCNNBIO, Type[] JBJNBAHADBG)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, PHCIKGJNJIP> MOPEPEKJFLL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::NHBMDHKNINC<PHCIKGJNJIP> PMHPGMPIJKK;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5054260", Offset = "0x5053260", VA = "0x185054260")]
		static GIKPFAJEDHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5053F60", Offset = "0x5052F60", VA = "0x185053F60")]
		private static PHCIKGJNJIP CJECKDEEDCO(Type JFEPPDBLNIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5053FE0", Offset = "0x5052FE0", VA = "0x185053FE0")]
		public static void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, object GGAFBKIEDPG, AJMMOEDPFDO AIAGOPPIPMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5054150", Offset = "0x5053150", VA = "0x185054150")]
		public static void PBAEFNNDLEC(Type JFEPPDBLNIJ, ref KGFCABFEODL LMBCAOJBJPJ, object GGAFBKIEDPG, AJMMOEDPFDO AIAGOPPIPMF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class NEJNGFNBDDF
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] NMENBHGBOOL;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x50597D0", Offset = "0x50587D0", VA = "0x1850597D0")]
		public static byte[] NGLJDJIGEIA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static AJMMOEDPFDO LEPBOBIHIBN;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] HAMPJDNBOHI;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] HPIIEGBKNDD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static AJMMOEDPFDO GOOBHGFJIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x50593E0", Offset = "0x50583E0", VA = "0x1850593E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x50594F0", Offset = "0x50584F0", VA = "0x1850594F0")]
	public static void DMIBIGCOLPO(AJMMOEDPFDO AIAGOPPIPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x36DEE80", Offset = "0x36DDE80", VA = "0x1836DEE80")]
	public static string FNFJNLJGDJE<T>(T GGAFBKIEDPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x36DEF00", Offset = "0x36DDF00", VA = "0x1836DEF00")]
	public static string FNFJNLJGDJE<T>(T GGAFBKIEDPG, AJMMOEDPFDO AIAGOPPIPMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1F70680", Offset = "0x1F6F680", VA = "0x181F70680")]
	public static T PKACOGLGLPC<T>(string BJBGNBLHEBN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1F705B0", Offset = "0x1F6F5B0", VA = "0x181F705B0")]
	public static T PKACOGLGLPC<T>(string BJBGNBLHEBN, AJMMOEDPFDO AIAGOPPIPMF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F70700", Offset = "0x1F6F700", VA = "0x181F70700")]
	public static T PKACOGLGLPC<T>(byte[] LNCIHJHIBKD, AJMMOEDPFDO AIAGOPPIPMF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1F70460", Offset = "0x1F6F460", VA = "0x181F70460")]
	public static T PKACOGLGLPC<T>(byte[] LNCIHJHIBKD, int GPILAGKEABD, AJMMOEDPFDO AIAGOPPIPMF)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum BAIHAMKMFCC : byte
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
public struct KGFCABFEODL
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] FCNLDCJFOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] NMENBHGBOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int GPILAGKEABD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int CNPPBHHEHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x84C1B0", Offset = "0x84B1B0", VA = "0x18084C1B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2FA81A0", Offset = "0x2FA71A0", VA = "0x182FA81A0")]
	public void LGFJGKLGBMH(int GPILAGKEABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7F50", Offset = "0x2FA6F50", VA = "0x182FA7F50")]
	public static byte[] JCBDCMMBOPD(string DDALMOPINCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8410", Offset = "0x2FA7410", VA = "0x182FA8410")]
	public static byte[] NJABANKIJON(string DDALMOPINCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7990", Offset = "0x2FA6990", VA = "0x182FA7990")]
	public static byte[] EKPFDOPJGBC(string DDALMOPINCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8200", Offset = "0x2FA7200", VA = "0x182FA8200")]
	public static byte[] MLDIILPKMLJ(string DDALMOPINCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xD09A90", Offset = "0xD08A90", VA = "0x180D09A90")]
	public KGFCABFEODL(byte[] CKAABDFBGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8360", Offset = "0x2FA7360", VA = "0x182FA8360")]
	public ArraySegment<byte> NGLJDJIGEIA()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8660", Offset = "0x2FA7660", VA = "0x182FA8660")]
	public byte[] PNMHEHGCKMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8900", Offset = "0x2FA7900", VA = "0x182FA8900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8000", Offset = "0x2FA7000", VA = "0x182FA8000")]
	public void JNJBENCJMKC(int APEKKONBOHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7E30", Offset = "0x2FA6E30", VA = "0x182FA7E30")]
	public void GOFKGABCMAB(byte[] OJFBIDHGIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7E90", Offset = "0x2FA6E90", VA = "0x182FA7E90")]
	public void HDLINIOHMOM(byte OJFBIDHGIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7F00", Offset = "0x2FA6F00", VA = "0x182FA7F00")]
	public void HICEOOMAAJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2FA81B0", Offset = "0x2FA71B0", VA = "0x182FA81B0")]
	public void MGKLOJMNBCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8150", Offset = "0x2FA7150", VA = "0x182FA8150")]
	public void LEIBEFOHBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7850", Offset = "0x2FA6850", VA = "0x182FA7850")]
	public void BMNDMFDJNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7590", Offset = "0x2FA6590", VA = "0x182FA7590")]
	public void APOPCDENHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7800", Offset = "0x2FA6800", VA = "0x182FA7800")]
	public void BLBOIHALFKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2FA78D0", Offset = "0x2FA68D0", VA = "0x182FA78D0")]
	public void DJNBOMFEMEG(string DDALMOPINCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2FA84E0", Offset = "0x2FA74E0", VA = "0x182FA84E0")]
	public void OHFLIGCKFJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8530", Offset = "0x2FA7530", VA = "0x182FA8530")]
	public void OINFAFKIEMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2FA75E0", Offset = "0x2FA65E0", VA = "0x182FA75E0")]
	public void BJJNBFPNOKH(bool GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2FA87B0", Offset = "0x2FA77B0", VA = "0x182FA87B0")]
	public void POFJJJIKMAO(float GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8010", Offset = "0x2FA7010", VA = "0x182FA8010")]
	public void LDLJIJJONHK(double GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7930", Offset = "0x2FA6930", VA = "0x182FA7930")]
	public void DPPGJMOAMEL(byte GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7ED0", Offset = "0x2FA6ED0", VA = "0x182FA7ED0")]
	public void HEHKIPIAEDN(ushort GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7960", Offset = "0x2FA6960", VA = "0x182FA7960")]
	public void EKLALJDBECA(uint GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8630", Offset = "0x2FA7630", VA = "0x182FA8630")]
	public void PMCJLCLDLHI(ulong GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2FA77D0", Offset = "0x2FA67D0", VA = "0x182FA77D0")]
	public void BKMPFPHHPLB(sbyte GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7FD0", Offset = "0x2FA6FD0", VA = "0x182FA7FD0")]
	public void JJLKGMGCPBD(short GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2FA78A0", Offset = "0x2FA68A0", VA = "0x182FA78A0")]
	public void COLMEEGKHBG(int GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8600", Offset = "0x2FA7600", VA = "0x182FA8600")]
	public void OMMPDKIBCDK(long GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7A60", Offset = "0x2FA6A60", VA = "0x182FA7A60")]
	public void FMJAPBDDGKB(string GGAFBKIEDPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NCIBICPDKHO : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class GEBEINCNBDC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3772BE0", Offset = "0x3771BE0", VA = "0x183772BE0")]
		static GEBEINCNBDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private NCIBICPDKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class BLKNDGHBJGD
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> COIFNKALJKI;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x34F0D80", Offset = "0x34EFD80", VA = "0x1834F0D80")]
	static BLKNDGHBJGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x34F0820", Offset = "0x34EF820", VA = "0x1834F0820")]
	internal static object OFGGPLEPJAI(Type FHAKMOPLLAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class EGLHNFEPBCP : global::GBPOCNIAKNN<Vector2>, MFPFDMIAIBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly KFIMDPANPGO MFBGHIPDHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] CGIEMGLDHAM;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x35005F0", Offset = "0x34FF5F0", VA = "0x1835005F0")]
	public EGLHNFEPBCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x35002A0", Offset = "0x34FF2A0", VA = "0x1835002A0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, Vector2 GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3500350", Offset = "0x34FF350", VA = "0x183500350", Slot = "5")]
	public Vector2 PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class LOICKDEAIPK : global::GBPOCNIAKNN<Vector3>, MFPFDMIAIBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly KFIMDPANPGO MFBGHIPDHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] CGIEMGLDHAM;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5057C60", Offset = "0x5056C60", VA = "0x185057C60")]
	public LOICKDEAIPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5057950", Offset = "0x5056950", VA = "0x185057950", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, Vector3 GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5057A70", Offset = "0x5056A70", VA = "0x185057A70", Slot = "5")]
	public Vector3 PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class LKJAPFBKHHE : global::GBPOCNIAKNN<Vector4>, MFPFDMIAIBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly KFIMDPANPGO MFBGHIPDHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] CGIEMGLDHAM;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5055FC0", Offset = "0x5054FC0", VA = "0x185055FC0")]
	public LKJAPFBKHHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x34FF4C0", Offset = "0x34FE4C0", VA = "0x1834FF4C0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, Vector4 GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5055D90", Offset = "0x5054D90", VA = "0x185055D90", Slot = "5")]
	public Vector4 PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class MBIFPFGCFFB : global::GBPOCNIAKNN<Quaternion>, MFPFDMIAIBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly KFIMDPANPGO MFBGHIPDHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] CGIEMGLDHAM;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x50580F0", Offset = "0x50570F0", VA = "0x1850580F0")]
	public MBIFPFGCFFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x34FF4C0", Offset = "0x34FE4C0", VA = "0x1834FF4C0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, Quaternion GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5057EC0", Offset = "0x5056EC0", VA = "0x185057EC0", Slot = "5")]
	public Quaternion PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class ECLMOPAAJKC : global::GBPOCNIAKNN<Color>, MFPFDMIAIBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly KFIMDPANPGO MFBGHIPDHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] CGIEMGLDHAM;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x34FF950", Offset = "0x34FE950", VA = "0x1834FF950")]
	public ECLMOPAAJKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x34FF4C0", Offset = "0x34FE4C0", VA = "0x1834FF4C0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, Color GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x34FF610", Offset = "0x34FE610", VA = "0x1834FF610", Slot = "5")]
	public Color PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class MFDBGBAECFG : global::GBPOCNIAKNN<Bounds>, MFPFDMIAIBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly KFIMDPANPGO MFBGHIPDHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] CGIEMGLDHAM;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x50588F0", Offset = "0x50578F0", VA = "0x1850588F0")]
	public MFDBGBAECFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x50583E0", Offset = "0x50573E0", VA = "0x1850583E0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, Bounds GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5058650", Offset = "0x5057650", VA = "0x185058650", Slot = "5")]
	public Bounds PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class CNPIENGCMCK : global::GBPOCNIAKNN<Rect>, MFPFDMIAIBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly KFIMDPANPGO MFBGHIPDHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] CGIEMGLDHAM;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x34F2660", Offset = "0x34F1660", VA = "0x1834F2660")]
	public CNPIENGCMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x34F2180", Offset = "0x34F1180", VA = "0x1834F2180", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, Rect GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x34F22F0", Offset = "0x34F12F0", VA = "0x1834F22F0", Slot = "5")]
	public Rect PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class IMMMJGLMOGF : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class MILEJEMBCCL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x44A5670", Offset = "0x44A4670", VA = "0x1844A5670")]
		static MILEJEMBCCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private IMMMJGLMOGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class JMBGEJAKMOK : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class DAPPMHAGJID<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3B4AF10", Offset = "0x3B49F10", VA = "0x183B4AF10")]
		static DAPPMHAGJID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class BNIEAIJMFJM
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> JPINMJMNCCD;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2F914F0", Offset = "0x2F904F0", VA = "0x182F914F0")]
		internal static object OFGGPLEPJAI(Type FHAKMOPLLAA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private JMBGEJAKMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class FOFIOGLMKFI : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class ELIHJEAHOME<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x41DEB60", Offset = "0x41DDB60", VA = "0x1841DEB60")]
		static ELIHJEAHOME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly FOFIOGLMKFI AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool DLLFAOKJDGA;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static MFPFDMIAIBB[] ECOBELFIDLH;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static AJMMOEDPFDO[] JOKNEMHHENO;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private FOFIOGLMKFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2F96170", Offset = "0x2F95170", VA = "0x182F96170")]
	public static void PDNGOJDAHMM(params AJMMOEDPFDO[] JOKNEMHHENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2F96230", Offset = "0x2F95230", VA = "0x182F96230")]
	public static void PDNGOJDAHMM(params MFPFDMIAIBB[] ECOBELFIDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2F95F20", Offset = "0x2F94F20", VA = "0x182F95F20")]
	public static void KNDGKFDAHLH(MFPFDMIAIBB[] ECOBELFIDLH, AJMMOEDPFDO[] JOKNEMHHENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class CFHHMNJMLJJ : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class LIANKECLNMA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x33F4470", Offset = "0x33F3470", VA = "0x1833F4470")]
		static LIANKECLNMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private CFHHMNJMLJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class CCHIBBCFAAB
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly AJMMOEDPFDO DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly AJMMOEDPFDO IOFKFCONLPG;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly AJMMOEDPFDO LMCLCEKOMBL;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly AJMMOEDPFDO BMACDOGHLLJ;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly AJMMOEDPFDO LMFOBFKAPGH;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly AJMMOEDPFDO PFEEOLKJKCI;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly AJMMOEDPFDO FKHLOHLKHPC;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly AJMMOEDPFDO OMCCLKOKNLH;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly AJMMOEDPFDO BAAHKIDDIJP;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly AJMMOEDPFDO LHAMBIGKMIF;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly AJMMOEDPFDO HCNOBCNECDO;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly AJMMOEDPFDO JEKMHJBNDHE;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class HHBAFAGEEAL
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly AJMMOEDPFDO DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly AJMMOEDPFDO HBFKBBMPDPH;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class ICNLNGHCADA
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly AJMMOEDPFDO DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly AJMMOEDPFDO IOFKFCONLPG;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly AJMMOEDPFDO LMCLCEKOMBL;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly AJMMOEDPFDO BMACDOGHLLJ;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly AJMMOEDPFDO LMFOBFKAPGH;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly AJMMOEDPFDO PFEEOLKJKCI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly AJMMOEDPFDO FKHLOHLKHPC;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly AJMMOEDPFDO OMCCLKOKNLH;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly AJMMOEDPFDO BAAHKIDDIJP;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly AJMMOEDPFDO LHAMBIGKMIF;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly AJMMOEDPFDO HCNOBCNECDO;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly AJMMOEDPFDO JEKMHJBNDHE;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class NPEKMODFLJE
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> JPINMJMNCCD;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x505A100", Offset = "0x5059100", VA = "0x18505A100")]
	internal static object OFGGPLEPJAI(Type FHAKMOPLLAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x505A0C0", Offset = "0x50590C0", VA = "0x18505A0C0")]
	private static object JEJGFGLIAKO(Type DPLBLPLOFGP, Type[] OPILJJFDLBJ, params object[] JBJNBAHADBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class PMGJMKPCHAF : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class DJGOLGABAEO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2CD5790", Offset = "0x2CD4790", VA = "0x182CD5790")]
		static DJGOLGABAEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> JJNNKGCCDJH;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool APLLGDCNGHL;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly JLEFHMJOGAN NLDLKKLIBJK;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5060860", Offset = "0x505F860", VA = "0x185060860")]
	static PMGJMKPCHAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private PMGJMKPCHAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class EFHCADBKMKO : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class DBNLHHFKDCO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x31C6C70", Offset = "0x31C5C70", VA = "0x1831C6C70")]
		static DBNLHHFKDCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> JJNNKGCCDJH;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool APLLGDCNGHL;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly JLEFHMJOGAN NLDLKKLIBJK;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x35001B0", Offset = "0x34FF1B0", VA = "0x1835001B0")]
	static EFHCADBKMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private EFHCADBKMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class EKPFPEIAJFP : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class BDKAKGALFGA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x31C65A0", Offset = "0x31C55A0", VA = "0x1831C65A0")]
		static BDKAKGALFGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> JJNNKGCCDJH;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool APLLGDCNGHL;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly JLEFHMJOGAN NLDLKKLIBJK;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x35008D0", Offset = "0x34FF8D0", VA = "0x1835008D0")]
	static EKPFPEIAJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private EKPFPEIAJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class NDGCGBIPENJ : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class BPILKMCKBAE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2D04EF0", Offset = "0x2D03EF0", VA = "0x182D04EF0")]
		static BPILKMCKBAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> JJNNKGCCDJH;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool APLLGDCNGHL;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly JLEFHMJOGAN NLDLKKLIBJK;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x50596E0", Offset = "0x50586E0", VA = "0x1850596E0")]
	static NDGCGBIPENJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private NDGCGBIPENJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class PMLIOJONLCJ : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class IONLPGLMLAA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x41C7530", Offset = "0x41C6530", VA = "0x1841C7530")]
		static IONLPGLMLAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> JJNNKGCCDJH;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool APLLGDCNGHL;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly JLEFHMJOGAN NLDLKKLIBJK;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5060950", Offset = "0x505F950", VA = "0x185060950")]
	static PMLIOJONLCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private PMLIOJONLCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class BDMKODBNOBA : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class HJNMONDAFPM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x37C7580", Offset = "0x37C6580", VA = "0x1837C7580")]
		static HJNMONDAFPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> JJNNKGCCDJH;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool APLLGDCNGHL;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly JLEFHMJOGAN NLDLKKLIBJK;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x34EF3B0", Offset = "0x34EE3B0", VA = "0x1834EF3B0")]
	static BDMKODBNOBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private BDMKODBNOBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class GBANFNPIJGI : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class CMILNAAABOI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3B71A10", Offset = "0x3B70A10", VA = "0x183B71A10")]
		static CMILNAAABOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> JJNNKGCCDJH;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool APLLGDCNGHL;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public GBANFNPIJGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class DPNAHHLJHCF : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class HANNBGFJLJO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3CAFD70", Offset = "0x3CAED70", VA = "0x183CAFD70")]
		static HANNBGFJLJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> JJNNKGCCDJH;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool APLLGDCNGHL;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public DPNAHHLJHCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class MJENILJOKAA : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class NBFPKEGNNIM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x318FB90", Offset = "0x318EB90", VA = "0x18318FB90")]
		static NBFPKEGNNIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> JJNNKGCCDJH;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool APLLGDCNGHL;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public MJENILJOKAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class HLMHMDLAJON : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class ACDAGKNCNOP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x40B9090", Offset = "0x40B8090", VA = "0x1840B9090")]
		static ACDAGKNCNOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> JJNNKGCCDJH;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool APLLGDCNGHL;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public HLMHMDLAJON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class CIHLJFLILNA : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class EADALFLMKIA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x33ED210", Offset = "0x33EC210", VA = "0x1833ED210")]
		static EADALFLMKIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> JJNNKGCCDJH;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool APLLGDCNGHL;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public CIHLJFLILNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class EACKADIIIAM : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class FFGBLJMGPIE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x31D6260", Offset = "0x31D5260", VA = "0x1831D6260")]
		static FFGBLJMGPIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> JJNNKGCCDJH;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool APLLGDCNGHL;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public EACKADIIIAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class DBJFFNPMKAC
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct CAFCEDLHFFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public IDGLPAIHJPH OKNHMEAPMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder KILGHIDHCLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder GKKBGKKFPGO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class GIJCCOMKLMF
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class PACCANJNFDN
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo EKPFDOPJGBC;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo NJABANKIJON;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo MLDIILPKMLJ;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo JCBDCMMBOPD;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo OINFAFKIEMC;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo GOFKGABCMAB;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo LEIBEFOHBAA;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo BMNDMFDJNOK;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo APOPCDENHGM;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3504CE0", Offset = "0x3503CE0", VA = "0x183504CE0")]
			static PACCANJNFDN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class BLAKFEMCCEK
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo MOAHKMGPDHC;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo HDHAHPHLDJP;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo JENIKNNEJIG;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo JLEPCEDLIMP;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo GPJEAODENMF;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo AMGNDFLAMNA;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo COPNNBMMMPM;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x34EFD20", Offset = "0x34EED20", VA = "0x1834EFD20")]
			static BLAKFEMCCEK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class OLIPGPNKAOG
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo DPFAKEOINEC;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo PGKLGFJEGDE;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo NICHBOACMOF;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo HLNAPLDOCDP;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo MBLGMNBIPBL;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo ELOFBOPFAIC;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo CCHPCFHEIGI;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo PIINMMHEKCP;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo ONBLMGFBKPA;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo COMCBPPNEAH;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo LBDOHPCDCFI;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo HGDFFGFLJDE;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo JKMCPPMJHMM;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo KJKHPPPDOKJ;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x35027B0", Offset = "0x35017B0", VA = "0x1835027B0")]
		public static MethodInfo PBAEFNNDLEC(Type JFEPPDBLNIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3502A40", Offset = "0x3501A40", VA = "0x183502A40")]
		public static MethodInfo PKACOGLGLPC(Type JFEPPDBLNIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3502690", Offset = "0x3501690", VA = "0x183502690")]
		public static MethodInfo LGLKDGIEADI(Type JFEPPDBLNIJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class DABFJKGNGJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<IDGLPAIHJPH, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public DABFJKGNGJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class HELNFOHMHHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public DABFJKGNGJL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public HELNFOHMHHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x35040C0", Offset = "0x35030C0", VA = "0x1835040C0")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3504100", Offset = "0x3503100", VA = "0x183504100")]
		internal bool <BuildType>b__2(int index, IDGLPAIHJPH member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class DEAALPCCFHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public DABFJKGNGJL CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public DEAALPCCFHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x34FBC50", Offset = "0x34FAC50", VA = "0x1834FBC50")]
		internal bool <BuildType>b__3(int index, IDGLPAIHJPH member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class EFAHHCDKIEN
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

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public EFAHHCDKIEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x3500150", Offset = "0x34FF150", VA = "0x183500150")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class CMLCFIMAGCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public CMLCFIMAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x34F2120", Offset = "0x34F1120", VA = "0x1834F2120")]
		internal bool <BuildAnonymousFormatter>b__2(IDGLPAIHJPH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class GFHMAGGJMJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public EFAHHCDKIEN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public GFHMAGGJMJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3502410", Offset = "0x3501410", VA = "0x183502410")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3502490", Offset = "0x3501490", VA = "0x183502490")]
		internal bool <BuildAnonymousFormatter>b__6(int index, IDGLPAIHJPH member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class EAAKJEIBCKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public EFAHHCDKIEN CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public EAAKJEIBCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x34FF210", Offset = "0x34FE210", VA = "0x1834FF210")]
		internal bool <BuildAnonymousFormatter>b__7(int index, IDGLPAIHJPH member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class BDDEGPEAOFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public BDDEGPEAOFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x595CC0", Offset = "0x594CC0", VA = "0x180595CC0")]
		internal Label <BuildSerialize>b__1(IDGLPAIHJPH _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class ALEDGIHFMBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public CAFCEDLHFFP[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, IDGLPAIHJPH, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public CACHJKGBDCI argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public CACHJKGBDCI argResolver;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public ALEDGIHFMBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x34EDCA0", Offset = "0x34ECCA0", VA = "0x1834EDCA0")]
		internal CAFCEDLHFFP <BuildDeserialize>b__0(IDGLPAIHJPH item)
		{
			return default(CAFCEDLHFFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class FKACOENNKPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public ALEDGIHFMBD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public FKACOENNKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3501F10", Offset = "0x3500F10", VA = "0x183501F10")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x35021F0", Offset = "0x35011F0", VA = "0x1835021F0")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class DHGPIHFGMEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public IDGLPAIHJPH item;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public DHGPIHFGMEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x14F8CF0", Offset = "0x14F7CF0", VA = "0x1814F8CF0")]
		internal bool <EmitNewObject>b__0(CAFCEDLHFFP x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class DEKNCNHGKDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public IDGLPAIHJPH item;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public DEKNCNHGKDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x14F8CF0", Offset = "0x14F7CF0", VA = "0x1814F8CF0")]
		internal bool <EmitNewObject>b__2(CAFCEDLHFFP x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex IHBLNIFGJMD;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int MADOLFEDNID;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> BBDEOIMCDCJ;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> JAEKKIGLAMO;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2506360", Offset = "0x2505360", VA = "0x182506360")]
	public static object IPBKKKKCBBP<T>(JLEFHMJOGAN NLDLKKLIBJK, AJMMOEDPFDO NCLEPICFBIK, Func<string, string> JJNNKGCCDJH, bool APLLGDCNGHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x36D7B30", Offset = "0x36D6B30", VA = "0x1836D7B30")]
	public static object MAJDODEDBJB<T>(AJMMOEDPFDO NCLEPICFBIK, Func<string, string> JJNNKGCCDJH, bool APLLGDCNGHL, bool JEFHOIPKOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x34F8C20", Offset = "0x34F7C20", VA = "0x1834F8C20")]
	private static TypeInfo MNHPJCFJOMK(JLEFHMJOGAN NLDLKKLIBJK, Type JFEPPDBLNIJ, Func<string, string> JJNNKGCCDJH, bool APLLGDCNGHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x34F7270", Offset = "0x34F6270", VA = "0x1834F7270")]
	public static object MCNFMMGHECH(Type JFEPPDBLNIJ, Func<string, string> JJNNKGCCDJH, bool APLLGDCNGHL, bool JEFHOIPKOPH, bool NJLKMKLPAMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x34F5590", Offset = "0x34F4590", VA = "0x1834F5590")]
	private static Dictionary<IDGLPAIHJPH, FieldInfo> IFEEOFKJMMI(TypeBuilder BHDGKCLPDGA, KFECHFOOMDL MANJEHEKKCK, ConstructorInfo EBDPCEJLBBJ, FieldBuilder JELBICDDAEM, ILGenerator EMMCBONJINM, bool APLLGDCNGHL, bool CENMIMGJAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x34F9AE0", Offset = "0x34F8AE0", VA = "0x1834F9AE0")]
	private static Dictionary<IDGLPAIHJPH, FieldInfo> OADJCIKLNII(TypeBuilder BHDGKCLPDGA, KFECHFOOMDL MANJEHEKKCK, ILGenerator EMMCBONJINM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x34F5C90", Offset = "0x34F4C90", VA = "0x1834F5C90")]
	private static void JMGMNDJGBFL(Type JFEPPDBLNIJ, KFECHFOOMDL MANJEHEKKCK, ILGenerator EMMCBONJINM, Action LFDMOCFDNMN, Func<int, IDGLPAIHJPH, bool> GKNFIPNGBFN, bool APLLGDCNGHL, bool CENMIMGJAOE, int BLEBEKCJONN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x34F50A0", Offset = "0x34F40A0", VA = "0x1834F50A0")]
	private static void FFJNLHGFIAA(TypeInfo JFEPPDBLNIJ, IDGLPAIHJPH NPCNNFEPNPP, ILGenerator EMMCBONJINM, int GPNCGBOOKKF, Func<int, IDGLPAIHJPH, bool> GKNFIPNGBFN, CACHJKGBDCI LMBCAOJBJPJ, CACHJKGBDCI EFPMIPFCDNC, CACHJKGBDCI OJCLHABFPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x34F2950", Offset = "0x34F1950", VA = "0x1834F2950")]
	private static void BBHKPLJOAIG(Type JFEPPDBLNIJ, KFECHFOOMDL MANJEHEKKCK, ILGenerator EMMCBONJINM, Func<int, IDGLPAIHJPH, bool> GKNFIPNGBFN, bool FMJCNJOMIHP, int BLEBEKCJONN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x34F96C0", Offset = "0x34F86C0", VA = "0x1834F96C0")]
	private static void MNNPJFNFCNL(ILGenerator EMMCBONJINM, CAFCEDLHFFP MANJEHEKKCK, int GPNCGBOOKKF, Func<int, IDGLPAIHJPH, bool> GKNFIPNGBFN, CACHJKGBDCI CLGGJMGJOLI, CACHJKGBDCI OJCLHABFPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x34F3CF0", Offset = "0x34F2CF0", VA = "0x1834F3CF0")]
	private static LocalBuilder CCNPLHKNACH(ILGenerator EMMCBONJINM, Type JFEPPDBLNIJ, KFECHFOOMDL MANJEHEKKCK, CAFCEDLHFFP[] FLKGIEJLILJ, bool HCFGMPAGLOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x34F49D0", Offset = "0x34F39D0", VA = "0x1834F49D0")]
	private static bool DNIFKBNMDNO(ConstructorInfo DKHEAFJMALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x34FA0B0", Offset = "0x34F90B0", VA = "0x1834FA0B0")]
	private static bool PHHFNFBPMBI(Type JFEPPDBLNIJ, out Type ILKKHCJIBKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void BPNLMFHKFIB<T>(byte[][] JELBICDDAEM, object[] NDPLFBIDGAJ, ref KGFCABFEODL LMBCAOJBJPJ, T GGAFBKIEDPG, AJMMOEDPFDO AIAGOPPIPMF);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T GADBHCJIECJ<T>(object[] NDPLFBIDGAJ, ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO AIAGOPPIPMF);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class GOJCMPAEIFN<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class MOAMAJDEOOM : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class INNFOLELDNC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3778F10", Offset = "0x3777F10", VA = "0x183778F10")]
		static INNFOLELDNC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private MOAMAJDEOOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class GAOGGLLPCDP : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class ILICBALPBBN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x41EE310", Offset = "0x41ED310", VA = "0x1841EE310")]
		static ILICBALPBBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private GAOGGLLPCDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class PFKJPMLJFFA
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	internal static readonly AJMMOEDPFDO[] KIJKFJHDLGN;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class PEHJKJLACBO : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class LIBAOCOKALA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3167B60", Offset = "0x3166B60", VA = "0x183167B60")]
		static LIBAOCOKALA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class JJJLBKMHOJO : AJMMOEDPFDO
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class CBDOPGPDNBP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3165100", Offset = "0x3164100", VA = "0x183165100")]
			static CBDOPGPDNBP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly AJMMOEDPFDO AOMOPIPEMFB;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly AJMMOEDPFDO[] JOKNEMHHENO;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		private JJJLBKMHOJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
		public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly global::GBPOCNIAKNN<object> MPHJMPANCEG;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private PEHJKJLACBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class BLPNHJNKNCH : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class IGBDEAOJNAN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x442AFE0", Offset = "0x4429FE0", VA = "0x18442AFE0")]
		static IGBDEAOJNAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class OOJFBIDJMMN : AJMMOEDPFDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class HLDKIIFAKGC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x4429530", Offset = "0x4428530", VA = "0x184429530")]
			static HLDKIIFAKGC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly AJMMOEDPFDO AOMOPIPEMFB;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly AJMMOEDPFDO[] JOKNEMHHENO;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		private OOJFBIDJMMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
		public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::GBPOCNIAKNN<object> MPHJMPANCEG;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private BLPNHJNKNCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class APBJLODEIIE : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class GMDBKGLHCNA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x43A2860", Offset = "0x43A1860", VA = "0x1843A2860")]
		static GMDBKGLHCNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class EPEBMNNCJLD : AJMMOEDPFDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class NHOJGHJHONF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x43A3C70", Offset = "0x43A2C70", VA = "0x1843A3C70")]
			static NHOJGHJHONF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly AJMMOEDPFDO AOMOPIPEMFB;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly AJMMOEDPFDO[] JOKNEMHHENO;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		private EPEBMNNCJLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
		public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly global::GBPOCNIAKNN<object> MPHJMPANCEG;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private APBJLODEIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class IBIJNJMJLIG : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class HMHPDGLNCEG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x218A750", Offset = "0x2189750", VA = "0x18218A750")]
		static HMHPDGLNCEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class IKHLONCDALF : AJMMOEDPFDO
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class EDKKHLBDFNA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x2186D50", Offset = "0x2185D50", VA = "0x182186D50")]
			static EDKKHLBDFNA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly AJMMOEDPFDO AOMOPIPEMFB;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly AJMMOEDPFDO[] JOKNEMHHENO;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		private IKHLONCDALF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
		public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly global::GBPOCNIAKNN<object> MPHJMPANCEG;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private IBIJNJMJLIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class MFEEIEIOCOH : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class CKDDPMKEEGN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x317E6D0", Offset = "0x317D6D0", VA = "0x18317E6D0")]
		static CKDDPMKEEGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class ILKHBKNMHEB : AJMMOEDPFDO
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class PEPKIJPBKNK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3193920", Offset = "0x3192920", VA = "0x183193920")]
			static PEPKIJPBKNK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly AJMMOEDPFDO AOMOPIPEMFB;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly AJMMOEDPFDO[] JOKNEMHHENO;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		private ILKHBKNMHEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
		public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::GBPOCNIAKNN<object> MPHJMPANCEG;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private MFEEIEIOCOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class HAFHPJFJJPI : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class KBFIJCDJMPL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2CF28E0", Offset = "0x2CF18E0", VA = "0x182CF28E0")]
		static KBFIJCDJMPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class LIKFGPJNAEF : AJMMOEDPFDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class EOIKIGCNEIA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x2CE99E0", Offset = "0x2CE89E0", VA = "0x182CE99E0")]
			static EOIKIGCNEIA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly AJMMOEDPFDO AOMOPIPEMFB;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly AJMMOEDPFDO[] JOKNEMHHENO;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		private LIKFGPJNAEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
		public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly global::GBPOCNIAKNN<object> MPHJMPANCEG;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private HAFHPJFJJPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class LGAFPHIELGG : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class AAJKPBAFOFG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x367E4D0", Offset = "0x367D4D0", VA = "0x18367E4D0")]
		static AAJKPBAFOFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class GAHBPNDKJOP : AJMMOEDPFDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class KOEGGABIOPA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x36836E0", Offset = "0x36826E0", VA = "0x1836836E0")]
			static KOEGGABIOPA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly AJMMOEDPFDO AOMOPIPEMFB;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly AJMMOEDPFDO[] JOKNEMHHENO;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		private GAHBPNDKJOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
		public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly global::GBPOCNIAKNN<object> MPHJMPANCEG;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private LGAFPHIELGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class GEDDJPMMDDL : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class NPJCCEOHOGF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3B81B00", Offset = "0x3B80B00", VA = "0x183B81B00")]
		static NPJCCEOHOGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class PPIENNLKAIP : AJMMOEDPFDO
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class FCDGHCDMMKK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3B74450", Offset = "0x3B73450", VA = "0x183B74450")]
			static FCDGHCDMMKK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly AJMMOEDPFDO AOMOPIPEMFB;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly AJMMOEDPFDO[] JOKNEMHHENO;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		private PPIENNLKAIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
		public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly global::GBPOCNIAKNN<object> MPHJMPANCEG;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private GEDDJPMMDDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class OIGNJNNLCPC : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class DAJOPEIICNA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x337E210", Offset = "0x337D210", VA = "0x18337E210")]
		static DAJOPEIICNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class CDGPOMFEKNK : AJMMOEDPFDO
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class PPBOFPNIBJP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3391890", Offset = "0x3390890", VA = "0x183391890")]
			static PPBOFPNIBJP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly AJMMOEDPFDO AOMOPIPEMFB;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly AJMMOEDPFDO[] JOKNEMHHENO;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		private CDGPOMFEKNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
		public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly global::GBPOCNIAKNN<object> MPHJMPANCEG;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private OIGNJNNLCPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class CEBKMELOALB : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class GACPDKDMHIK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3923690", Offset = "0x3922690", VA = "0x183923690")]
		static GACPDKDMHIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class FLKGEKGNGJD : AJMMOEDPFDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class CNKNMAMIKAL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x391DFA0", Offset = "0x391CFA0", VA = "0x18391DFA0")]
			static CNKNMAMIKAL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly AJMMOEDPFDO AOMOPIPEMFB;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly AJMMOEDPFDO[] JOKNEMHHENO;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		private FLKGEKGNGJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
		public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly global::GBPOCNIAKNN<object> MPHJMPANCEG;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private CEBKMELOALB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class ENJPLACFKIA : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class HCFPLNCJDIC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3D3EB40", Offset = "0x3D3DB40", VA = "0x183D3EB40")]
		static HCFPLNCJDIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class CBJGGLKHNNA : AJMMOEDPFDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class KMLOLCAHNNE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3D43D10", Offset = "0x3D42D10", VA = "0x183D43D10")]
			static KMLOLCAHNNE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly AJMMOEDPFDO AOMOPIPEMFB;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly AJMMOEDPFDO[] JOKNEMHHENO;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		private CBJGGLKHNNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
		public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::GBPOCNIAKNN<object> MPHJMPANCEG;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private ENJPLACFKIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class POGHDEKACBE : AJMMOEDPFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class NFMOEGCJOLN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x41CE1E0", Offset = "0x41CD1E0", VA = "0x1841CE1E0")]
		static NFMOEGCJOLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class IIPEGHGEEHJ : AJMMOEDPFDO
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class FNGHAJGJDLC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly global::GBPOCNIAKNN<T> BOEDMFLJAOE;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x41C3420", Offset = "0x41C2420", VA = "0x1841C3420")]
			static FNGHAJGJDLC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly AJMMOEDPFDO AOMOPIPEMFB;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly AJMMOEDPFDO[] JOKNEMHHENO;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		private IIPEGHGEEHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
		public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly AJMMOEDPFDO AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly global::GBPOCNIAKNN<object> MPHJMPANCEG;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	private POGHDEKACBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2103950", Offset = "0x2102950", VA = "0x182103950", Slot = "4")]
	public global::GBPOCNIAKNN<T> OFGGPLEPJAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct FBNMINJCBHE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public T[] IOFIAFEAPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int ECIOENCFCHJ;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x230A8B0", Offset = "0x23098B0", VA = "0x18230A8B0")]
	public FBNMINJCBHE(int BPCKONLJJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x230A5A0", Offset = "0x23095A0", VA = "0x18230A5A0")]
	public void CGEJAMCGIKA(T GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x230A820", Offset = "0x2309820", VA = "0x18230A820")]
	public T[] CJEOFMFDPCA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class NHCAHMNCDED : global::LKAPBCGDKHP<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly NHCAHMNCDED DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5059DA0", Offset = "0x5058DA0", VA = "0x185059DA0")]
	public NHCAHMNCDED(int JGAKBKINOAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class LKAPBCGDKHP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly int JGAKBKINOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly object AKNOGGJHNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int GPNCGBOOKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private T[][] IIFDBBDNFFG;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2C01F30", Offset = "0x2C00F30", VA = "0x182C01F30")]
	public LKAPBCGDKHP(int JGAKBKINOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2BFFE30", Offset = "0x2BFEE30", VA = "0x182BFFE30")]
	public T[] APGIMJPMJEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2C01030", Offset = "0x2C00030", VA = "0x182C01030")]
	public void DMNNBHBPDBJ(T[] FOHKJBHGAHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class KFIMDPANPGO : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class AAKEJKOBHLN : IComparable<AAKEJKOBHLN>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class PGBEBKOCIPJ : IEnumerable<AAKEJKOBHLN>, IEnumerable, IEnumerator<AAKEJKOBHLN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private AAKEJKOBHLN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public AAKEJKOBHLN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private AAKEJKOBHLN System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x69E3E0", Offset = "0x69D3E0", VA = "0x18069E3E0")]
			[DebuggerHidden]
			public PGBEBKOCIPJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x2FA9190", Offset = "0x2FA8190", VA = "0x182FA9190", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2FA92C0", Offset = "0x2FA82C0", VA = "0x182FA92C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2FA9220", Offset = "0x2FA8220", VA = "0x182FA9220", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<AAKEJKOBHLN> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2FA9220", Offset = "0x2FA8220", VA = "0x182FA9220", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class AMOHOGPNMLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
			public AMOHOGPNMLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x595CC0", Offset = "0x594CC0", VA = "0x180595CC0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x595CC0", Offset = "0x594CC0", VA = "0x180595CC0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly AAKEJKOBHLN[] OEDJGNJMMAM;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly ulong[] NGIPAMGEEPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ulong GDIPAGHFDEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int PDFBALCEGGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string IMMHIEDMCCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private AAKEJKOBHLN[] KLBGCPGIMCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ulong[] JGGBEFDPLEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int GLCMJLMDOEH;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool HBIIAEDLKGD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xBFB8E0", Offset = "0xBFA8E0", VA = "0x180BFB8E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2F91430", Offset = "0x2F90430", VA = "0x182F91430")]
		public AAKEJKOBHLN(ulong GLMMMFPEBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x2F90DC0", Offset = "0x2F8FDC0", VA = "0x182F90DC0")]
		public AAKEJKOBHLN CGEJAMCGIKA(ulong GLMMMFPEBHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2F90D70", Offset = "0x2F8FD70", VA = "0x182F90D70")]
		public AAKEJKOBHLN CGEJAMCGIKA(ulong GLMMMFPEBHE, int GGAFBKIEDPG, string IMMHIEDMCCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2F91110", Offset = "0x2F90110", VA = "0x182F91110")]
		public AAKEJKOBHLN ECELPMEOJFH(byte[] FLFKMIKGJFJ, ref int GPILAGKEABD, ref int OLGDKMIPOHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2F91330", Offset = "0x2F90330", VA = "0x182F91330")]
		internal static int KHBCPJELMEO(ulong[] FOHKJBHGAHL, int GPNCGBOOKKF, int ALCOEEKHPPJ, ulong GGAFBKIEDPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x2F910E0", Offset = "0x2F900E0", VA = "0x182F910E0", Slot = "4")]
		public int CompareTo(AAKEJKOBHLN GOAJJPLEOBJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2F912C0", Offset = "0x2F902C0", VA = "0x182F912C0")]
		[IteratorStateMachine(typeof(PGBEBKOCIPJ))]
		public IEnumerable<AAKEJKOBHLN> HLAKAAIJCAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2F90FB0", Offset = "0x2F8FFB0", VA = "0x182F90FB0")]
		public void CPDHHBABBGM(ILGenerator EMMCBONJINM, LocalBuilder FLFKMIKGJFJ, LocalBuilder OLGDKMIPOHI, LocalBuilder GLMMMFPEBHE, Action<KeyValuePair<string, int>> OLONIGEJLFF, Action KCHNKDKBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x2F90190", Offset = "0x2F8F190", VA = "0x182F90190")]
		private static void CBDBAOLJIIF(ILGenerator EMMCBONJINM, LocalBuilder FLFKMIKGJFJ, LocalBuilder OLGDKMIPOHI, LocalBuilder GLMMMFPEBHE, Action<KeyValuePair<string, int>> OLONIGEJLFF, Action KCHNKDKBIHC, AAKEJKOBHLN[] KLBGCPGIMCI, int GLCMJLMDOEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class LPOHIMOBFFP : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private IEnumerable<AAKEJKOBHLN> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IEnumerable<AAKEJKOBHLN> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEnumerator<AAKEJKOBHLN> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private AAKEJKOBHLN <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x58E000", Offset = "0x58D000", VA = "0x18058E000", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2FA8FA0", Offset = "0x2FA7FA0", VA = "0x182FA8FA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x9B64D0", Offset = "0x9B54D0", VA = "0x1809B64D0")]
		[DebuggerHidden]
		public LPOHIMOBFFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2FA8FF0", Offset = "0x2FA7FF0", VA = "0x182FA8FF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2FA8B30", Offset = "0x2FA7B30", VA = "0x182FA8B30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2FA90F0", Offset = "0x2FA80F0", VA = "0x182FA90F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2FA9140", Offset = "0x2FA8140", VA = "0x182FA9140")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2FA8F50", Offset = "0x2FA7F50", VA = "0x182FA8F50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2FA8EB0", Offset = "0x2FA7EB0", VA = "0x182FA8EB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2FA8EB0", Offset = "0x2FA7EB0", VA = "0x182FA8EB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly AAKEJKOBHLN BHOMFIKIJGC;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7520", Offset = "0x2FA6520", VA = "0x182FA7520")]
	public KFIMDPANPGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2FA6EB0", Offset = "0x2FA5EB0", VA = "0x182FA6EB0")]
	public void CGEJAMCGIKA(byte[] LNCIHJHIBKD, int GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7380", Offset = "0x2FA6380", VA = "0x182FA7380")]
	public bool HGMJIPOBLKE(ArraySegment<byte> GLMMMFPEBHE, out int GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7430", Offset = "0x2FA6430", VA = "0x182FA7430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7000", Offset = "0x2FA6000", VA = "0x182FA7000")]
	private static void FOFNFLMIFBJ(IEnumerable<AAKEJKOBHLN> KLBGCPGIMCI, StringBuilder NOOCKADCOFA, int HJCLNPMNHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7280", Offset = "0x2FA6280", VA = "0x182FA7280", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7280", Offset = "0x2FA6280", VA = "0x182FA7280", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2FA6E40", Offset = "0x2FA5E40", VA = "0x182FA6E40")]
	[IteratorStateMachine(typeof(LPOHIMOBFFP))]
	private static IEnumerable<KeyValuePair<string, int>> APNPLOGLCOD(IEnumerable<AAKEJKOBHLN> KLBGCPGIMCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2FA6FD0", Offset = "0x2FA5FD0", VA = "0x182FA6FD0")]
	public void ENGDEPIJLKG(ILGenerator EMMCBONJINM, LocalBuilder FLFKMIKGJFJ, LocalBuilder OLGDKMIPOHI, LocalBuilder GLMMMFPEBHE, Action<KeyValuePair<string, int>> OLONIGEJLFF, Action KCHNKDKBIHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class BCJKFPPGCNF
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly MethodInfo GHHAAGPNOCO;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x34EE320", Offset = "0x34ED320", VA = "0x1834EE320")]
	public static ulong AJNOJNCOKIP(byte[] LNCIHJHIBKD, ref int GPILAGKEABD, ref int OLGDKMIPOHI)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class JBFGGKHEHED
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2FA1E70", Offset = "0x2FA0E70", VA = "0x182FA1E70")]
	public static void JNJBENCJMKC(ref byte[] LNCIHJHIBKD, int GPILAGKEABD, int APEKKONBOHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2FA1F90", Offset = "0x2FA0F90", VA = "0x182FA1F90")]
	public static void LHPIPPGGCFL(ref byte[] FOHKJBHGAHL, int HPDMAEHINLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2080", Offset = "0x2FA1080", VA = "0x182FA2080")]
	public static byte[] MPAGPFFKHKJ(byte[] CHGLPKMJFPG, int HPDMAEHINLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class HEBGGDNJJIP
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2F9EF80", Offset = "0x2F9DF80", VA = "0x182F9EF80")]
	public static bool KOOAEOKKCJO(byte[] NGFBLOOELHK, int EKKPGIHLPGJ, int MAOOKBONKAB, byte[] KDAMMJHOBPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class ILKLPNHMDNG<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct EKJMGICEJEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public byte[] GDIPAGHFDEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T PDFBALCEGGK;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x300B090", Offset = "0x300A090", VA = "0x18300B090", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class KALGPDAAAAE : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public global::ILKLPNHMDNG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private EKJMGICEJEJ[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private EKJMGICEJEJ[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x10D4210", Offset = "0x10D3210", VA = "0x1810D4210", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x3014A60", Offset = "0x3013A60", VA = "0x183014A60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1D20DD0", Offset = "0x1D1FDD0", VA = "0x181D20DD0")]
		[DebuggerHidden]
		public KALGPDAAAAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3013A30", Offset = "0x3012A30", VA = "0x183013A30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x30146A0", Offset = "0x30136A0", VA = "0x1830146A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly EKJMGICEJEJ[][] EKCDJMDPNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ulong PNBNNJEGCFJ;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x3012380", Offset = "0x3011380", VA = "0x183012380")]
	public ILKLPNHMDNG(int PGIGOJJPHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x30122C0", Offset = "0x30112C0", VA = "0x1830122C0")]
	public ILKLPNHMDNG(int PGIGOJJPHFM, float IDGFILAFFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x300F430", Offset = "0x300E430", VA = "0x18300F430")]
	public void CGEJAMCGIKA(byte[] GLMMMFPEBHE, T GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3010EC0", Offset = "0x300FEC0", VA = "0x183010EC0")]
	private bool KKNFIFJKFBM(byte[] GLMMMFPEBHE, T GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3011560", Offset = "0x3010560", VA = "0x183011560")]
	public bool NHHHDIDPJMI(ArraySegment<byte> GLMMMFPEBHE, out T GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x300F8F0", Offset = "0x300E8F0", VA = "0x18300F8F0")]
	private static ulong CLIPLCJBDMJ(byte[] BIBNBCIJJEK, int GPILAGKEABD, int GLCMJLMDOEH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D7C0", Offset = "0x2D0C7C0", VA = "0x182D0D7C0")]
	private static int AALLGFEMNFN(int APKCBNLCIDJ, float IDGFILAFFLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x300F950", Offset = "0x300E950", VA = "0x18300F950", Slot = "4")]
	[IteratorStateMachine(typeof(global::ILKLPNHMDNG<>.KALGPDAAAAE))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x1D17110", Offset = "0x1D16110", VA = "0x181D17110", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class IFEFAFDPAON : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OpCode[] JKBEFCFOADG;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly OpCode[] MOLKKINEIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int GPIELBCJPNE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool OEOKOEOFMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2FA1520", Offset = "0x2FA0520", VA = "0x182FA1520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x2FA1680", Offset = "0x2FA0680", VA = "0x182FA1680")]
	static IFEFAFDPAON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x2FA18D0", Offset = "0x2FA08D0", VA = "0x182FA18D0")]
	public IFEFAFDPAON(byte[] FJKOFFELAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2FA1570", Offset = "0x2FA0570", VA = "0x182FA1570")]
	public OpCode LMLOAEIHKBK()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct OPLGENILPGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly Guid PDFBALCEGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte IDOHPBAGOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte JAGMADMLJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte KGEAMHONNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte MGIIEPGJJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte HPPOEAMIDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte FJEDDAGMHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte DEABIIEFNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte KADMKPAEPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte PIACEAEEIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte IEDOMIMMIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte AIHCABNALBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte HBJFHNCOOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte JJIPGJNOLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte NMFFDMAGDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte PIONOBKMOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte NMOBLKGEFDA;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static byte[] FPFDGCGLJMN;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static byte[] NPOOIPIKLBD;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x505D2E0", Offset = "0x505C2E0", VA = "0x18505D2E0")]
	public OPLGENILPGN(ref Guid GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x505D2F0", Offset = "0x505C2F0", VA = "0x18505D2F0")]
	public OPLGENILPGN(ref ArraySegment<byte> DJHMLOLPMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x505D060", Offset = "0x505C060", VA = "0x18505D060")]
	private static byte ENPOLMFNJFI(byte[] LNCIHJHIBKD, int BOKCEJGPNMP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x505D120", Offset = "0x505C120", VA = "0x18505D120")]
	private static byte LILDGDOECPG(byte BMEGDOGJIKK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x505BD20", Offset = "0x505AD20", VA = "0x18505BD20")]
	public void ECHDCGMHCOL(byte[] NMENBHGBOOL, int GPILAGKEABD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class GJHMGFFBEOM
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2F9B280", Offset = "0x2F9A280", VA = "0x182F9B280")]
	public static bool JMNJJJKIIFH(byte HEMCNHOJBJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2F9B290", Offset = "0x2F9A290", VA = "0x182F9B290")]
	public static bool KFIOOFHMEML(byte HEMCNHOJBJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x2F9AF50", Offset = "0x2F99F50", VA = "0x182F9AF50")]
	public static sbyte GOJABGJJLKK(byte[] LNCIHJHIBKD, int GPILAGKEABD, out int IKEDJOLJIIP)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x2F9AEE0", Offset = "0x2F99EE0", VA = "0x182F9AEE0")]
	public static short DHBJJOFHCEI(byte[] LNCIHJHIBKD, int GPILAGKEABD, out int IKEDJOLJIIP)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2F9AFC0", Offset = "0x2F99FC0", VA = "0x182F9AFC0")]
	public static int JKLAKMIJBJJ(byte[] LNCIHJHIBKD, int GPILAGKEABD, out int IKEDJOLJIIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x2F9B410", Offset = "0x2F9A410", VA = "0x182F9B410")]
	public static long LHBDDBOINMM(byte[] LNCIHJHIBKD, int GPILAGKEABD, out int IKEDJOLJIIP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x2F9AE70", Offset = "0x2F99E70", VA = "0x182F9AE70")]
	public static byte CBJILPGBGNE(byte[] LNCIHJHIBKD, int GPILAGKEABD, out int IKEDJOLJIIP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x2F9B5B0", Offset = "0x2F9A5B0", VA = "0x182F9B5B0")]
	public static ushort ODABAKJPHNF(byte[] LNCIHJHIBKD, int GPILAGKEABD, out int IKEDJOLJIIP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2F9ADF0", Offset = "0x2F99DF0", VA = "0x182F9ADF0")]
	public static uint CALKOKLBNAL(byte[] LNCIHJHIBKD, int GPILAGKEABD, out int IKEDJOLJIIP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x2F9B300", Offset = "0x2F9A300", VA = "0x182F9B300")]
	public static ulong LCMMOMAEFPB(byte[] LNCIHJHIBKD, int GPILAGKEABD, out int IKEDJOLJIIP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x2F9B4C0", Offset = "0x2F9A4C0", VA = "0x182F9B4C0")]
	public static float LODJJBMFKGC(byte[] LNCIHJHIBKD, int GPILAGKEABD, out int IKEDJOLJIIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x2F9AD00", Offset = "0x2F99D00", VA = "0x182F9AD00")]
	public static double AIBIHJFDNJM(byte[] LNCIHJHIBKD, int GPILAGKEABD, out int IKEDJOLJIIP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2F9C260", Offset = "0x2F9B260", VA = "0x182F9C260")]
	public static int PMCJLCLDLHI(ref byte[] NMENBHGBOOL, int GPILAGKEABD, ulong GGAFBKIEDPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2F9B620", Offset = "0x2F9A620", VA = "0x182F9B620")]
	public static int OMMPDKIBCDK(ref byte[] NMENBHGBOOL, int GPILAGKEABD, long GGAFBKIEDPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2F9B030", Offset = "0x2F9A030", VA = "0x182F9B030")]
	public static bool JMJLPLIOJGL(byte[] LNCIHJHIBKD, int GPILAGKEABD, out int IKEDJOLJIIP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class EOAHPJJIKDE
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class BPEMMKNIDEC : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private PropertyInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private IEnumerator<PropertyInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		PropertyInfo IEnumerator<PropertyInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x69E3E0", Offset = "0x69D3E0", VA = "0x18069E3E0")]
		[DebuggerHidden]
		public BPEMMKNIDEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2F93110", Offset = "0x2F92110", VA = "0x182F93110", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2F92CB0", Offset = "0x2F91CB0", VA = "0x182F92CB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2F93230", Offset = "0x2F92230", VA = "0x182F93230")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2F93280", Offset = "0x2F92280", VA = "0x182F93280")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2F930C0", Offset = "0x2F920C0", VA = "0x182F930C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x2F93010", Offset = "0x2F92010", VA = "0x182F93010", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2F93010", Offset = "0x2F92010", VA = "0x182F93010", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class HPMHCAEEIJD : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private FieldInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private IEnumerator<FieldInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		FieldInfo IEnumerator<FieldInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x69E3E0", Offset = "0x69D3E0", VA = "0x18069E3E0")]
		[DebuggerHidden]
		public HPMHCAEEIJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0740", Offset = "0x2F9F740", VA = "0x182FA0740", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2FA02E0", Offset = "0x2F9F2E0", VA = "0x182FA02E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0860", Offset = "0x2F9F860", VA = "0x182FA0860")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2FA08B0", Offset = "0x2F9F8B0", VA = "0x182FA08B0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x2FA06F0", Offset = "0x2F9F6F0", VA = "0x182FA06F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0640", Offset = "0x2F9F640", VA = "0x182FA0640", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0640", Offset = "0x2F9F640", VA = "0x182FA0640", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2F93890", Offset = "0x2F92890", VA = "0x182F93890")]
	public static bool EJGMPANCLIA(this TypeInfo JFEPPDBLNIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2F93790", Offset = "0x2F92790", VA = "0x182F93790")]
	public static bool AMLPLHHBOPJ(this TypeInfo JFEPPDBLNIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2F93AC0", Offset = "0x2F92AC0", VA = "0x182F93AC0")]
	public static IEnumerable<PropertyInfo> PLKHDDLDEIA(this Type JFEPPDBLNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2F939A0", Offset = "0x2F929A0", VA = "0x182F939A0")]
	[IteratorStateMachine(typeof(BPEMMKNIDEC))]
	private static IEnumerable<PropertyInfo> HGMKKMLNIFE(Type JFEPPDBLNIJ, HashSet<string> INFPEKMEEHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2F93940", Offset = "0x2F92940", VA = "0x182F93940")]
	public static IEnumerable<FieldInfo> GHIELICIEPA(this Type JFEPPDBLNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2F93A30", Offset = "0x2F92A30", VA = "0x182F93A30")]
	[IteratorStateMachine(typeof(HPMHCAEEIJD))]
	private static IEnumerable<FieldInfo> IEEABJEILCH(Type JFEPPDBLNIJ, HashSet<string> INFPEKMEEHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class KCJMHJKGJDN
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public static readonly Encoding CCIIMBGPPBJ;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class GADAMONBACM
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x642F60", Offset = "0x641F60", VA = "0x180642F60")]
	public static string PLFILDOEAFB(string BEAIDOMOPNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2F96580", Offset = "0x2F95580", VA = "0x182F96580")]
	public static string MGCLGKJIFOB(string BEAIDOMOPNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2F963B0", Offset = "0x2F953B0", VA = "0x182F963B0")]
	public static string ELOGPCBHJDB(string BEAIDOMOPNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class NHBMDHKNINC<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class MCKKNJEBCEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Type GDIPAGHFDEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public TValue PDFBALCEGGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int LFFGENFAPMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public MCKKNJEBCEP KICFPNAHFOE;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B220", Offset = "0x2D0A220", VA = "0x182D0B220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x2D0AF80", Offset = "0x2D09F80", VA = "0x182D0AF80")]
		private int MMNJCBPCOIK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
		public MCKKNJEBCEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class CKKMOOAJAPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
		public CKKMOOAJAPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x89E740", Offset = "0x89D740", VA = "0x18089E740")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private MCKKNJEBCEP[] EKCDJMDPNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int GGOGIDMAHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly object PLJOOPICKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly float IDGFILAFFLJ;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EC10", Offset = "0x2D0DC10", VA = "0x182D0EC10")]
	public NHBMDHKNINC(int PGIGOJJPHFM = 4, float IDGFILAFFLJ = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D9C0", Offset = "0x2D0C9C0", VA = "0x182D0D9C0")]
	public bool DDECLGPGGGI(Type GLMMMFPEBHE, TValue GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D940", Offset = "0x2D0C940", VA = "0x182D0D940")]
	public bool DDECLGPGGGI(Type GLMMMFPEBHE, Func<Type, TValue> JKLIDEMGJCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E340", Offset = "0x2D0D340", VA = "0x182D0E340")]
	private bool KKNFIFJKFBM(Type GLMMMFPEBHE, Func<Type, TValue> JKLIDEMGJCI, out TValue AABJEGOLEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x2D0DBE0", Offset = "0x2D0CBE0", VA = "0x182D0DBE0")]
	private bool EMDIPLPHDOL(MCKKNJEBCEP[] EKCDJMDPNCH, Type AMJJHEAOBCH, MCKKNJEBCEP GHFECOFBDOM, Func<Type, TValue> JKLIDEMGJCI, out TValue AABJEGOLEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EA90", Offset = "0x2D0DA90", VA = "0x182D0EA90")]
	public bool NHHHDIDPJMI(Type GLMMMFPEBHE, out TValue GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D7F0", Offset = "0x2D0C7F0", VA = "0x182D0D7F0")]
	public TValue CJECKDEEDCO(Type GLMMMFPEBHE, Func<Type, TValue> JKLIDEMGJCI)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D7C0", Offset = "0x2D0C7C0", VA = "0x182D0D7C0")]
	private static int AALLGFEMNFN(int APKCBNLCIDJ, float IDGFILAFFLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EBE0", Offset = "0x2D0DBE0", VA = "0x182D0EBE0")]
	private static void OPKEJOCBCIL(ref MCKKNJEBCEP FEGAMDLKAJG, MCKKNJEBCEP GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EBE0", Offset = "0x2D0DBE0", VA = "0x182D0EBE0")]
	private static void OPKEJOCBCIL(ref MCKKNJEBCEP[] FEGAMDLKAJG, MCKKNJEBCEP[] GGAFBKIEDPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class JLEFHMJOGAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly AssemblyBuilder BPAKPINPBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ModuleBuilder BBOHDMICBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly object AKNOGGJHNIH;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2FA29E0", Offset = "0x2FA19E0", VA = "0x182FA29E0")]
	public TypeBuilder LPPCGCGBDOD(string IPJBPCNNBIO, TypeAttributes AIPNOPOILGE, Type NKNFLMKNNCC, Type[] NDELCECGLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2AD0", Offset = "0x2FA1AD0", VA = "0x182FA2AD0")]
	public JLEFHMJOGAN(string LDILGIJEFIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class PICIAAHMFMK
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5060770", Offset = "0x505F770", VA = "0x185060770")]
	private static MethodInfo OIEOOFGOAAJ(LambdaExpression ICBAGFJMNCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x36E1290", Offset = "0x36E0290", VA = "0x1836E1290")]
	public static MethodInfo KFDOAAKGCIK<T>(Expression<Func<T>> ICBAGFJMNCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x36E1290", Offset = "0x36E0290", VA = "0x1836E1290")]
	public static MethodInfo KFDOAAKGCIK<T, TR>(Expression<Func<T, TR>> ICBAGFJMNCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x36E1290", Offset = "0x36E0290", VA = "0x1836E1290")]
	public static MethodInfo KFDOAAKGCIK<T>(Expression<Action<T>> ICBAGFJMNCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x36E1290", Offset = "0x36E0290", VA = "0x1836E1290")]
	public static MethodInfo KFDOAAKGCIK<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> ICBAGFJMNCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x36E1300", Offset = "0x36E0300", VA = "0x1836E1300")]
	private static MemberInfo MLKCJAFCGEG<T>(Expression<T> GLLFOKJFDGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x36E12A0", Offset = "0x36E02A0", VA = "0x1836E12A0")]
	public static PropertyInfo LKKDKIBJKIM<T, TR>(Expression<Func<T, TR>> ICBAGFJMNCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct CACHJKGBDCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int FBIMLOLEMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool MAICIKKCMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly ILGenerator EMMCBONJINM;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x34F1390", Offset = "0x34F0390", VA = "0x1834F1390")]
	public CACHJKGBDCI(ILGenerator EMMCBONJINM, int FBIMLOLEMBB, bool MAICIKKCMCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x34F13D0", Offset = "0x34F03D0", VA = "0x1834F13D0")]
	public CACHJKGBDCI(ILGenerator EMMCBONJINM, int FBIMLOLEMBB, Type JFEPPDBLNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x34F1280", Offset = "0x34F0280", VA = "0x1834F1280")]
	public void ELBIIBEEMLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class DDHAKBCOOAL
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x34FBA20", Offset = "0x34FAA20", VA = "0x1834FBA20")]
	public static void PGDOAKPDCCI(this ILGenerator EMMCBONJINM, int GPNCGBOOKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x34FB9E0", Offset = "0x34FA9E0", VA = "0x1834FB9E0")]
	public static void PGDOAKPDCCI(this ILGenerator EMMCBONJINM, LocalBuilder BOFGLGJDECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x34FB220", Offset = "0x34FA220", VA = "0x1834FB220")]
	public static void HEFKLABBJCH(this ILGenerator EMMCBONJINM, int GPNCGBOOKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x34FB1E0", Offset = "0x34FA1E0", VA = "0x1834FB1E0")]
	public static void HEFKLABBJCH(this ILGenerator EMMCBONJINM, LocalBuilder BOFGLGJDECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x34FB670", Offset = "0x34FA670", VA = "0x1834FB670")]
	public static void KAKBMALLCGI(this ILGenerator EMMCBONJINM, int GPNCGBOOKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x34FB760", Offset = "0x34FA760", VA = "0x1834FB760")]
	public static void KAKBMALLCGI(this ILGenerator EMMCBONJINM, LocalBuilder BOFGLGJDECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x34FAA50", Offset = "0x34F9A50", VA = "0x1834FAA50")]
	public static void FGPKMHEDFLE(this ILGenerator EMMCBONJINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x34FA9B0", Offset = "0x34F99B0", VA = "0x1834FA9B0")]
	public static void AIECPKDMHPA(this ILGenerator EMMCBONJINM, bool GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x34FAB60", Offset = "0x34F9B60", VA = "0x1834FAB60")]
	public static void HAAABLGBCHJ(this ILGenerator EMMCBONJINM, int GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x34FB8F0", Offset = "0x34FA8F0", VA = "0x1834FB8F0")]
	public static void LJKIHOEHIAI(this ILGenerator EMMCBONJINM, Type JFEPPDBLNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x34FB450", Offset = "0x34FA450", VA = "0x1834FB450")]
	public static void HEOACMJJIJB(this ILGenerator EMMCBONJINM, Type JFEPPDBLNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x34FAFB0", Offset = "0x34F9FB0", VA = "0x1834FAFB0")]
	public static void HBLEONJKDPC(this ILGenerator EMMCBONJINM, int GPNCGBOOKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x34FB870", Offset = "0x34FA870", VA = "0x1834FB870")]
	public static void KLDAOFDKPNJ(this ILGenerator EMMCBONJINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x34FB580", Offset = "0x34FA580", VA = "0x1834FB580")]
	public static void IMPMIOJEOEM(this ILGenerator EMMCBONJINM, int GPNCGBOOKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x34FAA60", Offset = "0x34F9A60", VA = "0x1834FAA60")]
	public static void GKCJKCNJNMB(this ILGenerator EMMCBONJINM, MethodInfo JEKKIGJGFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x34FA9C0", Offset = "0x34F99C0", VA = "0x1834FA9C0")]
	public static void EADJCJNCNLJ(this ILGenerator EMMCBONJINM, FieldInfo JJECNCBFCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x34FB4F0", Offset = "0x34FA4F0", VA = "0x1834FB4F0")]
	public static void IMGDFGLNOLJ(this ILGenerator EMMCBONJINM, ulong GGAFBKIEDPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class IDGLPAIHJPH
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class PNNNLDDALKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public PNNNLDDALKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2FA9310", Offset = "0x2FA8310", VA = "0x182FA9310")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MethodInfo OIOIBOMNHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MethodInfo NBIGNLBEHIO;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string ADLJMBIPGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x58D490", Offset = "0x58C490", VA = "0x18058D490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string BADHOMCMAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x58D4A0", Offset = "0x58C4A0", VA = "0x18058D4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool ADHOBKLHNOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0DF0", Offset = "0x2F9FDF0", VA = "0x182FA0DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool FBDDIDDOMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x58D190", Offset = "0x58C190", VA = "0x18058D190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6E7E80", Offset = "0x6E6E80", VA = "0x1806E7E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool LPMOPHLNEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x58D1A0", Offset = "0x58C1A0", VA = "0x18058D1A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7AC200", Offset = "0x7AB200", VA = "0x1807AC200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type IAOAKEPDHMN
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5B60C0", Offset = "0x5B50C0", VA = "0x1805B60C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CC0", Offset = "0x6AFCC0", VA = "0x1806B0CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo GINHJMAFAIC
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x5B5A30", Offset = "0x5B4A30", VA = "0x1805B5A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6C5580", Offset = "0x6C4580", VA = "0x1806C5580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo CBDGOKPJKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x58E010", Offset = "0x58D010", VA = "0x18058E010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x58E020", Offset = "0x58D020", VA = "0x18058E020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo GEHPLNOKFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5A0D70", Offset = "0x59FD70", VA = "0x1805A0D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x627FC0", Offset = "0x626FC0", VA = "0x180627FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2FA10A0", Offset = "0x2FA00A0", VA = "0x182FA10A0")]
	protected IDGLPAIHJPH(Type JFEPPDBLNIJ, string IPJBPCNNBIO, string BKPINLHKDEG, bool HDAPIEJIONP, bool NJIIIIBKNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x2FA1120", Offset = "0x2FA0120", VA = "0x182FA1120")]
	public IDGLPAIHJPH(FieldInfo MANJEHEKKCK, string IPJBPCNNBIO, bool JEFHOIPKOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x2FA1230", Offset = "0x2FA0230", VA = "0x182FA1230")]
	public IDGLPAIHJPH(PropertyInfo MANJEHEKKCK, string IPJBPCNNBIO, bool JEFHOIPKOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x2FA0F80", Offset = "0x2F9FF80", VA = "0x182FA0F80")]
	private static MethodInfo NPOLEJDAHAI(MemberInfo MANJEHEKKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x20AD090", Offset = "0x20AC090", VA = "0x1820AD090")]
	public T GKKBHLDIPMD<T>(bool KIOBOEFNIKP) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x2FA0E00", Offset = "0x2F9FE00", VA = "0x182FA0E00", Slot = "4")]
	public virtual void JBAPOEPFEIO(ILGenerator EMMCBONJINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x2FA0EC0", Offset = "0x2F9FEC0", VA = "0x182FA0EC0", Slot = "5")]
	public virtual void MNAOFKLFBKG(ILGenerator EMMCBONJINM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class DPJJELBGCMP : IDGLPAIHJPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly string ICIKAMOLAOB;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x34FF0B0", Offset = "0x34FE0B0", VA = "0x1834FF0B0")]
	public DPJJELBGCMP(string IPJBPCNNBIO, string ICIKAMOLAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x34FEFA0", Offset = "0x34FDFA0", VA = "0x1834FEFA0", Slot = "4")]
	public override void JBAPOEPFEIO(ILGenerator EMMCBONJINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x34FF060", Offset = "0x34FE060", VA = "0x1834FF060", Slot = "5")]
	public override void MNAOFKLFBKG(ILGenerator EMMCBONJINM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class GJGFGPBADEH : IDGLPAIHJPH
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly MethodInfo FILHFDICKLM;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MethodInfo IAMOIJFKEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	internal CACHJKGBDCI HINLNCOHIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	internal CACHJKGBDCI EFPMIPFCDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	internal CACHJKGBDCI OJCLHABFPME;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x2F9AC50", Offset = "0x2F99C50", VA = "0x182F9AC50")]
	public GJGFGPBADEH(string IPJBPCNNBIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x2F9A6A0", Offset = "0x2F996A0", VA = "0x182F9A6A0", Slot = "4")]
	public override void JBAPOEPFEIO(ILGenerator EMMCBONJINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x2F9A760", Offset = "0x2F99760", VA = "0x182F9A760", Slot = "5")]
	public override void MNAOFKLFBKG(ILGenerator EMMCBONJINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x2F9A590", Offset = "0x2F99590", VA = "0x182F9A590")]
	public void CKLKPGIJEIK(ILGenerator EMMCBONJINM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class KFECHFOOMDL
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type IAOAKEPDHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x58D490", Offset = "0x58C490", VA = "0x18058D490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool FMKGKMALNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6BBC80", Offset = "0x6BAC80", VA = "0x1806BBC80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7619D0", Offset = "0x7609D0", VA = "0x1807619D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool ONFOLEHCFGI
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x750C10", Offset = "0x74FC10", VA = "0x180750C10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xDD22F0", Offset = "0xDD12F0", VA = "0x180DD22F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo LLIJAIJNMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x58FDF0", Offset = "0x58EDF0", VA = "0x18058FDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x5B7D70", Offset = "0x5B6D70", VA = "0x1805B7D70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IDGLPAIHJPH[] IDDCHHIIOPF
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5B60C0", Offset = "0x5B50C0", VA = "0x1805B60C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CC0", Offset = "0x6AFCC0", VA = "0x1806B0CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IDGLPAIHJPH[] NANELHFHIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5B5A30", Offset = "0x5B4A30", VA = "0x1805B5A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6C5580", Offset = "0x6C4580", VA = "0x1806C5580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x2FA5C20", Offset = "0x2FA4C20", VA = "0x182FA5C20")]
	public KFECHFOOMDL(Type JFEPPDBLNIJ, Func<string, string> AODHHAOEIFB, bool JEFHOIPKOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x2FA5B50", Offset = "0x2FA4B50", VA = "0x182FA5B50")]
	private static bool COEHJDBJMCL(IEnumerator<ConstructorInfo> INNCKDBEIMK, ref ConstructorInfo BJHKOPDDOLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct EOPJIAKKDBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ulong CKCPJOBAOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int MMICFFPKPAJ;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x23C28F0", Offset = "0x23C18F0", VA = "0x1823C28F0")]
	public EOPJIAKKDBN(ulong DKBJNDFDDPG, int BDJJFHOJFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x2F93C60", Offset = "0x2F92C60", VA = "0x182F93C60")]
	public void JEBOOFLKMMI(ref EOPJIAKKDBN GOAJJPLEOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x2F93D10", Offset = "0x2F92D10", VA = "0x182F93D10")]
	public static EOPJIAKKDBN OOFGMLKIPEH(ref EOPJIAKKDBN INIPPOEHOLP, ref EOPJIAKKDBN BMEGDOGJIKK)
	{
		return default(EOPJIAKKDBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2F93BD0", Offset = "0x2F92BD0", VA = "0x182F93BD0")]
	public void GOJCHLLBLMG(ref EOPJIAKKDBN GOAJJPLEOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2F93B20", Offset = "0x2F92B20", VA = "0x182F93B20")]
	public static EOPJIAKKDBN BKCJOCPDEND(ref EOPJIAKKDBN INIPPOEHOLP, ref EOPJIAKKDBN BMEGDOGJIKK)
	{
		return default(EOPJIAKKDBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x2F93CD0", Offset = "0x2F92CD0", VA = "0x182F93CD0")]
	public void NKHNIEJBEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2F93C70", Offset = "0x2F92C70", VA = "0x182F93C70")]
	public static EOPJIAKKDBN NKHNIEJBEBH(ref EOPJIAKKDBN INIPPOEHOLP)
	{
		return default(EOPJIAKKDBN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct MLCCFCFBKEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public byte[] NMENBHGBOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int GPILAGKEABD;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x9CE790", Offset = "0x9CD790", VA = "0x1809CE790")]
	public MLCCFCFBKEC(byte[] NMENBHGBOOL, int PFANDEKBLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5058F00", Offset = "0x5057F00", VA = "0x185058F00")]
	public void FHBKIOLIKOE(byte KCCHPAJODNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x5058F60", Offset = "0x5057F60", VA = "0x185058F60")]
	public void HDFBGACKGHL(byte[] KCCHPAJODNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x5058D60", Offset = "0x5057D60", VA = "0x185058D60")]
	public void BLOGDNPKBAG(byte[] KCCHPAJODNN, int ALCOEEKHPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x5058CB0", Offset = "0x5057CB0", VA = "0x185058CB0")]
	public void BLOGDNPKBAG(byte[] KCCHPAJODNN, int DBHBFIKBLHB, int ALCOEEKHPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x5059000", Offset = "0x5058000", VA = "0x185059000")]
	public void IEKIJDONCCK(byte HEMCNHOJBJG, int GLCMJLMDOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x5058E00", Offset = "0x5057E00", VA = "0x185058E00")]
	public void DDOLJBPMMHB(string KCCHPAJODNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class GDMPOCBFNCD
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum LPDKHKPCJAM
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum DFJFMPLFDBP
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum PHGPCJCOEPB
	{
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	[ThreadStatic]
	private static byte[] FAELJDKHGNL;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ThreadStatic]
	private static byte[] MCNKCCBLJON;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly byte[] MLOAHLLIHPD;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly byte[] FHGCPLBJECD;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly PHGPCJCOEPB GHFICPAPIFF;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly char CMCKFGJMEMC;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly int NGJPIKGPLFA;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly int CNEECDNJCHM;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly uint[] BGNGBJFMMGL;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2F97D10", Offset = "0x2F96D10", VA = "0x182F97D10")]
	private static byte[] BJJLJBDPCAE(int GGOGIDMAHAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x2F98AA0", Offset = "0x2F97AA0", VA = "0x182F98AA0")]
	private static byte[] LLMAMKIJNOG(int GGOGIDMAHAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x2F991D0", Offset = "0x2F981D0", VA = "0x182F991D0")]
	public static int PJBKPHJJHFA(ref byte[] NMENBHGBOOL, int GPILAGKEABD, float GGAFBKIEDPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x2F990C0", Offset = "0x2F980C0", VA = "0x182F990C0")]
	public static int PJBKPHJJHFA(ref byte[] NMENBHGBOOL, int GPILAGKEABD, double GGAFBKIEDPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2F98FC0", Offset = "0x2F97FC0", VA = "0x182F98FC0")]
	private static bool PDLEOLEENHH(byte[] NMENBHGBOOL, int ALCOEEKHPPJ, ulong HNICABBMPNC, ulong BLPHGGHMJBL, ulong OLGDKMIPOHI, ulong JPHOBGJBIHJ, ulong GBGACHOCBFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2F981B0", Offset = "0x2F971B0", VA = "0x182F981B0")]
	private static void IGCANPJHFLF(uint DHAFNNLIDME, int EJELMLLEBJB, out uint PHOENDDFEDL, out int EBAJKPKDPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2F97DE0", Offset = "0x2F96DE0", VA = "0x182F97DE0")]
	private static bool GKONJIJAKPM(EOPJIAKKDBN LONCNALPEEC, EOPJIAKKDBN OBDHDNFKOBC, EOPJIAKKDBN HOJEBBKJEPK, byte[] NMENBHGBOOL, out int ALCOEEKHPPJ, out int EMMCCAPGPLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x2F978A0", Offset = "0x2F968A0", VA = "0x182F978A0")]
	private static bool BHFDOKOFOHO(double KJGFEKLHDPF, LPDKHKPCJAM PAMKEOLBJEH, byte[] NMENBHGBOOL, out int ALCOEEKHPPJ, out int PGEJJGNJFBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2F98B80", Offset = "0x2F97B80", VA = "0x182F98B80")]
	private static bool MENBLLODOAB(double KJGFEKLHDPF, LPDKHKPCJAM PAMKEOLBJEH, byte[] NMENBHGBOOL, out int ALCOEEKHPPJ, out int KAHLGGLAIFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2F98E30", Offset = "0x2F97E30", VA = "0x182F98E30")]
	private static bool OCGBGGAJJHN(double GGAFBKIEDPG, ref MLCCFCFBKEC CMHHPBMMBIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2F982D0", Offset = "0x2F972D0", VA = "0x182F982D0")]
	private static bool KDDJLLGFFPI(double GGAFBKIEDPG, ref MLCCFCFBKEC CMHHPBMMBIN, DFJFMPLFDBP PAMKEOLBJEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x2F98C70", Offset = "0x2F97C70", VA = "0x182F98C70")]
	private static void MLILGGMLKPC(byte[] DGKGNCOCPDB, int ALCOEEKHPPJ, int KAHLGGLAIFC, int DOPLBPLBFMP, ref MLCCFCFBKEC CMHHPBMMBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2F975B0", Offset = "0x2F965B0", VA = "0x182F975B0")]
	private static void BCMEICBFOAO(byte[] DGKGNCOCPDB, int ALCOEEKHPPJ, int BDJJFHOJFJK, ref MLCCFCFBKEC CMHHPBMMBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2F98900", Offset = "0x2F97900", VA = "0x182F98900")]
	private static bool LEKHJLLJACM(double KJGFEKLHDPF, DFJFMPLFDBP PAMKEOLBJEH, int INPOKBLCDKL, byte[] PODEMFGJPIM, out bool NGKAGIOKINP, out int ALCOEEKHPPJ, out int DLKGDIEINAF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct KGNLLICKKBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public double LPFPPCBAAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ulong KCHBNCACFNG;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct LODNCLDBBJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public float CKCPJOBAOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public uint ONEHOGDIJAO;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct DKOEJELDIJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ulong MDEICBPKJHA;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x34FC2E0", Offset = "0x34FB2E0", VA = "0x1834FC2E0")]
	public DKOEJELDIJJ(double LPFPPCBAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x34FC2F0", Offset = "0x34FB2F0", VA = "0x1834FC2F0")]
	public DKOEJELDIJJ(EOPJIAKKDBN LPFPPCBAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x34FC1E0", Offset = "0x34FB1E0", VA = "0x1834FC1E0")]
	public EOPJIAKKDBN ONAAGBBNCNG()
	{
		return default(EOPJIAKKDBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x34FBD10", Offset = "0x34FAD10", VA = "0x1834FBD10")]
	public EOPJIAKKDBN AGEEHGHFNLE()
	{
		return default(EOPJIAKKDBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7630E0", Offset = "0x7620E0", VA = "0x1807630E0")]
	public ulong AJFPJLAPJLI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x34FC000", Offset = "0x34FB000", VA = "0x1834FC000")]
	public double GGFIGNHIIIM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x34FC260", Offset = "0x34FB260", VA = "0x1834FC260")]
	public double PGOBLGMGJOC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x34FC120", Offset = "0x34FB120", VA = "0x1834FC120")]
	public int HKOGBMAPBHD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x34FC1B0", Offset = "0x34FB1B0", VA = "0x1834FC1B0")]
	public ulong NBGKOODDDFB()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x34FC150", Offset = "0x34FB150", VA = "0x1834FC150")]
	public bool MACMCFJKGOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x34FC170", Offset = "0x34FB170", VA = "0x1834FC170")]
	public bool MMKDFMCIEEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x34FBF90", Offset = "0x34FAF90", VA = "0x1834FBF90")]
	public bool DIIONGAKAIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x34FBFC0", Offset = "0x34FAFC0", VA = "0x1834FBFC0")]
	public bool EAFAJDAPFFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x34FC190", Offset = "0x34FB190", VA = "0x1834FC190")]
	public int NAFBMMDIALB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x34FBE00", Offset = "0x34FAE00", VA = "0x1834FBE00")]
	public void CBOKIMMGLFD(out EOPJIAKKDBN PFEJEMDBDCM, out EOPJIAKKDBN AJJDDHFIBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x34FBDB0", Offset = "0x34FADB0", VA = "0x1834FBDB0")]
	public bool ANICPFIBCPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x34FBFF0", Offset = "0x34FAFF0", VA = "0x1834FBFF0")]
	public double GGAFBKIEDPG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x34FBCF0", Offset = "0x34FACF0", VA = "0x1834FBCF0")]
	public static int ABNECBLFBMH(int GJMEMCCAACK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x34FC110", Offset = "0x34FB110", VA = "0x1834FC110")]
	public static double HFPOJHCNLLN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x34FC070", Offset = "0x34FB070", VA = "0x1834FC070")]
	public static ulong HABIFINALLD(EOPJIAKKDBN MKPOEIOAJLL)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct AMOAMHBAKEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private uint IDKPPOCCINM;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1EEAA90", Offset = "0x1EE9A90", VA = "0x181EEAA90")]
	public AMOAMHBAKEN(float CKCPJOBAOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x34EDFD0", Offset = "0x34ECFD0", VA = "0x1834EDFD0")]
	public EOPJIAKKDBN ONAAGBBNCNG()
	{
		return default(EOPJIAKKDBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x84C200", Offset = "0x84B200", VA = "0x18084C200")]
	public uint HNOFNCAKINF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x34EDF80", Offset = "0x34ECF80", VA = "0x1834EDF80")]
	public int HKOGBMAPBHD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x34EDFB0", Offset = "0x34ECFB0", VA = "0x1834EDFB0")]
	public uint NBGKOODDDFB()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x34EDFA0", Offset = "0x34ECFA0", VA = "0x1834EDFA0")]
	public bool MACMCFJKGOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x34EDE10", Offset = "0x34ECE10", VA = "0x1834EDE10")]
	public void CBOKIMMGLFD(out EOPJIAKKDBN PFEJEMDBDCM, out EOPJIAKKDBN AJJDDHFIBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x34EDDD0", Offset = "0x34ECDD0", VA = "0x1834EDDD0")]
	public bool ANICPFIBCPL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct GIPEDLPMEHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly ulong DKBJNDFDDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly short LJLLJAEHEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public readonly short PGEJJGNJFBA;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2F9A580", Offset = "0x2F99580", VA = "0x182F9A580")]
	public GIPEDLPMEHP(ulong DKBJNDFDDPG, short LJLLJAEHEKH, short PGEJJGNJFBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class KENCLNHJAHB
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly GIPEDLPMEHP[] IFNKJJEBPFP;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4020", Offset = "0x2FA3020", VA = "0x182FA4020")]
	public static void MJIPHCFPGBO(int HDBOABHKKLO, int CPLIKJOPFNP, out EOPJIAKKDBN PHOENDDFEDL, out int PGEJJGNJFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x2FA3F30", Offset = "0x2FA2F30", VA = "0x182FA3F30")]
	public static void HPCJCBKAPPE(int AFKGGLHELDB, out EOPJIAKKDBN PHOENDDFEDL, out int BCLGDJECBJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct DNFNOHOGODK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly byte[] LNCIHJHIBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly int DBHBFIKBLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly int IOBIFLNMMDH;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x34FEF60", Offset = "0x34FDF60", VA = "0x1834FEF60")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x99A6E0", Offset = "0x9996E0", VA = "0x18099A6E0")]
	public DNFNOHOGODK(byte[] LNCIHJHIBKD, int DBHBFIKBLHB, int ALCOEEKHPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x84C1C0", Offset = "0x84B1C0", VA = "0x18084C1C0")]
	public int ALCOEEKHPPJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x34FEF00", Offset = "0x34FDF00", VA = "0x1834FEF00")]
	public DNFNOHOGODK GABJENFOIFO(int NDDANCLKIGJ, int KCGOFNGJODJ)
	{
		return default(DNFNOHOGODK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class FNLINJABCLG
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] ACKOEPBKCPI;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly double[] OFJBGHFHMEK;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly int DBNCGIPLBIM;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2F94F50", Offset = "0x2F93F50", VA = "0x182F94F50")]
	private static byte[] HNMHGMLGFEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2F94A90", Offset = "0x2F93A90", VA = "0x182F94A90")]
	private static DNFNOHOGODK EMCDCNLNIEN(DNFNOHOGODK NMENBHGBOOL)
	{
		return default(DNFNOHOGODK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2F94CE0", Offset = "0x2F93CE0", VA = "0x182F94CE0")]
	private static DNFNOHOGODK GFMCKKCCPLD(DNFNOHOGODK NMENBHGBOOL)
	{
		return default(DNFNOHOGODK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2F95030", Offset = "0x2F94030", VA = "0x182F95030")]
	private static void IBHPPGACOMO(DNFNOHOGODK NMENBHGBOOL, int BDJJFHOJFJK, byte[] PJONEMPPIDJ, out int PPOCIDBGAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2F950F0", Offset = "0x2F940F0", VA = "0x182F950F0")]
	private static void ILMGOMHKJLM(DNFNOHOGODK NMENBHGBOOL, int BDJJFHOJFJK, byte[] KMGLEKCJMBF, int BGFMBCMCGIF, out DNFNOHOGODK LMHCIJAJDLF, out int DMFEJEHDLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2F94D90", Offset = "0x2F93D90", VA = "0x182F94D90")]
	private static ulong GMMGGMJEEOI(DNFNOHOGODK NMENBHGBOOL, out int MHFGMEBCDHG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2F94E20", Offset = "0x2F93E20", VA = "0x182F94E20")]
	private static void HEEDBEFFECN(DNFNOHOGODK NMENBHGBOOL, out EOPJIAKKDBN CLNIDHLHIFO, out int HMAHMNHMKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2F959A0", Offset = "0x2F949A0", VA = "0x182F959A0")]
	private static bool KJEPFNKJIML(DNFNOHOGODK LMHCIJAJDLF, int BDJJFHOJFJK, out double CLNIDHLHIFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2F94B40", Offset = "0x2F93B40", VA = "0x182F94B40")]
	private static EOPJIAKKDBN GFHPFDPBJDA(int BDJJFHOJFJK)
	{
		return default(EOPJIAKKDBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2F953A0", Offset = "0x2F943A0", VA = "0x182F953A0")]
	private static bool JIJDBBAEGAF(DNFNOHOGODK NMENBHGBOOL, int BDJJFHOJFJK, out double CLNIDHLHIFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2F95D50", Offset = "0x2F94D50", VA = "0x182F95D50")]
	private static bool MKHOOEOOCFF(DNFNOHOGODK LMHCIJAJDLF, int BDJJFHOJFJK, out double EKKKAHFBIPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2F94960", Offset = "0x2F93960", VA = "0x182F94960")]
	public static double? EICIPKKFFMI(DNFNOHOGODK NMENBHGBOOL, int BDJJFHOJFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2F94780", Offset = "0x2F93780", VA = "0x182F94780")]
	public static float? COPJLIEFKNO(DNFNOHOGODK NMENBHGBOOL, int BDJJFHOJFJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct JBMLMFJOHGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private byte[] NMENBHGBOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private int GPILAGKEABD;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte PDFBALCEGGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x2FA2190", Offset = "0x2FA1190", VA = "0x182FA2190")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x9CE790", Offset = "0x9CD790", VA = "0x1809CE790")]
	public JBMLMFJOHGA(byte[] NMENBHGBOOL, int GPILAGKEABD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2230", Offset = "0x2FA1230", VA = "0x182FA2230")]
	public static JBMLMFJOHGA FGGDLKDFOAN(JBMLMFJOHGA CKPEPLIGOCA)
	{
		return default(JBMLMFJOHGA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2240", Offset = "0x2FA1240", VA = "0x182FA2240")]
	public static JBMLMFJOHGA IBMLGIDJCMG(JBMLMFJOHGA CKPEPLIGOCA, int ALCOEEKHPPJ)
	{
		return default(JBMLMFJOHGA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2170", Offset = "0x2FA1170", VA = "0x182FA2170")]
	public static int BDHINGPKEHO(JBMLMFJOHGA KAGKGBBFFFK, JBMLMFJOHGA DIPABAFKBMG)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2320", Offset = "0x2FA1320", VA = "0x182FA2320")]
	public static bool MBGDBMMMDPP(JBMLMFJOHGA KAGKGBBFFFK, JBMLMFJOHGA DIPABAFKBMG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2210", Offset = "0x2FA1210", VA = "0x182FA2210")]
	public static bool FFFMFKKHPCB(JBMLMFJOHGA KAGKGBBFFFK, JBMLMFJOHGA DIPABAFKBMG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2340", Offset = "0x2FA1340", VA = "0x182FA2340")]
	public static bool MBGDBMMMDPP(JBMLMFJOHGA KAGKGBBFFFK, char DIPABAFKBMG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2FA21D0", Offset = "0x2FA11D0", VA = "0x182FA21D0")]
	public static bool FFFMFKKHPCB(JBMLMFJOHGA KAGKGBBFFFK, char DIPABAFKBMG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x2FA21D0", Offset = "0x2FA11D0", VA = "0x182FA21D0")]
	public static bool FFFMFKKHPCB(JBMLMFJOHGA KAGKGBBFFFK, byte DIPABAFKBMG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2FA22A0", Offset = "0x2FA12A0", VA = "0x182FA22A0")]
	public static bool IKHGLLPPMKL(JBMLMFJOHGA KAGKGBBFFFK, char DIPABAFKBMG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2380", Offset = "0x2FA1380", VA = "0x182FA2380")]
	public static bool MBHNHGHKBMG(JBMLMFJOHGA KAGKGBBFFFK, char DIPABAFKBMG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x2FA23C0", Offset = "0x2FA13C0", VA = "0x182FA23C0")]
	public static bool OAPJECOJHBA(JBMLMFJOHGA KAGKGBBFFFK, char DIPABAFKBMG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2FA22E0", Offset = "0x2FA12E0", VA = "0x182FA22E0")]
	public static bool ILKDKGJJOHB(JBMLMFJOHGA KAGKGBBFFFK, char DIPABAFKBMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class GPCIADNNEOP
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] EPOEKPOOHPC;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ThreadStatic]
	private static byte[] ALIJGILMPHK;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly byte[] MLOAHLLIHPD;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly byte[] FHGCPLBJECD;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly byte[] HBKCLKOLICL;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly int OBFMKGKMIKP;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ushort[] EBAHMOFBFNI;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly int LJIIIPOFDLA;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x2F9E620", Offset = "0x2F9D620", VA = "0x182F9E620")]
	private static byte[] NGLJDJIGEIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x2F9D100", Offset = "0x2F9C100", VA = "0x182F9D100")]
	private static byte[] GAAFFEOOIAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2F9E700", Offset = "0x2F9D700", VA = "0x182F9E700")]
	public static double OECKOAKKAJM(byte[] NMENBHGBOOL, int GPILAGKEABD, out int IKEDJOLJIIP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2F9CF10", Offset = "0x2F9BF10", VA = "0x182F9CF10")]
	public static float DHNOKEALEEE(byte[] NMENBHGBOOL, int GPILAGKEABD, out int IKEDJOLJIIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2F9D240", Offset = "0x2F9C240", VA = "0x182F9D240")]
	private static bool HPODBBEKKGC(int BIBNBCIJJEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2F9CFD0", Offset = "0x2F9BFD0", VA = "0x182F9CFD0")]
	private static bool DJGPNCDPBGI(ref JBMLMFJOHGA FHGIIEAEPHB, JBMLMFJOHGA OENKNOGFNFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2F9E500", Offset = "0x2F9D500", VA = "0x182F9E500")]
	private static bool KLJJJLFEDKJ(ref JBMLMFJOHGA FHGIIEAEPHB, JBMLMFJOHGA OENKNOGFNFA, byte[] CCBHCDJPCPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x2F9D1E0", Offset = "0x2F9C1E0", VA = "0x182F9D1E0")]
	private static bool GHHNCMFGACO(ref JBMLMFJOHGA KPANHNDEDOJ, byte[] KCCHPAJODNN, int GPILAGKEABD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0xF18840", Offset = "0xF17840", VA = "0x180F18840")]
	private static double ICOOJOEGCBD(bool NGKAGIOKINP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x2F9D3C0", Offset = "0x2F9C3C0", VA = "0x182F9D3C0")]
	private static double ICAIGNEMCNL(JBMLMFJOHGA HKCJCCGOAEC, int ALCOEEKHPPJ, bool PNDPOGKKFOL, out int DDAEKFHADHM)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class BPFHIDFLCOD<T> : global::GBPOCNIAKNN<T[]>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly global::LKAPBCGDKHP<T> MCNIDLFFBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly BJAAJMHKOAJ NEGKNAOHEHO;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x287B580", Offset = "0x287A580", VA = "0x18287B580")]
	public BPFHIDFLCOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x1D20DD0", Offset = "0x1D1FDD0", VA = "0x181D20DD0")]
	public BPFHIDFLCOD(BJAAJMHKOAJ NEGKNAOHEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x4422B60", Offset = "0x4421B60", VA = "0x184422B60", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, T[] GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x4424B20", Offset = "0x4423B20", VA = "0x184424B20", Slot = "5")]
	public T[] PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class DBKJICMLIGB<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly global::LKAPBCGDKHP<T> MCNIDLFFBGF;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class HIBNHHLLKFK<T> : global::GBPOCNIAKNN<List<T>>, MFPFDMIAIBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly BJAAJMHKOAJ NEGKNAOHEHO;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x287B580", Offset = "0x287A580", VA = "0x18287B580")]
	public HIBNHHLLKFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1D20DD0", Offset = "0x1D1FDD0", VA = "0x181D20DD0")]
	public HIBNHHLLKFK(BJAAJMHKOAJ NEGKNAOHEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x287A3F0", Offset = "0x28793F0", VA = "0x18287A3F0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, List<T> GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x287AE40", Offset = "0x2879E40", VA = "0x18287AE40", Slot = "5")]
	public List<T> PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class EPFJAOOOFBM<TElement, TIntermediate, TEnumerator, TCollection> : global::GBPOCNIAKNN<TCollection>, MFPFDMIAIBB where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2990", Offset = "0x3EB1990", VA = "0x183EB2990", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, TCollection GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3420", Offset = "0x3EB2420", VA = "0x183EB3420", Slot = "5")]
	public TCollection PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator EOLADAPILKI(TCollection GLLFOKJFDGL);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate NPKHJENBLIG();

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void CGEJAMCGIKA(ref TIntermediate CNMMINBJCJI, int GPNCGBOOKKF, TElement GGAFBKIEDPG);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection JHIPCMEIJDH(ref TIntermediate COIJGBLILMC);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
	protected EPFJAOOOFBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class AKFGNPICCGD<TElement, TIntermediate, TCollection> : global::EPFJAOOOFBM<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x23117A0", Offset = "0x23107A0", VA = "0x1823117A0", Slot = "6")]
	protected override IEnumerator<TElement> EOLADAPILKI(TCollection GLLFOKJFDGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x20196A0", Offset = "0x20186A0", VA = "0x1820196A0")]
	protected AKFGNPICCGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class KEMAMEDCFEL<TElement, TCollection> : global::AKFGNPICCGD<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x1007010", Offset = "0x1006010", VA = "0x181007010", Slot = "9")]
	protected sealed override TCollection JHIPCMEIJDH(ref TCollection COIJGBLILMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class BPBHBMIMMKE<TElement, TCollection> : global::KEMAMEDCFEL<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x44192A0", Offset = "0x44182A0", VA = "0x1844192A0", Slot = "7")]
	protected override TCollection NPKHJENBLIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x4419230", Offset = "0x4418230", VA = "0x184419230", Slot = "8")]
	protected override void CGEJAMCGIKA(ref TCollection CNMMINBJCJI, int GPNCGBOOKKF, TElement GGAFBKIEDPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class JGABLDHGMNN<T> : global::EPFJAOOOFBM<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x21937E0", Offset = "0x21927E0", VA = "0x1821937E0", Slot = "8")]
	protected override void CGEJAMCGIKA(ref LinkedList<T> CNMMINBJCJI, int GPNCGBOOKKF, T GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x1007010", Offset = "0x1006010", VA = "0x181007010", Slot = "9")]
	protected override LinkedList<T> JHIPCMEIJDH(ref LinkedList<T> COIJGBLILMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2193870", Offset = "0x2192870", VA = "0x182193870", Slot = "7")]
	protected override LinkedList<T> NPKHJENBLIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x2696530", Offset = "0x2695530", VA = "0x182696530", Slot = "6")]
	protected override LinkedList<T>.Enumerator EOLADAPILKI(LinkedList<T> GLLFOKJFDGL)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class IELNINJOCGB<T> : global::EPFJAOOOFBM<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x21937E0", Offset = "0x21927E0", VA = "0x1821937E0", Slot = "8")]
	protected override void CGEJAMCGIKA(ref Queue<T> CNMMINBJCJI, int GPNCGBOOKKF, T GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2193870", Offset = "0x2192870", VA = "0x182193870", Slot = "7")]
	protected override Queue<T> NPKHJENBLIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2193820", Offset = "0x2192820", VA = "0x182193820", Slot = "6")]
	protected override Queue<T>.Enumerator EOLADAPILKI(Queue<T> GLLFOKJFDGL)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x1007010", Offset = "0x1006010", VA = "0x181007010", Slot = "9")]
	protected override Queue<T> JHIPCMEIJDH(ref Queue<T> COIJGBLILMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class FKCDFNNMNMP<T> : global::EPFJAOOOFBM<T, global::FBNMINJCBHE<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x31D2AD0", Offset = "0x31D1AD0", VA = "0x1831D2AD0", Slot = "8")]
	protected override void CGEJAMCGIKA(ref global::FBNMINJCBHE<T> CNMMINBJCJI, int GPNCGBOOKKF, T GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA770", Offset = "0x3EB9770", VA = "0x183EBA770", Slot = "7")]
	protected override global::FBNMINJCBHE<T> NPKHJENBLIG()
	{
		return default(global::FBNMINJCBHE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2193820", Offset = "0x2192820", VA = "0x182193820", Slot = "6")]
	protected override Stack<T>.Enumerator EOLADAPILKI(Stack<T> GLLFOKJFDGL)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x41E1930", Offset = "0x41E0930", VA = "0x1841E1930", Slot = "9")]
	protected override Stack<T> JHIPCMEIJDH(ref global::FBNMINJCBHE<T> COIJGBLILMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class MGOEOGIMBML<T> : global::EPFJAOOOFBM<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x21937E0", Offset = "0x21927E0", VA = "0x1821937E0", Slot = "8")]
	protected override void CGEJAMCGIKA(ref HashSet<T> CNMMINBJCJI, int GPNCGBOOKKF, T GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x1007010", Offset = "0x1006010", VA = "0x181007010", Slot = "9")]
	protected override HashSet<T> JHIPCMEIJDH(ref HashSet<T> COIJGBLILMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2193870", Offset = "0x2192870", VA = "0x182193870", Slot = "7")]
	protected override HashSet<T> NPKHJENBLIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2193820", Offset = "0x2192820", VA = "0x182193820", Slot = "6")]
	protected override HashSet<T>.Enumerator EOLADAPILKI(HashSet<T> GLLFOKJFDGL)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class ELKPPEEIEAO<T> : global::AKFGNPICCGD<T, global::FBNMINJCBHE<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x31D2AD0", Offset = "0x31D1AD0", VA = "0x1831D2AD0", Slot = "8")]
	protected override void CGEJAMCGIKA(ref global::FBNMINJCBHE<T> CNMMINBJCJI, int GPNCGBOOKKF, T GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x31D2B00", Offset = "0x31D1B00", VA = "0x1831D2B00", Slot = "9")]
	protected override ReadOnlyCollection<T> JHIPCMEIJDH(ref global::FBNMINJCBHE<T> COIJGBLILMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x31D2B90", Offset = "0x31D1B90", VA = "0x1831D2B90", Slot = "7")]
	protected override global::FBNMINJCBHE<T> NPKHJENBLIG()
	{
		return default(global::FBNMINJCBHE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class NICHKECPMPM<T> : global::AKFGNPICCGD<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x21937E0", Offset = "0x21927E0", VA = "0x1821937E0", Slot = "8")]
	protected override void CGEJAMCGIKA(ref List<T> CNMMINBJCJI, int GPNCGBOOKKF, T GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2193870", Offset = "0x2192870", VA = "0x182193870", Slot = "7")]
	protected override List<T> NPKHJENBLIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x1007010", Offset = "0x1006010", VA = "0x181007010", Slot = "9")]
	protected override IList<T> JHIPCMEIJDH(ref List<T> COIJGBLILMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class JLBHPDJCBAO<T> : global::AKFGNPICCGD<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x21937E0", Offset = "0x21927E0", VA = "0x1821937E0", Slot = "8")]
	protected override void CGEJAMCGIKA(ref List<T> CNMMINBJCJI, int GPNCGBOOKKF, T GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2193870", Offset = "0x2192870", VA = "0x182193870", Slot = "7")]
	protected override List<T> NPKHJENBLIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x1007010", Offset = "0x1006010", VA = "0x181007010", Slot = "9")]
	protected override ICollection<T> JHIPCMEIJDH(ref List<T> COIJGBLILMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class FMEAKMANGGO<T> : global::AKFGNPICCGD<T, global::FBNMINJCBHE<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x31D2AD0", Offset = "0x31D1AD0", VA = "0x1831D2AD0", Slot = "8")]
	protected override void CGEJAMCGIKA(ref global::FBNMINJCBHE<T> CNMMINBJCJI, int GPNCGBOOKKF, T GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA770", Offset = "0x3EB9770", VA = "0x183EBA770", Slot = "7")]
	protected override global::FBNMINJCBHE<T> NPKHJENBLIG()
	{
		return default(global::FBNMINJCBHE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x41E8280", Offset = "0x41E7280", VA = "0x1841E8280", Slot = "9")]
	protected override IEnumerable<T> JHIPCMEIJDH(ref global::FBNMINJCBHE<T> COIJGBLILMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class POJCKPKBKOF<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class HJHKMEDNAHO<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class PGMIICAEACE<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class PAIHJEBKNDI : global::GBPOCNIAKNN<IEnumerable>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::GBPOCNIAKNN<IEnumerable> DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x505DB50", Offset = "0x505CB50", VA = "0x18505DB50", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, IEnumerable GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x505DDF0", Offset = "0x505CDF0", VA = "0x18505DDF0", Slot = "5")]
	public IEnumerable PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public PAIHJEBKNDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class KFBOMJMELLL : global::GBPOCNIAKNN<ICollection>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public static readonly global::GBPOCNIAKNN<ICollection> DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2FA5610", Offset = "0x2FA4610", VA = "0x182FA5610", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, ICollection GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2FA5970", Offset = "0x2FA4970", VA = "0x182FA5970", Slot = "5")]
	public ICollection PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public KFBOMJMELLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class AHBKFCMDCOF : global::GBPOCNIAKNN<IList>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::GBPOCNIAKNN<IList> DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x34ED7B0", Offset = "0x34EC7B0", VA = "0x1834ED7B0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, IList GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x34EDA50", Offset = "0x34ECA50", VA = "0x1834EDA50", Slot = "5")]
	public IList PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public AHBKFCMDCOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class FAJBBJEOICN<T> : global::AKFGNPICCGD<T, global::FBNMINJCBHE<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA700", Offset = "0x3EB9700", VA = "0x183EBA700", Slot = "8")]
	protected override void CGEJAMCGIKA(ref global::FBNMINJCBHE<T> CNMMINBJCJI, int GPNCGBOOKKF, T GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA770", Offset = "0x3EB9770", VA = "0x183EBA770", Slot = "7")]
	protected override global::FBNMINJCBHE<T> NPKHJENBLIG()
	{
		return default(global::FBNMINJCBHE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA730", Offset = "0x3EB9730", VA = "0x183EBA730", Slot = "9")]
	protected override IReadOnlyList<T> JHIPCMEIJDH(ref global::FBNMINJCBHE<T> COIJGBLILMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1D17440", Offset = "0x1D16440", VA = "0x181D17440")]
	public FAJBBJEOICN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class MOMMFNINKAI
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x5059340", Offset = "0x5058340", VA = "0x185059340")]
	public static DateTime BODNNPEBCFH(DateTime MJEGLEDOIMI)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class LLJEINFJFIH : global::GBPOCNIAKNN<DateTime>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly global::GBPOCNIAKNN<DateTime> DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x50562B0", Offset = "0x50552B0", VA = "0x1850562B0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, DateTime GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x5056700", Offset = "0x5055700", VA = "0x185056700", Slot = "5")]
	public DateTime PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public LLJEINFJFIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class ELFGJMHKIDO : global::GBPOCNIAKNN<DateTimeOffset>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public static readonly global::GBPOCNIAKNN<DateTimeOffset> DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x35009C0", Offset = "0x34FF9C0", VA = "0x1835009C0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, DateTimeOffset GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3500D90", Offset = "0x34FFD90", VA = "0x183500D90", Slot = "5")]
	public DateTimeOffset PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public ELFGJMHKIDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class HFJDNBIENAD : global::GBPOCNIAKNN<TimeSpan>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::GBPOCNIAKNN<TimeSpan> DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static byte[] JIKKIPFBMIJ;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2F9F010", Offset = "0x2F9E010", VA = "0x182F9F010", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, TimeSpan GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x2F9F4B0", Offset = "0x2F9E4B0", VA = "0x182F9F4B0", Slot = "5")]
	public TimeSpan PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public HFJDNBIENAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class PJNJFEHGMBO<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::GBPOCNIAKNN<TDictionary>, MFPFDMIAIBB where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x2CE69A0", Offset = "0x2CE59A0", VA = "0x182CE69A0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, TDictionary GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7BA0", Offset = "0x2CE6BA0", VA = "0x182CE7BA0", Slot = "5")]
	public TDictionary PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator EOLADAPILKI(TDictionary GLLFOKJFDGL);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate NPKHJENBLIG();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void CGEJAMCGIKA(ref TIntermediate CNMMINBJCJI, int GPNCGBOOKKF, TKey GLMMMFPEBHE, TValue GGAFBKIEDPG);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary JHIPCMEIJDH(ref TIntermediate COIJGBLILMC);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
	protected PJNJFEHGMBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class FHGIAFPIGMP<TKey, TValue, TIntermediate, TDictionary> : global::PJNJFEHGMBO<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x23117A0", Offset = "0x23107A0", VA = "0x1823117A0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> EOLADAPILKI(TDictionary GLLFOKJFDGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class OEIOMNGGJFD<TKey, TValue, TDictionary> : global::FHGIAFPIGMP<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x1007010", Offset = "0x1006010", VA = "0x181007010", Slot = "9")]
	protected override TDictionary JHIPCMEIJDH(ref TDictionary COIJGBLILMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class KLNFNANDJIA<TKey, TValue> : global::PJNJFEHGMBO<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x27EFAA0", Offset = "0x27EEAA0", VA = "0x1827EFAA0", Slot = "8")]
	protected override void CGEJAMCGIKA(ref Dictionary<TKey, TValue> CNMMINBJCJI, int GPNCGBOOKKF, TKey GLMMMFPEBHE, TValue GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x1007010", Offset = "0x1006010", VA = "0x181007010", Slot = "9")]
	protected override Dictionary<TKey, TValue> JHIPCMEIJDH(ref Dictionary<TKey, TValue> COIJGBLILMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2193870", Offset = "0x2192870", VA = "0x182193870", Slot = "7")]
	protected override Dictionary<TKey, TValue> NPKHJENBLIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x27EFB20", Offset = "0x27EEB20", VA = "0x1827EFB20", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator EOLADAPILKI(Dictionary<TKey, TValue> GLLFOKJFDGL)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1D1FFA0", Offset = "0x1D1EFA0", VA = "0x181D1FFA0")]
	public KLNFNANDJIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class PCFMOEHFPCJ<TKey, TValue, TDictionary> : global::OEIOMNGGJFD<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x31747B0", Offset = "0x31737B0", VA = "0x1831747B0", Slot = "8")]
	protected override void CGEJAMCGIKA(ref TDictionary CNMMINBJCJI, int GPNCGBOOKKF, TKey GLMMMFPEBHE, TValue GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x298C8C0", Offset = "0x298B8C0", VA = "0x18298C8C0", Slot = "7")]
	protected override TDictionary NPKHJENBLIG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class OBKMBLCHLAK<TKey, TValue> : global::FHGIAFPIGMP<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x27EFAE0", Offset = "0x27EEAE0", VA = "0x1827EFAE0", Slot = "8")]
	protected override void CGEJAMCGIKA(ref Dictionary<TKey, TValue> CNMMINBJCJI, int GPNCGBOOKKF, TKey GLMMMFPEBHE, TValue GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x2193870", Offset = "0x2192870", VA = "0x182193870", Slot = "7")]
	protected override Dictionary<TKey, TValue> NPKHJENBLIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x1007010", Offset = "0x1006010", VA = "0x181007010", Slot = "9")]
	protected override IDictionary<TKey, TValue> JHIPCMEIJDH(ref Dictionary<TKey, TValue> COIJGBLILMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class BBDPGFNHDIK<TKey, TValue> : global::OEIOMNGGJFD<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x27EFAE0", Offset = "0x27EEAE0", VA = "0x1827EFAE0", Slot = "8")]
	protected override void CGEJAMCGIKA(ref SortedList<TKey, TValue> CNMMINBJCJI, int GPNCGBOOKKF, TKey GLMMMFPEBHE, TValue GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x2193870", Offset = "0x2192870", VA = "0x182193870", Slot = "7")]
	protected override SortedList<TKey, TValue> NPKHJENBLIG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class JODCCOLIIHP<TKey, TValue> : global::PJNJFEHGMBO<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x27EFAE0", Offset = "0x27EEAE0", VA = "0x1827EFAE0", Slot = "8")]
	protected override void CGEJAMCGIKA(ref SortedDictionary<TKey, TValue> CNMMINBJCJI, int GPNCGBOOKKF, TKey GLMMMFPEBHE, TValue GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x1007010", Offset = "0x1006010", VA = "0x181007010", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> JHIPCMEIJDH(ref SortedDictionary<TKey, TValue> COIJGBLILMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2193870", Offset = "0x2192870", VA = "0x182193870", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> NPKHJENBLIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x3B52160", Offset = "0x3B51160", VA = "0x183B52160", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator EOLADAPILKI(SortedDictionary<TKey, TValue> GLLFOKJFDGL)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class FFCJELMEJFN<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class GBFCGBNDLPJ : global::GBPOCNIAKNN<IDictionary>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::GBPOCNIAKNN<IDictionary> DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2F967A0", Offset = "0x2F957A0", VA = "0x182F967A0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, IDictionary GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x2F96C30", Offset = "0x2F95C30", VA = "0x182F96C30", Slot = "5")]
	public IDictionary PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public GBFCGBNDLPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class AAFANPDLLCH : global::GBPOCNIAKNN<object>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void NFOPNPAPDOI(object DJGCCMKHLFP, ref KGFCABFEODL LMBCAOJBJPJ, object GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly global::NHBMDHKNINC<KeyValuePair<object, NFOPNPAPDOI>> LIPCDACPIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly AJMMOEDPFDO[] DGKPKDDJGKD;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x34ED710", Offset = "0x34EC710", VA = "0x1834ED710")]
	public AAFANPDLLCH(params AJMMOEDPFDO[] DGKPKDDJGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x34ECD10", Offset = "0x34EBD10", VA = "0x1834ECD10", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, object GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x34ED680", Offset = "0x34EC680", VA = "0x1834ED680", Slot = "5")]
	public object PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class KBCIMGGNDNA
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2F10", Offset = "0x2FA1F10", VA = "0x182FA2F10")]
	public static object CNGFFHJODLL(Type JFEPPDBLNIJ, out bool OBECPBGPONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2FA36F0", Offset = "0x2FA26F0", VA = "0x182FA36F0")]
	public static object JMAINDGHFMB(Type JFEPPDBLNIJ, out bool OBECPBGPONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class AKPADKPJLLO<T> : global::GBPOCNIAKNN<T>, MFPFDMIAIBB, global::PBDCCPEPJIO<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class FCFCPGIJKKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
		public FCFCPGIJKKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x4516130", Offset = "0x4515130", VA = "0x184516130")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class BEJJNBLIDHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public global::MDJBEFEKPNE<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
		public BEJJNBLIDHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x4514CF0", Offset = "0x4513CF0", VA = "0x184514CF0")]
		internal void <.cctor>b__1(ref KGFCABFEODL writer, T value, AJMMOEDPFDO _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class IFJHFDPCHDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public global::HCHHAEDJHDL<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
		public IFJHFDPCHDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x424B5A0", Offset = "0x424A5A0", VA = "0x18424B5A0")]
		internal T <.cctor>b__2(ref DMMPAKHNCHE reader, AJMMOEDPFDO _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly global::ILKLPNHMDNG<T> KDEGHKLMONA;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly Dictionary<T, string> BMHOMCEAFED;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static readonly global::MDJBEFEKPNE<T> NGIMKOINLOC;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly global::HCHHAEDJHDL<T> NMAEKNJIDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly bool IFNBHEAJKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly global::MDJBEFEKPNE<T> FIFDLCHGLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::HCHHAEDJHDL<T> HBJPNFIPDFE;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x4246A50", Offset = "0x4245A50", VA = "0x184246A50")]
	static AKPADKPJLLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x4249570", Offset = "0x4248570", VA = "0x184249570")]
	public AKPADKPJLLO(bool IFNBHEAJKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x42318B0", Offset = "0x42308B0", VA = "0x1842318B0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, T GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x42355B0", Offset = "0x42345B0", VA = "0x1842355B0", Slot = "5")]
	public T PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x42306D0", Offset = "0x422F6D0", VA = "0x1842306D0", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, T GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x422FD40", Offset = "0x422ED40", VA = "0x18422FD40", Slot = "7")]
	public T MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class GFDMHOGJBKB<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class DBKMFMMKLKH<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class BDKOPKOKNLM<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class PDMMGGKEOLD<T> : global::GBPOCNIAKNN<T?>, MFPFDMIAIBB where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3174A60", Offset = "0x3173A60", VA = "0x183174A60", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, T? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3174BC0", Offset = "0x3173BC0", VA = "0x183174BC0", Slot = "5")]
	public T? PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
	public PDMMGGKEOLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class BLOAOPGCEJN<T> : global::GBPOCNIAKNN<T?>, MFPFDMIAIBB where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::GBPOCNIAKNN<T> OICOKGHJNDF;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2512C30", Offset = "0x2511C30", VA = "0x182512C30")]
	public BLOAOPGCEJN(global::GBPOCNIAKNN<T> OICOKGHJNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x37BE2D0", Offset = "0x37BD2D0", VA = "0x1837BE2D0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, T? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x37BEF20", Offset = "0x37BDF20", VA = "0x1837BEF20", Slot = "5")]
	public T? PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class BKPHIPDFOAH : global::GBPOCNIAKNN<sbyte>, MFPFDMIAIBB, global::PBDCCPEPJIO<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly BKPHIPDFOAH DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x34EFC50", Offset = "0x34EEC50", VA = "0x1834EFC50", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, sbyte GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x34EFC70", Offset = "0x34EEC70", VA = "0x1834EFC70", Slot = "5")]
	public sbyte PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x34EFC10", Offset = "0x34EEC10", VA = "0x1834EFC10", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, sbyte GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x34EFBA0", Offset = "0x34EEBA0", VA = "0x1834EFBA0", Slot = "7")]
	public sbyte MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public BKPHIPDFOAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class BHGBCIENJEE : global::GBPOCNIAKNN<sbyte?>, MFPFDMIAIBB, global::PBDCCPEPJIO<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly BHGBCIENJEE DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x34EFA20", Offset = "0x34EEA20", VA = "0x1834EFA20", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, sbyte? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x34EFA90", Offset = "0x34EEA90", VA = "0x1834EFA90", Slot = "5")]
	public sbyte? PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x34EF9A0", Offset = "0x34EE9A0", VA = "0x1834EF9A0", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, sbyte? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x34EF8F0", Offset = "0x34EE8F0", VA = "0x1834EF8F0", Slot = "7")]
	public sbyte? MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public BHGBCIENJEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class GDAOBCKBFLJ : global::GBPOCNIAKNN<sbyte[]>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly GDAOBCKBFLJ DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x2F97270", Offset = "0x2F96270", VA = "0x182F97270", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, sbyte[] GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x2F97410", Offset = "0x2F96410", VA = "0x182F97410", Slot = "5")]
	public sbyte[] PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public GDAOBCKBFLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class PAGKEMEOJOC : global::GBPOCNIAKNN<short>, MFPFDMIAIBB, global::PBDCCPEPJIO<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly PAGKEMEOJOC DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x505DA50", Offset = "0x505CA50", VA = "0x18505DA50", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, short GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x505DA70", Offset = "0x505CA70", VA = "0x18505DA70", Slot = "5")]
	public short PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x505DA10", Offset = "0x505CA10", VA = "0x18505DA10", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, short GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x505D9A0", Offset = "0x505C9A0", VA = "0x18505D9A0", Slot = "7")]
	public short MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public PAGKEMEOJOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class LNBCFBPONEN : global::GBPOCNIAKNN<short?>, MFPFDMIAIBB, global::PBDCCPEPJIO<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly LNBCFBPONEN DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5057810", Offset = "0x5056810", VA = "0x185057810", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, short? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5057880", Offset = "0x5056880", VA = "0x185057880", Slot = "5")]
	public short? PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5057790", Offset = "0x5056790", VA = "0x185057790", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, short? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x50576F0", Offset = "0x50566F0", VA = "0x1850576F0", Slot = "7")]
	public short? MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public LNBCFBPONEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class GLPOKKIFCCD : global::GBPOCNIAKNN<short[]>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly GLPOKKIFCCD DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x2F9CA30", Offset = "0x2F9BA30", VA = "0x182F9CA30", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, short[] GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x2F9CBD0", Offset = "0x2F9BBD0", VA = "0x182F9CBD0", Slot = "5")]
	public short[] PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public GLPOKKIFCCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class ELFPFOHKJHI : global::GBPOCNIAKNN<int>, MFPFDMIAIBB, global::PBDCCPEPJIO<int>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly ELFPFOHKJHI DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x2F935B0", Offset = "0x2F925B0", VA = "0x182F935B0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, int GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2F935E0", Offset = "0x2F925E0", VA = "0x182F935E0", Slot = "5")]
	public int PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2F934F0", Offset = "0x2F924F0", VA = "0x182F934F0", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, int GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2F93450", Offset = "0x2F92450", VA = "0x182F93450", Slot = "7")]
	public int MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public ELFPFOHKJHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class CMAGODNOENH : global::GBPOCNIAKNN<int?>, MFPFDMIAIBB, global::PBDCCPEPJIO<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly CMAGODNOENH DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x34F1FA0", Offset = "0x34F0FA0", VA = "0x1834F1FA0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, int? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x34F2010", Offset = "0x34F1010", VA = "0x1834F2010", Slot = "5")]
	public int? PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x34F1F20", Offset = "0x34F0F20", VA = "0x1834F1F20", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, int? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x34F1E80", Offset = "0x34F0E80", VA = "0x1834F1E80", Slot = "7")]
	public int? MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public CMAGODNOENH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class LFMJABCEMGP : global::GBPOCNIAKNN<int[]>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly LFMJABCEMGP DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x50553D0", Offset = "0x50543D0", VA = "0x1850553D0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, int[] GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5055490", Offset = "0x5054490", VA = "0x185055490", Slot = "5")]
	public int[] PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public LFMJABCEMGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class OMPPNGPKJOP : global::GBPOCNIAKNN<long>, MFPFDMIAIBB, global::PBDCCPEPJIO<long>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly OMPPNGPKJOP DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x505BC90", Offset = "0x505AC90", VA = "0x18505BC90", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, long GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x505BCB0", Offset = "0x505ACB0", VA = "0x18505BCB0", Slot = "5")]
	public long PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x505BC50", Offset = "0x505AC50", VA = "0x18505BC50", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, long GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x505BBE0", Offset = "0x505ABE0", VA = "0x18505BBE0", Slot = "7")]
	public long MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public OMPPNGPKJOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class PCJKFJHPIJH : global::GBPOCNIAKNN<long?>, MFPFDMIAIBB, global::PBDCCPEPJIO<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly PCJKFJHPIJH DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x505E300", Offset = "0x505D300", VA = "0x18505E300", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, long? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x505E370", Offset = "0x505D370", VA = "0x18505E370", Slot = "5")]
	public long? PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x505E280", Offset = "0x505D280", VA = "0x18505E280", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, long? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x505E1C0", Offset = "0x505D1C0", VA = "0x18505E1C0", Slot = "7")]
	public long? MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public PCJKFJHPIJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class JDLJAOIKHHH : global::GBPOCNIAKNN<long[]>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly JDLJAOIKHHH DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2400", Offset = "0x2FA1400", VA = "0x182FA2400", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, long[] GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2FA25A0", Offset = "0x2FA15A0", VA = "0x182FA25A0", Slot = "5")]
	public long[] PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public JDLJAOIKHHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class JJDJCOOIDDA : global::GBPOCNIAKNN<byte>, MFPFDMIAIBB, global::PBDCCPEPJIO<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly JJDJCOOIDDA DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2930", Offset = "0x2FA1930", VA = "0x182FA2930", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, byte GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2970", Offset = "0x2FA1970", VA = "0x182FA2970", Slot = "5")]
	public byte PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2870", Offset = "0x2FA1870", VA = "0x182FA2870", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, byte GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x2FA27D0", Offset = "0x2FA17D0", VA = "0x182FA27D0", Slot = "7")]
	public byte MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public JJDJCOOIDDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class EELIDHFMNKF : global::GBPOCNIAKNN<byte?>, MFPFDMIAIBB, global::PBDCCPEPJIO<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly EELIDHFMNKF DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x34FFFD0", Offset = "0x34FEFD0", VA = "0x1834FFFD0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, byte? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x3500040", Offset = "0x34FF040", VA = "0x183500040", Slot = "5")]
	public byte? PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x34FFF50", Offset = "0x34FEF50", VA = "0x1834FFF50", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, byte? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x34FFEA0", Offset = "0x34FEEA0", VA = "0x1834FFEA0", Slot = "7")]
	public byte? MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public EELIDHFMNKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class PIAIEGDGEHP : global::GBPOCNIAKNN<ushort>, MFPFDMIAIBB, global::PBDCCPEPJIO<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly PIAIEGDGEHP DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x50606E0", Offset = "0x505F6E0", VA = "0x1850606E0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, ushort GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5060700", Offset = "0x505F700", VA = "0x185060700", Slot = "5")]
	public ushort PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x50606A0", Offset = "0x505F6A0", VA = "0x1850606A0", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, ushort GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x5060630", Offset = "0x505F630", VA = "0x185060630", Slot = "7")]
	public ushort MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public PIAIEGDGEHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class KMFBMJBJJIH : global::GBPOCNIAKNN<ushort?>, MFPFDMIAIBB, global::PBDCCPEPJIO<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly KMFBMJBJJIH DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x5054D90", Offset = "0x5053D90", VA = "0x185054D90", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, ushort? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5054E00", Offset = "0x5053E00", VA = "0x185054E00", Slot = "5")]
	public ushort? PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5054D10", Offset = "0x5053D10", VA = "0x185054D10", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, ushort? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5054C70", Offset = "0x5053C70", VA = "0x185054C70", Slot = "7")]
	public ushort? MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public KMFBMJBJJIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class NFIOBEIJNNJ : global::GBPOCNIAKNN<ushort[]>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly NFIOBEIJNNJ DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x5059AC0", Offset = "0x5058AC0", VA = "0x185059AC0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, ushort[] GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x5059B80", Offset = "0x5058B80", VA = "0x185059B80", Slot = "5")]
	public ushort[] PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public NFIOBEIJNNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class CANBIGGHFHL : global::GBPOCNIAKNN<uint>, MFPFDMIAIBB, global::PBDCCPEPJIO<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly CANBIGGHFHL DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x34F1510", Offset = "0x34F0510", VA = "0x1834F1510", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, uint GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x34F1520", Offset = "0x34F0520", VA = "0x1834F1520", Slot = "5")]
	public uint PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x34F14D0", Offset = "0x34F04D0", VA = "0x1834F14D0", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, uint GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x34F1460", Offset = "0x34F0460", VA = "0x1834F1460", Slot = "7")]
	public uint MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public CANBIGGHFHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class CCDLANBLOPN : global::GBPOCNIAKNN<uint?>, MFPFDMIAIBB, global::PBDCCPEPJIO<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly CCDLANBLOPN DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x34F1700", Offset = "0x34F0700", VA = "0x1834F1700", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, uint? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x34F1770", Offset = "0x34F0770", VA = "0x1834F1770", Slot = "5")]
	public uint? PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x34F1680", Offset = "0x34F0680", VA = "0x1834F1680", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, uint? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x34F15E0", Offset = "0x34F05E0", VA = "0x1834F15E0", Slot = "7")]
	public uint? MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public CCDLANBLOPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class IJPNPLACOPJ : global::GBPOCNIAKNN<uint[]>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly IJPNPLACOPJ DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2FA1950", Offset = "0x2FA0950", VA = "0x182FA1950", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, uint[] GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2FA1AF0", Offset = "0x2FA0AF0", VA = "0x182FA1AF0", Slot = "5")]
	public uint[] PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public IJPNPLACOPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class NJAKKEJFPKL : global::GBPOCNIAKNN<ulong>, MFPFDMIAIBB, global::PBDCCPEPJIO<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly NJAKKEJFPKL DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5059EA0", Offset = "0x5058EA0", VA = "0x185059EA0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, ulong GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5059EC0", Offset = "0x5058EC0", VA = "0x185059EC0", Slot = "5")]
	public ulong PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5059E60", Offset = "0x5058E60", VA = "0x185059E60", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, ulong GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5059DF0", Offset = "0x5058DF0", VA = "0x185059DF0", Slot = "7")]
	public ulong MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public NJAKKEJFPKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class KONAFNADEAM : global::GBPOCNIAKNN<ulong?>, MFPFDMIAIBB, global::PBDCCPEPJIO<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly KONAFNADEAM DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5055010", Offset = "0x5054010", VA = "0x185055010", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, ulong? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x5055080", Offset = "0x5054080", VA = "0x185055080", Slot = "5")]
	public ulong? PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x5054F90", Offset = "0x5053F90", VA = "0x185054F90", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, ulong? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x5054ED0", Offset = "0x5053ED0", VA = "0x185054ED0", Slot = "7")]
	public ulong? MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public KONAFNADEAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class MMJJHHPPPEE : global::GBPOCNIAKNN<ulong[]>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly MMJJHHPPPEE DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x5059080", Offset = "0x5058080", VA = "0x185059080", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, ulong[] GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x5059140", Offset = "0x5058140", VA = "0x185059140", Slot = "5")]
	public ulong[] PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public MMJJHHPPPEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class FKPILNKJEDL : global::GBPOCNIAKNN<float>, MFPFDMIAIBB, global::PBDCCPEPJIO<float>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly FKPILNKJEDL DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2F94700", Offset = "0x2F93700", VA = "0x182F94700", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, float GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x2F94710", Offset = "0x2F93710", VA = "0x182F94710", Slot = "5")]
	public float PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x2F94650", Offset = "0x2F93650", VA = "0x182F94650", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, float GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x2F94520", Offset = "0x2F93520", VA = "0x182F94520", Slot = "7")]
	public float MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public FKPILNKJEDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class EDAIPEEBPAO : global::GBPOCNIAKNN<float?>, MFPFDMIAIBB, global::PBDCCPEPJIO<float?>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly EDAIPEEBPAO DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x34FFD60", Offset = "0x34FED60", VA = "0x1834FFD60", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, float? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x34FFDD0", Offset = "0x34FEDD0", VA = "0x1834FFDD0", Slot = "5")]
	public float? PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x34FFCE0", Offset = "0x34FECE0", VA = "0x1834FFCE0", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, float? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x34FFC40", Offset = "0x34FEC40", VA = "0x1834FFC40", Slot = "7")]
	public float? MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public EDAIPEEBPAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class BFDANDCLEFJ : global::GBPOCNIAKNN<float[]>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly BFDANDCLEFJ DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x34EF630", Offset = "0x34EE630", VA = "0x1834EF630", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, float[] GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x34EF6F0", Offset = "0x34EE6F0", VA = "0x1834EF6F0", Slot = "5")]
	public float[] PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public BFDANDCLEFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class GMGBMKBCEOH : global::GBPOCNIAKNN<double>, MFPFDMIAIBB, global::PBDCCPEPJIO<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly GMGBMKBCEOH DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x2F9CE90", Offset = "0x2F9BE90", VA = "0x182F9CE90", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, double GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x2F9CEA0", Offset = "0x2F9BEA0", VA = "0x182F9CEA0", Slot = "5")]
	public double PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x2F9CDE0", Offset = "0x2F9BDE0", VA = "0x182F9CDE0", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, double GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x2F9CD70", Offset = "0x2F9BD70", VA = "0x182F9CD70", Slot = "7")]
	public double MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public GMGBMKBCEOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class HBIHJLMJAEP : global::GBPOCNIAKNN<double?>, MFPFDMIAIBB, global::PBDCCPEPJIO<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly HBIHJLMJAEP DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x2F9EE20", Offset = "0x2F9DE20", VA = "0x182F9EE20", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, double? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x2F9EE90", Offset = "0x2F9DE90", VA = "0x182F9EE90", Slot = "5")]
	public double? PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x2F9ED20", Offset = "0x2F9DD20", VA = "0x182F9ED20", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, double? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x2F9EC60", Offset = "0x2F9DC60", VA = "0x182F9EC60", Slot = "7")]
	public double? MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public HBIHJLMJAEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class LFCMDGGIIIL : global::GBPOCNIAKNN<double[]>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly LFCMDGGIIIL DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x5055170", Offset = "0x5054170", VA = "0x185055170", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, double[] GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x5055230", Offset = "0x5054230", VA = "0x185055230", Slot = "5")]
	public double[] PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public LFCMDGGIIIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class FHDPICNHFIA : global::GBPOCNIAKNN<bool>, MFPFDMIAIBB, global::PBDCCPEPJIO<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly FHDPICNHFIA DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2F941E0", Offset = "0x2F931E0", VA = "0x182F941E0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, bool GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2F94200", Offset = "0x2F93200", VA = "0x182F94200", Slot = "5")]
	public bool PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2F94130", Offset = "0x2F93130", VA = "0x182F94130", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, bool GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2F940C0", Offset = "0x2F930C0", VA = "0x182F940C0", Slot = "7")]
	public bool MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public FHDPICNHFIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class JMDCLKICLHC : global::GBPOCNIAKNN<bool?>, MFPFDMIAIBB, global::PBDCCPEPJIO<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly JMDCLKICLHC DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2DD0", Offset = "0x2FA1DD0", VA = "0x182FA2DD0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, bool? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2E40", Offset = "0x2FA1E40", VA = "0x182FA2E40", Slot = "5")]
	public bool? PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2CE0", Offset = "0x2FA1CE0", VA = "0x182FA2CE0", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, bool? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2C30", Offset = "0x2FA1C30", VA = "0x182FA2C30", Slot = "7")]
	public bool? MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public JMDCLKICLHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class NFEHIOCJAAE : global::GBPOCNIAKNN<bool[]>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly NFEHIOCJAAE DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x5059850", Offset = "0x5058850", VA = "0x185059850", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, bool[] GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x5059920", Offset = "0x5058920", VA = "0x185059920", Slot = "5")]
	public bool[] PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public NFEHIOCJAAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class GECIGOEFGBK : global::GBPOCNIAKNN<object>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly global::GBPOCNIAKNN<object> DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly Dictionary<Type, int> NFFLPPEJDGD;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2F994E0", Offset = "0x2F984E0", VA = "0x182F994E0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, object GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2F99E90", Offset = "0x2F98E90", VA = "0x182F99E90", Slot = "5")]
	public object PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public GECIGOEFGBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class APLNCICNGBP : global::GBPOCNIAKNN<byte[]>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly global::GBPOCNIAKNN<byte[]> DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x34EE180", Offset = "0x34ED180", VA = "0x1834EE180", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, byte[] GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x34EE210", Offset = "0x34ED210", VA = "0x1834EE210", Slot = "5")]
	public byte[] PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public APLNCICNGBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class LKEOEJMKGIF : global::GBPOCNIAKNN<ArraySegment<byte>>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly global::GBPOCNIAKNN<ArraySegment<byte>> DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x5055BC0", Offset = "0x5054BC0", VA = "0x185055BC0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, ArraySegment<byte> GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x5055C60", Offset = "0x5054C60", VA = "0x185055C60", Slot = "5")]
	public ArraySegment<byte> PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public LKEOEJMKGIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class JHOOLOJMHOO : global::GBPOCNIAKNN<string>, MFPFDMIAIBB, global::PBDCCPEPJIO<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::GBPOCNIAKNN<string> DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2750", Offset = "0x2FA1750", VA = "0x182FA2750", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, string GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2740", Offset = "0x2FA1740", VA = "0x182FA2740", Slot = "5")]
	public string PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2750", Offset = "0x2FA1750", VA = "0x182FA2750", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, string GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2FA2740", Offset = "0x2FA1740", VA = "0x182FA2740", Slot = "7")]
	public string MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public JHOOLOJMHOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class KHFCMCPHLHP : global::GBPOCNIAKNN<string[]>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly KHFCMCPHLHP DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x5054A10", Offset = "0x5053A10", VA = "0x185054A10", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, string[] GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x5054AD0", Offset = "0x5053AD0", VA = "0x185054AD0", Slot = "5")]
	public string[] PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public KHFCMCPHLHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class EHKHEECGGHE : global::GBPOCNIAKNN<char>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly EHKHEECGGHE DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x35007C0", Offset = "0x34FF7C0", VA = "0x1835007C0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, char GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x3500840", Offset = "0x34FF840", VA = "0x183500840", Slot = "5")]
	public char PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public EHKHEECGGHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class PBFPEEKACHN : global::GBPOCNIAKNN<char?>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly PBFPEEKACHN DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x505DFD0", Offset = "0x505CFD0", VA = "0x18505DFD0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, char? GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x505E0A0", Offset = "0x505D0A0", VA = "0x18505E0A0", Slot = "5")]
	public char? PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public PBFPEEKACHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class GCPDFKJNPMG : global::GBPOCNIAKNN<char[]>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly GCPDFKJNPMG DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x2F96E30", Offset = "0x2F95E30", VA = "0x182F96E30", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, char[] GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x2F97070", Offset = "0x2F96070", VA = "0x182F97070", Slot = "5")]
	public char[] PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public GCPDFKJNPMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class FJDEBAOFLEN : global::GBPOCNIAKNN<Guid>, MFPFDMIAIBB, global::PBDCCPEPJIO<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::GBPOCNIAKNN<Guid> DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x2F94300", Offset = "0x2F93300", VA = "0x182F94300", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, Guid GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x2F94270", Offset = "0x2F93270", VA = "0x182F94270", Slot = "5")]
	public Guid PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x2F942D0", Offset = "0x2F932D0", VA = "0x182F942D0", Slot = "6")]
	public void NECCNJIMEGP(ref KGFCABFEODL LMBCAOJBJPJ, Guid GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x2F94270", Offset = "0x2F93270", VA = "0x182F94270", Slot = "7")]
	public Guid MEKOAMNDADB(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public FJDEBAOFLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class FFLGBAJIADC : global::GBPOCNIAKNN<decimal>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::GBPOCNIAKNN<decimal> DDKLLKCKOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly bool LEOPBGJACAI;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xB72C40", Offset = "0xB71C40", VA = "0x180B72C40")]
	public FFLGBAJIADC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0xE5ED90", Offset = "0xE5DD90", VA = "0x180E5ED90")]
	public FFLGBAJIADC(bool LEOPBGJACAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x2F93D40", Offset = "0x2F92D40", VA = "0x182F93D40", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, decimal GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x2F93EB0", Offset = "0x2F92EB0", VA = "0x182F93EB0", Slot = "5")]
	public decimal PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class NPEFODNKBMO : global::GBPOCNIAKNN<Uri>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly global::GBPOCNIAKNN<Uri> DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x5059F30", Offset = "0x5058F30", VA = "0x185059F30", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, Uri GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x5059FE0", Offset = "0x5058FE0", VA = "0x185059FE0", Slot = "5")]
	public Uri PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public NPEFODNKBMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class BFBLCCGAKAB : global::GBPOCNIAKNN<Version>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly global::GBPOCNIAKNN<Version> DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x34EF4A0", Offset = "0x34EE4A0", VA = "0x1834EF4A0", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, Version GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x34EF550", Offset = "0x34EE550", VA = "0x1834EF550", Slot = "5")]
	public Version PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public BFBLCCGAKAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class DCBFFCBIGCE<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class LHDAGMCFCHB : global::GBPOCNIAKNN<StringBuilder>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::GBPOCNIAKNN<StringBuilder> DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x5055770", Offset = "0x5054770", VA = "0x185055770", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, StringBuilder GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x50557C0", Offset = "0x50547C0", VA = "0x1850557C0", Slot = "5")]
	public StringBuilder PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public LHDAGMCFCHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class DDEMLEMDHAI : global::GBPOCNIAKNN<BitArray>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::GBPOCNIAKNN<BitArray> DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x34FA760", Offset = "0x34F9760", VA = "0x1834FA760", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, BitArray GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x34FA7F0", Offset = "0x34F97F0", VA = "0x1834FA7F0", Slot = "5")]
	public BitArray PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public DDEMLEMDHAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class HKBACBMKOIL : global::GBPOCNIAKNN<Type>, MFPFDMIAIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly HKBACBMKOIL DDKLLKCKOJH;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly Regex IHBLNIFGJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool NCLCIPCKPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool MIGBJBGEIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private bool CKMGNNDOLHI;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x2FA01C0", Offset = "0x2F9F1C0", VA = "0x182FA01C0")]
	public HKBACBMKOIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x2FA01E0", Offset = "0x2F9F1E0", VA = "0x182FA01E0")]
	public HKBACBMKOIL(bool NCLCIPCKPCD, bool MIGBJBGEIFB, bool CKMGNNDOLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x2F9FF10", Offset = "0x2F9EF10", VA = "0x182F9FF10", Slot = "4")]
	public void PBAEFNNDLEC(ref KGFCABFEODL LMBCAOJBJPJ, Type GGAFBKIEDPG, AJMMOEDPFDO PGOJJPMAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x2FA0000", Offset = "0x2F9F000", VA = "0x182FA0000", Slot = "5")]
	public Type PKACOGLGLPC(ref DMMPAKHNCHE CLGGJMGJOLI, AJMMOEDPFDO PGOJJPMAOCD)
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
