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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1D7C2E0", Offset = "0x1D7ACE0", VA = "0x181D7C2E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D2560", Offset = "0x7D0F60", VA = "0x1807D2560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7D25A0", Offset = "0x7D0FA0", VA = "0x1807D25A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D7CCE0", Offset = "0x1D7B6E0", VA = "0x181D7CCE0")]
	private PKKJHLCJAKN([In] KLAHACLPKMA<CCLFIJANHEE> MLDABOFDONH, [In] LBFBFNIPGIA<CCLFIJANHEE, object> IKAFDOJLKGE, Dictionary<object, JLGMECJOLDI<CCLFIJANHEE>> JIPAHDDKEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1D7CAC0", Offset = "0x1D7B4C0", VA = "0x181D7CAC0")]
	public static PKKJHLCJAKN JKJFENIAMEL()
	{
		return default(PKKJHLCJAKN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HPMFDCKMAPN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1D7A650", Offset = "0x1D79050", VA = "0x181D7A650")]
	public static void NNIMNMJHJOG(this PKKJHLCJAKN NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1D7A560", Offset = "0x1D78F60", VA = "0x181D7A560")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D765C0", Offset = "0x1D74FC0", VA = "0x181D765C0")]
	private EMLGDLJKPDC([In] FHOAFJPGJCO<int> DFEGFPPFDNE, [In] FHOAFJPGJCO<int> OLJAHMJIDAA, int CLFNBNPIMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1D76530", Offset = "0x1D74F30", VA = "0x181D76530")]
	public static EMLGDLJKPDC JKJFENIAMEL()
	{
		return default(EMLGDLJKPDC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class PPJLFHJPPHO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1D7CD50", Offset = "0x1D7B750", VA = "0x181D7CD50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D75870", Offset = "0x1D74270", VA = "0x181D75870")]
		private ADIKDBKFKDO([In] FHOAFJPGJCO<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>> DFEGFPPFDNE, [In] FHOAFJPGJCO<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>> OLJAHMJIDAA, JLGMECJOLDI<MLIIACGFEJG<KLPEGIKGDIA>> CCNPBJHNEED, EMFOGFIHNHA IGJBLBIPNCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1D757D0", Offset = "0x1D741D0", VA = "0x181D757D0")]
		public static ADIKDBKFKDO JKJFENIAMEL(EMFOGFIHNHA IGJBLBIPNCH)
		{
			return default(ADIKDBKFKDO);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal JAPKIEEEPLM<KLHDDGCLHLM, ADIKDBKFKDO> HHDGNDCDABE;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D7CA90", Offset = "0x1D7B490", VA = "0x181D7CA90")]
	private PGGHPMNBHKA([In] JAPKIEEEPLM<KLHDDGCLHLM, ADIKDBKFKDO> DECFOJFNFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D7CA20", Offset = "0x1D7B420", VA = "0x181D7CA20")]
	public static PGGHPMNBHKA JKJFENIAMEL()
	{
		return default(PGGHPMNBHKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BJDOBODKCHM
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1D75B30", Offset = "0x1D74530", VA = "0x181D75B30")]
	public static void NNIMNMJHJOG(this PGGHPMNBHKA.ADIKDBKFKDO NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1D75B80", Offset = "0x1D74580", VA = "0x181D75B80")]
	public static void NNIMNMJHJOG(this PGGHPMNBHKA NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1D758D0", Offset = "0x1D742D0", VA = "0x181D758D0")]
	public static KLAHACLPKMA<PGGHPMNBHKA.KLHDDGCLHLM> EEMBANPOOIA([In] this PGGHPMNBHKA NHHBAHIFHJK)
	{
		return default(KLAHACLPKMA<PGGHPMNBHKA.KLHDDGCLHLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1D75910", Offset = "0x1D74310", VA = "0x181D75910")]
	public static JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> GEGPOIBGIKD(this PGGHPMNBHKA NHHBAHIFHJK)
	{
		return default(JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1D75A20", Offset = "0x1D74420", VA = "0x181D75A20")]
	public static JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> IFKLPGGGNCF(this PGGHPMNBHKA NHHBAHIFHJK)
	{
		return default(JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1D75D90", Offset = "0x1D74790", VA = "0x181D75D90")]
	public static void PKGNPALMLGA(this PGGHPMNBHKA NHHBAHIFHJK, JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> PDDHPPHOJPD, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MJIACGIHBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1D75D10", Offset = "0x1D74710", VA = "0x181D75D10")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D7ADE0", Offset = "0x1D797E0", VA = "0x181D7ADE0")]
	private KBPEDJPLPIH([In] FHOAFJPGJCO<byte> AFHPFLFPLOF, [In] PGGHPMNBHKA GAMCKLAMHIE, [In] EJEKCIJBILF HGOBGEEIMPF, [In] PKKJHLCJAKN LIAINIKHGPL, [In] LBFBFNIPGIA<JOHHLDIDKOB, DBOBIGPCLFL?> KPEMCHLFOMO, [In] FHOAFJPGJCO<JLGMECJOLDI<JOHHLDIDKOB>> CPAEMIEGOCN, [In] LBFBFNIPGIA<HIPKLPLFKLJ, JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>>?> FPBMDBPEBIK, [In] FHOAFJPGJCO<(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> VariableId, JLGMECJOLDI<MLIIACGFEJG<NMPFNBKMFCL<DJLDLENNLAH>>> ByteCodeWriteLocation)> NPCBEBPMDMI, [In] FHOAFJPGJCO<(JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> Target, JLGMECJOLDI<MLIIACGFEJG<MLIIACGFEJG<IDIDHCJPJCJ>>> ByteCodeWriteLocation)> KCJDMJANKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1D7A6B0", Offset = "0x1D790B0", VA = "0x181D7A6B0")]
	public static KBPEDJPLPIH JKJFENIAMEL()
	{
		return default(KBPEDJPLPIH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NAKPGIJINID
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1D7BF60", Offset = "0x1D7A960", VA = "0x181D7BF60")]
	public static void NNIMNMJHJOG(this KBPEDJPLPIH NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1D7BE50", Offset = "0x1D7A850", VA = "0x181D7BE50")]
	public static JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> MNOOHCBLHFJ(this KBPEDJPLPIH NHHBAHIFHJK)
	{
		return default(JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x27AFAC0", Offset = "0x27AE4C0", VA = "0x1827AFAC0")]
	public static void BMBBBHDPNAF<M>(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MJIACGIHBFB, JLGMECJOLDI<MLIIACGFEJG<NMPFNBKMFCL<M>>> KNOIDJFJLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1D7B980", Offset = "0x1D7A380", VA = "0x181D7B980")]
	public static void FFLFLNLCAFC(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> DAPOBFHGAGK, JLGMECJOLDI<MLIIACGFEJG<MLIIACGFEJG<IDIDHCJPJCJ>>> ALMHIAPGCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1D7BDE0", Offset = "0x1D7A7E0", VA = "0x181D7BDE0")]
	public static void LANABPGCBOH(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> BAHGEJPOBPF, JLGMECJOLDI<MLIIACGFEJG<KLPEGIKGDIA>> CCNPBJHNEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1D7BD30", Offset = "0x1D7A730", VA = "0x181D7BD30")]
	public static void KMFPDOJGAJC(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MJIACGIHBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1D7B770", Offset = "0x1D7A170", VA = "0x181D7B770")]
	public static void CCKAHNPAGGG(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<JOHHLDIDKOB> FLOGJHFICGN, [In] DBOBIGPCLFL LECKFDGPBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1D7B850", Offset = "0x1D7A250", VA = "0x181D7B850")]
	public static void FAOLDPAGLLO(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<JOHHLDIDKOB> FLOGJHFICGN, [In] DBOBIGPCLFL LECKFDGPBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1D7BAA0", Offset = "0x1D7A4A0", VA = "0x181D7BAA0")]
	public static DBOBIGPCLFL? GOOEGCMMFMG([In] this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<JOHHLDIDKOB> FLOGJHFICGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x27AFB80", Offset = "0x27AE580", VA = "0x1827AFB80")]
	public static DBOBIGPCLFL CKPCCLCJGDE<TDeps, TStateSys>(this KBPEDJPLPIH NHHBAHIFHJK, TDeps NFFMMJBNJIB, TStateSys LHJOOKKDPIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB, JLGMECJOLDI<HIPKLPLFKLJ> FIPNEPOHCEF) where TDeps : FOAEJGFGFCP<TStateSys>
	{
		return default(DBOBIGPCLFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1D7C180", Offset = "0x1D7AB80", VA = "0x181D7C180")]
	private static void PKNFCDFJKFH(this KBPEDJPLPIH NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1D7BA10", Offset = "0x1D7A410", VA = "0x181D7BA10")]
	private static JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>>? GLMLDFOEIJL([In] this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<HIPKLPLFKLJ> FIPNEPOHCEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x27B2730", Offset = "0x27B1130", VA = "0x1827B2730")]
	public static LFHOHGKFAGD HCHAAJGPMDI<TDeps, TStateSys>(this KBPEDJPLPIH NHHBAHIFHJK, TDeps NFFMMJBNJIB, TStateSys LHJOOKKDPIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB, JLGMECJOLDI<JOHHLDIDKOB> FLOGJHFICGN) where TDeps : FOAEJGFGFCP<TStateSys>
	{
		return default(LFHOHGKFAGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1D7B610", Offset = "0x1D7A010", VA = "0x181D7B610")]
	public static void AJKGHPADJHD(this KBPEDJPLPIH NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x27B05E0", Offset = "0x27AEFE0", VA = "0x1827B05E0")]
	public static int ELANFAJEPDN<TDeps, TStateSys>(this KBPEDJPLPIH NHHBAHIFHJK, TDeps NFFMMJBNJIB, TStateSys LHJOOKKDPIO, JLGMECJOLDI<BIKLLPOLGEF> KGGOGFBCEKB, LBFBFNIPGIA<PGGHPMNBHKA.KLHDDGCLHLM, EMLGDLJKPDC> KDIPLCBEEEH) where TDeps : FOAEJGFGFCP<TStateSys>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1D7BB60", Offset = "0x1D7A560", VA = "0x181D7BB60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8964E0", Offset = "0x894EE0", VA = "0x1808964E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D7B5E0", Offset = "0x1D79FE0", VA = "0x181D7B5E0")]
		private LBOGJDFLGMN([In] ReadOnlyMemory<byte> PEBEDGMMHMC, BKILFBCIGKN HOPLPMKDEIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B170", Offset = "0x1D79B70", VA = "0x181D7B170")]
		public static LBOGJDFLGMN FEBFKEGDCNI(bool LAFDDICOPFM)
		{
			return default(LBOGJDFLGMN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B2A0", Offset = "0x1D79CA0", VA = "0x181D7B2A0")]
		public static LBOGJDFLGMN HCIJDLNDLDE([In] ReadOnlyMemory<byte> PEBEDGMMHMC)
		{
			return default(LBOGJDFLGMN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B2E0", Offset = "0x1D79CE0", VA = "0x181D7B2E0")]
		public static LBOGJDFLGMN KAOPBGBBIGL(int HELELFNPBBH)
		{
			return default(LBOGJDFLGMN);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B1D0", Offset = "0x1D79BD0", VA = "0x181D7B1D0")]
		public static bool FFFIMEBHMPG([In] LBOGJDFLGMN CGDDINAJAOB, [In] LBOGJDFLGMN GIFBDNCPDKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B020", Offset = "0x1D79A20", VA = "0x181D7B020", Slot = "4")]
		public bool Equals(LBOGJDFLGMN AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B1D0", Offset = "0x1D79BD0", VA = "0x181D7B1D0")]
		public bool MLPLMDDOIJN([In] LBOGJDFLGMN AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B090", Offset = "0x1D79A90", VA = "0x181D7B090", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B240", Offset = "0x1D79C40", VA = "0x181D7B240", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B330", Offset = "0x1D79D30", VA = "0x181D7B330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1D7B1D0", Offset = "0x1D79BD0", VA = "0x181D7B1D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8964E0", Offset = "0x894EE0", VA = "0x1808964E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D76080", Offset = "0x1D74A80", VA = "0x181D76080")]
	private DBOBIGPCLFL(BLNGOBJJMEN FEAIAIPEEKK, [In] LBOGJDFLGMN DNMPDLPJNPM, ICCPAPECPGJ KKFGPFKAMKM, OOJJMJHPGBO JBAFOMDHMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1D75FA0", Offset = "0x1D749A0", VA = "0x181D75FA0")]
	public static DBOBIGPCLFL MLAIGNBNJOA(JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> AJDKHMNHOII)
	{
		return default(DBOBIGPCLFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1D75F10", Offset = "0x1D74910", VA = "0x181D75F10")]
	public static DBOBIGPCLFL LMEIGJLBFBE(bool LAFDDICOPFM)
	{
		return default(DBOBIGPCLFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1D75EA0", Offset = "0x1D748A0", VA = "0x181D75EA0")]
	public static DBOBIGPCLFL DJGGEKNODGI([In] ReadOnlyMemory<byte> PEBEDGMMHMC)
	{
		return default(DBOBIGPCLFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1D75FF0", Offset = "0x1D749F0", VA = "0x181D75FF0")]
	public static DBOBIGPCLFL NOLNGEKJJKO(int HELELFNPBBH)
	{
		return default(DBOBIGPCLFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1D75E40", Offset = "0x1D74840", VA = "0x181D75E40")]
	public static DBOBIGPCLFL CPLHJMHAHKN(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> EHMIDGEEBFF)
	{
		return default(DBOBIGPCLFL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class KBLKLHKFBEP
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380")]
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
	[Cpp2IlInjected.Address(RVA = "0x8964E0", Offset = "0x894EE0", VA = "0x1808964E0")]
	private LFHOHGKFAGD(LGJBEJCDFDO JBAFOMDHMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380")]
	public static LFHOHGKFAGD MLAIGNBNJOA()
	{
		return default(LFHOHGKFAGD);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380")]
	public static LFHOHGKFAGD GNEBLBHEEHN([In] DBOBIGPCLFL JHEMNDMHNOB)
	{
		return default(LFHOHGKFAGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7F2CB0", Offset = "0x7F16B0", VA = "0x1807F2CB0")]
	public static LFHOHGKFAGD NAJNOKAIMML()
	{
		return default(LFHOHGKFAGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8A3970", Offset = "0x8A2370", VA = "0x1808A3970")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D76D00", Offset = "0x1D75700", VA = "0x181D76D00")]
	public static JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> CBHLNEFLPEL([In] this KBPEDJPLPIH NHHBAHIFHJK)
	{
		return default(JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1D79F10", Offset = "0x1D78910", VA = "0x181D79F10")]
	private static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> NMAGBECKDBP(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> BAHGEJPOBPF, int OJANCMLFDOJ, int CMHIAJEPKIJ)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1D7A250", Offset = "0x1D78C50", VA = "0x181D7A250")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> OCMOPJFJDLE(this KBPEDJPLPIH NHHBAHIFHJK, int OJANCMLFDOJ)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D79740", Offset = "0x1D78140", VA = "0x181D79740")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MFIKNGINJOP(this KBPEDJPLPIH NHHBAHIFHJK, int BFFGCOIILMK)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1D768E0", Offset = "0x1D752E0", VA = "0x181D768E0")]
	private static void BEPFCFACMIF(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MJIACGIHBFB, JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> BAHGEJPOBPF, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1D77B10", Offset = "0x1D76510", VA = "0x181D77B10")]
	public static void FCFELLKNIBH(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MJIACGIHBFB, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1D7A370", Offset = "0x1D78D70", VA = "0x181D7A370")]
	private static void OFDCNJNFGKC(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> BAHGEJPOBPF, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> PDDHPPHOJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1D7A4E0", Offset = "0x1D78EE0", VA = "0x181D7A4E0")]
	private static void PKGNPALMLGA(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> BAHGEJPOBPF, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> PDDHPPHOJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1D77F10", Offset = "0x1D76910", VA = "0x181D77F10")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FJIPAPPNDPB(this KBPEDJPLPIH NHHBAHIFHJK, float FOLCJDPBAHJ, float BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1D797C0", Offset = "0x1D781C0", VA = "0x181D797C0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MHCEGEMJEIM(this KBPEDJPLPIH NHHBAHIFHJK, float FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1D76D60", Offset = "0x1D75760", VA = "0x181D76D60")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> CECIEAJJCBE(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1D774B0", Offset = "0x1D75EB0", VA = "0x181D774B0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> DJJCEMLMPMG(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, int BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1D79480", Offset = "0x1D77E80", VA = "0x181D79480")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> LHCIBFLCPAI(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1D773C0", Offset = "0x1D75DC0", VA = "0x181D773C0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> DJJBAHMCNGD(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1D77C50", Offset = "0x1D76650", VA = "0x181D77C50")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FCFPOHNAAIM(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, int BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1D792B0", Offset = "0x1D77CB0", VA = "0x181D792B0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> KOIPHMPLCGE(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1D76610", Offset = "0x1D75010", VA = "0x181D76610")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> ADHEHDGBHGE(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1D79570", Offset = "0x1D77F70", VA = "0x181D79570")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> LLJIEIDDMKA(this KBPEDJPLPIH NHHBAHIFHJK, int CGDDINAJAOB, int GIFBDNCPDKC)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1D79D30", Offset = "0x1D78730", VA = "0x181D79D30")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> NKANBPGDNKG(this KBPEDJPLPIH NHHBAHIFHJK, int CGDDINAJAOB, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> GIFBDNCPDKC)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1D7A3F0", Offset = "0x1D78DF0", VA = "0x181D7A3F0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> OINILJAEBIM(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> CGDDINAJAOB, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> GIFBDNCPDKC)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1D77590", Offset = "0x1D75F90", VA = "0x181D77590")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> EBFOJLHABKB(this KBPEDJPLPIH NHHBAHIFHJK, float CGDDINAJAOB, float GIFBDNCPDKC)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1D7A050", Offset = "0x1D78A50", VA = "0x181D7A050")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> NNJFOCDGGJJ(this KBPEDJPLPIH NHHBAHIFHJK, float CGDDINAJAOB, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> GIFBDNCPDKC)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1D79C40", Offset = "0x1D78640", VA = "0x181D79C40")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> NCFDDIPBBID(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> CGDDINAJAOB, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> GIFBDNCPDKC)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1D76F50", Offset = "0x1D75950", VA = "0x181D76F50")]
	public static void DGKGOPFFGIA(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EFDJLNOJKKM> IOKDJPPOKHD, [In] ReadOnlySpan<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>> OLJAHMJIDAA, [In] ReadOnlySpan<int> OLDJLECAKBN, [In] Span<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>> NAIOEMHLLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1D78D40", Offset = "0x1D77740", VA = "0x181D78D40")]
	public static void IPOMLBNMKDB(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<MCGCPIODCLF> OLGPONHEIMP, [In] ReadOnlySpan<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>> OLJAHMJIDAA, [In] ReadOnlySpan<int> OLDJLECAKBN, [In] Span<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>> NAIOEMHLLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1D78600", Offset = "0x1D77000", VA = "0x181D78600")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> GGBDBJCMFIK(this KBPEDJPLPIH NHHBAHIFHJK, int DNFMACCGFHJ, [Optional] JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>? AKPLHCDECML)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1D79A90", Offset = "0x1D78490", VA = "0x181D79A90")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> NAKHCAPHEJA(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> DNFMACCGFHJ, [Optional] JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>? AKPLHCDECML)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1D76C20", Offset = "0x1D75620", VA = "0x181D76C20")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> CAGBNABCFIC(this KBPEDJPLPIH NHHBAHIFHJK, [In] ReadOnlySpan<byte> DNFMACCGFHJ, [Optional] JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>? AKPLHCDECML)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1D76E50", Offset = "0x1D75850", VA = "0x181D76E50")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> CHBPKPPDIHN(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> DNFMACCGFHJ, int BFFGCOIILMK, [Optional] JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>? AKPLHCDECML)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D787A0", Offset = "0x1D771A0", VA = "0x181D787A0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> HLABEBGGAGA(this KBPEDJPLPIH NHHBAHIFHJK, float FOLCJDPBAHJ, float BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1D76700", Offset = "0x1D75100", VA = "0x181D76700")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> AIBGEAINLAE(this KBPEDJPLPIH NHHBAHIFHJK, float FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1D78980", Offset = "0x1D77380", VA = "0x181D78980")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> IBANDICLJKJ(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1D78000", Offset = "0x1D76A00", VA = "0x181D78000")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FPKOHJFGCCB(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, int BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1D77D30", Offset = "0x1D76730", VA = "0x181D77D30")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FICAPGCLDFK(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1D798B0", Offset = "0x1D782B0", VA = "0x181D798B0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MKILNJEHGDK(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1D78C50", Offset = "0x1D77650", VA = "0x181D78C50")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> IFFAAENDJDN(this KBPEDJPLPIH NHHBAHIFHJK, float FOLCJDPBAHJ, float BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1D7A150", Offset = "0x1D78B50", VA = "0x181D7A150")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> OAOIPOCFNIC(this KBPEDJPLPIH NHHBAHIFHJK, float FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1D78890", Offset = "0x1D77290", VA = "0x181D78890")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> IAPKBFOPLEO(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1D786C0", Offset = "0x1D770C0", VA = "0x181D786C0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> HBJKDFNFBEF(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, int BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1D77780", Offset = "0x1D76180", VA = "0x181D77780")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> EHDBIELLBIK(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1D772D0", Offset = "0x1D75CD0", VA = "0x181D772D0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> DGMGLPMEJKH(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1D791B0", Offset = "0x1D77BB0", VA = "0x181D791B0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> JKKLBMHHIFF(this KBPEDJPLPIH NHHBAHIFHJK, float FOLCJDPBAHJ, float BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1D799A0", Offset = "0x1D783A0", VA = "0x181D799A0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MLFEFFIKIJF(this KBPEDJPLPIH NHHBAHIFHJK, float FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1D790C0", Offset = "0x1D77AC0", VA = "0x181D790C0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> JBNLCOMNPEL(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1D79B60", Offset = "0x1D78560", VA = "0x181D79B60")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> NCDIAEAILNB(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, int BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1D78B60", Offset = "0x1D77560", VA = "0x181D78B60")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> IDCOJOGDFEC(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1D79E20", Offset = "0x1D78820", VA = "0x181D79E20")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> NLOFJMDNMMH(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1D792A0", Offset = "0x1D77CA0", VA = "0x181D792A0")]
	public static void JNLLBFCHFHJ(this KBPEDJPLPIH NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D78350", Offset = "0x1D76D50", VA = "0x181D78350")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> GEENKPKFNJH(this KBPEDJPLPIH NHHBAHIFHJK, float FOLCJDPBAHJ, float BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1D767F0", Offset = "0x1D751F0", VA = "0x181D767F0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> ALPCLJDKMFJ(this KBPEDJPLPIH NHHBAHIFHJK, float FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1D79650", Offset = "0x1D78050", VA = "0x181D79650")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> LMKGEJCIKHH(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1D793A0", Offset = "0x1D77DA0", VA = "0x181D793A0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> LBMGMALCKLP(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, int BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1D77E20", Offset = "0x1D76820", VA = "0x181D77E20")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FJANDAIEPLI(this KBPEDJPLPIH NHHBAHIFHJK, int FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1D78A70", Offset = "0x1D77470", VA = "0x181D78A70")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> IBJAMLCAFOP(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> FOLCJDPBAHJ, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BEHLMMBFHLA)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1D780E0", Offset = "0x1D76AE0", VA = "0x181D780E0")]
	public static void GDHHJLEGLOH(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<MCGCPIODCLF> BINBFFLGBGL, [In] ReadOnlySpan<(DBOBIGPCLFL DataBack, int Size)> PPONEGNNAIF, [In] ReadOnlySpan<int> OLDJLECAKBN, [In] Span<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>> NAIOEMHLLHI, [In] Span<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>> JNPIGDDCODJ, [In] ReadOnlySpan<JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>?> EMEAPNCIMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1D78440", Offset = "0x1D76E40", VA = "0x181D78440")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> GENNDEFINKP(this KBPEDJPLPIH NHHBAHIFHJK, [In] DBOBIGPCLFL.LBOGJDFLGMN DNMPDLPJNPM, int BFFGCOIILMK, [Optional] JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>? AKPLHCDECML)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1D76A80", Offset = "0x1D75480", VA = "0x181D76A80")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> BNKHEGKKGNN(this KBPEDJPLPIH NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> CDJPMFLMFBP, int BFFGCOIILMK, [Optional] JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>? AKPLHCDECML)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1D77870", Offset = "0x1D76270", VA = "0x181D77870")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> ENIIIAHDPDO(this KBPEDJPLPIH NHHBAHIFHJK, [In] DBOBIGPCLFL FGKKFGCHDEL, int BFFGCOIILMK, [Optional] JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>? AKPLHCDECML)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x266A6E0", Offset = "0x26690E0", VA = "0x18266A6E0")]
	private static void EEFDCNEIFLF<TStateSys, TDeps>(this KBPEDJPLPIH NHHBAHIFHJK, TStateSys LHJOOKKDPIO, TDeps NFFMMJBNJIB) where TStateSys : notnull where TDeps : notnull, FOAEJGFGFCP<TStateSys>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x266A980", Offset = "0x2669380", VA = "0x18266A980")]
	public static DBOBIGPCLFL NOFJFEBLCPB<TStateSys, TDeps>(this KBPEDJPLPIH NHHBAHIFHJK, TStateSys LHJOOKKDPIO, TDeps NFFMMJBNJIB) where TStateSys : notnull where TDeps : notnull, FOAEJGFGFCP<TStateSys>
	{
		return default(DBOBIGPCLFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x266A6C0", Offset = "0x26690C0", VA = "0x18266A6C0")]
	public static LFHOHGKFAGD EDFCDFACOLD<TStateSys, TDeps>(this KBPEDJPLPIH NHHBAHIFHJK, TStateSys LHJOOKKDPIO, TDeps NFFMMJBNJIB) where TStateSys : notnull where TDeps : notnull, FOAEJGFGFCP<TStateSys>
	{
		return default(LFHOHGKFAGD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1D77680", Offset = "0x1D76080", VA = "0x181D77680")]
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

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xA4E280", Offset = "0xA4CC80", VA = "0x180A4E280")]
	public KCJMJMBNNEC(JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> GPAELNKNJNO, JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> NAHFDLEOAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1D7B010", Offset = "0x1D79A10", VA = "0x181D7B010")]
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

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x18C5ED0", Offset = "0x18C48D0", VA = "0x1818C5ED0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8964E0", Offset = "0x894EE0", VA = "0x1808964E0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x18C5ED0", Offset = "0x18C48D0", VA = "0x1818C5ED0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1D75E30", Offset = "0x1D74830", VA = "0x181D75E30")]
		private CCLGGAFPJOA([In] KCJMJMBNNEC MLLMPKJPAGK, PEIIALFLLAG IGJBLBIPNCH, JLGMECJOLDI<DHNGJJDPLAI> KMGGGOILHHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1D75E10", Offset = "0x1D74810", VA = "0x181D75E10")]
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

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8964E0", Offset = "0x894EE0", VA = "0x1808964E0")]
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

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8964E0", Offset = "0x894EE0", VA = "0x1808964E0")]
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

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1D76380", Offset = "0x1D74D80", VA = "0x181D76380")]
	private EJEKCIJBILF([In] JAPKIEEEPLM<GCPJHDDAIBM, CCLGGAFPJOA> DECFOJFNFME, [In] JAPKIEEEPLM<EGGBEEFCDPI, KLCNENMKPNM> FNBJJFFEPKB, [In] JAPKIEEEPLM<DCAJBPDDACJ, NNJOEDHKDOI> IHMDFPOKIMA, [In] JAPKIEEEPLM<HIEMJPMIAED, OFCHDDKEOKD> HAHNEMJECCJ, [In] JAPKIEEEPLM<JBJDLLBONJA, AANOLIGOMCI> BNJGCIKGAKF, [In] JAPKIEEEPLM<HECBDDMPMMK, HDGAGGNODFN> GKIPCOIOEOI, [In] JAPKIEEEPLM<JNEFOIEGOCD, BGJPKGMGAMF> GEEJHHFEANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1D760D0", Offset = "0x1D74AD0", VA = "0x181D760D0")]
	public static EJEKCIJBILF JKJFENIAMEL()
	{
		return default(EJEKCIJBILF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class PDFOFOLGEFI
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1D7C860", Offset = "0x1D7B260", VA = "0x181D7C860")]
	public static void NNIMNMJHJOG(this EJEKCIJBILF NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1D7C7A0", Offset = "0x1D7B1A0", VA = "0x181D7C7A0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MFIKNGINJOP(this EJEKCIJBILF NHHBAHIFHJK, JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> GPAELNKNJNO, int CMHIAJEPKIJ)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1D7C360", Offset = "0x1D7AD60", VA = "0x181D7C360")]
	public static void BEPFCFACMIF(this EJEKCIJBILF NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MJIACGIHBFB, JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> BAHGEJPOBPF, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1D7C6B0", Offset = "0x1D7B0B0", VA = "0x181D7C6B0")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> JCJGNEGJNNB(this EJEKCIJBILF NHHBAHIFHJK, JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> GPAELNKNJNO, JLGMECJOLDI<PGGHPMNBHKA.KLHDDGCLHLM> BAHGEJPOBPF, int OJANCMLFDOJ, int CMHIAJEPKIJ)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1D7C950", Offset = "0x1D7B350", VA = "0x181D7C950")]
	public static JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> OCMOPJFJDLE(this EJEKCIJBILF NHHBAHIFHJK, JLGMECJOLDI<MLIIACGFEJG<IDIDHCJPJCJ>> GPAELNKNJNO, int OJANCMLFDOJ)
	{
		return default(JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1D7C500", Offset = "0x1D7AF00", VA = "0x181D7C500")]
	public static void FCFELLKNIBH(this EJEKCIJBILF NHHBAHIFHJK, JLGMECJOLDI<EJEKCIJBILF.GCPJHDDAIBM> MJIACGIHBFB, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1D7C640", Offset = "0x1D7B040", VA = "0x181D7C640")]
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
