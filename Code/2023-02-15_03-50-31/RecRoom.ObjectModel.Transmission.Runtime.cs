using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.Toolkit.HighPerformance.Buffers;
using Mono.Math;
using Nito.Collections;
using RecRoom.ObjectModel;
using RecRoom.ObjectModel.Transmission;
using Unity.Collections;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class NCIDNNGEDEO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private KICCKOIDPBO HBPEOGPLFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private KICCKOIDPBO POKIDGHBJOH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x639D4F0", Offset = "0x639C8F0", VA = "0x18639D4F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x639D530", Offset = "0x639C930", VA = "0x18639D530")]
	public NCIDNNGEDEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FECLFGCBMKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly FileStream EPMHFOMBHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private Task DFOKIJANOCO;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x639AE70", Offset = "0x639A270", VA = "0x18639AE70")]
	private UnmanagedMemoryStream AHMNNNOHEFI(NativeList<byte> NHOGENNANEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[KFMPJDNIPEO(JHCKAKNDFFP.Application)]
public interface LKAABLKDBAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHPLHEMDKDN(int NPNCGJAPKIL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJAHCCJNDFI(int NPNCGJAPKIL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[LOJIIDJFKAI(typeof(LKAABLKDBAJ), new string[] { })]
public class ALIIIGMCGFP : LKAABLKDBAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private MDFFEMBCHAF KFOCKHDJNMO;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x153EC50", Offset = "0x153E050", VA = "0x18153EC50", Slot = "5")]
	public void BJAHCCJNDFI(int NPNCGJAPKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6396940", Offset = "0x6395D40", VA = "0x186396940", Slot = "4")]
	public void OHPLHEMDKDN(int NPNCGJAPKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6396950", Offset = "0x6395D50", VA = "0x186396950")]
	public ALIIIGMCGFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class ALJJJEBEIBH
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct MDFFEMBCHAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public int OPLOKOGHFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public int LMCJKAIMNHE;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[LOJIIDJFKAI(typeof(MMFAICNEGNG), new string[] { })]
public class JAOOEFJANFP : MMFAICNEGNG, JHAPMNIDGIE, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[IMNMHIBEIDL]
	private CKLCNCEGFJL FALMDJENKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[IMNMHIBEIDL]
	private JBAGHGJLPDN JKFMGNOHJAO;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x639C710", Offset = "0x639BB10", VA = "0x18639C710", Slot = "5")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x639C580", Offset = "0x639B980", VA = "0x18639C580", Slot = "4")]
	public void OLDKFHFNEIH(IHLDPPPJBMN EBOEHIFNNLM, ReadOnlyMemory<byte> KBGLHNCEHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public JAOOEFJANFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[LOJIIDJFKAI(typeof(JHAPMNIDGIE), new string[] { })]
public class KLAMKFFCKDN : DPDCPMNGBKH, JHAPMNIDGIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[IMNMHIBEIDL]
	private ONCHKBFFGOO FABKDBFOMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[IMNMHIBEIDL]
	private MMFAICNEGNG NKGIHOPAIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[IMNMHIBEIDL]
	private ADMIKKBEDIN LNJLGDKOFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private FNCOHMIDMDB DPKKHGCIENJ;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x639CFA0", Offset = "0x639C3A0", VA = "0x18639CFA0", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x639CDE0", Offset = "0x639C1E0", VA = "0x18639CDE0", Slot = "5")]
	public void OLDKFHFNEIH(IHLDPPPJBMN EBOEHIFNNLM, ReadOnlyMemory<byte> KBGLHNCEHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public KLAMKFFCKDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[LOJIIDJFKAI(typeof(ONCHKBFFGOO), new string[] { })]
public class HOBJFGJKKLE : DPDCPMNGBKH, ONCHKBFFGOO, JHAPMNIDGIE
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private struct KPELPGFGDPG : IEqualityComparer<KPELPGFGDPG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public IHLDPPPJBMN EBOEHIFNNLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public IMemoryOwner<byte> KBGLHNCEHFF;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F670", Offset = "0x2D8EA70", VA = "0x182D8F670")]
		public KPELPGFGDPG(IHLDPPPJBMN EBOEHIFNNLM, IMemoryOwner<byte> KBGLHNCEHFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x639D050", Offset = "0x639C450", VA = "0x18639D050", Slot = "0")]
		public override bool Equals(object ADHHHFDPAPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x639D110", Offset = "0x639C510", VA = "0x18639D110", Slot = "4")]
		public bool Equals(KPELPGFGDPG BIAIPPDLOMD, KPELPGFGDPG ECJDGGJBGPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x639D140", Offset = "0x639C540", VA = "0x18639D140", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x639D140", Offset = "0x639C540", VA = "0x18639D140", Slot = "5")]
		public int GetHashCode(KPELPGFGDPG ADHHHFDPAPI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x639D1B0", Offset = "0x639C5B0", VA = "0x18639D1B0")]
		public PJFDNGLBKCH IBFOBLEGCKH()
		{
			return default(PJFDNGLBKCH);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private MIPAJPBOJKO KLKKDLFFHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[IMNMHIBEIDL]
	private MNCPFFBIPBM PIOIBKPFDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly global::GCMHCAIPOAB<Deque<KPELPGFGDPG>> GPNCOKNMELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int FANJJCGGBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int HOEDGDMFPAL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int APIEHMDNFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F0AD0", Offset = "0x6EFED0", VA = "0x1806F0AD0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x639BA10", Offset = "0x639AE10", VA = "0x18639BA10", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x639B7B0", Offset = "0x639ABB0", VA = "0x18639B7B0", Slot = "7")]
	public void FPNLAFLJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x639B8A0", Offset = "0x639ACA0", VA = "0x18639B8A0", Slot = "8")]
	public void OLDKFHFNEIH(IHLDPPPJBMN EBOEHIFNNLM, ReadOnlyMemory<byte> FGCHPEJCAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x639B740", Offset = "0x639AB40", VA = "0x18639B740", Slot = "6")]
	public IHLDPPPJBMN AOHDPLOGJNF()
	{
		return default(IHLDPPPJBMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x639BA80", Offset = "0x639AE80", VA = "0x18639BA80")]
	public HOBJFGJKKLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[LOJIIDJFKAI(typeof(PCLKDHMAHBL), new string[] { })]
public class MBKGKLPMNNJ : PCLKDHMAHBL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HLAJIEGPHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7DF3D0", Offset = "0x7DE7D0", VA = "0x1807DF3D0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	[Preserve]
	public MBKGKLPMNNJ()
	{
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[MBALNPKLAGP(FOFKCKDBIPD.NetworkSend)]
	[LOJIIDJFKAI(typeof(CBKFGLANBFD), new string[] { })]
	public class ChunkWriterService : JNMOIIJNEHL, LFPMKPLIAAM, DPDCPMNGBKH, FPHKGEBJIKC, CBKFGLANBFD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly int NONIGMNJBKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private MIPAJPBOJKO KLKKDLFFHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[IMNMHIBEIDL]
		private CKLCNCEGFJL FALMDJENKGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[IMNMHIBEIDL]
		private ONCHKBFFGOO FABKDBFOMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[IMNMHIBEIDL]
		private PCLKDHMAHBL KINMHJMGOEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly GDKEGMAHJIA MLHHLBBHLIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly GDKEGMAHJIA GDIMKCHOLDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly int PCFJGOODJGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int FACHOJCMPIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private byte[] HMCHFOHJMEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private byte[] NCDJFNBBLFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private (int bytes, int bits) DEPFCFPNCOH;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public GDKEGMAHJIA BJJEOOBONPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x77D5F0", Offset = "0x77C9F0", VA = "0x18077D5F0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6397CB0", Offset = "0x63970B0", VA = "0x186397CB0")]
		public ChunkWriterService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6397D80", Offset = "0x6397180", VA = "0x186397D80")]
		public ChunkWriterService(int PCFJGOODJGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6396F80", Offset = "0x6396380", VA = "0x186396F80", Slot = "4")]
		public void JLJMFLGJEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6397B60", Offset = "0x6396F60", VA = "0x186397B60", Slot = "5")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6397450", Offset = "0x6396850", VA = "0x186397450", Slot = "6")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6396F80", Offset = "0x6396380", VA = "0x186396F80", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6397400", Offset = "0x6396800", VA = "0x186397400", Slot = "10")]
		public void FPNLAFLJCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6397440", Offset = "0x6396840", VA = "0x186397440", Slot = "9")]
		public void GDABCFKGMAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6396BE0", Offset = "0x6395FE0", VA = "0x186396BE0", Slot = "8")]
		public void AHNBIKLGCNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6397090", Offset = "0x6396490", VA = "0x186397090")]
		private void EHFBLEKJNGC(int ELEDMGMIIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6397150", Offset = "0x6396550", VA = "0x186397150")]
		private void FHOJKBBBJHG(bool ODOPEODNDPB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6397600", Offset = "0x6396A00", VA = "0x186397600")]
		private void KEAKGNABBBJ((int bytes, int bits) IHGEDBBELKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6397A30", Offset = "0x6396E30", VA = "0x186397A30")]
		private ReadOnlyMemory<byte> OAHIPHJPDLM((int bytes, int bits) IHGEDBBELKI)
		{
			return default(ReadOnlyMemory<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6397890", Offset = "0x6396C90", VA = "0x186397890")]
		private void LGEGBEDACDK((int bytes, int bits) IDCHKLCNMBN, (int bytes, int bits) HEGLMOCOEGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6396BF0", Offset = "0x6395FF0", VA = "0x186396BF0")]
		private ReadOnlyMemory<byte> AKDIOFCMINI(Memory<byte> HCHNJGMBMMC, (int bytes, int bits) HJLFGOAABDN)
		{
			return default(ReadOnlyMemory<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6396EB0", Offset = "0x63962B0", VA = "0x186396EB0")]
		private (int, int) BKKGFOBDKGF()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6396F40", Offset = "0x6396340", VA = "0x186396F40")]
		private void CHJBLPFBADN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6397400", Offset = "0x6396800", VA = "0x186397400")]
		private void KPHMALMMEMN()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[LOJIIDJFKAI(typeof(CKLCNCEGFJL), new string[] { })]
public class IMEEEKEFLKA : CKLCNCEGFJL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly bool HAHGPPMAAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] KMPLJJPKHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private byte[] IKNPBJKJNDB;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xC398E0", Offset = "0xC38CE0", VA = "0x180C398E0")]
	public IMEEEKEFLKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x9AA560", Offset = "0x9A9960", VA = "0x1809AA560")]
	public IMEEEKEFLKA(bool HAHGPPMAAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x639C320", Offset = "0x639B720", VA = "0x18639C320", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x639C3F0", Offset = "0x639B7F0", VA = "0x18639C3F0", Slot = "4")]
	public void EGNKABKEOEF(int PCAHMJECHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x639BB20", Offset = "0x639AF20", VA = "0x18639BB20")]
	public void ADEFIMBLCDG(in ReadOnlyMemory<byte> ADKJIBICKCJ, out ReadOnlyMemory<byte> CFNNDAOEOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x639BF40", Offset = "0x639B340", VA = "0x18639BF40")]
	public void CJPFBGIPCDE(in ReadOnlyMemory<byte> ADKJIBICKCJ, out ReadOnlyMemory<byte> CFNNDAOEOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x639C570", Offset = "0x639B970", VA = "0x18639C570", Slot = "5")]
	private void PJILJLEDIBP(in ReadOnlyMemory<byte> ADKJIBICKCJ, out ReadOnlyMemory<byte> CFNNDAOEOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x639C560", Offset = "0x639B960", VA = "0x18639C560", Slot = "6")]
	private void NMBKOBDNLPJ(in ReadOnlyMemory<byte> ADKJIBICKCJ, out ReadOnlyMemory<byte> CFNNDAOEOKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[LOJIIDJFKAI(typeof(MNCPFFBIPBM), new string[] { })]
public class FDAJPFIEHIO : MNCPFFBIPBM, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private GAOMEBKFAAA FGFPMOHFMOM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private uint MELJDHBDNKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x639ADC0", Offset = "0x639A1C0", VA = "0x18639ADC0", Slot = "4")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x639AE10", Offset = "0x639A210", VA = "0x18639AE10", Slot = "5")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public FDAJPFIEHIO()
	{
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[LOJIIDJFKAI(typeof(JBAGHGJLPDN), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.NetworkReceive)]
	public class DeltaReaderService : JBAGHGJLPDN, DPDCPMNGBKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly GDKEGMAHJIA OJMODHIKFDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly DeserializedPropertyForwarder BKBHMDFBDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[IMNMHIBEIDL]
		private MNCPFFBIPBM PIOIBKPFDMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[IMNMHIBEIDL]
		private GINHFLNLBFM CNEDOMDONMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[IMNMHIBEIDL]
		private BEHAFONEFJN BBBINPFAAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[IMNMHIBEIDL]
		private KJEMHJEIOEO ELCMIPNJFNP;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6399AF0", Offset = "0x6398EF0", VA = "0x186399AF0", Slot = "5")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6399920", Offset = "0x6398D20", VA = "0x186399920", Slot = "4")]
		public void NDJBHKCBOCI(IHLDPPPJBMN EBOEHIFNNLM, ReadOnlyMemory<byte> FGCHPEJCAHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x63996D0", Offset = "0x6398AD0", VA = "0x1863996D0")]
		public void NDJBHKCBOCI(GDKEGMAHJIA OJMODHIKFDB, JKDEDHBDHBM OKNMPNCPLGN, bool LGLOBJDPOGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6399A00", Offset = "0x6398E00", VA = "0x186399A00")]
		public void PAOMGKMPDAL(IOLFAAOECPP IOCKLNNJMIA, bool LGLOBJDPOGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6399300", Offset = "0x6398700", VA = "0x186399300")]
		public void DMBGCDINDHK(IOLFAAOECPP IOCKLNNJMIA, bool LGLOBJDPOGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x63993D0", Offset = "0x63987D0", VA = "0x1863993D0")]
		public void ILMMIOLFLJE(IOLFAAOECPP IOCKLNNJMIA, bool LGLOBJDPOGN, GDKEGMAHJIA OJMODHIKFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6399BF0", Offset = "0x6398FF0", VA = "0x186399BF0")]
		public DeltaReaderService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[LOJIIDJFKAI(typeof(DOKECPFELPH), new string[] { })]
	[MBALNPKLAGP(FOFKCKDBIPD.NetworkSend)]
	public class DeltaWriterService : DPDCPMNGBKH, DOKECPFELPH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[IMNMHIBEIDL]
		private GINHFLNLBFM CNEDOMDONMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[IMNMHIBEIDL]
		private CBKFGLANBFD OJHNJFEHCKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[IMNMHIBEIDL]
		private KJEMHJEIOEO ELCMIPNJFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[IMNMHIBEIDL]
		private INBLIGACKIF IIIFHEOJELH;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private GDKEGMAHJIA CNFAFKOPEHO
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6399C90", Offset = "0x6399090", VA = "0x186399C90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x639A480", Offset = "0x6399880", VA = "0x18639A480", Slot = "4")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x639A130", Offset = "0x6399530", VA = "0x18639A130")]
		public void MIDOHAAOAKG(IOLFAAOECPP IOCKLNNJMIA, in FANLJDFBPKN ONIBEFDCPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x639A350", Offset = "0x6399750", VA = "0x18639A350", Slot = "6")]
		public void OIGAJOAAOIJ(IOLFAAOECPP IOCKLNNJMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x639A590", Offset = "0x6399990", VA = "0x18639A590")]
		public void PHHHBJEMBDI(IOLFAAOECPP IOCKLNNJMIA, NMLCFAIOCDK MPKOBDPILJB, in LONBCMOJAJF JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6399F30", Offset = "0x6399330", VA = "0x186399F30")]
		private void LHKGFMPFPPE(NMLCFAIOCDK MPKOBDPILJB, in LONBCMOJAJF JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6399DD0", Offset = "0x63991D0", VA = "0x186399DD0")]
		private static void EEJEOFEIIPE(ICAMIIGEPFO IPFKDLFGNOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x639A410", Offset = "0x6399810", VA = "0x18639A410")]
		private void PBMOFOCOOCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6399D40", Offset = "0x6399140", VA = "0x186399D40", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x639A300", Offset = "0x6399700", VA = "0x18639A300")]
		private void NOCJNALLGBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public DeltaWriterService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6399E40", Offset = "0x6399240", VA = "0x186399E40", Slot = "5")]
		private void JHCGAEPAGJP(IOLFAAOECPP PBICEPMHFMD, in FANLJDFBPKN ONIBEFDCPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x639A220", Offset = "0x6399620", VA = "0x18639A220", Slot = "7")]
		private void NBIJFJCINIA(IOLFAAOECPP PBICEPMHFMD, NMLCFAIOCDK MPKOBDPILJB, in LONBCMOJAJF JFBPNBNBHOE)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[MBALNPKLAGP(FOFKCKDBIPD.NetworkReceive)]
	public class DeserializedPropertyForwarder : NGFPDGDPGKP
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private BEHAFONEFJN BBBINPFAAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IOLFAAOECPP IOCKLNNJMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private NMLCFAIOCDK MPKOBDPILJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private bool LGLOBJDPOGN;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x639A6C0", Offset = "0x6399AC0", VA = "0x18639A6C0")]
		public void EHOMOCKHKBC(GDKEGMAHJIA OJMODHIKFDB, NAFDCBJOMHH HIFHBPOKANI, BEHAFONEFJN BBBINPFAAIG, IOLFAAOECPP IOCKLNNJMIA, NMLCFAIOCDK MPKOBDPILJB, bool LGLOBJDPOGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x27C0370", Offset = "0x27BF770", VA = "0x1827C0370")]
		public void HDGCPPMCFIL<T>(in T JFBPNBNBHOE, [Optional] object MAFDHEKFLMG) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public DeserializedPropertyForwarder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x28764D0", Offset = "0x28758D0", VA = "0x1828764D0", Slot = "4")]
		private void DCKBDFLHNCH<T>(in T JFBPNBNBHOE, object MAFDHEKFLMG) where T : struct
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[LOJIIDJFKAI(typeof(MMMCMDMBHHM), new string[] { })]
public class DECOAMFNCIE : MMMCMDMBHHM, OFBAEOMDOIH, DBCDGJLOLCA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class HMOIJBKKHKD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private delegate string LAAEAEDIAOH<T>(in T CDKILDODEEL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private JHLNNPKIFCO FDNPNEDJHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private ONCHKBFFGOO FABKDBFOMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private AODNELIIJCJ HDABMDIKMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private GDKEGMAHJIA ABIHDCBCABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private bool NJLDGBGEGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly global::GCMHCAIPOAB<CHLMDABNGKB> EJIIKHKCAEA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CMBBHCAPAJC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6398640", Offset = "0x6397A40", VA = "0x186398640", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "6")]
	public void DEGPICAHJGE(JHLNNPKIFCO DNPLPNCPPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x63987E0", Offset = "0x6397BE0", VA = "0x1863987E0", Slot = "5")]
	public Task LIFBDBIMAEJ(CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x63986A0", Offset = "0x6397AA0", VA = "0x1863986A0", Slot = "7")]
	private bool IHJHFGPNBDM(Type DDJDPMGLPAE, out object EEMENGAFDFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6398830", Offset = "0x6397C30", VA = "0x186398830")]
	public DECOAMFNCIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class CLHNDNANMEH
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class AEGIGEABOEN : AODNELIIJCJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private IMemoryOwner<byte> PILMMBNBJIG;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6396870", Offset = "0x6395C70", VA = "0x186396870", Slot = "4")]
	public Task MMCIEHAJLAK(ReadOnlySpan<byte> JFBPNBNBHOE, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6396820", Offset = "0x6395C20", VA = "0x186396820", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public AEGIGEABOEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class CGMKMNMHIEL
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[KFMPJDNIPEO(JHCKAKNDFFP.Application)]
	public sealed class PLKGHHLCIMC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PLKGHHLCIMC()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DJFACGLEAKM : DPDCPMNGBKH, PAJDHDDGBCI, BEHAFONEFJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct DGOOEAPCHIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int ELOEOOGBENM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int EMAKBLAIODO;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x74EC80", Offset = "0x74E080", VA = "0x18074EC80")]
		public DGOOEAPCHIG(int ELOEOOGBENM, int EMAKBLAIODO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private delegate string FLCDKMDIIGK<T>(in T CDKILDODEEL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly SortedDictionary<IOLFAAOECPP, SortedDictionary<NMLCFAIOCDK, DGOOEAPCHIG>> KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private GINHFLNLBFM CNEDOMDONMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private BEHAFONEFJN BBBINPFAAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private KJEMHJEIOEO KNGEPEIOMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private DeserializedPropertyForwarder BKBHMDFBDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly GDKEGMAHJIA MLHHLBBHLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ArrayPoolBufferWriter<byte> JLCGCJGMGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private Stream DLMOMMKMLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private uint IAMHCEBJECP;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6398DA0", Offset = "0x63981A0", VA = "0x186398DA0")]
	private void FOIHMNAIABH(in IOLFAAOECPP ONBAMHPEIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6399160", Offset = "0x6398560", VA = "0x186399160", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6398CF0", Offset = "0x63980F0", VA = "0x186398CF0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6398E50", Offset = "0x6398250", VA = "0x186398E50")]
	public void HKECMHKPKCN(IOLFAAOECPP ONBAMHPEIDG, in FANLJDFBPKN ONIBEFDCPGD, bool OCNBEHMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x63988C0", Offset = "0x6397CC0", VA = "0x1863988C0", Slot = "6")]
	public void AJMBANJFKHK(IOLFAAOECPP ONBAMHPEIDG, bool OCNBEHMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x63989B0", Offset = "0x6397DB0", VA = "0x1863989B0")]
	public void DBCEICDGIHA(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF JFBPNBNBHOE, bool OCNBEHMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6398C10", Offset = "0x6398010", VA = "0x186398C10")]
	private SortedDictionary<NMLCFAIOCDK, DGOOEAPCHIG> DEFDLLNJAAO(IOLFAAOECPP ONBAMHPEIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6399210", Offset = "0x6398610", VA = "0x186399210")]
	public DJFACGLEAKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6398FE0", Offset = "0x63983E0", VA = "0x186398FE0", Slot = "5")]
	private void MKPPAMMNHMK(IOLFAAOECPP ONBAMHPEIDG, in FANLJDFBPKN ONIBEFDCPGD, bool OCNBEHMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6398990", Offset = "0x6397D90", VA = "0x186398990", Slot = "7")]
	private void BAOBFJBJOHA(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF JFBPNBNBHOE, bool OCNBEHMFPGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[LOJIIDJFKAI(typeof(CKIHGNIOLNC), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.LoadInstance)]
public class KKONPGMOKEE : CKIHGNIOLNC, DPDCPMNGBKH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct BBJLGOOFICC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public KKONPGMOKEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6396960", Offset = "0x6395D60", VA = "0x186396960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[IMNMHIBEIDL]
	private MMMCMDMBHHM PILMMBNBJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[IMNMHIBEIDL]
	private GAOMEBKFAAA FGFPMOHFMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly CancellationTokenSource DODGJIDAKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private Task NNNMAHNODCK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool LCLFCKFIHOD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x77F530", Offset = "0x77E930", VA = "0x18077F530", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x639CCC0", Offset = "0x639C0C0", VA = "0x18639CCC0", Slot = "5")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x639CBC0", Offset = "0x639BFC0", VA = "0x18639CBC0", Slot = "7")]
	[AsyncStateMachine(typeof(BBJLGOOFICC))]
	public Task JPIABMFGHIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x639CA40", Offset = "0x639BE40", VA = "0x18639CA40", Slot = "4")]
	public bool EFGCJIIBNNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x639CD30", Offset = "0x639C130", VA = "0x18639CD30")]
	public KKONPGMOKEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[LOJIIDJFKAI(typeof(DEMIGFIOEMK), new string[] { })]
public class NPCEIAKKHIM : DEMIGFIOEMK, JNMOIIJNEHL, LFPMKPLIAAM, DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class PHAMGACLNPA : FNFKCLIHOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5AD4510", Offset = "0x5AD3910", VA = "0x185AD4510", Slot = "4")]
		public void HDGCPPMCFIL<TKey, T>(global::MALNIJMODCH<TKey, T> LKAENGEIFGG, object MAFDHEKFLMG) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PHAMGACLNPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private class PFPDMNANFFI : FNFKCLIHOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x35B2270", Offset = "0x35B1670", VA = "0x1835B2270", Slot = "4")]
		public void HDGCPPMCFIL<TKey, T>(global::MALNIJMODCH<TKey, T> LKAENGEIFGG, object MAFDHEKFLMG) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PFPDMNANFFI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly Dictionary<int, Delegate> NOFGIOGCCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[IMNMHIBEIDL]
	private NPFNHEGAPFJ KEFDOOCIHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[IMNMHIBEIDL]
	private BKOAPAPEJAI OLMPCNJEJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[IMNMHIBEIDL]
	private KJEMHJEIOEO ELCMIPNJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[IMNMHIBEIDL]
	private POIJNILNJOE ONNGBJNFMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[IMNMHIBEIDL]
	private OCNNCEMNKMG LJMEBHLNOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[IMNMHIBEIDL]
	private FNCOHMIDMDB OKPOBPNCFMK;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x639DFE0", Offset = "0x639D3E0", VA = "0x18639DFE0", Slot = "11")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x639E8B0", Offset = "0x639DCB0", VA = "0x18639E8B0", Slot = "12")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x639E370", Offset = "0x639D770", VA = "0x18639E370", Slot = "13")]
	public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x639DFE0", Offset = "0x639D3E0", VA = "0x18639DFE0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8F9E90", Offset = "0x8F9290", VA = "0x1808F9E90")]
	private FANLJDFBPKN FCJCGMOHCDJ(MFOBNBKALPH JDHIJCJKFOO)
	{
		return default(FANLJDFBPKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x639E5A0", Offset = "0x639D9A0", VA = "0x18639E5A0")]
	private void MGBCJIMKCLO(NFJEDPPAJMK OOGHONKGHEE, MFOBNBKALPH JDHIJCJKFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x639DD60", Offset = "0x639D160", VA = "0x18639DD60")]
	private void AHMBLEDJIAC(NFJEDPPAJMK OOGHONKGHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x639DDD0", Offset = "0x639D1D0", VA = "0x18639DDD0")]
	public JMAKJOJHHNF CPIDOPDPFFB(IOLFAAOECPP IOCKLNNJMIA, in FANLJDFBPKN ONIBEFDCPGD)
	{
		return default(JMAKJOJHHNF);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x639E210", Offset = "0x639D610", VA = "0x18639E210", Slot = "8")]
	public void IMPGHFMPLKG(IOLFAAOECPP IOCKLNNJMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x639E100", Offset = "0x639D500", VA = "0x18639E100")]
	public bool GFMCIJHDPBA(IOLFAAOECPP IOCKLNNJMIA, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x639E490", Offset = "0x639D890", VA = "0x18639E490")]
	public void LPKJPMGMJLK(IOLFAAOECPP IOCKLNNJMIA, NMLCFAIOCDK LKAENGEIFGG, in EGIBCKCHGAP JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x639DEC0", Offset = "0x639D2C0", VA = "0x18639DEC0", Slot = "6")]
	public void DBOBEMBMCPG(IOLFAAOECPP IOCKLNNJMIA, Span<NMLCFAIOCDK> ELCMIPNJFNP, bool PHHHFKPPFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x639DFC0", Offset = "0x639D3C0", VA = "0x18639DFC0")]
	public bool FGMOMLLOOIL(LADNHJNEPKG DPBGLDFEONN, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x639E690", Offset = "0x639DA90", VA = "0x18639E690", Slot = "5")]
	public void NMKBKFBFGOP(IOLFAAOECPP IOCKLNNJMIA, JLMGPHFMAFP CFPEBKLBEPN, object MAFDHEKFLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x639E9A0", Offset = "0x639DDA0", VA = "0x18639E9A0")]
	public NPCEIAKKHIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x639E490", Offset = "0x639D890", VA = "0x18639E490", Slot = "4")]
	private void MPEMALDLLCA(IOLFAAOECPP IOCKLNNJMIA, NMLCFAIOCDK LKAENGEIFGG, in EGIBCKCHGAP JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x639DDD0", Offset = "0x639D1D0", VA = "0x18639DDD0", Slot = "7")]
	private JMAKJOJHHNF PBLJADBAGDK(IOLFAAOECPP IOCKLNNJMIA, in FANLJDFBPKN ONIBEFDCPGD)
	{
		return default(JMAKJOJHHNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x639E100", Offset = "0x639D500", VA = "0x18639E100", Slot = "9")]
	private bool IMPBIDMPDNC(IOLFAAOECPP IOCKLNNJMIA, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x639DFC0", Offset = "0x639D3C0", VA = "0x18639DFC0", Slot = "10")]
	private bool DBPDGGMGKDB(LADNHJNEPKG DPBGLDFEONN, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF JFBPNBNBHOE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[LOJIIDJFKAI(typeof(JHFKBMAMGAH), new string[] { })]
[KFMPJDNIPEO(JHCKAKNDFFP.OMRoom)]
internal class JHFKBMAMGAH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private bool HJHEPEKODIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private IOLFAAOECPP ONBAMHPEIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NMLCFAIOCDK MPKOBDPILJB;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x639C800", Offset = "0x639BC00", VA = "0x18639C800")]
	public IDisposable BFPHDDBHNEE(in IOLFAAOECPP ONBAMHPEIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x639C780", Offset = "0x639BB80", VA = "0x18639C780")]
	public IDisposable ACJHDFNHANL(in IOLFAAOECPP ONBAMHPEIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x639C970", Offset = "0x639BD70", VA = "0x18639C970")]
	public IDisposable GFMCIJHDPBA(in IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x639C880", Offset = "0x639BC80", VA = "0x18639C880")]
	public bool EJALAPOKFGO(in IOLFAAOECPP DMBGMLGAHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x639C990", Offset = "0x639BD90", VA = "0x18639C990")]
	public bool GMMMOLBBMJC(in IOLFAAOECPP DMBGMLGAHFM, NMLCFAIOCDK BLCBJOMKEKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x9BF0F0", Offset = "0x9BE4F0", VA = "0x1809BF0F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public JHFKBMAMGAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[LOJIIDJFKAI(typeof(BEHAFONEFJN), new string[] { })]
public class NHKHJGEHDFB : DPDCPMNGBKH, BEHAFONEFJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[CompilerGenerated]
	private Action<IOLFAAOECPP, NMLCFAIOCDK> NNFNCCEFMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[IMNMHIBEIDL]
	private JHFKBMAMGAH LEMDLAFLPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[IMNMHIBEIDL]
	private DEMIGFIOEMK GIPMDGDJGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[IMNMHIBEIDL]
	private LADNHJNEPKG ADKNNKGKOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[IMNMHIBEIDL]
	private KNNAFEJKLMH OKPOBPNCFMK;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x639DCB0", Offset = "0x639D0B0", VA = "0x18639DCB0", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x639DAF0", Offset = "0x639CEF0", VA = "0x18639DAF0")]
	public void HKECMHKPKCN(IOLFAAOECPP ONBAMHPEIDG, in FANLJDFBPKN ONIBEFDCPGD, bool OCNBEHMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x639D5D0", Offset = "0x639C9D0", VA = "0x18639D5D0", Slot = "6")]
	public void AJMBANJFKHK(IOLFAAOECPP ONBAMHPEIDG, bool OCNBEHMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x639D720", Offset = "0x639CB20", VA = "0x18639D720")]
	public void DBCEICDGIHA(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF JFBPNBNBHOE, bool OCNBEHMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public NHKHJGEHDFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x639DCA0", Offset = "0x639D0A0", VA = "0x18639DCA0", Slot = "5")]
	private void MKPPAMMNHMK(IOLFAAOECPP ONBAMHPEIDG, in FANLJDFBPKN ONIBEFDCPGD, bool OCNBEHMFPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x639D700", Offset = "0x639CB00", VA = "0x18639D700", Slot = "7")]
	private void BAOBFJBJOHA(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF JFBPNBNBHOE, bool OCNBEHMFPGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[LOJIIDJFKAI(typeof(BKOAPAPEJAI), new string[] { })]
public class FKJKGPDNDIC : DPDCPMNGBKH, BKOAPAPEJAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[IMNMHIBEIDL]
	private LADNHJNEPKG ADKNNKGKOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[IMNMHIBEIDL]
	private POIJNILNJOE ONNGBJNFMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[IMNMHIBEIDL]
	private JHFKBMAMGAH LEMDLAFLPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[IMNMHIBEIDL]
	private PropertyChangeRouterService AEINHIAACKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[IMNMHIBEIDL]
	private FNCOHMIDMDB OKPOBPNCFMK;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x639B500", Offset = "0x639A900", VA = "0x18639B500", Slot = "4")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x639B0C0", Offset = "0x639A4C0", VA = "0x18639B0C0")]
	public void BPMMEAKNNHC(IOLFAAOECPP ONBAMHPEIDG, in FANLJDFBPKN MBIBEFAMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x639B330", Offset = "0x639A730", VA = "0x18639B330", Slot = "6")]
	public void FPPEFKBFIKG(IOLFAAOECPP ONBAMHPEIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x639B1B0", Offset = "0x639A5B0", VA = "0x18639B1B0")]
	public void FBKKELGLPHB(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF CNMFKPMEJDC, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public FKJKGPDNDIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x639B410", Offset = "0x639A810", VA = "0x18639B410", Slot = "5")]
	private void LBJEBJAKKME(IOLFAAOECPP PBICEPMHFMD, in FANLJDFBPKN ONIBEFDCPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x639AF40", Offset = "0x639A340", VA = "0x18639AF40", Slot = "7")]
	private void BCIJNEBCAIE(IOLFAAOECPP PBICEPMHFMD, NMLCFAIOCDK LKAENGEIFGG, in LONBCMOJAJF CNMFKPMEJDC, in LONBCMOJAJF FPEGOFLFPHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[LOJIIDJFKAI(typeof(LADNHJNEPKG), new string[] { })]
public class DBJHKMFPIIK : LADNHJNEPKG, LFPMKPLIAAM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private ALALGBOOEMC PLAJLNIKEKL;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6398430", Offset = "0x6397830", VA = "0x186398430", Slot = "8")]
	public void JLJMFLGJEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3A4D480", Offset = "0x3A4C880", VA = "0x183A4D480", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x63982D0", Offset = "0x63976D0", VA = "0x1863982D0")]
	public void ALBEGJGADIE(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB, in LONBCMOJAJF CNMFKPMEJDC, in LONBCMOJAJF DGKEIICJPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x63984D0", Offset = "0x63978D0", VA = "0x1863984D0")]
	public bool JPEPLHOOAIC(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB, in EGIBCKCHGAP CNMFKPMEJDC, in EGIBCKCHGAP DGKEIICJPPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x63983D0", Offset = "0x63977D0", VA = "0x1863983D0", Slot = "6")]
	public bool AMPEKNCDIFL(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6397E60", Offset = "0x6397260", VA = "0x186397E60")]
	public bool AFJHHKFAHMA(IOLFAAOECPP ONBAMHPEIDG, NMLCFAIOCDK MPKOBDPILJB, in LONBCMOJAJF DGKEIICJPPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public DBJHKMFPIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6398410", Offset = "0x6397810", VA = "0x186398410", Slot = "4")]
	private void CDLBPLDEAPH(IOLFAAOECPP PBICEPMHFMD, NMLCFAIOCDK MPKOBDPILJB, in LONBCMOJAJF CNMFKPMEJDC, in LONBCMOJAJF DGKEIICJPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6398630", Offset = "0x6397A30", VA = "0x186398630", Slot = "5")]
	private bool OBBCOAPPCGC(IOLFAAOECPP PBICEPMHFMD, NMLCFAIOCDK MPKOBDPILJB, in EGIBCKCHGAP CNMFKPMEJDC, in EGIBCKCHGAP DGKEIICJPPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6398420", Offset = "0x6397820", VA = "0x186398420", Slot = "7")]
	private bool GMLAKIODDOD(IOLFAAOECPP PBICEPMHFMD, NMLCFAIOCDK MPKOBDPILJB, in LONBCMOJAJF DGKEIICJPPN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct NGMPAEGDFGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly Type FKOGCICBGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly byte[] NNNLEJFKDGN;
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[LOJIIDJFKAI(typeof(IPBKNNKPCHC), new string[] { })]
public class HJCEKJELLNP : IPBKNNKPCHC, DPDCPMNGBKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[IMNMHIBEIDL]
	private CBKFGLANBFD OJHNJFEHCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[IMNMHIBEIDL]
	private CKIHGNIOLNC ALIECAOHAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[IMNMHIBEIDL]
	private PropertyChangeNetworkRouter FIKJKKODDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[IMNMHIBEIDL]
	private ADMIKKBEDIN LNJLGDKOFHH;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x639B690", Offset = "0x639AA90", VA = "0x18639B690", Slot = "5")]
	public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x639B5D0", Offset = "0x639A9D0", VA = "0x18639B5D0", Slot = "4")]
	public void LFIFIKJMEDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public HJCEKJELLNP()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Transmission.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	internal class _RRAssemblyIndex : IIPLPEOFAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x639EEB0", Offset = "0x639E2B0", VA = "0x18639EEB0", Slot = "6")]
		public sealed override void ABDNPPIKLOH(FJJGEPPJBDA IGAMPECHIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x639F210", Offset = "0x639E610", VA = "0x18639F210", Slot = "4")]
		public sealed override void FKBDNONAKOB()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EGIIOKJKKGL()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
