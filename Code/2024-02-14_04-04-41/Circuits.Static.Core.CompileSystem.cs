using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1D60BA0", Offset = "0x1D5FFA0", VA = "0x181D60BA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C8560", Offset = "0x7C7960", VA = "0x1807C8560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C85A0", Offset = "0x7C79A0", VA = "0x1807C85A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct PKKJHLCJAKN
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class CCLFIJANHEE
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal KLAHACLPKMA<CCLFIJANHEE> JPGFHCGHAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal LBFBFNIPGIA<CCLFIJANHEE, object> KMFKMKEIPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal Dictionary<object, JLGMECJOLDI<CCLFIJANHEE>> OCFANDEDNII;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1D615A0", Offset = "0x1D609A0", VA = "0x181D615A0")]
	private PKKJHLCJAKN([In] KLAHACLPKMA<CCLFIJANHEE> MLDABOFDONH, [In] LBFBFNIPGIA<CCLFIJANHEE, object> IKAFDOJLKGE, Dictionary<object, JLGMECJOLDI<CCLFIJANHEE>> JIPAHDDKEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1D61380", Offset = "0x1D60780", VA = "0x181D61380")]
	public static PKKJHLCJAKN JKJFENIAMEL()
	{
		return default(PKKJHLCJAKN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HPMFDCKMAPN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1D5EF10", Offset = "0x1D5E310", VA = "0x181D5EF10")]
	public static void NNIMNMJHJOG(this PKKJHLCJAKN NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1D5EE20", Offset = "0x1D5E220", VA = "0x181D5EE20")]
	public static JLGMECJOLDI<PKKJHLCJAKN.CCLFIJANHEE> MOIIIMGGNLM(this PKKJHLCJAKN NHHBAHIFHJK, object MBCPMMHPENP)
	{
		return default(JLGMECJOLDI<PKKJHLCJAKN.CCLFIJANHEE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum OLHKBPPIFIE
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Bool,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Int,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Bytes,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Class
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct EMLGDLJKPDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public FHOAFJPGJCO<int> LBEBLLOBBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public FHOAFJPGJCO<int> PFAHLDNBNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public int MDEECBLBMOM;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B9C0", Offset = "0x1D5ADC0", VA = "0x181D5B9C0")]
	private EMLGDLJKPDC([In] FHOAFJPGJCO<int> DFEGFPPFDNE, [In] FHOAFJPGJCO<int> OLJAHMJIDAA, int CLFNBNPIMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B930", Offset = "0x1D5AD30", VA = "0x181D5B930")]
	public static EMLGDLJKPDC JKJFENIAMEL()
	{
		return default(EMLGDLJKPDC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class PPJLFHJPPHO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1D61610", Offset = "0x1D60A10", VA = "0x181D61610")]
	public static void NNIMNMJHJOG(this EMLGDLJKPDC NHHBAHIFHJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct PGGHPMNBHKA
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class KLHDDGCLHLM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum EMFOGFIHNHA
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		External
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct ADIKDBKFKDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public FHOAFJPGJCO<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>> LBEBLLOBBEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public FHOAFJPGJCO<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>> PFAHLDNBNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public JLGMECJOLDI<MLIIACGFEJG<KLPEGIKGDIA>> FGGBILNDCLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public EMFOGFIHNHA CLLBBANBPDH;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1D5AC70", Offset = "0x1D5A070", VA = "0x181D5AC70")]
		private ADIKDBKFKDO([In] FHOAFJPGJCO<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>> DFEGFPPFDNE, [In] FHOAFJPGJCO<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>> OLJAHMJIDAA, JLGMECJOLDI<MLIIACGFEJG<KLPEGIKGDIA>> CCNPBJHNEED, EMFOGFIHNHA IGJBLBIPNCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1D5ABD0", Offset = "0x1D59FD0", VA = "0x181D5ABD0")]
		public static ADIKDBKFKDO JKJFENIAMEL(EMFOGFIHNHA IGJBLBIPNCH)
		{
			return default(ADIKDBKFKDO);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal JAPKIEEEPLM<KLHDDGCLHLM, ADIKDBKFKDO> HHDGNDCDABE;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D61350", Offset = "0x1D60750", VA = "0x181D61350")]
	private PGGHPMNBHKA([In] JAPKIEEEPLM<KLHDDGCLHLM, ADIKDBKFKDO> DECFOJFNFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D612E0", Offset = "0x1D606E0", VA = "0x181D612E0")]
	public static PGGHPMNBHKA JKJFENIAMEL()
	{
		return default(PGGHPMNBHKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BJDOBODKCHM
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1D5AF30", Offset = "0x1D5A330", VA = "0x181D5AF30")]
	public static void NNIMNMJHJOG(this PGGHPMNBHKA.ADIKDBKFKDO NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1D5AF80", Offset = "0x1D5A380", VA = "0x181D5AF80")]
	public static void NNIMNMJHJOG(this PGGHPMNBHKA NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1D5ACD0", Offset = "0x1D5A0D0", VA = "0x181D5ACD0")]
	public static KLAHACLPKMA<PGGHPMNBHKA.KLHDDGCLHLM> EEMBANPOOIA([In] this PGGHPMNBHKA NHHBAHIFHJK)
	{
		return default(KLAHACLPKMA<PGGHPMNBHKA.KLHDDGCLHLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1D5AD10", Offset = "0x1D5A110", VA = "0x181D5AD10")]
	public static JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> GEGPOIBGIKD(this PGGHPMNBHKA NHHBAHIFHJK)
	{
		return default(JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1D5AE20", Offset = "0x1D5A220", VA = "0x181D5AE20")]
	public static JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> IFKLPGGGNCF(this PGGHPMNBHKA NHHBAHIFHJK)
	{
		return default(JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B190", Offset = "0x1D5A590", VA = "0x181D5B190")]
	public static void PKGNPALMLGA(this PGGHPMNBHKA NHHBAHIFHJK, JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> PDDHPPHOJPD, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MJIACGIHBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B110", Offset = "0x1D5A510", VA = "0x181D5B110")]
	public static void OFDCNJNFGKC(this PGGHPMNBHKA NHHBAHIFHJK, JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> PDDHPPHOJPD, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MJIACGIHBFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct KBPEDJPLPIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public FHOAFJPGJCO<byte> PDFHFNBHLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public PGGHPMNBHKA KHPAFAIDIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public EJEKCIJBILF NFOAJPOPDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal PKKJHLCJAKN FMEOLNGDPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal LBFBFNIPGIA<JOHHLDIDKOB, DBOBIGPCLFL?> OPDGDCGPHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal FHOAFJPGJCO<JLGMECJOLDI<JOHHLDIDKOB>> JANGPNFPFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal LBFBFNIPGIA<HIPKLPLFKLJ, JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>>?> DNFCGEILHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal FHOAFJPGJCO<(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> VariableId, JLGMECJOLDI<MLIIACGFEJG<NMPFNBKMFCL<DJLDLENNLAH>>> ByteCodeWriteLocation)> JHCLHGBJKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal FHOAFJPGJCO<(JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> Target, JLGMECJOLDI<MLIIACGFEJG<MLIIACGFEJG<IDIDHCJPJCJ>>> ByteCodeWriteLocation)> ECOIIOAKFKA;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1D5F6A0", Offset = "0x1D5EAA0", VA = "0x181D5F6A0")]
	private KBPEDJPLPIH([In] FHOAFJPGJCO<byte> AFHPFLFPLOF, [In] PGGHPMNBHKA GAMCKLAMHIE, [In] EJEKCIJBILF HGOBGEEIMPF, [In] PKKJHLCJAKN LIAINIKHGPL, [In] LBFBFNIPGIA<JOHHLDIDKOB, DBOBIGPCLFL?> KPEMCHLFOMO, [In] FHOAFJPGJCO<JLGMECJOLDI<JOHHLDIDKOB>> CPAEMIEGOCN, [In] LBFBFNIPGIA<HIPKLPLFKLJ, JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>>?> FPBMDBPEBIK, [In] FHOAFJPGJCO<(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> VariableId, JLGMECJOLDI<MLIIACGFEJG<NMPFNBKMFCL<DJLDLENNLAH>>> ByteCodeWriteLocation)> NPCBEBPMDMI, [In] FHOAFJPGJCO<(JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> Target, JLGMECJOLDI<MLIIACGFEJG<MLIIACGFEJG<IDIDHCJPJCJ>>> ByteCodeWriteLocation)> KCJDMJANKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1D5EF70", Offset = "0x1D5E370", VA = "0x181D5EF70")]
	public static KBPEDJPLPIH JKJFENIAMEL()
	{
		return default(KBPEDJPLPIH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NAKPGIJINID
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1D60820", Offset = "0x1D5FC20", VA = "0x181D60820")]
	public static void NNIMNMJHJOG(this KBPEDJPLPIH NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1D60710", Offset = "0x1D5FB10", VA = "0x181D60710")]
	public static JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> MNOOHCBLHFJ(this KBPEDJPLPIH NHHBAHIFHJK)
	{
		return default(JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2759400", Offset = "0x2758800", VA = "0x182759400")]
	public static void BMBBBHDPNAF<M>(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MJIACGIHBFB, JLGMECJOLDI<MLIIACGFEJG<NMPFNBKMFCL<M>>> KNOIDJFJLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1D60240", Offset = "0x1D5F640", VA = "0x181D60240")]
	public static void FFLFLNLCAFC(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> DAPOBFHGAGK, JLGMECJOLDI<MLIIACGFEJG<MLIIACGFEJG<IDIDHCJPJCJ>>> ALMHIAPGCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1D606A0", Offset = "0x1D5FAA0", VA = "0x181D606A0")]
	public static void LANABPGCBOH(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> BAHGEJPOBPF, JLGMECJOLDI<MLIIACGFEJG<KLPEGIKGDIA>> CCNPBJHNEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1D605F0", Offset = "0x1D5F9F0", VA = "0x181D605F0")]
	public static void KMFPDOJGAJC(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MJIACGIHBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1D60030", Offset = "0x1D5F430", VA = "0x181D60030")]
	public static void CCKAHNPAGGG(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<JOHHLDIDKOB> FLOGJHFICGN, [In] DBOBIGPCLFL LECKFDGPBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1D60110", Offset = "0x1D5F510", VA = "0x181D60110")]
	public static void FAOLDPAGLLO(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<JOHHLDIDKOB> FLOGJHFICGN, [In] DBOBIGPCLFL LECKFDGPBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1D60360", Offset = "0x1D5F760", VA = "0x181D60360")]
	public static DBOBIGPCLFL? GOOEGCMMFMG([In] this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<JOHHLDIDKOB> FLOGJHFICGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x27594C0", Offset = "0x27588C0", VA = "0x1827594C0")]
	public static DBOBIGPCLFL CKPCCLCJGDE<TDeps, TStateSys>(this KBPEDJPLPIH NHHBAHIFHJK, TDeps NFFMMJBNJIB, TStateSys LHJOOKKDPIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB, JLGMECJOLDI<HIPKLPLFKLJ> FIPNEPOHCEF) where TDeps : FOAEJGFGFCP<TStateSys>
	{
		return default(DBOBIGPCLFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1D60A40", Offset = "0x1D5FE40", VA = "0x181D60A40")]
	private static void PKNFCDFJKFH(this KBPEDJPLPIH NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1D602D0", Offset = "0x1D5F6D0", VA = "0x181D602D0")]
	private static JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>>? GLMLDFOEIJL([In] this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<HIPKLPLFKLJ> FIPNEPOHCEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x275C070", Offset = "0x275B470", VA = "0x18275C070")]
	public static LFHOHGKFAGD HCHAAJGPMDI<TDeps, TStateSys>(this KBPEDJPLPIH NHHBAHIFHJK, TDeps NFFMMJBNJIB, TStateSys LHJOOKKDPIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB, JLGMECJOLDI<JOHHLDIDKOB> FLOGJHFICGN) where TDeps : FOAEJGFGFCP<TStateSys>
	{
		return default(LFHOHGKFAGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1D5FED0", Offset = "0x1D5F2D0", VA = "0x181D5FED0")]
	public static void AJKGHPADJHD(this KBPEDJPLPIH NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2759F20", Offset = "0x2759320", VA = "0x182759F20")]
	public static int ELANFAJEPDN<TDeps, TStateSys>(this KBPEDJPLPIH NHHBAHIFHJK, TDeps NFFMMJBNJIB, TStateSys LHJOOKKDPIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB, LBFBFNIPGIA<PGGHPMNBHKA.KLHDDGCLHLM, EMLGDLJKPDC> KDIPLCBEEEH) where TDeps : FOAEJGFGFCP<TStateSys>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1D60420", Offset = "0x1D5F820", VA = "0x181D60420")]
	public static void KCKCGIJKHHJ(this KBPEDJPLPIH NHHBAHIFHJK, [In] LBFBFNIPGIA<PGGHPMNBHKA.KLHDDGCLHLM, EMLGDLJKPDC> CDHEKFEJDAP, int NIAKPIPAMFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct DBOBIGPCLFL
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum OOJJMJHPGBO
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Register
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public readonly struct BLNGOBJJMEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> AOFAAKNKAIF;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x88AE90", Offset = "0x88A290", VA = "0x18088AE90")]
		public BLNGOBJJMEN(JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> AJDKHMNHOII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct LBOGJDFLGMN : IEquatable<LBOGJDFLGMN>, FONIOECJOBC<LBOGJDFLGMN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public ReadOnlyMemory<byte> OOMNBKACKHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public BKILFBCIGKN GCCAKKJPAMG;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1D5FEA0", Offset = "0x1D5F2A0", VA = "0x181D5FEA0")]
		private LBOGJDFLGMN([In] ReadOnlyMemory<byte> PEBEDGMMHMC, BKILFBCIGKN HOPLPMKDEIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1D5FA30", Offset = "0x1D5EE30", VA = "0x181D5FA30")]
		public static LBOGJDFLGMN FEBFKEGDCNI(bool LAFDDICOPFM)
		{
			return default(LBOGJDFLGMN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1D5FB60", Offset = "0x1D5EF60", VA = "0x181D5FB60")]
		public static LBOGJDFLGMN HCIJDLNDLDE([In] ReadOnlyMemory<byte> PEBEDGMMHMC)
		{
			return default(LBOGJDFLGMN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1D5FBA0", Offset = "0x1D5EFA0", VA = "0x181D5FBA0")]
		public static LBOGJDFLGMN KAOPBGBBIGL(int HELELFNPBBH)
		{
			return default(LBOGJDFLGMN);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1D5FA90", Offset = "0x1D5EE90", VA = "0x181D5FA90")]
		public static bool FFFIMEBHMPG([In] LBOGJDFLGMN CGDDINAJAOB, [In] LBOGJDFLGMN GIFBDNCPDKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F8E0", Offset = "0x1D5ECE0", VA = "0x181D5F8E0", Slot = "4")]
		public bool Equals(LBOGJDFLGMN AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1D5FA90", Offset = "0x1D5EE90", VA = "0x181D5FA90")]
		public bool MLPLMDDOIJN([In] LBOGJDFLGMN AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F950", Offset = "0x1D5ED50", VA = "0x181D5F950", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1D5FB00", Offset = "0x1D5EF00", VA = "0x181D5FB00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1D5FBF0", Offset = "0x1D5EFF0", VA = "0x181D5FBF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1D5FA90", Offset = "0x1D5EE90", VA = "0x181D5FA90", Slot = "5")]
		private bool KNJEIJOOOLJ([In] LBOGJDFLGMN AAMIMDAKFMC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct ICCPAPECPGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public readonly JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> IKELDDFBKKC;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x88AE90", Offset = "0x88A290", VA = "0x18088AE90")]
		public ICCPAPECPGJ(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MJIACGIHBFB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly BLNGOBJJMEN NBLKPBEGNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly LBOGJDFLGMN EIMNIDKBMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly ICCPAPECPGJ LIBHGHNAKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly OOJJMJHPGBO EOGGGAPGMPC;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B480", Offset = "0x1D5A880", VA = "0x181D5B480")]
	private DBOBIGPCLFL(BLNGOBJJMEN FEAIAIPEEKK, [In] LBOGJDFLGMN DNMPDLPJNPM, ICCPAPECPGJ KKFGPFKAMKM, OOJJMJHPGBO JBAFOMDHMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B3A0", Offset = "0x1D5A7A0", VA = "0x181D5B3A0")]
	public static DBOBIGPCLFL MLAIGNBNJOA(JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> AJDKHMNHOII)
	{
		return default(DBOBIGPCLFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B310", Offset = "0x1D5A710", VA = "0x181D5B310")]
	public static DBOBIGPCLFL LMEIGJLBFBE(bool LAFDDICOPFM)
	{
		return default(DBOBIGPCLFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B2A0", Offset = "0x1D5A6A0", VA = "0x181D5B2A0")]
	public static DBOBIGPCLFL DJGGEKNODGI([In] ReadOnlyMemory<byte> PEBEDGMMHMC)
	{
		return default(DBOBIGPCLFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B3F0", Offset = "0x1D5A7F0", VA = "0x181D5B3F0")]
	public static DBOBIGPCLFL NOLNGEKJJKO(int HELELFNPBBH)
	{
		return default(DBOBIGPCLFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B240", Offset = "0x1D5A640", VA = "0x181D5B240")]
	public static DBOBIGPCLFL CPLHJMHAHKN(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> EHMIDGEEBFF)
	{
		return default(DBOBIGPCLFL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class KBLKLHKFBEP
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380")]
	public static LFHOHGKFAGD PHLAAKMHGNJ([In] this DBOBIGPCLFL NHHBAHIFHJK)
	{
		return default(LFHOHGKFAGD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct LFHOHGKFAGD
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum LGJBEJCDFDO
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		OutNode,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		NodeCantVisit,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		NodeAlreadyVisited,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		Branch
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly LGJBEJCDFDO EOGGGAPGMPC;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x88AE90", Offset = "0x88A290", VA = "0x18088AE90")]
	private LFHOHGKFAGD(LGJBEJCDFDO JBAFOMDHMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380")]
	public static LFHOHGKFAGD MLAIGNBNJOA()
	{
		return default(LFHOHGKFAGD);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380")]
	public static LFHOHGKFAGD GNEBLBHEEHN([In] DBOBIGPCLFL JHEMNDMHNOB)
	{
		return default(LFHOHGKFAGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7E8CB0", Offset = "0x7E80B0", VA = "0x1807E8CB0")]
	public static LFHOHGKFAGD NAJNOKAIMML()
	{
		return default(LFHOHGKFAGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8985B0", Offset = "0x8979B0", VA = "0x1808985B0")]
	public static LFHOHGKFAGD BMFNAPAOEMJ()
	{
		return default(LFHOHGKFAGD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface FOAEJGFGFCP<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JLGMECJOLDI<EFDJLNOJKKM> NKIALDCDGMC(TStateSys LHJOOKKDPIO);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LFHOHGKFAGD PMPOAFGPGKO(TStateSys LHJOOKKDPIO, KBPEDJPLPIH JNEKMOKLKIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB, JLGMECJOLDI<HIPKLPLFKLJ> FIPNEPOHCEF);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DBOBIGPCLFL BBAHNKJACCL(TStateSys LHJOOKKDPIO, KBPEDJPLPIH JNEKMOKLKIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB, JLGMECJOLDI<JOHHLDIDKOB> FLOGJHFICGN);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GCPNLIDJDBA(TStateSys LHJOOKKDPIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB, JLGMECJOLDI<HIPKLPLFKLJ> FIPNEPOHCEF);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JLGMECJOLDI<JOHHLDIDKOB> PKPCNBJFMHI(TStateSys LHJOOKKDPIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB, JLGMECJOLDI<HIPKLPLFKLJ> FIPNEPOHCEF, int PGPOANIMGEO);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OLHKBPPIFIE HHLGPICMHPK(TStateSys LHJOOKKDPIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB, JLGMECJOLDI<HIPKLPLFKLJ> FIPNEPOHCEF);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PPEINGPMGGH(TStateSys LHJOOKKDPIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB, JLGMECJOLDI<HIPKLPLFKLJ> FIPNEPOHCEF);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int NAEAMDJGAOL(TStateSys LHJOOKKDPIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB, JLGMECJOLDI<HIPKLPLFKLJ> FIPNEPOHCEF);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ONCNDMJEMJA<byte> ACICKDLOHCP(TStateSys LHJOOKKDPIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB, JLGMECJOLDI<HIPKLPLFKLJ> FIPNEPOHCEF);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	object FDOBDLPNCDC(TStateSys LHJOOKKDPIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB, JLGMECJOLDI<HIPKLPLFKLJ> FIPNEPOHCEF);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int EOKMLKLCHCI(TStateSys LHJOOKKDPIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB, JLGMECJOLDI<JOHHLDIDKOB> FLOGJHFICGN);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	JLGMECJOLDI<HIPKLPLFKLJ> ACNPCFFMOAL(TStateSys LHJOOKKDPIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB, JLGMECJOLDI<JOHHLDIDKOB> FLOGJHFICGN, int BOJKIKKOMIE);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	int FMIBIKNIFOG(TStateSys LHJOOKKDPIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int POOABPDFJHI(TStateSys LHJOOKKDPIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB, int OJANCMLFDOJ);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "14")]
	int PBBJFLKDCLG(TStateSys LHJOOKKDPIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int DGCENBFMLOJ(TStateSys LHJOOKKDPIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB, int OJANCMLFDOJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class FKLNHDMBAGB
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1D5C100", Offset = "0x1D5B500", VA = "0x181D5C100")]
	public static JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> CBHLNEFLPEL([In] this KBPEDJPLPIH NHHBAHIFHJK)
	{
		return default(JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1D5EAC0", Offset = "0x1D5DEC0", VA = "0x181D5EAC0")]
	private static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> NMAGBECKDBP(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> BAHGEJPOBPF, int OJANCMLFDOJ, int CMHIAJEPKIJ)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1D5EC00", Offset = "0x1D5E000", VA = "0x181D5EC00")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> OCMOPJFJDLE(this KBPEDJPLPIH NHHBAHIFHJK, int OJANCMLFDOJ)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E4D0", Offset = "0x1D5D8D0", VA = "0x181D5E4D0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MFIKNGINJOP(this KBPEDJPLPIH NHHBAHIFHJK, int BFFGCOIILMK)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1D5BCE0", Offset = "0x1D5B0E0", VA = "0x181D5BCE0")]
	private static void BEPFCFACMIF(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MJIACGIHBFB, JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> BAHGEJPOBPF, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1D5CC40", Offset = "0x1D5C040", VA = "0x181D5CC40")]
	public static void FCFELLKNIBH(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MJIACGIHBFB, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1D5ED20", Offset = "0x1D5E120", VA = "0x181D5ED20")]
	private static void OFDCNJNFGKC(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> BAHGEJPOBPF, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> PDDHPPHOJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1D5EDA0", Offset = "0x1D5E1A0", VA = "0x181D5EDA0")]
	private static void PKGNPALMLGA(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> BAHGEJPOBPF, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> PDDHPPHOJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1D5D040", Offset = "0x1D5C440", VA = "0x181D5D040")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FJIPAPPNDPB(this KBPEDJPLPIH NHHBAHIFHJK, float FOLCJDPBAHJ, float BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E550", Offset = "0x1D5D950", VA = "0x181D5E550")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MHCEGEMJEIM(this KBPEDJPLPIH NHHBAHIFHJK, float FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1D5C160", Offset = "0x1D5B560", VA = "0x181D5C160")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> CECIEAJJCBE(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1D5C7C0", Offset = "0x1D5BBC0", VA = "0x181D5C7C0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> DJJCEMLMPMG(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, int BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E2F0", Offset = "0x1D5D6F0", VA = "0x181D5E2F0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> LHCIBFLCPAI(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1D5C6D0", Offset = "0x1D5BAD0", VA = "0x181D5C6D0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> DJJBAHMCNGD(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1D5CD80", Offset = "0x1D5C180", VA = "0x181D5CD80")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FCFPOHNAAIM(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, int BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E120", Offset = "0x1D5D520", VA = "0x181D5E120")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> KOIPHMPLCGE(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1D5BA10", Offset = "0x1D5AE10", VA = "0x181D5BA10")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> ADHEHDGBHGE(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1D5C350", Offset = "0x1D5B750", VA = "0x181D5C350")]
	public static void DGKGOPFFGIA(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EFDJLNOJKKM> IOKDJPPOKHD, [In] ReadOnlySpan<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>> OLJAHMJIDAA, [In] ReadOnlySpan<int> OLDJLECAKBN, [In] Span<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>> NAIOEMHLLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1D5DBB0", Offset = "0x1D5CFB0", VA = "0x181D5DBB0")]
	public static void IPOMLBNMKDB(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<MCGCPIODCLF> OLGPONHEIMP, [In] ReadOnlySpan<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>> OLJAHMJIDAA, [In] ReadOnlySpan<int> OLDJLECAKBN, [In] Span<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>> NAIOEMHLLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1D5D730", Offset = "0x1D5CB30", VA = "0x181D5D730")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> GGBDBJCMFIK(this KBPEDJPLPIH NHHBAHIFHJK, int DNFMACCGFHJ, [Optional] JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>? AKPLHCDECML)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E820", Offset = "0x1D5DC20", VA = "0x181D5E820")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> NAKHCAPHEJA(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> DNFMACCGFHJ, [Optional] JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>? AKPLHCDECML)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1D5C020", Offset = "0x1D5B420", VA = "0x181D5C020")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> CAGBNABCFIC(this KBPEDJPLPIH NHHBAHIFHJK, [In] ReadOnlySpan<byte> DNFMACCGFHJ, [Optional] JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>? AKPLHCDECML)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1D5C250", Offset = "0x1D5B650", VA = "0x181D5C250")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> CHBPKPPDIHN(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> DNFMACCGFHJ, int BFFGCOIILMK, [Optional] JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>? AKPLHCDECML)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1D5D7F0", Offset = "0x1D5CBF0", VA = "0x181D5D7F0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> HLABEBGGAGA(this KBPEDJPLPIH NHHBAHIFHJK, float FOLCJDPBAHJ, float BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1D5BB00", Offset = "0x1D5AF00", VA = "0x181D5BB00")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> AIBGEAINLAE(this KBPEDJPLPIH NHHBAHIFHJK, float FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1D5D8E0", Offset = "0x1D5CCE0", VA = "0x181D5D8E0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> IBANDICLJKJ(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1D5D130", Offset = "0x1D5C530", VA = "0x181D5D130")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FPKOHJFGCCB(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, int BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1D5CE60", Offset = "0x1D5C260", VA = "0x181D5CE60")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FICAPGCLDFK(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E640", Offset = "0x1D5DA40", VA = "0x181D5E640")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MKILNJEHGDK(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E020", Offset = "0x1D5D420", VA = "0x181D5E020")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> JKKLBMHHIFF(this KBPEDJPLPIH NHHBAHIFHJK, float FOLCJDPBAHJ, float BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E730", Offset = "0x1D5DB30", VA = "0x181D5E730")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MLFEFFIKIJF(this KBPEDJPLPIH NHHBAHIFHJK, float FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1D5DF30", Offset = "0x1D5D330", VA = "0x181D5DF30")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> JBNLCOMNPEL(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E8F0", Offset = "0x1D5DCF0", VA = "0x181D5E8F0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> NCDIAEAILNB(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, int BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1D5DAC0", Offset = "0x1D5CEC0", VA = "0x181D5DAC0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> IDCOJOGDFEC(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E9D0", Offset = "0x1D5DDD0", VA = "0x181D5E9D0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> NLOFJMDNMMH(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E110", Offset = "0x1D5D510", VA = "0x181D5E110")]
	public static void JNLLBFCHFHJ(this KBPEDJPLPIH NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1D5D480", Offset = "0x1D5C880", VA = "0x181D5D480")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> GEENKPKFNJH(this KBPEDJPLPIH NHHBAHIFHJK, float FOLCJDPBAHJ, float BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1D5BBF0", Offset = "0x1D5AFF0", VA = "0x181D5BBF0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> ALPCLJDKMFJ(this KBPEDJPLPIH NHHBAHIFHJK, float FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E3E0", Offset = "0x1D5D7E0", VA = "0x181D5E3E0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> LMKGEJCIKHH(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E210", Offset = "0x1D5D610", VA = "0x181D5E210")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> LBMGMALCKLP(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, int BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1D5CF50", Offset = "0x1D5C350", VA = "0x181D5CF50")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FJANDAIEPLI(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1D5D9D0", Offset = "0x1D5CDD0", VA = "0x181D5D9D0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> IBJAMLCAFOP(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1D5D210", Offset = "0x1D5C610", VA = "0x181D5D210")]
	public static void GDHHJLEGLOH(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<MCGCPIODCLF> BINBFFLGBGL, [In] ReadOnlySpan<(DBOBIGPCLFL DataBack, int Size)> PPONEGNNAIF, [In] ReadOnlySpan<int> OLDJLECAKBN, [In] Span<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>> NAIOEMHLLHI, [In] Span<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>> JNPIGDDCODJ, [In] ReadOnlySpan<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>?> EMEAPNCIMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1D5D570", Offset = "0x1D5C970", VA = "0x181D5D570")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> GENNDEFINKP(this KBPEDJPLPIH NHHBAHIFHJK, [In] DBOBIGPCLFL.LBOGJDFLGMN DNMPDLPJNPM, int BFFGCOIILMK, [Optional] JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>? AKPLHCDECML)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1D5BE80", Offset = "0x1D5B280", VA = "0x181D5BE80")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BNKHEGKKGNN(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> CDJPMFLMFBP, int BFFGCOIILMK, [Optional] JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>? AKPLHCDECML)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1D5C9A0", Offset = "0x1D5BDA0", VA = "0x181D5C9A0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> ENIIIAHDPDO(this KBPEDJPLPIH NHHBAHIFHJK, [In] DBOBIGPCLFL FGKKFGCHDEL, int BFFGCOIILMK, [Optional] JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>? AKPLHCDECML)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2615710", Offset = "0x2614B10", VA = "0x182615710")]
	private static void EEFDCNEIFLF<TStateSys, TDeps>(this KBPEDJPLPIH NHHBAHIFHJK, TStateSys LHJOOKKDPIO, TDeps NFFMMJBNJIB) where TStateSys : notnull where TDeps : notnull, FOAEJGFGFCP<TStateSys>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x26159B0", Offset = "0x2614DB0", VA = "0x1826159B0")]
	public static DBOBIGPCLFL NOFJFEBLCPB<TStateSys, TDeps>(this KBPEDJPLPIH NHHBAHIFHJK, TStateSys LHJOOKKDPIO, TDeps NFFMMJBNJIB) where TStateSys : notnull where TDeps : notnull, FOAEJGFGFCP<TStateSys>
	{
		return default(DBOBIGPCLFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x26156F0", Offset = "0x2614AF0", VA = "0x1826156F0")]
	public static LFHOHGKFAGD EDFCDFACOLD<TStateSys, TDeps>(this KBPEDJPLPIH NHHBAHIFHJK, TStateSys LHJOOKKDPIO, TDeps NFFMMJBNJIB) where TStateSys : notnull where TDeps : notnull, FOAEJGFGFCP<TStateSys>
	{
		return default(LFHOHGKFAGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1D5C8A0", Offset = "0x1D5BCA0", VA = "0x181D5C8A0")]
	private static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> EFNOHNDGLBK(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>? CDJPMFLMFBP, int BFFGCOIILMK)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct KCJMJMBNNEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> CJBMAADKCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> DCMMBNIHEDD;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xA42880", Offset = "0xA41C80", VA = "0x180A42880")]
	public KCJMJMBNNEC(JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> GPAELNKNJNO, JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> NAHFDLEOAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1D5F8D0", Offset = "0x1D5ECD0", VA = "0x181D5F8D0")]
	public static KCJMJMBNNEC JKJFENIAMEL(JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> GPAELNKNJNO)
	{
		return default(KCJMJMBNNEC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct EJEKCIJBILF
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public sealed class HIEMJPMIAED : DHNGJJDPLAI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct OFCHDDKEOKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> GIHJAPPJDID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int MEJJBNBBHJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int KCONJIGIJDI;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x18ADC60", Offset = "0x18AD060", VA = "0x1818ADC60")]
		public OFCHDDKEOKD(JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> BAHGEJPOBPF, int OJANCMLFDOJ, int CMHIAJEPKIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class JNEFOIEGOCD : DHNGJJDPLAI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct BGJPKGMGAMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int MEJJBNBBHJJ;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x88AE90", Offset = "0x88A290", VA = "0x18088AE90")]
		public BGJPKGMGAMF(int OJANCMLFDOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class JBJDLLBONJA : DHNGJJDPLAI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct AANOLIGOMCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> GIHJAPPJDID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int MEJJBNBBHJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int KCONJIGIJDI;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x18ADC60", Offset = "0x18AD060", VA = "0x1818ADC60")]
		public AANOLIGOMCI(JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> BAHGEJPOBPF, int OJANCMLFDOJ, int CMHIAJEPKIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum PEIIALFLLAG
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		Temporary,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		Named,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Argument,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		CallerReturnValue,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Parameter,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		CalleeReturnValue
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class GCPJHDDAIBM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class DHNGJJDPLAI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct CCLGGAFPJOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public KCJMJMBNNEC JBJPJIBNJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public PEIIALFLLAG CLLBBANBPDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public JLGMECJOLDI<DHNGJJDPLAI> EFOFPNPFJBM;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1D5B230", Offset = "0x1D5A630", VA = "0x181D5B230")]
		private CCLGGAFPJOA([In] KCJMJMBNNEC MLLMPKJPAGK, PEIIALFLLAG IGJBLBIPNCH, JLGMECJOLDI<DHNGJJDPLAI> KMGGGOILHHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1D5B210", Offset = "0x1D5A610", VA = "0x181D5B210")]
		public static CCLGGAFPJOA JKJFENIAMEL(JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> GPAELNKNJNO, PEIIALFLLAG IGJBLBIPNCH, JLGMECJOLDI<DHNGJJDPLAI> KMGGGOILHHG)
		{
			return default(CCLGGAFPJOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class DCAJBPDDACJ : DHNGJJDPLAI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct NNJOEDHKDOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int KCONJIGIJDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public bool JIHGFPCBNJI;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class HECBDDMPMMK : DHNGJJDPLAI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public struct HDGAGGNODFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int MEJJBNBBHJJ;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x88AE90", Offset = "0x88A290", VA = "0x18088AE90")]
		public HDGAGGNODFN(int OJANCMLFDOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public sealed class EGGBEEFCDPI : DHNGJJDPLAI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct KLCNENMKPNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int KCONJIGIJDI;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x88AE90", Offset = "0x88A290", VA = "0x18088AE90")]
		public KLCNENMKPNM(int CMHIAJEPKIJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal JAPKIEEEPLM<GCPJHDDAIBM, CCLGGAFPJOA> HHDGNDCDABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal JAPKIEEEPLM<EGGBEEFCDPI, KLCNENMKPNM> IOKDGLDAEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal JAPKIEEEPLM<DCAJBPDDACJ, NNJOEDHKDOI> GNBAHPNHNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal JAPKIEEEPLM<HIEMJPMIAED, OFCHDDKEOKD> JPJALIMBAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal JAPKIEEEPLM<JBJDLLBONJA, AANOLIGOMCI> OOAHKODBPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal JAPKIEEEPLM<HECBDDMPMMK, HDGAGGNODFN> LPMMOFAIPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal JAPKIEEEPLM<JNEFOIEGOCD, BGJPKGMGAMF> OAEPNGFFLIL;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B780", Offset = "0x1D5AB80", VA = "0x181D5B780")]
	private EJEKCIJBILF([In] JAPKIEEEPLM<GCPJHDDAIBM, CCLGGAFPJOA> DECFOJFNFME, [In] JAPKIEEEPLM<EGGBEEFCDPI, KLCNENMKPNM> FNBJJFFEPKB, [In] JAPKIEEEPLM<DCAJBPDDACJ, NNJOEDHKDOI> IHMDFPOKIMA, [In] JAPKIEEEPLM<HIEMJPMIAED, OFCHDDKEOKD> HAHNEMJECCJ, [In] JAPKIEEEPLM<JBJDLLBONJA, AANOLIGOMCI> BNJGCIKGAKF, [In] JAPKIEEEPLM<HECBDDMPMMK, HDGAGGNODFN> GKIPCOIOEOI, [In] JAPKIEEEPLM<JNEFOIEGOCD, BGJPKGMGAMF> GEEJHHFEANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B4D0", Offset = "0x1D5A8D0", VA = "0x181D5B4D0")]
	public static EJEKCIJBILF JKJFENIAMEL()
	{
		return default(EJEKCIJBILF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class PDFOFOLGEFI
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1D61120", Offset = "0x1D60520", VA = "0x181D61120")]
	public static void NNIMNMJHJOG(this EJEKCIJBILF NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1D61060", Offset = "0x1D60460", VA = "0x181D61060")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MFIKNGINJOP(this EJEKCIJBILF NHHBAHIFHJK, JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> GPAELNKNJNO, int CMHIAJEPKIJ)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1D60C20", Offset = "0x1D60020", VA = "0x181D60C20")]
	public static void BEPFCFACMIF(this EJEKCIJBILF NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MJIACGIHBFB, JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> BAHGEJPOBPF, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1D60F70", Offset = "0x1D60370", VA = "0x181D60F70")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> JCJGNEGJNNB(this EJEKCIJBILF NHHBAHIFHJK, JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> GPAELNKNJNO, JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> BAHGEJPOBPF, int OJANCMLFDOJ, int CMHIAJEPKIJ)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1D61210", Offset = "0x1D60610", VA = "0x181D61210")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> OCMOPJFJDLE(this EJEKCIJBILF NHHBAHIFHJK, JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> GPAELNKNJNO, int OJANCMLFDOJ)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1D60DC0", Offset = "0x1D601C0", VA = "0x181D60DC0")]
	public static void FCFELLKNIBH(this EJEKCIJBILF NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MJIACGIHBFB, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1D60F00", Offset = "0x1D60300", VA = "0x181D60F00")]
	public static void GIACLOMPKFB(this EJEKCIJBILF NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> PDDHPPHOJPD, JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> LOOFHILODEK)
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
