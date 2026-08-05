using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OGIDOOLIEGA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJNKBIHCNDA(LPHAAGNHOAH MKIOBJMIBCN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ONLENKPGCBM(BDLPMJHFHLL IOJEJAFBOHN);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void GJBNPCAEDCF<T>(LPHAAGNHOAH MKIOBJMIBCN, T EOHMJBFGDPD) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate T GIAAJBNLCFD<T>(BDLPMJHFHLL IOJEJAFBOHN) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ICEIHEDOEJN
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public ref struct BDLPMJHFHLL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate BDLPMJHFHLL EBGKMFDCGKI(BDLPMJHFHLL GCLEDKPLBKL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal readonly ReadOnlySpan<byte> GHFAAPNAFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal readonly EBGKMFDCGKI CNHEEJPFOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal int MOLHPCKEOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal int BCPFCDOBMEI;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5C71F90", Offset = "0x5C71390", VA = "0x185C71F90")]
	public BDLPMJHFHLL(ReadOnlySpan<byte> GHFAAPNAFDE, int MOLHPCKEOPH = 0, int BCPFCDOBMEI = 0, [Optional] EBGKMFDCGKI CNHEEJPFOAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HAHLOAJFCGN
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x23A4740", Offset = "0x23A3B40", VA = "0x1823A4740")]
	public static T OEAJMABMJDL<T>(this BDLPMJHFHLL IOJEJAFBOHN) where T : struct, OGIDOOLIEGA
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5C73E90", Offset = "0x5C73290", VA = "0x185C73E90")]
	public static bool ONEFKOCABGK(this BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5C73C60", Offset = "0x5C73060", VA = "0x185C73C60")]
	public static byte HJHAPDLAEBE(this BDLPMJHFHLL GCLEDKPLBKL, byte CJDNODDJLGJ, byte MHLKGFHCBMF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5C73A60", Offset = "0x5C72E60", VA = "0x185C73A60")]
	public static sbyte FLDGDMJICDB(this BDLPMJHFHLL GCLEDKPLBKL, sbyte CJDNODDJLGJ, sbyte MHLKGFHCBMF)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5C73BC0", Offset = "0x5C72FC0", VA = "0x185C73BC0")]
	public static ushort FOEKBGIBCGL(this BDLPMJHFHLL GCLEDKPLBKL, ushort CJDNODDJLGJ, ushort MHLKGFHCBMF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5C738F0", Offset = "0x5C72CF0", VA = "0x185C738F0")]
	public static short COGNJLGJIIF(this BDLPMJHFHLL GCLEDKPLBKL, short CJDNODDJLGJ, short MHLKGFHCBMF)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5C73830", Offset = "0x5C72C30", VA = "0x185C73830")]
	public static uint BEEHDHFEHHD(this BDLPMJHFHLL GCLEDKPLBKL, uint CJDNODDJLGJ, uint MHLKGFHCBMF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5C737C0", Offset = "0x5C72BC0", VA = "0x185C737C0")]
	public static int ALKBBLLANNF(this BDLPMJHFHLL GCLEDKPLBKL, int CJDNODDJLGJ, int MHLKGFHCBMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5C73B00", Offset = "0x5C72F00", VA = "0x185C73B00")]
	public static int FLMEDFBIECE(this BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5C73D00", Offset = "0x5C73100", VA = "0x185C73D00")]
	public static long IAIDEMADOKO(this BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5C73DA0", Offset = "0x5C731A0", VA = "0x185C73DA0")]
	public static uint KHJNPOJCAOB(this BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5C738A0", Offset = "0x5C72CA0", VA = "0x185C738A0")]
	public static ulong CNEGPDEEJHL(this BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5C73D90", Offset = "0x5C73190", VA = "0x185C73D90")]
	public static float IIAAONBDPDK(this BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5C73990", Offset = "0x5C72D90", VA = "0x185C73990")]
	public static double EIIFBJLJIIO(this BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5C73E20", Offset = "0x5C73220", VA = "0x185C73E20")]
	public static float3 MLOBOECLODH(this BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MGNBHIGAEMB
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class NNIFHCHFBCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5C749F0", Offset = "0x5C73DF0", VA = "0x185C749F0")]
	public static void KMHGBHDFLLK(this LPHAAGNHOAH MKIOBJMIBCN, uint BAKECOOKLAC, bool NJAGPAGOICO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5C74B90", Offset = "0x5C73F90", VA = "0x185C74B90")]
	public static uint PHDOABJBHFJ(this BDLPMJHFHLL IOJEJAFBOHN, bool NJAGPAGOICO = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class KNMKPNMMIAG
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private struct MIDGGJHLNNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public uint FINJHMOLCJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public uint DNADNJCNAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public double IEMMJLAMEKD;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5C73990", Offset = "0x5C72D90", VA = "0x185C73990")]
	public static double EIIFBJLJIIO(BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C74890", Offset = "0x5C73C90", VA = "0x185C74890")]
	public static void MLCDICGHAEA(double EOHMJBFGDPD, LPHAAGNHOAH GCLEDKPLBKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class AIBKGGGCFOD
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class CANKCDJLFAE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public CANKCDJLFAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4A98DB0", Offset = "0x4A981B0", VA = "0x184A98DB0")]
		internal void MOIIHJKMIHF(LPHAAGNHOAH b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4A98D80", Offset = "0x4A98180", VA = "0x184A98D80")]
		internal T JDNCALLLCBI(BDLPMJHFHLL b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class FPNJAFIDHJB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public FPNJAFIDHJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x33F2A20", Offset = "0x33F1E20", VA = "0x1833F2A20")]
		internal void GCHKFKKDOMH(LPHAAGNHOAH b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x33F2A50", Offset = "0x33F1E50", VA = "0x1833F2A50")]
		internal T OFHCPIGANOJ(BDLPMJHFHLL b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class MCFGGDLLKNN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public MCFGGDLLKNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3B5E1B0", Offset = "0x3B5D5B0", VA = "0x183B5E1B0")]
		internal void NKCLGDDLCBD(LPHAAGNHOAH b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3B5E180", Offset = "0x3B5D580", VA = "0x183B5E180")]
		internal T DGOHGFLOCPD(BDLPMJHFHLL b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class CPMOCPCEHGM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public CPMOCPCEHGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4B0A810", Offset = "0x4B09C10", VA = "0x184B0A810")]
		internal void FDOMBMOPEEF(LPHAAGNHOAH b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4B0A840", Offset = "0x4B09C40", VA = "0x184B0A840")]
		internal T GGIHOFMLNDB(BDLPMJHFHLL b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class CEHIHMOFCIE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public CEHIHMOFCIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4AB9620", Offset = "0x4AB8A20", VA = "0x184AB9620")]
		internal void NAFCCIHFHLP(LPHAAGNHOAH b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4AB9600", Offset = "0x4AB8A00", VA = "0x184AB9600")]
		internal T JNOLPPJLFCB(BDLPMJHFHLL b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class PCKEPPICIEE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public PCKEPPICIEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9620", Offset = "0x3DB8A20", VA = "0x183DB9620")]
		internal void DFKFBDBJEAN(LPHAAGNHOAH b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9600", Offset = "0x3DB8A00", VA = "0x183DB9600")]
		internal T CNFNIABJHGD(BDLPMJHFHLL b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x29D2EE0", Offset = "0x29D22E0", VA = "0x1829D2EE0")]
	public static void KDNDLPBDNFO<T>(T HMHBFKEMPJM, T NJNDGGPGGKK, [Out] GJBNPCAEDCF<T> PHDBCDEGCAH, [Out] GIAAJBNLCFD<T> HDIMDMDNIFK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x29D2DB0", Offset = "0x29D21B0", VA = "0x1829D2DB0")]
	private static void OILONOEAODC<T>(T HMHBFKEMPJM, T NJNDGGPGGKK, [Out] GJBNPCAEDCF<T> PHDBCDEGCAH, [Out] GIAAJBNLCFD<T> HDIMDMDNIFK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x29D2DB0", Offset = "0x29D21B0", VA = "0x1829D2DB0")]
	private static void JMGNKMFALIP<T>(T HMHBFKEMPJM, T NJNDGGPGGKK, [Out] GJBNPCAEDCF<T> PHDBCDEGCAH, [Out] GIAAJBNLCFD<T> HDIMDMDNIFK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x29D3220", Offset = "0x29D2620", VA = "0x1829D3220")]
	private static void OLEJPLAIKJB<T>(T HMHBFKEMPJM, T NJNDGGPGGKK, [Out] GJBNPCAEDCF<T> PHDBCDEGCAH, [Out] GIAAJBNLCFD<T> HDIMDMDNIFK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x29D3220", Offset = "0x29D2620", VA = "0x1829D3220")]
	private static void LFLABGABDKA<T>(T HMHBFKEMPJM, T NJNDGGPGGKK, [Out] GJBNPCAEDCF<T> PHDBCDEGCAH, [Out] GIAAJBNLCFD<T> HDIMDMDNIFK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x29D30F0", Offset = "0x29D24F0", VA = "0x1829D30F0")]
	private static void PNNLLIBPHJL<T>(T HMHBFKEMPJM, T NJNDGGPGGKK, [Out] GJBNPCAEDCF<T> PHDBCDEGCAH, [Out] GIAAJBNLCFD<T> HDIMDMDNIFK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x29D30F0", Offset = "0x29D24F0", VA = "0x1829D30F0")]
	private static void KNONFEALNDA<T>(T HMHBFKEMPJM, T NJNDGGPGGKK, [Out] GJBNPCAEDCF<T> PHDBCDEGCAH, [Out] GIAAJBNLCFD<T> HDIMDMDNIFK) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class APDJPIDMBPD
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct BKAFDMNHEGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public uint NIOOANOKGGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float PEMPCCIFBIN;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5C71F00", Offset = "0x5C71300", VA = "0x185C71F00")]
	public static float IIAAONBDPDK(BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5C71EA0", Offset = "0x5C712A0", VA = "0x185C71EA0")]
	public static void BIPGFJHKKLJ(float EOHMJBFGDPD, LPHAAGNHOAH GCLEDKPLBKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class DIKELKMEIMF
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class CIPALHPPHML
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static readonly int[] KLCDDJDCPOO;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5C72030", Offset = "0x5C71430", VA = "0x185C72030")]
	public static int AHOAFHFDMFN(uint DEPLHPBANAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5C72840", Offset = "0x5C71C40", VA = "0x185C72840")]
	public static uint DDDDHAKOLEJ(int EIKBEBCCKJJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5C72340", Offset = "0x5C71740", VA = "0x185C72340")]
	private static uint CCKEFFECHLA(int EIKBEBCCKJJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5C73710", Offset = "0x5C72B10", VA = "0x185C73710")]
	public static int PKFKCILHLLB(int EOHMJBFGDPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5C73600", Offset = "0x5C72A00", VA = "0x185C73600")]
	public static bool ONEFKOCABGK(BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5C72C90", Offset = "0x5C72090", VA = "0x185C72C90")]
	public static byte HJHAPDLAEBE(byte CJDNODDJLGJ, byte MHLKGFHCBMF, BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5C729F0", Offset = "0x5C71DF0", VA = "0x185C729F0")]
	public static sbyte FLDGDMJICDB(sbyte CJDNODDJLGJ, sbyte MHLKGFHCBMF, BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5C72AF0", Offset = "0x5C71EF0", VA = "0x185C72AF0")]
	public static ushort FOEKBGIBCGL(ushort CJDNODDJLGJ, ushort MHLKGFHCBMF, BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5C727D0", Offset = "0x5C71BD0", VA = "0x185C727D0")]
	public static short COGNJLGJIIF(short CJDNODDJLGJ, short MHLKGFHCBMF, BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5C72A60", Offset = "0x5C71E60", VA = "0x185C72A60")]
	public static int FLMEDFBIECE(BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5C72D00", Offset = "0x5C72100", VA = "0x185C72D00")]
	public static long IAIDEMADOKO(BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5C730C0", Offset = "0x5C724C0", VA = "0x185C730C0")]
	public static uint KHJNPOJCAOB(BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5C726E0", Offset = "0x5C71AE0", VA = "0x185C726E0")]
	public static ulong CNEGPDEEJHL(BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5C721F0", Offset = "0x5C715F0", VA = "0x185C721F0")]
	public static uint BEEHDHFEHHD(uint CJDNODDJLGJ, uint MHLKGFHCBMF, BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5C720E0", Offset = "0x5C714E0", VA = "0x185C720E0")]
	public static int ALKBBLLANNF(int CJDNODDJLGJ, int MHLKGFHCBMF, BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5C72990", Offset = "0x5C71D90", VA = "0x185C72990")]
	public static uint FLBBBLGIKIM(int EIKBEBCCKJJ, BDLPMJHFHLL GCLEDKPLBKL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5C732F0", Offset = "0x5C726F0", VA = "0x185C732F0")]
	public static uint LPDBEEIJCOL(int MHLJBFCKBGP, BDLPMJHFHLL FJHKACIMEOO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5C73200", Offset = "0x5C72600", VA = "0x185C73200")]
	private static void LOJNIBBOEMM(BDLPMJHFHLL GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5C72190", Offset = "0x5C71590", VA = "0x185C72190")]
	public static void APCKGLEBCCO(bool EOHMJBFGDPD, LPHAAGNHOAH FJHKACIMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5C73580", Offset = "0x5C72980", VA = "0x185C73580")]
	public static void OHNPJDACAAC(byte EOHMJBFGDPD, byte CJDNODDJLGJ, byte MHLKGFHCBMF, LPHAAGNHOAH FJHKACIMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5C72910", Offset = "0x5C71D10", VA = "0x185C72910")]
	public static void FIMPBMBKIMN(sbyte EOHMJBFGDPD, sbyte CJDNODDJLGJ, sbyte MHLKGFHCBMF, LPHAAGNHOAH FJHKACIMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5C73690", Offset = "0x5C72A90", VA = "0x185C73690")]
	public static void PECDLEDINGC(ushort EOHMJBFGDPD, ushort CJDNODDJLGJ, ushort MHLKGFHCBMF, LPHAAGNHOAH FJHKACIMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5C72B60", Offset = "0x5C71F60", VA = "0x185C72B60")]
	public static void HFMBHMODADP(short EOHMJBFGDPD, short CJDNODDJLGJ, short MHLKGFHCBMF, LPHAAGNHOAH FJHKACIMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5C72BE0", Offset = "0x5C71FE0", VA = "0x185C72BE0")]
	public static void HJAIDJBLPAJ(uint EOHMJBFGDPD, uint CJDNODDJLGJ, uint MHLKGFHCBMF, LPHAAGNHOAH FJHKACIMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5C72D60", Offset = "0x5C72160", VA = "0x185C72D60")]
	public static void JEBOKBMEDPJ(int EOHMJBFGDPD, int CJDNODDJLGJ, int MHLKGFHCBMF, LPHAAGNHOAH FJHKACIMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5C734E0", Offset = "0x5C728E0", VA = "0x185C734E0")]
	public static void MHCOGFOKPJF(int EOHMJBFGDPD, LPHAAGNHOAH FJHKACIMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5C72660", Offset = "0x5C71A60", VA = "0x185C72660")]
	public static void CKMPDNFKBMD(long EOHMJBFGDPD, LPHAAGNHOAH FJHKACIMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5C728B0", Offset = "0x5C71CB0", VA = "0x185C728B0")]
	public static void ECJIPAHCPOD(uint EOHMJBFGDPD, LPHAAGNHOAH FJHKACIMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5C72350", Offset = "0x5C71750", VA = "0x185C72350")]
	public static void CEANLOEKMGB(ulong EOHMJBFGDPD, LPHAAGNHOAH FJHKACIMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5C72E20", Offset = "0x5C72220", VA = "0x185C72E20")]
	public static void KGGDBIDKIFC(uint EOHMJBFGDPD, int EIKBEBCCKJJ, LPHAAGNHOAH FJHKACIMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5C73110", Offset = "0x5C72510", VA = "0x185C73110")]
	private static void KPPJOCHMMBP(LPHAAGNHOAH GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5C722A0", Offset = "0x5C716A0", VA = "0x185C722A0")]
	private static ulong BHAJIPGEEKG(ulong EOHMJBFGDPD, LPHAAGNHOAH GCLEDKPLBKL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5C71FB0", Offset = "0x5C713B0", VA = "0x185C71FB0")]
	public static int AGKKDHKBFHI(LPHAAGNHOAH GCLEDKPLBKL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal static class AHHPAKNGEJD
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4E26830", Offset = "0x4E25C30", VA = "0x184E26830")]
	public static int CGMAALJGFJG(uint HKKGEHMHEGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4E26840", Offset = "0x4E25C40", VA = "0x184E26840")]
	public static long EOEAOHGEHKM(ulong HKKGEHMHEGP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4E32810", Offset = "0x4E31C10", VA = "0x184E32810")]
	public static uint OLLOFDJCLFM(int HKKGEHMHEGP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4E32820", Offset = "0x4E31C20", VA = "0x184E32820")]
	public static ulong EKLAICOBADP(long HKKGEHMHEGP)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BEKOKBPJGNG
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct HLFACBPLAMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly byte[] FNCIFBBDALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly Stream FMJIOIIBMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int MOLHPCKEOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int BCPFCDOBMEI;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public ref struct LPHAAGNHOAH
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate LPHAAGNHOAH PHJJILKHHNF(LPHAAGNHOAH GCLEDKPLBKL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly Span<byte> GHFAAPNAFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly PHJJILKHHNF HJEIFBKHOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal int MOLHPCKEOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal int BCPFCDOBMEI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ReadOnlySpan<byte> BCFMMMEJKKO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5C74910", Offset = "0x5C73D10", VA = "0x185C74910")]
		get
		{
			return default(ReadOnlySpan<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5C749D0", Offset = "0x5C73DD0", VA = "0x185C749D0")]
	public LPHAAGNHOAH(Span<byte> GHFAAPNAFDE, int MOLHPCKEOPH = 0, int BCPFCDOBMEI = 0, [Optional] PHJJILKHHNF HJEIFBKHOIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class HALKEGDHCEF
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x23A4880", Offset = "0x23A3C80", VA = "0x1823A4880")]
	public static void EOCHBNCKDPC<T>(this LPHAAGNHOAH MKIOBJMIBCN, T EOHMJBFGDPD) where T : struct, OGIDOOLIEGA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5C73F50", Offset = "0x5C73350", VA = "0x185C73F50")]
	public static void APCKGLEBCCO(this LPHAAGNHOAH GCLEDKPLBKL, bool EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5C74730", Offset = "0x5C73B30", VA = "0x185C74730")]
	public static void OHNPJDACAAC(this LPHAAGNHOAH GCLEDKPLBKL, byte EOHMJBFGDPD, byte CJDNODDJLGJ, byte MHLKGFHCBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5C742E0", Offset = "0x5C736E0", VA = "0x185C742E0")]
	public static void FIMPBMBKIMN(this LPHAAGNHOAH GCLEDKPLBKL, sbyte EOHMJBFGDPD, sbyte CJDNODDJLGJ, sbyte MHLKGFHCBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5C747E0", Offset = "0x5C73BE0", VA = "0x185C747E0")]
	public static void PECDLEDINGC(this LPHAAGNHOAH GCLEDKPLBKL, ushort EOHMJBFGDPD, ushort CJDNODDJLGJ, ushort MHLKGFHCBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5C74430", Offset = "0x5C73830", VA = "0x185C74430")]
	public static void HFMBHMODADP(this LPHAAGNHOAH GCLEDKPLBKL, short EOHMJBFGDPD, short CJDNODDJLGJ, short MHLKGFHCBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5C744E0", Offset = "0x5C738E0", VA = "0x185C744E0")]
	public static void HJAIDJBLPAJ(this LPHAAGNHOAH GCLEDKPLBKL, uint EOHMJBFGDPD, uint CJDNODDJLGJ, uint MHLKGFHCBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5C74560", Offset = "0x5C73960", VA = "0x185C74560")]
	public static void JEBOKBMEDPJ(this LPHAAGNHOAH GCLEDKPLBKL, int EOHMJBFGDPD, int CJDNODDJLGJ, int MHLKGFHCBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5C745E0", Offset = "0x5C739E0", VA = "0x185C745E0")]
	public static void MHCOGFOKPJF(this LPHAAGNHOAH GCLEDKPLBKL, int EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5C741A0", Offset = "0x5C735A0", VA = "0x185C741A0")]
	public static void CKMPDNFKBMD(this LPHAAGNHOAH GCLEDKPLBKL, long EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5C74250", Offset = "0x5C73650", VA = "0x185C74250")]
	public static void ECJIPAHCPOD(this LPHAAGNHOAH GCLEDKPLBKL, uint EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5C74040", Offset = "0x5C73440", VA = "0x185C74040")]
	public static void CEANLOEKMGB(this LPHAAGNHOAH GCLEDKPLBKL, ulong EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5C73FE0", Offset = "0x5C733E0", VA = "0x185C73FE0")]
	public static void BIPGFJHKKLJ(this LPHAAGNHOAH GCLEDKPLBKL, float EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5C746B0", Offset = "0x5C73AB0", VA = "0x185C746B0")]
	public static void MLCDICGHAEA(this LPHAAGNHOAH GCLEDKPLBKL, double EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5C740A0", Offset = "0x5C734A0", VA = "0x185C740A0")]
	public static void CJANCBCDJLG(this LPHAAGNHOAH GCLEDKPLBKL, [In] float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5C74390", Offset = "0x5C73790", VA = "0x185C74390")]
	public static int GPKGIBGJCPP(this LPHAAGNHOAH GCLEDKPLBKL)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GJFEHICIKAF
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GJFEHICIKAF()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
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
