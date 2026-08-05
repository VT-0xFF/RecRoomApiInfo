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
public class FDMNHHLIJKO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x576690", Offset = "0x575890", VA = "0x180576690")]
	public FDMNHHLIJKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class AHLFOJCHLJF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x576690", Offset = "0x575890", VA = "0x180576690")]
	public AHLFOJCHLJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class HDEFDNCGNFL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x576690", Offset = "0x575890", VA = "0x180576690")]
	public HDEFDNCGNFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class JAFGLJAEPBE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x576690", Offset = "0x575890", VA = "0x180576690")]
	public JAFGLJAEPBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class HMAPACKBJKE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2D794D0", Offset = "0x2D786D0", VA = "0x182D794D0")]
	public static bool AILIMACCMJC(this TypeInfo DEJAEMDNDIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class JMJBPOOGGLL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type JILNHGOGNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1C0", Offset = "0x5CB3C0", VA = "0x1805CC1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] OMADGJHAAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x828D40", Offset = "0x827F40", VA = "0x180828D40")]
	public JMJBPOOGGLL(Type IMKDEFEOKOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class KFOJMGHIKIB : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void LPJMOEOIKKG<T>(ref IBLFHDPAOJL LNPAFIKAJEA, T PNLMJAPAHBD, NANOOOKCECO CCBHBNJKONP);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T IKKMKJHBCCD<T>(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO CCBHBNJKONP);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MFDNLKBHFMM
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HPJLNAKDKDD<T> : MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, T PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AGHBCCPLNBJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, T PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum GBEMDJDJANC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OCOJHCAIPHF
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x19C6A20", Offset = "0x19C5C20", VA = "0x1819C6A20")]
	public static global::HPJLNAKDKDD<T> JIJNIJOCLOG<T>(this NANOOOKCECO CCBHBNJKONP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4E91310", Offset = "0x4E90510", VA = "0x184E91310")]
	public static object JIEDGIPEAKE(this NANOOOKCECO CCBHBNJKONP, Type DEJAEMDNDIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MKNNADLGNNI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D2F0", Offset = "0x4E8C4F0", VA = "0x184E8D2F0")]
	public MKNNADLGNNI(string MPHBMEGMJKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct PELPFKDLCGI
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class LLHOLKDKNNO
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] AJBILMJPKED;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] IBOPPOKFLMN;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4E8C170", Offset = "0x4E8B370", VA = "0x184E8C170")]
		public static byte[] GOADAECNHJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4E8C0E0", Offset = "0x4E8B2E0", VA = "0x184E8C0E0")]
		public static char[] ACJHFPHLEOK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> GNHHELLIJMM;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] AHCLBFNANPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] PKBLLNJJAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int CEEEAFDKEEP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool ADNBKLMFBJM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4E95880", Offset = "0x4E94A80", VA = "0x184E95880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4E97710", Offset = "0x4E96910", VA = "0x184E97710")]
	public PELPFKDLCGI(byte[] PKBLLNJJAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4E97720", Offset = "0x4E96920", VA = "0x184E97720")]
	public PELPFKDLCGI(byte[] PKBLLNJJAGK, int CEEEAFDKEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4E96C50", Offset = "0x4E95E50", VA = "0x184E96C50")]
	private EBGBOJGMFGN MBCNNIHMNLA(string DAFEKCLAOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4E95990", Offset = "0x4E94B90", VA = "0x184E95990")]
	private EBGBOJGMFGN EONAGHCPKMB(string MPHBMEGMJKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B880", Offset = "0x2D7AA80", VA = "0x182D7B880")]
	public void BGJGDPJOGMO(int CEEEAFDKEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6813F0", Offset = "0x6805F0", VA = "0x1806813F0")]
	public byte[] IJOCAEJILFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x647060", Offset = "0x646260", VA = "0x180647060")]
	public int GFHNAHBHNCP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4E94E60", Offset = "0x4E94060", VA = "0x184E94E60")]
	public LFFPIINNOBI AMAJMLDCIBM()
	{
		return default(LFFPIINNOBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4E96310", Offset = "0x4E95510", VA = "0x184E96310")]
	public void KFJKKNPEOPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4E96A90", Offset = "0x4E95C90", VA = "0x184E96A90")]
	public bool LLKDHEGEGOA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4E96520", Offset = "0x4E95720", VA = "0x184E96520")]
	public bool KNFBGBMKAJE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4E94FF0", Offset = "0x4E941F0", VA = "0x184E94FF0")]
	public void BGHPGGDEDBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4E96A00", Offset = "0x4E95C00", VA = "0x184E96A00")]
	public bool LHOLGNMFJOK(ref int KOAOGJIGGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4E96450", Offset = "0x4E95650", VA = "0x184E96450")]
	public bool KICBMJKGCGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4E96BB0", Offset = "0x4E95DB0", VA = "0x184E96BB0")]
	public void LNOBENGHMHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4E973C0", Offset = "0x4E965C0", VA = "0x184E973C0")]
	public bool NHDODKJHAGG(ref int KOAOGJIGGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4E962A0", Offset = "0x4E954A0", VA = "0x184E962A0")]
	public bool KCABMFNADCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4E95C90", Offset = "0x4E94E90", VA = "0x184E95C90")]
	public void HAGKEBKNIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4E95B90", Offset = "0x4E94D90", VA = "0x184E95B90")]
	public bool GHIIBJBLGOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4E95D30", Offset = "0x4E94F30", VA = "0x184E95D30")]
	public void HEBDDFOJNDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4E950F0", Offset = "0x4E942F0", VA = "0x184E950F0")]
	private void CHADPMLAPGN(out byte[] HIBEHEGDPJF, out int HPNOKPKOIDM, out int OAEGPKJLOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4E970F0", Offset = "0x4E962F0", VA = "0x184E970F0")]
	private static int MODGELFGAPC(char JNDOPINGBDA, char CJCOEBBKILK, char MGJAENEOBLK, char AKJOAFLMJFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4E96930", Offset = "0x4E95B30", VA = "0x184E96930")]
	private static int LGJFCHGHFND(char NJBKHCBPNDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4E95F60", Offset = "0x4E95160", VA = "0x184E95F60")]
	public ArraySegment<byte> IGEAPMGHCCG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4E95AF0", Offset = "0x4E94CF0", VA = "0x184E95AF0")]
	public string GGEFHABNOLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4E95C00", Offset = "0x4E94E00", VA = "0x184E95C00")]
	public string GKGPMPIGDEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4E97210", Offset = "0x4E96410", VA = "0x184E97210")]
	public ArraySegment<byte> NACINJEIMBA()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4E94CA0", Offset = "0x4E93EA0", VA = "0x184E94CA0")]
	public ArraySegment<byte> ADCDOAPNCKL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4E966D0", Offset = "0x4E958D0", VA = "0x184E966D0")]
	public bool LAFDKAGPFNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4E95DD0", Offset = "0x4E94FD0", VA = "0x184E95DD0")]
	private static bool IBPPALIFIEM(byte MGJAENEOBLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4E960D0", Offset = "0x4E952D0", VA = "0x184E960D0")]
	private void JOCBGAOPAAG(LFFPIINNOBI OFCAAIDMNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4E971A0", Offset = "0x4E963A0", VA = "0x184E971A0")]
	public void MPFJJJJHOKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4E95E90", Offset = "0x4E95090", VA = "0x184E95E90")]
	private void IFNKJLIDFFL(int JAPEMHCKLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4E97450", Offset = "0x4E96650", VA = "0x184E97450")]
	public sbyte NNDDJHMIGBK()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4E971B0", Offset = "0x4E963B0", VA = "0x184E971B0")]
	public short MPMGBMNCAJK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4E95C30", Offset = "0x4E94E30", VA = "0x184E95C30")]
	public int GOCBGBCNADK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4E96050", Offset = "0x4E95250", VA = "0x184E96050")]
	public long IJEACMJLAAF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4E95090", Offset = "0x4E94290", VA = "0x184E95090")]
	public byte BGIPBIKHNEH()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4E974A0", Offset = "0x4E966A0", VA = "0x184E974A0")]
	public ushort OBAOBJFNOOO()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4E964C0", Offset = "0x4E956C0", VA = "0x184E964C0")]
	public uint KNBHKBLPGKI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4E95A70", Offset = "0x4E94C70", VA = "0x184E95A70")]
	public ulong FAEMIKMCIKH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4E96590", Offset = "0x4E95790", VA = "0x184E96590")]
	public float KPJPFDAHPBF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4E97500", Offset = "0x4E96700", VA = "0x184E97500")]
	public double OOADHADJDDA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4E958A0", Offset = "0x4E94AA0", VA = "0x184E958A0")]
	public ArraySegment<byte> ECLKHLPLFML()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4E94CE0", Offset = "0x4E93EE0", VA = "0x184E94CE0")]
	private static int AEFMOMKGPMD(byte[] PKBLLNJJAGK, int CEEEAFDKEEP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EBGBOJGMFGN : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference AFBKJPMGHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int JPMCCMMKAOD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int DMCONNJAMCI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x106D8D0", Offset = "0x106CAD0", VA = "0x18106D8D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string IOGOKJBCDCG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x59F850", Offset = "0x59EA50", VA = "0x18059F850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5250", Offset = "0x2DB4450", VA = "0x182DB5250")]
	public EBGBOJGMFGN(string MPHBMEGMJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5180", Offset = "0x2DB4380", VA = "0x182DB5180")]
	public EBGBOJGMFGN(string MPHBMEGMJKJ, byte[] HKEPAHHKHPO, int CEEEAFDKEEP, int JPMCCMMKAOD, string BGDPCMJCOAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class JNBGCILIHKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class OJMNKAANJHF
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void FHDLONLACKK(ref IBLFHDPAOJL LNPAFIKAJEA, object PNLMJAPAHBD, NANOOOKCECO CCBHBNJKONP);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object MLODPKJKPEC(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO CCBHBNJKONP);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class IEPENCNENKC
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class NEJLMFGAJNH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
				public NEJLMFGAJNH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x2D88E10", Offset = "0x2D88010", VA = "0x182D88E10")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x2D88E50", Offset = "0x2D88050", VA = "0x182D88E50")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, NANOOOKCECO, byte[]> CEKCEKAKIJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, NANOOOKCECO> KPNGKCFCMPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly FHDLONLACKK MHEHGJOHNDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, NANOOOKCECO, ArraySegment<byte>> JBIBHKIKIFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, NANOOOKCECO, string> OILDLBNCCNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, NANOOOKCECO, object> MGAPHMKKMOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, NANOOOKCECO, object> OFMENHLMJEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, NANOOOKCECO, object> GNGKPIFHJGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly MLODPKJKPEC ENEGKBFNJNP;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2D7CF70", Offset = "0x2D7C170", VA = "0x182D7CF70")]
			public IEPENCNENKC(Type DEJAEMDNDIC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x193C620", Offset = "0x193B820", VA = "0x18193C620")]
			private static T NLEEJHOMLPI<T>(DynamicMethod NLBABMKMKHP)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2D7CD80", Offset = "0x2D7BF80", VA = "0x182D7CD80")]
			private static MethodInfo BAIDCKHBADB(Type DEJAEMDNDIC, string HKLPIGDOLHA, Type[] NECBNOCOABD)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, IEPENCNENKC> MKKKBNAMOAK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::GIFEOMFPNIJ<IEPENCNENKC> OPHDDDHMENF;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2D894D0", Offset = "0x2D886D0", VA = "0x182D894D0")]
		static OJMNKAANJHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2D891D0", Offset = "0x2D883D0", VA = "0x182D891D0")]
		private static IEPENCNENKC FOKGNNDKGPH(Type DEJAEMDNDIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2D89360", Offset = "0x2D88560", VA = "0x182D89360")]
		public static void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, object PNLMJAPAHBD, NANOOOKCECO CCBHBNJKONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2D89250", Offset = "0x2D88450", VA = "0x182D89250")]
		public static void MNIJLJLODBL(Type DEJAEMDNDIC, ref IBLFHDPAOJL LNPAFIKAJEA, object PNLMJAPAHBD, NANOOOKCECO CCBHBNJKONP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class HCIFEADPDIO
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] AJBILMJPKED;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2D75470", Offset = "0x2D74670", VA = "0x182D75470")]
		public static byte[] GOADAECNHJC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static NANOOOKCECO AEABDINCLNB;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] PDCHCJDOLNK;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] CLIKELKGBLP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NANOOOKCECO LDNCLGGEFDN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2D805F0", Offset = "0x2D7F7F0", VA = "0x182D805F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2D80590", Offset = "0x2D7F790", VA = "0x182D80590")]
	public static void KDPMHPGMMGN(NANOOOKCECO CCBHBNJKONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x22AA920", Offset = "0x22A9B20", VA = "0x1822AA920")]
	public static string MFHKBCLPENE<T>(T PNLMJAPAHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x22AA9A0", Offset = "0x22A9BA0", VA = "0x1822AA9A0")]
	public static string MFHKBCLPENE<T>(T PNLMJAPAHBD, NANOOOKCECO CCBHBNJKONP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x193E9C0", Offset = "0x193DBC0", VA = "0x18193E9C0")]
	public static T HMOLPLGFINA<T>(string JPGPHPOFDEN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x193EA40", Offset = "0x193DC40", VA = "0x18193EA40")]
	public static T HMOLPLGFINA<T>(string JPGPHPOFDEN, NANOOOKCECO CCBHBNJKONP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x193E940", Offset = "0x193DB40", VA = "0x18193E940")]
	public static T HMOLPLGFINA<T>(byte[] PKBLLNJJAGK, NANOOOKCECO CCBHBNJKONP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x193E7F0", Offset = "0x193D9F0", VA = "0x18193E7F0")]
	public static T HMOLPLGFINA<T>(byte[] PKBLLNJJAGK, int CEEEAFDKEEP, NANOOOKCECO CCBHBNJKONP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum LFFPIINNOBI : byte
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
public struct IBLFHDPAOJL
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] MJBIFKKNBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] AJBILMJPKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int CEEEAFDKEEP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int DFMCOANAPKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x647060", Offset = "0x646260", VA = "0x180647060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B880", Offset = "0x2D7AA80", VA = "0x182D7B880")]
	public void BGJGDPJOGMO(int CEEEAFDKEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2D7BBC0", Offset = "0x2D7ADC0", VA = "0x182D7BBC0")]
	public static byte[] FCIAHGMHFMP(string JDNMAPFEFKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B9F0", Offset = "0x2D7ABF0", VA = "0x182D7B9F0")]
	public static byte[] COOCEBPJJDB(string JDNMAPFEFKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2D7C610", Offset = "0x2D7B810", VA = "0x182D7C610")]
	public static byte[] NGKOMJENOOA(string JDNMAPFEFKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2D7C7E0", Offset = "0x2D7B9E0", VA = "0x182D7C7E0")]
	public static byte[] OOBGPFHCOOI(string JDNMAPFEFKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2D7CC30", Offset = "0x2D7BE30", VA = "0x182D7CC30")]
	public IBLFHDPAOJL(byte[] CDGGEEOJCDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2D7BD20", Offset = "0x2D7AF20", VA = "0x182D7BD20")]
	public ArraySegment<byte> GOADAECNHJC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2D7C520", Offset = "0x2D7B720", VA = "0x182D7C520")]
	public byte[] LIOCFAILONO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2D7CB80", Offset = "0x2D7BD80", VA = "0x182D7CB80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2D7C600", Offset = "0x2D7B800", VA = "0x182D7C600")]
	public void NGIBFOMCMPB(int HGCCICMLEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B820", Offset = "0x2D7AA20", VA = "0x182D7B820")]
	public void BFNFEEKMOBH(byte[] OBICCMOKCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2D7BDD0", Offset = "0x2D7AFD0", VA = "0x182D7BDD0")]
	public void HCPMEBNMJPC(byte OBICCMOKCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2D7C790", Offset = "0x2D7B990", VA = "0x182D7C790")]
	public void OMOHAECFNMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2D7BB20", Offset = "0x2D7AD20", VA = "0x182D7BB20")]
	public void DAJNAIABCIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2D7BB70", Offset = "0x2D7AD70", VA = "0x182D7BB70")]
	public void FBHNKEOGIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2D7C940", Offset = "0x2D7BB40", VA = "0x182D7C940")]
	public void PBFMNNCMBLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2D7C740", Offset = "0x2D7B940", VA = "0x182D7C740")]
	public void OKKAMKHOBBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2D7C1E0", Offset = "0x2D7B3E0", VA = "0x182D7C1E0")]
	public void HJBLFPNAMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B890", Offset = "0x2D7AA90", VA = "0x182D7B890")]
	public void BMABCABNGGJ(string JDNMAPFEFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2D7BCD0", Offset = "0x2D7AED0", VA = "0x182D7BCD0")]
	public void GLPDMJCFGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B920", Offset = "0x2D7AB20", VA = "0x182D7B920")]
	public void CMCABHPKNKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2D7C990", Offset = "0x2D7BB90", VA = "0x182D7C990")]
	public void PONJHCEGLND(bool PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2D7C3D0", Offset = "0x2D7B5D0", VA = "0x182D7C3D0")]
	public void LCMACABGIGN(float PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2D7C290", Offset = "0x2D7B490", VA = "0x182D7C290")]
	public void LAMMOLLAIKI(double PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2D7C260", Offset = "0x2D7B460", VA = "0x182D7C260")]
	public void JBAJAMONOGJ(byte PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2D7C230", Offset = "0x2D7B430", VA = "0x182D7C230")]
	public void ICGMJFKNOGJ(ushort PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2D7C5A0", Offset = "0x2D7B7A0", VA = "0x182D7C5A0")]
	public void MDMCCKIFFNC(uint PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B8F0", Offset = "0x2D7AAF0", VA = "0x182D7B8F0")]
	public void CLLFINCHJGF(ulong PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2D7BCA0", Offset = "0x2D7AEA0", VA = "0x182D7BCA0")]
	public void FHGHMGCOLMF(sbyte PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B7C0", Offset = "0x2D7A9C0", VA = "0x182D7B7C0")]
	public void ABHJGJAAPOI(short PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B7F0", Offset = "0x2D7A9F0", VA = "0x182D7B7F0")]
	public void ACDHKOMNOIL(int PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2D7C5D0", Offset = "0x2D7B7D0", VA = "0x182D7C5D0")]
	public void MHBBAKFBCPI(long PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2D7BE10", Offset = "0x2D7B010", VA = "0x182D7BE10")]
	public void HHKBCLNMPOG(string PNLMJAPAHBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GNKKLDIIGDL : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class AKEOIOOMENL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x21792E0", Offset = "0x21784E0", VA = "0x1821792E0")]
		static AKEOIOOMENL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private GNKKLDIIGDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class LGKNIDFCGOE
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> KHLCIHMFLLC;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2D84250", Offset = "0x2D83450", VA = "0x182D84250")]
	static LGKNIDFCGOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2D83CF0", Offset = "0x2D82EF0", VA = "0x182D83CF0")]
	internal static object JNNOPNMNCDC(Type ELLGECINNIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class HJBNHODHCAM : global::HPJLNAKDKDD<Vector2>, MFDNLKBHFMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NONFMEBLNME OHPFAIMBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] GPIMFDHMEID;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2D78800", Offset = "0x2D77A00", VA = "0x182D78800")]
	public HJBNHODHCAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2D78690", Offset = "0x2D77890", VA = "0x182D78690", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, Vector2 PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2D78510", Offset = "0x2D77710", VA = "0x182D78510", Slot = "5")]
	public Vector2 HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class IGFNDJJGNJG : global::HPJLNAKDKDD<Vector3>, MFDNLKBHFMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly NONFMEBLNME OHPFAIMBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] GPIMFDHMEID;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2D7EF00", Offset = "0x2D7E100", VA = "0x182D7EF00")]
	public IGFNDJJGNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2D7ECF0", Offset = "0x2D7DEF0", VA = "0x182D7ECF0", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, Vector3 PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2D7EB00", Offset = "0x2D7DD00", VA = "0x182D7EB00", Slot = "5")]
	public Vector3 HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OGLHNKBEICE : global::HPJLNAKDKDD<Vector4>, MFDNLKBHFMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly NONFMEBLNME OHPFAIMBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] GPIMFDHMEID;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4E92A70", Offset = "0x4E91C70", VA = "0x184E92A70")]
	public OGLHNKBEICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2DAC730", Offset = "0x2DAB930", VA = "0x182DAC730", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, Vector4 PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4E926F0", Offset = "0x4E918F0", VA = "0x184E926F0", Slot = "5")]
	public Vector4 HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class CEBGBKHIOFM : global::HPJLNAKDKDD<Quaternion>, MFDNLKBHFMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly NONFMEBLNME OHPFAIMBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] GPIMFDHMEID;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2DB0090", Offset = "0x2DAF290", VA = "0x182DB0090")]
	public CEBGBKHIOFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2DAC730", Offset = "0x2DAB930", VA = "0x182DAC730", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, Quaternion PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2DAFE60", Offset = "0x2DAF060", VA = "0x182DAFE60", Slot = "5")]
	public Quaternion HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class AFCAMCNMBBJ : global::HPJLNAKDKDD<Color>, MFDNLKBHFMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly NONFMEBLNME OHPFAIMBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] GPIMFDHMEID;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2DAC880", Offset = "0x2DABA80", VA = "0x182DAC880")]
	public AFCAMCNMBBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2DAC730", Offset = "0x2DAB930", VA = "0x182DAC730", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, Color PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2DAC500", Offset = "0x2DAB700", VA = "0x182DAC500", Slot = "5")]
	public Color HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class BAHDHGFJFOE : global::HPJLNAKDKDD<Bounds>, MFDNLKBHFMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly NONFMEBLNME OHPFAIMBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] GPIMFDHMEID;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE7F0", Offset = "0x2DAD9F0", VA = "0x182DAE7F0")]
	public BAHDHGFJFOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE580", Offset = "0x2DAD780", VA = "0x182DAE580", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, Bounds PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE2E0", Offset = "0x2DAD4E0", VA = "0x182DAE2E0", Slot = "5")]
	public Bounds HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class EBLODBAHINM : global::HPJLNAKDKDD<Rect>, MFDNLKBHFMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly NONFMEBLNME OHPFAIMBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] GPIMFDHMEID;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5690", Offset = "0x2DB4890", VA = "0x182DB5690")]
	public EBLODBAHINM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5520", Offset = "0x2DB4720", VA = "0x182DB5520", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, Rect PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2DB52C0", Offset = "0x2DB44C0", VA = "0x182DB52C0", Slot = "5")]
	public Rect HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class CJPAJBFLBCL : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class IHJHNCNEBHJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7BD0", Offset = "0x3DE6DD0", VA = "0x183DE7BD0")]
		static IHJHNCNEBHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private CJPAJBFLBCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class HHFCBOOJMJE : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class FDPDKJGAABK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1E35C60", Offset = "0x1E34E60", VA = "0x181E35C60")]
		static FDPDKJGAABK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class POGGFEGDIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> OOGLLOEEILG;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D89770", Offset = "0x2D88970", VA = "0x182D89770")]
		internal static object JNNOPNMNCDC(Type ELLGECINNIM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private HHFCBOOJMJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class KHMEABPDODJ : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class FIFJKLEILJK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x36C1850", Offset = "0x36C0A50", VA = "0x1836C1850")]
		static FIFJKLEILJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly KHMEABPDODJ JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool MEJLLJFMKFP;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static MFDNLKBHFMM[] CBGONEOHOAD;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static NANOOOKCECO[] ODPDBGBFBIF;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private KHMEABPDODJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2D80A20", Offset = "0x2D7FC20", VA = "0x182D80A20")]
	public static void EMPBBIOHMBK(params NANOOOKCECO[] ODPDBGBFBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2D80960", Offset = "0x2D7FB60", VA = "0x182D80960")]
	public static void EMPBBIOHMBK(params MFDNLKBHFMM[] CBGONEOHOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2D80AE0", Offset = "0x2D7FCE0", VA = "0x182D80AE0")]
	public static void KJFGGNFADIK(MFDNLKBHFMM[] CBGONEOHOAD, NANOOOKCECO[] ODPDBGBFBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class OOOMAMNCKKM : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class OCPGMAGDODB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x458E850", Offset = "0x458DA50", VA = "0x18458E850")]
		static OCPGMAGDODB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private OOOMAMNCKKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class GKACNAGJCAN
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly NANOOOKCECO MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly NANOOOKCECO FHFJNEFFCHN;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly NANOOOKCECO MPFDMFAKCOI;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly NANOOOKCECO AGOPIFPDJAP;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly NANOOOKCECO LLMIAPOBAGN;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly NANOOOKCECO MBEPJJCMOBO;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly NANOOOKCECO KBFMKPNKJCF;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly NANOOOKCECO CLEADAMNKCI;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly NANOOOKCECO MGLBIEABBJB;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly NANOOOKCECO JJOBCAIFPON;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly NANOOOKCECO PDDLAMOPFGP;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly NANOOOKCECO NKGGEMHELHC;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class CDFKJCEKEHC
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly NANOOOKCECO MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly NANOOOKCECO FIDDEAKKIPB;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class AENGPBILELL
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly NANOOOKCECO MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly NANOOOKCECO FHFJNEFFCHN;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly NANOOOKCECO MPFDMFAKCOI;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly NANOOOKCECO AGOPIFPDJAP;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly NANOOOKCECO LLMIAPOBAGN;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly NANOOOKCECO MBEPJJCMOBO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly NANOOOKCECO KBFMKPNKJCF;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly NANOOOKCECO CLEADAMNKCI;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly NANOOOKCECO MGLBIEABBJB;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly NANOOOKCECO JJOBCAIFPON;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly NANOOOKCECO PDDLAMOPFGP;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly NANOOOKCECO NKGGEMHELHC;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class KPBHAFHCFKN
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> OOGLLOEEILG;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2D82190", Offset = "0x2D81390", VA = "0x182D82190")]
	internal static object JNNOPNMNCDC(Type ELLGECINNIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2D837B0", Offset = "0x2D829B0", VA = "0x182D837B0")]
	private static object ONBAFKNGLFI(Type INFKKFMDDMP, Type[] OPIAPPGONNI, params object[] NECBNOCOABD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class MAGFJPHKCBD : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class KFCHMHFLCNI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x30164C0", Offset = "0x30156C0", VA = "0x1830164C0")]
		static KFCHMHFLCNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> FKMMHPAPKAD;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool DBANJLPJELN;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly OBEHIIJKFIJ ECHCGNHCGAJ;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2D85D80", Offset = "0x2D84F80", VA = "0x182D85D80")]
	static MAGFJPHKCBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private MAGFJPHKCBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class AHOIBEONHDK : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class BBIHBFFCIMH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2ECD770", Offset = "0x2ECC970", VA = "0x182ECD770")]
		static BBIHBFFCIMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> FKMMHPAPKAD;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool DBANJLPJELN;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly OBEHIIJKFIJ ECHCGNHCGAJ;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2DADF50", Offset = "0x2DAD150", VA = "0x182DADF50")]
	static AHOIBEONHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private AHOIBEONHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class NMMANICIGBI : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class BMBGOGKHAOP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4379080", Offset = "0x4378280", VA = "0x184379080")]
		static BMBGOGKHAOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> FKMMHPAPKAD;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool DBANJLPJELN;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly OBEHIIJKFIJ ECHCGNHCGAJ;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4E90100", Offset = "0x4E8F300", VA = "0x184E90100")]
	static NMMANICIGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private NMMANICIGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class FPCOMPALGAK : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class FIEECOHLMOJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1C98570", Offset = "0x1C97770", VA = "0x181C98570")]
		static FIEECOHLMOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> FKMMHPAPKAD;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool DBANJLPJELN;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly OBEHIIJKFIJ ECHCGNHCGAJ;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2DBD010", Offset = "0x2DBC210", VA = "0x182DBD010")]
	static FPCOMPALGAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private FPCOMPALGAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class LECEFMCIDKF : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class IFOHLLFFBJF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2246600", Offset = "0x2245800", VA = "0x182246600")]
		static IFOHLLFFBJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> FKMMHPAPKAD;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool DBANJLPJELN;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly OBEHIIJKFIJ ECHCGNHCGAJ;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2D83BA0", Offset = "0x2D82DA0", VA = "0x182D83BA0")]
	static LECEFMCIDKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private LECEFMCIDKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class EOFEGGOBMAM : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class OMACKIEABGO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2C51170", Offset = "0x2C50370", VA = "0x182C51170")]
		static OMACKIEABGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> FKMMHPAPKAD;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool DBANJLPJELN;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly OBEHIIJKFIJ ECHCGNHCGAJ;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5E50", Offset = "0x2DB5050", VA = "0x182DB5E50")]
	static EOFEGGOBMAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private EOFEGGOBMAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class GINKANJNCDP : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class PCJMDDACPDM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x22101D0", Offset = "0x220F3D0", VA = "0x1822101D0")]
		static PCJMDDACPDM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> FKMMHPAPKAD;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool DBANJLPJELN;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public GINKANJNCDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class NBHOEMPHKOO : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class DEBLGAOJDKA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x41A6A80", Offset = "0x41A5C80", VA = "0x1841A6A80")]
		static DEBLGAOJDKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> FKMMHPAPKAD;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool DBANJLPJELN;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public NBHOEMPHKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class HGOJHOIOKFI : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class CKCLGIBBMDN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1E32E50", Offset = "0x1E32050", VA = "0x181E32E50")]
		static CKCLGIBBMDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> FKMMHPAPKAD;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool DBANJLPJELN;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public HGOJHOIOKFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class JHNOAMMIDOD : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class NLLKNNDMLCJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x38C87C0", Offset = "0x38C79C0", VA = "0x1838C87C0")]
		static NLLKNNDMLCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> FKMMHPAPKAD;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool DBANJLPJELN;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public JHNOAMMIDOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class JBHDBJIFIIF : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class BNDGHPBJAIH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x38B31C0", Offset = "0x38B23C0", VA = "0x1838B31C0")]
		static BNDGHPBJAIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> FKMMHPAPKAD;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool DBANJLPJELN;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public JBHDBJIFIIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class BHOMAIMNFMN : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class BCLMLANGEAG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3DE99F0", Offset = "0x3DE8BF0", VA = "0x183DE99F0")]
		static BCLMLANGEAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> FKMMHPAPKAD;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool DBANJLPJELN;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public BHOMAIMNFMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class GGJEGAIKFNF
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct CODECDFDHGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public FJEIAANLMDN NEEECAJJEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder CIJFAMPPMLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder BBCDLELIGLB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class MGDIDIHMMFM
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class MCCKIMOILCA
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo NGKOMJENOOA;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo COOCEBPJJDB;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo OOBGPFHCOOI;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo FCIAHGMHFMP;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo CMCABHPKNKK;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo BFNFEEKMOBH;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo FBHNKEOGIIJ;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo PBFMNNCMBLL;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo OKKAMKHOBBH;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x2D85E80", Offset = "0x2D85080", VA = "0x182D85E80")]
			static MCCKIMOILCA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class HKFAIIFDLFM
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo LLKDHEGEGOA;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo LNOBENGHMHA;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo NHDODKJHAGG;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo FGHPHANHCFN;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo MPFJJJJHOKF;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo IJOCAEJILFI;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo GFHNAHBHNCP;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2D789D0", Offset = "0x2D77BD0", VA = "0x182D789D0")]
			static HKFAIIFDLFM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class DEJDJNDKIOD
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo JILNHGOGNEB;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo OMADGJHAAEG;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo LGFBHNFFNMI;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo JIJNIJOCLOG;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo PFONECDGGPM;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo PJDNILJEHLD;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo BMLJGGLIHIF;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo FJELOLEMNOF;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo GIAIDLCOPMB;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo DOIMDIABMFC;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo CFILAFLNCLP;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo GBFEHGCGCLJ;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo IAPOKLIHIKH;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo LNEFIMKLOPN;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2D86F70", Offset = "0x2D86170", VA = "0x182D86F70")]
		public static MethodInfo MNIJLJLODBL(Type DEJAEMDNDIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2D86D40", Offset = "0x2D85F40", VA = "0x182D86D40")]
		public static MethodInfo HMOLPLGFINA(Type DEJAEMDNDIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2D86C20", Offset = "0x2D85E20", VA = "0x182D86C20")]
		public static MethodInfo AILAHHJILPO(Type DEJAEMDNDIC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class PHPAKDLMBMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<FJEIAANLMDN, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public PHPAKDLMBMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class KIAEFOMCLFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public PHPAKDLMBMP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public KIAEFOMCLFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2D80DF0", Offset = "0x2D7FFF0", VA = "0x182D80DF0")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2D80E30", Offset = "0x2D80030", VA = "0x182D80E30")]
		internal bool <BuildType>b__2(int index, FJEIAANLMDN member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class MOHKGNIDCFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public PHPAKDLMBMP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public MOHKGNIDCFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2D88D70", Offset = "0x2D87F70", VA = "0x182D88D70")]
		internal bool <BuildType>b__3(int index, FJEIAANLMDN member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class COKJAJJLCDC
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
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public COKJAJJLCDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2D72650", Offset = "0x2D71850", VA = "0x182D72650")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class BKNHAOGPPNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public BKNHAOGPPNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2D722A0", Offset = "0x2D714A0", VA = "0x182D722A0")]
		internal bool <BuildAnonymousFormatter>b__2(FJEIAANLMDN x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class PHJEFOILJDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public COKJAJJLCDC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public PHJEFOILJDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2D895C0", Offset = "0x2D887C0", VA = "0x182D895C0")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2D895D0", Offset = "0x2D887D0", VA = "0x182D895D0")]
		internal bool <BuildAnonymousFormatter>b__6(int index, FJEIAANLMDN member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class FLLKABBHCLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public COKJAJJLCDC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public FLLKABBHCLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2D72F80", Offset = "0x2D72180", VA = "0x182D72F80")]
		internal bool <BuildAnonymousFormatter>b__7(int index, FJEIAANLMDN member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class GJDLGGDNFAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public GJDLGGDNFAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x59E450", Offset = "0x59D650", VA = "0x18059E450")]
		internal Label <BuildSerialize>b__1(FJEIAANLMDN _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class ICFMAIIHNEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public CODECDFDHGJ[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, FJEIAANLMDN, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AFONKAEHIAF argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AFONKAEHIAF argResolver;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public ICFMAIIHNEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2D7CC50", Offset = "0x2D7BE50", VA = "0x182D7CC50")]
		internal CODECDFDHGJ <BuildDeserialize>b__0(FJEIAANLMDN item)
		{
			return default(CODECDFDHGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class CAPCCCKFMHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public ICFMAIIHNEM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public CAPCCCKFMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2D72300", Offset = "0x2D71500", VA = "0x182D72300")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2D725B0", Offset = "0x2D717B0", VA = "0x182D725B0")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class ENHBJDDGIJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public FJEIAANLMDN item;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public ENHBJDDGIJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x134E7E0", Offset = "0x134D9E0", VA = "0x18134E7E0")]
		internal bool <EmitNewObject>b__0(CODECDFDHGJ x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class KEMKBLDDFBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public FJEIAANLMDN item;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public KEMKBLDDFBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x134E7E0", Offset = "0x134D9E0", VA = "0x18134E7E0")]
		internal bool <EmitNewObject>b__2(CODECDFDHGJ x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex NFHDAKBJLKN;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int JNMPEJDBNKE;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> GMFFGIIMGLN;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> NADAKDDAHHJ;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x295BB40", Offset = "0x295AD40", VA = "0x18295BB40")]
	public static object HPFNDLKJOKP<T>(OBEHIIJKFIJ ECHCGNHCGAJ, NANOOOKCECO GLAFGMNPOII, Func<string, string> FKMMHPAPKAD, bool DBANJLPJELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x22A5CF0", Offset = "0x22A4EF0", VA = "0x1822A5CF0")]
	public static object OEPLLNPNCPC<T>(NANOOOKCECO GLAFGMNPOII, Func<string, string> FKMMHPAPKAD, bool DBANJLPJELN, bool HLPMOGFODKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2DC2780", Offset = "0x2DC1980", VA = "0x182DC2780")]
	private static TypeInfo IPMHJGNPKBH(OBEHIIJKFIJ ECHCGNHCGAJ, Type DEJAEMDNDIC, Func<string, string> FKMMHPAPKAD, bool DBANJLPJELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2DBFAF0", Offset = "0x2DBECF0", VA = "0x182DBFAF0")]
	public static object DIDOAAONOPH(Type DEJAEMDNDIC, Func<string, string> FKMMHPAPKAD, bool DBANJLPJELN, bool HLPMOGFODKJ, bool DFOPOFKIFJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2DBF4A0", Offset = "0x2DBE6A0", VA = "0x182DBF4A0")]
	private static Dictionary<FJEIAANLMDN, FieldInfo> CBEECOGBMLJ(TypeBuilder EOOFNPAHCBE, AFIPCINKNCE LNOAGBDNLLD, ConstructorInfo PMPBCPKJNBD, FieldBuilder FNIMPMLBIJC, ILGenerator JKIGFLECKGI, bool DBANJLPJELN, bool JJPNJHBBDEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3220", Offset = "0x2DC2420", VA = "0x182DC3220")]
	private static Dictionary<FJEIAANLMDN, FieldInfo> LADBCAPICPL(TypeBuilder EOOFNPAHCBE, AFIPCINKNCE LNOAGBDNLLD, ILGenerator JKIGFLECKGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2DBD710", Offset = "0x2DBC910", VA = "0x182DBD710")]
	private static void AHGEACLNKEG(Type DEJAEMDNDIC, AFIPCINKNCE LNOAGBDNLLD, ILGenerator JKIGFLECKGI, Action GBAMPCLKGHD, Func<int, FJEIAANLMDN, bool> AIMMCHNFGFH, bool DBANJLPJELN, bool JJPNJHBBDEJ, int DPDAAFMIFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2DBEDD0", Offset = "0x2DBDFD0", VA = "0x182DBEDD0")]
	private static void BGDIHCCKJNA(TypeInfo DEJAEMDNDIC, FJEIAANLMDN LFNGLKJEEOK, ILGenerator JKIGFLECKGI, int PPMIPKENDBN, Func<int, FJEIAANLMDN, bool> AIMMCHNFGFH, AFONKAEHIAF LNPAFIKAJEA, AFONKAEHIAF GHGNHIJNIBB, AFONKAEHIAF PEDJJBCGLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2DC14B0", Offset = "0x2DC06B0", VA = "0x182DC14B0")]
	private static void ICIFMDGHFCF(Type DEJAEMDNDIC, AFIPCINKNCE LNOAGBDNLLD, ILGenerator JKIGFLECKGI, Func<int, FJEIAANLMDN, bool> AIMMCHNFGFH, bool LMCHMGCCFIC, int DPDAAFMIFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2DC37F0", Offset = "0x2DC29F0", VA = "0x182DC37F0")]
	private static void LGGHDDNKLJI(ILGenerator JKIGFLECKGI, CODECDFDHGJ LNOAGBDNLLD, int PPMIPKENDBN, Func<int, FJEIAANLMDN, bool> AIMMCHNFGFH, AFONKAEHIAF AGJPFNIFDJG, AFONKAEHIAF PEDJJBCGLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3E40", Offset = "0x2DC3040", VA = "0x182DC3E40")]
	private static LocalBuilder MBPLDBMNEGH(ILGenerator JKIGFLECKGI, Type DEJAEMDNDIC, AFIPCINKNCE LNOAGBDNLLD, CODECDFDHGJ[] JAOFONGMKME, bool NMGOCDAPBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2DC4AB0", Offset = "0x2DC3CB0", VA = "0x182DC4AB0")]
	private static bool NEMLPNAPNPH(ConstructorInfo KLNKHCLNJEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3CA0", Offset = "0x2DC2EA0", VA = "0x182DC3CA0")]
	private static bool LMMKDFECCCC(Type DEJAEMDNDIC, out Type EBJGKCDMOLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void MOLGHODCLEH<T>(byte[][] FNIMPMLBIJC, object[] HGAIHEJPDAJ, ref IBLFHDPAOJL LNPAFIKAJEA, T PNLMJAPAHBD, NANOOOKCECO CCBHBNJKONP);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T DFDGCPLJOJD<T>(object[] HGAIHEJPDAJ, ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO CCBHBNJKONP);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class AKIOHHCAOJP<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class MFFDEPLLAAO : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class CBHELLEEBLL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x39D60F0", Offset = "0x39D52F0", VA = "0x1839D60F0")]
		static CBHELLEEBLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private MFFDEPLLAAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class OPLIBFPBGHE : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class PGAGHFLEMDE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3315F60", Offset = "0x3315160", VA = "0x183315F60")]
		static PGAGHFLEMDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private OPLIBFPBGHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class NANEEAIOLMF
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	internal static readonly NANOOOKCECO[] BLDFDIENFKC;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class LHMHCAMMJFH : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class MGMJHHPCLLC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x1D03100", Offset = "0x1D02300", VA = "0x181D03100")]
		static MGMJHHPCLLC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class DCFMEPMHLLI : NANOOOKCECO
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class FFFIEDADLGE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x1CF3240", Offset = "0x1CF2440", VA = "0x181CF3240")]
			static FFFIEDADLGE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly NANOOOKCECO JACNMOBBDPN;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly NANOOOKCECO[] ODPDBGBFBIF;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		private DCFMEPMHLLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
		public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly global::HPJLNAKDKDD<object> OKKAJGGEHFM;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private LHMHCAMMJFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class KICPJBMDDBC : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class KLOGFHBMPIF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x36CDAE0", Offset = "0x36CCCE0", VA = "0x1836CDAE0")]
		static KLOGFHBMPIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class NIMLFOECFOO : NANOOOKCECO
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class OMEMEFGEBML<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x36D6250", Offset = "0x36D5450", VA = "0x1836D6250")]
			static OMEMEFGEBML()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly NANOOOKCECO JACNMOBBDPN;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly NANOOOKCECO[] ODPDBGBFBIF;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		private NIMLFOECFOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
		public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::HPJLNAKDKDD<object> OKKAJGGEHFM;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private KICPJBMDDBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class MHONGLCBCDG : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class KGLIPEACBEH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x39DF460", Offset = "0x39DE660", VA = "0x1839DF460")]
		static KGLIPEACBEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class AFLKAIFLAHL : NANOOOKCECO
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class NDKFHBCCDNC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x39EE3A0", Offset = "0x39ED5A0", VA = "0x1839EE3A0")]
			static NDKFHBCCDNC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly NANOOOKCECO JACNMOBBDPN;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly NANOOOKCECO[] ODPDBGBFBIF;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		private AFLKAIFLAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
		public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly global::HPJLNAKDKDD<object> OKKAJGGEHFM;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private MHONGLCBCDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class IHIGGDCCFDD : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class FAIDFHILANN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3F68630", Offset = "0x3F67830", VA = "0x183F68630")]
		static FAIDFHILANN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class GDFMNJNMNJC : NANOOOKCECO
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class NGJNJIKPADF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3F7DFC0", Offset = "0x3F7D1C0", VA = "0x183F7DFC0")]
			static NGJNJIKPADF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly NANOOOKCECO JACNMOBBDPN;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly NANOOOKCECO[] ODPDBGBFBIF;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		private GDFMNJNMNJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
		public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly global::HPJLNAKDKDD<object> OKKAJGGEHFM;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private IHIGGDCCFDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class NCDMAHJDFCC : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class CNPCNFIMDPI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x41A3C20", Offset = "0x41A2E20", VA = "0x1841A3C20")]
		static CNPCNFIMDPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class LHPPCJHBPEP : NANOOOKCECO
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class LLPFHNCJGLI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x41AF330", Offset = "0x41AE530", VA = "0x1841AF330")]
			static LLPFHNCJGLI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly NANOOOKCECO JACNMOBBDPN;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly NANOOOKCECO[] ODPDBGBFBIF;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		private LHPPCJHBPEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
		public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::HPJLNAKDKDD<object> OKKAJGGEHFM;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private NCDMAHJDFCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class LMFADDEEEBD : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class KCANOILPIEA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x409BD60", Offset = "0x409AF60", VA = "0x18409BD60")]
		static KCANOILPIEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class EFDEBAMIHKF : NANOOOKCECO
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class KNMMPBPDAAD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x409E4B0", Offset = "0x409D6B0", VA = "0x18409E4B0")]
			static KNMMPBPDAAD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly NANOOOKCECO JACNMOBBDPN;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly NANOOOKCECO[] ODPDBGBFBIF;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		private EFDEBAMIHKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
		public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly global::HPJLNAKDKDD<object> OKKAJGGEHFM;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private LMFADDEEEBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class BIHHGDNFHCE : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class KFIKFBNMPGG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3DF7DD0", Offset = "0x3DF6FD0", VA = "0x183DF7DD0")]
		static KFIKFBNMPGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class PKBJDIJDMGE : NANOOOKCECO
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class PKNELOBGFGN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3DFD200", Offset = "0x3DFC400", VA = "0x183DFD200")]
			static PKNELOBGFGN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly NANOOOKCECO JACNMOBBDPN;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly NANOOOKCECO[] ODPDBGBFBIF;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		private PKBJDIJDMGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
		public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly global::HPJLNAKDKDD<object> OKKAJGGEHFM;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private BIHHGDNFHCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class MIABECDFMKA : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class DCBGAIHMPEJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x24E56C0", Offset = "0x24E48C0", VA = "0x1824E56C0")]
		static DCBGAIHMPEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class MHEBNGKIKBN : NANOOOKCECO
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class HKDLEFELKFD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x24EC0B0", Offset = "0x24EB2B0", VA = "0x1824EC0B0")]
			static HKDLEFELKFD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly NANOOOKCECO JACNMOBBDPN;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly NANOOOKCECO[] ODPDBGBFBIF;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		private MHEBNGKIKBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
		public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly global::HPJLNAKDKDD<object> OKKAJGGEHFM;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private MIABECDFMKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class EEHOAANNMHL : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class IJPLLDMFBCD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3216DD0", Offset = "0x3215FD0", VA = "0x183216DD0")]
		static IJPLLDMFBCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class BHKJJCFLEKA : NANOOOKCECO
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class LONHLLODEGD<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x32211C0", Offset = "0x32203C0", VA = "0x1832211C0")]
			static LONHLLODEGD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly NANOOOKCECO JACNMOBBDPN;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly NANOOOKCECO[] ODPDBGBFBIF;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		private BHKJJCFLEKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
		public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly global::HPJLNAKDKDD<object> OKKAJGGEHFM;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private EEHOAANNMHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class ONPKCNGOPHL : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class KFNNKBAICDA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x45868E0", Offset = "0x4585AE0", VA = "0x1845868E0")]
		static KFNNKBAICDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class PKBMHCJFHEI : NANOOOKCECO
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class KKBJILMNJKC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x458B520", Offset = "0x458A720", VA = "0x18458B520")]
			static KKBJILMNJKC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly NANOOOKCECO JACNMOBBDPN;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly NANOOOKCECO[] ODPDBGBFBIF;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		private PKBMHCJFHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
		public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly global::HPJLNAKDKDD<object> OKKAJGGEHFM;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private ONPKCNGOPHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class BFHCGHIOJPD : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class PKJNOLCADHD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E0C0", Offset = "0x3A3D2C0", VA = "0x183A3E0C0")]
		static PKJNOLCADHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class PKKGIGBCGNK : NANOOOKCECO
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class JAOKHFHMBGN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3A39CA0", Offset = "0x3A38EA0", VA = "0x183A39CA0")]
			static JAOKHFHMBGN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly NANOOOKCECO JACNMOBBDPN;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly NANOOOKCECO[] ODPDBGBFBIF;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		private PKKGIGBCGNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
		public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::HPJLNAKDKDD<object> OKKAJGGEHFM;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private BFHCGHIOJPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class NJKACMOCPGD : NANOOOKCECO
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class LLJEMBBCKKJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x34D6670", Offset = "0x34D5870", VA = "0x1834D6670")]
		static LLJEMBBCKKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class JMFGFDBOHCD : NANOOOKCECO
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class NLBKJMAEBHP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly global::HPJLNAKDKDD<T> DELKIKBDAAB;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x34E73D0", Offset = "0x34E65D0", VA = "0x1834E73D0")]
			static NLBKJMAEBHP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly NANOOOKCECO JACNMOBBDPN;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly NANOOOKCECO[] ODPDBGBFBIF;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		private JMFGFDBOHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
		public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly NANOOOKCECO JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly global::HPJLNAKDKDD<object> OKKAJGGEHFM;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	private NJKACMOCPGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x19C7830", Offset = "0x19C6A30", VA = "0x1819C7830", Slot = "4")]
	public global::HPJLNAKDKDD<T> JNNOPNMNCDC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct CHKLPHNEILJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public T[] OAINCHCEPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int PHMELCGNMEH;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x2480480", Offset = "0x247F680", VA = "0x182480480")]
	public CHKLPHNEILJ(int AGPABEMJDOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x24803B0", Offset = "0x247F5B0", VA = "0x1824803B0")]
	public void INLOBDHPAIC(T PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x2480170", Offset = "0x247F370", VA = "0x182480170")]
	public T[] ILGGLAGBPPC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class JLFAIOPNFHJ : global::LHGIPJPMKKE<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly JLFAIOPNFHJ MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x2D80540", Offset = "0x2D7F740", VA = "0x182D80540")]
	public JLFAIOPNFHJ(int KCHJKJKDPBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class LHGIPJPMKKE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly int KCHJKJKDPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly object FNMAOKMJNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int PPMIPKENDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private T[][] PHFNPHHDEFH;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x1CFE2D0", Offset = "0x1CFD4D0", VA = "0x181CFE2D0")]
	public LHGIPJPMKKE(int KCHJKJKDPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD3D0", Offset = "0x1CFC5D0", VA = "0x181CFD3D0")]
	public T[] EDMMKOPDNBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC710", Offset = "0x1CFB910", VA = "0x181CFC710")]
	public void EANLMPBFPAD(T[] IBNOFMOJNKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class NONFMEBLNME : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class NLFNLBNEHHF : IComparable<NLFNLBNEHHF>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class DJCGHFKPHBH : IEnumerable<NLFNLBNEHHF>, IEnumerable, IEnumerator<NLFNLBNEHHF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private NLFNLBNEHHF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public NLFNLBNEHHF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private NLFNLBNEHHF System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x9016D0", Offset = "0x9008D0", VA = "0x1809016D0")]
			[DebuggerHidden]
			public DJCGHFKPHBH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x4E8B600", Offset = "0x4E8A800", VA = "0x184E8B600", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x4E8B730", Offset = "0x4E8A930", VA = "0x184E8B730", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x4E8B690", Offset = "0x4E8A890", VA = "0x184E8B690", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NLFNLBNEHHF> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x4E8B690", Offset = "0x4E8A890", VA = "0x184E8B690", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class FEGOEFFKNEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
			public FEGOEFFKNEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x59E450", Offset = "0x59D650", VA = "0x18059E450")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x59E450", Offset = "0x59D650", VA = "0x18059E450")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly NLFNLBNEHHF[] BMDDJNJMKFE;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly ulong[] EDJPBHOPBML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ulong PKFENIANCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int AMCKDLHOFMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string GCKDLJHPCKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private NLFNLBNEHHF[] AGDLOAPMFIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ulong[] JNPKCKJICOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int KOAOGJIGGHC;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool LIEHGAMGIGI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x6FB500", Offset = "0x6FA700", VA = "0x1806FB500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4E8FD90", Offset = "0x4E8EF90", VA = "0x184E8FD90")]
		public NLFNLBNEHHF(ulong DHDAEDILENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4E8F880", Offset = "0x4E8EA80", VA = "0x184E8F880")]
		public NLFNLBNEHHF INLOBDHPAIC(ulong DHDAEDILENC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x4E8F830", Offset = "0x4E8EA30", VA = "0x184E8F830")]
		public NLFNLBNEHHF INLOBDHPAIC(ulong DHDAEDILENC, int PNLMJAPAHBD, string GCKDLJHPCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x4E8EA60", Offset = "0x4E8DC60", VA = "0x184E8EA60")]
		public NLFNLBNEHHF EIELBIDBBMK(byte[] IEJJEFKGHBB, ref int CEEEAFDKEEP, ref int GJJDGKNLIGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x4E8FA70", Offset = "0x4E8EC70", VA = "0x184E8FA70")]
		internal static int NLMGKAIJHAF(ulong[] IBNOFMOJNKD, int PPMIPKENDBN, int NOPNDNKKPCL, ulong PNLMJAPAHBD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4E8E9C0", Offset = "0x4E8DBC0", VA = "0x184E8E9C0", Slot = "4")]
		public int CompareTo(NLFNLBNEHHF EBJKBJMLDOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4E8E9F0", Offset = "0x4E8DBF0", VA = "0x184E8E9F0")]
		[IteratorStateMachine(typeof(DJCGHFKPHBH))]
		public IEnumerable<NLFNLBNEHHF> EDFMLLDECMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4E8FAF0", Offset = "0x4E8ECF0", VA = "0x184E8FAF0")]
		public void PAJMOPEHCKL(ILGenerator JKIGFLECKGI, LocalBuilder IEJJEFKGHBB, LocalBuilder GJJDGKNLIGC, LocalBuilder DHDAEDILENC, Action<KeyValuePair<string, int>> BACJIDIJOMD, Action FLLNGCIOJBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4E8EC10", Offset = "0x4E8DE10", VA = "0x184E8EC10")]
		private static void FGAJALCGCPE(ILGenerator JKIGFLECKGI, LocalBuilder IEJJEFKGHBB, LocalBuilder GJJDGKNLIGC, LocalBuilder DHDAEDILENC, Action<KeyValuePair<string, int>> BACJIDIJOMD, Action FLLNGCIOJBA, NLFNLBNEHHF[] AGDLOAPMFIJ, int KOAOGJIGGHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class FBIHFPPIICF : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<NLFNLBNEHHF> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IEnumerable<NLFNLBNEHHF> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEnumerator<NLFNLBNEHHF> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private NLFNLBNEHHF <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x637160", Offset = "0x636360", VA = "0x180637160", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E8BBF0", Offset = "0x4E8ADF0", VA = "0x184E8BBF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2832B90", Offset = "0x2831D90", VA = "0x182832B90")]
		[DebuggerHidden]
		public FBIHFPPIICF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4E8BC40", Offset = "0x4E8AE40", VA = "0x184E8BC40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x4E8B780", Offset = "0x4E8A980", VA = "0x184E8B780", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x4E8BD40", Offset = "0x4E8AF40", VA = "0x184E8BD40")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x4E8BD90", Offset = "0x4E8AF90", VA = "0x184E8BD90")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x4E8BBA0", Offset = "0x4E8ADA0", VA = "0x184E8BBA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x4E8BB00", Offset = "0x4E8AD00", VA = "0x184E8BB00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x4E8BB00", Offset = "0x4E8AD00", VA = "0x184E8BB00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly NLFNLBNEHHF ANEBBMNIFPH;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4E90DE0", Offset = "0x4E8FFE0", VA = "0x184E90DE0")]
	public NONFMEBLNME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4E908A0", Offset = "0x4E8FAA0", VA = "0x184E908A0")]
	public void INLOBDHPAIC(byte[] PKBLLNJJAGK, int PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4E90C40", Offset = "0x4E8FE40", VA = "0x184E90C40")]
	public bool OMBPBJKAFBP(ArraySegment<byte> DHDAEDILENC, out int PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4E90CF0", Offset = "0x4E8FEF0", VA = "0x184E90CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4E909C0", Offset = "0x4E8FBC0", VA = "0x184E909C0")]
	private static void KNFIKPEBCIC(IEnumerable<NLFNLBNEHHF> AGDLOAPMFIJ, StringBuilder BCCHHLIBKMK, int LNPLMCEIBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4E907A0", Offset = "0x4E8F9A0", VA = "0x184E907A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4E907A0", Offset = "0x4E8F9A0", VA = "0x184E907A0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4E90700", Offset = "0x4E8F900", VA = "0x184E90700")]
	[IteratorStateMachine(typeof(FBIHFPPIICF))]
	private static IEnumerable<KeyValuePair<string, int>> ACAPNAKLINF(IEnumerable<NLFNLBNEHHF> AGDLOAPMFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4E90770", Offset = "0x4E8F970", VA = "0x184E90770")]
	public void CKDCDIPBFOA(ILGenerator JKIGFLECKGI, LocalBuilder IEJJEFKGHBB, LocalBuilder GJJDGKNLIGC, LocalBuilder DHDAEDILENC, Action<KeyValuePair<string, int>> BACJIDIJOMD, Action FLLNGCIOJBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class HIHNEBEGJFP
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly MethodInfo GFIIKBBOFIA;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2D77480", Offset = "0x2D76680", VA = "0x182D77480")]
	public static ulong EBJCBHOKMKJ(byte[] PKBLLNJJAGK, ref int CEEEAFDKEEP, ref int GJJDGKNLIGC)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class NALECLICOBI
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x4E8DCE0", Offset = "0x4E8CEE0", VA = "0x184E8DCE0")]
	public static void NGIBFOMCMPB(ref byte[] PKBLLNJJAGK, int CEEEAFDKEEP, int HGCCICMLEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x4E8DBF0", Offset = "0x4E8CDF0", VA = "0x184E8DBF0")]
	public static void JBNKLJHBIBI(ref byte[] IBNOFMOJNKD, int NKMKIPLDEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x4E8DB00", Offset = "0x4E8CD00", VA = "0x184E8DB00")]
	public static byte[] HFHDNEOCJHL(byte[] PGOPEJMDLKB, int NKMKIPLDEBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class PIDOJFCOFCP
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x4E97900", Offset = "0x4E96B00", VA = "0x184E97900")]
	public static bool HNONPHLDFEM(byte[] HDKELKIMMNI, int AEPJIGAICNC, int NIBOHIOJGEM, byte[] IIFOAOLKJEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class EELCLMKDDMB<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct LLNDNMEEDNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public byte[] PKFENIANCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T AMCKDLHOFMB;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x321AA00", Offset = "0x3219C00", VA = "0x18321AA00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class CJLAFKLCKGF : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public global::EELCLMKDDMB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private LLNDNMEEDNP[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private LLNDNMEEDNP[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x145CBE0", Offset = "0x145BDE0", VA = "0x18145CBE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x320C870", Offset = "0x320BA70", VA = "0x18320C870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x17B9E10", Offset = "0x17B9010", VA = "0x1817B9E10")]
		[DebuggerHidden]
		public CJLAFKLCKGF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x320B7B0", Offset = "0x320A9B0", VA = "0x18320B7B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x320C2D0", Offset = "0x320B4D0", VA = "0x18320C2D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly LLNDNMEEDNP[][] GGNFJFOPJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ulong IONKCDOCNDD;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x3212920", Offset = "0x3211B20", VA = "0x183212920")]
	public EELCLMKDDMB(int EICHEFNLNOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x3212860", Offset = "0x3211A60", VA = "0x183212860")]
	public EELCLMKDDMB(int EICHEFNLNOA, float HCCDOPELCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x3211350", Offset = "0x3210550", VA = "0x183211350")]
	public void INLOBDHPAIC(byte[] DHDAEDILENC, T PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3211AE0", Offset = "0x3210CE0", VA = "0x183211AE0")]
	private bool OLGIEKLPJGI(byte[] DHDAEDILENC, T PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3210540", Offset = "0x320F740", VA = "0x183210540")]
	public bool FIDGIGFFKFJ(ArraySegment<byte> DHDAEDILENC, out T PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3212800", Offset = "0x3211A00", VA = "0x183212800")]
	private static ulong PAMLDMNHJCJ(byte[] NJBKHCBPNDB, int CEEEAFDKEEP, int KOAOGJIGGHC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2207C30", Offset = "0x2206E30", VA = "0x182207C30")]
	private static int AKAPAJBMCBH(int NMCOFNHFKEP, float HCCDOPELCKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3210EE0", Offset = "0x32100E0", VA = "0x183210EE0", Slot = "4")]
	[IteratorStateMachine(typeof(global::EELCLMKDDMB<>.CJLAFKLCKGF))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x201CBE0", Offset = "0x201BDE0", VA = "0x18201CBE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class IGKKCCJEMMA : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OpCode[] MHDONPBOPOO;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly OpCode[] FPKLLNDOHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int PHACNFOCHDN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool PKMPGAGCHHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2D7F160", Offset = "0x2D7E360", VA = "0x182D7F160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x2D7F2C0", Offset = "0x2D7E4C0", VA = "0x182D7F2C0")]
	static IGKKCCJEMMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x2D7F510", Offset = "0x2D7E710", VA = "0x182D7F510")]
	public IGKKCCJEMMA(byte[] PHAALBLKKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2D7F1B0", Offset = "0x2D7E3B0", VA = "0x182D7F1B0")]
	public OpCode PEPMDOLCILP()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct FLKOIGMBFPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly Guid AMCKDLHOFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte EJANOLCKINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte KLODIJDEGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte IBGCJIMMJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte DHCPIDLMPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte LFLJOFJKGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte CCPHPDKGEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte NNJJHMIKIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte PMMADGBBEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte BIDJOGGMPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte KFDCDGPJEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte NEJCIKAALGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte HONODAHKMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte IGGBMPKNADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte KLJKBCDMPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte PLDBOLOOIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte ECNIAOAJAHH;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static byte[] EACOAGMCPAN;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static byte[] GDOMKOMGIKG;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x2DBC6E0", Offset = "0x2DBB8E0", VA = "0x182DBC6E0")]
	public FLKOIGMBFPC(ref Guid PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2DBC6F0", Offset = "0x2DBB8F0", VA = "0x182DBC6F0")]
	public FLKOIGMBFPC(ref ArraySegment<byte> PNKAIIODKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2DBC570", Offset = "0x2DBB770", VA = "0x182DBC570")]
	private static byte JFKENGBNECE(byte[] PKBLLNJJAGK, int AIDIPIPCOAD)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2DBB120", Offset = "0x2DBA320", VA = "0x182DBB120")]
	private static byte FHCJDHDFJCL(byte CJCOEBBKILK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2DBB230", Offset = "0x2DBA430", VA = "0x182DBB230")]
	public void HOGGHLHFECL(byte[] AJBILMJPKED, int CEEEAFDKEEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class COONAEMMHAG
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2DB3960", Offset = "0x2DB2B60", VA = "0x182DB3960")]
	public static bool OJECBHGPNGE(byte MGJAENEOBLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2DB2820", Offset = "0x2DB1A20", VA = "0x182DB2820")]
	public static bool IODLCDGDDMK(byte MGJAENEOBLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x2DB3880", Offset = "0x2DB2A80", VA = "0x182DB3880")]
	public static sbyte NNDDJHMIGBK(byte[] PKBLLNJJAGK, int CEEEAFDKEEP, out int CFCBNPJNNBP)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x2DB3810", Offset = "0x2DB2A10", VA = "0x182DB3810")]
	public static short MPMGBMNCAJK(byte[] PKBLLNJJAGK, int CEEEAFDKEEP, out int CFCBNPJNNBP)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2DB2700", Offset = "0x2DB1900", VA = "0x182DB2700")]
	public static int GOCBGBCNADK(byte[] PKBLLNJJAGK, int CEEEAFDKEEP, out int CFCBNPJNNBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x2DB2770", Offset = "0x2DB1970", VA = "0x182DB2770")]
	public static long IJEACMJLAAF(byte[] PKBLLNJJAGK, int CEEEAFDKEEP, out int CFCBNPJNNBP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1DB0", Offset = "0x2DB0FB0", VA = "0x182DB1DB0")]
	public static byte BGIPBIKHNEH(byte[] PKBLLNJJAGK, int CEEEAFDKEEP, out int CFCBNPJNNBP)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x2DB38F0", Offset = "0x2DB2AF0", VA = "0x182DB38F0")]
	public static ushort OBAOBJFNOOO(byte[] PKBLLNJJAGK, int CEEEAFDKEEP, out int CFCBNPJNNBP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2DB2890", Offset = "0x2DB1A90", VA = "0x182DB2890")]
	public static uint KNBHKBLPGKI(byte[] PKBLLNJJAGK, int CEEEAFDKEEP, out int CFCBNPJNNBP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x2DB25F0", Offset = "0x2DB17F0", VA = "0x182DB25F0")]
	public static ulong FAEMIKMCIKH(byte[] PKBLLNJJAGK, int CEEEAFDKEEP, out int CFCBNPJNNBP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x2DB2910", Offset = "0x2DB1B10", VA = "0x182DB2910")]
	public static float KPJPFDAHPBF(byte[] PKBLLNJJAGK, int CEEEAFDKEEP, out int CFCBNPJNNBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x2DB3970", Offset = "0x2DB2B70", VA = "0x182DB3970")]
	public static double OOADHADJDDA(byte[] PKBLLNJJAGK, int CEEEAFDKEEP, out int CFCBNPJNNBP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1E20", Offset = "0x2DB1020", VA = "0x182DB1E20")]
	public static int CLLFINCHJGF(ref byte[] AJBILMJPKED, int CEEEAFDKEEP, ulong PNLMJAPAHBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2DB2BD0", Offset = "0x2DB1DD0", VA = "0x182DB2BD0")]
	public static int MHBBAKFBCPI(ref byte[] AJBILMJPKED, int CEEEAFDKEEP, long PNLMJAPAHBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2DB2980", Offset = "0x2DB1B80", VA = "0x182DB2980")]
	public static bool LAFDKAGPFNA(byte[] PKBLLNJJAGK, int CEEEAFDKEEP, out int CFCBNPJNNBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class ELFBAGPOCHB
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class FFHJENLJLOA : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x9016D0", Offset = "0x9008D0", VA = "0x1809016D0")]
		[DebuggerHidden]
		public FFHJENLJLOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2DB7EC0", Offset = "0x2DB70C0", VA = "0x182DB7EC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2DB7A60", Offset = "0x2DB6C60", VA = "0x182DB7A60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2DB7FE0", Offset = "0x2DB71E0", VA = "0x182DB7FE0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2DB8030", Offset = "0x2DB7230", VA = "0x182DB8030")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2DB7E70", Offset = "0x2DB7070", VA = "0x182DB7E70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x2DB7DC0", Offset = "0x2DB6FC0", VA = "0x182DB7DC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2DB7DC0", Offset = "0x2DB6FC0", VA = "0x182DB7DC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class PNEHFDLAEAH : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x9016D0", Offset = "0x9008D0", VA = "0x1809016D0")]
		[DebuggerHidden]
		public PNEHFDLAEAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2DC5DF0", Offset = "0x2DC4FF0", VA = "0x182DC5DF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2DC5990", Offset = "0x2DC4B90", VA = "0x182DC5990", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2DC5F10", Offset = "0x2DC5110", VA = "0x182DC5F10")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2DC5F60", Offset = "0x2DC5160", VA = "0x182DC5F60")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x2DC5DA0", Offset = "0x2DC4FA0", VA = "0x182DC5DA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2DC5CF0", Offset = "0x2DC4EF0", VA = "0x182DC5CF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2DC5CF0", Offset = "0x2DC4EF0", VA = "0x182DC5CF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5B20", Offset = "0x2DB4D20", VA = "0x182DB5B20")]
	public static bool JDMDFALJLIB(this TypeInfo DEJAEMDNDIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5D50", Offset = "0x2DB4F50", VA = "0x182DB5D50")]
	public static bool PMGPMCKLGFN(this TypeInfo DEJAEMDNDIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5CF0", Offset = "0x2DB4EF0", VA = "0x182DB5CF0")]
	public static IEnumerable<PropertyInfo> NPLAODAFLFN(this Type DEJAEMDNDIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5C60", Offset = "0x2DB4E60", VA = "0x182DB5C60")]
	[IteratorStateMachine(typeof(FFHJENLJLOA))]
	private static IEnumerable<PropertyInfo> NCHJGEBBEOF(Type DEJAEMDNDIC, HashSet<string> GKAPAIAHCFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5AC0", Offset = "0x2DB4CC0", VA = "0x182DB5AC0")]
	public static IEnumerable<FieldInfo> GJKLJHOFBCF(this Type DEJAEMDNDIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5BD0", Offset = "0x2DB4DD0", VA = "0x182DB5BD0")]
	[IteratorStateMachine(typeof(PNEHFDLAEAH))]
	private static IEnumerable<FieldInfo> LAGHKPNMALA(Type DEJAEMDNDIC, HashSet<string> GKAPAIAHCFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class LFKDIMEOONL
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public static readonly Encoding MIDICPBHOPE;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class KINLLJMKPBN
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5BAA20", Offset = "0x5B9C20", VA = "0x1805BAA20")]
	public static string JBNPFDNDGHI(string MAABPLEGKJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2D81010", Offset = "0x2D80210", VA = "0x182D81010")]
	public static string HIGJKDOCPPN(string MAABPLEGKJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2D81120", Offset = "0x2D80320", VA = "0x182D81120")]
	public static string PJLJPNKAJFN(string MAABPLEGKJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class GIFEOMFPNIJ<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class KHIDNECFBDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Type PKFENIANCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public TValue AMCKDLHOFMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int BKPAFEPFGGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public KHIDNECFBDB DFNKBGGDJDF;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x220FDB0", Offset = "0x220EFB0", VA = "0x18220FDB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x220FB50", Offset = "0x220ED50", VA = "0x18220FB50")]
		private int BNNMPMMNNOG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
		public KHIDNECFBDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class OFOFCCJMKHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
		public OFOFCCJMKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x6457F0", Offset = "0x6449F0", VA = "0x1806457F0")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private KHIDNECFBDB[] GGNFJFOPJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int GKFHLIDAILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly object POLIEINDKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly float HCCDOPELCKN;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2209080", Offset = "0x2208280", VA = "0x182209080")]
	public GIFEOMFPNIJ(int EICHEFNLNOA = 4, float HCCDOPELCKN = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2208860", Offset = "0x2207A60", VA = "0x182208860")]
	public bool NCLDJIPBNOB(Type DHDAEDILENC, TValue PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x22087E0", Offset = "0x22079E0", VA = "0x1822087E0")]
	public bool NCLDJIPBNOB(Type DHDAEDILENC, Func<Type, TValue> PCICMAFOEFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2208D80", Offset = "0x2207F80", VA = "0x182208D80")]
	private bool OLGIEKLPJGI(Type DHDAEDILENC, Func<Type, TValue> PCICMAFOEFL, out TValue AIEOFGDNGMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x2208420", Offset = "0x2207620", VA = "0x182208420")]
	private bool MGEMDPAGKGC(KHIDNECFBDB[] GGNFJFOPJPC, Type CFGMKMIKGEE, KHIDNECFBDB GIHJONAJFIL, Func<Type, TValue> PCICMAFOEFL, out TValue AIEOFGDNGMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x2207DB0", Offset = "0x2206FB0", VA = "0x182207DB0")]
	public bool FIDGIGFFKFJ(Type DHDAEDILENC, out TValue PNLMJAPAHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x2207FB0", Offset = "0x22071B0", VA = "0x182207FB0")]
	public TValue FOKGNNDKGPH(Type DHDAEDILENC, Func<Type, TValue> PCICMAFOEFL)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x2207C30", Offset = "0x2206E30", VA = "0x182207C30")]
	private static int AKAPAJBMCBH(int NMCOFNHFKEP, float HCCDOPELCKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x2208050", Offset = "0x2207250", VA = "0x182208050")]
	private static void ILDOGMHIAEM(ref KHIDNECFBDB AIEIIGEMIMC, KHIDNECFBDB PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x2208050", Offset = "0x2207250", VA = "0x182208050")]
	private static void ILDOGMHIAEM(ref KHIDNECFBDB[] AIEIIGEMIMC, KHIDNECFBDB[] PNLMJAPAHBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class OBEHIIJKFIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly AssemblyBuilder LEADBBDMJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ModuleBuilder DNJIMKMOMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly object FNMAOKMJNKE;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x4E90E50", Offset = "0x4E90050", VA = "0x184E90E50")]
	public TypeBuilder HDIJOHJGIOA(string HKLPIGDOLHA, TypeAttributes NAGILHEKADB, Type KJHHLEFOCFM, Type[] FGOCLHPOBCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x4E90F40", Offset = "0x4E90140", VA = "0x184E90F40")]
	public OBEHIIJKFIJ(string CCPOMPGNFKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class MJEFMCHHCKK
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x4E8C1F0", Offset = "0x4E8B3F0", VA = "0x184E8C1F0")]
	private static MethodInfo OMIGIFIMAKM(LambdaExpression HFIOIJHCKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x22AC650", Offset = "0x22AB850", VA = "0x1822AC650")]
	public static MethodInfo BKDGJGEBODB<T>(Expression<Func<T>> HFIOIJHCKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x22AC650", Offset = "0x22AB850", VA = "0x1822AC650")]
	public static MethodInfo BKDGJGEBODB<T, TR>(Expression<Func<T, TR>> HFIOIJHCKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x22AC650", Offset = "0x22AB850", VA = "0x1822AC650")]
	public static MethodInfo BKDGJGEBODB<T>(Expression<Action<T>> HFIOIJHCKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x22AC650", Offset = "0x22AB850", VA = "0x1822AC650")]
	public static MethodInfo BKDGJGEBODB<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> HFIOIJHCKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x22AC6C0", Offset = "0x22AB8C0", VA = "0x1822AC6C0")]
	private static MemberInfo NAEFAIKEMED<T>(Expression<T> FAFGFKFFMLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x22AC660", Offset = "0x22AB860", VA = "0x1822AC660")]
	public static PropertyInfo IDBOBBIDGHF<T, TR>(Expression<Func<T, TR>> HFIOIJHCKHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct AFONKAEHIAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int PNNJEJIELDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool DIHHBHNCFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly ILGenerator JKIGFLECKGI;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x2DADE80", Offset = "0x2DAD080", VA = "0x182DADE80")]
	public AFONKAEHIAF(ILGenerator JKIGFLECKGI, int PNNJEJIELDM, bool DIHHBHNCFBP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x2DADEC0", Offset = "0x2DAD0C0", VA = "0x182DADEC0")]
	public AFONKAEHIAF(ILGenerator JKIGFLECKGI, int PNNJEJIELDM, Type DEJAEMDNDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x2DADE60", Offset = "0x2DAD060", VA = "0x182DADE60")]
	public void JJKCACOGLHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class OEMPFFMNNHH
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x4E921C0", Offset = "0x4E913C0", VA = "0x184E921C0")]
	public static void HMPGKBLHDNF(this ILGenerator JKIGFLECKGI, int PPMIPKENDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x4E92180", Offset = "0x4E91380", VA = "0x184E92180")]
	public static void HMPGKBLHDNF(this ILGenerator JKIGFLECKGI, LocalBuilder AMDFNMPIOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4E91930", Offset = "0x4E90B30", VA = "0x184E91930")]
	public static void DNHLAEBDFMK(this ILGenerator JKIGFLECKGI, int PPMIPKENDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x4E91B60", Offset = "0x4E90D60", VA = "0x184E91B60")]
	public static void DNHLAEBDFMK(this ILGenerator JKIGFLECKGI, LocalBuilder AMDFNMPIOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x4E91E50", Offset = "0x4E91050", VA = "0x184E91E50")]
	public static void GGDEPMCCIJJ(this ILGenerator JKIGFLECKGI, int PPMIPKENDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x4E91D40", Offset = "0x4E90F40", VA = "0x184E91D40")]
	public static void GGDEPMCCIJJ(this ILGenerator JKIGFLECKGI, LocalBuilder AMDFNMPIOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x4E91F40", Offset = "0x4E91140", VA = "0x184E91F40")]
	public static void HGBCFNJJAFJ(this ILGenerator JKIGFLECKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x4E91920", Offset = "0x4E90B20", VA = "0x184E91920")]
	public static void CPCFLMCEIGG(this ILGenerator JKIGFLECKGI, bool PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x4E914D0", Offset = "0x4E906D0", VA = "0x184E914D0")]
	public static void CNIGMJHNPIN(this ILGenerator JKIGFLECKGI, int PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x4E92480", Offset = "0x4E91680", VA = "0x184E92480")]
	public static void LGJKJBEKLIB(this ILGenerator JKIGFLECKGI, Type DEJAEMDNDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x4E91CA0", Offset = "0x4E90EA0", VA = "0x184E91CA0")]
	public static void FFFKEICPPAK(this ILGenerator JKIGFLECKGI, Type DEJAEMDNDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x4E91F50", Offset = "0x4E91150", VA = "0x184E91F50")]
	public static void HILFCEEPNNN(this ILGenerator JKIGFLECKGI, int PPMIPKENDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4E91450", Offset = "0x4E90650", VA = "0x184E91450")]
	public static void CDADJINFJIK(this ILGenerator JKIGFLECKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x4E92600", Offset = "0x4E91800", VA = "0x184E92600")]
	public static void OKPBBBCKKIP(this ILGenerator JKIGFLECKGI, int PPMIPKENDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x4E91BA0", Offset = "0x4E90DA0", VA = "0x184E91BA0")]
	public static void DNKFLDAFBJP(this ILGenerator JKIGFLECKGI, MethodInfo HFNMPBGMDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x4E92570", Offset = "0x4E91770", VA = "0x184E92570")]
	public static void NGGJFDKBDKE(this ILGenerator JKIGFLECKGI, FieldInfo PHHEGBLELEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x4E923F0", Offset = "0x4E915F0", VA = "0x184E923F0")]
	public static void KLFOEOJOPBF(this ILGenerator JKIGFLECKGI, ulong PNLMJAPAHBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class FJEIAANLMDN
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class DCKCEMMMDOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public DCKCEMMMDOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2DB41E0", Offset = "0x2DB33E0", VA = "0x182DB41E0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MethodInfo HKJAGOKFDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MethodInfo LEPEONFJGIN;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string MMPCHPMLKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1C0", Offset = "0x5CB3C0", VA = "0x1805CC1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string LHDFMNPINLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x575980", Offset = "0x574B80", VA = "0x180575980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool GKJLAJEBCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2DB86E0", Offset = "0x2DB78E0", VA = "0x182DB86E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool GGAKDEABLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x5CC100", Offset = "0x5CB300", VA = "0x1805CC100")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x5CC190", Offset = "0x5CB390", VA = "0x1805CC190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool LLPAHPOMIHD
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4C0", Offset = "0x7D96C0", VA = "0x1807DA4C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7DA8A0", Offset = "0x7D9AA0", VA = "0x1807DA8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type KNALKGNJKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5749E0", Offset = "0x573BE0", VA = "0x1805749E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1E0", Offset = "0x5CB3E0", VA = "0x1805CC1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo FBIDFGFHKEN
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x574330", Offset = "0x573530", VA = "0x180574330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x5CC170", Offset = "0x5CB370", VA = "0x1805CC170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo BCFHGFKPOGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x573EE0", Offset = "0x5730E0", VA = "0x180573EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5CC180", Offset = "0x5CB380", VA = "0x1805CC180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo APGEKEBHOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x574F30", Offset = "0x574130", VA = "0x180574F30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x59FA10", Offset = "0x59EC10", VA = "0x18059FA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2DB8A20", Offset = "0x2DB7C20", VA = "0x182DB8A20")]
	protected FJEIAANLMDN(Type DEJAEMDNDIC, string HKLPIGDOLHA, string HPPDHCDAEPO, bool LGOONFKHHGH, bool CJDAFHLNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x2DB8AA0", Offset = "0x2DB7CA0", VA = "0x182DB8AA0")]
	public FJEIAANLMDN(FieldInfo LNOAGBDNLLD, string HKLPIGDOLHA, bool HLPMOGFODKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x2DB8870", Offset = "0x2DB7A70", VA = "0x182DB8870")]
	public FJEIAANLMDN(PropertyInfo LNOAGBDNLLD, string HKLPIGDOLHA, bool HLPMOGFODKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x2DB85C0", Offset = "0x2DB77C0", VA = "0x182DB85C0")]
	private static MethodInfo FAIAGHMFLIM(MemberInfo LNOAGBDNLLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x193B650", Offset = "0x193A850", VA = "0x18193B650")]
	public T BHKOBBHDCAB<T>(bool GIKGKMPMONJ) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x2DB87B0", Offset = "0x2DB79B0", VA = "0x182DB87B0", Slot = "4")]
	public virtual void HNBGICEBMNJ(ILGenerator JKIGFLECKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x2DB86F0", Offset = "0x2DB78F0", VA = "0x182DB86F0", Slot = "5")]
	public virtual void HKGFDHNNJJE(ILGenerator JKIGFLECKGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class HAINDLHNIJK : FJEIAANLMDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly string FHNCKKJKBGG;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x2D753C0", Offset = "0x2D745C0", VA = "0x182D753C0")]
	public HAINDLHNIJK(string HKLPIGDOLHA, string FHNCKKJKBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x2D75300", Offset = "0x2D74500", VA = "0x182D75300", Slot = "4")]
	public override void HNBGICEBMNJ(ILGenerator JKIGFLECKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x2D752B0", Offset = "0x2D744B0", VA = "0x182D752B0", Slot = "5")]
	public override void HKGFDHNNJJE(ILGenerator JKIGFLECKGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class DKPKOEHBCLG : FJEIAANLMDN
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly MethodInfo JLMJCAGAAKK;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MethodInfo KIDFKIDAMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	internal AFONKAEHIAF BKNEENCEAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	internal AFONKAEHIAF GHGNHIJNIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	internal AFONKAEHIAF PEDJJBCGLHE;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x2DB4F30", Offset = "0x2DB4130", VA = "0x182DB4F30")]
	public DKPKOEHBCLG(string HKLPIGDOLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x2DB49D0", Offset = "0x2DB3BD0", VA = "0x182DB49D0", Slot = "4")]
	public override void HNBGICEBMNJ(ILGenerator JKIGFLECKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x2DB4980", Offset = "0x2DB3B80", VA = "0x182DB4980", Slot = "5")]
	public override void HKGFDHNNJJE(ILGenerator JKIGFLECKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x2DB4840", Offset = "0x2DB3A40", VA = "0x182DB4840")]
	public void FCLBFBNAJEC(ILGenerator JKIGFLECKGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class AFIPCINKNCE
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type KNALKGNJKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1C0", Offset = "0x5CB3C0", VA = "0x1805CC1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool NMBHFKDOCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6070A0", Offset = "0x6062A0", VA = "0x1806070A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6070C0", Offset = "0x6062C0", VA = "0x1806070C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool PBMIDMFMMMI
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xACF4B0", Offset = "0xACE6B0", VA = "0x180ACF4B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xD1DD50", Offset = "0xD1CF50", VA = "0x180D1DD50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo BPKLNJBGPMN
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x574E70", Offset = "0x574070", VA = "0x180574E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x576710", Offset = "0x575910", VA = "0x180576710")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public FJEIAANLMDN[] PNLDIAIAGAA
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5749E0", Offset = "0x573BE0", VA = "0x1805749E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1E0", Offset = "0x5CB3E0", VA = "0x1805CC1E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public FJEIAANLMDN[] EBEAMBBCFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x574330", Offset = "0x573530", VA = "0x180574330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x5CC170", Offset = "0x5CB370", VA = "0x1805CC170")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x2DACC40", Offset = "0x2DABE40", VA = "0x182DACC40")]
	public AFIPCINKNCE(Type DEJAEMDNDIC, Func<string, string> AKCDNHGJGEF, bool HLPMOGFODKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x2DACB70", Offset = "0x2DABD70", VA = "0x182DACB70")]
	private static bool GKLDAJOFLMI(IEnumerator<ConstructorInfo> GNPPCCCDCHC, ref ConstructorInfo AJOFCPAKBDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct MJNIMOBCDIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ulong JNDKHLDHKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int BEHJIIABFNP;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2140580", Offset = "0x213F780", VA = "0x182140580")]
	public MJNIMOBCDIF(ulong EGBABIEOOGK, int AKGGPCMAANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x4E8C4F0", Offset = "0x4E8B6F0", VA = "0x184E8C4F0")]
	public void PBPHFMEEGKO(ref MJNIMOBCDIF EBJKBJMLDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x4E8C410", Offset = "0x4E8B610", VA = "0x184E8C410")]
	public static MJNIMOBCDIF IIAONNIDKAG(ref MJNIMOBCDIF JNDOPINGBDA, ref MJNIMOBCDIF CJCOEBBKILK)
	{
		return default(MJNIMOBCDIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x4E8C380", Offset = "0x4E8B580", VA = "0x184E8C380")]
	public void HDJHDLHJADI(ref MJNIMOBCDIF EBJKBJMLDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x4E8C440", Offset = "0x4E8B640", VA = "0x184E8C440")]
	public static MJNIMOBCDIF JFADPBNCIGM(ref MJNIMOBCDIF JNDOPINGBDA, ref MJNIMOBCDIF CJCOEBBKILK)
	{
		return default(MJNIMOBCDIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x4E8C340", Offset = "0x4E8B540", VA = "0x184E8C340")]
	public void GNLCDLJAICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x4E8C2E0", Offset = "0x4E8B4E0", VA = "0x184E8C2E0")]
	public static MJNIMOBCDIF GNLCDLJAICH(ref MJNIMOBCDIF JNDOPINGBDA)
	{
		return default(MJNIMOBCDIF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct DFLJNNDPLMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public byte[] AJBILMJPKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int CEEEAFDKEEP;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6813C0", Offset = "0x6805C0", VA = "0x1806813C0")]
	public DFLJNNDPLMJ(byte[] AJBILMJPKED, int AKHJPGEHPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x2DB43E0", Offset = "0x2DB35E0", VA = "0x182DB43E0")]
	public void LNANCJEJCDD(byte ANPGKNCGDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x2DB4440", Offset = "0x2DB3640", VA = "0x182DB4440")]
	public void MGFAENGENLF(byte[] ANPGKNCGDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x2DB4560", Offset = "0x2DB3760", VA = "0x182DB4560")]
	public void PHGFOOJDIOL(byte[] ANPGKNCGDAM, int NOPNDNKKPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x2DB4600", Offset = "0x2DB3800", VA = "0x182DB4600")]
	public void PHGFOOJDIOL(byte[] ANPGKNCGDAM, int PIDBKIOIGJG, int NOPNDNKKPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x2DB44E0", Offset = "0x2DB36E0", VA = "0x182DB44E0")]
	public void OCBKHNGNPKJ(byte MGJAENEOBLK, int KOAOGJIGGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x2DB42E0", Offset = "0x2DB34E0", VA = "0x182DB42E0")]
	public void CJFKLBHPBIE(string ANPGKNCGDAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class HNKFAAJAELI
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum ALAIFPGNMOO
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum NKCDCJODFCM
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum NFKHALCBCDB
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
	private static byte[] DEIBPMFCCDL;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ThreadStatic]
	private static byte[] DIHLJGHGBPH;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly byte[] OMIBCLDDJED;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly byte[] GDDANLDMHEP;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly NFKHALCBCDB DBJIEEMEGNK;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly char NIJBLMDAIPD;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly int GAPKGLKEFCO;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly int GCCMBBGGMNH;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly uint[] ECFPCJDLHCH;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2D79E70", Offset = "0x2D79070", VA = "0x182D79E70")]
	private static byte[] DGGBMNHCGLM(int GKFHLIDAILA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x2D79F40", Offset = "0x2D79140", VA = "0x182D79F40")]
	private static byte[] DPLMNICNLDN(int GKFHLIDAILA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x2D7A410", Offset = "0x2D79610", VA = "0x182D7A410")]
	public static int FDADHMNHGHO(ref byte[] AJBILMJPKED, int CEEEAFDKEEP, float PNLMJAPAHBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x2D7A520", Offset = "0x2D79720", VA = "0x182D7A520")]
	public static int FDADHMNHGHO(ref byte[] AJBILMJPKED, int CEEEAFDKEEP, double PNLMJAPAHBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2D7A8A0", Offset = "0x2D79AA0", VA = "0x182D7A8A0")]
	private static bool IDDFDKABIAB(byte[] AJBILMJPKED, int NOPNDNKKPCL, ulong NGCLIFBIICD, ulong KMIFICFIOJA, ulong GJJDGKNLIGC, ulong NODACCGFCLC, ulong IBAKHGDGGMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2D7A2F0", Offset = "0x2D794F0", VA = "0x182D7A2F0")]
	private static void EOFEFHPONIA(uint NJOGFEOGPMC, int KELMHCPNNKM, out uint EIJEHPNANDL, out int BIABLJDGNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2D7A9A0", Offset = "0x2D79BA0", VA = "0x182D7A9A0")]
	private static bool ONMECCNHHIM(MJNIMOBCDIF PEFCJDCBGHD, MJNIMOBCDIF BBPCEFEBLNB, MJNIMOBCDIF HGBHIKBJCMG, byte[] AJBILMJPKED, out int NOPNDNKKPCL, out int KNBBONOIOEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x2D7A020", Offset = "0x2D79220", VA = "0x182D7A020")]
	private static bool ECNNIBLLGEA(double HBLIEEAHDEM, ALAIFPGNMOO GNPBHEELLND, byte[] AJBILMJPKED, out int NOPNDNKKPCL, out int PPPBOGGBOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2D7A630", Offset = "0x2D79830", VA = "0x182D7A630")]
	private static bool FKMLACMOHEF(double HBLIEEAHDEM, ALAIFPGNMOO GNPBHEELLND, byte[] AJBILMJPKED, out int NOPNDNKKPCL, out int HNCNIMNEMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2D79500", Offset = "0x2D78700", VA = "0x182D79500")]
	private static bool AJCDDHFMMMG(double PNLMJAPAHBD, ref DFLJNNDPLMJ MJIDLDLPPGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2D79690", Offset = "0x2D78890", VA = "0x182D79690")]
	private static bool AKIJGHOGLKG(double PNLMJAPAHBD, ref DFLJNNDPLMJ MJIDLDLPPGC, NKCDCJODFCM GNPBHEELLND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x2D79CB0", Offset = "0x2D78EB0", VA = "0x182D79CB0")]
	private static void CDCBONKLFKB(byte[] OGILCFMMPNC, int NOPNDNKKPCL, int HNCNIMNEMPK, int GCPLAKJDPBI, ref DFLJNNDPLMJ MJIDLDLPPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2D7ADF0", Offset = "0x2D79FF0", VA = "0x182D7ADF0")]
	private static void PAHAJJJLKNC(byte[] OGILCFMMPNC, int NOPNDNKKPCL, int AKGGPCMAANN, ref DFLJNNDPLMJ MJIDLDLPPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2D7A720", Offset = "0x2D79920", VA = "0x182D7A720")]
	private static bool GNEHOFODJCG(double HBLIEEAHDEM, NKCDCJODFCM GNPBHEELLND, int GEDPICOBPPB, byte[] HCMGEPFEIGJ, out bool MBAMFMBIPNA, out int NOPNDNKKPCL, out int AEDDGIMLFIJ)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct EAMODBHMBBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public double AKJOAFLMJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ulong OEKJDBDECNO;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct CFMFAIGAEMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public float JNDKHLDHKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public uint CMAHODPMGCJ;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct HGGPELOEONI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ulong FJOEKFNJHLL;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2D76C60", Offset = "0x2D75E60", VA = "0x182D76C60")]
	public HGGPELOEONI(double AKJOAFLMJFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2D76C70", Offset = "0x2D75E70", VA = "0x182D76C70")]
	public HGGPELOEONI(MJNIMOBCDIF AKJOAFLMJFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x2D768A0", Offset = "0x2D75AA0", VA = "0x182D768A0")]
	public MJNIMOBCDIF GJLOMKEFAIC()
	{
		return default(MJNIMOBCDIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x2D76BB0", Offset = "0x2D75DB0", VA = "0x182D76BB0")]
	public MJNIMOBCDIF PACMMILNJBM()
	{
		return default(MJNIMOBCDIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6813F0", Offset = "0x6805F0", VA = "0x1806813F0")]
	public ulong PHELDPOANGJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2D76820", Offset = "0x2D75A20", VA = "0x182D76820")]
	public double BHKICPOKBHL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x2D769C0", Offset = "0x2D75BC0", VA = "0x182D769C0")]
	public double IOOHEPBDAHA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x2D76B30", Offset = "0x2D75D30", VA = "0x182D76B30")]
	public int NBPDHJFCGOL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x2D76B80", Offset = "0x2D75D80", VA = "0x182D76B80")]
	public ulong NEDNEJEFKDI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x2D76800", Offset = "0x2D75A00", VA = "0x182D76800")]
	public bool BEKEGNIGLEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2D76B60", Offset = "0x2D75D60", VA = "0x182D76B60")]
	public bool NCPLGCELFJC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x2D76990", Offset = "0x2D75B90", VA = "0x182D76990")]
	public bool IKHDEIHILDK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x2D76A40", Offset = "0x2D75C40", VA = "0x182D76A40")]
	public bool JAHADAIPBLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x2D76970", Offset = "0x2D75B70", VA = "0x182D76970")]
	public int HJKENNEDPGC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x2D76670", Offset = "0x2D75870", VA = "0x182D76670")]
	public void AJCIHOHENEN(out MJNIMOBCDIF PKMLICBLDNO, out MJNIMOBCDIF PCCOOHONPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x2D76920", Offset = "0x2D75B20", VA = "0x182D76920")]
	public bool HEEKIMNGCDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x2D76C50", Offset = "0x2D75E50", VA = "0x182D76C50")]
	public double PNLMJAPAHBD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x2D76A70", Offset = "0x2D75C70", VA = "0x182D76A70")]
	public static int LKEOGPFIFJF(int AHAAJDILDCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x2D76890", Offset = "0x2D75A90", VA = "0x182D76890")]
	public static double FMAFFLBNMDN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x2D76A90", Offset = "0x2D75C90", VA = "0x182D76A90")]
	public static ulong MOBIONCIGBJ(MJNIMOBCDIF AHNCJHFGMAI)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct FAKINEJNOMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private uint CIBOLIEOGHK;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x198F900", Offset = "0x198EB00", VA = "0x18198F900")]
	public FAKINEJNOMA(float JNDKHLDHKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6360", Offset = "0x2DB5560", VA = "0x182DB6360")]
	public MJNIMOBCDIF GJLOMKEFAIC()
	{
		return default(MJNIMOBCDIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x647070", Offset = "0x646270", VA = "0x180647070")]
	public uint DNAACKCEHAI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6410", Offset = "0x2DB5610", VA = "0x182DB6410")]
	public int NBPDHJFCGOL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6430", Offset = "0x2DB5630", VA = "0x182DB6430")]
	public uint NEDNEJEFKDI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6350", Offset = "0x2DB5550", VA = "0x182DB6350")]
	public bool BEKEGNIGLEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2DB61E0", Offset = "0x2DB53E0", VA = "0x182DB61E0")]
	public void AJCIHOHENEN(out MJNIMOBCDIF PKMLICBLDNO, out MJNIMOBCDIF PCCOOHONPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2DB63D0", Offset = "0x2DB55D0", VA = "0x182DB63D0")]
	public bool HEEKIMNGCDC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct MBNMIECFION
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly ulong EGBABIEOOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly short MBGPDJPEMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public readonly short PPPBOGGBOKJ;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2D85E70", Offset = "0x2D85070", VA = "0x182D85E70")]
	public MBNMIECFION(ulong EGBABIEOOGK, short MBGPDJPEMME, short PPPBOGGBOKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class FKIPMMDBAAL
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly MBNMIECFION[] CGCCIBJPHFG;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2DB8E10", Offset = "0x2DB8010", VA = "0x182DB8E10")]
	public static void LKOGDDHMPIO(int FEPOLLFKCJG, int LIKBACLGKCJ, out MJNIMOBCDIF EIJEHPNANDL, out int PPPBOGGBOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x2DB8D10", Offset = "0x2DB7F10", VA = "0x182DB8D10")]
	public static void EKLAICNDDKJ(int LONMGLPEADO, out MJNIMOBCDIF EIJEHPNANDL, out int JFEDLHMGDFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct HNKLEENBKIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly byte[] PKBLLNJJAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly int PIDBKIOIGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly int BBJNDHNCJAJ;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte DABONIHJEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2D7B340", Offset = "0x2D7A540", VA = "0x182D7B340")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x212EC20", Offset = "0x212DE20", VA = "0x18212EC20")]
	public HNKLEENBKIO(byte[] PKBLLNJJAGK, int PIDBKIOIGJG, int NOPNDNKKPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x67BE10", Offset = "0x67B010", VA = "0x18067BE10")]
	public int NOPNDNKKPCL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B2E0", Offset = "0x2D7A4E0", VA = "0x182D7B2E0")]
	public HNKLEENBKIO MMMKCLIHPJB(int JGNEFGLFHDB, int MNDAOBMHGGM)
	{
		return default(HNKLEENBKIO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class GKEDLHIGDMJ
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] BMHAMBLEKAK;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly double[] CGLGAFDBNHD;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly int AINBMEHMJIM;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2D737B0", Offset = "0x2D729B0", VA = "0x182D737B0")]
	private static byte[] ABBFFHGIHGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2D74420", Offset = "0x2D73620", VA = "0x182D74420")]
	private static HNKLEENBKIO CDDJAAGBMLM(HNKLEENBKIO AJBILMJPKED)
	{
		return default(HNKLEENBKIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2D74980", Offset = "0x2D73B80", VA = "0x182D74980")]
	private static HNKLEENBKIO OFEPKBGGLOM(HNKLEENBKIO AJBILMJPKED)
	{
		return default(HNKLEENBKIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2D74B90", Offset = "0x2D73D90", VA = "0x182D74B90")]
	private static void PEKICOEDAJK(HNKLEENBKIO AJBILMJPKED, int AKGGPCMAANN, byte[] AFICBLDGPKD, out int CIMNKKFHPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2D74C40", Offset = "0x2D73E40", VA = "0x182D74C40")]
	private static void POEOIPHEKIC(HNKLEENBKIO AJBILMJPKED, int AKGGPCMAANN, byte[] EFGPAFKBFPJ, int HHMIMADEOMF, out HNKLEENBKIO POBBPHDGJNN, out int EAEPHHDOBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2D74660", Offset = "0x2D73860", VA = "0x182D74660")]
	private static ulong GPMGFNFKEBL(HNKLEENBKIO AJBILMJPKED, out int BMNGBJCILPH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2D74150", Offset = "0x2D73350", VA = "0x182D74150")]
	private static void BICHBDFMAKI(HNKLEENBKIO AJBILMJPKED, out MJNIMOBCDIF HPCDOCAJMAG, out int KLMLEHFABIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2D73D00", Offset = "0x2D72F00", VA = "0x182D73D00")]
	private static bool BHPNMPDGJIK(HNKLEENBKIO POBBPHDGJNN, int AKGGPCMAANN, out double HPCDOCAJMAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2D74500", Offset = "0x2D73700", VA = "0x182D74500")]
	private static MJNIMOBCDIF GGDEHOBBPDO(int AKGGPCMAANN)
	{
		return default(MJNIMOBCDIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2D73890", Offset = "0x2D72A90", VA = "0x182D73890")]
	private static bool AIKNAIHIGJI(HNKLEENBKIO AJBILMJPKED, int AKGGPCMAANN, out double HPCDOCAJMAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2D74A60", Offset = "0x2D73C60", VA = "0x182D74A60")]
	private static bool PDOKDGJPJHA(HNKLEENBKIO POBBPHDGJNN, int AKGGPCMAANN, out double KLANPJPJEOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2D742F0", Offset = "0x2D734F0", VA = "0x182D742F0")]
	public static double? BPNBGAEPNAE(HNKLEENBKIO AJBILMJPKED, int AKGGPCMAANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2D746F0", Offset = "0x2D738F0", VA = "0x182D746F0")]
	public static float? OBEPJBMNKAM(HNKLEENBKIO AJBILMJPKED, int AKGGPCMAANN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct CBMLHDGJDLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private byte[] AJBILMJPKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private int CEEEAFDKEEP;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte AMCKDLHOFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x2DAFD00", Offset = "0x2DAEF00", VA = "0x182DAFD00")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6813C0", Offset = "0x6805C0", VA = "0x1806813C0")]
	public CBMLHDGJDLM(byte[] AJBILMJPKED, int CEEEAFDKEEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2DAFCB0", Offset = "0x2DAEEB0", VA = "0x182DAFCB0")]
	public static CBMLHDGJDLM MMFDPPCHCCH(CBMLHDGJDLM EEGMPMAILGF)
	{
		return default(CBMLHDGJDLM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x2DAFB90", Offset = "0x2DAED90", VA = "0x182DAFB90")]
	public static CBMLHDGJDLM FBGPCCMIGKB(CBMLHDGJDLM EEGMPMAILGF, int NOPNDNKKPCL)
	{
		return default(CBMLHDGJDLM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2DAFC90", Offset = "0x2DAEE90", VA = "0x182DAFC90")]
	public static int KMMIECOBGKO(CBMLHDGJDLM EKPKCLNNFCJ, CBMLHDGJDLM NJJGMIMHBHM)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x2DAFC30", Offset = "0x2DAEE30", VA = "0x182DAFC30")]
	public static bool KGKBOOEBLON(CBMLHDGJDLM EKPKCLNNFCJ, CBMLHDGJDLM NJJGMIMHBHM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2DAFD40", Offset = "0x2DAEF40", VA = "0x182DAFD40")]
	public static bool PLKBPAENLHK(CBMLHDGJDLM EKPKCLNNFCJ, CBMLHDGJDLM NJJGMIMHBHM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x2DAFC50", Offset = "0x2DAEE50", VA = "0x182DAFC50")]
	public static bool KGKBOOEBLON(CBMLHDGJDLM EKPKCLNNFCJ, char NJJGMIMHBHM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2DAFD60", Offset = "0x2DAEF60", VA = "0x182DAFD60")]
	public static bool PLKBPAENLHK(CBMLHDGJDLM EKPKCLNNFCJ, char NJJGMIMHBHM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x2DAFD60", Offset = "0x2DAEF60", VA = "0x182DAFD60")]
	public static bool PLKBPAENLHK(CBMLHDGJDLM EKPKCLNNFCJ, byte NJJGMIMHBHM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2DAFB50", Offset = "0x2DAED50", VA = "0x182DAFB50")]
	public static bool EKIPNOFOGJD(CBMLHDGJDLM EKPKCLNNFCJ, char NJJGMIMHBHM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2DAFBF0", Offset = "0x2DAEDF0", VA = "0x182DAFBF0")]
	public static bool GEFICPFCDID(CBMLHDGJDLM EKPKCLNNFCJ, char NJJGMIMHBHM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x2DAFCC0", Offset = "0x2DAEEC0", VA = "0x182DAFCC0")]
	public static bool OBAFNMMPBIA(CBMLHDGJDLM EKPKCLNNFCJ, char NJJGMIMHBHM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2DAFB10", Offset = "0x2DAED10", VA = "0x182DAFB10")]
	public static bool DNGLHKFBBMN(CBMLHDGJDLM EKPKCLNNFCJ, char NJJGMIMHBHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class OJJNBHBICOO
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] BGNMDELPAGC;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ThreadStatic]
	private static byte[] IPAJCMGGOBO;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly byte[] OMIBCLDDJED;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly byte[] GDDANLDMHEP;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly byte[] JIKLKGPHDGF;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly int PCIFCGHJIBL;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ushort[] LCKKJGGBNCB;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly int FPKLLNHPIGP;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x4E93FB0", Offset = "0x4E931B0", VA = "0x184E93FB0")]
	private static byte[] GOADAECNHJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x4E94210", Offset = "0x4E93410", VA = "0x184E94210")]
	private static byte[] LADGJIGECFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4E94090", Offset = "0x4E93290", VA = "0x184E94090")]
	public static double HPIHPLAKAKG(byte[] AJBILMJPKED, int CEEEAFDKEEP, out int CFCBNPJNNBP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x4E94150", Offset = "0x4E93350", VA = "0x184E94150")]
	public static float IDCKOGCIFIH(byte[] AJBILMJPKED, int CEEEAFDKEEP, out int CFCBNPJNNBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x4E94340", Offset = "0x4E93540", VA = "0x184E94340")]
	private static bool OOBAFNGDAHL(int NJBKHCBPNDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4E944C0", Offset = "0x4E936C0", VA = "0x184E944C0")]
	private static bool PLBENELEIEN(ref CBMLHDGJDLM AFPMECMEOLH, CBMLHDGJDLM BHNHKBKLDOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4E93EA0", Offset = "0x4E930A0", VA = "0x184E93EA0")]
	private static bool FKLOLPDOGEG(ref CBMLHDGJDLM AFPMECMEOLH, CBMLHDGJDLM BHNHKBKLDOH, byte[] FIHAGBNBEKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x4E942F0", Offset = "0x4E934F0", VA = "0x184E942F0")]
	private static bool OFJPNFFPMCH(ref CBMLHDGJDLM HJGJIEHBKJP, byte[] ANPGKNCGDAM, int CEEEAFDKEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x8C7210", Offset = "0x8C6410", VA = "0x1808C7210")]
	private static double PJIJLAJLOJA(bool MBAMFMBIPNA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x4E92D90", Offset = "0x4E91F90", VA = "0x184E92D90")]
	private static double CJNGNKNJAII(CBMLHDGJDLM ABAPFCJBDAA, int NOPNDNKKPCL, bool IGPKMIKBHPN, out int BGJGHDLJMIM)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class GBMHAEKPPFF<T> : global::HPJLNAKDKDD<T[]>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly global::LHGIPJPMKKE<T> HBOEHGBDMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly GBEMDJDJANC ANGCKLHIBFC;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2204F50", Offset = "0x2204150", VA = "0x182204F50")]
	public GBMHAEKPPFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x17B9E10", Offset = "0x17B9010", VA = "0x1817B9E10")]
	public GBMHAEKPPFF(GBEMDJDJANC ANGCKLHIBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2204C60", Offset = "0x2203E60", VA = "0x182204C60", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, T[] PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2202EB0", Offset = "0x22020B0", VA = "0x182202EB0", Slot = "5")]
	public T[] HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class EHMJIFBEPIP<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly global::LHGIPJPMKKE<T> HBOEHGBDMHM;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class NGOJNGHBIAO<T> : global::HPJLNAKDKDD<List<T>>, MFDNLKBHFMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly GBEMDJDJANC ANGCKLHIBFC;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2204F50", Offset = "0x2204150", VA = "0x182204F50")]
	public NGOJNGHBIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x17B9E10", Offset = "0x17B9010", VA = "0x1817B9E10")]
	public NGOJNGHBIAO(GBEMDJDJANC ANGCKLHIBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x34D8710", Offset = "0x34D7910", VA = "0x1834D8710", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, List<T> PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x34D8150", Offset = "0x34D7350", VA = "0x1834D8150", Slot = "5")]
	public List<T> HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class CBOAGCFIGPJ<TElement, TIntermediate, TEnumerator, TCollection> : global::HPJLNAKDKDD<TCollection>, MFDNLKBHFMM where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x247C9C0", Offset = "0x247BBC0", VA = "0x18247C9C0", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, TCollection PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x247BB70", Offset = "0x247AD70", VA = "0x18247BB70", Slot = "5")]
	public TCollection HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator HJKANALBJLF(TCollection FAFGFKFFMLN);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate EJKEJHFJNHJ();

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void INLOBDHPAIC(ref TIntermediate JDCPKKMMBFE, int PPMIPKENDBN, TElement PNLMJAPAHBD);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection BPHKGBFPAIE(ref TIntermediate JJINCIBKKPA);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
	protected CBOAGCFIGPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class AEDHEANKPEB<TElement, TIntermediate, TCollection> : global::CBOAGCFIGPJ<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2019500", Offset = "0x2018700", VA = "0x182019500", Slot = "6")]
	protected override IEnumerator<TElement> HJKANALBJLF(TCollection FAFGFKFFMLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1B32E70", Offset = "0x1B32070", VA = "0x181B32E70")]
	protected AEDHEANKPEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class PDDCGLJEPLH<TElement, TCollection> : global::AEDHEANKPEB<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xEB6D10", Offset = "0xEB5F10", VA = "0x180EB6D10", Slot = "9")]
	protected sealed override TCollection BPHKGBFPAIE(ref TCollection JJINCIBKKPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class MPPIDHPLFCL<TElement, TCollection> : global::PDDCGLJEPLH<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x24F95C0", Offset = "0x24F87C0", VA = "0x1824F95C0", Slot = "7")]
	protected override TCollection EJKEJHFJNHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x24F95E0", Offset = "0x24F87E0", VA = "0x1824F95E0", Slot = "8")]
	protected override void INLOBDHPAIC(ref TCollection JDCPKKMMBFE, int PPMIPKENDBN, TElement PNLMJAPAHBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class HMDMEBIJJIN<T> : global::CBOAGCFIGPJ<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6F30", Offset = "0x1CF6130", VA = "0x181CF6F30", Slot = "8")]
	protected override void INLOBDHPAIC(ref LinkedList<T> JDCPKKMMBFE, int PPMIPKENDBN, T PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xEB6D10", Offset = "0xEB5F10", VA = "0x180EB6D10", Slot = "9")]
	protected override LinkedList<T> BPHKGBFPAIE(ref LinkedList<T> JJINCIBKKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6ED0", Offset = "0x1CF60D0", VA = "0x181CF6ED0", Slot = "7")]
	protected override LinkedList<T> EJKEJHFJNHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x37BAB20", Offset = "0x37B9D20", VA = "0x1837BAB20", Slot = "6")]
	protected override LinkedList<T>.Enumerator HJKANALBJLF(LinkedList<T> FAFGFKFFMLN)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class BCNMCFHNAGO<T> : global::CBOAGCFIGPJ<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6F30", Offset = "0x1CF6130", VA = "0x181CF6F30", Slot = "8")]
	protected override void INLOBDHPAIC(ref Queue<T> JDCPKKMMBFE, int PPMIPKENDBN, T PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6ED0", Offset = "0x1CF60D0", VA = "0x181CF6ED0", Slot = "7")]
	protected override Queue<T> EJKEJHFJNHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x36CB340", Offset = "0x36CA540", VA = "0x1836CB340", Slot = "6")]
	protected override Queue<T>.Enumerator HJKANALBJLF(Queue<T> FAFGFKFFMLN)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0xEB6D10", Offset = "0xEB5F10", VA = "0x180EB6D10", Slot = "9")]
	protected override Queue<T> BPHKGBFPAIE(ref Queue<T> JJINCIBKKPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class KMLLOOKJEAD<T> : global::CBOAGCFIGPJ<T, global::CHKLPHNEILJ<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x1DA58E0", Offset = "0x1DA4AE0", VA = "0x181DA58E0", Slot = "8")]
	protected override void INLOBDHPAIC(ref global::CHKLPHNEILJ<T> JDCPKKMMBFE, int PPMIPKENDBN, T PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5890", Offset = "0x1DA4A90", VA = "0x181DA5890", Slot = "7")]
	protected override global::CHKLPHNEILJ<T> EJKEJHFJNHJ()
	{
		return default(global::CHKLPHNEILJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x36CB340", Offset = "0x36CA540", VA = "0x1836CB340", Slot = "6")]
	protected override Stack<T>.Enumerator HJKANALBJLF(Stack<T> FAFGFKFFMLN)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x36D0230", Offset = "0x36CF430", VA = "0x1836D0230", Slot = "9")]
	protected override Stack<T> BPHKGBFPAIE(ref global::CHKLPHNEILJ<T> JJINCIBKKPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class KKENOHACIOH<T> : global::CBOAGCFIGPJ<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6F30", Offset = "0x1CF6130", VA = "0x181CF6F30", Slot = "8")]
	protected override void INLOBDHPAIC(ref HashSet<T> JDCPKKMMBFE, int PPMIPKENDBN, T PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xEB6D10", Offset = "0xEB5F10", VA = "0x180EB6D10", Slot = "9")]
	protected override HashSet<T> BPHKGBFPAIE(ref HashSet<T> JJINCIBKKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6ED0", Offset = "0x1CF60D0", VA = "0x181CF6ED0", Slot = "7")]
	protected override HashSet<T> EJKEJHFJNHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x36CB340", Offset = "0x36CA540", VA = "0x1836CB340", Slot = "6")]
	protected override HashSet<T>.Enumerator HJKANALBJLF(HashSet<T> FAFGFKFFMLN)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class IELIDBHBOOM<T> : global::AEDHEANKPEB<T, global::CHKLPHNEILJ<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x1DA58E0", Offset = "0x1DA4AE0", VA = "0x181DA58E0", Slot = "8")]
	protected override void INLOBDHPAIC(ref global::CHKLPHNEILJ<T> JDCPKKMMBFE, int PPMIPKENDBN, T PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3F72470", Offset = "0x3F71670", VA = "0x183F72470", Slot = "9")]
	protected override ReadOnlyCollection<T> BPHKGBFPAIE(ref global::CHKLPHNEILJ<T> JJINCIBKKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3F72500", Offset = "0x3F71700", VA = "0x183F72500", Slot = "7")]
	protected override global::CHKLPHNEILJ<T> EJKEJHFJNHJ()
	{
		return default(global::CHKLPHNEILJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class BJODOPGKDMK<T> : global::AEDHEANKPEB<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6F30", Offset = "0x1CF6130", VA = "0x181CF6F30", Slot = "8")]
	protected override void INLOBDHPAIC(ref List<T> JDCPKKMMBFE, int PPMIPKENDBN, T PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6ED0", Offset = "0x1CF60D0", VA = "0x181CF6ED0", Slot = "7")]
	protected override List<T> EJKEJHFJNHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0xEB6D10", Offset = "0xEB5F10", VA = "0x180EB6D10", Slot = "9")]
	protected override IList<T> BPHKGBFPAIE(ref List<T> JJINCIBKKPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class LFDBPMHLFPH<T> : global::AEDHEANKPEB<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6F30", Offset = "0x1CF6130", VA = "0x181CF6F30", Slot = "8")]
	protected override void INLOBDHPAIC(ref List<T> JDCPKKMMBFE, int PPMIPKENDBN, T PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6ED0", Offset = "0x1CF60D0", VA = "0x181CF6ED0", Slot = "7")]
	protected override List<T> EJKEJHFJNHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0xEB6D10", Offset = "0xEB5F10", VA = "0x180EB6D10", Slot = "9")]
	protected override ICollection<T> BPHKGBFPAIE(ref List<T> JJINCIBKKPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class KBNGBAGICDB<T> : global::AEDHEANKPEB<T, global::CHKLPHNEILJ<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x1DA58E0", Offset = "0x1DA4AE0", VA = "0x181DA58E0", Slot = "8")]
	protected override void INLOBDHPAIC(ref global::CHKLPHNEILJ<T> JDCPKKMMBFE, int PPMIPKENDBN, T PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5890", Offset = "0x1DA4A90", VA = "0x181DA5890", Slot = "7")]
	protected override global::CHKLPHNEILJ<T> EJKEJHFJNHJ()
	{
		return default(global::CHKLPHNEILJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5870", Offset = "0x1DA4A70", VA = "0x181DA5870", Slot = "9")]
	protected override IEnumerable<T> BPHKGBFPAIE(ref global::CHKLPHNEILJ<T> JJINCIBKKPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class CBPBCICHNHO<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class PKBMOFFCHAI<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class MIHAAJLGAGE<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class HOMMAMKHABG : global::HPJLNAKDKDD<IEnumerable>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::HPJLNAKDKDD<IEnumerable> MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B500", Offset = "0x2D7A700", VA = "0x182D7B500", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, IEnumerable PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B380", Offset = "0x2D7A580", VA = "0x182D7B380", Slot = "5")]
	public IEnumerable HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public HOMMAMKHABG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class CPAHOHLJEHB : global::HPJLNAKDKDD<ICollection>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public static readonly global::HPJLNAKDKDD<ICollection> MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2DB3B60", Offset = "0x2DB2D60", VA = "0x182DB3B60", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, ICollection PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2DB39E0", Offset = "0x2DB2BE0", VA = "0x182DB39E0", Slot = "5")]
	public ICollection HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public CPAHOHLJEHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class BFNMLLDJEJM : global::HPJLNAKDKDD<IList>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::HPJLNAKDKDD<IList> MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x2DAEC80", Offset = "0x2DADE80", VA = "0x182DAEC80", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, IList PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2DAEB00", Offset = "0x2DADD00", VA = "0x182DAEB00", Slot = "5")]
	public IList HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public BFNMLLDJEJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class EGNHBICEGGE<T> : global::AEDHEANKPEB<T, global::CHKLPHNEILJ<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x370D290", Offset = "0x370C490", VA = "0x18370D290", Slot = "8")]
	protected override void INLOBDHPAIC(ref global::CHKLPHNEILJ<T> JDCPKKMMBFE, int PPMIPKENDBN, T PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5890", Offset = "0x1DA4A90", VA = "0x181DA5890", Slot = "7")]
	protected override global::CHKLPHNEILJ<T> EJKEJHFJNHJ()
	{
		return default(global::CHKLPHNEILJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x370D250", Offset = "0x370C450", VA = "0x18370D250", Slot = "9")]
	protected override IReadOnlyList<T> BPHKGBFPAIE(ref global::CHKLPHNEILJ<T> JJINCIBKKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x17C1BE0", Offset = "0x17C0DE0", VA = "0x1817C1BE0")]
	public EGNHBICEGGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class CNPPOEOIHDH
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1D10", Offset = "0x2DB0F10", VA = "0x182DB1D10")]
	public static DateTime ICAIBAOMJHE(DateTime IBHFHODBACJ)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class FDGLDPDHMMK : global::HPJLNAKDKDD<DateTime>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly global::HPJLNAKDKDD<DateTime> MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x2DB75B0", Offset = "0x2DB67B0", VA = "0x182DB75B0", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, DateTime PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2DB66E0", Offset = "0x2DB58E0", VA = "0x182DB66E0", Slot = "5")]
	public DateTime HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public FDGLDPDHMMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class CEIGEAGNFHC : global::HPJLNAKDKDD<DateTimeOffset>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public static readonly global::HPJLNAKDKDD<DateTimeOffset> MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1260", Offset = "0x2DB0460", VA = "0x182DB1260", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, DateTimeOffset PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2DB0380", Offset = "0x2DAF580", VA = "0x182DB0380", Slot = "5")]
	public DateTimeOffset HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public CEIGEAGNFHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class MKDKIOLPPNN : global::HPJLNAKDKDD<TimeSpan>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::HPJLNAKDKDD<TimeSpan> MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static byte[] GJPLKCNFKDG;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x4E8CF00", Offset = "0x4E8C100", VA = "0x184E8CF00", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, TimeSpan PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x4E8C500", Offset = "0x4E8B700", VA = "0x184E8C500", Slot = "5")]
	public TimeSpan HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public MKDKIOLPPNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class NHOKBBEMDHF<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::HPJLNAKDKDD<TDictionary>, MFDNLKBHFMM where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x34DE490", Offset = "0x34DD690", VA = "0x1834DE490", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, TDictionary PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x34DCCA0", Offset = "0x34DBEA0", VA = "0x1834DCCA0", Slot = "5")]
	public TDictionary HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator HJKANALBJLF(TDictionary FAFGFKFFMLN);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate EJKEJHFJNHJ();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void INLOBDHPAIC(ref TIntermediate JDCPKKMMBFE, int PPMIPKENDBN, TKey DHDAEDILENC, TValue PNLMJAPAHBD);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary BPHKGBFPAIE(ref TIntermediate JJINCIBKKPA);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
	protected NHOKBBEMDHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class EMMIALGNCOJ<TKey, TValue, TIntermediate, TDictionary> : global::NHOKBBEMDHF<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2C40A50", Offset = "0x2C3FC50", VA = "0x182C40A50", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> HJKANALBJLF(TDictionary FAFGFKFFMLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class PPHEKNDEHBG<TKey, TValue, TDictionary> : global::EMMIALGNCOJ<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xEB6D10", Offset = "0xEB5F10", VA = "0x180EB6D10", Slot = "9")]
	protected override TDictionary BPHKGBFPAIE(ref TDictionary JJINCIBKKPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class OHBCJMOJNEA<TKey, TValue> : global::NHOKBBEMDHF<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x4356ED0", Offset = "0x43560D0", VA = "0x184356ED0", Slot = "8")]
	protected override void INLOBDHPAIC(ref Dictionary<TKey, TValue> JDCPKKMMBFE, int PPMIPKENDBN, TKey DHDAEDILENC, TValue PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0xEB6D10", Offset = "0xEB5F10", VA = "0x180EB6D10", Slot = "9")]
	protected override Dictionary<TKey, TValue> BPHKGBFPAIE(ref Dictionary<TKey, TValue> JJINCIBKKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6ED0", Offset = "0x1CF60D0", VA = "0x181CF6ED0", Slot = "7")]
	protected override Dictionary<TKey, TValue> EJKEJHFJNHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x4356E80", Offset = "0x4356080", VA = "0x184356E80", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator HJKANALBJLF(Dictionary<TKey, TValue> FAFGFKFFMLN)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x17C78F0", Offset = "0x17C6AF0", VA = "0x1817C78F0")]
	public OHBCJMOJNEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class PAGKICNDDDB<TKey, TValue, TDictionary> : global::PPHEKNDEHBG<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x3308610", Offset = "0x3307810", VA = "0x183308610", Slot = "8")]
	protected override void INLOBDHPAIC(ref TDictionary JDCPKKMMBFE, int PPMIPKENDBN, TKey DHDAEDILENC, TValue PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x26735E0", Offset = "0x26727E0", VA = "0x1826735E0", Slot = "7")]
	protected override TDictionary EJKEJHFJNHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class EBHKJIGOPME<TKey, TValue> : global::EMMIALGNCOJ<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x36D36E0", Offset = "0x36D28E0", VA = "0x1836D36E0", Slot = "8")]
	protected override void INLOBDHPAIC(ref Dictionary<TKey, TValue> JDCPKKMMBFE, int PPMIPKENDBN, TKey DHDAEDILENC, TValue PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6ED0", Offset = "0x1CF60D0", VA = "0x181CF6ED0", Slot = "7")]
	protected override Dictionary<TKey, TValue> EJKEJHFJNHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0xEB6D10", Offset = "0xEB5F10", VA = "0x180EB6D10", Slot = "9")]
	protected override IDictionary<TKey, TValue> BPHKGBFPAIE(ref Dictionary<TKey, TValue> JJINCIBKKPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class KOKEFJMNBFM<TKey, TValue> : global::PPHEKNDEHBG<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x36D36E0", Offset = "0x36D28E0", VA = "0x1836D36E0", Slot = "8")]
	protected override void INLOBDHPAIC(ref SortedList<TKey, TValue> JDCPKKMMBFE, int PPMIPKENDBN, TKey DHDAEDILENC, TValue PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6ED0", Offset = "0x1CF60D0", VA = "0x181CF6ED0", Slot = "7")]
	protected override SortedList<TKey, TValue> EJKEJHFJNHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class MGNODPPMBPF<TKey, TValue> : global::NHOKBBEMDHF<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x36D36E0", Offset = "0x36D28E0", VA = "0x1836D36E0", Slot = "8")]
	protected override void INLOBDHPAIC(ref SortedDictionary<TKey, TValue> JDCPKKMMBFE, int PPMIPKENDBN, TKey DHDAEDILENC, TValue PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xEB6D10", Offset = "0xEB5F10", VA = "0x180EB6D10", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> BPHKGBFPAIE(ref SortedDictionary<TKey, TValue> JJINCIBKKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6ED0", Offset = "0x1CF60D0", VA = "0x181CF6ED0", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> EJKEJHFJNHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x39EBE00", Offset = "0x39EB000", VA = "0x1839EBE00", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator HJKANALBJLF(SortedDictionary<TKey, TValue> FAFGFKFFMLN)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class BKBJIEEBNIA<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class GEPHCGIBIOD : global::HPJLNAKDKDD<IDictionary>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::HPJLNAKDKDD<IDictionary> MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2DBD330", Offset = "0x2DBC530", VA = "0x182DBD330", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, IDictionary PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x2DBD190", Offset = "0x2DBC390", VA = "0x182DBD190", Slot = "5")]
	public IDictionary HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public GEPHCGIBIOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class KKOCMKFGNEA : global::HPJLNAKDKDD<object>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void FPEBMIABOEJ(object JPNOCJBKHBD, ref IBLFHDPAOJL LNPAFIKAJEA, object PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly global::GIFEOMFPNIJ<KeyValuePair<object, FPEBMIABOEJ>> GGEFJNPMLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly NANOOOKCECO[] ALPKIEMGAAF;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2D820F0", Offset = "0x2D812F0", VA = "0x182D820F0")]
	public KKOCMKFGNEA(params NANOOOKCECO[] ALPKIEMGAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2D818A0", Offset = "0x2D80AA0", VA = "0x182D818A0", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, object PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2D81810", Offset = "0x2D80A10", VA = "0x182D81810", Slot = "5")]
	public object HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class LKHCGICNALJ
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2D84AD0", Offset = "0x2D83CD0", VA = "0x182D84AD0")]
	public static object CBLNBIFLLEJ(Type DEJAEMDNDIC, out bool EJCJDMCMOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2D852B0", Offset = "0x2D844B0", VA = "0x182D852B0")]
	public static object EHOEEEMJLDJ(Type DEJAEMDNDIC, out bool EJCJDMCMOGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class KFLKMJACOAJ<T> : global::HPJLNAKDKDD<T>, MFDNLKBHFMM, global::AGHBCCPLNBJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class ENIOJNOAMAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
		public ENIOJNOAMAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x319DCE0", Offset = "0x319CEE0", VA = "0x18319DCE0")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class MBMENDPNOHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public global::LPJMOEOIKKG<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
		public MBMENDPNOHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x31B0D10", Offset = "0x31AFF10", VA = "0x1831B0D10")]
		internal void <.cctor>b__1(ref IBLFHDPAOJL writer, T value, NANOOOKCECO _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class ODKPPHJLPGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public global::IKKMKJHBCCD<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
		public ODKPPHJLPGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x31B37E0", Offset = "0x31B29E0", VA = "0x1831B37E0")]
		internal T <.cctor>b__2(ref PELPFKDLCGI reader, NANOOOKCECO _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly global::EELCLMKDDMB<T> DJAPPDJNHGP;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly Dictionary<T, string> IFOFOBLEHDO;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static readonly global::LPJMOEOIKKG<T> FEAFFKPFIPN;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly global::IKKMKJHBCCD<T> GLDPOIJBLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly bool JEOLFHINCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly global::LPJMOEOIKKG<T> LFOPMLINMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::IKKMKJHBCCD<T> KHMNPMJGLDC;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x31A9DC0", Offset = "0x31A8FC0", VA = "0x1831A9DC0")]
	static KFLKMJACOAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x31B0340", Offset = "0x31AF540", VA = "0x1831B0340")]
	public KFLKMJACOAJ(bool JEOLFHINCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x31A7DE0", Offset = "0x31A6FE0", VA = "0x1831A7DE0", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, T PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x31A6570", Offset = "0x31A5770", VA = "0x1831A6570", Slot = "5")]
	public T HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x31A7810", Offset = "0x31A6A10", VA = "0x1831A7810", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, T PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x31A8740", Offset = "0x31A7940", VA = "0x1831A8740", Slot = "7")]
	public T PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class PGCMEIHOEPO<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class JHOCOBOLOFE<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class EABNBHCFHAD<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class LAAOLLEKEHD<T> : global::HPJLNAKDKDD<T?>, MFDNLKBHFMM where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x224BC10", Offset = "0x224AE10", VA = "0x18224BC10", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, T? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x224B930", Offset = "0x224AB30", VA = "0x18224B930", Slot = "5")]
	public T? HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
	public LAAOLLEKEHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class PEEIKDHEDDA<T> : global::HPJLNAKDKDD<T?>, MFDNLKBHFMM where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::HPJLNAKDKDD<T> HLLKFEDGMBK;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5640", Offset = "0x1CF4840", VA = "0x181CF5640")]
	public PEEIKDHEDDA(global::HPJLNAKDKDD<T> HLLKFEDGMBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x32296D0", Offset = "0x32288D0", VA = "0x1832296D0", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, T? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3228590", Offset = "0x3227790", VA = "0x183228590", Slot = "5")]
	public T? HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class KJBFEGNHLPI : global::HPJLNAKDKDD<sbyte>, MFDNLKBHFMM, global::AGHBCCPLNBJ<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly KJBFEGNHLPI MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2D813C0", Offset = "0x2D805C0", VA = "0x182D813C0", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, sbyte PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2D812F0", Offset = "0x2D804F0", VA = "0x182D812F0", Slot = "5")]
	public sbyte HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2D81300", Offset = "0x2D80500", VA = "0x182D81300", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, sbyte PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x2D81400", Offset = "0x2D80600", VA = "0x182D81400", Slot = "7")]
	public sbyte PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public KJBFEGNHLPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class NLHJDCCBMGE : global::HPJLNAKDKDD<sbyte?>, MFDNLKBHFMM, global::AGHBCCPLNBJ<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly NLHJDCCBMGE MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FF80", Offset = "0x4E8F180", VA = "0x184E8FF80", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, sbyte? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FE50", Offset = "0x4E8F050", VA = "0x184E8FE50", Slot = "5")]
	public sbyte? HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FF00", Offset = "0x4E8F100", VA = "0x184E8FF00", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, sbyte? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FFF0", Offset = "0x4E8F1F0", VA = "0x184E8FFF0", Slot = "7")]
	public sbyte? PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public NLHJDCCBMGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class INKONDNMLGB : global::HPJLNAKDKDD<sbyte[]>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly INKONDNMLGB MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x2D7FE70", Offset = "0x2D7F070", VA = "0x182D7FE70", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, sbyte[] PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x2D7FD30", Offset = "0x2D7EF30", VA = "0x182D7FD30", Slot = "5")]
	public sbyte[] HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public INKONDNMLGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class JGCMKCBMLEA : global::HPJLNAKDKDD<short>, MFDNLKBHFMM, global::AGHBCCPLNBJ<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly JGCMKCBMLEA MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x2D80300", Offset = "0x2D7F500", VA = "0x182D80300", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, short PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x2D80230", Offset = "0x2D7F430", VA = "0x182D80230", Slot = "5")]
	public short HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x2D80240", Offset = "0x2D7F440", VA = "0x182D80240", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, short PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x2D80340", Offset = "0x2D7F540", VA = "0x182D80340", Slot = "7")]
	public short PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public JGCMKCBMLEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class FBAAGBKMODH : global::HPJLNAKDKDD<short?>, MFDNLKBHFMM, global::AGHBCCPLNBJ<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly FBAAGBKMODH MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6540", Offset = "0x2DB5740", VA = "0x182DB6540", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, short? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6450", Offset = "0x2DB5650", VA = "0x182DB6450", Slot = "5")]
	public short? HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x2DB64C0", Offset = "0x2DB56C0", VA = "0x182DB64C0", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, short? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x2DB65B0", Offset = "0x2DB57B0", VA = "0x182DB65B0", Slot = "7")]
	public short? PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public FBAAGBKMODH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class NGBPEOBBNBN : global::HPJLNAKDKDD<short[]>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly NGBPEOBBNBN MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E760", Offset = "0x4E8D960", VA = "0x184E8E760", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, short[] PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E5C0", Offset = "0x4E8D7C0", VA = "0x184E8E5C0", Slot = "5")]
	public short[] HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public NGBPEOBBNBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class MNGDKEKEGBP : global::HPJLNAKDKDD<int>, MFDNLKBHFMM, global::AGHBCCPLNBJ<int>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly MNGDKEKEGBP MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D400", Offset = "0x4E8C600", VA = "0x184E8D400", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, int PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D360", Offset = "0x4E8C560", VA = "0x184E8D360", Slot = "5")]
	public int HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D3C0", Offset = "0x4E8C5C0", VA = "0x184E8D3C0", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, int PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D410", Offset = "0x4E8C610", VA = "0x184E8D410", Slot = "7")]
	public int PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public MNGDKEKEGBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class BLLAMHPHGLA : global::HPJLNAKDKDD<int?>, MFDNLKBHFMM, global::AGHBCCPLNBJ<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly BLLAMHPHGLA MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF970", Offset = "0x2DAEB70", VA = "0x182DAF970", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, int? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF880", Offset = "0x2DAEA80", VA = "0x182DAF880", Slot = "5")]
	public int? HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF8F0", Offset = "0x2DAEAF0", VA = "0x182DAF8F0", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, int? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF9E0", Offset = "0x2DAEBE0", VA = "0x182DAF9E0", Slot = "7")]
	public int? PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public BLLAMHPHGLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class INGGABLAMME : global::HPJLNAKDKDD<int[]>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly INGGABLAMME MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2D7FB30", Offset = "0x2D7ED30", VA = "0x182D7FB30", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, int[] PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2D7F9F0", Offset = "0x2D7EBF0", VA = "0x182D7F9F0", Slot = "5")]
	public int[] HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public INGGABLAMME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class BHEIAAKIDKE : global::HPJLNAKDKDD<long>, MFDNLKBHFMM, global::AGHBCCPLNBJ<long>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly BHEIAAKIDKE MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x2DAEFD0", Offset = "0x2DAE1D0", VA = "0x182DAEFD0", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, long PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2DAEF80", Offset = "0x2DAE180", VA = "0x182DAEF80", Slot = "5")]
	public long HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2DAEF90", Offset = "0x2DAE190", VA = "0x182DAEF90", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, long PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x2DAEFF0", Offset = "0x2DAE1F0", VA = "0x182DAEFF0", Slot = "7")]
	public long PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public BHEIAAKIDKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class FJCGDJLHGGC : global::HPJLNAKDKDD<long?>, MFDNLKBHFMM, global::AGHBCCPLNBJ<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly FJCGDJLHGGC MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x2DB8430", Offset = "0x2DB7630", VA = "0x182DB8430", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, long? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x2DB8320", Offset = "0x2DB7520", VA = "0x182DB8320", Slot = "5")]
	public long? HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2DB83B0", Offset = "0x2DB75B0", VA = "0x182DB83B0", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, long? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2DB84A0", Offset = "0x2DB76A0", VA = "0x182DB84A0", Slot = "7")]
	public long? PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public FJCGDJLHGGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class KKDLNNMMPLN : global::HPJLNAKDKDD<long[]>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly KKDLNNMMPLN MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D81610", Offset = "0x2D80810", VA = "0x182D81610", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, long[] PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2D814D0", Offset = "0x2D806D0", VA = "0x182D814D0", Slot = "5")]
	public long[] HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public KKDLNNMMPLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class CJKNHBDNLAG : global::HPJLNAKDKDD<byte>, MFDNLKBHFMM, global::AGHBCCPLNBJ<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly CJKNHBDNLAG MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x2DB16E0", Offset = "0x2DB08E0", VA = "0x182DB16E0", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, byte PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1690", Offset = "0x2DB0890", VA = "0x182DB1690", Slot = "5")]
	public byte HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x2DB16A0", Offset = "0x2DB08A0", VA = "0x182DB16A0", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, byte PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1700", Offset = "0x2DB0900", VA = "0x182DB1700", Slot = "7")]
	public byte PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public CJKNHBDNLAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class AKNNMKMJLFO : global::HPJLNAKDKDD<byte?>, MFDNLKBHFMM, global::AGHBCCPLNBJ<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly AKNNMKMJLFO MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE130", Offset = "0x2DAD330", VA = "0x182DAE130", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, byte? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE040", Offset = "0x2DAD240", VA = "0x182DAE040", Slot = "5")]
	public byte? HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE0B0", Offset = "0x2DAD2B0", VA = "0x182DAE0B0", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, byte? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE1A0", Offset = "0x2DAD3A0", VA = "0x182DAE1A0", Slot = "7")]
	public byte? PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public AKNNMKMJLFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class NNIFAKGHNIJ : global::HPJLNAKDKDD<ushort>, MFDNLKBHFMM, global::AGHBCCPLNBJ<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly NNIFAKGHNIJ MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x4E90370", Offset = "0x4E8F570", VA = "0x184E90370", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, ushort PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x4E902D0", Offset = "0x4E8F4D0", VA = "0x184E902D0", Slot = "5")]
	public ushort HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x4E90330", Offset = "0x4E8F530", VA = "0x184E90330", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, ushort PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x4E90390", Offset = "0x4E8F590", VA = "0x184E90390", Slot = "7")]
	public ushort PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public NNIFAKGHNIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class PACPJFEMNBM : global::HPJLNAKDKDD<ushort?>, MFDNLKBHFMM, global::AGHBCCPLNBJ<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly PACPJFEMNBM MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x4E94B30", Offset = "0x4E93D30", VA = "0x184E94B30", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, ushort? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x4E94A00", Offset = "0x4E93C00", VA = "0x184E94A00", Slot = "5")]
	public ushort? HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x4E94AB0", Offset = "0x4E93CB0", VA = "0x184E94AB0", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, ushort? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x4E94BA0", Offset = "0x4E93DA0", VA = "0x184E94BA0", Slot = "7")]
	public ushort? PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public PACPJFEMNBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class MPGKKEBEGHC : global::HPJLNAKDKDD<ushort[]>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly MPGKKEBEGHC MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D680", Offset = "0x4E8C880", VA = "0x184E8D680", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, ushort[] PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D4E0", Offset = "0x4E8C6E0", VA = "0x184E8D4E0", Slot = "5")]
	public ushort[] HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public MPGKKEBEGHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class ACLPCBAEJIG : global::HPJLNAKDKDD<uint>, MFDNLKBHFMM, global::AGHBCCPLNBJ<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly ACLPCBAEJIG MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2DAC040", Offset = "0x2DAB240", VA = "0x182DAC040", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, uint PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2DABFF0", Offset = "0x2DAB1F0", VA = "0x182DABFF0", Slot = "5")]
	public uint HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2DAC000", Offset = "0x2DAB200", VA = "0x182DAC000", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, uint PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2DAC050", Offset = "0x2DAB250", VA = "0x182DAC050", Slot = "7")]
	public uint PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public ACLPCBAEJIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class BJMKODMCIAL : global::HPJLNAKDKDD<uint?>, MFDNLKBHFMM, global::AGHBCCPLNBJ<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly BJMKODMCIAL MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF6D0", Offset = "0x2DAE8D0", VA = "0x182DAF6D0", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, uint? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF5E0", Offset = "0x2DAE7E0", VA = "0x182DAF5E0", Slot = "5")]
	public uint? HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF650", Offset = "0x2DAE850", VA = "0x182DAF650", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, uint? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF740", Offset = "0x2DAE940", VA = "0x182DAF740", Slot = "7")]
	public uint? PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public BJMKODMCIAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class FLAFGPEKFDB : global::HPJLNAKDKDD<uint[]>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly FLAFGPEKFDB MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2DBB000", Offset = "0x2DBA200", VA = "0x182DBB000", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, uint[] PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2DBAEC0", Offset = "0x2DBA0C0", VA = "0x182DBAEC0", Slot = "5")]
	public uint[] HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public FLAFGPEKFDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class BIHNHEMMBFA : global::HPJLNAKDKDD<ulong>, MFDNLKBHFMM, global::AGHBCCPLNBJ<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly BIHNHEMMBFA MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF4F0", Offset = "0x2DAE6F0", VA = "0x182DAF4F0", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, ulong PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF4A0", Offset = "0x2DAE6A0", VA = "0x182DAF4A0", Slot = "5")]
	public ulong HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF4B0", Offset = "0x2DAE6B0", VA = "0x182DAF4B0", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, ulong PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF510", Offset = "0x2DAE710", VA = "0x182DAF510", Slot = "7")]
	public ulong PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public BIHNHEMMBFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class EOIIGIFJHFH : global::HPJLNAKDKDD<ulong?>, MFDNLKBHFMM, global::AGHBCCPLNBJ<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly EOIIGIFJHFH MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6050", Offset = "0x2DB5250", VA = "0x182DB6050", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, ulong? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5F40", Offset = "0x2DB5140", VA = "0x182DB5F40", Slot = "5")]
	public ulong? HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5FD0", Offset = "0x2DB51D0", VA = "0x182DB5FD0", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, ulong? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x2DB60C0", Offset = "0x2DB52C0", VA = "0x182DB60C0", Slot = "7")]
	public ulong? PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public EOIIGIFJHFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class HIAGKKKDLHO : global::HPJLNAKDKDD<ulong[]>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly HIAGKKKDLHO MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2D77280", Offset = "0x2D76480", VA = "0x182D77280", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, ulong[] PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2D77140", Offset = "0x2D76340", VA = "0x182D77140", Slot = "5")]
	public ulong[] HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public HIAGKKKDLHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class ABMPIIPKIFO : global::HPJLNAKDKDD<float>, MFDNLKBHFMM, global::AGHBCCPLNBJ<float>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly ABMPIIPKIFO MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x2DABEE0", Offset = "0x2DAB0E0", VA = "0x182DABEE0", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, float PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x2DABE90", Offset = "0x2DAB090", VA = "0x182DABE90", Slot = "5")]
	public float HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x2DABEA0", Offset = "0x2DAB0A0", VA = "0x182DABEA0", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, float PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x2DABEF0", Offset = "0x2DAB0F0", VA = "0x182DABEF0", Slot = "7")]
	public float PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public ABMPIIPKIFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class FHKNIMGJAOL : global::HPJLNAKDKDD<float?>, MFDNLKBHFMM, global::AGHBCCPLNBJ<float?>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly FHKNIMGJAOL MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x2DB8170", Offset = "0x2DB7370", VA = "0x182DB8170", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, float? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x2DB8080", Offset = "0x2DB7280", VA = "0x182DB8080", Slot = "5")]
	public float? HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x2DB80F0", Offset = "0x2DB72F0", VA = "0x182DB80F0", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, float? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x2DB81E0", Offset = "0x2DB73E0", VA = "0x182DB81E0", Slot = "7")]
	public float? PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public FHKNIMGJAOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class IKOBFHFJFNF : global::HPJLNAKDKDD<float[]>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly IKOBFHFJFNF MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x2D7F810", Offset = "0x2D7EA10", VA = "0x182D7F810", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, float[] PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x2D7F6D0", Offset = "0x2D7E8D0", VA = "0x182D7F6D0", Slot = "5")]
	public float[] HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public IKOBFHFJFNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class FKCGAGNPFOO : global::HPJLNAKDKDD<double>, MFDNLKBHFMM, global::AGHBCCPLNBJ<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly FKCGAGNPFOO MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x2DB8C00", Offset = "0x2DB7E00", VA = "0x182DB8C00", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, double PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x2DB8BB0", Offset = "0x2DB7DB0", VA = "0x182DB8BB0", Slot = "5")]
	public double HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x2DB8BC0", Offset = "0x2DB7DC0", VA = "0x182DB8BC0", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, double PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x2DB8C10", Offset = "0x2DB7E10", VA = "0x182DB8C10", Slot = "7")]
	public double PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public FKCGAGNPFOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class NNKHNJBOLFB : global::HPJLNAKDKDD<double?>, MFDNLKBHFMM, global::AGHBCCPLNBJ<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly NNKHNJBOLFB MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x4E90570", Offset = "0x4E8F770", VA = "0x184E90570", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, double? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x4E90460", Offset = "0x4E8F660", VA = "0x184E90460", Slot = "5")]
	public double? HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x4E904F0", Offset = "0x4E8F6F0", VA = "0x184E904F0", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, double? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x4E905E0", Offset = "0x4E8F7E0", VA = "0x184E905E0", Slot = "7")]
	public double? PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public NNKHNJBOLFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class HHABFOBLHND : global::HPJLNAKDKDD<double[]>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly HHABFOBLHND MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2D76F00", Offset = "0x2D76100", VA = "0x182D76F00", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, double[] PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2D76DC0", Offset = "0x2D75FC0", VA = "0x182D76DC0", Slot = "5")]
	public double[] HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public HHABFOBLHND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class LNIICPEBLDP : global::HPJLNAKDKDD<bool>, MFDNLKBHFMM, global::AGHBCCPLNBJ<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly LNIICPEBLDP MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2D85C90", Offset = "0x2D84E90", VA = "0x182D85C90", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, bool PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2D85BD0", Offset = "0x2D84DD0", VA = "0x182D85BD0", Slot = "5")]
	public bool HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2D85BE0", Offset = "0x2D84DE0", VA = "0x182D85BE0", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, bool PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2D85CB0", Offset = "0x2D84EB0", VA = "0x182D85CB0", Slot = "7")]
	public bool PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public LNIICPEBLDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class FNMOGEJINKI : global::HPJLNAKDKDD<bool?>, MFDNLKBHFMM, global::AGHBCCPLNBJ<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly FNMOGEJINKI MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x2DBCE90", Offset = "0x2DBC090", VA = "0x182DBCE90", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, bool? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x2DBCDA0", Offset = "0x2DBBFA0", VA = "0x182DBCDA0", Slot = "5")]
	public bool? HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2DBCE10", Offset = "0x2DBC010", VA = "0x182DBCE10", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, bool? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2DBCF00", Offset = "0x2DBC100", VA = "0x182DBCF00", Slot = "7")]
	public bool? PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public FNMOGEJINKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class OBNNBCHKEMC : global::HPJLNAKDKDD<bool[]>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly OBNNBCHKEMC MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x4E911E0", Offset = "0x4E903E0", VA = "0x184E911E0", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, bool[] PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x4E91040", Offset = "0x4E90240", VA = "0x184E91040", Slot = "5")]
	public bool[] HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public OBNNBCHKEMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class HCKNGDKOFAA : global::HPJLNAKDKDD<object>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly global::HPJLNAKDKDD<object> MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly Dictionary<Type, int> KFMEODMGBJD;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2D75790", Offset = "0x2D74990", VA = "0x182D75790", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, object PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2D754F0", Offset = "0x2D746F0", VA = "0x182D754F0", Slot = "5")]
	public object HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public HCKNGDKOFAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class NADJIGPAEBK : global::HPJLNAKDKDD<byte[]>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly global::HPJLNAKDKDD<byte[]> MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D820", Offset = "0x4E8CA20", VA = "0x184E8D820", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, byte[] PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D7A0", Offset = "0x4E8C9A0", VA = "0x184E8D7A0", Slot = "5")]
	public byte[] HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public NADJIGPAEBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class HDABHGJLPOO : global::HPJLNAKDKDD<ArraySegment<byte>>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly global::HPJLNAKDKDD<ArraySegment<byte>> MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2D76570", Offset = "0x2D75770", VA = "0x182D76570", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, ArraySegment<byte> PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2D764A0", Offset = "0x2D756A0", VA = "0x182D764A0", Slot = "5")]
	public ArraySegment<byte> HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public HDABHGJLPOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class GCFEKNLPKEL : global::HPJLNAKDKDD<string>, MFDNLKBHFMM, global::AGHBCCPLNBJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::HPJLNAKDKDD<string> MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2DBD110", Offset = "0x2DBC310", VA = "0x182DBD110", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, string PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2DBD100", Offset = "0x2DBC300", VA = "0x182DBD100", Slot = "5")]
	public string HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2DBD110", Offset = "0x2DBC310", VA = "0x182DBD110", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, string PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2DBD100", Offset = "0x2DBC300", VA = "0x182DBD100", Slot = "7")]
	public string PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public GCFEKNLPKEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class NEGCNIDBELO : global::HPJLNAKDKDD<string[]>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly NEGCNIDBELO MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E4A0", Offset = "0x4E8D6A0", VA = "0x184E8E4A0", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, string[] PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x4E8E300", Offset = "0x4E8D500", VA = "0x184E8E300", Slot = "5")]
	public string[] HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public NEGCNIDBELO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class JDFAFCBIHKF : global::HPJLNAKDKDD<char>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly JDFAFCBIHKF MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x2D80150", Offset = "0x2D7F350", VA = "0x182D80150", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, char PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2D80120", Offset = "0x2D7F320", VA = "0x182D80120", Slot = "5")]
	public char HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public JDFAFCBIHKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class NAFHIJHIDCD : global::HPJLNAKDKDD<char?>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly NAFHIJHIDCD MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D9D0", Offset = "0x4E8CBD0", VA = "0x184E8D9D0", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, char? PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D910", Offset = "0x4E8CB10", VA = "0x184E8D910", Slot = "5")]
	public char? HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public NAFHIJHIDCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class DAIDDELHIHE : global::HPJLNAKDKDD<char[]>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly DAIDDELHIHE MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x2DB4000", Offset = "0x2DB3200", VA = "0x182DB4000", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, char[] PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x2DB3E60", Offset = "0x2DB3060", VA = "0x182DB3E60", Slot = "5")]
	public char[] HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public DAIDDELHIHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class DLJAOKICIOK : global::HPJLNAKDKDD<Guid>, MFDNLKBHFMM, global::AGHBCCPLNBJ<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::HPJLNAKDKDD<Guid> MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5030", Offset = "0x2DB4230", VA = "0x182DB5030", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, Guid PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x2DB4FE0", Offset = "0x2DB41E0", VA = "0x182DB4FE0", Slot = "5")]
	public Guid HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x2DB5030", Offset = "0x2DB4230", VA = "0x182DB5030", Slot = "6")]
	public void LDDNPDCBCGF(ref IBLFHDPAOJL LNPAFIKAJEA, Guid PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x2DB50D0", Offset = "0x2DB42D0", VA = "0x182DB50D0", Slot = "7")]
	public Guid PFAINIKCLIL(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public DLJAOKICIOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class LHOOOMHNKAL : global::HPJLNAKDKDD<decimal>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::HPJLNAKDKDD<decimal> MLLBELOGAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly bool BKMNDCEGGDB;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x7F0160", Offset = "0x7EF360", VA = "0x1807F0160")]
	public LHOOOMHNKAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0xF09D90", Offset = "0xF08F90", VA = "0x180F09D90")]
	public LHOOOMHNKAL(bool BKMNDCEGGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x2D84900", Offset = "0x2D83B00", VA = "0x182D84900", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, decimal PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x2D84750", Offset = "0x2D83950", VA = "0x182D84750", Slot = "5")]
	public decimal HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class CLFNNOMAECH : global::HPJLNAKDKDD<Uri>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly global::HPJLNAKDKDD<Uri> MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x2DB18E0", Offset = "0x2DB0AE0", VA = "0x182DB18E0", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, Uri PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1860", Offset = "0x2DB0A60", VA = "0x182DB1860", Slot = "5")]
	public Uri HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public CLFNNOMAECH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class DJFCMENPNFE : global::HPJLNAKDKDD<Version>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly global::HPJLNAKDKDD<Version> MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x2DB4730", Offset = "0x2DB3930", VA = "0x182DB4730", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, Version PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x2DB46B0", Offset = "0x2DB38B0", VA = "0x182DB46B0", Slot = "5")]
	public Version HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public DJFCMENPNFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class DLBNFFDCPHF<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class KFHCCBKKKMI : global::HPJLNAKDKDD<StringBuilder>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::HPJLNAKDKDD<StringBuilder> MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x2D808B0", Offset = "0x2D7FAB0", VA = "0x182D808B0", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, StringBuilder PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x2D80830", Offset = "0x2D7FA30", VA = "0x182D80830", Slot = "5")]
	public StringBuilder HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public KFHCCBKKKMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class HABEAKKPLIB : global::HPJLNAKDKDD<BitArray>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::HPJLNAKDKDD<BitArray> MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x2D75150", Offset = "0x2D74350", VA = "0x182D75150", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, BitArray PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x2D75050", Offset = "0x2D74250", VA = "0x182D75050", Slot = "5")]
	public BitArray HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public HABEAKKPLIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class CMLHJALEBJG : global::HPJLNAKDKDD<Type>, MFDNLKBHFMM
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly CMLHJALEBJG MLLBELOGAMP;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly Regex NFHDAKBJLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool NDLMJJDJCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool HDMIFGGEPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private bool AGBPOENKILI;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1CF0", Offset = "0x2DB0EF0", VA = "0x182DB1CF0")]
	public CMLHJALEBJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1CA0", Offset = "0x2DB0EA0", VA = "0x182DB1CA0")]
	public CMLHJALEBJG(bool NDLMJJDJCIA, bool HDMIFGGEPBF, bool AGBPOENKILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1B10", Offset = "0x2DB0D10", VA = "0x182DB1B10", Slot = "4")]
	public void MNIJLJLODBL(ref IBLFHDPAOJL LNPAFIKAJEA, Type PNLMJAPAHBD, NANOOOKCECO KEOMJFPOAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x2DB19F0", Offset = "0x2DB0BF0", VA = "0x182DB19F0", Slot = "5")]
	public Type HMOLPLGFINA(ref PELPFKDLCGI AGJPFNIFDJG, NANOOOKCECO KEOMJFPOAJF)
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
