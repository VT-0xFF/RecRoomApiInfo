using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using Mono.Math;
using RecRoom.Components;
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LHHFLKFIFDL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> JGNNHLILKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CFBEFPIPHOM HHLMHCFLMDK(CFBEFPIPHOM KPNLPNEALHL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Entity HHLMHCFLMDK(Entity KPNLPNEALHL);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NIPPBJJLFPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	FBKJAGMDHMF FJPFHCMMMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PIIGAGDECED
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GIDONOBPNKN BLAHOJHKOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JDKEMADGCJE(ByteString DMDONNOOOJK, AAEGGCGNJEL AGFHKAICCAO = AAEGGCGNJEL.All);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ODKGJHJEKNG();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MFDBKIPJIIL();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PHEODFNJOHM();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JFFAIIABHKB();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IFPNJNOFHPP();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void COJMMEGIOJN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct AADKKGNCIPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public float3 BAFCICKIIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public quaternion ALKIIOKOBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float3 MJDIJCCGCED;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ENJAHHPPGPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FNPJNNKAEFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LJEGENIPLAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int OKDDHCPIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GJLHIFOEGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	BPHIMPPJCDN JEBNIEPMJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HIIKCJJCMCG OCABJKCFKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LHCLGLENANB(bool MAGFABKGNKB);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EBDAALAPLOC(NIPPBJJLFPM FLIFGDEMFID);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NBIJNMBOOPA(GameObject KFNNOPCEBCG, out MCOCAFPBHKN GFKNINEELBB);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HCJDBFMGBJC(GameObject KFNNOPCEBCG, out bool NNMGNADFEAC);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JHABANKAEDK(NativeArray<MCOCAFPBHKN> GFKNINEELBB, NativeArray<AADKKGNCIPP> CJCNOIMAAPK);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NNCLEEGIIBK EGOJJJFENOH(in MCOCAFPBHKN GFKNINEELBB, in Vector3 BAFCICKIIDG, in Quaternion ALKIIOKOBPG, in Vector3 MJDIJCCGCED);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OGNJDAODHHN(GameObject KFNNOPCEBCG, bool ANMIKBKEBOB);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DPMFBEIPMJM(GameObject KFNNOPCEBCG);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task IHBNGIOIGBF();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AACAOJHICCL(object GPGPHLEMPIJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IIGIGHMENLH(object GPGPHLEMPIJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DLJHNLDFCID(object KDGHFFBPFDE);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool MNHJAIKBOBJ(object AFJGLEGGBOF, [Optional] object GNBGKGLJPPO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GKKEBDIDBGG(Transform EOBPGPELLLJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PECACOPBJHE(Transform EOBPGPELLLJ, MOIAKKPEEBP MIAMFBEJLDG);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void MGJHCCOLDJE(Transform EOBPGPELLLJ, IGFMCOLGPHP INBPHFALNCP);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IAFJCPAOOOC(GameObject KFNNOPCEBCG, BKFAAPNNILK FCJBEHIFLNB);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Vector3 PLGCCCFGNNG(GameObject KFNNOPCEBCG, int PPOAAPIJGCI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GIDONOBPNKN
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	FBKJAGMDHMF FJPFHCMMMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	ENJAHHPPGPN FFIHAAFFBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HFEGCOONMAM JAGNOKIGICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	NIPPBJJLFPM HFEICCLODGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	FOJPBIGOEBJ COKDEHMBBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	DEGKEFODIJP ABMNDBMJIJA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	HIPDIEDHHMJ CHAOBDNLKEI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FCGCJNHMCDH DCMPMMMNCFA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	CKLENHMGEIH OJOPOBEELHA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	NBEIBLIFPGD GPDGCAFEFPC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	AINBLNOJEEC ECHCFPCIPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	GMIEFABEJHP KOBOGKHACLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	OPJJGBNKIAF KNIIIEIDDKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	DGGIPLGOKHJ JHMPKHIMHCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	FHCDFMOJBCC FJOJPJBILFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	MGIHGMHOKEE HGMDBOMADIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	DIAELLIMJAK PJPGLNLHADD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct HHPKOLIEIPI<TKey> : IDisposable where TKey : struct, IEquatable<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct KPMCOHGJODB
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeHashMap<TKey, KPMCOHGJODB> OMEFEABFKAE;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public struct FCCBMJGNNEF : IReadOnlyList<CFBEFPIPHOM>, IEnumerable<CFBEFPIPHOM>, IEnumerable, IReadOnlyCollection<CFBEFPIPHOM>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct MBDOLKNGPDG : IEnumerator<CFBEFPIPHOM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly FOJPBIGOEBJ NLJLBCPPCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<Entity>.Enumerator PBDDMPLIKAI;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public CFBEFPIPHOM HLHDNNKPFLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3EFFCC0", Offset = "0x3EFE4C0", VA = "0x183EFFCC0", Slot = "4")]
			get
			{
				return default(CFBEFPIPHOM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3EFFBF0", Offset = "0x3EFE3F0", VA = "0x183EFFBF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xECDB90", Offset = "0xECC390", VA = "0x180ECDB90")]
		public MBDOLKNGPDG(FOJPBIGOEBJ NLJLBCPPCEG, NativeArray<Entity>.Enumerator PBDDMPLIKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3EFFB30", Offset = "0x3EFE330", VA = "0x183EFFB30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3EFFB70", Offset = "0x3EFE370", VA = "0x183EFFB70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3EFFBB0", Offset = "0x3EFE3B0", VA = "0x183EFFBB0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FOJPBIGOEBJ NLJLBCPPCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeArray<Entity> NLBMCCOBHKD;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CFBEFPIPHOM NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3EFA5B0", Offset = "0x3EF8DB0", VA = "0x183EFA5B0", Slot = "4")]
		get
		{
			return default(CFBEFPIPHOM);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3EFA170", Offset = "0x3EF8970", VA = "0x183EFA170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private int EPCBJCKABNO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6348F0", Offset = "0x6330F0", VA = "0x1806348F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int KJDFLCMLCGF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6348F0", Offset = "0x6330F0", VA = "0x1806348F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool JCLGOONBLNF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3EFA260", Offset = "0x3EF8A60", VA = "0x183EFA260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public NativeArray<Entity> HHCGHHNMLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xECE4C0", Offset = "0xECCCC0", VA = "0x180ECE4C0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3EFA510", Offset = "0x3EF8D10", VA = "0x183EFA510")]
	public FCCBMJGNNEF(int JPMPKCEDKPJ, FOJPBIGOEBJ NLJLBCPPCEG, Allocator DDJPHGFEOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xCFBD50", Offset = "0xCFA550", VA = "0x180CFBD50")]
	public FCCBMJGNNEF(FOJPBIGOEBJ NLJLBCPPCEG, NativeArray<Entity> NLBMCCOBHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3EFA460", Offset = "0x3EF8C60", VA = "0x183EFA460")]
	public FCCBMJGNNEF(FCCBMJGNNEF KLEHFKLBEMN, Allocator DDJPHGFEOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3EFA180", Offset = "0x3EF8980", VA = "0x183EFA180", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3EFA1C0", Offset = "0x3EF89C0", VA = "0x183EFA1C0")]
	public MBDOLKNGPDG JMGPEBMNFFJ()
	{
		return default(MBDOLKNGPDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3EFA2A0", Offset = "0x3EF8AA0", VA = "0x183EFA2A0", Slot = "6")]
	private IEnumerator<CFBEFPIPHOM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3EFA380", Offset = "0x3EF8B80", VA = "0x183EFA380", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DebuggerTypeProxy(typeof(BOIPBIAIIND))]
public struct CFBEFPIPHOM : IComparable<CFBEFPIPHOM>, IEquatable<CFBEFPIPHOM>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly CFBEFPIPHOM EOOIPOMJEJG;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public FOJPBIGOEBJ COKDEHMBBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6DA260", Offset = "0x6D8A60", VA = "0x1806DA260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Entity LLFIHJDDJGH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6DA250", Offset = "0x6D8A50", VA = "0x1806DA250")]
		[CompilerGenerated]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x10CD9E0", Offset = "0x10CC1E0", VA = "0x1810CD9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool CPNLIKCPMHB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8D80", Offset = "0x3EF7580", VA = "0x183EF8D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool OHLPCPFMMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8FA0", Offset = "0x3EF77A0", VA = "0x183EF8FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool NKBMJECLOCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8E70", Offset = "0x3EF7670", VA = "0x183EF8E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3EF9040", Offset = "0x3EF7840", VA = "0x183EF9040")]
	public CFBEFPIPHOM(FOJPBIGOEBJ BIMFEMAEJGD, Entity NBIJCGHBCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
	public BKIEEIBJMKG FEBNGBHOBGG()
	{
		return default(BKIEEIBJMKG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6DA250", Offset = "0x6D8A50", VA = "0x1806DA250")]
	public static Entity HLHIMDAEEEO(CFBEFPIPHOM CJIGGIKGLNO)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3EF8F50", Offset = "0x3EF7750", VA = "0x183EF8F50")]
	public static bool LLPKNBIICCC(CFBEFPIPHOM DKLHMFCLOAB, CFBEFPIPHOM FLEBMPFFCAA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3EF8FD0", Offset = "0x3EF77D0", VA = "0x183EF8FD0")]
	public static bool PNNBKKFLHKP(CFBEFPIPHOM DKLHMFCLOAB, CFBEFPIPHOM FLEBMPFFCAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3EF9020", Offset = "0x3EF7820", VA = "0x183EF9020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3EF8DD0", Offset = "0x3EF75D0", VA = "0x183EF8DD0", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xAECF60", Offset = "0xAEB760", VA = "0x180AECF60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3EF8D20", Offset = "0x3EF7520", VA = "0x183EF8D20", Slot = "4")]
	public int CompareTo(CFBEFPIPHOM ALBOAABJIJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "5")]
	public bool Equals(CFBEFPIPHOM ALBOAABJIJF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PBOJOLAOCFN
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3F00720", Offset = "0x3EFEF20", VA = "0x183F00720")]
	public static MCOCAFPBHKN DCDNMCENJCL(this CFBEFPIPHOM LEPHKDIHJFD)
	{
		return default(MCOCAFPBHKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3F00820", Offset = "0x3EFF020", VA = "0x183F00820")]
	public static BKIEEIBJMKG EIDBIEHIAEK(this CFBEFPIPHOM DEGGOOGCHFA, [Optional] object HMOHICKINOJ)
	{
		return default(BKIEEIBJMKG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal sealed class BOIPBIAIIND
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct LGDKNEJIEJC
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const uint EGOMKGNFOCM = 2147483648u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly AJGLDHBFLPA MMECDMIFJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal readonly AJGLDHBFLPA NOOMMODKENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly uint BLBPBLODIPP;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool CPNLIKCPMHB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x3EFF5B0", Offset = "0x3EFDDB0", VA = "0x183EFF5B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public uint MAJPFGOCDAG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x355F700", Offset = "0x355DF00", VA = "0x18355F700")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3EFF880", Offset = "0x3EFE080", VA = "0x183EFF880")]
	public LGDKNEJIEJC(AJGLDHBFLPA MMECDMIFJKL, AJGLDHBFLPA NOOMMODKENI, uint BLBPBLODIPP, bool KALMELICGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3EFF5C0", Offset = "0x3EFDDC0", VA = "0x183EFF5C0")]
	public bool IANDMFPODBI(LGDKNEJIEJC ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3EFF610", Offset = "0x3EFDE10", VA = "0x183EFF610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DOHCKPDOJMD(PAPAHBCPMGP.History)]
	public readonly struct UndoAction
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		internal readonly LGDKNEJIEJC MJHIGMCCOPA;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool CPNLIKCPMHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3EFF5B0", Offset = "0x3EFDDB0", VA = "0x183EFF5B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2E19910", Offset = "0x2E18110", VA = "0x182E19910")]
		internal UndoAction(LGDKNEJIEJC MJHIGMCCOPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3F00DF0", Offset = "0x3EFF5F0", VA = "0x183F00DF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DOHCKPDOJMD(PAPAHBCPMGP.History)]
	public readonly struct RedoAction
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal readonly LGDKNEJIEJC MJHIGMCCOPA;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool CPNLIKCPMHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x3EFF5B0", Offset = "0x3EFDDB0", VA = "0x183EFF5B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2E19910", Offset = "0x2E18110", VA = "0x182E19910")]
		internal RedoAction(LGDKNEJIEJC MJHIGMCCOPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3F00DF0", Offset = "0x3EFF5F0", VA = "0x183F00DF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct PDNOMKJLIJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	internal readonly uint BLBPBLODIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal readonly bool MLEOKCCGLKC;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3F00970", Offset = "0x3EFF170", VA = "0x183F00970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct AJGLDHBFLPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal int IBIPCEJMDGF;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x825F70", Offset = "0x824770", VA = "0x180825F70")]
	public AJGLDHBFLPA(int IBIPCEJMDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3EF60D0", Offset = "0x3EF48D0", VA = "0x183EF60D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum FGDPNBCKGJP
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Embodied,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Disembodying,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Disembodied
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NNCLEEGIIBK : JEBFPKINFDH
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	FGDPNBCKGJP HKCNKIGLIMG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool BDHGNDIDKCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	GameObject KFNNOPCEBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OnEmbody(HFEGCOONMAM LMKNNIPOPLE, CFBEFPIPHOM GLFHHHLLMDK);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnDisembody(bool LGHILPKOFIL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class NELEJMBFGKK
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3F002C0", Offset = "0x3EFEAC0", VA = "0x183F002C0")]
	public static bool GJPEFJBAECC(this NNCLEEGIIBK MDLJNEBAIPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3F003A0", Offset = "0x3EFEBA0", VA = "0x183F003A0")]
	public static bool KPEOKFEDEEC(this NNCLEEGIIBK MDLJNEBAIPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3F00270", Offset = "0x3EFEA70", VA = "0x183F00270")]
	public static bool FCDFNKEDHKG(this NNCLEEGIIBK MDLJNEBAIPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3F00310", Offset = "0x3EFEB10", VA = "0x183F00310")]
	public static bool JAADKEOKHCH(this NNCLEEGIIBK MDLJNEBAIPD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JEBFPKINFDH
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	CFBEFPIPHOM BNLNJFHLOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NJFOBBNGILB : global::FEFJONNJDKD<MCOCAFPBHKN>, PMNGPOALGLO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string EADEMHAIMKE(in BJHFEKKLKGB CJMMBFLIBMO);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LCHBJNMGJAE<T> : global::KMAABHDKKLE<MCOCAFPBHKN, T>, global::FEFJONNJDKD<MCOCAFPBHKN>, PMNGPOALGLO, IDisposable, NJFOBBNGILB where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HPBPJBBHIID
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8FF0A0", Offset = "0x8FD8A0", VA = "0x1808FF0A0")]
	public static T NOBGIOELFLB<T>(this global::FEFJONNJDKD<MCOCAFPBHKN> IOADAIMHMFG, MCOCAFPBHKN GFKNINEELBB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x178D110", Offset = "0x178B910", VA = "0x18178D110")]
	public static bool HEMBJNPDPPJ<T>(this global::FEFJONNJDKD<MCOCAFPBHKN> IOADAIMHMFG, MCOCAFPBHKN GFKNINEELBB, in T JFBNMEBIPAN) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HMMELKFLGKD : global::FEFJONNJDKD<CFBEFPIPHOM>, PMNGPOALGLO, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FMGDPJPCCFA<T> : global::KMAABHDKKLE<CFBEFPIPHOM, T>, global::FEFJONNJDKD<CFBEFPIPHOM>, PMNGPOALGLO, IDisposable, HMMELKFLGKD where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class KCCEMPGFONK
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1C3F370", Offset = "0x1C3DB70", VA = "0x181C3F370")]
	public static T NOBGIOELFLB<T>(this global::FEFJONNJDKD<CFBEFPIPHOM> IOADAIMHMFG, CFBEFPIPHOM LEPHKDIHJFD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1791F80", Offset = "0x1790780", VA = "0x181791F80")]
	public static bool HEMBJNPDPPJ<T>(this global::FEFJONNJDKD<CFBEFPIPHOM> IOADAIMHMFG, CFBEFPIPHOM LEPHKDIHJFD, in T JFBNMEBIPAN) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct MIPCILJMDGJ : IComparable<MIPCILJMDGJ>, IEquatable<MIPCILJMDGJ>
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly MIPCILJMDGJ EOOIPOMJEJG;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly MIPCILJMDGJ JDCINKDFFNF;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly MIPCILJMDGJ AEKFCCGOHEB;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly MIPCILJMDGJ AEFDAAEMODH;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly MIPCILJMDGJ LBKLLANPPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public int PDGADEKDACK;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x825F70", Offset = "0x824770", VA = "0x180825F70")]
	public MIPCILJMDGJ(int AKLHCIJHJKB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xC66D90", Offset = "0xC65590", VA = "0x180C66D90")]
	public static bool LLPKNBIICCC(MIPCILJMDGJ DKLHMFCLOAB, MIPCILJMDGJ FLEBMPFFCAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3F000C0", Offset = "0x3EFE8C0", VA = "0x183F000C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3F00040", Offset = "0x3EFE840", VA = "0x183F00040", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6D3600", Offset = "0x6D1E00", VA = "0x1806D3600", Slot = "5")]
	public bool Equals(MIPCILJMDGJ ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xC6C7B0", Offset = "0xC6AFB0", VA = "0x180C6C7B0", Slot = "4")]
	public int CompareTo(MIPCILJMDGJ ALBOAABJIJF)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xC66DA0", Offset = "0xC655A0", VA = "0x180C66DA0")]
	public static MIPCILJMDGJ HLHIMDAEEEO(int AKLHCIJHJKB)
	{
		return default(MIPCILJMDGJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xC66DA0", Offset = "0xC655A0", VA = "0x180C66DA0")]
	public static int HLHIMDAEEEO(MIPCILJMDGJ KBHHIDGOLNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3F00120", Offset = "0x3EFE920", VA = "0x183F00120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct BKIEEIBJMKG : IEquatable<BKIEEIBJMKG>, JEBFPKINFDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public CFBEFPIPHOM BNLNJFHLOKF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x86BC00", Offset = "0x86A400", VA = "0x18086BC00", Slot = "5")]
		get
		{
			return default(CFBEFPIPHOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public FOJAOFJKAGF NBJIGELBGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(FOJAOFJKAGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public JGGOMBBEMFD ABMNDBMJIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(JGGOMBBEMFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private FOJPBIGOEBJ COKDEHMBBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public GameObject KFNNOPCEBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3EF71F0", Offset = "0x3EF59F0", VA = "0x183EF71F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public MCOCAFPBHKN BHBEJABGJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6D40", Offset = "0x3EF5540", VA = "0x183EF6D40")]
		get
		{
			return default(MCOCAFPBHKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public MNBPBHNFCPJ HEHAMFHIPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6A50", Offset = "0x3EF5250", VA = "0x183EF6A50")]
		get
		{
			return default(MNBPBHNFCPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public HEIIJIHIAKK PPONIPDEIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7360", Offset = "0x3EF5B60", VA = "0x183EF7360")]
		get
		{
			return default(HEIIJIHIAKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool OAEMKONHBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6A10", Offset = "0x3EF5210", VA = "0x183EF6A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool DMPMPDGCONN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3EF69D0", Offset = "0x3EF51D0", VA = "0x183EF69D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool MGCEPGJLBGA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3EF69F0", Offset = "0x3EF51F0", VA = "0x183EF69F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool CBBEODBPAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6E10", Offset = "0x3EF5610", VA = "0x183EF6E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool NNLPPDFFIKL
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6A30", Offset = "0x3EF5230", VA = "0x183EF6A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool PCDFDAMCCIE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6D20", Offset = "0x3EF5520", VA = "0x183EF6D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool OACNDCAIPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6D00", Offset = "0x3EF5500", VA = "0x183EF6D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public KICGABHBMDE HMACFFEDADF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(KICGABHBMDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public ANILAGPFFAK KMPPAIJKHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(ANILAGPFFAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public CGIKGEBEMPB HGMDBOMADIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(CGIKGEBEMPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public JPJDENDKADH ENILBAIOONM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(JPJDENDKADH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public JDHNLEDMPPM JHMPKHIMHCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(JDHNLEDMPPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public EEHJOBCJODM BJGDCBDBJBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(EEHJOBCJODM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool GJPEFJBAECC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6E30", Offset = "0x3EF5630", VA = "0x183EF6E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1F64C80", Offset = "0x1F63480", VA = "0x181F64C80")]
	public BKIEEIBJMKG(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6CC0", Offset = "0x3EF54C0", VA = "0x183EF6CC0")]
	public static bool HLHIMDAEEEO(BKIEEIBJMKG CJMMBFLIBMO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x86BC00", Offset = "0x86A400", VA = "0x18086BC00")]
	public static CFBEFPIPHOM HLHIMDAEEEO(BKIEEIBJMKG CJMMBFLIBMO)
	{
		return default(CFBEFPIPHOM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50")]
	public static bool LLPKNBIICCC(BKIEEIBJMKG DKLHMFCLOAB, BKIEEIBJMKG FLEBMPFFCAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6C10", Offset = "0x3EF5410", VA = "0x183EF6C10", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(BKIEEIBJMKG ALBOAABJIJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
	public static BKIEEIBJMKG HLHIMDAEEEO(CFBEFPIPHOM MEDLGIKFPNL)
	{
		return default(BKIEEIBJMKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7300", Offset = "0x3EF5B00", VA = "0x183EF7300")]
	public CLMHOEMCILK OJCNLKCPLMK()
	{
		return default(CLMHOEMCILK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7040", Offset = "0x3EF5840", VA = "0x183EF7040")]
	public BLLFBFCFDFI MKKCCPKEDBP()
	{
		return default(BLLFBFCFDFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6FE0", Offset = "0x3EF57E0", VA = "0x183EF6FE0")]
	public PPAOPCOFLAL LDOKCFMLELF()
	{
		return default(PPAOPCOFLAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7190", Offset = "0x3EF5990", VA = "0x183EF7190")]
	public NOPCNLDHECI NMCBDNOAFAD()
	{
		return default(NOPCNLDHECI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6B30", Offset = "0x3EF5330", VA = "0x183EF6B30")]
	public void EIDBIEHIAEK([Optional] object HMOHICKINOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6F10", Offset = "0x3EF5710", VA = "0x183EF6F10")]
	public void KGEPALGALDH(object HMOHICKINOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3EF70A0", Offset = "0x3EF58A0", VA = "0x183EF70A0")]
	public bool MNFPKMAEIFA(object HMOHICKINOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7440", Offset = "0x3EF5C40", VA = "0x183EF7440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct CLMHOEMCILK : IEquatable<CLMHOEMCILK>
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly CLMHOEMCILK JNMBFHLLFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public CFBEFPIPHOM BNLNJFHLOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x86BC00", Offset = "0x86A400", VA = "0x18086BC00")]
		get
		{
			return default(CFBEFPIPHOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public FOJAOFJKAGF NBJIGELBGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(FOJAOFJKAGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public JGGOMBBEMFD ABMNDBMJIJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(JGGOMBBEMFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private FOJPBIGOEBJ COKDEHMBBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private GIDONOBPNKN BLAHOJHKOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9A10", Offset = "0x3EF8210", VA = "0x183EF9A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private DEGKEFODIJP BGKGGCKELEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9570", Offset = "0x3EF7D70", VA = "0x183EF9570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public IEnumerable<CFBEFPIPHOM> DPOLJNHHJEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9B70", Offset = "0x3EF8370", VA = "0x183EF9B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public IEnumerable<BKIEEIBJMKG> EJJNHBDBKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9460", Offset = "0x3EF7C60", VA = "0x183EF9460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public IEnumerable<BKIEEIBJMKG> NAPPAEOBEME
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9A60", Offset = "0x3EF8260", VA = "0x183EF9A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public int AKGLECAHOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9380", Offset = "0x3EF7B80", VA = "0x183EF9380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int GHEBHKCNHIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3EF99C0", Offset = "0x3EF81C0", VA = "0x183EF99C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public string JMBPOHFOGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3EF98E0", Offset = "0x3EF80E0", VA = "0x183EF98E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1F64C80", Offset = "0x1F63480", VA = "0x181F64C80")]
	public CLMHOEMCILK(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6CC0", Offset = "0x3EF54C0", VA = "0x183EF6CC0")]
	public static bool HLHIMDAEEEO(CLMHOEMCILK CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3EF9610", Offset = "0x3EF7E10", VA = "0x183EF9610", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(CLMHOEMCILK ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
	public static BKIEEIBJMKG HLHIMDAEEEO(CLMHOEMCILK IGEIPKGINDO)
	{
		return default(BKIEEIBJMKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3EF95F0", Offset = "0x3EF7DF0", VA = "0x183EF95F0")]
	public bool EIBFCDPOKEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3EF96C0", Offset = "0x3EF7EC0", VA = "0x183EF96C0")]
	public FCCBMJGNNEF FFFDGOGDGMH(Allocator DDJPHGFEOFF)
	{
		return default(FCCBMJGNNEF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct HJJJKPDHCLP : IEquatable<HJJJKPDHCLP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3EFD7D0", Offset = "0x3EFBFD0", VA = "0x183EFD7D0", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(HJJJKPDHCLP ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct ANILAGPFFAK : IEquatable<ANILAGPFFAK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private FOJPBIGOEBJ COKDEHMBBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F64C80", Offset = "0x1F63480", VA = "0x181F64C80")]
	public ANILAGPFFAK(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6780", Offset = "0x3EF4F80", VA = "0x183EF6780", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(ANILAGPFFAK ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6830", Offset = "0x3EF5030", VA = "0x183EF6830")]
	public void LIPJKPPEBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6900", Offset = "0x3EF5100", VA = "0x183EF6900")]
	public void NAPPOONKJCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct PPAOPCOFLAL : IEquatable<PPAOPCOFLAL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F64C80", Offset = "0x1F63480", VA = "0x181F64C80")]
	public PPAOPCOFLAL(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3F00D40", Offset = "0x3EFF540", VA = "0x183F00D40", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(PPAOPCOFLAL ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct AGPEOFGEPHN : IEquatable<AGPEOFGEPHN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5FA0", Offset = "0x3EF47A0", VA = "0x183EF5FA0", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(AGPEOFGEPHN ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct HHPCBHLNIFP : IEquatable<HHPCBHLNIFP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3EFD720", Offset = "0x3EFBF20", VA = "0x183EFD720", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(HHPCBHLNIFP ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct LLDMHMKOEMI : IEquatable<LLDMHMKOEMI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3EFF8A0", Offset = "0x3EFE0A0", VA = "0x183EFF8A0", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(LLDMHMKOEMI ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct JGGOMBBEMFD : IEquatable<JGGOMBBEMFD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public CFBEFPIPHOM BNLNJFHLOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x86BC00", Offset = "0x86A400", VA = "0x18086BC00")]
		get
		{
			return default(CFBEFPIPHOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	private FOJPBIGOEBJ COKDEHMBBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	private GIDONOBPNKN BLAHOJHKOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE7C0", Offset = "0x3EFCFC0", VA = "0x183EFE7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private DEGKEFODIJP BGKGGCKELEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE590", Offset = "0x3EFCD90", VA = "0x183EFE590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public CFBEFPIPHOM NIKHLLGMADG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE810", Offset = "0x3EFD010", VA = "0x183EFE810")]
		get
		{
			return default(CFBEFPIPHOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public BKIEEIBJMKG OLJDFKOJMEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE6C0", Offset = "0x3EFCEC0", VA = "0x183EFE6C0")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1F64C80", Offset = "0x1F63480", VA = "0x181F64C80")]
	public JGGOMBBEMFD(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3EFE610", Offset = "0x3EFCE10", VA = "0x183EFE610", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(JGGOMBBEMFD ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3EFE900", Offset = "0x3EFD100", VA = "0x183EFE900")]
	public bool MEIKIKOFGKA(BKIEEIBJMKG CELKNCFBAOE, bool BONIBHBAFFM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3EFEA10", Offset = "0x3EFD210", VA = "0x183EFEA10")]
	public bool MFEJJMDALEL(BKIEEIBJMKG ELKNCMDOGDP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct KICGABHBMDE : IEquatable<KICGABHBMDE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public string OKPLMMNJHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3EFF280", Offset = "0x3EFDA80", VA = "0x183EFF280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1F64C80", Offset = "0x1F63480", VA = "0x181F64C80")]
	public KICGABHBMDE(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3EFF2C0", Offset = "0x3EFDAC0", VA = "0x183EFF2C0", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(KICGABHBMDE ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct KPJKPGAJIPH : IEquatable<KPJKPGAJIPH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3EFF500", Offset = "0x3EFDD00", VA = "0x183EFF500", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(KPJKPGAJIPH ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct CGIKGEBEMPB : IEquatable<CGIKGEBEMPB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public CFBEFPIPHOM BNLNJFHLOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x86BC00", Offset = "0x86A400", VA = "0x18086BC00")]
		get
		{
			return default(CFBEFPIPHOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float IDEHBIJMKHP
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9090", Offset = "0x3EF7890", VA = "0x183EF9090")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 IENJNHEMJAL
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3EF92D0", Offset = "0x3EF7AD0", VA = "0x183EF92D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1F64C80", Offset = "0x1F63480", VA = "0x181F64C80")]
	public CGIKGEBEMPB(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3EF9220", Offset = "0x3EF7A20", VA = "0x183EF9220", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(CGIKGEBEMPB ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3EF9100", Offset = "0x3EF7900", VA = "0x183EF9100")]
	public bool EJPHCBKJDBD(out Collider OKCFJNOIDBD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct JPJDENDKADH : IEquatable<JPJDENDKADH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private JMCGHFPHKDF JIILLENBGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3EFF030", Offset = "0x3EFD830", VA = "0x183EFF030")]
		get
		{
			return default(JMCGHFPHKDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool ABINMADOMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3EFEBD0", Offset = "0x3EFD3D0", VA = "0x183EFEBD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool AFEKFBHHJLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3EFEC40", Offset = "0x3EFD440", VA = "0x183EFEC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool KPHNJOGGPND
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3EFEEC0", Offset = "0x3EFD6C0", VA = "0x183EFEEC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool AFIGBLBCCCG
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3EFEE10", Offset = "0x3EFD610", VA = "0x183EFEE10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool DGJFIGJBGLN
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3EFEE30", Offset = "0x3EFD630", VA = "0x183EFEE30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool COKHIAMIDJI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3EFEE00", Offset = "0x3EFD600", VA = "0x183EFEE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool DAMMMEDFAEF
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x3EFEED0", Offset = "0x3EFD6D0", VA = "0x183EFEED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool JELHBOEBGII
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3EFF020", Offset = "0x3EFD820", VA = "0x183EFF020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public bool FFLFBFOBLLO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3EFEE20", Offset = "0x3EFD620", VA = "0x183EFEE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool PLMBGDNCKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3EFF010", Offset = "0x3EFD810", VA = "0x183EFF010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool MJDGMAJMMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3EFEC50", Offset = "0x3EFD450", VA = "0x183EFEC50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public bool ECMIEFIACKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3EFEC60", Offset = "0x3EFD460", VA = "0x183EFEC60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public bool IKNALCGCIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3EFEEE0", Offset = "0x3EFD6E0", VA = "0x183EFEEE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 JEDDCECJIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3EFEB00", Offset = "0x3EFD300", VA = "0x183EFEB00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Vector3 FIJILDGGLAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3EFEF50", Offset = "0x3EFD750", VA = "0x183EFEF50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1F64C80", Offset = "0x1F63480", VA = "0x181F64C80")]
	public JPJDENDKADH(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3EFED50", Offset = "0x3EFD550", VA = "0x183EFED50", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(JPJDENDKADH ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3EFEE40", Offset = "0x3EFD640", VA = "0x183EFEE40")]
	public bool JKFMBLAHLFP(IALKPOKNGGM FNBJDMBIOKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3EFEC70", Offset = "0x3EFD470", VA = "0x183EFEC70")]
	public void DDJDJKBKBDJ(IALKPOKNGGM FNBJDMBIOKK, bool IMIPLIDOHFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct NOPCNLDHECI : IEquatable<NOPCNLDHECI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private HBCJNBPIAPG GBBCPLLGELP
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x3F005C0", Offset = "0x3EFEDC0", VA = "0x183F005C0")]
		get
		{
			return default(HBCJNBPIAPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public JBEILNODJLP PONJGCAAAPF
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x3F004A0", Offset = "0x3EFECA0", VA = "0x183F004A0")]
		get
		{
			return default(JBEILNODJLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x1F64C80", Offset = "0x1F63480", VA = "0x181F64C80")]
	public NOPCNLDHECI(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3F003F0", Offset = "0x3EFEBF0", VA = "0x183F003F0", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(NOPCNLDHECI ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3F00510", Offset = "0x3EFED10", VA = "0x183F00510")]
	public KPCELMGFPAF MJIFKALPAEM()
	{
		return default(KPCELMGFPAF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct KPCELMGFPAF : IEquatable<KPCELMGFPAF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private EKNKIDLEOBN JBMDBIGLGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3EFF4A0", Offset = "0x3EFDCA0", VA = "0x183EFF4A0")]
		get
		{
			return default(EKNKIDLEOBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public MINFGCMJKBL KOGACKONFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x3EFF370", Offset = "0x3EFDB70", VA = "0x183EFF370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x1F64C80", Offset = "0x1F63480", VA = "0x181F64C80")]
	public KPCELMGFPAF(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3EFF3F0", Offset = "0x3EFDBF0", VA = "0x183EFF3F0", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(KPCELMGFPAF ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct EEHJOBCJODM : IEquatable<EEHJOBCJODM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private FOJPBIGOEBJ COKDEHMBBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private GIDONOBPNKN BLAHOJHKOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9FF0", Offset = "0x3EF87F0", VA = "0x183EF9FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x1F64C80", Offset = "0x1F63480", VA = "0x181F64C80")]
	public EEHJOBCJODM(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF9E00", Offset = "0x3EF8600", VA = "0x183EF9E00", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(EEHJOBCJODM ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3EFA040", Offset = "0x3EF8840", VA = "0x183EFA040")]
	public void NPBCOPCMENI(bool CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3EF9EB0", Offset = "0x3EF86B0", VA = "0x183EF9EB0")]
	public void FCDHMLDDIEE(bool CJMMBFLIBMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct JDHNLEDMPPM : IEquatable<JDHNLEDMPPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public CFBEFPIPHOM BNLNJFHLOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x86BC00", Offset = "0x86A400", VA = "0x18086BC00")]
		get
		{
			return default(CFBEFPIPHOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private FOJPBIGOEBJ COKDEHMBBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private GIDONOBPNKN BLAHOJHKOBM
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE280", Offset = "0x3EFCA80", VA = "0x183EFE280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private DGGIPLGOKHJ EOIFMOBHENA
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE120", Offset = "0x3EFC920", VA = "0x183EFE120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool MNIGEBADBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE1A0", Offset = "0x3EFC9A0", VA = "0x183EFE1A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool OPKMAIDODJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE490", Offset = "0x3EFCC90", VA = "0x183EFE490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool JDHOKAGOOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE460", Offset = "0x3EFCC60", VA = "0x183EFE460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool IHJBEDOMNBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE2D0", Offset = "0x3EFCAD0", VA = "0x183EFE2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool APIIGKDIAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3EFDE10", Offset = "0x3EFC610", VA = "0x183EFDE10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool CJIOGGEKKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3EFDF10", Offset = "0x3EFC710", VA = "0x183EFDF10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x1F64C80", Offset = "0x1F63480", VA = "0x181F64C80")]
	public JDHNLEDMPPM(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6CC0", Offset = "0x3EF54C0", VA = "0x183EF6CC0")]
	public static bool HLHIMDAEEEO(JDHNLEDMPPM CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3EFE070", Offset = "0x3EFC870", VA = "0x183EFE070", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(JDHNLEDMPPM ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3EFE300", Offset = "0x3EFCB00", VA = "0x183EFE300")]
	public void MHGMLGGAGPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3EFE330", Offset = "0x3EFCB30", VA = "0x183EFE330")]
	public BKIEEIBJMKG MJOKOCIJMOO(BKIEEIBJMKG GPGPHLEMPIJ)
	{
		return default(BKIEEIBJMKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3EFDC50", Offset = "0x3EFC450", VA = "0x183EFDC50")]
	public CFBEFPIPHOM AJOJFAIADGH()
	{
		return default(CFBEFPIPHOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct BLLFBFCFDFI : IEquatable<BLLFBFCFDFI>
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly BLLFBFCFDFI JNMBFHLLFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CFBEFPIPHOM BNLNJFHLOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x86BC00", Offset = "0x86A400", VA = "0x18086BC00")]
		get
		{
			return default(CFBEFPIPHOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public FOJAOFJKAGF NBJIGELBGDB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(FOJAOFJKAGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private LPMJFLBINNI NEPHJLGNGDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7B40", Offset = "0x3EF6340", VA = "0x183EF7B40")]
		get
		{
			return default(LPMJFLBINNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public GLHLHKJFECD ODDHKMBILGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7730", Offset = "0x3EF5F30", VA = "0x183EF7730")]
		get
		{
			return default(GLHLHKJFECD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public EPIKIGEFNBH KEAMIMEJNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3EF75F0", Offset = "0x3EF5DF0", VA = "0x183EF75F0")]
		get
		{
			return default(EPIKIGEFNBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public LIJIPOABCIK CEMPDHDFCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7C20", Offset = "0x3EF6420", VA = "0x183EF7C20")]
		get
		{
			return default(LIJIPOABCIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public HKLFFMNFEFK FFIMMNDHBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7990", Offset = "0x3EF6190", VA = "0x183EF7990")]
		get
		{
			return default(HKLFFMNFEFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public GKJAAHKBHAN KJJMAICBAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7840", Offset = "0x3EF6040", VA = "0x183EF7840")]
		get
		{
			return default(GKJAAHKBHAN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7C80", Offset = "0x3EF6480", VA = "0x183EF7C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public FLDBANCHKMF EMFCGNEGLJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7580", Offset = "0x3EF5D80", VA = "0x183EF7580")]
		get
		{
			return default(FLDBANCHKMF);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7D00", Offset = "0x3EF6500", VA = "0x183EF7D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public float BPMFOOEEIOK
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7AD0", Offset = "0x3EF62D0", VA = "0x183EF7AD0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3EF78B0", Offset = "0x3EF60B0", VA = "0x183EF78B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Vector3 APAHLHEGLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7A40", Offset = "0x3EF6240", VA = "0x183EF7A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public float FPBFJMBJCMO
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3EF76B0", Offset = "0x3EF5EB0", VA = "0x183EF76B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public ShapeConfigData.Flags PBEKHAKJJDP
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7510", Offset = "0x3EF5D10", VA = "0x183EF7510")]
		get
		{
			return default(ShapeConfigData.Flags);
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7BA0", Offset = "0x3EF63A0", VA = "0x183EF7BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x1F64C80", Offset = "0x1F63480", VA = "0x181F64C80")]
	public BLLFBFCFDFI(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6CC0", Offset = "0x3EF54C0", VA = "0x183EF6CC0")]
	public static bool HLHIMDAEEEO(BLLFBFCFDFI CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7790", Offset = "0x3EF5F90", VA = "0x183EF7790", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(BLLFBFCFDFI ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7930", Offset = "0x3EF6130", VA = "0x183EF7930")]
	public CNGONJFLFDO JAPKCAKLNHC()
	{
		return default(CNGONJFLFDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7650", Offset = "0x3EF5E50", VA = "0x183EF7650")]
	public CELEFKODKGB DGECFANCLGN()
	{
		return default(CELEFKODKGB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct CNGONJFLFDO : IEquatable<CNGONJFLFDO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public CFBEFPIPHOM BNLNJFHLOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x86BC00", Offset = "0x86A400", VA = "0x18086BC00")]
		get
		{
			return default(CFBEFPIPHOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public FOJAOFJKAGF NBJIGELBGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(FOJAOFJKAGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public BLLFBFCFDFI IKMFLOENBIH
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BLLFBFCFDFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private BCMCBOLIGAE NHJFLOAGIHD
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9DA0", Offset = "0x3EF85A0", VA = "0x183EF9DA0")]
		get
		{
			return default(BCMCBOLIGAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public JPMNNMNBHIP NHCNADGAMBO
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9C80", Offset = "0x3EF8480", VA = "0x183EF9C80")]
		get
		{
			return default(JPMNNMNBHIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1F64C80", Offset = "0x1F63480", VA = "0x181F64C80")]
	public CNGONJFLFDO(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6CC0", Offset = "0x3EF54C0", VA = "0x183EF6CC0")]
	public static bool HLHIMDAEEEO(CNGONJFLFDO CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3EF9CF0", Offset = "0x3EF84F0", VA = "0x183EF9CF0", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(CNGONJFLFDO ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public struct CELEFKODKGB : IEquatable<CELEFKODKGB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public CFBEFPIPHOM BNLNJFHLOKF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x86BC00", Offset = "0x86A400", VA = "0x18086BC00")]
		get
		{
			return default(CFBEFPIPHOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public FOJAOFJKAGF NBJIGELBGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(FOJAOFJKAGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private FOJPBIGOEBJ COKDEHMBBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private GIDONOBPNKN BLAHOJHKOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8800", Offset = "0x3EF7000", VA = "0x183EF8800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private GMIEFABEJHP KOBOGKHACLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8A00", Offset = "0x3EF7200", VA = "0x183EF8A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public BLLFBFCFDFI IKMFLOENBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BLLFBFCFDFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	private MDOBDKKHBHJ ACOEHIIKCLI
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8CC0", Offset = "0x3EF74C0", VA = "0x183EF8CC0")]
		get
		{
			return default(MDOBDKKHBHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public PCLBMPEEANA FKCOAAEHHHH
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8970", Offset = "0x3EF7170", VA = "0x183EF8970")]
		get
		{
			return default(PCLBMPEEANA);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3EF86C0", Offset = "0x3EF6EC0", VA = "0x183EF86C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public IEnumerable<MGHHJKIEGLL> DMPAHHGIABE
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8850", Offset = "0x3EF7050", VA = "0x183EF8850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public MGHHJKIEGLL NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3EF81D0", Offset = "0x3EF69D0", VA = "0x183EF81D0")]
		get
		{
			return default(MGHHJKIEGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8A80", Offset = "0x3EF7280", VA = "0x183EF8A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x1F64C80", Offset = "0x1F63480", VA = "0x181F64C80")]
	public CELEFKODKGB(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6CC0", Offset = "0x3EF54C0", VA = "0x183EF6CC0")]
	public static bool HLHIMDAEEEO(CELEFKODKGB CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3EF8750", Offset = "0x3EF6F50", VA = "0x183EF8750", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(CELEFKODKGB ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3EF84C0", Offset = "0x3EF6CC0", VA = "0x183EF84C0")]
	public MGHHJKIEGLL BOMNJOOOGNC(Vector3? BAFCICKIIDG, Quaternion? ALKIIOKOBPG, Vector3? MJDIJCCGCED)
	{
		return default(MGHHJKIEGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3EF8320", Offset = "0x3EF6B20", VA = "0x183EF8320")]
	public MGHHJKIEGLL BOMNJOOOGNC()
	{
		return default(MGHHJKIEGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3EF8BA0", Offset = "0x3EF73A0", VA = "0x183EF8BA0")]
	public void NGEIKIGMGGE(int AKLHCIJHJKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct FOJAOFJKAGF : IEquatable<FOJAOFJKAGF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly CFBEFPIPHOM MEDLGIKFPNL;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public BKIEEIBJMKG DHANKKIIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6070", Offset = "0x3EF4870", VA = "0x183EF6070")]
		get
		{
			return default(BKIEEIBJMKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	private FOJPBIGOEBJ COKDEHMBBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	private HIPDIEDHHMJ LCEJKDDCKLC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3EFA6E0", Offset = "0x3EF8EE0", VA = "0x183EFA6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool AJHLJBDIIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3EFB200", Offset = "0x3EF9A00", VA = "0x183EFB200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public Vector3 NALEPNNAJJH
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3EFA9D0", Offset = "0x3EF91D0", VA = "0x183EFA9D0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3EFBC10", Offset = "0x3EFA410", VA = "0x183EFBC10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Quaternion EIJLNJOCHLE
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3EFA890", Offset = "0x3EF9090", VA = "0x183EFA890")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3EFC8B0", Offset = "0x3EFB0B0", VA = "0x183EFC8B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public Vector3 LIFDJHHLJBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3EFAED0", Offset = "0x3EF96D0", VA = "0x183EFAED0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3EFC2F0", Offset = "0x3EFAAF0", VA = "0x183EFC2F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Quaternion JNMBNNMDAKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3EFBD50", Offset = "0x3EFA550", VA = "0x183EFBD50")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3EFA750", Offset = "0x3EF8F50", VA = "0x183EFA750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public float JHLBABDBAAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3EFA620", Offset = "0x3EF8E20", VA = "0x183EFA620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 HEAHKHBALJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3EFB6C0", Offset = "0x3EF9EC0", VA = "0x183EFB6C0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3EFAD90", Offset = "0x3EF9590", VA = "0x183EFAD90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Vector3 CMPAKLONCGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3EFC630", Offset = "0x3EFAE30", VA = "0x183EFC630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public Vector3 ANFELJJAJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3EFC4F0", Offset = "0x3EFACF0", VA = "0x183EFC4F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Matrix4x4 LHHDNOFAKAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3EFB800", Offset = "0x3EFA000", VA = "0x183EFB800")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x1F64C80", Offset = "0x1F63480", VA = "0x181F64C80")]
	public FOJAOFJKAGF(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6050", Offset = "0x3EF4850", VA = "0x183EF6050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3EFB150", Offset = "0x3EF9950", VA = "0x183EFB150", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5F50", Offset = "0x3EF4750", VA = "0x183EF5F50", Slot = "4")]
	public bool Equals(FOJAOFJKAGF ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3EF6090", Offset = "0x3EF4890", VA = "0x183EF6090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3EFC280", Offset = "0x3EFAA80", VA = "0x183EFC280")]
	public KAKBADJGMGN LLLCBLILBDA()
	{
		return default(KAKBADJGMGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3EFBAD0", Offset = "0x3EFA2D0", VA = "0x183EFBAD0")]
	public void JCOCHMIBGHF(out Vector3 NDFADLNAIEP, out Quaternion DEOODMICGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3EFB4D0", Offset = "0x3EF9CD0", VA = "0x183EFB4D0")]
	public Vector3 FOFKBPCDHCC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3EFC770", Offset = "0x3EFAF70", VA = "0x183EFC770")]
	public void OMLCGAIBOJA(Vector3 CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3EFB390", Offset = "0x3EF9B90", VA = "0x183EFB390")]
	public Vector3 FGIJGFMAGEB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3EFC9F0", Offset = "0x3EFB1F0", VA = "0x183EFC9F0")]
	public void PFGIPJBCEHB(Vector3 CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3EFB250", Offset = "0x3EF9A50", VA = "0x183EFB250")]
	public Quaternion FCNFIPICALP()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3EFCB30", Offset = "0x3EFB330", VA = "0x183EFCB30")]
	public void PFHEPKJLKOF(Quaternion CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3EFC080", Offset = "0x3EFA880", VA = "0x183EFC080")]
	public Quaternion KPECDGKPIDK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x3EFBF40", Offset = "0x3EFA740", VA = "0x183EFBF40")]
	public void KBAMKMOPIEE(Quaternion CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x3EFB610", Offset = "0x3EF9E10", VA = "0x183EFB610")]
	public float HIEDNFCJPCA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x3EFC1C0", Offset = "0x3EFA9C0", VA = "0x183EFC1C0")]
	public void LHCHEMGBINM(float CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x3EFBE90", Offset = "0x3EFA690", VA = "0x183EFBE90")]
	public float JMBJHIBKJDM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3EFC430", Offset = "0x3EFAC30", VA = "0x183EFC430")]
	public void MPLLAANJBNG(float CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3EFCC70", Offset = "0x3EFB470", VA = "0x183EFCC70")]
	public void PPGBCHDDCHP(Vector3 CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3EFB010", Offset = "0x3EF9810", VA = "0x183EFB010")]
	public Vector3 EMGOAMPKKGE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3EFAC50", Offset = "0x3EF9450", VA = "0x183EFAC50")]
	public void CKIGJDHKJHC(Vector3 CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3EFAB10", Offset = "0x3EF9310", VA = "0x183EFAB10")]
	public Vector3 CHIDJLFBBNO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3EFB990", Offset = "0x3EFA190", VA = "0x183EFB990")]
	public void IKIIOKEPGHI(Vector3 CJMMBFLIBMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class PFPIOKNPIHH
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3F00B10", Offset = "0x3EFF310", VA = "0x183F00B10")]
	public static HFEGCOONMAM JAGNOKIGICD(this CFBEFPIPHOM OCNCOBFEOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3F009F0", Offset = "0x3EFF1F0", VA = "0x183F009F0")]
	public static EntityManager BNFBCOAMLJO(this CFBEFPIPHOM OCNCOBFEOBE)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0xA89EA0", Offset = "0xA886A0", VA = "0x180A89EA0")]
	public static T GIHEJADCLAH<T>(this CFBEFPIPHOM OCNCOBFEOBE) where T : struct, EICPOGHKDOL
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0xFA82D0", Offset = "0xFA6AD0", VA = "0x180FA82D0")]
	public static bool EOLJNDGJLOB<T>(this CFBEFPIPHOM OCNCOBFEOBE) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface ELFHFLPLNFA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Entity ACGHDBHCAGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Entity KMBIOAFFABC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AIHDFPEDAPD(float3 INKEIBHHMOK);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EOLGCBCLPKA(float3 INKEIBHHMOK);

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ADGMLBEPLMB(out float3 MMECDMIFJKL, out float3 NOOMMODKENI);

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KACBCMJFGEG(float3 MMECDMIFJKL, float3 NOOMMODKENI);

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GOHNOBIFPPC(Color MMECDMIFJKL, Color NOOMMODKENI);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ELFHFLPLNFA Instantiate(Transform EOBPGPELLLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface HKAAAHCLJJH
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGHMODLDJCJ(Transform EOBPGPELLLJ, ELFHFLPLNFA LPFPBCGNFNJ);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ELFHFLPLNFA FLJEMHGLBBA();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface HFCJOFNPJDG
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	Func<ELFHFLPLNFA> FLJEMHGLBBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<CFBEFPIPHOM, CFBEFPIPHOM> NPONHJCPNDF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<CFBEFPIPHOM, CFBEFPIPHOM> DHBFONNJJOK;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<CFBEFPIPHOM, CFBEFPIPHOM, CFBEFPIPHOM> PBMNFHOGJBI;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<CFBEFPIPHOM> BPLKPAFDEBI;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CFBEFPIPHOM LOOBONCPBDH(CFBEFPIPHOM LEPHKDIHJFD, int HIJMIBAOAJE);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Color HFKGILBLCIB(CFBEFPIPHOM LEPHKDIHJFD, int HIJMIBAOAJE);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 PLGCCCFGNNG(CFBEFPIPHOM LEPHKDIHJFD, int HIJMIBAOAJE);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MEIKIKOFGKA(CFBEFPIPHOM LEPHKDIHJFD, CFBEFPIPHOM FFOKEBNNBAE);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CFBEFPIPHOM MOLCNOANCBK(CFBEFPIPHOM LEPHKDIHJFD);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IEnumerable<CFBEFPIPHOM> OOBCJHMMBOP(CFBEFPIPHOM LEPHKDIHJFD);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	CFBEFPIPHOM PAECMEAAFNB(CFBEFPIPHOM LEPHKDIHJFD);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EBOIEJALFCB(CFBEFPIPHOM LEPHKDIHJFD, Vector3 KKIIPFPIGCC, Quaternion DKDOCMODCJB);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	(Vector3, Quaternion, bool) MKKKPNCHLNF(CFBEFPIPHOM LEPHKDIHJFD);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class HANINFEMBPK
{
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface DEGKEFODIJP
{
	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CFBEFPIPHOM MOLCNOANCBK(CFBEFPIPHOM LEPHKDIHJFD);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MEIKIKOFGKA(CFBEFPIPHOM LEPHKDIHJFD, CFBEFPIPHOM CELKNCFBAOE, bool BONIBHBAFFM);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BCIMKCBBIFF(CFBEFPIPHOM LEPHKDIHJFD, CFBEFPIPHOM CELKNCFBAOE);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int EDJIMEHBLAH(CFBEFPIPHOM LEPHKDIHJFD);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FCCBMJGNNEF AJHEBEBEEGH(CFBEFPIPHOM MEDLGIKFPNL);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BIPHIMNHBID(CFBEFPIPHOM LEPHKDIHJFD, CFBEFPIPHOM KILCGFPNBMC);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MFEJJMDALEL(CFBEFPIPHOM LEPHKDIHJFD, CFBEFPIPHOM ELKNCMDOGDP);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CFBEFPIPHOM GHFKNMIKJEG(CFBEFPIPHOM KILCGFPNBMC, CFBEFPIPHOM BBAPJHOFLJP);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MAIKBHHOMHF(CFBEFPIPHOM KILCGFPNBMC, CFBEFPIPHOM BBAPJHOFLJP, out CFBEFPIPHOM JDBIDILANEA);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class LHKDCKALDAP
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface FHCDFMOJBCC
{
	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	UndoAction FAGONPKNJKM();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	RedoAction ADHHPMDACID(UndoAction GPGPHLEMPIJ);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	UndoAction OKFJFAKGOAI(RedoAction GPGPHLEMPIJ);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IDisposable BPIPLGJBJAN();
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface FOJPBIGOEBJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	GIDONOBPNKN BLAHOJHKOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	int CADHINJENAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	int JGMMMCHPMBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<CFBEFPIPHOM, HEIIJIHIAKK> HLDCKKIBNFH;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<CFBEFPIPHOM> PPMNIDEBOPA;

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FCCBMJGNNEF OBPLLDFCCBJ();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MNBPBHNFCPJ OOHEKPANOLH(CFBEFPIPHOM LEPHKDIHJFD);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HEIIJIHIAKK IILOCACPEEL(CFBEFPIPHOM LEPHKDIHJFD);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DAFBLBFDDID(MCOCAFPBHKN GFKNINEELBB, NNCLEEGIIBK MDLJNEBAIPD);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BKIEEIBJMKG EIDBIEHIAEK(CFBEFPIPHOM LEPHKDIHJFD, [Optional] object HMOHICKINOJ);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GOFIPHNJIDA(CFBEFPIPHOM LEPHKDIHJFD, out NNCLEEGIIBK MDLJNEBAIPD);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ADKEHJNDCIK(NNCLEEGIIBK MDLJNEBAIPD);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool KFAIBMCBPEJ(CFBEFPIPHOM LEPHKDIHJFD, out Transform EOBPGPELLLJ);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool GJPEFJBAECC(CFBEFPIPHOM LEPHKDIHJFD);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KGEPALGALDH(Entity NBIJCGHBCCI, object HMOHICKINOJ);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool MNFPKMAEIFA(Entity NBIJCGHBCCI, object HMOHICKINOJ);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	CFBEFPIPHOM PGAAHFGOMDE(MCOCAFPBHKN GFKNINEELBB);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	MCOCAFPBHKN DCDNMCENJCL(CFBEFPIPHOM LEPHKDIHJFD);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "20")]
	BKIEEIBJMKG JDCINKDFFNF(HEIIJIHIAKK GPMEIOIEDNN);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "21")]
	BKIEEIBJMKG FNHIIMHAIEO(HEIIJIHIAKK GPMEIOIEDNN);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "22")]
	BKIEEIBJMKG KLLAAEAJMPK(MCOCAFPBHKN GFKNINEELBB, HEIIJIHIAKK GPMEIOIEDNN);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CLMHOEMCILK NJIEKEKJKAE();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "24")]
	CELEFKODKGB NBMMMGOIFIH();

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "25")]
	CNGONJFLFDO OECKONEOFKD(JPMNNMNBHIP FDICACCAPEJ);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LIPJKPPEBGH(CFBEFPIPHOM LEPHKDIHJFD);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void APJLKFMLABG(CFBEFPIPHOM LEPHKDIHJFD);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NAPPOONKJCM(CFBEFPIPHOM LEPHKDIHJFD);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "29")]
	NativeArray<(CFBEFPIPHOM, CFBEFPIPHOM)> ODJPPNHBFCL(NativeArray<CFBEFPIPHOM> OMHJJDKCAJM, Allocator DDJPHGFEOFF);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool NKBMJECLOCI(CFBEFPIPHOM LEPHKDIHJFD);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void IDPJIGKEBOL();

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void DMPAKMCFACH();
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class HDMLNCLKLCK
{
	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x3EFD4A0", Offset = "0x3EFBCA0", VA = "0x183EFD4A0")]
	public static bool KFAIBMCBPEJ(this FOJPBIGOEBJ NLJLBCPPCEG, Entity NBIJCGHBCCI, out Transform EOBPGPELLLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x3EFD6C0", Offset = "0x3EFBEC0", VA = "0x183EFD6C0")]
	public static CFBEFPIPHOM PGAAHFGOMDE(this FOJPBIGOEBJ NLJLBCPPCEG, Entity NBIJCGHBCCI)
	{
		return default(CFBEFPIPHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x3EFCE40", Offset = "0x3EFB640", VA = "0x183EFCE40")]
	public static MCOCAFPBHKN DCDNMCENJCL(this FOJPBIGOEBJ NLJLBCPPCEG, Entity NBIJCGHBCCI)
	{
		return default(MCOCAFPBHKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x3EFCF50", Offset = "0x3EFB750", VA = "0x183EFCF50")]
	public static BKIEEIBJMKG DNAOFNJNKDB(this FOJPBIGOEBJ NLJLBCPPCEG, HEIIJIHIAKK GPMEIOIEDNN, [Optional] object HMOHICKINOJ)
	{
		return default(BKIEEIBJMKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3EFD5C0", Offset = "0x3EFBDC0", VA = "0x183EFD5C0")]
	public static CLMHOEMCILK OENLJKGDEKE(this FOJPBIGOEBJ NLJLBCPPCEG, [Optional] object HMOHICKINOJ)
	{
		return default(CLMHOEMCILK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3EFD280", Offset = "0x3EFBA80", VA = "0x183EFD280")]
	public static CELEFKODKGB IAMFNDNLBKG(this FOJPBIGOEBJ NLJLBCPPCEG, [Optional] object HMOHICKINOJ)
	{
		return default(CELEFKODKGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3EFD380", Offset = "0x3EFBB80", VA = "0x183EFD380")]
	public static CNGONJFLFDO JELFLAEBPFB(this FOJPBIGOEBJ NLJLBCPPCEG, JPMNNMNBHIP HFDDOCDDIDO, [Optional] object HMOHICKINOJ)
	{
		return default(CNGONJFLFDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x3EFD060", Offset = "0x3EFB860", VA = "0x183EFD060")]
	public static KPCELMGFPAF EAHLHECPDKP(this FOJPBIGOEBJ NLJLBCPPCEG, MINFGCMJKBL BCDIBHFAEEF, [Optional] object HMOHICKINOJ)
	{
		return default(KPCELMGFPAF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface MGIHGMHOKEE
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<CFBEFPIPHOM, GCCNGCMPMGI> JJPKNJHCHIO;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PGECBNGPHCG(CFBEFPIPHOM LEPHKDIHJFD, Vector3 IONIHDHIJOB);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CONCKEJJICO(CFBEFPIPHOM LEPHKDIHJFD, out Collider OKCFJNOIDBD);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OLGGKPMALKJ(CFBEFPIPHOM LEPHKDIHJFD);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface NBEIBLIFPGD
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	bool PIIGAGDECED
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface DGGIPLGOKHJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	CFBEFPIPHOM OHCJLKLDMPI
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	BKIEEIBJMKG NMKJGNNIJAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event KCAPIKBFAKO BBGCFIDDLAG;

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CFBEFPIPHOM GHFKNMIKJEG(CFBEFPIPHOM KILCGFPNBMC, CFBEFPIPHOM BBAPJHOFLJP);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MAIKBHHOMHF(CFBEFPIPHOM KILCGFPNBMC, CFBEFPIPHOM BBAPJHOFLJP, out CFBEFPIPHOM JDBIDILANEA);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EKIBEIGCHHE();

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CLJHKKIDENI();

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MNIGEBADBKD(CFBEFPIPHOM GPGPHLEMPIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public delegate void KCAPIKBFAKO(BKIEEIBJMKG LKFKKPMLKAJ, BKIEEIBJMKG AEJLMNEIPCH);
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class CCEDCKHPIAP
{
	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7E60", Offset = "0x3EF6660", VA = "0x183EF7E60")]
	public static void DLIBGEDNLMM(this DGGIPLGOKHJ NENEJICOPCM, BKIEEIBJMKG GPGPHLEMPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7ED0", Offset = "0x3EF66D0", VA = "0x183EF7ED0")]
	public static void DLIBGEDNLMM(this DGGIPLGOKHJ NENEJICOPCM, CFBEFPIPHOM GPGPHLEMPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x3EF80D0", Offset = "0x3EF68D0", VA = "0x183EF80D0")]
	public static bool NGNHKCNPFLD(this DGGIPLGOKHJ NENEJICOPCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x3EF7D80", Offset = "0x3EF6580", VA = "0x183EF7D80")]
	public static bool APIIGKDIAMP(this DGGIPLGOKHJ NENEJICOPCM, CFBEFPIPHOM GPGPHLEMPIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface DIAELLIMJAK
{
	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPBCOPCMENI(CFBEFPIPHOM MEDLGIKFPNL, bool CJMMBFLIBMO);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCDHMLDDIEE(CFBEFPIPHOM MEDLGIKFPNL, bool CJMMBFLIBMO);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface FCGCJNHMCDH
{
	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action JFFAIIABHKB;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action ECBGBFEFLPL;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action NDPELOONAKM;

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IBNNJBDJGFI(bool MAGFABKGNKB);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ByteString BAGHAKDDGPK();

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ByteString BAGHAKDDGPK(out IDisposable HKKEDPNHGPK);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MFDBKIPJIIL();

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BMDAHBGMMID();

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool JDKEMADGCJE(ByteString LHBBKEDIBLE, AAEGGCGNJEL AGFHKAICCAO = AAEGGCGNJEL.All);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool ODKGJHJEKNG();

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool IFPNJNOFHPP();

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool COJMMEGIOJN();
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface GMIEFABEJHP
{
	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MGHHJKIEGLL HGCGLDIBEJE(MDOBDKKHBHJ MBHDJAIODMF, [Optional] Vector3? BAFCICKIIDG, [Optional] Quaternion? ALKIIOKOBPG, [Optional] Vector3? MJDIJCCGCED);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MGHHJKIEGLL FFBICNDKAAN(MDOBDKKHBHJ MBHDJAIODMF, int AKLHCIJHJKB);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NPFLBPFDAOK(MDOBDKKHBHJ MBHDJAIODMF, int AKLHCIJHJKB);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int EHCDOLDOHAM(MDOBDKKHBHJ MBHDJAIODMF);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IEnumerable<MGHHJKIEGLL> IIEEIMGJNGJ(MDOBDKKHBHJ MBHDJAIODMF);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface HCGLAJOCALO
{
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGHJIKEEDBP();

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJGHHDLHBGK();

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OIBDPPPLFAH();

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BFIFEKCCGLJ();

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DIGEMLMICNK();

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LGBICGPCPBJ();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface HIPDIEDHHMJ
{
	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNFMMHNMGDP(Entity NBIJCGHBCCI);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMLCGAIBOJA(Entity NBIJCGHBCCI, Vector3 CJMMBFLIBMO);

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Vector3 FOFKBPCDHCC(Entity NBIJCGHBCCI);

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PFHEPKJLKOF(Entity NBIJCGHBCCI, Quaternion CJMMBFLIBMO);

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Quaternion FCNFIPICALP(Entity NBIJCGHBCCI);

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BKIMJMIPHBH(Entity NBIJCGHBCCI, Vector3 BAFCICKIIDG, Quaternion ALKIIOKOBPG);

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JCOCHMIBGHF(Entity NBIJCGHBCCI, out Vector3 BAFCICKIIDG, out Quaternion ALKIIOKOBPG);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FKJLMKDKIFB(Entity NBIJCGHBCCI, out Vector3 BAFCICKIIDG, out Quaternion ALKIIOKOBPG);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 JBIEIPJKHEE(Entity NBIJCGHBCCI);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PPGBCHDDCHP(Entity NBIJCGHBCCI, Vector3 CJMMBFLIBMO);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LHCHEMGBINM(Entity NBIJCGHBCCI, float CJMMBFLIBMO);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float HIEDNFCJPCA(Entity NBIJCGHBCCI);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CKIGJDHKJHC(Entity NBIJCGHBCCI, Vector3 CJMMBFLIBMO);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Vector3 EMGOAMPKKGE(Entity NBIJCGHBCCI);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PFGIPJBCEHB(Entity NBIJCGHBCCI, Vector3 CJMMBFLIBMO);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Vector3 FGIJGFMAGEB(Entity NBIJCGHBCCI);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KBAMKMOPIEE(Entity NBIJCGHBCCI, Quaternion CJMMBFLIBMO);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Quaternion KPECDGKPIDK(Entity NBIJCGHBCCI);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 GJKGHMFKPIF(Entity NBIJCGHBCCI);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OFNKNCBDEAE(Entity NBIJCGHBCCI, Vector3 CJMMBFLIBMO);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MPLLAANJBNG(Entity NBIJCGHBCCI, float CJMMBFLIBMO);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float JMBJHIBKJDM(Entity NBIJCGHBCCI);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IKIIOKEPGHI(Entity NBIJCGHBCCI, Vector3 CJMMBFLIBMO);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Vector3 CHIDJLFBBNO(Entity NBIJCGHBCCI);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IFIDHGKCBNB(Entity NBIJCGHBCCI, out Matrix4x4 CDGLHEJLHNI);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void DHBBMBKEDLI(Entity NBIJCGHBCCI, in Matrix4x4 CDGLHEJLHNI);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IGENMEJMCEG(Entity NBIJCGHBCCI, out Matrix4x4 CDGLHEJLHNI);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool KFAIBMCBPEJ(Entity NBIJCGHBCCI, out Transform EOBPGPELLLJ);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void HNLDCIKCBDF(Entity NBIJCGHBCCI);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class GFBNAFIDNBJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface BOMMAODPLGI
{
	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEBIPMHGPHG(CFBEFPIPHOM MEDLGIKFPNL, bool CJMMBFLIBMO);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface HFEGCOONMAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	GIDONOBPNKN BLAHOJHKOBM
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	FDJJGOGKMHG JAGNOKIGICD
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	ADAIPEODNMG HOCMGGGFBDD
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	EntityManager BNFBCOAMLJO
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action AJPKEHIOGDA;

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ComponentSystemBase NJNMKMBNAAI(Type BKDBLJPNPPJ);

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CAHGKFOGDMN();

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BGEFLJGNICF();

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KCELMCCJFKF();

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NKFIBHOPCHB();

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LPLNHNICGJI();

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PKHOCIAIPDH();

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DFMCHFJPHOK();

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DEDKCCDALPP();

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LEDANGKKEKK();
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class JPJJHCDOFEN
{
	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x3EFF090", Offset = "0x3EFD890", VA = "0x183EFF090")]
	public static World NMDEEKFMAML(this HFEGCOONMAM JLFJGJMGNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x1C3B320", Offset = "0x1C39B20", VA = "0x181C3B320")]
	public static T NJNMKMBNAAI<T>(this HFEGCOONMAM JLFJGJMGNNJ) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[Flags]
public enum AAEGGCGNJEL
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	DestroyObjects = 1,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	InitializeWorld = 2,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Settings = 4,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	PreInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	PostInstantiate = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	All = 0x1F
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface CAMIJMPEPJA
{
	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GDOHKFNFMFO(in float3 PILBMAKMDBK, in float3 ABCIPBECLHO, float OHGAJDFAGIK, Allocator DDJPHGFEOFF, out NativeArray<Entity> NLBMCCOBHKD);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface OPJJGBNKIAF
{
	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GDOHKFNFMFO(in float3 PILBMAKMDBK, in float3 ABCIPBECLHO, float OHGAJDFAGIK, out FMKJPGNJLOO PDHCKJKKNDJ, out Entity PKJFCACDAKH);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface GCCIHKGPIOM
{
	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDOHKFNFMFO(in NativeArray<Entity> NLBMCCOBHKD, in float3 PILBMAKMDBK, in float3 ABCIPBECLHO, in NativeArray<FMKJPGNJLOO> LFFIDMKGJAG);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct KENLICLHJFC : global::KDFMKIHLJFP<KENLICLHJFC>, ECOGJIGKDHI, IEquatable<KENLICLHJFC>
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int PDGADEKDACK
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7E9EC0", Offset = "0x7E86C0", VA = "0x1807E9EC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x825F70", Offset = "0x824770", VA = "0x180825F70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public int JLICIKJPFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xECE690", Offset = "0xECCE90", VA = "0x180ECE690", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xF35920", Offset = "0xF34120", VA = "0x180F35920", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x3EFF1E0", Offset = "0x3EFD9E0", VA = "0x183EFF1E0", Slot = "8")]
	public bool Equals(KENLICLHJFC ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x3EFF230", Offset = "0x3EFDA30", VA = "0x183EFF230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct FMKJPGNJLOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float LCKAAHNJMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float3 MBODGIHCDNC;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface NONOFHBMPEN
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string CLKEGIDEGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	NONOFHBMPEN KNNHFNODLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	IEnumerable<NONOFHBMPEN> KHAHDCBPAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface IECNLFJIGBE
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	NONOFHBMPEN IMFAMLKJPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	List<HMMELKFLGKD> FMNJCLMNMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PAPAKKEPEPG(HMMELKFLGKD IOADAIMHMFG, out NONOFHBMPEN AKCNNHAPOMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DefaultMember("Item")]
public interface FBFMOHPHODB : IEnumerable<NOPBMJOJCGP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	NOPBMJOJCGP NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	NOPBMJOJCGP NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NOPBMJOJCGP ANIGAEEOCNL(OMOEODCFEGL EMMPAJPIILL);

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MIPCILJMDGJ KJPBFOEADCJ(OMOEODCFEGL EMMPAJPIILL);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class OCIJOOHKOIH
{
	[Cpp2IlInjected.Token(Token = "0x600028F")]
	public static global::MJOLCMOKJJE<T> ANIGAEEOCNL<T>(this FBFMOHPHODB AFJGLEGGBOF, OMOEODCFEGL JNAACNJBHOF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0xDAECE0", Offset = "0xDAD4E0", VA = "0x180DAECE0")]
	public static global::MJOLCMOKJJE<T> ANIGAEEOCNL<T>(this FBFMOHPHODB AFJGLEGGBOF, global::NNAELPPPNEG<T> JNAACNJBHOF) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[DefaultMember("Item")]
public interface DNHMPLANJOC : IEnumerable<NJFOBBNGILB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	NJFOBBNGILB NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NJFOBBNGILB ANIGAEEOCNL(OMOEODCFEGL EMMPAJPIILL);

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MIPCILJMDGJ KJPBFOEADCJ(OMOEODCFEGL EMMPAJPIILL);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class GGMOGGJLFPI
{
	[Cpp2IlInjected.Token(Token = "0x6000295")]
	public static global::LCHBJNMGJAE<T> ANIGAEEOCNL<T>(this DNHMPLANJOC AFJGLEGGBOF, OMOEODCFEGL JNAACNJBHOF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0xDA2860", Offset = "0xDA1060", VA = "0x180DA2860")]
	public static MIPCILJMDGJ KJPBFOEADCJ<T>(this DNHMPLANJOC AFJGLEGGBOF, global::NNAELPPPNEG<T> JNAACNJBHOF) where T : struct
	{
		return default(MIPCILJMDGJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[DefaultMember("Item")]
public interface AINBLNOJEEC : IEnumerable<HMMELKFLGKD>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	HMMELKFLGKD NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HMMELKFLGKD ANIGAEEOCNL(OMOEODCFEGL EMMPAJPIILL);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class CFJIBNEDNLM
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x524A740", Offset = "0x5248F40", VA = "0x18524A740")]
	public static global::FMGDPJPCCFA<T> ANIGAEEOCNL<T>(this AINBLNOJEEC AFJGLEGGBOF, OMOEODCFEGL JNAACNJBHOF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x524A870", Offset = "0x5249070", VA = "0x18524A870")]
	public static global::FMGDPJPCCFA<T> ANIGAEEOCNL<T>(this AINBLNOJEEC AFJGLEGGBOF, global::NNAELPPPNEG<T> JNAACNJBHOF) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface IPKLKAMJJNH
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MDCLHEKMCMO(MCOCAFPBHKN GFKNINEELBB, MIPCILJMDGJ IOADAIMHMFG);

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIPBNBHHBLC(MCOCAFPBHKN GFKNINEELBB, Span<MIPCILJMDGJ> AFJGLEGGBOF, bool PMEJKGPCEKM);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct MABIDPJIHBP : JJELBHOACBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public HEIIJIHIAKK GPMEIOIEDNN;

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x3EFFAF0", Offset = "0x3EFE2F0", VA = "0x183EFFAF0", Slot = "5")]
	public void JDKEMADGCJE(BFPHBAFEECN IAAPJBOKIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x3EFFAB0", Offset = "0x3EFE2B0", VA = "0x183EFFAB0", Slot = "4")]
	public void BAGHAKDDGPK(BFPHBAFEECN IAAPJBOKIIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct MCOCAFPBHKN : IComparable<MCOCAFPBHKN>, IEquatable<MCOCAFPBHKN>, JJELBHOACBE
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly MCOCAFPBHKN EOOIPOMJEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private uint OKBGKBPHLLK;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public uint PBCOLHDFMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xC67850", Offset = "0xC66050", VA = "0x180C67850")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public uint EJFMLMNCFJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xC674F0", Offset = "0xC65CF0", VA = "0x180C674F0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public uint DOFPPMGPLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7E9EC0", Offset = "0x7E86C0", VA = "0x1807E9EC0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool CPNLIKCPMHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x22857C0", Offset = "0x2283FC0", VA = "0x1822857C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool LNHIKBMEHEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3EFFDD0", Offset = "0x3EFE5D0", VA = "0x183EFFDD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x3F00030", Offset = "0x3EFE830", VA = "0x183F00030")]
	public MCOCAFPBHKN(int KOHFEKFJAIH, int GOGMNCBMMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x3F00030", Offset = "0x3EFE830", VA = "0x183F00030")]
	public MCOCAFPBHKN(uint KOHFEKFJAIH, uint GOGMNCBMMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x825F70", Offset = "0x824770", VA = "0x180825F70")]
	private MCOCAFPBHKN(uint OKBGKBPHLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0xC66DA0", Offset = "0xC655A0", VA = "0x180C66DA0")]
	public static MCOCAFPBHKN GNAJKHMJKIG(uint OKBGKBPHLLK)
	{
		return default(MCOCAFPBHKN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0xC66D90", Offset = "0xC65590", VA = "0x180C66D90")]
	public static bool LLPKNBIICCC(MCOCAFPBHKN DKLHMFCLOAB, MCOCAFPBHKN FLEBMPFFCAA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0xC66DB0", Offset = "0xC655B0", VA = "0x180C66DB0")]
	public static bool PNNBKKFLHKP(MCOCAFPBHKN DKLHMFCLOAB, MCOCAFPBHKN FLEBMPFFCAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D3600", Offset = "0x6D1E00", VA = "0x1806D3600", Slot = "5")]
	public bool Equals(MCOCAFPBHKN OCNCOBFEOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x3EFFE40", Offset = "0x3EFE640", VA = "0x183EFFE40", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x825EF0", Offset = "0x8246F0", VA = "0x180825EF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x3EFFFA0", Offset = "0x3EFE7A0", VA = "0x183EFFFA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x3EFFF30", Offset = "0x3EFE730", VA = "0x183EFFF30")]
	public static void NPDHAOIKMMK(BFPHBAFEECN IAAPJBOKIIH, MCOCAFPBHKN CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x3EFFDE0", Offset = "0x3EFE5E0", VA = "0x183EFFDE0")]
	public static MCOCAFPBHKN EPALHLGIDAE(BFPHBAFEECN IAAPJBOKIIH)
	{
		return default(MCOCAFPBHKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x3EFFD50", Offset = "0x3EFE550", VA = "0x183EFFD50", Slot = "6")]
	public void BAGHAKDDGPK(BFPHBAFEECN IAAPJBOKIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x3EFFEC0", Offset = "0x3EFE6C0", VA = "0x183EFFEC0", Slot = "7")]
	public void JDKEMADGCJE(BFPHBAFEECN IAAPJBOKIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x1C8BC10", Offset = "0x1C8A410", VA = "0x181C8BC10", Slot = "4")]
	public int CompareTo(MCOCAFPBHKN ALBOAABJIJF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum FHKNJPEFKKK
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Mark = 1,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	GroupBegin = 2,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	GroupEnd = 3,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	EntCreate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	EntDestroy = 5,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	EntSetParent = 6,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	EntCreateInstance = 7,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	XfmSetLocalPosition = 8,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	XfmSetLocalRotation = 9,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	XfmSetLocalScale = 10,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	COUNT = 11,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	MAX = 10
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface POMCEDFPCNK
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public delegate bool GAPEKCIFGNC(BHKCMBKKPEM KKGDKGFFJGP, in BJHFEKKLKGB CJMMBFLIBMO);
[Cpp2IlInjected.Token(Token = "0x2000060")]
public delegate bool NCKFDDLMJNK<T>(BHKCMBKKPEM KKGDKGFFJGP, in T CJMMBFLIBMO);
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface IEDMOKDLMMK
{
	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DAFBLBFDDID(MIPCILJMDGJ KBHHIDGOLNC, Type PJHBOMGCKND, GAPEKCIFGNC OOAKNNCEGCI);

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JKOEIOCEBNB(MIPCILJMDGJ KBHHIDGOLNC, out GAPEKCIFGNC OOAKNNCEGCI);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public static class OLNOHJMDCHM
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class LHJKGBJNMPF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public global::NCKFDDLMJNK<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public LHJKGBJNMPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x57339C0", Offset = "0x57321C0", VA = "0x1857339C0")]
	public static void DAFBLBFDDID<T>(this IEDMOKDLMMK CCOJAKINIDK, MIPCILJMDGJ KBHHIDGOLNC, global::NCKFDDLMJNK<T> OOAKNNCEGCI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x3F00620", Offset = "0x3EFEE20", VA = "0x183F00620")]
	public static bool OIGLBJAFFJP(this IEDMOKDLMMK CCOJAKINIDK, BHKCMBKKPEM KKGDKGFFJGP, MIPCILJMDGJ KBHHIDGOLNC, in BJHFEKKLKGB CJMMBFLIBMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface MIECHCHEMLP
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIKFIEHBGLF(int OCAKIKBDFGC);

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMHCPKOKHAM(in ReadOnlyMemory<byte> KMABBNINIEC, out ReadOnlyMemory<byte> CBMGDPAPCGN);

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJKFCLEDHJE(in ReadOnlyMemory<byte> KMABBNINIEC, out ReadOnlyMemory<byte> CBMGDPAPCGN);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface GJMEOOGNMEP : KOHIKPOCAHD
{
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface KOHIKPOCAHD
{
	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHPMLPEMMMM(LOEGPKPDOHK BAGMDNPKAJL, ReadOnlyMemory<byte> KDGHFFBPFDE);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface DHMGIBBALDI : KOHIKPOCAHD
{
	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	int PBIBCHDKHIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LOEGPKPDOHK IOFHGOIBJHF();
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface BENMCECCEEA
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	int BIANPAFMDDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public delegate void IPEKLOCGEIH(LOEGPKPDOHK BAGMDNPKAJL, ReadOnlyMemory<byte> KDGHFFBPFDE);
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct LOEGPKPDOHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public uint KOHFEKFJAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int MFEPDPICBBJ;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x76F510", Offset = "0x76DD10", VA = "0x18076F510")]
	public LOEGPKPDOHK(uint KOHFEKFJAIH, int MFEPDPICBBJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x3EFFA10", Offset = "0x3EFE210", VA = "0x183EFFA10")]
	public static bool LLPKNBIICCC(in LOEGPKPDOHK MEHHMGBDHKJ, in LOEGPKPDOHK MLOFKBADEJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x3EFF950", Offset = "0x3EFE150", VA = "0x183EFF950", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x3EFF9E0", Offset = "0x3EFE1E0", VA = "0x183EFF9E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x3EFFA30", Offset = "0x3EFE230", VA = "0x183EFFA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct AMMENKFLOJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public LOEGPKPDOHK BAGMDNPKAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public ReadOnlyMemory<byte> KDGHFFBPFDE;

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0xECDD00", Offset = "0xECC500", VA = "0x180ECDD00")]
	public AMMENKFLOJG(LOEGPKPDOHK BAGMDNPKAJL, ReadOnlyMemory<byte> KDGHFFBPFDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface IBANDGBNLDD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLJHNLDFCID(LOEGPKPDOHK BAGMDNPKAJL, ReadOnlyMemory<byte> KDGHFFBPFDE);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface DDBJEFCJIOL
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	BFPHBAFEECN GPLJIGMOIME
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMCPJLDGJHN();

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNCCPKAGAGL();
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface HDNKFPINMMI
{
	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LDFNNBCNCNI(LOEGPKPDOHK BAGMDNPKAJL, ReadOnlyMemory<byte> ENPKJHPNEAL);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface CCOPBFAPCJI
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DAHDKFOAAJG(MCOCAFPBHKN CLBACPKJNKF, in MABIDPJIHBP DMDONNOOOJK);

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFNGLEMOCMI(MCOCAFPBHKN CLBACPKJNKF);

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OKEHHHIHJAB(MCOCAFPBHKN CLBACPKJNKF, MIPCILJMDGJ KBHHIDGOLNC, in BJHFEKKLKGB CJMMBFLIBMO);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class GJBKIMODCOC
{
	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x315DED0", Offset = "0x315C6D0", VA = "0x18315DED0")]
	public static void OKEHHHIHJAB<T>(this CCOPBFAPCJI HELLEMCMMHJ, MCOCAFPBHKN CLBACPKJNKF, MIPCILJMDGJ KBHHIDGOLNC, T CJMMBFLIBMO) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public interface HIHOGFJICGL
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	uint MECJADGLGFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface CKLENHMGEIH
{
	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMFAIFGEOCM();

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLPAADGNHCK(MCOCAFPBHKN GFKNINEELBB, bool KFKHPBHPOGF);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface GDEMKJIGFOC
{
	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FBDMKEFKCAO(MCOCAFPBHKN MEDLGIKFPNL, in MABIDPJIHBP DMDONNOOOJK, bool HFIFFFBALHD);

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHEFHLIGEGP(MCOCAFPBHKN MEDLGIKFPNL, bool HFIFFFBALHD);

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CGADPNGAKBE(MCOCAFPBHKN MEDLGIKFPNL, MIPCILJMDGJ IOADAIMHMFG, in BJHFEKKLKGB CJMMBFLIBMO, bool HFIFFFBALHD);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class BPHGHALDNOE
{
	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0xB51B80", Offset = "0xB50380", VA = "0x180B51B80")]
	public static void CGADPNGAKBE<T>(this GDEMKJIGFOC FMAOAOODAPP, MCOCAFPBHKN MEDLGIKFPNL, MIPCILJMDGJ IOADAIMHMFG, T CJMMBFLIBMO, bool HFIFFFBALHD) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface AGOANOMDLFL
{
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBMOPAJMOPJ(MCOCAFPBHKN CLBACPKJNKF, in MABIDPJIHBP DMDONNOOOJK);

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAFAIFNGDJC(MCOCAFPBHKN CLBACPKJNKF);

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OGEKLCIGFMH(MCOCAFPBHKN CLBACPKJNKF, MIPCILJMDGJ IOADAIMHMFG, in BJHFEKKLKGB DCKOFIOPMNA, in BJHFEKKLKGB JFBNMEBIPAN);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class NINHMHKLKAJ
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x5732310", Offset = "0x5730B10", VA = "0x185732310")]
	public static void OGEKLCIGFMH<T>(this AGOANOMDLFL FMAOAOODAPP, MCOCAFPBHKN CLBACPKJNKF, MIPCILJMDGJ IOADAIMHMFG, T OEFKKBELGHM, T JFBNMEBIPAN) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface BHKCMBKKPEM
{
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADHJJEFKFHG(MCOCAFPBHKN CLBACPKJNKF, MIPCILJMDGJ KBHHIDGOLNC, in BJHFEKKLKGB DCKOFIOPMNA, in BJHFEKKLKGB DCNFIIDGCGI);

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EDMODCEAMOL(MCOCAFPBHKN CLBACPKJNKF, MIPCILJMDGJ KBHHIDGOLNC, in IOLFMJOGIFF DCKOFIOPMNA, in IOLFMJOGIFF DCNFIIDGCGI);

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NDJHHALFMNH(MCOCAFPBHKN CLBACPKJNKF, MIPCILJMDGJ KBHHIDGOLNC);

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MNHFCCLCHAA(MCOCAFPBHKN CLBACPKJNKF, MIPCILJMDGJ KBHHIDGOLNC, in BJHFEKKLKGB DCNFIIDGCGI);
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class FEOMMKFNCAI
{
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x178B220", Offset = "0x1789A20", VA = "0x18178B220")]
	public static bool EDMODCEAMOL<T>(this BHKCMBKKPEM LOGALNJEFEB, MCOCAFPBHKN CLBACPKJNKF, MIPCILJMDGJ KBHHIDGOLNC, out T DCKOFIOPMNA, out T DCNFIIDGCGI) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x178B380", Offset = "0x1789B80", VA = "0x18178B380")]
	public static bool MNHFCCLCHAA<T>(this BHKCMBKKPEM LOGALNJEFEB, MCOCAFPBHKN CLBACPKJNKF, MIPCILJMDGJ KBHHIDGOLNC, T DCNFIIDGCGI) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public interface LAIILCPKBAD
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKPCDFAFAJF(MCOCAFPBHKN GFKNINEELBB, MIPCILJMDGJ IOADAIMHMFG, in IOLFMJOGIFF CJMMBFLIBMO);

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCLAMECHFIJ(MCOCAFPBHKN GFKNINEELBB, AEEOODALKLG LBEBNBLLNKK, [Optional] object ALLCABKLNNG);

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MDCLHEKMCMO(MCOCAFPBHKN GFKNINEELBB, MIPCILJMDGJ IOADAIMHMFG);

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PIPBNBHHBLC(MCOCAFPBHKN GFKNINEELBB, Span<MIPCILJMDGJ> IOADAIMHMFG, bool PMEJKGPCEKM);

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BKIEEIBJMKG JDCINKDFFNF(MCOCAFPBHKN GFKNINEELBB, in MABIDPJIHBP DMDONNOOOJK);

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AEKFCCGOHEB(MCOCAFPBHKN GFKNINEELBB);

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OPPLOKABCLC(MCOCAFPBHKN GFKNINEELBB, MIPCILJMDGJ IOADAIMHMFG, in BJHFEKKLKGB CJMMBFLIBMO);

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OIGLBJAFFJP(BHKCMBKKPEM KKGDKGFFJGP, MIPCILJMDGJ IOADAIMHMFG, in BJHFEKKLKGB CJMMBFLIBMO);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class IJGFEOAOLLE
{
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x1C380F0", Offset = "0x1C368F0", VA = "0x181C380F0")]
	public static T IKPCDFAFAJF<T>(this LAIILCPKBAD FHGJEPMFKBJ, MCOCAFPBHKN GFKNINEELBB, MIPCILJMDGJ IOADAIMHMFG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x178DC00", Offset = "0x178C400", VA = "0x18178DC00")]
	public static bool OPPLOKABCLC<T>(this LAIILCPKBAD FHGJEPMFKBJ, MCOCAFPBHKN GFKNINEELBB, MIPCILJMDGJ IOADAIMHMFG, T CJMMBFLIBMO) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public enum JACJLCPOLIH
{
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	End,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public delegate void AKMJDAGPLAN(GDEMKJIGFOC FMAOAOODAPP, BFPHBAFEECN IAAPJBOKIIH, MCOCAFPBHKN MEDLGIKFPNL, MIPCILJMDGJ KBHHIDGOLNC, bool HFIFFFBALHD);
[Cpp2IlInjected.Token(Token = "0x200007D")]
public delegate void DKMHFCMPOEP<T>(BFPHBAFEECN IAAPJBOKIIH, T CJMMBFLIBMO) where T : struct;
[Cpp2IlInjected.Token(Token = "0x200007E")]
public delegate T BFGBMJDFBJC<T>(BFPHBAFEECN IAAPJBOKIIH) where T : struct;
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface FDEECNODPGL : global::MFLLONONPMG<FDEECNODPGL>
{
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MIPCILJMDGJ KJPBFOEADCJ(OMOEODCFEGL JNAACNJBHOF);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DAFBLBFDDID(MIPCILJMDGJ OCNCOBFEOBE, LANHGMANLOK MEBJIKNMLPK);

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool APHJBAJPDLG(MIPCILJMDGJ OCNCOBFEOBE, out LANHGMANLOK MEBJIKNMLPK);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class PLDEAPFMHLC
{
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0xDAF020", Offset = "0xDAD820", VA = "0x180DAF020")]
	public static MIPCILJMDGJ KJPBFOEADCJ<T>(this FDEECNODPGL AFJGLEGGBOF, global::NNAELPPPNEG<T> JNAACNJBHOF)
	{
		return default(MIPCILJMDGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0xDAEF20", Offset = "0xDAD720", VA = "0x180DAEF20")]
	public static MIPCILJMDGJ DAFBLBFDDID<T>(this FDEECNODPGL AFJGLEGGBOF, global::NNAELPPPNEG<T> JNAACNJBHOF, LANHGMANLOK MEBJIKNMLPK) where T : struct
	{
		return default(MIPCILJMDGJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface BBJMOOHBLPF
{
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PLCDFANINMD<T>(in T CJMMBFLIBMO, [Optional] object ALLCABKLNNG) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface LANHGMANLOK
{
	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	Type OHHOKIOJPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAGHAKDDGPK(BFPHBAFEECN IAAPJBOKIIH, in BJHFEKKLKGB MOLPKNIJMDK);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CIHAKFOOKLK(BFPHBAFEECN IAAPJBOKIIH, BBJMOOHBLPF LBEBNBLLNKK, [Optional] object ALLCABKLNNG);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class MBPGLINCMAF
{
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface HHIMBJHGJEM
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	bool ENDNMLIIOOL
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EEMGINAJICG([Optional] CancellationToken NFKHAKHIBIO);
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface CBMKDNBNDGL : GDEMKJIGFOC
{
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public interface KPKBHBEADGF
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CNPIMJIAICA(ReadOnlySpan<byte> CJMMBFLIBMO, CancellationToken NFKHAKHIBIO);
}
namespace RecRoom.ObjectModel.Interfaces.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[Preserve]
	internal class _RRAssemblyIndex : KOGEJEDODIH
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x606E30", Offset = "0x605630", VA = "0x180606E30")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x3F00F40", Offset = "0x3EFF740", VA = "0x183F00F40", Slot = "4")]
		public sealed override void DJCOPMFLKGB()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class PGKFNNKCMAN
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static byte[] EGKMOPGLIPA;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int JGABFFAEPHC;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static int OCNADIFHHML;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static BigInteger GACCCDCMEHO;

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public PGKFNNKCMAN()
	{
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
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
