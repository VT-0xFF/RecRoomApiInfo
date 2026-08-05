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
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
public interface PPDAOGDLOGH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KIDFNNNCEHA(in float3 IOOCLPLPHGP, in float3 DKILHHENEBB, float GMDPDEIGPMK, Allocator IEOPKOGNAGJ, out NativeArray<Entity> KPALEEBPIBN);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[ANLCMDHKMHN(GPIAMNEIDDC.Application)]
public interface EBGGPAEGCCO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Guid AGKJCBCHPBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPECMFDMFAK(Guid CFPACOPFCAN, Guid FJPNPMENKOG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KICFCIHAFMP(NGBBJMBOBME CMPOMIMIJEC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface IBGGDEIKCDF : HEIHDOIHLCP<NGBBJMBOBME>, JKEGKIMHFBI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HJDPKHDBJJM<T> : LDGDMCJHABE<NGBBJMBOBME, T>, HEIHDOIHLCP<NGBBJMBOBME>, JKEGKIMHFBI, IDisposable, IBGGDEIKCDF where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JCGNHPDGAGB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x298C700", Offset = "0x298B900", VA = "0x18298C700")]
	public static T MEINKDCJHDP<T>(this HEIHDOIHLCP<NGBBJMBOBME> CKAKOJLMGFA, NGBBJMBOBME LDDMDOBAIIL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x298C6D0", Offset = "0x298B8D0", VA = "0x18298C6D0")]
	public static bool EBIKLMMGLOI<T>(this HEIHDOIHLCP<NGBBJMBOBME> CKAKOJLMGFA, NGBBJMBOBME LDDMDOBAIIL, in T GFFDBEMENLA) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
public interface OIINAIEDAKP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Func<GBKNCDNCKOC> JGDMGNBOKKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<NGBBJMBOBME, NGBBJMBOBME> PEKEPBLHJJC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<NGBBJMBOBME, NGBBJMBOBME> FBMIGGDOENO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<NGBBJMBOBME, NGBBJMBOBME, NGBBJMBOBME> JFHKNALMJHJ;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<NGBBJMBOBME> CHDIKGCEBHL;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color OHAJPMFKEFL(NGBBJMBOBME LDDMDOBAIIL, int LPMDMLEGBJO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float3 EEAONECLNPF(NGBBJMBOBME LDDMDOBAIIL, int LPMDMLEGBJO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool EGFBACHGJMF(NGBBJMBOBME LDDMDOBAIIL, NGBBJMBOBME JJGPOPCIOOD);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NGBBJMBOBME EHONGKMODPK(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<NGBBJMBOBME> OEMFJEFOAEM(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "15")]
	NGBBJMBOBME CJPEOAOJHBP(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AHHKBJLJGLC(NGBBJMBOBME LDDMDOBAIIL, Vector3 LOAMFHIENOO, Quaternion LOLMBPOHNDB);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EEEBFPGMAME(NGBBJMBOBME LDDMDOBAIIL, float JGDPIMBHEIE);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool LNDJKIHCJBG(NGBBJMBOBME LDDMDOBAIIL, out RigidTransform JGFCEMHOAOL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool LHCDHBLEKBO(NGBBJMBOBME LDDMDOBAIIL, out float EPJKHLABEAC);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 DMENKONGLHC(IPBAAANCNOI PJOADOBDDBI);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	quaternion JJPAHMEHGLH(IPBAAANCNOI PJOADOBDDBI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CHINIIDBJAF
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
public interface PAIHAEEFGLH
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIDFNNNCEHA(in NativeArray<Entity> KPALEEBPIBN, in float3 IOOCLPLPHGP, in float3 DKILHHENEBB, in NativeArray<OAMAJKNKBPJ> HEGGHAJPCGL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
public interface KPINHOOOKEA
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGHBIKLOBON(NGBBJMBOBME IHKJNNPMCLD, bool ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBAFBEBFNGP(NGBBJMBOBME IHKJNNPMCLD, bool ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBBJEFFDPOG(NGBBJMBOBME IHKJNNPMCLD, int ACKOJNNBEBO);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
[DefaultMember("Item")]
public interface DJHGCLJICHD : IEnumerable<HBGGGACDKNF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	NativeBitArray NGFLOBFOKEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NativeArray<int> NLBKGCLAGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	HBGGGACDKNF LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	HBGGGACDKNF LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HBGGGACDKNF AIEJPNBDMBP(GFNBJKOODOI LPBMDNNGIOI);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NGGANMPEPOM AHFDFLNGHDK(GFNBJKOODOI LPBMDNNGIOI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GJPGDGMHCHI
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public static KMAEHNPNKPE<T> AIEJPNBDMBP<T>(this DJHGCLJICHD MDEOLPGKLLA, GFNBJKOODOI PCKMHBLNCII) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct ALLOPGNJLIH : IEquatable<ALLOPGNJLIH>
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly ALLOPGNJLIH CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	public ALLOPGNJLIH(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D7A1F0", Offset = "0x5D793F0", VA = "0x185D7A1F0", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(ALLOPGNJLIH HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct AHBBMLOCHOH : IEquatable<AHBBMLOCHOH>
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly AHBBMLOCHOH CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5D79230", Offset = "0x5D78430", VA = "0x185D79230", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(AHBBMLOCHOH HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface BOAPDEPOCID
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EAKOCLLCKMH DHJOHHADHMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PJGOODONNEA(HEGAMEGFABK ODDHIKCHJNG, NGGANMPEPOM CKAKOJLMGFA);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJMAIHODEPD(HEGAMEGFABK ODDHIKCHJNG, Span<NGGANMPEPOM> MDEOLPGKLLA, bool EKHIOIPCNFD);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJFOBINMNOH(NativeArray<HEGAMEGFABK> FFOAOJFLAHG);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct EAKOCLLCKMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NativeBitArray LDPCCCJLJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly NativeHashMap<HEGAMEGFABK, int> MJIAKNLLKFB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool LBLKPCPKJAD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5D7D710", Offset = "0x5D7C910", VA = "0x185D7D710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x86FD00", Offset = "0x86EF00", VA = "0x18086FD00")]
	public EAKOCLLCKMH(NativeBitArray LDPCCCJLJBP, NativeHashMap<HEGAMEGFABK, int> MJIAKNLLKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D730", Offset = "0x5D7C930", VA = "0x185D7D730")]
	public bool PJGOODONNEA(HEGAMEGFABK ODDHIKCHJNG, NGGANMPEPOM CKAKOJLMGFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EOOFPNIKCMD
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct AKCLBFIHGBC : KEHELDOGIHI, IEquatable<AKCLBFIHGBC>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly AKCLBFIHGBC CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GameObject JBOGCBPFIGA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5D79830", Offset = "0x5D78A30", VA = "0x185D79830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public HEGAMEGFABK BBEMPLPCAMC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5D79FE0", Offset = "0x5D791E0", VA = "0x185D79FE0")]
		get
		{
			return default(HEGAMEGFABK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ObjectType IPNKKDFLMDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5D79E20", Offset = "0x5D79020", VA = "0x185D79E20")]
		get
		{
			return default(ObjectType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ObjectPrefabType EOEAKKLGEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5D79D60", Offset = "0x5D78F60", VA = "0x185D79D60")]
		get
		{
			return default(ObjectPrefabType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool LEGCMLNHHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5D797F0", Offset = "0x5D789F0", VA = "0x185D797F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool HJAFHDGHAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5D79B60", Offset = "0x5D78D60", VA = "0x185D79B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool HBJMCHACDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5D79600", Offset = "0x5D78800", VA = "0x185D79600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool GPPOCPHBFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5D79420", Offset = "0x5D78620", VA = "0x185D79420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool NMEAENEIHIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5D79810", Offset = "0x5D78A10", VA = "0x185D79810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool BPMHCDJMEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5D79B80", Offset = "0x5D78D80", VA = "0x185D79B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool KNBOJAEJOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5D793D0", Offset = "0x5D785D0", VA = "0x185D793D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool CGBOPMKDDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5D799E0", Offset = "0x5D78BE0", VA = "0x185D799E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public LIIMIPLCIFC HABMLNJKAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(LIIMIPLCIFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public NGNPJOLPODN INMFHCNJBEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(NGNPJOLPODN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public KCPKEBCIEGB EFBEDLBPAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(KCPKEBCIEGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public KGGOMFBPBDG LIJPCEDLJAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(KGGOMFBPBDG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public DGNDKJBMNKA NLPLAFHKJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(DGNDKJBMNKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public JDHBMHNEIFC MKLCEHPIIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(JDHBMHNEIFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public EOBLGEOIKNL AIOPPJBNNJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(EOBLGEOIKNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool KBEBBDFMBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5D79620", Offset = "0x5D78820", VA = "0x185D79620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool AOGIKILIHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5D794B0", Offset = "0x5D786B0", VA = "0x185D794B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private bool IFNFCFKBANM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x844770", Offset = "0x843970", VA = "0x180844770", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public NGBBJMBOBME NKGMBOABFNH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1127750", Offset = "0x1126950", VA = "0x181127750", Slot = "5")]
		get
		{
			return default(NGBBJMBOBME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public OGPKIFMHBPM CMDBMJDLKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(OGPKIFMHBPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public GJPBPPPJKBH CNLJLEIOHON
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(GJPBPPPJKBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private CEAGEKAKLML LMFGPDLCEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B50", Offset = "0x8D5D50", VA = "0x1808D6B50")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
	public static AKCLBFIHGBC MDCOPBLGMCP(NGBBJMBOBME IHKJNNPMCLD)
	{
		return default(AKCLBFIHGBC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5D79F50", Offset = "0x5D79150", VA = "0x185D79F50")]
	public BGEGFFMEOEA OJIDLPGAGIK()
	{
		return default(BGEGFFMEOEA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5D79590", Offset = "0x5D78790", VA = "0x185D79590")]
	public NEKLHFPGMAI DIBALDNENCL()
	{
		return default(NEKLHFPGMAI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5D79440", Offset = "0x5D78640", VA = "0x185D79440")]
	public ALLOPGNJLIH BOBOCLPBKJN()
	{
		return default(ALLOPGNJLIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5D79EE0", Offset = "0x5D790E0", VA = "0x185D79EE0")]
	public NAACDNGEKOG OHMHNNMLNGJ()
	{
		return default(NAACDNGEKOG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5D79500", Offset = "0x5D78700", VA = "0x185D79500")]
	public IPBAAANCNOI DAIOLIFBEJL()
	{
		return default(IPBAAANCNOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5D79C80", Offset = "0x5D78E80", VA = "0x185D79C80")]
	public void NPJDBGAGMPP([Optional] object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5D79930", Offset = "0x5D78B30", VA = "0x185D79930")]
	public bool HHFEKKMKIFL(object IBIKCCMDMHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D79AA0", Offset = "0x5D78CA0", VA = "0x185D79AA0")]
	public bool KMBHFDHHCEG(object IBIKCCMDMHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D7A0A0", Offset = "0x5D792A0", VA = "0x185D7A0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	public AKCLBFIHGBC(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5D79B50", Offset = "0x5D78D50", VA = "0x185D79B50")]
	public static bool MDCOPBLGMCP(AKCLBFIHGBC ACKOJNNBEBO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1127750", Offset = "0x1126950", VA = "0x181127750")]
	public static NGBBJMBOBME MDCOPBLGMCP(AKCLBFIHGBC ACKOJNNBEBO)
	{
		return default(NGBBJMBOBME);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5D79A00", Offset = "0x5D78C00", VA = "0x185D79A00")]
	public static bool JGKKLLGINAK(AKCLBFIHGBC KCJELMMMDCA, AKCLBFIHGBC NMKMEIDKGEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5D79BA0", Offset = "0x5D78DA0", VA = "0x185D79BA0")]
	public static bool NGNNEMMJMMJ(AKCLBFIHGBC KCJELMMMDCA, AKCLBFIHGBC NMKMEIDKGEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D796F0", Offset = "0x5D788F0", VA = "0x185D796F0", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "6")]
	public bool Equals(AKCLBFIHGBC HPOECFLNEOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate void BGAOAOPMLDL(NGBBJMBOBME LDDMDOBAIIL, NGGANMPEPOM FNPJNJDJLAF, GMFPPNNBHJB EHCPBLKKGBB, GMFPPNNBHJB LNFLJFBBBCC);
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public struct HDELNHBJDAF : IList<NGBBJMBOBME>, ICollection<NGBBJMBOBME>, IEnumerable<NGBBJMBOBME>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct FJALMFNJDPP : IEnumerator<NGBBJMBOBME>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly CEAGEKAKLML EBMPGEPOMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private NativeArray<LocalId>.Enumerator DGEHLDDPFAK;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public NGBBJMBOBME HMPLADJAFAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5D7EE80", Offset = "0x5D7E080", VA = "0x185D7EE80", Slot = "4")]
			get
			{
				return default(NGBBJMBOBME);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5D7EDA0", Offset = "0x5D7DFA0", VA = "0x185D7EDA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x25CFDF0", Offset = "0x25CEFF0", VA = "0x1825CFDF0")]
		public FJALMFNJDPP(CEAGEKAKLML EBMPGEPOMDE, NativeArray<LocalId>.Enumerator DGEHLDDPFAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5D7ECE0", Offset = "0x5D7DEE0", VA = "0x185D7ECE0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5D7ED20", Offset = "0x5D7DF20", VA = "0x185D7ED20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5D7ED60", Offset = "0x5D7DF60", VA = "0x185D7ED60", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CEAGEKAKLML EBMPGEPOMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private NativeList<LocalId> JILMJAIGHMF;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public NGBBJMBOBME LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5D80910", Offset = "0x5D7FB10", VA = "0x185D80910", Slot = "4")]
		get
		{
			return default(NGBBJMBOBME);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5D80990", Offset = "0x5D7FB90", VA = "0x185D80990", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5D80390", Offset = "0x5D7F590", VA = "0x185D80390", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int CGOAKPGGPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5D80390", Offset = "0x5D7F590", VA = "0x185D80390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool NPDFLFDHFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5D80880", Offset = "0x5D7FA80", VA = "0x185D80880")]
	public HDELNHBJDAF(CEAGEKAKLML EBMPGEPOMDE, int CGGOJFONIPE, Allocator IEOPKOGNAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D804B0", Offset = "0x5D7F6B0", VA = "0x185D804B0")]
	public FNPNPGNLNBE JBEMOCLBHLC()
	{
		return default(FNPNPGNLNBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5D800E0", Offset = "0x5D7F2E0", VA = "0x185D800E0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5D80120", Offset = "0x5D7F320", VA = "0x185D80120", Slot = "13")]
	public bool Contains(NGBBJMBOBME FNPJDMFCFGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5D80180", Offset = "0x5D7F380", VA = "0x185D80180", Slot = "14")]
	public void CopyTo(NGBBJMBOBME[] BGBPILICHHA, int AAOCMLFBPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5D80080", Offset = "0x5D7F280", VA = "0x185D80080", Slot = "11")]
	public void Add(NGBBJMBOBME FNPJDMFCFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5D80430", Offset = "0x5D7F630", VA = "0x185D80430", Slot = "7")]
	public void Insert(int MMFFFGBLCAP, NGBBJMBOBME FNPJDMFCFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5D80610", Offset = "0x5D7F810", VA = "0x185D80610", Slot = "15")]
	public bool Remove(NGBBJMBOBME FNPJDMFCFGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5D803D0", Offset = "0x5D7F5D0", VA = "0x185D803D0", Slot = "6")]
	public int IndexOf(NGBBJMBOBME FNPJDMFCFGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5D805C0", Offset = "0x5D7F7C0", VA = "0x185D805C0", Slot = "8")]
	public void RemoveAt(int MMFFFGBLCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5D80350", Offset = "0x5D7F550", VA = "0x185D80350", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5D80530", Offset = "0x5D7F730", VA = "0x185D80530")]
	public FJALMFNJDPP KECFEFHENMC()
	{
		return default(FJALMFNJDPP);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D806A0", Offset = "0x5D7F8A0", VA = "0x185D806A0", Slot = "16")]
	private IEnumerator<NGBBJMBOBME> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5D80790", Offset = "0x5D7F990", VA = "0x185D80790", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
public interface IAFLLBAHGJH
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KIDFNNNCEHA(in float3 IOOCLPLPHGP, in float3 DKILHHENEBB, float GMDPDEIGPMK, out OAMAJKNKBPJ EABGHNJACOI, out NGBBJMBOBME MHOMGIBIJCO);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public readonly struct BHCPGPGNHFI : IEquatable<BHCPGPGNHFI>
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly BHCPGPGNHFI CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private HAGGNNONGHI HFLIBEOCDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5D7B7F0", Offset = "0x5D7A9F0", VA = "0x185D7B7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public NEKLHFPGMAI HAMBCECDANL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(NEKLHFPGMAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public BHNEBIKGAFE ENMCFPGIBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5D7C460", Offset = "0x5D7B660", VA = "0x185D7C460")]
		get
		{
			return default(BHNEBIKGAFE);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5D7BF40", Offset = "0x5D7B140", VA = "0x185D7BF40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IEnumerable<JJKEIKKDKKP> LEDNBIGOBFK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5D7B950", Offset = "0x5D7AB50", VA = "0x185D7B950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public JJKEIKKDKKP LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5D7C340", Offset = "0x5D7B540", VA = "0x185D7C340")]
		get
		{
			return default(JJKEIKKDKKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5D7C550", Offset = "0x5D7B750", VA = "0x185D7C550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public NGBBJMBOBME NKGMBOABFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1127750", Offset = "0x1126950", VA = "0x181127750")]
		get
		{
			return default(NGBBJMBOBME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public OGPKIFMHBPM CMDBMJDLKGK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(OGPKIFMHBPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private CEAGEKAKLML LMFGPDLCEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B50", Offset = "0x8D5D50", VA = "0x1808D6B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private JLNDDAGKPPB LCKLJFKANOH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5D7BE50", Offset = "0x5D7B050", VA = "0x185D7BE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D7BC30", Offset = "0x5D7AE30", VA = "0x185D7BC30")]
	public JJKEIKKDKKP FGCAHGDIMFN(float3? FNDKHLEFPKD, [Optional] quaternion? AAECNILGNMA, [Optional] Vector3? DNJLOGOEKNP)
	{
		return default(JJKEIKKDKKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C110", Offset = "0x5D7B310", VA = "0x185D7C110")]
	public JJKEIKKDKKP MCHLPOMICIK(int MMFFFGBLCAP, float3? FNDKHLEFPKD, [Optional] quaternion? AAECNILGNMA, [Optional] Vector3? DNJLOGOEKNP)
	{
		return default(JJKEIKKDKKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C030", Offset = "0x5D7B230", VA = "0x185D7C030")]
	public void LIDGMIKDKFG(int MMFFFGBLCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5D7B870", Offset = "0x5D7AA70", VA = "0x185D7B870")]
	public void DAFFCKIEONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	public BHCPGPGNHFI(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5D79B50", Offset = "0x5D78D50", VA = "0x185D79B50")]
	public static bool MDCOPBLGMCP(BHCPGPGNHFI ACKOJNNBEBO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5D7BEA0", Offset = "0x5D7B0A0", VA = "0x185D7BEA0")]
	public static bool JGKKLLGINAK(BHCPGPGNHFI KCJELMMMDCA, BHCPGPGNHFI NMKMEIDKGEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5D7BB30", Offset = "0x5D7AD30", VA = "0x185D7BB30", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(BHCPGPGNHFI HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
public interface EJKMFCDDIDM
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FMPLFBAEGOD(NGBBJMBOBME LDDMDOBAIIL, out Collider JHGJKCLNOFL);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject PLGDHLLIEEJ(NGBBJMBOBME JFJMHJPKEIC, GameObject AHDDCNOKJEA, Vector3 PMKBAJECIHL, Quaternion KOMNMIFOANH);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EHFBOEJJGCM(GameObject JHGJKCLNOFL);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider LPIEMOIKCDP<TCollider>(GameObject AELIEDJJAKH) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BPAMMFALFPL(Collider JHGJKCLNOFL);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject KCCKFIJMPDD<TCollider>(string PCKMHBLNCII) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface EHIFJGCKECG : HEIHDOIHLCP<HEGAMEGFABK>, JKEGKIMHFBI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CONCGEIHFKE<T> : LDGDMCJHABE<HEGAMEGFABK, T>, HEIHDOIHLCP<HEGAMEGFABK>, JKEGKIMHFBI, IDisposable, EHIFJGCKECG where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class DNHLDOGHPDK
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2C0C090", Offset = "0x2C0B290", VA = "0x182C0C090")]
	public static bool IDJOIMMOOEO<T>(this HEIHDOIHLCP<HEGAMEGFABK> CKAKOJLMGFA, HEGAMEGFABK ODDHIKCHJNG, out T ACKOJNNBEBO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2C0C080", Offset = "0x2C0B280", VA = "0x182C0C080")]
	public static bool EBIKLMMGLOI<T>(this HEIHDOIHLCP<HEGAMEGFABK> CKAKOJLMGFA, HEGAMEGFABK ODDHIKCHJNG, in T GFFDBEMENLA) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct EOBLGEOIKNL : IEquatable<EOBLGEOIKNL>
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly EOBLGEOIKNL CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private BEDMHIIIBHJ LEHIBONBOBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5D7E0E0", Offset = "0x5D7D2E0", VA = "0x185D7E0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool GPDOOBHEBED
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5D7DF00", Offset = "0x5D7D100", VA = "0x185D7DF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Guid LHCGADNDINF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5D7DE10", Offset = "0x5D7D010", VA = "0x185D7DE10")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool GMGLOBHMAFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5D7DC50", Offset = "0x5D7CE50", VA = "0x185D7DC50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Guid OIDKNIGHLPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5D7DA70", Offset = "0x5D7CC70", VA = "0x185D7DA70")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NGBBJMBOBME NKGMBOABFNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1127750", Offset = "0x1126950", VA = "0x181127750")]
		get
		{
			return default(NGBBJMBOBME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private CEAGEKAKLML LMFGPDLCEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B50", Offset = "0x8D5D50", VA = "0x1808D6B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private JLNDDAGKPPB LCKLJFKANOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5D7E160", Offset = "0x5D7D360", VA = "0x185D7E160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E380", Offset = "0x5D7D580", VA = "0x185D7E380")]
	public bool NOKGHDFGDOP(out Guid DDEOLFGMHMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5D7DB60", Offset = "0x5D7CD60", VA = "0x185D7DB60")]
	public void BJIFODIDGCL(Guid HKPIHPOEJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5D7DD30", Offset = "0x5D7CF30", VA = "0x185D7DD30")]
	public bool DDIMIPKIMKO(out Guid ECDINGOLKBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E290", Offset = "0x5D7D490", VA = "0x185D7E290")]
	public void LPCIBDOECBD(Guid HKPIHPOEJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E1B0", Offset = "0x5D7D3B0", VA = "0x185D7E1B0")]
	public void KBAFOACEKMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	public EOBLGEOIKNL(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D7DFE0", Offset = "0x5D7D1E0", VA = "0x185D7DFE0", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(EOBLGEOIKNL HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct NGNPJOLPODN : IEquatable<NGNPJOLPODN>
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly NGNPJOLPODN CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private CEAGEKAKLML LMFGPDLCEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B50", Offset = "0x8D5D50", VA = "0x1808D6B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5D865D0", Offset = "0x5D857D0", VA = "0x185D865D0")]
	public void DEAHKEFKGBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5D867A0", Offset = "0x5D859A0", VA = "0x185D867A0")]
	public void NFKJPDBEMAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	public NGNPJOLPODN(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5D866A0", Offset = "0x5D858A0", VA = "0x185D866A0", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(NGNPJOLPODN HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface MGECINBKDNJ : KEHELDOGIHI
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	DDIAGBGICLK CCIIMGNFHJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool BOJDKPOELOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	GameObject JBOGCBPFIGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<MGECINBKDNJ> HDCKHNAPOIP;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(GOFOAABNBIC EIAHLMIGNAE, NGBBJMBOBME ALFCFGKLGLO);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool HKGFLCGOKNP);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class BKKDOPIEJOO
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C760", Offset = "0x5D7B960", VA = "0x185D7C760")]
	public static bool KBEBBDFMBKM(this MGECINBKDNJ FIAGHIPJJMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C7B0", Offset = "0x5D7B9B0", VA = "0x185D7C7B0")]
	public static bool NEJHJEGHOHD(this MGECINBKDNJ FIAGHIPJJMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C670", Offset = "0x5D7B870", VA = "0x185D7C670")]
	public static bool FDHIPEFHACI(this MGECINBKDNJ FIAGHIPJJMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C6C0", Offset = "0x5D7B8C0", VA = "0x185D7C6C0")]
	public static bool FKBOPHAPEKO(this MGECINBKDNJ FIAGHIPJJMD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct KAILAFKOIBK : IEquatable<KAILAFKOIBK>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly KAILAFKOIBK CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5D836E0", Offset = "0x5D828E0", VA = "0x185D836E0", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(KAILAFKOIBK HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
public interface MNEOHAODGBM
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFCGEBDAIGH(NativeListAsync<Entity> NMGOAKDJIAM);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPEALHABPCM(ECGAHJOJJAC KIEFPCNLDCO);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJBGJMONJIN(NativeListAsync<Entity> OAPDCIIGPLJ, bool GCGDOAMDCJJ);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MGCAEGLHIGK();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
public interface CJLGHFBHLKH
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IPGBLMHOHJJ(NGBBJMBOBME LDDMDOBAIIL, JBLKIPLPNJE ACKOJNNBEBO);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface FBHCGHCHHHE
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFIOFHOCEEL();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHKGDHAELHF();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJBJIKOFFHC();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NFDAGMFBIFJ();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DPKCDKHDLAN();

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GNAPAEBGNDO();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CCPEOFGNMFF();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KJNBEOBHBHJ();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DLIIFCNEFJP();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CLMOENKOHCB();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MPMDPBIMNLH();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface MBCPCHPHCAL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	int GNILEIMHCGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> EMIIHOOACGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NGBBJMBOBME BPEOJIFGFFD(NGBBJMBOBME JILMJAIGHMF);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BPEOJIFGFFD(int HIGJBFHIIJD);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface GAIJCLAGEMC : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct KGGOMFBPBDG : IEquatable<KGGOMFBPBDG>
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly KGGOMFBPBDG CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private AEAPKAOBELK NPJMOBOOLIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D84630", Offset = "0x5D83830", VA = "0x185D84630")]
		get
		{
			return default(AEAPKAOBELK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool GEKFKBOPAMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5D843B0", Offset = "0x5D835B0", VA = "0x185D843B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool MGBENHNEFHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D83A90", Offset = "0x5D82C90", VA = "0x185D83A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool HEGEHDHKLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5D84070", Offset = "0x5D83270", VA = "0x185D84070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool GBLMBIPDOGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5D84000", Offset = "0x5D83200", VA = "0x185D84000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool FBIBMNCOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5D83BF0", Offset = "0x5D82DF0", VA = "0x185D83BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool IIADDNAADLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D841B0", Offset = "0x5D833B0", VA = "0x185D841B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool HPHLFKFLPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D83F90", Offset = "0x5D83190", VA = "0x185D83F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool KDPFHOJKMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5D84420", Offset = "0x5D83620", VA = "0x185D84420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool CFKCMKHPNEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5D84690", Offset = "0x5D83890", VA = "0x185D84690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool KECENBAJLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5D83B80", Offset = "0x5D82D80", VA = "0x185D83B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool HAFCIOEEGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5D84340", Offset = "0x5D83540", VA = "0x185D84340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool HHOJOHFIHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5D84490", Offset = "0x5D83690", VA = "0x185D84490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool FKBDEOJGNOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5D83C60", Offset = "0x5D82E60", VA = "0x185D83C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool LNHPFKFABLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5D83F70", Offset = "0x5D83170", VA = "0x185D83F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool LMHDKHOPKPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5D84700", Offset = "0x5D83900", VA = "0x185D84700")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5D83F80", Offset = "0x5D83180", VA = "0x185D83F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool HJLAGIEFJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5D845C0", Offset = "0x5D837C0", VA = "0x185D845C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Vector3 DEDMEPECEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5D83EA0", Offset = "0x5D830A0", VA = "0x185D83EA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector3 CKJJKAAACGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5D84500", Offset = "0x5D83700", VA = "0x185D84500")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool EHMCDFLHAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5D84220", Offset = "0x5D83420", VA = "0x185D84220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public NGBBJMBOBME NKGMBOABFNH
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x1127750", Offset = "0x1126950", VA = "0x181127750")]
		get
		{
			return default(NGBBJMBOBME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private CEAGEKAKLML LMFGPDLCEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B50", Offset = "0x8D5D50", VA = "0x1808D6B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private JLNDDAGKPPB LCKLJFKANOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5D840E0", Offset = "0x5D832E0", VA = "0x185D840E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5D84130", Offset = "0x5D83330", VA = "0x185D84130")]
	public bool JFBFEKACGLI(AOOHFPPALCO MBAJNGADACE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5D83DD0", Offset = "0x5D82FD0", VA = "0x185D83DD0")]
	public bool FICIEFCOAME(ObjectPolicyUserConfigurableFlags MBAJNGADACE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5D83B00", Offset = "0x5D82D00", VA = "0x185D83B00")]
	public void BODFDEGMBBB(ObjectPolicyUserConfigurableFlags MBAJNGADACE, bool NANKKNCCFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	public KGGOMFBPBDG(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5D83CD0", Offset = "0x5D82ED0", VA = "0x185D83CD0", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(KGGOMFBPBDG HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface GOFOAABNBIC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	AMEHENOOIKA KBDCDOFELIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	DAPDDMANBGJ CCKFADONHAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	EntityManager GLHEACEJGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool FKBOPHAPEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase LJJBLGDLEHE(Type JAACLLLIGMF);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class DMCLIIDKNHK
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D650", Offset = "0x5D7C850", VA = "0x185D7D650")]
	public static World GHLKNCLFGOJ(this GOFOAABNBIC FBNNMOPMEAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2C0BD00", Offset = "0x2C0AF00", VA = "0x182C0BD00")]
	public static T LJJBLGDLEHE<T>(this GOFOAABNBIC FBNNMOPMEAF) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct GJPBPPPJKBH : IEquatable<GJPBPPPJKBH>
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly GJPBPPPJKBH CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	private AANPFNEFCKN EDCBGNDNLHN
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5D7FA90", Offset = "0x5D7EC90", VA = "0x185D7FA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public NGBBJMBOBME CAMKNDLLPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5D7FD60", Offset = "0x5D7EF60", VA = "0x185D7FD60")]
		get
		{
			return default(NGBBJMBOBME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public AKCLBFIHGBC JBMONCCPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5D7FB10", Offset = "0x5D7ED10", VA = "0x185D7FB10")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public AKCLBFIHGBC HOKLBIFFMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5D7FF40", Offset = "0x5D7F140", VA = "0x185D7FF40")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public NGBBJMBOBME NKGMBOABFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x1127750", Offset = "0x1126950", VA = "0x181127750")]
		get
		{
			return default(NGBBJMBOBME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	private CEAGEKAKLML LMFGPDLCEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B50", Offset = "0x8D5D50", VA = "0x1808D6B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	private JLNDDAGKPPB LCKLJFKANOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5D7FD10", Offset = "0x5D7EF10", VA = "0x185D7FD10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5D7F980", Offset = "0x5D7EB80", VA = "0x185D7F980")]
	public bool ANGEEGJGALL(AKCLBFIHGBC BLFIAOLNAKG, bool DHBDMAFHHNC = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5D7FE50", Offset = "0x5D7F050", VA = "0x185D7FE50")]
	public bool OBLCBLFOEKD(AKCLBFIHGBC NAANOAKLEBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	public GJPBPPPJKBH(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5D7FC10", Offset = "0x5D7EE10", VA = "0x185D7FC10", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(GJPBPPPJKBH HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct NDHJDCFCHBC : IEquatable<NDHJDCFCHBC>
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly NDHJDCFCHBC CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private JEIALKIEPGE PALCHPFECAG
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5D852B0", Offset = "0x5D844B0", VA = "0x185D852B0")]
		get
		{
			return default(JEIALKIEPGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public PDABLEGONNF PFGPOCAAFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5D85410", Offset = "0x5D84610", VA = "0x185D85410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	public NDHJDCFCHBC(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5D85310", Offset = "0x5D84510", VA = "0x185D85310", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(NDHJDCFCHBC HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface KPKOKDIOIJB
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	HJJHEHOPHGJ PJDAKCLABBN
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
[ANLCMDHKMHN(GPIAMNEIDDC.Application)]
public interface IDJLLLINOCD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool CDCBOJFHMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool JFPICALLGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	int AFGCGBJDKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool IDDDPNOOJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	MKADNKAIDEE PGHIHGFCJAA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	MGAKDJBGALI EIFOIPCOPEI
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool JBGMGEALDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool PANAOBKIALN
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string CDJNBIFOKLE
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int ODMIJGCLKDC(GameObject JBOGCBPFIGA);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject[] DDFKMNDHKDI(IEnumerable<JGLKPOOCMBP> CHHCFBPFFBO);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HEGAMEGFABK FHKDEAEGCDP(Guid GENGGCBCCFD);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "12")]
	MGECINBKDNJ LGMEDMPCDDM(JGLKPOOCMBP JFILJIAPEEP);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MGECINBKDNJ LGMEDMPCDDM(string LOPGCKODAFJ, HEGAMEGFABK ODDHIKCHJNG, Vector3 FNDKHLEFPKD, Quaternion AAECNILGNMA, Vector3 DNJLOGOEKNP);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void APEPMMPLGCF(bool IKKHNLLIAGI);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OJILGEEGAOL();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool EAPOCMIFKAO(GameObject JBOGCBPFIGA, out HEGAMEGFABK ODDHIKCHJNG);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool FDLCKNFDPJB(GameObject JBOGCBPFIGA, out int EAOKEPBMPJE, out ObjectPrefabType DDFDFJDKPLL);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CPIHKLBNINP(GameObject JBOGCBPFIGA, bool IJMOOPOLMGL, bool INLAECGKABB);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CANONBLONNJ(GameObject JBOGCBPFIGA);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task IICIHCGHDOO();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task HHAHIGAKBMG();

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BPCBOBFNPAA(object PDDCMNAKECC);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void AFLPMCAJHLG(object PDDCMNAKECC);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KPOGOECCEAF(object DGLHFPEOHIM);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void EFNENMNDINO(Transform BDKBLCCDFEH);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HNCDAICNFLK(Transform BDKBLCCDFEH, EKBJCFCOELA GPMJLAIPENN);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DEHEDCDBHEJ(Transform BDKBLCCDFEH, HJJHEHOPHGJ INMFCIONCCO);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KBMNFJNJDAC(GameObject JBOGCBPFIGA, ObjectPolicyUserConfigurableFlags OGCDBDGFHAP);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Vector3 EEAONECLNPF(GameObject JBOGCBPFIGA, int OAAIPLCMBED);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool OGBMBAIKMEA(out Vector3 FNDKHLEFPKD);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void LLMGJEOLCLE();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void MHKEKJHLGHO(GameObject NIEDEOAHAJL, bool KENJFDFJIKG);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "33")]
	ObjectPrefabType HJAGOCJNCCC(GameObject HHFCGHHBGCH);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "34")]
	int GAPPFHJDJIP(GameObject JBOGCBPFIGA);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "35")]
	object NINBKNJKHIP(NGBBJMBOBME LDDMDOBAIIL, GameObject JBOGCBPFIGA, Action<NGBBJMBOBME, int> NMCNKNBHPHF);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void DNJNAFLLCLK(GameObject JBOGCBPFIGA, object KBAGBGJEFPP);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void DINLNDFLIGL(GameObject JBOGCBPFIGA);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void GAAABEDGCAL(FNPNPGNLNBE JILMJAIGHMF);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void DDCEOIFFGED(GameObject JBOGCBPFIGA);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void AGELBDMLAAJ(string CEOMJLPEFPB);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	int IOAJOJIOBKN(GameObject HHFCGHHBGCH);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void JKNMOJJGBJB(NativeArray<int> LCGPIGNABLK);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void JLABGBNCFKE(Action JFFMHPNGJBK, bool ACMNOENIHON);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool DLNCBGLCFML(string PCKMHBLNCII);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class FBFNPIPJEOP
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5D7E4A0", Offset = "0x5D7D6A0", VA = "0x185D7E4A0")]
	public static MGECINBKDNJ LGMEDMPCDDM(this IDJLLLINOCD JCECDDPGEKA, HEGAMEGFABK ODDHIKCHJNG, Vector3 FNDKHLEFPKD, Quaternion AAECNILGNMA, Vector3 DNJLOGOEKNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface GJAAGEIKOED
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct ECOOEMKNFFA : PGAAPACJAHM<ECOOEMKNFFA>, DGHMCHAIFOA, IEquatable<ECOOEMKNFFA>
{
	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public int FPMEKFLEFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x985170", Offset = "0x984370", VA = "0x180985170", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x985240", Offset = "0x984440", VA = "0x180985240", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public int OLFLDONEFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xC56930", Offset = "0xC55B30", VA = "0x180C56930", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x159B400", Offset = "0x159A600", VA = "0x18159B400", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D830", Offset = "0x5D7CA30", VA = "0x185D7D830", Slot = "8")]
	public bool Equals(ECOOEMKNFFA HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D880", Offset = "0x5D7CA80", VA = "0x185D7D880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct KKLINMMKDFA : APEHPGABFCH, IEquatable<KKLINMMKDFA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public ObjectPrefabType DDFDFJDKPLL;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5D84750", Offset = "0x5D83950", VA = "0x185D84750", Slot = "5")]
	public void AKLCAJOKCCK(ref GGBOLLKFPNF GFNCLDNPAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5D84810", Offset = "0x5D83A10", VA = "0x185D84810", Slot = "4")]
	public void IOEANABOGCL(ref GNKKHBAMNEA CGGGDFDBEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5D84840", Offset = "0x5D83A40", VA = "0x185D84840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xBC4020", Offset = "0xBC3220", VA = "0x180BC4020", Slot = "6")]
	public bool Equals(KKLINMMKDFA HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5D84780", Offset = "0x5D83980", VA = "0x185D84780", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x985170", Offset = "0x984370", VA = "0x180985170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ANLCMDHKMHN(GPIAMNEIDDC.Application)]
public interface NPPBDCCLPFE
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action HABDILCELNE;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IAIECCAKPIB();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JLLOJBIHKKF();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
public interface JJPBMBOMALF
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	IJBHEKFHKPC IMANJMLGCOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	List<IBGGDEIKCDF> ENLPMAGHOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JODFHHMCDLF(IBGGDEIKCDF CKAKOJLMGFA, out IJBHEKFHKPC JCKBEJKIJPJ);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JFGPOAFMNED(IBGGDEIKCDF CKAKOJLMGFA, BGAOAOPMLDL JKIOLDAOMBJ);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNCLIJOGEGL(IBGGDEIKCDF CKAKOJLMGFA, BGAOAOPMLDL JKIOLDAOMBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ANLCMDHKMHN(GPIAMNEIDDC.Application)]
public interface FPFDJNOKODC
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	GPPFLBNBGBN OAAENMKPEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct IPBAAANCNOI : IEquatable<IPBAAANCNOI>
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly IPBAAANCNOI CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private OIINAIEDAKP GMCBNFBKGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5D82210", Offset = "0x5D81410", VA = "0x185D82210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float3 DIKNAENPOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5D823E0", Offset = "0x5D815E0", VA = "0x185D823E0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public quaternion EPFLAMGEINB
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5D824D0", Offset = "0x5D816D0", VA = "0x185D824D0")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public AKCLBFIHGBC BJCBGEIFJBK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5D820E0", Offset = "0x5D812E0", VA = "0x185D820E0")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public NGBBJMBOBME NKGMBOABFNH
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x1127750", Offset = "0x1126950", VA = "0x181127750")]
		get
		{
			return default(NGBBJMBOBME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private CEAGEKAKLML LMFGPDLCEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B50", Offset = "0x8D5D50", VA = "0x1808D6B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private JLNDDAGKPPB LCKLJFKANOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5D82390", Offset = "0x5D81590", VA = "0x185D82390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	public IPBAAANCNOI(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x1127750", Offset = "0x1126950", VA = "0x181127750")]
	public static NGBBJMBOBME MDCOPBLGMCP(IPBAAANCNOI ACKOJNNBEBO)
	{
		return default(NGBBJMBOBME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5D82290", Offset = "0x5D81490", VA = "0x185D82290", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(IPBAAANCNOI HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ANLCMDHKMHN(GPIAMNEIDDC.Application)]
public interface CNFAAEDMFCE
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action BCFCCPEJFCH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action JNJPLBKHEJG;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action JOOJGOAAMLB;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface IJBHEKFHKPC
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	string CPHOEIBBKIK
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	IJBHEKFHKPC LCMOHAHKAMH
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	IEnumerable<IJBHEKFHKPC> KMNEEAGNOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[DefaultMember("Item")]
public struct FNPNPGNLNBE : IReadOnlyList<NGBBJMBOBME>, IEnumerable<NGBBJMBOBME>, IEnumerable, IReadOnlyCollection<NGBBJMBOBME>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct HLJCIHBJBLD : IEnumerator<NGBBJMBOBME>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly CEAGEKAKLML EBMPGEPOMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private NativeArray<LocalId>.Enumerator DGEHLDDPFAK;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public NGBBJMBOBME HMPLADJAFAK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x5D81090", Offset = "0x5D80290", VA = "0x185D81090", Slot = "4")]
			get
			{
				return default(NGBBJMBOBME);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x5D80FB0", Offset = "0x5D801B0", VA = "0x185D80FB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x25CFDF0", Offset = "0x25CEFF0", VA = "0x1825CFDF0")]
		public HLJCIHBJBLD(CEAGEKAKLML EBMPGEPOMDE, NativeArray<LocalId>.Enumerator DGEHLDDPFAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x5D80EF0", Offset = "0x5D800F0", VA = "0x185D80EF0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5D80F30", Offset = "0x5D80130", VA = "0x185D80F30", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x5D80F70", Offset = "0x5D80170", VA = "0x185D80F70", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly CEAGEKAKLML EBMPGEPOMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeArray<LocalId> JILMJAIGHMF;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public NGBBJMBOBME LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F620", Offset = "0x5D7E820", VA = "0x185D7F620", Slot = "4")]
		get
		{
			return default(NGBBJMBOBME);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F070", Offset = "0x5D7E270", VA = "0x185D7F070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private int GHFEJLKEOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int CGOAKPGGPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool APOMBNLPNLG
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F120", Offset = "0x5D7E320", VA = "0x185D7F120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public NativeArray<LocalId> EMNAMABGNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x25D09B0", Offset = "0x25CFBB0", VA = "0x1825D09B0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	internal NativeArray<Entity> BKLFIMMBNJG
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F0C0", Offset = "0x5D7E2C0", VA = "0x185D7F0C0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5D7F520", Offset = "0x5D7E720", VA = "0x185D7F520")]
	public FNPNPGNLNBE(int HBHBCIIAIII, CEAGEKAKLML EBMPGEPOMDE, Allocator IEOPKOGNAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x25CF8A0", Offset = "0x25CEAA0", VA = "0x1825CF8A0")]
	public FNPNPGNLNBE(CEAGEKAKLML EBMPGEPOMDE, NativeArray<LocalId> JILMJAIGHMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5D7F5B0", Offset = "0x5D7E7B0", VA = "0x185D7F5B0")]
	internal FNPNPGNLNBE(CEAGEKAKLML EBMPGEPOMDE, NativeArray<Entity> KPALEEBPIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5D7F480", Offset = "0x5D7E680", VA = "0x185D7F480")]
	public FNPNPGNLNBE(CEAGEKAKLML EBMPGEPOMDE, int CGGOJFONIPE, Allocator IEOPKOGNAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5D7F3D0", Offset = "0x5D7E5D0", VA = "0x185D7F3D0")]
	public FNPNPGNLNBE(FNPNPGNLNBE BEEAJJNHHAF, Allocator IEOPKOGNAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5D7F080", Offset = "0x5D7E280", VA = "0x185D7F080", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5D7F160", Offset = "0x5D7E360", VA = "0x185D7F160")]
	public HLJCIHBJBLD KECFEFHENMC()
	{
		return default(HLJCIHBJBLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5D7F1F0", Offset = "0x5D7E3F0", VA = "0x185D7F1F0", Slot = "6")]
	private IEnumerator<NGBBJMBOBME> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5D7F2E0", Offset = "0x5D7E4E0", VA = "0x185D7F2E0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct HEGAMEGFABK : IComparable<HEGAMEGFABK>, IEquatable<HEGAMEGFABK>, APEHPGABFCH
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public const uint JGHHJMGDAON = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public const uint ELKKFIEHBDP = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly HEGAMEGFABK EACGNLJCKKO;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const int IMAOFDOFLLP = 24;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const uint GCICHPLNMJB = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const int CPJCCKHCJFF = 8;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private const uint DPOEOALIGNK = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly uint KJNADKBIDLI;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public uint KFHJCLEEFNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x1340CD0", Offset = "0x133FED0", VA = "0x181340CD0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public uint IHPKAGOHFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x5D80B90", Offset = "0x5D7FD90", VA = "0x185D80B90")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public uint PHBAFCCEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x985170", Offset = "0x984370", VA = "0x180985170")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool LIKFKNKKDJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x155CCA0", Offset = "0x155BEA0", VA = "0x18155CCA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool NNGGCEMMDIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5D80C00", Offset = "0x5D7FE00", VA = "0x185D80C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0xBC5BE0", Offset = "0xBC4DE0", VA = "0x180BC5BE0")]
	public static HEGAMEGFABK KMPFJPANBPM(uint KJNADKBIDLI)
	{
		return default(HEGAMEGFABK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D80CE0", Offset = "0x5D7FEE0", VA = "0x185D80CE0")]
	public HEGAMEGFABK(int OGFMHCMJMHE, int KLDGHMFFNLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D80CE0", Offset = "0x5D7FEE0", VA = "0x185D80CE0")]
	public HEGAMEGFABK(uint OGFMHCMJMHE, int KLDGHMFFNLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5D80CE0", Offset = "0x5D7FEE0", VA = "0x185D80CE0")]
	public HEGAMEGFABK(uint OGFMHCMJMHE, uint KLDGHMFFNLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x985240", Offset = "0x984440", VA = "0x180985240")]
	private HEGAMEGFABK(uint KJNADKBIDLI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x56BBAF0", Offset = "0x56BACF0", VA = "0x1856BBAF0")]
	public static bool JGKKLLGINAK(HEGAMEGFABK KCJELMMMDCA, HEGAMEGFABK NMKMEIDKGEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x56BBB00", Offset = "0x56BAD00", VA = "0x1856BBB00")]
	public static bool NGNNEMMJMMJ(HEGAMEGFABK KCJELMMMDCA, HEGAMEGFABK NMKMEIDKGEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D80A60", Offset = "0x5D7FC60", VA = "0x185D80A60", Slot = "5")]
	public bool Equals(HEGAMEGFABK OOLLEDEIDOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D80AC0", Offset = "0x5D7FCC0", VA = "0x185D80AC0", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x1400E70", Offset = "0x1400070", VA = "0x181400E70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D80C10", Offset = "0x5D7FE10", VA = "0x185D80C10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D80BA0", Offset = "0x5D7FDA0", VA = "0x185D80BA0", Slot = "6")]
	public void IOEANABOGCL(ref GNKKHBAMNEA CGGGDFDBEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D809F0", Offset = "0x5D7FBF0", VA = "0x185D809F0", Slot = "7")]
	public void AKLCAJOKCCK(ref GGBOLLKFPNF GFNCLDNPAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D80A50", Offset = "0x5D7FC50", VA = "0x185D80A50", Slot = "4")]
	public int CompareTo(HEGAMEGFABK HPOECFLNEOJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface JGGKAKFDBAM
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAGGKIMEFFI(Entity FADPOFMJIJF);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CLCFHMBKGNJ(Entity FADPOFMJIJF, in float3 ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 EKEJDFBFDAI(Entity FADPOFMJIJF);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IOFIAOFDAPO(Entity FADPOFMJIJF, in quaternion ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion DNHBKOKCDEI(Entity FADPOFMJIJF);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IFLLOKNHAGE(Entity FADPOFMJIJF, in float3 FNDKHLEFPKD, in quaternion AAECNILGNMA);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HMHPAPDLLHI(Entity FADPOFMJIJF, out float3 FNDKHLEFPKD, out quaternion AAECNILGNMA);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HMHPAPDLLHI(Entity FADPOFMJIJF, out RigidTransform AHBHJCIFOOM);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LKALOAEPNJD(Entity FADPOFMJIJF, in float3 FNDKHLEFPKD, in quaternion AAECNILGNMA);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CEOMCANDPPI(Entity FADPOFMJIJF, out RigidTransform AHBHJCIFOOM);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float3 FFKBDKMOIBG(Entity FADPOFMJIJF);

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PAFCPNNMLIM(Entity FADPOFMJIJF, in float3 ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JKEGHLANEPD(Entity FADPOFMJIJF, float ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float NMKIABKAIEE(Entity FADPOFMJIJF);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LDGAKMNPHNJ(Entity FADPOFMJIJF, in float3 ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 PNAJPMBHMOG(Entity FADPOFMJIJF);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EBLHFMJJAFE(Entity FADPOFMJIJF, in float3 ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 GKLEDPHBFDI(Entity FADPOFMJIJF);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GMFNDCDKDAL(Entity FADPOFMJIJF, in quaternion ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "19")]
	quaternion IOPHIDKGNIO(Entity FADPOFMJIJF);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 DOCHCIIDAOJ(Entity FADPOFMJIJF);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FMABIJLAJAM(Entity FADPOFMJIJF, in float3 ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CMKJHEDCGGJ(Entity FADPOFMJIJF, float ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float KMBJMBJODIE(Entity FADPOFMJIJF);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BEKMHPKJJDC(Entity FADPOFMJIJF, in float3 ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float3 BKOKMDEEOJE(Entity FADPOFMJIJF);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ICJDIGHIFDH(Entity FADPOFMJIJF, out float4x4 PGLMBDOJLJD);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LCCAAPDBIBG(Entity FADPOFMJIJF, in float4x4 PGLMBDOJLJD);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KKDCCFMDGLP(Entity FADPOFMJIJF, out float4x4 PGLMBDOJLJD);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool HIFODIKFEMG(Entity FADPOFMJIJF, out Transform BDKBLCCDFEH);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void EGCEDFHCIFP(Entity FADPOFMJIJF);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void BKDIBBAONFJ(Entity FADPOFMJIJF, Entity ACMMIJCICJB, Entity AENILMDGHEI);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class PGFHANFPNPA
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct GAIFPCNJIAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly IEnumerable<JGLKPOOCMBP> CHHCFBPFFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly IReadOnlyList<GameObject> LFPBNJGPONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IReadOnlyList<int> NPELIFBACFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly int CJGFHABLOMH;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool LIKFKNKKDJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F920", Offset = "0x5D7EB20", VA = "0x185D7F920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public int NMKBNCBIBHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8D86B0", Offset = "0x8D78B0", VA = "0x1808D86B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IEnumerable<GameObject> KLFIDACKDFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x92C1F0", Offset = "0x92B3F0", VA = "0x18092C1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x1D27400", Offset = "0x1D26600", VA = "0x181D27400")]
	public GAIFPCNJIAL(IEnumerable<JGLKPOOCMBP> CHHCFBPFFBO, IReadOnlyList<GameObject> LFPBNJGPONM, IReadOnlyList<int> NPELIFBACFO, int CJGFHABLOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5D7F6F0", Offset = "0x5D7E8F0", VA = "0x185D7F6F0")]
	public IEnumerable<(GameObject, int)> GLMBLLHJGGP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct BGEGFFMEOEA : IEquatable<BGEGFFMEOEA>
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly BGEGFFMEOEA CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private AANPFNEFCKN EDCBGNDNLHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5D7AAB0", Offset = "0x5D79CB0", VA = "0x185D7AAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public FNPNPGNLNBE CKELLIGBOEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5D7AD20", Offset = "0x5D79F20", VA = "0x185D7AD20")]
		get
		{
			return default(FNPNPGNLNBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public IEnumerable<AKCLBFIHGBC> HBAAOHAMFOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5D7B4A0", Offset = "0x5D7A6A0", VA = "0x185D7B4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public IEnumerable<AKCLBFIHGBC> HPKBJPOGOBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5D7B610", Offset = "0x5D7A810", VA = "0x185D7B610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int DKMPBPDOPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5D7B360", Offset = "0x5D7A560", VA = "0x185D7B360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public int HCKOOIBMMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5D7B2F0", Offset = "0x5D7A4F0", VA = "0x185D7B2F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public string AOPINHAKJMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5D7AC50", Offset = "0x5D79E50", VA = "0x185D7AC50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public ContainerCollisionLayerEnum LALBDCFMPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x5D7B750", Offset = "0x5D7A950", VA = "0x185D7B750")]
		get
		{
			return default(ContainerCollisionLayerEnum);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5D7A980", Offset = "0x5D79B80", VA = "0x185D7A980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public CollisionMode BFCCPNOCBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5D7B440", Offset = "0x5D7A640", VA = "0x185D7B440")]
		get
		{
			return default(CollisionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5D7AA30", Offset = "0x5D79C30", VA = "0x185D7AA30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool EJHGOLBIFCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D7A9F0", Offset = "0x5D79BF0", VA = "0x185D7A9F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool MICPJKJJKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D7B340", Offset = "0x5D7A540", VA = "0x185D7B340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool BCDMBILBNKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x5D7AA10", Offset = "0x5D79C10", VA = "0x185D7AA10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool JMLPPNIOHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D7B260", Offset = "0x5D7A460", VA = "0x185D7B260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool MMLIHHIBHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x5D7AAA0", Offset = "0x5D79CA0", VA = "0x185D7AAA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5D7AB30", Offset = "0x5D79D30", VA = "0x185D7AB30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool FHJDKKHDMFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5D7AD10", Offset = "0x5D79F10", VA = "0x185D7AD10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D7AB40", Offset = "0x5D79D40", VA = "0x185D7AB40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public NGBBJMBOBME NKGMBOABFNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x1127750", Offset = "0x1126950", VA = "0x181127750")]
		get
		{
			return default(NGBBJMBOBME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public OGPKIFMHBPM CMDBMJDLKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(OGPKIFMHBPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public GJPBPPPJKBH CNLJLEIOHON
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(GJPBPPPJKBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private CEAGEKAKLML LMFGPDLCEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B50", Offset = "0x8D5D50", VA = "0x1808D6B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private JLNDDAGKPPB LCKLJFKANOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5D7B280", Offset = "0x5D7A480", VA = "0x185D7B280")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
	public static AKCLBFIHGBC MDCOPBLGMCP(BGEGFFMEOEA HPKKDLHOJJI)
	{
		return default(AKCLBFIHGBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5D7B2D0", Offset = "0x5D7A4D0", VA = "0x185D7B2D0")]
	public bool IPMCALMMGGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5D7A8C0", Offset = "0x5D79AC0", VA = "0x185D7A8C0")]
	public bool AANOEHNFJNI(ContainerEnumFlags MBAJNGADACE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D7B1E0", Offset = "0x5D7A3E0", VA = "0x185D7B1E0")]
	public void IKBFHNANHHK(ContainerEnumFlags MBAJNGADACE, bool ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D7AFD0", Offset = "0x5D7A1D0", VA = "0x185D7AFD0")]
	public FNPNPGNLNBE GNHJHNKJICH(Allocator IEOPKOGNAGJ)
	{
		return default(FNPNPGNLNBE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D7AE20", Offset = "0x5D7A020", VA = "0x185D7AE20")]
	public void GFAMEBINJGN(BGEGFFMEOEA HPOECFLNEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	public BGEGFFMEOEA(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5D79B50", Offset = "0x5D78D50", VA = "0x185D79B50")]
	public static bool MDCOPBLGMCP(BGEGFFMEOEA ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5D7AB50", Offset = "0x5D79D50", VA = "0x185D7AB50", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(BGEGFFMEOEA HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct NIFENMPGAAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal readonly HMKLCOMDOJL CPPJLPOOLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal readonly HMKLCOMDOJL AIMLNLNCPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal readonly uint KCINJIEOENB;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5D869F0", Offset = "0x5D85BF0", VA = "0x185D869F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct FJMJILCDNIF
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly ENGBMBNJAKF OEBNJDFJMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly NIFENMPGAAL JFFMHPNGJBK;

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5D7EEF0", Offset = "0x5D7E0F0", VA = "0x185D7EEF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct POBGGPKNDOO
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly ENGBMBNJAKF OEBNJDFJMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly NIFENMPGAAL JFFMHPNGJBK;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5D7EEF0", Offset = "0x5D7E0F0", VA = "0x185D7EEF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct EHEIAAMDMEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly uint KCINJIEOENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly bool JGAFGPBPFHA;

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D9D0", Offset = "0x5D7CBD0", VA = "0x185D7D9D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
public interface JGIPKANALKC
{
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDNEJGPPHBG(NGBBJMBOBME LDDMDOBAIIL, IMJFMCOALGG ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IMJFMCOALGG KEAJHJEPHBP(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KPDBLCMOHKN(NGBBJMBOBME LDDMDOBAIIL, NGBBJMBOBME ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NIHOLBFKPBD(NGBBJMBOBME LDDMDOBAIIL, NGBBJMBOBME ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FCFEMLOHIOH(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NGBBJMBOBME KDJIBELFFHA(NGBBJMBOBME LDDMDOBAIIL, int MMFFFGBLCAP);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MPICCIEGOJO(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FENMANPMBAK(NGBBJMBOBME LDDMDOBAIIL, object IBIKCCMDMHA, NGBBJMBOBME ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CMDHLICGGFN(NGBBJMBOBME LDDMDOBAIIL, object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NEPAJNNNDNA(NGBBJMBOBME LDDMDOBAIIL, out NGBBJMBOBME ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JGJBGMFMFGK(NGBBJMBOBME LDDMDOBAIIL, float3 ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NOLEPLIFCLD(NGBBJMBOBME LDDMDOBAIIL, out float3 ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NHGNOIMGPPP(NGBBJMBOBME LDDMDOBAIIL, float3 ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool PINPNEBPIEP(NGBBJMBOBME LDDMDOBAIIL, out float3 ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AMEDPJEKFKD(NGBBJMBOBME LDDMDOBAIIL, (Quaternion rot, Vector3 moments) NEODCFKLEFJ);

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool PLBLJKMNMPL(NGBBJMBOBME LDDMDOBAIIL, out quaternion FHIJBLIMPHK, out float3 FGLHCCPPAEE);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DMNLEJMGJBM(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HNOOCEFKMGF(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete]
	float3 PEBAJFDECDC(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 BEKALOCGJAF(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FMBACHBFBOP(NGBBJMBOBME LDDMDOBAIIL, float3 ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool OMOKOGOIMMF(NGBBJMBOBME LDDMDOBAIIL, out float3 DIBPFACDFNK);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PJNINHPOILN(NGBBJMBOBME LDDMDOBAIIL, float3 ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void FPBLMLCJJEE(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	float JHOHHNKEKOI(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float JNDPPEGFFIK(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MDNPONPNOHP(NGBBJMBOBME LDDMDOBAIIL, float ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool FDMIPMIKKBH(NGBBJMBOBME LDDMDOBAIIL, out float HLEHAADLBPG);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CPMLKFMNGBI(NGBBJMBOBME LDDMDOBAIIL, float ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "29")]
	CollisionDetectionMode GEDGHCOLHII(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void KFKPGKPDKBN(NGBBJMBOBME LDDMDOBAIIL, CollisionDetectionMode ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "31")]
	GFOBGKKNJAL ONKMFDIJFPI(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void NKLIJOPIOEM(NGBBJMBOBME LDDMDOBAIIL, GFOBGKKNJAL ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool FFDCJOFJCGI(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void EPJCBLBNBHE(NGBBJMBOBME LDDMDOBAIIL, bool ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "35")]
	NGBBJMBOBME ALEFOCFOOFE(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void AHKEMAPAOFL(NGBBJMBOBME LDDMDOBAIIL, NGBBJMBOBME ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "37")]
	NGBBJMBOBME MCOPDEBMCLA(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void ANGEEGJGALL(NGBBJMBOBME LDDMDOBAIIL, NGBBJMBOBME ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	IICIADPPFLC COBNDKMFNNG(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void OHKDLPBIOLB(NGBBJMBOBME LDDMDOBAIIL, IICIADPPFLC ALGPDFOHEJL);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool POAKCMFLDOP(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void NJIGPIAGBPP(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool JBENHNKKLNP(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void MGDPIIALJGE(NGBBJMBOBME LDDMDOBAIIL, bool ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool MCNADGIJABO(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void JHHGJCBFDAE(NGBBJMBOBME LDDMDOBAIIL, bool ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "47")]
	RigidbodyConstraints IJFOBGBBAJK(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void HPCDKMNOOEI(NGBBJMBOBME LDDMDOBAIIL, RigidbodyConstraints ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float GKNBIKPMNAG(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void BCEMOBDIGBG(NGBBJMBOBME LDDMDOBAIIL, float ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "51")]
	float ECEPLABPIBC(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void KPKBCHABBJE(NGBBJMBOBME LDDMDOBAIIL, float ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool NAIBNLNEOFM(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void GLFICDKHNDD(NGBBJMBOBME LDDMDOBAIIL, bool ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "55")]
	bool DKIHNENLPAE(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void DFHCBDELBOA(NGBBJMBOBME LDDMDOBAIIL, bool ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "57")]
	int EGJAEDBBJMM(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void BBIPDLGDKFI(NGBBJMBOBME LDDMDOBAIIL, int ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(Slot = "59")]
	object KPKFKPHEGDE(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void JCAMKOFKODH(NGBBJMBOBME LDDMDOBAIIL, object ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "61")]
	object GMCDHJEMJNO(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void HAMODKLMDLP(NGBBJMBOBME LDDMDOBAIIL, object ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "63")]
	float PHIILLGLGHJ(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void BJGFFGOIPAN(NGBBJMBOBME LDDMDOBAIIL, float ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void DJDIKDCIOHB(NGBBJMBOBME LDDMDOBAIIL, object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void NBJMGDMGPFO(NGBBJMBOBME LDDMDOBAIIL, object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool HJBODELPEDO(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void JIOGDHFHOJM(NGBBJMBOBME LDDMDOBAIIL, object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void LBOFHJEHOFA(NGBBJMBOBME LDDMDOBAIIL, object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool JICGEHJDOMK(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool BIEMIEHONCA(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void DKLKNJFIALP(NGBBJMBOBME LDDMDOBAIIL, bool ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Rigidbody OFOBNMOFNHE(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void MIACMALAALB(NGBBJMBOBME LDDMDOBAIIL, Rigidbody IKACAOHCKNG);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void AHHNEFEMJBL(NGBBJMBOBME LDDMDOBAIIL, object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void NHIAMLHBBKK(NGBBJMBOBME LDDMDOBAIIL, object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool FFJJLHJBEHK(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void MKFKNOCALBB(NGBBJMBOBME LDDMDOBAIIL, float3 ODDDGBEGEIL);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void OFFLGLDEAKO(NGBBJMBOBME LDDMDOBAIIL, float3 KDIKDMAHLGO);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "80")]
	bool EFDMDLJBONL(NGBBJMBOBME LDDMDOBAIIL, out float3 ODDDGBEGEIL);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool DDBFHMBBMFJ(NGBBJMBOBME LDDMDOBAIIL, out float3 KDIKDMAHLGO);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "82")]
	bool AICOKMDIKDE(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void JMKGFALHMMP(NGBBJMBOBME LDDMDOBAIIL, object IBIKCCMDMHA, bool ONBIDCCJKPO);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void HBKKCABCOHP(NGBBJMBOBME LDDMDOBAIIL, bool GCDOINAPJNO);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void NMFGHKGODMJ(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "86")]
	bool EIANNGNJEDD(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "87")]
	IEnumerable<object> BONANJICMFL(NGBBJMBOBME LDDMDOBAIIL);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
public interface FHNJDJHGIIK
{
	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LDCILKJIAHN(Entity GIONBPBEIBM);

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDLCPABONJI(Entity GIONBPBEIBM);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct LIIMIPLCIFC : IEquatable<LIIMIPLCIFC>
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly LIIMIPLCIFC CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public string OIHJKBDOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5D848D0", Offset = "0x5D83AD0", VA = "0x185D848D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public string BHHMAKMFMDB
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x5D84C10", Offset = "0x5D83E10", VA = "0x185D84C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	public LIIMIPLCIFC(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x5D84B10", Offset = "0x5D83D10", VA = "0x185D84B10", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(LIIMIPLCIFC HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct POALCLKMGOD : IEquatable<POALCLKMGOD>
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly POALCLKMGOD CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x5D8A510", Offset = "0x5D89710", VA = "0x185D8A510", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(POALCLKMGOD HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct DGNDKJBMNKA : IEquatable<DGNDKJBMNKA>
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly DGNDKJBMNKA CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private MEMNMHGIDMM ILBAKHPOHNM
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x5D7D2C0", Offset = "0x5D7C4C0", VA = "0x185D7D2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool HOFJBKCGLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5D7C980", Offset = "0x5D7BB80", VA = "0x185D7C980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool MABGFAFCNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5D7D4D0", Offset = "0x5D7C6D0", VA = "0x185D7D4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool CAKGJCGIEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5D7D340", Offset = "0x5D7C540", VA = "0x185D7D340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool ECDIPLLNIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x5D7C940", Offset = "0x5D7BB40", VA = "0x185D7C940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool NCEOIHCJLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x5D7CF10", Offset = "0x5D7C110", VA = "0x185D7CF10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool OFKIAOJCBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x5D7CA60", Offset = "0x5D7BC60", VA = "0x185D7CA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool APBEJOJOGFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5D7D050", Offset = "0x5D7C250", VA = "0x185D7D050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public NGBBJMBOBME NKGMBOABFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x1127750", Offset = "0x1126950", VA = "0x181127750")]
		get
		{
			return default(NGBBJMBOBME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CEAGEKAKLML LMFGPDLCEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B50", Offset = "0x8D5D50", VA = "0x1808D6B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private JLNDDAGKPPB LCKLJFKANOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5D7D000", Offset = "0x5D7C200", VA = "0x185D7D000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D290", Offset = "0x5D7C490", VA = "0x185D7D290")]
	public bool LJJDGHDBJNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D370", Offset = "0x5D7C570", VA = "0x185D7D370")]
	public AKCLBFIHGBC OPPJBIINAPC(AKCLBFIHGBC PDDCMNAKECC)
	{
		return default(AKCLBFIHGBC);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x5D7CD50", Offset = "0x5D7BF50", VA = "0x185D7CD50")]
	public NGBBJMBOBME FMIEHOCDOKD()
	{
		return default(NGBBJMBOBME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	public DGNDKJBMNKA(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x5D79B50", Offset = "0x5D78D50", VA = "0x185D79B50")]
	public static bool MDCOPBLGMCP(DGNDKJBMNKA ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x5D7CC50", Offset = "0x5D7BE50", VA = "0x185D7CC50", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(DGNDKJBMNKA HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct NGGANMPEPOM : IComparable<NGGANMPEPOM>, IEquatable<NGGANMPEPOM>
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly NGGANMPEPOM EACGNLJCKKO;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly NGGANMPEPOM JMIBOOIOGPP;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly NGGANMPEPOM IONHBFAMBHP;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly NGGANMPEPOM MFENIHECMNI;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly NGGANMPEPOM HJFMGIPJNKL;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly NGGANMPEPOM CGGECKAAEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public int FPMEKFLEFKK;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool AHKJKCKGADI
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x5D86330", Offset = "0x5D85530", VA = "0x185D86330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x985240", Offset = "0x984440", VA = "0x180985240")]
	public NGGANMPEPOM(int MMFFFGBLCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5D863E0", Offset = "0x5D855E0", VA = "0x185D863E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x5D86350", Offset = "0x5D85550", VA = "0x185D86350", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0xBC4020", Offset = "0xBC3220", VA = "0x180BC4020", Slot = "5")]
	public bool Equals(NGGANMPEPOM HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x5D86340", Offset = "0x5D85540", VA = "0x185D86340", Slot = "4")]
	public int CompareTo(NGGANMPEPOM HPOECFLNEOJ)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0xBC5BE0", Offset = "0xBC4DE0", VA = "0x180BC5BE0")]
	public static NGGANMPEPOM MDCOPBLGMCP(int MMFFFGBLCAP)
	{
		return default(NGGANMPEPOM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0xBC5BE0", Offset = "0xBC4DE0", VA = "0x180BC5BE0")]
	public static int MDCOPBLGMCP(NGGANMPEPOM FNPJNJDJLAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x5D86450", Offset = "0x5D85650", VA = "0x185D86450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface OCIMDGPPAOA : IEnumerable<EHIFJGCKECG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	EHIFJGCKECG LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EHIFJGCKECG AIEJPNBDMBP(GFNBJKOODOI LPBMDNNGIOI);

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NGGANMPEPOM AHFDFLNGHDK(GFNBJKOODOI LPBMDNNGIOI);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class ICMHGFOOGEF
{
	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	public static CONCGEIHFKE<T> AIEJPNBDMBP<T>(this OCIMDGPPAOA MDEOLPGKLLA, GFNBJKOODOI PCKMHBLNCII) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x268A400", Offset = "0x2689600", VA = "0x18268A400")]
	public static NGGANMPEPOM AHFDFLNGHDK<T>(this OCIMDGPPAOA MDEOLPGKLLA, FPAOGPJBAPF<T> PCKMHBLNCII) where T : struct
	{
		return default(NGGANMPEPOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface BEDMHIIIBHJ
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMGLOBHMAFH(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GPDOOBHEBED(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NOKGHDFGDOP(NGBBJMBOBME LDDMDOBAIIL, out Guid DDEOLFGMHMC);

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid JEFJFACBCPP(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BJIFODIDGCL(NGBBJMBOBME LDDMDOBAIIL, Guid DDEOLFGMHMC);

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DDIMIPKIMKO(NGBBJMBOBME LDDMDOBAIIL, out Guid ECDINGOLKBF);

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid FGBGBABBMJJ(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LPCIBDOECBD(NGBBJMBOBME LDDMDOBAIIL, Guid ECDINGOLKBF);

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KBAFOACEKMP(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OHGJOBNMOBM(NGBBJMBOBME DGKHGILMPOP, NGBBJMBOBME BLFIAOLNAKG);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
public interface AJOGFACNBDG
{
	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHALBNPONFD(NGBBJMBOBME IHKJNNPMCLD, bool ACKOJNNBEBO);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct HICJGPMMLFL : IEquatable<HICJGPMMLFL>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly HICJGPMMLFL CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public NEKLHFPGMAI HAMBCECDANL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(NEKLHFPGMAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private KHCEGNGMMJC FBMGILJLDJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x5D80D50", Offset = "0x5D7FF50", VA = "0x185D80D50")]
		get
		{
			return default(KHCEGNGMMJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public PrimitiveShapeType CGHOLEFCCMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x5D80CF0", Offset = "0x5D7FEF0", VA = "0x185D80CF0")]
		get
		{
			return default(PrimitiveShapeType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public NGBBJMBOBME NKGMBOABFNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x1127750", Offset = "0x1126950", VA = "0x181127750")]
		get
		{
			return default(NGBBJMBOBME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	public HICJGPMMLFL(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5D79B50", Offset = "0x5D78D50", VA = "0x185D79B50")]
	public static bool MDCOPBLGMCP(HICJGPMMLFL ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D80DB0", Offset = "0x5D7FFB0", VA = "0x185D80DB0", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(HICJGPMMLFL HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
public interface ADIDOGFIJDG
{
	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBLAIEMHPKM(NGBBJMBOBME LDDMDOBAIIL, ContainerCollisionLayerEnum JMOHCCPCAOJ, bool LJDKPKOOOOF, ContainerEnumFlags FCKEALEBEHA);

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGFOCGICBFI(NGBBJMBOBME LDDMDOBAIIL, ContainerCollisionLayerEnum JMOHCCPCAOJ, bool LJDKPKOOOOF, bool AMLHMELHLNE, bool LCFMGFHMFAD);

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IMMEHFBDEOH CEMAHGNONNN(NGBBJMBOBME NPDELNKHCNM, List<NGBBJMBOBME> CLKLJPFFGMO);

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ICNFLPOCKMB(GameObject KDJBFKGLKKM, GameObject JGKMNMGJAOB);

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OHLPPNNOGFD(GameObject JGKMNMGJAOB);

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T LPIEMOIKCDP<T>(GameObject AELIEDJJAKH) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BPAMMFALFPL(Collider JHGJKCLNOFL);

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject FKFCAEFFPGP<T>(string PCKMHBLNCII) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface KEHELDOGIHI
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	bool GAIAFJLIGLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	NGBBJMBOBME NKGMBOABFNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[ANLCMDHKMHN(GPIAMNEIDDC.Application)]
public interface PEJHJFMNPPF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	bool KHLGAANNJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	bool OCMGPEGKMBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	CDIMBHIJGCF NGBDLJEJEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LLMGDFNOMDP(bool IKKHNLLIAGI);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task PINOOJBAKHL(bool IKKHNLLIAGI);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KOGJHKDHONI JAHIGDIOKEO();

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KOGJHKDHONI GKOKGPGGLIL(IEnumerable<NGBBJMBOBME> JILMJAIGHMF, in JDHDLIGEPLE JMIOLFJKEHG);

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BFJOLEIBDPE BIJKJLKNOHB(ByteString ALPBLOPFDMK);

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FPANIHEBNCJ HDFJLAIMBAE(ByteString CFOODOIEFBB, NGBBJMBOBME BLFIAOLNAKG, in JDHDLIGEPLE LHBOOJPDEDN, KMNAFGNFHKA BFLKEABMBHN, bool COCJJPKBOGK = true);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HFCJONJEPGE();

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OFCIKHHGDNA(bool FEIAFIAAGAH);

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	GAIFPCNJIAL NEDDDEKDKCK(IEnumerable<JGLKPOOCMBP> CHHCFBPFFBO);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class HFGFJMEJIAG
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[ANLCMDHKMHN(GPIAMNEIDDC.Application)]
public interface AEEJPJKDJGJ : ABMNFPOAFLN, BFPPGIPJGJM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	bool FKBOPHAPEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	FENCPJEGFLM LCOBFIPBLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	IDJLLLINOCD HBOAAEKILAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	JLNDDAGKPPB LCKLJFKANOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[ANLCMDHKMHN(GPIAMNEIDDC.Application)]
public interface BFPPGIPJGJM
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	bool LBLKPCPKJAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
public interface OONLFDJGGKE
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	bool IFMGFDKHIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
public interface KEAFGEOHPMC
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	Guid AGKJCBCHPBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGJBKHNIKIM(Guid DDEOLFGMHMC, Guid ECDINGOLKBF, string PCKMHBLNCII);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct HMKLCOMDOJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal int ADLHMCAGLJA;

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5D81620", Offset = "0x5D80820", VA = "0x185D81620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class MBALMBNOCDC
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private struct ABBIKEAGOHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Guid CNDCJIFNLGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NFJNFHHGAEC KDMOHNMCEJL;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private struct NFJNFHHGAEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int ACKOJNNBEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int JFHDOPHDGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int FNOJAGHPPMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int KAMABGGCHJD;

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5D85DD0", Offset = "0x5D84FD0", VA = "0x185D85DD0")]
		public bool IOEEICPKBOP(out HEGAMEGFABK ODDHIKCHJNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x5D85E70", Offset = "0x5D85070", VA = "0x185D85E70")]
		public NFJNFHHGAEC(HEGAMEGFABK ODDHIKCHJNG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5D84F40", Offset = "0x5D84140", VA = "0x185D84F40")]
	public static Guid BIIMHBGGHFA(this HEGAMEGFABK ODDHIKCHJNG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x5D84FE0", Offset = "0x5D841E0", VA = "0x185D84FE0")]
	public static bool NBMKNEAILEK(this Guid CNDCJIFNLGE, out HEGAMEGFABK ODDHIKCHJNG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(MHMBPIINJCE))]
public readonly struct NGBBJMBOBME : IComparable<NGBBJMBOBME>, IEquatable<NGBBJMBOBME>
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly NGBBJMBOBME EACGNLJCKKO;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public CEAGEKAKLML LMFGPDLCEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B50", Offset = "0x8D5D50", VA = "0x1808D6B50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public LocalId NFAINGIHNGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x92C1F0", Offset = "0x92B3F0", VA = "0x18092C1F0")]
		[CompilerGenerated]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool KMMKKFEGNCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x5D85FA0", Offset = "0x5D851A0", VA = "0x185D85FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool FKOAEBNDHIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x5D860E0", Offset = "0x5D852E0", VA = "0x185D860E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool LMDEDAJGNCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x5D860C0", Offset = "0x5D852C0", VA = "0x185D860C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5D862B0", Offset = "0x5D854B0", VA = "0x185D862B0")]
	public NGBBJMBOBME(CEAGEKAKLML KKBBEDBIOIK, LocalId LDDMDOBAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
	public AKCLBFIHGBC JGKDBDNDDMD()
	{
		return default(AKCLBFIHGBC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x92C1F0", Offset = "0x92B3F0", VA = "0x18092C1F0")]
	public static LocalId MDCOPBLGMCP(NGBBJMBOBME HBLKNBMHNNE)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x5D86100", Offset = "0x5D85300", VA = "0x185D86100")]
	public static Entity MDCOPBLGMCP(NGBBJMBOBME HBLKNBMHNNE)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x5D86070", Offset = "0x5D85270", VA = "0x185D86070")]
	public static bool JGKKLLGINAK(NGBBJMBOBME KCJELMMMDCA, NGBBJMBOBME NMKMEIDKGEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x5D86110", Offset = "0x5D85310", VA = "0x185D86110")]
	public static bool NGNNEMMJMMJ(NGBBJMBOBME KCJELMMMDCA, NGBBJMBOBME NMKMEIDKGEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x5D861B0", Offset = "0x5D853B0", VA = "0x185D861B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x5D85EF0", Offset = "0x5D850F0", VA = "0x185D85EF0", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x5D85E90", Offset = "0x5D85090", VA = "0x185D85E90", Slot = "4")]
	public int CompareTo(NGBBJMBOBME HPOECFLNEOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "5")]
	public bool Equals(NGBBJMBOBME HPOECFLNEOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class LKAAFBADPAG
{
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x5D84D00", Offset = "0x5D83F00", VA = "0x185D84D00")]
	public static HEGAMEGFABK AIJKBBFHHMJ(this NGBBJMBOBME BHEOHCEHIBM)
	{
		return default(HEGAMEGFABK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x3344C00", Offset = "0x3343E00", VA = "0x183344C00")]
	public static T HINAFKFCFOF<T>(this NGBBJMBOBME BHEOHCEHIBM) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class MHMBPIINJCE
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
public interface PBIAEBDDJPF
{
	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	bool FKBOPHAPEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDBEBBMHLIJ(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JILCFDLJCMO(NGBBJMBOBME LDDMDOBAIIL, bool LJDKPKOOOOF, bool AMLHMELHLNE, bool FALNHDPJCAN);
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct JDHBMHNEIFC : IEquatable<JDHBMHNEIFC>
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly JDHBMHNEIFC CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public NGBBJMBOBME NKGMBOABFNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1127750", Offset = "0x1126950", VA = "0x181127750")]
		get
		{
			return default(NGBBJMBOBME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private CEAGEKAKLML LMFGPDLCEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B50", Offset = "0x8D5D50", VA = "0x1808D6B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private JLNDDAGKPPB LCKLJFKANOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x5D82840", Offset = "0x5D81A40", VA = "0x185D82840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5D82600", Offset = "0x5D81800", VA = "0x185D82600")]
	public void EGHBIKLOBON(bool ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D82890", Offset = "0x5D81A90", VA = "0x185D82890")]
	public void JBAFBEBFNGP(bool ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x298DAD0", Offset = "0x298CCD0", VA = "0x18298DAD0")]
	public T LCLLLADJDAP<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	public JDHBMHNEIFC(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D82740", Offset = "0x5D81940", VA = "0x185D82740", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(JDHBMHNEIFC HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct BPILLIHPBHA : IEquatable<BPILLIHPBHA>
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly BPILLIHPBHA CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5D7C800", Offset = "0x5D7BA00", VA = "0x185D7C800", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(BPILLIHPBHA HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[ANLCMDHKMHN(GPIAMNEIDDC.Application)]
public interface GMAFBAPLACC
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	bool OBKIJHAIDIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	bool CKMGKNJECJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	bool JDILJBBHGBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	bool MMOGIOABLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	bool MAHAIJPFNFH
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	bool MIELKEDKCCI
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	bool OMCJIGLAJDB
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct OAMAJKNKBPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float NELOPAHIPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float3 IJGNBLHAEPN;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct NEKLHFPGMAI : IEquatable<NEKLHFPGMAI>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly NEKLHFPGMAI CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private DLFFFAEKLNA KHIOEMGNDFN
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x5D85D30", Offset = "0x5D84F30", VA = "0x185D85D30")]
		get
		{
			return default(DLFFFAEKLNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public JGACKPHOKPF FICIMAOFFNO
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x5D859A0", Offset = "0x5D84BA0", VA = "0x185D859A0")]
		get
		{
			return default(JGACKPHOKPF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public NNECJJEBCFK EPAOHACBHMG
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x5D85BE0", Offset = "0x5D84DE0", VA = "0x185D85BE0")]
		get
		{
			return default(NNECJJEBCFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public PIHLENOCCBO AHNCJDFEODF
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x5D85640", Offset = "0x5D84840", VA = "0x185D85640")]
		get
		{
			return default(PIHLENOCCBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public EShapeType KJKDJNPNAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x5D854C0", Offset = "0x5D846C0", VA = "0x185D854C0")]
		get
		{
			return default(EShapeType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public RenderableColor CBHLHFBIIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x5D85700", Offset = "0x5D84900", VA = "0x185D85700")]
		get
		{
			return default(RenderableColor);
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x5D85C40", Offset = "0x5D84E40", VA = "0x185D85C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public RenderableMaterial POMHABFAHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x5D856A0", Offset = "0x5D848A0", VA = "0x185D856A0")]
		get
		{
			return default(RenderableMaterial);
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x5D85540", Offset = "0x5D84740", VA = "0x185D85540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public float CNFCOGFPHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x5D85B00", Offset = "0x5D84D00", VA = "0x185D85B00")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x5D85CB0", Offset = "0x5D84EB0", VA = "0x185D85CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 EKAOKKIFCAC
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x5D85A00", Offset = "0x5D84C00", VA = "0x185D85A00")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x5D855B0", Offset = "0x5D847B0", VA = "0x185D855B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public float GJPBJBLPBEN
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x5D85B60", Offset = "0x5D84D60", VA = "0x185D85B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public ShapeConfigData.Flags DJOCNJLFOIK
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x5D858D0", Offset = "0x5D84AD0", VA = "0x185D858D0")]
		get
		{
			return default(ShapeConfigData.Flags);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x5D85A90", Offset = "0x5D84C90", VA = "0x185D85A90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public NGBBJMBOBME NKGMBOABFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x1127750", Offset = "0x1126950", VA = "0x181127750")]
		get
		{
			return default(NGBBJMBOBME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public OGPKIFMHBPM CMDBMJDLKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(OGPKIFMHBPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x5D85930", Offset = "0x5D84B30", VA = "0x185D85930")]
	public HICJGPMMLFL GGBJIKENCAI()
	{
		return default(HICJGPMMLFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x5D85860", Offset = "0x5D84A60", VA = "0x185D85860")]
	public BHCPGPGNHFI FFMKCACILDD()
	{
		return default(BHCPGPGNHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	public NEKLHFPGMAI(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x5D79B50", Offset = "0x5D78D50", VA = "0x185D79B50")]
	public static bool MDCOPBLGMCP(NEKLHFPGMAI ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5D85760", Offset = "0x5D84960", VA = "0x185D85760", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(NEKLHFPGMAI HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[ANLCMDHKMHN(GPIAMNEIDDC.Application)]
public interface JLNDDAGKPPB
{
	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	EJCDFCAJDED LCOBFIPBLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	IDJLLLINOCD HBOAAEKILAL
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	GOFOAABNBIC KBDCDOFELIM
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	CEAGEKAKLML LMFGPDLCEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	AANPFNEFCKN CNLJLEIOHON
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	JGGKAKFDBAM LGODFBHDKJL
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	PEJHJFMNPPF DKNFFPDFGAE
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	HAGGNNONGHI HFLIBEOCDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	IAFLLBAHGJH LPIAEGCHLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	MEMNMHGIDMM NLPLAFHKJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	EJKMFCDDIDM EFBEDLBPAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	AJOGFACNBDG AOJILAIFNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	KPINHOOOKEA HLMIIIEDBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	BEDMHIIIBHJ ABGKCIDDFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	OIINAIEDAKP GLLKHOCBFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	JGIPKANALKC APFBOPBJOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	GMAFBAPLACC JGPELAJIFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
public interface COGCBHNHNMA
{
	[Cpp2IlInjected.Token(Token = "0x17000104")]
	object CBNMBMIJDNH
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAAABEDGCAL(FNPNPGNLNBE JILMJAIGHMF);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface AANPFNEFCKN
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public delegate void FFOFKCMCGBH(FNPNPGNLNBE EBMPGEPOMDE, FNPNPGNLNBE HPAAFGELLFF, FNPNPGNLNBE KDIKMEBMDNA);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NGBBJMBOBME ALEFOCFOOFE(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NGBBJMBOBME MCOPDEBMCLA(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ANGEEGJGALL(NGBBJMBOBME LDDMDOBAIIL, NGBBJMBOBME BLFIAOLNAKG, bool DHBDMAFHHNC);

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HKHNGDLCLIL(NGBBJMBOBME LDDMDOBAIIL, NGBBJMBOBME BLFIAOLNAKG);

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FCFEMLOHIOH(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FNPNPGNLNBE LDKPGMPEBDE(NGBBJMBOBME IHKJNNPMCLD);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LCDKDEGALJJ(NGBBJMBOBME LDDMDOBAIIL, NGBBJMBOBME JOGKKCDJIND);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OBLCBLFOEKD(NGBBJMBOBME LDDMDOBAIIL, NGBBJMBOBME NAANOAKLEBN);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NGBBJMBOBME PLPAEAMNHKA(NGBBJMBOBME JOGKKCDJIND, NGBBJMBOBME DOPPPNLMLFP);

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JDBHDGNCDKG(NGBBJMBOBME JOGKKCDJIND, NGBBJMBOBME DOPPPNLMLFP, out NGBBJMBOBME GFNMBJLLAGG);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class FLOJKFOGPAK
{
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x5D7EF90", Offset = "0x5D7E190", VA = "0x185D7EF90")]
	public static bool OEJPAMFBDGM(this AANPFNEFCKN CBLHBMDHMMB, NGBBJMBOBME LDDMDOBAIIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public enum DDIAGBGICLK
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
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
public interface HAGGNNONGHI
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<NGBBJMBOBME> CIPJIHNABNK(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NGBBJMBOBME FHHIAOIGAIG(NGBBJMBOBME LDDMDOBAIIL, int MMFFFGBLCAP);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int EJPCOPEIFLJ(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BHNEBIKGAFE KJEAIMBJGCM(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EEIMFNGFHLA(NGBBJMBOBME LDDMDOBAIIL, BHNEBIKGAFE OGEINKONADM);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NGBBJMBOBME HCHOLBBLMLA(NGBBJMBOBME LDDMDOBAIIL, [Optional] float3? FNDKHLEFPKD, [Optional] quaternion? AAECNILGNMA, [Optional] float3? DNJLOGOEKNP);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NGBBJMBOBME OKKMDCCEMAI(NGBBJMBOBME LDDMDOBAIIL, int MMFFFGBLCAP, [Optional] float3? FNDKHLEFPKD, [Optional] quaternion? AAECNILGNMA, [Optional] float3? DNJLOGOEKNP);

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HJPPKIFCDPC(NGBBJMBOBME LDDMDOBAIIL, int MMFFFGBLCAP);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DKMJOGAEKIL(NGBBJMBOBME LDDMDOBAIIL);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface ENBDLEKDPJE
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEGBKDOPBAO(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FLEGBCAMHMG(NGBBJMBOBME LDDMDOBAIIL, Transform BDKBLCCDFEH);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface GBKNCDNCKOC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000105")]
	LocalId BDDIPPHMGMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	LocalId OMDBADMAGBM
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
	void CGHBJOMPHHG(float3 JMLNBNKHCNA);

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EBMFGOGAIPI(float3 JMLNBNKHCNA);

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KBGLMGIIEBF(out float3 CPPJLPOOLJG, out float3 AIMLNLNCPLA);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JGOHKHNEAMM(float3 CPPJLPOOLJG, float3 AIMLNLNCPLA);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CJHKDACJPPI(Color CPPJLPOOLJG, Color AIMLNLNCPLA);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GBKNCDNCKOC Instantiate(Transform BDKBLCCDFEH);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface KNCOEBLNIPB
{
	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHLMLHJNBAL(Transform BDKBLCCDFEH, GBKNCDNCKOC EEJOOKIGGIP);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GBKNCDNCKOC JGDMGNBOKKD();
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct NAACDNGEKOG : IEquatable<NAACDNGEKOG>
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly NAACDNGEKOG CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	private JCGIIFIMPDO CFKANADCNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x5D85060", Offset = "0x5D84260", VA = "0x185D85060")]
		get
		{
			return default(JCGIIFIMPDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public PropType PMPGGJEOPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x5D85000", Offset = "0x5D84200", VA = "0x185D85000")]
		get
		{
			return default(PropType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x5D851C0", Offset = "0x5D843C0", VA = "0x185D851C0")]
	public NDHJDCFCHBC LDFKJHAFMBP()
	{
		return default(NDHJDCFCHBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	public NAACDNGEKOG(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x5D850C0", Offset = "0x5D842C0", VA = "0x185D850C0", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(NAACDNGEKOG HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface EEIKCCAPGKI
{
	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EPEILODOCEH();
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class LLJDJAPNNKH
{
	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x5D84DF0", Offset = "0x5D83FF0", VA = "0x185D84DF0")]
	public static void EPEILODOCEH(this GameObject HHFCGHHBGCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct NIBBJHLENKD : IEquatable<NIBBJHLENKD>
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly NIBBJHLENKD CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x5D868B0", Offset = "0x5D85AB0", VA = "0x185D868B0", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(NIBBJHLENKD HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct KCPKEBCIEGB : IEquatable<KCPKEBCIEGB>
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static readonly KCPKEBCIEGB CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	public KCPKEBCIEGB(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x5D83950", Offset = "0x5D82B50", VA = "0x185D83950", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(KCPKEBCIEGB HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x5D83820", Offset = "0x5D82A20", VA = "0x185D83820")]
	public bool BCPKEBNAHPH(out Collider JHGJKCLNOFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct JJKEIKKDKKP : IEquatable<JJKEIKKDKKP>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly JJKEIKKDKKP CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public NGBBJMBOBME NKGMBOABFNH
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x1127750", Offset = "0x1126950", VA = "0x181127750")]
		get
		{
			return default(NGBBJMBOBME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public BHCPGPGNHFI HPHENOPGIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x5D834D0", Offset = "0x5D826D0", VA = "0x185D834D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public float3 KGBIENJBPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x5D833E0", Offset = "0x5D825E0", VA = "0x185D833E0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x5D83070", Offset = "0x5D82270", VA = "0x185D83070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public quaternion AHCAPKEEIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x5D83620", Offset = "0x5D82820", VA = "0x185D83620")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x5D83100", Offset = "0x5D82300", VA = "0x185D83100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float3 HJDNNOLCMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x5D83350", Offset = "0x5D82550", VA = "0x185D83350")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x5D83590", Offset = "0x5D82790", VA = "0x185D83590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public JCLDJFKGCEG MNHGBHMGKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x5D832E0", Offset = "0x5D824E0", VA = "0x185D832E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private KNHHLJKAAAO AHPLJOHBLDE
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x5D82F50", Offset = "0x5D82150", VA = "0x185D82F50")]
		get
		{
			return default(KNHHLJKAAAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	private PJFAPHMJNGH EGHBAABINDK
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x5D83470", Offset = "0x5D82670", VA = "0x185D83470")]
		get
		{
			return default(PJFAPHMJNGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	private GDFGDHHIGMM JBBCDDLCPMK
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x5D83280", Offset = "0x5D82480", VA = "0x185D83280")]
		get
		{
			return default(GDFGDHHIGMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	private HPFBINLCPCH KIINCGFNNKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x5D82EF0", Offset = "0x5D820F0", VA = "0x185D82EF0")]
		get
		{
			return default(HPFBINLCPCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	private PECKODMLLMC IEBHPGCKHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x5D82E90", Offset = "0x5D82090", VA = "0x185D82E90")]
		get
		{
			return default(PECKODMLLMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	public JJKEIKKDKKP(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x5D83180", Offset = "0x5D82380", VA = "0x185D83180", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(JJKEIKKDKKP HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x5D82FB0", Offset = "0x5D821B0", VA = "0x185D82FB0")]
	public void CBHPOIOCKLB(BHCPGPGNHFI ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x5D83070", Offset = "0x5D82270", VA = "0x185D83070")]
	public void CLCFHMBKGNJ(float3 ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x5D83100", Offset = "0x5D82300", VA = "0x185D83100")]
	public void IOFIAOFDAPO(quaternion ACKOJNNBEBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct OGPKIFMHBPM : IEquatable<OGPKIFMHBPM>
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public static readonly OGPKIFMHBPM CFLDBFNJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly NGBBJMBOBME IHKJNNPMCLD;

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public AKCLBFIHGBC IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5D79330", Offset = "0x5D78530", VA = "0x185D79330")]
		get
		{
			return default(AKCLBFIHGBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private CEAGEKAKLML LMFGPDLCEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B50", Offset = "0x8D5D50", VA = "0x1808D6B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	private JGGKAKFDBAM BIFBKHGNAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x5D893E0", Offset = "0x5D885E0", VA = "0x185D893E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public bool JOPNGACNNHM
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5D89BE0", Offset = "0x5D88DE0", VA = "0x185D89BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Vector3 KGBIENJBPHB
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5D89050", Offset = "0x5D88250", VA = "0x185D89050")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x5D887B0", Offset = "0x5D879B0", VA = "0x185D887B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion AHCAPKEEIIP
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x5D8A1B0", Offset = "0x5D893B0", VA = "0x185D8A1B0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5D87A40", Offset = "0x5D86C40", VA = "0x185D87A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Vector3 HNKNNHMEGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5D87600", Offset = "0x5D86800", VA = "0x185D87600")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5D89C30", Offset = "0x5D88E30", VA = "0x185D89C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Quaternion DJDCKLEDKBO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x5D88DA0", Offset = "0x5D87FA0", VA = "0x185D88DA0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x5D86E50", Offset = "0x5D86050", VA = "0x185D86E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public float OIOGJBJKCED
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x5D89450", Offset = "0x5D88650", VA = "0x185D89450")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x5D881C0", Offset = "0x5D873C0", VA = "0x185D881C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public float HEOPLDAELCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x5D88420", Offset = "0x5D87620", VA = "0x185D88420")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public Vector3 HJDNNOLCMAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x5D88660", Offset = "0x5D87860", VA = "0x185D88660")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5D89D70", Offset = "0x5D88F70", VA = "0x185D89D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public Vector3 NFBGAGFOFGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x5D89550", Offset = "0x5D88750", VA = "0x185D89550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Vector3 IBCBOLFAMGK
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x5D89820", Offset = "0x5D88A20", VA = "0x185D89820")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Matrix4x4 FJAJLFKMENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x5D87580", Offset = "0x5D86780", VA = "0x185D87580")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	public OGPKIFMHBPM(NGBBJMBOBME LDDMDOBAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x825B60", Offset = "0x824D60", VA = "0x180825B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x5D87E10", Offset = "0x5D87010", VA = "0x185D87E10", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x5D79190", Offset = "0x5D78390", VA = "0x185D79190", Slot = "4")]
	public bool Equals(OGPKIFMHBPM HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x5D79350", Offset = "0x5D78550", VA = "0x185D79350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x5D89FF0", Offset = "0x5D891F0", VA = "0x185D89FF0")]
	public PPNEKCJPIML PHFFNDHBLDG()
	{
		return default(PPNEKCJPIML);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5D89690", Offset = "0x5D88890", VA = "0x185D89690")]
	public void NINHFJGPDPH(out Matrix4x4 PGLMBDOJLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5D888F0", Offset = "0x5D87AF0", VA = "0x185D888F0")]
	public void HMHPAPDLLHI(out Vector3 DCPAHAKGAMI, out Quaternion LGBNFNDLAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5D87220", Offset = "0x5D86420", VA = "0x185D87220")]
	public void CEOMCANDPPI(out RigidTransform CPAEMMDPKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5D89A70", Offset = "0x5D88C70", VA = "0x185D89A70")]
	public JDHDLIGEPLE NNHPALNFOLI()
	{
		return default(JDHDLIGEPLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5D89AC0", Offset = "0x5D88CC0", VA = "0x185D89AC0")]
	public void NNHPALNFOLI(out JDHDLIGEPLE KEECHNKDOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5D87F10", Offset = "0x5D87110", VA = "0x185D87F10")]
	public JDHDLIGEPLE FKMBEPAGNCA()
	{
		return default(JDHDLIGEPLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D87F60", Offset = "0x5D87160", VA = "0x185D87F60")]
	public void FKMBEPAGNCA(out JDHDLIGEPLE CPAEMMDPKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D87CC0", Offset = "0x5D86EC0", VA = "0x185D87CC0")]
	public Vector3 EKEJDFBFDAI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D87330", Offset = "0x5D86530", VA = "0x185D87330")]
	public void CLCFHMBKGNJ(in Vector3 ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D882D0", Offset = "0x5D874D0", VA = "0x185D882D0")]
	public Vector3 GKLEDPHBFDI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D87B80", Offset = "0x5D86D80", VA = "0x185D87B80")]
	public void EBLHFMJJAFE(in Vector3 ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D87750", Offset = "0x5D86950", VA = "0x185D87750")]
	public Quaternion DNHBKOKCDEI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D88AC0", Offset = "0x5D87CC0", VA = "0x185D88AC0")]
	public void IOFIAOFDAPO(in Quaternion ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D88C00", Offset = "0x5D87E00", VA = "0x185D88C00")]
	public Quaternion IOPHIDKGNIO()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D88520", Offset = "0x5D87720", VA = "0x185D88520")]
	public void GMFNDCDKDAL(in Quaternion ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5D89970", Offset = "0x5D88B70", VA = "0x185D89970")]
	public float NMKIABKAIEE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5D88F40", Offset = "0x5D88140", VA = "0x185D88F40")]
	public void JKEGHLANEPD(float ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5D891A0", Offset = "0x5D883A0", VA = "0x185D891A0")]
	public float KMBJMBJODIE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5D87470", Offset = "0x5D86670", VA = "0x185D87470")]
	public void CMKJHEDCGGJ(float ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5D89EB0", Offset = "0x5D890B0", VA = "0x185D89EB0")]
	public void PAFCPNNMLIM(in Vector3 ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5D878F0", Offset = "0x5D86AF0", VA = "0x185D878F0")]
	public Vector3 DOCHCIIDAOJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5D88080", Offset = "0x5D87280", VA = "0x185D88080")]
	public void FMABIJLAJAM(in Vector3 ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x5D8A060", Offset = "0x5D89260", VA = "0x185D8A060")]
	public Vector3 PNAJPMBHMOG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x5D892A0", Offset = "0x5D884A0", VA = "0x185D892A0")]
	public void LDGAKMNPHNJ(in Vector3 ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x5D870D0", Offset = "0x5D862D0", VA = "0x185D870D0")]
	public Vector3 BKOKMDEEOJE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x5D86F90", Offset = "0x5D86190", VA = "0x185D86F90")]
	public void BEKMHPKJJDC(in Vector3 ACKOJNNBEBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface CEAGEKAKLML : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	JLNDDAGKPPB LCKLJFKANOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ObjectType LOCJBPCHEEP(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ObjectPrefabType IHNPFADNDGB(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JFGPOAFMNED(HEGAMEGFABK ODDHIKCHJNG, MGECINBKDNJ FIAGHIPJJMD);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AKCLBFIHGBC NPJDBGAGMPP(NGBBJMBOBME LDDMDOBAIIL, [Optional] object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HHFDKLDNADM(NGBBJMBOBME LDDMDOBAIIL, out MGECINBKDNJ FIAGHIPJJMD);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CKOKMKMAHJC(MGECINBKDNJ FIAGHIPJJMD);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HIFODIKFEMG(NGBBJMBOBME LDDMDOBAIIL, out Transform BDKBLCCDFEH);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KBEBBDFMBKM(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HHFEKKMKIFL(LocalId LDDMDOBAIIL, object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KMBHFDHHCEG(LocalId LDDMDOBAIIL, object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NGBBJMBOBME JOPDBPJBGEP(HEGAMEGFABK ODDHIKCHJNG);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HEGAMEGFABK AIJKBBFHHMJ(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FNPNPGNLNBE JOPDBPJBGEP(NativeArray<HEGAMEGFABK> ODDHIKCHJNG, Allocator IEOPKOGNAGJ);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FNPNPGNLNBE GGDHGEBAGLL(NativeArray<HEGAMEGFABK> ODDHIKCHJNG, NativeArray<KKLINMMKDFA> BCMPKEPAGKC, Allocator IEOPKOGNAGJ);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AKCLBFIHGBC JMIBOOIOGPP(ObjectPrefabType DDFDFJDKPLL, bool IBMCLFEHACP);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	AKCLBFIHGBC JMIBOOIOGPP(ObjectPrefabType DDFDFJDKPLL);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	AKCLBFIHGBC IHGAEOOJEBB(ObjectPrefabType DDFDFJDKPLL);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	AKCLBFIHGBC GGDHGEBAGLL(HEGAMEGFABK ODDHIKCHJNG, ObjectPrefabType DDFDFJDKPLL);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "19")]
	BGEGFFMEOEA FHGHIABIHEO();

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "20")]
	BHCPGPGNHFI OKFKEOHHGLE();

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "21")]
	HICJGPMMLFL FJNKBAGOBPM(PrimitiveShapeType OHOBKNLEHID);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NFKJPDBEMAO(FNPNPGNLNBE JILMJAIGHMF);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void DEAHKEFKGBN(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BNEAHFOADDJ(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void NFKJPDBEMAO(NGBBJMBOBME LDDMDOBAIIL);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "26")]
	FNPNPGNLNBE DBLHLAHPJHP(FNPNPGNLNBE LGIDJCBFMIL, Allocator IEOPKOGNAGJ);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool KMMKKFEGNCC(NGBBJMBOBME LDDMDOBAIIL);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class ICAPEEIMCAJ
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5D81C20", Offset = "0x5D80E20", VA = "0x185D81C20")]
	public static AKCLBFIHGBC JBHNBHAABKA(this CEAGEKAKLML EBMPGEPOMDE, LocalId LDDMDOBAIIL)
	{
		return default(AKCLBFIHGBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5D81CD0", Offset = "0x5D80ED0", VA = "0x185D81CD0")]
	public static NGBBJMBOBME JOPDBPJBGEP(this CEAGEKAKLML EBMPGEPOMDE, LocalId LDDMDOBAIIL)
	{
		return default(NGBBJMBOBME);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5D81680", Offset = "0x5D80880", VA = "0x185D81680")]
	public static HEGAMEGFABK AIJKBBFHHMJ(this CEAGEKAKLML EBMPGEPOMDE, LocalId LDDMDOBAIIL)
	{
		return default(HEGAMEGFABK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5D81CF0", Offset = "0x5D80EF0", VA = "0x185D81CF0")]
	public static bool KMMKKFEGNCC(this CEAGEKAKLML EBMPGEPOMDE, HEGAMEGFABK ODDHIKCHJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x268A100", Offset = "0x2689300", VA = "0x18268A100")]
	public static T HINAFKFCFOF<T>(this CEAGEKAKLML EBMPGEPOMDE, LocalId LDDMDOBAIIL) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5D81F90", Offset = "0x5D81190", VA = "0x185D81F90")]
	public static BGEGFFMEOEA PGMJCNOEEHB(this CEAGEKAKLML EBMPGEPOMDE, RigidTransform KEECHNKDOCM, [Optional] object IBIKCCMDMHA)
	{
		return default(BGEGFFMEOEA);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5D81AD0", Offset = "0x5D80CD0", VA = "0x185D81AD0")]
	public static HICJGPMMLFL FMPKMNDCMKK(this CEAGEKAKLML EBMPGEPOMDE, PrimitiveShapeType KEDCKBODIDI, RigidTransform KEECHNKDOCM, [Optional] object IBIKCCMDMHA)
	{
		return default(HICJGPMMLFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5D81E40", Offset = "0x5D81040", VA = "0x185D81E40")]
	public static BHCPGPGNHFI MCNFOJILAOE(this CEAGEKAKLML EBMPGEPOMDE, RigidTransform KEECHNKDOCM, [Optional] object IBIKCCMDMHA)
	{
		return default(BHCPGPGNHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5D817A0", Offset = "0x5D809A0", VA = "0x185D817A0")]
	private static void BFOFCDDOMGB(AKCLBFIHGBC HAOLMMHODNH, RigidTransform KEECHNKDOCM, [Optional] object IBIKCCMDMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5D818C0", Offset = "0x5D80AC0", VA = "0x185D818C0")]
	internal static NDHJDCFCHBC EMEPJHBJPCL(this CEAGEKAKLML EBMPGEPOMDE, PDABLEGONNF BAANAPFALHJ, [Optional] object IBIKCCMDMHA)
	{
		return default(NDHJDCFCHBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal static class NIFKDIEPDOB
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5D86D40", Offset = "0x5D85F40", VA = "0x185D86D40")]
	public static GOFOAABNBIC KBDCDOFELIM(this NGBBJMBOBME OOLLEDEIDOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D86C90", Offset = "0x5D85E90", VA = "0x185D86C90")]
	public static EntityManager GLHEACEJGGD(this NGBBJMBOBME OOLLEDEIDOE)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x2FE7FC0", Offset = "0x2FE71C0", VA = "0x182FE7FC0")]
	public static T IEHODMHIBOE<T>(this NGBBJMBOBME OOLLEDEIDOE) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x2FE93F0", Offset = "0x2FE85F0", VA = "0x182FE93F0")]
	public static bool LMGCFADFPPC<T>(this NGBBJMBOBME OOLLEDEIDOE) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
internal interface FKDILKFBMOH
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event AANPFNEFCKN.FFOFKCMCGBH LAGAPBMDJEH;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[ANLCMDHKMHN(GPIAMNEIDDC.LoadInstance)]
public interface MEMNMHGIDMM
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	bool BFDEIIDIBLD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	NGBBJMBOBME OBIOELFKFFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	AKCLBFIHGBC PCOLGOCICBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	AKCLBFIHGBC AHAGFNKAEPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event FFFHJGPBFHG OCEDJNOPAMC;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NGBBJMBOBME PLPAEAMNHKA(NGBBJMBOBME JOGKKCDJIND, NGBBJMBOBME DOPPPNLMLFP);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JDBHDGNCDKG(NGBBJMBOBME JOGKKCDJIND, NGBBJMBOBME DOPPPNLMLFP, out NGBBJMBOBME GFNMBJLLAGG);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FMJICJONNBL();

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JBEIKKLHEKI();

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool HOFJBKCGLBL(NGBBJMBOBME PDDCMNAKECC);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public delegate void FFFHJGPBFHG(AKCLBFIHGBC MDDBHMNFPOF, AKCLBFIHGBC BNJCALAONPD);
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class HLPJKEBCBLC
{
	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5D81100", Offset = "0x5D80300", VA = "0x185D81100")]
	public static bool FCJIFHGGDFB(this MEMNMHGIDMM INADCDCCNKB, AKCLBFIHGBC PDDCMNAKECC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5D81190", Offset = "0x5D80390", VA = "0x185D81190")]
	public static bool FMGGPDBIFDI(this MEMNMHGIDMM INADCDCCNKB, NGBBJMBOBME PDDCMNAKECC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5D81530", Offset = "0x5D80730", VA = "0x185D81530")]
	public static bool NCEOIHCJLAG(this MEMNMHGIDMM INADCDCCNKB, NGBBJMBOBME PDDCMNAKECC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[DefaultMember("Item")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface JKCECAJIEIJ : IEnumerable<IBGGDEIKCDF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	IBGGDEIKCDF LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IBGGDEIKCDF AIEJPNBDMBP(GFNBJKOODOI LPBMDNNGIOI);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NGGANMPEPOM AHFDFLNGHDK(GFNBJKOODOI LPBMDNNGIOI);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class ONEMCKCMAML
{
	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x2EA43A0", Offset = "0x2EA35A0", VA = "0x182EA43A0")]
	public static HJDPKHDBJJM<T> AIEJPNBDMBP<T>(this JKCECAJIEIJ MDEOLPGKLLA, GFNBJKOODOI PCKMHBLNCII) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x2EA44C0", Offset = "0x2EA36C0", VA = "0x182EA44C0")]
	public static HJDPKHDBJJM<T> AIEJPNBDMBP<T>(this JKCECAJIEIJ MDEOLPGKLLA, FPAOGPJBAPF<T> PCKMHBLNCII) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2EA42B0", Offset = "0x2EA34B0", VA = "0x182EA42B0")]
	public static NGGANMPEPOM AHFDFLNGHDK<T>(this JKCECAJIEIJ MDEOLPGKLLA, FPAOGPJBAPF<T> PCKMHBLNCII) where T : struct
	{
		return default(NGGANMPEPOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface MMGFPFPCOFJ : PPDAOGDLOGH
{
	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ECOOEMKNFFA BEKEMOKDPJG(Entity FADPOFMJIJF);

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDMCHCAINGD(NativeArray<ECOOEMKNFFA> BJPHGHDJEIG, NativeArray<IDEMOMEEACM> NNBJBMNKACK);

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ANIHLHAHEHO(ECOOEMKNFFA CPJGFEGBDOF);

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EEJLEBPJAKF(ECOOEMKNFFA CPJGFEGBDOF, out Collider JHGJKCLNOFL);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct IDEMOMEEACM : ISystemStateComponentData, IComponentData, IEquatable<IDEMOMEEACM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float3 EEKPJIDHLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 PHNMLAKJJKC;

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x15AE8F0", Offset = "0x15ADAF0", VA = "0x1815AE8F0", Slot = "4")]
	public bool Equals(IDEMOMEEACM HPOECFLNEOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct JGLKPOOCMBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Guid CNDCJIFNLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public string LOPGCKODAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Vector3 FNDKHLEFPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Quaternion AAECNILGNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Vector3 DNJLOGOEKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public int CMJDLKPFHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Dictionary<string, object> OGEINKONADM;

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x5D82BA0", Offset = "0x5D81DA0", VA = "0x185D82BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x5D82A10", Offset = "0x5D81C10", VA = "0x185D82A10")]
	private static string JCGEPKDFKMM(Dictionary<string, object> NLCGADBFNFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public enum GDIAFCFNNBJ
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public enum AAEAHOHKCIP
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class BCPCAPDAIIK
{
	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0xCB63D0", Offset = "0xCB55D0", VA = "0x180CB63D0")]
	public static bool HONDOAIIKKH(this AAEAHOHKCIP JAACLLLIGMF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public interface BFJOLEIBDPE : CDIMBHIJGCF, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[Flags]
public enum NAMDLHJFMGI
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
public enum FNMPAJIJFOF
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
public interface FPANIHEBNCJ : CDIMBHIJGCF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	KMNAFGNFHKA NFKJMBOGCBE
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ONDGBMOLAPF();

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPEGADPIOHJ();
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public interface KMNAFGNFHKA
{
	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHCABPKFADI(Guid KDAGJHGAEFN, out Guid BLDOOIAGGHO);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface KOGJHKDHONI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	MBCPCHPHCAL LLDHKFJAACN
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString KBAMJNAOHLD();
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface CDIMBHIJGCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	IEnumerable<JGLKPOOCMBP> OIHCFMMOOBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	GAIFPCNJIAL COPLABLIEDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	LocalId FNKCLICJLLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	MBCPCHPHCAL PGCJGDFCDMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	Task ABPGIBHEIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AGDCFCDLKJK(NAMDLHJFMGI DJOGFGHOKNN);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface JBCADBKIPAE
{
	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDLACCBNNJK(HEGAMEGFABK ADJJHANDJPJ, NGGANMPEPOM FNPJNJDJLAF, ReadOnlySpan<byte> AOBIKELFAKB, ReadOnlySpan<byte> ILKGPGKAKFF);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CNBHFCDELEC(HEGAMEGFABK ADJJHANDJPJ, NGGANMPEPOM FNPJNJDJLAF);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AJMOKCENLNN(HEGAMEGFABK ADJJHANDJPJ, NGGANMPEPOM FNPJNJDJLAF, ReadOnlySpan<byte> ILKGPGKAKFF);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JJKOIGMIAJO(HEGAMEGFABK ADJJHANDJPJ, NGGANMPEPOM FNPJNJDJLAF, Span<byte> AOBIKELFAKB, Span<byte> ILKGPGKAKFF);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class AEJKHNICEAB
{
	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4F70", Offset = "0x2AE4170", VA = "0x182AE4F70")]
	public static bool JJKOIGMIAJO<T>(this JBCADBKIPAE JJAKMLBONGG, HEGAMEGFABK ADJJHANDJPJ, NGGANMPEPOM FNPJNJDJLAF, out T AOBIKELFAKB, out T ILKGPGKAKFF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4E50", Offset = "0x2AE4050", VA = "0x182AE4E50")]
	public static bool AJMOKCENLNN<T>(this JBCADBKIPAE JJAKMLBONGG, HEGAMEGFABK ADJJHANDJPJ, NGGANMPEPOM FNPJNJDJLAF, T ILKGPGKAKFF) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public enum HHFBHFKBEAF
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
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface HIBNGIALBBP : AHIHALOAKED<HIBNGIALBBP>
{
	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NGGANMPEPOM AHFDFLNGHDK(GFNBJKOODOI PCKMHBLNCII);

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFGPOAFMNED(NGGANMPEPOM OOLLEDEIDOE, JMHBPPMMBNG JAPFELDGLEP);

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IDJOIMMOOEO(NGGANMPEPOM OOLLEDEIDOE, out JMHBPPMMBNG JAPFELDGLEP);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class JGBAOFOCDDK
{
	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x298E540", Offset = "0x298D740", VA = "0x18298E540")]
	public static NGGANMPEPOM AHFDFLNGHDK<T>(this HIBNGIALBBP MDEOLPGKLLA, FPAOGPJBAPF<T> PCKMHBLNCII)
	{
		return default(NGGANMPEPOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	public static NGGANMPEPOM JFGPOAFMNED<T>(this HIBNGIALBBP MDEOLPGKLLA, FPAOGPJBAPF<T> PCKMHBLNCII, JMHBPPMMBNG JAPFELDGLEP) where T : struct
	{
		return default(NGGANMPEPOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface KHHCHIBJFAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	uint ODCAEEBCIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct GBAEDGGLNGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public PLLBNEENLNN PHDPIMPEHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public ReadOnlyMemory<byte> DGLHFPEOHIM;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface AFAJHLJLKAD
{
	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KGFEHANPDBG(PLLBNEENLNN PHDPIMPEHFJ, ReadOnlySpan<byte> DGLHFPEOHIM);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public delegate bool GADBPOMIJLC(JBCADBKIPAE LOHOJDBNFGJ, in GMFPPNNBHJB ACKOJNNBEBO);
[Cpp2IlInjected.Token(Token = "0x2000096")]
public delegate bool CNEHIDBKABJ<T>(JBCADBKIPAE LOHOJDBNFGJ, in T ACKOJNNBEBO);
[Cpp2IlInjected.Token(Token = "0x2000097")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface NNINLNLFDJK
{
	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFGPOAFMNED(NGGANMPEPOM FNPJNJDJLAF, Type HHCMCPKGLMN, GADBPOMIJLC ICFGFNGCHJG);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FDFCGLMIPKL(NGGANMPEPOM FNPJNJDJLAF, out GADBPOMIJLC ICFGFNGCHJG);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class EDEDKBDDMED
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class FBJHLFEPMDO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public CNEHIDBKABJ<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public FBJHLFEPMDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x1CCF750", Offset = "0x1CCE950", VA = "0x181CCF750")]
		internal bool PDPCBDJGEJD(JBCADBKIPAE pendingList, in GMFPPNNBHJB value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x33C06A0", Offset = "0x33BF8A0", VA = "0x1833C06A0")]
	public static void JFGPOAFMNED<T>(this NNINLNLFDJK FLCEELNBPDO, NGGANMPEPOM FNPJNJDJLAF, CNEHIDBKABJ<T> ICFGFNGCHJG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5D7D8D0", Offset = "0x5D7CAD0", VA = "0x185D7D8D0")]
	public static bool KHALMNNAIGK(this NNINLNLFDJK FLCEELNBPDO, JBCADBKIPAE LOHOJDBNFGJ, NGGANMPEPOM FNPJNJDJLAF, in GMFPPNNBHJB ACKOJNNBEBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct PLLBNEENLNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public uint OGFMHCMJMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int JINEJACLFPN;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x86FF80", Offset = "0x86F180", VA = "0x18086FF80")]
	public PLLBNEENLNN(uint OGFMHCMJMHE, int JINEJACLFPN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5D8A450", Offset = "0x5D89650", VA = "0x185D8A450")]
	public static bool JGKKLLGINAK(in PLLBNEENLNN JFHIJPMPOBA, in PLLBNEENLNN LPNFMADJDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x5D8A390", Offset = "0x5D89590", VA = "0x185D8A390", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5D8A420", Offset = "0x5D89620", VA = "0x185D8A420", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x5D8A470", Offset = "0x5D89670", VA = "0x185D8A470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface FCABEPBMOKB
{
	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PLLBNEENLNN LBLCDDMKLIA(ReadOnlySpan<byte> DGLHFPEOHIM);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public interface JMHBPPMMBNG
{
	[Cpp2IlInjected.Token(Token = "0x17000135")]
	Type DDBNNJCGINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKLCAJOKCCK(ref GGBOLLKFPNF GFNCLDNPAIL, Span<byte> PDDCMNAKECC);

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IOEANABOGCL(ref GNKKHBAMNEA CGGGDFDBEPL, ReadOnlySpan<byte> PHDPIMPEHFJ);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class BNPNCANKMBN
{
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public delegate void NPPKKMOPIFJ(PLLBNEENLNN PPNIGBBPGOI, ReadOnlySpan<byte> DGLHFPEOHIM);
[Cpp2IlInjected.Token(Token = "0x200009F")]
[ANLCMDHKMHN(GPIAMNEIDDC.OMRoom)]
public interface MDBLLAGJGOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KPOGOECCEAF(PLLBNEENLNN PPNIGBBPGOI, ReadOnlySpan<byte> DGLHFPEOHIM);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
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
