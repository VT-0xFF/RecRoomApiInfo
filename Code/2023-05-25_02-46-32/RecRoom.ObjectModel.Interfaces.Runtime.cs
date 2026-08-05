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
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
public interface FPDHDDILPLF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DLJICHMMDCK(in float3 OEBPJEAOOED, in float3 AGOGLFBBBLL, float LHLJEFHGAPL, Allocator FKPADLBILGP, out NativeArray<Entity> FPMGLBFKKPO);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[IHCFIENIHKO(JBOAFHDNBDO.Application)]
public interface JPGLBJDGEAP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Guid PJIOKECKKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNMILIBGPKJ(Guid MLJNOOHEBBO, Guid CCBHOBAKLOB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JOFMNHCINIK(ICDDKLLCIME EMLECGAOFGF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HPJPKKCENDM : global::BADCGGCOPPF<ICDDKLLCIME>, BEOGCACODJA, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EJDCIEBOMOK<T> : global::DNKKAPAMMED<ICDDKLLCIME, T>, global::BADCGGCOPPF<ICDDKLLCIME>, BEOGCACODJA, IDisposable, HPJPKKCENDM where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class IMHCHHEJKAC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x243AE30", Offset = "0x2439630", VA = "0x18243AE30")]
	public static T PNBJHLBKMLC<T>(this global::BADCGGCOPPF<ICDDKLLCIME> PIKMJGOIABL, ICDDKLLCIME EEOIFMPKINO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x243AE00", Offset = "0x2439600", VA = "0x18243AE00")]
	public static bool OLBGCODNBJK<T>(this global::BADCGGCOPPF<ICDDKLLCIME> PIKMJGOIABL, ICDDKLLCIME EEOIFMPKINO, in T PHMLIFLNFDO) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
public interface EMBNMLHIGII
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Func<KLLLAPPONHC> IHBCJHMOECJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<ICDDKLLCIME, ICDDKLLCIME> HJJPMCPHAJA;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<ICDDKLLCIME, ICDDKLLCIME> IIFOGBACNHG;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<ICDDKLLCIME, ICDDKLLCIME, ICDDKLLCIME> BHDOFGIKEPK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<ICDDKLLCIME> FEHEECMGNGH;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color ANHCEOFIPPJ(ICDDKLLCIME EEOIFMPKINO, int DFGAJGNKDIG);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float3 GNAJCIIILFJ(ICDDKLLCIME EEOIFMPKINO, int DFGAJGNKDIG);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool AJPDKPDLGDN(ICDDKLLCIME EEOIFMPKINO, ICDDKLLCIME NJFBFFHEIKP);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ICDDKLLCIME BILLHCGKMAH(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<ICDDKLLCIME> CHOIGDIFLOA(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ICDDKLLCIME IGDKJJGOCFK(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LDOPNHOGJAC(ICDDKLLCIME EEOIFMPKINO, Vector3 BPDHGCAGALH, Quaternion IHJIONPHOFA);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CMHBGLJNCGC(ICDDKLLCIME EEOIFMPKINO, float EGHKKPPIJGN);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool MKLIIIHGBHK(ICDDKLLCIME EEOIFMPKINO, out RigidTransform KBKIOKFBBLG);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool IKLKIHCJLEO(ICDDKLLCIME EEOIFMPKINO, out float FAICKAKEFBL);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 NEKKJBFKDIP(PGHELANFAGH FJCCCDLAFFJ);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	quaternion GJEFLCIIEEE(PGHELANFAGH FJCCCDLAFFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LDANOLCAMFG
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
public interface BEBFJHMFKLN
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLJICHMMDCK(in NativeArray<Entity> FPMGLBFKKPO, in float3 OEBPJEAOOED, in float3 AGOGLFBBBLL, in NativeArray<OBOFCBCJCMB> FJLPJENJKHE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
public interface GDABAFHKPJF
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DAMCFGEHNND(ICDDKLLCIME CMPMKFMJCNO, bool ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBGFHGHGAOK(ICDDKLLCIME CMPMKFMJCNO, bool ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DFENNHHEJCN(ICDDKLLCIME CMPMKFMJCNO, int ECNGHFJBIJL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
[DefaultMember("Item")]
public interface NNOFJALKEBE : IEnumerable<DAEIOAAPCOE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	NativeBitArray CCFBDPPBCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NativeArray<int> ABEBFCHLAND
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	DAEIOAAPCOE OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	DAEIOAAPCOE OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DAEIOAAPCOE AEFCPPJIBAA(GGIKBJPJGCF OHNDBNDIBPN);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PIGHOFHDBAG NOPLKMAJKCL(GGIKBJPJGCF OHNDBNDIBPN);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LOLOOAKCDBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public static global::OMNMPKLMELI<T> AEFCPPJIBAA<T>(this NNOFJALKEBE JEADDOCNIGI, GGIKBJPJGCF BPOKAAOBIOI) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct AIPBJAFJBJE : IEquatable<AIPBJAFJBJE>
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly AIPBJAFJBJE CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2605F30", Offset = "0x2604730", VA = "0x182605F30")]
	public AIPBJAFJBJE(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E14E50", Offset = "0x5E13650", VA = "0x185E14E50", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(AIPBJAFJBJE MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct GHOCBJOADLO : IEquatable<GHOCBJOADLO>
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly GHOCBJOADLO CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BF60", Offset = "0x5E1A760", VA = "0x185E1BF60", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(GHOCBJOADLO MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
public interface MDDEFLMOBIG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	PHHBANFODAP NBBABPBDNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BJBAJMOJEGK(CDGEIPMFEMD JDOPKGLAEGH, PIGHOFHDBAG PIKMJGOIABL);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GLKAOPCBPJI(CDGEIPMFEMD JDOPKGLAEGH, Span<PIGHOFHDBAG> JEADDOCNIGI, bool DJPKDLKDHOL);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPDAEKPGDIK(NativeArray<CDGEIPMFEMD> IFLIGDCMCFD);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct PHHBANFODAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NativeBitArray BPECLKGIDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly NativeHashMap<CDGEIPMFEMD, int> FENILIAPMNK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool GOEJILIBOLA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5E24D70", Offset = "0x5E23570", VA = "0x185E24D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x83CCB0", Offset = "0x83B4B0", VA = "0x18083CCB0")]
	public PHHBANFODAP(NativeBitArray BPECLKGIDBL, NativeHashMap<CDGEIPMFEMD, int> FENILIAPMNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E24C80", Offset = "0x5E23480", VA = "0x185E24C80")]
	public bool BJBAJMOJEGK(CDGEIPMFEMD JDOPKGLAEGH, PIGHOFHDBAG PIKMJGOIABL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EEOHNIMPJNH
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct GIFDOKMCBBO : IECEDPLHPPC, IEquatable<GIFDOKMCBBO>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly GIFDOKMCBBO CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GameObject ALBKEDBKENG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C7B0", Offset = "0x5E1AFB0", VA = "0x185E1C7B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public CDGEIPMFEMD CBNEEDBFGCE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CC30", Offset = "0x5E1B430", VA = "0x185E1CC30")]
		get
		{
			return default(CDGEIPMFEMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ObjectType ANGCMKNONOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C370", Offset = "0x5E1AB70", VA = "0x185E1C370")]
		get
		{
			return default(ObjectType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ObjectPrefabType PAOIPAINFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C540", Offset = "0x5E1AD40", VA = "0x185E1C540")]
		get
		{
			return default(ObjectPrefabType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool JOIJACEABBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C9B0", Offset = "0x5E1B1B0", VA = "0x185E1C9B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool GLNJEIDKHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CB10", Offset = "0x5E1B310", VA = "0x185E1CB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool LGGHMKNAHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CB30", Offset = "0x5E1B330", VA = "0x185E1CB30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool MHIAFNAPCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CC10", Offset = "0x5E1B410", VA = "0x185E1CC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool DJOAMMMCHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CAF0", Offset = "0x5E1B2F0", VA = "0x185E1CAF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool PECNBACBKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C740", Offset = "0x5E1AF40", VA = "0x185E1C740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool CBICPFHLFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CB50", Offset = "0x5E1B350", VA = "0x185E1CB50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool NEMFBCJCLAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C8B0", Offset = "0x5E1B0B0", VA = "0x185E1C8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ODFPCDMIBJD HHKJBOADFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(ODFPCDMIBJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public EOCJMOMDIND NAHCIKFJFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(EOCJMOMDIND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public OMGAEGFFOLF FAKNHMMOKCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(OMGAEGFFOLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public LNCMPMBNNIA FDLEOFPGCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(LNCMPMBNNIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CNJGLDLLEKL OOGAJJPIFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(CNJGLDLLEKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public BABNJLIFDFI CFBBIJKEJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(BABNJLIFDFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AIKKDGLDNIM MFCNBHJBFGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(AIKKDGLDNIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool JNJCDBENOFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C2A0", Offset = "0x5E1AAA0", VA = "0x185E1C2A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool MOABHDBCPLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C760", Offset = "0x5E1AF60", VA = "0x185E1C760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private bool NFPHJEDJIJA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x811740", Offset = "0x80FF40", VA = "0x180811740", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public ICDDKLLCIME DMBBBMNOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1118590", Offset = "0x1116D90", VA = "0x181118590", Slot = "5")]
		get
		{
			return default(ICDDKLLCIME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public DFGOKJHLIDD ELJOBKLNFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(DFGOKJHLIDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public JLNCECAFAMI AEAGMJDNIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(JLNCECAFAMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private LAFFONHEJBA AFFOFIDANDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AA640", VA = "0x1808ABE40")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
	public static GIFDOKMCBBO DGIADCHILCD(ICDDKLLCIME CMPMKFMJCNO)
	{
		return default(GIFDOKMCBBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CD00", Offset = "0x5E1B500", VA = "0x185E1CD00")]
	public EIEAAJJDDLF OCPPIEIFCBC()
	{
		return default(EIEAAJJDDLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C9D0", Offset = "0x5E1B1D0", VA = "0x185E1C9D0")]
	public GMPKEDCGJIK JMPJOHAFEIG()
	{
		return default(GMPKEDCGJIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C0A0", Offset = "0x5E1A8A0", VA = "0x185E1C0A0")]
	public AIPBJAFJBJE AAAIPKJJFCD()
	{
		return default(AIPBJAFJBJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CBA0", Offset = "0x5E1B3A0", VA = "0x185E1CBA0")]
	public CJPMNHIGLLL MMADHKNONKK()
	{
		return default(CJPMNHIGLLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C610", Offset = "0x5E1AE10", VA = "0x185E1C610")]
	public PGHELANFAGH FHMLMLCJOHK()
	{
		return default(PGHELANFAGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C8D0", Offset = "0x5E1B0D0", VA = "0x185E1C8D0")]
	public void JEHGHPAKPDB([Optional] object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CA40", Offset = "0x5E1B240", VA = "0x185E1CA40")]
	public bool KACMHADCANK(object FLDJLPKNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C110", Offset = "0x5E1A910", VA = "0x185E1C110")]
	public bool AMMCCEDBMFC(object FLDJLPKNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CD90", Offset = "0x5E1B590", VA = "0x185E1CD90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2605F30", Offset = "0x2604730", VA = "0x182605F30")]
	public GIFDOKMCBBO(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5E15B90", Offset = "0x5E14390", VA = "0x185E15B90")]
	public static bool DGIADCHILCD(GIFDOKMCBBO ECNGHFJBIJL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1118590", Offset = "0x1116D90", VA = "0x181118590")]
	public static ICDDKLLCIME DGIADCHILCD(GIFDOKMCBBO ECNGHFJBIJL)
	{
		return default(ICDDKLLCIME);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C6A0", Offset = "0x5E1AEA0", VA = "0x185E1C6A0")]
	public static bool FMMDKFLNNFA(GIFDOKMCBBO NBLDAOBEAEA, GIFDOKMCBBO PAJLLFKCBBD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C1C0", Offset = "0x5E1A9C0", VA = "0x185E1C1C0")]
	public static bool BDPOAMCDIDB(GIFDOKMCBBO NBLDAOBEAEA, GIFDOKMCBBO PAJLLFKCBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C440", Offset = "0x5E1AC40", VA = "0x185E1C440", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "6")]
	public bool Equals(GIFDOKMCBBO MDHJAFNLPON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate void ANIKAIHDNIF(ICDDKLLCIME EEOIFMPKINO, PIGHOFHDBAG AOGGNHKFEEF, CCENOJCALNE OFDNJFOOJOA, CCENOJCALNE MEKEHDPAILC);
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public struct OKDELJEJJGI : IList<ICDDKLLCIME>, ICollection<ICDDKLLCIME>, IEnumerable<ICDDKLLCIME>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct NDHJOBMIPIB : IEnumerator<ICDDKLLCIME>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly LAFFONHEJBA OJBDJOANLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private NativeArray<LocalId>.Enumerator ILKMAKIEBIF;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public ICDDKLLCIME NIBFGHDNPCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5E21AD0", Offset = "0x5E202D0", VA = "0x185E21AD0", Slot = "4")]
			get
			{
				return default(ICDDKLLCIME);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5E219F0", Offset = "0x5E201F0", VA = "0x185E219F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x231BF40", Offset = "0x231A740", VA = "0x18231BF40")]
		public NDHJOBMIPIB(LAFFONHEJBA OJBDJOANLPJ, NativeArray<LocalId>.Enumerator ILKMAKIEBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5E21930", Offset = "0x5E20130", VA = "0x185E21930", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5E21970", Offset = "0x5E20170", VA = "0x185E21970", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5E219B0", Offset = "0x5E201B0", VA = "0x185E219B0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly LAFFONHEJBA OJBDJOANLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private NativeList<LocalId> NJHLKKCLMGI;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public ICDDKLLCIME OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5E24170", Offset = "0x5E22970", VA = "0x185E24170", Slot = "4")]
		get
		{
			return default(ICDDKLLCIME);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5E241F0", Offset = "0x5E229F0", VA = "0x185E241F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E23DE0", Offset = "0x5E225E0", VA = "0x185E23DE0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int PJKEDAIIMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5E23DE0", Offset = "0x5E225E0", VA = "0x185E23DE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool JKOPFKMGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x80D0A0", Offset = "0x80B8A0", VA = "0x18080D0A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5E240E0", Offset = "0x5E228E0", VA = "0x185E240E0")]
	public OKDELJEJJGI(LAFFONHEJBA OJBDJOANLPJ, int HLPFAIAMMGH, Allocator FKPADLBILGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5E23CD0", Offset = "0x5E224D0", VA = "0x185E23CD0")]
	public MEDIMOPGJCH KJMGAIJPOJH()
	{
		return default(MEDIMOPGJCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5E23940", Offset = "0x5E22140", VA = "0x185E23940", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5E23980", Offset = "0x5E22180", VA = "0x185E23980", Slot = "13")]
	public bool Contains(ICDDKLLCIME FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5E239E0", Offset = "0x5E221E0", VA = "0x185E239E0", Slot = "14")]
	public void CopyTo(ICDDKLLCIME[] EABDNHJFDCB, int KHLMLDANMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5E238E0", Offset = "0x5E220E0", VA = "0x185E238E0", Slot = "11")]
	public void Add(ICDDKLLCIME FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5E23C50", Offset = "0x5E22450", VA = "0x185E23C50", Slot = "7")]
	public void Insert(int NHHNPPKPBIA, ICDDKLLCIME FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5E23E70", Offset = "0x5E22670", VA = "0x185E23E70", Slot = "15")]
	public bool Remove(ICDDKLLCIME FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5E23BF0", Offset = "0x5E223F0", VA = "0x185E23BF0", Slot = "6")]
	public int IndexOf(ICDDKLLCIME FHJBBMIILLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E23E20", Offset = "0x5E22620", VA = "0x185E23E20", Slot = "8")]
	public void RemoveAt(int NHHNPPKPBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5E23BB0", Offset = "0x5E223B0", VA = "0x185E23BB0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5E23D50", Offset = "0x5E22550", VA = "0x185E23D50")]
	public NDHJOBMIPIB MEOEHOBEEMI()
	{
		return default(NDHJOBMIPIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E23F00", Offset = "0x5E22700", VA = "0x185E23F00", Slot = "16")]
	private IEnumerator<ICDDKLLCIME> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E23FF0", Offset = "0x5E227F0", VA = "0x185E23FF0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
public interface GKNDABFCLBP
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DLJICHMMDCK(in float3 OEBPJEAOOED, in float3 AGOGLFBBBLL, float LHLJEFHGAPL, out OBOFCBCJCMB DANCKKJHDAJ, out ICDDKLLCIME NAKLMJDMHGM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public readonly struct NHKGALFBHLM : IEquatable<NHKGALFBHLM>
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly NHKGALFBHLM CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private JBJOCJBPPOP FDCMCBGJOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5E22930", Offset = "0x5E21130", VA = "0x185E22930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GMPKEDCGJIK DHNGAIKGDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GMPKEDCGJIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public BHKMKIAFEBP BHBNLFGFOEH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5E21D60", Offset = "0x5E20560", VA = "0x185E21D60")]
		get
		{
			return default(BHKMKIAFEBP);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5E21F90", Offset = "0x5E20790", VA = "0x185E21F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IEnumerable<GNGJAGJHOHA> BJGGDJFKMNH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5E22440", Offset = "0x5E20C40", VA = "0x185E22440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public GNGJAGJHOHA OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5E22090", Offset = "0x5E20890", VA = "0x185E22090")]
		get
		{
			return default(GNGJAGJHOHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5E22620", Offset = "0x5E20E20", VA = "0x185E22620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ICDDKLLCIME DMBBBMNOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1118590", Offset = "0x1116D90", VA = "0x181118590")]
		get
		{
			return default(ICDDKLLCIME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public DFGOKJHLIDD ELJOBKLNFLH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(DFGOKJHLIDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private LAFFONHEJBA AFFOFIDANDN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AA640", VA = "0x1808ABE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private IBBOOHDJAGI DJFECEFGDAL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5E21E60", Offset = "0x5E20660", VA = "0x185E21E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5E21B40", Offset = "0x5E20340", VA = "0x185E21B40")]
	public GNGJAGJHOHA ADDKFANBCHM(float3? NABPHMOHNDG, [Optional] quaternion? KDPJNNPKKHC, [Optional] Vector3? KACNEPKNFIL)
	{
		return default(GNGJAGJHOHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5E22700", Offset = "0x5E20F00", VA = "0x185E22700")]
	public GNGJAGJHOHA MMNMFEDDBCK(int NHHNPPKPBIA, float3? NABPHMOHNDG, [Optional] quaternion? KDPJNNPKKHC, [Optional] Vector3? KACNEPKNFIL)
	{
		return default(GNGJAGJHOHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5E222B0", Offset = "0x5E20AB0", VA = "0x185E222B0")]
	public void FLLDAADPLON(int NHHNPPKPBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5E21EB0", Offset = "0x5E206B0", VA = "0x185E21EB0")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2605F30", Offset = "0x2604730", VA = "0x182605F30")]
	public NHKGALFBHLM(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5E15B90", Offset = "0x5E14390", VA = "0x185E15B90")]
	public static bool DGIADCHILCD(NHKGALFBHLM ECNGHFJBIJL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5E223A0", Offset = "0x5E20BA0", VA = "0x185E223A0")]
	public static bool FMMDKFLNNFA(NHKGALFBHLM NBLDAOBEAEA, NHKGALFBHLM PAJLLFKCBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5E221B0", Offset = "0x5E209B0", VA = "0x185E221B0", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(NHKGALFBHLM MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
public interface BIADMEAMBOH
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IECEEBAGAAB(ICDDKLLCIME EEOIFMPKINO, out Collider JNLMKMJDNIN);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject JHCOHLIDGMA(ICDDKLLCIME OCANHEMMPOP, GameObject OGIDMIHPCNI, Vector3 CLLBFIHFGKG, Quaternion ANNMEOBLHIJ);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LCFGJKDELMO(GameObject JNLMKMJDNIN);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider LIPNMPDOJHB<TCollider>(GameObject OHGLGONNIBJ) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OAFGPHOIJPN(Collider JNLMKMJDNIN);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject MKHEPLPANKO<TCollider>(string BPOKAAOBIOI) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface IBCDCMBPNAD : global::BADCGGCOPPF<CDGEIPMFEMD>, BEOGCACODJA, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface OMHCKOEHOFD<T> : global::DNKKAPAMMED<CDGEIPMFEMD, T>, global::BADCGGCOPPF<CDGEIPMFEMD>, BEOGCACODJA, IDisposable, IBCDCMBPNAD where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class IPBOHJBBABG
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x243B5C0", Offset = "0x2439DC0", VA = "0x18243B5C0")]
	public static bool PFLIDDOFNIB<T>(this global::BADCGGCOPPF<CDGEIPMFEMD> PIKMJGOIABL, CDGEIPMFEMD JDOPKGLAEGH, out T ECNGHFJBIJL) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x240E560", Offset = "0x240CD60", VA = "0x18240E560")]
	public static bool OLBGCODNBJK<T>(this global::BADCGGCOPPF<CDGEIPMFEMD> PIKMJGOIABL, CDGEIPMFEMD JDOPKGLAEGH, in T PHMLIFLNFDO) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct AIKKDGLDNIM : IEquatable<AIKKDGLDNIM>
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly AIKKDGLDNIM CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private BKCDCDNCEAB NCGDKJJLIHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5E14530", Offset = "0x5E12D30", VA = "0x185E14530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool CCIFFBJJNNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5E14750", Offset = "0x5E12F50", VA = "0x185E14750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Guid OBJFEABEMMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E14A00", Offset = "0x5E13200", VA = "0x185E14A00")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool LLACCPADIGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5E14AF0", Offset = "0x5E132F0", VA = "0x185E14AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Guid BJPHJBMNEPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BF0", Offset = "0x5E133F0", VA = "0x185E14BF0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public ICDDKLLCIME DMBBBMNOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1118590", Offset = "0x1116D90", VA = "0x181118590")]
		get
		{
			return default(ICDDKLLCIME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private LAFFONHEJBA AFFOFIDANDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AA640", VA = "0x1808ABE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private IBBOOHDJAGI DJFECEFGDAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5E14300", Offset = "0x5E12B00", VA = "0x185E14300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E14350", Offset = "0x5E12B50", VA = "0x185E14350")]
	public bool BJMBFKLKJEK(out Guid DJCGAIJIDMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E14440", Offset = "0x5E12C40", VA = "0x185E14440")]
	public void EJHNDLDJJNI(Guid FOHLJCNEPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E14830", Offset = "0x5E13030", VA = "0x185E14830")]
	public bool GJEMDGOEKHM(out Guid ENELKLKDEHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E14CE0", Offset = "0x5E134E0", VA = "0x185E14CE0")]
	public void MMJAMCKOILJ(Guid FOHLJCNEPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E14920", Offset = "0x5E13120", VA = "0x185E14920")]
	public void HGPBMDEFBKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2605F30", Offset = "0x2604730", VA = "0x182605F30")]
	public AIKKDGLDNIM(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E14650", Offset = "0x5E12E50", VA = "0x185E14650", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(AIKKDGLDNIM MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct EOCJMOMDIND : IEquatable<EOCJMOMDIND>
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly EOCJMOMDIND CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private LAFFONHEJBA AFFOFIDANDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AA640", VA = "0x1808ABE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BA10", Offset = "0x5E1A210", VA = "0x185E1BA10")]
	public void ENFMBIKBCAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B940", Offset = "0x5E1A140", VA = "0x185E1B940")]
	public void BMEOGFOJNDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2605F30", Offset = "0x2604730", VA = "0x182605F30")]
	public EOCJMOMDIND(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BAE0", Offset = "0x5E1A2E0", VA = "0x185E1BAE0", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(EOCJMOMDIND MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface FGNGMCGHDEA : IECEDPLHPPC
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	IJOJONFKPPA HEBLBEEIEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool BFFFKBIEAAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	GameObject ALBKEDBKENG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<FGNGMCGHDEA> NFCNEEDMPDK;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(FOIKBHKKGCK GPEEKLGBDDJ, ICDDKLLCIME GAIFIAHAMBG);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool NKEMCFNEFLN);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class OJKEFDDEKEP
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5E23770", Offset = "0x5E21F70", VA = "0x185E23770")]
	public static bool JNJCDBENOFM(this FGNGMCGHDEA FIMMEEPHPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E23680", Offset = "0x5E21E80", VA = "0x185E23680")]
	public static bool BONAOLCGLHA(this FGNGMCGHDEA FIMMEEPHPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E237C0", Offset = "0x5E21FC0", VA = "0x185E237C0")]
	public static bool LGBHADIEJKP(this FGNGMCGHDEA FIMMEEPHPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E236D0", Offset = "0x5E21ED0", VA = "0x185E236D0")]
	public static bool JHFNJCFMCPC(this FGNGMCGHDEA FIMMEEPHPII)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct EEIMAEIJCHC : IEquatable<EEIMAEIJCHC>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly EEIMAEIJCHC CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A8F0", Offset = "0x5E190F0", VA = "0x185E1A8F0", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(EEIMAEIJCHC MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
public interface MMFKIBONOEE
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGBJFJNGKCH(NativeListAsync<Entity> HKAHLOFDLJM);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OCLMPHJFLGF(FOBJCOEKDPN IDOFLCMGCDN);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IGNFBLODEOG(NativeListAsync<Entity> KLLNDLFNPJF, bool EAMCGOEJBFJ);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MAJFLELMEIK();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
public interface EOLOOHOOHOM
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CJNIIAGIKAN(ICDDKLLCIME EEOIFMPKINO, EGEPCBOCIHN ECNGHFJBIJL);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
public interface PJLGJHJEGKD
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DBGKOHGMKEH();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDCGPHBMFKK();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NPIKCBDGBAI();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OIKLFEILJLF();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PCDMKMCMPMN();

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JALHKIHAEKE();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MJPBKBMNGGP();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KIGJPEINOAI();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FHKCHKNNAGM();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KLCGALNJGAA();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FOKEHDDDMJO();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface GMBIPNIBCPJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	int OANFOEHCGGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> IIHFNCBLIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ICDDKLLCIME BPOHDKPFPNM(ICDDKLLCIME NJHLKKCLMGI);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BPOHDKPFPNM(int JFJPMGOFPHE);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface KNNBPJOHHBD : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct LNCMPMBNNIA : IEquatable<LNCMPMBNNIA>
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly LNCMPMBNNIA CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private IILIOKGAOHJ NMBDDPDJKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FAE0", Offset = "0x5E1E2E0", VA = "0x185E1FAE0")]
		get
		{
			return default(IILIOKGAOHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool IEPJHPNAPBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FB90", Offset = "0x5E1E390", VA = "0x185E1FB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool HHMDEAJJJNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5E20070", Offset = "0x5E1E870", VA = "0x185E20070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool DPECFHGOFPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5E20410", Offset = "0x5E1EC10", VA = "0x185E20410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool AKFJEIIMGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FA00", Offset = "0x5E1E200", VA = "0x185E1FA00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool KGCPABEAPMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5E20250", Offset = "0x5E1EA50", VA = "0x185E20250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool JJILNONHCNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FA70", Offset = "0x5E1E270", VA = "0x185E1FA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool AJDHJFENABA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E20000", Offset = "0x5E1E800", VA = "0x185E20000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool HMAGBKIHIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FF00", Offset = "0x5E1E700", VA = "0x185E1FF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool LBLPBLOBGNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5E20330", Offset = "0x5E1EB30", VA = "0x185E20330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool NLMINLJCHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5E200E0", Offset = "0x5E1E8E0", VA = "0x185E200E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool JLECHMLLEBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E20610", Offset = "0x5E1EE10", VA = "0x185E20610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool INEPPEPFAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E203A0", Offset = "0x5E1EBA0", VA = "0x185E203A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool FJOABLKOKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E20150", Offset = "0x5E1E950", VA = "0x185E20150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool MNLMBIDJGDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FCD0", Offset = "0x5E1E4D0", VA = "0x185E1FCD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool HHBFHKFGDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FF70", Offset = "0x5E1E770", VA = "0x185E1FF70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5E201C0", Offset = "0x5E1E9C0", VA = "0x185E201C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool AMAHLEIJMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5E202C0", Offset = "0x5E1EAC0", VA = "0x185E202C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Vector3 IHFIAGAJIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FC00", Offset = "0x5E1E400", VA = "0x185E1FC00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector3 PKMNGJAAAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5E20550", Offset = "0x5E1ED50", VA = "0x185E20550")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool MOIJLFMJIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FDE0", Offset = "0x5E1E5E0", VA = "0x185E1FDE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public ICDDKLLCIME DMBBBMNOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x1118590", Offset = "0x1116D90", VA = "0x181118590")]
		get
		{
			return default(ICDDKLLCIME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private LAFFONHEJBA AFFOFIDANDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AA640", VA = "0x1808ABE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private IBBOOHDJAGI DJFECEFGDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FB40", Offset = "0x5E1E340", VA = "0x185E1FB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FF80", Offset = "0x5E1E780", VA = "0x185E1FF80")]
	public bool HMEBJGLBDGH(GHMJMLIAAOF AOCJDBLPGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5E20480", Offset = "0x5E1EC80", VA = "0x185E20480")]
	public bool MCEPBMJLJPO(ObjectPolicyUserConfigurableFlags AOCJDBLPGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5E201D0", Offset = "0x5E1E9D0", VA = "0x185E201D0")]
	public void JBBFHBDOFNO(ObjectPolicyUserConfigurableFlags AOCJDBLPGHC, bool PKDEOIANGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2605F30", Offset = "0x2604730", VA = "0x182605F30")]
	public LNCMPMBNNIA(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FCE0", Offset = "0x5E1E4E0", VA = "0x185E1FCE0", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(LNCMPMBNNIA MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
public interface FOIKBHKKGCK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	AFEABPHNIHP NPOEHFOMAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	PGDOKNDMILI IOEFOKHCAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	EntityManager EHBCKOIMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool JHFNJCFMCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase AFBGLLGADGF(Type FIJCKHKKDCC);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class OJPNFJJIBCE
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5E23810", Offset = "0x5E22010", VA = "0x185E23810")]
	public static World KNJMNHMOMNF(this FOIKBHKKGCK MLPNJHFKIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x23CC830", Offset = "0x23CB030", VA = "0x1823CC830")]
	public static T AFBGLLGADGF<T>(this FOIKBHKKGCK MLPNJHFKIDL) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct JLNCECAFAMI : IEquatable<JLNCECAFAMI>
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly JLNCECAFAMI CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	private GDNLPCCHFEA ALEMGALCAHG
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5E1ED00", Offset = "0x5E1D500", VA = "0x185E1ED00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public ICDDKLLCIME BKGMLNFKFLC
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5E1F0A0", Offset = "0x5E1D8A0", VA = "0x185E1F0A0")]
		get
		{
			return default(ICDDKLLCIME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public GIFDOKMCBBO PANFGPHKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EE90", Offset = "0x5E1D690", VA = "0x185E1EE90")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public GIFDOKMCBBO ODFEIMILGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EFA0", Offset = "0x5E1D7A0", VA = "0x185E1EFA0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public ICDDKLLCIME DMBBBMNOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x1118590", Offset = "0x1116D90", VA = "0x181118590")]
		get
		{
			return default(ICDDKLLCIME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	private LAFFONHEJBA AFFOFIDANDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AA640", VA = "0x1808ABE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	private IBBOOHDJAGI DJFECEFGDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EAC0", Offset = "0x5E1D2C0", VA = "0x185E1EAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1ED80", Offset = "0x5E1D580", VA = "0x185E1ED80")]
	public bool JPDJPFJGJJB(GIFDOKMCBBO ONIJEEBBCHK, bool MBAHOAFDFAD = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EB10", Offset = "0x5E1D310", VA = "0x185E1EB10")]
	public bool CCCAFPIBKLB(GIFDOKMCBBO ILLJGBKEOAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2605F30", Offset = "0x2604730", VA = "0x182605F30")]
	public JLNCECAFAMI(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EC00", Offset = "0x5E1D400", VA = "0x185E1EC00", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(JLNCECAFAMI MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct EPINPDDFOKB : IEquatable<EPINPDDFOKB>
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly EPINPDDFOKB CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private CLIMEDPEGPH AMPDPGGEHCH
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5E1BE30", Offset = "0x5E1A630", VA = "0x185E1BE30")]
		get
		{
			return default(CLIMEDPEGPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public FBAPEENEEOL HLDNEHJOEFK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5E1BCC0", Offset = "0x5E1A4C0", VA = "0x185E1BCC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2605F30", Offset = "0x2604730", VA = "0x182605F30")]
	public EPINPDDFOKB(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BD30", Offset = "0x5E1A530", VA = "0x185E1BD30", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(EPINPDDFOKB MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
public interface CLEGEBGLEKP
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	IJMHEDAFOOI BAGLLJADOHP
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
[IHCFIENIHKO(JBOAFHDNBDO.Application)]
public interface OCBAADNICLO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool IGDOKHOOFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool LHAPCIJBDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	int LLCLIEDKHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool BAAOGMEPFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	MFAPMCMFMOM PLOCFDBOOAN
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	JNACKMOFADO FMDDIAHCAIB
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool MKDEEPOAGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool CIEHFIHLCOK
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string DLPPDELIIEC
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int CMPABEIHNJM(GameObject ALBKEDBKENG);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject[] DNLKEIIEDHH(IEnumerable<KBJDMICBLPJ> PLPAPLMFCPM);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CDGEIPMFEMD JPCBLJMFIDD(Guid DCNGCDGBOBC);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FGNGMCGHDEA ELOLCDEMGBE(KBJDMICBLPJ PAJPFFIMEFB);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FGNGMCGHDEA ELOLCDEMGBE(string JKENAADABML, CDGEIPMFEMD JDOPKGLAEGH, Vector3 NABPHMOHNDG, Quaternion KDPJNNPKKHC, Vector3 KACNEPKNFIL);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LMHEKNPHGOO(bool CNIPDMAOMPP);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FLBGNLHGKNP();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool HEPKPNHACPA(GameObject ALBKEDBKENG, out CDGEIPMFEMD JDOPKGLAEGH);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool EJFOBNOPMHD(GameObject ALBKEDBKENG, out int BPIMBCANOCD, out ObjectPrefabType KJIFGCIDDIC);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FAEILOAAMEA(GameObject ALBKEDBKENG, bool NGGGGINLBDO, bool MNAJHJNGHCM);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KGCPKOPGFIH(GameObject ALBKEDBKENG);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task KEKMDCALPAN();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task IEDHPDGMDAD();

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IJIEHKIAFOI(object CBHLPGJGAKG);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void BGDMMGPBNCH(object CBHLPGJGAKG);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void EDMPMHACGNJ(object MEKBNGFFPML);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void LAALODFNBAO(Transform HGGDDBMAHMF);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void OBJOJPMIHHE(Transform HGGDDBMAHMF, COJBHKILGJI LOEMDIIHOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DJDJIOEGBDL(Transform HGGDDBMAHMF, IJMHEDAFOOI ADFOOOIPFKF);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NMBJHCBLMCF(GameObject ALBKEDBKENG, ObjectPolicyUserConfigurableFlags INHKDDFKGGE);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Vector3 GNAJCIIILFJ(GameObject ALBKEDBKENG, int CILPMBKFKIN);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool JCKPPLIJCHP(out Vector3 NABPHMOHNDG);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void JCHKLGOHIJB();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void CGKOGMFALHJ(GameObject DCFMICOOJKO, bool JACPCCGHLHM);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "33")]
	ObjectPrefabType IAHAEFAMDMK(GameObject NBIMDBPEIEO);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "34")]
	int BMCAPFJEILA(GameObject ALBKEDBKENG);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "35")]
	object LPBJFKJCPEC(ICDDKLLCIME EEOIFMPKINO, GameObject ALBKEDBKENG, Action<ICDDKLLCIME, int> IACLOIAOHJF);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void FGEAOLAEMNL(GameObject ALBKEDBKENG, object OENDNEOJGII);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void AJLJAECMLOP(GameObject ALBKEDBKENG);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void EJAFLKKLLAJ(MEDIMOPGJCH NJHLKKCLMGI);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void DPHDJDHNHFJ(GameObject ALBKEDBKENG);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void IIBEOLAANKF(string DKIECHCHJFL);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	int HLPOHPBCIEG(GameObject NBIMDBPEIEO);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void NAODCHAJMGN(NativeArray<int> FDJNDPNMAAG);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void GAMLIKBMOHC(Action FOGMDOMFJBB, bool EDIDDBOCJNE);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool HLFFJEBPAJK(string BPOKAAOBIOI);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class IIJMNNIFPBK
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E780", Offset = "0x5E1CF80", VA = "0x185E1E780")]
	public static FGNGMCGHDEA ELOLCDEMGBE(this OCBAADNICLO FGOMHOJPKFO, CDGEIPMFEMD JDOPKGLAEGH, Vector3 NABPHMOHNDG, Quaternion KDPJNNPKKHC, Vector3 KACNEPKNFIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
public interface HAJKLJPGFLG
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct DALFAANKAOP : global::NMBLHKCDDCH<DALFAANKAOP>, LHEDDDDOOOA, IEquatable<DALFAANKAOP>
{
	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public int OJOINFOLDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x95A520", Offset = "0x958D20", VA = "0x18095A520", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9E26F0", Offset = "0x9E0EF0", VA = "0x1809E26F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public int ODKLBHBAMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xB83B10", Offset = "0xB82310", VA = "0x180B83B10", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x10CDBC0", Offset = "0x10CC3C0", VA = "0x1810CDBC0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5E171C0", Offset = "0x5E159C0", VA = "0x185E171C0", Slot = "8")]
	public bool Equals(DALFAANKAOP MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5E17210", Offset = "0x5E15A10", VA = "0x185E17210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct NDEGEBOAGDJ : DCEINGFKEIM, IEquatable<NDEGEBOAGDJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public ObjectPrefabType KJIFGCIDDIC;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5E21870", Offset = "0x5E20070", VA = "0x185E21870", Slot = "5")]
	public void NLJPEOGMFGO(ref JDMEGDECHOI GAPKPHPMEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5E217B0", Offset = "0x5E1FFB0", VA = "0x185E217B0", Slot = "4")]
	public void ECCPKOGLKLF(ref OCBGHMJPILB FEHOOJAGKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5E218A0", Offset = "0x5E200A0", VA = "0x185E218A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xB2EF10", Offset = "0xB2D710", VA = "0x180B2EF10", Slot = "6")]
	public bool Equals(NDEGEBOAGDJ MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5E217E0", Offset = "0x5E1FFE0", VA = "0x185E217E0", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x95A520", Offset = "0x958D20", VA = "0x18095A520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[IHCFIENIHKO(JBOAFHDNBDO.Application)]
public interface JMKDGEEMOPF
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action EAMBHGJDAKD;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BOKNBCAKONI();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MHIPPFOFPHF();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
public interface CEFOPLFLJMD
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	CCDDLHCHJML CAJNNLALJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	List<HPJPKKCENDM> ODMHGPGJAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KIAPEGJMBCI(HPJPKKCENDM PIKMJGOIABL, out CCDDLHCHJML JDPPDHMPNHH);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JPCMNIEIIHN(HPJPKKCENDM PIKMJGOIABL, ANIKAIHDNIF JHPKELPIAMB);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NBNPHEKFNCJ(HPJPKKCENDM PIKMJGOIABL, ANIKAIHDNIF JHPKELPIAMB);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[IHCFIENIHKO(JBOAFHDNBDO.Application)]
public interface GODDAOGNABK
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	FCPALNGIIKE INKLIIPGEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct PGHELANFAGH : IEquatable<PGHELANFAGH>
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly PGHELANFAGH CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private EMBNMLHIGII DGOINDMBDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5E24BC0", Offset = "0x5E233C0", VA = "0x185E24BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float3 MDONFFMCJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5E247A0", Offset = "0x5E22FA0", VA = "0x185E247A0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public quaternion HGMHKFLNBPH
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5E24AD0", Offset = "0x5E232D0", VA = "0x185E24AD0")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public GIFDOKMCBBO EEGGOKNJFEL
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5E249A0", Offset = "0x5E231A0", VA = "0x185E249A0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public ICDDKLLCIME DMBBBMNOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x1118590", Offset = "0x1116D90", VA = "0x181118590")]
		get
		{
			return default(ICDDKLLCIME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private LAFFONHEJBA AFFOFIDANDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AA640", VA = "0x1808ABE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private IBBOOHDJAGI DJFECEFGDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5E24750", Offset = "0x5E22F50", VA = "0x185E24750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2605F30", Offset = "0x2604730", VA = "0x182605F30")]
	public PGHELANFAGH(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x1118590", Offset = "0x1116D90", VA = "0x181118590")]
	public static ICDDKLLCIME DGIADCHILCD(PGHELANFAGH ECNGHFJBIJL)
	{
		return default(ICDDKLLCIME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5E248A0", Offset = "0x5E230A0", VA = "0x185E248A0", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(PGHELANFAGH MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[IHCFIENIHKO(JBOAFHDNBDO.Application)]
public interface MFMEEJGLKDE
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action BHEGHCEIBKO;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action PAOBFOIHGMB;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action AMFGFPNCJAA;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface CCDDLHCHJML
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	string LMLIOHGKIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	CCDDLHCHJML KMKOOECDMAO
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	IEnumerable<CCDDLHCHJML> BEPJIAMFEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[DefaultMember("Item")]
public struct MEDIMOPGJCH : IReadOnlyList<ICDDKLLCIME>, IEnumerable<ICDDKLLCIME>, IEnumerable, IReadOnlyCollection<ICDDKLLCIME>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct IGBBDOLPDBG : IEnumerator<ICDDKLLCIME>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly LAFFONHEJBA OJBDJOANLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private NativeArray<LocalId>.Enumerator ILKMAKIEBIF;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public ICDDKLLCIME NIBFGHDNPCH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x5E1E710", Offset = "0x5E1CF10", VA = "0x185E1E710", Slot = "4")]
			get
			{
				return default(ICDDKLLCIME);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x5E1E630", Offset = "0x5E1CE30", VA = "0x185E1E630", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x231BF40", Offset = "0x231A740", VA = "0x18231BF40")]
		public IGBBDOLPDBG(LAFFONHEJBA OJBDJOANLPJ, NativeArray<LocalId>.Enumerator ILKMAKIEBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E570", Offset = "0x5E1CD70", VA = "0x185E1E570", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E5B0", Offset = "0x5E1CDB0", VA = "0x185E1E5B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E5F0", Offset = "0x5E1CDF0", VA = "0x185E1E5F0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly LAFFONHEJBA OJBDJOANLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeArray<LocalId> NJHLKKCLMGI;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public ICDDKLLCIME OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5E20D10", Offset = "0x5E1F510", VA = "0x185E20D10", Slot = "4")]
		get
		{
			return default(ICDDKLLCIME);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x5E207A0", Offset = "0x5E1EFA0", VA = "0x185E207A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private int KLHBGPGCOLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int PJKEDAIIMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool MMKBNABBBLH
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5E208A0", Offset = "0x5E1F0A0", VA = "0x185E208A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public NativeArray<LocalId> HKPDMHMFAIP
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x231CAB0", Offset = "0x231B2B0", VA = "0x18231CAB0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	internal NativeArray<Entity> ILPJLDKJMJP
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x5E207B0", Offset = "0x5E1EFB0", VA = "0x185E207B0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5E20B60", Offset = "0x5E1F360", VA = "0x185E20B60")]
	public MEDIMOPGJCH(int CABFJBCMJEP, LAFFONHEJBA OJBDJOANLPJ, Allocator FKPADLBILGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x231BAE0", Offset = "0x231A2E0", VA = "0x18231BAE0")]
	public MEDIMOPGJCH(LAFFONHEJBA OJBDJOANLPJ, NativeArray<LocalId> NJHLKKCLMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5E20CA0", Offset = "0x5E1F4A0", VA = "0x185E20CA0")]
	internal MEDIMOPGJCH(LAFFONHEJBA OJBDJOANLPJ, NativeArray<Entity> FPMGLBFKKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5E20AC0", Offset = "0x5E1F2C0", VA = "0x185E20AC0")]
	public MEDIMOPGJCH(LAFFONHEJBA OJBDJOANLPJ, int HLPFAIAMMGH, Allocator FKPADLBILGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5E20BF0", Offset = "0x5E1F3F0", VA = "0x185E20BF0")]
	public MEDIMOPGJCH(MEDIMOPGJCH DJHKLKFFGPA, Allocator FKPADLBILGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5E20760", Offset = "0x5E1EF60", VA = "0x185E20760", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5E20810", Offset = "0x5E1F010", VA = "0x185E20810")]
	public IGBBDOLPDBG MEOEHOBEEMI()
	{
		return default(IGBBDOLPDBG);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5E208E0", Offset = "0x5E1F0E0", VA = "0x185E208E0", Slot = "6")]
	private IEnumerator<ICDDKLLCIME> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E209D0", Offset = "0x5E1F1D0", VA = "0x185E209D0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct CDGEIPMFEMD : IComparable<CDGEIPMFEMD>, IEquatable<CDGEIPMFEMD>, DCEINGFKEIM
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public const uint LEHHFPENHJN = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public const uint KIOAANNEJGO = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly CDGEIPMFEMD BGKJPCCCNHP;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const int LBNDLDIEBHH = 24;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const uint EFAIDNNPDDI = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const int ILFBMALDHGF = 8;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private const uint DCOEEHLIIKG = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly uint ENEAOCDMOME;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public uint AELBIBCBDOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x13ABDA0", Offset = "0x13AA5A0", VA = "0x1813ABDA0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public uint MHGNIJCIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x5E15DB0", Offset = "0x5E145B0", VA = "0x185E15DB0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public uint FBBAJJPMAGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x95A520", Offset = "0x958D20", VA = "0x18095A520")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool JDGGFLPNGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x163B700", Offset = "0x1639F00", VA = "0x18163B700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool PLOEDJOGGDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5E15F50", Offset = "0x5E14750", VA = "0x185E15F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0xB30AD0", Offset = "0xB2F2D0", VA = "0x180B30AD0")]
	public static CDGEIPMFEMD PKGBAEKMADJ(uint ENEAOCDMOME)
	{
		return default(CDGEIPMFEMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E16090", Offset = "0x5E14890", VA = "0x185E16090")]
	public CDGEIPMFEMD(int NGOGDFCDCCD, int MILLMJDIBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E16090", Offset = "0x5E14890", VA = "0x185E16090")]
	public CDGEIPMFEMD(uint NGOGDFCDCCD, int MILLMJDIBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E16090", Offset = "0x5E14890", VA = "0x185E16090")]
	public CDGEIPMFEMD(uint NGOGDFCDCCD, uint MILLMJDIBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x9E26F0", Offset = "0x9E0EF0", VA = "0x1809E26F0")]
	private CDGEIPMFEMD(uint ENEAOCDMOME)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x57A8C10", Offset = "0x57A7410", VA = "0x1857A8C10")]
	public static bool FMMDKFLNNFA(CDGEIPMFEMD NBLDAOBEAEA, CDGEIPMFEMD PAJLLFKCBBD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x57A8C20", Offset = "0x57A7420", VA = "0x1857A8C20")]
	public static bool BDPOAMCDIDB(CDGEIPMFEMD NBLDAOBEAEA, CDGEIPMFEMD PAJLLFKCBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E15E20", Offset = "0x5E14620", VA = "0x185E15E20", Slot = "5")]
	public bool Equals(CDGEIPMFEMD EDPPELMHBFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E15E80", Offset = "0x5E14680", VA = "0x185E15E80", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x14D6580", Offset = "0x14D4D80", VA = "0x1814D6580", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E15FC0", Offset = "0x5E147C0", VA = "0x185E15FC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E15DC0", Offset = "0x5E145C0", VA = "0x185E15DC0", Slot = "6")]
	public void ECCPKOGLKLF(ref OCBGHMJPILB FEHOOJAGKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E15F60", Offset = "0x5E14760", VA = "0x185E15F60", Slot = "7")]
	public void NLJPEOGMFGO(ref JDMEGDECHOI GAPKPHPMEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E15DA0", Offset = "0x5E145A0", VA = "0x185E15DA0", Slot = "4")]
	public int CompareTo(CDGEIPMFEMD MDHJAFNLPON)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
public interface BFJKGPMPLME
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDMIACLEBOI(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CEGBFEOBNEL(Entity CMBJDMJHALL, in float3 ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 FJMCPLPLAGC(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LGAGLBLDGLF(Entity CMBJDMJHALL, in quaternion ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion PMKNPOOANGM(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GPEBANKMMGD(Entity CMBJDMJHALL, in float3 NABPHMOHNDG, in quaternion KDPJNNPKKHC);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HKHEPHINAIG(Entity CMBJDMJHALL, out float3 NABPHMOHNDG, out quaternion KDPJNNPKKHC);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KOIAFAFIKGD(Entity CMBJDMJHALL, in float3 NABPHMOHNDG, in quaternion KDPJNNPKKHC);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BIDHMOBJPBP(Entity CMBJDMJHALL, out RigidTransform OOGDENLHANG);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	float3 AMLONFICBJP(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ODCHMBFFKME(Entity CMBJDMJHALL, in float3 ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PEOGMCDEEIE(Entity CMBJDMJHALL, float ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float FAHIHLHMHHL(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NDCGJFCFEHJ(Entity CMBJDMJHALL, in float3 ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "14")]
	float3 GGIAMGPAMOP(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LPGMPPCIDNK(Entity CMBJDMJHALL, in float3 ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 NOAPPOJNGKH(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MHPPIPAEIAP(Entity CMBJDMJHALL, in quaternion ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion BNILFOFMDLD(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 BMBICGACECM(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LKDDOEBDAJH(Entity CMBJDMJHALL, in float3 ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void AFNFJBDPCLC(Entity CMBJDMJHALL, float ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float ILLFIAIDHFE(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void GIHPNIMEGIH(Entity CMBJDMJHALL, in float3 ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "24")]
	float3 KNOILFLODCK(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void EIDEGOOGLCC(Entity CMBJDMJHALL, out float4x4 PAOMBAOFFIM);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HHHJJPODJNG(Entity CMBJDMJHALL, in float4x4 PAOMBAOFFIM);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void AHOALHIOKHB(Entity CMBJDMJHALL, out float4x4 PAOMBAOFFIM);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool OIOMKLOHEFK(Entity CMBJDMJHALL, out Transform HGGDDBMAHMF);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void JJFAKLIJKGP(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void BGKBCGPIBJL(Entity CMBJDMJHALL, Entity FONBLAEODAI, Entity PBNMPICADBG);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class KAIKHJDCKHL
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct MIEJIEHKJBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly IEnumerable<KBJDMICBLPJ> PLPAPLMFCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly IReadOnlyList<GameObject> KNICAFCALMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IReadOnlyList<int> BFLEOHGALNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly int BGPAKALPCIE;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool JDGGFLPNGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E20F80", Offset = "0x5E1F780", VA = "0x185E20F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public int KIDIEJPELJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8AD980", Offset = "0x8AC180", VA = "0x1808AD980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IEnumerable<GameObject> LNEGDDIONDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x903380", Offset = "0x901B80", VA = "0x180903380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x1A92590", Offset = "0x1A90D90", VA = "0x181A92590")]
	public MIEJIEHKJBI(IEnumerable<KBJDMICBLPJ> PLPAPLMFCPM, IReadOnlyList<GameObject> KNICAFCALMF, IReadOnlyList<int> BFLEOHGALNH, int BGPAKALPCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E20D50", Offset = "0x5E1F550", VA = "0x185E20D50")]
	public IEnumerable<(GameObject, int)> JIBJCPBPGLB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct EIEAAJJDDLF : IEquatable<EIEAAJJDDLF>
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly EIEAAJJDDLF CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private GDNLPCCHFEA ALEMGALCAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B0E0", Offset = "0x5E198E0", VA = "0x185E1B0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public MEDIMOPGJCH JADHMIKNFII
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AC50", Offset = "0x5E19450", VA = "0x185E1AC50")]
		get
		{
			return default(MEDIMOPGJCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public IEnumerable<GIFDOKMCBBO> GLGFKAIAEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B590", Offset = "0x5E19D90", VA = "0x185E1B590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public IEnumerable<GIFDOKMCBBO> NEODJIBDHCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AB10", Offset = "0x5E19310", VA = "0x185E1AB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int PHBPJLCCFMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AA30", Offset = "0x5E19230", VA = "0x185E1AA30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public int ELCCOOEGBBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B700", Offset = "0x5E19F00", VA = "0x185E1B700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public string EKPDCEFJBCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E1ADE0", Offset = "0x5E195E0", VA = "0x185E1ADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public ContainerCollisionLayerEnum LEKEHGNEFFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AE90", Offset = "0x5E19690", VA = "0x185E1AE90")]
		get
		{
			return default(ContainerCollisionLayerEnum);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B070", Offset = "0x5E19870", VA = "0x185E1B070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public CollisionMode JCFDGGPMGOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B8A0", Offset = "0x5E1A0A0", VA = "0x185E1B8A0")]
		get
		{
			return default(CollisionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B830", Offset = "0x5E1A030", VA = "0x185E1B830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool FICCFMDDIIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B750", Offset = "0x5E19F50", VA = "0x185E1B750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool LMELFLKAMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AD50", Offset = "0x5E19550", VA = "0x185E1AD50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool ABHNBNKHOPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B040", Offset = "0x5E19840", VA = "0x185E1B040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool GDDDFHLBLOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AEF0", Offset = "0x5E196F0", VA = "0x185E1AEF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool LDBEDEDCAPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AF10", Offset = "0x5E19710", VA = "0x185E1AF10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AD70", Offset = "0x5E19570", VA = "0x185E1AD70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool JOLLDOLLOEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B060", Offset = "0x5E19860", VA = "0x185E1B060")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5E1ADD0", Offset = "0x5E195D0", VA = "0x185E1ADD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public ICDDKLLCIME DMBBBMNOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x1118590", Offset = "0x1116D90", VA = "0x181118590")]
		get
		{
			return default(ICDDKLLCIME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public DFGOKJHLIDD ELJOBKLNFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(DFGOKJHLIDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public JLNCECAFAMI AEAGMJDNIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(JLNCECAFAMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private LAFFONHEJBA AFFOFIDANDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AA640", VA = "0x1808ABE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private IBBOOHDJAGI DJFECEFGDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AD80", Offset = "0x5E19580", VA = "0x185E1AD80")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
	public static GIFDOKMCBBO DGIADCHILCD(EIEAAJJDDLF JMIFLNNGBHG)
	{
		return default(GIFDOKMCBBO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AF20", Offset = "0x5E19720", VA = "0x185E1AF20")]
	public bool EGFFMHIHBFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B770", Offset = "0x5E19F70", VA = "0x185E1B770")]
	public bool OENDJCOLJMF(ContainerEnumFlags AOCJDBLPGHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B510", Offset = "0x5E19D10", VA = "0x185E1B510")]
	public void LIGJJJFNAJB(ContainerEnumFlags AOCJDBLPGHC, bool ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B160", Offset = "0x5E19960", VA = "0x185E1B160")]
	public MEDIMOPGJCH ICKIEKKJGPD(Allocator FKPADLBILGP)
	{
		return default(MEDIMOPGJCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B360", Offset = "0x5E19B60", VA = "0x185E1B360")]
	public void KFAMPIOCHOF(EIEAAJJDDLF MDHJAFNLPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x2605F30", Offset = "0x2604730", VA = "0x182605F30")]
	public EIEAAJJDDLF(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E15B90", Offset = "0x5E14390", VA = "0x185E15B90")]
	public static bool DGIADCHILCD(EIEAAJJDDLF ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AF40", Offset = "0x5E19740", VA = "0x185E1AF40", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(EIEAAJJDDLF MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct MMFMKOIAAGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal readonly JCDEFFAAIIP DBEIIGKEBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal readonly JCDEFFAAIIP NBBICLPHKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal readonly uint IKFJDOLIOFE;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x5E20FE0", Offset = "0x5E1F7E0", VA = "0x185E20FE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct FEEOOFLNEBE
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly MFFHLJHLBIG HGFFDKCANPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly MMFMKOIAAGM FOGMDOMFJBB;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5E15AF0", Offset = "0x5E142F0", VA = "0x185E15AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct CAFBGBAIBCP
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly MFFHLJHLBIG HGFFDKCANPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly MMFMKOIAAGM FOGMDOMFJBB;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5E15AF0", Offset = "0x5E142F0", VA = "0x185E15AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct PLKHBEDBBBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly uint IKFJDOLIOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly bool BOKNLAMLLKD;

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5E25030", Offset = "0x5E23830", VA = "0x185E25030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
public interface BCOGGGBMMOK
{
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GOAIHCEKHMM(ICDDKLLCIME EEOIFMPKINO, MKCCBALLBBE ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MKCCBALLBBE GCKHNPDPOBK(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ANNGLPCKBKA(ICDDKLLCIME EEOIFMPKINO, ICDDKLLCIME ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MEAEKDMOCMC(ICDDKLLCIME EEOIFMPKINO, ICDDKLLCIME ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DELOAHKAPCA(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ICDDKLLCIME FOFCFNEEPOA(ICDDKLLCIME EEOIFMPKINO, int NHHNPPKPBIA);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GGFMJHFGJAG(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KANGGCAIPNN(ICDDKLLCIME EEOIFMPKINO, object FLDJLPKNKKO, ICDDKLLCIME ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OALEMBGPAMK(ICDDKLLCIME EEOIFMPKINO, object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KDENGIKLCBB(ICDDKLLCIME EEOIFMPKINO, out ICDDKLLCIME ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KFGABEKHJLK(ICDDKLLCIME EEOIFMPKINO, float3 ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NCPHGEOJCAF(ICDDKLLCIME EEOIFMPKINO, out float3 ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PFEJHIOIEGE(ICDDKLLCIME EEOIFMPKINO, float3 ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool FKKHBBLEOOF(ICDDKLLCIME EEOIFMPKINO, out float3 ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HJCCPBACOJK(ICDDKLLCIME EEOIFMPKINO, (Quaternion rot, Vector3 moments) DCEIBGLEFBC);

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool DPGEDGAANLL(ICDDKLLCIME EEOIFMPKINO, out quaternion HCLIKMFANKK, out float3 IIABCJIGPDE);

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JKOMDGPIIBA(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DIHIMNOPPBG(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete]
	float3 GEHBGPCKBJK(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 NDCDOLJBHLL(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PCAAMBKMJPP(ICDDKLLCIME EEOIFMPKINO, float3 ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool ADDPKNIPLIB(ICDDKLLCIME EEOIFMPKINO, out float3 JGECPMODFKL);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GJNGDOPDOPP(ICDDKLLCIME EEOIFMPKINO, float3 ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void NHOLJPJKDGG(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	float JCGIBCLNMGO(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float LFAGCBNIHLI(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DLCJAMEDIPF(ICDDKLLCIME EEOIFMPKINO, float ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool IBJDHIFLJOO(ICDDKLLCIME EEOIFMPKINO, out float CHODJKFAPAA);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BCIDMAGGIFE(ICDDKLLCIME EEOIFMPKINO, float ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	CollisionDetectionMode BLLIOBJAOGF(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void AAHELLMPCCB(ICDDKLLCIME EEOIFMPKINO, CollisionDetectionMode ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "31")]
	GALCBGLBFAD KJBLJFPPAFA(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void CDCAHEIBKLK(ICDDKLLCIME EEOIFMPKINO, GALCBGLBFAD ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool JFCNGIFGOFG(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void GBGMLMMGPPH(ICDDKLLCIME EEOIFMPKINO, bool ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "35")]
	ICDDKLLCIME HLEPDGLBDNM(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void GOLOLHKODGD(ICDDKLLCIME EEOIFMPKINO, ICDDKLLCIME ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "37")]
	ICDDKLLCIME DMFKJLCKIIE(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void JPDJPFJGJJB(ICDDKLLCIME EEOIFMPKINO, ICDDKLLCIME ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "39")]
	LHPAGGDFKDF LAPLEMEHPFD(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void PPPFNOIKOOE(ICDDKLLCIME EEOIFMPKINO, LHPAGGDFKDF LMIIBOOAPKI);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool MFHFOGALICK(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void CEANAAFBICF(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool BDDNDBCOIJE(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void NNGCNKJNGJG(ICDDKLLCIME EEOIFMPKINO, bool ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool GPONBJOHGEC(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void DNIOGGALMIA(ICDDKLLCIME EEOIFMPKINO, bool ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "47")]
	RigidbodyConstraints JDECGKNONLE(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void KHBCICHCMFM(ICDDKLLCIME EEOIFMPKINO, RigidbodyConstraints ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float IPJMILKGOJL(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void MKEAPDHMFJD(ICDDKLLCIME EEOIFMPKINO, float ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "51")]
	float EDFOPBJHIJJ(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void LOJIHPJDJIN(ICDDKLLCIME EEOIFMPKINO, float ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool ODEDGCKGMBD(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void IPELNPLCACD(ICDDKLLCIME EEOIFMPKINO, bool ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "55")]
	bool NGAOIBICLBD(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void LNOONFDPJKC(ICDDKLLCIME EEOIFMPKINO, bool ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "57")]
	int KPNJCLPOEPN(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void AALIEENJEGI(ICDDKLLCIME EEOIFMPKINO, int ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(Slot = "59")]
	object KJEAOIINJOM(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void HOBDCDHCKCH(ICDDKLLCIME EEOIFMPKINO, object ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "61")]
	object EOKMELPGKDH(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void DLOOPKNEKNM(ICDDKLLCIME EEOIFMPKINO, object ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "63")]
	float MAHMFBCFMCB(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void GNAGAOKDICE(ICDDKLLCIME EEOIFMPKINO, float ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void LOOMGCJFPCP(ICDDKLLCIME EEOIFMPKINO, object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void APLOOHDKEFI(ICDDKLLCIME EEOIFMPKINO, object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool LENIHIAGCIB(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void NJMABGGGNIL(ICDDKLLCIME EEOIFMPKINO, object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void JBCGOBGNCJK(ICDDKLLCIME EEOIFMPKINO, object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool APOIFCIAKPA(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool PJOIEPIIJNJ(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void KLGELKAOHGJ(ICDDKLLCIME EEOIFMPKINO, bool ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Rigidbody JBLFEONAKKP(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void NIINBDAAMOL(ICDDKLLCIME EEOIFMPKINO, Rigidbody GGGGHNNPHJC);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void GHIPEPNLOHM(ICDDKLLCIME EEOIFMPKINO, object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void IFJCMMGNPMM(ICDDKLLCIME EEOIFMPKINO, object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool FHKPEMNOLMP(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void MIJGGEEGNOB(ICDDKLLCIME EEOIFMPKINO, float3 PPJHGOCBPCK);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void LIIFGFLPOBG(ICDDKLLCIME EEOIFMPKINO, float3 JDNINLGNNJF);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "80")]
	bool NMPMEGGKPAC(ICDDKLLCIME EEOIFMPKINO, out float3 PPJHGOCBPCK);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool ELCCHFNMPFH(ICDDKLLCIME EEOIFMPKINO, out float3 JDNINLGNNJF);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "82")]
	bool NOPLLAJBAJC(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void LCPMJCKNJAI(ICDDKLLCIME EEOIFMPKINO, object FLDJLPKNKKO, bool GCGPLALBKNG);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void AAEFPHOPDCO(ICDDKLLCIME EEOIFMPKINO, bool NLLLGEDJNOD);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void BDHMPFOFHFL(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "86")]
	bool JCKNLCEFPGB(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "87")]
	IEnumerable<object> FFKAHJKDGNA(ICDDKLLCIME EEOIFMPKINO);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
public interface AOFLADNJDCE
{
	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MAIOMMIMKAD(Entity GIFJNPKJJHL);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OOBHNCKGNEJ(Entity GIFJNPKJJHL);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct ODFPCDMIBJD : IEquatable<ODFPCDMIBJD>
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly ODFPCDMIBJD CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public string HFLCPAHPIIE
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x5E22C70", Offset = "0x5E21470", VA = "0x185E22C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public string KOALFCJNACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5E22F20", Offset = "0x5E21720", VA = "0x185E22F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x2605F30", Offset = "0x2604730", VA = "0x182605F30")]
	public ODFPCDMIBJD(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x5E22B70", Offset = "0x5E21370", VA = "0x185E22B70", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(ODFPCDMIBJD MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct OLKFAJMMHEM : IEquatable<OLKFAJMMHEM>
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly OLKFAJMMHEM CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x5E24250", Offset = "0x5E22A50", VA = "0x185E24250", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(OLKFAJMMHEM MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct CNJGLDLLEKL : IEquatable<CNJGLDLLEKL>
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly CNJGLDLLEKL CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private DHECCDHDODI MFFACJPPKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x5E16C30", Offset = "0x5E15430", VA = "0x185E16C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool LLKECBBDNBM
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x5E16CF0", Offset = "0x5E154F0", VA = "0x185E16CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool IMOJNLIEHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5E17010", Offset = "0x5E15810", VA = "0x185E17010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool GLLPNFBGNCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5E17150", Offset = "0x5E15950", VA = "0x185E17150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool PBKNKGNOPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5E16CB0", Offset = "0x5E154B0", VA = "0x185E16CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool BHGJEFILDKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x5E16930", Offset = "0x5E15130", VA = "0x185E16930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool CGEEPDHCKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x5E16A40", Offset = "0x5E15240", VA = "0x185E16A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool IIEOOOCCKEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x5E16DD0", Offset = "0x5E155D0", VA = "0x185E16DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public ICDDKLLCIME DMBBBMNOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1118590", Offset = "0x1116D90", VA = "0x181118590")]
		get
		{
			return default(ICDDKLLCIME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private LAFFONHEJBA AFFOFIDANDN
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AA640", VA = "0x1808ABE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private IBBOOHDJAGI DJFECEFGDAL
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x5E164C0", Offset = "0x5E14CC0", VA = "0x185E164C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x5E16490", Offset = "0x5E14C90", VA = "0x185E16490")]
	public bool AJOLDJBPOBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5E16510", Offset = "0x5E14D10", VA = "0x185E16510")]
	public GIFDOKMCBBO BFDBHEKFIBO(GIFDOKMCBBO CBHLPGJGAKG)
	{
		return default(GIFDOKMCBBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x5E16670", Offset = "0x5E14E70", VA = "0x185E16670")]
	public ICDDKLLCIME ECKEIFNDBIK()
	{
		return default(ICDDKLLCIME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x2605F30", Offset = "0x2604730", VA = "0x182605F30")]
	public CNJGLDLLEKL(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x5E15B90", Offset = "0x5E14390", VA = "0x185E15B90")]
	public static bool DGIADCHILCD(CNJGLDLLEKL ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x5E16830", Offset = "0x5E15030", VA = "0x185E16830", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(CNJGLDLLEKL MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct PIGHOFHDBAG : IComparable<PIGHOFHDBAG>, IEquatable<PIGHOFHDBAG>
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly PIGHOFHDBAG BGKJPCCCNHP;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly PIGHOFHDBAG IBAOJCCJPON;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly PIGHOFHDBAG FPCNDMGBEKH;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly PIGHOFHDBAG DEFKFFHCFNE;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly PIGHOFHDBAG ALPMLCMCHMA;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly PIGHOFHDBAG PCKEOFNNBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public int OJOINFOLDPA;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool MDHMHBIHCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x5E24EA0", Offset = "0x5E236A0", VA = "0x185E24EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x9E26F0", Offset = "0x9E0EF0", VA = "0x1809E26F0")]
	public PIGHOFHDBAG(int NHHNPPKPBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x5E24E30", Offset = "0x5E23630", VA = "0x185E24E30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5E24DA0", Offset = "0x5E235A0", VA = "0x185E24DA0", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0xB2EF10", Offset = "0xB2D710", VA = "0x180B2EF10", Slot = "5")]
	public bool Equals(PIGHOFHDBAG MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x5E24D90", Offset = "0x5E23590", VA = "0x185E24D90", Slot = "4")]
	public int CompareTo(PIGHOFHDBAG MDHJAFNLPON)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0xB30AD0", Offset = "0xB2F2D0", VA = "0x180B30AD0")]
	public static PIGHOFHDBAG DGIADCHILCD(int NHHNPPKPBIA)
	{
		return default(PIGHOFHDBAG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0xB30AD0", Offset = "0xB2F2D0", VA = "0x180B30AD0")]
	public static int DGIADCHILCD(PIGHOFHDBAG AOGGNHKFEEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x5E24EB0", Offset = "0x5E236B0", VA = "0x185E24EB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
[DefaultMember("Item")]
public interface FFCDEHGABKN : IEnumerable<IBCDCMBPNAD>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	IBCDCMBPNAD OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IBCDCMBPNAD AEFCPPJIBAA(GGIKBJPJGCF OHNDBNDIBPN);

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PIGHOFHDBAG NOPLKMAJKCL(GGIKBJPJGCF OHNDBNDIBPN);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class JJINBLJGHIJ
{
	[Cpp2IlInjected.Token(Token = "0x600029F")]
	public static global::OMHCKOEHOFD<T> AEFCPPJIBAA<T>(this FFCDEHGABKN JEADDOCNIGI, GGIKBJPJGCF BPOKAAOBIOI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2939340", Offset = "0x2937B40", VA = "0x182939340")]
	public static PIGHOFHDBAG NOPLKMAJKCL<T>(this FFCDEHGABKN JEADDOCNIGI, global::MDFMNLBADDB<T> BPOKAAOBIOI) where T : struct
	{
		return default(PIGHOFHDBAG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
public interface BKCDCDNCEAB
{
	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LLACCPADIGK(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CCIFFBJJNNH(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BJMBFKLKJEK(ICDDKLLCIME EEOIFMPKINO, out Guid DJCGAIJIDMG);

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid ALCBNCLBBDG(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EJHNDLDJJNI(ICDDKLLCIME EEOIFMPKINO, Guid DJCGAIJIDMG);

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GJEMDGOEKHM(ICDDKLLCIME EEOIFMPKINO, out Guid ENELKLKDEHJ);

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid IIOIMDBFICB(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MMJAMCKOILJ(ICDDKLLCIME EEOIFMPKINO, Guid ENELKLKDEHJ);

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HGPBMDEFBKF(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KCDHEBALMFB(ICDDKLLCIME PIKIEEICNEP, ICDDKLLCIME ONIJEEBBCHK);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
public interface GNPEAEJAEHF
{
	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJAKNNPGKMA(ICDDKLLCIME CMPMKFMJCNO, bool ECNGHFJBIJL);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct CDBIJCLCCNG : IEquatable<CDBIJCLCCNG>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly CDBIJCLCCNG CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public GMPKEDCGJIK DHNGAIKGDOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GMPKEDCGJIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private CLCLIKNFDOH IPPONDLDMIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E15CA0", Offset = "0x5E144A0", VA = "0x185E15CA0")]
		get
		{
			return default(CLCLIKNFDOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public PrimitiveShapeType JAOHHJKHIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x5E15D00", Offset = "0x5E14500", VA = "0x185E15D00")]
		get
		{
			return default(PrimitiveShapeType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public ICDDKLLCIME DMBBBMNOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x1118590", Offset = "0x1116D90", VA = "0x181118590")]
		get
		{
			return default(ICDDKLLCIME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2605F30", Offset = "0x2604730", VA = "0x182605F30")]
	public CDBIJCLCCNG(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E15B90", Offset = "0x5E14390", VA = "0x185E15B90")]
	public static bool DGIADCHILCD(CDBIJCLCCNG ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E15BA0", Offset = "0x5E143A0", VA = "0x185E15BA0", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(CDBIJCLCCNG MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
public interface FDJONGFMDAL
{
	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKBMGLGKOHM(ICDDKLLCIME EEOIFMPKINO, ContainerCollisionLayerEnum NBDHEBHIMHO, bool OFPIHBKDDCH, ContainerEnumFlags PMEKPLODBMI);

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FBGKKGGIHDK(ICDDKLLCIME EEOIFMPKINO, ContainerCollisionLayerEnum NBDHEBHIMHO, bool OFPIHBKDDCH, bool PFMKDPAMNII, bool JDNOCBBPMAJ);

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AIKDJHPHICP NHMDMEKCFPE(ICDDKLLCIME PMBNHDHBMIA, List<ICDDKLLCIME> CGHEAIMIJKO);

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EPDFOGIACMA(GameObject HLCLJEJGKGE, GameObject KADAIGOPBOH);

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IMPLMLBJFJC(GameObject KADAIGOPBOH);

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T LIPNMPDOJHB<T>(GameObject OHGLGONNIBJ) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OAFGPHOIJPN(Collider JNLMKMJDNIN);

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject IGCMDHNDOJB<T>(string BPOKAAOBIOI) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface IECEDPLHPPC
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	bool GLGGKOPKDGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	ICDDKLLCIME DMBBBMNOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[IHCFIENIHKO(JBOAFHDNBDO.Application)]
public interface DDKKJKCIGCL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	bool BJHJGNHJCFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	bool BGFLIIPGGFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	FDMKLPADELH OBCGPLNDKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OCGLDALEHNI(bool CNIPDMAOMPP);

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task CFOKPLJGFID(bool CNIPDMAOMPP);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KABJJEIAHLA EJEMOLPPMFA();

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KABJJEIAHLA ICIFJICAMGE(IEnumerable<ICDDKLLCIME> NJHLKKCLMGI, in INPHLFCOHNJ IMFMGEKHDFF);

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CHIHGFEHFIA KIKLCEDPOHG(ByteString DHLDGOJFNAN);

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FPJINGKCDIG KJFJGJLHKFK(ByteString KNJBCHEFCED, ICDDKLLCIME ONIJEEBBCHK, in INPHLFCOHNJ KEGBMAPAOFP, HMCKEPFICOF HDNCKIIAPDL, bool EBIGPHIOJBE = true);

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NCIGFFEIHKO();

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IPMHCNBGJNF(bool FEIKJAFKEJD);

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	MIEJIEHKJBI NCNJOOKHELJ(IEnumerable<KBJDMICBLPJ> PLPAPLMFCPM);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class BMNKNCCOIGB
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[IHCFIENIHKO(JBOAFHDNBDO.Application)]
public interface EOKNKLJOCCB : EBEPAADCBMI, EDINIDCGNHI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	bool JHFNJCFMCPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	KJGJHMBJJHN HHOMKKLDIHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	OCBAADNICLO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	IBBOOHDJAGI DJFECEFGDAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[IHCFIENIHKO(JBOAFHDNBDO.Application)]
public interface EDINIDCGNHI
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	bool GOEJILIBOLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
public interface EOPIENHHPEL
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	bool LKECKDPDIAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
public interface JDDACPHHGBL
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	Guid PJIOKECKKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFKBNJLMJLF(Guid DJCGAIJIDMG, Guid ENELKLKDEHJ, string BPOKAAOBIOI);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct JCDEFFAAIIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal int MCMFGBNCCMI;

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E940", Offset = "0x5E1D140", VA = "0x185E1E940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class LBCODIJGKHO
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private struct GIIBFPMFMKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Guid PCFHAIHNKAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public KCOKMCEABEB MCFMODOABIP;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private struct KCOKMCEABEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int ECNGHFJBIJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int INPGCFLGACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int BFLFKGFNIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int KGLBBOOMEIM;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E1F790", Offset = "0x5E1DF90", VA = "0x185E1F790")]
		public bool JHBAMGOOPFI(out CDGEIPMFEMD JDOPKGLAEGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E1F830", Offset = "0x5E1E030", VA = "0x185E1F830")]
		public KCOKMCEABEB(CDGEIPMFEMD JDOPKGLAEGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F950", Offset = "0x5E1E150", VA = "0x185E1F950")]
	public static Guid IBHIEGFINNG(this CDGEIPMFEMD JDOPKGLAEGH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F930", Offset = "0x5E1E130", VA = "0x185E1F930")]
	public static bool CEIHMJOAGHC(this Guid PCFHAIHNKAK, out CDGEIPMFEMD JDOPKGLAEGH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DebuggerTypeProxy(typeof(JHHIDCDGJEJ))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct ICDDKLLCIME : IComparable<ICDDKLLCIME>, IEquatable<ICDDKLLCIME>
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly ICDDKLLCIME BGKJPCCCNHP;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public LAFFONHEJBA AFFOFIDANDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AA640", VA = "0x1808ABE40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public LocalId GDDKAAGDDOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x903380", Offset = "0x901B80", VA = "0x180903380")]
		[CompilerGenerated]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool PFHINLDLMKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E1F0", Offset = "0x5E1C9F0", VA = "0x185E1E1F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool CPHBJIEGPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E0D0", Offset = "0x5E1C8D0", VA = "0x185E1E0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool AAJGOHNPOPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E3D0", Offset = "0x5E1CBD0", VA = "0x185E1E3D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E4F0", Offset = "0x5E1CCF0", VA = "0x185E1E4F0")]
	public ICDDKLLCIME(LAFFONHEJBA DLPGNLEJCJL, LocalId EEOIFMPKINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
	public GIFDOKMCBBO JBECNCEBPOP()
	{
		return default(GIFDOKMCBBO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x903380", Offset = "0x901B80", VA = "0x180903380")]
	public static LocalId DGIADCHILCD(ICDDKLLCIME EEFFKIAEAGE)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E2C0", Offset = "0x5E1CAC0", VA = "0x185E1E2C0")]
	public static Entity DGIADCHILCD(ICDDKLLCIME EEFFKIAEAGE)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E380", Offset = "0x5E1CB80", VA = "0x185E1E380")]
	public static bool FMMDKFLNNFA(ICDDKLLCIME NBLDAOBEAEA, ICDDKLLCIME PAJLLFKCBBD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E0F0", Offset = "0x5E1C8F0", VA = "0x185E1E0F0")]
	public static bool BDPOAMCDIDB(ICDDKLLCIME NBLDAOBEAEA, ICDDKLLCIME PAJLLFKCBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E3F0", Offset = "0x5E1CBF0", VA = "0x185E1E3F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E2D0", Offset = "0x5E1CAD0", VA = "0x185E1E2D0", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E190", Offset = "0x5E1C990", VA = "0x185E1E190", Slot = "4")]
	public int CompareTo(ICDDKLLCIME MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "5")]
	public bool Equals(ICDDKLLCIME MDHJAFNLPON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class ABDKGGKCECM
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x5E14210", Offset = "0x5E12A10", VA = "0x185E14210")]
	public static CDGEIPMFEMD FLKPPNNNKFE(this ICDDKLLCIME HHNPCHNMLMA)
	{
		return default(CDGEIPMFEMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x1C3CC60", Offset = "0x1C3B460", VA = "0x181C3CC60")]
	public static T LMPKJKBGPGN<T>(this ICDDKLLCIME HHNPCHNMLMA) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class JHHIDCDGJEJ
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
public interface OCPDIKODPNM
{
	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	bool JHFNJCFMCPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCGOMGHJDJL(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HKHBOINIIGG(ICDDKLLCIME EEOIFMPKINO, bool OFPIHBKDDCH, bool PFMKDPAMNII, bool BIHGJFFAABO);
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct BABNJLIFDFI : IEquatable<BABNJLIFDFI>
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly BABNJLIFDFI CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public ICDDKLLCIME DMBBBMNOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x1118590", Offset = "0x1116D90", VA = "0x181118590")]
		get
		{
			return default(ICDDKLLCIME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private LAFFONHEJBA AFFOFIDANDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AA640", VA = "0x1808ABE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private IBBOOHDJAGI DJFECEFGDAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E155D0", Offset = "0x5E13DD0", VA = "0x185E155D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E15620", Offset = "0x5E13E20", VA = "0x185E15620")]
	public void DAMCFGEHNND(bool ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E15860", Offset = "0x5E14060", VA = "0x185E15860")]
	public void MBGFHGHGAOK(bool ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x3475460", Offset = "0x3473C60", VA = "0x183475460")]
	public T FFGHAMIKLEL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2605F30", Offset = "0x2604730", VA = "0x182605F30")]
	public BABNJLIFDFI(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E15760", Offset = "0x5E13F60", VA = "0x185E15760", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(BABNJLIFDFI MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct JNOCLGGHPNB : IEquatable<JNOCLGGHPNB>
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly JNOCLGGHPNB CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F1D0", Offset = "0x5E1D9D0", VA = "0x185E1F1D0", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(JNOCLGGHPNB MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[IHCFIENIHKO(JBOAFHDNBDO.Application)]
public interface LABIECOBMML
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	bool HNAIGOOGAIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	bool MMBFKDAICHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	bool HIFMBPDPDDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	bool HCIBMGDDMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	bool GMMFPIPJBPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	bool LCFDEIJDINE
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct OBOFCBCJCMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float CIKEFFDMPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float3 PKBDFEAADGM;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct GMPKEDCGJIK : IEquatable<GMPKEDCGJIK>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly GMPKEDCGJIK CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private OACBLGMJBNA EPNGHCLHIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CF50", Offset = "0x5E1B750", VA = "0x185E1CF50")]
		get
		{
			return default(OACBLGMJBNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public IBAOPOMLPBN KAMGBEJLKOL
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D340", Offset = "0x5E1BB40", VA = "0x185E1D340")]
		get
		{
			return default(IBAOPOMLPBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public EOPDDDMMMJA GOONIPGJBIG
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D470", Offset = "0x5E1BC70", VA = "0x185E1D470")]
		get
		{
			return default(EOPDDDMMMJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public OIKKAOINEHH KFAIJAANJLM
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D2E0", Offset = "0x5E1BAE0", VA = "0x185E1D2E0")]
		get
		{
			return default(OIKKAOINEHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public EShapeType MMIOJOAOMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D5C0", Offset = "0x5E1BDC0", VA = "0x185E1D5C0")]
		get
		{
			return default(EShapeType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public RenderableColor OHBNBDLMMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D0F0", Offset = "0x5E1B8F0", VA = "0x185E1D0F0")]
		get
		{
			return default(RenderableColor);
		}
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CEE0", Offset = "0x5E1B6E0", VA = "0x185E1CEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public RenderableMaterial LPKOAIKFIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D6D0", Offset = "0x5E1BED0", VA = "0x185E1D6D0")]
		get
		{
			return default(RenderableMaterial);
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D010", Offset = "0x5E1B810", VA = "0x185E1D010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public float AKDFIEKMHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D410", Offset = "0x5E1BC10", VA = "0x185E1D410")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D4D0", Offset = "0x5E1BCD0", VA = "0x185E1D4D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 JONLHPBMGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D150", Offset = "0x5E1B950", VA = "0x185E1D150")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D640", Offset = "0x5E1BE40", VA = "0x185E1D640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public float DEKJGBIDHOP
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D730", Offset = "0x5E1BF30", VA = "0x185E1D730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public ShapeConfigData.Flags DEMJPOKIHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CFB0", Offset = "0x5E1B7B0", VA = "0x185E1CFB0")]
		get
		{
			return default(ShapeConfigData.Flags);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D550", Offset = "0x5E1BD50", VA = "0x185E1D550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public ICDDKLLCIME DMBBBMNOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1118590", Offset = "0x1116D90", VA = "0x181118590")]
		get
		{
			return default(ICDDKLLCIME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public DFGOKJHLIDD ELJOBKLNFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(DFGOKJHLIDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D3A0", Offset = "0x5E1BBA0", VA = "0x185E1D3A0")]
	public CDBIJCLCCNG IAEIDEHMGOO()
	{
		return default(CDBIJCLCCNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D080", Offset = "0x5E1B880", VA = "0x185E1D080")]
	public NHKGALFBHLM CKBAKKKDHBO()
	{
		return default(NHKGALFBHLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x2605F30", Offset = "0x2604730", VA = "0x182605F30")]
	public GMPKEDCGJIK(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x5E15B90", Offset = "0x5E14390", VA = "0x185E15B90")]
	public static bool DGIADCHILCD(GMPKEDCGJIK ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D1E0", Offset = "0x5E1B9E0", VA = "0x185E1D1E0", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(GMPKEDCGJIK MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[IHCFIENIHKO(JBOAFHDNBDO.Application)]
public interface IBBOOHDJAGI
{
	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	JHMGDIDCDLA HHOMKKLDIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	OCBAADNICLO GMBBOAIKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	FOIKBHKKGCK NPOEHFOMAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	LAFFONHEJBA AFFOFIDANDN
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	GDNLPCCHFEA AEAGMJDNIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	BFJKGPMPLME DKPMDCFINML
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	DDKKJKCIGCL OBFMIGGILHN
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	JBJOCJBPPOP FDCMCBGJOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	GKNDABFCLBP FKGBMHPDNCI
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	DHECCDHDODI OOGAJJPIFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	BIADMEAMBOH FAKNHMMOKCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	GNPEAEJAEHF KEOPHEBKJEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	GDABAFHKPJF HMFFMFNFLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	BKCDCDNCEAB ABOJMBFIOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	EMBNMLHIGII JIAANDLNEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	BCOGGGBMMOK BBCGCDPBLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	LABIECOBMML JANCJPADJHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
public interface HBHFFEMNFBK
{
	[Cpp2IlInjected.Token(Token = "0x17000103")]
	object ANPFLEOIMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EJAFLKKLLAJ(MEDIMOPGJCH NJHLKKCLMGI);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
public interface GDNLPCCHFEA
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public delegate void OFICOMILLEI(MEDIMOPGJCH OJBDJOANLPJ, MEDIMOPGJCH NIMNBFPJFKM, MEDIMOPGJCH CBIAFCLJGMA);

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ICDDKLLCIME HLEPDGLBDNM(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ICDDKLLCIME DMFKJLCKIIE(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JPDJPFJGJJB(ICDDKLLCIME EEOIFMPKINO, ICDDKLLCIME ONIJEEBBCHK, bool MBAHOAFDFAD);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MLLDGDKIBBD(ICDDKLLCIME EEOIFMPKINO, ICDDKLLCIME ONIJEEBBCHK);

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DELOAHKAPCA(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MEDIMOPGJCH ELAELPBEKNF(ICDDKLLCIME CMPMKFMJCNO);

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CKGDPEOGGEI(ICDDKLLCIME EEOIFMPKINO, ICDDKLLCIME FFNICOMKDDC);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CCCAFPIBKLB(ICDDKLLCIME EEOIFMPKINO, ICDDKLLCIME ILLJGBKEOAD);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ICDDKLLCIME KLBJNJBEBME(ICDDKLLCIME FFNICOMKDDC, ICDDKLLCIME NEPEHHINJIN);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PENGEIKMKDP(ICDDKLLCIME FFNICOMKDDC, ICDDKLLCIME NEPEHHINJIN, out ICDDKLLCIME NACALKPMKDO);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class KFNNLGHKNHA
{
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F850", Offset = "0x5E1E050", VA = "0x185E1F850")]
	public static bool IAFDPAMALCM(this GDNLPCCHFEA PABIOJINDOL, ICDDKLLCIME EEOIFMPKINO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public enum IJOJONFKPPA
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
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
public interface JBJOCJBPPOP
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ICDDKLLCIME> CGCPNHJPFLH(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ICDDKLLCIME HINEDDGKCHB(ICDDKLLCIME EEOIFMPKINO, int NHHNPPKPBIA);

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int IIAFMLHOLHE(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BHKMKIAFEBP HDBEMIDJBNI(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DBADLOPJNEP(ICDDKLLCIME EEOIFMPKINO, BHKMKIAFEBP DAKKAABHBLK);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ICDDKLLCIME EBCJMFBBJEC(ICDDKLLCIME EEOIFMPKINO, [Optional] float3? NABPHMOHNDG, [Optional] quaternion? KDPJNNPKKHC, [Optional] float3? KACNEPKNFIL);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ICDDKLLCIME FGNBLFPGLIN(ICDDKLLCIME EEOIFMPKINO, int NHHNPPKPBIA, [Optional] float3? NABPHMOHNDG, [Optional] quaternion? KDPJNNPKKHC, [Optional] float3? KACNEPKNFIL);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GHFBHAINPEO(ICDDKLLCIME EEOIFMPKINO, int NHHNPPKPBIA);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HBEHNCJEBDA(ICDDKLLCIME EEOIFMPKINO);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
public interface MKIFJHBBCKI
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJODNFECBPB(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GDBALFGOGAP(ICDDKLLCIME EEOIFMPKINO, Transform HGGDDBMAHMF);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface KLLLAPPONHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000104")]
	LocalId MCMJAHHOIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	LocalId PNHEMEGFCHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LONABDOOMMO(float3 NFCEBNNOPDK);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BEDPJMFJMOP(float3 NFCEBNNOPDK);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void POABIEOLHDM(out float3 DBEIIGKEBIB, out float3 NBBICLPHKEO);

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FBIKOIHLKFK(float3 DBEIIGKEBIB, float3 NBBICLPHKEO);

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EGBEBONIJFI(Color DBEIIGKEBIB, Color NBBICLPHKEO);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KLLLAPPONHC Instantiate(Transform HGGDDBMAHMF);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface LJAIJPEMIKB
{
	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBAELFIBGFO(Transform HGGDDBMAHMF, KLLLAPPONHC GMFKDICNMFN);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KLLLAPPONHC IHBCJHMOECJ();
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct CJPMNHIGLLL : IEquatable<CJPMNHIGLLL>
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly CJPMNHIGLLL CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private HMPFBIJFMJK JACPDKGGIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x5E16100", Offset = "0x5E14900", VA = "0x185E16100")]
		get
		{
			return default(HMPFBIJFMJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public PropType CEOMIHJMMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x5E160A0", Offset = "0x5E148A0", VA = "0x185E160A0")]
		get
		{
			return default(PropType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x5E16160", Offset = "0x5E14960", VA = "0x185E16160")]
	public EPINPDDFOKB EHMPDPDIMGM()
	{
		return default(EPINPDDFOKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x2605F30", Offset = "0x2604730", VA = "0x182605F30")]
	public CJPMNHIGLLL(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x5E16210", Offset = "0x5E14A10", VA = "0x185E16210", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(CJPMNHIGLLL MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface IHMJGIAEEAN
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLMOKLENLNP();
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class OPHDOEINFEO
{
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x5E24600", Offset = "0x5E22E00", VA = "0x185E24600")]
	public static void HLMOKLENLNP(this GameObject NBIMDBPEIEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct CMDDOBKOGJC : IEquatable<CMDDOBKOGJC>
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly CMDDOBKOGJC CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x5E16350", Offset = "0x5E14B50", VA = "0x185E16350", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(CMDDOBKOGJC MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct OMGAEGFFOLF : IEquatable<OMGAEGFFOLF>
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static readonly OMGAEGFFOLF CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2605F30", Offset = "0x2604730", VA = "0x182605F30")]
	public OMGAEGFFOLF(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x5E24390", Offset = "0x5E22B90", VA = "0x185E24390", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(OMGAEGFFOLF MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x5E24490", Offset = "0x5E22C90", VA = "0x185E24490")]
	public bool KFBMPILNLDM(out Collider JNLMKMJDNIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct GNGJAGJHOHA : IEquatable<GNGJAGJHOHA>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly GNGJAGJHOHA CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public ICDDKLLCIME DMBBBMNOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x1118590", Offset = "0x1116D90", VA = "0x181118590")]
		get
		{
			return default(ICDDKLLCIME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public NHKGALFBHLM IMLGKOMEHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D900", Offset = "0x5E1C100", VA = "0x185E1D900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public float3 FLNDEGFPBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DC10", Offset = "0x5E1C410", VA = "0x185E1DC10")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D7F0", Offset = "0x5E1BFF0", VA = "0x185E1D7F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public quaternion OCOFEOLGBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DD60", Offset = "0x5E1C560", VA = "0x185E1DD60")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D880", Offset = "0x5E1C080", VA = "0x185E1D880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public float3 HCGADIMBDKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DEA0", Offset = "0x5E1C6A0", VA = "0x185E1DEA0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DA20", Offset = "0x5E1C220", VA = "0x185E1DA20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public HOAOFIPLABA PHJDPBIAMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DF30", Offset = "0x5E1C730", VA = "0x185E1DF30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	private IBOBFHLHBPD KOICHGDICNL
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DFA0", Offset = "0x5E1C7A0", VA = "0x185E1DFA0")]
		get
		{
			return default(IBOBFHLHBPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private GGBEOKMMMIB NPIMPGGHBDH
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DBB0", Offset = "0x5E1C3B0", VA = "0x185E1DBB0")]
		get
		{
			return default(GGBEOKMMMIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	private FPDPOELIODC KHIHNLAGNDN
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D9C0", Offset = "0x5E1C1C0", VA = "0x185E1D9C0")]
		get
		{
			return default(FPDPOELIODC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	private ECEAKFBOAFL EFOHCKNKAAD
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DE40", Offset = "0x5E1C640", VA = "0x185E1DE40")]
		get
		{
			return default(ECEAKFBOAFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	private JLBANIOPKJN ACNMHBPHKIL
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DDE0", Offset = "0x5E1C5E0", VA = "0x185E1DDE0")]
		get
		{
			return default(JLBANIOPKJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2605F30", Offset = "0x2604730", VA = "0x182605F30")]
	public GNGJAGJHOHA(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DAB0", Offset = "0x5E1C2B0", VA = "0x185E1DAB0", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(GNGJAGJHOHA MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DCA0", Offset = "0x5E1C4A0", VA = "0x185E1DCA0")]
	public void KDIIKMEJJBH(NHKGALFBHLM ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D7F0", Offset = "0x5E1BFF0", VA = "0x185E1D7F0")]
	public void CEGBFEOBNEL(float3 ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D880", Offset = "0x5E1C080", VA = "0x185E1D880")]
	public void LGAGLBLDGLF(quaternion ECNGHFJBIJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct DFGOKJHLIDD : IEquatable<DFGOKJHLIDD>
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public static readonly DFGOKJHLIDD CPDBIFPGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly ICDDKLLCIME CMPMKFMJCNO;

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public GIFDOKMCBBO CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x5E14BD0", Offset = "0x5E133D0", VA = "0x185E14BD0")]
		get
		{
			return default(GIFDOKMCBBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	private LAFFONHEJBA AFFOFIDANDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AA640", VA = "0x1808ABE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private BFJKGPMPLME BNGBEEBKDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5E17260", Offset = "0x5E15A60", VA = "0x185E17260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public bool MPMGIODKEEE
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x5E18E00", Offset = "0x5E17600", VA = "0x185E18E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public Vector3 FLNDEGFPBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x5E19000", Offset = "0x5E17800", VA = "0x185E19000")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5E174F0", Offset = "0x5E15CF0", VA = "0x185E174F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Quaternion OCOFEOLGBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5E19650", Offset = "0x5E17E50", VA = "0x185E19650")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x5E17B40", Offset = "0x5E16340", VA = "0x185E17B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Vector3 COBBPPAHGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x5E18E50", Offset = "0x5E17650", VA = "0x185E18E50")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E18460", Offset = "0x5E16C60", VA = "0x185E18460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Quaternion AEOIOMHPLMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E192F0", Offset = "0x5E17AF0", VA = "0x185E192F0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E17DC0", Offset = "0x5E165C0", VA = "0x185E17DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public float MONKEGPBKLP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E18990", Offset = "0x5E17190", VA = "0x185E18990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public float KCCKNLIMMOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E18890", Offset = "0x5E17090", VA = "0x185E18890")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public Vector3 HCGADIMBDKN
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E19FF0", Offset = "0x5E187F0", VA = "0x185E19FF0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E17C80", Offset = "0x5E16480", VA = "0x185E17C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public Vector3 AIHCBJMGELN
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x5E191B0", Offset = "0x5E179B0", VA = "0x185E191B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public Vector3 FPNCCLJKJGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x5E18100", Offset = "0x5E16900", VA = "0x185E18100")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Matrix4x4 KKBGEFDJBBH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5E18C80", Offset = "0x5E17480", VA = "0x185E18C80")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2605F30", Offset = "0x2604730", VA = "0x182605F30")]
	public DFGOKJHLIDD(ICDDKLLCIME EEOIFMPKINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F0", Offset = "0x7F11F0", VA = "0x1807F29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x5E17F00", Offset = "0x5E16700", VA = "0x185E17F00", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x5E145B0", Offset = "0x5E12DB0", VA = "0x185E145B0", Slot = "4")]
	public bool Equals(DFGOKJHLIDD MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x5E17AD0", Offset = "0x5E162D0", VA = "0x185E17AD0")]
	public MLOGLFPJNHJ DBMHLEAANHE()
	{
		return default(MLOGLFPJNHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A710", Offset = "0x5E18F10", VA = "0x185E1A710")]
	public void PNDCKNBIKJH(out Matrix4x4 PAOMBAOFFIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E18AA0", Offset = "0x5E172A0", VA = "0x185E18AA0")]
	public void HKHEPHINAIG(out Vector3 AHICOHBCMCM, out Quaternion JNODBPOHLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E173E0", Offset = "0x5E15BE0", VA = "0x185E173E0")]
	public void BIDHMOBJPBP(out RigidTransform DAANOGKGOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A400", Offset = "0x5E18C00", VA = "0x185E1A400")]
	public INPHLFCOHNJ OJJEMAJPMCJ()
	{
		return default(INPHLFCOHNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A2E0", Offset = "0x5E18AE0", VA = "0x185E1A2E0")]
	public void OJJEMAJPMCJ(out INPHLFCOHNJ HDGGLBPJBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E182B0", Offset = "0x5E16AB0", VA = "0x185E182B0")]
	public Vector3 FJMCPLPLAGC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E17990", Offset = "0x5E16190", VA = "0x185E17990")]
	public void CEGBFEOBNEL(in Vector3 ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E19E40", Offset = "0x5E18640", VA = "0x185E19E40")]
	public Vector3 NOAPPOJNGKH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E19A80", Offset = "0x5E18280", VA = "0x185E19A80")]
	public void LPGMPPCIDNK(in Vector3 ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A560", Offset = "0x5E18D60", VA = "0x185E1A560")]
	public Quaternion PMKNPOOANGM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E19800", Offset = "0x5E18000", VA = "0x185E19800")]
	public void LGAGLBLDGLF(in Quaternion ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E177E0", Offset = "0x5E15FE0", VA = "0x185E177E0")]
	public Quaternion BNILFOFMDLD()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E19BC0", Offset = "0x5E183C0", VA = "0x185E19BC0")]
	public void MHPPIPAEIAP(in Quaternion ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E18000", Offset = "0x5E16800", VA = "0x185E18000")]
	public float FAHIHLHMHHL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A450", Offset = "0x5E18C50", VA = "0x185E1A450")]
	public void PEOGMCDEEIE(float ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E18D00", Offset = "0x5E17500", VA = "0x185E18D00")]
	public float ILLFIAIDHFE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E172D0", Offset = "0x5E15AD0", VA = "0x185E172D0")]
	public void AFNFJBDPCLC(float ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A1A0", Offset = "0x5E189A0", VA = "0x185E1A1A0")]
	public void ODCHMBFFKME(in Vector3 ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E17630", Offset = "0x5E15E30", VA = "0x185E17630")]
	public Vector3 BMBICGACECM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E19940", Offset = "0x5E18140", VA = "0x185E19940")]
	public void LKDDOEBDAJH(in Vector3 ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E185A0", Offset = "0x5E16DA0", VA = "0x185E185A0")]
	public Vector3 GGIAMGPAMOP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E19D00", Offset = "0x5E18500", VA = "0x185E19D00")]
	public void NDCGJFCFEHJ(in Vector3 ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E194A0", Offset = "0x5E17CA0", VA = "0x185E194A0")]
	public Vector3 KNOILFLODCK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E18750", Offset = "0x5E16F50", VA = "0x185E18750")]
	public void GIHPNIMEGIH(in Vector3 ECNGHFJBIJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
public interface LAFFONHEJBA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	IBBOOHDJAGI DJFECEFGDAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ObjectType OJJNJPCANCF(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ObjectPrefabType GJJHFOKGPEM(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JPCMNIEIIHN(CDGEIPMFEMD JDOPKGLAEGH, FGNGMCGHDEA FIMMEEPHPII);

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GIFDOKMCBBO JEHGHPAKPDB(ICDDKLLCIME EEOIFMPKINO, [Optional] object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KGDHHCAIFGG(ICDDKLLCIME EEOIFMPKINO, out FGNGMCGHDEA FIMMEEPHPII);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AFLEAHOGCHM(FGNGMCGHDEA FIMMEEPHPII);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OIOMKLOHEFK(ICDDKLLCIME EEOIFMPKINO, out Transform HGGDDBMAHMF);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JNJCDBENOFM(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KACMHADCANK(LocalId EEOIFMPKINO, object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool AMMCCEDBMFC(LocalId EEOIFMPKINO, object FLDJLPKNKKO);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ICDDKLLCIME BJDOJICAIPM(CDGEIPMFEMD JDOPKGLAEGH);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CDGEIPMFEMD FLKPPNNNKFE(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MEDIMOPGJCH BJDOJICAIPM(NativeArray<CDGEIPMFEMD> JDOPKGLAEGH, Allocator FKPADLBILGP);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MEDIMOPGJCH JHCMGACGOKN(NativeArray<CDGEIPMFEMD> JDOPKGLAEGH, NativeArray<NDEGEBOAGDJ> BFDHHOKKBKA, Allocator FKPADLBILGP);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GIFDOKMCBBO IBAOJCCJPON(ObjectPrefabType KJIFGCIDDIC, bool OIGGAIFEIBF);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	GIFDOKMCBBO IBAOJCCJPON(ObjectPrefabType KJIFGCIDDIC);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	GIFDOKMCBBO LBCNANNDNIM(ObjectPrefabType KJIFGCIDDIC);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	GIFDOKMCBBO JHCMGACGOKN(CDGEIPMFEMD JDOPKGLAEGH, ObjectPrefabType KJIFGCIDDIC);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	EIEAAJJDDLF LJNFCOJPLGL();

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	NHKGALFBHLM KBEENHHAGOF();

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	CDBIJCLCCNG IHAFOOELILC(PrimitiveShapeType PIIFGEGHAME);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BMEOGFOJNDD(MEDIMOPGJCH NJHLKKCLMGI);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void ENFMBIKBCAA(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BEJJEKBDCBC(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void BMEOGFOJNDD(ICDDKLLCIME EEOIFMPKINO);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	MEDIMOPGJCH JJMHNAPNCCM(MEDIMOPGJCH CPPAKHAKJAF, Allocator FKPADLBILGP);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool PFHINLDLMKG(ICDDKLLCIME EEOIFMPKINO);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class PODBAGGOAHA
{
	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E25200", Offset = "0x5E23A00", VA = "0x185E25200")]
	public static GIFDOKMCBBO EOJALKEIEDE(this LAFFONHEJBA OJBDJOANLPJ, LocalId EEOIFMPKINO)
	{
		return default(GIFDOKMCBBO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E250D0", Offset = "0x5E238D0", VA = "0x185E250D0")]
	public static ICDDKLLCIME BJDOJICAIPM(this LAFFONHEJBA OJBDJOANLPJ, LocalId EEOIFMPKINO)
	{
		return default(ICDDKLLCIME);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E254C0", Offset = "0x5E23CC0", VA = "0x185E254C0")]
	public static CDGEIPMFEMD FLKPPNNNKFE(this LAFFONHEJBA OJBDJOANLPJ, LocalId EEOIFMPKINO)
	{
		return default(CDGEIPMFEMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E25860", Offset = "0x5E24060", VA = "0x185E25860")]
	public static bool PFHINLDLMKG(this LAFFONHEJBA OJBDJOANLPJ, CDGEIPMFEMD JDOPKGLAEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x23DAFC0", Offset = "0x23D97C0", VA = "0x1823DAFC0")]
	public static T LMPKJKBGPGN<T>(this LAFFONHEJBA OJBDJOANLPJ, LocalId EEOIFMPKINO) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E25720", Offset = "0x5E23F20", VA = "0x185E25720")]
	public static EIEAAJJDDLF ONKBGPPKDDL(this LAFFONHEJBA OJBDJOANLPJ, RigidTransform HDGGLBPJBIF, [Optional] object FLDJLPKNKKO)
	{
		return default(EIEAAJJDDLF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E259B0", Offset = "0x5E241B0", VA = "0x185E259B0")]
	public static CDBIJCLCCNG PNLIGHLABBH(this LAFFONHEJBA OJBDJOANLPJ, PrimitiveShapeType KHIENNFHPPM, RigidTransform HDGGLBPJBIF, [Optional] object FLDJLPKNKKO)
	{
		return default(CDBIJCLCCNG);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E255E0", Offset = "0x5E23DE0", VA = "0x185E255E0")]
	public static NHKGALFBHLM LJKAOLBJMHK(this LAFFONHEJBA OJBDJOANLPJ, RigidTransform HDGGLBPJBIF, [Optional] object FLDJLPKNKKO)
	{
		return default(NHKGALFBHLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E250F0", Offset = "0x5E238F0", VA = "0x185E250F0")]
	private static void CLNAKBJCBBL(GIFDOKMCBBO BGMCCLALBBP, RigidTransform HDGGLBPJBIF, [Optional] object FLDJLPKNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E252B0", Offset = "0x5E23AB0", VA = "0x185E252B0")]
	internal static EPINPDDFOKB FKNBEKDKOKJ(this LAFFONHEJBA OJBDJOANLPJ, FBAPEENEEOL FALEJNKCEDD, [Optional] object FLDJLPKNKKO)
	{
		return default(EPINPDDFOKB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal static class JIMCFONBGGA
{
	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EA50", Offset = "0x5E1D250", VA = "0x185E1EA50")]
	public static FOIKBHKKGCK NPOEHFOMAKE(this ICDDKLLCIME EDPPELMHBFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E9A0", Offset = "0x5E1D1A0", VA = "0x185E1E9A0")]
	public static EntityManager EHBCKOIMEPG(this ICDDKLLCIME EDPPELMHBFA)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2937B10", Offset = "0x2936310", VA = "0x182937B10")]
	public static T HHJBLJEFAKG<T>(this ICDDKLLCIME EDPPELMHBFA) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x2937AA0", Offset = "0x29362A0", VA = "0x182937AA0")]
	public static bool EFAGGABMEHL<T>(this ICDDKLLCIME EDPPELMHBFA) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
internal interface FPLKDHFMDNG
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event GDNLPCCHFEA.OFICOMILLEI EAIOALMCIOB;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[IHCFIENIHKO(JBOAFHDNBDO.LoadInstance)]
public interface DHECCDHDODI
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	bool PJPJOFCLGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	ICDDKLLCIME GLPEHKBBDJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	GIFDOKMCBBO CMNIKFBJLGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	GIFDOKMCBBO IIPILGOOCMK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event LPLFFGLIEFB LPMOLLOLAKE;

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ICDDKLLCIME KLBJNJBEBME(ICDDKLLCIME FFNICOMKDDC, ICDDKLLCIME NEPEHHINJIN);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PENGEIKMKDP(ICDDKLLCIME FFNICOMKDDC, ICDDKLLCIME NEPEHHINJIN, out ICDDKLLCIME NACALKPMKDO);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CNNBKLFANHI();

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BJMMELLIKGF();

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool LLKECBBDNBM(ICDDKLLCIME CBHLPGJGAKG);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public delegate void LPLFFGLIEFB(GIFDOKMCBBO CPBCCALIBIF, GIFDOKMCBBO LNFKJLCJMGB);
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class MNKJPOGLLDG
{
	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x5E21720", Offset = "0x5E1FF20", VA = "0x185E21720")]
	public static bool JJHIBANBLIH(this DHECCDHDODI IKBDCHBCJKE, GIFDOKMCBBO CBHLPGJGAKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x5E21380", Offset = "0x5E1FB80", VA = "0x185E21380")]
	public static bool HBHPDNIANCF(this DHECCDHDODI IKBDCHBCJKE, ICDDKLLCIME CBHLPGJGAKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5E21280", Offset = "0x5E1FA80", VA = "0x185E21280")]
	public static bool BHGJEFILDKN(this DHECCDHDODI IKBDCHBCJKE, ICDDKLLCIME CBHLPGJGAKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[DefaultMember("Item")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
public interface AHHKAPLLJIN : IEnumerable<HPJPKKCENDM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	HPJPKKCENDM OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HPJPKKCENDM AEFCPPJIBAA(GGIKBJPJGCF OHNDBNDIBPN);

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PIGHOFHDBAG NOPLKMAJKCL(GGIKBJPJGCF OHNDBNDIBPN);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class JACPODMLCOP
{
	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x2932FC0", Offset = "0x29317C0", VA = "0x182932FC0")]
	public static global::EJDCIEBOMOK<T> AEFCPPJIBAA<T>(this AHHKAPLLJIN JEADDOCNIGI, GGIKBJPJGCF BPOKAAOBIOI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2932E70", Offset = "0x2931670", VA = "0x182932E70")]
	public static global::EJDCIEBOMOK<T> AEFCPPJIBAA<T>(this AHHKAPLLJIN JEADDOCNIGI, global::MDFMNLBADDB<T> BPOKAAOBIOI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x29330F0", Offset = "0x29318F0", VA = "0x1829330F0")]
	public static PIGHOFHDBAG NOPLKMAJKCL<T>(this AHHKAPLLJIN JEADDOCNIGI, global::MDFMNLBADDB<T> BPOKAAOBIOI) where T : struct
	{
		return default(PIGHOFHDBAG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
public interface GODHJPHIEIM : FPDHDDILPLF
{
	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DALFAANKAOP OOCBBIPOHHI(Entity CMBJDMJHALL);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDHANHMCKOC(NativeArray<DALFAANKAOP> GEMGNHPNKMF, NativeArray<PCMEFCDKIED> NDJAACEKCOK);

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BMFKDNECPIB(DALFAANKAOP AAFHCAILJEB);

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NGPEJNIMDCE(DALFAANKAOP AAFHCAILJEB, out Collider JNLMKMJDNIN);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct PCMEFCDKIED : ISystemStateComponentData, IComponentData, IEquatable<PCMEFCDKIED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float3 MGGNICOGCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 CMEMGFNKADJ;

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x16944B0", Offset = "0x1692CB0", VA = "0x1816944B0", Slot = "4")]
	public bool Equals(PCMEFCDKIED MDHJAFNLPON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct KBJDMICBLPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Guid PCFHAIHNKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public string JKENAADABML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Vector3 NABPHMOHNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Quaternion KDPJNNPKKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Vector3 KACNEPKNFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public int DIPIFCKBJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Dictionary<string, object> DAKKAABHBLK;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F4A0", Offset = "0x5E1DCA0", VA = "0x185E1F4A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F310", Offset = "0x5E1DB10", VA = "0x185E1F310")]
	private static string BNBNLIMGNCF(Dictionary<string, object> AFPDPADDMJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public enum KGAPHIGMNEP
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public enum IAJFELLNNLD
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class LOMCOJOMMPD
{
	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0xC7C2F0", Offset = "0xC7AAF0", VA = "0x180C7C2F0")]
	public static bool EDPBBKHDPJM(this IAJFELLNNLD FIJCKHKKDCC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public interface CHIHGFEHFIA : FDMKLPADELH, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[Flags]
public enum CJPCEKMKPNL
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
public enum MNCGIEILBPK
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
public interface FPJINGKCDIG : FDMKLPADELH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	HMCKEPFICOF JEHFFDMDHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBDHDHCPNAJ();

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DBJEDAEEIFC();
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public interface HMCKEPFICOF
{
	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LNGLEFEGIFK(Guid LBADBCNNFAH, out Guid EBICJNCHIIB);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface KABJJEIAHLA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	GMBIPNIBCPJ BFEPJNKFLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString GBLNIBAJACB();
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface FDMKLPADELH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	IEnumerable<KBJDMICBLPJ> OBHKELAKBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	MIEJIEHKJBI PDOBJBHOHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	LocalId HKEDDLFMJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	GMBIPNIBCPJ NPLDLNDFIDC
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	Task CDEOMJIEABK
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BNHDLCIOKEP(CJPCEKMKPNL LMMLNHGPIFE);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
public interface PPMNJPKHDKN
{
	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDKDAIKBELO(CDGEIPMFEMD FAFPIHCBCLB, PIGHOFHDBAG AOGGNHKFEEF, ReadOnlySpan<byte> NOFFICDABAK, ReadOnlySpan<byte> MJINNJIFEPF);

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HCEFAGJEINK(CDGEIPMFEMD FAFPIHCBCLB, PIGHOFHDBAG AOGGNHKFEEF);

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CMMOPPBLNGG(CDGEIPMFEMD FAFPIHCBCLB, PIGHOFHDBAG AOGGNHKFEEF, ReadOnlySpan<byte> MJINNJIFEPF);

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JOILJLKKCBE(CDGEIPMFEMD FAFPIHCBCLB, PIGHOFHDBAG AOGGNHKFEEF, Span<byte> NOFFICDABAK, Span<byte> MJINNJIFEPF);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class IPOAPDIFNJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x243C260", Offset = "0x243AA60", VA = "0x18243C260")]
	public static bool JOILJLKKCBE<T>(this PPMNJPKHDKN FEOPOAEDKIN, CDGEIPMFEMD FAFPIHCBCLB, PIGHOFHDBAG AOGGNHKFEEF, out T NOFFICDABAK, out T MJINNJIFEPF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x243C130", Offset = "0x243A930", VA = "0x18243C130")]
	public static bool CMMOPPBLNGG<T>(this PPMNJPKHDKN FEOPOAEDKIN, CDGEIPMFEMD FAFPIHCBCLB, PIGHOFHDBAG AOGGNHKFEEF, T MJINNJIFEPF) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public enum BKPKCMKNEGK
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
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
public interface EMJOMIEGDHL : global::MCDCPLNHCBM<EMJOMIEGDHL>
{
	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PIGHOFHDBAG NOPLKMAJKCL(GGIKBJPJGCF BPOKAAOBIOI);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPCMNIEIIHN(PIGHOFHDBAG EDPPELMHBFA, DMCKJONIOKJ NOIKGIPKMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PFLIDDOFNIB(PIGHOFHDBAG EDPPELMHBFA, out DMCKJONIOKJ NOIKGIPKMFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class DCLODLGNDHI
{
	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x2E9F140", Offset = "0x2E9D940", VA = "0x182E9F140")]
	public static PIGHOFHDBAG NOPLKMAJKCL<T>(this EMJOMIEGDHL JEADDOCNIGI, global::MDFMNLBADDB<T> BPOKAAOBIOI)
	{
		return default(PIGHOFHDBAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	public static PIGHOFHDBAG JPCMNIEIIHN<T>(this EMJOMIEGDHL JEADDOCNIGI, global::MDFMNLBADDB<T> BPOKAAOBIOI, DMCKJONIOKJ NOIKGIPKMFJ) where T : struct
	{
		return default(PIGHOFHDBAG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
public interface FJBBNCNDMLD
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	uint COMJCEPBGGO
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct CCBIMOHAJDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public OAKBKBLFPOC PDHOFJLLEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public ReadOnlyMemory<byte> MEKBNGFFPML;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
public interface DFIMFFMODCD
{
	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBIHNHEKNMA(OAKBKBLFPOC PDHOFJLLEID, ReadOnlySpan<byte> MEKBNGFFPML);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public delegate bool HBDOIJGNAKB(PPMNJPKHDKN OANDNJEPPJB, in CCENOJCALNE ECNGHFJBIJL);
[Cpp2IlInjected.Token(Token = "0x2000096")]
public delegate bool GPIDPKBHHID<T>(PPMNJPKHDKN OANDNJEPPJB, in T ECNGHFJBIJL);
[Cpp2IlInjected.Token(Token = "0x2000097")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
public interface DNBPEFMIDOC
{
	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPCMNIEIIHN(PIGHOFHDBAG AOGGNHKFEEF, Type KIMGNJKGFMN, HBDOIJGNAKB CEKOHKOOFBA);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GDNIEHOKNOP(PIGHOFHDBAG AOGGNHKFEEF, out HBDOIJGNAKB CEKOHKOOFBA);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class BKEPCDIKDPC
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class PNKJPBBOPGC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public global::GPIDPKBHHID<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public PNKJPBBOPGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x2C68C20", Offset = "0x2C67420", VA = "0x182C68C20")]
		internal bool NJCKIHEMOCP(PPMNJPKHDKN pendingList, in CCENOJCALNE value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x4BAD2C0", Offset = "0x4BABAC0", VA = "0x184BAD2C0")]
	public static void JPCMNIEIIHN<T>(this DNBPEFMIDOC LOJMOJPJAMH, PIGHOFHDBAG AOGGNHKFEEF, global::GPIDPKBHHID<T> CEKOHKOOFBA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x5E159F0", Offset = "0x5E141F0", VA = "0x185E159F0")]
	public static bool ICHJAABMLHJ(this DNBPEFMIDOC LOJMOJPJAMH, PPMNJPKHDKN OANDNJEPPJB, PIGHOFHDBAG AOGGNHKFEEF, in CCENOJCALNE ECNGHFJBIJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct OAKBKBLFPOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public uint NGOGDFCDCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int DBKFIDONOEO;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x83CF30", Offset = "0x83B730", VA = "0x18083CF30")]
	public OAKBKBLFPOC(uint NGOGDFCDCCD, int DBKFIDONOEO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x5E22A80", Offset = "0x5E21280", VA = "0x185E22A80")]
	public static bool FMMDKFLNNFA(in OAKBKBLFPOC EOEOFNCKKHJ, in OAKBKBLFPOC AOEAFBFCPPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5E229F0", Offset = "0x5E211F0", VA = "0x185E229F0", Slot = "0")]
	public override bool Equals(object HHNPCHNMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x5E22AA0", Offset = "0x5E212A0", VA = "0x185E22AA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5E22AD0", Offset = "0x5E212D0", VA = "0x185E22AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
public interface GFPBPJFDGOI
{
	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OAKBKBLFPOC NEBNJLHKONO(ReadOnlySpan<byte> MEKBNGFFPML);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public interface DMCKJONIOKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	Type JDNOFHKFKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLJPEOGMFGO(ref JDMEGDECHOI GAPKPHPMEOL, Span<byte> CBHLPGJGAKG);

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ECCPKOGLKLF(ref OCBGHMJPILB FEHOOJAGKPN, ReadOnlySpan<byte> PDHOFJLLEID);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class OLFNBLMNJAJ
{
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public delegate void EPEOHBFPGLE(OAKBKBLFPOC BDFCACLHAFA, ReadOnlySpan<byte> MEKBNGFFPML);
[Cpp2IlInjected.Token(Token = "0x200009F")]
[IHCFIENIHKO(JBOAFHDNBDO.OMRoom)]
public interface PKNLBCKILDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EDMPMHACGNJ(OAKBKBLFPOC BDFCACLHAFA, ReadOnlySpan<byte> MEKBNGFFPML);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
