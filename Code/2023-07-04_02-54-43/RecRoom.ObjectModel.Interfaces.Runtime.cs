using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using RecRoom.Components;
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
public interface IDDAEIFJOAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EEEFHKKIKBI(in float3 OACJHEFCBAA, in float3 JPHMHCBHKFF, float HPJGDBFIPFJ, Allocator HDOCJKNPNPA, out NativeArray<Entity> DJGJGAHPJBG);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[KAEAKLGOHIG(GMBNIBPKKJK.Application)]
public interface IFCKAPBAHNK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Guid GFPCEEDIHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LDDLPIMDGGB(Guid KCCFIFDBOJJ, Guid MJIHAEEHECO);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PNKJOEAAKLB(AIEJIADOHAF CNPHJKCFBKD);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EJJAPLIMLCB : AJDIOEGOOJG<AIEJIADOHAF>, NBIFMCDOFDB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BLLIPOGFPLJ<T> : MFDDLGLKMCP<AIEJIADOHAF, T>, AJDIOEGOOJG<AIEJIADOHAF>, NBIFMCDOFDB, IDisposable, EJJAPLIMLCB where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CLMIBOCJHOB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x16AA0C0", Offset = "0x16A86C0", VA = "0x1816AA0C0")]
	public static T PIDCPOPDLLJ<T>(this AJDIOEGOOJG<AIEJIADOHAF> OMEMEFEKGAP, AIEJIADOHAF EHPNFPDFJDJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x16AA090", Offset = "0x16A8690", VA = "0x1816AA090")]
	public static bool PCICHOODFHC<T>(this AJDIOEGOOJG<AIEJIADOHAF> OMEMEFEKGAP, AIEJIADOHAF EHPNFPDFJDJ, in T ABBAPCAIMDJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
public interface GKCHHELPBFO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Func<GOFJCDAGEHB> OOPDNHLMMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<AIEJIADOHAF, AIEJIADOHAF> NHPHPKIDMFN;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<AIEJIADOHAF, AIEJIADOHAF> DMLDIJDIFKP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<AIEJIADOHAF, AIEJIADOHAF, AIEJIADOHAF> LNLOFCONBAK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<AIEJIADOHAF> OFEOMFHEEKG;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color AJGBOKPFNHO(AIEJIADOHAF EHPNFPDFJDJ, int ICFHOBDKNNE);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float3 CJDKDMLPICN(AIEJIADOHAF EHPNFPDFJDJ, int ICFHOBDKNNE);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool EIEKDPHLDIB(AIEJIADOHAF EHPNFPDFJDJ, AIEJIADOHAF PPEPHBAFPDB);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AIEJIADOHAF ENLCEGLCEJH(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<AIEJIADOHAF> AGKLDEIENLN(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AIEJIADOHAF DELDAEJEOOL(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MHMOLBPEMDL(AIEJIADOHAF EHPNFPDFJDJ, Vector3 CEINKNECCBG, Quaternion JMNCJOKJHFO);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CNKBLHHLKML(AIEJIADOHAF EHPNFPDFJDJ, float CGGDAIKDGDF);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool CDAOMMAANLB(AIEJIADOHAF EHPNFPDFJDJ, out RigidTransform NACEBLJEJGA);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool BNGKMOHJJJL(AIEJIADOHAF EHPNFPDFJDJ, out float EINBJBFNFLE);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 GJFOKOFPFND(LOHABCBDDHD IHOFICHLDHN);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	quaternion CBCPNEDKNFG(LOHABCBDDHD IHOFICHLDHN);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DHKAGAFHGBJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
public interface NJGPHNFOJHN
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EEEFHKKIKBI(in NativeArray<Entity> DJGJGAHPJBG, in float3 OACJHEFCBAA, in float3 JPHMHCBHKFF, in NativeArray<FDAAIAENPGP> FLJELABMDCA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
public interface BCLFIGEAPCO
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EEADNPIGCKD(AIEJIADOHAF PAGDHPEICGI, bool FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILAIKFDGAMJ(AIEJIADOHAF PAGDHPEICGI, bool FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JOGOADMELMI(AIEJIADOHAF PAGDHPEICGI, int FEBHELIDNED);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
[DefaultMember("Item")]
public interface FFDBHDNDJOH : IEnumerable<PKJHJMAHAIO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	NativeBitArray MBJHGHIGKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NativeArray<int> FFCLKBCNKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	PKJHJMAHAIO KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	PKJHJMAHAIO KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PKJHJMAHAIO INBDFKHIIHK(CLLJMNNCKMG LDLHPBNHANP);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DMCAMPNBLKJ JFELANGNBDJ(CLLJMNNCKMG LDLHPBNHANP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class ICPHOHLLJHP
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public static DHJOLBGJFBM<T> INBDFKHIIHK<T>(this FFDBHDNDJOH GOMAHIOPLHH, CLLJMNNCKMG HNPIEGONNBC) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct AMLNHIIINLO : IEquatable<AMLNHIIINLO>
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly AMLNHIIINLO OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	public AMLNHIIINLO(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD2A0", Offset = "0x5ACB8A0", VA = "0x185ACD2A0", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(AMLNHIIINLO EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct KHOHEGMMOHP : IEquatable<KHOHEGMMOHP>
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly KHOHEGMMOHP OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5AD53B0", Offset = "0x5AD39B0", VA = "0x185AD53B0", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(KHOHEGMMOHP EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface CJMOMIJLCCI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JGELCJDLJNB MOMGLEPCCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EFBLDFCGDKJ(JLPKHKEHPHF FJAJFKMDLKL, DMCAMPNBLKJ OMEMEFEKGAP);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ACOPLAKAGJG(JLPKHKEHPHF FJAJFKMDLKL, Span<DMCAMPNBLKJ> GOMAHIOPLHH, bool LNPNLCABJAM);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBEMJHFDIHG(NativeArray<JLPKHKEHPHF> JIMFPBFNKFB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct JGELCJDLJNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NativeBitArray DOAHCEHPLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly NativeParallelHashMap<JLPKHKEHPHF, int> IOFHLJEPFKF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool EJJKPGEEHMI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5090", Offset = "0x5AD3690", VA = "0x185AD5090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xB14810", Offset = "0xB12E10", VA = "0x180B14810")]
	public JGELCJDLJNB(NativeBitArray DOAHCEHPLMB, NativeParallelHashMap<JLPKHKEHPHF, int> IOFHLJEPFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5AD4F90", Offset = "0x5AD3590", VA = "0x185AD4F90")]
	public bool EFBLDFCGDKJ(JLPKHKEHPHF FJAJFKMDLKL, DMCAMPNBLKJ OMEMEFEKGAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HGHLOAPFFJI
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct CBELJALGPAD : FNIFPCAPMKM, IEquatable<CBELJALGPAD>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly CBELJALGPAD OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GameObject CGLKMGEDNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF9B0", Offset = "0x5ACDFB0", VA = "0x185ACF9B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JLPKHKEHPHF IEBNIGKOLCN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5ACFCB0", Offset = "0x5ACE2B0", VA = "0x185ACFCB0")]
		get
		{
			return default(JLPKHKEHPHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ObjectType BBAOGLENOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF880", Offset = "0x5ACDE80", VA = "0x185ACF880")]
		get
		{
			return default(ObjectType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ObjectPrefabType FEKDDJPBDNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF7A0", Offset = "0x5ACDDA0", VA = "0x185ACF7A0")]
		get
		{
			return default(ObjectPrefabType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool JPCCENBCHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0200", Offset = "0x5ACE800", VA = "0x185AD0200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool MKDGEBALNFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5ACFD70", Offset = "0x5ACE370", VA = "0x185ACFD70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool PHBMODACMOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5ACFD90", Offset = "0x5ACE390", VA = "0x185ACFD90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool AJOKDEBDHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF860", Offset = "0x5ACDE60", VA = "0x185ACF860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool ELKGGHKADKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF680", Offset = "0x5ACDC80", VA = "0x185ACF680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool HBEAOGDIAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5ACFDB0", Offset = "0x5ACE3B0", VA = "0x185ACFDB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool FOOHBMKICKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5ACFE20", Offset = "0x5ACE420", VA = "0x185ACFE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HHLLAJIFNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5ACFC90", Offset = "0x5ACE290", VA = "0x185ACFC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public HOMFNBJNNNF DELPDCGKMAM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(HOMFNBJNNNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public PJBJMGJKFKC CHDPOENOHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(PJBJMGJKFKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public OCCCFAEHDLO HKJBFJHBFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(OCCCFAEHDLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public EPCAAKBOJIG HPOIMOMFDPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(EPCAAKBOJIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public OIODOPALBEJ HDKKFAMLNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(OIODOPALBEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IIMIHPCMHFF JCNOAJJDJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(IIMIHPCMHFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public HAMNMDHHPGK IPKLCEFGFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(HAMNMDHHPGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool PFAEDBNEHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5ACFF50", Offset = "0x5ACE550", VA = "0x185ACFF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool EEOKJDGLNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5ACFDD0", Offset = "0x5ACE3D0", VA = "0x185ACFDD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private bool KIKOCPLJHJK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9146D0", Offset = "0x912CD0", VA = "0x1809146D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public AIEJIADOHAF DOCLPKLCMEE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690", Slot = "5")]
		get
		{
			return default(AIEJIADOHAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public AACKNDBGOGF LDKGJPDELDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(AACKNDBGOGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public OCBJCGCAGOE ALAPLOOKJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(OCBJCGCAGOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private MDMCNHEDDOJ DMDBGNCGEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
	public static CBELJALGPAD BJIOOOHFEFG(AIEJIADOHAF PAGDHPEICGI)
	{
		return default(CBELJALGPAD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5ACF6A0", Offset = "0x5ACDCA0", VA = "0x185ACF6A0")]
	public CJGHEGNPGGH AFBJOPOCGDI()
	{
		return default(CJGHEGNPGGH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5ACF730", Offset = "0x5ACDD30", VA = "0x185ACF730")]
	public BOINGAAAIME AHFAHGPLFON()
	{
		return default(BOINGAAAIME);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5AD02D0", Offset = "0x5ACE8D0", VA = "0x185AD02D0")]
	public AMLNHIIINLO PPHJCKNMHOK()
	{
		return default(AMLNHIIINLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5ACF940", Offset = "0x5ACDF40", VA = "0x185ACF940")]
	public KKGLEOIEPED EAFDMMABFHF()
	{
		return default(KKGLEOIEPED);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD00D0", Offset = "0x5ACE6D0", VA = "0x185AD00D0")]
	public LOHABCBDDHD MBAIDNENIKD()
	{
		return default(LOHABCBDDHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5ACFAB0", Offset = "0x5ACE0B0", VA = "0x185ACFAB0")]
	public void ENCJPIPPPGP([Optional] object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5AD0220", Offset = "0x5ACE820", VA = "0x185AD0220")]
	public bool OGBDFNJMJEG(object LODBJLOKBLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5AD0020", Offset = "0x5ACE620", VA = "0x185AD0020")]
	public bool LNOKELEGEMD(object LODBJLOKBLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5AD0340", Offset = "0x5ACE940", VA = "0x185AD0340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	public CBELJALGPAD(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD7B0", Offset = "0x5ACBDB0", VA = "0x185ACD7B0")]
	public static bool BJIOOOHFEFG(CBELJALGPAD FEBHELIDNED)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690")]
	public static AIEJIADOHAF BJIOOOHFEFG(CBELJALGPAD FEBHELIDNED)
	{
		return default(AIEJIADOHAF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5AD0160", Offset = "0x5ACE760", VA = "0x185AD0160")]
	public static bool MOJFGPLDDKP(CBELJALGPAD LLAFGJINMOA, CBELJALGPAD LKIHFBEPDMH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5ACFE70", Offset = "0x5ACE470", VA = "0x185ACFE70")]
	public static bool LFBHPMALHHK(CBELJALGPAD LLAFGJINMOA, CBELJALGPAD LKIHFBEPDMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5ACFB90", Offset = "0x5ACE190", VA = "0x185ACFB90", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "6")]
	public bool Equals(CBELJALGPAD EJECOGCICOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate void OAJMIAIAIPN(AIEJIADOHAF EHPNFPDFJDJ, DMCAMPNBLKJ GMFCGGOOKOG, IGCFDMLBPPM IOHGKHFMCBP, IGCFDMLBPPM AODCBCDFMFP);
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public struct DOBLGLEBKAA : IList<AIEJIADOHAF>, ICollection<AIEJIADOHAF>, IEnumerable<AIEJIADOHAF>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct AOCHCBAKMAO : IEnumerator<AIEJIADOHAF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly MDMCNHEDDOJ HIHBENBCOLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private NativeArray<LocalId>.Enumerator NLCCEHBOCJM;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public AIEJIADOHAF PGNBHIOAFDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5ACD580", Offset = "0x5ACBB80", VA = "0x185ACD580", Slot = "4")]
			get
			{
				return default(AIEJIADOHAF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5ACD4A0", Offset = "0x5ACBAA0", VA = "0x185ACD4A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x15C38F0", Offset = "0x15C1EF0", VA = "0x1815C38F0")]
		public AOCHCBAKMAO(MDMCNHEDDOJ HIHBENBCOLF, NativeArray<LocalId>.Enumerator NLCCEHBOCJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5ACD3E0", Offset = "0x5ACB9E0", VA = "0x185ACD3E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5ACD420", Offset = "0x5ACBA20", VA = "0x185ACD420", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5ACD460", Offset = "0x5ACBA60", VA = "0x185ACD460", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly MDMCNHEDDOJ HIHBENBCOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private NativeList<LocalId> IFENDBDPCHC;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public AIEJIADOHAF KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2080", Offset = "0x5AD0680", VA = "0x185AD2080", Slot = "4")]
		get
		{
			return default(AIEJIADOHAF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2100", Offset = "0x5AD0700", VA = "0x185AD2100", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1B00", Offset = "0x5AD0100", VA = "0x185AD1B00", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int DIDJDLOPKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1B00", Offset = "0x5AD0100", VA = "0x185AD1B00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool ICHMNNBEJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1FF0", Offset = "0x5AD05F0", VA = "0x185AD1FF0")]
	public DOBLGLEBKAA(MDMCNHEDDOJ HIHBENBCOLF, int CPHEGBCGAHF, Allocator HDOCJKNPNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1C20", Offset = "0x5AD0220", VA = "0x185AD1C20")]
	public LBINFBCBAJB JEHLPGMEOJB()
	{
		return default(LBINFBCBAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1850", Offset = "0x5ACFE50", VA = "0x185AD1850", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1890", Offset = "0x5ACFE90", VA = "0x185AD1890", Slot = "13")]
	public bool Contains(AIEJIADOHAF CDIFGMFCFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5AD18F0", Offset = "0x5ACFEF0", VA = "0x185AD18F0", Slot = "14")]
	public void CopyTo(AIEJIADOHAF[] JHKFLJIAOGC, int AELLNPMJPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5AD17F0", Offset = "0x5ACFDF0", VA = "0x185AD17F0", Slot = "11")]
	public void Add(AIEJIADOHAF CDIFGMFCFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1BA0", Offset = "0x5AD01A0", VA = "0x185AD1BA0", Slot = "7")]
	public void Insert(int IIOMOLKAONM, AIEJIADOHAF CDIFGMFCFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1D80", Offset = "0x5AD0380", VA = "0x185AD1D80", Slot = "15")]
	public bool Remove(AIEJIADOHAF CDIFGMFCFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1B40", Offset = "0x5AD0140", VA = "0x185AD1B40", Slot = "6")]
	public int IndexOf(AIEJIADOHAF CDIFGMFCFLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1D30", Offset = "0x5AD0330", VA = "0x185AD1D30", Slot = "8")]
	public void RemoveAt(int IIOMOLKAONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1AC0", Offset = "0x5AD00C0", VA = "0x185AD1AC0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1CA0", Offset = "0x5AD02A0", VA = "0x185AD1CA0")]
	public AOCHCBAKMAO PFBFKEIKCCB()
	{
		return default(AOCHCBAKMAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1E10", Offset = "0x5AD0410", VA = "0x185AD1E10", Slot = "16")]
	private IEnumerator<AIEJIADOHAF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1F00", Offset = "0x5AD0500", VA = "0x185AD1F00", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
public interface MDJGNCFEHHF
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EEEFHKKIKBI(in float3 OACJHEFCBAA, in float3 JPHMHCBHKFF, float HPJGDBFIPFJ, out FDAAIAENPGP OPBOEONIHKI, out AIEJIADOHAF LPBMHDMBDFH);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public readonly struct BMEGNONALPO : IEquatable<BMEGNONALPO>
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly BMEGNONALPO OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private IKNMCINAEEI AJFLAMFEHAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE020", Offset = "0x5ACC620", VA = "0x185ACE020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public BOINGAAAIME NEMNGMDANFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(BOINGAAAIME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HOLODDBGGIJ NJNKNLLOGNF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE3F0", Offset = "0x5ACC9F0", VA = "0x185ACE3F0")]
		get
		{
			return default(HOLODDBGGIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE0A0", Offset = "0x5ACC6A0", VA = "0x185ACE0A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IEnumerable<BMMDCLAMBPO> IJDLKMOAGKL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5ACDCF0", Offset = "0x5ACC2F0", VA = "0x185ACDCF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public BMMDCLAMBPO KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5ACD690", Offset = "0x5ACBC90", VA = "0x185ACD690")]
		get
		{
			return default(BMMDCLAMBPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE270", Offset = "0x5ACC870", VA = "0x185ACE270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public AIEJIADOHAF DOCLPKLCMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690")]
		get
		{
			return default(AIEJIADOHAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public AACKNDBGOGF LDKGJPDELDD
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(AACKNDBGOGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private MDMCNHEDDOJ DMDBGNCGEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private BLGMLIKMCAK LDGNNMJJEKB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5ACDFD0", Offset = "0x5ACC5D0", VA = "0x185ACDFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD7C0", Offset = "0x5ACBDC0", VA = "0x185ACD7C0")]
	public BMMDCLAMBPO BNDIPMBKEFF(float3? FADCMIMHMJH, [Optional] quaternion? HOHKOHLHECA, [Optional] Vector3? KPABHDDPFGG)
	{
		return default(BMMDCLAMBPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5ACDAC0", Offset = "0x5ACC0C0", VA = "0x185ACDAC0")]
	public BMMDCLAMBPO CJIDPAHKBHA(int IIOMOLKAONM, float3? FADCMIMHMJH, [Optional] quaternion? HOHKOHLHECA, [Optional] Vector3? KPABHDDPFGG)
	{
		return default(BMMDCLAMBPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5ACE190", Offset = "0x5ACC790", VA = "0x185ACE190")]
	public void KHMDPDLENDM(int IIOMOLKAONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD9E0", Offset = "0x5ACBFE0", VA = "0x185ACD9E0")]
	public void CCIICLEBIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	public BMEGNONALPO(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD7B0", Offset = "0x5ACBDB0", VA = "0x185ACD7B0")]
	public static bool BJIOOOHFEFG(BMEGNONALPO FEBHELIDNED)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5ACE350", Offset = "0x5ACC950", VA = "0x185ACE350")]
	public static bool MOJFGPLDDKP(BMEGNONALPO LLAFGJINMOA, BMEGNONALPO LKIHFBEPDMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5ACDED0", Offset = "0x5ACC4D0", VA = "0x185ACDED0", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(BMEGNONALPO EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
public interface BFLFBIBFGEH
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IEPMMBNAOPP(AIEJIADOHAF EHPNFPDFJDJ, out Collider OHNLBFFNOJG);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject FFLOFLFHKMJ(AIEJIADOHAF GJNHNKFDGPG, GameObject NBHNBEHBBFP, Vector3 FFBPBBJMKKL, Quaternion PJECOBPELHJ);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MKEBBKPNOPK(GameObject OHNLBFFNOJG);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider AHJAFICPCEP<TCollider>(GameObject CJGPPLOJCEH) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BEOGOAKMKOH(Collider OHNLBFFNOJG);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject FPCFAFPGDME<TCollider>(string HNPIEGONNBC) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface FDODPLMFAKJ : AJDIOEGOOJG<JLPKHKEHPHF>, NBIFMCDOFDB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FEFHMMPJLAL<T> : MFDDLGLKMCP<JLPKHKEHPHF, T>, AJDIOEGOOJG<JLPKHKEHPHF>, NBIFMCDOFDB, IDisposable, FDODPLMFAKJ where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class LDNLPMBIIGP
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1B6F800", Offset = "0x1B6DE00", VA = "0x181B6F800")]
	public static bool HNEMDLLFNLP<T>(this AJDIOEGOOJG<JLPKHKEHPHF> OMEMEFEKGAP, JLPKHKEHPHF FJAJFKMDLKL, out T FEBHELIDNED) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x16AA710", Offset = "0x16A8D10", VA = "0x1816AA710")]
	public static bool PCICHOODFHC<T>(this AJDIOEGOOJG<JLPKHKEHPHF> OMEMEFEKGAP, JLPKHKEHPHF FJAJFKMDLKL, in T ABBAPCAIMDJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct HAMNMDHHPGK : IEquatable<HAMNMDHHPGK>
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly HAMNMDHHPGK OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private NCIGGAADPPM ECOELJKKAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3780", Offset = "0x5AD1D80", VA = "0x185AD3780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool ANBEKOEEIGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3CE0", Offset = "0x5AD22E0", VA = "0x185AD3CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Guid GFKFKBLJLFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3EB0", Offset = "0x5AD24B0", VA = "0x185AD3EB0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool CGIKNPNDEOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3B20", Offset = "0x5AD2120", VA = "0x185AD3B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Guid PAAADIKKPIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3950", Offset = "0x5AD1F50", VA = "0x185AD3950")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public AIEJIADOHAF DOCLPKLCMEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690")]
		get
		{
			return default(AIEJIADOHAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private MDMCNHEDDOJ DMDBGNCGEPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private BLGMLIKMCAK LDGNNMJJEKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3900", Offset = "0x5AD1F00", VA = "0x185AD3900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5AD3C00", Offset = "0x5AD2200", VA = "0x185AD3C00")]
	public bool LGAIBOALMCG(out Guid ELEBJEJCHNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5AD35B0", Offset = "0x5AD1BB0", VA = "0x185AD35B0")]
	public void ACFIHCDAEKE(Guid CHEGNIOHCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5AD3A40", Offset = "0x5AD2040", VA = "0x185AD3A40")]
	public bool GLBEKPJHAOM(out Guid IGPIKBBAHPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5AD3DC0", Offset = "0x5AD23C0", VA = "0x185AD3DC0")]
	public void LPAIKJECIJG(Guid CHEGNIOHCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5AD36A0", Offset = "0x5AD1CA0", VA = "0x185AD36A0")]
	public void DFNDMMNHNCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	public HAMNMDHHPGK(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5AD3800", Offset = "0x5AD1E00", VA = "0x185AD3800", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(HAMNMDHHPGK EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct PJBJMGJKFKC : IEquatable<PJBJMGJKFKC>
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly PJBJMGJKFKC OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private MDMCNHEDDOJ DMDBGNCGEPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5ADAB10", Offset = "0x5AD9110", VA = "0x185ADAB10")]
	public void LFGPNIBMGLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5ADAA40", Offset = "0x5AD9040", VA = "0x185ADAA40")]
	public void JGMGKPAOHON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	public PJBJMGJKFKC(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5ADA940", Offset = "0x5AD8F40", VA = "0x185ADA940", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(PJBJMGJKFKC EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DIEOBLMALKE : FNIFPCAPMKM
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	CFELAPKFMGP JMEOJLHCJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool IIBOOHGLJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	GameObject CGLKMGEDNPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<DIEOBLMALKE> NKKLCFAJHEI;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(GOIGDNBBPCE MDGIABLFKGC, AIEJIADOHAF CAHJDMLAEPA);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool NHMGCDCDGNM);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class DMINIMHPHID
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1700", Offset = "0x5ACFD00", VA = "0x185AD1700")]
	public static bool PFAEDBNEHJG(this DIEOBLMALKE OIJEFGKAECP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1660", Offset = "0x5ACFC60", VA = "0x185AD1660")]
	public static bool ENBDMNCJAJD(this DIEOBLMALKE OIJEFGKAECP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5AD16B0", Offset = "0x5ACFCB0", VA = "0x185AD16B0")]
	public static bool HOIFIEIALAL(this DIEOBLMALKE OIJEFGKAECP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1750", Offset = "0x5ACFD50", VA = "0x185AD1750")]
	public static bool PGDNGHJKGGD(this DIEOBLMALKE OIJEFGKAECP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct HLLOJPFPHEI : IEquatable<HLLOJPFPHEI>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly HLLOJPFPHEI OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5AD4270", Offset = "0x5AD2870", VA = "0x185AD4270", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(HLLOJPFPHEI EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
public interface FBGBLGIDKBI
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLMLCFELMAH(NativeListAsync<Entity> JOMJPEJPCPP);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DAGBHFAGJND(ABMGLFIKGIM JAICHEOOCCJ);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LAHDLJFJEGM(NativeListAsync<Entity> OMEMNBOBDEH, bool KKHBFAHJOLK);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BCBLJCDJDGE();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
public interface LKDPHHHHGJD
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNJNEBAFHGH(AIEJIADOHAF EHPNFPDFJDJ, FOLHPMBKIGD FEBHELIDNED);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface GAIJFDPIKKC
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCIDEBAKEAN();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BPPLKGPMFKB();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HHPDOBGJCPG();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NMFBBMLEBJF();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NOABOKLDOHD();

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EGCMBCEEDKI();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CLOABHCGPKG();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AFOEHENMMKJ();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DMLFKCJBMDI();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JENOCJNOGFP();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MACJLDHGEAE();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface GHGJHFHPJIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	int ACGAGHHMJMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> IDNNFGAJEGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AIEJIADOHAF PKOELEHJNOK(AIEJIADOHAF IFENDBDPCHC);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PKOELEHJNOK(int GAAAGPFNOFP);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface KBAJDEKKIMF : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct EPCAAKBOJIG : IEquatable<EPCAAKBOJIG>
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly EPCAAKBOJIG OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private PEACHOKPGON DCNICABKGMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2E40", Offset = "0x5AD1440", VA = "0x185AD2E40")]
		get
		{
			return default(PEACHOKPGON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool EDJPOGOAJBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2610", Offset = "0x5AD0C10", VA = "0x185AD2610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool DPIAHIJMFPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2B90", Offset = "0x5AD1190", VA = "0x185AD2B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool LJNCIELEINM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2840", Offset = "0x5AD0E40", VA = "0x185AD2840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool CALKNCOAGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2780", Offset = "0x5AD0D80", VA = "0x185AD2780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool MIGIIIAMBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2CC0", Offset = "0x5AD12C0", VA = "0x185AD2CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool LCMHGHCPJEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5AD30C0", Offset = "0x5AD16C0", VA = "0x185AD30C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool MFGPBGFNJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2F80", Offset = "0x5AD1580", VA = "0x185AD2F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool ENIIHBDGECO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2EA0", Offset = "0x5AD14A0", VA = "0x185AD2EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool CAMNCJLHPBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2930", Offset = "0x5AD0F30", VA = "0x185AD2930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool EFMOALCFGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2DC0", Offset = "0x5AD13C0", VA = "0x185AD2DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool ILAKFOCMGIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5AD24B0", Offset = "0x5AD0AB0", VA = "0x185AD24B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool CCIFHKPGFNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5AD28B0", Offset = "0x5AD0EB0", VA = "0x185AD28B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool NBCOALCOKDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2F10", Offset = "0x5AD1510", VA = "0x185AD2F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool KFKNEOMBNNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2D30", Offset = "0x5AD1330", VA = "0x185AD2D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool LELFJAHBJFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2E30", Offset = "0x5AD1430", VA = "0x185AD2E30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2920", Offset = "0x5AD0F20", VA = "0x185AD2920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool MIDOPPFMDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2520", Offset = "0x5AD0B20", VA = "0x185AD2520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Vector3 KIKLOGEGFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2FF0", Offset = "0x5AD15F0", VA = "0x185AD2FF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector3 OIPKKGCPFHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2C00", Offset = "0x5AD1200", VA = "0x185AD2C00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool JDFGMGKENAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2A70", Offset = "0x5AD1070", VA = "0x185AD2A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public AIEJIADOHAF DOCLPKLCMEE
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690")]
		get
		{
			return default(AIEJIADOHAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private MDMCNHEDDOJ DMDBGNCGEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private BLGMLIKMCAK LDGNNMJJEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5AD27F0", Offset = "0x5AD0DF0", VA = "0x185AD27F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5AD2590", Offset = "0x5AD0B90", VA = "0x185AD2590")]
	public bool EEBEMLKDJFE(DJGIOMCBOKH LGEAECDPGKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5AD29A0", Offset = "0x5AD0FA0", VA = "0x185AD29A0")]
	public bool IIOFKAPJECP(ObjectPolicyUserConfigurableFlags LGEAECDPGKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5AD2D40", Offset = "0x5AD1340", VA = "0x185AD2D40")]
	public void LOKIFENBABL(ObjectPolicyUserConfigurableFlags LGEAECDPGKJ, bool CHKEADEKBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	public EPCAAKBOJIG(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5AD2680", Offset = "0x5AD0C80", VA = "0x185AD2680", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(EPCAAKBOJIG EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface GOIGDNBBPCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	AFBGDHKOKKB OIEFMCLOMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	ENAOPEFLDPO OKNBJFAFJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	EntityManager IKKIOEAOHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool PGDNGHJKGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase DJOOJAPNLFF(Type LFBJHCMDIAE);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class FAIHEOJHBGP
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5AD3170", Offset = "0x5AD1770", VA = "0x185AD3170")]
	public static World GHPGHEOIGKH(this GOIGDNBBPCE LMCINHHLFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x20AF850", Offset = "0x20ADE50", VA = "0x1820AF850")]
	public static T DJOOJAPNLFF<T>(this GOIGDNBBPCE LMCINHHLFIM) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct OCBJCGCAGOE : IEquatable<OCBJCGCAGOE>
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly OCBJCGCAGOE OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	private EHKILPFAOPG KHDNHBHIFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5AD85A0", Offset = "0x5AD6BA0", VA = "0x185AD85A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public AIEJIADOHAF HGFPLOKBADO
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5AD8720", Offset = "0x5AD6D20", VA = "0x185AD8720")]
		get
		{
			return default(AIEJIADOHAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public CBELJALGPAD IHLKEFDBIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5AD8810", Offset = "0x5AD6E10", VA = "0x185AD8810")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public CBELJALGPAD PACKEMKPJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5AD8620", Offset = "0x5AD6C20", VA = "0x185AD8620")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public AIEJIADOHAF DOCLPKLCMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690")]
		get
		{
			return default(AIEJIADOHAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	private MDMCNHEDDOJ DMDBGNCGEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	private BLGMLIKMCAK LDGNNMJJEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5AD8A10", Offset = "0x5AD7010", VA = "0x185AD8A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD8A60", Offset = "0x5AD7060", VA = "0x185AD8A60")]
	public bool HGKEBMICHFN(CBELJALGPAD KHJHJOOPMKP, bool HKIOJBCBMCC = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5AD84B0", Offset = "0x5AD6AB0", VA = "0x185AD84B0")]
	public bool AHDHKBGGAKJ(CBELJALGPAD PGGIOMMDBAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	public OCBJCGCAGOE(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5AD8910", Offset = "0x5AD6F10", VA = "0x185AD8910", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(OCBJCGCAGOE EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct EMPIPIJOHPF : IEquatable<EMPIPIJOHPF>
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly EMPIPIJOHPF OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private FIHOAKPFDLC ICLNGIAIAAD
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5AD23A0", Offset = "0x5AD09A0", VA = "0x185AD23A0")]
		get
		{
			return default(FIHOAKPFDLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public NLLGCLNFGJN CACIBCMOGFA
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2400", Offset = "0x5AD0A00", VA = "0x185AD2400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	public EMPIPIJOHPF(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD22A0", Offset = "0x5AD08A0", VA = "0x185AD22A0", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(EMPIPIJOHPF EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface MEJLHHMDNFN
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	CCEOOFIGOLM CDMIHAOOAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[KAEAKLGOHIG(GMBNIBPKKJK.Application)]
public interface OIMMBHMCLGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool EGJHFAFPIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool CPFCCLPOFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	int CKKICJBNDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool LLECMJJMFNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	PAANCIHNAEA OGHHOJNEPLL
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	BOLAEFFCJHJ NKFDFOAHBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool PKNJBIEPBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool DCCMIBMBJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string LHIGNCIJJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int HPLLJFDOMGI(GameObject CGLKMGEDNPH);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject[] OAGGAPJJCAB(IEnumerable<OOMENMIPJFG> FKPPPCNINKD);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "11")]
	JLPKHKEHPHF DLEKNGDOCDD(Guid EPNFCAKMBLJ);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DIEOBLMALKE FLDBLFJPDJO(OOMENMIPJFG PKNENDONMCN);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DIEOBLMALKE FLDBLFJPDJO(string HCOMHOGEGKD, JLPKHKEHPHF FJAJFKMDLKL, Vector3 FADCMIMHMJH, Quaternion HOHKOHLHECA, Vector3 KPABHDDPFGG);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EKFEEHFLMMA(bool OGJCOIOGMOG);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JNLJKMHDJCP();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool LDOMEDEJKCG(GameObject CGLKMGEDNPH, out JLPKHKEHPHF FJAJFKMDLKL);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool OLKDBMNFDEJ(GameObject CGLKMGEDNPH, out int OEDJBMGNINO, out ObjectPrefabType INKNLFCIIAC);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void ALODPEACPML(GameObject CGLKMGEDNPH, bool AOEOBOHNFND, bool GAGJMOJIJDN);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void FGGBAJGOCHJ(GameObject CGLKMGEDNPH);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task IFJIHPLJKPJ();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task NBBAADIGGPC();

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DDMPFALJENB(object DPNGJGBLPFN);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void JFFELKOLJEN(object DPNGJGBLPFN);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void HPAKNCEEDMO(object OGLJJNFALNA);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void NOLPNABHFAP(Transform IEIHNIMHKCE);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GNJPACPHIBD(Transform IEIHNIMHKCE, CJIPLNKDHLJ DEFLACGLPKN);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void KJLAFLIFAJF(Transform IEIHNIMHKCE, CCEOOFIGOLM NGNOCIABAAB);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OKINPGKLJGM(GameObject CGLKMGEDNPH, ObjectPolicyUserConfigurableFlags DEIODGDGPGM);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Vector3 CJDKDMLPICN(GameObject CGLKMGEDNPH, int CLEHDFNJKGM);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool BOGPHGFNCPJ(out Vector3 FADCMIMHMJH);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void LMEFPLFIJDC();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void PCCMCOPLBAK(GameObject NJMGBAPJOHE, bool FGOINGEANAD);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "33")]
	ObjectPrefabType BIGFJADPKDH(GameObject GMNIHJDBJGJ);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "34")]
	int PHGNJJJGLHE(GameObject CGLKMGEDNPH);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "35")]
	object DOENHEMGHBH(AIEJIADOHAF EHPNFPDFJDJ, GameObject CGLKMGEDNPH, Action<AIEJIADOHAF, int> OIBMDOLHJFJ);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void IGGAJIJCJIF(GameObject CGLKMGEDNPH, object HFPPAOFFLJN);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void EMDNGGOPFLJ(GameObject CGLKMGEDNPH);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void HLMNDAPDLIH(LBINFBCBAJB IFENDBDPCHC);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void PAJDPAHJIFD(GameObject CGLKMGEDNPH);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void KAKHFKECGJM(string JIEHBANCLJP);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	int HACNCKBDPAE(GameObject GMNIHJDBJGJ);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void JGELEBDKBFN(NativeArray<int> IJDKCIBLMMD);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void AFIHMHJANDE(Action INJMGBDPOBO, bool LFPKLMAJCKF);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool PNLFJEANLCN(string HNPIEGONNBC);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class JFFHFFKNCPB
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5AD4DC0", Offset = "0x5AD33C0", VA = "0x185AD4DC0")]
	public static DIEOBLMALKE FLDBLFJPDJO(this OIMMBHMCLGC OODHPHIHFDJ, JLPKHKEHPHF FJAJFKMDLKL, Vector3 FADCMIMHMJH, Quaternion HOHKOHLHECA, Vector3 KPABHDDPFGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface EEPLPEGKFFC
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct GECCGDGCHBH : GAIFJLIBHND<GECCGDGCHBH>, DMCNAIJDMDB, IEquatable<GECCGDGCHBH>
{
	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public int IKGMLJIBDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xC2E540", Offset = "0xC2CB40", VA = "0x180C2E540", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA47570", Offset = "0xA45B70", VA = "0x180A47570", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public int KPKAGFLDHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x15C4E60", Offset = "0x15C3460", VA = "0x1815C4E60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x187E3D0", Offset = "0x187C9D0", VA = "0x18187E3D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5AD3470", Offset = "0x5AD1A70", VA = "0x185AD3470", Slot = "8")]
	public bool Equals(GECCGDGCHBH EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5AD34C0", Offset = "0x5AD1AC0", VA = "0x185AD34C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct FFPIFKPNGLN : KIAMMPFPLDI, IEquatable<FFPIFKPNGLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public ObjectPrefabType INKNLFCIIAC;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5AD3260", Offset = "0x5AD1860", VA = "0x185AD3260", Slot = "5")]
	public void EMHFJGFFMPB(ref GIGHIDGOGIA PDNINNPJLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5AD3230", Offset = "0x5AD1830", VA = "0x185AD3230", Slot = "4")]
	public void DHDFEGACAHE(ref PMFHDCBANDG NKODOJNBMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5AD3320", Offset = "0x5AD1920", VA = "0x185AD3320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3EEE550", Offset = "0x3EECB50", VA = "0x183EEE550", Slot = "6")]
	public bool Equals(FFPIFKPNGLN EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5AD3290", Offset = "0x5AD1890", VA = "0x185AD3290", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0xC2E540", Offset = "0xC2CB40", VA = "0x180C2E540", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[KAEAKLGOHIG(GMBNIBPKKJK.Application)]
public interface LKAIOFDBANF
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action PBCCGAPLAOG;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NCOGNJEFLIN();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DLHMLOHADHI();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
public interface NNOBJJOHOKE
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	BOLDPBNDGFL PIBENIEJMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	List<EJJAPLIMLCB> EKDCPLFDGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AOBKCKEMHBG(EJJAPLIMLCB OMEMEFEKGAP, out BOLDPBNDGFL HBJKBGILPGD);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BLMBLLKPLEN(EJJAPLIMLCB OMEMEFEKGAP, OAJMIAIAIPN JGAOCGDCOME);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BFGBAKNGHOP(EJJAPLIMLCB OMEMEFEKGAP, OAJMIAIAIPN JGAOCGDCOME);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[KAEAKLGOHIG(GMBNIBPKKJK.Application)]
public interface GENOHKAEKDK
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	LKLOKPFPLPE FOHHKAPGODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct LOHABCBDDHD : IEquatable<LOHABCBDDHD>
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly LOHABCBDDHD OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private GKCHHELPBFO NGDBANEFGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5AD6AB0", Offset = "0x5AD50B0", VA = "0x185AD6AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float3 CJACACKPMCH
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5AD69C0", Offset = "0x5AD4FC0", VA = "0x185AD69C0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public quaternion OIPCPMPAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5AD6DB0", Offset = "0x5AD53B0", VA = "0x185AD6DB0")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public CBELJALGPAD FGCJOJJAPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5AD6C80", Offset = "0x5AD5280", VA = "0x185AD6C80")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public AIEJIADOHAF DOCLPKLCMEE
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690")]
		get
		{
			return default(AIEJIADOHAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private MDMCNHEDDOJ DMDBGNCGEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private BLGMLIKMCAK LDGNNMJJEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5AD6C30", Offset = "0x5AD5230", VA = "0x185AD6C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	public LOHABCBDDHD(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690")]
	public static AIEJIADOHAF BJIOOOHFEFG(LOHABCBDDHD FEBHELIDNED)
	{
		return default(AIEJIADOHAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5AD6B30", Offset = "0x5AD5130", VA = "0x185AD6B30", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(LOHABCBDDHD EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[KAEAKLGOHIG(GMBNIBPKKJK.Application)]
public interface BNBOCGMLPDM
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action JOADOPAOHJA;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action NFNOOIOADBD;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action OPHIHHNPNIC;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface BOLDPBNDGFL
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	string LNDCEMCHAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	BOLDPBNDGFL BCIFCGLMBDA
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	IEnumerable<BOLDPBNDGFL> OFJANELEOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[DefaultMember("Item")]
public struct LBINFBCBAJB : IReadOnlyList<AIEJIADOHAF>, IEnumerable<AIEJIADOHAF>, IEnumerable, IReadOnlyCollection<AIEJIADOHAF>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct KJEMAECGHFH : IEnumerator<AIEJIADOHAF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly MDMCNHEDDOJ HIHBENBCOLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private NativeArray<LocalId>.Enumerator NLCCEHBOCJM;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public AIEJIADOHAF PGNBHIOAFDF
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x5AD5690", Offset = "0x5AD3C90", VA = "0x185AD5690", Slot = "4")]
			get
			{
				return default(AIEJIADOHAF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x5AD55B0", Offset = "0x5AD3BB0", VA = "0x185AD55B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x15C38F0", Offset = "0x15C1EF0", VA = "0x1815C38F0")]
		public KJEMAECGHFH(MDMCNHEDDOJ HIHBENBCOLF, NativeArray<LocalId>.Enumerator NLCCEHBOCJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x5AD54F0", Offset = "0x5AD3AF0", VA = "0x185AD54F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5530", Offset = "0x5AD3B30", VA = "0x185AD5530", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5570", Offset = "0x5AD3B70", VA = "0x185AD5570", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly MDMCNHEDDOJ HIHBENBCOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeArray<LocalId> IFENDBDPCHC;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public AIEJIADOHAF KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5AD60A0", Offset = "0x5AD46A0", VA = "0x185AD60A0", Slot = "4")]
		get
		{
			return default(AIEJIADOHAF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5B90", Offset = "0x5AD4190", VA = "0x185AD5B90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private int FHEAANHIBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x86D470", Offset = "0x86BA70", VA = "0x18086D470", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int DIDJDLOPKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x86D470", Offset = "0x86BA70", VA = "0x18086D470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool EGOPANFHJLK
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5BA0", Offset = "0x5AD41A0", VA = "0x185AD5BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public NativeArray<LocalId> LIDACABLGPO
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x15C4D90", Offset = "0x15C3390", VA = "0x1815C4D90")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	internal NativeArray<Entity> JNKHBEKFHAK
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5B30", Offset = "0x5AD4130", VA = "0x185AD5B30")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5E50", Offset = "0x5AD4450", VA = "0x185AD5E50")]
	public LBINFBCBAJB(int IOKNIDFIOPP, MDMCNHEDDOJ HIHBENBCOLF, Allocator HDOCJKNPNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x15C38C0", Offset = "0x15C1EC0", VA = "0x1815C38C0")]
	public LBINFBCBAJB(MDMCNHEDDOJ HIHBENBCOLF, NativeArray<LocalId> IFENDBDPCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5EE0", Offset = "0x5AD44E0", VA = "0x185AD5EE0")]
	internal LBINFBCBAJB(MDMCNHEDDOJ HIHBENBCOLF, NativeArray<Entity> DJGJGAHPJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5F50", Offset = "0x5AD4550", VA = "0x185AD5F50")]
	public LBINFBCBAJB(MDMCNHEDDOJ HIHBENBCOLF, int CPHEGBCGAHF, Allocator HDOCJKNPNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5FF0", Offset = "0x5AD45F0", VA = "0x185AD5FF0")]
	public LBINFBCBAJB(LBINFBCBAJB HPGONDGNKBG, Allocator HDOCJKNPNPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5AF0", Offset = "0x5AD40F0", VA = "0x185AD5AF0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5BE0", Offset = "0x5AD41E0", VA = "0x185AD5BE0")]
	public KJEMAECGHFH PFBFKEIKCCB()
	{
		return default(KJEMAECGHFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5C70", Offset = "0x5AD4270", VA = "0x185AD5C70", Slot = "6")]
	private IEnumerator<AIEJIADOHAF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5D60", Offset = "0x5AD4360", VA = "0x185AD5D60", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct JLPKHKEHPHF : IComparable<JLPKHKEHPHF>, IEquatable<JLPKHKEHPHF>, KIAMMPFPLDI
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public const uint HKGHGAOEIMD = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public const uint AFJJGCFCLBB = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly JLPKHKEHPHF MJIPICDIFME;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const int IOJJCKPCCIO = 24;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const uint MCGNMEKJPBK = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const int GKOPCAKKAFD = 8;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private const uint CONIPBFNDKO = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly uint FBHPMOOILJP;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public uint IJFDDEKOECK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xBC3CD0", Offset = "0xBC22D0", VA = "0x180BC3CD0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public uint CNODGJBIHLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x5AD50B0", Offset = "0x5AD36B0", VA = "0x185AD50B0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public uint ABFEEBDADMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xC2E540", Offset = "0xC2CB40", VA = "0x180C2E540")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool PLFPHKBCLKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x532FBF0", Offset = "0x532E1F0", VA = "0x18532FBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool FLIPDIMGMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5AD52C0", Offset = "0x5AD38C0", VA = "0x185AD52C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x1E7C230", Offset = "0x1E7A830", VA = "0x181E7C230")]
	public static JLPKHKEHPHF ICNLGNPIMFI(uint FBHPMOOILJP)
	{
		return default(JLPKHKEHPHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5AD53A0", Offset = "0x5AD39A0", VA = "0x185AD53A0")]
	public JLPKHKEHPHF(int OIJHKJJKMIK, int OMIDODFKHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5AD53A0", Offset = "0x5AD39A0", VA = "0x185AD53A0")]
	public JLPKHKEHPHF(uint OIJHKJJKMIK, int OMIDODFKHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5AD53A0", Offset = "0x5AD39A0", VA = "0x185AD53A0")]
	public JLPKHKEHPHF(uint OIJHKJJKMIK, uint OMIDODFKHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0xA47570", Offset = "0xA45B70", VA = "0x180A47570")]
	private JLPKHKEHPHF(uint FBHPMOOILJP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x519C370", Offset = "0x519A970", VA = "0x18519C370")]
	public static bool MOJFGPLDDKP(JLPKHKEHPHF LLAFGJINMOA, JLPKHKEHPHF LKIHFBEPDMH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x519C380", Offset = "0x519A980", VA = "0x18519C380")]
	public static bool LFBHPMALHHK(JLPKHKEHPHF LLAFGJINMOA, JLPKHKEHPHF LKIHFBEPDMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5260", Offset = "0x5AD3860", VA = "0x185AD5260", Slot = "5")]
	public bool Equals(JLPKHKEHPHF LNHACNHDILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5190", Offset = "0x5AD3790", VA = "0x185AD5190", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x372D680", Offset = "0x372BC80", VA = "0x18372D680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5AD52D0", Offset = "0x5AD38D0", VA = "0x185AD52D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5AD50D0", Offset = "0x5AD36D0", VA = "0x185AD50D0", Slot = "6")]
	public void DHDFEGACAHE(ref PMFHDCBANDG NKODOJNBMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5130", Offset = "0x5AD3730", VA = "0x185AD5130", Slot = "7")]
	public void EMHFJGFFMPB(ref GIGHIDGOGIA PDNINNPJLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5AD50C0", Offset = "0x5AD36C0", VA = "0x185AD50C0", Slot = "4")]
	public int CompareTo(JLPKHKEHPHF EJECOGCICOM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface CMMJKEJBOBN
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCOEGAGFGLN(Entity PEKCJMKIHGK);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILIJKDKJPLP(Entity PEKCJMKIHGK, in float3 FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 OAHOABOBPBG(Entity PEKCJMKIHGK);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AKOHACCCCHD(Entity PEKCJMKIHGK, in quaternion FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion JGJPBBIKKBL(Entity PEKCJMKIHGK);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IEOLEIBMEOE(Entity PEKCJMKIHGK, in float3 FADCMIMHMJH, in quaternion HOHKOHLHECA);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MINGLPHAKIC(Entity PEKCJMKIHGK, out float3 FADCMIMHMJH, out quaternion HOHKOHLHECA);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MINGLPHAKIC(Entity PEKCJMKIHGK, out RigidTransform MBOPLLMEPFF);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KPIFCHFBLOC(Entity PEKCJMKIHGK, in float3 FADCMIMHMJH, in quaternion HOHKOHLHECA);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DFLMEDGGBOB(Entity PEKCJMKIHGK, out RigidTransform MBOPLLMEPFF);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float3 KPJCFJMFBPN(Entity PEKCJMKIHGK);

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HGNGANAPEKM(Entity PEKCJMKIHGK, in float3 FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FGEFEILHDGE(Entity PEKCJMKIHGK, float FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float EHFFLGPPANK(Entity PEKCJMKIHGK);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HJGDKGBDHAG(Entity PEKCJMKIHGK, in float3 FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 MKMLNHMPFPF(Entity PEKCJMKIHGK);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EHAJKHEEDHE(Entity PEKCJMKIHGK, in float3 FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 LKDOCFGLPHD(Entity PEKCJMKIHGK);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OOHMKIBDPKM(Entity PEKCJMKIHGK, in quaternion FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "19")]
	quaternion HAALEHDPEPI(Entity PEKCJMKIHGK);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 DIDKECJICGJ(Entity PEKCJMKIHGK);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void EIALPPJAGGF(Entity PEKCJMKIHGK, in float3 FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LIFPPOFBDGC(Entity PEKCJMKIHGK, float FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float JAHKNMDMCBN(Entity PEKCJMKIHGK);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void EPKAGDMCECP(Entity PEKCJMKIHGK, in float3 FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float3 PBBAEENJCOM(Entity PEKCJMKIHGK);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NCBGAAALEPH(Entity PEKCJMKIHGK, out float4x4 HBDOGBNHOBE);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void HFGPHIMFLDO(Entity PEKCJMKIHGK, in float4x4 HBDOGBNHOBE);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void EIAKOPKLIHE(Entity PEKCJMKIHGK, out float4x4 HBDOGBNHOBE);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool HNJMAPCHIDN(Entity PEKCJMKIHGK, out Transform IEIHNIMHKCE);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IHPKLFHCOGE(Entity PEKCJMKIHGK);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void DMBLGNABGNI(Entity PEKCJMKIHGK, Entity NOJJKLOEFMB, Entity BMPJGPJDGHG);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class JFIFDOJDFBL
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct HCNEPPCPGJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly IEnumerable<OOMENMIPJFG> FKPPPCNINKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly IReadOnlyList<GameObject> CHCBGKHIKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IReadOnlyList<int> ICJICKJEDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly int LNAOEMEMBHF;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool PLFPHKBCLKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3FE0", Offset = "0x5AD25E0", VA = "0x185AD3FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public int HGMDNOJOPDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x944070", Offset = "0x942670", VA = "0x180944070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IEnumerable<GameObject> FGMAGCDCMIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x9BE150", Offset = "0x9BC750", VA = "0x1809BE150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x9C0CF0", Offset = "0x9BF2F0", VA = "0x1809C0CF0")]
	public HCNEPPCPGJG(IEnumerable<OOMENMIPJFG> FKPPPCNINKD, IReadOnlyList<GameObject> CHCBGKHIKCD, IReadOnlyList<int> ICJICKJEDKA, int LNAOEMEMBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5AD4040", Offset = "0x5AD2640", VA = "0x185AD4040")]
	public IEnumerable<(GameObject, int)> GKIALPHLDEB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct CJGHEGNPGGH : IEquatable<CJGHEGNPGGH>
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly CJGHEGNPGGH OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private EHKILPFAOPG KHDNHBHIFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0510", Offset = "0x5ACEB10", VA = "0x185AD0510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public LBINFBCBAJB ELCAHHMIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1220", Offset = "0x5ACF820", VA = "0x185AD1220")]
		get
		{
			return default(LBINFBCBAJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public IEnumerable<CBELJALGPAD> PPNNCBGGBIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0F10", Offset = "0x5ACF510", VA = "0x185AD0F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public IEnumerable<CBELJALGPAD> LNBAPGOFCKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0980", Offset = "0x5ACEF80", VA = "0x185AD0980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int CMCOHGGIAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0B30", Offset = "0x5ACF130", VA = "0x185AD0B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public int EBIEEBLBBKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1080", Offset = "0x5ACF680", VA = "0x185AD1080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public string NHAFHGAJCFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5AD05B0", Offset = "0x5ACEBB0", VA = "0x185AD05B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public ContainerCollisionLayerEnum OGCANCDGGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1320", Offset = "0x5ACF920", VA = "0x185AD1320")]
		get
		{
			return default(ContainerCollisionLayerEnum);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1190", Offset = "0x5ACF790", VA = "0x185AD1190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public CollisionMode OJLFGGLDHGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0AC0", Offset = "0x5ACF0C0", VA = "0x185AD0AC0")]
		get
		{
			return default(CollisionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0490", Offset = "0x5ACEA90", VA = "0x185AD0490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool HFNHNDJCJLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0590", Offset = "0x5ACEB90", VA = "0x185AD0590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool FKCOPHLDCCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1200", Offset = "0x5ACF800", VA = "0x185AD1200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool LMIJOMLLOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0C20", Offset = "0x5ACF220", VA = "0x185AD0C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool KGHOBJIOOFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0EF0", Offset = "0x5ACF4F0", VA = "0x185AD0EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool BCHNFNPPDHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0500", Offset = "0x5ACEB00", VA = "0x185AD0500")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0820", Offset = "0x5ACEE20", VA = "0x185AD0820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool MMAEMNPKPCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0C10", Offset = "0x5ACF210", VA = "0x185AD0C10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0B20", Offset = "0x5ACF120", VA = "0x185AD0B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public AIEJIADOHAF DOCLPKLCMEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690")]
		get
		{
			return default(AIEJIADOHAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public AACKNDBGOGF LDKGJPDELDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(AACKNDBGOGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public OCBJCGCAGOE ALAPLOOKJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(OCBJCGCAGOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private MDMCNHEDDOJ DMDBGNCGEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private BLGMLIKMCAK LDGNNMJJEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0930", Offset = "0x5ACEF30", VA = "0x185AD0930")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
	public static CBELJALGPAD BJIOOOHFEFG(CJGHEGNPGGH GEAGAOEEJFO)
	{
		return default(CBELJALGPAD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5AD0ED0", Offset = "0x5ACF4D0", VA = "0x185AD0ED0")]
	public bool KFLFMGCMJIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5AD10D0", Offset = "0x5ACF6D0", VA = "0x185AD10D0")]
	public bool OGMHGEBDCMK(ContainerEnumFlags LGEAECDPGKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5AD0E50", Offset = "0x5ACF450", VA = "0x185AD0E50")]
	public void KEPJLEFIEPL(ContainerEnumFlags LGEAECDPGKJ, bool FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5AD0C40", Offset = "0x5ACF240", VA = "0x185AD0C40")]
	public LBINFBCBAJB JAOKLPIJIEB(Allocator HDOCJKNPNPA)
	{
		return default(LBINFBCBAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5AD0670", Offset = "0x5ACEC70", VA = "0x185AD0670")]
	public void EEGODMIBJDF(CJGHEGNPGGH EJECOGCICOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	public CJGHEGNPGGH(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD7B0", Offset = "0x5ACBDB0", VA = "0x185ACD7B0")]
	public static bool BJIOOOHFEFG(CJGHEGNPGGH FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5AD0830", Offset = "0x5ACEE30", VA = "0x185AD0830", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(CJGHEGNPGGH EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct LCOBMELKFMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal readonly PGKIALOLKML OCFMKLJCPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal readonly PGKIALOLKML ANMDJLIBDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal readonly uint ACCKKLFBPEP;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5AD62C0", Offset = "0x5AD48C0", VA = "0x185AD62C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct IICHHDDGOIE
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly CMJEFMOJNAO NJCJMLIIBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly LCOBMELKFMH INJMGBDPOBO;

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD47E0", Offset = "0x5AD2DE0", VA = "0x185AD47E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct JAKBFDJDDPH
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly CMJEFMOJNAO NJCJMLIIBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly LCOBMELKFMH INJMGBDPOBO;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5AD47E0", Offset = "0x5AD2DE0", VA = "0x185AD47E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct AOPDHKLIOFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly uint ACCKKLFBPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly bool LBHGBJGFPEI;

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD5F0", Offset = "0x5ACBBF0", VA = "0x185ACD5F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
public interface NMOPMAJCNOG
{
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMEACIMEIIJ(AIEJIADOHAF EHPNFPDFJDJ, CMEDKBLEPDC FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CMEDKBLEPDC PDGEJDJBHDG(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OHKLDBMINNB(AIEJIADOHAF EHPNFPDFJDJ, AIEJIADOHAF FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OPLEBKGGPAP(AIEJIADOHAF EHPNFPDFJDJ, AIEJIADOHAF FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int KCDHPAECDBB(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AIEJIADOHAF BOIIBAGLDNN(AIEJIADOHAF EHPNFPDFJDJ, int IIOMOLKAONM);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MLJKBNGDGGD(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CENAMCPBCGK(AIEJIADOHAF EHPNFPDFJDJ, object LODBJLOKBLP, AIEJIADOHAF FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EEIMNGJENNB(AIEJIADOHAF EHPNFPDFJDJ, object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JAPAOCPAHHD(AIEJIADOHAF EHPNFPDFJDJ, out AIEJIADOHAF FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JKNEPEFACBI(AIEJIADOHAF EHPNFPDFJDJ, float3 FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool JCBLAGMANMA(AIEJIADOHAF EHPNFPDFJDJ, out float3 FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MJNKMHHBDLG(AIEJIADOHAF EHPNFPDFJDJ, float3 FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool AIHHAMNMEMB(AIEJIADOHAF EHPNFPDFJDJ, out float3 FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HGFFBEBEPKK(AIEJIADOHAF EHPNFPDFJDJ, (Quaternion rot, Vector3 moments) EDPHAEDLFHN);

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool HDDEKKCKFJK(AIEJIADOHAF EHPNFPDFJDJ, out quaternion CBJHADKMJGC, out float3 NICLFJCLEDH);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NPNHCDLMHCB(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CJBOHIKFOAM(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete]
	float3 ACMKJCFIODB(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 LBOKMCNFCGN(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BOIGPOIGIOH(AIEJIADOHAF EHPNFPDFJDJ, float3 FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool DNDADHAGPPK(AIEJIADOHAF EHPNFPDFJDJ, out float3 PMNJOKOOFEN);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void ICHADHBFADN(AIEJIADOHAF EHPNFPDFJDJ, float3 FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void OGJEPHGOCCK(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	float FEKMDGENMME(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float FCIIKJDGGEA(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JDDMCNCDEIB(AIEJIADOHAF EHPNFPDFJDJ, float FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool MKLCNPNNELN(AIEJIADOHAF EHPNFPDFJDJ, out float JGAFGMLHFID);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BJEHPFMBOHI(AIEJIADOHAF EHPNFPDFJDJ, float FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "29")]
	CollisionDetectionMode PCGFLKCFDFM(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void BLINBGOCNGJ(AIEJIADOHAF EHPNFPDFJDJ, CollisionDetectionMode FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DEJBIADAKBB DPLFDENJLAJ(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void JECLBAJDMDE(AIEJIADOHAF EHPNFPDFJDJ, DEJBIADAKBB FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool DHGGNABOHCP(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void CIPKGEBCAIA(AIEJIADOHAF EHPNFPDFJDJ, bool FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "35")]
	AIEJIADOHAF AABLMKINBBF(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void MKBGEMJMEPL(AIEJIADOHAF EHPNFPDFJDJ, AIEJIADOHAF FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "37")]
	AIEJIADOHAF DILEMILBDPF(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void HGKEBMICHFN(AIEJIADOHAF EHPNFPDFJDJ, AIEJIADOHAF FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	BJDBFCFOACF EHEHLOCBEPM(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void BDNPHFKHGAN(AIEJIADOHAF EHPNFPDFJDJ, BJDBFCFOACF PPKMCBDGMPJ);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool JIGBCAMEKIF(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void OFEHKLIDIEK(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool FOKABKEBOAE(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void JPEDKKEJNCM(AIEJIADOHAF EHPNFPDFJDJ, bool FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool IBOOCNJJFCN(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void COFELCMPJEE(AIEJIADOHAF EHPNFPDFJDJ, bool FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "47")]
	RigidbodyConstraints PPLIKCENGGO(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void JKPBDOILEGO(AIEJIADOHAF EHPNFPDFJDJ, RigidbodyConstraints FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float CELHPNHBJBN(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void LPEKLHDIGJP(AIEJIADOHAF EHPNFPDFJDJ, float FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "51")]
	float MBJHFPMPFLE(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void BKKKKKINNMG(AIEJIADOHAF EHPNFPDFJDJ, float FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool MIJFCEADCEN(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void DNMAHNBIFIE(AIEJIADOHAF EHPNFPDFJDJ, bool FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "55")]
	bool MPFHAGMDJIG(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void PIAEFEFGBHF(AIEJIADOHAF EHPNFPDFJDJ, bool FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "57")]
	int PGEMDIOCLAK(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void OBINNGEELHD(AIEJIADOHAF EHPNFPDFJDJ, int FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(Slot = "59")]
	object PDKKNHMDAKN(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void AEONPMPJDLG(AIEJIADOHAF EHPNFPDFJDJ, object FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "61")]
	object FCKGGGHDOCN(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void JOJEGKPPEBC(AIEJIADOHAF EHPNFPDFJDJ, object FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "63")]
	float DJPEMHBLHPB(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void AOANOJALJKB(AIEJIADOHAF EHPNFPDFJDJ, float FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void CMGHDKCOJDA(AIEJIADOHAF EHPNFPDFJDJ, object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void PMNMPDDKJPN(AIEJIADOHAF EHPNFPDFJDJ, object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool LAEODOMMPHG(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void EMMIADAAKLE(AIEJIADOHAF EHPNFPDFJDJ, object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void NOJMBMJLEIL(AIEJIADOHAF EHPNFPDFJDJ, object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool MDIJCOLHBLB(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool DEJEENNOGCG(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void MIHDKNBEJHF(AIEJIADOHAF EHPNFPDFJDJ, bool FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Rigidbody LJHPHJAPFLB(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void ODDDGFPJDHG(AIEJIADOHAF EHPNFPDFJDJ, Rigidbody PJFGPOLLAAL);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void OFLHGNEJJLB(AIEJIADOHAF EHPNFPDFJDJ, object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void GHFKJENLLMH(AIEJIADOHAF EHPNFPDFJDJ, object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool OAIABMDHKKL(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void LDAJGMDLHIK(AIEJIADOHAF EHPNFPDFJDJ, float3 BHCAEBJCEFE);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void IMFAINDFIGO(AIEJIADOHAF EHPNFPDFJDJ, float3 LPOFGCMCEJI);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "80")]
	bool ACJFNKKPLKJ(AIEJIADOHAF EHPNFPDFJDJ, out float3 BHCAEBJCEFE);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool GCPOFHEADOG(AIEJIADOHAF EHPNFPDFJDJ, out float3 LPOFGCMCEJI);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "82")]
	bool FCJFIFJMCHG(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void BJNNCOGEIHI(AIEJIADOHAF EHPNFPDFJDJ, object LODBJLOKBLP, bool HCLOPJHBCEH);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void GJGEFIKGFKH(AIEJIADOHAF EHPNFPDFJDJ, bool JKHFELGNKFF);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void EPGPAOJANMK(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "86")]
	bool DJPEDOFEHNK(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "87")]
	IEnumerable<object> BKDCCBNFEKA(AIEJIADOHAF EHPNFPDFJDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
public interface BCLHAAMFMCE
{
	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFGBDMABPIK(Entity GNEABCEOKDO);

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CIAHJMEDIKE(Entity GNEABCEOKDO);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct HOMFNBJNNNF : IEquatable<HOMFNBJNNNF>
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly HOMFNBJNNNF OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public string FAIBFIAJKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5AD44B0", Offset = "0x5AD2AB0", VA = "0x185AD44B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public string BMFMAFCHECA
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x5AD46F0", Offset = "0x5AD2CF0", VA = "0x185AD46F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	public HOMFNBJNNNF(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x5AD43B0", Offset = "0x5AD29B0", VA = "0x185AD43B0", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(HOMFNBJNNNF EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct LKCLMLPFHKK : IEquatable<LKCLMLPFHKK>
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly LKCLMLPFHKK OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x5AD6680", Offset = "0x5AD4C80", VA = "0x185AD6680", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(LKCLMLPFHKK EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct OIODOPALBEJ : IEquatable<OIODOPALBEJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly OIODOPALBEJ OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private OHGMLGFAHCB HPMOPKACHCK
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x5AD9A70", Offset = "0x5AD8070", VA = "0x185AD9A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool NPDDKOIECIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5AD90B0", Offset = "0x5AD76B0", VA = "0x185AD90B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool BLAHIILBJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5AD9340", Offset = "0x5AD7940", VA = "0x185AD9340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool BAFDDMCEPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5AD91C0", Offset = "0x5AD77C0", VA = "0x185AD91C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool FFEHMGCPAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x5AD8E20", Offset = "0x5AD7420", VA = "0x185AD8E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool OKPLPIPBFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x5AD8FC0", Offset = "0x5AD75C0", VA = "0x185AD8FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool KBJFIAIDEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x5AD9480", Offset = "0x5AD7A80", VA = "0x185AD9480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool JOOJNEHHGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5AD9830", Offset = "0x5AD7E30", VA = "0x185AD9830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public AIEJIADOHAF DOCLPKLCMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690")]
		get
		{
			return default(AIEJIADOHAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private MDMCNHEDDOJ DMDBGNCGEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private BLGMLIKMCAK LDGNNMJJEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5AD92F0", Offset = "0x5AD78F0", VA = "0x185AD92F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5AD9190", Offset = "0x5AD7790", VA = "0x185AD9190")]
	public bool EMONPHEEFJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD8E60", Offset = "0x5AD7460", VA = "0x185AD8E60")]
	public CBELJALGPAD DHFJPNLBPKP(CBELJALGPAD DPNGJGBLPFN)
	{
		return default(CBELJALGPAD);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x5AD9670", Offset = "0x5AD7C70", VA = "0x185AD9670")]
	public AIEJIADOHAF MMOBFNDHHEC()
	{
		return default(AIEJIADOHAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	public OIODOPALBEJ(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD7B0", Offset = "0x5ACBDB0", VA = "0x185ACD7B0")]
	public static bool BJIOOOHFEFG(OIODOPALBEJ FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x5AD91F0", Offset = "0x5AD77F0", VA = "0x185AD91F0", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(OIODOPALBEJ EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct DMCAMPNBLKJ : IComparable<DMCAMPNBLKJ>, IEquatable<DMCAMPNBLKJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly DMCAMPNBLKJ MJIPICDIFME;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly DMCAMPNBLKJ HJDDELBIEBF;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly DMCAMPNBLKJ HJGEMJLCCOB;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly DMCAMPNBLKJ JENCAIJPAIJ;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly DMCAMPNBLKJ GAFECJJGKDN;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly DMCAMPNBLKJ DAHKEADBBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public int IKGMLJIBDML;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool NMNHOJFPODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x5AD13C0", Offset = "0x5ACF9C0", VA = "0x185AD13C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0xA47570", Offset = "0xA45B70", VA = "0x180A47570")]
	public DMCAMPNBLKJ(int IIOMOLKAONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1470", Offset = "0x5ACFA70", VA = "0x185AD1470", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x5AD13E0", Offset = "0x5ACF9E0", VA = "0x185AD13E0", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x3EEE550", Offset = "0x3EECB50", VA = "0x183EEE550", Slot = "5")]
	public bool Equals(DMCAMPNBLKJ EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x5AD13D0", Offset = "0x5ACF9D0", VA = "0x185AD13D0", Slot = "4")]
	public int CompareTo(DMCAMPNBLKJ EJECOGCICOM)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x1E7C230", Offset = "0x1E7A830", VA = "0x181E7C230")]
	public static DMCAMPNBLKJ BJIOOOHFEFG(int IIOMOLKAONM)
	{
		return default(DMCAMPNBLKJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x1E7C230", Offset = "0x1E7A830", VA = "0x181E7C230")]
	public static int BJIOOOHFEFG(DMCAMPNBLKJ GMFCGGOOKOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x5AD14E0", Offset = "0x5ACFAE0", VA = "0x185AD14E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface LLLAMIHNCHM : IEnumerable<FDODPLMFAKJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	FDODPLMFAKJ KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FDODPLMFAKJ INBDFKHIIHK(CLLJMNNCKMG LDLHPBNHANP);

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DMCAMPNBLKJ JFELANGNBDJ(CLLJMNNCKMG LDLHPBNHANP);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class NACPKKNJIJD
{
	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	public static FEFHMMPJLAL<T> INBDFKHIIHK<T>(this LLLAMIHNCHM GOMAHIOPLHH, CLLJMNNCKMG HNPIEGONNBC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x27157E0", Offset = "0x2713DE0", VA = "0x1827157E0")]
	public static DMCAMPNBLKJ JFELANGNBDJ<T>(this LLLAMIHNCHM GOMAHIOPLHH, JGHGJDHNFBJ<T> HNPIEGONNBC) where T : struct
	{
		return default(DMCAMPNBLKJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface NCIGGAADPPM
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CGIKNPNDEOD(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ANBEKOEEIGM(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LGAIBOALMCG(AIEJIADOHAF EHPNFPDFJDJ, out Guid ELEBJEJCHNH);

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid LJGHEFMDGGM(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ACFIHCDAEKE(AIEJIADOHAF EHPNFPDFJDJ, Guid ELEBJEJCHNH);

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GLBEKPJHAOM(AIEJIADOHAF EHPNFPDFJDJ, out Guid IGPIKBBAHPG);

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid EFFKFOGAEMK(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LPAIKJECIJG(AIEJIADOHAF EHPNFPDFJDJ, Guid IGPIKBBAHPG);

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DFNDMMNHNCF(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BPNHAPJOEKE(AIEJIADOHAF AIMPELPKDNP, AIEJIADOHAF KHJHJOOPMKP);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
public interface GJLPANMLACP
{
	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PMJALEGGEEL(AIEJIADOHAF PAGDHPEICGI, bool FEBHELIDNED);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct LLFGAGOKFIA : IEquatable<LLFGAGOKFIA>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly LLFGAGOKFIA OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public BOINGAAAIME NEMNGMDANFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(BOINGAAAIME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private ACNLLHDNCAC LECOIGEBIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x5AD6920", Offset = "0x5AD4F20", VA = "0x185AD6920")]
		get
		{
			return default(ACNLLHDNCAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public PrimitiveShapeType HKLPCBEKAMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x5AD68C0", Offset = "0x5AD4EC0", VA = "0x185AD68C0")]
		get
		{
			return default(PrimitiveShapeType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public AIEJIADOHAF DOCLPKLCMEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690")]
		get
		{
			return default(AIEJIADOHAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	public LLFGAGOKFIA(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD7B0", Offset = "0x5ACBDB0", VA = "0x185ACD7B0")]
	public static bool BJIOOOHFEFG(LLFGAGOKFIA FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5AD67C0", Offset = "0x5AD4DC0", VA = "0x185AD67C0", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(LLFGAGOKFIA EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
public interface HIBNBCEFDLA
{
	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DAOMJOJIIIP(AIEJIADOHAF EHPNFPDFJDJ, ContainerCollisionLayerEnum NHCHAAOMJFJ, bool PNBAFBCIGBE, ContainerEnumFlags KMLFAIIEDFB);

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJFMCPFEEAO(AIEJIADOHAF EHPNFPDFJDJ, ContainerCollisionLayerEnum NHCHAAOMJFJ, bool PNBAFBCIGBE, bool HFPFGBLDLPH, bool KJIGNEAOEOA);

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CPKDAEAJPMH FOJOCFINGDL(AIEJIADOHAF MPEICFNBKOF, List<AIEJIADOHAF> IBFFAIEPINL);

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PIEPHCJGHPE(GameObject MDECHHPNDGB, GameObject OFGDHBCKHIM);

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OIDHPAIJBCI(GameObject OFGDHBCKHIM);

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T AHJAFICPCEP<T>(GameObject CJGPPLOJCEH) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BEOGOAKMKOH(Collider OHNLBFFNOJG);

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject HFFJNAMNGON<T>(string HNPIEGONNBC) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface FNIFPCAPMKM
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	bool AGOOCBLDBDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	AIEJIADOHAF DOCLPKLCMEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[KAEAKLGOHIG(GMBNIBPKKJK.Application)]
public interface FIIJBGOABOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	bool MCFHGIEDJGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	bool HOCKLHLNMLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	AAJLOOHEGIL FNDKFOMNKHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void INBKDCIOLHP(bool OGJCOIOGMOG);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task MJDLDMNPFEB(bool OGJCOIOGMOG);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OINAJNHIOBP FFDLKDFLKFB();

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OINAJNHIOBP LGBPJIPJJDO(IEnumerable<AIEJIADOHAF> IFENDBDPCHC, in KGDNDLAGOFK JLFHGAILCBJ);

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MNKKENBHJHP KBIHALELCHG(ByteString BOELNJCHAEO);

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JFOMIOOEKFH BCOCPHJJPHC(ByteString FBJCGAGDCPB, AIEJIADOHAF KHJHJOOPMKP, in KGDNDLAGOFK BEHIKHCHFOH, ENKAENLLILN NOPKDNELDKO, bool EAADJOADHOK = true);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ILBAGMFKPPE();

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ICOABIHLDIK(bool NLLJIKMHNFL);

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HCNEPPCPGJG AGAJHKMHGGJ(IEnumerable<OOMENMIPJFG> FKPPPCNINKD);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class KPAFLODDDJP
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[KAEAKLGOHIG(GMBNIBPKKJK.Application)]
public interface LEBPHEIBKKF : FGDOOFLOFCP, AMIGGHNJKLM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	bool PGDNGHJKGGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	HEOCAEGOLLB AKDADDEJFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	OIMMBHMCLGC JLLINPPOIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	BLGMLIKMCAK LDGNNMJJEKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[KAEAKLGOHIG(GMBNIBPKKJK.Application)]
public interface AMIGGHNJKLM
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	bool EJJKPGEEHMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
public interface JMMKHAHPEDG
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	bool PIKLBDDAEFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
public interface GOJFGIMBKFC
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	Guid GFPCEEDIHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PICMHDGNOAC(Guid ELEBJEJCHNH, Guid IGPIKBBAHPG, string HNPIEGONNBC);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct PGKIALOLKML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal int BIKMMIGFKEM;

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5ADA8E0", Offset = "0x5AD8EE0", VA = "0x185ADA8E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class FPPDAOEJNDA
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private struct GGGGKKLGKCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Guid IKGPBILBBIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NPCEGNKDHCI CAILGGKMKMN;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private struct NPCEGNKDHCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int FEBHELIDNED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int PLLIDINLPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int EMFHLBNJJMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int OKLHIOPLKJI;

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5AD7E60", Offset = "0x5AD6460", VA = "0x185AD7E60")]
		public bool OBFEALCEPIG(out JLPKHKEHPHF FJAJFKMDLKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x5AD7F00", Offset = "0x5AD6500", VA = "0x185AD7F00")]
		public NPCEGNKDHCI(JLPKHKEHPHF FJAJFKMDLKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5AD33B0", Offset = "0x5AD19B0", VA = "0x185AD33B0")]
	public static Guid BFHDMIEEDBG(this JLPKHKEHPHF FJAJFKMDLKL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x5AD3450", Offset = "0x5AD1A50", VA = "0x185AD3450")]
	public static bool EPIIDJDMEHF(this Guid IKGPBILBBIK, out JLPKHKEHPHF FJAJFKMDLKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(OLBEHABOLFA))]
public readonly struct AIEJIADOHAF : IComparable<AIEJIADOHAF>, IEquatable<AIEJIADOHAF>
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly AIEJIADOHAF MJIPICDIFME;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public MDMCNHEDDOJ DMDBGNCGEPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public LocalId EDLOPPEDFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x9BE150", Offset = "0x9BC750", VA = "0x1809BE150")]
		[CompilerGenerated]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool PFAIEHOFDHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x5ACCC80", Offset = "0x5ACB280", VA = "0x185ACCC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool JGHNPEDPALL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x5ACCDC0", Offset = "0x5ACB3C0", VA = "0x185ACCDC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool ICCDHMCMKDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x5ACCDE0", Offset = "0x5ACB3E0", VA = "0x185ACCDE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD0A0", Offset = "0x5ACB6A0", VA = "0x185ACD0A0")]
	public AIEJIADOHAF(MDMCNHEDDOJ LFNPDPEMFAH, LocalId EHPNFPDFJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
	public CBELJALGPAD PFKPEOFJDAN()
	{
		return default(CBELJALGPAD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x9BE150", Offset = "0x9BC750", VA = "0x1809BE150")]
	public static LocalId BJIOOOHFEFG(AIEJIADOHAF CJIDPEHLNAD)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCD50", Offset = "0x5ACB350", VA = "0x185ACCD50")]
	public static Entity BJIOOOHFEFG(AIEJIADOHAF CJIDPEHLNAD)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCF50", Offset = "0x5ACB550", VA = "0x185ACCF50")]
	public static bool MOJFGPLDDKP(AIEJIADOHAF LLAFGJINMOA, AIEJIADOHAF LKIHFBEPDMH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCEB0", Offset = "0x5ACB4B0", VA = "0x185ACCEB0")]
	public static bool LFBHPMALHHK(AIEJIADOHAF LLAFGJINMOA, AIEJIADOHAF LKIHFBEPDMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCFA0", Offset = "0x5ACB5A0", VA = "0x185ACCFA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCE00", Offset = "0x5ACB400", VA = "0x185ACCE00", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCD60", Offset = "0x5ACB360", VA = "0x185ACCD60", Slot = "4")]
	public int CompareTo(AIEJIADOHAF EJECOGCICOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "5")]
	public bool Equals(AIEJIADOHAF EJECOGCICOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class PBCGFKMPIDM
{
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x5ADA7F0", Offset = "0x5AD8DF0", VA = "0x185ADA7F0")]
	public static JLPKHKEHPHF MHFOFECMKGN(this AIEJIADOHAF IAMEECMGPIF)
	{
		return default(JLPKHKEHPHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x1BF9220", Offset = "0x1BF7820", VA = "0x181BF9220")]
	public static T EELDDJLLIIM<T>(this AIEJIADOHAF IAMEECMGPIF) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class OLBEHABOLFA
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
public interface EJCELCGLOFD
{
	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	bool PGDNGHJKGGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEEOGBCBCNH(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DPMGAGHPLDA(AIEJIADOHAF EHPNFPDFJDJ, bool PNBAFBCIGBE, bool HFPFGBLDLPH, bool PPJHBDFFDOA);
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct IIMIHPCMHFF : IEquatable<IIMIHPCMHFF>
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly IIMIHPCMHFF OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public AIEJIADOHAF DOCLPKLCMEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690")]
		get
		{
			return default(AIEJIADOHAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private MDMCNHEDDOJ DMDBGNCGEPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private BLGMLIKMCAK LDGNNMJJEKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x5AD4AC0", Offset = "0x5AD30C0", VA = "0x185AD4AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5AD4880", Offset = "0x5AD2E80", VA = "0x185AD4880")]
	public void EEADNPIGCKD(bool FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5AD4B10", Offset = "0x5AD3110", VA = "0x185AD4B10")]
	public void ILAIKFDGAMJ(bool FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2017F70", Offset = "0x2016570", VA = "0x182017F70")]
	public T BINLEIAHDHB<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	public IIMIHPCMHFF(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5AD49C0", Offset = "0x5AD2FC0", VA = "0x185AD49C0", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(IIMIHPCMHFF EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct KLPAKBHOFJA : IEquatable<KLPAKBHOFJA>
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly KLPAKBHOFJA OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5AD59B0", Offset = "0x5AD3FB0", VA = "0x185AD59B0", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(KLPAKBHOFJA EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[KAEAKLGOHIG(GMBNIBPKKJK.Application)]
public interface BFMMBBOONKH
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	bool BKJENJKPDBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	bool FKLFOHPFNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	bool MBOOMDJHFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	bool HDGFHJBLNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	bool NOEBKGPEBIP
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	bool IPALJPALNKI
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	bool BAKLPNDNMJO
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct FDAAIAENPGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float DGCKGDHMMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float3 MCAKNKCONJB;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct BOINGAAAIME : IEquatable<BOINGAAAIME>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly BOINGAAAIME OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private PJFPMDLAMIM ADGGIILGJCN
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF1D0", Offset = "0x5ACD7D0", VA = "0x185ACF1D0")]
		get
		{
			return default(PJFPMDLAMIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public NCAFHGAIGJM PMLGPKLGGNE
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF480", Offset = "0x5ACDA80", VA = "0x185ACF480")]
		get
		{
			return default(NCAFHGAIGJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public CHGOJEGBJNG CLFNPODCKIO
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF3A0", Offset = "0x5ACD9A0", VA = "0x185ACF3A0")]
		get
		{
			return default(CHGOJEGBJNG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public FPFMFENIOBG CAHOHMPOAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x5ACEF60", Offset = "0x5ACD560", VA = "0x185ACEF60")]
		get
		{
			return default(FPFMFENIOBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public EShapeType ONNBNADCMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF400", Offset = "0x5ACDA00", VA = "0x185ACF400")]
		get
		{
			return default(EShapeType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public RenderableColor NCILMPDNAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x5ACEF00", Offset = "0x5ACD500", VA = "0x185ACEF00")]
		get
		{
			return default(RenderableColor);
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF5D0", Offset = "0x5ACDBD0", VA = "0x185ACF5D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public RenderableMaterial NKGKBLOKJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x5ACEDD0", Offset = "0x5ACD3D0", VA = "0x185ACEDD0")]
		get
		{
			return default(RenderableMaterial);
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF2C0", Offset = "0x5ACD8C0", VA = "0x185ACF2C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public float DGJIFNJGHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x5ACED70", Offset = "0x5ACD370", VA = "0x185ACED70")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF150", Offset = "0x5ACD750", VA = "0x185ACF150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 PHBJBPAOIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF0C0", Offset = "0x5ACD6C0", VA = "0x185ACF0C0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF230", Offset = "0x5ACD830", VA = "0x185ACF230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public float LEANNHKDLPL
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF550", Offset = "0x5ACDB50", VA = "0x185ACF550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public ShapeConfigData.Flags HBDDPIFGOFE
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x5ACEE30", Offset = "0x5ACD430", VA = "0x185ACEE30")]
		get
		{
			return default(ShapeConfigData.Flags);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x5ACEE90", Offset = "0x5ACD490", VA = "0x185ACEE90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public AIEJIADOHAF DOCLPKLCMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690")]
		get
		{
			return default(AIEJIADOHAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public AACKNDBGOGF LDKGJPDELDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(AACKNDBGOGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x5ACF4E0", Offset = "0x5ACDAE0", VA = "0x185ACF4E0")]
	public LLFGAGOKFIA MOBIAHGKDOF()
	{
		return default(LLFGAGOKFIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x5ACF330", Offset = "0x5ACD930", VA = "0x185ACF330")]
	public BMEGNONALPO KHDFKFJKAEI()
	{
		return default(BMEGNONALPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	public BOINGAAAIME(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD7B0", Offset = "0x5ACBDB0", VA = "0x185ACD7B0")]
	public static bool BJIOOOHFEFG(BOINGAAAIME FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5ACEFC0", Offset = "0x5ACD5C0", VA = "0x185ACEFC0", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(BOINGAAAIME EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[KAEAKLGOHIG(GMBNIBPKKJK.Application)]
public interface BLGMLIKMCAK
{
	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	AONANDJIJLG AKDADDEJFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	OIMMBHMCLGC JLLINPPOIKE
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	GOIGDNBBPCE OIEFMCLOMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	MDMCNHEDDOJ DMDBGNCGEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	EHKILPFAOPG ALAPLOOKJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	CMMJKEJBOBN PPNHIJADGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	FIIJBGOABOE FPLGBPLOGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	IKNMCINAEEI AJFLAMFEHAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	MDJGNCFEHHF CBIKLAKEMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	OHGMLGFAHCB HDKKFAMLNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	BFLFBIBFGEH HKJBFJHBFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	GJLPANMLACP MKIGPFEFGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	BCLFIGEAPCO ODPNEJIMMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	NCIGGAADPPM ANNPEOPCADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	GKCHHELPBFO GDLNPHINGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	NMOPMAJCNOG LJDJKIPGIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	BFMMBBOONKH GPHBAOMINLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
public interface HADGGCLDABI
{
	[Cpp2IlInjected.Token(Token = "0x17000104")]
	object HLOIKNDDADM
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HLMNDAPDLIH(LBINFBCBAJB IFENDBDPCHC);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface EHKILPFAOPG
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public delegate void ONDLKLENHMA(LBINFBCBAJB HIHBENBCOLF, LBINFBCBAJB NNJNJCOILNP, LBINFBCBAJB PFKCMNFGHBH);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AIEJIADOHAF AABLMKINBBF(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AIEJIADOHAF DILEMILBDPF(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HGKEBMICHFN(AIEJIADOHAF EHPNFPDFJDJ, AIEJIADOHAF KHJHJOOPMKP, bool HKIOJBCBMCC);

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PHANEJNNMCJ(AIEJIADOHAF EHPNFPDFJDJ, AIEJIADOHAF KHJHJOOPMKP);

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int KCDHPAECDBB(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LBINFBCBAJB MIAILMCBIGM(AIEJIADOHAF PAGDHPEICGI);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MALIGHLFLMH(AIEJIADOHAF EHPNFPDFJDJ, AIEJIADOHAF DKAMNPKDEFD);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool AHDHKBGGAKJ(AIEJIADOHAF EHPNFPDFJDJ, AIEJIADOHAF PGGIOMMDBAK);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AIEJIADOHAF AHEBLLIPEFK(AIEJIADOHAF DKAMNPKDEFD, AIEJIADOHAF BCEEACEDILA);

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GGDKOLIMOAB(AIEJIADOHAF DKAMNPKDEFD, AIEJIADOHAF BCEEACEDILA, out AIEJIADOHAF KNIBHOMLKHF);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class LBJJHLIJHGH
{
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x5AD60E0", Offset = "0x5AD46E0", VA = "0x185AD60E0")]
	public static bool OOPCMFCPAAK(this EHKILPFAOPG DFAJGJDLFMJ, AIEJIADOHAF EHPNFPDFJDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public enum CFELAPKFMGP
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Legacy,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Embodied,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Disembodying,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Disembodied
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
public interface IKNMCINAEEI
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<AIEJIADOHAF> OBOMFFFPDKD(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AIEJIADOHAF DFBIICBNLHE(AIEJIADOHAF EHPNFPDFJDJ, int IIOMOLKAONM);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int HDMFCABGFFG(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HOLODDBGGIJ DOMCHOEJDGD(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MMIIOGPNPMJ(AIEJIADOHAF EHPNFPDFJDJ, HOLODDBGGIJ CCDJMIJMJKG);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AIEJIADOHAF LICKDBCLCCC(AIEJIADOHAF EHPNFPDFJDJ, [Optional] float3? FADCMIMHMJH, [Optional] quaternion? HOHKOHLHECA, [Optional] float3? KPABHDDPFGG);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AIEJIADOHAF KFCHFIGBOJF(AIEJIADOHAF EHPNFPDFJDJ, int IIOMOLKAONM, [Optional] float3? FADCMIMHMJH, [Optional] quaternion? HOHKOHLHECA, [Optional] float3? KPABHDDPFGG);

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HAMFHLFMAJM(AIEJIADOHAF EHPNFPDFJDJ, int IIOMOLKAONM);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PKPHOPBKMHF(AIEJIADOHAF EHPNFPDFJDJ);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface KPJNLAPEMMO
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KEJIPHLGONJ(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BDJFBLNDNGD(AIEJIADOHAF EHPNFPDFJDJ, Transform IEIHNIMHKCE);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface GOFJCDAGEHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000105")]
	LocalId JDNMIJBGANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	LocalId BOODKGLCOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NOCPLDOJOPP(float3 JFGEFOCIEAG);

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FHHGHEIFAGJ(float3 JFGEFOCIEAG);

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PLODKKGCIPE(out float3 OCFMKLJCPIC, out float3 ANMDJLIBDCA);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NCCCAPIFODC(float3 OCFMKLJCPIC, float3 ANMDJLIBDCA);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CLHBHDKHNJH(Color OCFMKLJCPIC, Color ANMDJLIBDCA);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GOFJCDAGEHB Instantiate(Transform IEIHNIMHKCE);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface MHCNMANLKOE
{
	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KGHKJOCLFMF(Transform IEIHNIMHKCE, GOFJCDAGEHB ENKKGNNILEO);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GOFJCDAGEHB OOPDNHLMMKE();
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct KKGLEOIEPED : IEquatable<KKGLEOIEPED>
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly KKGLEOIEPED OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	private KAKPGGDGODD CHMCHEKOPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5760", Offset = "0x5AD3D60", VA = "0x185AD5760")]
		get
		{
			return default(KAKPGGDGODD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public PropType IPCEJAEFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5700", Offset = "0x5AD3D00", VA = "0x185AD5700")]
		get
		{
			return default(PropType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x5AD58C0", Offset = "0x5AD3EC0", VA = "0x185AD58C0")]
	public EMPIPIJOHPF NECOEIMKDJE()
	{
		return default(EMPIPIJOHPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	public KKGLEOIEPED(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x5AD57C0", Offset = "0x5AD3DC0", VA = "0x185AD57C0", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(KKGLEOIEPED EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface IGJAIIMLBJP
{
	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIBHEJKBMND();
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class ONIIPDINCHH
{
	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x5ADA220", Offset = "0x5AD8820", VA = "0x185ADA220")]
	public static void OIBHEJKBMND(this GameObject GMNIHJDBJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct EKDEDALMLCB : IEquatable<EKDEDALMLCB>
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly EKDEDALMLCB OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD2160", Offset = "0x5AD0760", VA = "0x185AD2160", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(EKDEDALMLCB EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct OCCCFAEHDLO : IEquatable<OCCCFAEHDLO>
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static readonly OCCCFAEHDLO OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	public OCCCFAEHDLO(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x5AD8CE0", Offset = "0x5AD72E0", VA = "0x185AD8CE0", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(OCCCFAEHDLO EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x5AD8BB0", Offset = "0x5AD71B0", VA = "0x185AD8BB0")]
	public bool EEAEBOIPEHA(out Collider OHNLBFFNOJG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct BMMDCLAMBPO : IEquatable<BMMDCLAMBPO>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly BMMDCLAMBPO OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public AIEJIADOHAF DOCLPKLCMEE
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690")]
		get
		{
			return default(AIEJIADOHAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public BMEGNONALPO PFHJJPDEFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x5ACEA30", Offset = "0x5ACD030", VA = "0x185ACEA30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public float3 LNGMBEAPKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE8C0", Offset = "0x5ACCEC0", VA = "0x185ACE8C0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x5ACEAF0", Offset = "0x5ACD0F0", VA = "0x185ACEAF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public quaternion ADFIAGOOGDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE9B0", Offset = "0x5ACCFB0", VA = "0x185ACE9B0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE520", Offset = "0x5ACCB20", VA = "0x185ACE520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float3 LBHFNHABPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x5ACECA0", Offset = "0x5ACD2A0", VA = "0x185ACECA0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE600", Offset = "0x5ACCC00", VA = "0x185ACE600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public EALGDNFPJGP CNOFGIGAPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE690", Offset = "0x5ACCC90", VA = "0x185ACE690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private PPIIKAOFABA DHDCFHGPLML
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE860", Offset = "0x5ACCE60", VA = "0x185ACE860")]
		get
		{
			return default(PPIIKAOFABA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	private EDEIFOAEPKP IFKIGJPHJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE950", Offset = "0x5ACCF50", VA = "0x185ACE950")]
		get
		{
			return default(EDEIFOAEPKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	private GCNKFELAJBE HAIDANOELMB
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE800", Offset = "0x5ACCE00", VA = "0x185ACE800")]
		get
		{
			return default(GCNKFELAJBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	private DMIFPGLLNFG IMKFEGBLOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE5A0", Offset = "0x5ACCBA0", VA = "0x185ACE5A0")]
		get
		{
			return default(DMIFPGLLNFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	private MKJJEOFFCBA LCOAPGOAHJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x5ACEC40", Offset = "0x5ACD240", VA = "0x185ACEC40")]
		get
		{
			return default(MKJJEOFFCBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	public BMMDCLAMBPO(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x5ACE700", Offset = "0x5ACCD00", VA = "0x185ACE700", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(BMMDCLAMBPO EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x5ACEB80", Offset = "0x5ACD180", VA = "0x185ACEB80")]
	public void KLLNHOHELPN(BMEGNONALPO FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x5ACEAF0", Offset = "0x5ACD0F0", VA = "0x185ACEAF0")]
	public void ILIJKDKJPLP(float3 FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x5ACE520", Offset = "0x5ACCB20", VA = "0x185ACE520")]
	public void AKOHACCCCHD(quaternion FEBHELIDNED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct AACKNDBGOGF : IEquatable<AACKNDBGOGF>
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public static readonly AACKNDBGOGF OLFLDHDLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly AIEJIADOHAF PAGDHPEICGI;

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public CBELJALGPAD JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB630", Offset = "0x5AC9C30", VA = "0x185ACB630")]
		get
		{
			return default(CBELJALGPAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private MDMCNHEDDOJ DMDBGNCGEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	private CMMJKEJBOBN AAOANDOMFJP
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB650", Offset = "0x5AC9C50", VA = "0x185ACB650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public bool HABICEMKMMI
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB5E0", Offset = "0x5AC9BE0", VA = "0x185ACB5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Vector3 LNGMBEAPKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5ACAAD0", Offset = "0x5AC90D0", VA = "0x185ACAAD0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x5ACBA60", Offset = "0x5ACA060", VA = "0x185ACBA60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion ADFIAGOOGDM
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x5ACAEA0", Offset = "0x5AC94A0", VA = "0x185ACAEA0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB200", Offset = "0x5AC9800", VA = "0x185ACB200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Vector3 JEKEADKLECO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5ACC590", Offset = "0x5ACAB90", VA = "0x185ACC590")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5AC9890", Offset = "0x5AC7E90", VA = "0x185AC9890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Quaternion HCENNMNFPLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x5ACC1A0", Offset = "0x5ACA7A0", VA = "0x185ACC1A0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB6C0", Offset = "0x5AC9CC0", VA = "0x185ACB6C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public float MNBIEAAONEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x5ACC490", Offset = "0x5ACAA90", VA = "0x185ACC490")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x5AC9780", Offset = "0x5AC7D80", VA = "0x185AC9780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public float JFIILHNBEGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x5AC9EE0", Offset = "0x5AC84E0", VA = "0x185AC9EE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public Vector3 LBHFNHABPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x5ACBBA0", Offset = "0x5ACA1A0", VA = "0x185ACBBA0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5AC99D0", Offset = "0x5AC7FD0", VA = "0x185AC99D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public Vector3 KIGOOOBEELH
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x5ACC970", Offset = "0x5ACAF70", VA = "0x185ACC970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Vector3 DKADJJBCCBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x5ACCAB0", Offset = "0x5ACB0B0", VA = "0x185ACCAB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Matrix4x4 CPKNNGKCDND
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB040", Offset = "0x5AC9640", VA = "0x185ACB040")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	public AACKNDBGOGF(AIEJIADOHAF EHPNFPDFJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x1F00260", Offset = "0x1EFE860", VA = "0x181F00260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA6B0", Offset = "0x5AC8CB0", VA = "0x185ACA6B0", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA610", Offset = "0x5AC8C10", VA = "0x185ACA610", Slot = "4")]
	public bool Equals(AACKNDBGOGF EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCC00", Offset = "0x5ACB200", VA = "0x185ACCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA8C0", Offset = "0x5AC8EC0", VA = "0x185ACA8C0")]
	public BCMKHJJBBNL FNBLBDKLKCN()
	{
		return default(BCMKHJJBBNL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5ACC010", Offset = "0x5ACA610", VA = "0x185ACC010")]
	public void NEFECHEADNO(out Matrix4x4 HBDOGBNHOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5ACBCF0", Offset = "0x5ACA2F0", VA = "0x185ACBCF0")]
	public void MINGLPHAKIC(out Vector3 BDNIFFMLDMB, out Quaternion GMCCDMMKDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5AC9C80", Offset = "0x5AC8280", VA = "0x185AC9C80")]
	public void DFLMEDGGBOB(out RigidTransform PEGFBFIMHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA480", Offset = "0x5AC8A80", VA = "0x185ACA480")]
	public KGDNDLAGOFK EMGPAEHIDBG()
	{
		return default(KGDNDLAGOFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA360", Offset = "0x5AC8960", VA = "0x185ACA360")]
	public void EMGPAEHIDBG(out KGDNDLAGOFK FGDGNAAOGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5AC9C30", Offset = "0x5AC8230", VA = "0x185AC9C30")]
	public KGDNDLAGOFK DCMOBBMJPNK()
	{
		return default(KGDNDLAGOFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5AC9B10", Offset = "0x5AC8110", VA = "0x185AC9B10")]
	public void DCMOBBMJPNK(out KGDNDLAGOFK PEGFBFIMHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5ACC340", Offset = "0x5ACA940", VA = "0x185ACC340")]
	public Vector3 OAHOABOBPBG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5ACB0C0", Offset = "0x5AC96C0", VA = "0x185ACB0C0")]
	public void ILIJKDKJPLP(in Vector3 FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5ACB910", Offset = "0x5AC9F10", VA = "0x185ACB910")]
	public Vector3 LKDOCFGLPHD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5AC9FE0", Offset = "0x5AC85E0", VA = "0x185AC9FE0")]
	public void EHAJKHEEDHE(in Vector3 FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5ACB440", Offset = "0x5AC9A40", VA = "0x185ACB440")]
	public Quaternion JGJPBBIKKBL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5AC9640", Offset = "0x5AC7C40", VA = "0x185AC9640")]
	public void AKOHACCCCHD(in Quaternion FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA930", Offset = "0x5AC8F30", VA = "0x185ACA930")]
	public Quaternion HAALEHDPEPI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5ACC6E0", Offset = "0x5ACACE0", VA = "0x185ACC6E0")]
	public void OOHMKIBDPKM(in Quaternion FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA120", Offset = "0x5AC8720", VA = "0x185ACA120")]
	public float EHFFLGPPANK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA7B0", Offset = "0x5AC8DB0", VA = "0x185ACA7B0")]
	public void FGEFEILHDGE(float FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5ACB340", Offset = "0x5AC9940", VA = "0x185ACB340")]
	public float JAHKNMDMCBN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5ACB800", Offset = "0x5AC9E00", VA = "0x185ACB800")]
	public void LIFPPOFBDGC(float FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5ACAC20", Offset = "0x5AC9220", VA = "0x185ACAC20")]
	public void HGNGANAPEKM(in Vector3 FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5AC9D90", Offset = "0x5AC8390", VA = "0x185AC9D90")]
	public Vector3 DIDKECJICGJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA220", Offset = "0x5AC8820", VA = "0x185ACA220")]
	public void EIALPPJAGGF(in Vector3 FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x5ACBEC0", Offset = "0x5ACA4C0", VA = "0x185ACBEC0")]
	public Vector3 MKMLNHMPFPF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x5ACAD60", Offset = "0x5AC9360", VA = "0x185ACAD60")]
	public void HJGDKGBDHAG(in Vector3 FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x5ACC820", Offset = "0x5ACAE20", VA = "0x185ACC820")]
	public Vector3 PBBAEENJCOM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA4D0", Offset = "0x5AC8AD0", VA = "0x185ACA4D0")]
	public void EPKAGDMCECP(in Vector3 FEBHELIDNED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface MDMCNHEDDOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	BLGMLIKMCAK LDGNNMJJEKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ObjectType FIHCDMAJGBN(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ObjectPrefabType GJOHKNGLMAI(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BLMBLLKPLEN(JLPKHKEHPHF FJAJFKMDLKL, DIEOBLMALKE OIJEFGKAECP);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CBELJALGPAD ENCJPIPPPGP(AIEJIADOHAF EHPNFPDFJDJ, [Optional] object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KBIAODGDPHL(AIEJIADOHAF EHPNFPDFJDJ, out DIEOBLMALKE OIJEFGKAECP);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CFHDMOMEOLG(DIEOBLMALKE OIJEFGKAECP);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HNJMAPCHIDN(AIEJIADOHAF EHPNFPDFJDJ, out Transform IEIHNIMHKCE);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PFAEDBNEHJG(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OGBDFNJMJEG(LocalId EHPNFPDFJDJ, object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LNOKELEGEMD(LocalId EHPNFPDFJDJ, object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	AIEJIADOHAF JHBDMGFKDOC(JLPKHKEHPHF FJAJFKMDLKL);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	JLPKHKEHPHF MHFOFECMKGN(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LBINFBCBAJB JHBDMGFKDOC(NativeArray<JLPKHKEHPHF> FJAJFKMDLKL, Allocator HDOCJKNPNPA);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	LBINFBCBAJB BGFEANKBMHG(NativeArray<JLPKHKEHPHF> FJAJFKMDLKL, NativeArray<FFPIFKPNGLN> ODFBJMLEBHD, Allocator HDOCJKNPNPA);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CBELJALGPAD HJDDELBIEBF(ObjectPrefabType INKNLFCIIAC, bool GECMPFDBOMA);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	CBELJALGPAD HJDDELBIEBF(ObjectPrefabType INKNLFCIIAC);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	CBELJALGPAD OPHLAFLKENG(ObjectPrefabType INKNLFCIIAC);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	CBELJALGPAD BGFEANKBMHG(JLPKHKEHPHF FJAJFKMDLKL, ObjectPrefabType INKNLFCIIAC);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "19")]
	CJGHEGNPGGH IHDJCEPLKPO();

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "20")]
	BMEGNONALPO MLBFOGOBGJO();

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "21")]
	LLFGAGOKFIA OAMLNCDAFOC(PrimitiveShapeType KGAILFDFMNI);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JGMGKPAOHON(LBINFBCBAJB IFENDBDPCHC);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void LFGPNIBMGLP(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MGOFDLEFAEC(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void JGMGKPAOHON(AIEJIADOHAF EHPNFPDFJDJ);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "26")]
	LBINFBCBAJB NHBBNFDODPI(LBINFBCBAJB GNOONHCPGBK, Allocator HDOCJKNPNPA);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool PFAIEHOFDHF(AIEJIADOHAF EHPNFPDFJDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class MHGNDHBCECM
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7670", Offset = "0x5AD5C70", VA = "0x185AD7670")]
	public static CBELJALGPAD DDGKNCECJLF(this MDMCNHEDDOJ HIHBENBCOLF, LocalId EHPNFPDFJDJ)
	{
		return default(CBELJALGPAD);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7720", Offset = "0x5AD5D20", VA = "0x185AD7720")]
	public static AIEJIADOHAF JHBDMGFKDOC(this MDMCNHEDDOJ HIHBENBCOLF, LocalId EHPNFPDFJDJ)
	{
		return default(AIEJIADOHAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5AD79E0", Offset = "0x5AD5FE0", VA = "0x185AD79E0")]
	public static JLPKHKEHPHF MHFOFECMKGN(this MDMCNHEDDOJ HIHBENBCOLF, LocalId EHPNFPDFJDJ)
	{
		return default(JLPKHKEHPHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7B00", Offset = "0x5AD6100", VA = "0x185AD7B00")]
	public static bool PFAIEHOFDHF(this MDMCNHEDDOJ HIHBENBCOLF, JLPKHKEHPHF FJAJFKMDLKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x177BC80", Offset = "0x177A280", VA = "0x18177BC80")]
	public static T EELDDJLLIIM<T>(this MDMCNHEDDOJ HIHBENBCOLF, LocalId EHPNFPDFJDJ) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7400", Offset = "0x5AD5A00", VA = "0x185AD7400")]
	public static CJGHEGNPGGH ADAFFHMPKNP(this MDMCNHEDDOJ HIHBENBCOLF, RigidTransform FGDGNAAOGCE, [Optional] object LODBJLOKBLP)
	{
		return default(CJGHEGNPGGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7890", Offset = "0x5AD5E90", VA = "0x185AD7890")]
	public static LLFGAGOKFIA KEKNHGFGJEL(this MDMCNHEDDOJ HIHBENBCOLF, PrimitiveShapeType EFODIILEDPK, RigidTransform FGDGNAAOGCE, [Optional] object LODBJLOKBLP)
	{
		return default(LLFGAGOKFIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7740", Offset = "0x5AD5D40", VA = "0x185AD7740")]
	public static BMEGNONALPO JMHNOJBFNMG(this MDMCNHEDDOJ HIHBENBCOLF, RigidTransform FGDGNAAOGCE, [Optional] object LODBJLOKBLP)
	{
		return default(BMEGNONALPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7550", Offset = "0x5AD5B50", VA = "0x185AD7550")]
	private static void CPMNODIHKDM(CBELJALGPAD BMEDLOCLPJG, RigidTransform FGDGNAAOGCE, [Optional] object LODBJLOKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7C50", Offset = "0x5AD6250", VA = "0x185AD7C50")]
	internal static EMPIPIJOHPF PIKDAGHPEFL(this MDMCNHEDDOJ HIHBENBCOLF, NLLGCLNFGJN AJBKCOAABPJ, [Optional] object LODBJLOKBLP)
	{
		return default(EMPIPIJOHPF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal static class LGEHPMFBJJD
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5AD6610", Offset = "0x5AD4C10", VA = "0x185AD6610")]
	public static GOIGDNBBPCE OIEFMCLOMBH(this AIEJIADOHAF LNHACNHDILG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x5AD6560", Offset = "0x5AD4B60", VA = "0x185AD6560")]
	public static EntityManager IKKIOEAOHBF(this AIEJIADOHAF LNHACNHDILG)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x2311B30", Offset = "0x2310130", VA = "0x182311B30")]
	public static T MCHBAPBDDIO<T>(this AIEJIADOHAF LNHACNHDILG) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x2311AC0", Offset = "0x23100C0", VA = "0x182311AC0")]
	public static bool HMCKOHJIMFJ<T>(this AIEJIADOHAF LNHACNHDILG) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
internal interface BJDNGAKILOM
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event EHKILPFAOPG.ONDLKLENHMA EPCPHIBJAII;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[KAEAKLGOHIG(GMBNIBPKKJK.LoadInstance)]
public interface OHGMLGFAHCB
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	bool PIGGHAGNLKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	AIEJIADOHAF IAPMLODGDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	CBELJALGPAD AMKBEFBLNLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	CBELJALGPAD PDCPLJNJCDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event GMDOOEGHKND EJHADIAHMFF;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AIEJIADOHAF AHEBLLIPEFK(AIEJIADOHAF DKAMNPKDEFD, AIEJIADOHAF BCEEACEDILA);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GGDKOLIMOAB(AIEJIADOHAF DKAMNPKDEFD, AIEJIADOHAF BCEEACEDILA, out AIEJIADOHAF KNIBHOMLKHF);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OOICNFNMNLG();

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FKHCNFHMICE();

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NPDDKOIECIN(AIEJIADOHAF DPNGJGBLPFN);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public delegate void GMDOOEGHKND(CBELJALGPAD HACKBNFHIAB, CBELJALGPAD JCHIPKCIAJN);
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class MAAKPAJLBCN
{
	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5AD6EE0", Offset = "0x5AD54E0", VA = "0x185AD6EE0")]
	public static bool DPAKHPAJOIO(this OHGMLGFAHCB EJEJJPPLPNN, CBELJALGPAD DPNGJGBLPFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5AD6F70", Offset = "0x5AD5570", VA = "0x185AD6F70")]
	public static bool IBOEKENLHBA(this OHGMLGFAHCB EJEJJPPLPNN, AIEJIADOHAF DPNGJGBLPFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7310", Offset = "0x5AD5910", VA = "0x185AD7310")]
	public static bool OKPLPIPBFON(this OHGMLGFAHCB EJEJJPPLPNN, AIEJIADOHAF DPNGJGBLPFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[DefaultMember("Item")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface MKHKFDLGAOI : IEnumerable<EJJAPLIMLCB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	EJJAPLIMLCB KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EJJAPLIMLCB INBDFKHIIHK(CLLJMNNCKMG LDLHPBNHANP);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DMCAMPNBLKJ JFELANGNBDJ(CLLJMNNCKMG LDLHPBNHANP);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class EJMKECBLJIL
{
	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x295ADC0", Offset = "0x29593C0", VA = "0x18295ADC0")]
	public static BLLIPOGFPLJ<T> INBDFKHIIHK<T>(this MKHKFDLGAOI GOMAHIOPLHH, CLLJMNNCKMG HNPIEGONNBC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x295AEE0", Offset = "0x29594E0", VA = "0x18295AEE0")]
	public static BLLIPOGFPLJ<T> INBDFKHIIHK<T>(this MKHKFDLGAOI GOMAHIOPLHH, JGHGJDHNFBJ<T> HNPIEGONNBC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x295B030", Offset = "0x2959630", VA = "0x18295B030")]
	public static DMCAMPNBLKJ JFELANGNBDJ<T>(this MKHKFDLGAOI GOMAHIOPLHH, JGHGJDHNFBJ<T> HNPIEGONNBC) where T : struct
	{
		return default(DMCAMPNBLKJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface LHKEMGACBDF : IDDAEIFJOAJ
{
	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GECCGDGCHBH ODJMFBFGJNN(Entity PEKCJMKIHGK);

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILECILCDAHJ(NativeArray<GECCGDGCHBH> AHINOIINAKL, NativeArray<OLIPPODKLOF> DIHAGLJEBCB);

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FMENFPHONOG(GECCGDGCHBH GMLKHLPDINM);

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FNLIMABEJCH(GECCGDGCHBH GMLKHLPDINM, out Collider OHNLBFFNOJG);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct OLIPPODKLOF : ISystemStateComponentData, IComponentData, IEquatable<OLIPPODKLOF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float3 EBCHOCBMHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 LAKPEJPJAIH;

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x5AD9B30", Offset = "0x5AD8130", VA = "0x185AD9B30", Slot = "4")]
	public bool Equals(OLIPPODKLOF EJECOGCICOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct OOMENMIPJFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Guid IKGPBILBBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public string HCOMHOGEGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Vector3 FADCMIMHMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Quaternion HOHKOHLHECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Vector3 KPABHDDPFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public int MBFGIIMNPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Dictionary<string, object> CCDJMIJMJKG;

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x5ADA500", Offset = "0x5AD8B00", VA = "0x185ADA500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x5ADA370", Offset = "0x5AD8970", VA = "0x185ADA370")]
	private static string KDNCCJOJJDB(Dictionary<string, object> ECEEIOKBPPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public enum HFAIEBKBACD
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public enum JGGFGHBOPMM
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class JBFHIDHAPEI
{
	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x3F5DB30", Offset = "0x3F5C130", VA = "0x183F5DB30")]
	public static bool BELCHMLKJFC(this JGGFGHBOPMM LFBJHCMDIAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public interface MNKKENBHJHP : AAJLOOHEGIL, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[Flags]
public enum IOEFPNFELCP
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	NotifyEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	PreInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	BulkInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	PostInstantiate = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	NotifyInstantiated = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DisposeProtobuf = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	NotifyCompleted = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	WorldPhasesMaster = 0xFF,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	WorldPhasesClient = 0xF7,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	AdditivePhases = 0xFF
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[Flags]
public enum JPOGOPPAKHH
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	SetEnabledInRoom = 2,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	PreInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	BulkInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	PostInstantiate = 0x30,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	LoadCompleted = 0xC0,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	All = 0xFF
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface JFOMIOOEKFH : AAJLOOHEGIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	ENKAENLLILN KFMHLBLJIJH
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INHJMLKPHDN();

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LGOHOCDHPMK();
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public interface ENKAENLLILN
{
	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DEIHEJNLNNF(Guid FDDHIMHLJAI, out Guid PBFCNGOCEEJ);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface OINAJNHIOBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	GHGJHFHPJIP CHGIGOMJLEP
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString IGKBCNFEIBJ();
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface AAJLOOHEGIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	IEnumerable<OOMENMIPJFG> DOFJNOMJNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	HCNEPPCPGJG PMBNLGIILHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	LocalId HKFDCNKJEEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	GHGJHFHPJIP KFEPMOIINFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	Task CBMCAKCBPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool INMPCLDOECM(IOEFPNFELCP MPHKDHOHMJI);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface HLPJPCKONEF
{
	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPPOCHAFELI(JLPKHKEHPHF AACAAADHPAN, DMCAMPNBLKJ GMFCGGOOKOG, ReadOnlySpan<byte> OOGICJNMABM, ReadOnlySpan<byte> PJEKJMNEHAP);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PJMFGLHBMIM(JLPKHKEHPHF AACAAADHPAN, DMCAMPNBLKJ GMFCGGOOKOG);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JLPGNONLOPF(JLPKHKEHPHF AACAAADHPAN, DMCAMPNBLKJ GMFCGGOOKOG, ReadOnlySpan<byte> PJEKJMNEHAP);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HIMGHKPEKAN(JLPKHKEHPHF AACAAADHPAN, DMCAMPNBLKJ GMFCGGOOKOG, Span<byte> OOGICJNMABM, Span<byte> PJEKJMNEHAP);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class CBDHNCAGINC
{
	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x169E670", Offset = "0x169CC70", VA = "0x18169E670")]
	public static bool HIMGHKPEKAN<T>(this HLPJPCKONEF JPNLEPFJGFD, JLPKHKEHPHF AACAAADHPAN, DMCAMPNBLKJ GMFCGGOOKOG, out T OOGICJNMABM, out T PJEKJMNEHAP) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x169E830", Offset = "0x169CE30", VA = "0x18169E830")]
	public static bool JLPGNONLOPF<T>(this HLPJPCKONEF JPNLEPFJGFD, JLPKHKEHPHF AACAAADHPAN, DMCAMPNBLKJ GMFCGGOOKOG, T PJEKJMNEHAP) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public enum IGFAHLINFMA
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	End,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface BPCDFDLOGEP : BMLKOINMPLB<BPCDFDLOGEP>
{
	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DMCAMPNBLKJ JFELANGNBDJ(CLLJMNNCKMG HNPIEGONNBC);

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BLMBLLKPLEN(DMCAMPNBLKJ LNHACNHDILG, BFLADCOMPJB NLJODBPDNBN);

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HNEMDLLFNLP(DMCAMPNBLKJ LNHACNHDILG, out BFLADCOMPJB NLJODBPDNBN);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class HEEINMFBBDP
{
	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x2AD3D70", Offset = "0x2AD2370", VA = "0x182AD3D70")]
	public static DMCAMPNBLKJ JFELANGNBDJ<T>(this BPCDFDLOGEP GOMAHIOPLHH, JGHGJDHNFBJ<T> HNPIEGONNBC)
	{
		return default(DMCAMPNBLKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	public static DMCAMPNBLKJ BLMBLLKPLEN<T>(this BPCDFDLOGEP GOMAHIOPLHH, JGHGJDHNFBJ<T> HNPIEGONNBC, BFLADCOMPJB NLJODBPDNBN) where T : struct
	{
		return default(DMCAMPNBLKJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface BBDMGICIAOL
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	uint KMGKNDFEMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct MCDNNOJPBEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public AIIEPMOJEPO BDIPIDIIILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public ReadOnlyMemory<byte> OGLJJNFALNA;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface GHCHGNGDPNN
{
	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BICMHFGOAMN(AIIEPMOJEPO BDIPIDIIILI, ReadOnlySpan<byte> OGLJJNFALNA);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public delegate bool OMCDBCNPNCE(HLPJPCKONEF JNHMAGLDMKP, in IGCFDMLBPPM FEBHELIDNED);
[Cpp2IlInjected.Token(Token = "0x2000096")]
public delegate bool FKGIHIDPDEF<T>(HLPJPCKONEF JNHMAGLDMKP, in T FEBHELIDNED);
[Cpp2IlInjected.Token(Token = "0x2000097")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface IOKANCINJJI
{
	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLMBLLKPLEN(DMCAMPNBLKJ GMFCGGOOKOG, Type MMKMNPJMPKF, OMCDBCNPNCE GKNBAANLABE);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GNLBMEDJNDA(DMCAMPNBLKJ GMFCGGOOKOG, out OMCDBCNPNCE GKNBAANLABE);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class LCIMHGLBAHC
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class EMHEBIMNMOL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public FKGIHIDPDEF<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public EMHEBIMNMOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x121DED0", Offset = "0x121C4D0", VA = "0x18121DED0")]
		internal bool ILLIGBJFADK(HLPJPCKONEF pendingList, in IGCFDMLBPPM value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2306190", Offset = "0x2304790", VA = "0x182306190")]
	public static void BLMBLLKPLEN<T>(this IOKANCINJJI LNGEDFDIBDI, DMCAMPNBLKJ GMFCGGOOKOG, FKGIHIDPDEF<T> GKNBAANLABE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD61C0", Offset = "0x5AD47C0", VA = "0x185AD61C0")]
	public static bool BBIJIOKEMLP(this IOKANCINJJI LNGEDFDIBDI, HLPJPCKONEF JNHMAGLDMKP, DMCAMPNBLKJ GMFCGGOOKOG, in IGCFDMLBPPM FEBHELIDNED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct AIIEPMOJEPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public uint OIJHKJJKMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int JJJMIAJNLMG;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0xA2D850", Offset = "0xA2BE50", VA = "0x180A2D850")]
	public AIIEPMOJEPO(uint OIJHKJJKMIK, int JJJMIAJNLMG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD1E0", Offset = "0x5ACB7E0", VA = "0x185ACD1E0")]
	public static bool MOJFGPLDDKP(in AIIEPMOJEPO NNCBKOEDDGO, in AIIEPMOJEPO IHJFFGMGNME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD120", Offset = "0x5ACB720", VA = "0x185ACD120", Slot = "0")]
	public override bool Equals(object IAMEECMGPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD1B0", Offset = "0x5ACB7B0", VA = "0x185ACD1B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD200", Offset = "0x5ACB800", VA = "0x185ACD200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface KBADDPOHPGA
{
	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AIIEPMOJEPO EHEPDFBHGKF(ReadOnlySpan<byte> OGLJJNFALNA);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public interface BFLADCOMPJB
{
	[Cpp2IlInjected.Token(Token = "0x17000135")]
	Type FMACPCMLJEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMHFJGFFMPB(ref GIGHIDGOGIA PDNINNPJLDN, Span<byte> DPNGJGBLPFN);

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DHDFEGACAHE(ref PMFHDCBANDG NKODOJNBMFJ, ReadOnlySpan<byte> BDIPIDIIILI);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class CEDCAGMLLBP
{
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public delegate void IOJGGHDOIDG(AIIEPMOJEPO NAJDAPHOGEH, ReadOnlySpan<byte> OGLJJNFALNA);
[Cpp2IlInjected.Token(Token = "0x200009F")]
[KAEAKLGOHIG(GMBNIBPKKJK.OMRoom)]
public interface EPLPOJEDJFL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPAKNCEEDMO(AIIEPMOJEPO NAJDAPHOGEH, ReadOnlySpan<byte> OGLJJNFALNA);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
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
